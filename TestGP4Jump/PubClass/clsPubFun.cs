using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;

using System.Collections;
using System.Text;
using CommFunc4WebForm;
using System.Diagnostics;
using System.IO;
using com.taishsoft.common;
using System.Data;
using com.taishsoft.file;

using com.taishsoft.datetime;

namespace EduHigh
{
    public static class clsPubFun
    {

        /// <summary>
        /// 判断权限方式4,该方式比较好,速度快一点,不需要一次次地到服务器去判断,获取的是标志名称
        /// </summary>
        /// <param name="myPage">调用的页面</param>
        /// <param name="strRoleId">角色</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <returns>获取的标志名称</returns>
        public static string ValidPotenceMode4(System.Web.UI.Page myPage, string strRoleIdLstStr, string strPotenceName)
        {

            if (string.IsNullOrEmpty(clsCommonSession.RoleId) == true)
            {
                string strMsg = "你没有登录,或者你登录时间太长,需要重新登录!";
                clsCommonJsFunc.ShowMessage(strMsg);
                //                 clsCommonJsFunc.Alert(this, strMsg);
                //string c1 = "<script language='javascript'>window.parent.location.href='/Index.aspx'; </script>";
                //Response1.Write(c1);
                //clsPubFun.Logout(myPage);
                return "";
            }

            if (string.IsNullOrEmpty(clsCommonSession.UserId) == true)
            {
                string strMsg = "你没有登录,或者你登录时间太长,需要重新登录!";
                clsCommonJsFunc.ShowMessage(strMsg);
                //                 clsCommonJsFunc.Alert(this, strMsg);
                //string c1 = "<script language='javascript'>window.parent.location.href='/Index.aspx'; </script>";
                //Response1.Write(c1);
                //clsPubFun.Logout(myPage);
                return "";
            }
            List<string> lstAllSymbolName = new List<string>();

            string[] strRoleIdLst = strRoleIdLstStr.Split(',');
            foreach (string strRoleId in strRoleIdLst)
            {
                List<string> lstSymbolName = GeneralPlatform4WS.clsQxUsersExWS.GetSymbolNameLstByPotenceName4CurrRoleId(clsCommonSession.UserId, strPotenceName, clsPubVar.strCurrPrjId, strRoleId);
                foreach (string strSymbolName in lstSymbolName)
                {
                    if (lstAllSymbolName.Contains(strSymbolName) == false)
                    {
                        lstAllSymbolName.Add(strSymbolName);
                    }
                }
            }
            if (lstAllSymbolName.Count == 0)
            {
                //string ss = clsArray.GetSqlInStrByArray(lstSymbolName, true);
                //clsCommonSession.seErrMessage = string .Format("你没有{0}的权限！", strPotenceName);
                ////无权限
                //myPage.Response.Redirect(clsSysParaEN.ErrorPage);
                return "";
            }
            if (lstAllSymbolName.Contains("全局") == true)
            {
                //lblMsg_List.Text = "有校级权限";
                return "全局";

            }
            else if (lstAllSymbolName.Contains("单位") == true)
            {
                return "单位";
            }
            else if (lstAllSymbolName.Contains("个人") == true)
            {
                return "个人";
            }
            else
            {
                //clsCommonSession.seErrMessage = "你没有权限！或者你的权限不正确,请与管理员联系！";
                //myPage.Response.Redirect(clsSysParaEN.ErrorPage);
                return "";
            }

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

        #region 根据用户ID，获取该用户的角色列表
        /// <summary>
        /// 根据用户ID，获取该用户的角色列表
        /// </summary>
        /// <param name="UserId">学号（教职工号）</param>
        /// <returns>数据间用,号隔开</returns>
        public static string GetQxRoleList(string UserId)
        {
            DataTable dtRole = new DataTable();
            if (!String.IsNullOrEmpty(UserId))
            {
                if (clsPubVar.objMenuAndPotence == null)
                {
                    clsPubVar.objMenuAndPotence = new GeneralPlatform4WS.MenuAndPotence();
                }
                List<string> lstRoleId = clsPubVar.objMenuAndPotence.Get_RoleIdList2(clsPubVar.strCurrPrjId, UserId);
                string strRoleIds = clsArray.GetSqlInStrByArray(lstRoleId, false);
                //                    return ConvertDataTableToString(dtRole);
                return strRoleIds;
            }
            return "";
        }
        #endregion


    }
}