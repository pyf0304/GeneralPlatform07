
//----------------------
//生成代码版本：2015.06.19.1
//生成日期：2015/06/19
//生成者：潘以锋
//工程名称：统一平台
//工程ID：0014
//模块中文名：工程管理
//模块英文名：PrjManage
//注意：1、需要数据底层（PubDataBase.dll）的版本：2015.05.08.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2015.05.08.1
//========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferencePrjDataBase;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 数据库对象(PrjDataBase)
    /// </summary>
    public class clsQxPrjDataBaseWS
    {
        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsQxPrjDataBaseEN> arrPrjDataBaseObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        private static int intFindFailCount = 0;
        private static PrjDataBaseServiceSoapClient objPrjDataBaseServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static PrjDataBaseServiceSoapClient GetQxPrjDataBaseServiceSoapClient()
        {
            if (objPrjDataBaseServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "PrjDataBaseServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                String strServiceUrl = String.Empty;
                if (clsSysPara4WS.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/PrjDataBaseService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/PrjDataBaseService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new PrjDataBaseServiceSoapClient(binding, address);
            }
            else
            {
                return objPrjDataBaseServiceSoapClient;
            }
        }

        public clsQxPrjDataBaseWS()
        {
        }

        public static System.Data.DataTable GetQxPrjDataBaseId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjDataBaseId, PrjDataBaseName from PrjDataBase ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// </summary>
        /// <param name="objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_QxPrjDataBaseId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetDataTable_QxPrjDataBaseWs("1=1");
            clsQxPrjDataBaseEN objPrjDataBaseEN;
            //初始化一个对象列表
            ArrayList PrjDataBaseList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
            objPrjDataBaseEN = new clsQxPrjDataBaseEN();
            objPrjDataBaseEN.PrjDataBaseId = "0";
            objPrjDataBaseEN.PrjDataBaseName = "请选择...";
            PrjDataBaseList.Add(objPrjDataBaseEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjDataBaseEN = new clsQxPrjDataBaseEN();
                objPrjDataBaseEN.PrjDataBaseId = objRow["PrjDataBaseId"].ToString();
                objPrjDataBaseEN.PrjDataBaseName = objRow["PrjDataBaseName"].ToString();
                PrjDataBaseList.Add(objPrjDataBaseEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjDataBaseList;
            objComboBox.ValueMember = "PrjDataBaseId";
            objComboBox.DisplayMember = "PrjDataBaseName";
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// </summary>
        /// <param name="objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_QxPrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDataTable_QxPrjDataBaseWs("1=1");
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_QxPrjDataBase(System.Windows.Forms.ListView lvPrjDataBase, string strWhereCond)
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviPrjDataBase;
            List<clsQxPrjDataBaseEN> arrPrjDataBaseObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrPrjDataBaseObjList = GetQxPrjDataBaseObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvPrjDataBase.Items.Clear();//清除原来所有Item
            lvPrjDataBase.Columns.Clear();//清除原来所有列头信息
            lvPrjDataBase.Columns.Add("项目数据库Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("项目数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库拥有者", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("SID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("表空间", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("UpdDate", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxPrjDataBaseEN objPrjDataBaseEN in arrPrjDataBaseObjList)
            {
                lviPrjDataBase = new System.Windows.Forms.ListViewItem();
                lviPrjDataBase.Tag = objPrjDataBaseEN.PrjDataBaseId;
                lviPrjDataBase.Text = objPrjDataBaseEN.PrjDataBaseId.ToString();
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.PrjDataBaseName);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.DataBaseName);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.DatabaseOwner);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.DataBasePwd);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.DataBaseUserId);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.IpAddress);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.SID);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.TableSpace);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.UserId);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.UpdDate);
                lviPrjDataBase.SubItems.Add(objPrjDataBaseEN.Memo);
                lvPrjDataBase.Items.Add(lviPrjDataBase);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrPrjDataBaseObjList.Count;
        }

        /// <summary>
        /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public void CheckPropertyNew(clsQxPrjDataBaseEN objPrjDataBaseEN)
        {
            if (!Object.Equals(null, objPrjDataBaseEN.PrjDataBaseId) && getStrLen(objPrjDataBaseEN.PrjDataBaseId) > 4)
            {
                throw new Exception("字段[项目数据库Id]的长度不能超过4!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.PrjDataBaseName) && getStrLen(objPrjDataBaseEN.PrjDataBaseName) > 50)
            {
                throw new Exception("字段[项目数据库名]的长度不能超过50!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.DataBaseName) && getStrLen(objPrjDataBaseEN.DataBaseName) > 30)
            {
                throw new Exception("字段[数据库名称]的长度不能超过30!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.DatabaseOwner) && getStrLen(objPrjDataBaseEN.DatabaseOwner) > 30)
            {
                throw new Exception("字段[数据库拥有者]的长度不能超过30!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.DataBasePwd) && getStrLen(objPrjDataBaseEN.DataBasePwd) > 20)
            {
                throw new Exception("字段[数据库用户口令]的长度不能超过20!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.DataBaseTypeId) && getStrLen(objPrjDataBaseEN.DataBaseTypeId) > 2)
            {
                throw new Exception("字段[数据库类型ID]的长度不能超过2!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.DataBaseUserId) && getStrLen(objPrjDataBaseEN.DataBaseUserId) > 18)
            {
                throw new Exception("字段[数据库用户Id]的长度不能超过18!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.IpAddress) && getStrLen(objPrjDataBaseEN.IpAddress) > 23)
            {
                throw new Exception("字段[IP地址]的长度不能超过23!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.SID) && getStrLen(objPrjDataBaseEN.SID) > 30)
            {
                throw new Exception("字段[SID]的长度不能超过30!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.TableSpace) && getStrLen(objPrjDataBaseEN.TableSpace) > 30)
            {
                throw new Exception("字段[表空间]的长度不能超过30!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.UserId) && getStrLen(objPrjDataBaseEN.UserId) > 18)
            {
                throw new Exception("字段[用户ID]的长度不能超过18!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.UpdDate) && getStrLen(objPrjDataBaseEN.UpdDate) > 8)
            {
                throw new Exception("字段[UpdDate]的长度不能超过8!");
            }
            if (!Object.Equals(null, objPrjDataBaseEN.Memo) && getStrLen(objPrjDataBaseEN.Memo) > 1000)
            {
                throw new Exception("字段[备注]的长度不能超过1000!");
            }
            objPrjDataBaseEN.IsCheckProperty = true;
        }

        /// <summary>
        /// 根据条件获取数据表，用DataTable表示
        /// </summary>
        /// <param name="strWhereCond">条件串</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxPrjDataBaseWs(string strWhereCond)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjDataBaseService.PrjDataBase_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_GetDataSet", "clsQxPrjDataBaseWS:GetDataTable_QxPrjDataBaseWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取一定范围的数据表，用DataTable表示
        /// </summary>
        /// <param name="strWhereCond">条件串</param>
        /// <param name="lngMinNum">范围之最小值</param>
        /// <param name="lngMaxNum">范围之最大值</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxPrjDataBaseByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjDataBaseService.PrjDataBase_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_GetDataSetByRange", "clsQxPrjDataBaseWS:GetDataTable_QxPrjDataBaseByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetDataTable_QxPrjDataBaseVWs(string strWhereCond)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjDataBaseService.PrjDataBase_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_GetDataSetV", "clsQxPrjDataBaseWS:GetDataTable_QxPrjDataBaseVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetQxPrjDataBaseVWs(string strWhereCond)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjDataBaseService.PrjDataBase_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_GetDataSetV", "clsQxPrjDataBaseWS:GetDataTable_QxPrjDataBaseVWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取一定范围的数据表，用DataTable表示
        /// </summary>
        /// <param name="strWhereCond">条件串</param>
        /// <param name="lngMinNum">范围之最小值</param>
        /// <param name="lngMaxNum">范围之最大值</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_QxPrjDataBaseVByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjDataBaseService.PrjDataBase_GetDataSetVByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_GetDataSetVByRange", "clsQxPrjDataBaseWS:GetDataTable_QxPrjDataBaseVByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据对象的关键字值，获取对象的全部属性
        /// </summary>
        /// <param name="objPrjDataBaseEN">相关对象</param>
        /// <returns>是否成功</returns>
        public static bool GetQxPrjDataBaseWs(ref clsQxPrjDataBaseEN objPrjDataBaseEN)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            bool bolResult = objPrjDataBaseService.PrjDataBase_GetQxPrjDataBase(ref objPrjDataBaseEN);
            return bolResult;
        }

        public static clsQxPrjDataBaseEN GetQxPrjDataBaseByPrjDataBaseIdWs(string strPrjDataBaseId)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            clsQxPrjDataBaseEN objPrjDataBaseEN = objPrjDataBaseService.PrjDataBase_GetQxPrjDataBaseByPrjDataBaseId(strPrjDataBaseId);
            return objPrjDataBaseEN;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static string GetFirstID_S(string strCondition)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                string strPrjDataBaseId = objPrjDataBaseService.PrjDataBase_GetFirstID_S(strCondition);
                return strPrjDataBaseId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_GetFirstID_S", "clsQxPrjDataBaseWS:GetFirstID_S", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static clsQxPrjDataBaseEN GetFirstPrjDataBase_S(string strCondition)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                clsQxPrjDataBaseEN objPrjDataBaseEN = objPrjDataBaseService.PrjDataBase_GetFirstPrjDataBase_S(strCondition);
                return objPrjDataBaseEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_GetFirstPrjDataBase_S", "clsQxPrjDataBaseWS:GetFirstPrjDataBase_S", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strPrjDataBaseId">所给的关键字</param>
        /// <returns>根据关键字获取的名称</returns>
        public static string GetQxPrjDataBaseNameByPrjDataBaseId_Cache(string strPrjDataBaseId)
        {
            if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return "";
            string strCondition = string.Format("1=1 order by PrjDataBaseId");
            if (arrPrjDataBaseObjLst_Cache == null)
            {
                arrPrjDataBaseObjLst_Cache = clsQxPrjDataBaseWS.GetQxPrjDataBaseObjList(strCondition);
            }
            int intStart = 0;
            int intEnd = arrPrjDataBaseObjLst_Cache.Count - 1;
            int intMid = 0;
            clsQxPrjDataBaseEN objPrjDataBaseEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objPrjDataBaseEN = arrPrjDataBaseObjLst_Cache[intMid];
                if (objPrjDataBaseEN.PrjDataBaseId == strPrjDataBaseId)
                {
                    intFindFailCount = 0;
                    return objPrjDataBaseEN.PrjDataBaseName;
                }
                else if (objPrjDataBaseEN.PrjDataBaseId.CompareTo(strPrjDataBaseId) > 0)
                {
                    intEnd = intMid - 1;
                }
                else
                {
                    intStart = intMid + 1;
                }
            }
            intFindFailCount++;
            // 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
            arrPrjDataBaseObjLst_Cache = null;
            if (intFindFailCount == 1) return GetQxPrjDataBaseNameByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strErrMsgForGetObjById = string.Format("在PrjDataBase对象缓存列表中，找不到记录[PrjDataBaseId={0}][intFindFailCount={1}](函数:GetQxPrjDataBaseNameByPrjDataBaseId_Cache)", strPrjDataBaseId, intFindFailCount);
            if (objPrjDataBaseEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid={1}]", objPrjDataBaseEN.PrjDataBaseId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查！[intMid={0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsQxPrjDataBaseBL", "GetQxPrjDataBaseNameByPrjDataBaseId_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strPrjDataBaseId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxPrjDataBaseEN GetQxPrjDataBaseObjByPrjDataBaseId_Cache(string strPrjDataBaseId)
        {
            if (string.IsNullOrEmpty(strPrjDataBaseId) == true) return null;
            string strCondition = string.Format("1=1 order by PrjDataBaseId");
            if (arrPrjDataBaseObjLst_Cache == null)
            {
                arrPrjDataBaseObjLst_Cache = clsQxPrjDataBaseWS.GetQxPrjDataBaseObjList(strCondition);
            }
            int intStart = 0;
            int intEnd = arrPrjDataBaseObjLst_Cache.Count - 1;
            int intMid = 0;
            clsQxPrjDataBaseEN objPrjDataBaseEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objPrjDataBaseEN = arrPrjDataBaseObjLst_Cache[intMid];
                if (objPrjDataBaseEN.PrjDataBaseId == strPrjDataBaseId)
                {
                    intFindFailCount = 0;
                    return objPrjDataBaseEN;
                }
                else if (objPrjDataBaseEN.PrjDataBaseId.CompareTo(strPrjDataBaseId) > 0)
                {
                    intEnd = intMid - 1;
                }
                else
                {
                    intStart = intMid + 1;
                }
            }
            intFindFailCount++;
            // 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
            arrPrjDataBaseObjLst_Cache = null;
            if (intFindFailCount == 1) return GetQxPrjDataBaseObjByPrjDataBaseId_Cache(strPrjDataBaseId);
            string strErrMsgForGetObjById = string.Format("在PrjDataBase对象缓存列表中，找不到记录[PrjDataBaseId={0}][intFindFailCount={1}](函数:GetQxPrjDataBaseObjByPrjDataBaseId_Cache)", strPrjDataBaseId, intFindFailCount);
            if (objPrjDataBaseEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid={1}]", objPrjDataBaseEN.PrjDataBaseId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查！[intMid={0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsQxPrjDataBaseBL", "GetQxPrjDataBaseObjByPrjDataBaseId_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        public static List<clsQxPrjDataBaseEN> GetQxPrjDataBaseObjList(string strCondition)
        {
            List<clsQxPrjDataBaseEN> arrObjList = new List<clsQxPrjDataBaseEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxPrjDataBaseWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxPrjDataBaseEN objPrjDataBaseEN = new clsQxPrjDataBaseEN();
                objPrjDataBaseEN.PrjDataBaseId = objRow["PrjDataBaseId"].ToString().Trim(); //项目数据库Id
                objPrjDataBaseEN.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim(); //项目数据库名
                objPrjDataBaseEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
                objPrjDataBaseEN.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim(); //数据库拥有者
                objPrjDataBaseEN.DataBasePwd = objRow["DataBasePwd"].ToString().Trim(); //数据库用户口令
                objPrjDataBaseEN.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim(); //数据库类型ID
                objPrjDataBaseEN.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim(); //数据库用户Id
                objPrjDataBaseEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
                objPrjDataBaseEN.SID = objRow["SID"].ToString().Trim(); //SID
                objPrjDataBaseEN.TableSpace = objRow["TableSpace"].ToString().Trim(); //表空间
                objPrjDataBaseEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objPrjDataBaseEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
                objPrjDataBaseEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objPrjDataBaseEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static List<clsQxPrjDataBaseEN> GetQxPrjDataBaseObjListByRange(string strCondition, long lngMinNum, long lngMaxNum)
        {
            List<clsQxPrjDataBaseEN> arrObjList = new List<clsQxPrjDataBaseEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_QxPrjDataBaseByRangeWs(strCondition, lngMinNum, lngMaxNum);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxPrjDataBaseEN objPrjDataBaseEN = new clsQxPrjDataBaseEN();
                objPrjDataBaseEN.PrjDataBaseId = objRow["PrjDataBaseId"].ToString().Trim(); //项目数据库Id
                objPrjDataBaseEN.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim(); //项目数据库名
                objPrjDataBaseEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
                objPrjDataBaseEN.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim(); //数据库拥有者
                objPrjDataBaseEN.DataBasePwd = objRow["DataBasePwd"].ToString().Trim(); //数据库用户口令
                objPrjDataBaseEN.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim(); //数据库类型ID
                objPrjDataBaseEN.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim(); //数据库用户Id
                objPrjDataBaseEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
                objPrjDataBaseEN.SID = objRow["SID"].ToString().Trim(); //SID
                objPrjDataBaseEN.TableSpace = objRow["TableSpace"].ToString().Trim(); //表空间
                objPrjDataBaseEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objPrjDataBaseEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
                objPrjDataBaseEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objPrjDataBaseEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(string strPrjDataBaseId)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                bool bolResult = objPrjDataBaseService.PrjDataBase_DelRecord(strPrjDataBaseId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_DelRecord", "clsQxPrjDataBaseWS:DelRecordWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool DelPrjDataBasesWs(List<string> arrPrjDataBaseId)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                string[] sstrPrjDataBaseId = (string[])(arrPrjDataBaseId.ToArray());
                bool bolResult = objPrjDataBaseService.PrjDataBase_DelPrjDataBases(sstrPrjDataBaseId);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_DelPrjDataBases", "clsQxPrjDataBaseWS:DelPrjDataBasesWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static int DelPrjDataBasesByCondWs(string strWhereCond)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                int intRecNum = objPrjDataBaseService.PrjDataBase_DelPrjDataBasesByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_DelPrjDataBasesByCond", "clsQxPrjDataBaseWS:DelPrjDataBasesByCondWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsQxPrjDataBaseEN objPrjDataBaseEN)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                bool bolResult = objPrjDataBaseService.PrjDataBase_AddNewRecordBySql2(objPrjDataBaseEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_AddNewRecordBySql2", "clsQxPrjDataBaseWS:AddNewRecordBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把表对象添加到数据库中，并且返回该记录的关键字
        /// </summary>
        /// <param name="objPrjDataBaseEN">需要添加的表对象</param>
        /// <returns>返回新添加记录的关键字</returns>
        public static string AddNewRecordBySql2WithReturnKey(clsQxPrjDataBaseEN objPrjDataBaseEN)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                string strKey = objPrjDataBaseService.PrjDataBase_AddNewRecordBySql2WithReturnKey(objPrjDataBaseEN);
                return strKey;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_AddNewRecordBySql2WithReturnKey", "clsQxPrjDataBaseWS:AddNewRecordBySql2WithReturnKey", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool UpdateBySql2Ws(clsQxPrjDataBaseEN objPrjDataBaseEN)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                bool bolResult = objPrjDataBaseService.PrjDataBase_UpdateBySql2(objPrjDataBaseEN);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_UpdateBySql2", "clsQxPrjDataBaseWS:UpdateBySql2Ws", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// </summary>
        /// <param name="objPrjDataBaseEN">需要修改的对象</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static bool UpdateBySqlWithCondition(clsQxPrjDataBaseEN objPrjDataBaseEN, string strCondition)
        {
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            try
            {
                bool bolResult = objPrjDataBaseService.PrjDataBase_UpdateBySqlWithCondition(objPrjDataBaseEN, strCondition);
                return bolResult;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}. 调用函数名：{2}.",
                         GetServiceUrl(), "PrjDataBase_UpdateBySqlWithCondition", "clsQxPrjDataBaseWS:UpdateBySqlWithCondition", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                         objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            bool bolIsExist = objPrjDataBaseService.PrjDataBase_IsExistRecord(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(string strPrjDataBaseId)
        {
            //检测记录是否存在
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            bool bolIsExist = objPrjDataBaseService.PrjDataBase_IsExist(strPrjDataBaseId);
            return bolIsExist;
        }

        /// <summary>
        /// 获取当前表关键字值的最大值，再加1，避免重复
        /// </summary>
        /// <returns>当前表关键字值的最大值，再加1</returns>
        public static string GetMaxStrIdWs()
        {
            //检测记录是否存在
            PrjDataBaseServiceSoapClient objPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
            string strMaxPrjDataBaseId = objPrjDataBaseService.PrjDataBase_GetMaxStrId();
            return strMaxPrjDataBaseId;
        }

        public static int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2=9
            return len;
        }

        /// <summary>
        /// 获取Web服务的地址
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetServiceUrl()
        {
            String strServiceUrl = String.Empty;
            if (clsSysPara4WS.bolIsLocalHost == false)
            {
                strServiceUrl = String.Format("http://{0}/{1}/PrjDataBaseService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
            }
            else
            {
                strServiceUrl = String.Format("http://{0}/PrjDataBaseService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
            }
            return strServiceUrl;
        }
    }
}