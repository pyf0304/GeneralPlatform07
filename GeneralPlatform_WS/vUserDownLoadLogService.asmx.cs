
//----------------------
//生成代码版本：2014.10.27.1
//生成日期：2014/11/03
//生成者：潘以锋
//工程名称：统一平台
//工程ID：0014
//模块中文名：工程文件下载
//模块英文名：PrjFileDownLoad
//注意：1、需要数据底层（PubDataBase.dll）的版本：2014.10.28.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2014.10.28.1
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
    /// vUserDownLoadLogService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vUserDownLoadLogService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vUserDownLoadLog_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsvUserDownLoadLogBL.GetDataSet_vUserDownLoadLog(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet vUserDownLoadLog_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsvUserDownLoadLogBL.GetDataSet_vUserDownLoadLogByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public bool vUserDownLoadLog_GetvUserDownLoadLog(ref clsvUserDownLoadLogEN objvUserDownLoadLogEN)
        {
            bool bolResult = clsvUserDownLoadLogBL.GetvUserDownLoadLog(ref objvUserDownLoadLogEN);
            return bolResult;
        }

        [WebMethod]
        public clsvUserDownLoadLogEN vUserDownLoadLog_GetvUserDownLoadLogByUserDownLoadLogId(string strUserDownLoadLogId)
        {
            clsvUserDownLoadLogEN objvUserDownLoadLogEN = clsvUserDownLoadLogBL.GetvUserDownLoadLogByUserDownLoadLogId(strUserDownLoadLogId);
            return objvUserDownLoadLogEN;
        }

        [WebMethod]
        public bool vUserDownLoadLog_GetvUserDownLoadLogV(ref clsvUserDownLoadLogEN objvUserDownLoadLogEN)
        {
            bool bolResult = clsvUserDownLoadLogBL.GetvUserDownLoadLog(ref objvUserDownLoadLogEN);
            return bolResult;
        }

        [WebMethod]
        public List<clsvUserDownLoadLogEN> vUserDownLoadLog_GetvUserDownLoadLogObjList(string strWhereCond)
        {
            List<clsvUserDownLoadLogEN> arrvUserDownLoadLogObjLst = clsvUserDownLoadLogBL.GetvUserDownLoadLogObjList(strWhereCond);
            return arrvUserDownLoadLogObjLst;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [WebMethod]
        public string vUserDownLoadLog_GetFirstID_S(string strCondition)
        {
            string strUserDownLoadLogId;
            try
            {
                strUserDownLoadLogId = clsvUserDownLoadLogBL.GetFirstID_S(strCondition);
                return strUserDownLoadLogId;
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
        public clsvUserDownLoadLogEN vUserDownLoadLog_GetFirstvUserDownLoadLog_S(string strCondition)
        {
            try
            {
                clsvUserDownLoadLogEN objvUserDownLoadLogEN = clsvUserDownLoadLogBL.GetFirstvUserDownLoadLog_S(strCondition);
                return objvUserDownLoadLogEN;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First记录对象出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool vUserDownLoadLog_IsExistRecord(string strWhereCond)
        {
            bool bolIsExist = clsvUserDownLoadLogBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vUserDownLoadLog_IsExist(string strUserDownLoadLogId)
        {
            bool bolIsExist = clsvUserDownLoadLogBL.IsExist(strUserDownLoadLogId);
            return bolIsExist;
        }

        [WebMethod]
        public clsvUserDownLoadLogEN ExposeLogicClass(clsvUserDownLoadLogEN objvUserDownLoadLogEN)
        {
            return objvUserDownLoadLogEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="strUserDownLoadLogId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsvUserDownLoadLogEN>对象XML串</returns>
        [WebMethod]
        public string vUserDownLoadLog_SerializeObjToXMLStr(string strUserDownLoadLogId)
        {
            string strXmlString = "";
            clsvUserDownLoadLogEN objvUserDownLoadLogEN = new clsvUserDownLoadLogEN(strUserDownLoadLogId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsvUserDownLoadLogBL.GetvUserDownLoadLog(ref objvUserDownLoadLogEN);
                strXmlString = clsvUserDownLoadLogBL.SerializeObjToXMLStr(objvUserDownLoadLogEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vUserDownLoadLogService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsvUserDownLoadLogEN>对象列表XML串</returns>
        [WebMethod]
        public string vUserDownLoadLog_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsvUserDownLoadLogEN> lstvUserDownLoadLogENObjList = clsvUserDownLoadLogBL.GetvUserDownLoadLogObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsvUserDownLoadLogBL.SerializeObjListToXMLStr(lstvUserDownLoadLogENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vUserDownLoadLogService");
            }
            return strXmlString;
        }
    }
}