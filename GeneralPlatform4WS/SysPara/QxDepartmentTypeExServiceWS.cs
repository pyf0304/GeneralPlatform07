
/*-- -- -- -- -- -- -- -- -- -- --
类名:QxDepartmentTypeExServiceWS
生成代码版本:2017.07.08.1
生成日期:2017/07/31 16:44:45
生成者:潘以锋
生成服务器IP:192.168.1.4
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
using GeneralPlatform4WS.ServiceReferenceQxDepartmentTypeEx;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// QxDepartmentTypeExServiceWS
    /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode4SpecialWs)
    /// </summary>
    public class QxDepartmentTypeExServiceWS
    {
        private static string mstrPageName = "QxDepartmentTypeExService.asmx";
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
        private static QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceSoapClient = null;
        /// <summary>
        /// 
        /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode4SpecialWs)
        /// </summary>
        /// <returns></returns>
        public static QxDepartmentTypeExServiceSoapClient GetQxDepartmentTypeExServiceSoapClient()
        {
            if (objQxDepartmentTypeExServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "QxDepartmentTypeExServiceWSServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new QxDepartmentTypeExServiceSoapClient(binding, address);
            }
            else
            {
                return objQxDepartmentTypeExServiceSoapClient;
            }
        }

        /// <summary>
        /// QxDepartmentType_DelQxDepartmentTypesByCond
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static int QxDepartmentType_DelQxDepartmentTypesByCondWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                int intTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_DelQxDepartmentTypesByCond(strWhereCond);
                return intTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_DelQxDepartmentTypesByCond", "QxDepartmentTypeExServiceWS:QxDepartmentType_DelQxDepartmentTypesByCondWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// ExposeLogicClass
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "objQxDepartmentTypeEN">objQxDepartmentTypeEN</param>
        /// <returns>返回</returns>
        public static clsQxDepartmentTypeEN ExposeLogicClassWs(clsQxDepartmentTypeEN objQxDepartmentTypeEN)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                clsQxDepartmentTypeEN objQxDepartmentTypeEN_Re = objQxDepartmentTypeExServiceService.ExposeLogicClass(objQxDepartmentTypeEN);
                return objQxDepartmentTypeEN_Re;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "ExposeLogicClass", "QxDepartmentTypeExServiceWS:ExposeLogicClassWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_SerializeObjToXMLStr
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strDepartmentTypeId">strDepartmentTypeId</param>
        /// <returns>返回</returns>
        public static string QxDepartmentType_SerializeObjToXMLStrWs(string strDepartmentTypeId)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_SerializeObjToXMLStr(strDepartmentTypeId);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_SerializeObjToXMLStr", "QxDepartmentTypeExServiceWS:QxDepartmentType_SerializeObjToXMLStrWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_SerializeObjListToXMLStr
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static string QxDepartmentType_SerializeObjListToXMLStrWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_SerializeObjListToXMLStr(strWhereCond);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_SerializeObjListToXMLStr", "QxDepartmentTypeExServiceWS:QxDepartmentType_SerializeObjListToXMLStrWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_SerializeTopObjListToXMLStr
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "intTopSize">intTopSize</param>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static string QxDepartmentType_SerializeTopObjListToXMLStrWs(int intTopSize, string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_SerializeTopObjListToXMLStr(intTopSize, strWhereCond);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_SerializeTopObjListToXMLStr", "QxDepartmentTypeExServiceWS:QxDepartmentType_SerializeTopObjListToXMLStrWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetDataSet
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static DataSet QxDepartmentType_GetDataSetWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                DataSet dsTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetDataSet(strWhereCond);
                return dsTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetDataSet", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetDataSetWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetTopDataSet
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "intTopSize">intTopSize</param>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static DataSet QxDepartmentType_GetTopDataSetWs(int intTopSize, string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                DataSet dsTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetTopDataSet(intTopSize, strWhereCond);
                return dsTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetTopDataSet", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetTopDataSetWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetDataSetByRange
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <param name = "lngMinNum">lngMinNum</param>
        /// <param name = "lngMaxNum">lngMaxNum</param>
        /// <returns>返回</returns>
        public static DataSet QxDepartmentType_GetDataSetByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                DataSet dsTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
                return dsTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetDataSetByRange", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetDataSetByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetDataSetV
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static DataSet QxDepartmentType_GetDataSetVWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                DataSet dsTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetDataSetV(strWhereCond);
                return dsTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetDataSetV", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetDataSetVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetQxDepartmentType
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "objQxDepartmentTypeEN">引用型参数,返回:objQxDepartmentTypeEN</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_GetQxDepartmentTypeWs(ref clsQxDepartmentTypeEN objQxDepartmentTypeEN)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetQxDepartmentType(ref objQxDepartmentTypeEN);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetQxDepartmentType", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetQxDepartmentTypeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetQxDepartmentTypeByDepartmentTypeId
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strDepartmentTypeId">strDepartmentTypeId</param>
        /// <returns>返回</returns>
        public static clsQxDepartmentTypeEN QxDepartmentType_GetQxDepartmentTypeByDepartmentTypeIdWs(string strDepartmentTypeId)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                clsQxDepartmentTypeEN objQxDepartmentTypeEN_Re = objQxDepartmentTypeExServiceService.QxDepartmentType_GetObjByDepartmentTypeId(strDepartmentTypeId);
                return objQxDepartmentTypeEN_Re;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetQxDepartmentTypeByDepartmentTypeId", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetQxDepartmentTypeByDepartmentTypeIdWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetQxDepartmentTypeV
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "objQxDepartmentTypeEN">引用型参数,返回:objQxDepartmentTypeEN</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_GetQxDepartmentTypeVWs(ref clsQxDepartmentTypeEN objQxDepartmentTypeEN)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetQxDepartmentTypeV(ref objQxDepartmentTypeEN);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetQxDepartmentTypeV", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetQxDepartmentTypeVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetObjLst
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static clsQxDepartmentTypeEN[] QxDepartmentType_GetObjLstWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                clsQxDepartmentTypeEN[] arrQxDepartmentTypeObjLst = objQxDepartmentTypeExServiceService.QxDepartmentType_GetObjLst(strWhereCond);
                return arrQxDepartmentTypeObjLst;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetObjLst", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetObjLstWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetTopObjLst
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "intTopSize">intTopSize</param>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static clsQxDepartmentTypeEN[] QxDepartmentType_GetTopObjLstWs(int intTopSize, string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                clsQxDepartmentTypeEN[] arrQxDepartmentTypeObjLst = objQxDepartmentTypeExServiceService.QxDepartmentType_GetTopObjLst(intTopSize, strWhereCond);
                return arrQxDepartmentTypeObjLst;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetTopObjLst", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetTopObjLstWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetFirstID_S
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static string QxDepartmentType_GetFirstID_SWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetFirstID_S(strWhereCond);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetFirstID_S", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetFirstID_SWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetFirstObj_S
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static clsQxDepartmentTypeEN QxDepartmentType_GetFirstObj_SWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                clsQxDepartmentTypeEN objQxDepartmentTypeEN_Re = objQxDepartmentTypeExServiceService.QxDepartmentType_GetFirstObj_S(strWhereCond);
                return objQxDepartmentTypeEN_Re;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetFirstObj_S", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetFirstObj_SWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// GetQxDepartmentTypeJSONObjByDepartmentTypeId
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strDepartmentTypeId">strDepartmentTypeId</param>
        /// <returns>返回</returns>
        public static string GetQxDepartmentTypeJSONObjByDepartmentTypeIdWs(string strDepartmentTypeId)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.GetQxDepartmentTypeJSONObjByDepartmentTypeId(strDepartmentTypeId);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "GetQxDepartmentTypeJSONObjByDepartmentTypeId", "QxDepartmentTypeExServiceWS:GetQxDepartmentTypeJSONObjByDepartmentTypeIdWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// GetFirstQxDepartmentTypeJSONObj
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static string GetFirstQxDepartmentTypeJSONObjWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.GetFirstQxDepartmentTypeJSONObj(strWhereCond);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "GetFirstQxDepartmentTypeJSONObj", "QxDepartmentTypeExServiceWS:GetFirstQxDepartmentTypeJSONObjWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// GetQxDepartmentTypeJSONObjLst
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static string GetQxDepartmentTypeJSONObjLstWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.GetQxDepartmentTypeJSONObjLst(strWhereCond);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "GetQxDepartmentTypeJSONObjLst", "QxDepartmentTypeExServiceWS:GetQxDepartmentTypeJSONObjLstWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// GetTopQxDepartmentTypeJSONObjLst
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "intTopSize">intTopSize</param>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static string GetTopQxDepartmentTypeJSONObjLstWs(int intTopSize, string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.GetTopQxDepartmentTypeJSONObjLst(intTopSize, strWhereCond);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "GetTopQxDepartmentTypeJSONObjLst", "QxDepartmentTypeExServiceWS:GetTopQxDepartmentTypeJSONObjLstWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_IsExistRecord
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_IsExistRecordWs(string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_IsExistRecord(strWhereCond);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_IsExistRecord", "QxDepartmentTypeExServiceWS:QxDepartmentType_IsExistRecordWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_IsExist
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strDepartmentTypeId">strDepartmentTypeId</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_IsExistWs(string strDepartmentTypeId)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_IsExist(strDepartmentTypeId);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_IsExist", "QxDepartmentTypeExServiceWS:QxDepartmentType_IsExistWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetMaxStrId
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <returns>返回</returns>
        public static string QxDepartmentType_GetMaxStrIdWs()
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetMaxStrId();
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetMaxStrId", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetMaxStrIdWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_GetMaxStrIdByPrefix
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strPrefix">strPrefix</param>
        /// <returns>返回</returns>
        public static string QxDepartmentType_GetMaxStrIdByPrefixWs(string strPrefix)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                string strTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_GetMaxStrIdByPrefix(strPrefix);
                return strTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_GetMaxStrIdByPrefix", "QxDepartmentTypeExServiceWS:QxDepartmentType_GetMaxStrIdByPrefixWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_AddNewRecordBySql2
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "objQxDepartmentTypeEN">objQxDepartmentTypeEN</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_AddNewRecordBySql2Ws(clsQxDepartmentTypeEN objQxDepartmentTypeEN)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_AddNewRecordBySql2(objQxDepartmentTypeEN);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_AddNewRecordBySql2", "QxDepartmentTypeExServiceWS:QxDepartmentType_AddNewRecordBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_AddNewRecordBySql2ByJSON
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strQxDepartmentTypeJSONObj">strQxDepartmentTypeJSONObj</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_AddNewRecordBySql2ByJSONWs(string strQxDepartmentTypeJSONObj)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_AddNewRecordBySql2ByJSON(strQxDepartmentTypeJSONObj);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_AddNewRecordBySql2ByJSON", "QxDepartmentTypeExServiceWS:QxDepartmentType_AddNewRecordBySql2ByJSONWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_AddNewRecordBySql_XML
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strQxDepartmentTypeENObjXml">strQxDepartmentTypeENObjXml</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_AddNewRecordBySql_XMLWs(string strQxDepartmentTypeENObjXml)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_AddNewRecordBySql_XML(strQxDepartmentTypeENObjXml);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_AddNewRecordBySql_XML", "QxDepartmentTypeExServiceWS:QxDepartmentType_AddNewRecordBySql_XMLWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_UpdateBySql2
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "objQxDepartmentTypeEN">objQxDepartmentTypeEN</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_UpdateBySql2Ws(clsQxDepartmentTypeEN objQxDepartmentTypeEN)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_UpdateBySql2(objQxDepartmentTypeEN);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_UpdateBySql2", "QxDepartmentTypeExServiceWS:QxDepartmentType_UpdateBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_UpdateBySql2ByJSON
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strQxDepartmentTypeJSONObj">strQxDepartmentTypeJSONObj</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_UpdateBySql2ByJSONWs(string strQxDepartmentTypeJSONObj)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_UpdateBySql2ByJSON(strQxDepartmentTypeJSONObj);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_UpdateBySql2ByJSON", "QxDepartmentTypeExServiceWS:QxDepartmentType_UpdateBySql2ByJSONWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_UpdateBySqlWithCondition
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "objQxDepartmentTypeEN">objQxDepartmentTypeEN</param>
        /// <param name = "strWhereCond">strWhereCond</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_UpdateBySqlWithConditionWs(clsQxDepartmentTypeEN objQxDepartmentTypeEN, string strWhereCond)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_UpdateBySqlWithCondition(objQxDepartmentTypeEN, strWhereCond);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_UpdateBySqlWithCondition", "QxDepartmentTypeExServiceWS:QxDepartmentType_UpdateBySqlWithConditionWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_UpdateBySql_XML
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strQxDepartmentTypeENObjXml">strQxDepartmentTypeENObjXml</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_UpdateBySql_XMLWs(string strQxDepartmentTypeENObjXml)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_UpdateBySql_XML(strQxDepartmentTypeENObjXml);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_UpdateBySql_XML", "QxDepartmentTypeExServiceWS:QxDepartmentType_UpdateBySql_XMLWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_DelRecord
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "strDepartmentTypeId">strDepartmentTypeId</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_DelRecordWs(string strDepartmentTypeId)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_DelRecord(strDepartmentTypeId);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_DelRecord", "QxDepartmentTypeExServiceWS:QxDepartmentType_DelRecordWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// QxDepartmentType_DelQxDepartmentTypes
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_ByCommonFunction)
        /// </summary>
        /// <param name = "arrDepartmentTypeId">arrDepartmentTypeId</param>
        /// <returns>返回</returns>
        public static bool QxDepartmentType_DelQxDepartmentTypesWs(string[] arrDepartmentTypeId)
        {
            QxDepartmentTypeExServiceSoapClient objQxDepartmentTypeExServiceService = GetQxDepartmentTypeExServiceSoapClient();
            try
            {
                bool bolTemp = objQxDepartmentTypeExServiceService.QxDepartmentType_DelQxDepartmentTypes(arrDepartmentTypeId);
                return bolTemp;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentType_DelQxDepartmentTypes", "QxDepartmentTypeExServiceWS:QxDepartmentType_DelQxDepartmentTypesWs", objException.Message);
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