
//----------------------
//生成代码版本：2014.10.06.1
//生成日期：2014/10/17
//生成者：潘以锋
//工程名称：统一平台
//工程ID：0014
//模块中文名：用户管理
//模块英文名：UserManage
//注意：1、需要数据底层（PubDataBase.dll）的版本：2014.10.06.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2014.10.06.1
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
    /// vUserRoleRelationService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vUserRoleRelationService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vUserRoleRelation_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsvUserRoleRelationBL.GetDataSet_vUserRoleRelation(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet vUserRoleRelation_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            DataSet objDS = clsvUserRoleRelationBL.GetDataSet_vUserRoleRelationByRange(strWhereCond, lngMinNum, lngMaxNum);
            return objDS;
        }

        [WebMethod]
        public bool vUserRoleRelation_GetvUserRoleRelation(ref clsvUserRoleRelationEN objvUserRoleRelationEN)
        {
            bool bolResult = clsvUserRoleRelationBL.GetvUserRoleRelation(ref objvUserRoleRelationEN);
            return bolResult;
        }

        [WebMethod]
        public clsvUserRoleRelationEN vUserRoleRelation_GetvUserRoleRelationBymId(long lngmId)
        {
            clsvUserRoleRelationEN objvUserRoleRelationEN = clsvUserRoleRelationBL.GetvUserRoleRelationBymId(lngmId);
            return objvUserRoleRelationEN;
        }

        [WebMethod]
        public bool vUserRoleRelation_GetvUserRoleRelationV(ref clsvUserRoleRelationEN objvUserRoleRelationEN)
        {
            bool bolResult = clsvUserRoleRelationBL.GetvUserRoleRelation(ref objvUserRoleRelationEN);
            return bolResult;
        }

        [WebMethod]
        public List<clsvUserRoleRelationEN> vUserRoleRelation_GetvUserRoleRelationObjList(string strWhereCond)
        {
            List<clsvUserRoleRelationEN> arrvUserRoleRelationObjLst = clsvUserRoleRelationBL.GetvUserRoleRelationObjList(strWhereCond);
            return arrvUserRoleRelationObjLst;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        [WebMethod]
        public long vUserRoleRelation_GetFirstID_S(string strCondition)
        {
            long lngmId;
            try
            {
                lngmId = clsvUserRoleRelationBL.GetFirstID_S(strCondition);
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
        public clsvUserRoleRelationEN vUserRoleRelation_GetFirstvUserRoleRelation_S(string strCondition)
        {
            try
            {
                clsvUserRoleRelationEN objvUserRoleRelationEN = clsvUserRoleRelationBL.GetFirstvUserRoleRelation_S(strCondition);
                return objvUserRoleRelationEN;
            }
            catch (Exception objException)
            {
                throw new Exception("获取First记录对象出错！\r\n" + objException.Message);
            }
        }

        [WebMethod]
        public bool vUserRoleRelation_IsExistRecord(string strWhereCond)
        {
            bool bolIsExist = clsvUserRoleRelationBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vUserRoleRelation_IsExist(long lngmId)
        {
            bool bolIsExist = clsvUserRoleRelationBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public clsvUserRoleRelationEN ExposeLogicClass(clsvUserRoleRelationEN objvUserRoleRelationEN)
        {
            return objvUserRoleRelationEN;
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// 作者：潘以锋
        /// 日期：2014/10/17
        /// </summary>
        /// <param name="lngmId">需要序列化的对象关键字</param>
        /// <returns>返回一个<clsvUserRoleRelationEN>对象XML串</returns>
        [WebMethod]
        public string vUserRoleRelation_SerializeObjToXMLStr(long lngmId)
        {
            string strXmlString = "";
            clsvUserRoleRelationEN objvUserRoleRelationEN = new clsvUserRoleRelationEN(lngmId);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                clsvUserRoleRelationBL.GetvUserRoleRelation(ref objvUserRoleRelationEN);
                strXmlString = clsvUserRoleRelationBL.SerializeObjToXMLStr(objvUserRoleRelationEN);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vUserRoleRelationService");
            }
            return strXmlString;
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// 作者：潘以锋
        /// 日期：2014/10/17
        /// </summary>
        /// <param name="strWhereCond">需要序列化的对象列表的条件串</param>
        /// <returns>返回一个<clsvUserRoleRelationEN>对象列表XML串</returns>
        [WebMethod]
        public string vUserRoleRelation_SerializeObjListToXMLStr(string strWhereCond)
        {
            string strXmlString = "";
            List<clsvUserRoleRelationEN> lstvUserRoleRelationENObjList = clsvUserRoleRelationBL.GetvUserRoleRelationObjList(strWhereCond);
            try
            {
                clsPubVar.objLog.WriteDebugLog("XML输出文件：" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
                strXmlString = clsvUserRoleRelationBL.SerializeObjListToXMLStr(lstvUserRoleRelationENObjList);
            }
            catch (Exception objException)
            {
                clsPubVar.objLog.WriteDebugLog(objException.Message);
                clsLog.LogErrorS(objException, "vUserRoleRelationService");
            }
            return strXmlString;
        }
    }
}