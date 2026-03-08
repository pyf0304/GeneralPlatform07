
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserLoginNameBLEx
表名:QxUserLoginName
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:09
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
using com.taishsoft.sql;
using com.taishsoft.datetime;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 用户登录名(QxUserLoginName)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxUserLoginNameBLEx : clsQxUserLoginNameBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserLoginNameDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserLoginNameDAEx QxUserLoginNameDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserLoginNameDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 从用户Id建立登录名
        /// </summary>
        /// <param name="strCurrUserId">当前用户</param>
        /// <returns>是否成功？</returns>
        public static bool CreateLoginNameFromUserId(string strCurrUserId)
        {
            string strCurrDate = clsDateTime.getTodayStr(0);
            string strCurrTime = clsDateTime.getCurrTime(0);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append(" userId not in (Select UserLoginName from UserLoginName)");
            List<clsQxUsersEN> arrUsersObjLst = clsQxUsersBL.GetObjLst(sbCondition.ToString());
            foreach (clsQxUsersEN objUsers in arrUsersObjLst)
            {
                clsQxUserLoginNameEN objUserLoginName = new clsQxUserLoginNameEN();
                objUserLoginName.UserLoginName = objUsers.UserId;
                objUserLoginName.UserId = objUsers.UserId;
                objUserLoginName.UpdDate = strCurrDate;
                objUserLoginName.UpdTime = strCurrTime;
                objUserLoginName.UpdUserId = strCurrUserId;
                objUserLoginName.Memo = "通过用户Id同步。";
                try
                {
                    clsQxUserLoginNameBL.AddNewRecordBySql2(objUserLoginName);
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }
            return true;
        }


        /// <summary>
        /// 从学工号建立登录名
        /// </summary>
        /// <param name="strCurrUserId">当前用户</param>
        /// <returns>是否成功？</returns>
        public static bool CreateLoginNameFromStuTeacherId(string strCurrUserId)
        {
            string strCurrDate = clsDateTime.getTodayStr(0);
            string strCurrTime = clsDateTime.getCurrTime(0);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append(" StuIdTeacherId not in (Select UserLoginName from UserLoginName)");
            List<clsQxUsers_SchoolEN> arrUsersObjLst = clsQxUsers_SchoolBL.GetObjLst(sbCondition.ToString());
            foreach (clsQxUsers_SchoolEN objUsers in arrUsersObjLst)
            {
                if (string.IsNullOrEmpty(objUsers.StuTeacherId) == true) continue;
                clsQxUserLoginNameEN objUserLoginName = new clsQxUserLoginNameEN();
                objUserLoginName.UserLoginName = objUsers.StuTeacherId;
                objUserLoginName.UserId = objUsers.UserId;
                objUserLoginName.UpdDate = strCurrDate;
                objUserLoginName.UpdTime = strCurrTime;
                objUserLoginName.UpdUserId = strCurrUserId;
                objUserLoginName.Memo = "通过学工号建立登录名。";
                try
                {
                    clsQxUserLoginNameBL.AddNewRecordBySql2(objUserLoginName);
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }
            return true;
        }
        public static string GetUserIdByLoginName(string strLoginName)
        {
            try
            {

                clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
                string strConnectString = objSQL.ConnectionString;
                if (string.IsNullOrEmpty(strConnectString) == true)
                {
                    throw new Exception("当前连接串为空，请检查！");
                }
                bool bolIsExist = clsSqlObject.IsExistTable(strConnectString, "QxUserLoginName");
                if (bolIsExist == false)
                {
                    return strLoginName;
                }

                clsQxUserLoginNameEN objUserLoginName = clsQxUserLoginNameBL.GetObjByUserLoginName(strLoginName);
                
                if (objUserLoginName == null || string.IsNullOrEmpty(objUserLoginName.UserId) == true)
                {
                    return strLoginName;
                }

                return objUserLoginName.UserId;
            }
            catch (Exception objException)
            {
                clsGeneralTab2.LogErrorS(objException, "clsQxUserLoginNameBLEx");
                return strLoginName;
            }
        }
    }
}