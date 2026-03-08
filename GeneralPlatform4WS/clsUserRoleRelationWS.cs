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
    public class clsQxUserRoleRelationWS
    {
        private static UserRoleRelationServiceSoapClient objUserRoleRelationServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserRoleRelationServiceSoapClient GetQxUserRoleRelationServiceSoapClient()
        {
            if (objUserRoleRelationServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UserRoleRelationServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UserRoleRelationService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
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

        public clsQxUserRoleRelationWS()
        {
        }


        public static DataTable GetDataTable_QxUserRoleRelationWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
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

        public static DataTable GetDataTable_QxUserRoleRelationVWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
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

        public static DataTable GetQxUserRoleRelationVWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
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

        public static bool GetQxUserRoleRelationWs(ref clsQxUserRoleRelationEN objUserRoleRelation)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
            bool bolResult = objUserRoleRelationService.UserRoleRelation_GetQxUserRoleRelation(ref objUserRoleRelation);
            return bolResult;
        }

        public static List<clsQxUserRoleRelationEN> GetQxUserRoleRelationObjList(string strCondition)
        {
            List<clsQxUserRoleRelationEN> arrObjList = new List<clsQxUserRoleRelationEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxUserRoleRelationWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxUserRoleRelationEN objUserRoleRelation = new clsQxUserRoleRelationEN();
                objUserRoleRelation.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objUserRoleRelation.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserRoleRelation.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserRoleRelation.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目编号
                objUserRoleRelation.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserRoleRelation);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
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

        public static bool DelQxUserRoleRelationsWs(List<string>  arrStdId)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrStdId.ToArray());
                bool bolResult = objUserRoleRelationService.UserRoleRelation_DelQxUserRoleRelations(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static int DelQxUserRoleRelationsByCondWs(string strWhereCond)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
            try
            {
                int intRecNum = objUserRoleRelationService.UserRoleRelation_DelQxUserRoleRelationsByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsQxUserRoleRelationEN objUserRoleRelation)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
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

        public static bool UpdateBySql2Ws(clsQxUserRoleRelationEN objUserRoleRelation)
        {
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
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
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
            bool bolIsExist = objUserRoleRelationService.UserRoleRelation_IsExistRecord(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            UserRoleRelationServiceSoapClient objUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
            bool bolIsExist = objUserRoleRelationService.UserRoleRelation_IsExist(lngmId);
            return bolIsExist;
        }


        /// <summary>
        /// 获取该帐户在本系统中的角色号RoleId 列表，
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>角色号RoleId 的列表 </returns>
        public static List<string> Get_QxUserRoleIdList2(string strPrjId, string strUserId)
        {
            List<string> arrRoleIdList = new List<string>();
            DataTable objDT = new DataTable();

            objDT = Get_QxUserRoleRelationByJoinUsersV(strUserId, strPrjId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrRoleIdList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {

                arrRoleIdList.Add(objRow["RoleId"].ToString().Trim());
            }
            objDT = null;
            return arrRoleIdList;

        }

        /// <summary>
        /// 获取用户角色关系表
        /// </summary>
        /// <param name="strUserId">帐号</param>
        /// <param name="strUserPrjId">项目号</param>
        /// <returns>数据表</returns>
        private static DataTable Get_QxUserRoleRelationByJoinUsersV(string strUserId, string strUserPrjId)
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendFormat(" UserId = '{0}'", strUserId);
            sb.AppendFormat(" and PrjId = '{0}'", strUserPrjId);

            DataTable objDT = clsQxUserRoleRelationWS.GetDataTable_QxUserRoleRelationVWs(sb.ToString());

            return objDT;

        }
    }
}