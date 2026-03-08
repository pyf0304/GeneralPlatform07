using com.taishsoft.common;
using com.taishsoft.syspara;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GeneralPlatformWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            clsDebugBase_Sql.IsDebug = clsMyConfig.IsDebug4PubDatabase;
            clsDebugBase_Sql.LogDir4Debug = clsMyConfig.LogDir4Debug;
            clsDebugBase_Sql.LogFile4Debug = "Log4GP";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;
            // 在应用程序启动时运行的代码
            string strCurrVirtualRoot = @"~";
            SpecData.clsSpecSQL.strWebRoot = @"~\ConnStr\";
            SpecData.clsSpecSQL.strWebRoot = strCurrVirtualRoot + @"\ConnStr\";
            com.taishsoft.commdb.clsSpecSQLforSql.strWebRoot = strCurrVirtualRoot + @"\ConnStr\";

            clsSysParaEN.strUserType = System.Configuration.ConfigurationManager.AppSettings["UserType"].ToString();
            clsSysParaEN.strXMLFolder = strCurrVirtualRoot + @"\XML\";
            clsSysParaEN.TempWebFolder = strCurrVirtualRoot + @"\TempFiles\";
            clsSysParaEN.ErrorPage = strCurrVirtualRoot + @"/Webform/ErrorMsg.aspx";
            clsSysParaEN.SuccessPage = strCurrVirtualRoot + @"/Webform/success.aspx";

            clsSysParaEN.ConfigFileName = Server.MapPath(clsSysParaEN.strXMLFolder) + "TzGPDllCfg.xml";
            clsSysParaEN.FileSvrFileName = Server.MapPath(clsSysParaEN.strXMLFolder) + "FileSvrCfg.xml";
            clsSysParaEN.strXMLFileName = Server.MapPath(clsSysParaEN.strXMLFolder) + "XMLSP.xml";
            clsSysParaEN.TempFileFolder = Server.MapPath(clsSysParaEN.TempWebFolder);
            clsSysParaEN.strCompanyName = clsTSysParaBLEx.getCompanyName();


            GeneralPlatform.Entity.clsSysParaEN.TempFileFolder = Server.MapPath(GeneralPlatform.Entity.clsSysParaEN.TempWebFolder);
            AGCCS4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.10";
            AGCCS4WS.clsSysPara4WS.strCurrPrx = "AGCCS_WS";
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}