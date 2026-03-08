using GeneralPlatform.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralPlatform.BusinessLogicEx
{
    public class clsQxUserRightsBLEx
    {

        /// <summary>
        /// 判断权限方式4，该方式比较好，速度快一点，不需要一次次地到服务器去判断,获取的是标志名称
        /// </summary>
        /// <param name="myPage">调用的页面</param>
        /// <param name="strRoleId">角色</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <returns>获取的标志名称</returns>
        public static string ValidPotenceMode4(string strRoleId, string strUserId, string strCurrPrjId, string strPotenceName)
        {

            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = "角色为空！";

                throw new Exception(strMsg);
            }

            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = "用户为空!";
                throw new Exception(strMsg);
            }
            List<string> lstAllSymbolName = new List<string>();

            List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName4CurrRoleId(strUserId, strPotenceName, strCurrPrjId, strRoleId);
            foreach (string strSymbolName in lstSymbolName)
            {
                if (lstAllSymbolName.Contains(strSymbolName) == false)
                {
                    lstAllSymbolName.Add(strSymbolName);
                }
            }
            
            if (lstAllSymbolName.Count == 0)
            {
                //string ss = clsArray.GetSqlInStrByArray(lstSymbolName, true);
                //clsCommonSession.ErrMessage = string .Format("你没有{0}的权限！", strPotenceName);
                ////无权限
                //myPage.Response.Redirect(clsSysParaEN.ErrorPage);
                return "";
            }
            if (lstAllSymbolName.Contains("校级") == true)
            {
                //lblMsg_List.Text = "有校级权限";
                return "校级";

            }
            else if (lstAllSymbolName.Contains("全校") == true)
            {
                return "全校";
            }
            else if (lstAllSymbolName.Contains("全部") == true)
            {
                return "全部";
            }
            else if (lstAllSymbolName.Contains("院级") == true)
            {
                return "院级";
            }
            else if (lstAllSymbolName.Contains("部门") == true)
            {
                return "部门";
            }
            else if (lstAllSymbolName.Contains("系") == true)
            {
                return "系";
            }
            else if (lstAllSymbolName.Contains("学院") == true)
            {
                return "学院";
            }
            else if (lstAllSymbolName.Contains("个人") == true)
            {
                return "个人";
            }
            else if (lstAllSymbolName.Contains("后台案例维护") == true)
            {
                return "后台案例维护";
            }
            else
            {
                //clsCommonSession.ErrMessage = "你没有权限！或者你的权限不正确，请与管理员联系！";
                //myPage.Response.Redirect(clsSysParaEN.ErrorPage);
                return "";
            }

        }

        /// <summary>
        /// 判断权限方式4，该方式比较好，速度快一点，不需要一次次地到服务器去判断,获取的是标志名称
        /// </summary>
        /// <param name="myPage">调用的页面</param>
        /// <param name="strRoleId">角色</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <returns>获取的标志名称</returns>
        public static string ValidPotenceMode4MultiRoles(string strCurrRoleId, string strUserId, string strCurrPrjId, string strRoleIdLstStr, string strPotenceName)
        {

            if (string.IsNullOrEmpty(strCurrRoleId) == true)
            {
                string strMsg = "角色为空！";

                throw new Exception(strMsg);
            }

            if (string.IsNullOrEmpty(strUserId) == true)
            {
                string strMsg = "用户为空!";
                throw new Exception(strMsg);
            }
            List<string> lstAllSymbolName = new List<string>();

            string[] strRoleIdLst = strRoleIdLstStr.Split(',');
            foreach (string strRoleId in strRoleIdLst)
            {
                List<string> lstSymbolName = clsQxUsersBLEx.GetSymbolNameLstByPotenceName4CurrRoleId(strUserId, strPotenceName, strCurrPrjId, strRoleId);
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
                //clsCommonSession.ErrMessage = string .Format("你没有{0}的权限！", strPotenceName);
                ////无权限
                //myPage.Response.Redirect(clsSysParaEN.ErrorPage);
                return "";
            }
            if (lstAllSymbolName.Contains("校级") == true)
            {
                //lblMsg_List.Text = "有校级权限";
                return "校级";

            }
            else if (lstAllSymbolName.Contains("全校") == true)
            {
                return "全校";
            }
            else if (lstAllSymbolName.Contains("全部") == true)
            {
                return "全部";
            }
            else if (lstAllSymbolName.Contains("院级") == true)
            {
                return "院级";
            }
            else if (lstAllSymbolName.Contains("部门") == true)
            {
                return "部门";
            }
            else if (lstAllSymbolName.Contains("学院") == true)
            {
                return "学院";
            }
            else if (lstAllSymbolName.Contains("个人") == true)
            {
                return "个人";
            }
            else if (lstAllSymbolName.Contains("后台案例维护") == true)
            {
                return "后台案例维护";
            }
            else if (lstAllSymbolName.Contains("全局级") == true)
            {
                return "全局级";
            }
            else if (lstAllSymbolName.Contains("项目级") == true)
            {
                return "项目级";
            }
            else
            {
                //clsCommonSession.ErrMessage = "你没有权限！或者你的权限不正确，请与管理员联系！";
                //myPage.Response.Redirect(clsSysParaEN.ErrorPage);
                return "";
            }

        }

    }
}
