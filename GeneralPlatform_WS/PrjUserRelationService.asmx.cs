///----------------------
///生成代码版本：09.08.22.1
///生成日期：2009/09/29
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
    /// PrjUserRelationService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class PrjUserRelationService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet PrjUserRelation_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsPrjUserRelationBL.GetDataSet_PrjUserRelation(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet PrjUserRelation_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsPrjUserRelationBL.GetDataSet_PrjUserRelationV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool PrjUserRelation_GetPrjUserRelation(ref clsPrjUserRelationEN objPrjUserRelation)
        {
            bool bolResult = clsPrjUserRelationBL.GetPrjUserRelation(ref objPrjUserRelation);
            return bolResult;
        }

        [WebMethod]
        public bool PrjUserRelation_GetPrjUserRelationV(ref clsPrjUserRelationEN objPrjUserRelation)
        {
            bool bolResult = clsPrjUserRelationBL.GetPrjUserRelation(ref objPrjUserRelation);
            return bolResult;
        }

        [WebMethod]
        public bool PrjUserRelation_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsPrjUserRelationBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjUserRelation_IsExist(long lngmId)
        {
            bool bolIsExist = clsPrjUserRelationBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public bool PrjUserRelation_AddNewRecordBySql2(clsPrjUserRelationEN objPrjUserRelation)
        {
            bool bolResult = clsPrjUserRelationBL.AddNewRecordBySql2(objPrjUserRelation);
            return bolResult;
        }

        [WebMethod]
        public bool PrjUserRelation_UpdateBySql2(clsPrjUserRelationEN objPrjUserRelation)
        {
            bool bolResult = clsPrjUserRelationBL.UpdateBySql2(objPrjUserRelation);
            return bolResult;
        }

        [WebMethod]
        public bool PrjUserRelation_DelRecord(long lngmId)
        {
            bool bolResult = clsPrjUserRelationBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool PrjUserRelation_DelPrjUserRelations(List<string>  arrStdId)
        {
            bool bolResult = clsPrjUserRelationBL.DelPrjUserRelations(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsPrjUserRelationEN ExposeLogicClass(clsPrjUserRelationEN objPrjUserRelation)
        {
            return objPrjUserRelation;
        }
    }
}