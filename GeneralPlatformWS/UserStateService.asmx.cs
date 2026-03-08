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
    /// UserStateService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class UserStateService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet UserState_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsUserStateBL.GetDataSet_UserState(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet UserState_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsUserStateBL.GetDataSet_UserStateV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool UserState_GetUserState(ref clsUserState objUserState)
        {
            bool bolResult = clsUserStateBL.GetUserState(ref objUserState);
            return bolResult;
        }

        [WebMethod]
        public bool UserState_GetUserStateV(ref clsUserState objUserState)
        {
            bool bolResult = clsUserStateBL.GetUserState(ref objUserState);
            return bolResult;
        }

        [WebMethod]
        public bool UserState_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsUserStateBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserState_IsExist(string strUserStateId)
        {
            bool bolIsExist = clsUserStateBL.IsExist(strUserStateId);
            return bolIsExist;
        }

        [WebMethod]
        public bool UserState_AddNewRecordBySql2(clsUserState objUserState)
        {
            bool bolResult = clsUserStateBL.AddNewRecordBySql2(objUserState);
            return bolResult;
        }

        [WebMethod]
        public bool UserState_UpdateBySql2(clsUserState objUserState)
        {
            bool bolResult = clsUserStateBL.UpdateBySql2(objUserState);
            return bolResult;
        }

        [WebMethod]
        public bool UserState_DelRecord(string strUserStateId)
        {
            bool bolResult = clsUserStateBL.DelRecord(strUserStateId);
            return bolResult;
        }

        [WebMethod]
        public bool UserState_DelUserStates(ArrayList arrStdId)
        {
            bool bolResult = clsUserStateBL.DelUserStates(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsUserState ExposeLogicClass(clsUserState objUserState)
        {
            return objUserState;
        }
    }
}