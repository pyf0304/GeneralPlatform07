using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using com.taishsoft.commdb;
using com.taishsoft.encrypt;
using System.Web.SessionState;
using GeneralPlatform;
using System.Security.Cryptography;
//using System.Security.Cryptography.Xml;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using com.taishsoft.common;


using System.Collections.Generic;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// Login_WebApplications 的摘要说明。
    /// </summary>
    public partial class Index_quick : System.Web.UI.Page
    {
        //private string strnuid = "";
        //private string strmodule = "";
        private void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面


            if (!IsPostBack)
            {
                //UserId = "t01";
                //Key = "0a3597ba2700b5abe3ec0d0ba2c2b9c1";
                //this.strnuid = "1000000000shnuneusoft";
                //this.strmodule = "ky_kyxt";
                Judge4QuickLogin();
            }
        }

        //定义从东软传来的id
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
        //定义从东软传来的module
        private string qsKey
        {
            get
            {
                string strkey = Request.QueryString["key"] ?? "".ToString();
                if ((strkey != null) && (strkey != ""))
                {
                    return strkey;//Request.QueryString["key"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        private string qsQxPrjId
        {
            get
            {
                string strQxPrjId = Request.QueryString["QxPrjId"] ?? "".ToString();
                if ((strQxPrjId != null) && (strQxPrjId != ""))
                {
                    return strQxPrjId;//Request.QueryString["QxPrjId"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从东软传来的module
        private string qsPageName
        {
            get
            {
                string strPageName = Request.QueryString["PageName"] ?? "".ToString();
                if ((strPageName != null) && (strPageName != ""))
                {
                    return strPageName;//Request.QueryString["PageName"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        private string qsFunctionName
        {
            get
            {
                string strFunctionName = Request.QueryString["FunctionName"] ?? "".ToString();
                if ((strFunctionName != null) && (strFunctionName != ""))
                {
                    return strFunctionName;//Request.QueryString["FunctionName"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        //定义从东软传来的operate
        private string qsOperate
        {
            get
            {
                string strOperate = Request.QueryString["Operate"] ?? "".ToString();
                if ((strOperate != null) && (strOperate != ""))
                {
                    return strOperate;//Request.QueryString["Operate"] ?? "";
                }
                else
                {
                    return "";
                }
            }
        }
        

        public string ReplaceStr(string strReplace)
        {
            string strReplaceNu = strReplace.Substring(0, 10);
            //shnuneusoft
            string strReplaceWord = strReplace.Substring(10, 11);
            if (strReplaceWord == "shnuneusoft")
            {
                //是从东软传过来的
                return strReplaceNu;
            }
            else
            {
                //不是从东软传过来的,返回"" 跳转到错误页面
                return "";
            }
        }
        private bool Set_QxUserInfoToSession()
        {
            new clsCommonSession().ClearSession();
            //string strUserId = ReplaceStr(this.strnuid);// (this.NeusoftId);
            if (string .IsNullOrEmpty(qsUserId) == false)
            {
                clsCommonSession.UserId = qsUserId;//this.txtUserId.Text.Trim();
                clsCommonSession.UserStateId = clsQxUsersBL.GetObjByUserIdCache(qsUserId).UserStateId;
                string strCondition = string.Format("{0}='{1}' And {2}='{3}' ",
                    conQxUserRoleRelation.QxPrjId, qsQxPrjId,
                    conQxUserRoleRelation.UserId, qsUserId
                    );
                string strCondition2 = string.Format("{0} in (select {0} From {1} where {2}) order by {3}",
                    conQxRoles.RoleId,
                    conQxUserRoleRelation._CurrTabName,
                    strCondition,
                    conQxRoles.RoleIndex);
                List<clsQxRolesEN> arrQxUserRolesObjLst = clsQxRolesBL.GetObjLst(strCondition2);
                if (arrQxUserRolesObjLst.Count ==0)
                {
                    string strMsg = string.Format("条件记录为空！在表: [{0}] 中，条件: [{1}] 。({2})",
                        conQxUserRoleRelation._CurrTabName, strCondition,
                        clsStackTrace.GetCurrClassFunction());
                    clsPubVar.objLog.WriteDebugLog(strMsg);
                    //throw new Exception(strMsg);
                    clsCommonSession.ErrMessage = strMsg;
                    Response.Redirect(clsSysParaEN.ErrorPage);
                }
                clsCommonSession.RoleId = arrQxUserRolesObjLst[0].RoleId;
                return true;
            }
            else
            {
                // 返回false 跳转到错误页面
                return false;
            }
        }
        //静态的处理错误日志的函数
        private void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }


        protected void ibLogin_Click(object sender, ImageClickEventArgs e)
        {
        }
        /// <summary>
        /// MD5加密函数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public  string MD5(String str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(data);
            String ret = "";
            for (int i = 0; i < result.Length; i++)
                ret += result[i].ToString("x").PadLeft(2, '0');
            return ret;
        } 
        //判断是否是东软统一平台过来的链接
        private void Judge4QuickLogin()
        {
            //clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strMsg = string.Format("开始进入，用户Id={0}; Key={2}; Operate={3}.({1})", 
                qsUserId, clsStackTrace.GetCurrClassFunction(), qsKey, qsOperate);
            clsPubVar.objLog.WriteDebugLog(strMsg);

            string strCode = MD5(qsUserId + "gpintegration");
            if (strCode.Equals(qsKey, StringComparison.OrdinalIgnoreCase)==false)
            {
                clsCommonSession.ErrMessage = "登录信息不正确，请联系管理员！";
                Response.Redirect(clsSysParaEN.ErrorPage);
                return;
            }
            //判断是否来自东软的链接
            //if (this.strnuid != "" && this.strmodule != "")
            if (qsUserId != "" && this.qsKey != "")
            {
                    //添加系统登录成功的Session 
                if (Set_QxUserInfoToSession())
                {
                    if (string.IsNullOrEmpty(qsPageName) == false)
                    {
                        new clsCommonSession().UserSelPrjId = qsQxPrjId;
                        clsCommonSession.UserPrjId = qsQxPrjId;
                        string strHTML = qsPageName + string.Format("?UserId={0}&QxPrjId={2}&FunctionName={1}",
                            qsUserId, qsFunctionName, qsQxPrjId);
                        clsPubVar.objLog.WriteDebugLog(strHTML);
                        Response.Redirect(strHTML);
                    }
                    else
                    {
                        Response.Redirect("Webform/wfmSelectUserPrjAndRole_GeneralPlatform.aspx");
                    }
                }
                else
                {
                    Response.Redirect(clsSysParaEN.ErrorPage);
                }
                //JumpPages4Neusoft();
            }
            else
            {
                Response.Redirect("Index.aspx");             
                //Response.Redirect("wfmSelectRoles_WebApplications.aspx?UserPrjId=" + new clsCommonSession().UserPrjId);
        
            }
     
            strMsg = string.Format("结束，用户Id:{0}.({1})",
                qsUserId, clsStackTrace.GetCurrClassFunction());
            clsPubVar.objLog.WriteDebugLog(strMsg);
        }
    }
}
