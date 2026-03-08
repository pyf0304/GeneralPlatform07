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
using CommFunc4WebForm;
using GeneralPlatform;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmDepartmentInfo_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
	public partial class wfmDepartmentInfo_QUDIBak : System.Web.UI.Page
	{

		///生成有关的变量定义代码
		private const string ViewId4Potence="00260203";		//界面编号


		private void Page_Load(object sender, System.EventArgs e)
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
				wucDepartmentInfo1.SetDdl_UpDepartmentId();
				//wucDepartmentInfo1.SetDdl_SubjectTypeId();
				BindDdl_UpDepartmentId(ddlUpDepartmentId_q);
				BindDdl_SubjectTypeId(ddlSubjectTypeId_q);
				strSortDepartmentInfoBy = "OrderNum Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_DepartmentInfo();
				//3、设置表控件中字控件的ReadOnly属性，
				///   使之只读，因为在修改功能中关键字是不能被修改的。
				wucDepartmentInfo1.SetKeyReadOnly(true);
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
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);
			this.btnUpMove.Click += new System.EventHandler(this.btnUpMove_Click);
			this.btnDownMove.Click += new System.EventHandler(this.btnDownMove_Click);
			this.btnReOrder.Click += new System.EventHandler(this.btnReOrder_Click);
			this.dgDepartmentInfo.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgDepartmentInfo_ItemCreated);
			this.dgDepartmentInfo.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgDepartmentInfo_ItemCommand);
			this.dgDepartmentInfo.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgDepartmentInfo_PageIndexChanged);
			this.dgDepartmentInfo.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dgDepartmentInfo_SortCommand);
			this.btnDepartmentInfoPrevPage.Click += new System.EventHandler(this.btnDepartmentInfoPrevPage_Click);
			this.btnDepartmentInfoNextPage.Click += new System.EventHandler(this.btnDepartmentInfoNextPage_Click);
			this.btnDepartmentInfoJumpPage.Click += new System.EventHandler(this.btnDepartmentInfoJumpPage_Click);
			this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);
			this.Load += new System.EventHandler(this.Page_Load);

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
					//					sPotenceLevel=new TzGeneralPlatformDll.MenuAndPotence(clsSysParaEN.ConfigFileName).Get_PotenceLevel(ViewId4Potence);
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
		private string DepartmentId
		{
			get
			{
				string strDepartmentId;
				strDepartmentId = (string)Session["DepartmentId"];
				if (strDepartmentId==null) 
				{
					strDepartmentId = "";
				}
				return strDepartmentId;
			}
			set
			{
				string strDepartmentId = value;
				Session.Add("DepartmentId", strDepartmentId);
			}
		}
		private string UpDepartmentId
		{
			get
			{
				string strUpDepartmentId;
				strUpDepartmentId = (string)Session["UpDepartmentId"];
				if (strUpDepartmentId==null) 
				{
					strUpDepartmentId = "";
				}
				return strUpDepartmentId;
			}
			set
			{
				string strUpDepartmentId = value;
				Session.Add("UpDepartmentId", strUpDepartmentId);
			}
		}

		///生成组合查询条件的代码
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombineDepartmentInfoCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 ";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtDepartmentId_q.Text.Trim()!="")
			{
				strWhereCond += " And DepartmentId like '%" + this.txtDepartmentId_q.Text.Trim()+"%'";
			}
			if (this.ddlUpDepartmentId_q.SelectedValue!="" && this.ddlUpDepartmentId_q.SelectedValue!="0")
			{
				strWhereCond += " And UpDepartmentId='" + this.ddlUpDepartmentId_q.SelectedValue+"'";
			}
			if (this.txtDepartmentType_q.Text.Trim()!="")
			{
				strWhereCond += " And DepartmentType='" + this.txtDepartmentType_q.Text.Trim()+"'";
			}
			if (this.txtDepartmentName_q.Text.Trim()!="")
			{
				strWhereCond += " And DepartmentName='" + this.txtDepartmentName_q.Text.Trim()+"'";
			}
			if (this.txtDepartMentId4Card_q.Text.Trim()!="")
			{
				strWhereCond += " And DepartMentId4Card like '%" + this.txtDepartMentId4Card_q.Text.Trim()+"%'";
			}

			if (this.ddlSubjectTypeId_q.SelectedValue!="" && this.ddlSubjectTypeId_q.SelectedValue!="0")
			{
				strWhereCond += " And SubjectTypeId='" + this.ddlSubjectTypeId_q.SelectedValue+"'";
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_DepartmentInfo()
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
			string strWhereCond = CombineDepartmentInfoCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxDepartmentInfoBL.GetDataTable(strWhereCond);
			//3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			///		3.1 首先计算页数；
			///		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgDepartmentInfo.PageSize);
			if (intPages==0) 
			{
				this.dgDepartmentInfo.CurrentPageIndex = 0;
			}
			else if (this.dgDepartmentInfo.CurrentPageIndex > intPages - 1) 
			{
				this.dgDepartmentInfo.CurrentPageIndex = intPages - 1;
			}
			//4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortDepartmentInfoBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgDepartmentInfo.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgDepartmentInfo.DataBind();

			///生成专门用于BINDDG中的跳页相关代码
			//当前记录数
			this.lblDepartmentInfoRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblDepartmentInfoAllPages.Text = this.dgDepartmentInfo.PageCount.ToString(); 
			//当前页序数
			this.lblDepartmentInfoCurrentPage.Text=(this.dgDepartmentInfo.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtDepartmentInfoJump2Page.Text=(this.dgDepartmentInfo.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgDepartmentInfo.CurrentPageIndex==0) 
			{
				this.btnDepartmentInfoPrevPage.Enabled=false; 
			}
			else 
			{ 
				this.btnDepartmentInfoPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgDepartmentInfo.CurrentPageIndex==this.dgDepartmentInfo.PageCount-1) 
			{ 
				this.btnDepartmentInfoNextPage.Enabled=false; 
			} 
			else 
			{ 
				this.btnDepartmentInfoNextPage.Enabled=true; 
			} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			if(objDT.Rows.Count>0) 
			{ 
				this.tabDepartmentInfoJumpPage.Visible = true; 
			} 
			else 
			{ 
				this.tabDepartmentInfoJumpPage.Visible = false; 
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
			this.dgDepartmentInfo.CurrentPageIndex=0;
			///把表记录的内容显示在DATAGRID中
			BindDg_DepartmentInfo();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void dgDepartmentInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgDepartmentInfo.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_DepartmentInfo();
		}
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="strDepartmentId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(string strDepartmentId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (strDepartmentId == "") return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsQxDepartmentInfoBL.IsExist(strDepartmentId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + strDepartmentId + "的不存在!";
				Response.Write("<script>alert('" + ss + "')</script>");
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsQxDepartmentInfoEN objDepartmentInfo = new clsQxDepartmentInfoEN(strDepartmentId);
			//4、获取类对象的所有属性；
            clsQxDepartmentInfoBL.GetQxDepartmentInfo(ref objDepartmentInfo);
			Session.Add("objDepartmentInfo", objDepartmentInfo);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromQxDepartmentInfoClass(objDepartmentInfo);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjDepartmentInfo">表实体类对象</param>
		private void GetDataFromQxDepartmentInfoClass(clsQxDepartmentInfoEN pobjDepartmentInfo)
		{
			wucDepartmentInfo1.DepartmentId = pobjDepartmentInfo.DepartmentId;
			wucDepartmentInfo1.UpDepartmentId = pobjDepartmentInfo.UpDepartmentId;
			wucDepartmentInfo1.DepartmentName = pobjDepartmentInfo.DepartmentName;
			//wucDepartmentInfo1.DepartMentId4Card = pobjDepartmentInfo.DepartMentId4Card;
			wucDepartmentInfo1.Memo = pobjDepartmentInfo.Memo;
            //wucDepartmentInfo1.IsAcademy = pobjDepartmentInfo.IsAcademy;
            //wucDepartmentInfo1.IsExam = pobjDepartmentInfo.IsExam;
            //wucDepartmentInfo1.SubjectTypeId = pobjDepartmentInfo.SubjectTypeId;
            wucDepartmentInfo1.OrderNum = pobjDepartmentInfo.OrderNum ?? 0;
			wucDepartmentInfo1.DepartmentAbbrName = pobjDepartmentInfo.DepartmentAbbrName;

		}
		/// <summary>
		/// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
		///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void btnOKUpd_Click(object sender, System.EventArgs e)
		{
			string strMsg;	//专门用于传递信息的变量
			string strResult=" ";	//用于传递在检验对象属性时结果值的变量
			string strCommandText;
			clsQxDepartmentInfoEN objDepartmentInfo;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					wucDepartmentInfo1.SetKeyReadOnly(false);
					btnOKUpd.Text = "确认添加";
					//wucDepartmentInfo1.DepartmentId = clsCommForWebForm.G1etMaxStrId("QxDepartmentInfo","DepartmentId", 4, "");
					break;				
				case "确认添加":
					//这是一个单表的插入的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					//操作步骤：
					//1、检查控件中输入数据类型是否正确
					//2、定义对象并初始化对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					//5、检查传进去的对象属性是否合法
					//6、把数据实体层的数据存贮到数据库中
					//7、把新添的记录内容显示在DATAGRID中
					//1、检查控件中输入数据类型是否正确
                    //if (!wucDepartmentInfo1.IsValid())
                    //{
                    //    lblMsg.Text = "控件中输入数据类型不正确请检查!";
                    //    return ;
                    //}
					//2、定义对象并初始化对象
					//clsQxDepartmentInfoEN objDepartmentInfo;	//定义对象
					objDepartmentInfo = new clsQxDepartmentInfoEN(wucDepartmentInfo1.DepartmentId);	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                    if (clsQxDepartmentInfoBL.IsExist(objDepartmentInfo.DepartmentId))	//判断是否有相同的关键字
					{
						strMsg = "关键字字段已有相同的值";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						return;
					}
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToDepartmentInfoClass(objDepartmentInfo);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    //if (objDepartmentInfo.CheckProperty(ref strResult)==false)
                    //{
                    //    Response.Write("<script>alert('" + strResult + "')</script>");
                    //    return ; 
                    //}
					//6、把数据实体层的数据存贮到数据库中
                    if (clsQxDepartmentInfoBL.AddNewRecordBySql2(objDepartmentInfo) == false) 
					{
						strMsg = "添加不成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "添加记录不成功!";
					}
					else
					{
						strMsg = "添加记录成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "添加记录成功!";
					}
					//7、把新添的记录内容显示在DATAGRID中
					BindDg_DepartmentInfo();
					wucDepartmentInfo1.Clear();		//清空控件中内容
					///恢复<确认添加>变成<添加>
					btnOKUpd.Text = "添加";
					break;
				case "确认修改":
					//这是一个单表的修改的代码，由于逻辑层太简单，
					//就把逻辑层合并到控制层,
					//操作步骤：
					//1、检查控件中输入数据类型是否正确
					//2、把值从界面层传到逻辑层或数据实体层
					//3、检查传进去的对象属性是否合法
					//4、把数据实体层的数据存贮到数据库中
					//5、把修改后的内容显示在DATAGRID中
					//1、检查控件中输入数据类型是否正确
                    //if (!wucDepartmentInfo1.IsValid())
                    //{
                    //    lblMsg.Text = "控件中输入数据类型不正确请检查!";
                    //    return ;
                    //}
					//2、把值从界面层传到逻辑层或数据实体层
					objDepartmentInfo  = (clsQxDepartmentInfoEN) Session["objDepartmentInfo"];
					PutDataToDepartmentInfoClass(objDepartmentInfo);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    //if (objDepartmentInfo.CheckProperty(ref strResult)==false)
                    //{
                    //    Response.Write("<script>alert('" + strResult + "')</script>");
                    //    return ; 
                    //}
					//4、把数据实体层的数据修改同步到数据库中
                    if (clsQxDepartmentInfoBL.UpdateBySql2(objDepartmentInfo) == false) 
					{
						strMsg = "修改记录不成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "修改记录不成功!";
					}
					else
					{
						strMsg = "修改记录成功!";
						Response.Write("<script>alert('" + strMsg + "')</script>");
						lblMsg.Text = "修改记录成功!";
					}
					//5、把修改后的内容显示在DATAGRID中
					BindDg_DepartmentInfo();
					wucDepartmentInfo1.Clear();//添空控件中的内容
					///恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		///生成从界面层到逻辑层的数据传输函数代码
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjDepartmentInfo">数据传输的目的类对象</param>
		private void PutDataToDepartmentInfoClass(clsQxDepartmentInfoEN pobjDepartmentInfo)
		{
			pobjDepartmentInfo.DepartmentId = wucDepartmentInfo1.DepartmentId;
			pobjDepartmentInfo.UpDepartmentId = wucDepartmentInfo1.UpDepartmentId;
            //pobjDepartmentInfo.DepartmentType = wucDepartmentInfo1.DepartmentType;
			pobjDepartmentInfo.DepartmentName = wucDepartmentInfo1.DepartmentName;
			//pobjDepartmentInfo.DepartMentId4Card = wucDepartmentInfo1.DepartMentId4Card;
			//pobjDepartmentInfo.IsAcademy = wucDepartmentInfo1.IsAcademy;
			//pobjDepartmentInfo.IsExam = wucDepartmentInfo1.IsExam;
			//pobjDepartmentInfo.SubjectTypeId = wucDepartmentInfo1.SubjectTypeId;
			pobjDepartmentInfo.OrderNum = wucDepartmentInfo1.OrderNum;
			pobjDepartmentInfo.DepartmentAbbrName = wucDepartmentInfo1.DepartmentAbbrName;
			pobjDepartmentInfo.Memo = wucDepartmentInfo1.Memo;
		}

		private void dgDepartmentInfo_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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
			if (strSortDepartmentInfoBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgDepartmentInfo.Columns.Count;i++)
				{
					strSortEx = this.dgDepartmentInfo.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortDepartmentInfoBy.IndexOf(strSortEx);
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortDepartmentInfoBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?"▲":"▼");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
				}
			}
		}

		private void dgDepartmentInfo_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string strDepartmentId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				strDepartmentId = e.Item.Cells[2].Text;
				switch(strCommandName)
				{
					case "Delete":
						clsQxDepartmentInfoBL.DelRecord(strDepartmentId);
						BindDg_DepartmentInfo();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(strDepartmentId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						btnOKUpd.Enabled = true;
						wucDepartmentInfo1.SetKeyReadOnly(true);
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		public void BindDdl_UpDepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
            string strCondition = string.Format("{0}='1'", conQxDepartmentInfo.InUse);
            System.Data.DataTable objDT = clsQxDepartmentInfoBL.GetDataTable_QxDepartmentInfo(strCondition);
           objDDL.DataValueField="DepartmentId";
			objDDL.DataTextField="DepartmentName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetSubjectTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select SubjectTypeId, SubjectTypeName from SubjectType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_SubjectTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetSubjectTypeId();
			objDDL.DataValueField="SubjectTypeId";
			objDDL.DataTextField="SubjectTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		///生成组合查询条件的代码
		private void dgDepartmentInfo_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			///判断是否是新的排序字段
			intIndex = strSortDepartmentInfoBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortDepartmentInfoBy = e.SortExpression + " Asc";
				BindDg_DepartmentInfo();
				return ;
			}
			///检查原来是升序
			intIndex = strSortDepartmentInfoBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortDepartmentInfoBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortDepartmentInfoBy = e.SortExpression + " Desc";
			}
			BindDg_DepartmentInfo();
		}

		private string strSortDepartmentInfoBy
		{
			get
			{
				string sSortDepartmentInfoBy;
				sSortDepartmentInfoBy = (string)ViewState["SortDepartmentInfoBy"];
				if (sSortDepartmentInfoBy==null) 
				{
					sSortDepartmentInfoBy = "";
				}
				return sSortDepartmentInfoBy;
			}
			set
			{
				string sSortDepartmentInfoBy = value;
				ViewState.Add("SortDepartmentInfoBy", sSortDepartmentInfoBy);
			}
		}

		///生成父对象的SESSION相关属性函数
		protected void btnDepartmentInfoPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgDepartmentInfo.CurrentPageIndex -=1; 
			this.BindDg_DepartmentInfo(); 
		}

		protected void btnDepartmentInfoNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgDepartmentInfo.CurrentPageIndex +=1; 
			this.BindDg_DepartmentInfo(); 
		}

		protected void btnDepartmentInfoJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtDepartmentInfoJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtDepartmentInfoJump2Page.Text)>0 && 
				int.Parse(this.txtDepartmentInfoJump2Page.Text)-1<this.dgDepartmentInfo.PageCount) 
			{ 
				this.dgDepartmentInfo.CurrentPageIndex=int.Parse(this.txtDepartmentInfoJump2Page.Text)-1; 
			} 
			this.BindDg_DepartmentInfo();
		}

		protected void btnUpMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strDepartmentId =GetFirstCheckedItemFromDg(dgDepartmentInfo);
			if (strDepartmentId == null || strDepartmentId.Trim().Length == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg1.Text = "";
			try
			{
				clsQxDepartmentInfoBLEx.AdjustSequenceNumber("UP", strDepartmentId);
				
			}
			
			catch(Exception objException)
			{
				strMsg = objException.Message;
				Response.Write("<script>alert('" + strMsg + "')</script>");
				lblMsg1.Text = strMsg;
				//				ErrMessage = objException.Message;
				//				BackLinkStr = Page.Request.Url.AbsolutePath;	//"/AGC_CSV4/Webform/GenCode/wfmGenViewCode_WebV5.aspx";
				//				Response.Redirect(clsSysParaEN.ErrorPage);
			}
			BindDg_DepartmentInfo();
			clsCommForWebForm.SetCheckedItemForDg(dgDepartmentInfo, 2, strDepartmentId);
		}

		protected void btnDownMove_Click(object sender, System.EventArgs e)
		{
			string strMsg;
			string strDepartmentId =GetFirstCheckedItemFromDg(dgDepartmentInfo);
			if (strDepartmentId == null || strDepartmentId.Trim().Length == 0) 
			{
				lblMsg1.Text = "没有选择记录，请选择一个有效的表记录!";
				return ;
			}
			lblMsg1.Text = "";
			try
			{
				clsQxDepartmentInfoBLEx.AdjustSequenceNumber("DOWN", strDepartmentId);
			}
			catch(Exception objException)
			{
				strMsg = objException.Message;
				Response.Write("<script>alert('" + strMsg + "')</script>");
				lblMsg1.Text = strMsg;
				//				ErrMessage = objException.Message;
				//				BackLinkStr = Page.Request.Url.AbsolutePath;	//"/AGC_CSV4/Webform/GenCode/wfmGenViewCode_WebV5.aspx";
				//				Response.Redirect(clsSysParaEN.ErrorPage);
			}
			BindDg_DepartmentInfo();
			clsCommForWebForm.SetCheckedItemForDg(dgDepartmentInfo, 2, strDepartmentId);
		}

		protected void btnReOrder_Click(object sender, System.EventArgs e)
		{
			clsQxDepartmentInfoBLEx.ReOrder();
			BindDg_DepartmentInfo();
		}

		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//1、组合界面条件串；
			string strWhereCond = CombineDepartmentInfoCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxDepartmentInfoBL.GetDataTable(strWhereCond + " Order by OrderNum ");
			ArrayList arrCnName = new ArrayList();
			ArrayList arrColName = new ArrayList();
			string strFileName = "QxDepartmentInfo信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			//arrColName.Add(convQxDepartmentInfo.ProcessName); arrCnName.Add("过程名称");
			//arrColName.Add(convQxDepartmentInfo.EngPostClassName); arrCnName.Add("聘岗分类名称");
			//arrColName.Add(convQxDepartmentInfo.OrderNum); arrCnName.Add("排序");
			//arrColName.Add(convQxDepartmentInfo.StartPointName); arrCnName.Add("StartPointName");
			//arrColName.Add(convQxDepartmentInfo.EndPointName); arrCnName.Add("EndPointName");
			strFolderName = Server.MapPath("/RSKH") +  "\\TempFiles\\";
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
						return di.Cells[2].Text;
					}
				}
			}
			return "";
		}


        protected void btnUpMove_Click1(object sender, EventArgs e)
        {

        }
}
}