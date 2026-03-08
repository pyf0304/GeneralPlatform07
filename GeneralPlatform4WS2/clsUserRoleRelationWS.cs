///----------------------
///生成代码版本：2010.05.04.1
///生成日期：2010/06/03
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
using GeneralPlatform4WS.ServiceReferenceUserRoleRelation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 用户角色关系(UserRoleRelation)
    /// </summary>
    public class clsUserRoleRelationWS
    {
        private static UserRoleRelationServiceSoapClient objUserRoleRelationServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserRoleRelationServiceSoapClient GetUserRoleRelationServiceSoapClient()
        {
            if (objUserRoleRelationServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UserRoleRelationServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UserRoleRelationService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UserRoleRelationService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new UserRoleRelationServiceSoapClient(binding, address);
            }
            else
            {
                return objUserRoleRelationServiceSoapClient;
            }
        }

        public clsUserRoleRelationWS()
        {
        }


        public static DataTable GetDataTable_UserRoleRelationWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserRoleRelationService.UserRoleRelation_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserRoleRelation 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_UserRoleRelationVWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserRoleRelationService.UserRoleRelation_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserRoleRelation View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetUserRoleRelationVWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserRoleRelationService.UserRoleRelation_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetUserRoleRelationWs(ref clsUserRoleRelationEN objUserRoleRelation)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            bool bolResult = objUserRoleRelationService.UserRoleRelation_GetUserRoleRelation(ref objUserRoleRelation);
            return bolResult;
        }

        public static List<clsUserRoleRelationEN> GetUserRoleRelationObjList(string strCondition)
        {
            List<clsUserRoleRelationEN> arrObjList = new List<clsUserRoleRelationEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_UserRoleRelationWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUserRoleRelationEN objUserRoleRelation = new clsUserRoleRelationEN();
                objUserRoleRelation.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objUserRoleRelation.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserRoleRelation.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserRoleRelation.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objUserRoleRelation.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserRoleRelation);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            try
            {
                bool bolResult = objUserRoleRelationService.UserRoleRelation_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelUserRoleRelationsWs(List<string>  arrStdId)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrStdId.ToArray());
                bool bolResult = objUserRoleRelationService.UserRoleRelation_DelUserRoleRelations(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static int DelUserRoleRelationsByCondWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            try
            {
                int intRecNum = objUserRoleRelationService.UserRoleRelation_DelUserRoleRelationsByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsUserRoleRelationEN objUserRoleRelation)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            try
            {
                bool bolResult = objUserRoleRelationService.UserRoleRelation_AddNewRecordBySql2(objUserRoleRelation);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsUserRoleRelationEN objUserRoleRelation)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            try
            {
                bool bolResult = objUserRoleRelationService.UserRoleRelation_UpdateBySql2(objUserRoleRelation);
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
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            bool bolIsExist = objUserRoleRelationService.UserRoleRelation_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetUserRoleRelationServiceSoapClient();
            bool bolIsExist = objUserRoleRelationService.UserRoleRelation_IsExist(lngmId);
            return bolIsExist;
        }

      
    }
}