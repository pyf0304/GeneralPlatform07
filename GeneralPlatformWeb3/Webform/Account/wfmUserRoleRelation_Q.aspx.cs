///生成查询修改记录的控制层代码

///生成控制层的控件变量名列表
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
using CommFunc4WebForm;
using GeneralPlatform;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmUserRoleRelation_Q 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmUserRoleRelation_Q : System.Web.UI.Page
	{

		///生成有关的变量定义代码
		private const string ViewId4Potence="00260203";		//界面编号


		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
			{

				///生成权限有关判断权限的代码
				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
				switch (strPotenceLevel)
				{
					case "0":
						Response.Redirect("../error.aspx");
						break;
					case "1":
						Response.Redirect("../error.aspx");
						break;
					case "2":
						Response.Redirect("../error.aspx");
						break;
					case "3":
						Response.Redirect("../error.aspx");
						break;
					case "4":
						Response.Redirect("../error.aspx");
						break;
					case "9":
						break;
					default:
						Response.Redirect("../error.aspx");
						break;
				}

				// 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
				//wucStudent1.SetDdl_College();
				//1、为下拉框设置数据源，绑定列表数据
//				BindDdl_RoleId(ddlRoleId_q);
                clsDropDownList.BindDdl_DepartmentId4InUse(ddlDepartmentId_q);
                clsQxUserStateBL.BindDdl_UserStateId(ddlUserStateId_q);
                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);
				if (getUserPrjId != "0001")
				{
					ddlPrjId_q.SelectedValue = getUserPrjId;
					ddlPrjId_q.Enabled = false;
				}
				else
				{

				}
                clsDropDownList.BindDdl_QxRoles(ddlRoleId_q, getUserPrjId);

				//2、显示无条件的表内容在DATAGRID中
				strSortUserRoleRelationBy = "mId Asc";
				BindDg_QxUserRoleRelation();
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
			this.dgUserRoleRelation.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgUserRoleRelation_ItemCreated);
			this.dgUserRoleRelation.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgUserRoleRelation_PageIndexChanged);
			this.dgUserRoleRelation.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dgUserRoleRelation_SortCommand);

		}
		#endregion

		///生成权限等级的属性
		private string  strPotenceLevel
		{
			get
			{
				string sPotenceLevel;
				sPotenceLevel = (string)ViewState["PotenceLevel"];
				if (sPotenceLevel==null) 
				{
					//					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
					sPotenceLevel = "9";
					ViewState.Add("PotenceLevel", sPotenceLevel);
				}
				return sPotenceLevel;
			}
		}


		///生成登录用户的用户名Session
		private string UserId
		{
			get
			{
				string strUserId;
				strUserId = (string)Session["UserId"];
				if (strUserId==null) 
				{
					strUserId = "";
				}
				return strUserId;
			}
			set
			{
				string strUserId = value;
				Session.Add("UserId", strUserId);
			}
		}
		

		///生成组合查询条件的代码
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineUserRoleRelationCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtUserId_q.Text.Trim()!="")
			{
				strWhereCond += " And UserId like '%" + this.txtUserId_q.Text.Trim()+"%'";
			}
			if (this.ddlRoleId_q.SelectedValue!="" && this.ddlRoleId_q.SelectedValue!="0")
			{
				strWhereCond += " And RoleId='" + this.ddlRoleId_q.SelectedValue+"'";
			}
			if (this.ddlDepartmentId_q.SelectedValue!="" && this.ddlDepartmentId_q.SelectedValue!="0")
			{
				strWhereCond += " And DepartmentId='" + this.ddlDepartmentId_q.SelectedValue+"'";
			}
			if (this.ddlUserStateId_q.SelectedValue!="" && this.ddlUserStateId_q.SelectedValue!="0")
			{
				strWhereCond += " And UserStateId='" + this.ddlUserStateId_q.SelectedValue+"'";
			}
			if (this.ddlPrjId_q.SelectedValue!="" && this.ddlPrjId_q.SelectedValue!="0")
			{
				strWhereCond += string.Format(" And {0}='{1}'", conQxUserRoleRelation.QxPrjId, this.ddlPrjId_q.SelectedValue);
                
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QxUserRoleRelation()
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
			string strWhereCond = CombineUserRoleRelationCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxUserRoleRelationBL.GetDataTable(strWhereCond);
			//3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			///		3.1 首先计算页数；
			///		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgUserRoleRelation.PageSize);
			if (intPages==0) 
			{
				this.dgUserRoleRelation.CurrentPageIndex = 0;
			}
			else if (this.dgUserRoleRelation.CurrentPageIndex > intPages - 1) 
			{
				this.dgUserRoleRelation.CurrentPageIndex = intPages - 1;
			}
			//4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortUserRoleRelationBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgUserRoleRelation.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUserRoleRelation.DataBind();

			///生成专门用于BINDDG中的跳页相关代码
			//当前记录数
			this.lblUserRoleRelationRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblUserRoleRelationAllPages.Text = this.dgUserRoleRelation.PageCount.ToString(); 
			//当前页序数
			this.lblUserRoleRelationCurrentPage.Text=(this.dgUserRoleRelation.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtUserRoleRelationJump2Page.Text=(this.dgUserRoleRelation.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgUserRoleRelation.CurrentPageIndex==0) 
			{
				this.btnUserRoleRelationPrevPage.Enabled=false; 
			}
			else 
			{ 
				this.btnUserRoleRelationPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgUserRoleRelation.CurrentPageIndex==this.dgUserRoleRelation.PageCount-1) 
			{ 
				this.btnUserRoleRelationNextPage.Enabled=false; 
			} 
			else 
			{ 
				this.btnUserRoleRelationNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabUserRoleRelationJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabUserRoleRelationJumpPage.Visible = false; 
			}
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

		/// <summary>
		/// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnQuery_Click(object sender, System.EventArgs e)
		{
			///把DATAGRID的当前页索引设置为0，即第1页。
			///当单击查询时，首先显示的是表记录内容的第一部分内容。
			this.dgUserRoleRelation.CurrentPageIndex=0;
			///把表记录的内容显示在DATAGRID中
			BindDg_QxUserRoleRelation();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void dgUserRoleRelation_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgUserRoleRelation.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxUserRoleRelation();
		}

		///生成专门用于BINDDG中的跳页相关代码
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//1、组合界面条件串；
			string strWhereCond = CombineUserRoleRelationCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxUserRoleRelationBL.GetDataTable(strWhereCond);
			ArrayList arrCnName = new ArrayList();
			ArrayList arrColName = new ArrayList();
			string strFileName = "UserRoleRelation信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add(convQxUserRoleRelation.UserId); arrCnName.Add("用户ID");
			arrColName.Add(convQxUserRoleRelation.UserName); arrCnName.Add("用户名");
			arrColName.Add(convQxUserRoleRelation.RoleName); arrCnName.Add("角色名称");
			arrColName.Add(convQxUserRoleRelation.DepartmentName); arrCnName.Add("部门名");
			arrColName.Add(convQxUserRoleRelation.UserStateName); arrCnName.Add("用户状态名");
			arrColName.Add(convQxUserRoleRelation.PrjName); arrCnName.Add("工程名");
			strFolderName = Server.MapPath("/GeneralPlatform") +  "\\TempFiles\\";
			strDownLoadFileName = strFolderName + strFileName;
			GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
			DownLoadFile(strDownLoadFileName);
		}
		/// <summary>
		/// 功能：下载文件。从服务器下载文件到客户端浏览器
		/// </summary>
		/// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
		/// <returns></returns>
		private bool DownLoadFile(string strDownLoadFileName)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End();
			return true;
		}
		///生成从界面层到逻辑层的数据传输函数代码
		public System.Data.DataTable GetRoleId()
		{
			//获取某学院所有专业信息
			string strSQL = "select RoleId, RoleName from UserRoles ";
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
		
		
		///生成组合查询条件的代码
		private void dgUserRoleRelation_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			///判断是否是新的排序字段
			intIndex = strSortUserRoleRelationBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortUserRoleRelationBy = e.SortExpression + " Asc";
				BindDg_QxUserRoleRelation();
				return ;
			}
			///检查原来是升序
			intIndex = strSortUserRoleRelationBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortUserRoleRelationBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortUserRoleRelationBy = e.SortExpression + " Desc";
			}
			BindDg_QxUserRoleRelation();
		}

		private string strSortUserRoleRelationBy
		{
			get
			{
				string sSortUserRoleRelationBy;
				sSortUserRoleRelationBy = (string)ViewState["SortUserRoleRelationBy"];
				if (sSortUserRoleRelationBy==null) 
				{
					sSortUserRoleRelationBy = "";
				}
				return sSortUserRoleRelationBy;
			}
			set
			{
				string sSortUserRoleRelationBy = value;
				ViewState.Add("SortUserRoleRelationBy", sSortUserRoleRelationBy);
			}
		}
		private void dgUserRoleRelation_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			int intIndex;
			if (strSortUserRoleRelationBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgUserRoleRelation.Columns.Count;i++)
				{
					strSortEx = this.dgUserRoleRelation.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortUserRoleRelationBy.IndexOf(strSortEx);
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortUserRoleRelationBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?"▲":"▼");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		///生成父对象的SESSION相关属性函数
		protected void btnUserRoleRelationPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgUserRoleRelation.CurrentPageIndex -=1; 
			this.BindDg_QxUserRoleRelation(); 
		}

		protected void btnUserRoleRelationNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgUserRoleRelation.CurrentPageIndex +=1; 
			this.BindDg_QxUserRoleRelation(); 
		}

		protected void btnUserRoleRelationJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtUserRoleRelationJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtUserRoleRelationJump2Page.Text)>0 && 
				int.Parse(this.txtUserRoleRelationJump2Page.Text)-1<this.dgUserRoleRelation.PageCount) 
			{ 
				this.dgUserRoleRelation.CurrentPageIndex=int.Parse(this.txtUserRoleRelationJump2Page.Text)-1; 
			} 
			this.BindDg_QxUserRoleRelation();
		}

		protected void ddlPrjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string strPrjId = ddlPrjId_q.SelectedValue;
			if (strPrjId != null  || strPrjId != "0")
			{
                clsDropDownList.BindDdl_QxRoles(ddlRoleId_q, strPrjId);
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