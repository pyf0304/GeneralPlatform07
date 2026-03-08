using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceLogin;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 
    /// </summary>
    public class clsLoginWS
    {

        private static LoginServiceSoapClient objLoginServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static LoginServiceSoapClient GetLoginServiceSoapClient()
        {
            if (objLoginServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "LoginServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/LoginService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/LoginService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/LoginService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/LoginService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new LoginServiceSoapClient(binding, address);
            }
            else
            {
                return objLoginServiceSoapClient;
            }
        }
        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <returns>是否成功？</returns>
        public static bool UserLogin(string strUserId, string strPassword)
        {
            //检测记录是否存在
            LoginServiceSoapClient objLoginService = null;
            try
            {
                objLoginService = GetLoginServiceSoapClient();
            }
            catch (Exception objException)
            {
                string strMsg =string .Format( "获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
                     objException.Message,
                     clsSysPara.strCurrPrx,
                     clsSysPara.strCurrIPAddressAndPort);
                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            bool bolIsSuccess = false;
            try
            {
                bolIsSuccess = objLoginService.UserLogin(strUserId, strPassword);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("用户登录（UserLogin）有问题。{0}. clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                     objException.Message,
                     clsSysPara.strCurrIPAddressAndPort,
                     clsSysPara.strCurrPrx);
                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            return bolIsSuccess;
        }
        /// <summary>
        /// 根据用户登录名获取用户Id
        /// </summary>
        /// <param name="strLoginName">用户登录名</param>        
        /// <returns>返回strUserId</returns>

        public static string GetUserIdByLoginName(string strLoginName)
        {
            LoginServiceSoapClient objLoginService = GetLoginServiceSoapClient();

            string strUserId = objLoginService.GetUserIdByLoginName(strLoginName);

            return strUserId;

        }
    }
}
