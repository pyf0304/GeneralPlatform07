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
    /// UserMenusService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserMenusService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserMenus_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserMenusBL.GetDataSet_UserMenus(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserMenus_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserMenusBL.GetDataSet_UserMenusV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserMenus_GetUserMenus(ref clsUserMenusEN objUserMenus)
        {
            bool bolResult = clsUserMenusBL.GetUserMenus(ref objUserMenus);
            return bolResult;
        }

        [WebMethod]
        public bool UserMenus_GetUserMenusV(ref clsUserMenusEN objUserMenus)
        {
            bool bolResult = clsUserMenusBL.GetUserMenus(ref objUserMenus);
            return bolResult;
        }

        [WebMethod]
        public bool UserMenus_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserMenusBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserMenus_IsExist(long lngmId)
        {
            bool bolIsExist = clsUserMenusBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public string UserMenus_GetMaxStrId()
        {
            string strMaxlngmId = clsUserMenusBL.GetMaxStrId_S();
            return strMaxlngmId;
        }

        [WebMethod]
        public bool UserMenus_AddNewRecordBySql2(clsUserMenusEN objUserMenus)
        {
            bool bolResult = clsUserMenusBL.AddNewRecordBySql2(objUserMenus);
            return bolResult;
        }

        [WebMethod]
        public bool UserMenus_UpdateBySql2(clsUserMenusEN objUserMenus)
        {
            bool bolResult = clsUserMenusBL.UpdateBySql2(objUserMenus);
            return bolResult;
        }

        [WebMethod]
        public bool UserMenus_DelRecord(long lngmId)
        {
            bool bolResult = clsUserMenusBL.DelRecord(lngmId);
            return bolResult;
        }

        [WebMethod]
        public bool UserMenus_DelUserMenuss(List<string>  arrStdId)
        {
            bool bolResult = clsUserMenusBL.DelUserMenuss(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsUserMenusEN ExposeLogicClass(clsUserMenusEN objUserMenus)
        {
            return objUserMenus;
        }
    }
}