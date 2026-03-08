///生成查询删除记录的控制层代码
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
using SpecData;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmUserGroupRelation_QD 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmUserGroupRelation_QD : System.Web.UI.Page
	{
		private ArrayList ay =new ArrayList();
		private clsQxUserGroup_Functions fun=new clsQxUserGroup_Functions();


		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				//1、为下拉框设置数据源，绑定列表数据
				//BindDdl_GroupId(ddlGroupId_q);
				///BindDdl_QxPrjId(ddlPrjId_q);
				//2、显示无条件的表内容在DATAGRID中
				BindDg_QxUserGroupRelation();

				fun.BindCkbList_GroupId(this.CheckBoxList1, clsCommonSession.UserPrjId4get);

				
				
				fun.BindDdl_Department(this.DropDownList1);
				//3、设置控件<删除>按钮的属性，使之在删除前先让用户通过对话框确认
				
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
		///生成从界面层到逻辑层的数据传输函数代码
   
		
		

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

		/// <summary>
		/// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			///把DATAGRID的当前页索引设置为0，即第1页。
			///当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.dgUserGroupRelation.CurrentPageIndex=0;

			///把表记录的内容显示在DATAGRID中
			BindDg_QxUserGroupRelation();
			
			this.dgUserGroupRelation.SelectedIndex=-1;

			fun.Set_CkbList_AllUnChecked(this.CheckBoxList1);
			
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void dgUserGroupRelation_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgUserGroupRelation.CurrentPageIndex=e.NewPageIndex;
			this.dgUserGroupRelation.SelectedIndex=-1;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxUserGroupRelation();
			fun.Set_CkbList_AllUnChecked(this.CheckBoxList1);
			
		}
	

		
		protected void btnDelete_Click(object sender, System.EventArgs e)
		{
			if(this.dgUserGroupRelation.SelectedIndex==-1)
			{
				return;
			}
			else
			{

				string userid=this.dgUserGroupRelation.SelectedItem.Cells[0].Text;
				ArrayList arr1,arr2;
					
				arr1=fun.Get_CkbList_SelectedArr(this.CheckBoxList1);
				arr2=fun.Get_CkbList_UnSelectedArr(this.CheckBoxList1);

                clsQxUserGroup_Functions.Set_SingleUser_MultiGroups(userid, arr1, clsCommonSession.UserPrjId4get);
				fun.Del_SingleUser_MultiGroups(userid,arr2);
				Response.Write("<script>alert('权限组已经修改！！')</script>");

			}
			
		}

		protected void dgUserGroupRelation_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string userid=this.dgUserGroupRelation.SelectedItem.Cells[0].Text;
			
			fun.Set_CkbList(this.CheckBoxList1,userid);
		}

		


	}
}