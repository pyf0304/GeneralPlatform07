using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using GeneralPlatform;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// top 的摘要说明。
	/// </summary>
	public partial class top : System.Web.UI.Page
	{
		
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
            if (!IsPostBack)
            {
                lblApplicationName.Text = clsTSysParaBLEx.getApplicationName(clsMyConfig.spSchool);
                //this.Parent.Page.Title = string.Format("{0}--用户权限管理统一平台", lblApplicationName.Text);
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

		}
		#endregion

	

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			//Response.Cookies.Clear();
			Session.Clear();
//			string strflag = FormsAuthentication.HashPasswordForStoringInConfigFile("no","MD5");
//			Response.Cookies.Add(new HttpCookie("LoginState",strflag));

//			Request.Cookies.Clear();
			string c1 = "<script language='javascript'>window.parent.location.href='Index.aspx'; </script>";
			Response.Write(c1);
		}

		
	}
}
