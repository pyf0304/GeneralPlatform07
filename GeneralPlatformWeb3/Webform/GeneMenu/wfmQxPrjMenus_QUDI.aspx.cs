///----------------------
///生成代码版本：2010.05.04.1
///生成日期：2010/06/03
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2010.05.04.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2010.05.04.1
///========================
///生成查询，修改，删除，添加记录的控制层代码

///生成控制层的控件变量名列表
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;


namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmQxPrjMenus_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmQxPrjMenus_QUDI : System.Web.UI.Page
    {

        ///生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                vsViewName = "工程菜单维护";
                vsTabName = "vQxPrjMenus";
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
                wucQxPrjMenus1.SetDdl_QxPrjId();
                wucQxPrjMenus1.SetDdl_MenuSetId(strPrjId);

                wucQxPrjMenus1.SetDdl_IsLeafNode();
                wucQxPrjMenus1.SetDdl_InUse();

                wucQxPrjMenus1.SetDdl_PageDispModeId();
                //wucQxPrjMenus1.SetDdl_RoleId();
                clsDropDownList.BindDdl_TrueOrFalse(ddlInUse);
                clsDropDownList.BindDdl_TrueOrFalse(ddlIsLeafNode);
                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);
                clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlPrjMenuSet_q, strPrjId);
                clsQxApplicationTypeBLEx.BindDdl_ApplicationTypeIdEx(ddlApplicationTypeId_q);
                ddlApplicationTypeId_q.SelectedValue = "2";
                clsQxApplicationTypeBLEx.BindDdl_ApplicationTypeIdEx(ddlApplicationTypeId);

                string strDefaultMenuSetId = clsQxPrjMenuSetBLEx.GetDefaultMenuSetIdByPrjId(strPrjId);
                if (string.IsNullOrEmpty(strDefaultMenuSetId) == false)
                {
                    ddlPrjMenuSet.SelectedValue = strDefaultMenuSetId;
                }
                clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlPrjMenuSet, strPrjId);
                if (getUserPrjId != "0001")
                {
                    ddlPrjId_q.SelectedValue = strPrjId;
                    ddlPrjId_q.Enabled = false;
                    wucQxPrjMenus1.SetDdl_UpMenuId(strPrjId);
                }
                else
                {
                    ddlPrjId_q.SelectedValue = strPrjId;
                    wucQxPrjMenus1.SetDdl_UpMenuId(strPrjId);
                }
                clsDropDownList.BindDdl_UpMenuId(ddlUpMenuId, strPrjId);
                strSortQxPrjMenusBy = "MenuId Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_QxPrjMenus();
                //3、设置表控件中字控件的ReadOnly属性，
                ///   使之只读，因为在修改功能中关键字是不能被修改的。
                wucQxPrjMenus1.SetKeyReadOnly(true);
                DispQxPrjMenusListRegion();
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
            this.gvQxPrjMenus.PageIndex = 0;
            ///把表记录的内容显示在DATAGRID中
            BindGv_QxPrjMenus();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			  具体功能是重新显示新页(所单击页索引)的内容。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void gvQxPrjMenus_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            //操作步骤：（共2步）
            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页

            //1、设置当前页的页索引，即把新单击的页索引赋给当前页索引
            this.gvQxPrjMenus.PageIndex = e.NewPageIndex;
            //2、重新绑定DATAGRID，使之内容更新，变化到新的页
            BindGv_QxPrjMenus();
        }
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strMenuId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsQxPrjMenusEN objQxPrjMenus;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddQxPrjMenusRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddQxPrjMenusRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objQxPrjMenus = (clsQxPrjMenusEN)Session["objQxPrjMenus"];
                    UpdateQxPrjMenusRecordSave(objQxPrjMenus);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucQxPrjMenus1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            lblMsg_Edit.Text = "";
            //wucQxPrjMenus1.MenuId = clsQxPrjMenusBL.GetMaxStrId_S();
            DispEditQxPrjMenusRegion();
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
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxPrjMenus, "chkCheckRec", "MenuId");
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
                    string strMenuId = strKeys[0];
                    clsQxPrjMenusBL.DelRecord(strMenuId);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxPrjMenus();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvQxPrjMenus, "MenuId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            string strMenuId = strKeys[0];
            UpdateQxPrjMenusRecord(strMenuId);
        }
        ///生成组合查询条件的代码
        protected void gvQxPrjMenus_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            ///判断是否是新的排序字段
            intIndex = strSortQxPrjMenusBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortQxPrjMenusBy = e.SortExpression + " Asc";
                BindGv_QxPrjMenus();
                return;
            }
            ///检查原来是升序
            intIndex = strSortQxPrjMenusBy.IndexOf(" Asc");
            if (intIndex == -1)		//如果原来不是升序就设置为升序
            {
                strSortQxPrjMenusBy = e.SortExpression + " Asc";
            }
            else			///否则设置为降序
            {
                strSortQxPrjMenusBy = e.SortExpression + " Desc";
            }
            BindGv_QxPrjMenus();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式，以便决定下一次是升序，还是降序排序。
        /// </summary>
        protected string strSortQxPrjMenusBy
        {
            get
            {
                string sSortQxPrjMenusBy;
                sSortQxPrjMenusBy = (string)ViewState["SortQxPrjMenusBy"];
                if (sSortQxPrjMenusBy == null)
                {
                    sSortQxPrjMenusBy = "";
                }
                return sSortQxPrjMenusBy;
            }
            set
            {
                string sSortQxPrjMenusBy = value;
                ViewState.Add("SortQxPrjMenusBy", sSortQxPrjMenusBy);
            }
        }

        ///生成与跳页的相关函数
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvQxPrjMenus.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvQxPrjMenus.PageCount)
                {
                    this.gvQxPrjMenus.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_QxPrjMenus();
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
                    BindGv_QxPrjMenus();
                }
            }
        }

        ///生成GridView行命令的事件代码
        protected void gvQxPrjMenus_RowCommand(object sender, GridViewCommandEventArgs e)
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
                        clsCommForWebForm.Set_GridViewAllChecked(gvQxPrjMenus, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvQxPrjMenus, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        ///删除记录过程代码for C#
        protected void gvQxPrjMenus_RowCreated(object sender, GridViewRowEventArgs e)
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
            if (strSortQxPrjMenusBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvQxPrjMenus.Columns.Count; i++)
                {
                    strSortEx = this.gvQxPrjMenus.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortQxPrjMenusBy.IndexOf(strSortEx);
                    if (intIndex >= 0)  //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体，在"webdings"中5是上三角，6是下三角；
                        intIndex = strSortQxPrjMenusBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序，而且为string型；"▲" : "▼"
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        ///
        protected void gvQxPrjMenus_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strMenuId = gvQxPrjMenus.DataKeys[e.RowIndex]["MenuId"].ToString();
            DeleteQxPrjMenusRecord(strMenuId);
        }
        ///
        protected void gvQxPrjMenus_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strMenuId = gvQxPrjMenus.DataKeys[e.RowIndex]["MenuId"].ToString();
            UpdateQxPrjMenusRecord(strMenuId);
        }
        ///删除记录过程代码for C#
        protected void gvQxPrjMenus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (e.NewPageIndex != -1)
            {
                gvQxPrjMenus.PageIndex = e.NewPageIndex;
                this.BindGv_QxPrjMenus();
            }
        }
        ///
        protected void btnCancelQxPrjMenusEdit_Click(object sender, EventArgs e)
        {
            DispQxPrjMenusListRegion();
        }

        protected void ddlPrjId_q_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPrjId_q.SelectedIndex > 0)
            {
                string strPrjId = ddlPrjId_q.SelectedValue;
                clsDropDownList.BindDdl_UpMenuId(ddlUpMenuId, strPrjId);

                clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlPrjMenuSet, strPrjId);
            }
        }

        protected void btnSetPrjMenuSet_Click(object sender, EventArgs e)
        {
            if (ddlPrjMenuSet.SelectedIndex <= 0)
            {
                lblMsg_List.Text = "请选择一个菜单集!";
                return;
            }
            string strMenuSetId = ddlPrjMenuSet.SelectedValue;
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxPrjMenus, "chkCheckRec", "MenuId");
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
                    string strMenuId = strKeys[0];
                    clsQxPrjMenusBLEx.SetPrjMenuSet(strMenuId, strMenuSetId, clsCommonSession.UserId);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxPrjMenus();
        }

        protected void btnSetInUse_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxPrjMenus, "chkCheckRec", "MenuId");
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
                    string strMenuId = strKeys[0];
                    clsQxPrjMenusEN objQxPrjMenusEN = clsQxPrjMenusBL.GetObjByMenuId(strMenuId);
                    if (objQxPrjMenusEN.InUse == true)
                    {
                        objQxPrjMenusEN.InUse = false;
                    }
                    else
                    {
                        objQxPrjMenusEN.InUse = true;
                    }
                    objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objQxPrjMenusEN.UpdUserId = clsCommonSession.UserId;
                    ///			如果没有就直接删除，
                    clsQxPrjMenusBL.UpdateBySql2(objQxPrjMenusEN);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxPrjMenus();
        }

        protected void ddlMenuSetId_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlPrjMenuSet_q.SelectedIndex <= 0) return;
            string strMenuSetId = ddlPrjMenuSet_q.SelectedValue;
            clsQxPrjMenusBLEx.BindDdl_MenuIdByMenuSetId(ddlUpMenuId, clsCommonSession.UserPrjId4get, strMenuSetId);

        }

        protected void btnApplicationType_Click(object sender, EventArgs e)
        {
            List<string> arrMenuId = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxPrjMenus, "chkCheckRec");
            if (arrMenuId == null || arrMenuId.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            if (ddlApplicationTypeId.SelectedIndex <= 0)
            {
                lblMsg_List.Text = "请选择一个应用!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                ddlApplicationTypeId.Focus();
                return;
            }
            string strApplicationTypeId = ddlApplicationTypeId.SelectedValue;
            lblMsg_List.Text = "";
            foreach (string strMenuId in arrMenuId)
            {
                clsQxPrjMenusEN obj = clsQxPrjMenusBL.GetObjByMenuId(strMenuId);
                obj.ApplicationTypeId = int.Parse( strApplicationTypeId);
                clsQxPrjMenusBL.UpdateBySql2(obj);
            }

            BindGv_QxPrjMenus();

        }

        protected void btnAutoGetTabName_Click(object sender, EventArgs e)
        {
            string strCondition = string.Format("{0}='{1}'", conQxPrjMenus.QxPrjId, getUserPrjId);
            List<clsQxPrjMenusEN> arrQxPrjMenus = clsQxPrjMenusBL.GetObjLst(strCondition);
            List<clsQxPrjTabEN> arrQxPrjTabLst = clsQxPrjTabBL.GetObjLst(strCondition).OrderBy(x => x.TabName).ToList();
            //IEnumerable<clsQxPrjTabEN> arrQxPrjTab      = arrQxPrjTabLst.OrderBy(x=>x.TabName).ToList();
            int intCount = 0;
            foreach (clsQxPrjMenusEN objInFor in arrQxPrjMenus)
            {
                if (string.IsNullOrEmpty(objInFor.LinkFile) == true) continue;
                int intLen = arrQxPrjTabLst.Count;
                string strTabId = "";
                for(int i=0; i< intLen; i++)
                {
                    clsQxPrjTabEN objPrjTab = arrQxPrjTabLst[i];
                    
                    if (objInFor.LinkFile.IndexOf(objPrjTab.TabName) <= 0) continue;
                    strTabId = objPrjTab.TabId;
                    int j = i+1;
                    while(j<i+4 && j<intLen)
                    {
                        clsQxPrjTabEN objPrjTab_j = arrQxPrjTabLst[j];
                        if (objInFor.LinkFile.IndexOf(objPrjTab_j.TabName) >= 0)
                        {
                            if (objPrjTab_j.TabName.Length>objPrjTab.TabName.Length)
                            {
                                objPrjTab = objPrjTab_j;
                            }
                        }
                        else
                        {
                            break;
                        }
                        j++;
                    }
                    strTabId = objPrjTab.TabId;
                    break;
                }
                objInFor.TabId = strTabId;
                objInFor.Update();
                intCount++;
            }
            BindGv_QxPrjMenus();
        }
    }
    public partial class wfmQxPrjMenus_QUDI : System.Web.UI.Page
    {
        protected void ShowData(string strMenuId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strMenuId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsQxPrjMenusBL.IsExist(strMenuId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strMenuId + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQxPrjMenusEN objQxPrjMenus = new clsQxPrjMenusEN(strMenuId);
            //4、获取类对象的所有属性；
            try
            {
                clsQxPrjMenusBL.GetQxPrjMenus(ref objQxPrjMenus);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objQxPrjMenus", objQxPrjMenus);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromQxPrjMenusClass(objQxPrjMenus);
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
        protected string CombineQxPrjMenusCondion()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtMenuName_q.Text.Trim() != "")
            {
                strWhereCond += " And MenuName like '%" + this.txtMenuName_q.Text.Trim() + "%'";
            }
            if (this.ddlPrjId_q.SelectedValue != "" && this.ddlPrjId_q.SelectedValue != "0")
            {
                strWhereCond += string.Format(" And {0}='{1}'", conQxPrjMenus.QxPrjId, this.ddlPrjId_q.SelectedValue);

            }
            if (this.ddlPrjMenuSet_q.SelectedValue != "" && this.ddlPrjMenuSet_q.SelectedValue != "0")
            {
                strWhereCond += " And MenuSetId='" + this.ddlPrjMenuSet_q.SelectedValue + "'";
            }
            if (this.ddlUpMenuId.SelectedValue != "" && this.ddlUpMenuId.SelectedValue != "0")
            {
                strWhereCond += " And UpMenuId='" + this.ddlUpMenuId.SelectedValue + "'";
            }
            if (this.ddlInUse.SelectedIndex > 0)
            {
                if (InUse == true)
                {
                    strWhereCond += string.Format(" And {0}='1'", convQxPrjMenus.InUse);
                }
                else
                {
                    strWhereCond += string.Format(" And {0}='0'", convQxPrjMenus.InUse);
                }
            }
            if (this.ddlIsLeafNode.SelectedIndex > 0)
            {
                if (IsLeafNode == true)
                {
                    strWhereCond += string.Format(" And {0}='1'", convQxPrjMenus.IsLeafNode);
                }
                else
                {
                    strWhereCond += string.Format(" And {0}='0'", convQxPrjMenus.IsLeafNode);
                }
            }
            if (this.ddlApplicationTypeId_q.SelectedValue != "" && this.ddlApplicationTypeId_q.SelectedValue != "0")
            {
                //objvFunction4CodeEN.ApplicationTypeId = int.Parse(this.ddlApplicationTypeId_q.SelectedValue.ToString());
                strWhereCond += string.Format(" And {0} = {1}",
                    convQxPrjMenus.ApplicationTypeId,
                    this.ddlApplicationTypeId_q.SelectedValue);
            }
            return strWhereCond;
        }
        ///生成绑定GridView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_QxPrjMenus()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //4、设置GridView的数据源(DataSource)；
            //5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。

            //1、组合界面条件串；
            string strWhereCond = CombineQxPrjMenusCondion();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {
                objDT = clsvQxPrjMenusBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                ErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortQxPrjMenusBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                                  ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvQxPrjMenus.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvQxPrjMenus.PageSize = 10;
            }
            this.gvQxPrjMenus.DataSource = objDV;
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            this.gvQxPrjMenus.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvQxPrjMenus.BottomPagerRow;
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
                lblAllPages.Text = this.gvQxPrjMenus.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvQxPrjMenus.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvQxPrjMenus.PageIndex + 1).ToString();
                //如果当前页序数为0，则<前一页>按钮无效
                if (this.gvQxPrjMenus.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页，则<前一页>按钮无效
                if (this.gvQxPrjMenus.PageIndex == this.gvQxPrjMenus.PageCount - 1)
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
            gvQxPrjMenus.BottomPagerRow.Visible = true;
        }


        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjQxPrjMenus">表实体类对象</param>
        protected void GetDataFromQxPrjMenusClass(clsQxPrjMenusEN pobjQxPrjMenus)
        {
            wucQxPrjMenus1.MenuId = pobjQxPrjMenus.MenuId;//    菜单Id
            wucQxPrjMenus1.MenuName = pobjQxPrjMenus.MenuName;//    菜单名
            wucQxPrjMenus1.QxPrjId = pobjQxPrjMenus.QxPrjId;//    项目编号
            //wucQxPrjMenus1.MenuSetId = pobjQxPrjMenus.MenuSetId;//    项目编号

            wucQxPrjMenus1.UpMenuId = pobjQxPrjMenus.UpMenuId;//    上级菜单Id
            wucQxPrjMenus1.LinkFile = pobjQxPrjMenus.LinkFile;//    链接文件
            wucQxPrjMenus1.qsParameters = pobjQxPrjMenus.qsParameters;//    链接文件

            wucQxPrjMenus1.ImgFile = pobjQxPrjMenus.ImgFile;//    图像文件
            //wucQxPrjMenus1.RoleId = pobjQxPrjMenus.RoleId;//    角色Id
            wucQxPrjMenus1.OrderNum = pobjQxPrjMenus.OrderNum;//    排序号
            wucQxPrjMenus1.IsLeafNode = pobjQxPrjMenus.IsLeafNode;//    是否叶子
            wucQxPrjMenus1.PageDispModeId = pobjQxPrjMenus.PageDispModeId;//    页面显示方式

        }
        ///生成从界面层到逻辑层的数据传输函数代码
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjQxPrjMenus">数据传输的目的类对象</param>
        protected void PutDataToQxPrjMenusClass(clsQxPrjMenusEN pobjQxPrjMenus)
        {
            pobjQxPrjMenus.MenuId = wucQxPrjMenus1.MenuId;//    菜单Id
            pobjQxPrjMenus.MenuName = wucQxPrjMenus1.MenuName;//    菜单名
            pobjQxPrjMenus.QxPrjId = wucQxPrjMenus1.QxPrjId;//    项目编号
            //pobjQxPrjMenus.MenuSetId = wucQxPrjMenus1.MenuSetId;//    项目编号

            pobjQxPrjMenus.UpMenuId = wucQxPrjMenus1.UpMenuId;//    上级菜单Id
            pobjQxPrjMenus.LinkFile = wucQxPrjMenus1.LinkFile;//    链接文件
            pobjQxPrjMenus.qsParameters = wucQxPrjMenus1.qsParameters;//    链接文件

            pobjQxPrjMenus.ImgFile = wucQxPrjMenus1.ImgFile;//    图像文件
            //pobjQxPrjMenus.RoleId = wucQxPrjMenus1.RoleId;//    角色Id
            pobjQxPrjMenus.OrderNum = wucQxPrjMenus1.OrderNum;//    排序号
            pobjQxPrjMenus.IsLeafNode = wucQxPrjMenus1.IsLeafNode;//    是否叶子
            pobjQxPrjMenus.PageDispModeId = wucQxPrjMenus1.PageDispModeId;//    是否叶子
        }

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
        ///生成的插入记录准备过程代码for C#
        protected void AddQxPrjMenusRecord()
        {
            wucQxPrjMenus1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelQxPrjMenusEdit.Text = "取消添加";
            wucQxPrjMenus1.MenuId = clsQxPrjMenusBL.GetMaxStrIdByPrefix_S(clsPubVar.strCurrPrjId4AgcCs);
        }
        ///插入记录存盘过程代码for C#
        protected bool AddQxPrjMenusRecordSave()
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
            clsQxPrjMenusEN objQxPrjMenus;
            //1、检查控件中输入数据类型是否正确
            //if (!wucQxPrjMenus1.IsValid(ref strResult))
            //{
            //    lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
            //    return false;
            //}
            //2、定义对象并初始化对象
            //clsQxPrjMenusEN objQxPrjMenus;	//定义对象
            objQxPrjMenus = new clsQxPrjMenusEN(wucQxPrjMenus1.MenuId);	//初始化新对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsQxPrjMenusBL.IsExist(objQxPrjMenus.MenuId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToQxPrjMenusClass(objQxPrjMenus);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxPrjMenusBL.CheckPropertyNew(objQxPrjMenus);
                //6、把数据实体层的数据存贮到数据库中
                clsQxPrjMenusBL.AddNewRecordBySql2(objQxPrjMenus);
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
            BindGv_QxPrjMenus();
            DispQxPrjMenusListRegion();
            wucQxPrjMenus1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxPrjMenusEdit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddQxPrjMenusRecordSaveV5()
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
            //string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsQxPrjMenusEN objQxPrjMenus;
            //1、检查控件中输入数据类型是否正确

            //2、定义对象并初始化对象
            //clsQxPrjMenusEN objQxPrjMenus;	//定义对象
            objQxPrjMenus = new clsQxPrjMenusEN(wucQxPrjMenus1.MenuId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsQxPrjMenusBL.IsExist(objQxPrjMenus.MenuId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToQxPrjMenusClass(objQxPrjMenus);		//把界面的值传到
            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxPrjMenusBL.CheckPropertyNew(objQxPrjMenus);
                //6、把数据实体层的数据存贮到数据库中
                clsQxPrjMenusBL.AddNewRecordBySql2(objQxPrjMenus);
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
            BindGv_QxPrjMenus();
            DispQxPrjMenusListRegion();
            wucQxPrjMenus1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxPrjMenusEdit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateQxPrjMenusRecord(string strMenuId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strMenuId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucQxPrjMenus1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelQxPrjMenusEdit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditQxPrjMenusRegion();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateQxPrjMenusRecordSave(clsQxPrjMenusEN objQxPrjMenus)
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
            //if (!wucQxPrjMenus1.IsValid(ref strResult))
            //{
            //    lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
            //    return false;
            //}
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToQxPrjMenusClass(objQxPrjMenus);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxPrjMenusBL.CheckPropertyNew(objQxPrjMenus);
                //4、把数据实体层的数据存贮到数据库中
                clsQxPrjMenusBL.UpdateBySql2(objQxPrjMenus);
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
            BindGv_QxPrjMenus();
            DispQxPrjMenusListRegion();
            wucQxPrjMenus1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxPrjMenusEdit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateQxPrjMenusRecordSaveV5(clsQxPrjMenusEN objQxPrjMenus)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            //string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            //if (!wucQxPrjMenus1.IsValid(ref strResult))
            //{
            //    lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
            //    return false;
            //}
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToQxPrjMenusClass(objQxPrjMenus);		//把界面的值传到
            //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxPrjMenusBL.CheckPropertyNew(objQxPrjMenus);
                //4、把数据实体层的数据存贮到数据库中
                clsQxPrjMenusBL.UpdateBySql2(objQxPrjMenus);
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
            BindGv_QxPrjMenus();
            DispQxPrjMenusListRegion();
            wucQxPrjMenus1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxPrjMenusEdit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteQxPrjMenusRecord(string strMenuId)
        {
            try
            {
                clsQxPrjMenusBL.DelRecord(strMenuId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxPrjMenus();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //1、组合界面条件串；
            string strWhereCond = CombineQxPrjMenusCondion();
            strWhereCond += " Order By OrderNum";
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QxPrjMenus信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxPrjMenus.MenuId); arrCnName.Add("菜单Id");
            arrColName.Add(convQxPrjMenus.MenuName); arrCnName.Add("菜单名");
            arrColName.Add(convQxPrjMenus.UpMenuId); arrCnName.Add("上级菜单Id");
            arrColName.Add(convQxPrjMenus.LinkFile); arrCnName.Add("链接文件");
            arrColName.Add(convQxPrjMenus.ImgFile); arrCnName.Add("图像文件");
            arrColName.Add(convQxPrjMenus.RoleId); arrCnName.Add("角色Id");
            arrColName.Add(convQxPrjMenus.RoleName); arrCnName.Add("角色名称");
            arrColName.Add(convQxPrjMenus.OrderNum); arrCnName.Add("排序号");
            arrColName.Add(convQxPrjMenus.QxPrjId); arrCnName.Add("项目编号");
            arrColName.Add(convQxPrjMenus.PrjName); arrCnName.Add("工程名");
            arrColName.Add(convQxPrjMenus.IsLeafNode); arrCnName.Add("是否叶子");
            arrColName.Add(convQxPrjMenus.UpMenuName); arrCnName.Add("上级菜单");
            arrColName.Add(convQxPrjMenus.InUse); arrCnName.Add("是否在用");
            arrColName.Add(convQxPrjMenus.qsParameters); arrCnName.Add("qs参数");
            arrColName.Add(convQxPrjMenus.MenuTitle); arrCnName.Add("菜单标题");

            arrColName.Add(convQxPrjMenus.UpdUserId); arrCnName.Add("修改人");
            arrColName.Add(convQxPrjMenus.UpdDate); arrCnName.Add("修改日期");

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
                objDT = clsvQxPrjMenusBL.GetDataTable(strWhereCond);
                //foreach (DataRow objDR in objDT.Rows)
                //{

                //}
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
            //    objDT = clsQxPrjMenusBL.GetDataTable_QxPrjMenusV(strWhereCond);
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
        private void DispEditQxPrjMenusRegion()
        {
            tabQxPrjMenusGridView.Visible = false;
            tabEditQxPrjMenusRegion.Visible = true;
        }
        private void DispQxPrjMenusListRegion()
        {
            tabQxPrjMenusGridView.Visible = true;
            tabEditQxPrjMenusRegion.Visible = false;
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


        public bool InUse
        {
            get
            {
                if (ddlInUse.SelectedValue == "0")
                {
                    return false;
                }
                else if (ddlInUse.SelectedValue == "01")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlInUse.SelectedValue = "01";
                }
                else
                {
                    ddlInUse.SelectedValue = "00";
                }
            }
        }
        public bool IsLeafNode
        {
            get
            {
                if (ddlIsLeafNode.SelectedValue == "0")
                {
                    return false;
                }
                else if (ddlIsLeafNode.SelectedValue == "01")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlIsLeafNode.SelectedValue = "01";
                }
                else
                {
                    ddlIsLeafNode.SelectedValue = "00";
                }
            }
        }
        protected void btnCloneNewRec4Gv_Click(object sender, EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxPrjMenus, "chkCheckRec");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            foreach (string strMenuIds in lstKeyValue)
            {
                string[] strKeys = strMenuIds.Split(',');
                string strMenuId = strKeys[0];
                clsQxPrjMenusEN obj = new clsQxPrjMenusEN(strMenuId);
                clsQxPrjMenusBL.GetQxPrjMenus(ref obj);
                obj.MenuId = clsQxPrjMenusBL.GetMaxStrIdByPrefix_S(clsPubVar.strCurrPrjId4AgcCs); ;
                obj.MenuName = "Copy_" + obj.MenuName;
                //if (string.IsNullOrEmpty(obj.ReturnType))
                //{
                //    obj.ReturnType = "Object";
                //}
                try
                {
                    clsQxPrjMenusBL.AddNewRecordBySql2(obj);

                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                }
            }
            BindGv_QxPrjMenus();
        }

    }

}