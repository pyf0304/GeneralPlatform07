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
using GeneralPlatform4WS.ServiceReferencevRoleMenus;
using System.ServiceModel;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// vRoleMenus(vRoleMenus)
    /// </summary>
    public class clsvRoleMenusWS
    {
        private static vRoleMenusServiceSoapClient objvRoleMenusServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static vRoleMenusServiceSoapClient GetvRoleMenusServiceSoapClient()
        {
            if (objvRoleMenusServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vRoleMenusServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 200000;
                
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/vRoleMenusService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/vRoleMenusService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/vRoleMenusService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new vRoleMenusServiceSoapClient(binding, address);
            }
            else
            {
                return objvRoleMenusServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsvRoleMenusWS()
        {
        }


   
        public static DataTable GetDataTable_vRoleMenusWs(string strWhereCond)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vRoleMenus_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vRoleMenus 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_vRoleMenusVWs(string strWhereCond)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vRoleMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vRoleMenus View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetvRoleMenusVWs(string strWhereCond)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vRoleMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetvRoleMenusWs(ref clsvRoleMenusEN objvRoleMenus)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            bool bolResult = objvRoleMenusService.vRoleMenus_GetvRoleMenus(ref objvRoleMenus);
            return bolResult;
        }

        public static List<clsvRoleMenusEN> GetvRoleMenusObjList(string strCondition)
        {
            List<clsvRoleMenusEN> arrObjList = new List<clsvRoleMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vRoleMenusWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvRoleMenusEN objvRoleMenus = new clsvRoleMenusEN();
                objvRoleMenus.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvRoleMenus.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objvRoleMenus.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objvRoleMenus.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objvRoleMenus.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
                objvRoleMenus.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
                objvRoleMenus.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
                objvRoleMenus.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
                objvRoleMenus.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //菜单显示方式ID
                objvRoleMenus.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenus.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集合ID

                objvRoleMenus.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objvRoleMenus.IsDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objvRoleMenus.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                arrObjList.Add(objvRoleMenus);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            bool bolIsExist = objvRoleMenusService.vRoleMenus_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            bool bolIsExist = objvRoleMenusService.vRoleMenus_IsExist(lngmId);
            return bolIsExist;
        }
        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvRoleMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
                strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' ",
                strPrjId);
            sbCondition.Append(" ORDER BY OrderNum");
            try
            {
                arrUpMenuObjList = GetvRoleMenusObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvRoleMenusEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId <> '00000000' AND ",
                strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' ",
                strPrjId);
            sbCondition.Append(" ORDER BY OrderNum");
            try
            {
                arrSubMenuObjList = GetvRoleMenusObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }
     
        //静态的处理错误日志的函数

        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="objException">异常对象</param>
        /// <param name="strModuleName">模块名称</param>
        public static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
    }
}