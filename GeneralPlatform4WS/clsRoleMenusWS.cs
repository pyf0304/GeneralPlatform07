
//类名:clsQxRoleMenusWS
///----------------------
///生成代码版本:2016.09.12.1
///生成日期:2016/09/20
///生成者:潘以锋
///工程名称:统一平台
///工程ID:0014
///模块中文名:菜单管理
///模块英文名:MenuManage
///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.09.04.01
///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.09.04.01
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
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
    /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
    /// </summary>
    public class clsQxRoleMenusWS
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        public static List<clsQxRoleMenusEN> arrRoleMenusObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        private static int intFindFailCount = 0;
        private static RoleMenusServiceSoapClient objRoleMenusServiceSoapClient = null;
        /// <summary>
        /// 
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        /// <returns></returns>
        public static RoleMenusServiceSoapClient GetQxRoleMenusServiceSoapClient()
        {
            if (objRoleMenusServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "RoleMenusServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                String strServiceUrl = String.Empty;
                if (clsSysPara4WS.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/RoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/RoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new RoleMenusServiceSoapClient(binding, address);
            }
            else
            {
                return objRoleMenusServiceSoapClient;
            }
        }

        public clsQxRoleMenusWS()
        {
        }



        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:GenBindListView)
        /// </summary>
        public static int BindLv_QxRoleMenus(System.Windows.Forms.ListView lvRoleMenus, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviRoleMenus;
            List<clsQxRoleMenusEN> arrRoleMenusObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrRoleMenusObjList = GetQxRoleMenusObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvRoleMenus.Items.Clear();//清除原来所有Item
            lvRoleMenus.Columns.Clear();//清除原来所有列头信息
            lvRoleMenus.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvRoleMenus.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxRoleMenusEN objRoleMenusEN in arrRoleMenusObjList)
            {
                lviRoleMenus = new System.Windows.Forms.ListViewItem();
                lviRoleMenus.Tag = objRoleMenusEN.mId;
                lviRoleMenus.Text = objRoleMenusEN.mId.ToString();
                lviRoleMenus.SubItems.Add(objRoleMenusEN.IsDisp.ToString());
                lviRoleMenus.SubItems.Add(objRoleMenusEN.UpdDate);
                lviRoleMenus.SubItems.Add(objRoleMenusEN.UpdUserId);
                lviRoleMenus.SubItems.Add(objRoleMenusEN.Memo);
                lvRoleMenus.Items.Add(lviRoleMenus);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrRoleMenusObjList.Count;
        }

        /// <summary>
        /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4WS_CheckPropertyNew)
        /// </summary>
        public void CheckPropertyNew(clsQxRoleMenusEN objRoleMenusEN)
        {
            if (!Object.Equals(null, objRoleMenusEN.RoleId) && getStrLen(objRoleMenusEN.RoleId) > 8)
            {
                throw new Exception("字段[角色Id]的长度不能超过8!");
            }
            if (!Object.Equals(null, objRoleMenusEN.QxPrjId) && getStrLen(objRoleMenusEN.QxPrjId) > 4)
            {
                throw new Exception("字段[项目Id]的长度不能超过4!");
            }
            if (!Object.Equals(null, objRoleMenusEN.MenuId) && getStrLen(objRoleMenusEN.MenuId) > 8)
            {
                throw new Exception("字段[菜单Id]的长度不能超过8!");
            }
            if (!Object.Equals(null, objRoleMenusEN.UpdDate) && getStrLen(objRoleMenusEN.UpdDate) > 14)
            {
                throw new Exception("字段[修改日期]的长度不能超过14!");
            }
            if (!Object.Equals(null, objRoleMenusEN.UpdUserId) && getStrLen(objRoleMenusEN.UpdUserId) > 20)
            {
                throw new Exception("字段[修改用户Id]的长度不能超过20!");
            }
            if (!Object.Equals(null, objRoleMenusEN.Memo) && getStrLen(objRoleMenusEN.Memo) > 1000)
            {
                throw new Exception("字段[备注]的长度不能超过1000!");
            }
            objRoleMenusEN.IsCheckProperty = true;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxRoleMenusWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_GetDataSet", "clsQxRoleMenusWS:GetDataTable_QxRoleMenusWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取一定范围的数据表,用DataTable表示
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4TabByRange)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "lngMinNum">范围之最小值</param>
        /// <param name = "lngMaxNum">范围之最大值</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxRoleMenusByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_GetDataSetByRange", "clsQxRoleMenusWS:GetDataTable_QxRoleMenusByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetDataTable_QxRoleMenusVWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_GetDataSetV", "clsQxRoleMenusWS:GetDataTable_QxRoleMenusVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetQxRoleMenusVWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_GetDataSetV", "clsQxRoleMenusWS:GetDataTable_QxRoleMenusVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取一定范围的数据表,用DataTable表示
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4TabV2ByRange)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <param name = "lngMinNum">范围之最小值</param>
        /// <param name = "lngMaxNum">范围之最大值</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxRoleMenusVByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objRoleMenusService.RoleMenus_GetDataSetVByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_GetDataSetVByRange", "clsQxRoleMenusWS:GetDataTable_QxRoleMenusVByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据对象的关键字值,获取对象的全部属性
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
        /// </summary>
        /// <param name = "objRoleMenusEN">相关对象</param>
        /// <returns>是否成功</returns>
        public static bool GetQxRoleMenusWs(ref clsQxRoleMenusEN objRoleMenusEN)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            bool bolResult = objRoleMenusService.RoleMenus_GetQxRoleMenus(ref objRoleMenusEN);
            return bolResult;
        }

        public static clsQxRoleMenusEN GetQxRoleMenusBymIdWs(long lngmId)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            clsQxRoleMenusEN objRoleMenusEN = objRoleMenusService.RoleMenus_GetQxRoleMenusBymId(lngmId);
            return objRoleMenusEN;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static long GetFirstID_S(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                long lngmId = objRoleMenusService.RoleMenus_GetFirstID_S(strWhereCond);
                return lngmId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_GetFirstID_S", "clsQxRoleMenusWS:GetFirstID_S", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstObject_S)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static clsQxRoleMenusEN GetFirstRoleMenus_S(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                clsQxRoleMenusEN objRoleMenusEN = objRoleMenusService.RoleMenus_GetFirstRoleMenus_S(strWhereCond);
                return objRoleMenusEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_GetFirstRoleMenus_S", "clsQxRoleMenusWS:GetFirstRoleMenus_S", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecObjByKey_Cache)
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxRoleMenusEN GetQxRoleMenusObjBymId_Cache(long lngmId)
        {
            string strWhereCond = string.Format("1 = 1 order by mId");
            if (arrRoleMenusObjLst_Cache == null)
            {
                arrRoleMenusObjLst_Cache = clsQxRoleMenusWS.GetQxRoleMenusObjList(strWhereCond);
            }
            int intStart = 0;
            int intEnd = arrRoleMenusObjLst_Cache.Count - 1;
            int intMid = 0;
            clsQxRoleMenusEN objRoleMenusEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objRoleMenusEN = arrRoleMenusObjLst_Cache[intMid];
                if (objRoleMenusEN.mId == lngmId)
                {
                    intFindFailCount = 0;
                    return objRoleMenusEN;
                }
                else if (objRoleMenusEN.mId.CompareTo(lngmId) > 0)
                {
                    intEnd = intMid - 1;
                }
                else
                {
                    intStart = intMid + 1;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            arrRoleMenusObjLst_Cache = null;
            if (intFindFailCount == 1) return GetQxRoleMenusObjBymId_Cache(lngmId);
            string strErrMsgForGetObjById = string.Format("在RoleMenus对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:GetQxRoleMenusObjBymId_Cache)", lngmId, intFindFailCount);
            if (objRoleMenusEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objRoleMenusEN.mId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsQxRoleMenusBL", "GetQxRoleMenusObjBymId_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        public static List<clsQxRoleMenusEN> GetQxRoleMenusObjList(string strWhereCond)
        {
            List<clsQxRoleMenusEN> arrObjList = new List<clsQxRoleMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxRoleMenusWs(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxRoleMenusEN objRoleMenusEN = new clsQxRoleMenusEN();
                objRoleMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objRoleMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objRoleMenusEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
                objRoleMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objRoleMenusEN.IsDisp = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objRoleMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
                objRoleMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
                objRoleMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objRoleMenusEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static List<clsQxRoleMenusEN> GetQxRoleMenusObjListByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            List<clsQxRoleMenusEN> arrObjList = new List<clsQxRoleMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxRoleMenusByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxRoleMenusEN objRoleMenusEN = new clsQxRoleMenusEN();
                objRoleMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objRoleMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objRoleMenusEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
                objRoleMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objRoleMenusEN.IsDisp = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objRoleMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
                objRoleMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
                objRoleMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objRoleMenusEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                bool bolResult = objRoleMenusService.RoleMenus_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_DelRecord", "clsQxRoleMenusWS:DelRecordWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool DelRoleMenussWs(List<string> arrmId)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrmId.ToArray());
                bool bolResult = objRoleMenusService.RoleMenus_DelRoleMenuss(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_DelRoleMenuss", "clsQxRoleMenusWS:DelRoleMenussWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int DelRoleMenussByCondWs(string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                int intRecNum = objRoleMenusService.RoleMenus_DelRoleMenussByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_DelRoleMenussByCond", "clsQxRoleMenusWS:DelRoleMenussByCondWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsQxRoleMenusEN objRoleMenusEN)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                bool bolResult = objRoleMenusService.RoleMenus_AddNewRecordBySql2(objRoleMenusEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_AddNewRecordBySql2", "clsQxRoleMenusWS:AddNewRecordBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
        /// </summary>
        /// <param name = "objRoleMenusEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        public static string AddNewRecordBySql2WithReturnKey(clsQxRoleMenusEN objRoleMenusEN)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                string strKey = objRoleMenusService.RoleMenus_AddNewRecordBySql2WithReturnKey(objRoleMenusEN);
                return strKey;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_AddNewRecordBySql2WithReturnKey", "clsQxRoleMenusWS:AddNewRecordBySql2WithReturnKey", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool UpdateBySql2Ws(clsQxRoleMenusEN objRoleMenusEN)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                bool bolResult = objRoleMenusService.RoleMenus_UpdateBySql2(objRoleMenusEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_UpdateBySql2", "clsQxRoleMenusWS:UpdateBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_UpdateBySqlWithCondition)
        /// </summary>
        /// <param name = "objRoleMenusEN">需要修改的对象</param>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static bool UpdateBySqlWithCondition(clsQxRoleMenusEN objRoleMenusEN, string strWhereCond)
        {
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            try
            {
                bool bolResult = objRoleMenusService.RoleMenus_UpdateBySqlWithCondition(objRoleMenusEN, strWhereCond);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "RoleMenus_UpdateBySqlWithCondition", "clsQxRoleMenusWS:UpdateBySqlWithCondition", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool IsExistRecordWs(string strWhereCond)
        {
            //检测记录是否存在
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            bool bolIsExist = objRoleMenusService.RoleMenus_IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            RoleMenusServiceSoapClient objRoleMenusService = GetQxRoleMenusServiceSoapClient();
            bool bolIsExist = objRoleMenusService.RoleMenus_IsExist(lngmId);
            return bolIsExist;
        }



        public static int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2 = 9
            return len;
        }

        /// <summary>
        /// 获取Web服务的地址
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetServiceUrl()
        {
            String strServiceUrl = String.Empty;
            if (clsSysPara4WS.bolIsLocalHost == false)
            {
                strServiceUrl = String.Format("http://{0}/{1}/RoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
            }
            else
            {
                strServiceUrl = String.Format("http://{0}/RoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
            }
            return strServiceUrl;
        }
    }
}