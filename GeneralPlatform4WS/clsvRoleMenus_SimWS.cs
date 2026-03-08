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
using GeneralPlatform4WS.ServiceReferencevRoleMenus_Sim;
using System.ServiceModel;
using System.Collections.Generic;
using com.taishsoft.common;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// vRoleMenus_Sim(vRoleMenus_Sim)
    /// </summary>
    public class clsvQxRoleMenus_SimWS
    {
        private static vRoleMenus_SimServiceSoapClient objvRoleMenus_SimServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static vRoleMenus_SimServiceSoapClient GetvQxRoleMenus_SimServiceSoapClient()
        {
            if (objvRoleMenus_SimServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vRoleMenus_SimServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                //binding.MaxReceivedMessageSize = 20000;
                
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/vRoleMenus_SimService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/vRoleMenus_SimService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/vRoleMenus_SimService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new vRoleMenus_SimServiceSoapClient(binding, address);
            }
            else
            {
                return objvRoleMenus_SimServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsvQxRoleMenus_SimWS()
        {
        }


   
        public static DataTable GetDataTable_vRoleMenus_SimWs(string strWhereCond)
        {
            vRoleMenus_SimServiceSoapClient objvRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenus_SimService.vRoleMenus_Sim_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vRoleMenus_Sim 数据出错！\r\n" + objException.Message);
            }
        }

        //public static DataTable GetDataTable_vRoleMenus_SimWsEx(string strRoleId, string strPrjId, string strMenuSetId)
        //{
        //    vRoleMenus_SimServiceSoapClient objvRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
        //    DataSet objDS = null;
        //    try
        //    {
        //        objDS = objvRoleMenus_SimService.vRoleMenus_Sim_GetDataSetEx(strRoleId, strPrjId, strMenuSetId);
        //        DataTable objDT = objDS.Tables[0];
        //        return objDT;
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("获取表:vRoleMenus_Sim 数据出错！\r\n" + objException.Message);
        //    }
        //}



        public static bool GetvQxRoleMenus_SimWs(ref clsvQxRoleMenus_SimEN objvRoleMenus_Sim)
        {
            vRoleMenus_SimServiceSoapClient objvRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
            bool bolResult = objvRoleMenus_SimService.vRoleMenus_Sim_GetvQxRoleMenus_Sim(ref objvRoleMenus_Sim);
            return bolResult;
        }
        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="strCondition">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetvQxRoleMenus_SimObjList(string strCondition)
        {
            List<clsvQxRoleMenus_SimEN> arrObjList = new List<clsvQxRoleMenus_SimEN>();
            System.Data.DataTable objDT = null;
            try
            {
                objDT = GetDataTable_vRoleMenus_SimWs(strCondition);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
              
                clsvQxRoleMenus_SimEN objvRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
                objvRoleMenus_SimEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvRoleMenus_SimEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                
                objvRoleMenus_SimEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objvRoleMenus_SimEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
                objvRoleMenus_SimEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
                objvRoleMenus_SimEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
                objvRoleMenus_SimEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
                objvRoleMenus_SimEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //链接文件
                objvRoleMenus_SimEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //链接文件

                objvRoleMenus_SimEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
                //objvRoleMenus_SimEN.OrderNum = TransNullToInt(objRow["OrderNum"].ToString().Trim()); //排序号
                //objvRoleMenus_SimEN.IsDisp = TransNullToBool(objRow["IsDisp"].ToString().Trim()); //是否显示
                //objvRoleMenus_SimEN.IsLeafNode = TransNullToBool(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenus_SimEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenus_SimEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenus_SimEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
               
                objvRoleMenus_SimEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目编号

                objvRoleMenus_SimEN.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objvRoleMenus_SimEN.IsDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objvRoleMenus_SimEN.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                arrObjList.Add(objvRoleMenus_SimEN);
            }
            objDT = null;
            return arrObjList;
        }

        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="strCondition">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        //public static List<clsvQxRoleMenus_SimEN> GetvQxRoleMenus_SimObjListEx(string strRoleId, string strPrjId, string strMenuSetId)
        //{
        //    List<clsvQxRoleMenus_SimEN> arrObjList = new List<clsvQxRoleMenus_SimEN>();
        //    System.Data.DataTable objDT = null;
        //    try
        //    {
        //        objDT = GetDataTable_vRoleMenus_SimWsEx(strRoleId, strPrjId, strMenuSetId);
        //    }
        //    catch (Exception objException)
        //    {
        //        LogErrorS(objException, "clsvQxRoleMenus_SimWS");
        //        throw objException;
        //    }
        //    if (objDT.Rows.Count == 0)
        //    {
        //        objDT = null;
        //        return arrObjList;
        //    }
        //    foreach (DataRow objRow in objDT.Rows)
        //    {

        //        clsvQxRoleMenus_SimEN objvRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
        //        objvRoleMenus_SimEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
        //        objvRoleMenus_SimEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id

        //        objvRoleMenus_SimEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
        //        objvRoleMenus_SimEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
        //        objvRoleMenus_SimEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
        //        objvRoleMenus_SimEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
        //        objvRoleMenus_SimEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
        //        objvRoleMenus_SimEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //链接文件
        //        objvRoleMenus_SimEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //链接文件

        //        objvRoleMenus_SimEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
        //        //objvRoleMenus_SimEN.OrderNum = TransNullToInt(objRow["OrderNum"].ToString().Trim()); //排序号
        //        //objvRoleMenus_SimEN.IsDisp = TransNullToBool(objRow["IsDisp"].ToString().Trim()); //是否显示
        //        //objvRoleMenus_SimEN.IsLeafNode = TransNullToBool(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
        //        objvRoleMenus_SimEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
        //        objvRoleMenus_SimEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
        //        objvRoleMenus_SimEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id

        //        objvRoleMenus_SimEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目编号

        //        objvRoleMenus_SimEN.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
        //        objvRoleMenus_SimEN.IsDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
        //        objvRoleMenus_SimEN.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
        //        arrObjList.Add(objvRoleMenus_SimEN);
        //    }
        //    objDT = null;
        //    return arrObjList;
        //}
        /// <summary>
        /// 是否存在条件记录
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            vRoleMenus_SimServiceSoapClient objvRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
            bool bolIsExist = objvRoleMenus_SimService.vRoleMenus_Sim_IsExistRecord(strCondition);
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
            vRoleMenus_SimServiceSoapClient objvRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
            bool bolIsExist = objvRoleMenus_SimService.vRoleMenus_Sim_IsExist(lngmId);
            return bolIsExist;
        }
        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的顶层菜单列表</returns>
        //public static List<clsvQxRoleMenus_SimEN> GetUpMenuObjList(string strRoleId, string strPrjId)
        //{
        //    List<clsvQxRoleMenus_SimEN> arrUpMenuObjList = null;
        //    //StringBuilder sbCondition = new StringBuilder();
        //    //sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
        //    //    strRoleId);
        //    //sbCondition.AppendFormat(" PrjId = '{0}' ",
        //    //    strPrjId);
        //    //sbCondition.Append(" ORDER BY OrderNum");
        //    //sbCondition.Append("[Exclude]or [/Exclude]");

        //    try
        //    {
        //        arrUpMenuObjList = GetvQxRoleMenus_SimObjListEx(strRoleId, strPrjId, "", true);
        //    }
        //    catch (Exception objException)
        //    {
        //        LogErrorS(objException, "clsvQxRoleMenus_SimWS");
        //        throw objException;
        //    }
        //    finally
        //    {
        //    }
        //    return arrUpMenuObjList;
        //}

        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetUpMenuObjList(string strPrjId)
        {
            List<clsvQxRoleMenus_SimEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append(" UpMenuId = '00000000' AND ");
            sbCondition.AppendFormat(" PrjId = '{0}' ",
                strPrjId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }

        /// <summary>
        /// 获取当前角色的顶层和子层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的顶层和子层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetAllMenuObjList(string strPrjId)
        {
            List<clsvQxRoleMenus_SimEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            //sbCondition.Append(" UpMenuId = '00000000' AND ");
            sbCondition.AppendFormat(" PrjId = '{0}' ",
                strPrjId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }


        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetSubMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvQxRoleMenus_SimEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}'", strPrjId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }

        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetSubMenuObjList(string strPrjId)
        {
            List<clsvQxRoleMenus_SimEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.Append(" UpMenuId <> '00000000' and ");
            sbCondition.AppendFormat(" PrjId = '{0}'", strPrjId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }


        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的顶层菜单列表</returns>
        //public static List<clsvQxRoleMenus_SimEN> GetUpMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        //{
        //    List<clsvQxRoleMenus_SimEN> arrUpMenuObjList = null;
        //    //StringBuilder sbCondition = new StringBuilder();
        //    //sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
        //    //    strRoleId);
        //    //sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'",
        //    //    strPrjId, strMenuSetId);
        //    //sbCondition.Append(" ORDER BY OrderNum");
        //    //sbCondition.Append("[Exclude]or [/Exclude]");

        //    try
        //    {
        //        arrUpMenuObjList = GetvQxRoleMenus_SimObjListEx(strRoleId, strPrjId, strMenuSetId);
        //    }
        //    catch (Exception objException)
        //    {
        //        LogErrorS(objException, "clsvQxRoleMenus_SimWS");
        //        throw objException;
        //    }
        //    finally
        //    {
        //    }
        //    return arrUpMenuObjList;
        //}
        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetSubMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenus_SimEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }



        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetUpMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenus_SimEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" UpMenuId = '00000000' AND ");
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId={1}",
                strPrjId, strMenuSetId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetSubMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenus_SimEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" UpMenuId <> '00000000' and ");
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId={1}", strPrjId, strMenuSetId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }


        /// <summary>
        /// 获取当前角色列表的子层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetSubMenuObjList(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenus_SimEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            sbCondition.AppendFormat(" RoleId in ({0}) And UpMenuId <> '00000000' and ", sstrRoleId);
            sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }

        /// <summary>
        /// 获取当前角色列表的顶层菜单列表，以List<clsvQxRoleMenus_SimEN>的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenus_SimEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenus_SimEN> GetUpMenuObjList(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenus_SimEN> arrUpMenuObjList = null;
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
                arrUpMenuObjList = GetvQxRoleMenus_SimObjList(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenus_SimWS");
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