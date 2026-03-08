
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxDepartmentInfoBLEx
表名:QxDepartmentInfo
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:05
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
using System.Web.UI.WebControls;
using com.taishsoft.datetime;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 部门信息(QxDepartmentInfo)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxDepartmentInfoBLEx : clsQxDepartmentInfoBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxDepartmentInfoDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxDepartmentInfoDAEx QxDepartmentInfoDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxDepartmentInfoDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQxDepartmentInfoDAEx().GoTop(arrKeyId);
                bolResult = new clsQxDepartmentInfoDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }

        public static bool GoTop(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsQxDepartmentInfoDAEx().GoTop(arrKeyId);
                bolResult = new clsQxDepartmentInfoDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsQxDepartmentInfoDAEx().GoBottom(arrKeyId);
                bolResult = new clsQxDepartmentInfoDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsQxDepartmentInfoDAEx().GoBottom(arrKeyId);
                bolResult = new clsQxDepartmentInfoDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }


        public static bool AdjustSequenceNumber(string strDirect, string strDepartmentId)
        {
            try
            {
                bool bolResult = new clsQxDepartmentInfoDAEx().AdjustSequenceNumber(strDirect, strDepartmentId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }

        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsQxDepartmentInfoDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }



        public bool GetQxDepartmentInfoEx(clsQxDepartmentInfoEN objDepartmentInfoEN)
        {

            return true;
        }


        public static bool Bindtv_Departments(TreeView objTV)
        {

            TreeNode tnRoot, tnDepartment;
            List<clsQxDepartmentInfoEN> arrDepartmentObjList = clsQxDepartmentInfoBL.GetObjLst(" InUse='1' order by OrderNum ");
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
            tnRoot.Text = clsSysParaEN.strCompanyName;
            //			tnRoot.CheckBox=true;
            objTV.Nodes.Add(tnRoot);
            foreach (clsQxDepartmentInfoEN objDepartments in arrDepartmentObjList)
            {
                tnDepartment = new TreeNode();
                tnDepartment.Value = "Departments," + objDepartments.DepartmentId;
                tnDepartment.Text = objDepartments.DepartmentName + "(" + objDepartments.DepartmentId + ")";
                //				tnDepartment.CheckBox = true;
                tnRoot.ChildNodes.Add(tnDepartment);
            }

            return true;

        }

        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strUserId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExistEx(string strDepartmentId, clsSpecSQLforSql objSQL)
        {

            if (objSQL.IsExistRecord(clsQxDepartmentInfoEN._CurrTabName, "DepartmentId=" + "'" + strDepartmentId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SynDataToClientDatabase(string strPrjId)
        {
            clsQxProjectsEN objProjects = clsQxProjectsBL.GetObjByQxPrjIdCache(strPrjId);
            clsQxPrjDataBaseEN objPrjDataBase = clsQxPrjDataBaseBL.GetObjByQxPrjDataBaseId(objProjects.QxPrjDataBaseId);
            string strConnectString = clsQxPrjDataBaseBLEx.GetConnectString(objPrjDataBase);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            SqlConnection objSqlConnection = objSQL.getConnectObj(strConnectString);


            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append(" 1=1 ");
            List<clsQxDepartmentInfoEN> arrDepartmentObjList = clsQxDepartmentInfoBL.GetObjLst(sbCondition.ToString());

            foreach (clsQxDepartmentInfoEN objDepartmentInfoEN in arrDepartmentObjList)
            {

                objDepartmentInfoEN.Memo = clsDateTime.getTodayStr(0) + "从平台复制";

                SqlTransaction objSqlTransaction = objSqlConnection.BeginTransaction();
                try
                {
                    if (clsQxDepartmentInfoBLEx.IsExistEx(objDepartmentInfoEN.DepartmentId, objSQL) == false)
                    {
                        objDepartmentInfoEN.AddNewRecord(objSqlConnection, objSqlTransaction);

                    }
                    else
                    {
                        objDepartmentInfoEN.Update(objSqlConnection, objSqlTransaction);
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
        /// 功能：设置多条部门为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetInUse(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
            //删除QxDepartmentInfo本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update QxDepartmentInfo Set {0}='1' where DepartmentId in (" + strKeyList + ")",
                conQxDepartmentInfo.InUse);
            return objSQL.ExecSql(strSQL);
        }
        /// <summary>
        /// 功能：设置多条部门为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetNotInUse(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxDepartmentInfoDA.GetSpecSQLObj();
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
            //删除QxDepartmentInfo本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update QxDepartmentInfo Set {0}='0' where DepartmentId in (" + strKeyList + ")",
                conQxDepartmentInfo.InUse);
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 根据名称获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strDepartmentName">部门名称</param>
        /// <returns>根据名称获取的对象</returns>
        public static clsQxDepartmentInfoEN GetObjByDepartmentNameCache(string strDepartmentName)
        {
            var arrQxDepartmentInfoObjLst_Cache = GetObjLstCache();

            foreach (clsQxDepartmentInfoEN objQxDepartmentInfoEN in arrQxDepartmentInfoObjLst_Cache)
            {
                if (objQxDepartmentInfoEN.DepartmentName == strDepartmentName)
                {
                    return objQxDepartmentInfoEN;
                }
            }
            return null;
        }
    }
}