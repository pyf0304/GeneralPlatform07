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
using GeneralPlatform;
using GeneralPlatform.BusinessLogic;


namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmCheck_QxUserInfo 的摘要说明。
	/// </summary>
	public partial class wfmCheck_QxUserInfo : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if(!IsPostBack)
			{
				if(new MenuAndPotence().Check_Login(this.requestUserId ,this.requestUserStateId , this.requestRoleId) == true)
				{
					
					Response.Redirect("MeetingSign.htm");
					//这里跳转到每个系统的筐架页

				}
				else
				{
					this.Label1.Text = "对不起，您的登录信息不正确，请重试！";

				}

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

		public string requestRoleId
		{
			get
			{
				if(Request.QueryString["RoleId"]!=null)
				{
					return Request.QueryString["RoleId"];
				}
				else
				{
					return "0";
				}
			}

		}

		public string requestUserId
		{
			get
			{
				if(Request.QueryString["UserId"]!=null)
				{
					return Request.QueryString["UserId"];
				}
				else
				{
					return "0";
				}
			}

		}

		public string requestUserStateId
		{
			get
			{
				if(Request.QueryString["UserStateId"]!=null)
				{
					return Request.QueryString["UserStateId"];
				}
				else
				{
					return "0";
				}
			}
			

		}

	


		



	}
}
