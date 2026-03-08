///----------------------
///生成代码版本：8.2.0.0
///生成日期：2008/11/16
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：08.11.15.2
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
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using System.Collections.Generic;
namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmUserRoleRelation2_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmUserRoleRelation2_QUDI : System.Web.UI.Page
    {

        ///生成有关的变量定义代码
        protected const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	///如果本界面是初次被调用，而不是单击按钮事件所调用
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

                ///1、为下拉框设置数据源，绑定列表数据
                wucUserRoleRelation21.SetDdl_PrjId();
                clsProjectsBL.BindDdl_PrjId(ddlPrjId_q);
                strSortUserRoleRelation2By = "UserId Asc";
                ///2、显示无条件的表内容在DATAGRID中
                ///
                string strWhereCond = wucUserRoleRelation21.CombineUserRoleRelation2Condion();
                wucUserRoleRelation2GV1.WhereCond = strWhereCond;
                wucUserRoleRelation2GV1.BindGv_UserRoleRelation2();
                ///3、设置表控件中字控件的ReadOnly属性，
                ///   使之只读，因为在修改功能中关键字是不能被修改的。
                wucUserRoleRelation21.SetKeyReadOnly(true);
                DispUserRoleRelation2ListRegion();
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
            this.wucUserRoleRelation2GV1.PageIndex = 0;
            string strWhereCond = wucUserRoleRelation21.CombineUserRoleRelation2Condion();
            this.wucUserRoleRelation2GV1.WhereCond = strWhereCond;
            ///把表记录的内容显示在DATAGRID中
            this.wucUserRoleRelation2GV1.BindGv_UserRoleRelation2();
        }
       
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strRoleId">表记录的关键字，显示该表关键字的内容</param>
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsUserRoleRelation2 objUserRoleRelation2;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddUserRoleRelation2Record();
                    break;
                case "确认添加":
                    ///这是一个单表的插入的代码，由于逻辑层太简单，
                    ///就把逻辑层合并到控制层,
                    AddUserRoleRelation2RecordSave();
                    break;
                case "确认修改":
                    ///这是一个单表的修改的代码，由于逻辑层太简单，
                    ///就把逻辑层合并到控制层,
                    objUserRoleRelation2 = (clsUserRoleRelation2)Session["objUserRoleRelation2"];
                    UpdateUserRoleRelation2RecordSave(objUserRoleRelation2);
                    break;
            }
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
        {
            wucUserRoleRelation21.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            lblMsg_Edit.Text = "";
            //wucUserRoleRelation21.RoleId = clsCommForWebForm.GetMaxStrId("UserRoleRelation2","RoleId", 8, "");
            DispEditUserRoleRelation2Region();
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
            List<string> lstKeyValues = wucUserRoleRelation2GV1.GetAllCheckedItemFromGv();
            if (lstKeyValues.Count  == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            try
            {
                foreach (string strKeyValue in lstKeyValues)
                {
                    string [] strKeys = strKeyValue.Split(',');
                    string strUserId = strKeys[0];
                    string strRoleId = strKeys[1];
                    clsUserRoleRelation2BL.DelRecord(strUserId, strRoleId);
                }
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            wucUserRoleRelation2GV1.BindGv_UserRoleRelation2();
        }

        ///生成专门用于BINDgv中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
        {
            List<string> lstKeyValue = wucUserRoleRelation2GV1.GetFirstCheckedItemFromGv();
            if (lstKeyValue.Count == 0)
            {
                lblMsg_List.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg_List.Text = "";
            //1、显示该关键字的数据让用户修改该关键字记录；
            string strUserId = lstKeyValue[0];
            string strRoleId = lstKeyValue[1];
            UpdateUserRoleRelation2Record(strUserId, strRoleId);
        }
        ///
        protected void btnCancelUserRoleRelation2Edit_Click(object sender, EventArgs e)
        {
            DispUserRoleRelation2ListRegion();
        }

    }
    public partial class wfmUserRoleRelation2_QUDI : System.Web.UI.Page
    {
        protected void ShowData(string strUserId, string strRoleId)
        {
            ///操作步骤：
            ///1、检查关键字是否为空；
            ///2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            ///3、用提供的关键字初始化一个类对象；
            ///4、获取类对象的所有属性；
            ///5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            ///1、检查关键字是否为空；
            if (strRoleId == "") return;		//如果关键字为空就返回退出
            ///2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsUserRoleRelation2BL.IsExist(strUserId, strRoleId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strRoleId + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            ///3、用提供的关键字初始化一个类对象；
            clsUserRoleRelation2 objUserRoleRelation2 = new clsUserRoleRelation2(strUserId, strRoleId);
            ///4、获取类对象的所有属性；
            try
            {
                clsUserRoleRelation2BL.GetUserRoleRelation2(ref objUserRoleRelation2);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            Session.Add("objUserRoleRelation2", objUserRoleRelation2);
            ///5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            wucUserRoleRelation21.GetDataFromUserRoleRelation2Class(objUserRoleRelation2);
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
        ///生成从界面层到逻辑层的数据传输函数代码
        public System.Data.DataTable GetPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjId, PrjName from Projects ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_PrjId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPrjId();
            objDDL.DataValueField = "PrjId";
            objDDL.DataTextField = "PrjName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成的插入记录准备过程代码for C#
        protected void AddUserRoleRelation2Record()
        {
            wucUserRoleRelation21.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            btnCancelUserRoleRelation2Edit.Text = "取消添加";
            //wucUserRoleRelation21.RoleId = clsCommForWebForm.GetMaxStrId("UserRoleRelation2","RoleId", 8, "");
        }
        ///插入记录存盘过程代码for C#
        protected bool AddUserRoleRelation2RecordSave()
        {
            ///操作步骤：
            ///1、检查控件中输入数据类型是否正确
            ///2、定义对象并初始化对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            ///3.2、检查唯一性
            ///4、把值从界面层传到逻辑层或数据实体层
            ///5、检查传进去的对象属性是否合法
            ///6、把数据实体层的数据存贮到数据库中
            ///7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsUserRoleRelation2 objUserRoleRelation2;
            ///1、检查控件中输入数据类型是否正确
            if (!wucUserRoleRelation21.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            ///2、定义对象并初始化对象
            //clsUserRoleRelation2 objUserRoleRelation2;	//定义对象
            objUserRoleRelation2 = new clsUserRoleRelation2(wucUserRoleRelation21.UserId, wucUserRoleRelation21.RoleId);	//初始化新对象
            ///3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsUserRoleRelation2BL.IsExist(objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            ///4、把值从界面层传到逻辑层或数据实体层
            wucUserRoleRelation21.PutDataToUserRoleRelation2Class(ref objUserRoleRelation2);		//把界面的值传到
            ///5、检查传进去的对象属性是否合法
            try
            {
                clsUserRoleRelation2BL.CheckPropertyNew(objUserRoleRelation2);
                ///6、把数据实体层的数据存贮到数据库中
                clsUserRoleRelation2BL.AddNewRecordBySql2(objUserRoleRelation2);
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
            ///7、把新添的记录内容显示在DATAGRID中
            wucUserRoleRelation2GV1. BindGv_UserRoleRelation2();
            DispUserRoleRelation2ListRegion();
            wucUserRoleRelation21.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserRoleRelation2Edit.Text = "取消编辑";
            return true;
        }
        ///插入记录存盘过程代码for C#
        protected bool AddUserRoleRelation2RecordSaveV5()
        {
            ///操作步骤：
            ///1、检查控件中输入数据类型是否正确
            ///2、定义对象并初始化对象
            ///3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            ///4、把值从界面层传到逻辑层或数据实体层
            ///5、检查传进去的对象属性是否合法
            ///6、把数据实体层的数据存贮到数据库中
            ///7、把新添的记录内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            clsUserRoleRelation2 objUserRoleRelation2;
            ///1、检查控件中输入数据类型是否正确
            if (!wucUserRoleRelation21.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            ///2、定义对象并初始化对象
            //clsUserRoleRelation2 objUserRoleRelation2;	//定义对象
            objUserRoleRelation2 = new clsUserRoleRelation2(wucUserRoleRelation21.UserId, wucUserRoleRelation21.RoleId);	//初始化新对象
            ///3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsUserRoleRelation2BL.IsExist(objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId))	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return false;
            }
            ///4、把值从界面层传到逻辑层或数据实体层
            wucUserRoleRelation21.PutDataToUserRoleRelation2Class(ref objUserRoleRelation2);		//把界面的值传到
            ///5、检查传进去的对象属性是否合法
            try
            {
                clsUserRoleRelation2BL.CheckPropertyNew(objUserRoleRelation2);
                ///6、把数据实体层的数据存贮到数据库中
                clsUserRoleRelation2BL.AddNewRecordBySql2(objUserRoleRelation2);
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
            ///7、把新添的记录内容显示在DATAGRID中
            wucUserRoleRelation2GV1.BindGv_UserRoleRelation2();
            DispUserRoleRelation2ListRegion();
            wucUserRoleRelation21.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserRoleRelation2Edit.Text = "取消编辑";
            return true;
        }
        ///生成修改记录准备过程代码 for C#
        protected void UpdateUserRoleRelation2Record(string strUserId, string strRoleId)
        {
            ///操作步骤：（总共2步）
            ///1、显示该关键字记录的内容在界面上；
            ///2、清空提示信息的内容,同时使<确定修改>按钮可用；

            ///1、显示该关键字记录的内容在界面上；
            ShowData(strUserId, strRoleId);
            ///2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucUserRoleRelation21.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            btnCancelUserRoleRelation2Edit.Text = "取消修改";
            lblMsg_Edit.Text = "";
            DispEditUserRoleRelation2Region();
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateUserRoleRelation2RecordSave(clsUserRoleRelation2 objUserRoleRelation2)
        {
            ///操作步骤：
            ///1、检查控件中输入数据类型是否正确
            ///2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            ///3.2、检查唯一性
            ///4、把数据实体层的数据存贮到数据库中
            ///5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            ///1、检查控件中输入数据类型是否正确
            if (!wucUserRoleRelation21.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            ///2、把值从界面层传到逻辑层或数据实体层
         wucUserRoleRelation21.   PutDataToUserRoleRelation2Class(ref objUserRoleRelation2);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsUserRoleRelation2BL.CheckPropertyNew(objUserRoleRelation2);
                ///4、把数据实体层的数据存贮到数据库中
                clsUserRoleRelation2BL.UpdateBySql2(objUserRoleRelation2);
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
            ///5、把修改后的内容显示在DATAGRID中
            wucUserRoleRelation2GV1.BindGv_UserRoleRelation2();
            DispUserRoleRelation2ListRegion();
            wucUserRoleRelation21.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserRoleRelation2Edit.Text = "取消编辑";
            return true;
        }
        ///修改存盘准备过程代码 for C#
        protected bool UpdateUserRoleRelation2RecordSaveV5(clsUserRoleRelation2 objUserRoleRelation2)
        {
            ///操作步骤：
            ///1、检查控件中输入数据类型是否正确
            ///2、把值从界面层传到逻辑层或数据实体层
            ///3.1、检查传进去的对象属性是否合法
            ///4、把数据实体层的数据存贮到数据库中
            ///5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            ///1、检查控件中输入数据类型是否正确
            if (!wucUserRoleRelation21.IsValid(ref strResult))
            {
                lblMsg_Edit.Text = "控件中输入数据类型不正确请检查!";
                return false;
            }
            ///2、把值从界面层传到逻辑层或数据实体层
            wucUserRoleRelation21.PutDataToUserRoleRelation2Class(ref objUserRoleRelation2);		//把界面的值传到
            ///3.1、检查传进去的对象属性是否合法
            try
            {
                clsUserRoleRelation2BL.CheckPropertyNew(objUserRoleRelation2);
                ///4、把数据实体层的数据存贮到数据库中
                clsUserRoleRelation2BL.UpdateBySql2(objUserRoleRelation2);
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
            ///5、把修改后的内容显示在DATAGRID中
            wucUserRoleRelation2GV1.BindGv_UserRoleRelation2();
            DispUserRoleRelation2ListRegion();
            wucUserRoleRelation21.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            btnCancelUserRoleRelation2Edit.Text = "取消编辑";
            return true;
        }
        ///删除记录过程代码for C#
        protected void DeleteUserRoleRelation2Record(string strUserId, string strRoleId)
        {
            try
            {
                clsUserRoleRelation2BL.DelRecord(strUserId, strRoleId);
            }
            catch (Exception objException)
            {
                ErrMessage = objException.Message;
                BackErrPageLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
            wucUserRoleRelation2GV1.BindGv_UserRoleRelation2();
        }

        ///生成专门用于导出Excel的相关代码
        private void ExportExcel()
        {
            ///	1、组合界面条件串；
            string strWhereCond = wucUserRoleRelation21.CombineUserRoleRelation2Condion();
            ///	2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = null;
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            string strFileName = "UserRoleRelation2信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add("UserId"); arrCnName.Add("用户ID");
            arrColName.Add("RoleId"); arrCnName.Add("角色Id");
            arrColName.Add("PrjId"); arrCnName.Add("项目编号");
            arrColName.Add("Memo"); arrCnName.Add("备注");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            try
            {
                ///	2、根据条件串获取该表满足条件的DataTable；
                objDT = clsUserRoleRelation2BL.GetDataTable_UserRoleRelation2(strWhereCond);
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
        private void DispEditUserRoleRelation2Region()
        {
            tabUserRoleRelation2GridView.Visible = false;
            tabEditUserRoleRelation2Region.Visible = true;
        }
        private void DispUserRoleRelation2ListRegion()
        {
            tabUserRoleRelation2GridView.Visible = true;
            tabEditUserRoleRelation2Region.Visible = false;
        }
    }
}