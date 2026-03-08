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

namespace GeneralPlatformWS
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
        public bool UserLogin(string strUserId, string strUserPassword)
        {
            clsUsers objUsers = new clsUsers(strUserId);
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
    }
}
