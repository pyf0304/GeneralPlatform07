using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using CommFunc4WebForm;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.file;

namespace EduHigh
{
    /// <summary>
    /// Common 的摘要说明
    /// </summary>
    public class clsCommonSession
    {
        public clsCommonSession()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public string LiveRoomSite
        {
            get
            {
                string strLiveRoomSite;
                strLiveRoomSite = (string)System.Web.HttpContext.Current.Session["LiveRoomSite"];
                if (strLiveRoomSite == null)
                {
                    strLiveRoomSite = "";
                }
                return strLiveRoomSite;
            }
            set
            {
                string strLiveRoomSite = value;
                System.Web.HttpContext.Current.Session.Add("LiveRoomSite", strLiveRoomSite);
            }
        }

        /// <summary>
        /// 当前登录userID
        /// </summary>
        public static string UserId
        {
            get
            {
                string strUserId;
                strUserId = (string)System.Web.HttpContext.Current.Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                System.Web.HttpContext.Current.Session.Add("UserId", strUserId);
            }
        }

        public static string UserId4get
        {
            get
            {
                string strUserId;
                strUserId = (string)System.Web.HttpContext.Current.Session["UserId"];
                if (strUserId == null)
                {
                    strUserId = "";
                }
                return strUserId;
            }
            set
            {
                string strUserId = value;
                string strMsg = string.Format("用户被设置为：{0}。在页面：【{1}】",
                    value,
                  System.Web.HttpContext.Current.Request.Url.AbsolutePath);
                clsPubVar.objLog.WriteDebugLog(strMsg);
                System.Web.HttpContext.Current.Session.Add("UserId", strUserId);
            }
        }
        //
        //public string UserId
        //{
        //    get
        //    {
        //        string strUserId;
        //        strUserId = (string)System.Web.HttpContext.Current.Session["UserId"];
        //        if (strUserId == null)
        //        {
        //            strUserId = "";
        //        }
        //        return strUserId;
        //    }
        //    set
        //    {
        //        string strUserId = value;
        //        System.Web.HttpContext.Current.Session.Add("UserId", strUserId);
        //    }
        //}


        /// <summary>
        /// 基教名师图片
        /// </summary>
        public string JJMSPic
        {
            get
            {
                string strJJMSPic;
                strJJMSPic = (string)System.Web.HttpContext.Current.Session["JJMSPic"];
                if (strJJMSPic == null)
                {
                    strJJMSPic = "";
                }
                return strJJMSPic;
            }
            set
            {
                string strJJMSPic = value;
                System.Web.HttpContext.Current.Session.Add("JJMSPic", strJJMSPic);
            }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public static string UserName
        {
            get
            {
                string strUserName;
                strUserName = (string)System.Web.HttpContext.Current.Session["UserName"];
                if (strUserName == null)
                {
                    strUserName = "";
                }
                return strUserName;
            }
            set
            {
                string strUserName = value;
                System.Web.HttpContext.Current.Session.Add("UserName", strUserName);
            }
        }

        /// <summary>
        /// 用户类型Id, 主要用来区分职前用户,职后用户
        /// </summary>
        public string UserTypeId
        {
            get
            {
                string strUserTypeId;
                strUserTypeId = (string)System.Web.HttpContext.Current.Session["UserTypeId"];
                if (strUserTypeId == null)
                {
                    strUserTypeId = "";
                }
                return strUserTypeId;
            }
            set
            {
                string strUserTypeId = value;
                System.Web.HttpContext.Current.Session.Add("UserTypeId", strUserTypeId);
            }
        }

        /// <summary>
        /// 用户类别Id, 主要用来区分：学生、教师、管理员
        /// </summary>
        public string UserKindId
        {
            get
            {
                string strUserKindId;
                strUserKindId = (string)System.Web.HttpContext.Current.Session["UserKindId"];
                if (strUserKindId == null)
                {
                    strUserKindId = "";
                }
                return strUserKindId;
            }
            set
            {
                string strUserKindId = value;
                System.Web.HttpContext.Current.Session.Add("UserKindId", strUserKindId);
            }
        }
        /// <summary>
        /// 功能模块ID
        /// </summary>
        public string FuncModuleId
        {
            get
            {
                string strFuncModuleId;
                strFuncModuleId = (string)System.Web.HttpContext.Current.Session["FuncModuleId"];
                if (strFuncModuleId == null)
                {
                    strFuncModuleId = "";
                }
                return strFuncModuleId;
            }
            set
            {
                string strFuncModuleId = value;
                System.Web.HttpContext.Current.Session.Add("FuncModuleId", strFuncModuleId);
            }
        }
        /// <summary>
        /// 浏览器信息
        /// </summary>
        public static string BrowserInfo
        {
            get
            {
                string strBrowserInfo;
                strBrowserInfo = (string)System.Web.HttpContext.Current.Session["BrowserInfo"];
                if (strBrowserInfo == null)
                {
                    strBrowserInfo = "";
                }
                return strBrowserInfo;
            }
            set
            {
                string strBrowserInfo = value;
                System.Web.HttpContext.Current.Session.Add("BrowserInfo", strBrowserInfo);
            }
        }
        /// <summary>
        /// 模块名
        /// </summary>
        public string Module
        {
            get
            {
                string strModule;
                strModule = (string)System.Web.HttpContext.Current.Session["Module"];
                if (strModule == null)
                {
                    strModule = "";
                }
                return strModule;
            }
            set
            {
                string strModule = value;
                System.Web.HttpContext.Current.Session.Add("Module", strModule);
            }
        }
        public string CurrentUserPassword
        {
            get
            {
                string strCurrentUserPassword;
                strCurrentUserPassword = (string)System.Web.HttpContext.Current.Session["CurrentUserPassword"];
                if (strCurrentUserPassword == null)
                {
                    strCurrentUserPassword = "";
                }
                return strCurrentUserPassword;
            }
            set
            {
                string strCurrentUserPassword = value;
                System.Web.HttpContext.Current.Session.Add("CurrentUserPassword", strCurrentUserPassword);
            }
        }
        /// <summary>
        /// 调用登录界面的前一界面名称
        /// </summary>
        public string BeforePage
        {
            get
            {
                string strBeforePage;
                strBeforePage = (string)System.Web.HttpContext.Current.Session["BeforePage"];
                if (strBeforePage == null)
                {
                    strBeforePage = "";
                }
                return strBeforePage;
            }
            set
            {
                string strBeforePage = value;
                System.Web.HttpContext.Current.Session.Add("BeforePage", strBeforePage);
            }
        }

        public static string RoleId
        {
            get
            {
                string strRoleId;
                strRoleId = (string)System.Web.HttpContext.Current.Session["RoleId"];
                if (strRoleId == null)
                {
                    strRoleId = "";
                }
                return strRoleId;
            }
            set
            {
                string strRoleId = value;
                System.Web.HttpContext.Current.Session.Add("RoleId", strRoleId);
            }

        }


        public string Id_StudentInfo
        {
            get
            {
                string strId_StudentInfo;
                strId_StudentInfo = (string)System.Web.HttpContext.Current.Session["Id_StudentInfo"];
                if (strId_StudentInfo == null)
                {
                    strId_StudentInfo = "";
                }
                return strId_StudentInfo;
            }
            set
            {
                string strId_StudentInfo = value;
                System.Web.HttpContext.Current.Session.Add("Id_StudentInfo", strId_StudentInfo);
            }
        }

        public static string IpAddress
        {
            get
            {
                string strIpAddress;
                strIpAddress = (string)System.Web.HttpContext.Current.Session["IpAddress"];
                if (strIpAddress == null)
                {
                    strIpAddress = "";
                }
                return strIpAddress;
            }
            set
            {
                string strIpAddress = value;
                System.Web.HttpContext.Current.Session.Add("IpAddress", strIpAddress);
            }
        }
        public FileCollection sessFileCol
        {
            get
            {
                FileCollection objFileCol;
                objFileCol = (FileCollection)System.Web.HttpContext.Current.Session["FileCol"];
                if (objFileCol == null)
                {
                    objFileCol = null;
                }
                return objFileCol;
            }
            set
            {
                FileCollection objFileCol = value;
                System.Web.HttpContext.Current.Session.Add("FileCol", objFileCol);
            }
        }
        public string qs_EditType
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.QueryString["EditType"] != null)
                {
                    if (!String.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["EditType"].ToString()))
                    {
                        return System.Web.HttpContext.Current.Request.QueryString["EditType"].ToString();
                    }
                }
                return "";
            }
        }
        public string qs_Id_PracticeScore
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.QueryString["Id_PracticeScore"] != null)
                {
                    if (!String.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["Id_PracticeScore"].ToString()))
                    {
                        return System.Web.HttpContext.Current.Request.QueryString["Id_PracticeScore"].ToString();
                    }
                }
                return "";
            }
        }
        public string qs_Id_PracticeLevel
        {
            get
            {
                if (System.Web.HttpContext.Current.Request.QueryString["Id_PracticeLevel"] != null)
                {
                    if (!String.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["Id_PracticeLevel"].ToString()))
                    {
                        return System.Web.HttpContext.Current.Request.QueryString["Id_PracticeLevel"].ToString();
                    }
                }
                return "";
            }
        }

        public static string seErrMessage
        {
            get
            {
                string strErrMessage;
                strErrMessage = (string)System.Web.HttpContext.Current.Session["clsCommonSession.seErrMessage"];
                if (strErrMessage == null)
                {
                    strErrMessage = "";
                }
                return strErrMessage;
            }
            set
            {
                string strErrMessage = value;
                System.Web.HttpContext.Current.Session.Add("clsCommonSession.seErrMessage", strErrMessage);
            }
        }
        public static string seBackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)System.Web.HttpContext.Current.Session["clsCommonSession.seBackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                System.Web.HttpContext.Current.Session.Add("clsCommonSession.seBackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }
        public void ClearSession()
        {
            //ErrorInformationBL.AddInformation("clsCommonSession", "ClearSession " + IpAddress,
            //    "取消ViewState" + clsDateTime_Db.GetDataBaseDateTime14(), UserId);
            //System.Web.HttpContext.Current.Session.Clear();
        }
        public static  void SetSessionTimeout(int intTime)
        {
         
            System.Web.HttpContext.Current.Session.Timeout = intTime;
        }

        public string Id_YoungTAppraisedCase
        {
            get
            {
                string strId_YoungTAppraisedCase;
                strId_YoungTAppraisedCase = (string)System.Web.HttpContext.Current.Session["Id_YoungTAppraisedCase"];
                if (strId_YoungTAppraisedCase == null)
                {
                    strId_YoungTAppraisedCase = "";
                }
                return strId_YoungTAppraisedCase;
            }
            set
            {
                string strId_YoungTAppraisedCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_YoungTAppraisedCase", strId_YoungTAppraisedCase);
            }
        }

        public string Id_MandarinCase
        {
            get
            {
                string strId_MandarinCase;
                strId_MandarinCase = (string)System.Web.HttpContext.Current.Session["Id_MandarinCase"];
                if (strId_MandarinCase == null)
                {
                    strId_MandarinCase = "";
                }
                return strId_MandarinCase;
            }
            set
            {
                string strId_MandarinCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_MandarinCase", strId_MandarinCase);
            }
        }

        public string Id_WritingOnBBCase
        {
            get
            {
                string strId_WritingOnBBCase;
                strId_WritingOnBBCase = (string)System.Web.HttpContext.Current.Session["Id_WritingOnBBCase"];
                if (strId_WritingOnBBCase == null)
                {
                    strId_WritingOnBBCase = "";
                }
                return strId_WritingOnBBCase;
            }
            set
            {
                string strId_WritingOnBBCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_WritingOnBBCase", strId_WritingOnBBCase);
            }
        }
        public string Id_MicroTechCase
        {
            get
            {
                string strId_MicroTechCase;
                strId_MicroTechCase = (string)System.Web.HttpContext.Current.Session["Id_MicroTechCase"];
                if (strId_MicroTechCase == null)
                {
                    strId_MicroTechCase = "";
                }
                return strId_MicroTechCase;
            }
            set
            {
                string strId_MicroTechCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_MicroTechCase", strId_MicroTechCase);
            }
        }

        public string Id_CoursewareResCase
        {
            get
            {
                string strId_CoursewareResCase;
                strId_CoursewareResCase = (string)System.Web.HttpContext.Current.Session["Id_CoursewareResCase"];
                if (strId_CoursewareResCase == null)
                {
                    strId_CoursewareResCase = "";
                }
                return strId_CoursewareResCase;
            }
            set
            {
                string strId_CoursewareResCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_CoursewareResCase", strId_CoursewareResCase);
            }
        }


        public string Id_TeachingCaseResCase
        {
            get
            {
                string strId_TeachingCaseResCase;
                strId_TeachingCaseResCase = (string)System.Web.HttpContext.Current.Session["Id_TeachingCaseResCase"];
                if (strId_TeachingCaseResCase == null)
                {
                    strId_TeachingCaseResCase = "";
                }
                return strId_TeachingCaseResCase;
            }
            set
            {
                string strId_TeachingCaseResCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_TeachingCaseResCase", strId_TeachingCaseResCase);
            }
        }

        public string Id_CourseLearningCase
        {
            get
            {
                string strId_CourseLearningCase;
                strId_CourseLearningCase = (string)System.Web.HttpContext.Current.Session["Id_CourseLearningCase"];
                if (strId_CourseLearningCase == null)
                {
                    strId_CourseLearningCase = "";
                }
                return strId_CourseLearningCase;
            }
            set
            {
                string strId_CourseLearningCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_CourseLearningCase", strId_CourseLearningCase);
            }
        }

        public string Id_EduMSTRGiftedClsCase
        {
            get
            {
                string strId_EduMSTRGiftedClsCase;
                strId_EduMSTRGiftedClsCase = (string)System.Web.HttpContext.Current.Session["Id_EduMSTRGiftedClsCase"];
                if (strId_EduMSTRGiftedClsCase == null)
                {
                    strId_EduMSTRGiftedClsCase = "";
                }
                return strId_EduMSTRGiftedClsCase;
            }
            set
            {
                string strId_EduMSTRGiftedClsCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_EduMSTRGiftedClsCase", strId_EduMSTRGiftedClsCase);
            }
        }

        public string Id_VideoResCase
        {
            get
            {
                string strId_VideoResCase;
                strId_VideoResCase = (string)System.Web.HttpContext.Current.Session["Id_VideoResCase"];
                if (strId_VideoResCase == null)
                {
                    strId_VideoResCase = "";
                }
                return strId_VideoResCase;
            }
            set
            {
                string strId_VideoResCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_VideoResCase", strId_VideoResCase);
            }
        }


        public string Id_ClsRmTeachingCase
        {
            get
            {
                string strId_ClsRmTeachingCase;
                strId_ClsRmTeachingCase = (string)System.Web.HttpContext.Current.Session["Id_ClsRmTeachingCase"];
                if (strId_ClsRmTeachingCase == null)
                {
                    strId_ClsRmTeachingCase = "";
                }
                return strId_ClsRmTeachingCase;
            }
            set
            {
                string strId_ClsRmTeachingCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_ClsRmTeachingCase", strId_ClsRmTeachingCase);
            }
        }
        public string Id_CoursewareCase
        {
            get
            {
                string strId_CoursewareCase;
                strId_CoursewareCase = (string)System.Web.HttpContext.Current.Session["Id_CoursewareCase"];
                if (strId_CoursewareCase == null)
                {
                    strId_CoursewareCase = "";
                }
                return strId_CoursewareCase;
            }
            set
            {
                string strId_CoursewareCase = value;
                System.Web.HttpContext.Current.Session.Add("Id_CoursewareCase", strId_CoursewareCase);
            }
        }
        public string id_XzCollege
        {
            get
            {
                string strId_College;
                strId_College = (string)System.Web.HttpContext.Current.Session["id_XzCollege"];
                if (strId_College == null)
                {
                    strId_College = "";
                }
                return strId_College;
            }
            set
            {
                string strId_College = value;
                System.Web.HttpContext.Current.Session.Add("id_XzCollege", strId_College);
            }
        }
        /// <summary>
        /// 课例等级Id,分为优秀、良好、一般、较差
        /// </summary>
        public string CaseLevelId
        {
            get
            {
                string strCaseLevelId;
                strCaseLevelId = (string)System.Web.HttpContext.Current.Session["CaseLevelId"];
                if (strCaseLevelId == null)
                {
                    strCaseLevelId = "";
                }
                return strCaseLevelId;
            }
            set
            {
                string strCaseLevelId = value;
                System.Web.HttpContext.Current.Session.Add("CaseLevelId", strCaseLevelId);
            }
        }

        /// <summary>
        /// 课件类型流水号,分为：教学设计、说课稿、课件、实习小结
        /// </summary>
        public string Id_ClsRmTeachingCaseType
        {
            get
            {
                string strId_ClsRmTeachingCaseType;
                strId_ClsRmTeachingCaseType = (string)System.Web.HttpContext.Current.Session["Id_ClsRmTeachingCaseType"];
                if (strId_ClsRmTeachingCaseType == null)
                {
                    strId_ClsRmTeachingCaseType = "";
                }
                return strId_ClsRmTeachingCaseType;
            }
            set
            {
                string strId_ClsRmTeachingCaseType = value;
                System.Web.HttpContext.Current.Session.Add("Id_ClsRmTeachingCaseType", strId_ClsRmTeachingCaseType);
            }
        }


        /// <summary>
        /// 课件类型流水号,分为：教学设计、说课稿、课件、实习小结
        /// </summary>
        public string Id_TeachingCaseResCaseType
        {
            get
            {
                string strId_TeachingCaseResCaseType;
                strId_TeachingCaseResCaseType = (string)System.Web.HttpContext.Current.Session["Id_TeachingCaseResCaseType"];
                if (strId_TeachingCaseResCaseType == null)
                {
                    strId_TeachingCaseResCaseType = "";
                }
                return strId_TeachingCaseResCaseType;
            }
            set
            {
                string strId_TeachingCaseResCaseType = value;
                System.Web.HttpContext.Current.Session.Add("Id_TeachingCaseResCaseType", strId_TeachingCaseResCaseType);
            }
        }

        /// <summary>
        /// 课件类型流水号,分为：教学设计、说课稿、课件、实习小结
        /// </summary>
        public string Id_CourseLearningCaseType
        {
            get
            {
                string strId_CourseLearningCaseType;
                strId_CourseLearningCaseType = (string)System.Web.HttpContext.Current.Session["Id_CourseLearningCaseType"];
                if (strId_CourseLearningCaseType == null)
                {
                    strId_CourseLearningCaseType = "";
                }
                return strId_CourseLearningCaseType;
            }
            set
            {
                string strId_CourseLearningCaseType = value;
                System.Web.HttpContext.Current.Session.Add("Id_CourseLearningCaseType", strId_CourseLearningCaseType);
            }
        }
        /// <summary>
        /// 课件类型流水号,分为：教学设计、说课稿、课件、实习小结
        /// </summary>
        public string Id_VideoResCaseType
        {
            get
            {
                string strId_VideoResCaseType;
                strId_VideoResCaseType = (string)System.Web.HttpContext.Current.Session["Id_VideoResCaseType"];
                if (strId_VideoResCaseType == null)
                {
                    strId_VideoResCaseType = "";
                }
                return strId_VideoResCaseType;
            }
            set
            {
                string strId_VideoResCaseType = value;
                System.Web.HttpContext.Current.Session.Add("Id_VideoResCaseType", strId_VideoResCaseType);
            }
        }

        /// <summary>
        /// 课件资源类型流水号,分为：教学设计、说课稿、课件、实习小结
        /// </summary>
        public string Id_CoursewareResCaseType
        {
            get
            {
                string strId_CoursewareResCaseType;
                strId_CoursewareResCaseType = (string)System.Web.HttpContext.Current.Session["Id_CoursewareResCaseType"];
                if (strId_CoursewareResCaseType == null)
                {
                    strId_CoursewareResCaseType = "";
                }
                return strId_CoursewareResCaseType;
            }
            set
            {
                string strId_CoursewareResCaseType = value;
                System.Web.HttpContext.Current.Session.Add("Id_CoursewareResCaseType", strId_CoursewareResCaseType);
            }
        }
        /// <summary>
        /// 课件类型流水号,分为：教学设计、说课稿、课件、实习小结
        /// </summary>
        public string Id_CoursewareCaseType
        {
            get
            {
                string strId_CoursewareCaseType;
                strId_CoursewareCaseType = (string)System.Web.HttpContext.Current.Session["Id_CoursewareCaseType"];
                if (strId_CoursewareCaseType == null)
                {
                    strId_CoursewareCaseType = "";
                }
                return strId_CoursewareCaseType;
            }
            set
            {
                string strId_CoursewareCaseType = value;
                System.Web.HttpContext.Current.Session.Add("Id_CoursewareCaseType", strId_CoursewareCaseType);
            }
        }
        /// <summary>
        /// 获取错误信息
        /// </summary>
        /// <param name="objException"></param>

        public void GetErrorMessage(Exception objException, string ErrorMessage)
        {

            clsCommonSession.seErrMessage = ErrorMessage + objException.Message;
            clsCommonSession.seBackErrPageLinkStr = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            //System.Web.HttpContext.Current.Response.Redirect(clsSysParaEN.ErrorPage);

        }
        /// <summary>
        /// 显示错误信息
        /// </summary>
        /// <param name="objException"></param>

        public void ShowErrorMessage(string strErrorMessage)
        {

            clsCommonSession.seErrMessage = strErrorMessage;
            clsCommonSession.seBackErrPageLinkStr = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            //System.Web.HttpContext.Current.Response.Redirect(clsSysParaEN.ErrorPage);

        }

        ///主菜单css样式
        public string MenuCss
        {
            get
            {
                string strMenuCss;
                strMenuCss = (string)System.Web.HttpContext.Current.Session["MenuCss"];
                if (strMenuCss == null)
                {
                    strMenuCss = "";
                }
                return strMenuCss;
            }
            set
            {
                string strMenuCss = value;
                System.Web.HttpContext.Current.Session.Add("MenuCss", strMenuCss);
            }
        }
        ///页面名称
        public static string PageName
        {
            get
            {
                string strPageName;
                strPageName = (string)System.Web.HttpContext.Current.Session["PageName"];
                if (strPageName == null)
                {
                    strPageName = "";
                }
                return strPageName;
            }
            set
            {
                string strPageName = value;
                System.Web.HttpContext.Current.Session.Add("PageName", strPageName);
            }
        }


        /// <summary>
        /// 主题名称
        /// </summary>
        public static string Theme
        {
            get
            {
                string strTheme;
                strTheme = (string)System.Web.HttpContext.Current.Session["Theme"];
                if (strTheme == null)
                {
                    strTheme = "";
                }
                return strTheme;
            }
            set
            {
                string strTheme = value;
                System.Web.HttpContext.Current.Session.Add("Theme", strTheme);
            }
        }


        /// <summary>
        /// 动态样式
        /// </summary>
        public static string configThemes
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["ThemesName"] != null)
                {
                    return System.Configuration.ConfigurationManager.AppSettings["ThemesName"].ToString();
                }
                else
                {
                    return "Skin1";
                }
            }
        }


        //课程IP
        public static string CourseId
        {
            get
            {
                string strCourseId;
                strCourseId = (string)System.Web.HttpContext.Current.Session["CourseId"];
                if (strCourseId == null)
                {
                    strCourseId = "";
                }
                return strCourseId;
            }
            set
            {
                string strCourseId = value;
                System.Web.HttpContext.Current.Session.Add("CourseId", strCourseId);
            }
        }
        /// <summary>
        /// 部门Id
        /// </summary>
        public static string DepartmentId
        {
            get
            {
                string strDepartmentId;
                strDepartmentId = (string)System.Web.HttpContext.Current.Session["DepartmentId"];
                if (strDepartmentId == null)
                {
                    strDepartmentId = "";
                }
                return strDepartmentId;
            }
            set
            {
                string strDepartmentId = value;
                System.Web.HttpContext.Current.Session.Add("DepartmentId", strDepartmentId);
            }
        }
        //教师ID
        public static string id_Teacher
        {
            get
            {
                string strid_Teacher;
                strid_Teacher = (string)System.Web.HttpContext.Current.Session["id_Teacher"];
                if (strid_Teacher == null)
                {
                    strid_Teacher = "";
                }
                return strid_Teacher;
            }
            set
            {
                string strid_Teacher = value;
                System.Web.HttpContext.Current.Session.Add("id_Teacher", strid_Teacher);
            }
        }


        public static string id_XzMajor
        {
            get
            {
                string strid_XzMajor;
                strid_XzMajor = (string)System.Web.HttpContext.Current.Session["id_XzMajor"];
                if (strid_XzMajor == null)
                {
                    strid_XzMajor = "";
                }
                return strid_XzMajor;
            }
            set
            {
                string strid_XzMajor = value;
                System.Web.HttpContext.Current.Session.Add("id_XzMajor", strid_XzMajor);
            }
        }
        public string HomePage
        {
            get
            {
                string strHomePage;
                strHomePage = (string)System.Web.HttpContext.Current.Session["HomePage"];
                if (strHomePage == null)
                {
                    strHomePage = "";
                }
                return strHomePage;
            }
            set
            {
                string strHomePage = value;
                System.Web.HttpContext.Current.Session.Add("HomePage", strHomePage);
            }
        }
        public static string id_TeachingPlan
        {
            get
            {
                string strid_TeachingPlan;
                strid_TeachingPlan = (string)System.Web.HttpContext.Current.Session["id_TeachingPlan"];
                if (strid_TeachingPlan == null)
                {
                    strid_TeachingPlan = "";
                }
                return strid_TeachingPlan;
            }
            set
            {
                string strid_TeachingPlan = value;
                System.Web.HttpContext.Current.Session.Add("id_TeachingPlan", strid_TeachingPlan);
            }
        }

        public static string PageTitle
        {
            get
            {
                string strPageTitle;
                strPageTitle = (string)System.Web.HttpContext.Current.Session["PageTitle"];
                if (strPageTitle == null)
                {
                    strPageTitle = "";
                }
                return strPageTitle;
            }
            set
            {
                string strPageTitle = value;
                System.Web.HttpContext.Current.Session.Add("PageTitle", strPageTitle);
            }
        }
        public static string BatchId
        {
            get
            {
                string strBatchId;
                strBatchId = (string)System.Web.HttpContext.Current.Session["BatchId"];
                if (strBatchId == null)
                {
                    strBatchId = "";
                }
                return strBatchId;
            }
            set
            {
                string strBatchId = value;
                System.Web.HttpContext.Current.Session.Add("BatchId", strBatchId);
            }
        }

        public static string QuestionID
        {
            get
            {
                string strQuestionID;
                strQuestionID = (string)System.Web.HttpContext.Current.Session["QuestionID"];
                if (strQuestionID == null)
                {
                    strQuestionID = "";
                }
                return strQuestionID;
            }
            set
            {
                string strQuestionID = value;
                System.Web.HttpContext.Current.Session.Add("QuestionID", strQuestionID);
            }
        }
        public static string Score
        {
            get
            {
                string strScore;
                strScore = (string)System.Web.HttpContext.Current.Session["Score"];
                if (strScore == null)
                {
                    strScore = "";
                }
                return strScore;
            }
            set
            {
                string strScore = value;
                System.Web.HttpContext.Current.Session.Add("Score", strScore);
            }
        }

        public static string AnswerID
        {
            get
            {
                string strAnswerID;
                strAnswerID = (string)System.Web.HttpContext.Current.Session["AnswerID"];
                if (strAnswerID == null)
                {
                    strAnswerID = "";
                }
                return strAnswerID;
            }
            set
            {
                string strAnswerID = value;
                System.Web.HttpContext.Current.Session.Add("AnswerID", strAnswerID);
            }
        }
        public static string PubClassCaseTypeID
        {
            get
            {
                string strPubClassCaseTypeID;
                strPubClassCaseTypeID = (string)System.Web.HttpContext.Current.Session["PubClassCaseTypeID"];
                if (strPubClassCaseTypeID == null)
                {
                    strPubClassCaseTypeID = "";
                }
                return strPubClassCaseTypeID;
            }
            set
            {
                string strPubClassCaseTypeID = value;
                System.Web.HttpContext.Current.Session.Add("PubClassCaseTypeID", strPubClassCaseTypeID);
            }
        }
        /// <summary>
        ///记录章节名
        /// </summary>
        public static string ChapterName
        {
            get
            {
                string strChapterName;
                strChapterName = (string)System.Web.HttpContext.Current.Session["ChapterName"];
                if (strChapterName == null)
                {
                    strChapterName = "";
                }
                return strChapterName;
            }
            set
            {
                string strChapterName = value;
                System.Web.HttpContext.Current.Session.Add("ChapterName", strChapterName);
            }
        }
        /// <summary>
        ///记录章节ID
        /// </summary>
        public static string ChapterID
        {
            get
            {
                string strChapterID;
                strChapterID = (string)System.Web.HttpContext.Current.Session["ChapterID"];
                if (strChapterID == null)
                {
                    strChapterID = "";
                }
                return strChapterID;
            }
            set
            {
                string strChapterID = value;
                System.Web.HttpContext.Current.Session.Add("ChapterID", strChapterID);
            }
        }
        public static string FreeSenateID
        {
            get
            {
                string strFreeSenateID;
                strFreeSenateID = (string)System.Web.HttpContext.Current.Session["FreeSenateID"];
                if (strFreeSenateID == null)
                {
                    strFreeSenateID = "";
                }
                return strFreeSenateID;
            }
            set
            {
                string strFreeSenateID = value;
                System.Web.HttpContext.Current.Session.Add("FreeSenateID", strFreeSenateID);
            }
        }
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

        public static string RoleName
        {
            get
            {
                string strRoleName;
                strRoleName = (string)System.Web.HttpContext.Current.Session["RoleName"];
                if (strRoleName == null)
                {
                    strRoleName = "";
                }
                return strRoleName;
            }
            set
            {
                string strRoleName = value;
                System.Web.HttpContext.Current.Session.Add("RoleName", strRoleName);
            }
        }
        public static string ValidateCode
        {
            get
            {
                string strValidateCode;
                strValidateCode = (string)System.Web.HttpContext.Current.Session["ValidateCode"];
                if (strValidateCode == null)
                {
                    strValidateCode = "";
                }
                return strValidateCode;
            }
            set
            {
                string strValidateCode = value;
                System.Web.HttpContext.Current.Session.Add("ValidateCode", strValidateCode);
            }
        }

        public static string UserPrjId
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserPrjId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["UserPrjId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("UserPrjId", value);

            }

        }
        public static string UserPrjId4get
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserPrjId"] != null)
                {
                    return System.Web.HttpContext.Current.Session["UserPrjId"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("UserPrjId", value);

            }
        }
    }
}
