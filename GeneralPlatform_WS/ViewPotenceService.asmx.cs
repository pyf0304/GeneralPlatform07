///----------------------
///生成代码版本：09.10.08.1
///生成日期：2011/03/14
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2010.05.04.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2010.05.04.1
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
    /// ViewPotenceService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class ViewPotenceService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet ViewPotence_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsViewPotenceBL.GetDataSet_ViewPotence(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet ViewPotence_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsViewPotenceBL.GetDataSet_ViewPotenceV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool ViewPotence_GetViewPotence(ref clsViewPotenceEN objViewPotenceEN)
        {
            bool bolResult = clsViewPotenceBL.GetViewPotence(ref objViewPotenceEN);
            return bolResult;
        }

        [WebMethod]
        public bool ViewPotence_GetViewPotenceV(ref clsViewPotenceEN objViewPotenceEN)
        {
            bool bolResult = clsViewPotenceBL.GetViewPotence(ref objViewPotenceEN);
            return bolResult;
        }

        [WebMethod]
        public bool ViewPotence_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsViewPotenceBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool ViewPotence_IsExist(long lngmId)
        {
            bool bolIsExist = clsViewPotenceBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public string ViewPotence_GetMaxStrId()
        {
            string strMaxlngmId = clsViewPotenceBL.GetMaxStrId_S();
            return strMaxlngmId;
        }

        [WebMethod]
        public bool ViewPotence_AddNewRecordBySql2(clsViewPotenceEN objViewPotenceEN)
        {
            bool bolResult = clsViewPotenceBL.AddNewRecordBySql2(objViewPotenceEN);
            return bolResult;
        }

        [WebMethod]
        public bool ViewPotence_AddNewRecordBySql_XML(string strViewPotenceENObjXml)
        {
            bool bolResult = clsViewPotenceBL.AddNewRecordBySql_XML(strViewPotenceENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool ViewPotence_UpdateBySql2(clsViewPotenceEN objViewPotenceEN)
        {
            bool bolResult = clsViewPotenceBL.UpdateBySql2(objViewPotenceEN);
            return bolResult;
        }

        [WebMethod]
        public bool ViewPotence_UpdateBySql_XML(string strViewPotenceENObjXml)
        {
            bool bolResult = clsViewPotenceBL.UpdateBySql_XML(strViewPotenceENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool ViewPotence_DelRecord(long lngmId)
        {
            bool bolResult = clsViewPotenceBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool ViewPotence_DelViewPotences(List<string>  arrStdId)
        {
            bool bolResult = clsViewPotenceBL.DelViewPotences(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public int ViewPotence_DelViewPotencesByCond(string strWhereCond)
        {
            int intRecNum = clsViewPotenceBL.DelViewPotencesByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsViewPotenceEN ExposeLogicClass(clsViewPotenceEN objViewPotenceEN)
        {
            return objViewPotenceEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2011/03/14
        /// </summary>
        /// <param name="lngmId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsViewPotenceEN>对象XML串</returns>
        [WebMethod]
        public string ViewPotence_SerializeObjToXMLStr(long lngmId)
        {
            string strXmlString = "";
            clsViewPotenceEN objViewPotenceEN = new clsViewPotenceEN(lngmId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsViewPotenceBL.GetViewPotence(ref objViewPotenceEN);
                strXmlString = clsViewPotenceBL.SerializeObjToXMLStr(objViewPotenceEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "ViewPotenceService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsViewPotenceEN>对象列表XML串</returns>
        [WebMethod]
        public string ViewPotence_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsViewPotenceEN> lstViewPotenceENObjList = clsViewPotenceBL.GetViewPotenceObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsViewPotenceBL.SerializeObjListToXMLStr(lstViewPotenceENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "ViewPotenceService");
            }
            return strXmlString;
        }
    }
}