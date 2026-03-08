///----------------------
///生成代码版本：8.2.0.0
///生成日期：2009/06/07
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.01.02.2
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

namespace GeneralPlatform_WS
{
    /// <summary>
    /// PrjMenusService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PrjMenusService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet PrjMenus_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsPrjMenusBL.GetDataSet_PrjMenus(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjMenus_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsPrjMenusBL.GetDataSet_PrjMenusV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool PrjMenus_GetPrjMenus(ref clsPrjMenus objPrjMenus)
        {
            bool bolResult = clsPrjMenusBL.GetPrjMenus(ref objPrjMenus);
            return bolResult;
        }

        [WebMethod]
        public bool PrjMenus_GetPrjMenusV(ref clsPrjMenus objPrjMenus)
        {
            bool bolResult = clsPrjMenusBL.GetPrjMenus(ref objPrjMenus);
            return bolResult;
        }

        [WebMethod]
        public bool PrjMenus_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsPrjMenusBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjMenus_IsExist(string strMenuId)
        {
            bool bolIsExist = clsPrjMenusBL.IsExist(strMenuId);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjMenus_AddNewRecordBySql2(clsPrjMenus objPrjMenus)
        {
            bool bolResult = clsPrjMenusBL.AddNewRecordBySql2(objPrjMenus);
            return bolResult;
        }

        [WebMethod]
        public bool PrjMenus_UpdateBySql2(clsPrjMenus objPrjMenus)
        {
            bool bolResult = clsPrjMenusBL.UpdateBySql2(objPrjMenus);
            return bolResult;
        }

        [WebMethod]
        public bool PrjMenus_DelRecord(string strMenuId)
        {
            bool bolResult = clsPrjMenusBL.DelRecord(strMenuId);
            return bolResult;
        }

        [WebMethod]
        public bool PrjMenus_DelPrjMenuss(ArrayList arrStdId)
        {
            bool bolResult = clsPrjMenusBL.DelPrjMenuss(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsPrjMenus ExposeLogicClass(clsPrjMenus objPrjMenus)
        {
            return objPrjMenus;
        }
    }
}