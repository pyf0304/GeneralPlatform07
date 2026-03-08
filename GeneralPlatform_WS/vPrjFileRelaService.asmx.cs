
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
    /// vPrjFileRelaService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vPrjFileRelaService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vPrjFileRela_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsvPrjFileRelaBL.GetDataSet_vPrjFileRela(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet vPrjFileRela_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsvPrjFileRelaBL.GetDataSet_vPrjFileRelaByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public bool vPrjFileRela_GetvPrjFileRela(ref clsvPrjFileRelaEN objvPrjFileRelaEN)
        {
            bool bolResult = clsvPrjFileRelaBL.GetvPrjFileRela(ref objvPrjFileRelaEN);
            return bolResult;
        }

        [WebMethod]
        public clsvPrjFileRelaEN vPrjFileRela_GetvPrjFileRelaBymId(long lngmId)
        {
            clsvPrjFileRelaEN objvPrjFileRelaEN = clsvPrjFileRelaBL.GetvPrjFileRelaBymId(lngmId);
            return objvPrjFileRelaEN;
        }

        [WebMethod]
        public bool vPrjFileRela_GetvPrjFileRelaV(ref clsvPrjFileRelaEN objvPrjFileRelaEN)
        {
            bool bolResult = clsvPrjFileRelaBL.GetvPrjFileRela(ref objvPrjFileRelaEN);
            return bolResult;
        }

        [WebMethod]
        public List<clsvPrjFileRelaEN> vPrjFileRela_GetvPrjFileRelaObjList(string strWhereCond)
        {
            List<clsvPrjFileRelaEN> arrvPrjFileRelaObjLst = clsvPrjFileRelaBL.GetvPrjFileRelaObjList(strWhereCond);
            return arrvPrjFileRelaObjLst;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [WebMethod]
        public long vPrjFileRela_GetFirstID_S(string strCondition)
        {
            long lngmId;
            try
            {
                lngmId = clsvPrjFileRelaBL.GetFirstID_S(strCondition);
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
        public clsvPrjFileRelaEN vPrjFileRela_GetFirstvPrjFileRela_S(string strCondition)
        {
            try
            {
                clsvPrjFileRelaEN objvPrjFileRelaEN = clsvPrjFileRelaBL.GetFirstvPrjFileRela_S(strCondition);
                return objvPrjFileRelaEN;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First记录对象出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool vPrjFileRela_IsExistRecord(string strWhereCond)
        {
            bool bolIsExist = clsvPrjFileRelaBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vPrjFileRela_IsExist(long lngmId)
        {
            bool bolIsExist = clsvPrjFileRelaBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public clsvPrjFileRelaEN ExposeLogicClass(clsvPrjFileRelaEN objvPrjFileRelaEN)
        {
            return objvPrjFileRelaEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="lngmId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsvPrjFileRelaEN>对象XML串</returns>
        [WebMethod]
        public string vPrjFileRela_SerializeObjToXMLStr(long lngmId)
        {
            string strXmlString = "";
            clsvPrjFileRelaEN objvPrjFileRelaEN = new clsvPrjFileRelaEN(lngmId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsvPrjFileRelaBL.GetvPrjFileRela(ref objvPrjFileRelaEN);
                strXmlString = clsvPrjFileRelaBL.SerializeObjToXMLStr(objvPrjFileRelaEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vPrjFileRelaService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsvPrjFileRelaEN>对象列表XML串</returns>
        [WebMethod]
        public string vPrjFileRela_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsvPrjFileRelaEN> lstvPrjFileRelaENObjList = clsvPrjFileRelaBL.GetvPrjFileRelaObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsvPrjFileRelaBL.SerializeObjListToXMLStr(lstvPrjFileRelaENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vPrjFileRelaService");
            }
            return strXmlString;
        }
    }
}