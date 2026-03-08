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
using GeneralPlatform4WS.ServiceReferenceUserRoles;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 角色(UserRoles)
    /// </summary>
    public class clsUserRolesWS
    {

        private static UserRolesServiceSoapClient objUserRolesServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserRolesServiceSoapClient GetUserRolesServiceSoapClient()
        {
            if (objUserRolesServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UserRolesServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/UserRolesService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UserRolesService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UserRolesService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/UserRolesService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new UserRolesServiceSoapClient(binding, address);
            }
            else
            {
                return objUserRolesServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsUserRolesWS()
        {
        }

        /// <summary>
        /// 获取用户角色的DataTable
        /// </summary>
        /// <param name="strWhereCond">条件</param>
        /// <returns>DataTable</returns>
        public static DataTable GetDataTable_UserRolesWs(string strWhereCond)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
         
            DataSet objDS = null;
            try
            {
                objDS = objUserRolesService.UserRoles_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserRoles 数据出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static DataTable GetDataTable_UserRolesVWs(string strWhereCond)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserRolesService.UserRoles_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserRoles View 数据出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static DataTable GetUserRolesVWs(string strWhereCond)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserRolesService.UserRoles_GetDataSetV(strWhereCond);
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
        /// <param name="objUserRoles"></param>
        /// <returns></returns>
        public static bool GetUserRolesWs(ref clsUserRolesEN objUserRoles)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            bool bolResult = objUserRolesService.UserRoles_GetUserRoles(ref objUserRoles);
            return bolResult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static List<clsUserRolesEN> GetUserRolesObjList(string strCondition)
        {
            List<clsUserRolesEN> arrObjList = new List<clsUserRolesEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_UserRolesWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUserRolesEN objUserRoles = new clsUserRolesEN();
                objUserRoles.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserRoles.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
                objUserRoles.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objUserRoles.IsInUse = bool.Parse(objRow["IsInUse"].ToString().Trim()); //是否在使用

                objUserRoles.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserRoles);
            }
            objDT = null;
            return arrObjList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strRoleId"></param>
        /// <returns></returns>
        public static bool DelRecordWs(string strRoleId)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            try
            {
                bool bolResult = objUserRolesService.UserRoles_DelRecord(strRoleId);
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
        public static bool DelUserRolessWs(List<string>  arrStdId)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            try
            {
                string[] sstrRoleId = (string[])(arrStdId.ToArray());
                bool bolResult = objUserRolesService.UserRoles_DelUserRoless(sstrRoleId);
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
        /// <param name="objUserRoles"></param>
        /// <returns></returns>
        public static bool AddNewRecordBySql2Ws(clsUserRolesEN objUserRoles)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            try
            {
                bool bolResult = objUserRolesService.UserRoles_AddNewRecordBySql2(objUserRoles);
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
        /// <param name="objUserRoles"></param>
        /// <returns></returns>
        public static bool UpdateBySql2Ws(clsUserRolesEN objUserRoles)
        {
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            try
            {
                bool bolResult = objUserRolesService.UserRoles_UpdateBySql2(objUserRoles);
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
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            bool bolIsExist = objUserRolesService.UserRoles_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strRoleId"></param>
        /// <returns></returns>
        public static bool IsExistWs(string strRoleId)
        {
            //检测记录是否存在
            UserRolesServiceSoapClient objUserRolesService = GetUserRolesServiceSoapClient();
            bool bolIsExist = objUserRolesService.UserRoles_IsExist(strRoleId);
            return bolIsExist;
        }
    }
}