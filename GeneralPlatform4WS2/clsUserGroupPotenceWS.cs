///----------------------
///生成代码版本：2010.05.04.1
///生成日期：2010/06/04
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2010.05.04.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2010.05.04.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceUserGroupPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 用户权限关系(UserGroupPotence)
    /// </summary>
    public class clsUserGroupPotenceWS
    {
        private static UserGroupPotenceServiceSoapClient objUserGroupPotenceServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserGroupPotenceServiceSoapClient GetUserGroupPotenceServiceSoapClient()
        {
            if (objUserGroupPotenceServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UserGroupPotenceServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UserGroupPotenceService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UserGroupPotenceService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new UserGroupPotenceServiceSoapClient(binding, address);
            }
            else
            {
                return objUserGroupPotenceServiceSoapClient;
            }
        }

        public clsUserGroupPotenceWS()
        {
        }


        public static DataTable GetDataTable_UserGroupPotenceWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserGroupPotence 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_UserGroupPotenceVWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserGroupPotence View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetUserGroupPotenceVWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetUserGroupPotenceWs(ref clsUserGroupPotenceEN objUserGroupPotence)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            bool bolResult = objUserGroupPotenceService.UserGroupPotence_GetUserGroupPotence(ref objUserGroupPotence);
            return bolResult;
        }

        public static List<clsUserGroupPotenceEN> GetUserGroupPotenceObjList(string strCondition)
        {
            List<clsUserGroupPotenceEN> arrObjList = new List<clsUserGroupPotenceEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_UserGroupPotenceWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUserGroupPotenceEN objUserGroupPotence = new clsUserGroupPotenceEN();
                objUserGroupPotence.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objUserGroupPotence.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserGroupPotence.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
                objUserGroupPotence.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserGroupPotence.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objUserGroupPotence.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
                objUserGroupPotence.RelaMid = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RelaMid"].ToString().Trim()); //流水号
                objUserGroupPotence.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserGroupPotence);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            try
            {
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelUserGroupPotencesWs(List<string>  arrStdId)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrStdId.ToArray());
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_DelUserGroupPotences(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static int DelUserGroupPotencesByCondWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            try
            {
                int intRecNum = objUserGroupPotenceService.UserGroupPotence_DelUserGroupPotencesByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsUserGroupPotenceEN objUserGroupPotence)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            try
            {
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_AddNewRecordBySql2(objUserGroupPotence);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsUserGroupPotenceEN objUserGroupPotence)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            try
            {
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_UpdateBySql2(objUserGroupPotence);
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
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            bool bolIsExist = objUserGroupPotenceService.UserGroupPotence_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            bool bolIsExist = objUserGroupPotenceService.UserGroupPotence_IsExist(lngmId);
            return bolIsExist;
        }

        public static string GetMaxStrIdWs()
        {
            //检测记录是否存在
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetUserGroupPotenceServiceSoapClient();
            string strMaxMId = objUserGroupPotenceService.UserGroupPotence_GetMaxStrId();
            return strMaxMId;
        }
    }
}