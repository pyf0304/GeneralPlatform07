
using GP4WApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace GP4WApi
{
    /// <summary>
    /// 针对转换类的公共类函数
    /// </summary>
    public class clsPubFun4WApi
    {
        public static string strCurrIPAddressAndPort = "";
        public static string strCurrPrx = "";

        /// <summary>
        /// 获取Web服务的地址
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetWebApiUrlBak(string strApiControllerName, string strAction)
        {
            String strServiceUrl = String.Empty;

            if (clsSysPara4WebApi_GP.bolIsLocalHost == false)
            {

                strServiceUrl = String.Format("{0}/{1}/api/{2}/{3}",
                    clsSysPara4WebApi_GP.strCurrIPAddressAndPort, clsSysPara4WebApi_GP.strCurrPrx, strApiControllerName, strAction);

            }
            else
            {
                strServiceUrl = String.Format("{0}/api/{1}/{2}",
                    clsSysPara4WebApi_GP.strCurrIPAddressAndPort_Local,
                    strApiControllerName, strAction);

            }
            return strServiceUrl;
        }

        public static string GetWebApiUrl(string strApiControllerName, string strAction)
        {
            String strServiceUrl = String.Empty;

            if (clsSysPara4WebApi_GP.bolIsLocalHost == false)
            {
                if (string.IsNullOrEmpty(clsSysPara4WebApi_GP.strCurrPrx))
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}",
                     clsSysPara4WebApi_GP.strCurrIPAddressAndPort,
                     strApiControllerName, strAction);
                }
                else
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}/{3}",
                    clsSysPara4WebApi_GP.strCurrIPAddressAndPort, clsSysPara4WebApi_GP.strCurrPrx, strApiControllerName, strAction);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(clsSysPara4WebApi_GP.strCurrPrx))
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}",
                     clsSysPara4WebApi_GP.strCurrIPAddressAndPort_Local,
                     strApiControllerName, strAction);
                }
                else
                {
                    strServiceUrl = String.Format("{0}/{1}/{2}/{3}",
                        clsSysPara4WebApi_GP.strCurrIPAddressAndPort_Local,
                        clsSysPara4WebApi_GP.strCurrPrx,
                        strApiControllerName, strAction);
                }
            }
            return strServiceUrl;
        }

        public static string GetWebApiUrl_Test(string strApiControllerName, string strAction)
        {
            String strServiceUrl = String.Empty;


            strServiceUrl = String.Format("http://{0}/{1}/api/{2}/{3}",
                strCurrIPAddressAndPort, strCurrPrx, strApiControllerName, strAction);

            return strServiceUrl;
        }



        /// <summary>
        /// 生成最终URL
        /// </summary>
        /// <param name="strApiControllerName">基准URL（不含查询串）</param>
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <returns>最终URL</returns>
        public static string GetLastUrl(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, bool bolIsTest = false)
        {
            //string baseUrl = GetServiceUrl();
            string strWebApiUrl = "";// GetWebApiUrl(strApiControllerName, strAction);
            if (bolIsTest == false)
            {
                strWebApiUrl = GetWebApiUrl(strApiControllerName, strAction);
            }
            else
            {
                strWebApiUrl = GetWebApiUrl_Test(strApiControllerName, strAction);
            }
            var sbUrl = new StringBuilder(strWebApiUrl);
            if (dictParam != null && dictParam.Count > 0)
            {
                sbUrl.Append("?");
                int index = 0;
                foreach (var item in dictParam)
                {
                    sbUrl.Append(string.Format("{0}={1}", item.Key,
                        HttpUtility.UrlEncode(item.Value, Encoding.UTF8)));
                    if (index < dictParam.Count - 1)
                    {
                        sbUrl.Append("&");
                    }
                    index++;
                }
            }
            var url = sbUrl.ToString();
            return url;
        }


        /// <summary>
        /// 生成最终URL
        /// </summary>
        /// <param name="strApiControllerName">基准URL（不含查询串）</param>
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <returns>最终URL</returns>
        public static string GetLastUrl4Delete(string strApiControllerName, string strAction, string id)
        {
            //string baseUrl = GetServiceUrl();
            string strWebApiUrl = GetWebApiUrl(strApiControllerName, strAction);
            var sbUrl = new StringBuilder(strWebApiUrl);
            if (string.IsNullOrEmpty(id) == false)
            {
                sbUrl.AppendFormat("/{0}", id);
            }
            else
            {
                throw new Exception("删除WebApi时id不能为空！");
            }
            var url = sbUrl.ToString();
            return url;
        }
        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>        
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Get(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                throw ex;

            }

        }

        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Get4WebApi(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg, bool bolIsTest = false)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam, bolIsTest);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                throw ex;
            }

        }

        /// <summary>
        /// GET方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool GetObjLst4WebApi(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var tmpResult = client.GetAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                throw ex;

            }

        }

        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Post(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg, bool bolIsTest = false)
        {
            errMsg = string.Empty;
            result = string.Empty;
            var url = GetLastUrl(strApiControllerName, strAction, dictParam, bolIsTest);
            StringContent content = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PostAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                throw ex;

            }
        }

        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="baseUrl">基准URL（不含查询串）</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        //public static bool Post(string baseUrl, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        //{
        //    errMsg = string.Empty;
        //    result = string.Empty;
        //    try
        //    {
        //        using (var client = new HttpClient())
        //        {
        //client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var url = GetLastUrl(baseUrl, dictParam);
        //            var content = new StringContent(parseData, Encoding.UTF8);
        //            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //            var tmpResult = client.PostAsJsonAsync(url, content).Result;
        //            tmpResult.EnsureSuccessStatusCode();
        //            result = tmpResult.Content.ReadAsStringAsync().Result;
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        errMsg = ex.Message;
        //        return false;
        //    }
        //}

        /// <summary>
        /// Put方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Put(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PutAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                throw ex;

            }
        }


        /// <summary>
        /// POST方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="parseData">传递实体数据（Json格式）</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Deletes(string strApiControllerName, string strAction, Dictionary<string, string> dictParam, string parseData, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl(strApiControllerName, strAction, dictParam);
                    var content = new StringContent(parseData, Encoding.UTF8);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var tmpResult = client.PostAsync(url, content).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                throw ex;

            }
        }

        /// <summary>
        /// Delete方式调用Web Api
        /// </summary>
        /// <param name="strApiControllerName">页面的ApiController名称</param>       
        /// <param name="strAction">函数名称</param>
        /// <param name="dictParam">查询参数字典</param>
        /// <param name="result">返回数据（Json格式）</param>
        /// <param name="errMsg">出错信息</param>
        /// <returns>成功与否</returns>
        public static bool Delete(string strApiControllerName, string strAction, string id, out string result, out string errMsg)
        {
            errMsg = string.Empty;
            result = string.Empty;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("WindowsApp");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = GetLastUrl4Delete(strApiControllerName, strAction, id);
                    var tmpResult = client.DeleteAsync(url).Result;
                    tmpResult.EnsureSuccessStatusCode();
                    result = tmpResult.Content.ReadAsStringAsync().Result;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                throw ex;
            }
        }
    }
}
