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

using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
//using CommFunc4WebForm;


namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmSetRelaOfViewAndPotence 的摘要说明。
	/// </summary>
	public partial class wfmSetRelaOfViewAndPotence : System.Web.UI.Page
	{

		///生成有关的变量定义代码
		private const string ViewId4Potence="00010405";		//界面编号


		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
			{

				this.Table2.Visible = false;
				///生成权限有关判断权限的代码
				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
				switch (strPotenceLevel)
				{
					case "0":
                        //Response.Redirect("../error.aspx");
						break;
					case "1":
						
						break;
					case "2":

						this.ddlPrjId_q.Enabled =false;
						wucQxViewPotence1.SetPrj_NotEnable();
						
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
				
				wucQxViewPotence1.SetDdl_QxPrjId();
				wucQxViewPotence1.QxPrjId =  clsCommonSession.UserPrjId;
				wucQxViewPotence1.SetDdl_PotenceId();
				wucQxViewPotence1.SetDdl_ViewId();


                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);
				this.ddlPrjId_q.SelectedValue = clsCommonSession.UserPrjId;
				BindDdl_ViewId(ddlViewId_q);

				BindDdl_PotenceId(ddlPotenceId_q);
				strSortQxViewPotenceBy = "mId Asc";
				//2、显示无条件的表内容在DATAGRID中
				BindDg_QxViewPotence();
				//3、设置表控件中字控件的ReadOnly属性，
				///   使之只读，因为在修改功能中关键字是不能被修改的。
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
			this.dgQxViewPotence.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgQxViewPotence_ItemCommand);
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
					sPotenceLevel=new MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
					//sPotenceLevel = "9";
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
		///private clsQxUsers objUser
		///{
		///get
		///{
		///clsQxUsers pobjUser;
		///pobjUser = (clsQxUsers)Session["objUser"];
		///if (pobjUser==null) 
		///{
		///pobjUser = null;
		///}
		///return pobjUser;
		///}
		///set
		///{
		///clsQxUsers pobjUser = value;
		///Session.Add("objUser", pobjUser);
		///}
		///}


		///生成专门用于BINDDG中的跳页相关代码

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
			if (this.txtmId_q.Text.Trim()!="")
			{
				strWhereCond += " And mId='" + this.txtmId_q.Text.Trim()+"'";
			}
			if (this.ddlViewId_q.SelectedValue!="" && this.ddlViewId_q.SelectedValue!="0")
			{
				strWhereCond += " And ViewId='" + this.ddlViewId_q.SelectedValue+"'";
			}
			if (this.ddlPrjId_q.SelectedValue!="" && this.ddlPrjId_q.SelectedValue!="0")
			{
				strWhereCond += " And QxPrjId='" + this.ddlPrjId_q.SelectedValue+"'";
			}
			if (this.ddlPotenceId_q.SelectedValue!="" && this.ddlPotenceId_q.SelectedValue!="0")
			{
				strWhereCond += " And PotenceId='" + this.ddlPotenceId_q.SelectedValue+"'";
			}
			if (this.txtLevel_q.Text.Trim()!="")
			{
				strWhereCond += " And Level='" + this.txtLevel_q.Text.Trim()+"'";
			}
			if (this.txtMemo_q.Text.Trim()!="")
			{
				strWhereCond += " And Memo like '%" + this.txtMemo_q.Text.Trim()+"%'";
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
		/// <summary>
		/// 函数功能：把以该关键字的记录内容显示在界面上，
		///　　　     在这里是把值传到表控件中
		/// </summary>
		/// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
		private void ShowData(long lngmId)
		{
			//操作步骤：
			//1、检查关键字是否为空；
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			//3、用提供的关键字初始化一个类对象；
			//4、获取类对象的所有属性；
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中

			//1、检查关键字是否为空；
			if (lngmId == 0) return ;		//如果关键字为空就返回退出
			//2、检查该关键字的记录是否存在，如果不存在就返回不显示；
			if (clsQxViewPotenceBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
			{
				string ss = "关键字为：" + lngmId + "的不存在!";
				Response.Write("<script>alert('" + ss + "')</script>");
				return ;
			}
			//3、用提供的关键字初始化一个类对象；
			clsQxViewPotenceEN objQxViewPotence = new clsQxViewPotenceEN(lngmId);
            //4、获取类对象的所有属性；
            clsQxViewPotenceBL .GetQxViewPotence(ref objQxViewPotence);
			Session.Add("objQxViewPotence", objQxViewPotence);
			//5、把该对象的所有属性显示在界面上，在这里显示在表控件中
			GetDataFromQxViewPotenceClass(objQxViewPotence);
		}
		///生成从逻辑层的数据传输到界面层的函数代码
		/// <summary>
		/// 函数功能：把类对象的属性内容显示到界面上
		///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
		///      如果在设置数据库时，就应该一级字段在前，二级字段在后
		/// </summary>
		/// <param name="pobjQxViewPotence">表实体类对象</param>
		private void GetDataFromQxViewPotenceClass(clsQxViewPotenceEN pobjQxViewPotence)
		{
			wucQxViewPotence1.ViewId = pobjQxViewPotence.ViewId;
			wucQxViewPotence1.QxPrjId = pobjQxViewPotence.QxPrjId;
			wucQxViewPotence1.PotenceId = pobjQxViewPotence.PotenceId;
			wucQxViewPotence1.Level = pobjQxViewPotence.Level;
			wucQxViewPotence1.Memo = pobjQxViewPotence.Memo;
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
			clsQxViewPotenceEN objQxViewPotence;
			Button btnTemp;
			btnTemp = (Button) sender;
			strCommandText = btnTemp.Text;
			switch(strCommandText)
			{
				case "添加":
					btnOKUpd.Text = "确认添加";
                    //wucQxViewPotence1.mId = clsQxViewPotenceBL.GetMaxStrId_S();
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
					if (!wucQxViewPotence1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、定义对象并初始化对象
					//clsQxViewPotenceEN objQxViewPotence;	//定义对象
					objQxViewPotence = new clsQxViewPotenceEN();	//初始化新对象
					//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
					//4、把值从界面层传到逻辑层或数据实体层
					PutDataToQxViewPotenceClass(objQxViewPotence);		//把界面的值传到
					//5、检查传进去的对象属性是否合法
                    try
                    {
                        clsQxViewPotenceBL .CheckPropertyNew(objQxViewPotence);
                    }
                    catch(Exception objException)
					{
                        Response.Write("<script>alert('" + objException.Message + "')</script>");
						return ; 
					}
					//6、把数据实体层的数据存贮到数据库中
					if (clsQxViewPotenceBL .AddNewRecordBySql2(objQxViewPotence) == false) 
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
					BindDg_QxViewPotence();
					wucQxViewPotence1.Clear();		//清空控件中内容
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
					if (!wucQxViewPotence1.IsValid())
					{
						lblMsg.Text = "控件中输入数据类型不正确请检查!";
						return ;
					}
					//2、把值从界面层传到逻辑层或数据实体层
					objQxViewPotence  = (clsQxViewPotenceEN) Session["objQxViewPotence"];
					PutDataToQxViewPotenceClass(objQxViewPotence);		//把界面的值传到
					//3、检查传进去的对象属性是否合法
                    try
                    {
                        clsQxViewPotenceBL .CheckPropertyNew(objQxViewPotence);
                    }
                    catch (Exception objException)
                    {
                        Response.Write("<script>alert('" + objException.Message + "')</script>");
                        return;
                    }
					//4、把数据实体层的数据修改同步到数据库中
					if (clsQxViewPotenceBL .UpdateBySql2(objQxViewPotence) == false) 
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
					BindDg_QxViewPotence();
					wucQxViewPotence1.Clear();//添空控件中的内容
					///恢复<确认修改>变成<添加>
					btnOKUpd.Text = "添加";
					break;
			}
		}
		///生成从界面层到逻辑层的数据传输函数代码
		/// <summary>
		/// 函数功能：把界面上的属性数据传到类对象中
		/// </summary>
		/// <param name="pobjQxViewPotence">数据传输的目的类对象</param>
		private void PutDataToQxViewPotenceClass(clsQxViewPotenceEN pobjQxViewPotence)
		{
			pobjQxViewPotence.ViewId = wucQxViewPotence1.ViewId;
			pobjQxViewPotence.QxPrjId = wucQxViewPotence1.QxPrjId;
			pobjQxViewPotence.PotenceId = wucQxViewPotence1.PotenceId;
			pobjQxViewPotence.Level = wucQxViewPotence1.Level;
			pobjQxViewPotence.Memo = wucQxViewPotence1.Memo;
		}

		private void dgQxViewPotence_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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

		private void dgQxViewPotence_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			long lngmId;
			string strCommandName;
			if (e.Item.ItemType == ListItemType.Item ||
				e.Item.ItemType == ListItemType.SelectedItem ||
				e.Item.ItemType == ListItemType.AlternatingItem ||
				e.Item.ItemType == ListItemType.EditItem)
			{
				strCommandName = ((LinkButton)e.CommandSource).CommandName;
				lngmId = long.Parse(e.Item.Cells[0].Text);
				switch(strCommandName)
				{
					case "Delete":
						clsQxViewPotenceBL.DelRecord(lngmId);
						BindDg_QxViewPotence();
						break;
						// Add other cases here, if there are multiple ButtonColumns in 
						// the DataGrid control.
					case "Update":
						//操作步骤：（总共2步）
						//1、显示该关键字记录的内容在界面上；
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；

						//1、显示该关键字记录的内容在界面上；
						ShowData(lngmId);
						//2、清空提示信息的内容,同时使<确定修改>按钮可用；
						btnOKUpd.Enabled = true;
						btnOKUpd.Text = "确认修改";
						lblMsg.Text = "";
						break;

					default:
						// Do nothing.
						break;
				}
			}
		}
		///生成从界面层到逻辑层的数据传输函数代码
		public System.Data.DataTable GetViewId(string strPrjId)
		{
			//获取某学院所有专业信息
			string strSQL = string.Format("select ViewId, ViewName from {0} where {1} ='{2}'",
                clsQxViewInfoEN._CurrTabName, conQxViewInfo.QxPrjId, strPrjId);
			clsSpecSQL mySql=new clsSpecSQL();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetViewId(this.ddlPrjId_q.SelectedValue);
			objDDL.DataValueField="ViewId";
			objDDL.DataTextField="ViewName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		
		///生成从界面层到逻辑层的数据传输函数代码
		public System.Data.DataTable GetPotenceId(string strPrjId)
		{
			//获取某学院所有专业信息
			string strSQL = string.Format("select PotenceId, PotenceName from {0} where {1} ='{2}'",
                clsQxPrjPotenceEN._CurrTabName, conQxPrjPotence.QxPrjId, strPrjId);
			clsSpecSQL mySql=new clsSpecSQL();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetPotenceId(this.ddlPrjId_q.SelectedValue);
			objDDL.DataValueField="PotenceId";
			objDDL.DataTextField="PotenceName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
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
			this.BindDdl_ViewId(this.ddlViewId_q);
			this.BindDdl_PotenceId(this.ddlPotenceId_q);
		}


	}
}
