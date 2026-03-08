///生成查询，修改，删除，添加记录的控制层代码

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
using System.Collections.Generic;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;

using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmUsers_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmUsers_QUDI : System.Web.UI.Page
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

				//1、为下拉框设置数据源，绑定列表数据
				wucUsers1.SetDdl_DepartmentId();
				wucUsers1.SetDdl_UserStateId();
		clsDropDownList.BindDdl_DepartmentId4InUse(ddlDepartmentId_q);
                clsQxUserStateBL.BindDdl_UserStateId(ddlUserStateId_q);
                clsQxProjectsBL.BindDdl_QxPrjIdCache(ddlPrjId_q);

				strSortUsersBy = "UserId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_QxUsers();
				//3、设置表控件中字控件的ReadOnly属性，
				///   使之只读，因为在修改功能中关键字是不能被修改的。
				wucUsers1.SetKeyReadOnly(true);
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
			this.dgUsers.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgUsers_ItemCreated);
			this.dgUsers.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgUsers_ItemCommand);
			this.dgUsers.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgUsers_PageIndexChanged);
			this.dgUsers.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dgUsers_SortCommand);

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
		///private clsQxUsersEN objUser
		///{
		///get
		///{
		///clsQxUsersEN pobjUser;
		///pobjUser = (clsQxUsersEN)Session["objUser"];
		///if (pobjUser==null) 
		///{
		///pobjUser = null;
		///}
		///return pobjUser;
		///}
		///set
		///{
		///clsQxUsersEN pobjUser = value;
		///Session.Add("objUser", pobjUser);
		///}
		///}


		///生成专门用于BINDDG中的跳页相关代码


		///生成错误信息的Session属性
		private string ErrMessage
		{
			get
			{
				string strErrMessage;
				strErrMessage = (string)Session["ErrMessage"];
				if (strErrMessage==null) 
				{
					strErrMessage = "";
				}
				return strErrMessage;
			}
			set
			{
				string strErrMessage = value;
				Session.Add("ErrMessage", strErrMessage);
			}
		}


		///生成返回链接串的Session属性
		private string BackLinkStr
		{
			get
			{
				string strBackLinkStr;
				strBackLinkStr = (string)Session["BackLinkStr"];
				if (strBackLinkStr==null) 
				{
					strBackLinkStr = "";
				}
				return strBackLinkStr;
			}
			set
			{
				string strBackLinkStr = value;
				Session.Add("BackLinkStr", strBackLinkStr);
			}
		}

		///生成组合查询条件的代码
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineUsersCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtUserId_q.Text.Trim()!="")
			{
				strWhereCond += " And UserId like '%" + this.txtUserId_q.Text.Trim()+"%'";
			}
			if (this.txtUserName_q.Text.Trim()!="")
			{
				strWhereCond += " And UserName like '%" + this.txtUserName_q.Text.Trim()+"%'";
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
				strWhereCond += string.Format(" And UserId in (Select UserId from {0} where {1}='{2}')",
                    clsvQxUserRoleRelationEN._CurrTabName,
                    convQxUserRoleRelation.QxPrjId,
                    this.ddlPrjId_q.SelectedValue);
			}
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
			string strWhereCond = CombineUsersCondion();
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
			objDV.Sort = strSortUsersBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgUsers.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUsers.DataBind();

			///生成专门用于BINDDG中的跳页相关代码
			//当前记录数
			this.lblUsersRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblUsersAllPages.Text = this.dgUsers.PageCount.ToString(); 
			//当前页序数
			this.lblUsersCurrentPage.Text=(this.dgUsers.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtUsersJump2Page.Text=(this.dgUsers.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgUsers.CurrentPageIndex==0) 
			{
				this.btnUsersPrevPage.Enabled=false; 
			}
			else 
			{ 
				this.btnUsersPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgUsers.CurrentPageIndex==this.dgUsers.PageCount-1) 
			{ 
				this.btnUsersNextPage.Enabled=false; 
			} 
			else 
			{ 
				this.btnUsersNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabUsersJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabUsersJumpPage.Visible = false; 
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
			this.dgUsers.CurrentPageIndex=0;
			///把表记录的内容显示在DATAGRID中
			BindDg_QxUsers();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
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
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strUserId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strUserId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strUserId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsQxUsersBL.IsExist(strUserId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strUserId + "的不存在!";
				Response.Write("<script>alert('" + ss + "')</script>");
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsQxUsersEN objUsersEN = clsQxUsersBL.GetObjByUserIdCache(strUserId);
			//4、获取类对象的所有属性；
		
			Session.Add("objUsersEN", objUsersEN);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromQxUsersClass(objUsersEN);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjUsers">表实体类对象</param>
		private void GetDataFromQxUsersClass(clsQxUsersEN pobjUsers)
		{
			wucUsers1.UserId = pobjUsers.UserId;
			wucUsers1.UserName = pobjUsers.UserName;
			wucUsers1.DepartmentId = pobjUsers.DepartmentId;
			wucUsers1.UserStateId = pobjUsers.UserStateId;
			wucUsers1.Password = pobjUsers.Password;
			wucUsers1.Memo = pobjUsers.Memo;
		}
		/// <summary>
		/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
		///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strCommandText;
			clsQxUsersEN objUsersEN;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					AddUsersRecord();
					break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					AddUsersRecordSave();
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					objUsersEN  = (clsQxUsersEN) Session["objUsersEN"];
					UpdateUsersRecordSave(objUsersEN);
					break;
			}
		}
		///生成从界面层到逻辑层的数据传输函数代码
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjUsers">数据传输的目的类对象</param>
		private void PutDataToUsersClass(clsQxUsersEN pobjUsers)
		{
			pobjUsers.UserId = wucUsers1.UserId;
			pobjUsers.UserName = wucUsers1.UserName;
			pobjUsers.DepartmentId = wucUsers1.DepartmentId;
			pobjUsers.UserStateId = wucUsers1.UserStateId;
			pobjUsers.Password = wucUsers1.Password;
			pobjUsers.Memo = wucUsers1.Memo;
		}

		private void dgUsers_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				System.Web.UI.WebControls.LinkButton myDeleteButton;
				myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Item.FindControl("lbnDelete");
				myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Item.ItemIndex+1).ToString() + " 行吗？');");
			}
			int intIndex;
			if (strSortUsersBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgUsers.Columns.Count;i++)
				{
					strSortEx = this.dgUsers.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortUsersBy.IndexOf(strSortEx);
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortUsersBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?"▲":"▼");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		private void dgUsers_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strUserId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strUserId = e.Item.Cells[1].Text;
				switch(strCommandName)
				{
					case "Delete":
						DeleteUsersRecord(strUserId);
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						UpdateUsersRecord(strUserId);
						break;

					default:
						// Do nothing.
						break;
				}
			}
			if (e.Item.ItemType == ListItemType.Header)
			{
				System.Web.UI.WebControls.LinkButton lbSelAll;
				lbSelAll = (LinkButton)e.CommandSource;
				if (lbSelAll.CommandName != "lbSelAll")
				{
					return ;
				}
				if (lbSelAll.Text == "全选")
				{
					Set_DataGridAllChecked(dgUsers, true);
					lbSelAll.Text = "不选";
				}
				else if (lbSelAll.Text == "不选")
				{
					Set_DataGridAllChecked(dgUsers, false);
					lbSelAll.Text = "全选";
				}
			}
		}
		private void Set_DataGridAllChecked(DataGrid objDg, bool IsSelected)
		{
			if(objDg.Items.Count==0 )
			{
				return;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox cb=(CheckBox)di.FindControl("chkCheckRec");
					if(cb!=null )
					{
						cb.Checked=IsSelected;
					}
				}
			}
		}
		private string GetFirstCheckedItemFromDg(DataGrid objDg)
		{
			if(objDg.Items.Count==0)
			{
				return null;
			}
			else
			{
				foreach(DataGridItem di in objDg.Items)
				{
					CheckBox chkCheckRec=(CheckBox)di.FindControl("chkCheckRec");
					if(chkCheckRec!=null && chkCheckRec.Checked)
					{
						return di.Cells[1].Text;
					}
				}
			}
			return "";
		}
		private ArrayList GetAllCheckedItemFromDg(System.Web.UI.WebControls.DataGrid objDg, string strChkName)
		{
			ArrayList arr=new ArrayList();
			if(objDg.Items.Count==0)
			{
				return arr;
			}
			else
			{
				foreach(DataGridItem li in objDg.Items)
				{
					CheckBox  cb=(CheckBox)li.Cells[0].FindControl(strChkName);
					if(cb!=null && cb.Checked)
					{
						arr.Add(li.Cells[1].Text);
					}
				}
				return arr;
			}
		}

		///生成专门用于BINDDG中的跳页相关代码
		//当前记录数
		protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
		{
			AddUsersRecord();
		}

		///生成专门用于BINDDG中的跳页相关代码
		//当前记录数
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//1、组合界面条件串；
			string strWhereCond = CombineUsersCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxUsersBL.GetDataTable(strWhereCond);
			ArrayList arrCnName = new ArrayList();
			ArrayList arrColName = new ArrayList();
			string strFileName = "Users信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			arrColName.Add(convQxUsers.UserId); arrCnName.Add("用户ID");
			arrColName.Add(convQxUsers.UserName); arrCnName.Add("用户名");
			arrColName.Add(convQxUsers.DepartmentId); arrCnName.Add("部门Id");
			arrColName.Add(convQxUsers.DepartmentName); arrCnName.Add("部门名");
			arrColName.Add(convQxUsers.UserStateName); arrCnName.Add("用户状态名");
			arrColName.Add(convQxUsers.Memo); arrCnName.Add("备注");
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

		///生成专门用于BINDDG中的跳页相关代码
		//当前记录数
		protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
		{
			List<string>  arrUserId =clsCommForWebForm. GetAllCheckedItemFromDg2(dgUsers, "chkCheckRec");
			if (arrUserId == null || arrUserId.Count == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			clsQxUsersBL.DelQxUserss(arrUserId);
			BindDg_QxUsers();
		}

		///生成专门用于BINDDG中的跳页相关代码
		//当前记录数
		protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
		{
			string strUserId =GetFirstCheckedItemFromDg(dgUsers);
			if (strUserId == null || strUserId.Trim().Length == 0) 
			{
				lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg.Text = "";
			//1、显示该关键字记录的内容在界面上；
			///当前所选记录
			UpdateUsersRecord(strUserId);
		}
       
		///生成组合查询条件的代码
		private void dgUsers_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			///判断是否是新的排序字段
			intIndex = strSortUsersBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortUsersBy = e.SortExpression + " Asc";
				BindDg_QxUsers();
				return ;
			}
			///检查原来是升序
			intIndex = strSortUsersBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortUsersBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortUsersBy = e.SortExpression + " Desc";
			}
			BindDg_QxUsers();
		}

		private string strSortUsersBy
		{
			get
			{
				string sSortUsersBy;
				sSortUsersBy = (string)ViewState["SortUsersBy"];
				if (sSortUsersBy==null) 
				{
					sSortUsersBy = "";
				}
				return sSortUsersBy;
			}
			set
			{
				string sSortUsersBy = value;
				ViewState.Add("SortUsersBy", sSortUsersBy);
			}
		}

		///生成父对象的SESSION相关属性函数
		protected void btnUsersPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgUsers.CurrentPageIndex -=1; 
			this.BindDg_QxUsers(); 
		}

		protected void btnUsersNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgUsers.CurrentPageIndex +=1; 
			this.BindDg_QxUsers(); 
		}

		protected void btnUsersJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtUsersJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtUsersJump2Page.Text)>0 && 
				int.Parse(this.txtUsersJump2Page.Text)-1<this.dgUsers.PageCount) 
			{ 
				this.dgUsers.CurrentPageIndex=int.Parse(this.txtUsersJump2Page.Text)-1; 
			} 
			this.BindDg_QxUsers();
		}

		///生成的插入记录准备过程代码for C#
		private void AddUsersRecord()
		{
			wucUsers1.SetKeyReadOnly(false);
			btnOKUpd.Text = "确认添加";
			//wucUsers1.UserId = clsCommForWebForm.G1etMaxStrId("Users","UserId", 18, "");
			DispEditUsersRegion();
		}
		///插入记录存盘过程代码for C#
		private void AddUsersRecordSave()
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			clsQxUsersEN objUsersEN;
			//1、检查控件中输入数据类型是否正确
			if (!wucUsers1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsQxUsersEN objUsersEN;	//定义对象
			objUsersEN = new clsQxUsersEN(wucUsers1.UserId);	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsQxUsersBL.IsExist(objUsersEN.UserId))	//判断是否有相同的关键字
			{
				strMsg = "关键字字段已有相同的值";
				Response.Write("<script>alert('" + strMsg + "')</script>");
				return;
			}
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToUsersClass(objUsersEN);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
				clsQxUsersBL.CheckPropertyNew(objUsersEN);
				//6、把数据实体层的数据存贮到数据库中
				clsQxUsersBL.AddNewRecordBySql2(objUsersEN);
                if (wucUsers1.IsAsDefaultPrjUser == true)
                {
                    string strDefaPrjId = clsQxProjectsBLEx.GetDefaultPrj();
                    if (string.IsNullOrEmpty(strDefaPrjId) == false)
                    {
                        clsQxPrjUserRelationBLEx.AddRecord(strDefaPrjId, objUsersEN.UserId);
                    }
                }
			}
			catch(Exception objException)
			{
				strMsg = "添加记录不成功!" + objException.Message;
				Response.Write("<script>alert('" + strMsg + "')</script>");
				lblMsg.Text = strMsg;
				return;
			}
			strMsg = "添加记录成功!";
			Response.Write("<script>alert('" + strMsg + "')</script>");
			lblMsg.Text = "添加记录成功!";
			//7、把新添的记录内容显示在DATAGRID中
			wucUsers1.Clear();		//清空控件中内容
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
			BindDg_QxUsers();
			DispUsersListRegion();
		}
		///插入记录存盘过程代码for C#
		private void AddUsersRecordSaveV5()
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、定义对象并初始化对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			//4、把值从界面层传到逻辑层或数据实体层
			//5、检查传进去的对象属性是否合法
			//6、把数据实体层的数据存贮到数据库中
			//7、把新添的记录内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			clsQxUsersEN objUsersEN;
			//1、检查控件中输入数据类型是否正确
			if (!wucUsers1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、定义对象并初始化对象
			//clsQxUsersEN objUsersEN;	//定义对象
			objUsersEN = new clsQxUsersEN(wucUsers1.UserId);	//初始化新对象
			//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
			if (clsQxUsersBL.IsExist(objUsersEN.UserId))	//判断是否有相同的关键字
			{
				strMsg = "关键字字段已有相同的值";
				Response.Write("<script>alert('" + strMsg + "')</script>");
				return;
			}
			//4、把值从界面层传到逻辑层或数据实体层
			PutDataToUsersClass(objUsersEN);		//把界面的值传到
			//5、检查传进去的对象属性是否合法
			try
			{
				clsQxUsersBL.CheckPropertyNew(objUsersEN);
				//6、把数据实体层的数据存贮到数据库中
				clsQxUsersBL.AddNewRecordBySql2(objUsersEN);
			}
			catch(Exception objException)
			{
				ErrMessage = "添加记录不成功!" + objException.Message;
				BackLinkStr = Page.Request.Url.AbsolutePath;
				Response.Redirect(clsSysParaEN.ErrorPage);
			}
			strMsg = "添加记录成功!";
			Response.Write("<script>alert('" + strMsg + "')</script>");
			lblMsg.Text = "添加记录成功!";
			//7、把新添的记录内容显示在DATAGRID中
			wucUsers1.Clear();		//清空控件中内容
			BindDg_QxUsers();
			DispUsersListRegion();
			///恢复<确认添加>变成<添加>
			btnOKUpd.Text = "添加";
		}
		///生成修改记录准备过程代码 for C#
		private void UpdateUsersRecord(string strUserId)
		{
			//操作步骤：（总共2步）
			//1、显示该关键字记录的内容在界面上；
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；

			//1、显示该关键字记录的内容在界面上；
			ShowData(strUserId);
			//2、清空提示信息的内容,同时使<确定修改>按钮可用；
			btnOKUpd.Enabled = true;
			wucUsers1.SetKeyReadOnly(true);
			btnOKUpd.Text = "确认修改";
			lblMsg.Text = "";
			DispEditUsersRegion();
		}
		///修改存盘准备过程代码 for C#
		private void UpdateUsersRecordSave(clsQxUsersEN objUsersEN)
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、把值从界面层传到逻辑层或数据实体层
			//3、检查传进去的对象属性是否合法
			//4、把数据实体层的数据存贮到数据库中
			//5、把修改后的内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			//1、检查控件中输入数据类型是否正确
			if (!wucUsers1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToUsersClass(objUsersEN);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				clsQxUsersBL.CheckPropertyNew(objUsersEN);
				//6、把数据实体层的数据存贮到数据库中
                clsQxUsersBL.UpdateBySql2(objUsersEN);
			}
			catch(Exception objException)
			{
				strMsg = "修改记录不成功!" + objException.Message;
				Response.Write("<script>alert('" + strMsg + "')</script>");
				lblMsg.Text = strMsg;
				return ; 
			}
			strMsg = "修改记录成功!";
			Response.Write("<script>alert('" + strMsg + "')</script>");
			lblMsg.Text = "修改记录成功!";
			wucUsers1.Clear();//添空控件中的内容
			///恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			//5、把修改后的内容显示在DATAGRID中
			BindDg_QxUsers();
			DispUsersListRegion();
		}
		///修改存盘准备过程代码 for C#
		private void UpdateUsersRecordSaveV5(clsQxUsersEN objUsersEN)
		{
			//操作步骤：
			//1、检查控件中输入数据类型是否正确
			//2、把值从界面层传到逻辑层或数据实体层
			//3、检查传进去的对象属性是否合法
			//4、把数据实体层的数据存贮到数据库中
			//5、把修改后的内容显示在DATAGRID中
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			//1、检查控件中输入数据类型是否正确
			if (!wucUsers1.IsValid(ref strResult))
			{
				lblMsg.Text = "控件中输入数据类型不正确请检查!";
				return ;
			}
			//2、把值从界面层传到逻辑层或数据实体层
			PutDataToUsersClass(objUsersEN);		//把界面的值传到
			//3、检查传进去的对象属性是否合法
			try
			{
				clsQxUsersBL.CheckPropertyNew(objUsersEN);
				//6、把数据实体层的数据存贮到数据库中
				 clsQxUsersBL.UpdateBySql2(objUsersEN);
			}
			catch(Exception objException)
			{
				ErrMessage = "修改记录不成功!" + objException.Message;
				BackLinkStr = Page.Request.Url.AbsolutePath;
				Response.Redirect(clsSysParaEN.ErrorPage);
			}
			strMsg = "修改记录成功!";
			Response.Write("<script>alert('" + strMsg + "')</script>");
			lblMsg.Text = "修改记录成功!";
			wucUsers1.Clear();//添空控件中的内容
			///恢复<确认修改>变成<添加>
			btnOKUpd.Text = "添加";
			//5、把修改后的内容显示在DATAGRID中
			BindDg_QxUsers();
			DispUsersListRegion();
		}
		///删除记录过程代码for C#
		private void DeleteUsersRecord(string strUserId)
		{
			clsQxUsersBL.DelRecord(strUserId);
			BindDg_QxUsers();
		}
		private void DispEditUsersRegion()
		{
			tabUsersDataGrid.Visible = false;
			tabEditUsersRegion.Visible = true;
		}
		private void DispUsersListRegion()
		{
			tabUsersDataGrid.Visible = true;
			tabEditUsersRegion.Visible = false;
		}
		///生成专门用于BINDDG中的跳页相关代码
		//当前记录数
		protected void lbDispUsersList_Click(object sender, System.EventArgs e)
		{
			DispUsersListRegion();
		}

	}
}