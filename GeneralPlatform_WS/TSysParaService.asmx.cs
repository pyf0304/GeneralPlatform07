///----------------------
///生成代码版本：09.08.22.1
///生成日期：2009/09/05
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.08.22.1
///========================
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.commdb;
using System.Collections.Generic;

namespace GeneralPlatform_WS
{
    /// <summary>
    /// TSysParaService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class TSysParaService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet TSysPara_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsTSysParaBL.GetDataSet_TSysPara(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet TSysPara_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsTSysParaBL.GetDataSet_TSysParaV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool TSysPara_GetTSysPara(ref clsTSysParaEN objTSysPara)
        {
            bool bolResult = clsTSysParaBL.GetTSysPara(ref objTSysPara);
            return bolResult;
        }

        [WebMethod]
        public bool TSysPara_GetTSysParaV(ref clsTSysParaEN objTSysPara)
        {
            bool bolResult = clsTSysParaBL.GetTSysPara(ref objTSysPara);
            return bolResult;
        }

        [WebMethod]
        public bool TSysPara_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsTSysParaBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool TSysPara_IsExist(long lngmId)
        {
            bool bolIsExist = clsTSysParaBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public bool TSysPara_AddNewRecordBySql2(clsTSysParaEN objTSysPara)
        {
            bool bolResult = clsTSysParaBL.AddNewRecordBySql2(objTSysPara);
            return bolResult;
        }

        [WebMethod]
        public bool TSysPara_UpdateBySql2(clsTSysParaEN objTSysPara)
        {
            bool bolResult = clsTSysParaBL.UpdateBySql2(objTSysPara);
            return bolResult;
        }

        [WebMethod]
        public bool TSysPara_DelRecord(long lngmId)
        {
            bool bolResult = clsTSysParaBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool TSysPara_DelTSysParas(List<string>  arrStdId)
        {
            bool bolResult = clsTSysParaBL.DelTSysParas(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsTSysParaEN ExposeLogicClass(clsTSysParaEN objTSysPara)
        {
            return objTSysPara;
        }
    }
}