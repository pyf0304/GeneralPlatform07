
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2013/01/18
///生成者：李玉龙
///工程名称：统一平台
///工程ID：0014
///模块中文名：工程文件下载
///模块英文名：PrjFileDownLoad
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.23.1
///========================
///生成查询，修改，删除，添加记录的控制层代码

///生成控制层的控件变量名列表
using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using CommFunc4WebForm;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.datetime;


namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmUserDownLoadLogB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmUserDownLoadLogB_QUDI : System.Web.UI.Page
    {

        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                //生成权限有关判断权限的代码
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
                string strPrjId = getUserPrjId;

                wucUserDownLoadLogB1.SetDdl_UserIdByPrjId(strPrjId);
                wucUserDownLoadLogB1.SetDdl_PrjSiteId(strPrjId);
                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);
                clsDropDownList.BindDdl_UserIdByPrjId(ddlUserId_q, strPrjId);
                if (strPrjId != "0001")
                {
                    ddlPrjId_q.SelectedValue = strPrjId;
                    ddlPrjId_q.Enabled = false;
                    //wucUserDownLoadLogB1.SetProjectEnabled(false);
                    //wucUserDownLoadLogB1.QxPrjId = getUserPrjId;
                }
                else
                {

                }
             
                strSortUserDownLoadLogBy = "PrjSiteName Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_QxUserDownLoadLog();
                //3、设置表控件中字控件的ReadOnly属性，
                //   使之只读，因为在修改功能中关键字是不能被修改的。
                //wucUserDownLoadLogB1.SetKeyReadOnly(true);
                DispUserDownLoadLogListRegion();
            }
        }

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把DATAGRID的当前页索引设置为0，即第1页。
            //当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvUserDownLoadLog.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_QxUserDownLoadLog();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvUserDownLoadLog_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvUserDownLoadLog.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_QxUserDownLoadLog();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strUserDownLoadLogId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsQxUserDownLoadLogEN objUserDownLoadLogEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddUserDownLoadLogRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddUserDownLoadLogRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objUserDownLoadLogEN = (clsQxUserDownLoadLogEN)Session["objUserDownLoadLogEN"];
                    UpdateUserDownLoadLogRecordSave(objUserDownLoadLogEN);
                    break;
            }
        }

        ///添加新记录的事件过程，建议在该过程中调用其他函数，不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddUserDownLoadLogRecord();
        }

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        ///删除当前被选记录
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvUserDownLoadLog, "chkCheckRec", "UserDownLoadLogId");
            if (lstKeyValues.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    string strUserDownLoadLogId = strKeys[0];
                    clsQxUserDownLoadLogBL.DelRecord(strUserDownLoadLogId);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxUserDownLoadLog();
        }

        /// <summary>
        ///修改当前被选记录
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvUserDownLoadLog, "UserDownLoadLogId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            string strUserDownLoadLogId = strKeys[0];
            UpdateUserDownLoadLogRecord(strUserDownLoadLogId);
        }
        protected void gvUserDownLoadLog_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortUserDownLoadLogBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortUserDownLoadLogBy = e.SortExpression + " Asc";
                BindGv_QxUserDownLoadLog();
                return;
            }
            //检查原来是升序
            intIndex = strSortUserDownLoadLogBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortUserDownLoadLogBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortUserDownLoadLogBy = e.SortExpression + " Desc";
            }
            BindGv_QxUserDownLoadLog();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortUserDownLoadLogBy
        {
            get
            {
                string sSortUserDownLoadLogBy;
                sSortUserDownLoadLogBy = (string)ViewState["SortUserDownLoadLogBy"];
                if (sSortUserDownLoadLogBy == null)
                {
                    sSortUserDownLoadLogBy = "";
                }
                return sSortUserDownLoadLogBy;
            }
            set
            {
                string sSortUserDownLoadLogBy = value;
                ViewState.Add("SortUserDownLoadLogBy", sSortUserDownLoadLogBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvUserDownLoadLog.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvUserDownLoadLog.PageCount)
                {
                    this.gvUserDownLoadLog.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_QxUserDownLoadLog();
            }
        }


        ///生成的改变GridView中每页记录数的下拉框相关函数
        protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PageSize = intPageSize.ToString();
                    BindGv_QxUserDownLoadLog();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvUserDownLoadLog_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvUserDownLoadLog, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvUserDownLoadLog, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvUserDownLoadLog_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortUserDownLoadLogBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvUserDownLoadLog.Columns.Count; i++)
                {
                    strSortEx = this.gvUserDownLoadLog.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortUserDownLoadLogBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortUserDownLoadLogBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvUserDownLoadLog_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strUserDownLoadLogId = gvUserDownLoadLog.DataKeys[e.RowIndex]["UserDownLoadLogId"].ToString();
            DeleteUserDownLoadLogRecord(strUserDownLoadLogId);
        }
        ///
        protected void gvUserDownLoadLog_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strUserDownLoadLogId = gvUserDownLoadLog.DataKeys[e.RowIndex]["UserDownLoadLogId"].ToString();
            UpdateUserDownLoadLogRecord(strUserDownLoadLogId);
        }
        ///删除记录过程代码for C#
        protected void gvUserDownLoadLog_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvUserDownLoadLog.PageIndex = e.NewPageIndex;
                this.BindGv_QxUserDownLoadLog();
            }
        }
        ///
        protected void btnCancelUserDownLoadLogEdit_Click(object sender, EventArgs e)
        {
            DispUserDownLoadLogListRegion();
        }

    }
    public partial class wfmUserDownLoadLogB_QUDI : System.Web.UI.Page
    {
        protected void ShowData(string strUserDownLoadLogId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strUserDownLoadLogId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsQxUserDownLoadLogBL.IsExist(strUserDownLoadLogId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strUserDownLoadLogId + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQxUserDownLoadLogEN objUserDownLoadLogEN = new clsQxUserDownLoadLogEN(strUserDownLoadLogId);
            //4、获取类对象的所有属性；
            try
            {
                clsQxUserDownLoadLogBL.GetQxUserDownLoadLog(ref objUserDownLoadLogEN);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objUserDownLoadLogEN", objUserDownLoadLogEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromQxUserDownLoadLogClass(objUserDownLoadLogEN);
        }

        //生成权限等级的属性
        protected string strPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        //生成登录用户的用户名Session
        /// <summary>
        /// 登录的用户ID，用于检查用户权限
        /// </summary>
        protected string UserId
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
        ///protected clsQxUsersEN objUser
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




        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// </summary>
        protected string PageSize
        {
            get
            {
                string strPageSize;
                strPageSize = (string)ViewState["PageSize"];
                if (strPageSize == null)
                {
                    strPageSize = "";
                }
                return strPageSize;
            }
            set
            {
                string strPageSize = value;
                ViewState.Add("PageSize", strPageSize);
            }
        }


        /// <summary>
        /// 错误信息的Session属性，该Session传递给显示出错页面，显示相应的错误内容。
        /// </summary>
        protected string ErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)Session["ErrMessage"];
                if (strErrMessage == null)
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


        //生成返回链接串的Session属性
        /// <summary>
        /// 返回链接串的Session属性，该Session用于告诉出错页面，哪一个页面是需要返回的页面。
        /// </summary>
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

        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineUserDownLoadLogCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlPrjId_q.SelectedValue != "" && this.ddlPrjId_q.SelectedValue != "0")
            {
                strWhereCond += string.Format(" And {0}='{1}'", convQxUserDownLoadLog.QxPrjId,
                    this.ddlPrjId_q.SelectedValue);
            }
            if (this.ddlUserId_q.SelectedValue != "" && this.ddlUserId_q.SelectedValue != "0")
            {
                strWhereCond += " And UserId='" + this.ddlUserId_q.SelectedValue + "'";
            }
            if (this.txtDownLownDate_q.Text.Trim() != "")
            {
                strWhereCond += " And DownLownDate like '%" + this.txtDownLownDate_q.Text.Trim() + "%'";
            }
           
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_QxUserDownLoadLog()
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineUserDownLoadLogCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvQxUserDownLoadLogBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortUserDownLoadLogBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvUserDownLoadLog.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvUserDownLoadLog.PageSize = 10;
            }
            this.gvUserDownLoadLog.DataSource = objDV;
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvUserDownLoadLog.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvUserDownLoadLog.BottomPagerRow;
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
                lblAllPages.Text = this.gvUserDownLoadLog.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvUserDownLoadLog.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvUserDownLoadLog.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvUserDownLoadLog.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvUserDownLoadLog.PageIndex == this.gvUserDownLoadLog.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
                //设置分页器中每页记录数的下拉框的值
                if (string.IsNullOrEmpty(PageSize) == false)
                {
                    ddlPagerRecCount.Text = PageSize;
                }
                else
                {
                    PageSize = "10";
                    ddlPagerRecCount.Text = PageSize;
                }
            }
            gvUserDownLoadLog.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjUserDownLoadLogEN">表实体类对象</param>
        protected void GetDataFromQxUserDownLoadLogClass(clsQxUserDownLoadLogEN pobjUserDownLoadLogEN)
        {
            wucUserDownLoadLogB1.UserId = pobjUserDownLoadLogEN.UserId;//    用户ID
            wucUserDownLoadLogB1.PrjSiteId = pobjUserDownLoadLogEN.PrjSiteId;//    工程站点Id
            wucUserDownLoadLogB1.DownLownDate = pobjUserDownLoadLogEN.DownLownDate;//    下载日期
            wucUserDownLoadLogB1.IsSuccess = pobjUserDownLoadLogEN.IsSuccess;//    是否成功
            wucUserDownLoadLogB1.LogInfo = pobjUserDownLoadLogEN.LogInfo;//    日志信息
            wucUserDownLoadLogB1.Memo = pobjUserDownLoadLogEN.Memo;//    备注
        }
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjUserDownLoadLogEN">数据传输的目的类对象</param>
        protected void PutDataToUserDownLoadLogClass(clsQxUserDownLoadLogEN pobjUserDownLoadLogEN)
        {
            pobjUserDownLoadLogEN.UserId = wucUserDownLoadLogB1.UserId;//    用户ID
            pobjUserDownLoadLogEN.PrjSiteId = wucUserDownLoadLogB1.PrjSiteId;//    工程站点Id
            pobjUserDownLoadLogEN.DownLownDate = wucUserDownLoadLogB1.DownLownDate;//    下载日期
            pobjUserDownLoadLogEN.IsSuccess = wucUserDownLoadLogB1.IsSuccess;//    是否成功
            pobjUserDownLoadLogEN.LogInfo = wucUserDownLoadLogB1.LogInfo;//    日志信息
            pobjUserDownLoadLogEN.Memo = wucUserDownLoadLogB1.Memo;//    备注
        }

        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddUserDownLoadLogRecord()
        {
            //wucUserDownLoadLogB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelUserDownLoadLogEdit.Text = "取消添加";
            //wucUserDownLoadLogB1.UserDownLoadLogId = clsCommForWebForm.G1etMaxStrId("UserDownLoadLog","UserDownLoadLogId", 8, "");
            DispEditUserDownLoadLogRegion();
        }
        ///插入记录存盘过程代码for C#
        protected bool AddUserDownLoadLogRecordSave()
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsQxUserDownLoadLogEN objUserDownLoadLogEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUserDownLoadLogB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQxUserDownLoadLogEN objUserDownLoadLogEN;	//定义对象
            objUserDownLoadLogEN = new clsQxUserDownLoadLogEN();	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsQxUserDownLoadLogBL.IsExist(objUserDownLoadLogEN.UserDownLoadLogId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUserDownLoadLogClass(objUserDownLoadLogEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                objUserDownLoadLogEN.UserDownLoadLogId = clsQxUserDownLoadLogBL.GetMaxStrId_S();
                clsQxUserDownLoadLogBL.CheckPropertyNew(objUserDownLoadLogEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxUserDownLoadLogBL.AddNewRecordBySql2(objUserDownLoadLogEN);
            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsg_Edit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_QxUserDownLoadLog();
            DispUserDownLoadLogListRegion();
            wucUserDownLoadLogB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserDownLoadLogEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddUserDownLoadLogRecordSaveV5()
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
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsQxUserDownLoadLogEN objUserDownLoadLogEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUserDownLoadLogB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQxUserDownLoadLogEN objUserDownLoadLogEN;	//定义对象
            objUserDownLoadLogEN = new clsQxUserDownLoadLogEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsQxUserDownLoadLogBL.IsExist(objUserDownLoadLogEN.UserDownLoadLogId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUserDownLoadLogClass(objUserDownLoadLogEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxUserDownLoadLogBL.CheckPropertyNew(objUserDownLoadLogEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxUserDownLoadLogBL.AddNewRecordBySql2(objUserDownLoadLogEN);
            }
            catch (Exception objException)
            {
                ErrMessage = "添加记录不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "添加记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsg_Edit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            BindGv_QxUserDownLoadLog();
            DispUserDownLoadLogListRegion();
            wucUserDownLoadLogB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserDownLoadLogEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateUserDownLoadLogRecord(string strUserDownLoadLogId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strUserDownLoadLogId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            //wucUserDownLoadLogB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelUserDownLoadLogEdit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditUserDownLoadLogRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateUserDownLoadLogRecordSave(clsQxUserDownLoadLogEN objUserDownLoadLogEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucUserDownLoadLogB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUserDownLoadLogClass(objUserDownLoadLogEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxUserDownLoadLogBL.CheckPropertyNew(objUserDownLoadLogEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQxUserDownLoadLogBL.UpdateBySql2(objUserDownLoadLogEN);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsg_Edit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_QxUserDownLoadLog();
            DispUserDownLoadLogListRegion();
            wucUserDownLoadLogB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserDownLoadLogEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateUserDownLoadLogRecordSaveV5(clsQxUserDownLoadLogEN objUserDownLoadLogEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucUserDownLoadLogB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUserDownLoadLogClass(objUserDownLoadLogEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxUserDownLoadLogBL.CheckPropertyNew(objUserDownLoadLogEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQxUserDownLoadLogBL.UpdateBySql2(objUserDownLoadLogEN);
            }
            catch (Exception objException)
            {
                ErrMessage = "修改记录不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "修改记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsg_Edit.Text = "修改记录成功!";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_QxUserDownLoadLog();
            DispUserDownLoadLogListRegion();
            wucUserDownLoadLogB1.Clear();//添空控件中的内容
            //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserDownLoadLogEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteUserDownLoadLogRecord(string strUserDownLoadLogId)
        {
            try
            {
                clsQxUserDownLoadLogBL.DelRecord(strUserDownLoadLogId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxUserDownLoadLog();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineUserDownLoadLogCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "UserDownLoadLog信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxUserDownLoadLog.UserDownLoadLogId); arrCnName.Add("用户下载日志Id");
            arrColName.Add(convQxUserDownLoadLog.PrjSiteId); arrCnName.Add("工程站点Id");
            arrColName.Add(convQxUserDownLoadLog.PrjSiteName); arrCnName.Add("工程站点名");
            arrColName.Add(convQxUserDownLoadLog.QxPrjId); arrCnName.Add("项目编号");
            arrColName.Add(convQxUserDownLoadLog.PrjName); arrCnName.Add("工程名");
            arrColName.Add(convQxUserDownLoadLog.UserId); arrCnName.Add("用户ID");
            arrColName.Add(convQxUserDownLoadLog.DownLownDate); arrCnName.Add("下载日期");
            arrColName.Add(convQxUserDownLoadLog.LogInfo); arrCnName.Add("日志信息");
            arrColName.Add(convQxUserDownLoadLog.IsSuccess); arrCnName.Add("是否成功");
            arrColName.Add(convQxUserDownLoadLog.FtpServer); arrCnName.Add("Ftp服务器");
            arrColName.Add(convQxUserDownLoadLog.FtpUserId); arrCnName.Add("Ftp用户Id");
            arrColName.Add(convQxUserDownLoadLog.FtpUserPassword); arrCnName.Add("Ftp用户口令");
            arrColName.Add(convQxUserDownLoadLog.Memo); arrCnName.Add("备注");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvQxUserDownLoadLogBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditUserDownLoadLogRegion()
        {
            tabUserDownLoadLogGridView.Visible = false;
            tabEditUserDownLoadLogRegion.Visible = true;
        }
        private void DispUserDownLoadLogListRegion()
        {
            tabUserDownLoadLogGridView.Visible = true;
            tabEditUserDownLoadLogRegion.Visible = false;
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