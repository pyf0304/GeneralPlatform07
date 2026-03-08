using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace TestGP4WS
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GeneralPlatform4WS.clsSysPara4WS.bolIsLocalHost = false;
           

            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.26";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_EduHigh_WS";

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