///----------------------
///生成代码版本：6.3.0.0
///生成日期：2008/07/25
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：7.1.0.0
///========================
///生成查询，修改，删除，添加记录的控制层代码

///生成控制层的控件变量名列表
using System;
using System.Data;
using System.Configuration;
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
using GeneralPlatform;
using System.Collections.Generic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.datetime;


namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmDataBaseType_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmDataBaseType_QUDI : System.Web.UI.Page
    {

        ///生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


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
                strSortDataBaseTypeBy = "DataBaseTypeId Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_DataBaseType();
                //3、设置表控件中字控件的ReadOnly属性，
                ///   使之只读，因为在修改功能中关键字是不能被修改的。
                wucDataBaseType1.SetKeyReadOnly(true);
                DispDataBaseTypeListRegion();
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
            this.gvDataBaseType.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_DataBaseType();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvDataBaseType_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvDataBaseType.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_DataBaseType();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strDataBaseTypeId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsDataBaseTypeEN objDataBaseType;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddDataBaseTypeRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddDataBaseTypeRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objDataBaseType = (clsDataBaseTypeEN)Session["objDataBaseType"];
                    UpdateDataBaseTypeRecordSave(objDataBaseType);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucDataBaseType1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            lblMsg_Edit.Text = "";
            //wucDataBaseType1.DataBaseTypeId = clsCommForWebForm.G1etMaxStrId("DataBaseType","DataBaseTypeId", 2, "");
            DispEditDataBaseTypeRegion();
        }

        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string>  arrDataBaseTypeId = clsCommForWebForm.GetAllCheckedItemFromGv(gvDataBaseType, "chkCheckRec");
            if (arrDataBaseTypeId == null || arrDataBaseTypeId.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsDataBaseTypeBL.DelDataBaseTypes(arrDataBaseTypeId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_DataBaseType();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            string strDataBaseTypeId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvDataBaseType);
            if (strDataBaseTypeId == null || strDataBaseTypeId.Trim().Length == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            UpdateDataBaseTypeRecord(strDataBaseTypeId);
        }
        ///生成组合查询条件的代码
        protected void gvDataBaseType_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortDataBaseTypeBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortDataBaseTypeBy = e.SortExpression + " Asc";
                BindGv_DataBaseType();
                return;
            }
            ///检查原来是升序
            intIndex = strSortDataBaseTypeBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortDataBaseTypeBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortDataBaseTypeBy = e.SortExpression + " Desc";
            }
            BindGv_DataBaseType();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortDataBaseTypeBy
        {
            get
            {
                string sSortDataBaseTypeBy;
                sSortDataBaseTypeBy = (string)ViewState["SortDataBaseTypeBy"];
                if (sSortDataBaseTypeBy == null)
                {
                    sSortDataBaseTypeBy = "";
                }
                return sSortDataBaseTypeBy;
            }
            set
            {
                string sSortDataBaseTypeBy = value;
                ViewState.Add("SortDataBaseTypeBy", sSortDataBaseTypeBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvDataBaseType.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvDataBaseType.PageCount)
                {
                    this.gvDataBaseType.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_DataBaseType();
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
                    BindGv_DataBaseType();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvDataBaseType_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvDataBaseType, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvDataBaseType, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvDataBaseType_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortDataBaseTypeBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvDataBaseType.Columns.Count; i++)
                {
                    strSortEx = this.gvDataBaseType.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortDataBaseTypeBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortDataBaseTypeBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvDataBaseType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strDataBaseTypeId = gvDataBaseType.DataKeys[e.RowIndex].Value.ToString();
            DeleteDataBaseTypeRecord(strDataBaseTypeId);
        }
        ///
        protected void gvDataBaseType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strDataBaseTypeId = gvDataBaseType.DataKeys[e.RowIndex].Value.ToString();
            UpdateDataBaseTypeRecord(strDataBaseTypeId);
        }
        ///删除记录过程代码for C#
        protected void gvDataBaseType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvDataBaseType.PageIndex = e.NewPageIndex;
                this.BindGv_DataBaseType();
            }
        }
        ///
        protected void btnCancelDataBaseTypeEdit_Click(object sender, EventArgs e)
        {
            DispDataBaseTypeListRegion();
        }

    }
    public partial class wfmDataBaseType_QUDI : System.Web.UI.Page
    {
        protected void ShowData(string strDataBaseTypeId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strDataBaseTypeId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsDataBaseTypeBL.IsExist(strDataBaseTypeId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strDataBaseTypeId + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsDataBaseTypeEN objDataBaseType = new clsDataBaseTypeEN(strDataBaseTypeId);
            //4、获取类对象的所有属性；
            try
            {
                clsDataBaseTypeBL.GetDataBaseType(ref objDataBaseType);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objDataBaseType", objDataBaseType);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromDataBaseTypeClass(objDataBaseType);
        }

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
        protected string CombineDataBaseTypeCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtDataBaseTypeId_q.Text.Trim() != "")
            {
                strWhereCond += " And DataBaseTypeId like '%" + this.txtDataBaseTypeId_q.Text.Trim() + "%'";
            }
            if (this.txtDataBaseTypeName_q.Text.Trim() != "")
            {
                strWhereCond += " And DataBaseTypeName like '%" + this.txtDataBaseTypeName_q.Text.Trim() + "%'";
            }
            if (this.txtMemo_q.Text.Trim() != "")
            {
                strWhereCond += " And Memo like '%" + this.txtMemo_q.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_DataBaseType()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //4、设置GridView的数据源(DataSource)；
            //5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombineDataBaseTypeCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsDataBaseTypeBL.GetDataTable_DataBaseType(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortDataBaseTypeBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvDataBaseType.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvDataBaseType.PageSize = 10;
            }
            this.gvDataBaseType.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvDataBaseType.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvDataBaseType.BottomPagerRow;
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
                lblAllPages.Text = this.gvDataBaseType.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvDataBaseType.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvDataBaseType.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvDataBaseType.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvDataBaseType.PageIndex == this.gvDataBaseType.PageCount - 1)
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
            gvDataBaseType.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjDataBaseType">表实体类对象</param>
        protected void GetDataFromDataBaseTypeClass(clsDataBaseTypeEN pobjDataBaseType)
        {
            wucDataBaseType1.DataBaseTypeId = pobjDataBaseType.DataBaseTypeId;//    数据库类型ID
            wucDataBaseType1.DataBaseTypeName = pobjDataBaseType.DataBaseTypeName;//    数据库类型名
            wucDataBaseType1.Memo = pobjDataBaseType.Memo;//    备注
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjDataBaseType">数据传输的目的类对象</param>
        protected void PutDataToDataBaseTypeClass(clsDataBaseTypeEN pobjDataBaseType)
        {
            pobjDataBaseType.DataBaseTypeId = wucDataBaseType1.DataBaseTypeId;//    数据库类型ID
            pobjDataBaseType.DataBaseTypeName = wucDataBaseType1.DataBaseTypeName;//    数据库类型名
            pobjDataBaseType.Memo = wucDataBaseType1.Memo;//    备注
        }

        ///生成从界面层到逻辑层的数据传输函数代码
        ///生成的插入记录准备过程代码for C#
        protected void AddDataBaseTypeRecord()
        {
            wucDataBaseType1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelDataBaseTypeEdit.Text = "取消添加";
            //wucDataBaseType1.DataBaseTypeId = clsCommForWebForm.G1etMaxStrId("DataBaseType","DataBaseTypeId", 2, "");
        }
        ///插入记录存盘过程代码for C#
        protected bool AddDataBaseTypeRecordSave()
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
            clsDataBaseTypeEN objDataBaseType;
            //1、检查控件中输入数据类型是否正确
            if (!wucDataBaseType1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsDataBaseTypeEN objDataBaseType;	//定义对象
            objDataBaseType = new clsDataBaseTypeEN(wucDataBaseType1.DataBaseTypeId);	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsDataBaseTypeBL.IsExist(objDataBaseType.DataBaseTypeId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToDataBaseTypeClass(objDataBaseType);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsDataBaseTypeBL.CheckPropertyNew(objDataBaseType);
                //6、把数据实体层的数据存贮到数据库中
                clsDataBaseTypeBL.AddNewRecordBySql2(objDataBaseType);
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
            BindGv_DataBaseType();
            DispDataBaseTypeListRegion();
            wucDataBaseType1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDataBaseTypeEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddDataBaseTypeRecordSaveV5()
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
            clsDataBaseTypeEN objDataBaseType;
            //1、检查控件中输入数据类型是否正确
            if (!wucDataBaseType1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsDataBaseTypeEN objDataBaseType;	//定义对象
            objDataBaseType = new clsDataBaseTypeEN(wucDataBaseType1.DataBaseTypeId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsDataBaseTypeBL.IsExist(objDataBaseType.DataBaseTypeId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToDataBaseTypeClass(objDataBaseType);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsDataBaseTypeBL.CheckPropertyNew(objDataBaseType);
                //6、把数据实体层的数据存贮到数据库中
                clsDataBaseTypeBL.AddNewRecordBySql2(objDataBaseType);
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
            BindGv_DataBaseType();
            DispDataBaseTypeListRegion();
            wucDataBaseType1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDataBaseTypeEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateDataBaseTypeRecord(string strDataBaseTypeId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strDataBaseTypeId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucDataBaseType1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelDataBaseTypeEdit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditDataBaseTypeRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateDataBaseTypeRecordSave(clsDataBaseTypeEN objDataBaseType)
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
            if (!wucDataBaseType1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToDataBaseTypeClass(objDataBaseType);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsDataBaseTypeBL.CheckPropertyNew(objDataBaseType);
                //4、把数据实体层的数据存贮到数据库中
                clsDataBaseTypeBL.UpdateBySql2(objDataBaseType);
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
            BindGv_DataBaseType();
            DispDataBaseTypeListRegion();
            wucDataBaseType1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDataBaseTypeEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateDataBaseTypeRecordSaveV5(clsDataBaseTypeEN objDataBaseType)
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
            if (!wucDataBaseType1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToDataBaseTypeClass(objDataBaseType);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsDataBaseTypeBL.CheckPropertyNew(objDataBaseType);
                //4、把数据实体层的数据存贮到数据库中
                clsDataBaseTypeBL.UpdateBySql2(objDataBaseType);
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
            BindGv_DataBaseType();
            DispDataBaseTypeListRegion();
            wucDataBaseType1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelDataBaseTypeEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteDataBaseTypeRecord(string strDataBaseTypeId)
        {
            try
            {
                clsDataBaseTypeBL.DelRecord(strDataBaseTypeId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_DataBaseType();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //1、组合界面条件串；
            string strWhereCond = CombineDataBaseTypeCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            string strFileName = "DataBaseType信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(conDataBaseType.DataBaseTypeId); arrCnName.Add("数据库类型ID");
            arrColName.Add(conDataBaseType.DataBaseTypeName); arrCnName.Add("数据库类型名");
            arrColName.Add(conDataBaseType.Memo); arrCnName.Add("备注");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                //2、根据条件串获取该表满足条件的DataTable；
                objDT = clsDataBaseTypeBL.GetDataTable_DataBaseType(strWhereCond);
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
        private void DispEditDataBaseTypeRegion()
        {
            tabDataBaseTypeGridView.Visible = false;
            tabEditDataBaseTypeRegion.Visible = true;
        }
        private void DispDataBaseTypeListRegion()
        {
            tabDataBaseTypeGridView.Visible = true;
            tabEditDataBaseTypeRegion.Visible = false;
        }
    }
}