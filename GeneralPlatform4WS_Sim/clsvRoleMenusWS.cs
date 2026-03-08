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
using com.taishsoft.common;

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
                    strServiceUrl = String.Format("http://{0}/{1}/vRoleMenusService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
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

        


        public static bool GetvRoleMenusWs(ref clsvRoleMenusEN objvRoleMenus)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            bool bolResult = objvRoleMenusService.vRoleMenus_GetvRoleMenus(ref objvRoleMenus);
            return bolResult;
        }
        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="strCondition">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvRoleMenusEN> GetvRoleMenusObjList(string strCondition)
        {
            List<clsvRoleMenusEN> arrObjList = new List<clsvRoleMenusEN>();
            System.Data.DataTable objDT = null;
            try
            {
                objDT = GetDataTable_vRoleMenusWs(strCondition);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvRoleMenusWS");
                throw objException;
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
              
                clsvRoleMenusEN objvRoleMenusEN = new clsvRoleMenusEN();
                objvRoleMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvRoleMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objvRoleMenusEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
                objvRoleMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objvRoleMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
                objvRoleMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
                objvRoleMenusEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
                objvRoleMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
                objvRoleMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //链接文件
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //链接文件

                objvRoleMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
                //objvRoleMenusEN.OrderNum = TransNullToInt(objRow["OrderNum"].ToString().Trim()); //排序号
                //objvRoleMenusEN.IsDisp = TransNullToBool(objRow["IsDisp"].ToString().Trim()); //是否显示
                //objvRoleMenusEN.IsLeafNode = TransNullToBool(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
                objvRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
                objvRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
                objvRoleMenusEN.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号

                objvRoleMenusEN.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objvRoleMenusEN.IsDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objvRoleMenusEN.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                arrObjList.Add(objvRoleMenusEN);
            }
            objDT = null;
            return arrObjList;
        }
        /// <summary>
        /// 是否存在条件记录
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            bool bolIsExist = objvRoleMenusService.vRoleMenus_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lngmId"></param>
        /// <returns></returns>
        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvRoleMenusServiceSoapClient();
            bool bolIsExist = objvRoleMenusService.vRoleMenus_IsExist(lngmId);
            return bolIsExist;
        }
        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvRoleMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
                strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' ",
                strPrjId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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
        /// 获取当前角色的顶层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetUpMenuObjList(string strPrjId)
        {
            List<clsvRoleMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append(" UpMenuId = '00000000' AND ");
            sbCondition.AppendFormat(" PrjId = '{0}' ",
                strPrjId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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
        /// 获取当前角色的顶层和子层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的顶层和子层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetAllMenuObjList(string strPrjId)
        {
            List<clsvRoleMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            //sbCondition.Append(" UpMenuId = '00000000' AND ");
            sbCondition.AppendFormat(" PrjId = '{0}' ",
                strPrjId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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
        /// 获取当前角色的子层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvRoleMenusEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}'", strPrjId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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

        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetSubMenuObjList(string strPrjId)
        {
            List<clsvRoleMenusEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.Append(" UpMenuId <> '00000000' and ");
            sbCondition.AppendFormat(" PrjId = '{0}'", strPrjId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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


        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvRoleMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
                strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'",
                strPrjId, strMenuSetId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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
        /// 获取当前角色的子层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvRoleMenusEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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



        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetUpMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvRoleMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" UpMenuId = '00000000' AND ");
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId={1}",
                strPrjId, strMenuSetId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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
        /// 获取当前角色的子层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetSubMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvRoleMenusEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" UpMenuId <> '00000000' and ");
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId={1}", strPrjId, strMenuSetId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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


        /// <summary>
        /// 获取当前角色列表的子层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetSubMenuObjList(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvRoleMenusEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            sbCondition.AppendFormat(" RoleId in ({0}) And UpMenuId <> '00000000' and ", sstrRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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

        /// <summary>
        /// 获取当前角色列表的顶层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvRoleMenusEN> GetUpMenuObjList(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvRoleMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            sbCondition.AppendFormat(" RoleId in ({0}) AND UpMenuId = '00000000' AND ",
                sstrRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'",
                strPrjId, strMenuSetId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

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