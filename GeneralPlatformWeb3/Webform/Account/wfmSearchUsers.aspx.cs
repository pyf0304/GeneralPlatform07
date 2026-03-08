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
using CommFunc4WebForm;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;

namespace  GeneralPlatform.Webform
{
	/// <summary>
	/// account 的摘要说明。
	/// </summary>
	public partial class wfmSearchUsers : System.Web.UI.Page
	{


	
		
		
		private const string ViewId="00010102";
		private string level;

		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			//获取当前用户的权限等级编号
			level=new MenuAndPotence().Get_PotenceLevel(ViewId);	


			if(!Page.IsPostBack)
			{
				this.DIV1.Visible =false;

                clsDropDownList.BindDdl_Departments(this.ddlDepartments_q);
                clsDropDownList.BindDdl_Departments(this.ddlDepartments);
                clsDropDownList.BindDdl_QxUserState(this.ddlUserState_q);
                clsDropDownList.BindDdl_QxUserState(this.ddlUserState);


				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
				switch (level)
				{
					case "0":

						Response.Redirect("../error.aspx");
						break;
					case "1":

						
					
						break;
					case "2":
						
						this.dgUsers.Columns[7].Visible =false;
						this.dgUsers.Columns[8].Visible =false;
						this.DIV2.Visible = false;

						break;
					case "3":

						Response.Redirect("../error.aspx");

						break;

					case "4":

						Response.Redirect("../error.aspx");

						break;


					default:
						Response.Redirect("../error.aspx");
						break;
				}




				this.BindDdl_QxUsers();


			
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
			this.dgUsers.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_ItemCommand);
			this.dgUsers.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
			this.dgUsers.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.DataGrid1_ItemDataBound);

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

		protected void btnQry_Click(object sender, System.EventArgs e)
		{
			this.dgUsers.CurrentPageIndex=0;
			this.BindDdl_QxUsers();
			
		}

		private string  CombineCondion()
		{
			string sWhereCon=" 1=1 ";
			if (this.txtUserId_q.Text.Trim()!="")
			{
				sWhereCon +=" and UserId like'"+txtUserId_q.Text.Trim()+"%'";
			}

			if(this.txtName_q.Text.Trim() != "")
			{
				sWhereCon += " and UserName like '"+txtName_q.Text.Trim()+"%'";
			}

			if (ddlDepartments_q.SelectedValue != "0")
			{
				sWhereCon+=" and DepartmentId ='"+ddlDepartments_q.SelectedValue+"'";
			}

			if(ddlUserState_q.SelectedValue != "0")
			{
				sWhereCon+=" and UserStateId ='"+ddlUserState_q.SelectedValue+"'";
			}
            if (getUserPrjId != "0001")
            {
                sWhereCon += string.Format(" And UserId in (Select UserId from {0} where {1}='{2}')",
                    clsQxPrjUserRelationEN._CurrTabName, conQxPrjUserRelation.QxPrjId, getUserPrjId );
            }


			return sWhereCon;
		}

		private void BindDdl_QxUsers()
		{

			//1、组合界面条件串；
			string strWhereCond = CombineCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxUsersBL.GetDataTable(strWhereCond);
			//3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			///		3.1 首先计算页数；
			///		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgUsers.PageSize);
			if (intPages==0) 
			{
				this.dgUsers.CurrentPageIndex = 0;
			}
			else if (this.dgUsers.CurrentPageIndex > intPages - 1) 
			{
				this.dgUsers.CurrentPageIndex = intPages - 1;
			}
			//4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			this.dgUsers.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUsers.DataBind();
			///	6、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();

			
		}

		/// <summary>
		/// 功能：计算DataGrid的页数
		/// </summary>
		/// <param name="intRecCount">总共的记录数</param>
		/// <param name="intPageSize">每页的记录数</param>
		/// <returns>计算出来的页数</returns>
		private int CalcPages(int intRecCount, int intPageSize)
		{
			int intPages;
			intPages = intRecCount / intPageSize;
			if (intRecCount % intPageSize !=0) intPages ++;
			return intPages;
		}


		private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			dgUsers.CurrentPageIndex=e.NewPageIndex;
			this.BindDdl_QxUsers();
		}

		protected void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.txtUserId.Text = dgUsers.SelectedItem.Cells[0].Text;
			this.txtName.Text = dgUsers.SelectedItem.Cells[1].Text;
			this.ddlDepartments.SelectedValue = dgUsers.SelectedItem.Cells[2].Text;
			this.ddlUserState.SelectedValue = this.dgUsers.SelectedItem.Cells[4].Text;
		
			
		}

		protected void btnSub_Click(object sender, System.EventArgs e)
		{
			if(this.txtUserId.Text.Trim()=="" || !clsQxUsersBL.IsExist(this.txtUserId.Text.Trim()))
			{
				Response.Write("<script>alert('帐号不正确！')</script>");
				return;
				
			}



			if(this.ddlDepartments.SelectedValue =="0")
			{
				Response.Write("<script>alert('部门不能为空！')</script>");
				return;

			}

			if(this.ddlUserState.SelectedValue=="0")
			{
				Response.Write("<script>alert('状态不能为空！')</script>");
				return;

			}



            clsQxUsersEN objUsersEN = clsQxUsersBL.GetObjByUserIdCache(this.txtUserId.Text);
			objUsersEN.UserName=this.txtName.Text.Trim();
			objUsersEN.DepartmentId = this.ddlDepartments.SelectedValue;
			objUsersEN.UserStateId=this.ddlUserState.SelectedValue;
			if(this.txtPwd.Text.Trim() != "")
			{
				objUsersEN.Password=this.txtPwd.Text;
			}
			objUsersEN.Memo = clsCommForWebForm.getTodayStr(0);
		    
			 clsQxUsersBL.UpdateBySql2(objUsersEN);


			Response.Write("<script>alert('修改成功！')</script>");
			this.Clear();

			this.BindDdl_QxUsers();


		}

		private void DataGrid1_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('如果暂时不使用这个帐号，可以修改帐号的状态！删除后将不可恢复！您真的要删除帐号： " + e.Item.Cells[0].Text + " 吗？');");
			}
		}

		public void Clear()
		{
			this.txtUserId.Text="";
			this.txtName.Text="";
			this.ddlDepartments.SelectedValue = "0";
			this.ddlUserState.SelectedValue = "0";
			this.txtPwd.Text="";
		    this.txtMemo.Text = "";
		}

		private void DataGrid1_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{

			string UserId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				UserId = e.Item.Cells[0].Text;
				switch(strCommandName)
				{
					case "Del":

						if(this.UserId == e.Item.Cells[0].Text)
						{
							Response.Write("<script>alert('无法删除当前使用的帐号！')</script>");
							return;
						}
			
						if(this.dgUsers.Items.Count==1 && this.dgUsers.CurrentPageIndex != 0)
						{
							this.dgUsers.CurrentPageIndex-=1;

						}

						try
						{
							clsQxUsersBL.DelRecord(e.Item.Cells[0].Text);
						}
						catch
						{
							Response.Write("<script>alert('删除失败，帐号已经被实际使用，请先删除所有此帐号的其他信息！')</script>");

						}
						this.BindDdl_QxUsers();
						break;

					case "Update":

						break;
						
                            
					default:
						// Do nothing.
						break;
				}
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
