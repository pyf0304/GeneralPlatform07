
///----------------------
///生成代码版本：2012.01.02.1
///生成日期：2012/02/26
///生成者：潘以锋
///工程名称：统一平台
///工程ID：0014
///模块中文名：菜单管理
///模块英文名：
///注意：1、需要数据底层（PubDataBase.dll）的版本：2011.05.08.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2011.05.08.1
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
using System.Text;
using GeneralPlatform;
using com.taishsoft.datetime;


using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmQxRoleMenusB_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmQxRoleMenusB_QUDI : System.Web.UI.Page
    {

        ///生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                vsViewName = "角色菜单维护";
                vsTabName = "vQxRoleMenus";
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
                string strPrjId = getUserPrjId;
                //1、为下拉框设置数据源，绑定列表数据
                wucQxRoleMenusB1.SetDdl_QxPrjId();
                wucQxRoleMenusB1.SetDdl_RoleId(strPrjId);

               
                wucQxRoleMenusB1.SetDdl_MenuId(strPrjId);

                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);

                clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlPrjMenuSet, strPrjId);
                string strDefaultMenuSetId = clsQxPrjMenuSetBLEx.GetDefaultMenuSetIdByPrjId(strPrjId);
                if (string.IsNullOrEmpty(strDefaultMenuSetId) == false)
                {
                    ddlPrjMenuSet.SelectedValue = strDefaultMenuSetId;
                }
                clsQxPrjMenusBLEx.BindDdl_MenuIdEx(ddlMenuId_q, strPrjId);
                clsQxRolesBLEx.BindDdl_RoleIdEx(ddlRoleId_q, strPrjId);

                if (getUserPrjId != "0001")
                {
                    ddlPrjId_q.SelectedValue = strPrjId;
                    ddlPrjId_q.Enabled = false;
                    wucQxRoleMenusB1.SetDdl_MenuId(strPrjId);
                }
                else
                {
                    ddlPrjId_q.SelectedValue = strPrjId;
                    wucQxRoleMenusB1.SetDdl_MenuId(strPrjId);
                }


                strSortQxRoleMenusBy = "mId Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_QxRoleMenus();
                //3、设置表控件中字控件的ReadOnly属性，
                ///   使之只读，因为在修改功能中关键字是不能被修改的。
                DispQxRoleMenusListRegion();
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
            this.gvQxRoleMenus.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_QxRoleMenus();
            ShowMenu();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvQxRoleMenus_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvQxRoleMenus.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_QxRoleMenus();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="lngmId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsQxRoleMenusEN objQxRoleMenusEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddQxRoleMenusRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddQxRoleMenusRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objQxRoleMenusEN = (clsQxRoleMenusEN)Session["objQxRoleMenusEN"];
                    UpdateQxRoleMenusRecordSave(objQxRoleMenusEN);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            btnOKUpd.Text = "确认添加";
            lblMsg_Edit.Text = "";
            //wucQxRoleMenusB1.mId = clsCommForWebForm.G1etMaxStrId("QxRoleMenus","mId", 8, "");
            DispEditQxRoleMenusRegion();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxRoleMenus, "chkCheckRec", "mId");
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
                    long lngmId = long.Parse(strKeys[0]);
                    clsQxRoleMenusBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxRoleMenus();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvQxRoleMenus, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateQxRoleMenusRecord(lngmId);
        }
        ///生成组合查询条件的代码
        protected void gvQxRoleMenus_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortQxRoleMenusBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortQxRoleMenusBy = e.SortExpression + " Asc";
                BindGv_QxRoleMenus();
                return;
            }
            ///检查原来是升序
            intIndex = strSortQxRoleMenusBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortQxRoleMenusBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortQxRoleMenusBy = e.SortExpression + " Desc";
            }
            BindGv_QxRoleMenus();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortQxRoleMenusBy
        {
            get
            {
                string sSortQxRoleMenusBy;
                sSortQxRoleMenusBy = (string)ViewState["SortQxRoleMenusBy"];
                if (sSortQxRoleMenusBy == null)
                {
                    sSortQxRoleMenusBy = "";
                }
                return sSortQxRoleMenusBy;
            }
            set
            {
                string sSortQxRoleMenusBy = value;
                ViewState.Add("SortQxRoleMenusBy", sSortQxRoleMenusBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvQxRoleMenus.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvQxRoleMenus.PageCount)
                {
                    this.gvQxRoleMenus.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_QxRoleMenus();
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
                    BindGv_QxRoleMenus();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvQxRoleMenus_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvQxRoleMenus, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvQxRoleMenus, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvQxRoleMenus_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortQxRoleMenusBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvQxRoleMenus.Columns.Count; i++)
                {
                    strSortEx = this.gvQxRoleMenus.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortQxRoleMenusBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortQxRoleMenusBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvQxRoleMenus_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvQxRoleMenus.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteQxRoleMenusRecord(lngmId);
        }
        ///
        protected void gvQxRoleMenus_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvQxRoleMenus.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateQxRoleMenusRecord(lngmId);
        }
        ///删除记录过程代码for C#
        protected void gvQxRoleMenus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvQxRoleMenus.PageIndex = e.NewPageIndex;
                this.BindGv_QxRoleMenus();
            }
        }
        ///
        protected void btnCancelQxRoleMenusEdit_Click(object sender, EventArgs e)
        {
            DispQxRoleMenusListRegion();
        }

        protected void ddlPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPrjId = "";
            if (ddlPrjId_q.SelectedIndex > 0)
            {
                strPrjId = ddlPrjId_q.SelectedValue.ToString();
                clsQxPrjMenusBLEx.BindDdl_MenuIdEx(ddlMenuId_q, strPrjId);
                clsQxRolesBLEx.BindDdl_RoleIdEx(ddlRoleId_q, strPrjId);

                clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlPrjMenuSet, strPrjId);
            }
        }

        protected void lbImportExcel4QxRoleMenus_Click(object sender, EventArgs e)
        {
            Response.Redirect("../DataExcelImport/QxRoleMenusExcelImport.aspx");
        }


    }
    public partial class wfmQxRoleMenusB_QUDI : System.Web.UI.Page
    {
        protected void ShowData(long lngmId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsQxRoleMenusBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + lngmId + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsQxRoleMenusBL.GetQxRoleMenus(ref objQxRoleMenusEN);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objQxRoleMenusEN", objQxRoleMenusEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromQxRoleMenusClass(objQxRoleMenusEN);
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
        protected string CombineQxRoleMenusCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.ddlRoleId_q.SelectedValue != "" && this.ddlRoleId_q.SelectedValue != "0")
            {
                strWhereCond += " And RoleId='" + this.ddlRoleId_q.SelectedValue + "'";
            }
            if (this.ddlPrjId_q.SelectedValue != "" && this.ddlPrjId_q.SelectedValue != "0")
            {
                strWhereCond += string.Format(" And {0}='{1}'", convQxRoleMenus.QxPrjId, this.ddlPrjId_q.SelectedValue);
                
            }
            if (this.ddlPrjMenuSet.SelectedValue != "" && this.ddlPrjMenuSet.SelectedValue != "0")
            {
                strWhereCond += " And MenuSetId='" + this.ddlPrjMenuSet.SelectedValue + "'";
            }
            if (this.ddlMenuId_q.SelectedValue != "" && this.ddlMenuId_q.SelectedValue != "0")
            {
                strWhereCond += " And MenuId='" + this.ddlMenuId_q.SelectedValue + "'";
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_QxRoleMenus()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //4、设置GridView的数据源(DataSource)；
            //5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombineQxRoleMenusCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvQxRoleMenusBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortQxRoleMenusBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
            ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvQxRoleMenus.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvQxRoleMenus.PageSize = 10;
            }
            this.gvQxRoleMenus.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvQxRoleMenus.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvQxRoleMenus.BottomPagerRow;
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
                lblAllPages.Text = this.gvQxRoleMenus.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvQxRoleMenus.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvQxRoleMenus.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvQxRoleMenus.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvQxRoleMenus.PageIndex == this.gvQxRoleMenus.PageCount - 1)
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
            gvQxRoleMenus.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjQxRoleMenusEN">表实体类对象</param>
        protected void GetDataFromQxRoleMenusClass(clsQxRoleMenusEN pobjQxRoleMenusEN)
        {
            wucQxRoleMenusB1.QxPrjId = pobjQxRoleMenusEN.QxPrjId;//    项目编号
            wucQxRoleMenusB1.RoleId = pobjQxRoleMenusEN.RoleId;//    角色Id
            wucQxRoleMenusB1.MenuId = pobjQxRoleMenusEN.MenuId;//    菜单Id
            wucQxRoleMenusB1.Memo = pobjQxRoleMenusEN.Memo;//    备注
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjQxRoleMenusEN">数据传输的目的类对象</param>
        protected void PutDataToQxRoleMenusClass(clsQxRoleMenusEN pobjQxRoleMenusEN)
        {
            pobjQxRoleMenusEN.QxPrjId = wucQxRoleMenusB1.QxPrjId;//    项目编号
            pobjQxRoleMenusEN.RoleId = wucQxRoleMenusB1.RoleId;//    角色Id
            pobjQxRoleMenusEN.MenuId = wucQxRoleMenusB1.MenuId;//    菜单Id
            pobjQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);//    是否显示
            pobjQxRoleMenusEN.UpdUserId = clsCommonSession.UserId;//    是否显示

            pobjQxRoleMenusEN.Memo = wucQxRoleMenusB1.Memo;//    备注
        }

        ///生成从界面层到逻辑层的数据传输函数代码
        public System.Data.DataTable GetRoleId()
        {
            //获取某学院所有专业信息
            string strSQL = "select RoleId, RoleName from UserRoles ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetRoleId();
            objDDL.DataValueField = "RoleId";
            objDDL.DataTextField = "RoleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
       
        public System.Data.DataTable GetMenuId()
        {
            //获取某学院所有专业信息
            string strSQL = "select MenuId, MenuName from QxPrjMenus ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetMenuId();
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddQxRoleMenusRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelQxRoleMenusEdit.Text = "取消添加";
            //wucQxRoleMenusB1.mId = clsCommForWebForm.G1etMaxStrId("QxRoleMenus","mId", 8, "");
        }
        ///插入记录存盘过程代码for C#
        protected bool AddQxRoleMenusRecordSave()
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
            clsQxRoleMenusEN objQxRoleMenusEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucQxRoleMenusB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQxRoleMenusEN objQxRoleMenusEN;	//定义对象
            objQxRoleMenusEN = new clsQxRoleMenusEN();	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToQxRoleMenusClass(objQxRoleMenusEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxRoleMenusBL.CheckPropertyNew(objQxRoleMenusEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxRoleMenusBL.AddNewRecordBySql2(objQxRoleMenusEN);
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
            BindGv_QxRoleMenus();
            DispQxRoleMenusListRegion();
            wucQxRoleMenusB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxRoleMenusEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddQxRoleMenusRecordSaveV5()
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
            clsQxRoleMenusEN objQxRoleMenusEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucQxRoleMenusB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQxRoleMenusEN objQxRoleMenusEN;	//定义对象
            objQxRoleMenusEN = new clsQxRoleMenusEN();	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToQxRoleMenusClass(objQxRoleMenusEN);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxRoleMenusBL.CheckPropertyNew(objQxRoleMenusEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxRoleMenusBL.AddNewRecordBySql2(objQxRoleMenusEN);
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
            BindGv_QxRoleMenus();
            DispQxRoleMenusListRegion();
            wucQxRoleMenusB1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxRoleMenusEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateQxRoleMenusRecord(long lngmId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelQxRoleMenusEdit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditQxRoleMenusRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateQxRoleMenusRecordSave(clsQxRoleMenusEN objQxRoleMenusEN)
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
            if (!wucQxRoleMenusB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToQxRoleMenusClass(objQxRoleMenusEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxRoleMenusBL.CheckPropertyNew(objQxRoleMenusEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQxRoleMenusBL.UpdateBySql2(objQxRoleMenusEN);
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
            BindGv_QxRoleMenus();
            DispQxRoleMenusListRegion();
            wucQxRoleMenusB1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxRoleMenusEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateQxRoleMenusRecordSaveV5(clsQxRoleMenusEN objQxRoleMenusEN)
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
            if (!wucQxRoleMenusB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToQxRoleMenusClass(objQxRoleMenusEN);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxRoleMenusBL.CheckPropertyNew(objQxRoleMenusEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQxRoleMenusBL.UpdateBySql2(objQxRoleMenusEN);
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
            BindGv_QxRoleMenus();
            DispQxRoleMenusListRegion();
            wucQxRoleMenusB1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxRoleMenusEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteQxRoleMenusRecord(long lngmId)
        {
            try
            {
                clsQxRoleMenusBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxRoleMenus();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //1、组合界面条件串；
            string strWhereCond = CombineQxRoleMenusCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QxRoleMenus信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxRoleMenus.QxPrjId); arrCnName.Add("项目编号");
            arrColName.Add(convQxRoleMenus.PrjName); arrCnName.Add("工程名");
            arrColName.Add(convQxRoleMenus.RoleId); arrCnName.Add("角色Id");
            arrColName.Add(convQxRoleMenus.RoleName); arrCnName.Add("角色名称");
            arrColName.Add(convQxRoleMenus.MenuId); arrCnName.Add("菜单Id");
            arrColName.Add(convQxRoleMenus.MenuName); arrCnName.Add("菜单名");
            arrColName.Add(convQxRoleMenus.UpMenuId); arrCnName.Add("上级菜单Id");
            arrColName.Add(convQxRoleMenus.UpMenuName); arrCnName.Add("上级菜单名");
            arrColName.Add(convQxRoleMenus.MenuTitle); arrCnName.Add("菜单标题");
            arrColName.Add(convQxRoleMenus.MenuSetId); arrCnName.Add("菜单集Id");
            arrColName.Add(convQxRoleMenus.MenuSetName); arrCnName.Add("菜单集名称");
            arrColName.Add(convQxRoleMenus.PageDispModeId); arrCnName.Add("页面显示模式Id");
            arrColName.Add(convQxRoleMenus.PageDispModeName); arrCnName.Add("页面显示模式名称");
            arrColName.Add(convQxRoleMenus.OrderNum); arrCnName.Add("排序号");
            arrColName.Add(convQxRoleMenus.LinkFile); arrCnName.Add("链接文件");
            arrColName.Add(convQxRoleMenus.ImgFile); arrCnName.Add("图像文件");
            arrColName.Add(convQxRoleMenus.IsLeafNode); arrCnName.Add("是否叶子");
            
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;
            objExportExcelSetENEx.TabName = vsTabName;
            objExportExcelSetENEx.ExportFileName = strFileName;
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4AgcCs;
            objExportExcelSetENEx.arrCnName = arrCnName;
            objExportExcelSetENEx.arrColName = arrColName;
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
                objDT = clsvQxRoleMenusBL.GetDataTable(strWhereCond);
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
            //    objDT = clsQxRoleMenusBL.GetDataTable_QxRoleMenusV(strWhereCond);
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
        private void DispEditQxRoleMenusRegion()
        {
            tabQxRoleMenusGridView.Visible = false;
            tabEditQxRoleMenusRegion.Visible = true;
        }
        private void DispQxRoleMenusListRegion()
        {
            tabQxRoleMenusGridView.Visible = true;
            tabEditQxRoleMenusRegion.Visible = false;
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
        private void ShowMenu()
        {

            string strUserId = this.UserId;

            //2、从用户表得出当前用户的角色ID。						
            //				arrList = (new clsQxUsersEN().funGetFldValue("RoleId","UserId = '" + strUserId +"'"));
            //				strCurrUserRoleId = (string) arrList[0];
            if (ddlRoleId_q.SelectedIndex<=0)
            {
                lblMsg_List.Text = "没有选择角色，请选择一个有效的角色!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }

            string strCurrUserRoleId = ddlRoleId_q.SelectedValue;
            string strCurrMenuSetId = "";
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                //lblMsg_List.Text = "没有选择菜单集，请选择一个有效的菜单集!";
                //clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                //return;
                strCurrMenuSetId = "";
            }
            else
            {
                strCurrMenuSetId = ddlPrjMenuSet.SelectedValue;
            }
            //3、从Web.Config取出当前的工程ID		
            string  strCurrPrjId = clsCommonSession.UserPrjId;   
            string  strHtml = clsGeneMenuBLEx.GetQxUserMenuHTML2(strCurrPrjId, strCurrMenuSetId, strCurrUserRoleId, strUserId);

            //6、把菜单HTML菜单串显示到界面上。						
            spanMenu.InnerHtml = strHtml.ToString();
        }
        public string CurrrntPrjId
        {
            get
            {
                if (ConfigurationSettings.AppSettings[conQxProjects.QxPrjId] != null)
                {
                    return ConfigurationSettings.AppSettings[conQxProjects.QxPrjId].ToString();
                }
                else
                {
                    return "0";
                }
            }
        }
    }
}