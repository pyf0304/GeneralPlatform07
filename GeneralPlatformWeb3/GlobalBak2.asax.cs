using com.taishsoft.common;
using com.taishsoft.syspara;
using CommonTable.Entity;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Webform;
using GeneralPlatform.WebSrv;
using System;

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

            clsPubVar.objLog.LogDir = clsMyConfig.LogDir4Debug;
            clsPubVar.objLog.LogFileName = @"Log4Dubug_Web";

            clsPubVar_WS.objLog.LogDir = clsMyConfig.LogDir4Debug_WS;
            clsPubVar_WS.objLog.LogFileName = @"Log4Dubug_WS";


            // 在应用程序启动时运行的代码
            string strCurrVirtualRoot = @"~";
            //SpecData.clsSpecSQL.strWebRoot = @"~\ConnStr\";
            //SpecData.clsSpecSQL.strWebRoot = strCurrVirtualRoot + @"\ConnStr\";
            //com.taishsoft.commdb.clsSpecSQLforSql.strWebRoot = strCurrVirtualRoot + @"\ConnStr\";
            com.taishsoft.commdb.clsSpecSQLforSql.strWebRoot = @"~/ConnStr/";
            SpecData.clsSpecSQL.strWebRoot = "~/ConnStr/";
            clsSysParaEN.strUserType = System.Configuration.ConfigurationManager.AppSettings["UserType"].ToString();
            clsSysParaEN.strXMLFolder = strCurrVirtualRoot + @"\XML\";
            
            clsSysParaEN.strTempXMLFileName = Server.MapPath(clsSysParaEN.strXMLFolder) + "temp.xml";

            clsSysParaEN.TempWebFolder = strCurrVirtualRoot + @"\TempFiles\";
            clsSysParaEN.ErrorPage = strCurrVirtualRoot + @"/Webform/ErrorMsg.aspx";
            clsSysParaEN.SuccessPage = strCurrVirtualRoot + @"/Webform/success.aspx";

            clsSysParaEN.ConfigFileName = Server.MapPath(clsSysParaEN.strXMLFolder) + "TzGPDllCfg.xml";
            clsSysParaEN.FileSvrFileName = Server.MapPath(clsSysParaEN.strXMLFolder) + "FileSvrCfg.xml";
            clsSysParaEN.strXMLFileName = Server.MapPath(clsSysParaEN.strXMLFolder) + "XMLSP.xml";
            clsSysParaEN.TempFileFolder = Server.MapPath(clsSysParaEN.TempWebFolder);
            //clsSysParaEN.strCompanyName = clsTSysParaBLEx.getCompanyName();


            clsSysParaEN.TempFileFolder = Server.MapPath(clsSysParaEN.TempWebFolder);
            AGC_CSV74WS.clsSysPara4WS.strCurrIPAddressAndPort = "101.251.68.133";
            AGC_CSV74WS.clsSysPara4WS.strCurrPrx = "AGC_CSv6/WebService";
            clsPubFun4BLEx.SetCommFun4BL();
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