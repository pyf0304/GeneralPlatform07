///生成查询，修改，删除，添加记录的控制层代码

///生成控制层的控件变量名列表
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using SpecData;
using GeneralPlatform;
using CommFunc4WebForm;
using com.taishsoft.common;
using System.Collections.Generic;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.datetime;

using com.taishsoft.web.treeview;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmUsers_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
    public partial class wfmSetPotenceSymbol4Roles2 : System.Web.UI.Page
	{
        private int RecordNumPerPage
        {
            get
            {
                string strRecordNumPerPage = ddlRecordNumPerPage.SelectedValue.ToString();
                return int.Parse(strRecordNumPerPage);
            }
        }

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
                ddlRecordNumPerPage.SelectedValue = "10";
				//1、为下拉框设置数据源，绑定列表数据
                CurrPrjId = getUserPrjId;

                clsQxPotenceTypeBLEx.BindDdl_PotenceTypeIdEx(ddlPotenceTypeId_q, CurrPrjId);
                clsQxPotenceTypeBLEx.BindDdl_PotenceTypeIdEx(ddlPotenceTypeId_q2, CurrPrjId);

//                clsQxDepartmentInfoBLEx.Bindtv_Departments(tvDepartments);
				strSortPotencesBy = "PotenceId Asc";
                strSortUserGroupPotencesBy = "RoleId Asc";
				//2、显示无条件的表内容在DATAGRID中
                SetDdl_QxPrjId();
                this.ddlPrjId.SelectedValue = CurrPrjId;
                if (clsCommonSession.RoleId != "00010001")
                {
                    this.ddlPrjId.Enabled = false;
                }
                wucTreeView1.QxPrjId = CurrPrjId;
                wucTreeView1.tmTreeModel = web.treeview.TreeModel.vQxRolesByMenuNum;
                wucTreeView1.BindTv();

                //this.ShowRolesTree(this.ddlPrjId.SelectedValue);
                BindDg_QxUserGroupPotence();
                tabUsersGridView.Visible = false;
			}
		}

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


		
        private string DepartmentId
        {
            get
            {
                string strDepartmentId;
                strDepartmentId = (string)Session["DepartmentId"];
                if (strDepartmentId == null)
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
		private string CombineUserGroupPotenceCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 And QxPrjId='" + CurrPrjId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            ///

            if (string.IsNullOrEmpty(vsRoleId)==false)
            {
                strWhereCond += " And RoleId='" + vsRoleId + "'";
            }
            //if (DepartmentId != "" && DepartmentId != "root")
            //{
            //    strWhereCond += " And DepartmentId='" + DepartmentId + "'";
            //}
           
            if (this.ddlPotenceId_q.SelectedValue != "" && this.ddlPotenceId_q.SelectedValue != "0")
            {
                strWhereCond += " And PotenceId='" + this.ddlPotenceId_q.SelectedValue + "'";
            }
            if (this.ddlPotenceTypeId_q.SelectedValue != "" && this.ddlPotenceTypeId_q.SelectedValue != "0")
            {
                strWhereCond += " And PotenceTypeId='" + this.ddlPotenceTypeId_q.SelectedValue + "'";
            }

            return strWhereCond;
		}
		///生成绑定DATAGRID的代码
		/// <summary>
		/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
		///			 并显示在DATAGRID中。
		/// </summary>
		private void BindDg_QxUserGroupPotence()
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
			string strWhereCond = CombineUserGroupPotenceCondion();
			//2、根据条件串获取该表满足条件的DataTable；
			System.Data.DataTable objDT = clsvQxUserGroupPotenceBL.GetDataTable(strWhereCond);
			//3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			///		3.1 首先计算页数；
			///		3.2 如果当前页大于页数就为最后一页
            ///		
            this.dgUserGroupPotence.PageSize = RecordNumPerPage;
			int intPages = CalcPages(objDT.Rows.Count, this.dgUserGroupPotence.PageSize);
			if (intPages==0) 
			{
				this.dgUserGroupPotence.CurrentPageIndex = 0;
			}
			else if (this.dgUserGroupPotence.CurrentPageIndex > intPages - 1) 
			{
				this.dgUserGroupPotence.CurrentPageIndex = intPages - 1;
			}
			//4、设置DATAGRID的数据源(DataSource)；
			DataView objDV = objDT.DefaultView;
			objDV.Sort = strSortUserGroupPotencesBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgUserGroupPotence.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUserGroupPotence.DataBind();

			///生成专门用于BINDDG中的跳页相关代码
			//当前记录数
			this.lblUsersRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblUsersAllPages.Text = this.dgUserGroupPotence.PageCount.ToString(); 
			//当前页序数
			this.lblUsersCurrentPage.Text=(this.dgUserGroupPotence.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtUsersJump2Page.Text=(this.dgUserGroupPotence.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgUserGroupPotence.CurrentPageIndex==0) 
			{
				this.btnUsersPrevPage.Enabled=false; 
			}
			else 
			{ 
				this.btnUsersPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgUserGroupPotence.CurrentPageIndex==this.dgUserGroupPotence.PageCount-1) 
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
			this.dgUserGroupPotence.CurrentPageIndex=0;
			///把表记录的内容显示在DATAGRID中
			BindDg_QxUserGroupPotence();
		}
		/// <summary>
		/// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
		///			  具体功能是重新显示新页(所单击页索引)的内容。
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		protected void dgUsers_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgUserGroupPotence.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxUserGroupPotence();
		}
		
		protected void dgUsers_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			
			int intIndex;
			if (strSortUserGroupPotencesBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgUserGroupPotence.Columns.Count;i++)
				{
					strSortEx = this.dgUserGroupPotence.Columns[i].SortExpression;
					if (strSortEx == "") continue;
					intIndex = strSortUserGroupPotencesBy.IndexOf(strSortEx);
					if(intIndex >=0)  //视图状态的排序表达式是否为该列的字段；
					{
						Label lblSort=new Label();
						lblSort.Font.Name="webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
						intIndex = strSortUserGroupPotencesBy.IndexOf("Asc");
						lblSort.Text=(intIndex>0?"▲":"▼");//是否为升序，而且为string型；
						e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
						break;
					}
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
		protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
		{
			//1、组合界面条件串；
			string strWhereCond = CombineUserGroupPotenceCondion();
			//2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvQxRelaOfPotenceAndSymbolBL.GetDataTable(strWhereCond);
			ArrayList arrCnName = new ArrayList();
			ArrayList arrColName = new ArrayList();
			string strFileName = "Users信息导出.xls";
			string strFolderName;
			string strDownLoadFileName;
			//arrColName.Add(convQxRelaOfPotenceAndSymbol.UserId); arrCnName.Add("用户ID");
			//arrColName.Add(convQxRelaOfPotenceAndSymbol.UserName); arrCnName.Add("用户名");
			//arrColName.Add(convQxRelaOfPotenceAndSymbol.DepartmentId); arrCnName.Add("部门Id");
			//arrColName.Add(convQxRelaOfPotenceAndSymbol.DepartmentName); arrCnName.Add("部门名");
			//arrColName.Add(convQxRelaOfPotenceAndSymbol.UserStateName); arrCnName.Add("用户状态名");
			arrColName.Add(convQxRelaOfPotenceAndSymbol.Memo); arrCnName.Add("备注");
			strFolderName = clsSysParaEN.TempFileFolder;
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
		protected void dgUsers_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
		{
			int intIndex;
			///判断是否是新的排序字段
			intIndex = strSortUserGroupPotencesBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortUserGroupPotencesBy = e.SortExpression + " Asc";
				BindDg_QxUserGroupPotence();
				return ;
			}
			///检查原来是升序
			intIndex = strSortUserGroupPotencesBy.IndexOf(" Asc");
			if (intIndex == -1)		//如果原来不是升序就设置为升序
			{
				strSortUserGroupPotencesBy = e.SortExpression + " Asc";
			}
			else			///否则设置为降序
			{
				strSortUserGroupPotencesBy = e.SortExpression + " Desc";
			}
			BindDg_QxUserGroupPotence();
		}

		private string strSortPotencesBy
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

        private string strSortUserGroupPotencesBy
        {
            get
            {
                string sSortUserGroupPotencesBy;
                sSortUserGroupPotencesBy = (string)ViewState["SortUserGroupPotencesBy"];
                if (sSortUserGroupPotencesBy == null)
                {
                    sSortUserGroupPotencesBy = "";
                }
                return sSortUserGroupPotencesBy;
            }
            set
            {
                string sSortUserGroupPotencesBy = value;
                ViewState.Add("SortUserGroupPotencesBy", sSortUserGroupPotencesBy);
            }
        }
       
		///生成父对象的SESSION相关属性函数
		protected void btnUsersPrevPage_Click(object sender, System.EventArgs e)
		{
			this.dgUserGroupPotence.CurrentPageIndex -=1; 
			this.BindDg_QxUserGroupPotence(); 
		}

		protected void btnUsersNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgUserGroupPotence.CurrentPageIndex +=1; 
			this.BindDg_QxUserGroupPotence(); 
		}

		protected void btnUsersJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtUsersJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtUsersJump2Page.Text)>0 && 
				int.Parse(this.txtUsersJump2Page.Text)-1<this.dgUserGroupPotence.PageCount) 
			{ 
				this.dgUserGroupPotence.CurrentPageIndex=int.Parse(this.txtUsersJump2Page.Text)-1; 
			} 
			this.BindDg_QxUserGroupPotence();
		}


        //protected void tvDepartments_SelectedNodeChanged(object sender, EventArgs e)
        //{
        //    string strDepartmentId = clsCommForWebForm.getNodeID_S(tvDepartments.SelectedNode);
        //    DepartmentId = strDepartmentId;
        //    if (strDepartmentId == "root")
        //    {
        //        lblUserGroupPotenceList.Text = "市妇联所有用户信息列表";
        //    }
        //    else
        //    {
        //        string strDepartmentName = new clsQxDepartmentInfoEN(strDepartmentId, true).DepartmentName;
        //        lblUserGroupPotenceList.Text = strDepartmentName + ":用户信息列表";
        //    }
        //    BindDg_QxRelaOfPotenceAndSymbol();
        //}
        //protected void btShowRoles_Click(object sender, EventArgs e)
        //{

        //    string strRelaMid = GetFirstCheckedItemFromDg(dgUserGroupPotence);
        //    if (strRelaMid == null || strRelaMid.Trim().Length == 0)
        //    {
        //        lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
        //        return;
        //    }
        //    lblMsg_List.Text = "";
        //    //1、显示该关键字记录的内容在界面上；

        //    //1 把选中人的所有角色Id都放到ArryList当中
        //    ArrayList alUserRoles = new ArrayList();
        //    StringBuilder sbSQL = new StringBuilder();
        //    sbSQL.AppendFormat("select RoleId from {2} where RelaMid = '{0}' and QxPrjId = '{1}'",
        //        strRelaMid, getUserPrjId,
        //        clsQxUserGroupPotenceEN._CurrTabName);
        //    System.Data.DataTable UsersRoleDT = clsQxUserGroupPotenceBL.GetDataTable_QxUserGroupPotence(sbSQL.ToString());
        //    if (UsersRoleDT.Rows.Count == 0)
        //    {
        //        return;
        //    }
        //    foreach (System.Data.DataRow row in UsersRoleDT.Rows)
        //    {
        //        alUserRoles.Add(row[0].ToString().Trim());
        //    }

        //    //2 遍历角色树，ArrayList中有的Id都打上钩
        //    foreach (TreeNode tnboot in this.tvRoles.Nodes)
        //    {
        //        foreach (TreeNode tnRoles in tnboot.ChildNodes)
        //        {
        //            if (alUserRoles.Contains(getNodeID(tnRoles)))
        //            {
        //                tnRoles.Checked = true;
        //            }
        //            else
        //            {
        //                tnRoles.Checked = false;
        //            }
        //        }
        //    }


        //}

    
        //private string getNodeType(TreeNode tnNode)
        //{
        //    string strValue = tnNode.Value;
        //    string[] strArr = strValue.Split(",".ToCharArray());
        //    if (strArr.Length < 1)
        //    {
        //        return "";
        //    }
        //    string strType = strArr[0];
        //    return strType;
        //}
        //private string getNodeID(TreeNode tnNode)
        //{
        //    string strValue = tnNode.Value;
        //    string[] strArr = strValue.Split(",".ToCharArray());
        //    if (strArr.Length < 2)
        //    {
        //        return "";
        //    }
        //    string strID = strArr[1];
        //    return strID;
        //    //string strID = getNodeID(tNode);
        //    //string strType = getNodeType(tNode);

        //}
      
        public void SetDdl_QxPrjId()
        {
            clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId);
        }

        //private void ShowRolesTree(string strPrjId)
        //{
        //    DataTable objDtRoles;
        //    TreeNode tnRoot, tnRoles;
        //    int iRow;
        //    DataRow objRow;

        //    clsQxRolesEN objRoles = new clsQxRolesEN();
        //    objDtRoles = clsQxRolesBL.GetDataTable_QxRoles(" QxPrjId = '" + strPrjId+ "'");
        //    tnRoot = new TreeNode();
        //    tnRoot.Value = "root,root";
           
        //    tnRoot.Text = "所有角色";
        //    //			tnRoot.CheckBox=true;
        //    tvRoles.Nodes.Add(tnRoot);
        //    for (iRow = 0; iRow < objDtRoles.Rows.Count; iRow++)
        //    {
        //        objRow = objDtRoles.Rows[iRow];
        //        tnRoles = new TreeNode();
        //        tnRoles.Value = "Roles," + objRow["RoleId"].ToString();
        //        //tnRoles.Type = "Roles";
        //        //tnRoles.ID = objRow["RoleId"].ToString();
        //        tnRoles.Text = objRow["RoleName"].ToString();
        //        //tnRoles.ShowCheckBox = true;
        //        tnRoot.ChildNodes.Add(tnRoles);
        //    }
        //    tvRoles.ExpandAll();
        //}
        protected void dgUsers_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            string strRelaMid;
            string strCommandName;
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.SelectedItem ||
                e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.EditItem)
            {
                strCommandName = ((LinkButton)e.CommandSource).CommandName;
                strRelaMid = e.Item.Cells[1].Text;
                switch (strCommandName)
                {
                    case "Delete":
                        clsQxUserGroupPotenceBLEx.DelPotence4Role(vsRoleId, long.Parse(strRelaMid), CurrPrjId);
                        BindDg_QxUserGroupPotence();
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
                    return;
                }
                if (lbSelAll.Text == "全选")
                {
                    Set_DataGridAllChecked(dgUserGroupPotence, true);
                    lbSelAll.Text = "不选";
                }
                else if (lbSelAll.Text == "不选")
                {
                    Set_DataGridAllChecked(dgUserGroupPotence, false);
                    lbSelAll.Text = "全选";
                }
            }
        }

        protected void ddlPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ddlPrjId.SelectedIndex > 0)
            {
                CurrPrjId = this.ddlPrjId.SelectedValue.ToString();
                wucTreeView1.QxPrjId = CurrPrjId;
                wucTreeView1.tmTreeModel = web.treeview.TreeModel.vQxRolesByMenuNum;
                wucTreeView1.BindTv();
                //this.ShowRolesTree(CurrPrjId);
            }
        }
    
        protected void btnAddUser4CurrRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRoleId))
            {
                lblMsg_List.Text = "请选择一个有效的角色!";
                return;
            }
            tabUsersGridView.Visible = true;
            BindGv_QxRelaOfPotenceAndSymbol();
        }
        protected void btnDelQxUser4CurrRole_Click(object sender, EventArgs e)
        {
            ArrayList arrRelaMid = clsCommForWebForm.GetAllCheckedItemFromDg(dgUserGroupPotence, "chkCheckRec");
            if (arrRelaMid == null || arrRelaMid.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            foreach (string strRelaMid in arrRelaMid)
            {
                clsQxUserGroupPotenceBL.DelRecord(long.Parse(strRelaMid));
            }
            BindDg_QxUserGroupPotence();
        }
      
        /// <summary>
        /// 当前所选工程ID
        /// </summary>
        private string CurrPrjId
        {
            get
            {
                string strCurrPrjId;
                strCurrPrjId = (string)ViewState["CurrPrjId"];
                if (strCurrPrjId == null)
                {
                    strCurrPrjId = "";
                }
                return strCurrPrjId;
            }
            set
            {
                string strCurrPrjId = value;
                ViewState.Add("CurrPrjId", strCurrPrjId);
            }
        }
        protected void wucTreeView1_afterSelect_Tz(object sender, clsEventArgs4TreeView e)
        {
            string strRoleId = e.KeyId;
            string strTypeName = e.NodeType;
         
            wucTreeView1.SelectNodeEx(strRoleId);

            //vsDepartmentId = strRoleId;

            new clsCommonSession().CurrRoleNodeId = strRoleId;
            vsRoleId = strRoleId;
            string strNodeType = e.NodeType;
      
            if (strRoleId == "root")
            {
                lblUserGroupPotenceList.Text = "所有用户角色关系列表";
            }
            else
            {
                string strPrjName = clsQxRolesBL.GetRoleNameByRoleIdCache(strRoleId);
                lblUserGroupPotenceList.Text = strPrjName + ":用户角色关系列表";
            }
            BindDg_QxUserGroupPotence();
            //throw new NotImplementedException();
        }
        //protected void tvRoles_SelectedNodeChanged(object sender, EventArgs e)
        //{
        //    string strRoleId = clsCommForWebForm.getNodeID_S(tvRoles.SelectedNode);
        //    RoleId = strRoleId;
        //    if (strRoleId == "root")
        //    {
        //        lblUserGroupPotenceList.Text = "所有用户角色关系列表";
        //    }
        //    else
        //    {
        //        string strPrjName = clsQxRolesBL.GetRoleNameByRoleIdCache(strRoleId);
        //        lblUserGroupPotenceList.Text = strPrjName + ":用户角色关系列表";
        //    }
        //    BindDg_QxUserGroupPotence();
        //}
        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddUsersRecord();
        }
        private void AddUsersRecord()
        {
            List<string>  arrRelaMid = clsCommForWebForm.GetAllCheckedItemFromGv(gvRelaOfPotenceAndSymbol, "chkCheckRec");
            if (arrRelaMid == null || arrRelaMid.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            foreach (string strRelaMid in arrRelaMid)
            {
                clsQxUserGroupPotenceBLEx.AddPotenceSymbol4Role(vsRoleId, long.Parse(strRelaMid), CurrPrjId);
            }
            BindGv_QxRelaOfPotenceAndSymbol();
            BindDg_QxUserGroupPotence();
        }
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_QxRelaOfPotenceAndSymbol()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //4、设置GridView的数据源(DataSource)；
            //5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombineUsersCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvQxRelaOfPotenceAndSymbolBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPotencesBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageUserSize) == false)
            {
                int intPageSize = int.Parse(PageUserSize);
                gvRelaOfPotenceAndSymbol.PageSize = intPageSize;
            }
            else
            {
                PageUserSize = "10";
                gvRelaOfPotenceAndSymbol.PageSize = 10;
            }
            this.gvRelaOfPotenceAndSymbol.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvRelaOfPotenceAndSymbol.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvRelaOfPotenceAndSymbol.BottomPagerRow;
            if (pagerRow == null)
            {
                return;
            }
            Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");

            if (lblRecCount != null)
            {
                //当前记录数
                lblRecCount.Text = objDT.Rows.Count.ToString();
                //当前页数
                lblAllPages.Text = this.gvRelaOfPotenceAndSymbol.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvRelaOfPotenceAndSymbol.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvRelaOfPotenceAndSymbol.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvRelaOfPotenceAndSymbol.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvRelaOfPotenceAndSymbol.PageIndex == this.gvRelaOfPotenceAndSymbol.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
                ddlPagerRecCount.Text = PageUserSize;
                this.gvRelaOfPotenceAndSymbol.BottomPagerRow.Visible = true;
                gvRelaOfPotenceAndSymbol.BottomPagerRow.HorizontalAlign = HorizontalAlign.Right;
            }
        }

        
        ///生成返回链接串的Session属性
        protected string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }
        
        ///生成专门用于记录GridView中的每页记录数
        protected string PageUserSize
        {
            get
            {
                string strPageUserSize;
                strPageUserSize = (string)ViewState["PageUserSize"];
                if (strPageUserSize == null)
                {
                    strPageUserSize = "";
                }
                return strPageUserSize;
            }
            set
            {
                string strPageUserSize = value;
                ViewState.Add("PageUserSize", strPageUserSize);
            }
        }

        ///生成专门用于记录GridView中的每页记录数
        protected string PageUserGroupPotenceSize
        {
            get
            {
                string strPageUserGroupPotenceSize;
                strPageUserGroupPotenceSize = (string)ViewState["PageUserGroupPotenceSize"];
                if (strPageUserGroupPotenceSize == null)
                {
                    strPageUserGroupPotenceSize = "";
                }
                return strPageUserGroupPotenceSize;
            }
            set
            {
                string strPageUserGroupPotenceSize = value;
                ViewState.Add("PageUserGroupPotenceSize", strPageUserGroupPotenceSize);
            }
        }

        protected void btnQuery4Users_Click(object sender, EventArgs e)
        {
            ///把DATAGRID的当前页索引设置为0，即第1页。
            ///当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvRelaOfPotenceAndSymbol.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_QxRelaOfPotenceAndSymbol();
        }
        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvRelaOfPotenceAndSymbol.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvRelaOfPotenceAndSymbol.PageCount)
                {
                    this.gvRelaOfPotenceAndSymbol.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_QxRelaOfPotenceAndSymbol();
            }
        }
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageUserSize = intPageSize.ToString();
                    BindGv_QxRelaOfPotenceAndSymbol();
                }
            }
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvRelaOfPotenceAndSymbol_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvRelaOfPotenceAndSymbol.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_QxRelaOfPotenceAndSymbol();
        }
        ///删除记录过程代码for C#
        protected void gvRelaOfPotenceAndSymbol_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvRelaOfPotenceAndSymbol.PageIndex = e.NewPageIndex;
                this.BindGv_QxRelaOfPotenceAndSymbol();
            }
        }
        ///生成GridView行命令的事件代码
        protected void gvRelaOfPotenceAndSymbol_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.LinkButton lbSelAll;
                    lbSelAll = (LinkButton)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "全选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvRelaOfPotenceAndSymbol, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvRelaOfPotenceAndSymbol, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
                case "AddUser":
                    int intRowIndex = int.Parse(e.CommandArgument.ToString());
                    string strRelaMid = gvRelaOfPotenceAndSymbol.DataKeys[intRowIndex].Value.ToString();

                    AddUsersRecord(vsRoleId, long.Parse(strRelaMid));

                    break;

            }
        }
        ///删除记录过程代码for C#
        protected void gvRelaOfPotenceAndSymbol_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.LinkButton myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
                }
            }
            int intIndex;
            if (strSortPotencesBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvRelaOfPotenceAndSymbol.Columns.Count; i++)
                {
                    strSortEx = this.gvRelaOfPotenceAndSymbol.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPotencesBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortPotencesBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }
        ///生成组合查询条件的代码
        protected void gvRelaOfPotenceAndSymbol_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortPotencesBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPotencesBy = e.SortExpression + " Asc";
                BindGv_QxRelaOfPotenceAndSymbol();
                return;
            }
            ///检查原来是升序
            intIndex = strSortPotencesBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortPotencesBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortPotencesBy = e.SortExpression + " Desc";
            }
            BindGv_QxRelaOfPotenceAndSymbol();
        }


        protected void gvRelaOfPotenceAndSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddUsersRecord(string strRoleId, long lngRelaMid)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            clsQxUserGroupPotenceBLEx.AddPotenceSymbol4Role(strRoleId, lngRelaMid, CurrPrjId);
            BindGv_QxRelaOfPotenceAndSymbol();
            BindDg_QxUserGroupPotence();
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineUsersCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" RelaMid not in (select RelaMid from {1} where RoleId = '{0}')",
                vsRoleId,
                clsQxUserGroupPotenceEN._CurrTabName);
            //            strWhereCond += string.Format(" and RelaMid in (select RelaMid from U1serGroupPotence where QxPrjId = '{0}')", CurrPrjId);

            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。


            if (this.ddlPotenceId_q2.SelectedValue != "" && this.ddlPotenceId_q2.SelectedValue != "0")
            {
                strWhereCond += " And PotenceId='" + this.ddlPotenceId_q2.SelectedValue + "'";
            }
            if (this.ddlPotenceTypeId_q2.SelectedValue != "" && this.ddlPotenceTypeId_q2.SelectedValue != "0")
            {
                strWhereCond += " And PotenceTypeId='" + this.ddlPotenceTypeId_q2.SelectedValue + "'";
            }

            return strWhereCond;
        }
        protected void ddlRecordNumPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageUserGroupPotenceSize = intPageSize.ToString();
                    BindDg_QxUserGroupPotence();
                }
            }
        }
        protected void ddlPotenceTypeId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPotenceTypeId_q.SelectedIndex>0)
            {
                string strPotenceTypeId = ddlPotenceTypeId_q.SelectedValue.ToString();
                clsDropDownList.BindDdl_PotenceId(ddlPotenceId_q, CurrPrjId, strPotenceTypeId);
            }
        }
        protected void ddlPotenceTypeId_q2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPotenceTypeId_q2.SelectedIndex > 0)
            {
                string strPotenceTypeId = ddlPotenceTypeId_q2.SelectedValue.ToString();
                clsDropDownList.BindDdl_PotenceId(ddlPotenceId_q2, CurrPrjId, strPotenceTypeId);
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
        /// <summary>
        /// 当前树中所选择角色
        /// </summary>
        protected string vsRoleId
        {
            get
            {
                string sRoleId;
                sRoleId = (string)ViewState["RoleId"];
                if (sRoleId == null)
                {
                    sRoleId = "";
                }
                return sRoleId;
            }
            set
            {
                string sRoleId = value;
                ViewState.Add("RoleId", sRoleId);
            }
        }
    }
}