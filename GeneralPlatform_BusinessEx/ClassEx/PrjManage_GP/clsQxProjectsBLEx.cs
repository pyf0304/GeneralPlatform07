
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxProjectsBLEx
表名:QxProjects
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:41
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;

using GeneralPlatform.Entity;
using System.Data;
using System.Data.SqlClient;
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;
using SpecData;
using System.Web.UI.WebControls;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 工程表(QxProjects)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxProjectsBLEx : clsQxProjectsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxProjectsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxProjectsDAEx QxProjectsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxProjectsDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsQxProjectsEN> arrProjectsObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        private static int intFindFailCount = 0;

        public static string GetDefaultPrj()
        {
            string strDefaultPrjId = clsQxProjectsBL.GetFirstID_S("IsDefaultPrj = '1'");
            return strDefaultPrjId;
        }


        public static bool DelRecordEx(string strPrjId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQL objSQL = new clsSpecSQL();
            //删除Users本表中与当前对象有关的记录
            //有关用户组,用户角色关系

            //第四层
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxUserGroupPotenceEN._CurrTabName, conQxProjects.QxPrjId);

            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxViewPotenceEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxRelaOfPotenceAndSymbolEN._CurrTabName, conQxProjects.QxPrjId);

            //第三层
            //有关菜单
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxUserMenuDetailEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxRoleMenusEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxUserRoleRelationEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxViewInfoEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxPrjPotenceEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxUserGroupRelationEN._CurrTabName, conQxProjects.QxPrjId);

            //第二层
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxRolesEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxPrjModuleEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxPrjMenusEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxPotenceTypeEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxUserGroupsEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxUserMenusEN._CurrTabName, conQxProjects.QxPrjId);
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxPrjUserRelationEN._CurrTabName, conQxProjects.QxPrjId);

            //第一层
            strSQL = strSQL + string.Format("Delete from {1} where {2}='{0}';", strPrjId, clsQxProjectsEN._CurrTabName, conQxProjects.QxPrjId);
            return objSQL.ExecSql(strSQL);
        }
        public static bool Bindtv_Projects(TreeView objTV)
        {

            TreeNode tnRoot, tnProject;
            List<clsQxProjectsEN> arrProjectObjList = clsQxProjectsBL.GetObjLst(" 1=1 ");
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = clsSysParaEN.strCompanyName;
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);
            foreach (clsQxProjectsEN objProject in arrProjectObjList)
            {
                tnProject = new TreeNode();
                tnProject.Value = "Departments," + objProject.QxPrjId;
                tnProject.Text = objProject.PrjName;
                //				tnProject.CheckBox = true;
                tnRoot.ChildNodes.Add(tnProject);
            }
            return true;

        }


        public static bool GetSubUserRolesLst(clsQxProjectsENEx objProjectsEx)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{1} = '{0}'", objProjectsEx.QxPrjId, conQxProjects.QxPrjId);
            clsQxRolesEN._ConnectString = objProjectsEx.ConnectStringS;
            clsQxPrjMenusEN._ConnectString = objProjectsEx.ConnectStringS;
            clsQxRoleMenusEN._ConnectString = objProjectsEx.ConnectStringS;
            clsQxUserGroupsEN._ConnectString = objProjectsEx.ConnectStringS;
            clsQxPotenceTypeEN._ConnectString = objProjectsEx.ConnectStringS;
            clsQxPrjPotenceEN._ConnectString = objProjectsEx.ConnectStringS;
            clsQxRelaOfPotenceAndSymbolEN._ConnectString = objProjectsEx.ConnectStringS;
            clsQxUserGroupPotenceEN._ConnectString = objProjectsEx.ConnectStringS;

            objProjectsEx.arrUserRolesobjLst = clsQxRolesBL.GetObjLst(sbCondition.ToString());
            objProjectsEx.arrQxPrjMenusobjLst = clsQxPrjMenusBL.GetObjLst(sbCondition.ToString());
            objProjectsEx.arrQxRoleMenusobjLst = clsQxRoleMenusBL.GetObjLst(sbCondition.ToString());
            objProjectsEx.arrUserGroupsobjLst = clsQxUserGroupsBL.GetObjLst(sbCondition.ToString());
            objProjectsEx.arrPotenceTypeobjLst = clsQxPotenceTypeBL.GetObjLst(sbCondition.ToString());
            objProjectsEx.arrPrjPotenceobjLst = clsQxPrjPotenceBL.GetObjLst(sbCondition.ToString());
            objProjectsEx.arrRelaOfPotenceAndSymbolobjLst = clsQxRelaOfPotenceAndSymbolBL.GetObjLst(sbCondition.ToString());
            objProjectsEx.arrUserGroupPotenceobjLst = clsQxUserGroupPotenceBL.GetObjLst(sbCondition.ToString());
            clsQxRolesEN._ConnectString = "";
            clsQxPrjMenusEN._ConnectString = "";
            clsQxRoleMenusEN._ConnectString = "";
            clsQxUserGroupsEN._ConnectString = "";
            clsQxPotenceTypeEN._ConnectString = "";
            clsQxPrjPotenceEN._ConnectString = "";
            clsQxRelaOfPotenceAndSymbolEN._ConnectString = "";
            clsQxUserGroupPotenceEN._ConnectString = "";

            return true;
        }
        public static bool GetProjectsEx(ref clsQxProjectsENEx objProjects)
        {
            clsQxProjectsDAEx objProjectsDA = new clsQxProjectsDAEx();
            bool bolResult = objProjectsDA.GetProjectsEx(ref objProjects);
            return bolResult;
        }
        public static bool CopyProjectsEx(clsQxProjectsENEx objProjects_S)
        {
            clsQxProjectsEN objProjects_T = new clsQxProjectsEN();
            CopyTo(objProjects_S, objProjects_T);
            if (clsQxProjectsBL.IsExist(objProjects_S.QxPrjId) == false)
            {
                clsQxProjectsBL.AddNewRecordBySql2(objProjects_T);
            }
            foreach (clsQxRolesEN objUserRolesEN in objProjects_S.arrUserRolesobjLst)
            {
                if (clsQxRolesBL.IsExist(objUserRolesEN.RoleId) == false)
                {
                    clsQxRolesBL.AddNewRecordBySql2(objUserRolesEN);
                }
            }

            foreach (clsQxPrjMenusEN objQxPrjMenus in objProjects_S.arrQxPrjMenusobjLst)
            {
                if (clsQxPrjMenusBL.IsExist(objQxPrjMenus.MenuId) == false)
                {
                    clsQxPrjMenusBL.AddNewRecordBySql2(objQxPrjMenus);
                }
            }

            foreach (clsQxUserGroupsEN objUserGroups in objProjects_S.arrUserGroupsobjLst)
            {
                if (clsQxUserGroupsBL.IsExist(objUserGroups.GroupId) == false)
                {
                    clsQxUserGroupsBL.AddNewRecordBySql2(objUserGroups);
                }
            }

            foreach (clsQxPotenceTypeEN objPotenceType in objProjects_S.arrPotenceTypeobjLst)
            {
                if (clsQxPotenceTypeBL.IsExist(objPotenceType.PotenceTypeId) == false)
                {
                    clsQxPotenceTypeBL.AddNewRecordBySql2(objPotenceType);
                }
            }


            foreach (clsQxPrjPotenceEN objPrjPotence in objProjects_S.arrPrjPotenceobjLst)
            {
                if (clsQxPrjPotenceBL.IsExist(objPrjPotence.PotenceId) == false)
                {
                    clsQxPrjPotenceBL.AddNewRecordBySql2(objPrjPotence);
                }
            }


            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in objProjects_S.arrRelaOfPotenceAndSymbolobjLst)
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("PotenceId='{0}'", objRelaOfPotenceAndSymbol.PotenceId);
                sbCondition.AppendFormat(" and SymbolForProgramme='{0}'", objRelaOfPotenceAndSymbol.SymbolForProgramme);

                if (clsQxRelaOfPotenceAndSymbolBL.IsExistRecord(sbCondition.ToString()) == false)
                {
                    clsQxRelaOfPotenceAndSymbolBL.AddNewRecordBySql2(objRelaOfPotenceAndSymbol);
                }
            }

            foreach (clsQxUserGroupPotenceEN objUserGroupPotence in objProjects_S.arrUserGroupPotenceobjLst)
            {
                clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol_S = clsQxRelaOfPotenceAndSymbolBLEx.GetQxRelaOfPotenceAndSymbolObjByRelaMid(objUserGroupPotence.RelaMid ?? 0, objProjects_S.arrRelaOfPotenceAndSymbolobjLst);

                StringBuilder sbCondition_T = new StringBuilder();
                sbCondition_T.AppendFormat("PotenceId='{0}'", objRelaOfPotenceAndSymbol_S.PotenceId);
                sbCondition_T.AppendFormat(" and SymbolForProgramme='{0}'", objRelaOfPotenceAndSymbol_S.SymbolForProgramme);

                clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol_T = clsQxRelaOfPotenceAndSymbolBL.GetFirstObj_S(sbCondition_T.ToString());

                StringBuilder sbCondition = new StringBuilder();
                if (objRelaOfPotenceAndSymbol_T == null)
                {
                    sbCondition.AppendFormat("RoleId='{0}'", objUserGroupPotence.RoleId);
                    sbCondition.AppendFormat(" and PotenceId='{0}'", objUserGroupPotence.PotenceId);
                }
                else
                {
                    sbCondition.AppendFormat("RoleId='{0}'", objUserGroupPotence.RoleId);
                    sbCondition.AppendFormat(" and RelaMid='{0}'", objRelaOfPotenceAndSymbol_T.RelaMid);
                    objUserGroupPotence.RelaMid = objRelaOfPotenceAndSymbol_T.RelaMid;
                }

                if (clsQxUserGroupPotenceBL.IsExistRecord(sbCondition.ToString()) == false)
                {
                    if (string.IsNullOrEmpty(objUserGroupPotence.UserId) == true)
                    {
                        objUserGroupPotence.UserId = null;
                    }
                    if (string.IsNullOrEmpty(objUserGroupPotence.GroupId) == true)
                    {
                        objUserGroupPotence.GroupId = null;
                    }
                    clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
                }
            }

            foreach (clsQxRoleMenusEN objQxRoleMenus in objProjects_S.arrQxRoleMenusobjLst)
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("RoleId='{0}'", objQxRoleMenus.RoleId);
                sbCondition.AppendFormat(" and MenuId='{0}'", objQxRoleMenus.MenuId);

                if (clsQxRoleMenusBL.IsExistRecord(sbCondition.ToString()) == false)
                {
                    clsQxRoleMenusBL.AddNewRecordBySql2(objQxRoleMenus);
                }
            }

            return true;
        }
        public static void CopyTo(clsQxProjectsENEx objProjectsS, clsQxProjectsEN objProjectsT)
        {
            objProjectsT.QxPrjId = objProjectsS.QxPrjId; //项目编号
            objProjectsT.PrjName = objProjectsS.PrjName; //工程名
            objProjectsT.PrjDomain = objProjectsS.PrjDomain; //工程域名
                                                             //clsQxPrjDataBaseEN objPrjDataBaseEN = new clsQxPrjDataBaseEN(objProjectsS.PrjDataBaseId);
                                                             //clsQxPrjDataBaseBL.GetQxPrjDataBase(ref objPrjDataBaseEN);
                                                             //objProjectsT.PrjMainDataBase = objProjectsS.PrjMainDataBase; //工程主数据库
                                                             //objProjectsT.IpAddress = objProjectsS.IpAddress; //IP地址
                                                             //objProjectsT.DataBaseUserId = objProjectsS.DataBaseUserId; //数据库用户Id
                                                             //objProjectsT.DataBasePwd = objProjectsS.DataBasePwd; //数据库用户口令
            objProjectsT.UpdUser = objProjectsS.UpdUser; //用户ID
            objProjectsT.UpdDate = objProjectsS.UpdDate; //UpdDate
                                                         //objProjectsT.UpdTime = objProjectsS.UpdTime; //UpdDate
            objProjectsT.IsDefaultPrj = objProjectsS.IsDefaultPrj; //是否默认工程
            objProjectsT.Memo = objProjectsS.Memo; //备注
            objProjectsT.QxPrjDataBaseId = objProjectsS.QxPrjDataBaseId; //项目数据库Id
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name="strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxProjectsEN GetProjectsObjByPrjName_Cache_SeqEx(string strPrjName)
        {
            if (string.IsNullOrEmpty(strPrjName) == true) return null;
            string strCondition = string.Format("1=1 order by PrjName");
            if (arrProjectsObjLst_Cache == null)
            {
                arrProjectsObjLst_Cache = new clsQxProjectsDA().GetObjLst(strCondition);
            }
            foreach (clsQxProjectsEN objProjectsEN in arrProjectsObjLst_Cache)
            {
                if (objProjectsEN.PrjName == strPrjName)
                {
                    intFindFailCount = 0;
                    return objProjectsEN;
                }
            }
            intFindFailCount++;
            // 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
            arrProjectsObjLst_Cache = null;
            if (intFindFailCount == 1) return GetProjectsObjByPrjName_Cache_SeqEx(strPrjName);
            string strErrMsgForGetObjById = string.Format("在QxProjects对象缓存列表中，找不到记录[PrjName={0}][intFindFailCount={1}](函数:GetProjectsObjByPrjName_Cache_SeqEx)", strPrjName, intFindFailCount);
            clsGeneralTab2.LogErrorS2("clsQxProjectsBLEx", "GetProjectsObjByPrjName_Cache_SeqEx", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }


    }
}