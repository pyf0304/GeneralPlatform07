using System;
using System.Collections.Generic;
using System.Text;
using GeneralPlatform.Entity;
using com.taishsoft.commdb;
using System.Collections;

namespace GeneralPlatform.DAL
{
    /// <summary>
    /// 
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
            List<string>  arrUserIdLst = new clsvQxUsersDA().GetFldValueNoDistinct("EnterSchoolDate", sbCondition.ToString());
            if (arrUserIdLst.Count == 0) return "";
            string strEnterSchoolDate = arrUserIdLst[0] as string;
            return strEnterSchoolDate.Substring(0,4);
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
