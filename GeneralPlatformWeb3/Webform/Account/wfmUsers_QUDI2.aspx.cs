///生成查询，修改，删除，添加记录的控制层代码

///生成控制层的控件变量名列表
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using SpecData;
using GeneralPlatform;
using CommFunc4WebForm;
using com.taishsoft.common;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.datetime;


using GeneralPlatform.BusinessLogicEx;
using System.Collections.Generic;


namespace GeneralPlatform.Webform
{
    /// <summary>
    /// wfmUsers_QUDI 的摘要说明。其中Q代表查询，U代表修改
    /// </summary>
    public partial class wfmUsers_QUDI2 : System.Web.UI.Page
    {
        
        private string qsUserId
        {
            get
            {
                string struserId = Request.QueryString["userid"] ?? "".ToString();
                if ((struserId != null) && (struserId != ""))
                {
                    return struserId;//Request.QueryString["userId"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }


        private string qsPrjId
        {
            get
            {
                string strPrjId = Request.QueryString[conQxProjects.QxPrjId] ?? "".ToString();
                if ((strPrjId != null) && (strPrjId != ""))
                {
                    return strPrjId;//Request.QueryString[conQxProjects.QxPrjId] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }

        ///生成有关的变量定义代码
        private const string ViewId4Potence = "00260203";		//界面编号


        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(qsUserId) == false)
            {
                clsCommonSession.UserId = qsUserId;
                //tvDepartments.Visible = false;
                //lblViewTitle.Visible = false;
                ddlPrjId_q.Visible = false;
                lblPrjId_q.Visible = false;
            }
            if (string.IsNullOrEmpty(qsPrjId) == false)
            {
                getUserPrjId = qsPrjId;
            }

            ErrorInformationBL.AddInformation("wfmUsers_QUDI2", "Page_Load", "进入用户管理页面：UserId=" + clsCommonSession.UserId, clsCommonSession.UserId); 
            


            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

          
            // 在此处放置用户代码以初始化页面
            if (!IsPostBack)	//如果本界面是初次被调用，而不是单击按钮事件所调用
            {
                //if (clsMyConfig.spSchool != "SHNU")
                //{
                //    btnSynCard_State.Visible = false;
                //}
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
                try
                {
                    //UserMan 用户管理
                    //UserMan_All 所有用户管理
                    //User - Disp 用户查看
                    //User - Disp_All 所有用户查看
                    switch (qsFunctionName)
                    {
                        case "UserMan":// 用户管理
                        case "User-Disp":// 用户查看
                            break;
                        case "User-Disp_All":// 所有用户查看
                        case "UserMan_All":// 所有用户管理
                            lblViewTitle.Visible = true;
                            tvDepartments.Visible = true;
                            break;
                        default:
                            string strMsg = string.Format("功能名:[{0}]在界面引导函数中没有处理，请检查！({1})",
                               qsFunctionName,
                               clsStackTrace.GetCurrClassFunction());
                            //lblTitleName.Text = strMsg;
                            clsCommonSession.PageName = "不正确的功能名称：";
                            clsCommonJsFunc.Alert(this, strMsg);
                            return;
                    }
                            //1、为下拉框设置数据源，绑定列表数据
                            wucUsers1.SetDdl_DepartmentId();
                    wucUsers1.SetDdl_UserStateId();
                    //wucUsers1.SetDdl_IdentityID();
                    //clsQxUserIdentityBLEx.BindDdl_IdentityId(ddlIdentityId);
                    clsQxServer4SynchBL.BindDdl_ServerIdCache(ddlServerId);
                    clsQxProjectsBL.BindDdl_QxPrjIdCache(ddlPrjId_q);

                    clsDropDownList.BindDdl_QxUserState(ddlUserStateId);
                    strSortUsersBy = "UserId Asc";

                    vsPotenceFlag = clsQxUserRightsBLEx.ValidPotenceMode4MultiRoles(clsCommonSession.RoleId,
            clsCommonSession.UserId, "0001", clsCommonSession.RoleId, "设置口令");
                    switch (vsPotenceFlag)
                    {
                        case "全局级":
                            break;
                        case "项目级":
                            clsQxUsersEN objUsersEN = clsQxUsersBL.GetObjByUserIdCache(clsCommonSession.UserId);
                            vsDepartmentId = objUsersEN.DepartmentId;
                            tvDepartments.Visible = false;
                            btnAddNewRec4Dg.Visible = false;
                            btnDelete4Dg.Visible = false;
                            btnDataSynToLocalDataBase.Visible = false;
                            //btnSynCard_State.Visible = false;
                            btnExportExcel4Dg.Visible = false;

                            break;
                       

                        default:
                            clsQxDepartmentInfoBLEx.Bindtv_Departments(tvDepartments);

                            //clsCommonJsFunc.Alert(this, "权限不正确，请与管理员联系！");
                            break;
                    }
                    //2、显示无条件的表内容在DATAGRID中
                    BindGv_vQxUsers();
                    //3、设置表控件中字控件的ReadOnly属性，
                    ///   使之只读，因为在修改功能中关键字是不能被修改的。
                    wucUsers1.SetKeyReadOnly(true);
                    if (getUserPrjId != "0001")
                    {
                        //dgUsers.Columns[5].Visible = false;
                        //tvDepartments.Visible = false;
                        //lblViewTitle.Visible = false;
                        ddlPrjId_q.Visible = false;
                        lblPrjId_q.Visible = false;
                    }
                    DispUsersListRegion();
                }
                catch (Exception objException)
                {
                    ErrorInformationBL.AddInformation("wfmUsers_QUDI2", "Page_Load", "objException.Message=" + objException.Message, clsCommonSession.UserId);
                    string strMsg = string.Format("用户管理导入出错：{0}({1})",
                        objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsPubVar.objLog.WriteDebugLog(strMsg);

                }
            }
        }

   

        ///生成权限等级的属性
        private string strPotenceLevel
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
        private string UserId
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
        private string DepartmentId
        {
            get
            {
                string strDepartmentId;
                strDepartmentId = (string)Session["DepartmentId"];
                if (strDepartmentId == null)
                {
                    strDepartmentId = "";
                }
                return strDepartmentId;
            }
            set
            {
                string strDepartmentId = value;
                Session.Add("DepartmentId", strDepartmentId);
            }
        }


        ///private clsQxUsersEN objUser
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


        ///生成专门用于BINDDG中的跳页相关代码


        ///生成错误信息的Session属性
        private string ErrMessage
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
        private string BackLinkStr
        {
            get
            {
                string strBackLinkStr;
                strBackLinkStr = (string)Session["BackLinkStr"];
                if (strBackLinkStr == null)
                {
                    strBackLinkStr = "";
                }
                return strBackLinkStr;
            }
            set
            {
                string strBackLinkStr = value;
                Session.Add("BackLinkStr", strBackLinkStr);
            }
        }

        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        private string CombinevQxUsersCondition()
        {
            //使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            //例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            switch (qsFunctionName)
            {
                case "UserMan":// 用户管理
                case "User-Disp":// 用户查看
                    if (getUserPrjId != "0001")
                    {
                        strWhereCond += string.Format(" And UserId in (Select UserId from {0} where {1}='{2}')", 
                            clsQxPrjUserRelationEN._CurrTabName,
                            conQxPrjUserRelation.QxPrjId,
                            getUserPrjId );
                    }
                    if (this.ddlPrjId_q.SelectedValue != "" && this.ddlPrjId_q.SelectedValue != "0")
                    {
                        strWhereCond += string.Format(" And UserId in (Select UserId from {0} where {1}='{2}')",
                             clsQxPrjUserRelationEN._CurrTabName,
                            conQxPrjUserRelation.QxPrjId,
                            this.ddlPrjId_q.SelectedValue);
                    }
                    break;
                case "UserMan_All":// 所有用户管理
                case "User-Disp_All":// 所有用户查看
                    if (this.ddlPrjId_q.SelectedValue != "" && this.ddlPrjId_q.SelectedValue != "0")
                    {
                        strWhereCond += string.Format(" And UserId in (Select UserId from {0} where {1}='{2}')",
                             clsQxPrjUserRelationEN._CurrTabName,
                            conQxPrjUserRelation.QxPrjId,
                            this.ddlPrjId_q.SelectedValue);
                    }
                    break;
                default:
                    string strMsg = string.Format("功能名:[{0}]在条件组合函数中没有处理，请检查！({1})",
                       qsFunctionName,
                       clsStackTrace.GetCurrClassFunction());
                    //lblTitleName.Text = strMsg;
                    clsCommonSession.PageName = "不正确的功能名称：";
                    //clsCommonJsFunc.Alert(this, strMsg);
                    throw new Exception(strMsg);
            }
            if (string.IsNullOrEmpty(vsDepartmentId) == false)
            {
                strWhereCond += string.Format(" And DepartmentId='{0}'", vsDepartmentId);
            }
            //如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (DepartmentId != "" && DepartmentId != "root")
            {
                strWhereCond += " And DepartmentId='" + DepartmentId + "'";
            }
            
           
            if (this.txtUserId_q.Text.Trim() != "")
            {
                strWhereCond += " And UserId like '%" + this.txtUserId_q.Text.Trim() + "%'";
            }
            if (this.txtUserName_q.Text.Trim() != "")
            {
                strWhereCond += " And UserName like '%" + this.txtUserName_q.Text.Trim() + "%'";
            }
            //if (this.ddlIdentityId.SelectedValue != "" && this.ddlIdentityId.SelectedValue != "0")
            //{
            //    strWhereCond += " And IdentityId='" + this.ddlIdentityId.SelectedValue + "'";
            //}
            if (this.ddlUserStateId.SelectedValue != "" && this.ddlUserStateId.SelectedValue != "0")
            {
                strWhereCond += " And UserStateId='" + this.ddlUserStateId.SelectedValue + "'";
            }
          

            return strWhereCond;
        }
        ///生成绑定DATAGRID的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在DATAGRID中。
        /// </summary>
        private void BindDg_QxUsersBak()
        {
            //操作步骤：(共5步)
            //1、组合界面条件串；
            //2、根据条件串获取该表满足条件的DataTable；
            //3、判别DATAGRID的当前页号是否超出DATAGRID的页数范围
            //4、设置DATAGRID的数据源(DataSource)；
            //5、绑定DATAGRID，即把DataTable的内容显示在DATAGRID中
            ///	6、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            string strMsg = "";
            //1、组合界面条件串；
            string strWhereCond = CombinevQxUsersCondition();
            switch (qsFunctionName)
            {
                case "UserMan":// 用户管理
                case "User-Disp":// 用户查看
                    if (strWhereCond == " 1=1 ")
                    {
                         strMsg = "查询记录太多，请输入合适的条件！";
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
                    }
                    break;
                case "UserMan_All":// 所有用户管理
         
                case "User-Disp_All":// 所有用户查看
                    break;
                default:
                     strMsg = string.Format("功能名:[{0}]在BindGv函数中没有处理，请检查！({1})",
                       qsFunctionName,
                       clsStackTrace.GetCurrClassFunction());
                    //lblTitleName.Text = strMsg;
                    clsCommonSession.PageName = "不正确的功能名称：";
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
            }
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvQxUsersBL.GetDataTable(strWhereCond);
            //clsPubVar.InsertCard_State(objDT);
            //3、差别DATAGRID的当前页号是否超出DATAGRID的页数范围
            ///		3.1 首先计算页数；
            ///		3.2 如果当前页大于页数就为最后一页
         
        }

        /// <summary>
        /// 功能：计算DataGrid的页数
        /// </summary>
        /// <param name="intRecCount">总共的记录数</param>
        /// <param name="intPageSize">每页的记录数</param>
        /// <returns>计算出来的页数</returns>
        private int CalcPages(int intRecCount, int intPageSize)
        {
            int intPages;
            intPages = intRecCount / intPageSize;
            if (intRecCount % intPageSize != 0) intPages++;
            return intPages;
        }

        /// <summary>
        /// 函数功能：事件函数，当单击<查询>按钮时所发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQuery_Click(object sender, System.EventArgs e)
        {

            //把GridView的当前页索引设置为0,即第1页。
            //当单击查询时,首先显示的是表记录内容的第一部分内容。
            wucvQxUsers4Gv1.vsPageIndex = 1;
            //把表记录的内容显示在GridView中
            BindGv_vQxUsers();
        }
       
        /// <summary>
        /// 函数功能：把以该关键字的记录内容显示在界面上，
        ///　　　     在这里是把值传到表控件中
        /// </summary>
        /// <param name="strUserId">表记录的关键字，显示该表关键字的内容</param>
        private void ShowData(string strUserId)
        {
            //操作步骤：
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中

            //1、检查关键字是否为空；
            if (strUserId == "") return;		//如果关键字为空就返回退出
            //2、检查该关键字的记录是否存在，如果不存在就返回不显示；
            if (clsQxUsersBL.IsExist(strUserId) == false)		//检查该关键字的记录是否存在
            {
                string ss = "关键字为：" + strUserId + "的不存在!";
                Response.Write("<script>alert('" + ss + "')</script>");
                return;
            }
            //3、用提供的关键字初始化一个类对象；
            clsQxUsersEN objUsersEN = clsQxUsersBL.GetObjByUserIdCache(strUserId);
         
            Session.Add("objUsersEN", objUsersEN);
            //5、把该对象的所有属性显示在界面上，在这里显示在表控件中
            GetDataFromQxUsersClass(objUsersEN);
        }
        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjUsers">表实体类对象</param>
        private void GetDataFromQxUsersClass(clsQxUsersEN pobjUsers)
        {
            wucUsers1.UserId = pobjUsers.UserId;
            wucUsers1.UserName = pobjUsers.UserName;
            wucUsers1.DepartmentId = pobjUsers.DepartmentId;
            wucUsers1.UserStateId = pobjUsers.UserStateId;
            //wucUsers1.IdentityId = pobjUsers.IdentityId;
            wucUsers1.EffitiveEndDate = pobjUsers.EffitiveEndDate;

            wucUsers1.Password = pobjUsers.Password;
            wucUsers1.Memo = pobjUsers.Memo;
            if (vsPotenceFlag == "项目级")
            {
                wucUsers1.SetAllCtrlFalseExceptPassword();
            }
        }
        /// <summary>
        /// 函数功能：事件函数，当单击<确定修改>时发生的事件函数，
        ///           具体功能为把界面内容同步数据库中，把界面内容保存到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOKUpd_Click(object sender, System.EventArgs e)
        {
            string strCommandText;
            clsQxUsersEN objUsersEN;
            Button btnTemp;
            btnTemp = (Button)sender;
            strCommandText = btnTemp.Text;
            switch (strCommandText)
            {
                case "添加":
                    AddUsersRecord();
                    break;
                case "确认添加":
                    //这是一个单表的插入的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    AddUsersRecordSave();
                    break;
                case "确认修改":
                    //这是一个单表的修改的代码，由于逻辑层太简单，
                    //就把逻辑层合并到控制层,
                    objUsersEN = (clsQxUsersEN)Session["objUsersEN"];
                    if (objUsersEN == null)
                    {
                        ErrorInformationBL.AddInformation("wfmUsers_QUDI2", "btnOKUpd_Click", "objUsersEN为null", "pyf");
                        string strUserId = hidUserId.Value;
                        objUsersEN =  clsQxUsersBL.GetObjByUserIdCache(strUserId);
                    }
                    UpdateUsersRecordSave(objUsersEN);
                    break;
            }
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjUsers">数据传输的目的类对象</param>
        private void PutDataToUsersClass(clsQxUsersEN pobjUsers)
        {
            pobjUsers.UserId = wucUsers1.UserId;
            pobjUsers.UserName = wucUsers1.UserName;
            pobjUsers.DepartmentId = wucUsers1.DepartmentId;
            pobjUsers.UserStateId = wucUsers1.UserStateId;
            //pobjUsers.IdentityId = wucUsers1.IdentityId;
            pobjUsers.EffitiveEndDate = wucUsers1.EffitiveEndDate;

            if (string.IsNullOrEmpty(wucUsers1.Password) == false)
            {
                pobjUsers.Password = wucUsers1.Password;
            }
            pobjUsers.Memo = wucUsers1.Memo;
        }



        ///生成专门用于BINDDG中的跳页相关代码
        //当前记录数
        protected void btnAddNewRec4Dg_Click(object sender, System.EventArgs e)
        {
            AddUsersRecord();
        }

        ///生成专门用于BINDDG中的跳页相关代码
        //当前记录数
        protected void btnExportExcel4Dg_Click(object sender, System.EventArgs e)
        {
            //1、组合界面条件串；
            string strWhereCond = CombinevQxUsersCondition();
            //2、根据条件串获取该表满足条件的DataTable；
            System.Data.DataTable objDT = clsvQxUsersBL.GetDataTable(strWhereCond);
            ArrayList arrCnName = new ArrayList();
            ArrayList arrColName = new ArrayList();
            string strFileName = "Users信息导出.xls";
            string strFolderName;
            string strDownLoadFileName;
            arrColName.Add(convQxUsers.UserId); arrCnName.Add("用户ID");
            arrColName.Add(convQxUsers.UserName); arrCnName.Add("用户名");
            arrColName.Add(convQxUsers.DepartmentId); arrCnName.Add("部门Id");
            arrColName.Add(convQxUsers.DepartmentName); arrCnName.Add("部门名");
            arrColName.Add(convQxUsers.UserStateName); arrCnName.Add("用户状态名");
            arrColName.Add(convQxUsers.Memo); arrCnName.Add("备注");
            strFolderName = clsSysParaEN.TempFileFolder;
            strDownLoadFileName = strFolderName + strFileName;
            GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
            DownLoadFile(strDownLoadFileName);
        }
        /// <summary>
        /// 功能：下载文件。从服务器下载文件到客户端浏览器
        /// </summary>
        /// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
        /// <returns></returns>
        private bool DownLoadFile(string strDownLoadFileName)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name));
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(file.FullName);
            Response.End();
            return true;
        }

        ///生成专门用于BINDDG中的跳页相关代码
        //当前记录数
        protected void btnDelete4Dg_Click(object sender, System.EventArgs e)
        {
            List<string> lstUserId = wucvQxUsers4Gv1.GetAllCheckedKeysFromGv();
            if (lstUserId == null) return;
            lblMsg_List.Text = "";
          
            lblMsg.Text = "";
            foreach (string strUserId in lstUserId)
            {
                if (getUserPrjId != "0001")
                {
                    clsQxUsersBLEx.DelRecordEx(strUserId, getUserPrjId);
                }
                else
                {
                    clsQxUsersBLEx.DelRecordEx(strUserId);
                }
            }
            BindGv_vQxUsers();
        }

        ///生成专门用于BINDDG中的跳页相关代码
        //当前记录数
        protected void btnUpdate4Dg_Click(object sender, System.EventArgs e)
        {
            string strUserId = wucvQxUsers4Gv1.GetFirstCheckedKeyFromGv();
            if (string.IsNullOrEmpty(strUserId) == true) return;
            hidUserId.Value = strUserId;
            if (strUserId == null || strUserId.Trim().Length == 0)
            {
                lblMsg.Text = "没有选择记录，请选择一个有效的表记录!";
                return;
            }
            lblMsg.Text = "";
            //1、显示该关键字记录的内容在界面上；
            ///当前所选记录
            UpdateQxUsersRecord(strUserId);
        }
     
       

        private string strSortUsersBy
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

     

        ///生成的插入记录准备过程代码for C#
        private void AddUsersRecord()
        {
            wucUsers1.SetKeyReadOnly(false);
            btnOKUpd.Text = "确认添加";
            //wucUsers1.UserId = clsCommForWebForm.G1etMaxStrId("Users","UserId", 18, "");
            if (DepartmentId != "" && DepartmentId != "root")
            {
                wucUsers1.DepartmentId = DepartmentId;
            }
            wucUsers1.UserStateId = "01";
            DispEditUsersRegion();
        }
        ///插入记录存盘过程代码for C#
        private void AddUsersRecordSave()
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
            clsQxUsersEN objUsersEN;
            //1、检查控件中输入数据类型是否正确
            if (!wucUsers1.IsValid(ref strResult))
            {
                lblMsg.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、定义对象并初始化对象
            //clsQxUsersEN objUsersEN;	//定义对象
            objUsersEN = new clsQxUsersEN(wucUsers1.UserId);	//初始化新对象
            //3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsQxUsersBL.IsExist( objUsersEN.UserId) == true)	//判断是否有相同的关键字
            {
                strMsg = "关键字字段已有相同的值";
                Response.Write("<script>alert('" + strMsg + "')</script>");
                return;
            }
            //4、把值从界面层传到逻辑层或数据实体层
            PutDataToUsersClass(objUsersEN);		//把界面的值传到
            //5、检查传进去的对象属性是否合法
            try
            {
                clsQxUsersBL.CheckPropertyNew(objUsersEN);
                //6、把数据实体层的数据存贮到数据库中
                clsQxUsersBL.AddNewRecordBySql2(objUsersEN);
                if (wucUsers1.IsAsDefaultPrjUser == true)
                {
                    string strDefaPrjId = getUserPrjId;// clsQxProjectsBLEx.GetDefaultPrj();
                    if (string.IsNullOrEmpty(strDefaPrjId) == false)
                    {
                        clsQxPrjUserRelationBLEx.AddRecord(strDefaPrjId, objUsersEN.UserId);
                    }
                }
            }
            catch (Exception objException)
            {
                strMsg = "添加记录不成功!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "添加记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsg.Text = "添加记录成功!";
            //7、把新添的记录内容显示在DATAGRID中
            wucUsers1.Clear();		//清空控件中内容
            ///恢复<确认添加>变成<添加>
            btnOKUpd.Text = "添加";
            BindGv_vQxUsers();
            DispUsersListRegion();
        }
   
        ///生成修改记录准备过程代码 for C#
        private void UpdateQxUsersRecord(string strUserId)
        {
            //操作步骤：（总共2步）
            //1、显示该关键字记录的内容在界面上；
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；

            //1、显示该关键字记录的内容在界面上；
            ShowData(strUserId);
            //2、清空提示信息的内容,同时使<确定修改>按钮可用；
            btnOKUpd.Enabled = true;
            wucUsers1.SetKeyReadOnly(true);
            btnOKUpd.Text = "确认修改";
            lblMsg.Text = "";
            DispEditUsersRegion();
        }
        ///修改存盘准备过程代码 for C#
        private void UpdateUsersRecordSave(clsQxUsersEN objUsersEN)
        {
            //操作步骤：
            //1、检查控件中输入数据类型是否正确
            //2、把值从界面层传到逻辑层或数据实体层
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            //5、把修改后的内容显示在DATAGRID中
            string strMsg;	//专门用于传递信息的变量
            string strResult = " ";	//用于传递在检验对象属性时结果值的变量
            //1、检查控件中输入数据类型是否正确
            if (!wucUsers1.IsValid(ref strResult))
            {
                lblMsg.Text = "控件中输入数据类型不正确请检查!";
                return;
            }
            //2、把值从界面层传到逻辑层或数据实体层
            PutDataToUsersClass(objUsersEN);		//把界面的值传到
            //3、检查传进去的对象属性是否合法
            try
            {
                clsQxUsersBL.CheckPropertyNew(objUsersEN);
                //6、把数据实体层的数据存贮到数据库中
                 clsQxUsersBL.UpdateBySql2(objUsersEN);
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                Response.Write("<script>alert('" + strMsg + "')</script>");
                lblMsg.Text = strMsg;
                return;
            }
            strMsg = "修改记录成功!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            lblMsg.Text = "修改记录成功!";
            wucUsers1.Clear();//添空控件中的内容
            ///恢复<确认修改>变成<添加>
            btnOKUpd.Text = "添加";
            //5、把修改后的内容显示在DATAGRID中
            BindGv_vQxUsers();
            DispUsersListRegion();
        }

        ///删除记录过程代码for C#
        private void DeleteQxUsersRecord(string strUserId)
        {
            clsQxUsersBL.DelRecord(strUserId);
            BindGv_vQxUsers();
        }
        private void DispEditUsersRegion()
        {
            //tabUsersDataGrid.Visible = false;
            tabEditUsersRegion.Visible = true;
        }
        private void DispUsersListRegion()
        {
            //tabUsersDataGrid.Visible = true;
            tabEditUsersRegion.Visible = false;
        }
        ///生成专门用于BINDDG中的跳页相关代码
        //当前记录数
        protected void lbDispUsersList_Click(object sender, System.EventArgs e)
        {
            DispUsersListRegion();
        }

        protected void tvDepartments_SelectedNodeChanged(object sender, EventArgs e)
        {
            string strDepartmentId = clsCommForWebForm.getNodeID_S(tvDepartments.SelectedNode);
            DepartmentId = strDepartmentId;
            if (strDepartmentId == "root")
            {
                lblUsersList.Text = clsSysParaEN.strCompanyName + "用户列表";
            }
            else
            {
                string strDepartmentName = clsQxDepartmentInfoBL.GetObjByDepartmentIdCache(strDepartmentId).DepartmentName;
                lblUsersList.Text = strDepartmentName + ":用户信息列表";
            }
            BindGv_vQxUsers();
            DispUsersListRegion();
        }

        protected void btnSynDataFromPlatform_Click(object sender, EventArgs e)
        {
            //ArrayList arrUserObjList = clsPubVar.objMenuAndPotence.Get_QxUserObjListOfPrj(clsSysParaEN.CurrPrjId);
            //clsQxUsersEN objUsersEN = new clsQxUsersEN();

            //foreach (TzGeneralPlatformDll2.clsQxUsersEN objUsersFromPlat in arrUserObjList)
            //{
            //    objUsersEN.UserId = objUsersFromPlat.UserId;


            //    objUsersEN.UserName = objUsersFromPlat.UserName;



            //    objUsersEN.UserStateId = objUsersFromPlat.UserStateId;
            //    objUsersEN.DepartmentId = objUsersFromPlat.DepartmentId;
            //    objUsersEN.Memo = "从平台复制";
            //    objUsersEN.Password = objUsersFromPlat.Password;
            //    if (clsQxUsersBL.IsExist(objUsersEN.UserId) == false)
            //    {
            //        clsQxUsersBL.AddNewRecordBySql2(objUsersEN);

            //    }
            //    else
            //    {
            //         clsQxUsersBL.UpdateBySql2(objUsersEN);
            //    }
     

            //}
        }
        protected void btnDataSynToLocalDataBase_Click(object sender, EventArgs e)
        {
            string strCurrPrjId = "";
            if (getUserPrjId != "0001")
            {
                strCurrPrjId = getUserPrjId;
            }
            else
            {
                strCurrPrjId = clsQxProjectsBLEx.GetDefaultPrj();
            }
            clsQxUsersBLEx.SynDataToClientDatabase(strCurrPrjId);
        }

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
        protected void btnSynCard_State_Click(object sender, EventArgs e)
        {
            try
            {
                clsQxUsersBLEx.SynCard_State();
            }
            catch (Exception objException)
            {
                ErrMessage = "同步卡状态不成功!" + objException.Message;
                BackLinkStr = Page.Request.Url.AbsolutePath;
                Response.Redirect(clsSysParaEN.ErrorPage);
            }
        }


        /// <summary>
        /// 当前操作的导出表名称
        /// </summary>
        protected string vsPotenceFlag
        {
            get
            {
                string sPotenceFlag;
                sPotenceFlag = (string)ViewState["PotenceFlag"];
                if (sPotenceFlag == null)
                {
                    sPotenceFlag = "";
                }
                return sPotenceFlag;
            }
            set
            {
                string sPotenceFlag = value;
                ViewState.Add("PotenceFlag", sPotenceFlag);
            }
        }

        protected string vsDepartmentId
        {
            get
            {
                string sDepartmentId;
                sDepartmentId = (string)ViewState["DepartmentId"];
                if (sDepartmentId == null)
                {
                    sDepartmentId = "";
                }
                return sDepartmentId;
            }
            set
            {
                string sDepartmentId = value;
                ViewState.Add("DepartmentId", sDepartmentId);
            }
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

        protected void btnSynchTo_Click(object sender, EventArgs e)
        {

            List<string> lstUserId = wucvQxUsers4Gv1.GetAllCheckedKeysFromGv();
            if (lstUserId == null) return;
            lblMsg_List.Text = "";

            string strMsg = "";
            if (ddlServerId.SelectedIndex<=0)
            {
                strMsg = "请输入正确的目标服务器！";
                ddlServerId.Focus();
                clsCommonJsFunc.Alert(this, strMsg);
                return;
            }
            string strServerId = ddlServerId.SelectedValue;
           

            try
            {
                int intCount = clsQxUsersBLEx.SynDataToOtherServer(lstUserId, strServerId);
                strMsg = string.Format("共同步了:{0}条记录！", intCount);
                BindGv_vQxUsers();
                clsCommonJsFunc.Alert(this, strMsg);
            }
            catch (Exception objException)
            {
                strMsg = "同步用户不成功!" + objException.Message;
                clsCommonJsFunc.Alert(this, strMsg);
                lblMsg.Text = strMsg;
                return;
            }
        }



        /// <summary>
        /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在GridView中。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
        /// </summary>
        protected void BindGv_vQxUsers()
        {
            //操作步骤:(共5步)
            //	1、组合界面条件串；
            //	2、调用控件中的绑定GridView函数;
            //	3、设置Gv控件的某些列不可见;

            try
            {
                //	1、组合界面条件串；
                string strWhereCond = CombinevQxUsersCondition();
                //	2、调用控件中的绑定GridView函数；
                wucvQxUsers4Gv1.BindGv_QxUsers(strWhereCond);
                //	3、设置Gv控件的某些列不可见；
                wucvQxUsers4Gv1.SetGvVisibility(convQxUsers.Password, false);
                //wucvQxUsers4Gv1.SetGvVisibility(convQxUsers.UpdDate, false);
                //wucvQxUsers4Gv1.SetGvVisibility(convQxUsers.UpdUser, false);
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
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        protected string CombinevQxUsersConditionBak()
        {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            string strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            //clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
            //try
            //{
            //    if (this.txtUserId_q.Text.Trim() != "")
            //    {
            //        objvQxUsersEN.UserId = this.txtUserId_q.Text.Trim();
            //        strWhereCond += string.Format(" And {0} like '%{1}%'", convQxUsers.UserId, this.txtUserId_q.Text.Trim());
            //    }
            //    if (this.txtUserName_q.Text.Trim() != "")
            //    {
            //        objvQxUsersEN.UserName = this.txtUserName_q.Text.Trim();
            //        strWhereCond += string.Format(" And {0} like '%{1}%'", convQxUsers.UserName, this.txtUserName_q.Text.Trim());
            //    }
            //    if (this.ddlDepartmentId_q.SelectedValue != "" && this.ddlDepartmentId_q.SelectedValue != "0")
            //    {
            //        objvQxUsersEN.DepartmentId = this.ddlDepartmentId_q.SelectedValue;
            //        strWhereCond += string.Format(" And {0} = '{1}'", convQxUsers.DepartmentId, this.ddlDepartmentId_q.SelectedValue);
            //    }
            //    if (this.ddlUserStateId_q.SelectedValue != "" && this.ddlUserStateId_q.SelectedValue != "0")
            //    {
            //        objvQxUsersEN.UserStateId = this.ddlUserStateId_q.SelectedValue;
            //        strWhereCond += string.Format(" And {0} = '{1}'", convQxUsers.UserStateId, this.ddlUserStateId_q.SelectedValue);
            //    }
            //    clsvQxUsersBL.CheckProperty4Condition(objvQxUsersEN);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!" + objException.Message);
            //    throw new Exception(strMsg);
            //}
            return strWhereCond;
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQxUsers4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
        {
            string strUserId = e.KeyId;
            DeleteQxUsersRecord(strUserId);
        }

        ///
        /// <summary>
        /// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
        /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
        /// </summary>
        /// <param name = "sender"></param>
        /// <param name = "e"></param>
        protected void wucvQxUsers4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
        {
            string strUserId = e.KeyId;
            UpdateQxUsersRecord(strUserId);
        }
    }
}
