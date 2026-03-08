
//----------------------
//生成代码版本：2015.06.16.1
//生成日期：2015/06/19
//生成者：潘以锋
//工程名称：统一平台
//工程ID：0014
//模块中文名：工程管理
//模块英文名：PrjManage
//注意：1、需要数据底层（PubDataBase.dll）的版本：2015.05.08.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2015.05.08.1
//========================
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
    /// PrjDataBaseService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PrjDataBaseService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet PrjDataBase_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsPrjDataBaseBL.GetDataSet_PrjDataBase(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjDataBase_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsPrjDataBaseBL.GetDataSet_PrjDataBaseByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjDataBase_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsPrjDataBaseBL.GetDataSet_PrjDataBaseV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjDataBase_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsPrjDataBaseBL.GetDataSet_PrjDataBaseVByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public bool PrjDataBase_GetPrjDataBase(ref clsPrjDataBaseEN objPrjDataBaseEN)
        {
            bool bolResult = clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
            return bolResult;
        }

        [WebMethod]
        public clsPrjDataBaseEN PrjDataBase_GetPrjDataBaseByPrjDataBaseId(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetPrjDataBaseByPrjDataBaseId(strPrjDataBaseId);
            return objPrjDataBaseEN;
        }

        [WebMethod]
        public bool PrjDataBase_GetPrjDataBaseV(ref clsPrjDataBaseEN objPrjDataBaseEN)
        {
            bool bolResult = clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
            return bolResult;
        }

        [WebMethod]
        public List<clsPrjDataBaseEN> PrjDataBase_GetPrjDataBaseObjList(string strWhereCond)
        {
            List<clsPrjDataBaseEN> arrPrjDataBaseObjLst = clsPrjDataBaseBL.GetPrjDataBaseObjList(strWhereCond);
            return arrPrjDataBaseObjLst;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [WebMethod]
        public string PrjDataBase_GetFirstID_S(string strCondition)
        {
            string strPrjDataBaseId;
            try
            {
                strPrjDataBaseId = clsPrjDataBaseBL.GetFirstID_S(strCondition);
                return strPrjDataBaseId;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First关键字出错！\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的对象</returns>
        [WebMethod]
        public clsPrjDataBaseEN PrjDataBase_GetFirstPrjDataBase_S(string strCondition)
        {
            try
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetFirstPrjDataBase_S(strCondition);
                return objPrjDataBaseEN;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First记录对象出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool PrjDataBase_IsExistRecord(string strWhereCond)
        {
            bool bolIsExist = clsPrjDataBaseBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjDataBase_IsExist(string strPrjDataBaseId)
        {
            bool bolIsExist = clsPrjDataBaseBL.IsExist(strPrjDataBaseId);
            return bolIsExist;
        }

        [WebMethod]
        public string PrjDataBase_GetMaxStrId()
        {
            string strMaxstrPrjDataBaseId = clsPrjDataBaseBL.GetMaxStrId_S();
            return strMaxstrPrjDataBaseId;
        }

        [WebMethod]
        public bool PrjDataBase_AddNewRecordBySql2(clsPrjDataBaseEN objPrjDataBaseEN)
        {
            bool bolResult = clsPrjDataBaseBL.AddNewRecordBySql2(objPrjDataBaseEN);
            return bolResult;
        }

        [WebMethod]
        public string PrjDataBase_AddNewRecordBySql2WithReturnKey(clsPrjDataBaseEN objPrjDataBaseEN)
        {
            try
            {
                string strKey = clsPrjDataBaseBL.AddNewRecordBySql2WithReturnKey(objPrjDataBaseEN);
                return strKey;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool PrjDataBase_AddNewRecordBySql_XML(string strPrjDataBaseENObjXml)
        {
            bool bolResult = clsPrjDataBaseBL.AddNewRecordBySql_XML(strPrjDataBaseENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool PrjDataBase_UpdateBySql2(clsPrjDataBaseEN objPrjDataBaseEN)
        {
            bool bolResult = clsPrjDataBaseBL.UpdateBySql2(objPrjDataBaseEN);
            return bolResult;
        }

        [WebMethod]
        public bool PrjDataBase_UpdateBySqlWithCondition(clsPrjDataBaseEN objPrjDataBaseEN, string strCondition)
        {
            try
            {
                bool bolResult = clsPrjDataBaseBL.UpdateBySqlWithCondition(objPrjDataBaseEN, strCondition);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("修改记录出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool PrjDataBase_UpdateBySql_XML(string strPrjDataBaseENObjXml)
        {
            bool bolResult = clsPrjDataBaseBL.UpdateBySql_XML(strPrjDataBaseENObjXml);
            return bolResult;
        }

        [WebMethod]
        public bool PrjDataBase_DelRecord(string strPrjDataBaseId)
        {
            bool bolResult = clsPrjDataBaseBL.DelRecord(strPrjDataBaseId);
            return bolResult;
        }

        [WebMethod]
        public bool PrjDataBase_DelPrjDataBases(List<string> arrPrjDataBaseId)
        {
            bool bolResult = clsPrjDataBaseBL.DelPrjDataBases(arrPrjDataBaseId);
            return bolResult;
        }

        [WebMethod]
        public int PrjDataBase_DelPrjDataBasesByCond(string strWhereCond)
        {
            int intRecNum = clsPrjDataBaseBL.DelPrjDataBasesByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsPrjDataBaseEN ExposeLogicClass(clsPrjDataBaseEN objPrjDataBaseEN)
        {
            return objPrjDataBaseEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2015/06/19
        /// </summary>
        /// <param name="strPrjDataBaseId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsPrjDataBaseEN>对象XML串</returns>
        [WebMethod]
        public string PrjDataBase_SerializeObjToXMLStr(string strPrjDataBaseId)
        {
            string strXmlString = "";
            clsPrjDataBaseEN objPrjDataBaseEN = new clsPrjDataBaseEN(strPrjDataBaseId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsPrjDataBaseBL.GetPrjDataBase(ref objPrjDataBaseEN);
                strXmlString = clsPrjDataBaseBL.SerializeObjToXMLStr(objPrjDataBaseEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "PrjDataBaseService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：2015/06/19
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsPrjDataBaseEN>对象列表XML串</returns>
        [WebMethod]
        public string PrjDataBase_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsPrjDataBaseEN> lstPrjDataBaseENObjList = clsPrjDataBaseBL.GetPrjDataBaseObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsPrjDataBaseBL.SerializeObjListToXMLStr(lstPrjDataBaseENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "PrjDataBaseService");
            }
            return strXmlString;
        }
    }
}