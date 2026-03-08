
//类名:clsQxUserGroupPotenceWS
///----------------------
///生成代码版本:2016.09.12.1
///生成日期:2016/09/20
///生成者:潘以锋
///工程名称:统一平台
///工程ID:0014
///模块中文名:用户权限管理
///模块英文名:UserPotenceMan
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
using GeneralPlatform4WS.ServiceReferenceUserGroupPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 用户权限关系(UserGroupPotence)
    /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
    /// </summary>
    public class clsQxUserGroupPotenceWS
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        public static List<clsQxUserGroupPotenceEN> arrUserGroupPotenceObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        private static int intFindFailCount = 0;
        private static UserGroupPotenceServiceSoapClient objUserGroupPotenceServiceSoapClient = null;
        /// <summary>
        /// 
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
        /// </summary>
        /// <returns></returns>
        public static UserGroupPotenceServiceSoapClient GetQxUserGroupPotenceServiceSoapClient()
        {
            if (objUserGroupPotenceServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UserGroupPotenceServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                String strServiceUrl = String.Empty;
                if (clsSysPara4WS.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UserGroupPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UserGroupPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new UserGroupPotenceServiceSoapClient(binding, address);
            }
            else
            {
                return objUserGroupPotenceServiceSoapClient;
            }
        }

        public clsQxUserGroupPotenceWS()
        {
        }



        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:GenBindListView)
        /// </summary>
        public static int BindLv_QxUserGroupPotence(System.Windows.Forms.ListView lvUserGroupPotence, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviUserGroupPotence;
            List<clsQxUserGroupPotenceEN> arrUserGroupPotenceObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrUserGroupPotenceObjList = GetQxUserGroupPotenceObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvUserGroupPotence.Items.Clear();//清除原来所有Item
            lvUserGroupPotence.Columns.Clear();//清除原来所有列头信息
            lvUserGroupPotence.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.Columns.Add("组Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserGroupPotence.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxUserGroupPotenceEN objUserGroupPotenceEN in arrUserGroupPotenceObjList)
            {
                lviUserGroupPotence = new System.Windows.Forms.ListViewItem();
                lviUserGroupPotence.Tag = objUserGroupPotenceEN.mId;
                lviUserGroupPotence.Text = objUserGroupPotenceEN.mId.ToString();
                lviUserGroupPotence.SubItems.Add(objUserGroupPotenceEN.UserId);
                lviUserGroupPotence.SubItems.Add(objUserGroupPotenceEN.Memo);
                lvUserGroupPotence.Items.Add(lviUserGroupPotence);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrUserGroupPotenceObjList.Count;
        }

        /// <summary>
        /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4WS_CheckPropertyNew)
        /// </summary>
        public void CheckPropertyNew(clsQxUserGroupPotenceEN objUserGroupPotenceEN)
        {
            if (!Object.Equals(null, objUserGroupPotenceEN.UserId) && getStrLen(objUserGroupPotenceEN.UserId) > 18)
            {
                throw new Exception("字段[用户ID]的长度不能超过18!");
            }
            if (!Object.Equals(null, objUserGroupPotenceEN.GroupId) && getStrLen(objUserGroupPotenceEN.GroupId) > 8)
            {
                throw new Exception("字段[组Id]的长度不能超过8!");
            }
            if (!Object.Equals(null, objUserGroupPotenceEN.RoleId) && getStrLen(objUserGroupPotenceEN.RoleId) > 8)
            {
                throw new Exception("字段[角色Id]的长度不能超过8!");
            }
            if (!Object.Equals(null, objUserGroupPotenceEN.QxPrjId) && getStrLen(objUserGroupPotenceEN.QxPrjId) > 4)
            {
                throw new Exception("字段[项目Id]的长度不能超过4!");
            }
            if (!Object.Equals(null, objUserGroupPotenceEN.PotenceId) && getStrLen(objUserGroupPotenceEN.PotenceId) > 8)
            {
                throw new Exception("字段[权限ID]的长度不能超过8!");
            }
            if (!Object.Equals(null, objUserGroupPotenceEN.Memo) && getStrLen(objUserGroupPotenceEN.Memo) > 1000)
            {
                throw new Exception("字段[备注]的长度不能超过1000!");
            }
            objUserGroupPotenceEN.IsCheckProperty = true;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxUserGroupPotenceWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_GetDataSet", "clsQxUserGroupPotenceWS:GetDataTable_QxUserGroupPotenceWs", objException.Message);
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
        public static DataTable GetDataTable_QxUserGroupPotenceByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_GetDataSetByRange", "clsQxUserGroupPotenceWS:GetDataTable_QxUserGroupPotenceByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetDataTable_QxUserGroupPotenceVWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_GetDataSetV", "clsQxUserGroupPotenceWS:GetDataTable_QxUserGroupPotenceVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetQxUserGroupPotenceVWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_GetDataSetV", "clsQxUserGroupPotenceWS:GetDataTable_QxUserGroupPotenceVWs", objException.Message);
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
        public static DataTable GetDataTable_QxUserGroupPotenceVByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserGroupPotenceService.UserGroupPotence_GetDataSetVByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_GetDataSetVByRange", "clsQxUserGroupPotenceWS:GetDataTable_QxUserGroupPotenceVByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据对象的关键字值,获取对象的全部属性
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
        /// </summary>
        /// <param name = "objUserGroupPotenceEN">相关对象</param>
        /// <returns>是否成功</returns>
        public static bool GetQxUserGroupPotenceWs(ref clsQxUserGroupPotenceEN objUserGroupPotenceEN)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            bool bolResult = objUserGroupPotenceService.UserGroupPotence_GetQxUserGroupPotence(ref objUserGroupPotenceEN);
            return bolResult;
        }

        public static clsQxUserGroupPotenceEN GetQxUserGroupPotenceBymIdWs(long lngmId)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            clsQxUserGroupPotenceEN objUserGroupPotenceEN = objUserGroupPotenceService.UserGroupPotence_GetQxUserGroupPotenceBymId(lngmId);
            return objUserGroupPotenceEN;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static long GetFirstID_S(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                long lngmId = objUserGroupPotenceService.UserGroupPotence_GetFirstID_S(strWhereCond);
                return lngmId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_GetFirstID_S", "clsQxUserGroupPotenceWS:GetFirstID_S", objException.Message);
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
        public static clsQxUserGroupPotenceEN GetFirstQxUserGroupPotence_S(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                clsQxUserGroupPotenceEN objUserGroupPotenceEN = objUserGroupPotenceService.UserGroupPotence_GetFirstQxUserGroupPotence_S(strWhereCond);
                return objUserGroupPotenceEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_GetFirstQxUserGroupPotence_S", "clsQxUserGroupPotenceWS:GetFirstQxUserGroupPotence_S", objException.Message);
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
        public static clsQxUserGroupPotenceEN GetQxUserGroupPotenceObjBymId_Cache(long lngmId)
        {
            string strWhereCond = string.Format("1 = 1 order by mId");
            if (arrUserGroupPotenceObjLst_Cache == null)
            {
                arrUserGroupPotenceObjLst_Cache = clsQxUserGroupPotenceWS.GetQxUserGroupPotenceObjList(strWhereCond);
            }
            int intStart = 0;
            int intEnd = arrUserGroupPotenceObjLst_Cache.Count - 1;
            int intMid = 0;
            clsQxUserGroupPotenceEN objUserGroupPotenceEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objUserGroupPotenceEN = arrUserGroupPotenceObjLst_Cache[intMid];
                if (objUserGroupPotenceEN.mId == lngmId)
                {
                    intFindFailCount = 0;
                    return objUserGroupPotenceEN;
                }
                else if (objUserGroupPotenceEN.mId.CompareTo(lngmId) > 0)
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
            arrUserGroupPotenceObjLst_Cache = null;
            if (intFindFailCount == 1) return GetQxUserGroupPotenceObjBymId_Cache(lngmId);
            string strErrMsgForGetObjById = string.Format("在UserGroupPotence对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:GetQxUserGroupPotenceObjBymId_Cache)", lngmId, intFindFailCount);
            if (objUserGroupPotenceEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objUserGroupPotenceEN.mId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsQxUserGroupPotenceBL", "GetQxUserGroupPotenceObjBymId_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        public static List<clsQxUserGroupPotenceEN> GetQxUserGroupPotenceObjList(string strWhereCond)
        {
            List<clsQxUserGroupPotenceEN> arrObjList = new List<clsQxUserGroupPotenceEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxUserGroupPotenceWs(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxUserGroupPotenceEN objUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
                objUserGroupPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objUserGroupPotenceEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserGroupPotenceEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
                objUserGroupPotenceEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserGroupPotenceEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
                objUserGroupPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
                objUserGroupPotenceEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
                objUserGroupPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserGroupPotenceEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static List<clsQxUserGroupPotenceEN> GetQxUserGroupPotenceObjListByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            List<clsQxUserGroupPotenceEN> arrObjList = new List<clsQxUserGroupPotenceEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxUserGroupPotenceByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxUserGroupPotenceEN objUserGroupPotenceEN = new clsQxUserGroupPotenceEN();
                objUserGroupPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objUserGroupPotenceEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserGroupPotenceEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
                objUserGroupPotenceEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserGroupPotenceEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
                objUserGroupPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
                objUserGroupPotenceEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
                objUserGroupPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserGroupPotenceEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_DelRecord", "clsQxUserGroupPotenceWS:DelRecordWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool DelQxUserGroupPotencesWs(List<string> arrmId)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrmId.ToArray());
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_DelQxUserGroupPotences(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_DelQxUserGroupPotences", "clsQxUserGroupPotenceWS:DelQxUserGroupPotencesWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int DelQxUserGroupPotencesByCondWs(string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                int intRecNum = objUserGroupPotenceService.UserGroupPotence_DelQxUserGroupPotencesByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_DelQxUserGroupPotencesByCond", "clsQxUserGroupPotenceWS:DelQxUserGroupPotencesByCondWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsQxUserGroupPotenceEN objUserGroupPotenceEN)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_AddNewRecordBySql2(objUserGroupPotenceEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_AddNewRecordBySql2", "clsQxUserGroupPotenceWS:AddNewRecordBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把表对象添加到数据库中,并且返回该记录的关键字
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
        /// </summary>
        /// <param name = "objUserGroupPotenceEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        public static string AddNewRecordBySql2WithReturnKey(clsQxUserGroupPotenceEN objUserGroupPotenceEN)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                string strKey = objUserGroupPotenceService.UserGroupPotence_AddNewRecordBySql2WithReturnKey(objUserGroupPotenceEN);
                return strKey;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_AddNewRecordBySql2WithReturnKey", "clsQxUserGroupPotenceWS:AddNewRecordBySql2WithReturnKey", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool UpdateBySql2Ws(clsQxUserGroupPotenceEN objUserGroupPotenceEN)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_UpdateBySql2(objUserGroupPotenceEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_UpdateBySql2", "clsQxUserGroupPotenceWS:UpdateBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_UpdateBySqlWithCondition)
        /// </summary>
        /// <param name = "objUserGroupPotenceEN">需要修改的对象</param>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static bool UpdateBySqlWithCondition(clsQxUserGroupPotenceEN objUserGroupPotenceEN, string strWhereCond)
        {
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            try
            {
                bool bolResult = objUserGroupPotenceService.UserGroupPotence_UpdateBySqlWithCondition(objUserGroupPotenceEN, strWhereCond);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "UserGroupPotence_UpdateBySqlWithCondition", "clsQxUserGroupPotenceWS:UpdateBySqlWithCondition", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool IsExistRecordWs(string strWhereCond)
        {
            //检测记录是否存在
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            bool bolIsExist = objUserGroupPotenceService.UserGroupPotence_IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            UserGroupPotenceServiceSoapClient objUserGroupPotenceService = GetQxUserGroupPotenceServiceSoapClient();
            bool bolIsExist = objUserGroupPotenceService.UserGroupPotence_IsExist(lngmId);
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
                strServiceUrl = String.Format("http://{0}/{1}/UserGroupPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
            }
            else
            {
                strServiceUrl = String.Format("http://{0}/UserGroupPotenceService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
            }
            return strServiceUrl;
        }
    }
}