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
            string strMsg = string.Format("函数：UserRoleRelation_GetDataSet；参数：strWhereCond={0}", strWhereCond);
            clsPubVar.objLog.WriteDebugLog(strMsg);
            DataSet objDS = clsUserRoleRelationBL.GetDataSet_UserRoleRelation(strWhereCond);
            strMsg = string.Format("记录数：{0}", objDS.Tables[0].Rows.Count);
            clsPubVar.objLog.WriteDebugLog(strMsg);
            return objDS;
        }

        [WebMethod]
        public DataSet UserRoleRelation_GetDataSetV(string strWhereCond)
        {
            string strMsg = string.Format("函数：UserRoleRelation_GetDataSetV；参数：strWhereCond={0}", strWhereCond);
            clsPubVar.objLog.WriteDebugLog(strMsg);
            DataSet objDS = clsUserRoleRelationBL.GetDataSet_UserRoleRelationV(strWhereCond);
            strMsg = string.Format("记录数：{0}", objDS.Tables[0].Rows.Count);
            clsPubVar.objLog.WriteDebugLog(strMsg);
            return objDS;
        }

        [WebMethod]
        public bool UserRoleRelation_GetUserRoleRelation(ref clsUserRoleRelationEN objUserRoleRelation)
        {
            bool bolResult = clsUserRoleRelationBL.GetUserRoleRelation(ref objUserRoleRelation);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation_GetUserRoleRelationV(ref clsUserRoleRelationEN objUserRoleRelation)
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
        public bool UserRoleRelation_AddNewRecordBySql2(clsUserRoleRelationEN objUserRoleRelation)
        {
            bool bolResult = clsUserRoleRelationBL.AddNewRecordBySql2(objUserRoleRelation);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation_UpdateBySql2(clsUserRoleRelationEN objUserRoleRelation)
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
        public bool UserRoleRelation_DelUserRoleRelations(List<string>  arrStdId)
        {
            bool bolResult = clsUserRoleRelationBL.DelUserRoleRelations(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public int UserRoleRelation_DelUserRoleRelationsByCond(string strWhereCond)
        {
            int intRecNum = clsUserRoleRelationBL.DelUserRoleRelationsByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsUserRoleRelationEN ExposeLogicClass(clsUserRoleRelationEN objUserRoleRelation)
        {
            return objUserRoleRelation;
        }
    }
}