
//类名:clsQxViewPotenceWS
///----------------------
///生成代码版本:2016.09.12.1
///生成日期:2016/09/20
///生成者:潘以锋
///工程名称:统一平台
///工程ID:0014
///模块中文名:界面管理
///模块英文名:InterfaceMan
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
using GeneralPlatform4WS.ServiceReferenceViewPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 界面权限(ViewPotence)
    /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
    /// </summary>
    public class clsQxViewPotenceWS
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        public static List<clsQxViewPotenceEN> arrViewPotenceObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        private static int intFindFailCount = 0;
        private static ViewPotenceServiceSoapClient objViewPotenceServiceSoapClient = null;
        /// <summary>
        /// 
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        /// <returns></returns>
        public static ViewPotenceServiceSoapClient GetViewPotenceServiceSoapClient()
        {
            if (objViewPotenceServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "ViewPotenceServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                String strServiceUrl = String.Empty;
                if (clsSysPara4WS.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/ViewPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/ViewPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new ViewPotenceServiceSoapClient(binding, address);
            }
            else
            {
                return objViewPotenceServiceSoapClient;
            }
        }

        public clsQxViewPotenceWS()
        {
        }



        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:GenBindListView)
        /// </summary>
        public static int BindLv_QxViewPotence(System.Windows.Forms.ListView lvViewPotence, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviViewPotence;
            List<clsQxViewPotenceEN> arrViewPotenceObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrViewPotenceObjList = GetViewPotenceObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvViewPotence.Items.Clear();//清除原来所有Item
            lvViewPotence.Columns.Clear();//清除原来所有列头信息
            lvViewPotence.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewPotence.Columns.Add("界面编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewPotence.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewPotence.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewPotence.Columns.Add("等级", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewPotence.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvViewPotence.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxViewPotenceEN objViewPotenceEN in arrViewPotenceObjList)
            {
                lviViewPotence = new System.Windows.Forms.ListViewItem();
                lviViewPotence.Tag = objViewPotenceEN.mId;
                lviViewPotence.Text = objViewPotenceEN.mId.ToString();
                lviViewPotence.SubItems.Add(objViewPotenceEN.Level.ToString());
                lviViewPotence.SubItems.Add(objViewPotenceEN.Memo);
                lvViewPotence.Items.Add(lviViewPotence);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrViewPotenceObjList.Count;
        }

        /// <summary>
        /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4WS_CheckPropertyNew)
        /// </summary>
        public void CheckPropertyNew(clsQxViewPotenceEN objViewPotenceEN)
        {
            if (!Object.Equals(null, objViewPotenceEN.ViewId) && getStrLen(objViewPotenceEN.ViewId) > 8)
            {
                throw new Exception("字段[界面编号]的长度不能超过8!");
            }
            if (!Object.Equals(null, objViewPotenceEN.QxPrjId) && getStrLen(objViewPotenceEN.QxPrjId) > 4)
            {
                throw new Exception("字段[项目Id]的长度不能超过4!");
            }
            if (!Object.Equals(null, objViewPotenceEN.PotenceId) && getStrLen(objViewPotenceEN.PotenceId) > 8)
            {
                throw new Exception("字段[权限ID]的长度不能超过8!");
            }
            if (!Object.Equals(null, objViewPotenceEN.Memo) && getStrLen(objViewPotenceEN.Memo) > 1000)
            {
                throw new Exception("字段[备注]的长度不能超过1000!");
            }
            objViewPotenceEN.IsCheckProperty = true;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxViewPotenceWs(string strWhereCond)
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
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_GetDataSet", "clsQxViewPotenceWS:GetDataTable_QxViewPotenceWs", objException.Message);
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
        public static DataTable GetDataTable_QxViewPotenceByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objViewPotenceService.ViewPotence_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_GetDataSetByRange", "clsQxViewPotenceWS:GetDataTable_QxViewPotenceByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetDataTable_QxViewPotenceVWs(string strWhereCond)
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
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_GetDataSetV", "clsQxViewPotenceWS:GetDataTable_QxViewPotenceVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
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
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_GetDataSetV", "clsQxViewPotenceWS:GetDataTable_QxViewPotenceVWs", objException.Message);
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
        public static DataTable GetDataTable_QxViewPotenceVByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objViewPotenceService.ViewPotence_GetDataSetVByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_GetDataSetVByRange", "clsQxViewPotenceWS:GetDataTable_QxViewPotenceVByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据对象的关键字值,获取对象的全部属性
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
        /// </summary>
        /// <param name = "objViewPotenceEN">相关对象</param>
        /// <returns>是否成功</returns>
        public static bool GetViewPotenceWs(ref clsQxViewPotenceEN objViewPotenceEN)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            bool bolResult = objViewPotenceService.ViewPotence_GetViewPotence(ref objViewPotenceEN);
            return bolResult;
        }

        public static clsQxViewPotenceEN GetViewPotenceBymIdWs(long lngmId)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            clsQxViewPotenceEN objViewPotenceEN = objViewPotenceService.ViewPotence_GetViewPotenceBymId(lngmId);
            return objViewPotenceEN;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static long GetFirstID_S(string strWhereCond)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                long lngmId = objViewPotenceService.ViewPotence_GetFirstID_S(strWhereCond);
                return lngmId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_GetFirstID_S", "clsQxViewPotenceWS:GetFirstID_S", objException.Message);
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
        public static clsQxViewPotenceEN GetFirstViewPotence_S(string strWhereCond)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                clsQxViewPotenceEN objViewPotenceEN = objViewPotenceService.ViewPotence_GetFirstViewPotence_S(strWhereCond);
                return objViewPotenceEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_GetFirstViewPotence_S", "clsQxViewPotenceWS:GetFirstViewPotence_S", objException.Message);
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
        public static clsQxViewPotenceEN GetViewPotenceObjBymId_Cache(long lngmId)
        {
            string strWhereCond = string.Format("1 = 1 order by mId");
            if (arrViewPotenceObjLst_Cache == null)
            {
                arrViewPotenceObjLst_Cache = clsQxViewPotenceWS.GetViewPotenceObjList(strWhereCond);
            }
            int intStart = 0;
            int intEnd = arrViewPotenceObjLst_Cache.Count - 1;
            int intMid = 0;
            clsQxViewPotenceEN objViewPotenceEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objViewPotenceEN = arrViewPotenceObjLst_Cache[intMid];
                if (objViewPotenceEN.mId == lngmId)
                {
                    intFindFailCount = 0;
                    return objViewPotenceEN;
                }
                else if (objViewPotenceEN.mId.CompareTo(lngmId) > 0)
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
            arrViewPotenceObjLst_Cache = null;
            if (intFindFailCount == 1) return GetViewPotenceObjBymId_Cache(lngmId);
            string strErrMsgForGetObjById = string.Format("在ViewPotence对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:GetViewPotenceObjBymId_Cache)", lngmId, intFindFailCount);
            if (objViewPotenceEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objViewPotenceEN.mId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsQxViewPotenceBL", "GetViewPotenceObjBymId_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        public static List<clsQxViewPotenceEN> GetViewPotenceObjList(string strWhereCond)
        {
            List<clsQxViewPotenceEN> arrObjList = new List<clsQxViewPotenceEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxViewPotenceWs(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxViewPotenceEN objViewPotenceEN = new clsQxViewPotenceEN();
                objViewPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objViewPotenceEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
                objViewPotenceEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
                objViewPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
                objViewPotenceEN.Level = Int32.Parse(objRow["Level"].ToString().Trim()); //等级
                objViewPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objViewPotenceEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static List<clsQxViewPotenceEN> GetViewPotenceObjListByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            List<clsQxViewPotenceEN> arrObjList = new List<clsQxViewPotenceEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxViewPotenceByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxViewPotenceEN objViewPotenceEN = new clsQxViewPotenceEN();
                objViewPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objViewPotenceEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
                objViewPotenceEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
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
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_DelRecord", "clsQxViewPotenceWS:DelRecordWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool DelViewPotencesWs(List<string> arrmId)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrmId.ToArray());
                bool bolResult = objViewPotenceService.ViewPotence_DelViewPotences(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_DelViewPotences", "clsQxViewPotenceWS:DelViewPotencesWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
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
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_DelViewPotencesByCond", "clsQxViewPotenceWS:DelViewPotencesByCondWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsQxViewPotenceEN objViewPotenceEN)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                bool bolResult = objViewPotenceService.ViewPotence_AddNewRecordBySql2(objViewPotenceEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_AddNewRecordBySql2", "clsQxViewPotenceWS:AddNewRecordBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
        /// </summary>
        /// <param name = "objViewPotenceEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        public static string AddNewRecordBySql2WithReturnKey(clsQxViewPotenceEN objViewPotenceEN)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                string strKey = objViewPotenceService.ViewPotence_AddNewRecordBySql2WithReturnKey(objViewPotenceEN);
                return strKey;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_AddNewRecordBySql2WithReturnKey", "clsQxViewPotenceWS:AddNewRecordBySql2WithReturnKey", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool UpdateBySql2Ws(clsQxViewPotenceEN objViewPotenceEN)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                bool bolResult = objViewPotenceService.ViewPotence_UpdateBySql2(objViewPotenceEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_UpdateBySql2", "clsQxViewPotenceWS:UpdateBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_UpdateBySqlWithCondition)
        /// </summary>
        /// <param name = "objViewPotenceEN">需要修改的对象</param>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static bool UpdateBySqlWithCondition(clsQxViewPotenceEN objViewPotenceEN, string strWhereCond)
        {
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            try
            {
                bool bolResult = objViewPotenceService.ViewPotence_UpdateBySqlWithCondition(objViewPotenceEN, strWhereCond);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "ViewPotence_UpdateBySqlWithCondition", "clsQxViewPotenceWS:UpdateBySqlWithCondition", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool IsExistRecordWs(string strWhereCond)
        {
            //检测记录是否存在
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            bool bolIsExist = objViewPotenceService.ViewPotence_IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            ViewPotenceServiceSoapClient objViewPotenceService = GetViewPotenceServiceSoapClient();
            bool bolIsExist = objViewPotenceService.ViewPotence_IsExist(lngmId);
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
                strServiceUrl = String.Format("http://{0}/{1}/ViewPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
            }
            else
            {
                strServiceUrl = String.Format("http://{0}/ViewPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
            }
            return strServiceUrl;
        }
    }
}