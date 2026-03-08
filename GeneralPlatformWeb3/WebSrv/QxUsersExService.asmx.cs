using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Text;
using System.Collections;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.WebSrv
{
    /// <summary>
    /// UsersServiceEx 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class QxUsersExService : System.Web.Services.WebService
    {

        
        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [WebMethod]
        public List<string> GetRoleIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxUserRoles.QxPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from {1} where userid = '{0}')",
                strUserId, clsQxUserRoleRelationEN._CurrTabName_S);
            List<clsQxUserRolesEN> arrUserRoleObjLst = clsQxUserRolesBL.GetObjLst(sbCondition.ToString());
            List<string> arrRoleIdLst = new List<string>();
            foreach (clsQxUserRolesEN objUserRoles in arrUserRoleObjLst)
            {
                arrRoleIdLst.Add(objUserRoles.RoleId);
            }

            return arrRoleIdLst;
        }

        [WebMethod]
        public List<string> GetRoleNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxUserRoles.QxPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from {1} where userid = '{0}')",
                strUserId, clsQxUserRoleRelationEN._CurrTabName_S);
            List<clsQxUserRolesEN> arrUserRoleObjLst = clsQxUserRolesBL.GetObjLst(sbCondition.ToString());
            List<string> arrRoleIdLst = new List<string>();
            foreach (clsQxUserRolesEN objUserRoles in arrUserRoleObjLst)
            {
                arrRoleIdLst.Add(objUserRoles.RoleName);
            }

            return arrRoleIdLst;
        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [WebMethod]
        public List<string> GetPotenceIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }


            //        select * from prjpotence
            //where Qxprjid = '0072'
            //    and potenceid in 
            //    (select potenceid from userGroupPotence
            //            where RoleId in 
            //                (select RoleId from userRoleRelation where UserId= 'pyf01' and Qxprjid = '0072')
            //    )
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("{1} = '{0}'", strPrjId, conQxPrjPotence.QxPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from {0} where RoleId in  ", clsQxUserGroupPotenceEN._CurrTabName_S);
            sbCondition4Potence2.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId, clsQxUserRoleRelationEN._CurrTabName_S, conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence2.Append(")");
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = clsQxPrjPotenceBL.GetObjLst(sbCondition4Potence2.ToString());
            List<string> arrPotenceIdLst = new List<string>();
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst)
            {
                arrPotenceIdLst.Add(objPrjPotence.PotenceId);
            }

            return arrPotenceIdLst;
        }

        [WebMethod]
        public List<string> GetPotenceNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }


            //        select * from prjpotence
            //where Qxprjid = '0072'
            //    and potenceid in 
            //    (select potenceid from userGroupPotence
            //            where RoleId in 
            //                (select RoleId from userRoleRelation where UserId= 'pyf01' and Qxprjid = '0072')
            //    )
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("{1} = '{0}'", strPrjId, conQxPrjPotence.QxPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from {0} where RoleId in  ", clsQxUserGroupPotenceEN._CurrTabName_S);
            sbCondition4Potence2.AppendFormat("(select RoleId from {2} where UserId= '{0}' and {3} = '{1}')",
                strUserId, strPrjId, clsQxUserRoleRelationEN._CurrTabName_S, conQxUserRoleRelation.QxPrjId);
            sbCondition4Potence2.Append(")");
            List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = clsQxPrjPotenceBL.GetObjLst(sbCondition4Potence2.ToString());
            List<string> arrPotenceIdLst = new List<string>();
            foreach (clsQxPrjPotenceEN objPrjPotence in arrPrjPotenceObjLst)
            {
                arrPotenceIdLst.Add(objPrjPotence.PotenceName);
            }

            return arrPotenceIdLst;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [WebMethod(Description = "作者:潘以锋 功能:获取用户的有关某权限的标志ID列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")]
        public List<string> GetSymbolIdLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolId = clsQxUsersBLEx.GetSymbolIdLstByPotenceId(strUserId, strPotenceId, strPrjId);
            return lstSymbolId;
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [WebMethod(Description = "作者:潘以锋 功能:获取用户的有关某权限的标志名称列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")]       
        public List<string> GetSymbolNameLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceId(strUserId, strPotenceId, strPrjId);
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [WebMethod(Description = "作者:潘以锋 功能:获取用户的有关某权限的标志ID列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")]
        public List<string> GetSymbolIdLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolId = clsQxUsersBLEx.GetSymbolIdLstByPotenceName(strUserId, strPotenceName, strPrjId);
            return lstSymbolId;
        }


        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [WebMethod(Description = "作者:潘以锋 功能:获取用户的有关某权限的标志名称列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID) 返回值:标志名称列表,用List<string>表示")]
        public List<string> GetSymbolNameLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName(strUserId, strPotenceName, strPrjId);
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">有关某角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [WebMethod(Description = "作者:潘以锋 功能:获取用户的有关某权限的标志名称列表 参数:strUserId(用户ID),strPotenceId(权限ID), strPrjId(工程ID),strRoleId(所给角色ID) 返回值:标志名称列表,用List<string>表示")]
        public List<string> GetSymbolNameLstByPotenceName4CurrRoleId(string strUserId, string strPotenceName, string strPrjId, string strRoleId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName4CurrRoleId(strUserId, strPotenceName, strPrjId, strRoleId);
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">有关某角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        [WebMethod(Description = "作者:潘以锋 功能:获取某角色的有关某权限的标志名称列表 参数:strPotenceId(权限ID), strPrjId(工程ID),strRoleId(所给角色ID) 返回值:标志名称列表,用List<string>表示")]
        public List<string> GetSymbolNameLstByPotenceName4CurrRoleId2(string strPotenceName, string strPrjId, string strRoleId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName4CurrRoleId2(strPotenceName, strPrjId, strRoleId);
            return lstSymbolName;
        }
  
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            return clsQxUsersBLEx.IsHavePotenceName(strPrjId, strUserId, strPotenceName);
        }
        /// <summary>
        /// 是否包含某权限Id
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceId(string strPrjId, string strUserId, string strPotenceId)
        {
            return clsQxUsersBLEx.IsHavePotenceId(strPrjId, strUserId, strPotenceId);
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            return clsQxUsersBLEx.GetQxPrjPotenceObjByPotenceName(strPrjId, strUserId, strPotenceName);
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName)
        {
            return clsQxUsersBLEx.GetQxPrjPotenceObjByPotenceName4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName);
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceNameAndSymbol(string strPrjId, string strUserId, string strPotenceName, string strSymbolName)
        {
            return clsQxUsersBLEx.IsHavePotenceNameAndSymbol(strPrjId, strUserId, strPotenceName, strSymbolName);
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceNameAndSymbol4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName, string strSymbolName)
        {
            return clsQxUsersBLEx.IsHavePotenceNameAndSymbol4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName, strSymbolName);
        }



        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strOldPassword">用户当前的密码，用以验证</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        [WebMethod]
        public bool Change_QxUserPassword(string strUserId, string strNewPassword, string strOldPassword)
        {
            return clsQxUsersBLEx.Change_QxUserPassword(strUserId, strNewPassword, strOldPassword);
        }
        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        [WebMethod]
        public bool Change_QxUserPassword2(string strUserId, string strNewPassword)
        {
            return clsQxUsersBLEx.Change_QxUserPassword(strUserId, strNewPassword);
        }


        [WebMethod]
        public int Users_DelRecord(string strUserId)
        {
            int intResult = clsQxUsersBL.DelRecord(strUserId);
            return intResult;
        }

        /// <summary>
        /// 根据用户Id（UserId）获取入校年月
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年月</returns>
        [WebMethod]
        public string GetEnterSchoolDateByUserId(string strUserId)
        {
            string strEnterSchoolDate = clsQxUsersBLEx.GetEnterSchoolDateByUserId(strUserId);
            return strEnterSchoolDate;
        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年</returns>
        [WebMethod]
        public string GetEnterSchoolYearByUserId(string strUserId)
        {
            string strEnterSchoolDate = clsQxUsersBLEx.GetEnterSchoolYearByUserId(strUserId);
            return strEnterSchoolDate;
        }
        /// <summary>
        /// 根据用户Id（UserId）获取用户名
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>用户名</returns>
        [WebMethod]
        public string GetUserNameByUserId(string strUserId)
        {
            string strUserName = clsQxUsersBLEx.GetUserNameByUserId(strUserId);
            return strUserName;
        }


        /// <summary>
        /// 为用户设置角色
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strRoleId">当前角色</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>是否成功？</returns>
        [WebMethod]
        public bool CreateUserRoleRelation(string strUserId, string strRoleId, string strPrjId)
        {
            bool bolIsSuccess = clsQxUsersBLEx.CreateUserRoleRelation(strUserId, strRoleId, strPrjId);
            return bolIsSuccess;
        }
        /// <summary>
        /// 根据部门ID获取该部门的二级管理员ID
        /// </summary>
        /// <param name="strDepartmentId">部门ID</param>
        /// <returns>二级管理员ID？</returns>
        [WebMethod]
        public string GetManager2IdByDepartmentId(string strDepartmentId)
        {
            string strUserId = clsQxUsersBLEx.GetManager2IdByDepartmentId(strDepartmentId);
            return strUserId;
        }


    }
}
