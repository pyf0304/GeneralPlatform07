///----------------------
///生成代码版本：09.10.08.1
///生成日期：2011/03/14
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
using GeneralPlatform4WS.ServiceReferenceViewPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 界面权限(ViewPotence)
    /// </summary>
    public class clsViewPotenceWS
    {
        private static ViewPotenceServiceSoapClient objViewPotenceServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ViewPotenceServiceSoapClient GetViewPotenceServiceSoapClient()
        {
            if (objViewPotenceServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "ViewPotenceServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/ViewPotenceService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/ViewPotenceService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new ViewPotenceServiceSoapClient(binding, address);
            }
            else
            {
                return objViewPotenceServiceSoapClient;
            }
        }

        public clsViewPotenceWS()
        {
        }


       
        public static DataTable GetDataTable_ViewPotenceWs(string strWhereCond)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objViewPotenceService.ViewPotence_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:ViewPotence 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_ViewPotenceVWs(string strWhereCond)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objViewPotenceService.ViewPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:ViewPotence View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetViewPotenceVWs(string strWhereCond)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objViewPotenceService.ViewPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetViewPotenceWs(ref clsViewPotenceEN objViewPotenceEN)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            bool bolResult = objViewPotenceService.ViewPotence_GetViewPotence(ref objViewPotenceEN);
            return bolResult;
        }

        public static List<clsViewPotenceEN> GetViewPotenceObjList(string strCondition)
        {
            List<clsViewPotenceEN> arrObjList = new List<clsViewPotenceEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_ViewPotenceWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsViewPotenceEN objViewPotenceEN = new clsViewPotenceEN();
                objViewPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objViewPotenceEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
                objViewPotenceEN.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objViewPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
                objViewPotenceEN.Level = Int32.Parse(objRow["Level"].ToString().Trim()); //等级
                objViewPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objViewPotenceEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                bool bolResult = objViewPotenceService.ViewPotence_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelViewPotencesWs(List<string>  arrStdId)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrStdId.ToArray());
                bool bolResult = objViewPotenceService.ViewPotence_DelViewPotences(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static int DelViewPotencesByCondWs(string strWhereCond)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                int intRecNum = objViewPotenceService.ViewPotence_DelViewPotencesByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsViewPotenceEN objViewPotenceEN)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                bool bolResult = objViewPotenceService.ViewPotence_AddNewRecordBySql2(objViewPotenceEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsViewPotenceEN objViewPotenceEN)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                bool bolResult = objViewPotenceService.ViewPotence_UpdateBySql2(objViewPotenceEN);
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
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            bool bolIsExist = objViewPotenceService.ViewPotence_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            bool bolIsExist = objViewPotenceService.ViewPotence_IsExist(lngmId);
            return bolIsExist;
        }

        public static string GetMaxStrIdWs()
        {
            //检测记录是否存在
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            string strMaxMId = objViewPotenceService.ViewPotence_GetMaxStrId();
            return strMaxMId;
        }
    }
}