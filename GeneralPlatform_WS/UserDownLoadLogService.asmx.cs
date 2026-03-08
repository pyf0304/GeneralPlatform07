
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
    /// UserDownLoadLogService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserDownLoadLogService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserDownLoadLog_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserDownLoadLogBL.GetDataSet_UserDownLoadLog(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserDownLoadLog_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserDownLoadLogBL.GetDataSet_UserDownLoadLogV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserDownLoadLog_GetUserDownLoadLog(ref clsUserDownLoadLogEN objUserDownLoadLogEN)
        {
            bool bolResult = clsUserDownLoadLogBL.GetUserDownLoadLog(ref objUserDownLoadLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadLog_GetUserDownLoadLogV(ref clsUserDownLoadLogEN objUserDownLoadLogEN)
        {
            bool bolResult = clsUserDownLoadLogBL.GetUserDownLoadLog(ref objUserDownLoadLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadLog_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserDownLoadLogBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserDownLoadLog_IsExist(string strUserDownLoadLogId)
        {
            bool bolIsExist = clsUserDownLoadLogBL.IsExist(strUserDownLoadLogId);
            return bolIsExist;
        }

        [WebMethod]
        public string UserDownLoadLog_GetMaxStrId()
        {
            string strMaxstrUserDownLoadLogId = clsUserDownLoadLogBL.GetMaxStrId_S();
            return strMaxstrUserDownLoadLogId;
        }

        [WebMethod]
        public bool UserDownLoadLog_AddNewRecordBySql2(clsUserDownLoadLogEN objUserDownLoadLogEN)
        {
            bool bolResult = clsUserDownLoadLogBL.AddNewRecordBySql2(objUserDownLoadLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadLog_AddNewRecordBySql_XML(string strUserDownLoadLogENObjXml)
        {
            bool bolResult = clsUserDownLoadLogBL.AddNewRecordBySql_XML(strUserDownLoadLogENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadLog_UpdateBySql2(clsUserDownLoadLogEN objUserDownLoadLogEN)
        {
            bool bolResult = clsUserDownLoadLogBL.UpdateBySql2(objUserDownLoadLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadLog_UpdateBySql_XML(string strUserDownLoadLogENObjXml)
        {
            bool bolResult = clsUserDownLoadLogBL.UpdateBySql_XML(strUserDownLoadLogENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadLog_DelRecord(string strUserDownLoadLogId)
        {
            bool bolResult = clsUserDownLoadLogBL.DelRecord(strUserDownLoadLogId);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadLog_DelUserDownLoadLogs(List<string> arrUserDownLoadLogId)
        {
            bool bolResult = clsUserDownLoadLogBL.DelUserDownLoadLogs(arrUserDownLoadLogId);
            return bolResult;
        }

        [WebMethod]
        public int UserDownLoadLog_DelUserDownLoadLogsByCond(string strWhereCond)
        {
            int intRecNum = clsUserDownLoadLogBL.DelUserDownLoadLogsByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsUserDownLoadLogEN ExposeLogicClass(clsUserDownLoadLogEN objUserDownLoadLogEN)
        {
            return objUserDownLoadLogEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2013/01/19
        /// </summary>
        /// <param name="strUserDownLoadLogId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsUserDownLoadLogEN>对象XML串</returns>
        [WebMethod]
        public string UserDownLoadLog_SerializeObjToXMLStr(string strUserDownLoadLogId)
        {
            string strXmlString = "";
            clsUserDownLoadLogEN objUserDownLoadLogEN = new clsUserDownLoadLogEN(strUserDownLoadLogId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsUserDownLoadLogBL.GetUserDownLoadLog(ref objUserDownLoadLogEN);
                strXmlString = clsUserDownLoadLogBL.SerializeObjToXMLStr(objUserDownLoadLogEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "UserDownLoadLogService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsUserDownLoadLogEN>对象列表XML串</returns>
        [WebMethod]
        public string UserDownLoadLog_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsUserDownLoadLogEN> lstUserDownLoadLogENObjList = clsUserDownLoadLogBL.GetUserDownLoadLogObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsUserDownLoadLogBL.SerializeObjListToXMLStr(lstUserDownLoadLogENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "UserDownLoadLogService");
            }
            return strXmlString;
        }
    }
}