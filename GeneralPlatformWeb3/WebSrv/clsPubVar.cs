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

using com.taishsoft.encrypt;
using System.Text;
using com.taishsoft.common;

namespace GeneralPlatform_WS
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar
    {
        public clsPubVar()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            
        }
        public static clsLog objLog = new clsLog();// null;
        public static string strPrjId = "0079";//当前工程ID

        //public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysParaEN.ConfigFileName)
      
        /// <summary>
        /// 获取登录BB的脚本代码
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns></returns>
        public static string GetGPLoginScript(string strUserId)
        {
            string c1 = string.Empty;
            string strKey = clsEncrypt.MD5(strUserId + "gpintegration");
            strKey = strKey.ToUpper();
            //http://202.121.49.7/webapps/login/
//            c1 = "<script language='javascript'>window.open('http://202.121.63.10/GeneralPlatformTZ/quick_index.aspx?userid=" + strUserId + "&key=" + strKey + "'); </script>";
            c1 = "<script language='javascript'>window.open('index_quick.aspx?userid=" + strUserId + "&key=" + strKey + "'); </script>";
            return c1;
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

        public static void Logout(Page myPage)
        {
            string strHomePage = "index.aspx";
            string strVirtualRoot = clsPubVar.GetVirtualRoot();
            string strHomePage_Absolute = strVirtualRoot + "/" + strHomePage;
            StringBuilder sbJS = new StringBuilder();
            sbJS.AppendFormat("<script language='javascript'>window.parent.location.href='{0}'; </script>", strHomePage_Absolute);
            myPage.Session.Clear();
            myPage.Response.Write(sbJS.ToString());
           
        }
    }
}