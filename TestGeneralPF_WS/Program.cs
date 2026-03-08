using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestGeneralPF_WS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            GeneralPlatform4WS.clsSysPara4WS.bolIsLocalHost = false;
            //GeneralPlatform4WS.clsSysPara.strCurrIPAddressAndPort = "202.121.63.9";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_RSKH_WS";//"127.0.0.1";
            //GeneralPlatform4WS.clsSysPara.strCurrIPAddressAndPort = "202.121.48.247";//"127.0.0.1";
            //GeneralPlatform4WS.clsSysPara.strCurrPrx = "Jwc_GP_WS";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.9";//"127.0.0.1";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_SHZ_WS";//"127.0.0.1";

            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.41";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_StuDorm_WS";//"127.0.0.1";

            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.10";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.39";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "tstc.hytc.edu.cn";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "210.35.115.5";//"127.0.0.1";

            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_JH_WS";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_JSIE_WS";//"127.0.0.1";GP_JSIE_WS
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_EduHigh_WS_Hysf";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_EduHigh_WS";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GP_DH_WS";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.bolIsLocalHost = false;
            //GeneralPlatform4WS.clsSysPara4WS.bolIsLocalHost = true;
            //< add key = "CurrIPAddressAndPort" value = "211.144.85.77" />

            //< add key = "CurrPrx" value = "GP/WebSrv" />
            //  GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "tstc.hytc.edu.cn";//"127.0.0.1";
            //            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "211.144.85.77";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "101.251.68.133";//"127.0.0.1";

            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GPJsie/WebSrv";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrPrx = "GPEfz/WebSrv";//"127.0.0.1";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "211.144.85.77";//"127.0.0.1";
            //GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort = "202.121.63.42";//"127.0.0.1";
            GeneralPlatform4WS.clsSysPara4WS.strCurrIPAddressAndPort_Local = "localhost/GP/WebSrv";//"127.0.0.1";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
