using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;

using System.Collections;
using System.Text;
using CommFunc4WebForm;
using GeneralPlatform.BusinessLogic;
using System.Diagnostics;
using System.IO;
using com.taishsoft.common;
using System.Data;
using GeneralPlatform;
using GeneralPlatformWeb;

using GeneralPlatform.Entity;
using com.taishsoft.datetime;
using System.Web.Services;
using com.taishsoft.syspara;

using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
    public class clsPubFun
    {
        /// <summary>
        /// 处理错误
        /// </summary>
        /// <param name="thisPage"></param>
        /// <param name="strParentPage"></param>
        /// <returns></returns>
        public static bool AccessError(Page thisPage, string strParentPage)
        {
            clsCommonSession.ParentPage = strParentPage;// "wfmPrjTab_QUDI3.aspx";
            thisPage.Response.Redirect("../error.aspx?ParentPage=" + strParentPage);
            return true;
        }
        public static bool Log4Debug(WebService myPage, string strFunctionName, Dictionary<string, string> dictParamNameValue)
        {
            if (clsDebugBase_Sql.IsDebug == false) return true;
            string strPageName = myPage.GetType().FullName;
            StringBuilder sbParam = new StringBuilder();
            foreach (string strKey in dictParamNameValue.Keys)
            {
                sbParam.AppendFormat("[{0}]:=[{1}];", strKey, dictParamNameValue[strKey]);
            }
            string strMsg = string.Format("WS:[{0}]-[{1}]-[{2}].",
                    strPageName,
                    strFunctionName, sbParam.ToString());
            clsPubVar.objLog.WriteDebugLog(strMsg);
            ErrorInformationBL.AddInformation(strPageName, strFunctionName, strMsg, "WebService");
            return true;
        }

        public static bool LogErrMsg(Page myPage, string strMsg)
        {
            StackTrace st = new StackTrace(new StackFrame(true));
            Console.WriteLine(" Stack trace for current level: {0}", st.ToString());
            StackFrame sf = st.GetFrame(0);
            Console.WriteLine(" File: {0}", sf.GetFileName());
            Console.WriteLine(" Method: {0}", sf.GetMethod().Name);
            Console.WriteLine(" Line Number: {0}", sf.GetFileLineNumber());
            Console.WriteLine(" Column Number: {0}", sf.GetFileColumnNumber());
            string strIpUser = clsCommonSession.UserId + " at " + clsCommForWebForm.GetClientIp();
            ErrorInformationBL.AddInformation(myPage.Request.Url.AbsolutePath, sf.GetMethod().Name, strMsg, strIpUser);
            return true;
        }

        /// <summary>
        /// 获取当前WEB项目的虚拟根目录
        /// </summary>
        /// <returns></returns>
        public static string GetVirtualRoot()
        {
            string strApp1 = System.Web.HttpContext.Current.Request.ApplicationPath;
            return strApp1;
        }
        /// <summary>
        /// 获取用户登陆IP
        /// </summary>
        /// <returns>返回用户IP</returns>
        public static string GetIp()
        {
            string user_IP;
            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
            {
                user_IP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                user_IP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return user_IP;
        }
        public static bool IsLocal()
        {
            bool bolIsLocal = System.Web.HttpContext.Current.Request.IsLocal;
            return bolIsLocal;
        }
        /// <summary>
        /// 设置可视性
        /// </summary>
        public static void SetDgVisibility(DataGrid objDG)
        {
            foreach (DataGridColumn objDGColumn in objDG.Columns)
            {
                string strColumnName = objDGColumn.HeaderText;
                bool bolIsVisible = clsvSetFieldVisibilityBLEx.IsVisible(clsMyConfig.spSchool, strColumnName);
                if (bolIsVisible == false)
                {
                    objDGColumn.Visible = false;
                }
                //if (strColumnName == "卡号" && clsMyConfig.School == "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }
        /// <summary>
        /// 设置GridView可视性
        /// </summary>
        public static void SetGvVisibility(GridView objGV, string strColumnName, bool bolIsVisible)
        {
            int intColumnNum = objGV.Columns.Count;
            for (int i = 0; i < intColumnNum; i++)
            {
                string strColumnNameIn = objGV.Columns[i].HeaderText;
                if (strColumnName.Equals(strColumnNameIn, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    objGV.Columns[i].Visible = bolIsVisible;
                    return;
                }

            }
        }
        /// <summary>
        /// 根据界面功能名称－设置可视性,
        /// </summary>
        public static void SetDgVisibilityByViewName(DataGrid objDG, string strViewName)
        {
            foreach (DataGridColumn objDGColumn in objDG.Columns)
            {
                string strColumnName = objDGColumn.HeaderText;
                bool bolIsVisible = clsvSetFieldVisibilityBLEx.IsVisible(clsMyConfig.spSchool, strViewName, strColumnName);
                if (bolIsVisible == false)
                {
                    objDGColumn.Visible = false;
                }
                //if (strColumnName == "卡号" && clsMyConfig.School == "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }

        public static void SetDgVisibility(DataGrid objDG, string strColumnName, bool bolIsVisible)
        {
            //int intColumnNum = objGV.Columns.Count;
            //for (int i = 0; i < intColumnNum; i++)
            //{
            //    string strColumnNameIn = objGV.Columns[i].HeaderText;
            //    if (strColumnName.Equals(strColumnNameIn, StringComparison.CurrentCultureIgnoreCase) == true)
            //    {
            //        objGV.Columns[i].Visible = bolIsVisible;
            //        return;
            //    }

            //}
            foreach (DataGridColumn objDGColumn in objDG.Columns)
            {
                string strColumnName_In = objDGColumn.HeaderText;
                if (strColumnName.Equals(strColumnName_In, StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    objDGColumn.Visible = bolIsVisible;
                }             
            }
        }

        public static void SetGvVisibilityByViewName(GridView objGV, string strViewName)
        {
            foreach (DataControlField objDGColumn in objGV.Columns)
            {
                string strColTypeName = objDGColumn.GetType().ToString();
                if (strColTypeName.IndexOf("BoundField") == -1) continue;
                BoundField objBoundField = (BoundField)objDGColumn;


                string strColumnName = objBoundField.DataField;
                bool bolIsVisible = clsvSetFieldVisibilityBLEx.IsVisible(clsMyConfig.spSchool, strViewName, strColumnName);
                if (bolIsVisible == false)
                {
                    objDGColumn.Visible = false;
                }
                //if (strColumnName == "卡号" && clsMyConfig.School == "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }

        /// <summary>
        /// 插入序号
        /// </summary>
        public static void InsertOrderNum(DataTable objDT, string strColumnName)
        {

            objDT.Columns.Add(strColumnName);
            int intOrderNum = 1;
            foreach (DataRow objDTRow in objDT.Rows)
            {
                objDTRow[strColumnName] = intOrderNum.ToString();
                intOrderNum++;
            }
        }
        //导入到学生表的信息


        /// <summary>
        /// 导入Excel文件到工程菜单表中
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="lblMess"></param>
        /// <param name="myPage"></param>
        /// <returns></returns>
        public static bool AddDateExcelToQxPrjMenus(DataTable dt, ref string lblMess, Page myPage)
        {
            clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
            string strUpMenuName = "";
            if (dt.Columns.Contains("菜单Id"))
            {

                foreach (DataRow row in dt.Rows)
                {
                    objQxPrjMenusEN.MenuId = row["菜单Id"].ToString();
                    objQxPrjMenusEN.qsParameters = row["qs参数"].ToString();
                    objQxPrjMenusEN.MenuName = row["菜单名"].ToString();
                    objQxPrjMenusEN.LinkFile = row["链接文件"].ToString();
                    objQxPrjMenusEN.ImgFile = row["图像文件"].ToString();
                    objQxPrjMenusEN.OrderNum = int.Parse(row["排序号"].ToString());
                    objQxPrjMenusEN.IsLeafNode = bool.Parse(row["是否叶子"].ToString());
                    objQxPrjMenusEN.MenuTitle = row["菜单标题"].ToString();
                    objQxPrjMenusEN.Memo = row["备注"].ToString();
                    objQxPrjMenusEN.InUse = bool.Parse( row["是否在用"].ToString());
                    objQxPrjMenusEN.UpMenuId = row["上级菜单Id"].ToString();
                    strUpMenuName = row["上级菜单名"].ToString();

                    //名族流水号获取
                    clsQxProjectsEN objProjectsEN = clsQxProjectsBLEx.GetProjectsObjByPrjName_Cache_SeqEx(row["工程名"].ToString());
                    if (objProjectsEN != null)
                    {
                        objQxPrjMenusEN.QxPrjId = objProjectsEN.QxPrjId;
                    }
                    //性别流水号获取
                    try
                    {
                        clsQxPrjMenuSetEN objPrjMenuSetEN = clsQxPrjMenuSetBLEx.GetQxPrjMenuSetObjByMenuSetName_Cache_SeqEx(objQxPrjMenusEN.QxPrjId, row["菜单集名称"].ToString());
                        if (objPrjMenuSetEN != null)
                        {
                            //objQxPrjMenusEN.MenuSetId = objPrjMenuSetEN.MenuSetId;
                        }
                    }
                    catch(Exception objException)
                    {
                        string strMenuSetName = row["菜单集名称"].ToString();
                        string strMsg = string.Format("菜单集名称:[{0}]不存在，请添加菜单集后再继续导入！", strMenuSetName);
                        clsCommonJsFunc.Alert(myPage, strMsg);
                        return false;
                    }
                    //政治面貌流水号获取
                    if (objQxPrjMenusEN.UpMenuId != "00000000")
                    {
          
                        clsQxPrjMenusEN objQxPrjMenusEN_P 
                            = clsQxPrjMenusBLEx.GetQxPrjMenusObjByMenuNameEx(strUpMenuName, objQxPrjMenusEN.QxPrjId);
                        if (objQxPrjMenusEN_P != null)
                        {
                            objQxPrjMenusEN.UpMenuId = objQxPrjMenusEN_P.MenuId;
                        }
                        else
                        {
                            string strMsg = string.Format("在导入菜单时，上级菜单名：{0}没有发现，请检查！({1})",
                                strUpMenuName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                        }
                    }
                    //学院流水号获取
                    clsQxPageDispModeEN objQxPageDispModeEN = clsQxPageDispModeBLEx.GetQxPageDispModeObjByPageDispModeName_Cache_SeqEx(row["页面显示模式名称"].ToString());
                    if (objQxPageDispModeEN != null)
                    {
                        objQxPrjMenusEN.PageDispModeId = objQxPageDispModeEN.PageDispModeId;
                    }
                    objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objQxPrjMenusEN.UpdUserId = clsCommonSession.UserId;

                    //判断学号是否存在
                    string strWhereCond = string.Format("MenuId='{0}'", objQxPrjMenusEN.MenuId.ToString());
                    if (clsQxPrjMenusBL.IsExistRecord(strWhereCond) == false)
                    {
                        objQxPrjMenusEN.Memo = "通过Excel导入添加！";
                        clsQxPrjMenusBL.AddNewRecordBySql2(objQxPrjMenusEN);
                    }
                    else
                    {
                        objQxPrjMenusEN.Memo = "通过Excel导入修改！";
                        clsQxPrjMenusBL.UpdateBySql2(objQxPrjMenusEN);
                    }
                }
                lblMess = "操作成功！";
                return true;

            }
            else
            {
                lblMess = "您所上传的excel格式不对！请下载excel模板";
                return false;
            }

        }


        /// <summary>
        /// 导入Excel文件到角色菜单表中
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="lblMess"></param>
        /// <param name="myPage"></param>
        /// <returns></returns>
        public static bool AddDateExcelToQxRoleMenus(DataTable dt, ref string lblMess, Page myPage)
        {
            clsQxRoleMenusEN objQxRoleMenusEN = new clsQxRoleMenusEN();

            if (dt.Columns.Contains("菜单Id"))
            {

                foreach (DataRow row in dt.Rows)
                {
                    objQxRoleMenusEN.MenuId = row["菜单Id"].ToString();
                    objQxRoleMenusEN.QxPrjId = row["项目编号"].ToString();
               
                    objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objQxRoleMenusEN.UpdUserId = clsCommonSession.UserId;
                    objQxRoleMenusEN.Memo = "通过Excel导入！";




                    //性别流水号获取
                    try
                    {
                        clsQxRolesEN objUserRolesEN = clsQxRolesBLEx.GetQxUserRolesObjByRoleName_Cache_SeqEx(row["角色名称"].ToString());
                        if (objUserRolesEN != null)
                        {
                            objQxRoleMenusEN.RoleId = objUserRolesEN.RoleId;
                        }
                    }
                    catch (Exception objException)
                    {
                        string strRoleName = row["角色名称"].ToString();
                        string strMsg = string.Format("角色名称:[{0}]不存在，请添加角色名称后再继续导入！", strRoleName);
                        clsCommonJsFunc.Alert(myPage, strMsg);
                        return false;
                    }
                    
                   
                    objQxRoleMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objQxRoleMenusEN.UpdUserId = clsCommonSession.UserId;
                    //判断学号是否存在
                    string strWhereCond = string.Format("MenuId='{0}' And RoleId='{1}'", objQxRoleMenusEN.MenuId, objQxRoleMenusEN.RoleId);
                    if (clsQxRoleMenusBL.IsExistRecord(strWhereCond) == false)
                    {
                        clsQxRoleMenusBL.AddNewRecordBySql2(objQxRoleMenusEN);
                    }
                    else
                    {
                        objQxRoleMenusEN.UpdateWithCondition(strWhereCond);
                    }
                }
                lblMess = "操作成功！";
                return true;

            }
            else
            {
                lblMess = "您所上传的excel格式不对！请下载excel模板";
                return false;
            }

        }

        /// <summary>
        /// 导入Excel文件到工程菜单表中
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="lblMess"></param>
        /// <param name="myPage"></param>
        /// <returns></returns>
        public static bool AddDateExcelToPrjMenuSet(DataTable dt, ref string lblMess, Page myPage)
        {
            clsQxPrjMenuSetEN objPrjMenuSetEN = new clsQxPrjMenuSetEN();

            if (dt.Columns.Contains("菜单集Id"))
            {

                foreach (DataRow row in dt.Rows)
                {
                    objPrjMenuSetEN.MenuSetId = row["菜单集Id"].ToString();
                    objPrjMenuSetEN.MenuSetName = row["菜单集名称"].ToString();
                    objPrjMenuSetEN.QxPrjId = row["项目Id"].ToString();
                    objPrjMenuSetEN.Memo = row["备注"].ToString();
                    objPrjMenuSetEN.IsDefault = bool.Parse(row["是否默认"].ToString());



                    //判断学号是否存在
                    string strWhereCond = string.Format("MenuSetId='{0}'", objPrjMenuSetEN.MenuSetId.ToString());
                    if (clsQxPrjMenuSetBL.IsExistRecord(strWhereCond) == false)
                    {
                        clsQxPrjMenuSetBL.AddNewRecordBySql2(objPrjMenuSetEN);
                    }
                    else
                    {
                        clsQxPrjMenuSetBL.UpdateBySql2(objPrjMenuSetEN);
                    }
                }
                lblMess = "操作成功！";
                return true;

            }
            else
            {
                lblMess = "您所上传的excel格式不对！请下载excel模板";
                return false;
            }

        }


        public static string GetLinkPageNameByFunctionName(string strFunctionName,
                bool bolIsStudent,
                string strId_StudentInfo,
                string strUserName4Unicode,
                string strQueryString,
                Page myPage)
        {
            string strWebformDir = myPage.ResolveUrl("~/Webform");
            string strReturnValue = "login";

            switch (strFunctionName)
            {
                case "Questionnaire-Disp":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)
                    //{
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaire_Show.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaire_Show.aspx?{0}", strQueryString);
                    }
                    break;
                case "Questionnaire-Edit":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)
                    //{
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaire_Edit.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaire_Edit.aspx?{0}", strQueryString);
                    }

                    break;


                case "UserMan":
                case "User-Disp"://User-Disp 用户查看 

                case "UserMan_All":
                case "User-Disp_All"://User-Disp_All 所有用户查看 
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUsers_QUDI2.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUsers_QUDI2.aspx?{0}", strQueryString);
                    }
                    break;
                case "User_SchoolMan"://                    User_SchoolMan 用户(学校)管理

  strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUsers_School_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUsers_School_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "User_School-Disp"://User_School-Disp 用户(学校)查看
                    strReturnValue = "";

                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUsers_School_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUsers_School_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "UserRoleMan"://                UserRoleMan 用户角色管理 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUserRoles_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmUserRoles_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "SetRole4User"://SetRole4User 为用户设置角色

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmSetRoles4Users2.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmSetRoles4Users2.aspx?{0}", strQueryString);
                    }
                    break;
                case "SetRole4User-Teacher"://SetRole4User-Teacher 为用户设置角色-教师 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmCourseTeacher_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmCourseTeacher_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "SetUsers4Role"://SetUsers4Role 为角色配用户 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmSetUsers4Roles.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmSetUsers4Roles.aspx?{0}", strQueryString);
                    }
                    break;
                case "DepartmentMan"://DepartmentMan 部门管理 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmDepartmentInfo_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmDepartmentInfo_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "QxPrjUserRelation-Edit":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)
                    //{E:\AspNet2011\Questionnaire\Questionnaire\WebForm\Admin\ExamsPapers\wfmcc_CourseExamPaper.aspx
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmQxPrjUserRelation_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Account/wfmQxPrjUserRelation_QUDI.aspx?{0}", strQueryString);
                    }

                    break;
                case "PaperReferExamLib":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)OneExamPaperTopic-Edit
                    //{PaperReferExamLib
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseExamPaperRelationship.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseExamPaperRelationship.aspx?{0}", strQueryString);
                    }

                    break;
               
                case "OneExamPaperTopic2-Edit":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)OneExamPaperTopic-Edit
                    //{
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourseWithPaperTopic_Edit.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourseWithPaperTopic_Edit.aspx?{0}", strQueryString);
                    }

                    break;
                case "OneExamPaperTopic-Edit":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)
                    //{E:\AspNet2011\Questionnaire\Questionnaire\WebForm\Admin\ExamsPapers\ExamPaperTopic.aspx
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/ExamPaperTopic.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/ExamPaperTopic.aspx?{0}", strQueryString);
                    }

                    break;
                case "DoingExercises-1Q":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)DoingExercises-1Q
                    //{E:\AspNet2011\Questionnaire\Questionnaire\WebForm\Admin\ExamsPapers\ExamPaperTopic.aspx
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourse_Show.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourse_Show.aspx?{0}", strQueryString);
                    }
                    break;
                case "DoingExercises-1Paper":

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourse_Show.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourse_Show.aspx?{0}", strQueryString);
                    }

                    break;
                case "SetPotence4Role-1Paper":

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourse_Show.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Wenjuan/wfmQuestionnaireByCourse_Show.aspx?{0}", strQueryString);
                    }

                    break;
                case "CurrEduCls-Edit":

                    strReturnValue = "";

                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "CurrEduCls-Disp-Teacher"://CurrEduCls-Disp-Teacher 教学班-显示-教师 

                    strReturnValue = "";

                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "CurrEduClsStu-Edit":

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsStuB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsStuB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "CurrEduClsStu-Edit-Teacher"://CurrEduClsStu-Edit-Teacher 教学班学生-编辑-教师 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsStuB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsStuB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "CurrEduClsTeacher-Edit":

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsTeacherB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/DailyRunning/wfmCurrEduClsTeacherB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "Knowledge-Edit":

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseKnowledgesB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseKnowledgesB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "Knowledge-Disp-Student"://Knowledge-Disp-Student 知识点-显示-学生 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseKnowledgesB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseKnowledgesB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "Knowledge-Disp-Teacher"://Knowledge-Disp-Teacher 知识点-显示-教师 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseKnowledgesB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_CourseKnowledgesB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "KnowledgeLearn-Student"://KnowledgeLearn-Student 知识点学习情况-学生 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnTotalB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnTotalB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "KnowledgeLearn-Teacher"://KnowledgeLearn-Teacher 知识点学习情况-教师

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnTotalB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnTotalB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "KnowledgeLearn-Detail-Student"://KnowledgeLearn-Detail-Student 知识点学习情况-详细-学生 

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnDetailB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnDetailB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "KnowledgeLearn-Detail-Teacher"://KnowledgeLearn-Detail-Teacher 知识点学习情况-详细-教师

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnDetailB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmKnowledgeLearnDetailB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "ExamLibKnowledge-Edit":

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strQueryString = "?ResouceType=题库&RelationshipType=exam";
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_KnowledgesExamLibRela.aspx");
                    }
                    else
                    {
                        strQueryString += "&ResouceType=题库&RelationshipType=exam";
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_KnowledgesExamLibRela.aspx?{0}", strQueryString);
                    }
                    break;
                case "KnowledgeExamLib-Edit":

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strQueryString = "?ResouceType=题库&RelationshipType=knowledge";
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_KnowledgesExamLibRela.aspx");
                    }
                    else
                    {
                        strQueryString += "&ResouceType=题库&RelationshipType=knowledge";
                        strReturnValue = string.Format(strWebformDir + "/ExamsPapers/wfmcc_KnowledgesExamLibRela.aspx?{0}", strQueryString);
                    }
                    break;
                case "QuestionnaireByCourse-LowEdit":

                    strReturnValue = "";

                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamLib/wfmQuestionnaireQUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamLib/wfmQuestionnaireQUDI.aspx?{0}", strQueryString);
                    }

                    break;
                case "OneQxPrjUserRelation-Edit-List"://OneQxPrjUserRelation-Edit-List 单套工程用户关系-维护-列表

                    strReturnValue = "";

                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamLib/wfmQuestionnaireQUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/ExamLib/wfmQuestionnaireQUDI.aspx?{0}", strQueryString);
                    }

                    break;
                case "MenuSet"://MenuSet 菜单设置
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/GeneMenu/wfmQxPrjMenus_EDITMenu2.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/GeneMenu/wfmQxPrjMenus_EDITMenu2.aspx?{0}", strQueryString);
                    }
                    break;
                case "WorkCorrectKeyWork-Edit"://WorkCorrectKeyWork-Edit 作业批改关键词-维护
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/InteractManage/wfmcc_WorkCorrectKeyWorkB_QUDI_SubPage.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/InteractManage/wfmcc_WorkCorrectKeyWorkB_QUDI_SubPage.aspx?{0}", strQueryString);
                    }
                    break;
                case "SetRoleMenu"://SetRoleMenu 设置角色菜单 
                case "SetRoleMenu-Question"://SetRoleMenu-Question 设置角色菜单-题目  
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/GeneMenu/wfmSetMenu4Roles2.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/GeneMenu/wfmSetMenu4Roles2.aspx?{0}", strQueryString);
                    }
                    break;
               
                case "MenuSet-Edit"://MenuSet-Edit 菜单集维护

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/GeneMenu/wfmPrjMenuSet_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/GeneMenu/wfmPrjMenuSet_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "AccessApplySendBack"://AccessApplySendBack 处理申请退回

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkScore.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkScore.aspx?{0}", strQueryString);
                    }
                    break;
                case "QueryFinishWork-Student"://作业完成情况-学生
                case "QueryFinishWork-Question-Student"://QueryFinishWork-Question-Student 作业完成情况-题目-学生

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkScore.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkScore.aspx?{0}", strQueryString);
                    }
                    break;



                case "QueryFinishWork-Teacher"://作业完成情况-教师
                case "QueryFinishWork-Question-Teacher"://QueryFinishWork-Question-Teacher 作业完成情况-题目-教师

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkScore.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkScore.aspx?{0}", strQueryString);
                    }
                    break;

                case "QueryWorkTotal-Student"://作业情况汇总-学生

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation_TotalB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation_TotalB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "QueryWorkTotal-Teacher"://作业情况汇总-教师
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation_TotalB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation_TotalB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "ErrorWorkLib-Edit"://ErrorWorkLib-Edit 错误作业-编辑
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation4ErrorLibB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation4ErrorLibB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "PotenceTypeMan":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true)
                    //{E:\AspNet2011\Questionnaire\Questionnaire\WebForm\Admin\ExamsPapers\wfmcc_CourseExamPaper.aspx
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/PotenceMan/wfmPotenceType_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/PotenceMan/wfmPotenceType_QUDI.aspx?{0}", strQueryString);
                    }

                    break;
                case "PotenceMan":

                    strReturnValue = "";
                    //if (clsSysParaEN.bolIsUseWidePage == true) 
                    //{E:\AspNet2011\Questionnaire\Questionnaire\WebForm\Admin\ExamsPapers\wfmcc_CourseExamPaper.aspx
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/PotenceMan/wfmPrjPotence_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/PotenceMan/wfmPrjPotence_QUDI.aspx?{0}", strQueryString);
                    }

                    break;
                case "SetPotence4Role"://为角色配权限

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/UserRolePotence/wfmSetPotenceSymbolForRoles.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/UserRolePotence/wfmSetPotenceSymbolForRoles.aspx?{0}", strQueryString);
                    }
                    break;
                case "PotenceSymbolMan"://权限标志管理

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/PotenceMan/wfmSetRelaOfPotenceAndSymbol.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/PotenceMan/wfmSetRelaOfPotenceAndSymbol.aspx?{0}", strQueryString);
                    }
                    break;
                case "QueryPotenceTypeMan-Teacher"://习题完成情况-教师

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/InteractManage/wfmExamPaperStuRelationB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/InteractManage/wfmExamPaperStuRelationB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "SetFieldVisibility"://设置字段可视性

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/SystemSet/wfmSetFieldVisibilityB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/SystemSet/wfmSetFieldVisibilityB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "QuestionType-Edit"://QuestionType-Edit  题型-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/SysPara/wfmQuestionTypeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/SysPara/wfmQuestionTypeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "ExamGrade-Edit"://ExamGrade-Edit 题库等级-编辑
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmcc_ExamGradeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmcc_ExamGradeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "CourseType-Edit"://CourseType-Edit 课程类型-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmcc_CourseTypeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmcc_CourseTypeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "QxPrjPotenceType-Edit"://QxPrjPotenceType-Edit 通用课程类型-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmQxPrjPotenceTypeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmQxPrjPotenceTypeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "TextDirect-Edit"://TextDirect-Edit 文本方向-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/SysPara/wfmTextDirectB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/SysPara/wfmTextDirectB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "PaperDispMode-Edit"://PaperDispMode-Edit 试卷显示模式-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmcc_PaperDispModeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmcc_PaperDispModeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "ExcellentType-Edit":// ExcellentType-Edit 精品课程类型-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmcc_ExcellentTypeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseManage/wfmcc_ExcellentTypeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "Themes-Edit":// Themes-Edit 课程主题-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseLearning/wfmcc_ThemesB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/CourseLearning/wfmcc_ThemesB_QUDI.aspx?{0}", strQueryString);
                    }

                    break;
                case "SetDefaultPapersBigTopic":// SetDefaultPapersBigTopic 设置默认题型

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmcc_PapersBigTopicDefaultB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/Knowledges/wfmcc_PapersBigTopicDefaultB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "RightType-Edit":// RightType-Edit 权限类型-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxRightTypeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxRightTypeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "Right-Edit":// Right-Edit 权限-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxRightB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxRightB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "UserRightRela-Edit":// UserRightRela-Edit 用户权限关系-编辑

                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxUserRightRelaB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxUserRightRelaB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;

                case "UserRightDetail-Edit":// UserRightDetail-Edit 用户权限详细关系-编辑
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxUserRightDetailB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmQxUserRightDetailB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "SetStudent4CrrectWork":// SetStudent4CrrectWork 设置菜单集维护学生
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation4CorrectB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmcc_WorkStuRelation4CorrectB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "SourseType-Edit":// SourseType-Edit 资源类型-编辑
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmSourceTypeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/HomeWork/wfmSourceTypeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "InOutType-Edit"://  InOutType-Edit InOut类型-编辑
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/SysPara/wfmInOutTypeB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/SysPara/wfmInOutTypeB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                case "SetEduCls4CrrectWork":// SetEduCls4CrrectWork 设置菜单集维护教学班
                    strReturnValue = "";
                    if (string.IsNullOrEmpty(strQueryString) == true)
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmCurrEduClsStu4CorrectB_QUDI.aspx");
                    }
                    else
                    {
                        strReturnValue = string.Format(strWebformDir + "/UsersRight/wfmCurrEduClsStu4CorrectB_QUDI.aspx?{0}", strQueryString);
                    }
                    break;
                default:
                    //strReturnValue = "";
                    string strMsg = string.Format("功能名:[{0}]在函数中没有处理，请检查！({1})",
                               strFunctionName,
                               clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
            return strReturnValue;
        }
        public static void GetLoginRelaInfo(string strUserId)
        {
            string strUserName = clsQxUsersBLEx.GetUserNameByUserId(strUserId);
            string strRoleIds = "";// clsUsersBLEx.GetRoleList(strUserId);
            string strCondition = string.Format("UserId='{0}'", strUserId);
            List<clsvQxUserRoleRelationEN> arrvUserRoleRelation = clsvQxUserRoleRelationBL.GetObjLst(strCondition);
            if (arrvUserRoleRelation.Count == 0)
            {

            }
            clsCommonSession.UserId = strUserId;

            clsCommonSession.UserName = strUserName;
            string strRoleNames = "";
            foreach (clsvQxUserRoleRelationEN obj in arrvUserRoleRelation)
            {
                strRoleIds += string.Format("{0},", obj.RoleId);
                strRoleNames += string.Format("{0},", obj.RoleName);
            }
            strRoleIds.TrimEnd(',');
            strRoleNames.TrimEnd(',');
            clsCommonSession.RoleId = strRoleIds;
            clsCommonSession.RoleName = strRoleNames;
            //保存当前用户ID
        }

    }
}