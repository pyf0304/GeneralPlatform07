using com.taishsoft.common;
using com.taishsoft.encrypt;
using CommFunc4Web.CommFunc4WebForm;
using CommFunc4WebForm;
using CoversManage.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace EduHigh
{
    /// <summary>
    /// clsPubVar 的摘要说明
    /// </summary>
    public class clsPubVar
    {
        //public clsPubVar()
        //{
        //    //
        //    // TODO: 在此处添加构造函数逻辑
        //    //
        //}
        //        public static TzGeneralPlatformDll2.MenuAndPotence objMenuAndPotence = null;// (clsSysParaEN.ConfigFileName)
        public static clsLog objLog = new clsLog();// null;
        public static clsLog objLog4SilverLight = new clsLog();// null;
        public static GeneralPlatform4WS.MenuAndPotence objMenuAndPotence = null;// (clsSysPara.ConfigFileName)

        public static string strCurrPrjId = "0150";
        public static string strCurrPrjId4AgcCs = "0042";
        public static bool bolIsNeedLoadFile = true;
        public static List<string> arrIsBinded = null;
        private static string mstrBrowserInfo;//浏览器信息
        public static string BrowserInfo
        {
            get { return clsPubVar.mstrBrowserInfo; }
            set { clsPubVar.mstrBrowserInfo = value; }
        }
        public static clsCommonSession objCommonSession = null; //new clsCommonSession();
        public static bool bolIsDeleteUserGroup = true;//是否去除用户分组,即教师针对学生不分组,教师可以为每个学生打分；
       

        ///// <summary>
        ///// 用户统一平台的WEB地址
        ///// </summary>
        //public static string G~eneralPlatform
        //{
        //    get
        //    {
        //        return ConfigurationSettings.AppSettings["G~eneralPlatform"].ToString();
        //    }
        //}

      
        private static string mstrUploadTempPath;
        /// <summary>
        /// 临时的上传路径
        /// </summary>
        public static string UploadTempPath
        {
            get
            {
                return mstrUploadTempPath;
            }
            set
            {
                mstrUploadTempPath = value;
                clsPubVar.objLog.WriteDebugLog(string.Format("UploadTempPath=[{0}]", value));
            }
        }
        /// <summary>
        /// 获取打开统一平台中用户管理的脚本代码
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPageName">页面名称</param>
        /// <returns></returns>
        //public static string GetGPLoginScript(string strUserId, string strPageName)
        //{
        //    string strScript = string.Empty;
        //    string strKey = clsEncrypt.MD5(strUserId + "gpintegration");
        //    strKey = strKey.ToUpper();
        //    //http://202.121.49.7/webapps/login/
        //    //            c1 = "<script language='javascript'>window.open('http://202.121.63.10/GeneralPlatformTZ/quick_index.aspx?userid=" + strUserId + "&key=" + strKey + "'); </script>";
        //    //strScript = string.Format("<script language='javascript'>window.open('http://202.121.63.26/GeneralPlatform/index_quick.aspx?userid={0}&key={1}&PageName={2}'); </script>", strUserId, strKey, strPageName);
        //    strScript = string.Format("<script language='javascript'>window.open('{3}/index_quick.aspx?userid={0}&key={1}&PageName={2}'); </script>", strUserId, strKey, strPageName, clsSysParaEN.spGeneralPlatform);
        //    return strScript;
        //}

      

        public static int intRecCount = 0;

      
        public static void Logout()
        {

            string strHomePage = "index.htm";
            string strVirtualRoot = clsPubVar.GetVirtualRoot();
            string strHomePage_Absolute = strVirtualRoot + "/" + strHomePage;
            StringBuilder sbJS = new StringBuilder();
            sbJS.AppendFormat("<script language='javascript'>window.parent.location.href='{0}'; </script>", strHomePage_Absolute);
            System.Web.HttpContext.Current.Session.Clear();
            System.Web.HttpContext.Current.Response.Write(sbJS.ToString());

        }
        public static void Logout(Page myPage)
        {
            string strHomePage = "index.htm";
            string strVirtualRoot = clsPubVar.GetVirtualRoot();
            string strHomePage_Absolute = strVirtualRoot + "/" + strHomePage;
            StringBuilder sbJS = new StringBuilder();
            sbJS.AppendFormat("<script language='javascript'>window.parent.location.href='{0}'; </script>", strHomePage_Absolute);
            myPage.Session.Clear();
            myPage.Response.Write(sbJS.ToString());

          
        }
   
        public static string GetVirtualRoot(Page myPage)
        {

            string strApp1 = myPage.Request.ApplicationPath;
            return strApp1;

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
        /// 初始化需要导出的Excel文件
        /// </summary>
        /// <param name="thisPage">当前页面对象</param>
        /// <param name="strFolderName">下载路径</param>
        /// <param name="strDownLoadFileName">下载文件名</param>
        /// <returns>是否成功</returns>
        public static bool InitExcelFile(Page thisPage, string strFolderName, string strDownLoadFileName)
        {

            if (string.IsNullOrEmpty(strFolderName) == true)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("目录变量:strFolderName为空,请联系管理员！"));
                return false;
            }

            if (string.IsNullOrEmpty(strDownLoadFileName) == true)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("目录变量:strDownLoadFileName为空,请联系管理员！"));
                return false;
            }
            
            if (Directory.Exists(strFolderName) == false)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("目录:{0}不存在,请检查！", strFolderName));
                return false;
            }
            string strSamXlsFile = strFolderName + clsMyConfig.SamXlsFileName;
            if (File.Exists(strSamXlsFile) == false)
            {
                clsCommonJsFunc.Alert(thisPage, string.Format("Excel导出样例文件:{0}不存在,请检查！", strSamXlsFile));
                return false;
            }
            if (File.Exists(strDownLoadFileName) == true)
            {
                File.Delete(strDownLoadFileName);
            }

            File.Copy(strSamXlsFile, strDownLoadFileName);
            return true;
        }
        /// <summary>
        /// 浏览器的类型
        /// </summary>
        public static string BrowserType
        {
            get
            {
                System.Web.HttpBrowserCapabilities browser = System.Web.HttpContext.Current.Request.Browser;
                return browser.Type;
                //System.Web.HttpBrowserCapabilities browser = Request.Browser;
                //string s = "Browser Capabilities<br />" +
                //"Type = " + browser.Type + "<br />" +
                //"Name = " + browser.Browser + "<br />" +
                //"Version = " + browser.Version + "<br />" +
                //"XzMajor Version = " + browser.MajorVersion + "<br />" +
                //"Minor Version = " + browser.MinorVersion + "<br />" +
                //"Platform = " + browser.Platform + "<br />" +
                //"Is Beta = " + browser.Beta + "<br />" +
                //"Is Crawler = " + browser.Crawler + "<br />" +
                //"Is AOL = " + browser.AOL + "<br />" +
                //"Is Win16 = " + browser.Win16 + "<br />" +
                //"Is Win32 = " + browser.Win32 + "<br />" +
                //"Supports Frames = " + browser.Frames + "<br />" +
                //"Supports Tables = " + browser.Tables + "<br />" +
                //"Supports Cookies = " + browser.Cookies + "<br />" +
                //"Supports VBScript = " + browser.VBScript + "<br />" +
                //"Supports JavaScript = " + browser.EcmaScriptVersion.ToString() + "<br />" +
                //"Supports Java Applets = " + browser.JavaApplets + "<br />" +
                //"Supports ActiveX Controls = " + browser.ActiveXControls + "<br />";
                //Response.Write(s);
            }
        }
        /// <summary>
        /// 浏览器的名称
        /// </summary>
        public static string BrowserName
        {
            get
            {
                System.Web.HttpBrowserCapabilities browser = System.Web.HttpContext.Current.Request.Browser;
                return browser.Browser;
                //System.Web.HttpBrowserCapabilities browser = Request.Browser;
                //string s = "Browser Capabilities<br />" +
                //"Type = " + browser.Type + "<br />" +
                //"Name = " + browser.Browser + "<br />" +
                //"Version = " + browser.Version + "<br />" +
                //"XzMajor Version = " + browser.MajorVersion + "<br />" +
                //"Minor Version = " + browser.MinorVersion + "<br />" +
                //"Platform = " + browser.Platform + "<br />" +
                //"Is Beta = " + browser.Beta + "<br />" +
                //"Is Crawler = " + browser.Crawler + "<br />" +
                //"Is AOL = " + browser.AOL + "<br />" +
                //"Is Win16 = " + browser.Win16 + "<br />" +
                //"Is Win32 = " + browser.Win32 + "<br />" +
                //"Supports Frames = " + browser.Frames + "<br />" +
                //"Supports Tables = " + browser.Tables + "<br />" +
                //"Supports Cookies = " + browser.Cookies + "<br />" +
                //"Supports VBScript = " + browser.VBScript + "<br />" +
                //"Supports JavaScript = " + browser.EcmaScriptVersion.ToString() + "<br />" +
                //"Supports Java Applets = " + browser.JavaApplets + "<br />" +
                //"Supports ActiveX Controls = " + browser.ActiveXControls + "<br />";
                //Response.Write(s);
            }
        }

        /// <summary>
        /// 浏览器的名称
        /// </summary>
        public static bool IsSupportsHtml5Bak
        {
            get
            {
                System.Web.HttpBrowserCapabilities httpBrowserCapabilities = System.Web.HttpContext.Current.Request.Browser;
                if (httpBrowserCapabilities.Browser == "IE" )
                {
                    if (httpBrowserCapabilities.MajorVersion >= 9) return true;
                    else return false;
                }
                else if (httpBrowserCapabilities.Browser == "Safari")
                {
                    return true;
                }
                else if (httpBrowserCapabilities.Browser == "Chrome")
                {
                    return true;
                }
                else
                {
                    return true;
                }

                //System.Web.HttpBrowserCapabilities browser = Request.Browser;
                //string s = "Browser Capabilities<br />" +
                //"Type = " + browser.Type + "<br />" +
                //"Name = " + browser.Browser + "<br />" +
                //"Version = " + browser.Version + "<br />" +
                //"XzMajor Version = " + browser.MajorVersion + "<br />" +
                //"Minor Version = " + browser.MinorVersion + "<br />" +
                //"Platform = " + browser.Platform + "<br />" +
                //"Is Beta = " + browser.Beta + "<br />" +
                //"Is Crawler = " + browser.Crawler + "<br />" +
                //"Is AOL = " + browser.AOL + "<br />" +
                //"Is Win16 = " + browser.Win16 + "<br />" +
                //"Is Win32 = " + browser.Win32 + "<br />" +
                //"Supports Frames = " + browser.Frames + "<br />" +
                //"Supports Tables = " + browser.Tables + "<br />" +
                //"Supports Cookies = " + browser.Cookies + "<br />" +
                //"Supports VBScript = " + browser.VBScript + "<br />" +
                //"Supports JavaScript = " + browser.EcmaScriptVersion.ToString() + "<br />" +
                //"Supports Java Applets = " + browser.JavaApplets + "<br />" +
                //"Supports ActiveX Controls = " + browser.ActiveXControls + "<br />";
                //Response.Write(s);
            }
        }
        //public static clsBrowserTypeEN getBrowserTypeObj()
        //{
        //    string strBrowserInfo = clsCommonSession.BrowserInfo;
        //    clsPubVar.objLog.WriteDebugLog("strBrowserInfo:" + strBrowserInfo);

        //    clsBrowserTypeEN objBrowseTypeEN = clsBrowserTypeBL.getBrowserTypeObjByBrowserInfo(strBrowserInfo);
        //    return objBrowseTypeEN;
        //}
        /// <summary>
        /// 是否用SilverLight来播放mp4
        /// </summary>
        /// <returns></returns>
        public static bool IsUseSilverLightPlay4Mp4()
        {
            bool bolIsUseSilverLightPlay4Mp4 = true;//默认为True
            string strBrowserInfo = clsCommonSession.BrowserInfo;
            clsPubVar.objLog.WriteDebugLog("strBrowserInfo:" + strBrowserInfo);

            //clsBrowserTypeEN objBrowserTypeEN = clsBrowserTypeBL.getBrowserTypeObjByBrowserInfo(strBrowserInfo);
            //if (objBrowserTypeEN != null && objBrowserTypeEN.OsObject == "Chrome")
            //{
            //    bolIsUseSilverLightPlay4Mp4 = false;
            //}
            //if (objBrowserTypeEN != null && objBrowserTypeEN.OsObject == "Safari")
            //{
            //    bolIsUseSilverLightPlay4Mp4 = false;
            //}
            return bolIsUseSilverLightPlay4Mp4;
        }

        /// <summary>
        /// 是否支持HTML5
        /// </summary>
        public static bool IsSupportsHtml5
        {
            get
            {
                string strBrowserInfo = clsCommonSession.BrowserInfo;
                string[] ssBrowserInfo = strBrowserInfo.Split('|');

                if (ssBrowserInfo[0] == "MSIE")
                {
                    float fltVersion = float.Parse(ssBrowserInfo[1]);
                    if (fltVersion == 10.0)
                    {
                        clsSysParaEN.bolIsSupportsHtml5 = false;
                        return false;
                    }
                    if (fltVersion >= 11.0)
                    {
                        clsSysParaEN.bolIsSupportsHtml5 = false;
                        return false;
                    }
                    else return false;
                }
                else if (ssBrowserInfo[0] == "Safari")
                {
                    clsSysParaEN.bolIsSupportsHtml5 = true;
                    return true;
                }
                else if (ssBrowserInfo[0] == "Chrome")
                {
                    clsSysParaEN.bolIsSupportsHtml5 = true; 
                    return true;
                }
                else
                {
                    clsSysParaEN.bolIsSupportsHtml5 = false;
                    return false;
                }

               
            }
        }

        /// <summary>
        /// 是否支持HTML5
        /// </summary>
        public static bool IsSupportsWmv
        {
            get
            {
                string strBrowserInfo = clsCommonSession.BrowserInfo;
                string[] ssBrowserInfo = strBrowserInfo.Split('|');

                if (ssBrowserInfo[0] == "MSIE")
                {
                    return true;
                }
                else if (ssBrowserInfo[0] == "Safari")
                {
                    return false;
                }
                else if (ssBrowserInfo[0] == "Chrome")
                {
                    return false;
                }
                else
                {
                    return false;
                }


            }
        }


    }
}

    