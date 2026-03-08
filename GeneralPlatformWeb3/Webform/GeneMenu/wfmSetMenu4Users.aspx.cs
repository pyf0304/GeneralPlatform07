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
using com.taishsoft.commdb;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmSetMenu4Users 的摘要说明。
	/// </summary>
	public partial class wfmSetMenu4Users : System.Web.UI.Page
	{
		private string strMsg;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
			{
				// 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
				//wucStudent1.SetDdl_College();
//				QxPrjId = "0001";
				//1、为下拉框设置数据源，绑定列表数据
				BindDdl_BMH(ddlBMH_q);
				BindDdl_RoleId(ddlRoleId_q);
				//2、显示无条件的表内容在DATAGRID中
				//				strSortBy = " Asc";
				BindDg_QxUsers();
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
			this.dgUsers.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgUsers_PageIndexChanged);

		}
		#endregion

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
		
		
		private string CombineCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 and XM = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtUserId_q.Text.Trim()!="")
			{
				strWhereCond += " and Users.UserId like '%" + this.txtUserId_q.Text.Trim()+"%'";
			}
			if (this.txtXM_q.Text.Trim()!="")
			{
				strWhereCond += " and Users.XM like '%" + this.txtXM_q.Text.Trim()+"%'";
			}
			if (this.ddlBMH_q.SelectedValue!="" && this.ddlBMH_q.SelectedValue!="0")
			{
				strWhereCond += " and Users.DepartmentId='" + this.ddlBMH_q.SelectedValue+"'";
			}
			if (this.ddlRoleId_q.SelectedValue!="" && this.ddlRoleId_q.SelectedValue!="0")
			{
				strWhereCond += " and Users.RoleId='" + this.ddlRoleId_q.SelectedValue+"'";
			}

//          strWhereCond += " and UserMenus.QxPrjId='" + this.QxPrjId+"'";
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QxUsers()
		{
			//操作步骤：(共5步)
			//1、组合界面条件串；
			//2、根据条件串获取该表满足条件的DataTable；
			//3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
			//4、设置DATAGRID的数据源(DataSource)；
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			///	6、设置记录数的状态，
			///		在本界面中是把状态显示在控件txtRecCount中。

			//1、组合界面条件串；
			string strWhereCond = CombineCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsQxUserMenusBLEx.GetQxUsers4UserMenusQuery(strWhereCond);
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
			Session.Add("dtUserMenus",objDT);
			this.cbChooseAll.Checked = false;
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

		public System.Data.DataTable GetBMH()
		{
			//获取某学院所有专业信息
			string strSQL = "select DepartmentId, DepartmentName from Departments ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_BMH(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetBMH();
			objDDL.DataValueField="DepartmentId";
			objDDL.DataTextField="DepartmentName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetRoleId()
		{
			//获取某学院所有专业信息
			string strSQL = "select RoleId, RoleName from UserRole ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetRoleId();
			objDDL.DataValueField="RoleId";
			objDDL.DataTextField="RoleName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			///把DATAGRID的当前页索引设置为0，即第1页。
			///当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.dgUsers.CurrentPageIndex=0;
			///把表记录的内容显示在DATAGRID中
			BindDg_QxUsers();
		}

		private void dgUsers_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgUsers.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxUsers();
		}

		protected void cbChooseAll_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.cbChooseAll.Checked==true)
			{
				foreach(DataGridItem di in this.dgUsers.Items)
				{					//遍历DataGrid中的每一项，达到多条数据的操作
					CheckBox cb = (CheckBox)di.FindControl("cb1"); //从DataGrid每一行中找出名为rbCheck的控件，并定义为CheckBox
					cb.Checked=true;
				}

			}
			else
			{
				foreach(DataGridItem di in this.dgUsers.Items)
				{					//遍历DataGrid中的每一项，达到多条数据的操作
					CheckBox cb = (CheckBox)di.FindControl("cb1"); //从DataGrid每一行中找出名为rbCheck的控件，并定义为CheckBox
					cb.Checked=false;
				}
			}
		}

		protected void btnMakeSure_Click(object sender, System.EventArgs e)
		{
			if(this.cbChooseAll.Checked)//如果是全选，那么遍历DataTable，符合条件选出来的全部要添加或修改
			{
				System.Data.DataTable dtUserMenus=(System.Data.DataTable)Session["dtUserMenus"];
				bool IsRoleMenu = this.cdUseRoleMenu.Checked;
				
				foreach(System.Data.DataRow row in dtUserMenus.Rows )
				{
					string xh=row.ItemArray[0].ToString().Trim();
					//判断这个学号在学费基本信息表里是否存在,如果存在,那么是更新这条记录,如果不存在,那么就添加一条记录				
					if(clsQxUserMenusBL.IsExistRecord(" UserId = '"+xh+ "' and QxPrjId = '" + this.QxPrjId+"' ")==false)
					{
						clsQxUserMenusEN  usermenus = new clsQxUserMenusEN();
						usermenus.UserId = xh ;
						usermenus.QxPrjId = this.QxPrjId ;
						usermenus.IsUseRoleMenu = IsRoleMenu ;
                        clsQxUserMenusBL.AddNewRecordBySql2(usermenus);

					}
					else
					{
						    
						long mid = long.Parse(row.ItemArray[9].ToString().Trim());
						clsQxUserMenusEN  usermenus = new clsQxUserMenusEN(mid);
						usermenus.UserId = xh ;
						usermenus.QxPrjId = this.QxPrjId ;
						usermenus.IsUseRoleMenu = IsRoleMenu ;
                        clsQxUserMenusBL.UpdateBySql2(usermenus);

					}
				}
				strMsg = "记录成功!";
				Response.Write("<script>alert('" + strMsg + "')</script>");
				this.BindDg_QxUsers();
			
			}
			else //不是全选，那么遍历DataGrid,将打钩的记录添加或修改
			{
				bool IsRoleMenu = this.cdUseRoleMenu.Checked;
				foreach(DataGridItem di in this.dgUsers.Items)//遍历DataGrid中的每一项，达到多条数据的操作
				{					
					string xh=di.Cells[1].Text;
					CheckBox cb = (CheckBox)di.FindControl("cb1"); //从DataGrid每一行中找出名为rbCheck的控件，并定义为CheckBox
					if(cb!=null && cb.Checked)		//判断CheckBox是否选中
					{
							
						if(clsQxUserMenusBL.IsExistRecord(" UserId = '"+xh+ "' and QxPrjId = '" + this.QxPrjId+"' ")==false)
						{
							clsQxUserMenusEN  usermenus = new clsQxUserMenusEN();
							usermenus.UserId = xh ;
							usermenus.QxPrjId = this.QxPrjId ;
							usermenus.IsUseRoleMenu = IsRoleMenu ;
                            clsQxUserMenusBL.AddNewRecordBySql2(usermenus);


						}
						else
						{
						    
							long mid = long.Parse(di.Cells[7].Text) ;
							clsQxUserMenusEN  usermenus = new clsQxUserMenusEN(mid);
							usermenus.UserId = xh ;
							usermenus.QxPrjId = this.QxPrjId ;
							usermenus.IsUseRoleMenu = IsRoleMenu ;
                            clsQxUserMenusBL.UpdateBySql2(usermenus);

						}
					}
				}
				strMsg = "记录成功!";
				Response.Write("<script>alert('" + strMsg + "')</script>");
				this.BindDg_QxUsers();


			}
		
		
		
		
		
		}
        




	}
}
