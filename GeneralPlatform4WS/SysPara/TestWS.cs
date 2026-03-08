
/*-- -- -- -- -- -- -- -- -- -- --
类名:TestWS
生成代码版本:2017.07.08.1
生成日期:2017/07/29 16:24:00
生成者:潘以锋
生成服务器IP:192.168.1.3
工程名称:统一平台
工程ID:0014
模块中文名:系统参数
模块英文名:SysPara
框架-层名:Web服务转换层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.07.14.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceTest;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// TestWS
    /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode4SpecialWs)
    /// </summary>
    public class TestWS
    {
        private static string mstrPageName = "Test.asmx";
        private static string mstrDir = "0";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode4SpecialWs)
        /// </summary>
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode4SpecialWs)
        /// </summary>
        protected static int intFindFailCount = 0;
        private static TestSoapClient objTestSoapClient = null;
        /// <summary>
        /// 
        /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode4SpecialWs)
        /// </summary>
        /// <returns></returns>
        public static TestSoapClient GetTestSoapClient()
        {
            if (objTestSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "TestWSServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new TestSoapClient(binding, address);
            }
            else
            {
                return objTestSoapClient;
            }
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strUserName">strUserName</param>
        /// <returns>返回</returns>
        public static string HelloWorldWs(string strUserName)
        {
            TestSoapClient objTestService = GetTestSoapClient();
            try
            {
                string strTemp = objTestService.HelloWorld(strUserName);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "HelloWorld", "TestWS:HelloWorldWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strUserName">strUserName</param>
        /// <param name = "strReturnValue">引用型参数,返回:strReturnValue</param>
        /// <returns>返回</returns>
        public static string HelloWorld2Ws(string strUserName, ref string strReturnValue)
        {
            TestSoapClient objTestService = GetTestSoapClient();
            try
            {
                string strTemp = objTestService.HelloWorld2(strUserName, ref strReturnValue);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "HelloWorld2", "TestWS:HelloWorld2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "a">a</param>
        /// <param name = "b">b</param>
        /// <returns>返回</returns>
        public static int myAddWs(int a, int b)
        {
            TestSoapClient objTestService = GetTestSoapClient();
            try
            {
                int intTemp = objTestService.myAdd(a, b);
                return intTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "myAdd", "TestWS:myAddWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取Web服务的地址
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetServiceUrl(string strPageName, ref string strDir)
        {
            String strServiceUrl = String.Empty;
            if (strDir == "0")
            {
                strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);
            }
            if (clsSysPara4WS.bolIsLocalHost == false)
            {
                if (string.IsNullOrEmpty(strDir) == true)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}",
                    clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strPageName);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}/{3}",
                    clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strDir, strPageName);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(strDir) == true)
                {
                    strServiceUrl = String.Format("http://{0}/{1}",
                    clsSysPara4WS.strCurrIPAddressAndPort_Local,
                    strPageName);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}",
                    clsSysPara4WS.strCurrIPAddressAndPort_Local, strDir, strPageName);
                }
            }
            return strServiceUrl;
        }
    }
}