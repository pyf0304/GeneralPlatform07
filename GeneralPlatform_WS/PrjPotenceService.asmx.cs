///----------------------
///生成代码版本：2010.05.04.1
///生成日期：2010/06/03
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2010.05.04.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2010.05.04.1
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
    /// PrjPotenceService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PrjPotenceService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet PrjPotence_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsPrjPotenceBL.GetDataSet_PrjPotence(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjPotence_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsPrjPotenceBL.GetDataSet_PrjPotenceV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool PrjPotence_GetPrjPotence(ref clsPrjPotenceEN objPrjPotence)
        {
            bool bolResult = clsPrjPotenceBL.GetPrjPotence(ref objPrjPotence);
            return bolResult;
        }

        [WebMethod]
        public bool PrjPotence_GetPrjPotenceV(ref clsPrjPotenceEN objPrjPotence)
        {
            bool bolResult = clsPrjPotenceBL.GetPrjPotence(ref objPrjPotence);
            return bolResult;
        }

        [WebMethod]
        public bool PrjPotence_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsPrjPotenceBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjPotence_IsExist(string strPotenceId)
        {
            bool bolIsExist = clsPrjPotenceBL.IsExist(strPotenceId);
            return bolIsExist;
        }

        [WebMethod]
        public string PrjPotence_GetMaxStrId()
        {
            string strMaxstrPotenceId = clsPrjPotenceBL.GetMaxStrId_S();
            return strMaxstrPotenceId;
        }

        [WebMethod]
        public bool PrjPotence_AddNewRecordBySql2(clsPrjPotenceEN objPrjPotence)
        {
            bool bolResult = clsPrjPotenceBL.AddNewRecordBySql2(objPrjPotence);
            return bolResult;
        }

        [WebMethod]
        public bool PrjPotence_UpdateBySql2(clsPrjPotenceEN objPrjPotence)
        {
            bool bolResult = clsPrjPotenceBL.UpdateBySql2(objPrjPotence);
            return bolResult;
        }

        [WebMethod]
        public bool PrjPotence_DelRecord(string strPotenceId)
        {
            bool bolResult = clsPrjPotenceBL.DelRecord(strPotenceId);
            return bolResult;
        }

        [WebMethod]
        public bool PrjPotence_DelPrjPotences(List<string>  arrStdId)
        {
            bool bolResult = clsPrjPotenceBL.DelPrjPotences(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsPrjPotenceEN ExposeLogicClass(clsPrjPotenceEN objPrjPotence)
        {
            return objPrjPotence;
        }
    }
}