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
using System.Data.SqlClient;
using GeneralPlatform;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using com.taishsoft.commdb;

namespace  GeneralPlatform.Webform
{
	/// <summary>
	/// chpwd 的摘要说明。
	/// </summary>
	public partial class wfmChangePwd : System.Web.UI.Page
	{

		private const string ViewId="00010103";
		private string level;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			//获取当前用户的权限等级编号
			level=new MenuAndPotence().Get_PotenceLevel(ViewId);	


		
			if(!IsPostBack)
			{
				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
				switch (level)
				{
					case "0":

						Response.Redirect("../error.aspx");
						break;
					case "1":

						
					
						break;
					case "2":
						
						
						break;
					case "3":

						

						break;
					case "4":

						

						break;

					default:
						Response.Redirect("../error.aspx");
						break;
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

		public string UserId
		{
			get
			{
				if(Session["UserId"]!=null)
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
				Session.Add("UserId",value);
			}

		}

		protected void btnSubmit_Click(object sender, System.EventArgs e)
		{
			if(!clsQxUsersBL.IsExistRecord(" UserId='"+this.UserId+"' and Password='"+this.txtOldpwd.Text+"'"))
			{
				Response.Write("<script>alert('旧密码不正确！')</script>");
				return;

			}

			if(this.txtNewpwd.Text=="")
			{
				Response.Write("<script>alert('新密码不能为空！')</script>");
				return;

			}
			
			if(txtNewpwd.Text!=txtNewpwd2.Text)
			{
				Response.Write("<script>alert('确认密码不符')</script>");
				return;
			}

            clsQxUsersBL.SetFldValue(clsQxUsersEN._CurrTabName, "Password", this.txtNewpwd2.Text, " UserId='" + this.UserId + "'");
			
		
//			string strSQL = "select PWD from Account where UID = '" +Session[0].ToString() +"'";
//			clsSpecSQLforSql mySql = new clsSpecSQLforSql();
////			SqlDataReader dr = mySql.GetSqlDataReader(strSQL);
////			dr.Read();
//			System.Data.DataTable dt=mySql.GetDataTable(strSQL);
//			
//			if(txtOldpwd.Text!=dt.Rows[0][0].ToString().Trim())
//			{
//				Response.Write("<script>alert('密码不正确！')</script>");
//				return;
//			}
//			if(txtNewpwd.Text!=txtNewpwd2.Text)
//			{
//				Response.Write("<script>alert('确认密码不符')</script>");
//				return;
//			}
//			cAccount act = new cAccount();
//			act.m_sUid=Session[0].ToString();
//			act.ChangePwd(txtNewpwd.Text);
			
			
			Response.Write("<script>alert('修改密码成功！')</script>");
			
		}
	}
}
