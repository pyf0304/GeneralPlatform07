using com.taishsoft.commexception;
using com.taishsoft.common;
using CommFunc4WebForm;


using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using GeneralPlatform.Webform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamLib.Webform.Admin
{
    public partial class login : CommWebBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strVirtualRoot = HttpContext.Current.Request.ApplicationPath;
            //clsPubFun4Web.SetSysPath(strVirtualRoot);
            //EduHigh.BusinessLogicEx.clsPubFun.SetSysPath(strVirtualRoot);
            switch (clsMyConfig.spId_School)
            {
                case "0004":
                    this.Title = "宁波大学统一平台";
                    lblTitle.Text = this.Title;
                    break;
                case "0009":
                    this.Title = "安全生产月知识竞赛统一平台";
                    lblTitle.Text = this.Title;
                    break;
                case "0006":
                    this.Title = "上海泰泽在线教育统一平台";
                    lblTitle.Text = this.Title;
                    break;
                case "0008":
                    this.Title = "上海师大二附中统一平台";
                    lblTitle.Text = this.Title;
                    break;
                case "0007":
                    this.Title = "上海泰泽统一平台";
                    lblTitle.Text = this.Title;
                    break;
                case "0001":
                    this.Title = "淮阴师范统一平台";
                    lblTitle.Text = this.Title;
                    break;
                default:
                    clsXzSchoolEN objXzSchoolEN = clsXzSchoolBL.GetObjByIdSchoolCache(clsMyConfig.spId_School);
                    if (objXzSchoolEN == null)
                    {
                        string strMsg1 = string.Format("学校Id_School：[{0}]没有相关的对象，请检查。({1})",
                            clsMyConfig.spId_School,
                            clsStackTrace.GetCurrClassFunction());
                        clsCommonJsFunc.Alert(this, strMsg1);
                        return;
                    }
                    string strMsg = string.Format("当前学校：[{0}({1})]没有在相关函数中处理。({2})",
                        objXzSchoolEN.SchoolName,
                        objXzSchoolEN.SchoolId,
                        clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                    //                        break;
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string strUserId, strPassword;
            strUserId = txtUid.Text.Trim();
            strPassword = txtPassWord.Text;
            Login(strUserId, strPassword);
           
        }

        private void Login(string strUserId, string strPassword)
        {
            string GetClientIp = CommFunc4WebForm.clsCommForWebForm.GetClientIp(this);

            string strMsg;
            string strTemp = strUserId.ToLower();
            int i = strTemp.IndexOf("or");
            int j = strTemp.IndexOf("'");

            if (i > 0 && j >= 0)
            {
                strMsg = "请输入正确的用户名！";
                clsCommonJsFunc.Alert(this, strMsg);
                return;

                //throw new clsDbObjException(strMsg);
            }
            if (strUserId == "")
            {
                strMsg = "请输入用户名！";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            bool bolResult;
            try
            {
               

                clsQxUsersEN objUsersEN = clsQxUsersBL.GetObjByUserIdCache(strUserId);
                if (objUsersEN == null)
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                    return;
                }
                if (objUsersEN.Password != strPassword)
                {
                    Response.Write("<script>alert('用户名或密码错误！')</script>");
                    return;
                }
                ErrorInformationBL.AddInformation("Index", "Login", "登录：UserId=" + strUserId, strUserId);

                this.Set_QxUserInfoToSession();
                //Response.Redirect("wfmSelectRoles_WebApplications.aspx?UserPrjId=" + getUserPrjId);
               
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("login", "UserLogin" + GetClientIp,
"可能统一认证平台有问题：" + objException.Message, clsCommonSession.UserId);
                CommFunc4WebForm.clsCommonJsFunc.Alert(this, "可能统一认证平台有问题！" + objException.Message);
                return;
                clsPubFun.AccessError(this, conCurrPageName);
            }
            Response.Redirect("../wfmSelectUserPrjAndRole_GeneralPlatform.aspx");

            //添加日志
        }
        private void Set_QxUserInfoToSession()
        {
            Session.Clear();

            this.UserId = this.txtUid.Text.Trim();
            this.UserStateId = clsQxUsersBL.GetObjByUserIdCache(this.txtUid.Text.Trim()).UserStateId;

            //System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordString, "MD5");

        }
        public string UserId
        {
            get
            {
                if (Session["UserId"] != null)
                {
                    return Session["UserId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                Session.Add("UserId", value);

            }

        }


        public string UserStateId
        {
            get
            {
                if (Session["UserStateId"] != null)
                {
                    return Session["UserStateId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                Session.Add("UserStateId", value);


            }
        }
        /// <summary>
        /// 常量:当前页面名称
        /// </summary>
        public string conCurrPageName
        {
            get
            {
                return "login.aspx";
            }
        }
        private void AddSysLogForLogin(string strUserId)
        {
            //			string strUserId = strUserId;
            string strUserIp = Request.UserHostAddress;
            if (strUserIp == "127.0.0.1")
            {
                return;
            }
            

        }

    }
}