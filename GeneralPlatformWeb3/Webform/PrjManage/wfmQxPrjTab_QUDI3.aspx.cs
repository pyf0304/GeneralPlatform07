
using GeneralPlatform;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;

using GeneralPlatform.Entity;
using GeneralPlatform.web.treeview;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.json;
using com.taishsoft.web.treeview;
using CommFunc4WebForm;


using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using AGC.Entity;
using AGC4WApi;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmQxPrjTab_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmQxPrjTab_QUDI3 : System.Web.UI.Page
    {

        //生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            //根据传回来的值决定调用哪个函数

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
            {


                //clsPubFun.ShowUserDefaLangType(rblNetOrJava);
                //生成权限有关判断权限的代码
                //根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推


                //vsViewName = "vQxPrjTab";

                clsFuncModuleBL.BindDdl_FuncModuleId(ddlFuncModuleId, getUserPrjId);
    
                clsTabStateBL.BindDdl_TabStateIdCache(ddlTabStateId_q);
                clsSQLDSTypeBL.BindDdl_SQLDSTypeIdCache(ddlSQLDSTypeId);



                //恢复上一次在此界面的状态
                if (new clsCommonSession().FuncModuleId != "")
                {
                    clsDropDownList.SetDdlValue(ddlFuncModuleId, new clsCommonSession().FuncModuleId);
                }
                //if (ObjId != "")
                //{
                //    clsDropDownList.SetDdlValue(ddlObjId_q, ObjId);
                //}

                txtTabName_q.Text = new clsCommonSession().TabName;
                txtTabCnName_q.Text = new clsCommonSession().TabCnName;

                //=====================================================

                ddlTabStateId_q.SelectedValue = "01";
                if (new clsCommonSession().SqlDsTypeId == "")
                {
                    ddlSQLDSTypeId.SelectedValue = "0";
                }
                else
                {
                    ddlSQLDSTypeId.SelectedValue = new clsCommonSession().SqlDsTypeId;
                }
                //2、显示无条件的表内容在DATAGRID中
                if (string.IsNullOrEmpty(vsSortQxPrjTabBy) == true)
                {
                    vsSortQxPrjTabBy = "UpdDate Desc";
                    wucvQxPrjTab4Gv1.SetSortBy("UpdDate Desc");
                }
                else
                {
                    wucvQxPrjTab4Gv1.SetSortBy(vsSortQxPrjTabBy);
                }

                //2、显示无条件的表内容在DATAGRID中
                try
                {
                    BindGv_vQxPrjTab();
                }
                catch (Exception objException)
                {
                    clsCommonJsFunc.Alert(this, objException.Message);
                    return;
                }
                
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
            wucvQxPrjTab4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在DATAGRID中
            //clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvQxPrjTab, vsViewName, clsCommonSession.UserId);
            new clsCommonSession().FuncModuleId = ddlFuncModuleId.SelectedValue;

            //ObjId = ddlObjId_q.SelectedValue;
            new clsCommonSession().TabName = txtTabName_q.Text;
            new clsCommonSession().TabCnName = txtTabCnName_q.Text;
            new clsCommonSession().SqlDsTypeId = ddlSQLDSTypeId.SelectedValue;

            try
            {
                BindGv_vQxPrjTab();
            }
            catch (Exception objExcepiton)
            {
                clsCommonJsFunc.Alert(this, objExcepiton.Message);
                return;
            }
            //保存这次查询条件，为下一次再来该界面服务


        }


        //生成专门用于导出Excel的相关代码
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        private List<string> getAllCheckedTabIds()
        {

            List<string> lstTabId = wucvQxPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return null;
            lblMsg_List.Text = "";
            return lstTabId;
        }

        private string getFirstCheckedTabId()
        {
            string strTabId = wucvQxPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return null;
            lblMsg_List.Text = "";
            return strTabId;
        }

        protected string vsSortQxPrjTabBy
        {
            get
            {
                string sSortQxPrjTabBy;
                sSortQxPrjTabBy = (string)ViewState["SortQxPrjTabBy"];
                if (sSortQxPrjTabBy == null)
                {
                    sSortQxPrjTabBy = "";
                }
                return sSortQxPrjTabBy;
            }
            set
            {
                string sSortQxPrjTabBy = value;
                ViewState.Add("SortQxPrjTabBy", sSortQxPrjTabBy);
            }
        }


        protected void lbSetModuleByObj_Click(object sender, EventArgs e)
        {

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
                    PageSize4QxPrjTab = intPageSize.ToString();
                    try
                    {
                        BindGv_vQxPrjTab();
                    }
                    catch (Exception objException)
                    {
                        clsCommonJsFunc.Alert(this, objException.Message);
                        return;
                    }

                }
            }
        }


        protected void btnEditEx_Click(object sender, EventArgs e)
        {

            string strTabId = wucvQxPrjTab4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strTabId) == true) return;
            lblMsg_List.Text = "";
            new clsCommonSession().TabId = strTabId;
            //1、显示该关键字的数据让用户修改该关键字记录；
            clsCommonSession.ParentPage = Page.Request.Url.AbsolutePath;
            string c1 = @"<script language='javascript'>window.open('../../FrameSetForTable.htm','EditTable'); </script>";
            Response.Write(c1);
        }
      

        private void DispAdvanceOperate()
        {
            //if (lbDispAdvanceDiv.Text == "高级操作")
            //{
            //    divAdvanceOperate.Visible = true;
            //    lbDispAdvanceDiv.Text = "隐藏高级操作";
            //}
            //else
            //{
            //    divAdvanceOperate.Visible = false;
            //    lbDispAdvanceDiv.Text = "高级操作";

            //}
        }

        protected void lbDispAdvanceDiv_Click(object sender, EventArgs e)
        {
            DispAdvanceOperate();
        }

        protected void ddlAppPageTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSetTabState_Click(object sender, EventArgs e)
        {
            List<string> lstTabId = wucvQxPrjTab4Gv1.GetAllCheckedKeysFromGv();
            if (lstTabId == null) return;

            if (ddlTabStateId_q.SelectedIndex <= 0)
            {
                lblMsg_List.Text = "没有选择表状态，请选择一个有效的表状态!";

                ddlTabStateId_q.Focus();
                return;
            }
            string strTabStateId = ddlTabStateId_q.SelectedValue;
            lblMsg_List.Text = "";
            foreach (string strTabId in lstTabId)
            {
                clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.GetObjByTabId(strTabId);
                objQxPrjTabEN.TabStateId = strTabStateId;
                objQxPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objQxPrjTabEN.UpdUserId = clsCommonSession.UserId;
                clsQxPrjTabBL.UpdateBySql2(objQxPrjTabEN);
            }
            try
            {
                BindGv_vQxPrjTab();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
                return;
            }
        }

        protected void btnSynchPrjTab_Click(object sender, EventArgs e)
        {
            //hidDivName.Value = "divGetObjLst";
            string strWhereCond = string.Format("{0}='{1}'", conPrjTab.PrjId, getUserPrjId);
            try
            {
                string strSynchDate = clsDateTime.getTodayStr(0);
                List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabWApi.GetObjLst(strWhereCond);
                int intCount = 0;

                foreach(clsPrjTabEN objInFor in arrPrjTabObjLst)
                {
                    clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN();
                    clsQxPrjTabBLEx.CopyTo(objInFor, objQxPrjTabEN);
                    objQxPrjTabEN.SynchDate = strSynchDate;
                    if (clsQxPrjTabBL.IsExist(objQxPrjTabEN.TabId) == false)
                    {
                        objQxPrjTabEN.AddNewRecord();
                        intCount++;
                    }
                    else
                    {
                        objQxPrjTabEN.Update();
                        intCount++;
                    }
                }
                string strCondition = string.Format("{0} <> '{1}'", conQxPrjTab.SynchDate, strSynchDate);
                clsQxPrjTabBL.DelQxPrjTabsByCond(strCondition);
                BindGv_vQxPrjTab();
                //lblResult12.Text = strInfo;
                //显示信息框
                string strInfo = string.Format("根据条件:[{0}]共获取对象列表数：{1}!", strWhereCond, intCount);
                clsCommonJsFunc.Alert(this, strInfo);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("根据条件获取相应的记录对象的列表不成功,{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
            }
        }
    }
    public partial class wfmQxPrjTab_QUDI3 : System.Web.UI.Page
    {


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
        protected string ObjId
        {
            get
            {
                string strObjId;
                strObjId = (string)Session["ObjId"];
                if (strObjId == null)
                {
                    strObjId = "";
                }
                return strObjId;
            }
            set
            {
                string strObjId = value;
                Session.Add("ObjId", strObjId);
            }
        }
        ///生成专门用于记录GridView中的每页记录数
        protected string PageSize4QxPrjTab
        {
            get
            {
                string strPageSize4QxPrjTab;
                strPageSize4QxPrjTab = (string)Session["PageSize4QxPrjTab"];
                if (strPageSize4QxPrjTab == null)
                {
                    strPageSize4QxPrjTab = "";
                }
                return strPageSize4QxPrjTab;
            }
            set
            {
                string strPageSize4QxPrjTab = value;
                Session.Add("PageSize4QxPrjTab", strPageSize4QxPrjTab);
            }
        }


        ///生成专门用于记录GridView中的每页记录数
        protected string DispAllErrMsg
        {
            get
            {
                string strPageSize4QxPrjTab;
                strPageSize4QxPrjTab = (string)Session["DispAllErrMsg"];
                if (strPageSize4QxPrjTab == null)
                {
                    strPageSize4QxPrjTab = "";
                }
                return strPageSize4QxPrjTab;
            }
            set
            {
                string strPageSize4QxPrjTab = value;
                Session.Add("DispAllErrMsg", strPageSize4QxPrjTab);
            }
        }




        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevQxPrjTabCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 and UserName = '张三'
            string strWhereCond = string.Format(" 1=1 and {0} = '{1}'", convQxPrjTab.QxPrjId, getUserPrjId);

            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtTabCnName_q.Text.Trim() != "")
            {
                strWhereCond += " and TabCnName like '" + this.txtTabCnName_q.Text.Trim() + "%'";
            }
            if (this.txtTabName_q.Text.Trim() != "")
            {
                strWhereCond += " and TabName like '" + this.txtTabName_q.Text.Trim() + "%'";
            }

            if (chkFuncModuleId_q.Checked)
            {
                if (this.ddlFuncModuleId.SelectedValue != "" && this.ddlFuncModuleId.SelectedValue != "0")
                {
                    strWhereCond += " and FuncModuleId='" + this.ddlFuncModuleId.SelectedValue + "'";
                }
            }
            if (chkTabStateId_q.Checked)
            {
                if (this.ddlTabStateId_q.SelectedValue != "" && this.ddlTabStateId_q.SelectedValue != "0")
                {
                    strWhereCond += " And TabStateId='" + this.ddlTabStateId_q.SelectedValue + "'";
                }
            }
            if (this.ddlSQLDSTypeId.SelectedValue != "" && this.ddlSQLDSTypeId.SelectedValue != "0")
            {
                strWhereCond += " And SQLDSTypeId='" + this.ddlSQLDSTypeId.SelectedValue + "'";
            }

            return strWhereCond;
        }
        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vQxPrjTab(string strCondition = "")
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                wucvQxPrjTab4Gv1.SetGvVisibility(convQxPrjTab.SqlDsTypeName, false);
                wucvQxPrjTab4Gv1.SetGvVisibility(convQxPrjTab.FuncModuleName, true);

                if (ddlTabStateId_q.SelectedValue != "01")//enumTabState.Normal_01)
                {
                    wucvQxPrjTab4Gv1.SetGvVisibility(convQxPrjTab.TabStateName, true);
                }
                else
                {
                    wucvQxPrjTab4Gv1.SetGvVisibility(convQxPrjTab.TabStateName, false);
                }

                //	1、组合界面条件串；
                string strWhereCond = "";
                if (string.IsNullOrEmpty(strCondition) == true)
                {
                    strWhereCond = CombinevQxPrjTabCondition();
                }
                else
                {
                    strWhereCond = string.Format("{0} And {1}='01'", strCondition, convQxPrjTab.TabStateId);

                }
                //	2、调用控件中的绑定GridView函数；
                wucvQxPrjTab4Gv1.BindGv_vQxPrjTab(strWhereCond);
                //	3、设置Gv控件的某些列不可见；

                //wucvQxPrjTab4Gv1.SetGvVisibility(convQxPrjTab.UpdUser, false);
                //clsSetFieldVisibilityBLEx.SetGvVisibilityByViewName(gvQxPrjTab, vsViewName, clsCommonSession.UserId);

            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }




        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在GridView中。
        /// </summary>
        protected void BindGv_QxPrjTabBak(params string[] args)
        {
            //操作步骤：(共5步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = "";
            if (args.Length == 0)
            {
                try
                {
                    strWhereCond = CombinevQxPrjTabCondition();
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }
            else if (args.Length == 1)
            {
                strWhereCond = string.Format("{0} And {1}='01' ",
                    args[0], convQxPrjTab.TabStateId);
            }
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            try
            {

                objDT = clsvQxPrjTabBL.GetDataTable(strWhereCond);

            }
            catch (Exception objException)
            {
                //clsCommonSession.seErrMessage = "获取数据表(DataTable)不成功!" + objException.Message;
                //clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = vsSortQxPrjTabBy;     ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
                                               ///设置GridView中每页的记录数
            //if (string.IsNullOrEmpty(PageSize4QxPrjTab) == false)
            //{
            //    int intPageSize = int.Parse(PageSize4QxPrjTab);
            //    gvQxPrjTab.PageSize = intPageSize;
            //}
            //else
            //{
            //    PageSize4QxPrjTab = "10";
            //    gvQxPrjTab.PageSize = 10;
            //}

            //this.gvQxPrjTab.DataSource = objDV;
            ////	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            //this.gvQxPrjTab.DataBind();

            /////生成专门用于BindGv中的跳页相关代码
            //GridViewRow pagerRow = gvQxPrjTab.BottomPagerRow;
            //if (pagerRow == null)
            //{
            //    return;
            //}
            //Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
            //Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
            //Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
            //TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
            //Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
            //Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
            //Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
            //DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
            //if (lblRecCount != null)
            //{
            //    //当前记录数
            //    lblRecCount.Text = objDT.Rows.Count.ToString();
            //    //当前页数
            //    lblAllPages.Text = this.gvQxPrjTab.PageCount.ToString();
            //    //当前页序数
            //    lblCurrentPage.Text = (this.gvQxPrjTab.PageIndex + 1).ToString();
            //    //当前即将跳到的页序数
            //    txtJump2Page.Text = (this.gvQxPrjTab.PageIndex + 1).ToString();
            //    //如果当前页序数为0，则<前一页>按钮无效
            //    if (this.gvQxPrjTab.PageIndex == 0)
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage, false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnPrevPage, true);
            //    }
            //    //如果当前页序数已为最后一页，则<前一页>按钮无效
            //    if (this.gvQxPrjTab.PageIndex == this.gvQxPrjTab.PageCount - 1)
            //    {
            //        clsPubFun.SetButtonEnabled(btnNextPage, false);
            //    }
            //    else
            //    {
            //        clsPubFun.SetButtonEnabled(btnNextPage, true);
            //    }
            //    //设置分页器中每页记录数的下拉框的值
            //    if (string.IsNullOrEmpty(PageSize4QxPrjTab) == false)
            //    {
            //        ddlPagerRecCount.Text = PageSize4QxPrjTab;
            //    }
            //    else
            //    {
            //        PageSize4QxPrjTab = "10";
            //        ddlPagerRecCount.Text = PageSize4QxPrjTab;
            //    }
            //}
            //gvQxPrjTab.BottomPagerRow.Visible = true;
        }



        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevQxPrjTabCondition();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QxPrjTab信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxPrjTab.TabName); arrCnName.Add("表名");
            arrColName.Add(convQxPrjTab.TabCnName); arrCnName.Add("表中文名");
            arrColName.Add(convQxPrjTab.TabId); arrCnName.Add("表ID");
            arrColName.Add(convQxPrjTab.Memo); arrCnName.Add("说明");

            arrColName.Add(convQxPrjTab.PrjName); arrCnName.Add("工程名称");
            arrColName.Add(convQxPrjTab.TabStateName); arrCnName.Add("表状态名称");
            strFolderName = Entity.clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;

            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvQxPrjTabBL.GetDataTable(strWhereCond);
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                //clsCommonSession.seErrMessage = objException.Message;
                //clsCommonSession.seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                //clsPubFun4Web.AccessError(this, conCurrPageName);
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }
       

        //生成返回链接串的Session属性
        protected string BackPageLinkStrFromUpdField
        {
            get
            {
                string strBackPageLinkStrFromUpdField;
                strBackPageLinkStrFromUpdField = (string)Session["BackPageLinkStrFromUpdField"];
                if (strBackPageLinkStrFromUpdField == null)
                {
                    strBackPageLinkStrFromUpdField = "";
                }
                return strBackPageLinkStrFromUpdField;
            }
            set
            {
                string strBackPageLinkStrFromUpdField = value;
                Session.Add("BackPageLinkStrFromUpdField", strBackPageLinkStrFromUpdField);
            }
        }


        /// <summary>
        /// 当前操作用户的Id_User,如果是教师就返回Id_Teacher,如果是学生就返回Id_StudentInfo。
        /// </summary>
        protected string vsReferTabId
        {
            get
            {
                string sReferTabId;
                sReferTabId = (string)ViewState["ReferTabId"];
                if (sReferTabId == null)
                {
                    sReferTabId = "";
                }
                return sReferTabId;
            }
            set
            {
                string sReferTabId = value;
                ViewState.Add("ReferTabId", sReferTabId);
            }
        }


        protected string vsTreeNodeType
        {
            get
            {
                string sTreeNodeType;
                sTreeNodeType = (string)ViewState["TreeNodeType"];
                if (sTreeNodeType == null)
                {
                    sTreeNodeType = "";
                }
                return sTreeNodeType;
            }
            set
            {
                string sTreeNodeType = value;
                ViewState.Add("TreeNodeType", sTreeNodeType);
            }
        }


        protected string vsKeyId
        {
            get
            {
                string sKeyId;
                sKeyId = (string)ViewState["KeyId"];
                if (sKeyId == null)
                {
                    sKeyId = "";
                }
                return sKeyId;
            }
            set
            {
                string sKeyId = value;
                ViewState.Add("KeyId", sKeyId);
            }
        }


        [WebMethod]
        public static string HelloWorld()
        {
            return "Hello World";
        }
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