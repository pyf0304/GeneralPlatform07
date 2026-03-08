
using com.taishsoft.common;
using com.taishsoft.syspara;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using GeneralPlatform.WebApi;
using GeneralPlatform.Webform;
using GeneralPlatform.WebSrv;
using GP4WApi;
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
            //GlobalConfiguration.Configuration.Filters.Add(new WebApiExceptionFilterAttribute());

            //AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            clsDebugBase_Sql.IsDebug = clsMyConfig.IsDebug4PubDatabase;
            clsDebugBase_Sql.LogDir4Debug = clsMyConfig.LogDir4Debug;
            clsDebugBase_Sql.LogFile4Debug = "Log4GP";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;

            clsPubVar.objLog = new clsLog(clsMyConfig.LogDir4Debug, @"Log4Dubug_Web");

            clsSysParaEN.objLog = new clsLog( clsMyConfig.LogDir4Debug, @"Log4Dubug_SysPara");

            clsPubVar_WS.objLog = new clsLog(clsMyConfig.LogDir4Debug_WS, @"Log4Dubug_WS");
            clsPubVar_WebApi.objLog = new clsLog(clsMyConfig.LogDir4Debug, @"Log4Dubug_WebApi");

            clsPubVar.objLog.WriteDebugLog(clsDebugBase_Sql.LogDir4Debug);
            clsSysParaEN.objErrorLog = new clsLog(clsMyConfig.LogDir4Debug, @"Log4Error_SysPara");

            //clsPubVar.objLog.WriteDebugLog(clsPubVar_WS.objLog.LogDir);
            //clsPubVar.objLog.WriteDebugLog(clsPubVar.objLog.LogDir);
            //clsPubVar.objLog.WriteDebugLog(clsSysParaEN.objLog.LogDir);

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

            //clsSysPara4WebApi.strCurrIPAddressAndPort = "localhost:51147";
            clsSysPara4WebApi_GP.strCurrIPAddressAndPort = "103.116.76.183";
            //GeneralPlatform4WApi.clsSysPara4WebApi.strCurrPrx = "GPEfz";
            clsSysPara4WebApi_GP.strCurrPrx = "GP";

            //clsSysPara4WebApi.strCurrIPAddressAndPort = "localhost:49540";
            AGC4WApi.clsSysPara4WebApi_Agc.strCurrIPAddressAndPort = "103.116.76.183";
            AGC4WApi.clsSysPara4WebApi_Agc.strCurrPrx = "Agc";

            //clsSysPara4WebApi.strCurrPrx = "GPJsie";

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