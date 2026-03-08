
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
    /// CodeTypeService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class CodeTypeService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet CodeType_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsCodeTypeBL.GetDataSet_CodeType(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet CodeType_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsCodeTypeBL.GetDataSet_CodeTypeV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool CodeType_GetCodeType(ref clsCodeTypeEN objCodeTypeEN)
        {
            bool bolResult = clsCodeTypeBL.GetCodeType(ref objCodeTypeEN);
            return bolResult;
        }

        [WebMethod]
        public bool CodeType_GetCodeTypeV(ref clsCodeTypeEN objCodeTypeEN)
        {
            bool bolResult = clsCodeTypeBL.GetCodeType(ref objCodeTypeEN);
            return bolResult;
        }

        [WebMethod]
        public bool CodeType_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsCodeTypeBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool CodeType_IsExist(string strCodeTypeId)
        {
            bool bolIsExist = clsCodeTypeBL.IsExist(strCodeTypeId);
            return bolIsExist;
        }

        [WebMethod]
        public string CodeType_GetMaxStrId()
        {
            string strMaxstrCodeTypeId = clsCodeTypeBL.GetMaxStrId_S();
            return strMaxstrCodeTypeId;
        }

        [WebMethod]
        public bool CodeType_AddNewRecordBySql2(clsCodeTypeEN objCodeTypeEN)
        {
            bool bolResult = clsCodeTypeBL.AddNewRecordBySql2(objCodeTypeEN);
            return bolResult;
        }

        [WebMethod]
        public bool CodeType_AddNewRecordBySql_XML(string strCodeTypeENObjXml)
        {
            bool bolResult = clsCodeTypeBL.AddNewRecordBySql_XML(strCodeTypeENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool CodeType_UpdateBySql2(clsCodeTypeEN objCodeTypeEN)
        {
            bool bolResult = clsCodeTypeBL.UpdateBySql2(objCodeTypeEN);
            return bolResult;
        }

        [WebMethod]
        public bool CodeType_UpdateBySql_XML(string strCodeTypeENObjXml)
        {
            bool bolResult = clsCodeTypeBL.UpdateBySql_XML(strCodeTypeENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool CodeType_DelRecord(string strCodeTypeId)
        {
            bool bolResult = clsCodeTypeBL.DelRecord(strCodeTypeId);
            return bolResult;
        }

        [WebMethod]
        public bool CodeType_DelCodeTypes(List<string> arrCodeTypeId)
        {
            bool bolResult = clsCodeTypeBL.DelCodeTypes(arrCodeTypeId);
            return bolResult;
        }

        [WebMethod]
        public int CodeType_DelCodeTypesByCond(string strWhereCond)
        {
            int intRecNum = clsCodeTypeBL.DelCodeTypesByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsCodeTypeEN ExposeLogicClass(clsCodeTypeEN objCodeTypeEN)
        {
            return objCodeTypeEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2013/01/19
        /// </summary>
        /// <param name="strCodeTypeId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsCodeTypeEN>对象XML串</returns>
        [WebMethod]
        public string CodeType_SerializeObjToXMLStr(string strCodeTypeId)
        {
            string strXmlString = "";
            clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN(strCodeTypeId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsCodeTypeBL.GetCodeType(ref objCodeTypeEN);
                strXmlString = clsCodeTypeBL.SerializeObjToXMLStr(objCodeTypeEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "CodeTypeService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsCodeTypeEN>对象列表XML串</returns>
        [WebMethod]
        public string CodeType_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsCodeTypeEN> lstCodeTypeENObjList = clsCodeTypeBL.GetCodeTypeObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsCodeTypeBL.SerializeObjListToXMLStr(lstCodeTypeENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "CodeTypeService");
            }
            return strXmlString;
        }
    }
}