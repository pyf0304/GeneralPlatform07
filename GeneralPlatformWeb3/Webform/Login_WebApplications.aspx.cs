using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using GeneralPlatform;
using System.Web.Security;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;


namespace GeneralPlatform.Webform
{
	/// <summary>
	/// Login_WebApplications 的摘要说明。
	/// </summary>
	public partial class Login_WebApplications : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面

			if(!IsPostBack)
			{
				Check_QxUserSession();
			}
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.iBtnLogin.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);

		}
		#endregion

		

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

			if(this.txtUserId.Text=="")
			{
				Response.Write("<script>alert('请输入用户名！')</script>");
				
			}
            string strUserId = this.txtUserId.Text.Trim();

            clsQxUsersEN objUsersEN = clsQxUsersBL.GetObjByUserIdCache(strUserId);
            if (objUsersEN == null)
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
                return;
            }
            if (objUsersEN.Password != this.txtPassword.Text.Trim())
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
                return;
            }
            ErrorInformationBL.AddInformation("Login_WebApplications", "ImageButton1_Click", "登录：UserId=" + strUserId, strUserId); 
            this.Set_QxUserInfoToSession();
            Response.Redirect("wfmSelectRoles_WebApplications.aspx?UserPrjId=" + getUserPrjId);
        }
		
		private void Set_QxUserInfoToSession()
		{
			Session.Clear();

            clsCommonSession.UserId = this.txtUserId.Text.Trim();
            clsCommonSession.UserStateId =  clsQxUsersBL.GetObjByUserIdCache(this.txtUserId.Text.Trim()).UserStateId;
			
			//System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordString, "MD5");

		}


		private void Check_QxUserSession()
		{
			if(getUserPrjId == "0")
			{
				Response.Redirect("wfmProjects_List.aspx");
				return;

			}

            if (clsCommonSession.UserId != "0" && clsCommonSession.UserStateId != "0")
			{
				Response.Redirect("wfmSelectRoles_WebApplications.aspx?UserPrjId="+getUserPrjId);
		
			}
				
			

		}


        protected void iBtnLogin_Click(object sender, ImageClickEventArgs e)
        {

        }


        /// <summary>
        /// 根据传递参数和选择参数决定的用户工程Id
        /// 功能：如果选择参数不为空，就返回选择参数用户工程Id，
        ///       否则就返回传递参数用户工程Id
        /// </summary>
        protected string getUserPrjId
        {
            get
            {
                if (string.IsNullOrEmpty(clsCommonSession.UserPrjId4get) == false) return clsCommonSession.UserPrjId4get;
                if (string.IsNullOrEmpty(qsUserPrjId) == false) return qsUserPrjId;
                return "";
            }
            set
            {
                clsCommonSession.UserPrjId4get = value;
            }
        }

        /// <summary>
        /// 用户选择的工程Id。例如：“0150”等
        /// 作者：潘以锋
        /// 建立日期：2016-07-01
        /// </summary>
        public string qsUserPrjId
        {
            get
            {
                if (Request.QueryString["UserPrjId"] != null)
                {
                    return Request.QueryString["UserPrjId"].ToString().Trim();
                }
                return "";
            }
        }
    }
}
