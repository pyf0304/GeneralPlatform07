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
            //            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "116.236.150.115";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.10";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_TH_WS";
          

            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.48.247";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "Jwc_GP_WS";

            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort2 = "202.121.48.246";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx2 = "Jwc_GP_WS";

            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort_Local = "LocalHost:9259";

            //    GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "210.35.112.3:8082";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "210.35.115.5";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_DH_WS";
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "tstc.hytc.edu.cn";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_EduHigh_WS";
            //http://180.153.158.158/GP/WebSrv/UsersService.asmx/Users_GetDataSet
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "180.153.158.158";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP/WebSrv";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.9";
            //          GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_RSKH_WS";

            //        <add key="CurrIPAddressAndPort" value="210.35.112.3" />
            //<add key="CurrPrx" value="GP_DH_WS" />
            //     <add key="CurrIPAddressAndPort" value="210.35.112.3" />
            //<add key="CurrPrx" value="GP_DH_WS" />
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