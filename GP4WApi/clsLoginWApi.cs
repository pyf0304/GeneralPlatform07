using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using com.taishsoft.json;
using GP4WApi;
using com.taishsoft.common;
using System.Web;
using Newtonsoft.Json.Linq;
using GP4WApi;

namespace GP4WApi
{
    /// <summary>
    /// 
    /// </summary>
    public class clsLoginWApi
    {
        private static readonly string mstrApiControllerName = "LoginApi";

      
        private static string mstrDir = "0";



        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="objLoginPara">objLoginPara</param>
        /// <param name="bolIsTest">bolIsTest</param>
        /// <returns>是否成功？</returns>
        public static bool UserLoginBak(stuLoginPara objLoginPara, bool bolIsTest = false)
        {
            bool bolIsSuccess = false;
            string strAction = "UserLogin";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objLoginPara.GetDictParam();

            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuLoginPara>(objLoginPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg, bolIsTest) == true)
                {
                    bolIsSuccess = bool.Parse(strResult);
                    return bolIsSuccess;
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }

            //检测记录是否存在
            //LoginServiceSoapClient objLoginService = null;
            //try
            //{
            //    objLoginService = GetLoginServiceSoapClient();
            //}
            //catch (Exception objException)
            //{

            //    string strMsg = string.Format("获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
            //         objException.Message,
            //         clsSysPara.CurrPrx,
            //         clsSysPara.CurrIPAddressAndPort);

            //    com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
            //    throw new Exception(strMsg);
            //}
            //bool bolIsSuccess = false;
            //try
            //{
            //    bolIsSuccess = objLoginService.UserLogin(strUserId, strPassword);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = "";
            //    string strMessage = objException.InnerException.Message;
            //    if (strMessage.IndexOf("无法连接") >= 0)
            //    {
            //        strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{3},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
            //            objException.Message,
            //            clsSysPara.CurrIPAddressAndPort,
            //            clsSysPara.CurrPrx,
            //            strMessage);
            //    }
            //    else
            //    {
            //        strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{0},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
            //      objException.Message,
            //      clsSysPara.CurrIPAddressAndPort,
            //      clsSysPara.CurrPrx,
            //      strMessage);
            //    }
            //    com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
            //    throw new Exception(strMsg);
            //}
            //return bolIsSuccess;
        }
        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <returns>是否成功？</returns>
        public static bool UserLogin(stuLoginPara objLoginPara, bool bolIsTest = false)
        {
            bool bolIsSuccess = false;
            string strAction = "UserLogin";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objLoginPara.GetDictParam();

            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuLoginPara>(objLoginPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg, bolIsTest) == true)
                {
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
                     
                        var bolReturnBool = (bool)jobjReturn0["returnBool"];
                        return bolReturnBool;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                    //bolIsSuccess = bool.Parse(strResult);
                    //return bolIsSuccess;
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }

            //检测记录是否存在
            //LoginServiceSoapClient objLoginService = null;
            //try
            //{
            //    objLoginService = GetLoginServiceSoapClient();
            //}
            //catch (Exception objException)
            //{

            //    string strMsg = string.Format("获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
            //         objException.Message,
            //         clsSysPara.CurrPrx,
            //         clsSysPara.CurrIPAddressAndPort);

            //    com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
            //    throw new Exception(strMsg);
            //}
            //bool bolIsSuccess = false;
            //try
            //{
            //    bolIsSuccess = objLoginService.UserLogin(strUserId, strPassword);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = "";
            //    string strMessage = objException.InnerException.Message;
            //    if (strMessage.IndexOf("无法连接") >= 0)
            //    {
            //        strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{3},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
            //            objException.Message,
            //            clsSysPara.CurrIPAddressAndPort,
            //            clsSysPara.CurrPrx,
            //            strMessage);
            //    }
            //    else
            //    {
            //        strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{0},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
            //      objException.Message,
            //      clsSysPara.CurrIPAddressAndPort,
            //      clsSysPara.CurrPrx,
            //      strMessage);
            //    }
            //    com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
            //    throw new Exception(strMsg);
            //}
            //return bolIsSuccess;
        }


       
        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <returns>是否成功？"True":成功，"False":失败， 其他的代表不成功，同时也显示原因</returns>
        public static string UserLogin2(stuLoginPara objLoginPara)
        {
            bool bolIsSuccess = false;
            string strAction = "UserLogin2";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objLoginPara.GetDictParam();

            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuLoginPara>(objLoginPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    bolIsSuccess = bool.Parse(strResult);
                    return bolIsSuccess.ToString();
                }
                else return false.ToString();
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <param name="strEffectiveDate">有效日期</param>
        /// <returns>成功返回"true"，不成功返回"false", 超过有效期返回"EffectiveDateError"</returns>
        public static bool UserLoginWithEffectiveDate(stuLoginPara objLoginPara)
        {
            string bolIsSuccess = "false";
            string strAction = "UserLogin";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objLoginPara.GetDictParam();

            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuLoginPara>(objLoginPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    bolIsSuccess = strResult;
               
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
                               objLoginPara.LoginName, objLoginPara.EffectiveDate);
                        throw new Exception(strMsg);
                    }
                    return bool.Parse(bolIsSuccess);
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }          
        }

        /// <summary>
        /// 用户登录函数
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPassword">口令</param>
        /// <param name="strPrjId">默认工程Id</param>
        /// <returns>是否成功？</returns>
        public static bool UserLoginByPrjId(stuLoginPara objLoginPara)
        {
            bool bolIsSuccess = false;
            string strAction = "UserLoginByPrjId";
            string strErrMsg = string.Empty;
            string strResult = "";

            if (string.IsNullOrEmpty( objLoginPara.QxPrjId))
            {
                string strMsg = string.Format("当前登录信息中工程Id不能为空！(from {0}). WebApi地址:{1}).",
                  clsStackTrace.GetCurrClassFunction(),
            clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }
            Dictionary<string, string> dictParam = objLoginPara.GetDictParam();

            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuLoginPara>(objLoginPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    bolIsSuccess = bool.Parse(strResult);
                    return bolIsSuccess;
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }

            ////检测记录是否存在
            //LoginServiceSoapClient objLoginService = null;
            //try
            //{
            //    objLoginService = GetLoginServiceSoapClient();
            //}
            //catch (Exception objException)
            //{

            //    string strMsg = string.Format("获取LoginService有问题。{0}.clsSysPara.strCurrPrx={1}; clsSysPara.strCurrIPAddressAndPort={2}",
            //         objException.Message,
            //         clsSysPara.CurrPrx,
            //         clsSysPara.CurrIPAddressAndPort);

            //    com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
            //    throw new Exception(strMsg);
            //}
            //bool bolIsSuccess = false;
            //try
            //{
            //    bolIsSuccess = objLoginService.UserLoginByPrjId(strUserId, strPassword, strPrjId);
            //}
            //catch (Exception objException)
            //{
            //    string strMsg = "";
            //    string strMessage = objException.InnerException.Message;
            //    if (strMessage.IndexOf("无法连接") >= 0)
            //    {
            //        strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{3},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
            //            objException.Message,
            //            clsSysPara.CurrIPAddressAndPort,
            //            clsSysPara.CurrPrx,
            //            strMessage);
            //    }
            //    else
            //    {
            //        strMsg = string.Format("用户登录（UserLogin）有问题,可能由于：{0},请联系系统管理员！clsSysPara.strCurrIPAddressAndPort={1},clsSysPara.strCurrPrx={2}",
            //      objException.Message,
            //      clsSysPara.CurrIPAddressAndPort,
            //      clsSysPara.CurrPrx,
            //      strMessage);
            //    }
            //    com.taishsoft.common.clsLog.LogErrorS(objException, "clsLoginWS");
            //    throw new Exception(strMsg);
            //}
            //return bolIsSuccess;
        }
        /// <summary>
        /// 根据用户登录名获取用户Id
        /// </summary>
        /// <param name="strLoginName">用户登录名</param>        
        /// <returns>返回strUserId</returns>

        public static string GetUserIdByLoginName(string strLoginName, bool bolIsTest = false)
        {
            //检测记录是否存在
            string strAction = "GetUserIdByLoginName";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strLoginName"] = strLoginName
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg, bolIsTest) == true)
                {
                    string strS1 = clsJSON.GetObjFromJson<string>(strResult);
                     return strS1;
                }
                else return "";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("根据用户登录名获取用户Id出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            //return strUserId;

        }
    }
}
