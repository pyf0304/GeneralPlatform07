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
using System.Text;
using System.Configuration;
using GeneralPlatform;
using SpecData;
using System.Web.Security;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmSelectUserPrjAndRole 的摘要说明。
	/// </summary>
	public partial class wfmSelectUserPrjAndRole_GeneralPlatform : System.Web.UI.Page
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
                this.Title = string.Format("{0}--用户权限管理统一平台--选择角色", clsTSysParaBLEx.getApplicationName(clsMyConfig.spSchool));
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


		public string  CurrrntPrjId
		{
			get
			{
				if(ConfigurationSettings.AppSettings[conQxProjects.QxPrjId] != null)
				{
					return ConfigurationSettings.AppSettings[conQxProjects.QxPrjId].ToString();
				}
				else
				{
					return "0";
				}
			}
		}

		private void BindDg_QxUserRoleRelation()
		{
			if(clsCommonSession.UserId == "" )
			{
				this.ReturnLoginView();
			}

            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" {0} = '{1}'" , conQxUserRoleRelation.UserId, clsCommonSession.UserId);

            sbCondition.AppendFormat(" and ({0} not like '0001%' or {0} = '00010001')",
                conQxUserRoleRelation.RoleId);
            sbCondition.Append("[exclude]or [/exclude]");
            DataTable objDT = clsvQxUserRoleRelationBL.GetDataTable_vQxUserRoleRelation(sbCondition.ToString());
            this.Dg_QxUserRoleRelation.DataSource = objDT;
			this.Dg_QxUserRoleRelation.DataBind();

		}

		private void Set_QxUserInfoToSession()
		{
            clsCommonSession.RoleId = clsQxUserRoleRelationBL.GetFldValue(clsQxUserRoleRelationEN._CurrTabName, "RoleId", " UserId = '" + clsCommonSession.UserId + "' and QxPrjId = '" + this.CurrrntPrjId + "'")[0].ToString();
            new clsCommonSession().RoleId4CurrPrj = this.Dg_QxUserRoleRelation.SelectedItem.Cells[5].Text;
            getUserPrjId = this.Dg_QxUserRoleRelation.SelectedItem.Cells[3].Text;

            //Response.Redirect("Frameset.htm");
            Response.Redirect("../Webform/Admin/IndexMenu.aspx");
        }

        protected void Dg_QxUserRoleRelation_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.Set_QxUserInfoToSession();
		}

		private void Check_QxUserRole()
		{
            if (this.Dg_QxUserRoleRelation.Items.Count == 0)
            {
                this.ReturnLoginView4NoRole();
            }
            string strCondition = string.Format(" {0} = '{1}' and {2} = '{3}'",
                conQxUserRoleRelation.UserId, clsCommonSession.UserId,
                conQxUserRoleRelation.QxPrjId,
                this.CurrrntPrjId);
            if ( !clsQxUserRoleRelationBL.IsExistRecord(strCondition))
			{
                this.ReturnLoginView4NoRole();
			}
			else if(this.Dg_QxUserRoleRelation.Items.Count == 1)
			{

                clsCommonSession.RoleId = clsQxUserRoleRelationBL.GetFldValue(clsQxUserRoleRelationEN._CurrTabName, "RoleId", strCondition)[0].ToString();
                getUserPrjId = this.Dg_QxUserRoleRelation.Items[0].Cells[3].Text;

				//Response.Redirect("../Frameset.htm");
                Response.Redirect("../Webform/Admin/IndexMenu.aspx");

            }
		}

		
		private void ReturnLoginView()
		{
			Session.Clear();
			string strMsg;
			strMsg = "对不起你的帐号状态不正确，请重新登录!";
			Response.Write("<script>alert('" + strMsg + "')</script>");
			string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
			//			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
			//			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
			Response.Write(ss);
		}

        private void ReturnLoginView4NoRole()
        {
            Session.Clear();
            string strMsg;
            strMsg = "对不起你还没有角色，请与管理员联系!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
            //			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
            //			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
            Response.Write(ss);
        }
		private void Button1_Click(object sender, System.EventArgs e)
		{
		this.Page.Request.Cookies.Clear();
		}
		private string QxPrjId
		{
			get
			{
				string strPrjId;
				strPrjId = (string)Session[conQxProjects.QxPrjId];
				if (strPrjId==null) 
				{
					strPrjId = "";
				}
				return strPrjId;
			}
			set
			{
				string strPrjId = value;
				Session.Add(conQxProjects.QxPrjId, strPrjId);
			}
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
