///生成查询修改记录的控制层代码
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
using System.Configuration;
using GeneralPlatform;
using SpecData;
using CommFunc4WebForm;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmUsers_Q 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmUsers_Q : System.Web.UI.Page
    {

        private const string ViewId = "00010311";
        private string level;

        private void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

            //获取当前用户的权限等级编号
            level = new MenuAndPotence().Get_PotenceLevel(ViewId);

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (level)
                {
                    case "0":

                        Response.Redirect("../error.aspx");
                        break;
                    case "1":



                        break;
                    case "2":

                        this.ddlPrjId.Enabled = false;


                        break;
                    case "3":

                        this.ddlPrjId.Enabled = false;

                        break;

                    case "4":

                        Response.Redirect("../error.aspx");

                        break;


                    default:
                        Response.Redirect("../error.aspx");
                        break;
                }


                // 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
                //wucStudent1.SetDdl_College();
                //1、为下拉框设置数据源，绑定列表数据
                clsDropDownList.BindDdl_DepartmentId4InUse(ddlDepartmentId_q);
          clsQxUserStateBL.BindDdl_UserStateId(ddlUserStateId_q);
                //2、显示无条件的表内容在DATAGRID中
                //				strSortBy = " Asc";
                BindDg_QxUsers();
                SetDdl_QxPrjId();
                this.ddlPrjId.SelectedValue = getUserPrjId;
                this.ShowRolesTree(this.ddlPrjId.SelectedValue);
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
            this.ddlPrjId.SelectedIndexChanged += new System.EventHandler(this.ddlPrjId_SelectedIndexChanged);
            this.dgUsers.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgUsers_PageIndexChanged);
            this.cbChooseAll.CheckedChanged += new System.EventHandler(this.cbChooseAll_CheckedChanged);
            this.btShowRoles.Click += new System.EventHandler(this.btShowRoles_Click);
            this.btAddRoles.Click += new System.EventHandler(this.Button2_Click);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion

       

        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and XM = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtUserId_q.Text.Trim() != "")
            {
                strWhereCond += " and UserId like '%" + this.txtUserId_q.Text.Trim() + "%'";
            }
            if (this.txtUserName_q.Text.Trim() != "")
            {
                strWhereCond += " and UserName like '%" + this.txtUserName_q.Text.Trim() + "%'";
            }
            if (this.ddlDepartmentId_q.SelectedValue != "" && this.ddlDepartmentId_q.SelectedValue != "0")
            {
                strWhereCond += " and DepartmentId='" + this.ddlDepartmentId_q.SelectedValue + "'";
            }
            if (this.ddlUserStateId_q.SelectedValue != "" && this.ddlUserStateId_q.SelectedValue != "0")
            {
                strWhereCond += " and UserStateId='" + this.ddlUserStateId_q.SelectedValue + "'";
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
            string strWhereCond = CombineCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvQxUsersBL.GetDataTable(strWhereCond);
            Session.Add("UsersDt", objDT);
            //3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            ///		3.1 首先计算页数；
            ///		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgUsers.PageSize);
            if (intPages == 0)
            {
                this.dgUsers.CurrentPageIndex = 0;
            }
            else if (this.dgUsers.CurrentPageIndex > intPages - 1)
            {
                this.dgUsers.CurrentPageIndex = intPages - 1;
            }
            //4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            this.dgUsers.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgUsers.DataBind();
            ///	6、设置记录数的状态，
            this.txtRecCount.Text = objDT.Rows.Count.ToString();
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
            if (intRecCount % intPageSize != 0) intPages++;
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
            this.dgUsers.CurrentPageIndex = 0;
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
            this.dgUsers.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_QxUsers();
        }
      

        private void cbChooseAll_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.cbChooseAll.Checked)
            {
                foreach (DataGridItem di in this.dgUsers.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("cb1");
                    cb.Checked = true;
                }
            }
            else
            {
                foreach (DataGridItem di in this.dgUsers.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("cb1");
                    cb.Checked = false;
                }
            }
        }

        public void SetDdl_QxPrjId()
        {
            clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId);
        }

        private void ShowRolesTree(string prjid)
        {
            DataTable objDtRoles;
            TreeNode tnRoot, tnRoles;
            int iRow;
            DataRow objRow;

            clsQxRolesEN objRoles = new clsQxRolesEN();
            objDtRoles = clsQxRolesBL.GetDataTable_QxRoles("QxPrjId = '" + prjid + "'");
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
                
                tnRoles.Text = objRow["RoleName"].ToString();
                tnRoles.ShowCheckBox = true;
                tnRoot.ChildNodes.Add(tnRoles);
            }

        }

        private void Button2_Click(object sender, System.EventArgs e)
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
            clsQxUserRoleRelationEN URrelation = new clsQxUserRoleRelationEN();
            //1循环角色树，把所有的选种角色取出来放到ArrayList当中
            ArrayList alRoles = new ArrayList();
            foreach (TreeNode tnboot in this.tvRoles.Nodes)
            {
                foreach (TreeNode tnRoles in tnboot.ChildNodes)
                {
                    string strRoleId = clsCommForWebForm.getNodeID_S(tnRoles);
                    if (tnRoles.Checked)
                    {
                        alRoles.Add(strRoleId);
                        tnRoles.Checked = false;
                    }
                }
            }

            if (this.cbChooseAll.Checked)
            {
                System.Data.DataTable UsersDT = (System.Data.DataTable)Session["UsersDt"];

                //循环Users的DataTable
                foreach (System.Data.DataRow row in UsersDT.Rows)
                {
                    string UserId = row.ItemArray[0].ToString().Trim();
                    clsQxUserRoleRelationBL.DelQxUserRoleRelationsByCond(" UserId = '" + UserId + "' and QxPrjId = '" + this.ddlPrjId.SelectedValue + "'");//把原来此人的角色全部删除
                    foreach (string Id in alRoles)
                    {
                        URrelation.UserId = UserId;
                        URrelation.RoleId = Id;
                        URrelation.QxPrjId = this.ddlPrjId.SelectedValue;
                        clsQxUserRoleRelationBL.AddNewRecordBySql2(URrelation);
                    }

                }

                this.lblShow.Text = "更新角色成功!";
            }
            else//没有全选，遍历DataGrid
            {
                foreach (DataGridItem di in this.dgUsers.Items)
                {
                    CheckBox cb = (CheckBox)di.FindControl("cb1");
                    if (cb != null && cb.Checked)		//判断CheckBox是否选中
                    {
                        string UserId = di.Cells[1].Text;
                        clsQxUserRoleRelationBL.DelQxUserRoleRelationsByCond(" UserId = '" + UserId + "' and QxPrjId = '" + this.ddlPrjId.SelectedValue + "'");//把原来此人的角色全部删除
                        foreach (string Id in alRoles)
                        {
                            URrelation.UserId = UserId;
                            URrelation.RoleId = Id;
                            URrelation.QxPrjId = this.ddlPrjId.SelectedValue;
                            clsQxUserRoleRelationBL.AddNewRecordBySql2(URrelation);
                            cb.Checked = false;
                        }

                    }
                }

                this.lblShow.Text = "更新角色成功!";
            }


        }

        private void btShowRoles_Click(object sender, System.EventArgs e)
        {
            //1 把选中人的所有角色Id都放到ArryList当中
            ArrayList alUserRoles = new ArrayList();
            foreach (DataGridItem di in this.dgUsers.Items)
            {
                CheckBox cb = (CheckBox)di.FindControl("cb1");
                if (cb != null && cb.Checked)		//判断CheckBox是否选中
                {
                    string UserId = di.Cells[1].Text;
                    System.Data.DataTable UsersRoleDT = clsQxUserRoleRelationBL.GetDataTable_QxUserRoleRelation("select * from QxUserRoleRelation where UserId = '" + UserId + "' ");
                    foreach (System.Data.DataRow row in UsersRoleDT.Rows)
                    {
                        alUserRoles.Add(row.ItemArray[2].ToString().Trim());
                    }

                    break;

                }
            }

            //2 遍历角色树，ArrayList中有的Id都打上钩
            foreach (TreeNode tnboot in this.tvRoles.Nodes)
            {
                foreach (TreeNode tnRoles in tnboot.ChildNodes)
                {
                    string strRoleId = clsCommForWebForm.getNodeID_S(tnRoles);
                    if (alUserRoles.Contains(strRoleId))
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

        protected void ddlPrjId_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.tvRoles.Nodes.Clear();
            this.ShowRolesTree(this.ddlPrjId.SelectedValue);
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