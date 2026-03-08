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
using com.taishsoft.commdb;
using EduHigh;
using GeneralPlatform.Entity;
//using GeneralPlatform.Entity;
//using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmPrjModule_QUDI 的摘要说明。
	/// </summary>
	public partial class wfmPrjModule_QUDI : System.Web.UI.Page
	{

		///生成有关的变量定义代码
		private const string ViewId4Potence="00260203";		//界面编号


		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            //clsPubVar.CheckUserSession();
            clsCommonSession.UserId = "lyl";
			// 在此处放置用户代码以初始化页面
			if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
			{
                clsCommonSession.RoleId = clsPubFun.GetQxRoleList(clsCommonSession.UserId);
                string strRoleIds = clsCommonSession.RoleId;
                vsPotenceFlag = clsPubFun.ValidPotenceMode4(this, strRoleIds, "单位管理维护");
                if (string.IsNullOrEmpty(vsPotenceFlag) == false)
                {
                    vsPotenceName = "单位管理维护";
                }
                else
                {
                    vsPotenceFlag = clsPubFun.ValidPotenceMode4(this, strRoleIds, "单位管理查看");
                    if (string.IsNullOrEmpty(vsPotenceFlag) == false)
                    {
                        vsPotenceName = "单位管理查看";
                    }
                }
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
				//wucPrjModule1.SetDdl_QxPrjId();
				//BindDdl_QxPrjId(ddlPrjId_q);
				//strSortPrjModuleBy = "ModuleId Asc";



				//2、显示无条件的表内容在DATAGRID中
				//BindDg_QxPrjModule();
				//3、设置表控件中字控件的ReadOnly属性，
				///   使之只读，因为在修改功能中关键字是不能被修改的。
				wucPrjModule1.SetKeyReadOnly(true);
			}
		}
        /// <summary>
        /// 权限名称
        /// </summary>
        public string vsPotenceName
        {
            get
            {
                if (ViewState["PotenceName"] != null)
                {
                    return ViewState["PotenceName"].ToString().Trim();
                }
                return "";

            }
            set
            {
                ViewState["PotenceName"] = value;
            }
        }

        /// <summary>
        /// 权限标志
        /// </summary>
        public string vsPotenceFlag
        {
            get
            {
                if (ViewState["PotenceFlag"] != null)
                {
                    return ViewState["PotenceFlag"].ToString().Trim();
                }
                return "";

            }
            set
            {
                ViewState["PotenceFlag"] = value;
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


		


		///生成专门用于BINDDG中的跳页相关代码

		///生成组合查询条件的代码
		/// <summary>
		/// 把所有的查询控件内容组合成一个条件串
		/// </summary>
		/// <returns>条件串(strWhereCond)</returns>
		private string CombinePrjModuleCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
			string strWhereCond=" 1=1 ";
            switch(vsPotenceFlag)
            {
                case "全局":
                    break;
                case "单位":
                    //strWhereCond += string.Format(" And {0} = '{0}'", clsQxPrjModuleEN.con_DepartmentId, clsCommonSession.DepartmentId);
                    break;
                case "个人":
                    break;
                default:
                    break;

            }

			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
			if (this.txtModuleId_q.Text.Trim()!="")
			{
				strWhereCond += " And ModuleId like '%" + this.txtModuleId_q.Text.Trim()+"%'";
			}
			if (this.txtModuleName_q.Text.Trim()!="")
			{
				strWhereCond += " And ModuleName like '%" + this.txtModuleName_q.Text.Trim()+"%'";
			}
			if (this.ddlPrjId_q.SelectedValue!="" && this.ddlPrjId_q.SelectedValue!="0")
			{
				strWhereCond += string.Format(" And {0}='{1}'", conQxPrjModule.QxPrjId, this.ddlPrjId_q.SelectedValue);
                
			}
			return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QxPrjModule()
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
			string strWhereCond = CombinePrjModuleCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;// clsQxPrjModuleBL.GetDataTable_QxPrjModuleV(strWhereCond);
			//3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			///		3.1 首先计算页数；
			///		3.2 如果当前页大于页数就为最后一页
			int intPages = CalcPages(objDT.Rows.Count, this.dgPrjModule.PageSize);
			if (intPages==0) 
			{
				this.dgPrjModule.CurrentPageIndex = 0;
			}
			else if (this.dgPrjModule.CurrentPageIndex > intPages - 1) 
			{
				this.dgPrjModule.CurrentPageIndex = intPages - 1;
			}
			//4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			//objDV.Sort = strSortPrjModuleBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgPrjModule.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgPrjModule.DataBind();

			///生成专门用于BINDDG中的跳页相关代码
			////当前记录数
			//this.lblPrjModuleRecCount.Text = objDT.Rows.Count.ToString(); 
			////当前页数
			//this.lblPrjModuleAllPages.Text = this.dgPrjModule.PageCount.ToString(); 
			////当前页序数
			//this.lblPrjModuleCurrentPage.Text=(this.dgPrjModule.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			//this.txtPrjModuleJump2Page.Text=(this.dgPrjModule.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			//if(this.dgPrjModule.CurrentPageIndex==0) 
			//{
			//	this.btnPrjModulePrevPage.Enabled=false; 
			//}
			//else 
			//{ 
			//	this.btnPrjModulePrevPage.Enabled=true; 
			//} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			//if(this.dgPrjModule.CurrentPageIndex==this.dgPrjModule.PageCount-1) 
			//{ 
			//	this.btnPrjModuleNextPage.Enabled=false; 
			//} 
			//else 
			//{ 
			//	this.btnPrjModuleNextPage.Enabled=true; 
			//} 
			//7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
			//if(objDT.Rows.Count>0) 
			//{ 
			//	this.tabPrjModuleJumpPage.Visible = true; 
			//} 
			//else 
			//{ 
			//	this.tabPrjModuleJumpPage.Visible = false; 
			//}
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
			this.dgPrjModule.CurrentPageIndex=0;
			///把表记录的内容显示在DATAGRID中
			BindDg_QxPrjModule();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void dgPrjModule_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgPrjModule.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxPrjModule();
		}

        protected void btnOKUpd_Click(object sender, EventArgs e)
        {

        }
    }
}
