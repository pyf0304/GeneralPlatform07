using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GeneralPlatformWS
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
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