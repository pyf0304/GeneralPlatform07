
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmQxFuncModule_Agc_QUDI
表名:QxFuncModule_Agc(00140086)
生成代码版本:2018.10.19.1
生成日期:2018/11/21 21:13:36
生成者:
工程名称:统一平台
工程ID:0014
相关数据库:103.116.76.183,9433MSEduSys
PrjDataBaseId:0199
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:Web界面后台代码(WebViewControlCode)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
     2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

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
using GeneralPlatform;
using AGC.Entity;
using AGC4WApi;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmQxFuncModule_Agc_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenViewCode)
    /// </summary>
    public partial class wfmQxFuncModule_Agc_QUDI : System.Web.UI.Page
    {

        #region 界面初始化

        /// <summary>
        /// 函数功能:页面导入,当页面开始运行时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)    ///如果本界面是初次被调用,而不是单击按钮事件所调用
            {

                vsViewName = "功能模块维护";
                vsTabName = string.Format("{0}", clsvQxFuncModule_AgcEN._CurrTabName);
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
          
                clsQxProjectsBL.BindDdl_QxPrjId(ddlQxPrjId_q);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlInUse_q);
                ddlQxPrjId_q.SelectedValue = clsCommonSession.UserPrjId;
                ddlQxPrjId_q.Enabled = false;
                ddlInUse_q.SelectedIndex = 1;
     
                wucvQxFuncModule_Agc4Gv1.SetSortBy(string.Format("{0} Asc", convQxFuncModule_Agc.OrderNum));
                //2、显示无条件的表内容在GridView中
                BindGv_vQxFuncModule_Agc();
                //3、设置表控件中字控件的ReadOnly属性,
       
                
            }
        }

        #endregion 界面初始化

        #region 权限管理

        /// <summary>
        /// Session属性:登录的用户ID,用于检查用户权限
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_WebView_CS_DefProperty_seUserId)
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

        /// <summary>
        /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
        /// 姓名:
        /// 日期:
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_WebView_CS_DefProperty_qsUserId)
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
        /// ViewState属性:用于记录当前用户在当前界面的权限等级
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
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
        /// 与权限相关的界面编号
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_WebView_CS_DefConst_ViewId4Potence)
        /// </summary>
        protected const string ViewId4Potence = "00260203";     //界面编号

        #endregion 权限管理

        #region 查询

        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vQxFuncModule_Agc()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevQxFuncModule_AgcCondion();
                //	2、调用控件中的绑定GridView函数；
                wucvQxFuncModule_Agc4Gv1.BindGv_QxFuncModule_Agc(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvQxFuncModule_Agc4Gv1.SetGvVisibility(convQxFuncModule_Agc.UpdDate, false);
                //wucvQxFuncModule_Agc4Gv1.SetGvVisibility(convQxFuncModule_Agc.UpdUser, false);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }

        }


        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondion)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevQxFuncModule_AgcCondion()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN = new clsvQxFuncModule_AgcEN();
            try
            {
                if (this.txtFuncModuleName_q.Text.Trim() != "")
                {
                    objvQxFuncModule_AgcEN.FuncModuleName = this.txtFuncModuleName_q.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convQxFuncModule_Agc.FuncModuleName, this.txtFuncModuleName_q.Text.Trim());
                }
                if (this.txtFuncModuleNameSim_q.Text.Trim() != "")
                {
                    objvQxFuncModule_AgcEN.FuncModuleNameSim = this.txtFuncModuleNameSim_q.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convQxFuncModule_Agc.FuncModuleNameSim, this.txtFuncModuleNameSim_q.Text.Trim());
                }
                if (this.ddlQxPrjId_q.SelectedValue != "" && this.ddlQxPrjId_q.SelectedValue != "0")
                {
                    objvQxFuncModule_AgcEN.QxPrjId = this.ddlQxPrjId_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convQxFuncModule_Agc.QxPrjId, this.ddlQxPrjId_q.SelectedValue);
                }
                clsvQxFuncModule_AgcBL.CheckProperty4Condition(objvQxFuncModule_AgcEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineQxFuncModule_AgcCondion)时出错!请联系管理员!" + objException.Message);
                throw new Exception(strMsg);
            }
            return strWhereCond;
        }

        /// <summary>
        /// 专门用于记录GridView中的每页记录数
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
        /// </summary>
        public string PageSize
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


      
        #endregion 查询

        #region 导出到文件

        /// <summary>
        /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {
            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            wucvQxFuncModule_Agc4Gv1.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_vQxFuncModule_Agc();
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vQxFuncModule_Agc]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevQxFuncModule_AgcCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QxFuncModule_Agc信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxFuncModule_Agc.FuncModuleAgcId); arrCnName.Add("模块Id");
            arrColName.Add(convQxFuncModule_Agc.FuncModuleName); arrCnName.Add("模块名");
            arrColName.Add(convQxFuncModule_Agc.FuncModuleNameSim); arrCnName.Add("模块名_Sim");
            arrColName.Add(convQxFuncModule_Agc.FuncModuleEnName); arrCnName.Add("模块英文名");
            arrColName.Add(convQxFuncModule_Agc.OrderNum); arrCnName.Add("排序号");
            arrColName.Add(convQxFuncModule_Agc.QxPrjId); arrCnName.Add("项目Id");
            arrColName.Add(convQxFuncModule_Agc.PrjName); arrCnName.Add("工程名");
            //arrColName.Add(convQxFuncModule_Agc.InUse); arrCnName.Add("是否在用");
            arrColName.Add(convQxFuncModule_Agc.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convQxFuncModule_Agc.UpdUser); arrCnName.Add("修改用户");
            arrColName.Add(convQxFuncModule_Agc.Memo); arrCnName.Add("备注");
            strFolderName = Entity.clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvQxFuncModule_AgcBL.GetDataTable(strWhereCond);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取数据出错,请联系管理员！错误:{0}.({1})",
                objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            try
            {
                //用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
                GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
            }
            catch (Exception objException)
            {
                try
                {
                    clsPubVar.objLog.WriteDebugLog(objException.Message);
                    GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
                    //GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
                }
                catch (Exception objException2)
                {
                    string strMsg = string.Format("导出Excel出错,请联系管理员！错误:{0}.({1})",
                    objException2.Message, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
            }
            clsCommForWebForm.DownLoadFile(strDownLoadFileName);
        }

        /// <summary>
        /// 事件函数:把查询条件的表记录，导出到Excel.
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
        {
            //导出Excel函数
            ExportExcel();
        }

        /// <summary>
        /// ViewState属性:当前操作的界面功能名称
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_WebView_CS_DefProperty_vsViewName)
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
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_WebView_CS_DefProperty_vsTabName)
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

        #endregion 导出到文件

        
        #region 调整记录次序

        /// <summary>
        ///下移
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDownMove_Click)
        /// </summary>
        protected void btnDownMove_Click(object sender, System.EventArgs e)
        {
            MoveRecord("DOWN");
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnGoBottum_Click)
        /// </summary>
        protected void btnGoBottum_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strQxPrjId = ddlQxPrjId_q.SelectedValue;
            List<string> lstFuncModuleId = wucvQxFuncModule_Agc4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncModuleId == null)
            {
                lblMsg_List.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsQxFuncModule_AgcBL.GoBottom(lstFuncModuleId, strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_List.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevQxFuncModule_AgcCondion();
            wucvQxFuncModule_Agc4Gv1.BindGv_QxFuncModule_Agc(strWhereCond);
        }

        /// <summary>
        ///置顶
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnGoTop_Click)
        /// </summary>
        protected void btnGoTop_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strQxPrjId = ddlQxPrjId_q.SelectedValue;
            List<string> lstFuncModuleId = wucvQxFuncModule_Agc4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncModuleId == null)
            {
                lblMsg_List.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsQxFuncModule_AgcBL.GoTop(lstFuncModuleId, strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevQxFuncModule_AgcCondion();
            wucvQxFuncModule_Agc4Gv1.BindGv_QxFuncModule_Agc(strWhereCond);
        }

        /// <summary>
        ///重序
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnReOrder_Click)
        /// </summary>
        protected void btnReOrder_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strQxPrjId = ddlQxPrjId_q.SelectedValue;
            try
            {
                clsQxFuncModule_AgcBL.ReOrder(strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevQxFuncModule_AgcCondion();
            wucvQxFuncModule_Agc4Gv1.BindGv_QxFuncModule_Agc(strWhereCond);
        }

        /// <summary>
        ///上移
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpMove_Click)
        /// </summary>
        protected void btnUpMove_Click(object sender, System.EventArgs e)
        {
            MoveRecord("UP");
        }

        /// <summary>
        ///置底
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPreCheck4Order)
        /// </summary>
        private bool PreCheck4Order()
        {
            if (ddlQxPrjId_q.SelectedIndex <= 0)
            {
                lblMsg_List.Text = "请输入QxPrjId!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                ddlQxPrjId_q.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        ///移动记录，包括上移和下移
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenMoveRecord)
        /// </summary>
        protected void MoveRecord(string strDirect)
        {
            if (PreCheck4Order() == false) return;
            string strQxPrjId = ddlQxPrjId_q.SelectedValue;
            string strFuncModuleId = wucvQxFuncModule_Agc4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFuncModuleId) == true)
            {
                lblMsg_List.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsQxFuncModule_AgcBL.AdjustOrderNum(strDirect, strFuncModuleId, strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_List.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevQxFuncModule_AgcCondion();
            wucvQxFuncModule_Agc4Gv1.BindGv_QxFuncModule_Agc(strWhereCond);
        }

        #endregion 调整记录次序

        protected void btnSynchFuncModule_Click(object sender, EventArgs e)
        {
            //hidDivName.Value = "divGetObjLst";
            string strWhereCond = string.Format("{0}='{1}'", conFuncModule.PrjId, getUserPrjId);
            try
            {
                string strSynchDate = clsDateTime.getTodayStr(0);
                List<clsFuncModule_AgcEN> arrFuncModuleObjLst = clsFuncModule_AgcWApi.GetObjLst(strWhereCond);
                int intCount = 0;

                foreach (clsFuncModule_AgcEN objInFor in arrFuncModuleObjLst)
                {
                    clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = new clsQxFuncModule_AgcEN();
                    clsQxFuncModule_AgcBLEx.CopyTo(objInFor, objQxFuncModule_AgcEN);
                    objQxFuncModule_AgcEN.SynchDate = strSynchDate;
                    if (clsQxFuncModule_AgcBL.IsExist(objQxFuncModule_AgcEN.FuncModuleAgcId) == false)
                    {
                        objQxFuncModule_AgcEN.AddNewRecord();
                        intCount++;
                    }
                    else
                    {
                        objQxFuncModule_AgcEN.Update();
                        intCount++;
                    }
                }
                string strCondition = string.Format("{0} <> '{1}'", conQxFuncModule_Agc.SynchDate, strSynchDate);
                clsQxFuncModule_AgcBL.DelQxFuncModule_AgcsByCond(strCondition);
                BindGv_vQxFuncModule_Agc();
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