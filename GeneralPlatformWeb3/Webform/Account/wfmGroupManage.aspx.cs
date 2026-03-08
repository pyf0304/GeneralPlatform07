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
using SpecData;
using GeneralPlatform;
using GeneralPlatform;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;

 


namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmGroupManage 的摘要说明。
	/// </summary>
	public partial class wfmGroupManage : System.Web.UI.Page
	{

		private clsQxUserGroup_Functions fun ;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面
			if(!IsPostBack)
			{
                fun = new clsQxUserGroup_Functions();

clsQxProjectsBL.BindDdl_QxPrjId(this.DropDownList1);
				//this.DropDownList1.SelectedValue=fun.QxPrjId;
				fun.BindDdl_GroupId(this.DropDownList2, getUserPrjId);


				this.BindDg_QxUserGroupRelation();

				BindLb_QxUsers();
				

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
			this.dgUserGroupRelation.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgUserGroupRelation_ItemCreated);
			this.dgUserGroupRelation.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgUserGroupRelation_ItemCommand);
			this.dgUserGroupRelation.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgUserGroupRelation_PageIndexChanged);

		}
		#endregion

		


		private string CombineCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and XM = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.DropDownList1.SelectedValue!="0")
			{
				strWhereCond += " and ug.prjid = '" + this.DropDownList1.SelectedValue+"'";
			}
			else
			{
				strWhereCond += " and 1=2 ";
			}
			
			if (this.DropDownList2.SelectedValue!="0")
			{
				strWhereCond += " and ug.groupid = '" + this.DropDownList2.SelectedValue+"'";
			}
			else
			{
				strWhereCond += " and 1=2 ";
			}
			

		

			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QxUserGroupRelation()
		{
			//操作步骤：(共5步)
			//1、组合界面条件串；
			//2、根据条件串获取该表满足条件的DataTable；
			//3、设置DATAGRID的数据源(DataSource)；
			//4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			//5、设置记录数的状态，
			///		在本界面中是把状态显示在控件txtRecCount中。
			

			//1、组合界面条件串；
			string strWhereCond = CombineCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			string SQL=string.Format(" select users.*,userstate.UserStateName userstatemc,ug.groupid groupid,ugps.groupname groupmc from UserGroupRelation ug left join users on(ug.userid=users.userid) left join userstate on (users.userstateid=userstate.userstateid) left join usergroups ugps on (ug.groupid = ugps.groupid) where {0}",strWhereCond);
			clsSpecSQLforSql objSQL=new clsSpecSQLforSql();
			System.Data.DataTable objDT = objSQL.GetDataTable(SQL);
			//3、设置DATAGRID的数据源(DataSource)；
			this.dgUserGroupRelation.DataSource=objDT.DefaultView;
			//4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUserGroupRelation.DataBind();
			//5、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
		}

		private void BindLb_QxUsers()
		{
			DataTable objDt=clsQxUsersBL.GetDataTable_QxUsers(" 1=1 ");
			this.ListBox1.DataSource=objDt;
			this.ListBox1.DataTextField="UserName";
			this.ListBox1.DataValueField="UserId";
			this.ListBox1.DataBind();

		}

		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			this.dgUserGroupRelation.CurrentPageIndex=0;
			this.BindDg_QxUserGroupRelation();
		}

		protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string strPrjId=this.DropDownList1.SelectedValue;
			fun.BindDdl_GroupId(this.DropDownList2, strPrjId);
			
		}

		protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			fun.Set_AllDgCkecked(this.dgUserGroupRelation,this.CheckBox1);
		}

		private void dgUserGroupRelation_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.dgUserGroupRelation.CurrentPageIndex=e.NewPageIndex;
			
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxUserGroupRelation();
			
			fun.Set_AllDgCkecked(this.dgUserGroupRelation,this.CheckBox1);
		}

		private void dgUserGroupRelation_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem )
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Text = "删除";
				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}

		
		}

		private void dgUserGroupRelation_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				
				switch(strCommandName)
				{
					case "Delete":
						string userid=e.Item.Cells[1].Text;
						string groupid=e.Item.Cells[3].Text;

						fun.Del_SingleUser_SingleGroup(userid,groupid);

						BindDg_QxUserGroupRelation();
						
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						break;

					default:
						// Do nothing.
						break;
				}
			}

		}

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			ArrayList arr1;
			arr1=fun.Get_DgCheckedArr(this.dgUserGroupRelation);
			string Groupid=this.DropDownList2.SelectedValue;
			fun.Del_MultiUsers_SingleGroup(arr1,Groupid);
			this.dgUserGroupRelation.CurrentPageIndex=0;
			this.BindDg_QxUserGroupRelation();
		}

		protected void Button3_Click(object sender, System.EventArgs e)
		{
			clsQxUserGroupRelationBL.DelQxUserGroupRelationsByCond(string.Format(" groupid = '{0}' and prjid = '{1}'",this.DropDownList2.SelectedValue,this.DropDownList1.SelectedValue));
			this.dgUserGroupRelation.CurrentPageIndex=0;
			this.BindDg_QxUserGroupRelation();
		
		}

		protected void btnOK_Click(object sender, System.EventArgs e)
		{
			ArrayList arr1;
			arr1=fun.Get_ListBox_SelectedArr(this.ListBox1);
			string Groupid=this.DropDownList2.SelectedValue;
			fun.Set_MultiUsers_SingleGroup(arr1,Groupid, getUserPrjId);
			this.dgUserGroupRelation.CurrentPageIndex=0;
			this.BindDg_QxUserGroupRelation();
			
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
