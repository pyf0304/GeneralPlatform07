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
        /// 用主连接来获取Web服务客户端
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
                    strServiceUrl = String.Format("http://{0}/{1}/LoginService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
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
        /// 用备用连接来获取Web服务客户端
        /// </summary>
        /// <returns></returns>
        public static LoginServiceSoapClient GetLoginServiceSoapClientByBackup()
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
                    strServiceUrl = String.Format("http://{0}/{1}/LoginService.asmx", clsSysPara.strCurrIPAddressAndPort2, clsSysPara.strCurrPrx2);
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

                string strMsg = string.Format("获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
                     objException.Message,
                     clsSysPara.CurrPrx,
                     clsSysPara.CurrIPAddressAndPort);

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
                string strMsg = "";
                string strMessage = objException.InnerException.Message;
                if (strMessage.IndexOf("无法连接") >= 0)
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{3},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                        objException.Message,
                        clsSysPara.CurrIPAddressAndPort,
                        clsSysPara.CurrPrx,
                        strMessage);
                }
                else
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{0},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                  objException.Message,
                  clsSysPara.CurrIPAddressAndPort,
                  clsSysPara.CurrPrx,
                  strMessage);
                }
                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            return bolIsSuccess;
        }

        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <returns>是否成功？"True":成功，"False":失败， 其他的代表不成功，同时也显示原因</returns>
        public static string UserLogin2(string strUserId, string strPassword)
        {
            //检测记录是否存在
            LoginServiceSoapClient objLoginService = null;
            try
            {
                objLoginService = GetLoginServiceSoapClient();
            }
            catch (Exception objException)
            {

                string strMsg = string.Format("获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
                     objException.Message,
                     clsSysPara.CurrPrx,
                     clsSysPara.CurrIPAddressAndPort);

                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            string strIsSuccess = "";
            try
            {
                strIsSuccess = objLoginService.UserLogin2(strUserId, strPassword);
            }
            catch (Exception objException)
            {
                string strMsg = "";
                string strMessage = objException.InnerException.Message;
                if (strMessage.IndexOf("无法连接") >= 0)
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{3},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                        objException.Message,
                        clsSysPara.CurrIPAddressAndPort,
                        clsSysPara.CurrPrx,
                        strMessage);
                }
                else
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{0},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                  objException.Message,
                  clsSysPara.CurrIPAddressAndPort,
                  clsSysPara.CurrPrx,
                  strMessage);
                }
                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            return strIsSuccess;
        }


        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <param name="strEffectiveDate">有效日期</param>
        /// <returns>成功返回"true"，不成功返回"false", 超过有效期返回"EffectiveDateError"</returns>
        public static bool UserLoginWithEffectiveDate(string strUserId, string strPassword, string strEffectiveDate)
        {
            //检测记录是否存在
            LoginServiceSoapClient objLoginService = null;
            try
            {
                objLoginService = GetLoginServiceSoapClient();
            }
            catch (Exception objException)
            {

                string strMsg = string.Format("获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
                     objException.Message,
                     clsSysPara.CurrPrx,
                     clsSysPara.CurrIPAddressAndPort);

                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            string bolIsSuccess = "false";
            try
            {
                bolIsSuccess = objLoginService.UserLoginWithEffectiveDate(strUserId, strPassword, strEffectiveDate);
             
            }
            catch (Exception objException)
            {
                string strMsg = "";
                string strMessage = objException.InnerException.Message;
                if (strMessage.IndexOf("无法连接") >= 0)
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{3},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                        objException.Message,
                        clsSysPara.CurrIPAddressAndPort,
                        clsSysPara.CurrPrx,
                        strMessage);
                }
                else
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{0},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                  objException.Message,
                  clsSysPara.CurrIPAddressAndPort,
                  clsSysPara.CurrPrx,
                  strMessage);
                }
                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            if (bolIsSuccess == "false")
            {
                return false;
            }
            else if (bolIsSuccess == "true")
            {
                return true;
            }
            else if (bolIsSuccess == "EffectiveDateError")
            {
                string strMsg = "";
                strMsg = string.Format("用户登录（UserLoginWithEffectiveDate）有问题,由于您({0})的用户有效日期出错,请联系系统管理员！当前日期：{1}.",
                       strUserId, strEffectiveDate);
                throw new Exception(strMsg);
            }
            return bool.Parse(bolIsSuccess);
        }

        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <param name="strPrjId">默认工程Id</param>
        /// <returns>是否成功？</returns>
        public static bool UserLogin(string strUserId, string strPassword, string strPrjId)
        {
            //检测记录是否存在
            LoginServiceSoapClient objLoginService = null;
            try
            {
                objLoginService = GetLoginServiceSoapClient();
            }
            catch (Exception objException)
            {

                string strMsg = string.Format("获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
                     objException.Message,
                     clsSysPara.CurrPrx,
                     clsSysPara.CurrIPAddressAndPort);

                com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
                throw new Exception(strMsg);
            }
            bool bolIsSuccess = false;
            try
            {
                bolIsSuccess = objLoginService.UserLoginByPrjId(strUserId, strPassword, strPrjId);
            }
            catch (Exception objException)
            {
                string strMsg = "";
                string strMessage = objException.InnerException.Message;
                if (strMessage.IndexOf("无法连接") >= 0)
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{3},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                        objException.Message,
                        clsSysPara.CurrIPAddressAndPort,
                        clsSysPara.CurrPrx,
                        strMessage);
                }
                else
                {
                    strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{0},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
                  objException.Message,
                  clsSysPara.CurrIPAddressAndPort,
                  clsSysPara.CurrPrx,
                  strMessage);
                }
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

        public static string GetQxUserIdByLoginName(string strLoginName)
        {
            LoginServiceSoapClient objLoginService = GetLoginServiceSoapClient();

            string strUserId = objLoginService.GetQxUserIdByLoginName(strLoginName);

            return strUserId;

        }
    }
}
