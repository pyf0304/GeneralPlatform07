
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxRoleMenusBLEx
表名:QxRoleMenus
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:47
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:菜单管理
模块英文名:MenuManage
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
using com.taishsoft.datetime;
using SpecData;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 角色菜单(QxRoleMenus)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxRoleMenusBLEx : clsQxRoleMenusBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxRoleMenusDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxRoleMenusDAEx QxRoleMenusDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxRoleMenusDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 根据角色权限的关系决定角色所拥有的菜单
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strRoleId"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool EditQxRoleMenusByPotence(string strPrjId, string strRoleId, string strUserId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录后空闲过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(0);

            string strCondition_PotenceMenu = string.Format("{0}='{1}' And {2}='{3}'",
                convQxUserGroupPotence.QxPrjId, strPrjId,
                convQxUserGroupPotence.RoleId, strRoleId
                );
            List<string> arrMenuId_Potence = new List<string>();


            List<clsvQxUserGroupPotenceEN> arrvUserGroupPotenceObjLst = clsvQxUserGroupPotenceBL.GetObjLst(strCondition_PotenceMenu);
            foreach (clsvQxUserGroupPotenceEN objvUserGroupPotenceEN in arrvUserGroupPotenceObjLst)
            {
                if (arrMenuId_Potence.Contains(objvUserGroupPotenceEN.MenuId) == false)
                {
                    if (string.IsNullOrEmpty(objvUserGroupPotenceEN.MenuId) == false)
                    {
                        arrMenuId_Potence.Add(objvUserGroupPotenceEN.MenuId);
                    }
                }
                if (arrMenuId_Potence.Contains(objvUserGroupPotenceEN.UpMenuId) == false)
                {
                    if (string.IsNullOrEmpty(objvUserGroupPotenceEN.UpMenuId) == false)
                    {
                        arrMenuId_Potence.Add(objvUserGroupPotenceEN.UpMenuId);
                    }
                }
            }


            string strCondition_QxPrjMenus = string.Format("{0}='{1}' And {2}='{3}'",
                conQxRoleMenus.QxPrjId, strPrjId,
                conQxRoleMenus.RoleId, strRoleId
                );
            List<string> arrMenuId_QxPrjMenus = clsQxRoleMenusBL.GetFldValue(conQxRoleMenus.MenuId, strCondition_QxPrjMenus);

            List<string> arrNewMenuIds = clsAggregate.TwoAggrDiff(arrMenuId_Potence, arrMenuId_QxPrjMenus);
            List<string> arrNeedDelMenuIds = clsAggregate.TwoAggrDiff(arrMenuId_QxPrjMenus, arrMenuId_Potence);
            clsQxRoleMenusBLEx.RoleAddMenus(strPrjId, strRoleId, arrNewMenuIds, strUserId);
            clsQxRoleMenusBLEx.RoleDelMenus(strPrjId, strRoleId, arrNeedDelMenuIds);

            return true;
        }


        public static bool RoleAddMenus(string strPrjId, string strRoleId, List<string> arrCheckedMenus, string strUserId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(0);
            StringBuilder strCondition;
            foreach (string strMenuId in arrCheckedMenus)
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and MenuId = '{2}'",
                    strPrjId, strRoleId, strMenuId, conQxRoleMenus.QxPrjId);
                if (clsQxRoleMenusBL.IsExistRecord(strCondition.ToString()) == false)
                {
                    clsQxRoleMenusEN objQxRoleMenus = new clsQxRoleMenusEN();
                    objQxRoleMenus.QxPrjId = strPrjId;
                    objQxRoleMenus.RoleId = strRoleId;
                    objQxRoleMenus.MenuId = strMenuId;

                    objQxRoleMenus.UpdDate = strCurrDate14;
                    objQxRoleMenus.UpdUserId = strUserId;
                    clsQxRoleMenusBL.AddNewRecordBySql2(objQxRoleMenus);
                }
            }
            return true;
        }

        public static bool SetRoleMenu(string strPrjId, string strCmPrjId, string strMenuSetId, string strRoleId, string strMenuId, string strOpUserId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(0);
            StringBuilder strCondition;

            strCondition = new StringBuilder();
            strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and MenuId = '{2}' and {4}='{5}'",
                strCmPrjId, strRoleId, strMenuId, conQxRoleMenus.CmPrjId, conQxRoleMenus.MenuSetId, strMenuSetId);
            if (clsQxRoleMenusBL.IsExistRecord(strCondition.ToString()) == false)
            {
                clsQxRoleMenusEN objQxRoleMenus = new clsQxRoleMenusEN();
                objQxRoleMenus.QxPrjId = strPrjId;
                objQxRoleMenus.CmPrjId = strCmPrjId;
                objQxRoleMenus.MenuSetId = strMenuSetId;
                objQxRoleMenus.RoleId = strRoleId;
                objQxRoleMenus.MenuId = strMenuId;

                objQxRoleMenus.UpdDate = strCurrDate14;
                objQxRoleMenus.UpdUserId = strOpUserId;
                clsQxRoleMenusBL.AddNewRecordBySql2(objQxRoleMenus);
            }

            return true;
        }


        public static bool RoleAddRoles4Menu(string strPrjId, string strMenuId, List<string> arrCheckedRoles, string strUserId)
        {
            if (string.IsNullOrEmpty(strMenuId) == true)
            {
                string strMsg = string.Format("菜单Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(0);
            StringBuilder strCondition;
            foreach (string strRoleId in arrCheckedRoles)
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and MenuId = '{2}'",
                    strPrjId, strRoleId, strMenuId, conQxRoleMenus.QxPrjId);
                if (clsQxRoleMenusBL.IsExistRecord(strCondition.ToString()) == false)
                {
                    clsQxRoleMenusEN objQxRoleMenus = new clsQxRoleMenusEN();
                    objQxRoleMenus.QxPrjId = strPrjId;
                    objQxRoleMenus.RoleId = strRoleId;
                    objQxRoleMenus.MenuId = strMenuId;

                    objQxRoleMenus.UpdDate = strCurrDate14;
                    objQxRoleMenus.UpdUserId = strUserId;
                    clsQxRoleMenusBL.AddNewRecordBySql2(objQxRoleMenus);
                }
            }
            return true;
        }

        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        public static System.Data.DataTable GetUpMenuTable(string strRoleId, string strPrjId)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT;
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL.Append("SELECT TOP 100 PERCENT dbo.QxRoleMenus.MenuId, dbo.QxPrjMenus.MenuName, ");
            strSQL.Append(" dbo.QxPrjMenus.UpMenuId, dbo.QxPrjMenus.LinkFile, dbo.QxPrjMenus.ImgFile, ");
            strSQL.Append(" dbo.QxPrjMenus.OrderNum, dbo.QxRoleMenus.QxPrjId, dbo.QxRoleMenus.RoleId ");
            strSQL.Append(" FROM dbo.QxPrjMenus RIGHT OUTER JOIN ");
            strSQL.Append(" dbo.QxRoleMenus ON dbo.QxPrjMenus.MenuId = dbo.QxRoleMenus.MenuId");
            strSQL.AppendFormat(" WHERE (dbo.QxRoleMenus.RoleId = '{0}') AND (dbo.QxPrjMenus.UpMenuId = '00000000') AND ",
                strRoleId);
            strSQL.AppendFormat("( dbo.QxRoleMenus.QxPrjId = '{0}')",
                strPrjId);
            strSQL.Append(" ORDER BY dbo.QxPrjMenus.OrderNum");
            try
            {
                objDT = objSQL.GetDataTable(strSQL.ToString());
            }
            catch (Exception objException)
            {
                clsGeneralTab2.LogErrorS(objException, "GetSubMenuTable");
                throw new Exception("", objException);
            }
            finally
            {
            }
            return objDT;
        }
        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        public static System.Data.DataTable GetSubMenuTable(string strRoleId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT;
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL.Append("SELECT TOP 100 PERCENT dbo.QxRoleMenus.MenuId, dbo.QxPrjMenus.MenuName, ");
            strSQL.Append(" dbo.QxPrjMenus.UpMenuId, dbo.QxPrjMenus.LinkFile, dbo.QxPrjMenus.ImgFile, ");
            strSQL.Append(" dbo.QxPrjMenus.OrderNum, dbo.QxRoleMenus.QxPrjId, dbo.QxRoleMenus.RoleId ");
            strSQL.Append(" FROM dbo.QxPrjMenus RIGHT OUTER JOIN ");
            strSQL.Append(" dbo.QxRoleMenus ON dbo.QxPrjMenus.MenuId = dbo.QxRoleMenus.MenuId");
            strSQL.AppendFormat(" WHERE (dbo.QxRoleMenus.RoleId = '{0}') AND (dbo.QxPrjMenus.UpMenuId <> '00000000') AND ",
                strRoleId);
            strSQL.AppendFormat(" (dbo.QxRoleMenus.QxPrjId = '{0}')",
                strPrjId);
            strSQL.Append(" ORDER BY dbo.QxPrjMenus.OrderNum");
            try
            {
                objDT = objSQL.GetDataTable(strSQL.ToString());
            }
            catch (Exception objException)
            {
                clsGeneralTab2.LogErrorS(objException, "GetSubMenuTable");
                throw new Exception("", objException);
            }
            finally
            {
            }
            return objDT;
        }
        public void RoleDelAllPotence(string strPrjId, string strRoleId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{2}='{0}' and RoleId='{1}'", strPrjId, strRoleId, conQxRoleMenus.QxPrjId);
            clsQxRoleMenusBL.DelQxRoleMenussByCond(strCondition.ToString());
        }

        public static void RoleDelMenu(string strPrjId, string strRoleId, string strMenuId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and MenuId = '{2}'", strPrjId, strRoleId, strMenuId,
                conQxRoleMenus.QxPrjId);
            clsQxRoleMenusBL.DelQxRoleMenussByCond(strCondition.ToString());
        }
        public static void RoleDelMenus(string strPrjId, string strRoleId, List<string> arrMenuIds)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            foreach (string strMenuId in arrMenuIds)
            {
                StringBuilder strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and MenuId = '{2}'", strPrjId, strRoleId, strMenuId,
                    conQxRoleMenus.QxPrjId);
                clsQxRoleMenusBL.DelQxRoleMenussByCond(strCondition.ToString());
            }
        }

        public static bool Delete(string strRoleId, string strMenuSetId, string strMenuId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder strCondition = new StringBuilder();
            strCondition.Append($" {conQxRoleMenus.RoleId}='{strRoleId}' and {conQxRoleMenus.MenuSetId}='{strMenuSetId}' and {conQxRoleMenus.MenuId} = '{strMenuId}'");
            if (clsQxRoleMenusBL.DelQxRoleMenussByCond(strCondition.ToString())>0) return true;
            return false;
        }

    }
}