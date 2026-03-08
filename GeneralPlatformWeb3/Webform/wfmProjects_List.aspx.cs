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
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmProjects_List 的摘要说明。
	/// </summary>
	public partial class wfmProjects_List : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面

			if(!IsPostBack)
			{
				this.BindDl_Projects(this.DataList1);
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

		public void BindDl_Projects(DataList objDl)
		{
			objDl.DataSource = clsQxProjectsBL.GetDataTable_QxProjects(" QxPrjId != '0001' ");
			objDl.DataBind();

		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
		    this.Page.Request.Cookies.Clear();
		}
	}
}
