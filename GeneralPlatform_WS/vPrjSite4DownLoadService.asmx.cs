
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
    /// vPrjSite4DownLoadService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vPrjSite4DownLoadService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vPrjSite4DownLoad_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsvPrjSite4DownLoadBL.GetDataSet_vPrjSite4DownLoad(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet vPrjSite4DownLoad_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsvPrjSite4DownLoadBL.GetDataSet_vPrjSite4DownLoadByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public bool vPrjSite4DownLoad_GetvPrjSite4DownLoad(ref clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN)
        {
            bool bolResult = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoad(ref objvPrjSite4DownLoadEN);
            return bolResult;
        }

        [WebMethod]
        public clsvPrjSite4DownLoadEN vPrjSite4DownLoad_GetvPrjSite4DownLoadByPrjSiteId(string strPrjSiteId)
        {
            clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadByPrjSiteId(strPrjSiteId);
            return objvPrjSite4DownLoadEN;
        }

        [WebMethod]
        public bool vPrjSite4DownLoad_GetvPrjSite4DownLoadV(ref clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN)
        {
            bool bolResult = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoad(ref objvPrjSite4DownLoadEN);
            return bolResult;
        }

        [WebMethod]
        public List<clsvPrjSite4DownLoadEN> vPrjSite4DownLoad_GetvPrjSite4DownLoadObjList(string strWhereCond)
        {
            List<clsvPrjSite4DownLoadEN> arrvPrjSite4DownLoadObjLst = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObjList(strWhereCond);
            return arrvPrjSite4DownLoadObjLst;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [WebMethod]
        public string vPrjSite4DownLoad_GetFirstID_S(string strCondition)
        {
            string strPrjSiteId;
            try
            {
                strPrjSiteId = clsvPrjSite4DownLoadBL.GetFirstID_S(strCondition);
                return strPrjSiteId;
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
        public clsvPrjSite4DownLoadEN vPrjSite4DownLoad_GetFirstvPrjSite4DownLoad_S(string strCondition)
        {
            try
            {
                clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = clsvPrjSite4DownLoadBL.GetFirstvPrjSite4DownLoad_S(strCondition);
                return objvPrjSite4DownLoadEN;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First记录对象出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool vPrjSite4DownLoad_IsExistRecord(string strWhereCond)
        {
            bool bolIsExist = clsvPrjSite4DownLoadBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vPrjSite4DownLoad_IsExist(string strPrjSiteId)
        {
            bool bolIsExist = clsvPrjSite4DownLoadBL.IsExist(strPrjSiteId);
            return bolIsExist;
        }

        [WebMethod]
        public clsvPrjSite4DownLoadEN ExposeLogicClass(clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN)
        {
            return objvPrjSite4DownLoadEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="strPrjSiteId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsvPrjSite4DownLoadEN>对象XML串</returns>
        [WebMethod]
        public string vPrjSite4DownLoad_SerializeObjToXMLStr(string strPrjSiteId)
        {
            string strXmlString = "";
            clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = new clsvPrjSite4DownLoadEN(strPrjSiteId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoad(ref objvPrjSite4DownLoadEN);
                strXmlString = clsvPrjSite4DownLoadBL.SerializeObjToXMLStr(objvPrjSite4DownLoadEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vPrjSite4DownLoadService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsvPrjSite4DownLoadEN>对象列表XML串</returns>
        [WebMethod]
        public string vPrjSite4DownLoad_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsvPrjSite4DownLoadEN> lstvPrjSite4DownLoadENObjList = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsvPrjSite4DownLoadBL.SerializeObjListToXMLStr(lstvPrjSite4DownLoadENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vPrjSite4DownLoadService");
            }
            return strXmlString;
        }
    }
}