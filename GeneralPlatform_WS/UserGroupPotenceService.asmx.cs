///----------------------
///生成代码版本：2010.05.04.1
///生成日期：2010/06/04
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
    /// UserGroupPotenceService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserGroupPotenceService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserGroupPotence_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserGroupPotenceBL.GetDataSet_UserGroupPotence(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserGroupPotence_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserGroupPotenceBL.GetDataSet_UserGroupPotenceV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserGroupPotence_GetUserGroupPotence(ref clsUserGroupPotenceEN objUserGroupPotence)
        {
            bool bolResult = clsUserGroupPotenceBL.GetUserGroupPotence(ref objUserGroupPotence);
            return bolResult;
        }

        [WebMethod]
        public bool UserGroupPotence_GetUserGroupPotenceV(ref clsUserGroupPotenceEN objUserGroupPotence)
        {
            bool bolResult = clsUserGroupPotenceBL.GetUserGroupPotence(ref objUserGroupPotence);
            return bolResult;
        }

        [WebMethod]
        public bool UserGroupPotence_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserGroupPotenceBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserGroupPotence_IsExist(long lngmId)
        {
            bool bolIsExist = clsUserGroupPotenceBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public string UserGroupPotence_GetMaxStrId()
        {
            string strMaxlngmId = clsUserGroupPotenceBL.GetMaxStrId_S();
            return strMaxlngmId;
        }

        [WebMethod]
        public bool UserGroupPotence_AddNewRecordBySql2(clsUserGroupPotenceEN objUserGroupPotence)
        {
            bool bolResult = clsUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
            return bolResult;
        }

        [WebMethod]
        public bool UserGroupPotence_UpdateBySql2(clsUserGroupPotenceEN objUserGroupPotence)
        {
            bool bolResult = clsUserGroupPotenceBL.UpdateBySql2(objUserGroupPotence);
            return bolResult;
        }

        [WebMethod]
        public bool UserGroupPotence_DelRecord(long lngmId)
        {
            bool bolResult = clsUserGroupPotenceBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool UserGroupPotence_DelUserGroupPotences(List<string>  arrStdId)
        {
            bool bolResult = clsUserGroupPotenceBL.DelUserGroupPotences(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public int UserGroupPotence_DelUserGroupPotencesByCond(string strWhereCond)
        {
            int intRecNum = clsUserGroupPotenceBL.DelUserGroupPotencesByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsUserGroupPotenceEN ExposeLogicClass(clsUserGroupPotenceEN objUserGroupPotence)
        {
            return objUserGroupPotence;
        }
    }
}