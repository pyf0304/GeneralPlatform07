
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
    /// vUserDownLoadDetailLogService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vUserDownLoadDetailLogService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vUserDownLoadDetailLog_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsvUserDownLoadDetailLogBL.GetDataSet_vUserDownLoadDetailLog(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet vUserDownLoadDetailLog_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsvUserDownLoadDetailLogBL.GetDataSet_vUserDownLoadDetailLogByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public bool vUserDownLoadDetailLog_GetvUserDownLoadDetailLog(ref clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN)
        {
            bool bolResult = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLog(ref objvUserDownLoadDetailLogEN);
            return bolResult;
        }

        [WebMethod]
        public clsvUserDownLoadDetailLogEN vUserDownLoadDetailLog_GetvUserDownLoadDetailLogBymId(long lngmId)
        {
            clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogBymId(lngmId);
            return objvUserDownLoadDetailLogEN;
        }

        [WebMethod]
        public bool vUserDownLoadDetailLog_GetvUserDownLoadDetailLogV(ref clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN)
        {
            bool bolResult = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLog(ref objvUserDownLoadDetailLogEN);
            return bolResult;
        }

        [WebMethod]
        public List<clsvUserDownLoadDetailLogEN> vUserDownLoadDetailLog_GetvUserDownLoadDetailLogObjList(string strWhereCond)
        {
            List<clsvUserDownLoadDetailLogEN> arrvUserDownLoadDetailLogObjLst = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObjList(strWhereCond);
            return arrvUserDownLoadDetailLogObjLst;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [WebMethod]
        public long vUserDownLoadDetailLog_GetFirstID_S(string strCondition)
        {
            long lngmId;
            try
            {
                lngmId = clsvUserDownLoadDetailLogBL.GetFirstID_S(strCondition);
                return lngmId;
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
        public clsvUserDownLoadDetailLogEN vUserDownLoadDetailLog_GetFirstvUserDownLoadDetailLog_S(string strCondition)
        {
            try
            {
                clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = clsvUserDownLoadDetailLogBL.GetFirstvUserDownLoadDetailLog_S(strCondition);
                return objvUserDownLoadDetailLogEN;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First记录对象出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool vUserDownLoadDetailLog_IsExistRecord(string strWhereCond)
        {
            bool bolIsExist = clsvUserDownLoadDetailLogBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vUserDownLoadDetailLog_IsExist(long lngmId)
        {
            bool bolIsExist = clsvUserDownLoadDetailLogBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public clsvUserDownLoadDetailLogEN ExposeLogicClass(clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN)
        {
            return objvUserDownLoadDetailLogEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="lngmId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsvUserDownLoadDetailLogEN>对象XML串</returns>
        [WebMethod]
        public string vUserDownLoadDetailLog_SerializeObjToXMLStr(long lngmId)
        {
            string strXmlString = "";
            clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = new clsvUserDownLoadDetailLogEN(lngmId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLog(ref objvUserDownLoadDetailLogEN);
                strXmlString = clsvUserDownLoadDetailLogBL.SerializeObjToXMLStr(objvUserDownLoadDetailLogEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vUserDownLoadDetailLogService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsvUserDownLoadDetailLogEN>对象列表XML串</returns>
        [WebMethod]
        public string vUserDownLoadDetailLog_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsvUserDownLoadDetailLogEN> lstvUserDownLoadDetailLogENObjList = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsvUserDownLoadDetailLogBL.SerializeObjListToXMLStr(lstvUserDownLoadDetailLogENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vUserDownLoadDetailLogService");
            }
            return strXmlString;
        }
    }
}