///----------------------
///生成代码版本：8.2.0.0
///生成日期：2009/06/07
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.01.02.2
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceUsers;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 用户(Users)
    /// </summary>
    public class clsUsersWS
    {

        private static UsersServiceSoapClient objUsersServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UsersServiceSoapClient GetUsersServiceSoapClient()
        {
            if (objUsersServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UsersServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                //binding.maxBufferSize = 2147483647;
                //binding.maxBufferPoolSize = 2147483647; 

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/UsersService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UsersService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UsersService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/UsersService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new UsersServiceSoapClient(binding, address);
            }
            else
            {
                return objUsersServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsUsersWS()
        {
        }


       /// <summary>
       /// 
       /// </summary>
       /// <param name="strWhereCond"></param>
       /// <returns></returns>
        public static DataTable GetDataTable_UsersWs(string strWhereCond)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUsersService.Users_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:Users 数据出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static DataTable GetDataTable_UsersVWs(string strWhereCond)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            
            DataSet objDS = null;
            try
            {
                objDS = objUsersService.Users_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:Users View 数据出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static DataTable GetUsersVWs(string strWhereCond)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            
            DataSet objDS = null;
            try
            {
                objDS = objUsersService.Users_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUsers"></param>
        /// <returns></returns>
        public static bool GetUsersWs(ref clsUsersEN objUsers)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            
            bool bolResult = objUsersService.Users_GetUsers(ref objUsers);
            return bolResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static List<clsUsersEN> GetUsersObjList(string strCondition)
        {
            List<clsUsersEN> arrObjList = new List<clsUsersEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_UsersWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUsersEN objUsers = new clsUsersEN();
                objUsers.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUsers.UserName = objRow["UserName"].ToString().Trim(); //用户名
                objUsers.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
                objUsers.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
                objUsers.Password = objRow["Password"].ToString().Trim(); //口令
                objUsers.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
                objUsers.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUsers);
            }
            objDT = null;
            return arrObjList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool DelRecordWs(string strUserId)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            
            try
            {
                bool bolResult = objUsersService.Users_DelRecord(strUserId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrStdId"></param>
        /// <returns></returns>
        public static bool DelUserssWs(List<string>  arrStdId)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            
            try
            {
                string[] sstrUserId = (string[])(arrStdId.ToArray());
                bool bolResult = objUsersService.Users_DelUserss(sstrUserId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUsers"></param>
        /// <returns></returns>
        public static bool AddNewRecordBySql2Ws(clsUsersEN objUsers)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            try
            {
                bool bolResult = objUsersService.Users_AddNewRecordBySql2(objUsers);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUsers"></param>
        /// <returns></returns>
        public static bool UpdateBySql2Ws(clsUsersEN objUsers)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            try
            {
                bool bolResult = objUsersService.Users_UpdateBySql2(objUsers);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            bool bolIsExist = objUsersService.Users_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool IsExistWs(string strUserId)
        {
            //检测记录是否存在
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            bool bolIsExist = objUsersService.Users_IsExist(strUserId);
            return bolIsExist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static clsUsersEN GetUsersWs(string strUserId)
        {
            UsersServiceSoapClient objUsersService = GetUsersServiceSoapClient();
            clsUsersEN objUsers = new clsUsersEN();
            objUsers.UserId = strUserId;
            bool bolResult = objUsersService.Users_GetUsers(ref objUsers);
            return objUsers;
        }
    }
}