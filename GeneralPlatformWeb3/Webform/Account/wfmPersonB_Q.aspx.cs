///----------------------
///生成代码版本：2011.05.08.1
///生成日期：2011/05/25
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
///========================
///生成查询修改记录的控制层代码

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
    /// wfmPerson_Q 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPersonB_Q : System.Web.UI.Page
    {

        ///生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {

                ///生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推

                // 在此处放置一些用户初始化界面的代码，例如设置下拉框的数据源等
                //wucPersonB1.SetDdl_TabName();
                //1、为下拉框设置数据源，绑定列表数据
                //2、显示无条件的表内容在DATAGRID中
                strSortPersonBy = "ACCOUNT Asc";
                BindGv_Person();
            }
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
            this.gvPerson.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_Person();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvPerson_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvPerson.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_Person();
        }
        ///生成组合查询条件的代码
        protected void gvPerson_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortPersonBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortPersonBy = e.SortExpression + " Asc";
                BindGv_Person();
                return;
            }
            ///检查原来是升序
            intIndex = strSortPersonBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortPersonBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortPersonBy = e.SortExpression + " Desc";
            }
            BindGv_Person();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortPersonBy
        {
            get
            {
                string sSortPersonBy;
                sSortPersonBy = (string)ViewState["SortPersonBy"];
                if (sSortPersonBy == null)
                {
                    sSortPersonBy = "";
                }
                return sSortPersonBy;
            }
            set
            {
                string sSortPersonBy = value;
                ViewState.Add("SortPersonBy", sSortPersonBy);
            }
        }

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvPerson.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvPerson.PageCount)
                {
                    this.gvPerson.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_Person();
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
                    BindGv_Person();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvPerson_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvPerson, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvPerson, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvPerson_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortPersonBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvPerson.Columns.Count; i++)
                {
                    strSortEx = this.gvPerson.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortPersonBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortPersonBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

       
        ///
        protected void gvPerson_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strACCOUNT = gvPerson.DataKeys[e.RowIndex]["ACCOUNT"].ToString();
        }
        ///删除记录过程代码for C#
        protected void gvPerson_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvPerson.PageIndex = e.NewPageIndex;
                this.BindGv_Person();
            }
        }

    }
    /// <summary>
    /// wfmPerson_Q 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmPersonB_Q : System.Web.UI.Page
    {

        ///生成权限等级的属性
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


        ///生成登录用户的用户名Session
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
        ///protected clsUsersEN objUser
        ///{
        ///get
        ///{
        ///clsUsersEN pobjUser;
        ///pobjUser = (clsUsersEN)Session["objUser"];
        ///if (pobjUser==null) 
        ///{
        ///pobjUser = null;
        ///}
        ///return pobjUser;
        ///}
        ///set
        ///{
        ///clsUsersEN pobjUser = value;
        ///Session.Add("objUser", pobjUser);
        ///}
        ///}


        ///生成专门用于BINDgv中的跳页相关代码


        ///生成错误信息的Session属性
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


        ///生成错误信息的Session属性
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


        ///生成返回链接串的Session属性
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

        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinePersonCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtACCOUNT_q.Text.Trim() != "")
            {
                strWhereCond += " And ACCOUNT like '%" + this.txtACCOUNT_q.Text.Trim() + "%'";
            }
            if (this.txtCARD_NO_q.Text.Trim() != "")
            {
                strWhereCond += " And CARD_NO like '%" + this.txtCARD_NO_q.Text.Trim() + "%'";
            }
            if (this.txtNAME_q.Text.Trim() != "")
            {
                strWhereCond += " And NAME like '%" + this.txtNAME_q.Text.Trim() + "%'";
            }
            if (this.txtSex_q.Text.Trim() != "")
            {
                strWhereCond += " And Sex like '%" + this.txtSex_q.Text.Trim() + "%'";
            }
            if (this.txtSTUDENT_ID_q.Text.Trim() != "")
            {
                strWhereCond += " And STUDENT_ID like '%" + this.txtSTUDENT_ID_q.Text.Trim() + "%'";
            }
            if (this.txtACADEMY_NO_q.Text.Trim() != "")
            {
                strWhereCond += " And ACADEMY_NO like '%" + this.txtACADEMY_NO_q.Text.Trim() + "%'";
            }
            if (this.txtGrade_q.Text.Trim() != "")
            {
                strWhereCond += " And Grade like '%" + this.txtGrade_q.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_Person()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //4、设置GridView的数据源(DataSource)；
            //5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombinePersonCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsPersonBL.GetDataTable_Person(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortPersonBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvPerson.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvPerson.PageSize = 10;
            }
            this.gvPerson.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvPerson.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvPerson.BottomPagerRow;
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
                lblAllPages.Text = this.gvPerson.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvPerson.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvPerson.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvPerson.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvPerson.PageIndex == this.gvPerson.PageCount - 1)
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
            gvPerson.BottomPagerRow.Visible = true;
        }


        ///生成从界面层到逻辑层的数据传输函数代码

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //1、组合界面条件串；
            string strWhereCond = CombinePersonCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            string strFileName = "Person_Q信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            //arrColName.Add(clsPersonEN.con_ACCOUNT); arrCnName.Add("明卡号");
            //arrColName.Add(clsPersonEN.con_SCH_ID); arrCnName.Add("学校统一编号");
            //arrColName.Add(clsPersonEN.con_BANK_ACC); arrCnName.Add("银行帐号");
            //arrColName.Add(clsPersonEN.con_CARD_NO); arrCnName.Add("卡号");
            //arrColName.Add(clsPersonEN.con_TEMP_CARD_NO); arrCnName.Add("临时卡卡号");
            //arrColName.Add(clsPersonEN.con_TEMP_USING); arrCnName.Add("临时卡使用标志");
            //arrColName.Add(clsPersonEN.con_TEMP_DEPOSIT); arrCnName.Add("临时卡押金");
            //arrColName.Add(clsPersonEN.con_Password); arrCnName.Add("口令");
            //arrColName.Add(clsPersonEN.con_MONEY); arrCnName.Add("余额");
            //arrColName.Add(clsPersonEN.con_CARD_KIND); arrCnName.Add("卡种类");
            //arrColName.Add(clsPersonEN.con_CARD_STATE); arrCnName.Add("卡状态");
            //arrColName.Add(clsPersonEN.con_LAST_TIME); arrCnName.Add("最近使用时间");
            //arrColName.Add(clsPersonEN.con_USEFUL_LIMIT); arrCnName.Add("有效期");
            //arrColName.Add(clsPersonEN.con_RECYCLE_LIMIT); arrCnName.Add("退役期");
            //arrColName.Add(clsPersonEN.con_NAME); arrCnName.Add("姓名");
            //arrColName.Add(clsPersonEN.con_Sex); arrCnName.Add("性别");
            //arrColName.Add(clsPersonEN.con_IDEN_NO); arrCnName.Add("身份标识");
            //arrColName.Add(clsPersonEN.con_NATION_NO); arrCnName.Add("民族");
            //arrColName.Add(clsPersonEN.con_POLITICS); arrCnName.Add("政治面貌");
            //arrColName.Add(clsPersonEN.con_Duty); arrCnName.Add("职务");
            //arrColName.Add(clsPersonEN.con_BIRTH); arrCnName.Add("出生年月");
            //arrColName.Add(clsPersonEN.con_PERSON_ID); arrCnName.Add("身份证号");
            //arrColName.Add(clsPersonEN.con_STUDENT_ID); arrCnName.Add("学生证号");
            //arrColName.Add(clsPersonEN.con_SCHOOL_NO); arrCnName.Add("学校编号");
            //arrColName.Add(clsPersonEN.con_ACADEMY_NO); arrCnName.Add("学院编号");
            //arrColName.Add(clsPersonEN.con_DEP_NO); arrCnName.Add("系别编号");
            //arrColName.Add(clsPersonEN.con_CLASS_NO); arrCnName.Add("班级编号");
            //arrColName.Add(clsPersonEN.con_IN_TIME); arrCnName.Add("入学年月");
            //arrColName.Add(clsPersonEN.con_WALLANCE); arrCnName.Add("补贴金额");
            //arrColName.Add(clsPersonEN.con_ADDRESS); arrCnName.Add("住址");
            //arrColName.Add(clsPersonEN.con_Phone); arrCnName.Add("电话");
            //arrColName.Add(clsPersonEN.con_POST_NO); arrCnName.Add("邮政编码");
            //arrColName.Add(clsPersonEN.con_POST_ADDRESS); arrCnName.Add("通信地址");
            //arrColName.Add(clsPersonEN.con_MAIL); arrCnName.Add("电子邮件");
            //arrColName.Add(clsPersonEN.con_DESCR); arrCnName.Add("描述");
            //arrColName.Add(clsPersonEN.con_USER_ID); arrCnName.Add("操作员代码");
            //arrColName.Add(clsPersonEN.con_OP_DATE); arrCnName.Add("操作日期");
            //arrColName.Add(clsPersonEN.con_ANNEX); arrCnName.Add("备注");
            //arrColName.Add(clsPersonEN.con_Grade); arrCnName.Add("年级");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                //2、根据条件串获取该表满足条件的DataTable；
                objDT = clsPersonBL.GetDataTable_Person(strWhereCond);
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
    }
}