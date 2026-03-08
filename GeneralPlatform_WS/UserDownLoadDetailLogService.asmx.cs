
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
    /// UserDownLoadDetailLogService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserDownLoadDetailLogService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserDownLoadDetailLog_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserDownLoadDetailLogBL.GetDataSet_UserDownLoadDetailLog(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserDownLoadDetailLog_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserDownLoadDetailLogBL.GetDataSet_UserDownLoadDetailLogV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_GetUserDownLoadDetailLog(ref clsUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.GetUserDownLoadDetailLog(ref objUserDownLoadDetailLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_GetUserDownLoadDetailLogV(ref clsUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.GetUserDownLoadDetailLog(ref objUserDownLoadDetailLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserDownLoadDetailLogBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_IsExist(long lngmId)
        {
            bool bolIsExist = clsUserDownLoadDetailLogBL.IsExist(lngmId);
            return bolIsExist;
        }


        [WebMethod]
        public bool UserDownLoadDetailLog_AddNewRecordBySql2(clsUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.AddNewRecordBySql2(objUserDownLoadDetailLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_AddNewRecordBySql_XML(string strUserDownLoadDetailLogENObjXml)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.AddNewRecordBySql_XML(strUserDownLoadDetailLogENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_UpdateBySql2(clsUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.UpdateBySql2(objUserDownLoadDetailLogEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_UpdateBySql_XML(string strUserDownLoadDetailLogENObjXml)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.UpdateBySql_XML(strUserDownLoadDetailLogENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_DelRecord(long lngmId)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool UserDownLoadDetailLog_DelUserDownLoadDetailLogs(List<string> arrmId)
        {
            bool bolResult = clsUserDownLoadDetailLogBL.DelUserDownLoadDetailLogs(arrmId);
            return bolResult;
        }

        [WebMethod]
        public int UserDownLoadDetailLog_DelUserDownLoadDetailLogsByCond(string strWhereCond)
        {
            int intRecNum = clsUserDownLoadDetailLogBL.DelUserDownLoadDetailLogsByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsUserDownLoadDetailLogEN ExposeLogicClass(clsUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
        {
            return objUserDownLoadDetailLogEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2013/01/19
        /// </summary>
        /// <param name="lngmId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsUserDownLoadDetailLogEN>对象XML串</returns>
        [WebMethod]
        public string UserDownLoadDetailLog_SerializeObjToXMLStr(long lngmId)
        {
            string strXmlString = "";
            clsUserDownLoadDetailLogEN objUserDownLoadDetailLogEN = new clsUserDownLoadDetailLogEN(lngmId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsUserDownLoadDetailLogBL.GetUserDownLoadDetailLog(ref objUserDownLoadDetailLogEN);
                strXmlString = clsUserDownLoadDetailLogBL.SerializeObjToXMLStr(objUserDownLoadDetailLogEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "UserDownLoadDetailLogService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsUserDownLoadDetailLogEN>对象列表XML串</returns>
        [WebMethod]
        public string UserDownLoadDetailLog_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsUserDownLoadDetailLogEN> lstUserDownLoadDetailLogENObjList = clsUserDownLoadDetailLogBL.GetUserDownLoadDetailLogObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsUserDownLoadDetailLogBL.SerializeObjListToXMLStr(lstUserDownLoadDetailLogENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "UserDownLoadDetailLogService");
            }
            return strXmlString;
        }
    }
}