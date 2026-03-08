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
using GeneralPlatform4WS.ServiceReferenceRoleMenus;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 角色菜单(RoleMenus)
    /// </summary>
    public class clsRoleMenusWS
    {
        private static RoleMenusServiceSoapClient objRoleMenusServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RoleMenusServiceSoapClient GetRoleMenusServiceSoapClient()
        {
            if (objRoleMenusServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "RoleMenusServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 200000;
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/RoleMenusService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/RoleMenusService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new RoleMenusServiceSoapClient(binding, address);
            }
            else
            {
                return objRoleMenusServiceSoapClient;
            }
        }

        public clsRoleMenusWS()
        {
        }


      
        public static DataTable GetDataTable_RoleMenusWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:RoleMenus 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_RoleMenusVWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:RoleMenus View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetRoleMenusVWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetRoleMenusWs(ref clsRoleMenusEN objRoleMenus)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            bool bolResult = objRoleMenusService.RoleMenus_GetRoleMenus(ref objRoleMenus);
            return bolResult;
        }

        public static List<clsRoleMenusEN> GetRoleMenusObjList(string strCondition)
        {
            List<clsRoleMenusEN> arrObjList = new List<clsRoleMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_RoleMenusWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsRoleMenusEN objRoleMenus = new clsRoleMenusEN();
                objRoleMenus.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objRoleMenus.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objRoleMenus.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objRoleMenus.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objRoleMenus.IsDisp = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objRoleMenus.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objRoleMenus);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            try
            {
                bool bolResult = objRoleMenusService.RoleMenus_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelRoleMenussWs(List<string>  arrStdId)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrStdId.ToArray());
                bool bolResult = objRoleMenusService.RoleMenus_DelRoleMenuss(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static int DelRoleMenussByCondWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            try
            {
                int intRecNum = objRoleMenusService.RoleMenus_DelRoleMenussByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsRoleMenusEN objRoleMenus)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            try
            {
                bool bolResult = objRoleMenusService.RoleMenus_AddNewRecordBySql2(objRoleMenus);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsRoleMenusEN objRoleMenus)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            try
            {
                bool bolResult = objRoleMenusService.RoleMenus_UpdateBySql2(objRoleMenus);
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
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            bool bolIsExist = objRoleMenusService.RoleMenus_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            bool bolIsExist = objRoleMenusService.RoleMenus_IsExist(lngmId);
            return bolIsExist;
        }

        public static string GetMaxStrIdWs()
        {
            //检测记录是否存在
            RoleMenusServiceSoapClient objRoleMenusService = GetRoleMenusServiceSoapClient();
            string strMaxMId = objRoleMenusService.RoleMenus_GetMaxStrId();
            return strMaxMId;
        }
    }
}