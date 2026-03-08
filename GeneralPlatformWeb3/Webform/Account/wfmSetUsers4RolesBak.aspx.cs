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

using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmUsers_QUDI 的摘要说明。其中Q代表查询，U代表修改
	/// </summary>
    public partial class wfmSetUsers4RolesBak : System.Web.UI.Page
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
                //clsQxUserIdentityBLEx.BindDdl_IdentityId(ddlIdentityId_q);
                //clsQxUserIdentityBLEx.BindDdl_IdentityId(ddlIdentityId_q2);
                clsDropDownList.BindDdl_DepartmentId4InUse(ddlDepartmentId_q);
                clsDropDownList.BindDdl_DepartmentId4InUse(ddlDepartmentId_q2);

//                clsQxDepartmentInfoBLEx.Bindtv_Departments(tvDepartments);
				strSortUsersBy = "UserId Asc";
				//2、显示无条件的表内容在DATAGRID中
                SetDdl_QxPrjId();
                CurrPrjId = getUserPrjId;
                this.ddlPrjId.SelectedValue = CurrPrjId;
                if (clsCommonSession.RoleId != "00010001")
                {
                    this.ddlPrjId.Enabled = false;
                }
                this.ShowRolesTree(this.ddlPrjId.SelectedValue);
                BindDg_QxUserRoleRelation();
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
		private string CombineUserRoleRelationCondion()
		{
			//使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
			//例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 And QxPrjId='" + CurrPrjId + "'";
			//如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            ///

            if (string.IsNullOrEmpty(vsRoleId) == false)
            {
                strWhereCond += " And RoleId='" + vsRoleId + "'";
            }
            //if (DepartmentId != "" && DepartmentId != "root")
            //{
            //    strWhereCond += " And DepartmentId='" + DepartmentId + "'";
            //}
           
            if (this.txtUserId_q.Text.Trim() != "")
            {
                strWhereCond += " And UserId like '%" + this.txtUserId_q.Text.Trim() + "%'";
            }
            if (this.txtUserName_q.Text.Trim() != "")
            {
                strWhereCond += " And UserName like '%" + this.txtUserName_q.Text.Trim() + "%'";
            }
            //if (this.ddlIdentityId_q.SelectedValue != "" && this.ddlIdentityId_q.SelectedValue != "0")
            //{
            //    strWhereCond += " And IdentityId='" + this.ddlIdentityId_q.SelectedValue + "'";
            //}
            if (this.ddlDepartmentId_q.SelectedValue != "" && this.ddlDepartmentId_q.SelectedValue != "0")
            {
                strWhereCond += " And DepartmentId='" + this.ddlDepartmentId_q.SelectedValue + "'";
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
			System.Data.DataTable objDT = clsQxPrjUserRelationBLEx.GetQxPrjUserRelationVEx(strWhereCond);
			//3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
			///		3.1 首先计算页数；
			///		3.2 如果当前页大于页数就为最后一页
         	
            this.dgUserRoleRelation.PageSize = RecordNumPerPage;
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
			objDV.Sort = strSortUsersBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgUserRoleRelation.DataSource=objDV;
			//5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
			this.dgUserRoleRelation.DataBind();

			///生成专门用于BINDDG中的跳页相关代码
			//当前记录数
			this.lblUsersRecCount.Text = objDT.Rows.Count.ToString(); 
			//当前页数
			this.lblUsersAllPages.Text = this.dgUserRoleRelation.PageCount.ToString(); 
			//当前页序数
			this.lblUsersCurrentPage.Text=(this.dgUserRoleRelation.CurrentPageIndex+1).ToString();
			//当前即将跳到的页序数
			this.txtUsersJump2Page.Text=(this.dgUserRoleRelation.CurrentPageIndex+1).ToString();
			//如果当前页序数为0，则<前一页>按钮无效
			if(this.dgUserRoleRelation.CurrentPageIndex==0) 
			{
				this.btnUsersPrevPage.Enabled=false; 
			}
			else 
			{ 
				this.btnUsersPrevPage.Enabled=true; 
			} 
			//如果当前页序数已为最后一页，则<前一页>按钮无效
			if(this.dgUserRoleRelation.CurrentPageIndex==this.dgUserRoleRelation.PageCount-1) 
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
		protected void dgUsers_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
		{
			//操作步骤：（共2步）
			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页

			//1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
			this.dgUserRoleRelation.CurrentPageIndex=e.NewPageIndex;
			//2、重新绑定DATAGRID，使之内容更新，变化到新的页
			BindDg_QxUserRoleRelation();
		}
		
		protected void dgUsers_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			
			int intIndex;
			if (strSortUsersBy == "") return ;
			if(e.Item.ItemType==ListItemType.Header)//点击控件是否为页眉；
			{
				string strSortEx;
				for(int i=0;i<this.dgUserRoleRelation.Columns.Count;i++)
				{
					strSortEx = this.dgUserRoleRelation.Columns[i].SortExpression;
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
			string strWhereCond = CombineUserRoleRelationCondion();
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
			intIndex = strSortUsersBy.IndexOf(e.SortExpression);
			if (intIndex == -1)
			{
				strSortUsersBy = e.SortExpression + " Asc";
				BindDg_QxUserRoleRelation();
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
			BindDg_QxUserRoleRelation();
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
			this.dgUserRoleRelation.CurrentPageIndex -=1; 
			this.BindDg_QxUserRoleRelation(); 
		}

		protected void btnUsersNextPage_Click(object sender, System.EventArgs e)
		{
			this.dgUserRoleRelation.CurrentPageIndex +=1; 
			this.BindDg_QxUserRoleRelation(); 
		}

		protected void btnUsersJumpPage_Click(object sender, System.EventArgs e)
		{
			if(this.txtUsersJump2Page.Text.Trim()!="" && 
				int.Parse(this.txtUsersJump2Page.Text)>0 && 
				int.Parse(this.txtUsersJump2Page.Text)-1<this.dgUserRoleRelation.PageCount) 
			{ 
				this.dgUserRoleRelation.CurrentPageIndex=int.Parse(this.txtUsersJump2Page.Text)-1; 
			} 
			this.BindDg_QxUserRoleRelation();
		}


        //protected void tvDepartments_SelectedNodeChanged(object sender, EventArgs e)
        //{
        //    string strDepartmentId = clsCommForWebForm.getNodeID_S(tvDepartments.SelectedNode);
        //    DepartmentId = strDepartmentId;
        //    if (strDepartmentId == "root")
        //    {
        //        lblUserRoleRelationList.Text = "市妇联所有用户信息列表";
        //    }
        //    else
        //    {
        //        string strDepartmentName = new clsQxDepartmentInfoEN(strDepartmentId, true).DepartmentName;
        //        lblUserRoleRelationList.Text = strDepartmentName + ":用户信息列表";
        //    }
        //    BindDg_QxUsers();
        //}
        protected void btShowRoles_Click(object sender, EventArgs e)
        {

            string strUserId = GetFirstCheckedItemFromDg(dgUserRoleRelation);
            if (strUserId == null || strUserId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg.Text = "";
            //1、显示该关键字记录的内容在界面上；

            //1 把选中人的所有角色Id都放到ArryList当中
            ArrayList alUserRoles = new ArrayList();
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.AppendFormat("select RoleId from QxUserRoleRelation where UserId = '{0}' and QxPrjId = '{1}'",
                strUserId, getUserPrjId);
            System.Data.DataTable UsersRoleDT = clsQxUserRoleRelationBL.GetDataTable_QxUserRoleRelation(sbSQL.ToString());
            if (UsersRoleDT.Rows.Count == 0)
            {
                return;
            }
            foreach (System.Data.DataRow row in UsersRoleDT.Rows)
            {
                alUserRoles.Add(row[0].ToString().Trim());
            }

            //2 遍历角色树，ArrayList中有的Id都打上钩
            foreach (TreeNode tnboot in this.tvRoles.Nodes)
            {
                foreach (TreeNode tnRoles in tnboot.ChildNodes)
                {
                    if (alUserRoles.Contains(getNodeID(tnRoles)))
                    {
                        tnRoles.Checked = true;
                    }
                    else
                    {
                        tnRoles.Checked = false;
                    }
                }
            }


        }

        protected void btAddRoles_Click(object sender, EventArgs e)
        {
            ///			if(全选 选了 )
            ///			{
            ///              遍历整个DataTable 去加权限
            ///				 
            ///			}
            ///			else()
            ///			{
            ///              遍历DataGrid 去加权限
            ///			}
            ///			

            //获取被选的第一个用户ID
            string strUserId = GetFirstCheckedItemFromDg(dgUserRoleRelation);
            if (strUserId == null || strUserId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg.Text = "";

            clsQxUserRoleRelationEN objUserRoleRelation = new clsQxUserRoleRelationEN();
            //1循环角色树，把所有的选种角色取出来放到ArrayList当中
            ArrayList alRoles = new ArrayList();
            foreach (TreeNode tnboot in this.tvRoles.Nodes)
            {
                foreach (TreeNode tnRoles in tnboot.ChildNodes)
                {
                    if (tnRoles.Checked)
                    {
                        alRoles.Add(getNodeID(tnRoles));
                        tnRoles.Checked = false;
                    }
                }
            }

            clsQxUserRoleRelationBLEx.UpdateRoles4User(strUserId, alRoles, this.ddlPrjId.SelectedValue);
           
            BindDg_QxUserRoleRelation();

        }
        private string getNodeType(TreeNode tnNode)
        {
            string strValue = tnNode.Value;
            string[] strArr = strValue.Split(",".ToCharArray());
            if (strArr.Length < 1)
            {
                return "";
            }
            string strType = strArr[0];
            return strType;
        }
        private string getNodeID(TreeNode tnNode)
        {
            string strValue = tnNode.Value;
            string[] strArr = strValue.Split(",".ToCharArray());
            if (strArr.Length < 2)
            {
                return "";
            }
            string strID = strArr[1];
            return strID;
            //string strID = getNodeID(tNode);
            //string strType = getNodeType(tNode);

        }
       
        public void SetDdl_QxPrjId()
        {
            clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId);
        }

        private void ShowRolesTree(string strPrjId)
        {
            DataTable objDtRoles;
            TreeNode tnRoot, tnRoles;
            int iRow;
            DataRow objRow;

            clsQxRolesEN objRoles = new clsQxRolesEN();
            objDtRoles = clsQxRolesBL.GetDataTable_QxRoles(" QxPrjId = '" + strPrjId+ "'");
            tnRoot = new TreeNode();
            tnRoot.Value = "root,root";
           
            tnRoot.Text = "所有角色";
            //			tnRoot.CheckBox=true;
            tvRoles.Nodes.Add(tnRoot);
            for (iRow = 0; iRow < objDtRoles.Rows.Count; iRow++)
            {
                objRow = objDtRoles.Rows[iRow];
                tnRoles = new TreeNode();
                tnRoles.Value = "Roles," + objRow["RoleId"].ToString();
                //tnRoles.Type = "Roles";
                //tnRoles.ID = objRow["RoleId"].ToString();
                tnRoles.Text = objRow["RoleName"].ToString();
                //tnRoles.ShowCheckBox = true;
                tnRoot.ChildNodes.Add(tnRoles);
            }
            tvRoles.ExpandAll();
        }
        protected void dgUsers_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
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
                switch (strCommandName)
                {
                    case "Delete":
                        clsQxUserRoleRelationBLEx.DelRecord(vsRoleId, strUserId);
                        BindDg_QxUserRoleRelation();
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
                    Set_DataGridAllChecked(dgUserRoleRelation, true);
                    lbSelAll.Text = "不选";
                }
                else if (lbSelAll.Text == "不选")
                {
                    Set_DataGridAllChecked(dgUserRoleRelation, false);
                    lbSelAll.Text = "全选";
                }
            }
        }

        protected void ddlPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tvRoles.Nodes.Clear();
            if (ddlPrjId.SelectedIndex > 0)
            {
                CurrPrjId = this.ddlPrjId.SelectedValue.ToString();
                this.ShowRolesTree(CurrPrjId);
            }
        }
        protected void btnSetRole4AllSelectedUser_Click(object sender, EventArgs e)
        {
            ///			if(全选 选了 )
            ///			{
            ///              遍历整个DataTable 去加权限
            ///				 
            ///			}
            ///			else()
            ///			{
            ///              遍历DataGrid 去加权限
            ///			}
            ///			

            //获取被选的第一个用户ID
            ArrayList arrUserIdLst = GetAllCheckedItemFromDg(dgUserRoleRelation, "chkCheckRec");
            if (arrUserIdLst.Count == 0)
            {
                lblMsg.Text = "没有选择用户，请选择一个或多个用户!";
                return;
            }
            lblMsg.Text = "";

            clsQxUserRoleRelationEN objUserRoleRelation = new clsQxUserRoleRelationEN();
            //1循环角色树，把所有的选种角色取出来放到ArrayList当中
            ArrayList alRoles = new ArrayList();
            foreach (TreeNode tnboot in this.tvRoles.Nodes)
            {
                foreach (TreeNode tnRoles in tnboot.ChildNodes)
                {
                    if (tnRoles.Checked)
                    {
                        alRoles.Add(getNodeID(tnRoles));
                        tnRoles.Checked = false;
                    }
                }
            }
            foreach (string strUserId in arrUserIdLst)
            {
                foreach (string strRoleId in alRoles)
                {
                    clsQxUserRoleRelationBLEx.AddRecord(strRoleId, strUserId, "pyf");
                }
            }
           
            BindDg_QxUserRoleRelation();
        }
        protected void btnAddUser4CurrRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vsRoleId))
            {
                lblMsg_List.Text = "请选择一个有效的角色!";
                return;
            }
            tabUsersGridView.Visible = true;
            BindGv_QxUsers();
        }
        protected void btnDelQxUser4CurrRole_Click(object sender, EventArgs e)
        {
            ArrayList arrmId = clsCommForWebForm.GetAllCheckedItemFromDg(dgUserRoleRelation, "chkCheckRec");
            if (arrmId == null || arrmId.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            if (string.IsNullOrEmpty(vsRoleId) == true)
            {
                lblMsg_List.Text = "请在左边树中选中一个角色!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }
            lblMsg_List.Text = "";
            foreach (string strmId in arrmId)
            {
                clsQxPrjUserRelationEN objQxPrjUserRelationEN = clsQxPrjUserRelationBL.GetObjBymId(long.Parse(strmId));
                clsQxUserRoleRelationBLEx.DelRecord(vsRoleId, objQxPrjUserRelationEN.UserId);
            }
            BindDg_QxUserRoleRelation();
        }
        private string vsRoleId
        {
            get
            {
                string strRoleId;
                strRoleId = (string)ViewState["RoleId"];
                if (strRoleId == null)
                {
                    strRoleId = "";
                }
                return strRoleId;
            }
            set
            {
                string strRoleId = value;
                ViewState.Add("RoleId", strRoleId);
            }
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
        protected void tvRoles_SelectedNodeChanged(object sender, EventArgs e)
        {
            string strRoleId = clsCommForWebForm.getNodeID_S(tvRoles.SelectedNode);
            vsRoleId = strRoleId;
            if (strRoleId == "root")
            {
                lblUserRoleRelationList.Text = "所有用户角色关系列表";
            }
            else
            {
                string strPrjName = clsQxRolesBL.GetRoleNameByRoleIdCache(strRoleId);
                lblUserRoleRelationList.Text = strPrjName + ":用户角色关系列表";
            }
            BindDg_QxUserRoleRelation();
        }
        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddUsersRecord();
        }
        private void AddUsersRecord()
        {
            List<string>  arrUserId = clsCommForWebForm.GetAllCheckedItemFromGv(gvUsers, "chkCheckRec");
            if (arrUserId == null || arrUserId.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            foreach (string strUserId in arrUserId)
            {
                clsQxUserRoleRelationBLEx.AddRecord(vsRoleId, strUserId, "pyf");
            }
            BindGv_QxUsers();
            BindDg_QxUserRoleRelation();
        }
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_QxUsers()
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
                objDT = clsvQxUsersBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortUsersBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageUserSize) == false)
            {
                int intPageSize = int.Parse(PageUserSize);
                gvUsers.PageSize = intPageSize;
            }
            else
            {
                PageUserSize = "10";
                gvUsers.PageSize = 10;
            }
            this.gvUsers.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvUsers.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvUsers.BottomPagerRow;
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
                lblAllPages.Text = this.gvUsers.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvUsers.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvUsers.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvUsers.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvUsers.PageIndex == this.gvUsers.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
                ddlPagerRecCount.Text = PageUserSize;
                this.gvUsers.BottomPagerRow.Visible = true;
                gvUsers.BottomPagerRow.HorizontalAlign = HorizontalAlign.Right;
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
        protected string PageUserRoleRelationSize
        {
            get
            {
                string strPageUserRoleRelationSize;
                strPageUserRoleRelationSize = (string)ViewState["PageUserRoleRelationSize"];
                if (strPageUserRoleRelationSize == null)
                {
                    strPageUserRoleRelationSize = "";
                }
                return strPageUserRoleRelationSize;
            }
            set
            {
                string strPageUserRoleRelationSize = value;
                ViewState.Add("PageUserRoleRelationSize", strPageUserRoleRelationSize);
            }
        }

        protected void btnQuery4Users_Click(object sender, EventArgs e)
        {
            ///把DATAGRID的当前页索引设置为0，即第1页。
            ///当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvUsers.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_QxUsers();
        }
        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvUsers.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvUsers.PageCount)
                {
                    this.gvUsers.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_QxUsers();
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
                    BindGv_QxUsers();
                }
            }
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvUsers_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvUsers.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_QxUsers();
        }
        ///删除记录过程代码for C#
        protected void gvUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvUsers.PageIndex = e.NewPageIndex;
                this.BindGv_QxUsers();
            }
        }
        ///生成GridView行命令的事件代码
        protected void gvUsers_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvUsers, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvUsers, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
                case "AddUser":
                    int intRowIndex = int.Parse(e.CommandArgument.ToString());
                    string strUserId = gvUsers.DataKeys[intRowIndex].Value.ToString();

                    AddUsersRecord(vsRoleId, strUserId);

                    break;

            }
        }
        ///删除记录过程代码for C#
        protected void gvUsers_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortUsersBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvUsers.Columns.Count; i++)
                {
                    strSortEx = this.gvUsers.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortUsersBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortUsersBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }
        ///生成组合查询条件的代码
        protected void gvUsers_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortUsersBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortUsersBy = e.SortExpression + " Asc";
                BindGv_QxUsers();
                return;
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
            BindGv_QxUsers();
        }


        protected void gvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddUsersRecord(string strRoleId, string strUserId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            clsQxUserRoleRelationBLEx.AddRecord(vsRoleId, strUserId, "pyf");
            BindGv_QxUsers();
            BindDg_QxUserRoleRelation();
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineUsersCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = string.Format(" UserId not in (select userid from QxUserRoleRelation where RoleId = '{0}')", vsRoleId);
            strWhereCond += string.Format(" and UserId in (select userid from QxPrjUserRelation where QxPrjId = '{0}')", CurrPrjId);
            
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtUserId_q2.Text.Trim() != "")
            {
                strWhereCond += " And UserId like '" + this.txtUserId_q2.Text.Trim() + "%'";
            }
            if (this.ddlDepartmentId_q2.SelectedValue != "" && this.ddlDepartmentId_q2.SelectedValue != "0")
            {
                strWhereCond += " And DepartmentId='" + this.ddlDepartmentId_q2.SelectedValue + "'";
            }
            if (this.txtUserName_q2.Text.Trim() != "")
            {
                strWhereCond += " And UserName like '" + this.txtUserName_q2.Text.Trim() + "%'";
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
                    PageUserRoleRelationSize = intPageSize.ToString();
                    BindDg_QxUserRoleRelation();
                }
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