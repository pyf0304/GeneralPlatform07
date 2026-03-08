
//----------------------
//生成代码版本：2014.10.27.1
//生成日期：2014/11/03
//生成者：潘以锋
//工程名称：统一平台
//工程ID：0014
//模块中文名：权限管理
//模块英文名：PotenceMan
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
    /// vRelaOfPotenceAndSymbolService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vRelaOfPotenceAndSymbolService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vRelaOfPotenceAndSymbol_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsvRelaOfPotenceAndSymbolBL.GetDataSet_vRelaOfPotenceAndSymbol(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet vRelaOfPotenceAndSymbol_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsvRelaOfPotenceAndSymbolBL.GetDataSet_vRelaOfPotenceAndSymbolByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public bool vRelaOfPotenceAndSymbol_GetvRelaOfPotenceAndSymbol(ref clsvRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbolEN)
        {
            bool bolResult = clsvRelaOfPotenceAndSymbolBL.GetvRelaOfPotenceAndSymbol(ref objvRelaOfPotenceAndSymbolEN);
            return bolResult;
        }

        [WebMethod]
        public clsvRelaOfPotenceAndSymbolEN vRelaOfPotenceAndSymbol_GetvRelaOfPotenceAndSymbolByRelaMid(long lngRelaMid)
        {
            clsvRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbolEN = clsvRelaOfPotenceAndSymbolBL.GetvRelaOfPotenceAndSymbolByRelaMid(lngRelaMid);
            return objvRelaOfPotenceAndSymbolEN;
        }

        [WebMethod]
        public bool vRelaOfPotenceAndSymbol_GetvRelaOfPotenceAndSymbolV(ref clsvRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbolEN)
        {
            bool bolResult = clsvRelaOfPotenceAndSymbolBL.GetvRelaOfPotenceAndSymbol(ref objvRelaOfPotenceAndSymbolEN);
            return bolResult;
        }

        [WebMethod]
        public List<clsvRelaOfPotenceAndSymbolEN> vRelaOfPotenceAndSymbol_GetvRelaOfPotenceAndSymbolObjList(string strWhereCond)
        {
            List<clsvRelaOfPotenceAndSymbolEN> arrvRelaOfPotenceAndSymbolObjLst = clsvRelaOfPotenceAndSymbolBL.GetvRelaOfPotenceAndSymbolObjList(strWhereCond);
            return arrvRelaOfPotenceAndSymbolObjLst;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [WebMethod]
        public long vRelaOfPotenceAndSymbol_GetFirstID_S(string strCondition)
        {
            long lngRelaMid;
            try
            {
                lngRelaMid = clsvRelaOfPotenceAndSymbolBL.GetFirstID_S(strCondition);
                return lngRelaMid;
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
        public clsvRelaOfPotenceAndSymbolEN vRelaOfPotenceAndSymbol_GetFirstvRelaOfPotenceAndSymbol_S(string strCondition)
        {
            try
            {
                clsvRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbolEN = clsvRelaOfPotenceAndSymbolBL.GetFirstvRelaOfPotenceAndSymbol_S(strCondition);
                return objvRelaOfPotenceAndSymbolEN;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First记录对象出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool vRelaOfPotenceAndSymbol_IsExistRecord(string strWhereCond)
        {
            bool bolIsExist = clsvRelaOfPotenceAndSymbolBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vRelaOfPotenceAndSymbol_IsExist(long lngRelaMid)
        {
            bool bolIsExist = clsvRelaOfPotenceAndSymbolBL.IsExist(lngRelaMid);
            return bolIsExist;
        }

        [WebMethod]
        public clsvRelaOfPotenceAndSymbolEN ExposeLogicClass(clsvRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbolEN)
        {
            return objvRelaOfPotenceAndSymbolEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="lngRelaMid">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsvRelaOfPotenceAndSymbolEN>对象XML串</returns>
        [WebMethod]
        public string vRelaOfPotenceAndSymbol_SerializeObjToXMLStr(long lngRelaMid)
        {
            string strXmlString = "";
            clsvRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbolEN = new clsvRelaOfPotenceAndSymbolEN(lngRelaMid);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsvRelaOfPotenceAndSymbolBL.GetvRelaOfPotenceAndSymbol(ref objvRelaOfPotenceAndSymbolEN);
                strXmlString = clsvRelaOfPotenceAndSymbolBL.SerializeObjToXMLStr(objvRelaOfPotenceAndSymbolEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vRelaOfPotenceAndSymbolService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：2014/11/03
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsvRelaOfPotenceAndSymbolEN>对象列表XML串</returns>
        [WebMethod]
        public string vRelaOfPotenceAndSymbol_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsvRelaOfPotenceAndSymbolEN> lstvRelaOfPotenceAndSymbolENObjList = clsvRelaOfPotenceAndSymbolBL.GetvRelaOfPotenceAndSymbolObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsvRelaOfPotenceAndSymbolBL.SerializeObjListToXMLStr(lstvRelaOfPotenceAndSymbolENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vRelaOfPotenceAndSymbolService");
            }
            return strXmlString;
        }
    }
}