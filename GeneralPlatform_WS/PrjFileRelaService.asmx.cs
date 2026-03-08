
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2013/01/19
///生成者：潘以锋
///工程名称：统一平台
///工程ID：0014
///模块中文名：工程文件下载
///模块英文名：PrjFileDownLoad
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.23.1
///========================
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace GeneralPlatform_WS
{
    /// <summary>
    /// PrjFileRelaService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PrjFileRelaService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet PrjFileRela_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsPrjFileRelaBL.GetDataSet_PrjFileRela(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjFileRela_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsPrjFileRelaBL.GetDataSet_PrjFileRelaV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool PrjFileRela_GetPrjFileRela(ref clsPrjFileRelaEN objPrjFileRelaEN)
        {
            bool bolResult = clsPrjFileRelaBL.GetPrjFileRela(ref objPrjFileRelaEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjFileRela_GetPrjFileRelaV(ref clsPrjFileRelaEN objPrjFileRelaEN)
        {
            bool bolResult = clsPrjFileRelaBL.GetPrjFileRela(ref objPrjFileRelaEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjFileRela_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsPrjFileRelaBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjFileRela_IsExist(long lngmId)
        {
            bool bolIsExist = clsPrjFileRelaBL.IsExist(lngmId);
            return bolIsExist;
        }


        [WebMethod]
        public bool PrjFileRela_AddNewRecordBySql2(clsPrjFileRelaEN objPrjFileRelaEN)
        {
            bool bolResult = clsPrjFileRelaBL.AddNewRecordBySql2(objPrjFileRelaEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjFileRela_AddNewRecordBySql_XML(string strPrjFileRelaENObjXml)
        {
            bool bolResult = clsPrjFileRelaBL.AddNewRecordBySql_XML(strPrjFileRelaENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool PrjFileRela_UpdateBySql2(clsPrjFileRelaEN objPrjFileRelaEN)
        {
            bool bolResult = clsPrjFileRelaBL.UpdateBySql2(objPrjFileRelaEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjFileRela_UpdateBySql_XML(string strPrjFileRelaENObjXml)
        {
            bool bolResult = clsPrjFileRelaBL.UpdateBySql_XML(strPrjFileRelaENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool PrjFileRela_DelRecord(long lngmId)
        {
            bool bolResult = clsPrjFileRelaBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool PrjFileRela_DelPrjFileRelas(List<string> arrmId)
        {
            bool bolResult = clsPrjFileRelaBL.DelPrjFileRelas(arrmId);
            return bolResult;
        }

        [WebMethod]
        public int PrjFileRela_DelPrjFileRelasByCond(string strWhereCond)
        {
            int intRecNum = clsPrjFileRelaBL.DelPrjFileRelasByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsPrjFileRelaEN ExposeLogicClass(clsPrjFileRelaEN objPrjFileRelaEN)
        {
            return objPrjFileRelaEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2013/01/19
        /// </summary>
        /// <param name="lngmId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsPrjFileRelaEN>对象XML串</returns>
        [WebMethod]
        public string PrjFileRela_SerializeObjToXMLStr(long lngmId)
        {
            string strXmlString = "";
            clsPrjFileRelaEN objPrjFileRelaEN = new clsPrjFileRelaEN(lngmId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsPrjFileRelaBL.GetPrjFileRela(ref objPrjFileRelaEN);
                strXmlString = clsPrjFileRelaBL.SerializeObjToXMLStr(objPrjFileRelaEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "PrjFileRelaService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsPrjFileRelaEN>对象列表XML串</returns>
        [WebMethod]
        public string PrjFileRela_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsPrjFileRelaEN> lstPrjFileRelaENObjList = clsPrjFileRelaBL.GetPrjFileRelaObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsPrjFileRelaBL.SerializeObjListToXMLStr(lstPrjFileRelaENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "PrjFileRelaService");
            }
            return strXmlString;
        }
    }
}