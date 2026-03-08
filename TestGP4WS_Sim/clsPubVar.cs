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
using System.Text;

namespace GeneralPlatform
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
        public static string strPrjId = "0040";//当前工程ID
        

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