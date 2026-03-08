
/*-- -- -- -- -- -- -- -- -- -- --
类名:wfmQxFuncModuleB_QUDI
表名:QxFuncModule(00140086)
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
    /// wfmQxFuncModuleB_QUDI 的摘要说明。其中Q代表查询,U代表修改
    /// (AutoGCLib.AutoGC7Cs_CWeb_Net2005:A_GenViewCode)
    /// </summary>
    public partial class wfmQxFuncModuleB_QUDI : System.Web.UI.Page
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
                vsTabName = string.Format("{0}", clsvQxFuncModuleEN._CurrTabName);
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
                wucQxFuncModuleB1.SetDdl_QxPrjId();
                clsQxProjectsBL.BindDdl_QxPrjId(ddlQxPrjId_q);
                clsCommForWebForm.BindDdl_TrueAndFalse(ddlInUse_q);
                ddlQxPrjId_q.SelectedValue = clsCommonSession.UserPrjId;
                ddlQxPrjId_q.Enabled = false;
                ddlInUse_q.SelectedIndex = 1;
     
                wucvQxFuncModule4Gv1.SetSortBy(string.Format("{0} Asc", convQxFuncModule.OrderNum));
                //2、显示无条件的表内容在GridView中
                BindGv_vQxFuncModule();
                //3、设置表控件中字控件的ReadOnly属性,
                // 使之只读,因为在修改功能中关键字是不能被修改的。
                wucQxFuncModuleB1.SetKeyReadOnly(true);
                DispQxFuncModuleListRegion();
                //设置逻辑层的公共函数，包含：缓存刷新函数
                //clsQxFuncModuleBL.objCommFun4BL = new clsCommFun4BL4QxFuncModule();
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
        protected void BindGv_vQxFuncModule()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevQxFuncModuleCondion();
                //	2、调用控件中的绑定GridView函数；
                wucvQxFuncModule4Gv1.BindGv_QxFuncModule(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                //wucvQxFuncModule4Gv1.SetGvVisibility(convQxFuncModule.UpdDate, false);
                //wucvQxFuncModule4Gv1.SetGvVisibility(convQxFuncModule.UpdUser, false);
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
        protected string CombinevQxFuncModuleCondion()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            clsvQxFuncModuleEN objvQxFuncModuleEN = new clsvQxFuncModuleEN();
            try
            {
                if (this.txtFuncModuleName_q.Text.Trim() != "")
                {
                    objvQxFuncModuleEN.FuncModuleName = this.txtFuncModuleName_q.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convQxFuncModule.FuncModuleName, this.txtFuncModuleName_q.Text.Trim());
                }
                if (this.txtFuncModuleNameSim_q.Text.Trim() != "")
                {
                    objvQxFuncModuleEN.FuncModuleNameSim = this.txtFuncModuleNameSim_q.Text.Trim();
                    strWhereCond += string.Format(" And {0} like '%{1}%'", convQxFuncModule.FuncModuleNameSim, this.txtFuncModuleNameSim_q.Text.Trim());
                }
                if (this.ddlQxPrjId_q.SelectedValue != "" && this.ddlQxPrjId_q.SelectedValue != "0")
                {
                    objvQxFuncModuleEN.QxPrjId = this.ddlQxPrjId_q.SelectedValue;
                    strWhereCond += string.Format(" And {0} = '{1}'", convQxFuncModule.QxPrjId, this.ddlQxPrjId_q.SelectedValue);
                }
                if (this.ddlInUse_q.SelectedIndex == 1)
                {
                    objvQxFuncModuleEN.InUse = true;
                    strWhereCond += string.Format(" And {0} = '1'", convQxFuncModule.InUse);
                }
                else if (this.ddlInUse_q.SelectedIndex == 2)
                {
                    objvQxFuncModuleEN.InUse = false;
                    strWhereCond += string.Format(" And {0} = '0'", convQxFuncModule.InUse);
                }
                clsvQxFuncModuleBL.CheckProperty4Condition(objvQxFuncModuleEN);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:WebI000002)在组合查询条件(CombineQxFuncModuleCondion)时出错!请联系管理员!" + objException.Message);
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


        /// <summary>
        /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListRegion)
        /// </summary>
        private void DispQxFuncModuleListRegion()
        {
            divList.Visible = true;
            tabEditQxFuncModuleRegion.Visible = false;
        }

        /// <summary>
        /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispEditRegion)
        /// </summary>
        private void DispEditQxFuncModuleRegion()
        {
            divList.Visible = false;
            tabEditQxFuncModuleRegion.Visible = true;
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
            wucvQxFuncModule4Gv1.PageIndex = 0;
            //把表记录的内容显示在GridView中
            BindGv_vQxFuncModule();
        }

        /// <summary>
        /// 导出Excel。根据查询区组合的查询条件,从[vQxFuncModule]表中获取记录集,最终导出到Excel
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
        /// </summary>
        private void ExportExcel()
        {
            //	1、组合界面条件串；
            string strWhereCond = CombinevQxFuncModuleCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            List<string> arrCnName = new List<string>();
            List<string> arrColName = new List<string>();
            string strFileName = "QxFuncModule信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxFuncModule.FuncModuleId); arrCnName.Add("模块Id");
            arrColName.Add(convQxFuncModule.FuncModuleName); arrCnName.Add("模块名");
            arrColName.Add(convQxFuncModule.FuncModuleNameSim); arrCnName.Add("模块名_Sim");
            arrColName.Add(convQxFuncModule.FuncModuleEnName); arrCnName.Add("模块英文名");
            arrColName.Add(convQxFuncModule.OrderNum); arrCnName.Add("排序号");
            arrColName.Add(convQxFuncModule.QxPrjId); arrCnName.Add("项目Id");
            arrColName.Add(convQxFuncModule.PrjName); arrCnName.Add("工程名");
            arrColName.Add(convQxFuncModule.InUse); arrCnName.Add("是否在用");
            arrColName.Add(convQxFuncModule.UpdDate); arrCnName.Add("修改日期");
            arrColName.Add(convQxFuncModule.UpdUser); arrCnName.Add("修改用户");
            arrColName.Add(convQxFuncModule.Memo); arrCnName.Add("备注");
            strFolderName =Entity.clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            //初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
            if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
            {
                return;
            }
            try
            {
                //	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsvQxFuncModuleBL.GetDataTable(strWhereCond);
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

        #region 添加

        ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
        /// <summary>
        ///添加新记录的事件过程 
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnAddNewRec4Gv_Click)
        /// </summary>
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            AddQxFuncModuleRecord();
        }

        /// <summary>
        /// 为插入记录做准备工作
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
        /// </summary>
        protected void AddQxFuncModuleRecord()
        {
            wucQxFuncModuleB1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelQxFuncModuleEdit.Text = "取消添加";
            //wucQxFuncModuleB1.FuncModuleId = clsQxFuncModuleBL.GetMaxStrId_S();
            DispEditQxFuncModuleRegion();
        }

        /// <summary>
        /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnOKUpd_ClickCode)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsQxFuncModuleEN objQxFuncModuleEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddQxFuncModuleRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    AddQxFuncModuleRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码,由于逻辑层太简单,
                    //就把逻辑层合并到控制层,
                    objQxFuncModuleEN = (clsQxFuncModuleEN)Session["objQxFuncModuleEN"];
                    UpdateQxFuncModuleRecordSave(objQxFuncModuleEN);
                    break;
            }
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        protected bool AddQxFuncModuleRecordSave()
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
            clsQxFuncModuleEN objQxFuncModuleEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucQxFuncModuleB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、定义对象并初始化对象
            //clsQxFuncModuleEN objQxFuncModuleEN;	//定义对象
            objQxFuncModuleEN = new clsQxFuncModuleEN(wucQxFuncModuleB1.FuncModuleId);  //初始化新对象

            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsQxFuncModuleBL.IsExist(objQxFuncModuleEN.FuncModuleId))  //判断是否有相同的关键字
            {
                strMsg = "(errid:WebI000004)关键字字段已有相同的值";
                clsCommonJsFunc.Alert(this, strMsg);
                return false;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToQxFuncModuleClass(objQxFuncModuleEN);      //把界面的值传到
                                                                //5.1、检查传进去的对象属性是否合法
            try
            {
                clsQxFuncModuleBL.CheckPropertyNew(objQxFuncModuleEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxFuncModuleBL.AddNewRecordBySql2(objQxFuncModuleEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return false;
            }
            strMsg = "添加记录成功!";
            clsCommonJsFunc.Alert(this, strMsg);
            lblMsg_Edit.Text = "添加记录成功!";
            //7、把新添的记录内容显示在GridView中
            BindGv_vQxFuncModule();
            DispQxFuncModuleListRegion();
            wucQxFuncModuleB1.Clear();      //清空控件中内容
                                            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxFuncModuleEdit.Text = "取消编辑";
            return true;
        }
        #endregion 添加

        #region 修改

        /// <summary>
        /// 函数功能:把类对象的属性内容显示到界面上
        ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
        /// </summary>
        /// <param name = "pobjQxFuncModuleEN">表实体类对象</param>
        protected void GetDataFromQxFuncModuleClass(clsQxFuncModuleEN pobjQxFuncModuleEN)
        {
            wucQxFuncModuleB1.FuncModuleId = pobjQxFuncModuleEN.FuncModuleId;// 模块Id
            wucQxFuncModuleB1.FuncModuleName = pobjQxFuncModuleEN.FuncModuleName;// 模块名
            wucQxFuncModuleB1.FuncModuleNameSim = pobjQxFuncModuleEN.FuncModuleNameSim;// 模块名_Sim
            wucQxFuncModuleB1.FuncModuleEnName = pobjQxFuncModuleEN.FuncModuleEnName;// 模块英文名
            wucQxFuncModuleB1.OrderNum = pobjQxFuncModuleEN.OrderNum;// 排序号
            wucQxFuncModuleB1.QxPrjId = pobjQxFuncModuleEN.QxPrjId;// 项目Id
            wucQxFuncModuleB1.InUse = pobjQxFuncModuleEN.InUse;// 是否在用
            
            
            //wucQxFuncModuleB1.Memo = pobjQxFuncModuleEN.Memo;// 备注
        }

        /// <summary>
        /// 函数功能:把界面上的属性数据传到类对象中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
        /// </summary>
        /// <param name = "pobjQxFuncModuleEN">数据传输的目的类对象</param>
        protected void PutDataToQxFuncModuleClass(clsQxFuncModuleEN pobjQxFuncModuleEN)
        {
            pobjQxFuncModuleEN.FuncModuleId = wucQxFuncModuleB1.FuncModuleId;// 模块Id
            pobjQxFuncModuleEN.FuncModuleName = wucQxFuncModuleB1.FuncModuleName;// 模块名
            pobjQxFuncModuleEN.FuncModuleNameSim = wucQxFuncModuleB1.FuncModuleNameSim;// 模块名_Sim
            pobjQxFuncModuleEN.FuncModuleEnName = wucQxFuncModuleB1.FuncModuleEnName;// 模块英文名
            pobjQxFuncModuleEN.OrderNum = wucQxFuncModuleB1.OrderNum;// 排序号
            pobjQxFuncModuleEN.QxPrjId = wucQxFuncModuleB1.QxPrjId;// 项目Id
            pobjQxFuncModuleEN.InUse = wucQxFuncModuleB1.InUse;// 是否在用
            pobjQxFuncModuleEN.UpdDate = wucQxFuncModuleB1.UpdDate;// 修改日期
            pobjQxFuncModuleEN.UpdUser = wucQxFuncModuleB1.UpdUser;// 修改用户
            //pobjQxFuncModuleEN.Memo = wucQxFuncModuleB1.Memo;// 备注
        }


        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQxFuncModule4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strFuncModuleId = e.KeyId;
            UpdateQxFuncModuleRecord(strFuncModuleId);
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
        /// </summary>
        /// <param name = "objQxFuncModuleEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        protected bool UpdateQxFuncModuleRecordSave(clsQxFuncModuleEN objQxFuncModuleEN)
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
            if (!wucQxFuncModuleB1.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
                return false;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToQxFuncModuleClass(objQxFuncModuleEN);      //把界面的值传到
                                                                //3.1、检查传进去的对象属性是否合法
            try
            {
                clsQxFuncModuleBL.CheckPropertyNew(objQxFuncModuleEN);
                //4、把数据实体层的数据存贮到数据库中
                clsQxFuncModuleBL.UpdateBySql2(objQxFuncModuleEN);
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
            BindGv_vQxFuncModule();
            DispQxFuncModuleListRegion();
            wucQxFuncModuleB1.Clear();//添空控件中的内容
                                      //恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelQxFuncModuleEdit.Text = "取消编辑";
            //跳转到列表中刚刚的记录处,使用锚点功能。
            this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_QxFuncModule{0}'", objQxFuncModuleEN.FuncModuleId.ToString().Trim()), true);
            return true;
        }

        /// <summary>
        /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
        /// </summary>
        protected void UpdateQxFuncModuleRecord(string strFuncModuleId)
        {
            //操作步骤:(总共2步)
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strFuncModuleId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucQxFuncModuleB1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelQxFuncModuleEdit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditQxFuncModuleRegion();
        }

        /// <summary>
        /// 事件函数:取消编辑状态，退回到列表状态
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void btnCancelQxFuncModuleEdit_Click(object sender, EventArgs e)
        {
            DispQxFuncModuleListRegion();
        }

        /// <summary>
        /// 函数功能:把以该关键字的记录内容显示在界面上,
        ///　　　   在这里是把值传到表控件中
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
        /// </summary>
        /// <param name = "strFuncModuleId">表记录的关键字,显示该表关键字的内容</param>
        protected void ShowData(string strFuncModuleId)
        {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strFuncModuleId == "") return;      //如果关键字为空就返回退出
                                                    //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            if (clsQxFuncModuleBL.IsExist(strFuncModuleId) == false)        //检查该关键字的记录是否存在
            {
                string strMsg = "(errid:WebI000010)在表[QxFuncModule]中,关键字为:[strFuncModuleId]的记录不存在!";
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN(strFuncModuleId);
            //4、获取类对象的所有属性；
            try
            {
                clsQxFuncModuleBL.GetQxFuncModule(ref objQxFuncModuleEN);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_Edit.Text = strMsg;
                return;
            }
            Session.Add("objQxFuncModuleEN", objQxFuncModuleEN);
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            GetDataFromQxFuncModuleClass(objQxFuncModuleEN);
        }

        /// <summary>
        ///修改当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strFuncModuleId = wucvQxFuncModule4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFuncModuleId) == true) return;
            UpdateQxFuncModuleRecord(strFuncModuleId);
        }
        #endregion 修改

        #region 删除

        /// <summary>
        /// 根据给定关键字删除记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
        /// </summary>
        /// <param name = "strFuncModuleId">给定关键字</param>
        protected void DeleteQxFuncModuleRecord(string strFuncModuleId)
        {
            try
            {
                clsQxFuncModuleBL.DelRecord(strFuncModuleId);
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_List.Text = strMsg;
                return;
            }
            BindGv_vQxFuncModule();
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQxFuncModule4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strFuncModuleId = e.KeyId;
            DeleteQxFuncModuleRecord(strFuncModuleId);
        }

        /// <summary>
        ///删除当前被选记录
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstFuncModuleId = wucvQxFuncModule4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncModuleId == null) return;
            lblMsg_List.Text = "";
            try
            {
                foreach (string strFuncModuleId in lstFuncModuleId)
                {
                    clsQxFuncModuleBL.DelRecord(strFuncModuleId);
                }
            }
            catch (Exception objException)
            {
                string strMsg = "(errid:WebI000021)删除记录不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_List.Text = strMsg;
                return;
            }
            BindGv_vQxFuncModule();
        }
        #endregion 删除

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
            List<string> lstFuncModuleId = wucvQxFuncModule4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncModuleId == null)
            {
                lblMsg_List.Text = "请选择需要置底的记录!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsQxFuncModuleBL.GoBottom(lstFuncModuleId, strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置底出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_List.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevQxFuncModuleCondion();
            wucvQxFuncModule4Gv1.BindGv_QxFuncModule(strWhereCond);
        }

        /// <summary>
        ///置顶
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnGoTop_Click)
        /// </summary>
        protected void btnGoTop_Click(object sender, System.EventArgs e)
        {
            if (PreCheck4Order() == false) return;
            string strQxPrjId = ddlQxPrjId_q.SelectedValue;
            List<string> lstFuncModuleId = wucvQxFuncModule4Gv1.GetAllCheckedKeysFromGv();
            if (lstFuncModuleId == null)
            {
                lblMsg_List.Text = "请选择需要置顶的记录!";
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsQxFuncModuleBL.GoTop(lstFuncModuleId, strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevQxFuncModuleCondion();
            wucvQxFuncModule4Gv1.BindGv_QxFuncModule(strWhereCond);
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
                clsQxFuncModuleBL.ReOrder(strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strWhereCond = CombinevQxFuncModuleCondion();
            wucvQxFuncModule4Gv1.BindGv_QxFuncModule(strWhereCond);
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
            string strFuncModuleId = wucvQxFuncModule4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strFuncModuleId) == true)
            {
                lblMsg_List.Text = string.Format("请选择需要移动({0})的记录!", strDirect);
                clsCommonJsFunc.Alert(this, lblMsg_List.Text);
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                clsQxFuncModuleBL.AdjustOrderNum(strDirect, strFuncModuleId, strQxPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("移动({0})记录出错。错误:{1}.({2})", strDirect, objException.Message, clsStackTrace.GetCurrClassFunction());
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg_List.Text = strMsg;
                return;
            }
            string strWhereCond = CombinevQxFuncModuleCondion();
            wucvQxFuncModule4Gv1.BindGv_QxFuncModule(strWhereCond);
        }

        #endregion 调整记录次序

        protected void btnSynchFuncModule_Click(object sender, EventArgs e)
        {
            //hidDivName.Value = "divGetObjLst";
            string strWhereCond = string.Format("{0}='{1}'", conFuncModule.PrjId, getUserPrjId);
            try
            {
                List<clsFuncModule_AgcEN> arrFuncModuleObjLst = clsFuncModule_AgcWApi.GetObjLst(strWhereCond);
                int intCount = 0;

                foreach (clsFuncModule_AgcEN objInFor in arrFuncModuleObjLst)
                {
                    clsQxFuncModuleEN objQxFuncModuleEN = new clsQxFuncModuleEN();
                    clsQxFuncModuleBLEx.CopyTo(objInFor, objQxFuncModuleEN);
                    if (clsQxFuncModuleBL.IsExist(objQxFuncModuleEN.FuncModuleId) == false)
                    {
                        objQxFuncModuleEN.AddNewRecord();
                        intCount++;
                    }
                }
                BindGv_vQxFuncModule();
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