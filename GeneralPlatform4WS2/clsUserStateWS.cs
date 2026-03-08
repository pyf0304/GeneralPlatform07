///----------------------
///生成代码版本：8.2.0.0
///生成日期：2009/06/15
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.01.02.2
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using GeneralPlatform4WS.ServiceReferenceUserState;
using System.ServiceModel;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 用户状态(UserState)
    /// </summary>
    public class clsUserStateWS
    {
        private static UserStateServiceSoapClient objUserStateServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserStateServiceSoapClient GetUserStateServiceSoapClient()
        {
            if (objUserStateServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UserStateServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/UserStateService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UserStateService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UserStateService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/UserStateService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new UserStateServiceSoapClient(binding, address);
            }
            else
            {
                return objUserStateServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsUserStateWS()
        {
        }


      
        public static DataTable GetDataTable_UserStateWs(string strWhereCond)
        {
            UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserStateService.UserState_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserState 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_UserStateVWs(string strWhereCond)
        {
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserStateService.UserState_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserState View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetUserStateVWs(string strWhereCond)
        {
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserStateService.UserState_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetUserStateWs(ref clsUserStateEN objUserState)
        {
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            bool bolResult = objUserStateService.UserState_GetUserState(ref objUserState);
            return bolResult;
        }

        public static List<clsUserStateEN> GetUserStateObjList(string strCondition)
        {
            List<clsUserStateEN> arrObjList = new List<clsUserStateEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_UserStateWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUserStateEN objUserState = new clsUserStateEN();
                objUserState.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
                objUserState.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
                objUserState.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserState);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(string strUserStateId)
        {
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            try
            {
                bool bolResult = objUserStateService.UserState_DelRecord(strUserStateId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelUserStatesWs(List<string>  arrStdId)
        {
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            try
            {
                string[] sstrUserStateId = (string[])(arrStdId.ToArray());
                bool bolResult = objUserStateService.UserState_DelUserStates(sstrUserStateId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsUserStateEN objUserState)
        {
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            try
            {
                bool bolResult = objUserStateService.UserState_AddNewRecordBySql2(objUserState);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsUserStateEN objUserState)
        {
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            try
            {
                bool bolResult = objUserStateService.UserState_UpdateBySql2(objUserState);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            bool bolIsExist = objUserStateService.UserState_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(string strUserStateId)
        {
            //检测记录是否存在
                       UserStateServiceSoapClient objUserStateService = GetUserStateServiceSoapClient();
            bool bolIsExist = objUserStateService.UserState_IsExist(strUserStateId);
            return bolIsExist;
        }
    }
}