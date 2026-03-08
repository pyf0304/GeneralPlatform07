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
using com.taishsoft.common;
using CommFunc4WebForm;
using GeneralPlatform.BusinessLogic;
using GeneralPlatformLogic;
using System.Collections.Generic;
using GeneralPlatform;

public partial class Webform_Temp_wucUserRoleRelation2GV : System.Web.UI.UserControl
{
    ///生成登录用户的用户名Session
    /// <summary>
    /// 登录的用户ID，用于检查用户权限
    /// </summary>
    public string WhereCond
    {
        get
        {
            string strWhereCond;
            strWhereCond = (string)ViewState["WhereCond"];
            if (strWhereCond == null)
            {
                strWhereCond = "";
            }
            return strWhereCond;
        }
        set
        {
            string strWhereCond = value;
            ViewState.Add("WhereCond", strWhereCond);
        }
    }

   

    public int PageIndex
    {
        set { gvUserRoleRelation2.PageIndex = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    ///生成组合查询条件的代码
    protected void gvUserRoleRelation2_Sorting(object sender, GridViewSortEventArgs e)
    {
        int intIndex;
        ///判断是否是新的排序字段
        intIndex = strSortUserRoleRelation2By.IndexOf(e.SortExpression);
        if (intIndex == -1)
        {
            strSortUserRoleRelation2By = e.SortExpression + " Asc";
            BindGv_UserRoleRelation2();
            return;
        }
        ///检查原来是升序
        intIndex = strSortUserRoleRelation2By.IndexOf(" Asc");
        if (intIndex == -1)		///如果原来不是升序就设置为升序
        {
            strSortUserRoleRelation2By = e.SortExpression + " Asc";
        }
        else			///否则设置为降序
        {
            strSortUserRoleRelation2By = e.SortExpression + " Desc";
        }
        BindGv_UserRoleRelation2();
    }

    /// <summary>
    /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
    /// </summary>
    protected string strSortUserRoleRelation2By
    {
        get
        {
            string sSortUserRoleRelation2By;
            sSortUserRoleRelation2By = (string)ViewState["SortUserRoleRelation2By"];
            if (sSortUserRoleRelation2By == null)
            {
                sSortUserRoleRelation2By = "";
            }
            return sSortUserRoleRelation2By;
        }
        set
        {
            string sSortUserRoleRelation2By = value;
            ViewState.Add("SortUserRoleRelation2By", sSortUserRoleRelation2By);
        }
    }

    ///生成与跳页的相关函数
    protected void btnJumpPage_Click(object sender, EventArgs e)
    {
        GridViewRow pagerRow = gvUserRoleRelation2.BottomPagerRow;
        TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
        if (txtJump2Page != null)
        {
            if (txtJump2Page.Text.Trim() != "" &&
            int.Parse(txtJump2Page.Text) > 0 &&
            int.Parse(txtJump2Page.Text) - 1 < this.gvUserRoleRelation2.PageCount)
            {
                this.gvUserRoleRelation2.PageIndex = int.Parse(txtJump2Page.Text) - 1;
            }
            this.BindGv_UserRoleRelation2();
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
                BindGv_UserRoleRelation2();
            }
        }
    }

    ///生成GridView行命令的事件代码
    protected void gvUserRoleRelation2_RowCommand(object sender, GridViewCommandEventArgs e)
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
                    clsCommForWebForm.Set_GridViewAllChecked(gvUserRoleRelation2, true);
                    lbSelAll.Text = "不选";
                }
                else if (lbSelAll.Text == "不选")
                {
                    clsCommForWebForm.Set_GridViewAllChecked(gvUserRoleRelation2, false);
                    lbSelAll.Text = "全选";
                }
                break;
        }
    }
    ///删除记录过程代码for C#
    protected void gvUserRoleRelation2_RowCreated(object sender, GridViewRowEventArgs e)
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
        if (strSortUserRoleRelation2By == "") return;
        if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
        {
            string strSortEx;
            for (int i = 0; i < this.gvUserRoleRelation2.Columns.Count; i++)
            {
                strSortEx = this.gvUserRoleRelation2.Columns[i].SortExpression;
                if (strSortEx == "") continue;
                intIndex = strSortUserRoleRelation2By.IndexOf(strSortEx);
                if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                {
                    Label lblSort = new Label();
                    lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                    intIndex = strSortUserRoleRelation2By.IndexOf("Asc");
                    lblSort.Text = (intIndex > 0 ? " 5" : " 6");//是否为升序，而且为string型；
                    e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                    break;
                }
            }
        }
    }

    ///
    protected void gvUserRoleRelation2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string strUserId = gvUserRoleRelation2.DataKeys[e.RowIndex]["UserId"].ToString();
        string strRoleId = gvUserRoleRelation2.DataKeys[e.RowIndex]["RoleId"].ToString();
        //DeleteUserRoleRelation2Record(strUserId, strRoleId);
    }
    ///
    protected void gvUserRoleRelation2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string strUserId = gvUserRoleRelation2.DataKeys[e.RowIndex]["UserId"].ToString();
        string strRoleId = gvUserRoleRelation2.DataKeys[e.RowIndex]["RoleId"].ToString();
        //UpdateUserRoleRelation2Record(strUserId, strRoleId);
    }
    ///删除记录过程代码for C#
    protected void gvUserRoleRelation2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        if (e.NewPageIndex != -1)
        {
            gvUserRoleRelation2.PageIndex = e.NewPageIndex;
            this.BindGv_UserRoleRelation2();
        }
    }
    ///生成绑定GridView的代码
    /// <summary>
    /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
    ///			 并显示在GridView中。
    /// </summary>
    public void BindGv_UserRoleRelation2()
    {
        ///	操作步骤：(共5步)
        ///	1、组合界面条件串；
        ///	2、根据条件串获取该表满足条件的DataTable；
        ///	4、设置GridView的数据源(DataSource)；
        ///	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
        ///	6、设置记录数的状态，
        ///		在本界面中是把状态显示在控件txtRecCount中。

        ///	1、组合界面条件串；
        string strWhereCond = WhereCond;// CombineUserRoleRelation2Condion();
        ///	2、根据条件串获取该表满足条件的DataTable；
        System.Data.DataTable objDT = null;
        try
        {
            objDT = clsUserRoleRelation2BL.GetDataTable_UserRoleRelation2(strWhereCond);
        }
        catch (Exception objException)
        {
            new clsCommonSession().ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
            new clsCommonSession().BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            Response.Redirect(clsSysPara.ErrorPage);
        }
        ///	4、设置GRIDView的数据源(DataSource)；
        DataView objDV = objDT.DefaultView;
        objDV.Sort = strSortUserRoleRelation2By;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
        ///设置GridView中每页的记录数
        if (string.IsNullOrEmpty(PageSize) == false)
        {
            int intPageSize = int.Parse(PageSize);
            gvUserRoleRelation2.PageSize = intPageSize;
        }
        else
        {
            PageSize = "10";
            gvUserRoleRelation2.PageSize = 10;
        }
        this.gvUserRoleRelation2.DataSource = objDV;
        ///	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
        this.gvUserRoleRelation2.DataBind();

        ///生成专门用于BindGv中的跳页相关代码
        GridViewRow pagerRow = gvUserRoleRelation2.BottomPagerRow;
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
            lblAllPages.Text = this.gvUserRoleRelation2.PageCount.ToString();
            //当前页序数
            lblCurrentPage.Text = (this.gvUserRoleRelation2.PageIndex + 1).ToString();
            //当前即将跳到的页序数
            txtJump2Page.Text = (this.gvUserRoleRelation2.PageIndex + 1).ToString();
            //如果当前页序数为0，则<前一页>按钮无效
            if (this.gvUserRoleRelation2.PageIndex == 0)
            {
                btnPrevPage.Enabled = false;
            }
            else
            {
                btnPrevPage.Enabled = true;
            }
            //如果当前页序数已为最后一页，则<前一页>按钮无效
            if (this.gvUserRoleRelation2.PageIndex == this.gvUserRoleRelation2.PageCount - 1)
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
        gvUserRoleRelation2.BottomPagerRow.Visible = true;
    }
    ///protected clsUsers objUser
    ///{
    ///get
    ///{
    ///clsUsers pobjUser;
    ///pobjUser = (clsUsers)Session["objUser"];
    ///if (pobjUser==null) 
    ///{
    ///pobjUser = null;
    ///}
    ///return pobjUser;
    ///}
    ///set
    ///{
    ///clsUsers pobjUser = value;
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
    /// <summary>
    /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
    ///			  具体功能是重新显示新页(所单击页索引)的内容。
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void gvUserRoleRelation2_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        ///操作步骤：（共2步）
        ///1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
        ///2、重新绑定DATAGRID，使之内容更新，变化到新的页

        ///1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
        this.gvUserRoleRelation2.PageIndex = e.NewPageIndex;
        ///2、重新绑定DATAGRID，使之内容更新，变化到新的页
        BindGv_UserRoleRelation2();
    }
    public List<string> GetFirstCheckedItemFromGv()
    {
        List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvUserRoleRelation2, "UserId", "RoleId");
        return lstKeyValue;
    }
    public List<string> GetAllCheckedItemFromGv()
    {
        List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvUserRoleRelation2, "chkCheckRec", "UserId", "RoleId");
        return lstKeyValues;
    }
}

