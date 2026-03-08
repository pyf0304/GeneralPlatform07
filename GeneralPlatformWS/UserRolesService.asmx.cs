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
    /// UserRolesService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserRolesService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserRoles_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserRolesBL.GetDataSet_UserRoles(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserRoles_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserRolesBL.GetDataSet_UserRolesV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserRoles_GetUserRoles(ref clsUserRoles objUserRoles)
        {
            bool bolResult = clsUserRolesBL.GetUserRoles(ref objUserRoles);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoles_GetUserRolesV(ref clsUserRoles objUserRoles)
        {
            bool bolResult = clsUserRolesBL.GetUserRoles(ref objUserRoles);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoles_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserRolesBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserRoles_IsExist(string strRoleId)
        {
            bool bolIsExist = clsUserRolesBL.IsExist(strRoleId);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserRoles_AddNewRecordBySql2(clsUserRoles objUserRoles)
        {
            bool bolResult = clsUserRolesBL.AddNewRecordBySql2(objUserRoles);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoles_UpdateBySql2(clsUserRoles objUserRoles)
        {
            bool bolResult = clsUserRolesBL.UpdateBySql2(objUserRoles);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoles_DelRecord(string strRoleId)
        {
            bool bolResult = clsUserRolesBL.DelRecord(strRoleId);
            return bolResult;
        }

        [WebMethod]
        public bool UserRoles_DelUserRoless(ArrayList arrStdId)
        {
            bool bolResult = clsUserRolesBL.DelUserRoless(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsUserRoles ExposeLogicClass(clsUserRoles objUserRoles)
        {
            return objUserRoles;
        }
    }
}