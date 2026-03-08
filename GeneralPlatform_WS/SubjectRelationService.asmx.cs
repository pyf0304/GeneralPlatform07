///----------------------
///生成代码版本：09.08.22.1
///生成日期：2009/08/28
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
    /// SubjectRelationService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class SubjectRelationService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet SubjectRelation_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsSubjectRelationBL.GetDataSet_SubjectRelation(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet SubjectRelation_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsSubjectRelationBL.GetDataSet_SubjectRelationV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool SubjectRelation_GetSubjectRelation(ref clsSubjectRelationEN objSubjectRelation)
        {
            bool bolResult = clsSubjectRelationBL.GetSubjectRelation(ref objSubjectRelation);
            return bolResult;
        }

        [WebMethod]
        public bool SubjectRelation_GetSubjectRelationV(ref clsSubjectRelationEN objSubjectRelation)
        {
            bool bolResult = clsSubjectRelationBL.GetSubjectRelation(ref objSubjectRelation);
            return bolResult;
        }

        [WebMethod]
        public bool SubjectRelation_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsSubjectRelationBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool SubjectRelation_IsExist(long lngmId)
        {
            bool bolIsExist = clsSubjectRelationBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public bool SubjectRelation_AddNewRecordBySql2(clsSubjectRelationEN objSubjectRelation)
        {
            bool bolResult = clsSubjectRelationBL.AddNewRecordBySql2(objSubjectRelation);
            return bolResult;
        }

        [WebMethod]
        public bool SubjectRelation_UpdateBySql2(clsSubjectRelationEN objSubjectRelation)
        {
            bool bolResult = clsSubjectRelationBL.UpdateBySql2(objSubjectRelation);
            return bolResult;
        }

        [WebMethod]
        public bool SubjectRelation_DelRecord(long lngmId)
        {
            bool bolResult = clsSubjectRelationBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool SubjectRelation_DelSubjectRelations(List<string>  arrStdId)
        {
            bool bolResult = clsSubjectRelationBL.DelSubjectRelations(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsSubjectRelationEN ExposeLogicClass(clsSubjectRelationEN objSubjectRelation)
        {
            return objSubjectRelation;
        }
    }
}