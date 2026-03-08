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

using System.ServiceModel;
using System.Collections.Generic;
using com.taishsoft.common;
using GeneralPlatform4WS.ServiceReferencevQxRoleMenusEx;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// vRoleMenus(vRoleMenus)
    /// </summary>
    public class clsvQxRoleMenusWSEx
    {
        private static string mstrPageName = "vQxRoleMenusExService.asmx";
        private static string mstrDir = "0";
        private static vQxRoleMenusExServiceSoapClient objvRoleMenusServiceExSoapClient = null;
       /// <summary>
       /// 获取Web服务的地址
       /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetServiceUrlBak20170206()
        {
            String strServiceUrl = String.Empty;
            if (clsSysPara.bolIsLocalHost == false)
            {
                strServiceUrl = String.Format("http://{0}/{1}/vRoleMenusServiceEx.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
            }
            else
            {
                strServiceUrl = String.Format("http://{0}/vRoleMenusServiceEx.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
            }
            return strServiceUrl;
        }


        /// <summary>
        /// 获取Web服务的地址
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetServiceUrl(string strPageName, ref string strDir)
        {
            String strServiceUrl = String.Empty;
            if (strDir == "0")
            {
                strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);
            }
            if (clsSysPara4WS.bolIsLocalHost == false)
            {
                if (string.IsNullOrEmpty(strDir) == true)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}",
                    clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strPageName);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}/{3}",
                    clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strDir, strPageName);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(strDir) == true)
                {
                    strServiceUrl = String.Format("http://{0}/{1}",
                    clsSysPara4WS.strCurrIPAddressAndPort_Local,
                    strPageName);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}",
                    clsSysPara4WS.strCurrIPAddressAndPort_Local, strDir, strPageName);
                }
            }
            return strServiceUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static vQxRoleMenusExServiceSoapClient GetvQxRoleMenusServiceExSoapClient()
        {
            if (objvRoleMenusServiceExSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vRoleMenusServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2000000;
                string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
                //String strServiceUrl = String.Empty;
                //if (clsSysPara.bolIsLocalHost == false)
                //{
                //    strServiceUrl = String.Format("http://{0}/{1}/vRoleMenusService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
                //}
                //else
                //{
                //    strServiceUrl = String.Format("http://{0}/vRoleMenusService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                //}


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/vRoleMenusService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new vQxRoleMenusExServiceSoapClient(binding, address);
            }
            else
            {
                return objvRoleMenusServiceExSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsvQxRoleMenusWSEx()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strRoleId"></param>
        /// <param name="strPrjId"></param>
        /// <param name="strMenuSetId"></param>
        /// <param name="bolIsUpMenuId"></param>
        /// <returns></returns>
        public static DataTable GetDataTable_vRoleMenusWsEx(string strRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            vQxRoleMenusExServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceExSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vQxRoleMenus_GetDataSetEx(strRoleId, strPrjId, strMenuSetId, bolIsUpMenuId);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}.\r\n出错信息:{2}",
                    GetServiceUrl(mstrPageName, ref mstrDir), "vRoleMenus_GetDataSetEx", objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sstrRoleId"></param>
        /// <param name="strPrjId"></param>
        /// <param name="strMenuSetId"></param>
        /// <param name="bolIsUpMenuId"></param>
        /// <returns></returns>
        public static DataTable GetDataTable_vRoleMenusWsByRoleIdsEx(string sstrRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            vQxRoleMenusExServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceExSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vQxRoleMenus_GetDataSetByRoleIdsEx(sstrRoleId, strPrjId, strMenuSetId, bolIsUpMenuId);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}.\r\n出错信息:{2}",
                   GetServiceUrl(mstrPageName, ref mstrDir), "vRoleMenus_GetDataSetByRoleIdsEx", objException.Message);
                throw new Exception(strMsg);

            }
        }


        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="strRoleId">提供的条件</param>
        /// <param name="strPrjId">提供的条件</param>
        /// <param name="strMenuSetId">提供的条件</param>
        /// <param name="bolIsUpMenuId">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvQxRoleMenusEN> GetObjLstEx(string strRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            List<clsvQxRoleMenusEN> arrObjList = new List<clsvQxRoleMenusEN>();
            System.Data.DataTable objDT = null;
            try
            {
                objDT = GetDataTable_vRoleMenusWsEx(strRoleId, strPrjId, strMenuSetId, bolIsUpMenuId);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            List<string> arrMenuId = new List<string>();
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvQxRoleMenusEN objvRoleMenusEN = new clsvQxRoleMenusEN();
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
      
                //objvRoleMenusEN.IsLeafNode = TransNullToBool(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
                objvRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
                objvRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
                objvRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目编号

                objvRoleMenusEN.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                //objvRoleMenusEN.I1sDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["I1sDisp"].ToString().Trim()); //是否显示
                objvRoleMenusEN.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.InUse = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否叶子
                string strTemp = objvRoleMenusEN.RoleId + objvRoleMenusEN.MenuId;
                if (arrMenuId.Contains(strTemp) == false)
                {
                    arrMenuId.Add(strTemp);
                    arrObjList.Add(objvRoleMenusEN);
                }
            }
            objDT = null;
            return arrObjList;
        }



        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="sstrRoleId">提供的条件</param>
        /// <param name="strPrjId">提供的条件</param>
        /// <param name="strMenuSetId">提供的条件</param>
        /// <param name="bolIsUpMenuId">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvQxRoleMenusEN> GetObjLstByRoleIdsEx(string sstrRoleId, 
            string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            List<clsvQxRoleMenusEN> arrObjList = new List<clsvQxRoleMenusEN>();
            System.Data.DataTable objDT = null;
            try
            {
                objDT = GetDataTable_vRoleMenusWsByRoleIdsEx(sstrRoleId, strPrjId, strMenuSetId, bolIsUpMenuId);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            List<string> arrMenuId = new List<string>();
            foreach (DataRow objRow in objDT.Rows)
            {

                clsvQxRoleMenusEN objvRoleMenusEN = new clsvQxRoleMenusEN();
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
                //objvRoleMenusEN.I1sDisp = TransNullToBool(objRow["I1sDisp"].ToString().Trim()); //是否显示
                //objvRoleMenusEN.IsLeafNode = TransNullToBool(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
                objvRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
                objvRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
                objvRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目编号

                objvRoleMenusEN.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                //objvRoleMenusEN.I1sDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["I1sDisp"].ToString().Trim()); //是否显示
                objvRoleMenusEN.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.InUse = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否叶子
                string strTemp = objvRoleMenusEN.RoleId + objvRoleMenusEN.MenuId;
                if (arrMenuId.Contains(strTemp) == false)
                {
                    arrMenuId.Add(strTemp);
                    arrObjList.Add(objvRoleMenusEN);
                }
               
            }
            objDT = null;
            return arrObjList;
        }
   
     
        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
            //    strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' ",
            //    strPrjId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetObjLstEx(strRoleId, strPrjId, "", true);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }

        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.Append(" UpMenuId = '00000000' AND ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}' ",
            //    strPrjId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetObjLstEx("", strPrjId, "", true);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
               

        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}'", strPrjId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetObjLstEx(strRoleId, strPrjId, "", false);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }

        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.Append(" UpMenuId <> '00000000' and ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}'", strPrjId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetObjLstEx("",strPrjId, "", false);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }


        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
            //    strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetObjLstEx(strRoleId, strPrjId, strMenuSetId, true);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetObjLstEx(strRoleId, strPrjId, strMenuSetId, false);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }



        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" UpMenuId = '00000000' AND ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId={1}",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetObjLstEx("", strPrjId, strMenuSetId, true);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.AppendFormat(" UpMenuId <> '00000000' and ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId={1}", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetObjLstEx("", strPrjId, strMenuSetId, false);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }


        /// <summary>
        /// 获取当前角色列表的子层菜单列表，以List[clsvQxRoleMenusEN]的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List[clsvQxRoleMenusEN]形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjListByRoleIds(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            //sbCondition.AppendFormat(" RoleId in ({0}) And UpMenuId <> '00000000' and ", sstrRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetObjLstByRoleIdsEx(sstrRoleId, strPrjId, strMenuSetId, false);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }

        /// <summary>
        /// 获取当前角色列表的顶层菜单列表，以List[clsvQxRoleMenusEN]的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List[clsvQxRoleMenusEN]形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjListByRoleIds(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            //sbCondition.AppendFormat(" RoleId in ({0}) AND UpMenuId = '00000000' AND ",
            //    sstrRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetObjLstByRoleIdsEx(sstrRoleId, strPrjId, strMenuSetId, true);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
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