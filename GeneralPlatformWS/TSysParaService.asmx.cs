///----------------------
///生成代码版本：7.0.0.0
///生成日期：2008/11/12
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：8.0.0.5
///========================
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using GeneralPlatform;
using com.taishsoft.commdb;

namespace GeneralPlatformWS
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
            DataSet objDS = clsTSysPara.GetDataSet_TSysPara(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet TSysPara_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsTSysPara.GetDataSet_TSysParaV(strWhereCond);
            return objDS;
        }

        //[WebMethod]
        //public bool TSysPara_GetTSysPara(ref clsTSysPara objTSysPara)
        //{
        //    bool bolResult = objTSysPara.GetTSysPara();
        //    return bolResult;
        //}

        //[WebMethod]
        //public bool TSysPara_GetTSysParaV(ref clsTSysPara objTSysPara)
        //{
        //    bool bolResult = objTSysPara.GetTSysPara();
        //    return bolResult;
        //}

        [WebMethod]
        public bool TSysPara_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsTSysPara.IsExistCondRec("TSysPara", strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool TSysPara_IsExist(long lngmId)
        {
            bool bolIsExist = clsTSysPara.IsExist(lngmId);
            return bolIsExist;
        }

        //[WebMethod]
        //public bool TSysPara_AddNewRecordBySql2(clsTSysPara objTSysPara)
        //{
        //    bool bolResult = objTSysPara.AddNewRecordBySQL2();
        //    return bolResult;
        //}

        //[WebMethod]
        //public bool TSysPara_UpdateBySql2(clsTSysPara objTSysPara)
        //{
        //    bool bolResult = objTSysPara.UpdateBySql2();
        //    return bolResult;
        //}

        [WebMethod]
        public bool TSysPara_DelRecord(long lngmId)
        {
            bool bolResult = new clsTSysPara(lngmId).DelRecordBySP();
            return bolResult;
        }

        [WebMethod]
        public bool TSysPara_DelTSysParas(ArrayList arrStdId)
        {
            bool bolResult = clsTSysPara.DelTSysPara(arrStdId);
            return bolResult;
        }

        //[WebMethod]
        //public clsTSysPara ExposeLogicClass(clsTSysPara objTSysPara)
        //{
        //    return objTSysPara;
        //}

        //[WebMethod]
        //public clsTSysParaEx ExposeLogicExClass(clsTSysParaEx objTSysPara)
        //{
        //    return objTSysPara;
        //}
    }
}