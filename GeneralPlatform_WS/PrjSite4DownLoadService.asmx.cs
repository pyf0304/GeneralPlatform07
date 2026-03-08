
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
    /// PrjSite4DownLoadService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PrjSite4DownLoadService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet PrjSite4DownLoad_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsPrjSite4DownLoadBL.GetDataSet_PrjSite4DownLoad(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjSite4DownLoad_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsPrjSite4DownLoadBL.GetDataSet_PrjSite4DownLoadV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_GetPrjSite4DownLoad(ref clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
        {
            bool bolResult = clsPrjSite4DownLoadBL.GetPrjSite4DownLoad(ref objPrjSite4DownLoadEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_GetPrjSite4DownLoadV(ref clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
        {
            bool bolResult = clsPrjSite4DownLoadBL.GetPrjSite4DownLoad(ref objPrjSite4DownLoadEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsPrjSite4DownLoadBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_IsExist(string strPrjSiteId)
        {
            bool bolIsExist = clsPrjSite4DownLoadBL.IsExist(strPrjSiteId);
            return bolIsExist;
        }

        [WebMethod]
        public string PrjSite4DownLoad_GetMaxStrId()
        {
            string strMaxstrPrjSiteId = clsPrjSite4DownLoadBL.GetMaxStrId_S();
            return strMaxstrPrjSiteId;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_AddNewRecordBySql2(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
        {
            bool bolResult = clsPrjSite4DownLoadBL.AddNewRecordBySql2(objPrjSite4DownLoadEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_AddNewRecordBySql_XML(string strPrjSite4DownLoadENObjXml)
        {
            bool bolResult = clsPrjSite4DownLoadBL.AddNewRecordBySql_XML(strPrjSite4DownLoadENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_UpdateBySql2(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
        {
            bool bolResult = clsPrjSite4DownLoadBL.UpdateBySql2(objPrjSite4DownLoadEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_UpdateBySql_XML(string strPrjSite4DownLoadENObjXml)
        {
            bool bolResult = clsPrjSite4DownLoadBL.UpdateBySql_XML(strPrjSite4DownLoadENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_DelRecord(string strPrjSiteId)
        {
            bool bolResult = clsPrjSite4DownLoadBL.DelRecord(strPrjSiteId);
            return bolResult;
        }

        [WebMethod]
        public bool PrjSite4DownLoad_DelPrjSite4DownLoads(List<string> arrPrjSiteId)
        {
            bool bolResult = clsPrjSite4DownLoadBL.DelPrjSite4DownLoads(arrPrjSiteId);
            return bolResult;
        }

        [WebMethod]
        public int PrjSite4DownLoad_DelPrjSite4DownLoadsByCond(string strWhereCond)
        {
            int intRecNum = clsPrjSite4DownLoadBL.DelPrjSite4DownLoadsByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsPrjSite4DownLoadEN ExposeLogicClass(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
        {
            return objPrjSite4DownLoadEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2013/01/19
        /// </summary>
        /// <param name="strPrjSiteId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsPrjSite4DownLoadEN>对象XML串</returns>
        [WebMethod]
        public string PrjSite4DownLoad_SerializeObjToXMLStr(string strPrjSiteId)
        {
            string strXmlString = "";
            clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = new clsPrjSite4DownLoadEN(strPrjSiteId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsPrjSite4DownLoadBL.GetPrjSite4DownLoad(ref objPrjSite4DownLoadEN);
                strXmlString = clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "PrjSite4DownLoadService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsPrjSite4DownLoadEN>对象列表XML串</returns>
        [WebMethod]
        public string PrjSite4DownLoad_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsPrjSite4DownLoadEN> lstPrjSite4DownLoadENObjList = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsPrjSite4DownLoadBL.SerializeObjListToXMLStr(lstPrjSite4DownLoadENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "PrjSite4DownLoadService");
            }
            return strXmlString;
        }
    }
}