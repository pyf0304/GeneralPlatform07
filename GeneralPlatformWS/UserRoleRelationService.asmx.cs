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
    /// UserRoleRelationService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserRoleRelationService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserRoleRelation_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserRoleRelationBL.GetDataSet_UserRoleRelation(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserRoleRelation_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserRoleRelationBL.GetDataSet_UserRoleRelationV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserRoleRelation_GetUserRoleRelation(ref clsUserRoleRelation objUserRoleRelation)
        {
            bool bolResult = clsUserRoleRelationBL.GetUserRoleRelation(ref objUserRoleRelation);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation_GetUserRoleRelationV(ref clsUserRoleRelation objUserRoleRelation)
        {
            bool bolResult = clsUserRoleRelationBL.GetUserRoleRelation(ref objUserRoleRelation);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserRoleRelationBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserRoleRelation_IsExist(long lngmId)
        {
            bool bolIsExist = clsUserRoleRelationBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserRoleRelation_AddNewRecordBySql2(clsUserRoleRelation objUserRoleRelation)
        {
            bool bolResult = clsUserRoleRelationBL.AddNewRecordBySql2(objUserRoleRelation);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation_UpdateBySql2(clsUserRoleRelation objUserRoleRelation)
        {
            bool bolResult = clsUserRoleRelationBL.UpdateBySql2(objUserRoleRelation);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation_DelRecord(long lngmId)
        {
            bool bolResult = clsUserRoleRelationBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation_DelUserRoleRelations(ArrayList arrStdId)
        {
            bool bolResult = clsUserRoleRelationBL.DelUserRoleRelations(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsUserRoleRelation ExposeLogicClass(clsUserRoleRelation objUserRoleRelation)
        {
            return objUserRoleRelation;
        }
    }
}