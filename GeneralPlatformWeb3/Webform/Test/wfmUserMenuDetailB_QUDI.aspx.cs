
///----------------------
///生成代码版本:2016.07.06.1
///生成日期:2016/08/06
///生成者:潘以锋
///工程名称:统一平台
///工程ID:0014
///模块中文名:菜单管理
///模块英文名:MenuManage
///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.06.06.01
///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.06.06.01
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
///生成查询,修改,删除,添加记录的控制层代码

///生成控制层的控件变量名列表
using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;


using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmUserMenuDetailB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// </summary>
    public partial class wfmUserMenuDetailB_QUDI : System.Web.UI.Page
    {

        #region 页面启动函数
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "用户菜单维护";
                vsTabName = string.Format("{0}", clsQxUserMenuDetailEN._CurrTabName);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
                switch (vsPotenceLevel)
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

                //1、为下拉框设置数据源,绑定列表数据
                wucUserMenuDetailB1.SetDdl_MenuId();
                wucUserMenuDetailB1.SetDdl_UpMenuId();
                wucUserMenuDetailB1.SetDdl_UserId();
                wucUserMenuDetailB1.SetDdl_QxPrjId();
                //clsQxPrjMenusBL.BindDdl_MenuId(ddlMenuId_q,"");
                //clsQxPrjMenusBL.BindDdl_MenuId(ddlUpMenuId_q, "");
                clsQxUsersBL.BindDdl_UserId(ddlUserId_q);
                clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId_q);
                strSortUserMenuDetailBy = string.Format("{0} Asc", conQxUserMenuDetail.mId);
                //2、显示无条件的表内容在GridView中
                BindGv_QxUserMenuDetail();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                DispUserMenuDetailListRegion();
            }
        }

        #endregion 页面启动函数


        #region 查询相关函数
        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (GeneralPlatform.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            this.gvUserMenuDetail.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_QxUserMenuDetail();
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (GeneralPlatform.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenBindGridView)
        /// </summary>
        protected void BindGv_QxUserMenuDetail()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            //	6、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。

            System.Data.DataTable objDT = null;
            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombineUserMenuDetailCondion();
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsQxUserMenuDetailBL.GetDataTable_QxUserMenuDetail(strWhereCond);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI001310)获取数据表(DataTable)不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortUserMenuDetailBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
                                                  ///设置GridView中每页的记录数
            if (string.IsNullOrEmpty(PageSize) == false)
            {
                int intPageSize = int.Parse(PageSize);
                gvUserMenuDetail.PageSize = intPageSize;
            }
            else
            {
                PageSize = "10";
                gvUserMenuDetail.PageSize = 10;
            }
            this.gvUserMenuDetail.DataSource = objDV;
            //	5、绑定GridView,即把DataTable的内容显示在GridView中
            this.gvUserMenuDetail.DataBind();

            ///生成专门用于BindGv中的跳页相关代码
            GridViewRow pagerRow = gvUserMenuDetail.BottomPagerRow;
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
                lblAllPages.Text = this.gvUserMenuDetail.PageCount.ToString();
                //当前页序数
                lblCurrentPage.Text = (this.gvUserMenuDetail.PageIndex + 1).ToString();
                //当前即将跳到的页序数
                txtJump2Page.Text = (this.gvUserMenuDetail.PageIndex + 1).ToString();
                //如果当前页序数为0,则<前一页>按钮无效
                if (this.gvUserMenuDetail.PageIndex == 0)
                {
                    btnPrevPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                }
                //如果当前页序数已为最后一页,则<前一页>按钮无效
                if (this.gvUserMenuDetail.PageIndex == this.gvUserMenuDetail.PageCount - 1)
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
            gvUserMenuDetail.BottomPagerRow.Visible = true;
        }



        /// <summary>
        /// 事件函数：生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理：跳转到GridView的某一数。
        /// (GeneralPlatform.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenJumpPage_QxRelaFunction)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnJumpPage_Click(object sender, EventArgs e)
        {
            GridViewRow pagerRow = gvUserMenuDetail.BottomPagerRow;
            TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            if (txtJump2Page != null)
            {
                if (txtJump2Page.Text.Trim() != "" &&
                int.Parse(txtJump2Page.Text) > 0 &&
                int.Parse(txtJump2Page.Text) - 1 < this.gvUserMenuDetail.PageCount)
                {
                    this.gvUserMenuDetail.PageIndex = int.Parse(txtJump2Page.Text) - 1;
                }
                this.BindGv_QxUserMenuDetail();
            }
        }


        /// <summary>
        /// 事件函数：在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理：改变GridView的每页记录数。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenddlPagerRecCount_SelectedIndexChanged)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
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
                    BindGv_QxUserMenuDetail();
                }
            }
        }

        /// <summary>
        /// 事件函数：在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理：在列头显示单击全选按钮时全选GridView的所有行。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_RowCommand)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserMenuDetail_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string strCommandName = e.CommandName;
            switch (strCommandName)
            {
                case "lbSelAll":
                    System.Web.UI.WebControls.Button lbSelAll;
                    lbSelAll = (Button)e.CommandSource;
                    if (lbSelAll.CommandName != "lbSelAll")
                    {
                        return;
                    }
                    if (lbSelAll.Text == "全选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvUserMenuDetail, true);
                        lbSelAll.Text = "不选";
                    }
                    else if (lbSelAll.Text == "不选")
                    {
                        clsCommForWebForm.Set_GridViewAllChecked(gvUserMenuDetail, false);
                        lbSelAll.Text = "全选";
                    }
                    break;
            }
        }
        /// <summary>
        /// 事件函数：在GridView中，当GeidView行建立时发生的事件，在这里主要处理：数据行中处理删除时显示提示信息，还有在列头显示排序标志。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_RowCreated)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserMenuDetail_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                System.Web.UI.WebControls.Button myDeleteButton;
                myDeleteButton = (System.Web.UI.WebControls.Button)e.Row.FindControl("lbDelete");
                if (myDeleteButton != null)
                {
                    myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
                }
            }
            int intIndex;
            if (strSortUserMenuDetailBy == "") return;
            if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
            {
                string strSortEx;
                for (int i = 0; i < this.gvUserMenuDetail.Columns.Count; i++)
                {
                    strSortEx = this.gvUserMenuDetail.Columns[i].SortExpression;
                    if (strSortEx == "") continue;
                    intIndex = strSortUserMenuDetailBy.IndexOf(strSortEx + " ");
                    if (intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
                    {
                        Label lblSort = new Label();
                        lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
                        intIndex = strSortUserMenuDetailBy.IndexOf("Asc");
                        lblSort.Text = (intIndex > 0 ? "▲" : "▼");//是否为升序,而且为string型；
                        e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_PageIndexChanging)
        /// </summary>
        /// <param name = "source"></param>
        /// <param name = "e"></param>
        protected void gvUserMenuDetail_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //操作步骤:(共2步)
            //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
            //2、重新绑定GridView,使之内容更新,变化到新的页

            if (e.NewPageIndex != -1)
            {
                //1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
                gvUserMenuDetail.PageIndex = e.NewPageIndex;
                //2、重新绑定GridView,使之内容更新,变化到新的页
                this.BindGv_QxUserMenuDetail();
            }
        }
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenCombineCondion)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombineUserMenuDetailCondion()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try
            {
                if (this.txtmId_q.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conQxUserMenuDetail.mId, this.txtmId_q.Text.Trim());
                }
                if (this.ddlMenuId_q.SelectedValue != "" && this.ddlMenuId_q.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", conQxUserMenuDetail.MenuId, this.ddlMenuId_q.SelectedValue);
                }
                if (this.txtMenuName_q.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conQxUserMenuDetail.MenuName, this.txtMenuName_q.Text.Trim());
                }
                if (this.chkIsDisp_q.Checked == true)
                    strWhereCond += string.Format(" And {0} = '1'", conQxUserMenuDetail.IsDisp);
                else
                    strWhereCond += string.Format(" And {0} = '0'", conQxUserMenuDetail.IsDisp);
                if (this.ddlUpMenuId_q.SelectedValue != "" && this.ddlUpMenuId_q.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", conQxUserMenuDetail.UpMenuId, this.ddlUpMenuId_q.SelectedValue);
                }
                if (this.txtLinkFile_q.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conQxUserMenuDetail.LinkFile, this.txtLinkFile_q.Text.Trim());
                }
                if (this.txtImgFile_q.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conQxUserMenuDetail.ImgFile, this.txtImgFile_q.Text.Trim());
                }
                if (this.chkIsCustomMenu_q.Checked == true)
                    strWhereCond += string.Format(" And {0} = '1'", conQxUserMenuDetail.IsCustomMenu);
                else
                    strWhereCond += string.Format(" And {0} = '0'", conQxUserMenuDetail.IsCustomMenu);
                if (this.ddlUserId_q.SelectedValue != "" && this.ddlUserId_q.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", conQxUserMenuDetail.UserId, this.ddlUserId_q.SelectedValue);
                }
                if (this.ddlPrjId_q.SelectedValue != "" && this.ddlPrjId_q.SelectedValue != "0")
                {
                    strWhereCond += string.Format(" And {0} = '{1}'", conQxUserMenuDetail.QxPrjId, this.ddlPrjId_q.SelectedValue);
                }
                if (this.txtOrderNum_q.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conQxUserMenuDetail.OrderNum, this.txtOrderNum_q.Text.Trim());
                }
                if (this.txtMemo_q.Text.Trim() != "")
                {
                    strWhereCond += string.Format(" And {0} like '%{1}%'", conQxUserMenuDetail.Memo, this.txtMemo_q.Text.Trim());
                }
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI001311)在组合查询条件(CombineUserMenuDetailCondion)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPageSizeViewState)
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

        #endregion 查询相关函数


        #region 排序相关函数
        /// <summary>
        /// 事件函数：在GridView中，单击列头进行排序所发生的事件
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_Sorting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserMenuDetail_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortUserMenuDetailBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortUserMenuDetailBy = e.SortExpression + " Asc";
                BindGv_QxUserMenuDetail();
                return;
            }
            //检查原来是升序
            intIndex = strSortUserMenuDetailBy.IndexOf(" Asc");
            if (intIndex == -1)     //如果原来不是升序就设置为升序
            {
                strSortUserMenuDetailBy = e.SortExpression + " Asc";
            }
            else            ///否则设置为降序
            {
                strSortUserMenuDetailBy = e.SortExpression + " Desc";
            }
            BindGv_QxUserMenuDetail();
        }

        /// <summary>
        /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_Sorting)
        /// </summary>
        protected string strSortUserMenuDetailBy
        {
            get
            {
                string sSortUserMenuDetailBy;
                sSortUserMenuDetailBy = (string)ViewState["SortUserMenuDetailBy"];
                if (sSortUserMenuDetailBy == null)
                {
                    sSortUserMenuDetailBy = "";
                }
                return sSortUserMenuDetailBy;
            }
            set
            {
                string sSortUserMenuDetailBy = value;
                ViewState.Add("SortUserMenuDetailBy", sSortUserMenuDetailBy);
            }
        }
        #endregion 排序相关函数


        #region 添加相关函数

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddUserMenuDetailRecord();
        }
        /// <summary>
        /// 为插入记录做准备工作
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenAddRecordCode)
        /// </summary>
        protected void AddUserMenuDetailRecord()
        {
            btnOKUpd.Text = "确认添加";
            btnCancelUserMenuDetailEdit.Text = "取消添加";
            //wucUserMenuDetailB1.mId = clsQxUserMenuDetailBL.GetMaxStrId_S();
            DispEditUserMenuDetailRegion();
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddUserMenuDetailRecordSave()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsQxUserMenuDetailEN objUserMenuDetailEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUserMenuDetailB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI001312)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQxUserMenuDetailEN objUserMenuDetailEN;	//定义对象
            objUserMenuDetailEN = new clsQxUserMenuDetailEN();    //初始化新对象
                                                                //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                                //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUserMenuDetailClass(objUserMenuDetailEN);      //把界面的值传到
                                                                    ///5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxUserMenuDetailBL.CheckPropertyNew(objUserMenuDetailEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxUserMenuDetailBL.AddNewRecordBySql2(objUserMenuDetailEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI001313)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_QxUserMenuDetail();
            DispUserMenuDetailListRegion();
            wucUserMenuDetailB1.Clear();        //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserMenuDetailEdit.Text = "取消编辑";
            return true;
        }
        /// <summary>
        /// 插入记录存盘到数据表中,V5版
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenAddRecordSaveCodeV5)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddUserMenuDetailRecordSaveV5()
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsQxUserMenuDetailEN objUserMenuDetailEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUserMenuDetailB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI001314)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQxUserMenuDetailEN objUserMenuDetailEN;	//定义对象
            objUserMenuDetailEN = new clsQxUserMenuDetailEN();    //初始化新对象
                                                                //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                                //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUserMenuDetailClass(objUserMenuDetailEN);      //把界面的值传到
                                                                    ///5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxUserMenuDetailBL.CheckPropertyNew(objUserMenuDetailEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxUserMenuDetailBL.AddNewRecordBySql2(objUserMenuDetailEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "(errid:WebI001315)添加记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_QxUserMenuDetail();
            DispUserMenuDetailListRegion();
            wucUserMenuDetailB1.Clear();        //清空控件中内容
                                                ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserMenuDetailEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加相关函数


        #region 修改相关函数

        /// <summary>
        ///修改当前被选记录
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnUpdate4Gv_Click)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = clsCommForWebForm.GetFirstCheckedItemFromGv(gvUserMenuDetail, "mId");
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "(errid:WebI001316)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string[] strKeys = lstKeyValue[0].Split(',');
            long lngmId = long.Parse(strKeys[0]);
            UpdateUserMenuDetailRecord(lngmId);
        }
        ///
        protected void gvUserMenuDetail_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string strmId = gvUserMenuDetail.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            UpdateUserMenuDetailRecord(lngmId);
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenShowDataCode)
        /// </summary>
        /// <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(long lngmId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (lngmId == 0) return;        //如果关键字为空就返回退出
                                            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsQxUserMenuDetailBL.IsExist(lngmId) == false)       //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI001317)在表[UserMenuDetail]中,关键字为:[lngmId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQxUserMenuDetailEN objUserMenuDetailEN = new clsQxUserMenuDetailEN(lngmId);
            //4、获取类对象的所有属性；
            try
            {
                clsQxUserMenuDetailBL.GetQxUserMenuDetail(ref objUserMenuDetailEN);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objUserMenuDetailEN", objUserMenuDetailEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromQxUserMenuDetailClass(objUserMenuDetailEN);
        }
        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjUserMenuDetailEN">表实体类对象</param>
        protected void GetDataFromQxUserMenuDetailClass(clsQxUserMenuDetailEN pobjUserMenuDetailEN)
        {
            wucUserMenuDetailB1.MenuId = pobjUserMenuDetailEN.MenuId;// 菜单Id
            wucUserMenuDetailB1.MenuName = pobjUserMenuDetailEN.MenuName;// 菜单名
            wucUserMenuDetailB1.IsDisp = pobjUserMenuDetailEN.IsDisp;// 是否显示
            wucUserMenuDetailB1.UpMenuId = pobjUserMenuDetailEN.UpMenuId;// 上级菜单Id
            wucUserMenuDetailB1.LinkFile = pobjUserMenuDetailEN.LinkFile;// 链接文件
            wucUserMenuDetailB1.ImgFile = pobjUserMenuDetailEN.ImgFile;// 图像文件
            wucUserMenuDetailB1.IsCustomMenu = pobjUserMenuDetailEN.IsCustomMenu;// 是否定制菜单
            wucUserMenuDetailB1.UserId = pobjUserMenuDetailEN.UserId;// 用户ID
            wucUserMenuDetailB1.QxPrjId = pobjUserMenuDetailEN.QxPrjId;// 项目Id
            wucUserMenuDetailB1.OrderNum = pobjUserMenuDetailEN.OrderNum;// 排序号
            wucUserMenuDetailB1.Memo = pobjUserMenuDetailEN.Memo;// 备注
        }
        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateUserMenuDetailRecord(long lngmId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(lngmId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            btnOKUpd.Text = "确认修改";
            btnCancelUserMenuDetailEdit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditUserMenuDetailRegion();
        }
        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objUserMenuDetailEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateUserMenuDetailRecordSave(clsQxUserMenuDetailEN objUserMenuDetailEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //3.2、检查唯一性
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucUserMenuDetailB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI001318)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUserMenuDetailClass(objUserMenuDetailEN);      //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxUserMenuDetailBL.CheckPropertyNew(objUserMenuDetailEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQxUserMenuDetailBL.UpdateBySql2(objUserMenuDetailEN);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_QxUserMenuDetail();
            DispUserMenuDetailListRegion();
            wucUserMenuDetailB1.Clear();//添空控件中的内容
                                        //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserMenuDetailEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_QxUserMenuDetail{0}'", objUserMenuDetailEN.mId.ToString().Trim()), true);
            return true;
        }
        /// <summary>
        /// 修改记录存盘到数据表中, V5版
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenUpdateRecordSaveCodeV5)
        /// </summary>
        /// <param name = "objUserMenuDetailEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateUserMenuDetailRecordSaveV5(clsQxUserMenuDetailEN objUserMenuDetailEN)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3.1、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、检查控件中输入数据类型是否正确
            if (!wucUserMenuDetailB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI001319)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUserMenuDetailClass(objUserMenuDetailEN);      //把界面的值传到
                                                                    //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxUserMenuDetailBL.CheckPropertyNew(objUserMenuDetailEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQxUserMenuDetailBL.UpdateBySql2(objUserMenuDetailEN);
            }
            catch (Exception objException)
            {
                seErrMessage = "修改记录不成功!" + objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strMsg = "修改记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "修改记录成功!";
            //5、把修改后的内容显示在GridView中
            BindGv_QxUserMenuDetail();
            DispUserMenuDetailListRegion();
            wucUserMenuDetailB1.Clear();//添空控件中的内容
                                        //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserMenuDetailEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_QxUserMenuDetail{0}'", objUserMenuDetailEN.mId.ToString().Trim()), true);
            return true;
        }
        #endregion 修改相关函数


        #region 添加修改共用函数
        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsQxUserMenuDetailEN objUserMenuDetailEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddUserMenuDetailRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddUserMenuDetailRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objUserMenuDetailEN = (clsQxUserMenuDetailEN)Session["objUserMenuDetailEN"];
                    UpdateUserMenuDetailRecordSave(objUserMenuDetailEN);
                    break;
            }
        }
        /// <summary>
        /// 事件函数：取消编辑状态，退回到列表状态
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelUserMenuDetailEdit_Click(object sender, EventArgs e)
        {
            DispUserMenuDetailListRegion();
        }
        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjUserMenuDetailEN">数据传输的目的类对象</param>
        protected void PutDataToUserMenuDetailClass(clsQxUserMenuDetailEN pobjUserMenuDetailEN)
        {
            pobjUserMenuDetailEN.MenuId = wucUserMenuDetailB1.MenuId;// 菜单Id
            pobjUserMenuDetailEN.MenuName = wucUserMenuDetailB1.MenuName;// 菜单名
            pobjUserMenuDetailEN.IsDisp = wucUserMenuDetailB1.IsDisp;// 是否显示
            pobjUserMenuDetailEN.UpMenuId = wucUserMenuDetailB1.UpMenuId;// 上级菜单Id
            pobjUserMenuDetailEN.LinkFile = wucUserMenuDetailB1.LinkFile;// 链接文件
            pobjUserMenuDetailEN.ImgFile = wucUserMenuDetailB1.ImgFile;// 图像文件
            pobjUserMenuDetailEN.IsCustomMenu = wucUserMenuDetailB1.IsCustomMenu;// 是否定制菜单
            pobjUserMenuDetailEN.UserId = wucUserMenuDetailB1.UserId;// 用户ID
            pobjUserMenuDetailEN.QxPrjId = wucUserMenuDetailB1.QxPrjId;// 项目Id
            pobjUserMenuDetailEN.OrderNum = wucUserMenuDetailB1.OrderNum;// 排序号
            pobjUserMenuDetailEN.Memo = wucUserMenuDetailB1.Memo;// 备注
        }

        #endregion 添加修改共用函数


        #region 删除相关函数

        /// <summary>
        ///删除当前被选记录
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnDelete4Gv_Click)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvUserMenuDetail, "chkCheckRec", "mId");
            if (lstKeyValues.Count == 0)
            {
                lblMsg_List.Text = "(errid:WebI001320)没有选择记录,请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string[] strKeys = strKeyValue.Split(',');
                    long lngmId = long.Parse(strKeys[0]);
                    clsQxUserMenuDetailBL.DelRecord(lngmId);
                }
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxUserMenuDetail();
        }
        /// <summary>
        /// 事件函数：在GridView中，进行行删除(RowDeleting)
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:Gen_GridView_RowDeleting)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void gvUserMenuDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string strmId = gvUserMenuDetail.DataKeys[e.RowIndex]["mId"].ToString();
            long lngmId = long.Parse(strmId);
            DeleteUserMenuDetailRecord(lngmId);
        }
        /// <summary>
        /// 根据给定关键字删除记录
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDeleteRecordCode)
        /// </summary>
        /// <param name = "lngmId">给定关键字</param>
        protected void DeleteUserMenuDetailRecord(long lngmId)
        {
            try
            {
                clsQxUserMenuDetailBL.DelRecord(lngmId);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxUserMenuDetail();
        }
        #endregion 删除相关函数


        #region 导出函数

        /// <summary>
        /// 事件函数：把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        ///设置当前用户的Excel导出字段
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenbtnSetExportExcel4User_Click)
        /// </summary>
        protected void btnSetExportExcel4User_Click(object sender, EventArgs e)
        {
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("ViewName = '{0}'", vsViewName);//当前界面
            sbCondition.AppendFormat(" And TabName = '{0}'", vsTabName);//当前导出的使用的表
            sbCondition.AppendFormat(" And UserId = '{0}'", clsCommonSession.UserId);//当前用户
                                                                                     //根据条件获取Excel设置Id
            string strIdExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(sbCondition.ToString());
            if (string.IsNullOrEmpty(strIdExportExcel4Users) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("(errid:WinI000138)在系统中没有界面为[{0}]", vsViewName);
                sbMsg.AppendFormat(",表名 = '{0}'", vsTabName);
                sbMsg.AppendFormat("并且用户 = '{0}'的导出Excel用户设置,请先导出一次Excel,再不行可与管理员联系!", clsCommonSession.UserId);
                clsCommonJsFunc.Alert(this, sbMsg.ToString());
                return;
            }
            //弹出导出Excel字段界面进行设置
            StringBuilder sbScript = new StringBuilder();
            sbScript.Append("<script language = 'javascript'>");
            sbScript.Append("window.open('");
            sbScript.AppendFormat("../SysManage/wfmExportExcel4UsersB_QUDI.aspx?Id_ExportExcel4Users = {0}", strIdExportExcel4Users);
            sbScript.Append("','_blank', 'left = 50px,top = 50px,status = no,width = 920px,height = 650px,scrollbars = yes'); </script>");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "导出Excel字段设置", sbScript.ToString());
            // Response.Write(sbScript.ToString());
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[UserMenuDetail]表中获取记录集,最终导出到Excel
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombineUserMenuDetailCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "UserMenuDetail信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(conQxUserMenuDetail.MenuId); arrCnName.Add("菜单Id");
            arrColName.Add(conQxUserMenuDetail.MenuName); arrCnName.Add("菜单名");
            arrColName.Add(conQxUserMenuDetail.IsDisp); arrCnName.Add("是否显示");
            arrColName.Add(conQxUserMenuDetail.UpMenuId); arrCnName.Add("上级菜单Id");
            arrColName.Add(conQxUserMenuDetail.LinkFile); arrCnName.Add("链接文件");
            arrColName.Add(conQxUserMenuDetail.ImgFile); arrCnName.Add("图像文件");
            arrColName.Add(conQxUserMenuDetail.IsCustomMenu); arrCnName.Add("是否定制菜单");
            arrColName.Add(conQxUserMenuDetail.UserId); arrCnName.Add("用户ID");
            arrColName.Add(conQxUserMenuDetail.QxPrjId); arrCnName.Add("项目Id");
            arrColName.Add(conQxUserMenuDetail.OrderNum); arrCnName.Add("排序号");
            arrColName.Add(conQxUserMenuDetail.Memo); arrCnName.Add("备注");
            clsExportExcelSetENEx objExportExcelSetENEx = new clsExportExcelSetENEx();
            objExportExcelSetENEx.ViewName = vsViewName;//当前界面
            objExportExcelSetENEx.TabName = vsTabName;//导出Excel所用的表或者视图
            objExportExcelSetENEx.ExportFileName = strFileName;//导出Excel的文件名
            objExportExcelSetENEx.UserId = clsCommonSession.UserId;//当前用户Id
            objExportExcelSetENEx.UpdUserId = clsCommonSession.UserId;
            objExportExcelSetENEx.UpdDate = clsDateTime.getTodayStr(0);//当前日期
            objExportExcelSetENEx.strPrjId = clsPubVar.strCurrPrjId4AgcCs;//当前工程在生成代码系统中所用的工程Id,为了翻译字段名的中文名
            objExportExcelSetENEx.arrCnName = arrCnName;//中文字段名,也是Excel文件中的标题名
            objExportExcelSetENEx.arrColName = arrColName;//数据表的列名
            try
            {
                clsExportExcelSetBLEx.GetExportExcelSetInfo(ref objExportExcelSetENEx, new clsTranslateFieldName());
                strFileName = objExportExcelSetENEx.ExportFileName;//导出Excel的文件名
                arrCnName = objExportExcelSetENEx.arrCnName;//中文字段名,也是Excel文件中的标题名
                arrColName = objExportExcelSetENEx.arrColName;//数据表的列名
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsQxUserMenuDetailBL.GetDataTable_QxUserMenuDetail(strWhereCond);
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                seErrMessage = objException.Message;
                seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
        #endregion 导出函数


        #region 布局控制函数
        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDispListAndEditRegion)
        /// </summary>
        private void DispEditUserMenuDetailRegion()
        {
            divList.Visible = false;
            tabEditUserMenuDetailRegion.Visible = true;
        }
        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDispListAndEditRegion)
        /// </summary>
        private void DispUserMenuDetailListRegion()
        {
            divList.Visible = true;
            tabEditUserMenuDetailRegion.Visible = false;
        }
        #endregion 布局控制函数


        #region 错误处理函数

        /// <summary>
        /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenErrMessageSession)
        /// </summary>
        protected string seErrMessage
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
        /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenBackLinkStrSession)
        /// </summary>
        protected string seBackErrPageLinkStr
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

        #endregion 错误处理函数


        #region 权限处理函数

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
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
        /// ViewState属性:当前操作的导出表名称
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
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
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
        /// </summary>
        private string qsUserId
        {
            get
            {
                string strUserId = Request.QueryString["UserId"] ?? "".ToString();
                if ((strUserId != null) && (strUserId != ""))
                {
                    return strUserId;
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// 与权限相关的界面编号
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceRelaVar)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号


        /// <summary>
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenPotenceLevelProperty)
        /// </summary>
        protected string vsPotenceLevel
        {
            get
            {
                string sPotenceLevel;
                sPotenceLevel = (string)ViewState["PotenceLevel"];
                if (sPotenceLevel == null)
                {
                    //					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
                    sPotenceLevel = "9";
                    ViewState.Add("PotenceLevel", sPotenceLevel);
                }
                return sPotenceLevel;
            }
        }


        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenLoginUserSession)
        /// </summary>
        protected string seUserId
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
        ///if (pobjUser == null) 
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
        /// 菜单Id
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenParentObjSeesionProp)
        /// </summary>
        protected string MenuId
        {
            get
            {
                string strMenuId;
                strMenuId = (string)Session["MenuId"];
                if (strMenuId == null)
                {
                    strMenuId = "";
                }
                return strMenuId;
            }
            set
            {
                string strMenuId = value;
                Session.Add("MenuId", strMenuId);
            }
        }
        /// <summary>
        /// 项目Id
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenParentObjSeesionProp)
        /// </summary>
        protected string QxPrjId
        {
            get
            {
                string strPrjId;
                strPrjId = (string)Session[conQxProjects.QxPrjId];
                if (strPrjId == null)
                {
                    strPrjId = "";
                }
                return strPrjId;
            }
            set
            {
                string strPrjId = value;
                Session.Add(conQxProjects.QxPrjId, strPrjId);
            }
        }

        #endregion 权限处理函数

    }
}