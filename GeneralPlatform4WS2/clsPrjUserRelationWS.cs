///----------------------
///生成代码版本：09.08.22.1
///生成日期：2009/09/29
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.08.22.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferencePrjUserRelation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 工程用户关系(PrjUserRelation)
    /// </summary>
    public class clsPrjUserRelationWS
    {

        private static PrjUserRelationServiceSoapClient objPrjUserRelationServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static PrjUserRelationServiceSoapClient GetPrjUserRelationServiceSoapClient()
        {
            if (objPrjUserRelationServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "PrjUserRelationServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                //binding.maxBufferSize = 2147483647;
                //binding.maxBufferPoolSize = 2147483647; 

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/PrjUserRelationService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/PrjUserRelationService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/PrjUserRelationService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/PrjUserRelationService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new PrjUserRelationServiceSoapClient(binding, address);
            }
            else
            {
                return objPrjUserRelationServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsPrjUserRelationWS()
        {
        }



        PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();



        public static DataTable GetDataTable_PrjUserRelationWs(string strWhereCond)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjUserRelationService.PrjUserRelation_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:PrjUserRelation 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_PrjUserRelationVWs(string strWhereCond)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjUserRelationService.PrjUserRelation_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:PrjUserRelation View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetPrjUserRelationVWs(string strWhereCond)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjUserRelationService.PrjUserRelation_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetPrjUserRelationWs(ref clsPrjUserRelationEN objPrjUserRelation)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            bool bolResult = objPrjUserRelationService.PrjUserRelation_GetPrjUserRelation(ref objPrjUserRelation);
            return bolResult;
        }

        public static List<clsPrjUserRelationEN> GetPrjUserRelationObjList(string strCondition)
        {
            List<clsPrjUserRelationEN> arrObjList = new List<clsPrjUserRelationEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_PrjUserRelationWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPrjUserRelationEN objPrjUserRelation = new clsPrjUserRelationEN();
                objPrjUserRelation.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objPrjUserRelation.Memo = objRow["Memo"].ToString().Trim(); //备注
                objPrjUserRelation.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objPrjUserRelation.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                arrObjList.Add(objPrjUserRelation);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            try
            {
                bool bolResult = objPrjUserRelationService.PrjUserRelation_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelPrjUserRelationsWs(List<string>  arrStdId)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrStdId.ToArray());
                bool bolResult = objPrjUserRelationService.PrjUserRelation_DelPrjUserRelations(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsPrjUserRelationEN objPrjUserRelation)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            try
            {
                bool bolResult = objPrjUserRelationService.PrjUserRelation_AddNewRecordBySql2(objPrjUserRelation);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsPrjUserRelationEN objPrjUserRelation)
        {
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            try
            {
                bool bolResult = objPrjUserRelationService.PrjUserRelation_UpdateBySql2(objPrjUserRelation);
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
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            bool bolIsExist = objPrjUserRelationService.PrjUserRelation_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            PrjUserRelationServiceSoapClient objPrjUserRelationService = GetPrjUserRelationServiceSoapClient();
            bool bolIsExist = objPrjUserRelationService.PrjUserRelation_IsExist(lngmId);
            return bolIsExist;
        }
    }
}