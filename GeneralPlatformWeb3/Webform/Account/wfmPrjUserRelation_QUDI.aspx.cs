using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using GeneralPlatform;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;

using SpecData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmQxPrjUserRelation_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmQxPrjUserRelation_QUDI : System.Web.UI.Page
    {

        ///生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            //            clsPubVar.CheckUserSession();

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                vsViewName = "工程用户关系维护护";
                vsTabName = "vQxPrjUserRelation";
                ///生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
                switch (strPotenceLevel)
                {
                    case "全局级":
                        clsQxProjectsBLEx.Bindtv_Projects(tvProjects);
                        break;
                    case "项目级":
                        //QxPrjId =  getUserPrjId;
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
                switch (qsFunctionName)
                {
                    case "QxPrjUserRelation-Edit":// QxPrjUserRelation-Edit 工程用户关系-维护
                    case "PrjUserRelation-Edit":// QxPrjUserRelation-Edit 工程用户关系-维护
                        break;
                    default:
                        //ValidPotenceMode4();

                        string strMsg = string.Format("功能名:[{0}]在界面引导函数中没有处理，请检查！({1})",
                           qsFunctionName,
                           clsStackTrace.GetCurrClassFunction());
                        //lblTitleName.Text = strMsg;
                        clsCommonSession.PageName = "不正确的功能名称：";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                }
                clsDropDownList.BindDdl_DepartmentId4InUse(ddlDepartmentId_q1);
                clsDropDownList.BindDdl_DepartmentId4InUse(ddlDepartmentId_q2);
                //clsQxUserIdentityBLEx.BindDdl_IdentityId(ddlIdentityId_q2);
                //clsQxUserIdentityBLEx.BindDdl_IdentityId(ddlIdentityId_q);

                //1、为下拉框设置数据源，绑定列表数据
                strSortQxPrjUserRelationBy = "mId Asc";
                strSortUsersBy = "UserId Asc";

                //2、显示无条件的表内容在DATAGRID中
                BindGv_QxPrjUserRelation();
                //3、设置表控件中字控件的ReadOnly属性，
                ///   使之只读，因为在修改功能中关键字是不能被修改的。
                DispQxPrjUserRelationListRegion();
                divUsers.Visible = false;
            }
        }
        /// <summary>
        /// 当前操作的界面功能名称
        /// </summary>
        protected string vsViewName
        {
            get
            {
                string sViewName;
                sViewName = (string)ViewState["ViewName"];
                if (sViewName == null)
                {
                    sViewName = "";
                }
                return sViewName;
            }
            set
            {
                string sViewName = value;
                ViewState.Add("ViewName", sViewName);
            }
        }
        /// <summary>
        /// 当前操作的导出表名称
        /// </summary>
        protected string vsTabName
        {
            get
            {
                string sTabName;
                sTabName = (string)ViewState["TabName"];
                if (sTabName == null)
                {
                    sTabName = "";
                }
                return sTabName;
            }
            set
            {
                string sTabName = value;
                ViewState.Add("TabName", sTabName);
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
            this.gvQxPrjUserRelation.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_QxPrjUserRelation();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvQxPrjUserRelation_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvQxPrjUserRelation.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_QxPrjUserRelation();
        }
        
        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddUsersRecord();
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
            List<string>  arrmId = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxPrjUserRelation, "chkCheckRec");
            if (arrmId == null || arrmId.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsQxPrjUserRelationBL.DelQxPrjUserRelations(arrmId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxPrjUserRelation();
        }

        ///生成组合查询条件的代码
        protected void gvQxPrjUserRelation_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortQxPrjUserRelationBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortQxPrjUserRelationBy = e.SortExpression + " Asc";
                BindGv_QxPrjUserRelation();
                return;
            }
            ///检查原来是升序
            intIndex = strSortQxPrjUserRelationBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortQxPrjUserRelationBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortQxPrjUserRelationBy = e.SortExpression + " Desc";
            }
            BindGv_QxPrjUserRelation();
        }

        protected string strSortQxPrjUserRelationBy
        {
            get
            {
                string sSortQxPrjUserRelationBy;
                sSortQxPrjUserRelationBy = (string)ViewState["SortQxPrjUserRelationBy"];
                if (sSortQxPrjUserRelationBy == null)
                {
                    sSortQxPrjUserRelationBy = "";
                }
                return sSortQxPrjUserRelationBy;
            }
            set
            {
                string sSortQxPrjUserRelationBy = value;
                ViewState.Add("SortQxPrjUserRelationBy", sSortQxPrjUserRelationBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvQxPrjUserRelation.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvQxPrjUserRelation.PageCount)
                {
                    this.gvQxPrjUserRelation.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_QxPrjUserRelation();
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvQxPrjUserRelation_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvQxPrjUserRelation, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvQxPrjUserRelation, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvQxPrjUserRelation_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortQxPrjUserRelationBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvQxPrjUserRelation.Columns.Count; i++)
                {
                    strSortEx = this.gvQxPrjUserRelation.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortQxPrjUserRelationBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortQxPrjUserRelationBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvQxPrjUserRelation_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvQxPrjUserRelation.DataKeys[e.RowIndex].Value.ToString();
            long lngmId = long.Parse(strmId);
            DeleteQxPrjUserRelationRecord(lngmId);
        }
        ///删除记录过程代码for C#
        protected void gvQxPrjUserRelation_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvQxPrjUserRelation.PageIndex = e.NewPageIndex;
                this.BindGv_QxPrjUserRelation();
            }
        }
        ///
        protected void lbDispQxPrjUserRelationList_Click(object sender, EventArgs e)
        {
            DispQxPrjUserRelationListRegion();
        }

        protected void tvProjects_SelectedNodeChanged(object sender, EventArgs e)
        {
            string strPrjId = clsCommForWebForm.getNodeID_S(tvProjects.SelectedNode);
            getUserPrjId = strPrjId;
            if (strPrjId == "root")
            {
                lblQxPrjUserRelationList.Text = "泰泽公司所有用户信息列表";
            }
            else
            {
                string strPrjName = clsQxProjectsBL.GetPrjNameByQxPrjIdCache(strPrjId);
                lblQxPrjUserRelationList.Text = strPrjName + ":用户信息列表";
            }
            BindGv_QxPrjUserRelation();
        }
        protected void btnAddUser4CurrRole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getUserPrjId))
            {
                lblMsg_List.Text = "请选择一个有效的工程!";
                return;
            }
            divUsers.Visible = true;
            BindGv_QxUsers();
        }
        protected void btnDelQxUser4CurrRole_Click(object sender, EventArgs e)
        {
            List<string>  arrUserId = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxPrjUserRelation, "chkCheckRec");
            if (arrUserId == null || arrUserId.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            foreach (string strUserId in arrUserId)
            {
                clsQxPrjUserRelationBL.DelRecord(long.Parse(strUserId));
            }
            BindGv_QxPrjUserRelation();

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

                    AddUsersRecord(getUserPrjId, strUserId);

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
        protected void btnQuery4Users_Click(object sender, EventArgs e)
        {
            ///把DATAGRID的当前页索引设置为0，即第1页。
            ///当单击查询时，首先显示的是表记录内容的第一部分内容。
            this.gvUsers.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_QxUsers();
        }
}
    public partial class wfmQxPrjUserRelation_QUDI : System.Web.UI.Page
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
            set
            {
                string sPotenceLevel = value;
                ViewState.Add("PotenceLevel", sPotenceLevel);
            }
        }


        ///生成登录用户的用户名Session
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

        ///生成专门用于BINDgv中的跳页相关代码
        ///生成专门用于记录GridView中的每页记录数
        protected string PagePrjUserRelaSize
        {
            get
            {
                string strPagePrjUserRelaSize;
                strPagePrjUserRelaSize = (string)ViewState["PagePrjUserRelaSize"];
                if (strPagePrjUserRelaSize == null)
                {
                    strPagePrjUserRelaSize = "";
                }
                return strPagePrjUserRelaSize;
            }
            set
            {
                string strPagePrjUserRelaSize = value;
                ViewState.Add("PagePrjUserRelaSize", strPagePrjUserRelaSize);
            }
        }


        ///生成错误信息的Session属性
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
        protected string CombineQxPrjUserRelationCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (getUserPrjId != "" && getUserPrjId != "root")
            {
                strWhereCond += " And QxPrjId='" + getUserPrjId + "'";
            }
            if (this.ddlDepartmentId_q1.SelectedValue != "" && this.ddlDepartmentId_q1.SelectedValue != "0")
            {
                strWhereCond += " And DepartmentId='" + this.ddlDepartmentId_q1.SelectedValue + "'";
            }
            if (this.txtUserId_q.Text.Trim() != "")
            {
                strWhereCond += " And UserId like '" + this.txtUserId_q.Text.Trim() + "%'";
            }
            //if (this.ddlIdentityId_q.SelectedValue != "" && this.ddlIdentityId_q.SelectedValue != "0")
            //{
            //    strWhereCond += " And IdentityId='" + this.ddlIdentityId_q.SelectedValue + "'";
            //}
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_QxPrjUserRelation()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //4、设置GridView的数据源(DataSource)；
            //5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombineQxPrjUserRelationCondion();
            if (strWhereCond == " 1=1 ")
            {
                int intRecCount = clsQxPrjUserRelationBL.GetRecCountByCond(strWhereCond);
                if (intRecCount > 20000)
                {
                    string strMsg = "查询记录太多，请输入合适的条件！";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvQxPrjUserRelationBL.GetDataTable(strWhereCond);
                clsPubVar.InsertCard_State(objDT);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortQxPrjUserRelationBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用

            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PagePrjUserRelaSize) == false)
            {
                int intPageSize = int.Parse(PagePrjUserRelaSize);
                gvQxPrjUserRelation.PageSize = intPageSize;
            }
            else
            {
                PagePrjUserRelaSize = "10";
                gvQxPrjUserRelation.PageSize = 10;
            }
            
            this.gvQxPrjUserRelation.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvQxPrjUserRelation.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvQxPrjUserRelation.BottomPagerRow;
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
                lblAllPages.Text = this.gvQxPrjUserRelation.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvQxPrjUserRelation.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvQxPrjUserRelation.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvQxPrjUserRelation.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvQxPrjUserRelation.PageIndex == this.gvQxPrjUserRelation.PageCount - 1)
                {
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnNextPage.Enabled = true;
                }
                ddlPagerRecCount.Text = PagePrjUserRelaSize;
                this.gvQxPrjUserRelation.BottomPagerRow.Visible = true;
                gvQxPrjUserRelation.BottomPagerRow.HorizontalAlign = HorizontalAlign.Right;
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

        protected void ddlPagerRecCount_QxPrjUserRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlPagerRecCount = (DropDownList)sender;
            string strPageSize = ddlPagerRecCount.Text;
            if (clsDateTime.IsNumeric(strPageSize) == true)
            {
                int intPageSize = int.Parse(strPageSize);
                if (intPageSize >= 1)
                {
                    PagePrjUserRelaSize = intPageSize.ToString();
                    BindGv_QxPrjUserRelation();
                }
            }
        }
               
        ///删除记录过程代码for C#
        protected void DeleteQxPrjUserRelationRecord(long lngmId)
        {
            try
            {
                clsQxPrjUserRelationBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxPrjUserRelation();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //1、组合界面条件串；
            string strWhereCond = CombineQxPrjUserRelationCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QxPrjUserRelation信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxPrjUserRelation.QxPrjId); arrCnName.Add("项目编号");
            arrColName.Add(convQxPrjUserRelation.PrjName); arrCnName.Add("工程名");
            arrColName.Add(convQxPrjUserRelation.UserId); arrCnName.Add("用户ID");
            arrColName.Add(convQxPrjUserRelation.UserName); arrCnName.Add("用户名");
            arrColName.Add(convQxPrjUserRelation.DepartmentName); arrCnName.Add("部门名");
            arrColName.Add(convQxPrjUserRelation.UserStateName); arrCnName.Add("用户状态名");
            arrColName.Add(convQxPrjUserRelation.Memo); arrCnName.Add("备注");



            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx()
            {
                ViewName = vsViewName,
                TabName = vsTabName,
                ExportFileName = strFileName,
                UserId = clsCommonSession.UserId,
                UpdUserId = clsCommonSession.UserId,
                UpdDate = clsDateTime.getTodayStr(0),
                strPrjId = clsPubVar.strCurrPrjId4AgcCs,
                arrCnName = arrCnName,
                arrColName = arrColName
            };
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;
                arrCnName = objExportExcelSetENEx.arrCnName;
                arrColName = objExportExcelSetENEx.arrColName;
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }

            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                ///	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvQxPrjUserRelationBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);

            //strFolderName = clsSysParaEN.TempFileFolder;
            //strDownLoadFileName = strFolderName + strFileName;
            //try
            //{
            //    //2、根据条件串获取该表满足条件的DataTable；
            //    objDT = clsQxPrjUserRelationBL.GetQxPrjUserRelationV(strWhereCond);
            //    GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            //}
            //catch (Exception objException)
            //{
            //    ErrMessage = objException.Message;
            //    BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
            //    Response.Redirect(clsSysParaEN.ErrorPage);
            //}
            //clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        private void DispEditQxPrjUserRelationRegion()
        {
            tabQxPrjUserRelationGridView.Visible = false;
        }
        private void DispQxPrjUserRelationListRegion()
        {
            tabQxPrjUserRelationGridView.Visible = true;
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
            if (strWhereCond == " 1=1 ")
            {
                string strMsg = "查询记录太多，请输入合适的条件！";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvQxUsersBL.GetDataTable(strWhereCond);
                clsPubVar.InsertCard_State(objDT);
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
        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineUsersCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " UserId not in (select userid from QxPrjUserRelation where QxPrjId = '" + getUserPrjId + "')";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtUserId_q2.Text.Trim() != "")
            {
                strWhereCond += " And UserId like '%" + this.txtUserId_q2.Text.Trim() + "%'";
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
                clsQxPrjUserRelationBLEx.AddRecord(getUserPrjId, strUserId);
            }
            BindGv_QxUsers();
            BindGv_QxPrjUserRelation();
        }
        protected string strSortUsersBy
        {
            get
            {
                string sSortUsersBy;
                sSortUsersBy = (string)ViewState["SortUsersBy"];
                if (sSortUsersBy == null)
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
        private void AddUsersRecord(string strPrjId, string strUserId)
        {
            clsQxPrjUserRelationBLEx.AddRecord(getUserPrjId, strUserId);
            BindGv_QxUsers();
            BindGv_QxPrjUserRelation();
        }
        /// <summary>
        /// 判断权限方式4，该方式比较好，速度快一点，不需要一次次地到服务器去判断,获取的是标志名称
        /// </summary>
        /// <returns></returns>
        private bool ValidPotenceMode4()
        {

            if (string.IsNullOrEmpty(clsCommonSession.RoleId) == true)
            {
                string strMsg = "你没有登录，或者你登录时间太长，需要重新登录!";
                clsCommonJsFunc.ShowMessage(strMsg);
                //                Response.Write("<script>alert('" + strMsg + "')</script>");
                //string c1 = "<script language='javascript'>window.parent.location.href='/Index.aspx'; </script>";
                //Response.Write(c1);
                clsPubVar.Logout(this);
                return false;
            }

            if (string.IsNullOrEmpty(clsCommonSession.UserId) == true)
            {
                string strMsg = "你没有登录，或者你登录时间太长，需要重新登录!";
                clsCommonJsFunc.ShowMessage(strMsg);
                //                Response.Write("<script>alert('" + strMsg + "')</script>");
                //string c1 = "<script language='javascript'>window.parent.location.href='/Index.aspx'; </script>";
                //Response.Write(c1);
                clsPubVar.Logout(this);
                return false;
            }
            string strUserId = clsCommonSession.UserId;
            List<string> lstSymbolName = GeneralPlatform.BusinessLogicEx.clsQxUsersBLEx.GetSymbolNameLstByPotenceName(strUserId, "为项目设置用户", clsPubVar.strPrjId);
            if (lstSymbolName.Count == 0)
            {
                //string ss = clsArray.GetSqlInStrByArray(lstSymbolName, true);
                clsCommonSession.ErrMessage = "你没有为项目设置用户的权限！";
                //无权限
                Response.Redirect(clsSysParaEN.ErrorPage);
                return false;
            }
            if (lstSymbolName.Contains("全局级") == true)
            {
                //lblMsg_List.Text = "有校级权限";
                strPotenceLevel = "全局级";
                return true;

            }
            else if (lstSymbolName.Contains("项目级") == true)
            {
                strPotenceLevel = "项目级";
                return true;

            }


            else
            {
                clsCommonSession.ErrMessage = string.Format("你没有权限！或者你的权限不正确，请与管理员联系！({0})",
                    clsStackTrace.GetCurrClassFunction());
                Response.Redirect(clsSysParaEN.ErrorPage);
                return false;
            }

        }

        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName='{0}'", vsViewName);
            sbCondition.AppendFormat(" And TabName='{0}'", vsTabName);
            sbCondition.AppendFormat(" And UserId='{0}'", clsCommonSession.UserId);
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在系统中没有界面为'{0}'", vsViewName);
                sbMsg.AppendFormat("，表名='{0}'", vsTabName);
                sbMsg.AppendFormat("并且用户='{0}'的导出Excel用户设置，请与管理员联系！({1})",
                    clsCommonSession.UserId,
                    clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }

            StringBuilder sbScript = new StringBuilder();

            sbScript.Append("<script language='javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SystemSet/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users={0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left=50px,top=50px,status=no,width=920px,height=650px,scrollbars=yes'); </script>");

            Response.Write(sbScript.ToString());

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
        /// 功能名称。例如：“视频资源库-显示”、“视频资源库-后台编辑”、“教学案例资源库-显示”、“教学案例资源库-后台编辑”等
        ///         根据不同的功能名称，可能调用不同的页面
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsFunctionName
        {
            get
            {
                if (Request.QueryString["FunctionName"] != null)
                {
                    return Request.QueryString["FunctionName"].ToString().Trim();
                }
                return "";
            }
        }
    }
}

//                    switch (qsFunctionName)
//                    {
//                        case "QxPrjUserRelation-Edit":// QxPrjUserRelation-Edit 工程用户关系-维护
//                            break;
//                        default:
//                            string strMsg = string.Format("功能名:[{0}]在界面引导函数中没有处理，请检查！({1})",
//                               qsFunctionName,
//                               clsStackTrace.GetCurrClassFunction());
////lblTitleName.Text = strMsg;
//clsCommonSession.PageName = "不正确的功能名称：";
//                            clsCommonJsFunc.Alert(this, strMsg);
//                            return;
//}