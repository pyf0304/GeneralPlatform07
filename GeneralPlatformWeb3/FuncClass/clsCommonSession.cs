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
using GeneralPlatform;
using GeneralPlatform.Entity;

using System.Collections.Generic;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// Common 的摘要说明
    /// </summary>
    public class clsCommonSession : clsCommonSessionBase
    {
        public clsCommonSession()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public void ClearSession()
        {
            //ErrorInformationBL.AddInformation("clsCommonSession", "ClearSession " + IpAddress,
            //    "取消Session" + clsDateTime_Db.GetDataBaseDateTime14(), UserId);
            System.Web.HttpContext.Current.Session.Clear();
        }
        ///生成登录用户的用户名Session
        //public static string UserId
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

        public static string UserStateId
        {
            get
            {
                string strUserStateId;
                strUserStateId = (string)System.Web.HttpContext.Current.Session["UserStateId"];
                if (strUserStateId == null)
                {
                    strUserStateId = "";
                }
                return strUserStateId;
            }
            set
            {
                string strUserStateId = value;
                System.Web.HttpContext.Current.Session.Add("UserStateId", strUserStateId);
            }
        }
        
        //public string RoleId
        //{
        //    get
        //    {
        //        if (System.Web.HttpContext.Current.Session["RoleId"] != null)
        //        {
        //            return System.Web.HttpContext.Current.Session["RoleId"].ToString();
        //        }
        //        else
        //        {
        //            return "0";
        //        }
        //    }
        //    set
        //    {
        //        System.Web.HttpContext.Current.Session.Add("RoleId", value);

        //    }

        //}
        public string RoleId4CurrPrj
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["RoleId4CurrPrj"] != null)
                {
                    return System.Web.HttpContext.Current.Session["RoleId4CurrPrj"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("RoleId4CurrPrj", value);

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



        
        public string QxPrjId
        {
            get
            {
                string strPrjId;
                strPrjId = (string)System.Web.HttpContext.Current.Session[conQxProjects.QxPrjId];
                if (strPrjId == null)
                {
                    strPrjId = "";
                    clsCommForWebForm.CheckPrjId(strPrjId);
                }
                return strPrjId;
            }
            set
            {
                string strPrjId = value;
                System.Web.HttpContext.Current.Session.Add(conQxProjects.QxPrjId, strPrjId);
            }
        }
        
        public string UserSelPrjId//用户所选工程
        {
            get
            {
                string strUserSelPrjId;
                strUserSelPrjId = (string)System.Web.HttpContext.Current.Session["UserSelPrjId"];
                if (strUserSelPrjId == null)
                {
                    strUserSelPrjId = "";
                }
                return strUserSelPrjId;
            }
            set
            {
                string strUserSelPrjId = value;
                System.Web.HttpContext.Current.Session.Add("UserSelPrjId", strUserSelPrjId);
            }
        }

        public string ViewId
        {
            get
            {
                string strViewId;
                strViewId = (string)System.Web.HttpContext.Current.Session["ViewId"];
                if (strViewId == null)
                {
                    strViewId = "";
                }
                return strViewId;
            }
            set
            {
                string strViewId = value;
                System.Web.HttpContext.Current.Session.Add("ViewId", strViewId);
            }
        }
        /// <summary>
        /// 当前默认的数据库
        /// </summary>
        public string PrjMainDatabase
        {
            get
            {
                string strPrjMainDatabase;
                strPrjMainDatabase = (string)System.Web.HttpContext.Current.Session["PrjMainDatabase"];
                if (strPrjMainDatabase == null)
                {
                    strPrjMainDatabase = "";
                }
                return strPrjMainDatabase;
            }
            set
            {
                string strPrjMainDatabase = value;
                System.Web.HttpContext.Current.Session.Add("PrjMainDatabase", strPrjMainDatabase);
            }
        }

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
        public string TabId
        {
            get
            {
                string strTabId;
                strTabId = (string)System.Web.HttpContext.Current.Session["TabId"];
                if (strTabId == null)
                {
                    strTabId = "";
                }
                return strTabId;
            }
            set
            {
                string strTabId = value;
                System.Web.HttpContext.Current.Session.Add("TabId", strTabId);
            }
        }
        public string TabName
        {
            get
            {
                string strTabName;
                strTabName = (string)System.Web.HttpContext.Current.Session["TabName"];
                if (strTabName == null)
                {
                    strTabName = "";
                }
                return strTabName;
            }
            set
            {
                string strTabName = value;
                System.Web.HttpContext.Current.Session.Add("TabName", strTabName);
            }
        }
        public string TabCnName
        {
            get
            {
                string strTabCnName;
                strTabCnName = (string)System.Web.HttpContext.Current.Session["TabCnName"];
                if (strTabCnName == null)
                {
                    strTabCnName = "";
                }
                return strTabCnName;
            }
            set
            {
                string strTabCnName = value;
                System.Web.HttpContext.Current.Session.Add("TabCnName", strTabCnName);
            }
        }
        public string SqlDsTypeId
        {
            get
            {
                string strSqlDsTypeId;
                strSqlDsTypeId = (string)System.Web.HttpContext.Current.Session["SqlDsTypeId"];
                if (strSqlDsTypeId == null)
                {
                    strSqlDsTypeId = "";
                }
                return strSqlDsTypeId;
            }
            set
            {
                string strSqlDsTypeId = value;
                System.Web.HttpContext.Current.Session.Add("SqlDsTypeId", strSqlDsTypeId);
            }
        }
        /// <summary>
        /// 当前结点Id
        /// </summary>
        public string CurrNodeId
        {
            get
            {
                string strCurrNodeId;
                strCurrNodeId = (string)System.Web.HttpContext.Current.Session["CurrNodeId"];
                if (strCurrNodeId == null)
                {
                    strCurrNodeId = "";
                }
                return strCurrNodeId;
            }
            set
            {
                string strCurrNodeId = value;
                System.Web.HttpContext.Current.Session.Add("CurrNodeId", strCurrNodeId);
            }
        }
        /// <summary>
        /// 当前结点Id
        /// </summary>
        public string CurrRoleNodeId
        {
            get
            {
                string strCurrRoleNodeId;
                strCurrRoleNodeId = (string)System.Web.HttpContext.Current.Session["CurrRoleNodeId"];
                if (strCurrRoleNodeId == null)
                {
                    strCurrRoleNodeId = "";
                }
                return strCurrRoleNodeId;
            }
            set
            {
                string strCurrRoleNodeId = value;
                System.Web.HttpContext.Current.Session.Add("CurrRoleNodeId", strCurrRoleNodeId);
            }
        }
        //操作类型:主要指添加(ADD)还是修改(UPDATE)
        public string OperateType
        {
            get
            {
                string strOperateType;
                strOperateType = (string)System.Web.HttpContext.Current.Session["OperateType"];
                if (strOperateType == null)
                {
                    strOperateType = "";
                }
                return strOperateType;
            }
            set
            {
                string strOperateType = value;
                System.Web.HttpContext.Current.Session.Add("OperateType", strOperateType);
            }
        }
        ///父页面:是指一个页面,来调用另一个页面,用来添加(ADD)或者修改(UPDATE)
        ///     在父页面调用子页面调用该Session属性,以便子页面知道是哪一个页面来调用它.
        public static string ParentPage
        {
            get
            {
                string strParentPage;
                strParentPage = (string)System.Web.HttpContext.Current.Session["ParentPage"];
                if (strParentPage == null)
                {
                    strParentPage = "";
                }
                return strParentPage;
            }
            set
            {
                string strParentPage = value;
                System.Web.HttpContext.Current.Session.Add("ParentPage", strParentPage);
            }
        }


        public string BackErrPageEditFldLinkStr
        {
            get
            {
                string strBackErrPageEditFldLinkStr;
                strBackErrPageEditFldLinkStr = (string)System.Web.HttpContext.Current.Session["BackErrPageEditFldLinkStr"];
                if (strBackErrPageEditFldLinkStr == null)
                {
                    strBackErrPageEditFldLinkStr = "";
                }
                return strBackErrPageEditFldLinkStr;
            }
            set
            {
                string strBackErrPageEditFldLinkStr = value;
                System.Web.HttpContext.Current.Session.Add("BackErrPageEditFldLinkStr", strBackErrPageEditFldLinkStr);
            }
        }
        public string BackPageEditFldLinkStr
        {
            get
            {
                string strBackPageEditFldLinkStr;
                strBackPageEditFldLinkStr = (string)System.Web.HttpContext.Current.Session["BackPageEditFldLinkStr"];
                if (strBackPageEditFldLinkStr == null)
                {
                    strBackPageEditFldLinkStr = "";
                }
                return strBackPageEditFldLinkStr;
            }
            set
            {
                string strBackPageEditFldLinkStr = value;
                System.Web.HttpContext.Current.Session.Add("BackPageEditFldLinkStr", strBackPageEditFldLinkStr);
            }
        }
        //public string ErrMessage
        //{
        //    get
        //    {
        //        string strErrMessage;
        //        strErrMessage = (string)System.Web.HttpContext.Current.Session["ErrMessage"];
        //        if (strErrMessage == null)
        //        {
        //            strErrMessage = "";
        //        }
        //        return strErrMessage;
        //    }
        //    set
        //    {
        //        string strErrMessage = value;
        //        System.Web.HttpContext.Current.Session.Add("ErrMessage", strErrMessage);
        //    }
        //}
        /// <summary>
        /// 是否退出系统
        /// </summary>
        public string IsQuitSystem
        {
            get
            {
                string strIsQuitSystem;
                strIsQuitSystem = (string)System.Web.HttpContext.Current.Session["IsQuitSystem"];
                if (strIsQuitSystem == null)
                {
                    strIsQuitSystem = "";
                }
                return strIsQuitSystem;
            }
            set
            {
                string strIsQuitSystem = value;
                System.Web.HttpContext.Current.Session.Add("IsQuitSystem", strIsQuitSystem);
            }
        }
        public string BackErrPageLinkStr
        {
            get
            {
                string strBackErrPageLinkStr;
                strBackErrPageLinkStr = (string)System.Web.HttpContext.Current.Session["BackErrPageLinkStr"];
                if (strBackErrPageLinkStr == null)
                {
                    strBackErrPageLinkStr = "";
                }
                return strBackErrPageLinkStr;
            }
            set
            {
                string strBackErrPageLinkStr = value;
                System.Web.HttpContext.Current.Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
            }
        }

        /// <summary>
        /// 获取错误信息
        /// </summary>
        /// <param name="objException"></param>

        public void GetErrorMessage(Exception objException, string ErrorMessage)
        {

            ErrMessage = ErrorMessage + objException.Message;
            BackErrPageLinkStr = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            System.Web.HttpContext.Current.Response.Redirect(clsSysParaEN.ErrorPage);

        }
        /// <summary>
        /// 显示错误信息
        /// </summary>
        /// <param name="objException"></param>

        public void ShowErrorMessage(string strErrorMessage)
        {

            ErrMessage = strErrorMessage;
            BackErrPageLinkStr = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
            System.Web.HttpContext.Current.Response.Redirect(clsSysParaEN.ErrorPage);

        }
        ///页面名称
        //public string PageName
        //{
        //    get
        //    {
        //        string strPageName;
        //        strPageName = (string)System.Web.HttpContext.Current.Session["PageName"];
        //        if (strPageName == null)
        //        {
        //            strPageName = "";
        //        }
        //        return strPageName;
        //    }
        //    set
        //    {
        //        string strPageName = value;
        //        System.Web.HttpContext.Current.Session.Add("PageName", strPageName);
        //    }
        //}

        public static List<string> lstUserPotences
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UserPotences"] != null)
                {
                    return System.Web.HttpContext.Current.Session["UserPotences"] as List<string>;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                System.Web.HttpContext.Current.Session.Add("UserPotences", value);

            }

        }
        ///生成登录用户的用户名Session
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
    }
}
