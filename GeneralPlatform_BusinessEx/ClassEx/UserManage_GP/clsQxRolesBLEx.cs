
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxRolesBLEx
表名:QxRoles(00140014)
* 版本:2023.12.26.1(服务器:WIN-SRV103-116)
日期:2023/12/28 17:46:17
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:用户管理(UserManage_GP)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using GeneralPlatform.Entity;
using System.Data;
using System.Data.SqlClient;
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.datetime;
using SpecData;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_QxRolesEx : RelatedActions_QxRoles
    {
        public override bool UpdRelaTabDate(string strRoleId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxRolesBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxRolesENS">源对象</param>
        /// <returns>目标对象=>clsQxRolesEN:objQxRolesENT</returns>
        public static clsQxRolesENEx CopyToEx(this clsQxRolesEN objQxRolesENS)
        {
            try
            {
                clsQxRolesENEx objQxRolesENT = new clsQxRolesENEx();
                clsQxRolesBL.QxRolesDA.CopyTo(objQxRolesENS, objQxRolesENT);
                return objQxRolesENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objQxRolesENS">源对象</param>
        /// <returns>目标对象=>clsQxRolesEN:objQxRolesENT</returns>
        public static clsQxRolesEN CopyTo(this clsQxRolesENEx objQxRolesENS)
        {
            try
            {
                clsQxRolesEN objQxRolesENT = new clsQxRolesEN();
                clsQxRolesBL.CopyTo(objQxRolesENS, objQxRolesENT);
                return objQxRolesENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 角色(QxRoles)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxRolesBLEx : clsQxRolesBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxRolesDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxRolesDAEx QxRolesDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxRolesDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxRolesENS">源对象</param>
        /// <returns>目标对象=>clsQxRolesEN:objQxRolesENT</returns>
        public static clsQxRolesENEx CopyToEx(clsQxRolesEN objQxRolesENS)
        {
            try
            {
                clsQxRolesENEx objQxRolesENT = new clsQxRolesENEx();
                clsQxRolesBL.QxRolesDA.CopyTo(objQxRolesENS, objQxRolesENT);
                return objQxRolesENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsQxRolesENEx> GetObjExLst(string strCondition)
        {
            List<clsQxRolesEN> arrObjLst = clsQxRolesBL.GetObjLst(strCondition);
            List<clsQxRolesENEx> arrObjExLst = new List<clsQxRolesENEx>();
            foreach (clsQxRolesEN objInFor in arrObjLst)
            {
                clsQxRolesENEx objQxRolesENEx = new clsQxRolesENEx();
                clsQxRolesBL.CopyTo(objInFor, objQxRolesENEx);
                arrObjExLst.Add(objQxRolesENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strRoleId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxRolesENEx GetObjExByRoleId(string strRoleId)
        {
            clsQxRolesEN objQxRolesEN = clsQxRolesBL.GetObjByRoleId(strRoleId);
            clsQxRolesENEx objQxRolesENEx = new clsQxRolesENEx();
            clsQxRolesBL.CopyTo(objQxRolesEN, objQxRolesENEx);
            return objQxRolesENEx;
        }

        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsQxRolesEN> arrUserRolesObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        private static int intFindFailCount = 0;
        public static ArrayList GetObjLstEx(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            System.Data.DataTable objDT = null;
            objDT = clsQxRolesBL.GetDataTable_QxRoles(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxRolesENEx objUserRolesEN = new clsQxRolesENEx();
                objUserRolesEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserRolesEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
                objUserRolesEN.QxPrjId = objRow[conQxProjects.QxPrjId].ToString().Trim(); //项目编号
                objUserRolesEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserRolesEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool IsRoleObj(string strRoleId, ArrayList arrUserRolesObjLst)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            foreach (clsQxRolesENEx objUserRolesEN in arrUserRolesObjLst)
            {
                if (objUserRolesEN.RoleId == strRoleId)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsRoleObj(string strRoleId, clsQxUsersENEx objUserEx)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            foreach (clsQxRolesENEx objUserRolesEN in objUserEx.arrUserRoleObjLst)
            {
                if (objUserRolesEN.RoleId == strRoleId)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsRoleObj(string strRoleId, string strUserId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QxPrjId = '{0}'", strPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from {1} where userid = '{0}')",
                strUserId,
                clsQxUserRoleRelationEN._CurrTabName);
            ArrayList arrUserRoleObjLst = clsQxRolesBLEx.GetObjLstEx(sbCondition.ToString());
            foreach (clsQxRolesENEx objUserRolesEN in arrUserRoleObjLst)
            {
                if (objUserRolesEN.RoleId == strRoleId)
                {
                    return true;
                }
            }
            return false;
        }

        ///绑定下拉框的函数代码
        public static void BindDdl_RoleIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("QxPrjId ='{0}'", strPrjId);
            System.Data.DataTable objDT = clsQxRolesBL.GetDataTable_QxRoles(strCondition);
            objDDL.DataValueField = "RoleId";
            objDDL.DataTextField = "RoleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static DataTable GetQxRolesExQuery(string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQL objSQL = new clsSpecSQL();
            StringBuilder strSQL = new StringBuilder();
            strSQL.AppendFormat("select * from {1} where RoleId in (select RoleId from {0} ",
                clsQxUserRoleRelationEN._CurrTabName,
                clsQxRolesEN._CurrTabName);
            strSQL.AppendFormat("where " + "{0}" + ")", strCondition);
            string SQL = strSQL.ToString().Trim();
            objDT = objSQL.GetDataTable(SQL);
            return objDT;
        }
        public static bool DelRecordEx(string strRoleId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQL objSQL = new clsSpecSQL();
            //删除Users本表中与当前对象有关的记录

            strSQL = strSQL + string.Format("Delete from {1} where RoleId='{0}';", strRoleId, clsQxRoleMenusEN._CurrTabName);
            strSQL = strSQL + string.Format("Delete from {1} where RoleId='{0}';", strRoleId, clsQxUserGroupPotenceEN._CurrTabName);
            strSQL = strSQL + string.Format("Delete from {1} where RoleId='{0}';", strRoleId, clsQxUserRoleRelationEN._CurrTabName);
            strSQL = strSQL + string.Format("Delete from {1} where RoleId='{0}';", strRoleId, clsQxRolesEN._CurrTabName);
            return objSQL.ExecSql(strSQL);
        }
        public static bool DelQxUserRolesEx(ArrayList lstKey)
        {
            clsSpecSQL objSQL = new clsSpecSQL();
            //string strSQL;
            //string strKeyList;
            if (lstKey.Count == 0) return true;
            foreach (string strRoleId in lstKey)
            {
                DelRecordEx(strRoleId);
            }
            return true;
        }

        /// <summary>
        /// 根据名称获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strUserStateName">用户状态名称</param>
        /// <returns>根据名称获取的对象</returns>
        public static clsQxRolesEN GetObjByRoleNameCache(string strRoleName)
        {
            var arrQxUserRolesObjLst_Cache = GetObjLstCache();

            foreach (clsQxRolesEN objQxUserRolesEN in arrQxUserRolesObjLst_Cache)
            {
                if (objQxUserRolesEN.RoleName == strRoleName)
                {
                    return objQxUserRolesEN;
                }
            }
            return null;
        }


        public static bool IsExistEx(string strRoleId, clsSpecSQLforSql objSQL)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            if (objSQL.IsExistRecord(clsQxRolesEN._CurrTabName, "RoleId=" + "'" + strRoleId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SynDataToLocaldataBase(string strPrjId)
        {
            clsQxProjectsEN objProjects = clsQxProjectsBL.GetObjByQxPrjIdCache(strPrjId);
            clsQxPrjDataBaseEN objPrjDataBase = clsQxPrjDataBaseBL.GetObjByQxPrjDataBaseId(objProjects.QxPrjDataBaseId);
            string strConnectString = clsQxPrjDataBaseBLEx.GetConnectString(objPrjDataBase);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            SqlConnection objSqlConnection = objSQL.getConnectObj(strConnectString);


            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" QxPrjId = '{0}' ", strPrjId);

            //从平台复制角色
            List<clsQxRolesEN> arrUserRoleObjList = clsQxRolesBL.GetObjLst(sbCondition.ToString());

            foreach (clsQxRolesEN objUserRolesEN in arrUserRoleObjList)
            {
                objUserRolesEN.Memo = clsDateTime.getTodayStr(0) + "从平台复制";

                SqlTransaction objSqlTransaction = objSqlConnection.BeginTransaction();
                try
                {

                    if (clsQxRolesBLEx.IsExistEx(objUserRolesEN.RoleId, objSQL) == false)
                    {
                        objUserRolesEN.AddNewRecord(objSqlConnection, objSqlTransaction);
                    }
                    else
                    {
                        objUserRolesEN.UpdateBySql2(objSqlConnection, objSqlTransaction);
                    }
                    objSqlTransaction.Commit();
                }
                catch (Exception objException)
                {
                    objSqlTransaction.Rollback();
                    throw objException;
                }
                finally
                {

                }
            }
            //从平台复制角色用户关系
            List<clsQxUserRoleRelationEN> arrUserRoleRelationObjList = clsQxUserRoleRelationBL.GetObjLst(sbCondition.ToString());

            foreach (clsQxUserRoleRelationEN objUserRoleRelationEN in arrUserRoleRelationObjList)
            {
                objUserRoleRelationEN.Memo = clsDateTime.getTodayStr(0) + "从平台复制";

                //if (new clsQxUsersEN().IsExistCondRec("UserId = '" + objUserRoleRelationEN.UserId + "'") == false)
                //{
                //    continue;
                //}
                sbCondition = new StringBuilder();
                sbCondition.AppendFormat("UserId = '{0}' and RoleId = '{1}'",
                    objUserRoleRelationEN.UserId, objUserRoleRelationEN.RoleId);
                SqlTransaction objSqlTransaction = objSqlConnection.BeginTransaction();
                try
                {
                    if (clsQxUserRoleRelationBLEx.IsExistCondRecEx(sbCondition.ToString(), objSQL) == false)
                    {
                        objUserRoleRelationEN.AddNewRecord(objSqlConnection, objSqlTransaction);

                    }
                    objSqlTransaction.Commit();
                }
                catch (Exception objException)
                {
                    objSqlTransaction.Rollback();
                    throw objException;
                }
                finally
                {

                }
            }
            objSqlConnection.Close();
            return true;
        }
        /// <summary>
        /// 功能：设置多条用户角色为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetInUse(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxRolesDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除QxUserRoles本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update {0} Set IsInUse='1' where RoleId in (" + strKeyList + ")",
                clsQxRolesEN._CurrTabName);
            return objSQL.ExecSql(strSQL);
        }
        /// <summary>
        /// 功能：设置多条用户角色为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetNotInUse(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxRolesDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除QxUserRoles本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update {0} Set IsInUse='0' where RoleId in (" + strKeyList + ")",
                clsQxRolesEN._CurrTabName);
            return objSQL.ExecSql(strSQL);
        }



        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name="strRoleId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxRolesEN GetQxUserRolesObjByRoleName_Cache_SeqEx(string strRoleName)
        {
            if (string.IsNullOrEmpty(strRoleName) == true) return null;
            string strCondition = string.Format("1=1 order by RoleName");
            if (arrUserRolesObjLst_Cache == null)
            {
                arrUserRolesObjLst_Cache = new clsQxRolesDA().GetObjLst(strCondition);
            }
            foreach (clsQxRolesEN objUserRolesEN in arrUserRolesObjLst_Cache)
            {
                if (objUserRolesEN.RoleName == strRoleName)
                {
                    intFindFailCount = 0;
                    return objUserRolesEN;
                }
            }
            intFindFailCount++;
            // 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
            arrUserRolesObjLst_Cache = null;
            if (intFindFailCount == 1) return GetQxUserRolesObjByRoleName_Cache_SeqEx(strRoleName);
            string strErrMsgForGetObjById = string.Format("在QxUserRoles对象缓存列表中，找不到记录[RoleName={0}][intFindFailCount={1}](函数:GetQxUserRolesObjByRoleName_Cache_SeqEx)", strRoleName, intFindFailCount);
            clsGeneralTab2.LogErrorS2("clsQxRolesBLEx", "GetQxUserRolesObjByRoleName_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

    }
}