using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using com.taishsoft.syspara;
using com.taishsoft.common;

namespace GeneralPlatform_WS
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
            clsPubVar.objLog.LogDir = @"D:\Log4GP_WS\";
            clsPubVar.objLog.LogFileName = "DebugLog4GP";
             // 在应用程序启动时运行的代码
            com.taishsoft.commdb.clsSpecSQLforSql.IsUseEncrypt = false;
            com.taishsoft.commdb.clsSpecSQLforSql.strWebRoot = @"~\ConnStr\";
            com.taishsoft.commdbfororacle.clsSpecSQLforOra.strWebRoot = @"~\ConnStr\";
            com.taishsoft.commdb.clsSpecSQLforSql.WebConfigFileName = Server.MapPath(com.taishsoft.commdb.clsSpecSQLforSql.strWebRoot) + @"Web.Config";
        
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}