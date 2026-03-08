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
using System.Collections.Generic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmSetQxViewPotenceLevel 的摘要说明。
    /// </summary>
    public partial class wfmSetQxViewPotenceLevel : System.Web.UI.Page
    {
        ///生成有关的变量定义代码
        private const string ViewId = "00010403";       //界面编号


        private void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    //如果本界面是初次被调用，而不是单击按钮事件所调用
            {


                ///生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
                {
                    case "0":
                        Response.Redirect("../error.aspx");
                        break;
                    case "1":

                        break;
                    case "2":
                        this.ddlPrjId_q.Enabled = false;
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
                //2、显示无条件的表内容在DATAGRID中

                this.ddlPrjId_q.SelectedValue = clsCommonSession.UserPrjId;
                this.ddlPrjId_q_SelectedIndexChanged(this.ddlPrjId_q, new System.EventArgs());
                strSortViewInfoBy = "ViewId Asc";
                BindDg_QxViewInfo();

                this.BindCkbl_Level();
                this.BindTv_Treeview1();

                this.Table3.Visible = false;
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
            this.ddlPrjId_q.SelectedIndexChanged += new System.EventHandler(this.ddlPrjId_q_SelectedIndexChanged);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            this.dgViewInfo.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgViewInfo_ItemCreated);
            this.dgViewInfo.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgViewInfo_PageIndexChanged);
            this.dgViewInfo.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.dgViewInfo_SortCommand);
            this.btnViewInfoPrevPage.Click += new System.EventHandler(this.btnViewInfoPrevPage_Click);
            this.btnViewInfoNextPage.Click += new System.EventHandler(this.btnViewInfoNextPage_Click);
            this.btnViewInfoJumpPage.Click += new System.EventHandler(this.btnViewInfoJumpPage_Click);
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion

        ///生成权限等级的属性
        private string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    sPotenceLevel = new MenuAndPotence().Get_PotenceLevel(ViewId);
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
                if (strUserId == null)
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





        ///生成专门用于BINDDG中的跳页相关代码

        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombineCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtViewId_q.Text.Trim() != "")
            {
                strWhereCond += " And ViewId='" + this.txtViewId_q.Text.Trim() + "'";
            }
            if (this.txtViewName_q.Text.Trim() != "")
            {
                strWhereCond += " And ViewName='" + this.txtViewName_q.Text.Trim() + "'";
            }
            if (this.txtViewCnName_q.Text.Trim() != "")
            {
                strWhereCond += " And ViewCnName='" + this.txtViewCnName_q.Text.Trim() + "'";
            }
            if (this.txtFileName_q.Text.Trim() != "")
            {
                strWhereCond += " And FileName='" + this.txtFileName_q.Text.Trim() + "'";
            }
            if (this.txtFilePath_q.Text.Trim() != "")
            {
                strWhereCond += " And FilePath='" + this.txtFilePath_q.Text.Trim() + "'";
            }
            if (this.txtViewTypeCode_q.Text.Trim() != "")
            {
                strWhereCond += " And ViewTypeCode='" + this.txtViewTypeCode_q.Text.Trim() + "'";
            }
            if (this.txtUserID_q.Text.Trim() != "")
            {
                strWhereCond += " And UserID='" + this.txtUserID_q.Text.Trim() + "'";
            }
            //			if (this.ddlPrjId_q.SelectedValue!="" && this.ddlPrjId_q.SelectedValue!="0")
            //			{
            strWhereCond += " And QxPrjId='" + this.ddlPrjId_q.SelectedValue + "'";
            //			}
            if (this.txtViewFunction_q.Text.Trim() != "")
            {
                strWhereCond += " And ViewFunction='" + this.txtViewFunction_q.Text.Trim() + "'";
            }
            if (this.txtViewDetail_q.Text.Trim() != "")
            {
                strWhereCond += " And ViewDetail='" + this.txtViewDetail_q.Text.Trim() + "'";
            }
            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_QxViewInfo()
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
            System.Data.DataTable objDT = clsvQxViewInfoBL.GetDataTable(strWhereCond);
            //3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            ///		3.1 首先计算页数；
            ///		3.2 如果当前页大于页数就为最后一页
            int intPages = CalcPages(objDT.Rows.Count, this.dgViewInfo.PageSize);
            if (intPages == 0)
            {
                this.dgViewInfo.CurrentPageIndex = 0;
            }
            else if (this.dgViewInfo.CurrentPageIndex > intPages - 1)
            {
                this.dgViewInfo.CurrentPageIndex = intPages - 1;
            }
            //4、设置DATAGRID的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortViewInfoBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
			this.dgViewInfo.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.dgViewInfo.DataBind();

            ///生成专门用于BINDDG中的跳页相关代码
            //当前记录数
            this.lblViewInfoRecCount.Text = objDT.Rows.Count.ToString();
            //当前页数
            this.lblViewInfoAllPages.Text = this.dgViewInfo.PageCount.ToString();
            //当前页序数
            this.lblViewInfoCurrentPage.Text = (this.dgViewInfo.CurrentPageIndex + 1).ToString();
            //当前即将跳到的页序数
            this.txtViewInfoJump2Page.Text = (this.dgViewInfo.CurrentPageIndex + 1).ToString();
            //如果当前页序数为0，则<前一页>按钮无效
            if (this.dgViewInfo.CurrentPageIndex == 0)
            {
                this.btnViewInfoPrevPage.Enabled = false;
            }
            else
            {
                this.btnViewInfoPrevPage.Enabled = true;
            }
            //如果当前页序数已为最后一页，则<前一页>按钮无效
            if (this.dgViewInfo.CurrentPageIndex == this.dgViewInfo.PageCount - 1)
            {
                this.btnViewInfoNextPage.Enabled = false;
            }
            else
            {
                this.btnViewInfoNextPage.Enabled = true;
            }
            //7决定下面部分显示不显示 ，如果当前DataGrid中的记录数为0，则不显示当前的跳页工具栏
            if (objDT.Rows.Count > 0)
            {
                this.tabViewInfoJumpPage.Visible = true;
            }
            else
            {
                this.tabViewInfoJumpPage.Visible = false;
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
            this.dgViewInfo.CurrentPageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindDg_QxViewInfo();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void dgViewInfo_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.dgViewInfo.CurrentPageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindDg_QxViewInfo();
        }

        ///生成组合查询条件的代码
        private void dgViewInfo_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortViewInfoBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortViewInfoBy = e.SortExpression + " Asc";
                BindDg_QxViewInfo();
                return;
            }
            ///检查原来是升序
            intIndex = strSortViewInfoBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                strSortViewInfoBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
			{
                strSortViewInfoBy = e.SortExpression + " Desc";
            }
            BindDg_QxViewInfo();
        }

        private string strSortViewInfoBy
        {
            get
            {
                string sSortViewInfoBy;
                sSortViewInfoBy = (string)ViewState["SortViewInfoBy"];
                if (sSortViewInfoBy == null)
                {
                    sSortViewInfoBy = "";
                }
                return sSortViewInfoBy;
            }
            set
            {
                string sSortViewInfoBy = value;
                ViewState.Add("SortViewInfoBy", sSortViewInfoBy);
            }
        }
        private void dgViewInfo_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            int intIndex;
            if (strSortViewInfoBy == "") return;
            if (e.Item.ItemType == ListItemType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.dgViewInfo.Columns.Count; i++)
                {
                    strSortEx = this.dgViewInfo.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortViewInfoBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortViewInfoBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Item.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///生成父对象的SESSION相关属性函数
        protected void btnViewInfoPrevPage_Click(object sender, System.EventArgs e)
        {
            this.dgViewInfo.CurrentPageIndex -= 1;
            this.BindDg_QxViewInfo();
        }

        protected void btnViewInfoNextPage_Click(object sender, System.EventArgs e)
        {
            this.dgViewInfo.CurrentPageIndex += 1;
            this.BindDg_QxViewInfo();
        }

        protected void btnViewInfoJumpPage_Click(object sender, System.EventArgs e)
        {
            if (this.txtViewInfoJump2Page.Text.Trim() != "" &&
                int.Parse(this.txtViewInfoJump2Page.Text) > 0 &&
                int.Parse(this.txtViewInfoJump2Page.Text) - 1 < this.dgViewInfo.PageCount)
            {
                this.dgViewInfo.CurrentPageIndex = int.Parse(this.txtViewInfoJump2Page.Text) - 1;
            }
            this.BindDg_QxViewInfo();
        }



        public void BindCkbl_Level()
        {
            for (int i = 1; i <= 5; i++)
            {
                this.CheckBoxList1.Items.Add(i.ToString());
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (this.dgViewInfo.SelectedIndex != -1)
            {
                string ViewId = this.dgViewInfo.SelectedItem.Cells[0].Text;

                int CheckedLevelCount = new clsCheckBoxList(this.CheckBoxList1).CheckItemArr.Count;
                if (CheckedLevelCount == 0)
                {
                    this.Label1.Text = "请选择一个权限等级编号！";
                }
                else if (CheckedLevelCount > 1)
                {
                    this.Label1.Text = "请一次只选择一个权限等级编号！";
                }
                else
                {
                    this.Label1.Text = "";
                    string Level = new clsCheckBoxList(this.CheckBoxList1).CheckItemArr[0].ToString();

                    List<string> objArr = clsQxViewPotenceBL.GetFldValue(clsQxViewPotenceEN._CurrTabName, "PotenceId", " ViewId = '" + ViewId + "' and Level =" + Level);

                    new clsTreeViewBindDblTable(this.TreeView1).CheckedLevel2NodesIDArr = objArr;



                }

            }
            else
            {
                this.Label1.Text = "请选择您要维护权限等级的界面！";
            }


        }



        private void BindTv_Treeview1()
        {
            string strPrjId = this.ddlPrjId_q.SelectedValue;
            clsTreeViewBindDblTable objTv1 = new clsTreeViewBindDblTable(this.TreeView1)
            {
                RootTitle = "请选择需要配置界面等级的权限：",
                ExpandLevel = 2,
                Level1DataSource = clsQxPotenceTypeBL.GetDataTable_QxPotenceType(" QxPrjId = '" + strPrjId + "'"),
                Level1NameField = "PotenceTypeName",
                Level1ValueField = "PotenceTypeId",
                Level1CheckBox = false,
                Level2DataSource = clsQxPrjPotenceBL.GetDataTable_QxPrjPotence(" QxPrjId = '" + strPrjId + "'"),
                Level2NameField = "PotenceName",
                Level2ValueField = "PotenceId",
                Level1IDFieldInLevel2DataSource = "PotenceTypeId"
            };
            objTv1.DataBind();

        }

        protected void ddlPrjId_q_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.BindTv_Treeview1();
            this.BindDg_QxViewInfo();
        }

        private bool SetPotenceLevelForView(string ViewId, string PotenceId, int Level, string strPrjId)
        {
            if (strPrjId != "" && clsQxProjectsBL.IsExist(this.ddlPrjId_q.SelectedValue)
                && ViewId != "" && clsQxViewInfoBL.IsExist(ViewId)
                && PotenceId != "" && clsQxPrjPotenceBL.IsExist(PotenceId)
                && Level > 0)
            {
                if (!clsQxViewPotenceBL.IsExistRecord(" ViewId = '" + ViewId + "' and Level =" + Level + " and QxPrjId ='" + strPrjId + "'"))
                {
                    clsQxViewPotenceEN objQxViewPotence = new clsQxViewPotenceEN()
                    {
                        QxPrjId = strPrjId,
                        ViewId = ViewId,
                        PotenceId = PotenceId,
                        Level = Level
                    };

                    return clsQxViewPotenceBL.AddNewRecordBySql2(objQxViewPotence);

                }
                else
                {


                    if (clsQxViewPotenceBL.SetFldValue(clsQxViewPotenceEN._CurrTabName, "PotenceId", PotenceId, " ViewId = '" + ViewId + "' and Level =" + Level + " and QxPrjId ='" + strPrjId + "'") > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }


            }
            else
            {
                return false;
            }


        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            if (this.dgViewInfo.SelectedIndex != -1)
            {
                string ViewId = this.dgViewInfo.SelectedItem.Cells[0].Text;

                int CheckedTreeNodeCount = new clsTreeViewBindDblTable(this.TreeView1).CheckedLevel2NodesIDArr.Count;
                if (CheckedTreeNodeCount == 0)
                {
                    this.Label1.Text = "请选择一个权限名称！";
                }
                else if (CheckedTreeNodeCount > 1)
                {
                    this.Label1.Text = "请一次只选择一个权限名称！";

                }
                else
                {

                    string PotenceId = new clsTreeViewBindDblTable(this.TreeView1).CheckedLevel2NodesIDArr[0].ToString();
                    int CheckedLevelCount = new clsCheckBoxList(this.CheckBoxList1).CheckItemArr.Count;
                    if (CheckedLevelCount == 0)
                    {
                        this.Label1.Text = "请选择一个权限等级编号！";
                    }
                    else if (CheckedLevelCount > 1)
                    {
                        this.Label1.Text = "请一次只选择一个权限等级编号！";
                    }
                    else
                    {
                        int Level = int.Parse(new clsCheckBoxList(this.CheckBoxList1).CheckItemArr[0].ToString());

                        if (this.SetPotenceLevelForView(ViewId, PotenceId, Level, this.ddlPrjId_q.SelectedValue))
                        {
                            this.Label1.Text = "操作成功！！";

                        }
                        else
                        {
                            this.Label1.Text = "操作失败！可能原来就已设定过该权限！";

                        }
                    }

                }

            }
            else
            {
                this.Label1.Text = "请选择您要维护权限等级的界面！";
            }
        }




    }
}
