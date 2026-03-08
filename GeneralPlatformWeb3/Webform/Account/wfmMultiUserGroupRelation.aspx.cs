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
	/// wfmMultiUserGroupRelation 的摘要说明。
	/// </summary>
	public partial class wfmMultiUserGroupRelation : System.Web.UI.Page
	{

		private clsQxUserGroup_Functions fun=new clsQxUserGroup_Functions();
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面
			if(!IsPostBack)
			{
				BindDg_QxUserGroupRelation();

				fun.BindCkbList_GroupId(this.CheckBoxList1, clsCommonSession.UserPrjId4get);

				
				
				fun.BindDdl_Department(this.DropDownList1);
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
			this.dgUserGroupRelation.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgUserGroupRelation_PageIndexChanged);

		}
		#endregion


		///生成组合查询条件的代码
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and XM = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			
			if (this.txtUserId_q.Text.Trim()!="")
			{
				strWhereCond += " and UserId like '%" + this.txtUserId_q.Text.Trim()+"%'";
			}
			if (this.txtXM_q.Text.Trim()!="")
			{
				strWhereCond += " and XM like '%" + this.txtXM_q.Text.Trim()+"%'";
			}


			if (this.DropDownList1.SelectedValue!="" && this.DropDownList1.SelectedValue!="0")
			{
				strWhereCond += " and bmh='" + this.DropDownList1.SelectedValue+"'";
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
			System.Data.DataTable objDT = fun.GetQxUsers(strWhereCond);
			//3、设置DATAGRID的数据源(DataSource)；
			this.dgUserGroupRelation.DataSource=objDT.DefaultView;
			//4、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUserGroupRelation.DataBind();
			//5、设置记录数的状态，
			this.txtRecCount.Text= objDT.Rows.Count.ToString();
		}

		protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			fun.Set_AllDgCkecked(this.dgUserGroupRelation,this.CheckBox1);
		}

		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			///把DATAGRID的当前页索引设置为0，即第1页。
			///当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.dgUserGroupRelation.CurrentPageIndex=0;

			///把表记录的内容显示在DATAGRID中
			BindDg_QxUserGroupRelation();
			
			

			fun.Set_CkbList_AllUnChecked(this.CheckBoxList1);

			this.CheckBox1.Checked=false;
		}

		protected void btnOK_Click(object sender, System.EventArgs e)
		{
			ArrayList arr1,arr2;
			arr1=fun.Get_DgCheckedArr(this.dgUserGroupRelation);
			arr2=fun.Get_CkbList_SelectedArr(this.CheckBoxList1);
            clsQxUserGroup_Functions.Set_MultiUsers_MultiGroups(arr1,arr2, clsCommonSession.UserPrjId4get);
			Response.Write("<script>alert('已经添加成功！！')</script>");
		}

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			ArrayList arr1,arr2;
			arr1=fun.Get_DgCheckedArr(this.dgUserGroupRelation);
			arr2=fun.Get_CkbList_SelectedArr(this.CheckBoxList1);
			fun.Del_MultiUsers_MultiGroups(arr1,arr2);
			Response.Write("<script>alert('已经删除成功！！')</script>");
		
		}

		protected void Button2_Click(object sender, System.EventArgs e)
		{
			ArrayList arr1,arr2;
			arr1=fun.Get_WhereCondArr(this.CombineCondion());
			arr2=fun.Get_CkbList_SelectedArr(this.CheckBoxList1);
            clsQxUserGroup_Functions.Set_MultiUsers_MultiGroups(arr1,arr2, clsCommonSession.UserPrjId4get);
			Response.Write("<script>alert('已经添加成功！！')</script>");
		
		}

		protected void Button3_Click(object sender, System.EventArgs e)
		{
			ArrayList arr1,arr2;
			arr1=fun.Get_WhereCondArr(this.CombineCondion());
			arr2=fun.Get_CkbList_SelectedArr(this.CheckBoxList1);
			fun.Del_MultiUsers_MultiGroups(arr1,arr2);
			Response.Write("<script>alert('已经删除成功！！')</script>");
		
		}

		private void dgUserGroupRelation_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			this.dgUserGroupRelation.CurrentPageIndex=e.NewPageIndex;
			
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxUserGroupRelation();
			fun.Set_CkbList_AllUnChecked(this.CheckBoxList1);
			fun.Set_AllDgCkecked(this.dgUserGroupRelation,this.CheckBox1);
		}
	}
}
