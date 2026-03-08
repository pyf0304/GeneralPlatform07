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
using GeneralPlatform;
using CommFunc4WebForm;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmQxViewPotence_Q 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmQxViewPotence_Q : System.Web.UI.Page
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
                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);
                clsQxPrjModuleBL.BindDdl_ModuleId(ddlModuleId_q);
                clsQxViewInfoBL.BindDdl_ViewId(ddlViewId_q);
                clsQxPrjPotenceBL.BindDdl_PotenceId(ddlPotenceId_q);
				if (getUserPrjId != "0001")
				{
					ddlPrjId_q.SelectedValue = getUserPrjId;
					ddlPrjId_q.Enabled = false;
					dgQxViewPotence.Columns[8].Visible = false;//把工程列隐藏
                    clsDropDownList.BindDdl_ModuleId(ddlModuleId_q, getUserPrjId);
				}
				else
				{

				}

				//2、显示无条件的表内容在DATAGRID中
				strSortQxViewPotenceBy = "ViewId Asc";
				BindDg_QxViewPotence();
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
			this.dgQxViewPotence.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgQxViewPotence_ItemCreated);
			this.dgQxViewPotence.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgQxViewPotence_PageIndexChanged);
			this.dgQxViewPotence.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dgQxViewPotence_SortCommand);

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
		private string CombineQxViewPotenceCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.ddlPrjId_q.SelectedValue!="" && this.ddlPrjId_q.SelectedValue!="0")
			{
				strWhereCond += string.Format(" And {0}='{1}'", conQxViewPotence.QxPrjId, this.ddlPrjId_q.SelectedValue);
                
			}
			if (this.ddlModuleId_q.SelectedValue!="" && this.ddlModuleId_q.SelectedValue!="0")
			{
				strWhereCond += " And ModuleId='" + this.ddlModuleId_q.SelectedValue+"'";
			}
			if (this.ddlViewId_q.SelectedValue!="" && this.ddlViewId_q.SelectedValue!="0")
			{
				strWhereCond += " And ViewId='" + this.ddlViewId_q.SelectedValue+"'";
			}
			if (this.ddlPotenceId_q.SelectedValue!="" && this.ddlPotenceId_q.SelectedValue!="0")
			{
				strWhereCond += " And PotenceId='" + this.ddlPotenceId_q.SelectedValue+"'";
			}
			if (this.txtLevel_q.Text.Trim()!="")
			{
				strWhereCond += " And Level like '%" + this.txtLevel_q.Text.Trim()+"%'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QxViewPotence()
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
			string strWhereCond = CombineQxViewPotenceCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxViewPotenceBL.GetDataTable(strWhereCond);
			//3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			///		3.1 首先计算页数；
			///		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgQxViewPotence.PageSize);
			if (intPages==0) 
			{
				this.dgQxViewPotence.CurrentPageIndex = 0;
			}
			else if (this.dgQxViewPotence.CurrentPageIndex > intPages - 1) 
			{
				this.dgQxViewPotence.CurrentPageIndex = intPages - 1;
			}
			//4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortQxViewPotenceBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgQxViewPotence.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgQxViewPotence.DataBind();

			///生成专门用于BINDDG中的跳页相关代码
			//当前记录数
			this.lblQxViewPotenceRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblQxViewPotenceAllPages.Text = this.dgQxViewPotence.PageCount.ToString(); 
			//当前页序数
			this.lblQxViewPotenceCurrentPage.Text=(this.dgQxViewPotence.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtQxViewPotenceJump2Page.Text=(this.dgQxViewPotence.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgQxViewPotence.CurrentPageIndex==0) 
			{
				this.btnQxViewPotencePrevPage.Enabled=false; 
			}
			else 
			{ 
				this.btnQxViewPotencePrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgQxViewPotence.CurrentPageIndex==this.dgQxViewPotence.PageCount-1) 
			{ 
				this.btnQxViewPotenceNextPage.Enabled=false; 
			} 
			else 
			{ 
				this.btnQxViewPotenceNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabQxViewPotenceJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabQxViewPotenceJumpPage.Visible = false; 
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
			this.dgQxViewPotence.CurrentPageIndex=0;
			///把表记录的内容显示在DATAGRID中
			BindDg_QxViewPotence();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void dgQxViewPotence_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgQxViewPotence.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxViewPotence();
		}

		///生成专门用于BINDDG中的跳页相关代码
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//1、组合界面条件串；
			string strWhereCond = CombineQxViewPotenceCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxViewPotenceBL.GetDataTable(strWhereCond);
			ArrayList arrCnName = new ArrayList();
			ArrayList arrColName = new ArrayList();
			string strFileName = "QxViewPotence信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add(convQxViewPotence.PrjName); arrCnName.Add("工程名");
			arrColName.Add(convQxViewPotence.ModuleName); arrCnName.Add("模块名称");
			arrColName.Add(convQxViewPotence.ViewId); arrCnName.Add("界面编号");
			arrColName.Add(convQxViewPotence.ViewName); arrCnName.Add("界面名称");
			arrColName.Add(convQxViewPotence.PotenceId); arrCnName.Add("权限ID");
			arrColName.Add(convQxViewPotence.PotenceName); arrCnName.Add("权限名称");
			arrColName.Add(convQxViewPotence.Level); arrCnName.Add("等级");
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
	
		///生成组合查询条件的代码
		private void dgQxViewPotence_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			///判断是否是新的排序字段
			intIndex = strSortQxViewPotenceBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortQxViewPotenceBy = e.SortExpression + " Asc";
				BindDg_QxViewPotence();
				return ;
			}
			///检查原来是升序
			intIndex = strSortQxViewPotenceBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortQxViewPotenceBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortQxViewPotenceBy = e.SortExpression + " Desc";
			}
			BindDg_QxViewPotence();
		}

		private string strSortQxViewPotenceBy
		{
			get
			{
				string sSortQxViewPotenceBy;
				sSortQxViewPotenceBy = (string)ViewState["SortQxViewPotenceBy"];
				if (sSortQxViewPotenceBy==null) 
				{
					sSortQxViewPotenceBy = "";
				}
				return sSortQxViewPotenceBy;
			}
			set
			{
				string sSortQxViewPotenceBy = value;
				ViewState.Add("SortQxViewPotenceBy", sSortQxViewPotenceBy);
			}
		}
		private void dgQxViewPotence_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			int intIndex;
			if (strSortQxViewPotenceBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgQxViewPotence.Columns.Count;i++)
				{
					strSortEx = this.dgQxViewPotence.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortQxViewPotenceBy.IndexOf(strSortEx);
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortQxViewPotenceBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?"▲":"▼");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		///生成父对象的SESSION相关属性函数
		protected void btnQxViewPotencePrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgQxViewPotence.CurrentPageIndex -=1; 
			this.BindDg_QxViewPotence(); 
		}

		protected void btnQxViewPotenceNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgQxViewPotence.CurrentPageIndex +=1; 
			this.BindDg_QxViewPotence(); 
		}

		protected void btnQxViewPotenceJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtQxViewPotenceJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtQxViewPotenceJump2Page.Text)>0 && 
				int.Parse(this.txtQxViewPotenceJump2Page.Text)-1<this.dgQxViewPotence.PageCount) 
			{ 
				this.dgQxViewPotence.CurrentPageIndex=int.Parse(this.txtQxViewPotenceJump2Page.Text)-1; 
			} 
			this.BindDg_QxViewPotence();
		}

		protected void ddlPrjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string strPrjId = ddlPrjId_q.SelectedValue;
			if (strPrjId != null  || strPrjId != "0")
			{
				clsDropDownList.BindDdl_ModuleId(ddlModuleId_q, strPrjId);
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