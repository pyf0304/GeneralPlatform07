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
    public class clsQxUserStateWS
    {
        private static UserStateServiceSoapClient objUserStateServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserStateServiceSoapClient GetQxUserStateServiceSoapClient()
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
                    strServiceUrl = String.Format("http://{0}/{1}/UserStateService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
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
        public clsQxUserStateWS()
        {
        }


      
        public static DataTable GetDataTable_QxUserStateWs(string strWhereCond)
        {
            UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
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

        public static DataTable GetDataTable_QxUserStateVWs(string strWhereCond)
        {
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
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

        public static DataTable GetQxUserStateVWs(string strWhereCond)
        {
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
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

        public static bool GetQxUserStateWs(ref clsQxUserStateEN objUserState)
        {
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
            bool bolResult = objUserStateService.UserState_GetQxUserState(ref objUserState);
            return bolResult;
        }

        public static List<clsQxUserStateEN> GetQxUserStateObjList(string strCondition)
        {
            List<clsQxUserStateEN> arrObjList = new List<clsQxUserStateEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxUserStateWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxUserStateEN objUserState = new clsQxUserStateEN();
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
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
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

        public static bool DelQxUserStatesWs(List<string>  arrStdId)
        {
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
            try
            {
                string[] sstrUserStateId = (string[])(arrStdId.ToArray());
                bool bolResult = objUserStateService.UserState_DelQxUserStates(sstrUserStateId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsQxUserStateEN objUserState)
        {
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
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

        public static bool UpdateBySql2Ws(clsQxUserStateEN objUserState)
        {
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
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
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
            bool bolIsExist = objUserStateService.UserState_IsExistRecord(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(string strUserStateId)
        {
            //检测记录是否存在
                       UserStateServiceSoapClient objUserStateService = GetQxUserStateServiceSoapClient();
            bool bolIsExist = objUserStateService.UserState_IsExist(strUserStateId);
            return bolIsExist;
        }
    }
}