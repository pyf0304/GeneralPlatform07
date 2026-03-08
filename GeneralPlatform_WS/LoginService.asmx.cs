using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using GeneralPlatform;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform_WS
{
    /// <summary>
    /// LoginService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class LoginService : System.Web.Services.WebService
    {

        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [WebMethod]
        public bool UserLogin(string strLoginName, string strUserPassword)
        {
            string strUserId = clsUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsUsersEN objUsers = new clsUsersEN(strUserId);
            clsUsersBL.GetUsers(ref objUsers);
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            return true;

        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [WebMethod]
        public string UserLogin2(string strLoginName, string strUserPassword)
        {
            string strUserId = clsUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsUsersEN objUsers = null;
            try
            {
                objUsers = new clsUsersEN(strUserId);
                clsUsersBL.GetUsers(ref objUsers);
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            return "true";

        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <param name="strEffectiveDate">有效日期</param>
        /// <returns>成功返回"true"，不成功返回"false", 超过有效期返回"EffectiveDateError"</returns>
        [WebMethod]
        public string UserLoginWithEffectiveDate(string strLoginName, string strUserPassword, string strEffectiveDate)
        {
            string strUserId = clsUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsUsersEN objUsers = null;
            try
            {
                objUsers = new clsUsersEN(strUserId);
                clsUsersBL.GetUsers(ref objUsers);
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            if (string.IsNullOrEmpty(objUsers.EffectiveDate) == true) return "true";
            if (objUsers.EffectiveDate.CompareTo(strEffectiveDate) < 0)
            {
                return "EffectiveDateError";
            }
            return "true";

        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [WebMethod]
        public bool UserLoginByPrjId(string strLoginName, string strUserPassword, string strPrjId)
        {
            string strUserId = clsUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsUsersEN objUsers = new clsUsersEN(strUserId);
            clsUsersBL.GetUsers(ref objUsers);

            string strCondition = string.Format("UserId='{0}' And PrjId='{1}'", strUserId, strPrjId);
            if (clsPrjUserRelationBL.IsExistRecord(strCondition) == false)
            {
                return false;
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            return true;

        }

        /// <summary>
        /// 根据用户登录名获取用户Id
        /// </summary>
        /// <param name="strLoginName">用户登录名</param>        
        /// <returns>返回strUserId</returns>
        [WebMethod]
        public string GetUserIdByLoginName(string strLoginName)
        {
            string strUserId = clsUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);

            return strUserId;

        }
    }
}
