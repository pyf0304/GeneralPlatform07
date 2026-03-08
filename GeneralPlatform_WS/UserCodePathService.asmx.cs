
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
    /// UserCodePathService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserCodePathService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserCodePath_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserCodePathBL.GetDataSet_UserCodePath(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserCodePath_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserCodePathBL.GetDataSet_UserCodePathV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserCodePath_GetUserCodePath(ref clsUserCodePathEN objUserCodePathEN)
        {
            bool bolResult = clsUserCodePathBL.GetUserCodePath(ref objUserCodePathEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserCodePath_GetUserCodePathV(ref clsUserCodePathEN objUserCodePathEN)
        {
            bool bolResult = clsUserCodePathBL.GetUserCodePath(ref objUserCodePathEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserCodePath_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserCodePathBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserCodePath_IsExist(long lngmId)
        {
            bool bolIsExist = clsUserCodePathBL.IsExist(lngmId);
            return bolIsExist;
        }


        [WebMethod]
        public bool UserCodePath_AddNewRecordBySql2(clsUserCodePathEN objUserCodePathEN)
        {
            bool bolResult = clsUserCodePathBL.AddNewRecordBySql2(objUserCodePathEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserCodePath_AddNewRecordBySql_XML(string strUserCodePathENObjXml)
        {
            bool bolResult = clsUserCodePathBL.AddNewRecordBySql_XML(strUserCodePathENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool UserCodePath_UpdateBySql2(clsUserCodePathEN objUserCodePathEN)
        {
            bool bolResult = clsUserCodePathBL.UpdateBySql2(objUserCodePathEN);
            return bolResult;
        }

        [WebMethod]
        public bool UserCodePath_UpdateBySql_XML(string strUserCodePathENObjXml)
        {
            bool bolResult = clsUserCodePathBL.UpdateBySql_XML(strUserCodePathENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool UserCodePath_DelRecord(long lngmId)
        {
            bool bolResult = clsUserCodePathBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool UserCodePath_DelUserCodePaths(List<string> arrmId)
        {
            bool bolResult = clsUserCodePathBL.DelUserCodePaths(arrmId);
            return bolResult;
        }

        [WebMethod]
        public int UserCodePath_DelUserCodePathsByCond(string strWhereCond)
        {
            int intRecNum = clsUserCodePathBL.DelUserCodePathsByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsUserCodePathEN ExposeLogicClass(clsUserCodePathEN objUserCodePathEN)
        {
            return objUserCodePathEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2013/01/19
        /// </summary>
        /// <param name="lngmId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsUserCodePathEN>对象XML串</returns>
        [WebMethod]
        public string UserCodePath_SerializeObjToXMLStr(long lngmId)
        {
            string strXmlString = "";
            clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN(lngmId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsUserCodePathBL.GetUserCodePath(ref objUserCodePathEN);
                strXmlString = clsUserCodePathBL.SerializeObjToXMLStr(objUserCodePathEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "UserCodePathService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsUserCodePathEN>对象列表XML串</returns>
        [WebMethod]
        public string UserCodePath_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsUserCodePathEN> lstUserCodePathENObjList = clsUserCodePathBL.GetUserCodePathObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsUserCodePathBL.SerializeObjListToXMLStr(lstUserCodePathENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "UserCodePathService");
            }
            return strXmlString;
        }
    }
}