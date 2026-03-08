///----------------------
///生成代码版本：8.2.0.0
///生成日期：2008/11/16
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：08.11.15.2
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
    /// UserRoleRelation2Service 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserRoleRelation2Service : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserRoleRelation2_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserRoleRelation2BL.GetDataSet_UserRoleRelation2(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserRoleRelation2_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserRoleRelation2BL.GetDataSet_UserRoleRelation2V(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserRoleRelation2_GetUserRoleRelation2(ref clsUserRoleRelation2 objUserRoleRelation2)
        {
            bool bolResult = clsUserRoleRelation2BL.GetUserRoleRelation2(ref objUserRoleRelation2);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation2_GetUserRoleRelation2V(ref clsUserRoleRelation2 objUserRoleRelation2)
        {
            bool bolResult = clsUserRoleRelation2BL.GetUserRoleRelation2(ref objUserRoleRelation2);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation2_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserRoleRelation2BL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserRoleRelation2_IsExist(string strUserId, string strRoleId)
        {
            bool bolIsExist = clsUserRoleRelation2BL.IsExist(strUserId, strRoleId);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserRoleRelation2_AddNewRecordBySql2(clsUserRoleRelation2 objUserRoleRelation2)
        {
            bool bolResult = clsUserRoleRelation2BL.AddNewRecordBySql2(objUserRoleRelation2);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation2_UpdateBySql2(clsUserRoleRelation2 objUserRoleRelation2)
        {
            bool bolResult = clsUserRoleRelation2BL.UpdateBySql2(objUserRoleRelation2);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation2_DelRecord(string strUserId, string strRoleId)
        {
            bool bolResult = clsUserRoleRelation2BL.DelRecord(strUserId, strRoleId);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoleRelation2_DelUserRoleRelation2s(ArrayList arrStdId)
        {
            bool bolResult = clsUserRoleRelation2BL.DelUserRoleRelation2s(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsUserRoleRelation2 ExposeLogicClass(clsUserRoleRelation2 objUserRoleRelation2)
        {
            return objUserRoleRelation2;
        }

        //[WebMethod]
        //public clsUserRoleRelation2Ex ExposeLogicExClass(clsUserRoleRelation2Ex objUserRoleRelation2)
        //{
        //    return objUserRoleRelation2;
        //}
    }
}