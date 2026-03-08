
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersBLEx
表名:QxUsers
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:26
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:用户管理
模块英文名:UserManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.DAL;
using GeneralPlatform.Entity;
using SpecData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 用户(QxUsers)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public partial class clsQxUsersBLEx : clsQxUsersBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUsersDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUsersDAEx QxUsersDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUsersDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        #region 根据用户ID，获取该用户的角色列表
        /// <summary>
        /// 根据用户ID，获取该用户的角色Id列表
        /// </summary>
        /// <param name="UserId">学号（教职工号）</param>
        /// <returns>数据间用,号隔开</returns>
        public static string GetRoleIdList(string UserId)
        {
            //DataTable dtRole = new DataTable();
            if (!String.IsNullOrEmpty(UserId))
            {
                List<string> lstRoleId = clsQxUserRoleRelationBLEx.Get_UserRoleIdList2(clsSysParaEN.CurrPrjId, UserId);
                string strRoleIds = clsArray.GetSqlInStrByArray(lstRoleId, false);
                //                    return ConvertDataTableToString(dtRole);
                return strRoleIds;
            }
            return "";
        }
        /// <summary>
        /// 根据用户ID，获取该用户的角色Id列表
        /// </summary>
        /// <param name="strPrjid">学号（教职工号）</param>
        /// <param name="UserId">学号（教职工号）</param>
        /// <returns>数据间用,号隔开</returns>
        public static string GetRoleIdList(string strPrjid, string UserId)
        {
            //DataTable dtRole = new DataTable();
            if (!String.IsNullOrEmpty(UserId))
            {
                List<string> lstRoleId = clsQxUserRoleRelationBLEx.Get_UserRoleIdList2(strPrjid, UserId);
                string strRoleIds = clsArray.GetSqlInStrByArray(lstRoleId, false);
                //                    return ConvertDataTableToString(dtRole);
                return strRoleIds;
            }
            return "";
        }
        #endregion
        public static bool GetQxUsers(ref clsQxUsersENEx objUsers)
        {
            clsQxUsersDAEx objUsersDA = new clsQxUsersDAEx();
            bool bolResult = objUsersDA.GetQxUsers(ref objUsers);
            return bolResult;
        }
        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static clsQxUsersENEx GetQxUsersAllSubObj(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                strPrjId = clsQxProjectsBLEx.GetDefaultPrj();
            }
            GeneralPlatform.Entity.clsQxUsersENEx objUsersEx = new GeneralPlatform.Entity.clsQxUsersENEx()
            {
                UserId = strUserId
            };
            clsQxUsersBLEx.GetQxUsers(ref objUsersEx);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from {1} where userid = '{0}')",
                objUsersEx.UserId,
                clsQxUserRoleRelationEN._CurrTabName);
            objUsersEx.arrUserRoleObjLst = clsQxRolesBLEx.GetObjLstEx(sbCondition.ToString());
            foreach (clsQxRolesENEx objUserRolesEN in objUsersEx.arrUserRoleObjLst)
            {
                StringBuilder sbCondition4Potence = new StringBuilder();
                sbCondition4Potence.AppendFormat("  potenceid in ");
                sbCondition4Potence.AppendFormat(" (select potenceid from {1} where RoleId = '{0}')  ",
                    objUserRolesEN.RoleId,
                    clsQxUserGroupPotenceEN._CurrTabName);
                objUserRolesEN.arrPrjPotenceObjLst = clsQxPrjPotenceBLEx.GetObjLst(sbCondition4Potence.ToString());
            }

            //        select * from prjpotence
            //where Qxprjid = '0072'
            //    and potenceid in 
            //    (select potenceid from QxuserGroupPotence
            //            where RoleId in 
            //                (select RoleId from QxuserRoleRelation where UserId= 'pyf01' and Qxprjid = '0072')
            //    )
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence2.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                objUsersEx.UserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence2.Append(")");
            objUsersEx.arrPrjPotenceObjLst = clsQxPrjPotenceBLEx.GetObjLst(sbCondition4Potence2.ToString());


            //        select * from RelaOfPotenceAndSymbol
            //where Qxprjid = '0072'
            //    and RelaMid in 
            //    (select RelaMid from QxuserGroupPotence
            //            where RoleId in 
            //                (select RoleId from QxuserRoleRelation where UserId= 'pyf01' and Qxprjid = '0072')
            //    )

            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                objUsersEx.UserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence3.Append(")");
            objUsersEx.arrPrjPotenceAndSymbolObjLst = clsQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());

            return objUsersEx;
        }

        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static ArrayList GetQxUserRolesObjLst(string strUserId, string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from {1} where userid = '{0}')",
                strUserId,
                clsQxUserRoleRelationEN._CurrTabName);
            ArrayList arrUserRoleObjLst = clsQxRolesBLEx.GetObjLstEx(sbCondition.ToString());

            return arrUserRoleObjLst;
        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<clsQxPrjPotenceEN> GetQxPrjPotenceObjLst(string strUserId, string strPrjId)
        {

            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence2.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence2.Append(")");
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = clsQxPrjPotenceBLEx.GetObjLst(sbCondition4Potence2.ToString());

            return arrPrjPotenceObjLst;
        }

        /// <summary>
        /// 获取用户的所有权限及标志子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<clsQxRelaOfPotenceAndSymbolEN> GetQxPrjPotenceAndSymbolObjLst(string strUserId, string strPrjId)
        {
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence3.Append(")");
            List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = clsQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());

            return arrPrjPotenceAndSymbolObjLst;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolIdLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and PotenceId = '{0}'", strPotenceId);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence3.Append(")");
            List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = clsQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());
            List<string> lstSymbolId = new List<string>();
            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                lstSymbolId.Add(objRelaOfPotenceAndSymbol.SymbolForProgramme);
            }
            return lstSymbolId;
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolNameLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and PotenceId = '{0}'", strPotenceId);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence3.Append(")");
            List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = clsQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());
            List<string> lstSymbolName = new List<string>();
            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                lstSymbolName.Add(objRelaOfPotenceAndSymbol.SymbolName);
            }
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolIdLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and PotenceName = '{0}'", strPotenceName);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence3.Append(")");
            List<clsvQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());
            List<string> lstSymbolId = new List<string>();
            foreach (clsvQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                lstSymbolId.Add(objRelaOfPotenceAndSymbol.SymbolForProgramme);
            }
            return lstSymbolId;
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolNameLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and PotenceName = '{0}'", strPotenceName);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {0} where RoleId in  ",
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId,
                clsQxUserRoleRelationEN._CurrTabName,
                conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence3.Append(")");
            List<clsvQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());
            List<string> lstSymbolName = new List<string>();
            foreach (clsvQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                lstSymbolName.Add(objRelaOfPotenceAndSymbol.SymbolName);
            }
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">有关某角色</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolNameLstByPotenceName4CurrRoleId(string strUserId, string strPotenceName, string strPrjId, string strRoleId)
        {
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and PotenceName = '{0}'", strPotenceName);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {1} where RoleId = '{0}'  ",
                strRoleId,
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.Append(")");
            List<clsvQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());
            List<string> lstSymbolName = new List<string>();
            foreach (clsvQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                lstSymbolName.Add(objRelaOfPotenceAndSymbol.SymbolName);
            }
            return lstSymbolName;
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>

        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">有关某角色</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolNameLstByPotenceName4CurrRoleId2(string strPotenceName, string strPrjId, string strRoleId)
        {
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and PotenceName = '{0}'", strPotenceName);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {1} where RoleId = '{0}'  ", strRoleId,
                clsQxUserGroupPotenceEN._CurrTabName);
            sbCondition4Potence3.Append(")");
            List<clsvQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());
            List<string> lstSymbolName = new List<string>();
            foreach (clsvQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                lstSymbolName.Add(objRelaOfPotenceAndSymbol.SymbolName);
            }
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的当前所选角色的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strRoleId">当前角色</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<clsQxPrjPotenceEN> GetQxPrjPotenceObjLst4CurrRole(string strUserId, string strRoleId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from {1} where RoleId ='{0}')",
                strRoleId,
                clsQxUserGroupPotenceEN._CurrTabName);
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst4CurrRole = clsQxPrjPotenceBLEx.GetObjLst(sbCondition4Potence2.ToString());

            return arrPrjPotenceObjLst4CurrRole;
        }


        /// <summary>
        /// 获取用户的当前所选角色的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strRoleId">当前角色</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<clsQxRelaOfPotenceAndSymbolEN> GetQxPrjPotenceAndSymbolObjLst4CurrRole(string strUserId, string strRoleId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder sbCondition4Potence3 = new StringBuilder();
            sbCondition4Potence3.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition4Potence3.AppendFormat(" and RelaMid in ");
            sbCondition4Potence3.AppendFormat(" (select RelaMid from {1} where RoleId ='{0}')",
                 strRoleId,
                 clsQxUserGroupPotenceEN._CurrTabName);
            List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst4CurrRole = clsQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition4Potence3.ToString());

            return arrPrjPotenceAndSymbolObjLst4CurrRole;
        }


        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = GetQxPrjPotenceObjLst(strPrjId, strUserId);
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst)
            {
                if (objPrjPotence.PotenceName == strPotenceName)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// 是否包含某权限Id
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>       
        public static bool IsHavePotenceId(string strPrjId, string strUserId, string strPotenceId)
        {
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = GetQxPrjPotenceObjLst(strPrjId, strUserId);
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst)
            {
                if (objPrjPotence.PotenceId == strPotenceId)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>        
        public static clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = GetQxPrjPotenceObjLst(strUserId, strPrjId);
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst)
            {
                if (objPrjPotence.PotenceName == strPotenceName)
                {
                    return objPrjPotence;
                }
            }
            return null;
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst4CurrRole = GetQxPrjPotenceObjLst4CurrRole(strUserId, strRoleId, strPrjId);
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst4CurrRole)
            {
                if (objPrjPotence.PotenceName == strPotenceName)
                {
                    return objPrjPotence;
                }
            }
            return null;
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceNameAndSymbol(string strPrjId, string strUserId, string strPotenceName, string strSymbolName)
        {
            clsQxPrjPotenceEN objPrjPotence = GetQxPrjPotenceObjByPotenceName(strPrjId, strUserId, strPotenceName);
            if (objPrjPotence == null)
            {
                return false;
            }
            List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = GetQxPrjPotenceAndSymbolObjLst(strUserId, strPrjId);
            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                if (objRelaOfPotenceAndSymbol.SymbolName == strSymbolName && objRelaOfPotenceAndSymbol.PotenceId == objPrjPotence.PotenceId)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceNameAndSymbol4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName, string strSymbolName)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            clsQxPrjPotenceEN objPrjPotence = GetQxPrjPotenceObjByPotenceName4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName);
            if (objPrjPotence == null)
            {
                return false;
            }
            List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst4CurrRole = GetQxPrjPotenceAndSymbolObjLst4CurrRole(strUserId, strRoleId, strPrjId);
            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst4CurrRole)
            {
                if (objRelaOfPotenceAndSymbol.SymbolName == strSymbolName && objRelaOfPotenceAndSymbol.PotenceId == objPrjPotence.PotenceId)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strOldPassword">用户当前的密码，用以验证</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>      
        public static bool Change_QxUserPassword(string strUserId, string strNewPassword, string strOldPassword)
        {
            if (clsQxUsersBL.IsExistRecord(" UserId = '" + strUserId + "' and Password = '" + strOldPassword + "'"))
            {
                int intRecNum = clsGeneralTab.funSetFldValue(clsQxUsersEN._CurrTabName, "Password", strNewPassword, " UserId='" + strUserId + "'");
                if (intRecNum == 1) return true;
                else return false;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>      
        public static bool Change_QxUserPassword(string strUserId, string strNewPassword)
        {
            if (clsQxUsersBL.IsExistRecord(" UserId = '" + strUserId + "'"))
            {
                int intRecNum = clsGeneralTab.funSetFldValue(clsQxUsersEN._CurrTabName, "Password", strNewPassword, " UserId='" + strUserId + "'");
                if (intRecNum == 1) return true;
                else return false;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年月
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年月</returns>
        public static string GetEnterSchoolDateByUserId(string strUserId)
        {
            string strEnterSchoolDate = clsQxUsersDAEx.GetEnterSchoolDateByUserId(strUserId);
            return strEnterSchoolDate;
        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年</returns>
        public static string GetEnterSchoolYearByUserId(string strUserId)
        {
            string strEnterSchoolDate = clsQxUsersDAEx.GetEnterSchoolYearByUserId(strUserId);
            return strEnterSchoolDate;
        }

        /// <summary>
        /// 根据用户Id（UserId）获取用户名
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>用户名</returns>
        public static string GetUserNameByUserId(string strUserId)
        {
            string strUserName = clsQxUsersDAEx.GetUserNameByUserId(strUserId);
            return strUserName;
        }
        ///绑定下拉框的函数代码
        public static void BindDdl_UserId(
            System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDataTable_QxUsersByPrjId(strPrjId, "03");
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static DataTable GetDataTable_QxUsersByPrjId(string strPrjId, string strIdentityId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" IdentityId='{0}'", strIdentityId);
            sbCondition.AppendFormat(" and userId in (Select Userid From QxPrjUserRelation where {1}='{0}')", strPrjId,
                conQxPrjUserRelation.QxPrjId);

            DataTable objDT = null;
            try
            {
                objDT = clsQxUsersBL.GetDataTable_QxUsers(sbCondition.ToString());
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:Users 数据出错！\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 为用户设置角色
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strRoleId">当前角色</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>是否成功？</returns>
        public static bool CreateUserRoleRelation(string strUserId, string strRoleId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition.AppendFormat(" and RoleId='{0}'", strRoleId);
            sbCondition.AppendFormat(" and UserId='{0}'", strUserId);
            bool bolIsExist = clsQxUserRoleRelationBL.IsExistRecord(sbCondition.ToString());
            if (bolIsExist == true) return true;
            clsQxUserRoleRelationEN objUserRoleRelationEN = new clsQxUserRoleRelationEN()
            {
                UserId = strUserId,
                RoleId = strRoleId,
                QxPrjId = strPrjId
            };

            return clsQxUserRoleRelationBL.AddNewRecordBySql2(objUserRoleRelationEN);
        }

        /// <summary>
        /// 根据部门ID获取该部门的二级管理员ID
        /// </summary>
        /// <param name="strDepartmentId">部门ID</param>
        /// <returns>二级管理员ID？</returns>
        public static string GetManager2IdByDepartmentId(string strDepartmentId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" RoleId='{0}'", "01060005");
            sbCondition.AppendFormat(" and UserId in (Select UserId from Users where DepartmentId='{0}')", strDepartmentId);
            clsQxUserRoleRelationEN objUserRoleRelationEN = clsQxUserRoleRelationBL.GetFirstObj_S(sbCondition.ToString());
            if (objUserRoleRelationEN == null) return "";
            return objUserRoleRelationEN.UserId;
        }
        public static bool DelRecordEx(string strUserId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQL objSQL = new clsSpecSQL();
            //删除Users本表中与当前对象有关的记录

            //strSQL = strSQL + "Delete from IpOfSpecialUser where UserId=" + "'" + strUserId + "';";
            //strSQL = strSQL + "Delete from OptMethod where UserId=" + "'" + strUserId + "';";
            ////            strSQL = strSQL + "Delete from PubMsgDetail where UserId=" + "'" + strUserId + "';";
            //strSQL = strSQL + "Delete from PubMsgPersonalUser where UserId=" + "'" + strUserId + "';";
            //strSQL = strSQL + "Delete from SysLog  where UserId=" + "'" + strUserId + "';";
            strSQL = strSQL + string.Format("Delete from {1} where UserId='{0}';", strUserId, clsQxUserGroupPotenceEN._CurrTabName);
            strSQL = strSQL + string.Format("Delete from {1} where UserId='{0}';", strUserId, clsQxUserGroupRelationEN._CurrTabName);
            //strSQL = strSQL + "Delete from UserLog where UserId=" + "'" + strUserId + "';";
            //strSQL = strSQL + "Delete from UserPower where UserId=" + "'" + strUserId + "';";
            strSQL = strSQL + string.Format("Delete from {1} where UserId='{0}';", strUserId, clsQxUserRoleRelationEN._CurrTabName);
            strSQL = strSQL + string.Format("Delete from {1} where UserId='{0}';", strUserId, clsQxPrjUserRelationEN._CurrTabName);
            //strSQL = strSQL + "Delete from UserVisit where UserId=" + "'" + strUserId + "';";
            strSQL = strSQL + string.Format("Delete from {1} where UserId='{0}';", strUserId, clsQxUsersEN._CurrTabName);
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// 同步卡状态
        /// </summary>
        /// <returns></returns>
        public static bool SynCard_State()
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQL objSQL = new clsSpecSQL();
            //删除Users本表中与当前对象有关的记录


            strSQL = "Update a set a.Card_State=b.Card_State from Users a, Person_q b where a.UserId=b.Account";
            return objSQL.ExecSql(strSQL);
        }

        public static bool DelRecordEx(string strUserId, string strPrjId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQL objSQL = new clsSpecSQL();
            //删除Users本表中与当前对象有关的记录
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" UserId='{0}'", strUserId);
            sbCondition.AppendFormat(" and QxPrjId='{0}'", strPrjId);

            //strSQL = strSQL + "Delete from IpOfSpecialUser where UserId=" + "'" + strUserId + "';";
            //strSQL = strSQL + "Delete from OptMethod where UserId=" + "'" + strUserId + "';";
            ////            strSQL = strSQL + "Delete from PubMsgDetail where UserId=" + "'" + strUserId + "';";
            //strSQL = strSQL + "Delete from PubMsgPersonalUser where UserId=" + "'" + strUserId + "';";
            //strSQL = strSQL + "Delete from SysLog  where UserId=" + "'" + strUserId + "';";
            strSQL = strSQL + string.Format("Delete from {0} where {1};",
                clsQxUserGroupPotenceEN._CurrTabName,
                sbCondition.ToString());
            strSQL = strSQL + string.Format("Delete from {1} where {0};",
                sbCondition.ToString(),
                clsQxUserGroupRelationEN._CurrTabName);
            //strSQL = strSQL + "Delete from UserLog where " + sbCondition.ToString()+ ";";
            //strSQL = strSQL + "Delete from UserPower where " + sbCondition.ToString()+ ";";
            strSQL = strSQL + string.Format("Delete from {1} where {0};",
                sbCondition.ToString(),
                clsQxUserRoleRelationEN._CurrTabName);
            strSQL = strSQL + string.Format("Delete from {1} where {0};",
                sbCondition.ToString(),
                clsQxPrjUserRelationEN._CurrTabName);
            //strSQL = strSQL + "Delete from UserVisit where " + sbCondition.ToString();
            int intRecCount = GetRecCountByCond("QxPrjUserRelation", string.Format("UserId='{0}'", strUserId));
            if (intRecCount == 1)
            {
                strSQL = strSQL + string.Format("Delete from {0} where UserId='{1}';",
                            clsQxUsersEN._CurrTabName, strUserId);
            }
            return objSQL.ExecSql(strSQL);
        }
        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strUserId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExistEx(string strUserId, clsSpecSQLforSql objSQL)
        {

            if (objSQL.IsExistRecord(clsQxUsersEN._CurrTabName, "UserId=" + "'" + strUserId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        /// <summary>
        /// 建立工程用户关系
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPrjId">工程ID</param>
        /// <returns></returns>
        public static bool AddPrjUserRelation(string strUserId, string strPrjId, string strUpdUser)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QxPrjId='{0}' and UserId='{1}'", strPrjId, strUserId);
            if (clsQxPrjUserRelationBL.IsExistRecord(sbCondition.ToString()) == false)
            {
                clsQxPrjUserRelationEN objPrjUserRelation = new clsQxPrjUserRelationEN();
                objPrjUserRelation.QxPrjId = strPrjId;
                objPrjUserRelation.UserId = strUserId;
                objPrjUserRelation.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserRelation.UpdUser = strUpdUser;

                objPrjUserRelation.Memo = "由WebService同步！";
                objPrjUserRelation.AddNewRecord();
            }
            return true;

        }
        /// <summary>
        /// 建立用户角色关系
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strRoleId">工程ID</param>
        /// <returns></returns>
        public static bool AddUserRoleRelation(string strUserId, string strRoleId, string strUpdUser)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("RoleId='{0}' and UserId='{1}'", strRoleId, strUserId);
            if (clsQxUserRoleRelationBL.IsExistRecord(sbCondition.ToString()) == false)
            {
                clsQxUserRoleRelationEN objUserRoleRelation = new clsQxUserRoleRelationEN();
                objUserRoleRelation.RoleId = strRoleId;
                objUserRoleRelation.UserId = strUserId;
                objUserRoleRelation.QxPrjId = strRoleId.Substring(0, 4);
                objUserRoleRelation.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objUserRoleRelation.UpdUser = strUpdUser;

                objUserRoleRelation.Memo = "由WebService同步！";
                objUserRoleRelation.AddNewRecord();
            }
            return true;

        }
        /// <summary>
        /// 添加新的用户
        /// </summary>
        /// <param name="objUsers">用户对象</param>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <returns>是否成功？</returns>
        public static bool AddNewUsers(clsQxUsersEN objUsers, string strPrjId, string strRoleId, string strUpdUser)
        {
            //1、判断用户是否存在，如果存在就退出
            if (clsQxUsersBL.IsExist(objUsers.UserId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("用户:{0}({1})已经存在,不能再添加！", objUsers.UserId, objUsers.UserName);
                //                throw new Exception("");

            }
            else
            {
                objUsers.UpdUser = strUpdUser;
                objUsers.AddNewRecord();
            }
            AddPrjUserRelation(objUsers.UserId, strPrjId, strUpdUser);
            AddUserRoleRelation(objUsers.UserId, strRoleId, strUpdUser);

            return true;
        }
    }
}