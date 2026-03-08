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
    /// UsersService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UsersService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet Users_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUsersBL.GetDataSet_Users(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet Users_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUsersBL.GetDataSet_UsersV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool Users_GetUsers(ref clsUsers objUsers)
        {
            bool bolResult = clsUsersBL.GetUsers(ref objUsers);
            return bolResult;
        }

        [WebMethod]
        public bool Users_GetUsersV(ref clsUsers objUsers)
        {
            bool bolResult = clsUsersBL.GetUsers(ref objUsers);
            return bolResult;
        }

        [WebMethod]
        public bool Users_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUsersBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool Users_IsExist(string strUserId)
        {
            bool bolIsExist = clsUsersBL.IsExist(strUserId);
            return bolIsExist;
        }

        [WebMethod]
        public bool Users_AddNewRecordBySql2(clsUsers objUsers)
        {
            bool bolResult = clsUsersBL.AddNewRecordBySql2(objUsers);
            return bolResult;
        }

        [WebMethod]
        public bool Users_UpdateBySql2(clsUsers objUsers)
        {
            bool bolResult = clsUsersBL.UpdateBySql2(objUsers);
            return bolResult;
        }

        [WebMethod]
        public bool Users_DelRecord(string strUserId)
        {
            bool bolResult = clsUsersBL.DelRecord(strUserId);
            return bolResult;
        }

        [WebMethod]
        public bool Users_DelUserss(ArrayList arrStdId)
        {
            bool bolResult = clsUsersBL.DelUserss(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsUsers ExposeLogicClass(clsUsers objUsers)
        {
            return objUsers;
        }
    }
}