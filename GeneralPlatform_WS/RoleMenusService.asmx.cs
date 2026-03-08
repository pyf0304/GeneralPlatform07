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
    /// RoleMenusService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class RoleMenusService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet RoleMenus_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsRoleMenusBL.GetDataSet_RoleMenus(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet RoleMenus_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsRoleMenusBL.GetDataSet_RoleMenusV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool RoleMenus_GetRoleMenus(ref clsRoleMenusEN objRoleMenus)
        {
            bool bolResult = clsRoleMenusBL.GetRoleMenus(ref objRoleMenus);
            return bolResult;
        }

        [WebMethod]
        public bool RoleMenus_GetRoleMenusV(ref clsRoleMenusEN objRoleMenus)
        {
            bool bolResult = clsRoleMenusBL.GetRoleMenus(ref objRoleMenus);
            return bolResult;
        }

        [WebMethod]
        public bool RoleMenus_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsRoleMenusBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool RoleMenus_IsExist(long lngmId)
        {
            bool bolIsExist = clsRoleMenusBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public string RoleMenus_GetMaxStrId()
        {
            string strMaxlngmId = clsRoleMenusBL.GetMaxStrId_S();
            return strMaxlngmId;
        }

        [WebMethod]
        public bool RoleMenus_AddNewRecordBySql2(clsRoleMenusEN objRoleMenus)
        {
            bool bolResult = clsRoleMenusBL.AddNewRecordBySql2(objRoleMenus);
            return bolResult;
        }

        [WebMethod]
        public bool RoleMenus_UpdateBySql2(clsRoleMenusEN objRoleMenus)
        {
            bool bolResult = clsRoleMenusBL.UpdateBySql2(objRoleMenus);
            return bolResult;
        }

        [WebMethod]
        public bool RoleMenus_DelRecord(long lngmId)
        {
            bool bolResult = clsRoleMenusBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool RoleMenus_DelRoleMenuss(List<string>  arrStdId)
        {
            bool bolResult = clsRoleMenusBL.DelRoleMenuss(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public int RoleMenus_DelRoleMenussByCond(string strWhereCond)
        {
            int intRecNum = clsRoleMenusBL.DelRoleMenussByCond(strWhereCond);
            return intRecNum;
        }

        [WebMethod]
        public clsRoleMenusEN ExposeLogicClass(clsRoleMenusEN objRoleMenus)
        {
            return objRoleMenus;
        }
    }
}