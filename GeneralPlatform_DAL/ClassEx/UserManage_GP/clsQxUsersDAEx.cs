
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersDAEx
表名:QxUsers
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:26
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:用户管理
模块英文名:UserManage
框架-层名:数据处理扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{
    /// <summary>
    /// 用户(QxUsers)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsQxUsersDAEx : clsQxUsersDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUsers"></param>
        /// <returns></returns>
        public bool GetQxUsers(ref clsQxUsersENEx objUsers)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxUsersDA.GetSpecSQLObj();
            strSQL = "Select * from Users where UserId=" + "'" + objUsers.UserId + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            objUsers.UserId = objDT.Rows[0]["UserId"].ToString().Trim(); //用户ID
            objUsers.UserName = objDT.Rows[0]["UserName"].ToString().Trim(); //用户名
            objUsers.DepartmentId = objDT.Rows[0]["DepartmentId"].ToString().Trim(); //部门Id
            objUsers.UserStateId = objDT.Rows[0]["UserStateId"].ToString().Trim(); //用户状态Id
            objUsers.Password = objDT.Rows[0]["Password"].ToString().Trim(); //口令
            objUsers.Memo = objDT.Rows[0]["Memo"].ToString().Trim(); //备注
            objDT = null;
            return true;
        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年月
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年月</returns>
        public static string GetEnterSchoolDateByUserId(string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId = '{0}'", strUserId);
            List<string> arrUserIdLst = new clsvQxUsersDA().GetFldValueNoDistinct("EnterSchoolDate", sbCondition.ToString());
            if (arrUserIdLst.Count == 0) return "";
            string strEnterSchoolDate = arrUserIdLst[0] as string;
            return strEnterSchoolDate;
        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年</returns>
        public static string GetEnterSchoolYearByUserId(string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId = '{0}'", strUserId);
            List<string> arrUserIdLst = new clsvQxUsersDA().GetFldValueNoDistinct("EnterSchoolDate", sbCondition.ToString());
            if (arrUserIdLst.Count == 0) return "";
            string strEnterSchoolDate = arrUserIdLst[0] as string;
            return strEnterSchoolDate.Substring(0, 4);
        }
        /// <summary>
        /// 根据用户Id（UserId）获取用户名
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>用户名</returns>
        public static string GetUserNameByUserId(string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("UserId = '{0}'", strUserId);
            List<string> arrUserNameLst = new clsQxUsersDA().GetFldValueNoDistinct("UserName", sbCondition.ToString());
            if (arrUserNameLst.Count == 0) return "";
            string strUserName = arrUserNameLst[0] as string;
            return strUserName;
        }
    }
}