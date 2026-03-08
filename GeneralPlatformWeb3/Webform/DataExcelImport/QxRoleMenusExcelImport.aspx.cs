using com.taishsoft.commdb;
using com.taishsoft.commdb4odbc;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;

using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using GeneralPlatform.Webform;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GeneralPlatform.DataExcelImport
{
    public partial class QxRoleMenusExcelImport : System.Web.UI.Page
    {
        //用于上传文件时，在WEB服务器上文件的目录
        private string strUploadFileDir = "";

        ///生成Excel路径名Session
        public static string ExcelPath
        {
            get
            {
                string strExcelPath;
                strExcelPath = (string)System.Web.HttpContext.Current.Session["ExcelPath"];
                if (strExcelPath == null)
                {
                    strExcelPath = "";
                }
                return strExcelPath;
            }
            set
            {
                string strExcelPath = value;
                System.Web.HttpContext.Current.Session.Add("ExcelPath", strExcelPath);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //this.Title = clsMyConfig.spPageTitle + "-学生信息导入";
                clsCommonSession.PageName = "学生信息导入";

                //clsXzMajorBL.BindDdl_id_XzMajor(ddlid_Major_q);
                //BindDdl_id_Grade(ddlid_Grade_q);
                strSortQxRoleMenusBy = "MenuId Asc";
                //2、显示无条件的表内容在DATAGRID中
                BindGv_QxRoleMenus();
                this.gvStuInfo.Visible = false;
            }

            this.strUploadFileDir = Server.MapPath(clsSysParaEN.UploadWebFolder + "/");
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            TransFileFromBrowToWebSvr();
            GetDataStudent();
            // ExcelBindGridview();
            // DataBase.BindDropdownExcel(ddlExcel, clsCommonSession.UserId);
        }
        //上传文件
        private bool TransFileFromBrowToWebSvr()
        {

            string strUpLoadFileName = "";
            string strFileName = "";
            lblMsg.Text = "";
            if ((FileUploadChoose.PostedFile != null) && (FileUploadChoose.PostedFile.ContentLength > 0))
            {
                string times = DateTime.Now.ToString("yyyyMMddHHmmss");
                //上传前先删除指定文件夹所有文件
                System.IO.DirectoryInfo path = new System.IO.DirectoryInfo(Server.MapPath(clsSysParaEN.UploadWebFolder));
                deletefile(path);

                //检验文件，文件不能为空和长度要大于0
                string AddFile = System.IO.Path.GetFileName(FileUploadChoose.PostedFile.FileName);
                strFileName = times + "_" + AddFile;
                strUpLoadFileName = strUploadFileDir + strFileName;
                ///如果相关子目录不存在就新建子目录
                if (System.IO.Directory.Exists(strUploadFileDir) == false)
                {
                    Directory.CreateDirectory(strUploadFileDir);

                }
                else
                {
                    string[] tmpStringArr = Directory.GetFiles(strUploadFileDir);
                    if (tmpStringArr.Length > 0)
                    {
                        for (int i = 0; i < tmpStringArr.Length; i++)
                        {
                            tmpStringArr[i].Remove(0);
                            //this.DeleteFile(tmpStringArr[i].ToString());
                        }
                    }
                }
                try
                {

                    FileInfo fi = new FileInfo(strUpLoadFileName);
                    if (fi.Exists)             //如果文件存在
                    {

                        clsCommonJsFunc.Alert(this, "服务器已存在同名的文件");

                    }

                    else
                    {
                        //保存文件
                        FileUploadChoose.SaveAs(strUpLoadFileName);
                        ExcelPath = Server.MapPath(clsSysParaEN.UploadWebFolder + "/" + strFileName);

                    }
                }
                catch (Exception a)                   //出现错误
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = a.Message.ToString();
                    DeleteFile(strUploadFileDir + strFileName);//报错，并删除文件
                    return false;
                }
            }
            return true;
        }


        //绑定gridview 数据
        public void GetDataStudent()
        {
            System.Data.DataTable dtable = BindGv_Excel();
            //删除空行空列
            removeEmpty(dtable);
            this.gvStudent.DataSource = dtable;
            this.gvStudent.DataBind();
        }

        //删除文件夹里面所有文件
        private void deletefile(System.IO.DirectoryInfo path)
        {
            foreach (System.IO.DirectoryInfo d in path.GetDirectories())
            {
                deletefile(d);
            }
            foreach (System.IO.FileInfo f in path.GetFiles())
            {
                f.Delete();
            }
        }

        /// <summary>
        /// 删除上传文件
        /// </summary>
        /// <param name="strFileName"></param>
        private void DeleteFile(string strFileName)
        {
            if (strFileName.Trim().Length > 0)
            {
                FileInfo fi = new FileInfo(strFileName);
                if (fi.Exists)                           //如果文件存在，删除文件
                {
                    fi.Delete();
                }
            }
        }

        //删除空的文件夹
        public static void DeleteFolder(string dir)
        {
            if (Directory.Exists(dir)) //如果存在这个文件夹删除之 
            {
                DirectoryInfo dire = new DirectoryInfo(dir);

                if (dire.GetFileSystemInfos().Length > 0)
                {
                    return;
                }
                Directory.Delete(dir, true); //删除已空文件夹         
            }
        }

        //返回ExcelTable
        public System.Data.DataTable BindGv_Excel()
        {
            try
            {
                string strExcelFile = ExcelPath;
                clsExcelAllVersionSQL objxSQL = new clsExcelAllVersionSQL(strExcelFile);
                string strSheetName =objxSQL.GetExcelFirstTableName();

              
                string strSQL = " select * from [" + strSheetName + "] ";
                System.Data.DataTable objDt = objxSQL.funGetDataTable(strSQL);
                return objDt;
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "error", "<script>alert('获取Excel数据出错！" + ex.Message + "')</script>");
                this.lblMessFalse.Text = "获取Excel数据出错！" + ex.Message;
                return null;
            }
        }

        ///// <summary>
        ///// 得到excel信息
        ///// </summary>
        ///// <param name="strExcelFile"></param>
        ///// <returns></returns>
        //public string Get_FirstSheetNameBak(string strExcelFile)
        //{

        //    ///要使用ASP.NET打开EXCEL必须作如下设置：
        //    //1、打开控件面板
        //    //2、管理工具
        //    //3、组件服务
        //    //4、组件服务-->我的电脑-->DCOM配置
        //    //5、选择MicroSoft Excel 应用程序
        //    //6、右击，选属性
        //    //7、在安全面板中，编辑<访问权限>，添加ASP.NET到该应用程序(MicroSoft Excel 应用程序)的用户中
        //    ///
        //    Microsoft.Office.Interop.Excel.Application xApp = null;
        //    Microsoft.Office.Interop.Excel.Workbook xBook = null;

        //    try
        //    {
        //        xApp = new Microsoft.Office.Interop.Excel.Application();
        //        xBook = xApp.Workbooks.Open(strExcelFile,
        //            Missing.Value, Missing.Value, Missing.Value, Missing.Value
        //            , Missing.Value, Missing.Value, Missing.Value, Missing.Value
        //            , Missing.Value, Missing.Value, Missing.Value, Missing.Value,
        //            Missing.Value, Missing.Value);

        //        int i = xBook.Sheets.Count;
        //        return ((Microsoft.Office.Interop.Excel.Worksheet)xBook.Sheets[1]).Name;

        //    }
        //    catch (Exception objException)
        //    {
        //        string EXCEPTION_MSG = "";
        //        LogError(objException, "");
        //        Console.WriteLine(objException.ToString());
        //        throw new Exception(EXCEPTION_MSG, objException);
        //    }
        //    finally
        //    {
        //        if (xBook != null)
        //        {
        //            xBook.Close(Missing.Value, Missing.Value, Missing.Value);
        //            xApp.Quit();
        //            xApp = null;
        //        }
        //    }
        //}

        private void LogError(Exception objException, string strAdditionMsg)
        {
            //'Log the error information to the Application Log
            string strLogMsg;
            string strModuleName = this.GetType().ToString();

            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "\n"
                    + "Source: " + objException.Source + "\n"
                    + "Message: " + objException.Message + "\n"
                    + "Stack Trace:  " + objException.StackTrace + "\n"
                    + "Target Site:  " + objException.TargetSite.ToString() + "\n"
                    + strAdditionMsg;
                //'Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        //删除DataTable里面空行数据
        protected void removeEmpty(System.Data.DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool rowdataisnull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {

                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {

                        rowdataisnull = false;
                    }

                }
                if (rowdataisnull)
                {
                    removelist.Add(dt.Rows[i]);
                }

            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
        }

        //数据导入
        protected void btnImport_Click(object sender, EventArgs e)
        {
            //System.Data.DataTable dtable = BindGv_Excel();
            ////删除空行
            //removeEmpty(dtable);

            //clsPubFun.AddDateExcelTostudentInfo(dtable);
            

            string lblmess = string.Empty;
            System.Data.DataTable dtable = BindGv_Excel();
            if (dtable.Rows.Count > 0)
            {
                //删除空行
                removeEmpty(dtable);
                bool i = clsPubFun.AddDateExcelToQxRoleMenus(dtable, ref lblmess, this);
                if (i == true)
                {
                    clsCommonJsFunc.Alert(this, "操作成功！");
                    this.stuGV.Visible = false;
                    this.gvStuInfo.Visible = true;
                }
                else
                {
                    this.gvStuInfo.Visible = false;
                }
                this.lblMessFalse.Text = lblmess;
                //Response1.Write(this.lblMessFalse.Text);
            }
            else
            {
                clsCommonJsFunc.Alert(this, "当前没有数据可导入，请先上传Excel文件！");
            }

        }

        protected void gvStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //System.Data.DataTable dtable = BindGv_Excel();
            this.gvStudent.PageIndex = e.NewPageIndex;
            GetDataStudent();
        }



        public System.Data.DataTable Getid_Grade()
        {
            //获取某学院所有专业信息
            string strSQL = "select id_Grade, GradeName from vQxPrjMenus_Up ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_id_Grade(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = Getid_Grade();
            objDDL.DataValueField = "id_Grade";
            objDDL.DataTextField = "GradeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///删除记录过程代码for C#
        protected void DeleteQxRoleMenusRecord(long lngid_QxRoleMenus)
        {
            try
            {
                clsQxRoleMenusBL.DelRecord(lngid_QxRoleMenus);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            BindGv_QxRoleMenus();
        }



        public System.Data.DataTable Getid_Major()
        {
            //获取某学院所有专业信息
            string strSQL = "select id_XzMajor, MajorName from XzMajor ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_id_Major(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = Getid_Major();
            objDDL.DataValueField = "id_XzMajor";
            objDDL.DataTextField = "MajorName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


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


        //生成返回链接串的Session属性
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
            if (this.txtStuID_q.Text.Trim() != "")
            {
                strWhereCond += " And MenuId like '%" + this.txtStuID_q.Text.Trim() + "%'";
            }
            if (this.txtStuName_q.Text.Trim() != "")
            {
                strWhereCond += " And StuName like '%" + this.txtStuName_q.Text.Trim() + "%'";
            }
            if (this.ddlid_Major_q.SelectedValue != "" && this.ddlid_Major_q.SelectedValue != "0")
            {
                strWhereCond += " And id_XzMajor='" + this.ddlid_Major_q.SelectedValue + "'";
            }
            if (this.ddlid_Grade_q.SelectedValue != "" && this.ddlid_Grade_q.SelectedValue != "0")
            {
                strWhereCond += " And id_Grade='" + this.ddlid_Grade_q.SelectedValue + "'";
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
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	4、设置GridView的数据源(DataSource)；
            //	5、绑定GridView，即把DataTable的内容显示在DATAGRID中
            //	6、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。

            //	1、组合界面条件串；
            string strWhereCond = CombineQxRoleMenusCondion();
            //	2、根据条件串获取该表满足条件的DataTable；
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
            //	4、设置GRIDView的数据源(DataSource)；
            DataView objDV = objDT.DefaultView;
            objDV.Sort = strSortQxRoleMenusBy; ///注意这一行代码有可能需要注释掉，目前这行仅仅在单独的查询界面中起作用
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
            //	5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
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
            this.gvQxRoleMenus.PageIndex = 0;
            //把表记录的内容显示在DATAGRID中
            BindGv_QxRoleMenus();
        }
        /// <summary>
        /// 函数功能：事件函数，在更改DATAGRID的当前页索引时激发的函数。
        ///			 具体功能是重新显示新页(所单击页索引)的内容。
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
        ///删除当前被选记录
        /// </summary>
        protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValues = clsCommForWebForm.GetAllCheckedItemFromGv(gvQxRoleMenus, "chkCheckRec", "id_QxRoleMenus");
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
                    long lngid_QxRoleMenus = long.Parse(strKeys[0]);
                    clsQxRoleMenusBL.DelRecord(lngid_QxRoleMenus);
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



        protected void gvQxRoleMenus_Sorting(object sender, GridViewSortEventArgs e)
        {
            int intIndex;
            //判断是否是新的排序字段
            intIndex = strSortQxRoleMenusBy.IndexOf(e.SortExpression);
            if (intIndex == -1)
            {
                strSortQxRoleMenusBy = e.SortExpression + " Asc";
                BindGv_QxRoleMenus();
                return;
            }
            //检查原来是升序
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



        protected void gvQxRoleMenus_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            long lngid_QxRoleMenus = long.Parse(gvQxRoleMenus.DataKeys[e.RowIndex]["id_QxRoleMenus"].ToString());
            DeleteQxRoleMenusRecord(lngid_QxRoleMenus);
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
    }
}