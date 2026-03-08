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
using System.Text;
using SpecData;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// roles 的摘要说明。
	/// </summary>
	public partial class wfmSelectRoles_WebApplications : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面

			if(!IsPostBack)
			{
				this.BindDg_QxUserRoleRelation();
				this.Check_QxUserRole();
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

		public string RoleId
		{
			get
			{
				if(Session["RoleId"] != null)
				{
					return Session["RoleId"].ToString();
				}
				else
				{
					return "0";
				}
			}
			set
			{
				Session.Add("RoleId",value);
				
			}

		}

		public string UserId
		{
			get
			{
				if(Session["UserId"] != null)
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

		public string UserStateId
		{
			get
			{
				if(Session["UserStateId"] != null)
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
				Session.Add("UserStateId",value);
				
			}
		}



		private DataTable Get_QxUserRoleRelation1(string strUserId,string strUserPrjId)
		{
			StringBuilder sb=new StringBuilder("");
			sb.Append(" select UserRoleRelation.mId UserRoleRelationmId , ");
			sb.Append(" UserRoleRelation.UserId UserRoleRelationUserId , ");
			sb.Append(" Users.UserName UsersUserName , ");
			sb.Append(" UserRoleRelation.QxPrjId UserRoleRelationPrjId , ");
			sb.Append(" QxProjects.PrjName ProjectsPrjName , ");
			sb.Append(" UserRoleRelation.RoleId UserRoleRelationRoleId , ");
			sb.Append(" UserRoles.RoleName UserRolesRole ,");
			sb.Append(" UserRoleRelation.Memo UserRoleRelationMemo ");
			sb.Append(" from QxUserRoleRelation left join Users on (UserRoleRelation.UserId = Users.UserId) ");
			sb.Append(" left join QxUserRoles on (QxUserRoleRelation.RoleId = UserRoles.RoleId) ");
			sb.Append(" left join QxProjects on (QxUserRoleRelation.QxPrjId = QxProjects.QxPrjId) ");
			
			sb.AppendFormat(" where Users.UserId = '{0}'" ,strUserId);
			sb.AppendFormat(" and QxUserRoleRelation.QxPrjId = '{0}'" ,strUserPrjId);

			DataTable objDt = new clsSpecSQLforSql().GetDataTable(sb.ToString());

			return objDt;

		}

		private void BindDg_QxUserRoleRelation()
		{
			if(this.UserId == "0" )
			{
				this.ReturnLoginView();
			}
			if(getUserPrjId == "0")
			{
				this.ReturnLoginView();
			}
            string strCondition = string.Format("{0}='{1}' And {2}='{3}'", 
                conQxUserRoleRelation.QxPrjId, getUserPrjId, conQxUserRoleRelation.UserId, this.UserId);
            DataTable objDT = clsvQxUserRoleRelationBL.GetDataTable(strCondition);
            this.DataGrid1.DataSource = objDT;// this.Get_QxUserRoleRelation(this.UserId, getUserPrjId);
			this.DataGrid1.DataBind();

		}

		protected void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.RoleId = this.DataGrid1.SelectedItem.Cells[5].Text;
            Response.Redirect(clsQxProjectsBL.GetObjByQxPrjIdCache(getUserPrjId).Memo + "?UserId=" + this.UserId + "&RoleId=" + this.RoleId + "&UserStateId=" + this.UserStateId);
		}

		private void Check_QxUserRole()
		{
			if(this.DataGrid1.Items.Count == 0 )
			{
				this.ReturnLoginView();
			}
			else if(this.DataGrid1.Items.Count == 1)
			{
				this.RoleId = this.DataGrid1.Items[0].Cells[5].Text;
                string strTemp = clsQxProjectsBL.GetObjByQxPrjIdCache(getUserPrjId).Memo;
                Response.Redirect(strTemp + "?UserId=" + this.UserId + "&RoleId=" + this.RoleId + "&UserStateId=" + this.UserStateId);
			}
		}

		
		private void ReturnLoginView()
		{

			Session.Clear();
			string strMsg;
			strMsg = "对不起你的帐号状态不正确，请重新登录!";
			Response.Write("<script>alert('" + strMsg + "')</script>");
			string ss = "<script language='javascript'> parent.window.location.href='Login_WebApplications.aspx'</script>";
			//			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
			//			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
			Response.Write(ss);

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
