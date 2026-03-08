
//类名:clsvQxRoleMenusWS
///----------------------
///生成代码版本:2016.09.12.1
///生成日期:2016/09/29
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
using System.Collections.Generic;
using GeneralPlatform4WS.ServiceReferencevRoleMenus;
using com.taishsoft.common;


namespace GeneralPlatform4WS
{
    /// <summary>
    /// v角色菜单(vRoleMenus)
    /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode4View)
    /// </summary>
    public class clsvQxRoleMenusWS
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode4View)
        /// </summary>
        public static List<clsvQxRoleMenusEN> arrvRoleMenusObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode4View)
        /// </summary>
        private static int intFindFailCount = 0;
        private static vRoleMenusServiceSoapClient objvRoleMenusServiceSoapClient = null;
        /// <summary>
        /// 
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode4View)
        /// </summary>
        /// <returns></returns>
        public static vRoleMenusServiceSoapClient GetvQxRoleMenusServiceSoapClient()
        {
            if (objvRoleMenusServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vRoleMenusServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                String strServiceUrl = String.Empty;
                if (clsSysPara4WS.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/vRoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/vRoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new vRoleMenusServiceSoapClient(binding, address);
            }
            else
            {
                return objvRoleMenusServiceSoapClient;
            }
        }

        public clsvQxRoleMenusWS()
        {
        }



        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:GenBindListView)
        /// </summary>
        public static int BindLv_vRoleMenus(System.Windows.Forms.ListView lvvRoleMenus, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lvivRoleMenus;
            List<clsvQxRoleMenusEN> arrvRoleMenusObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvRoleMenusObjList = GetvQxRoleMenusObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvvRoleMenus.Items.Clear();//清除原来所有Item
            lvvRoleMenus.Columns.Clear();//清除原来所有列头信息
            lvvRoleMenus.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("菜单集名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("页面显示模式名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("上级菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvRoleMenus.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvQxRoleMenusEN objvRoleMenusEN in arrvRoleMenusObjList)
            {
                lvivRoleMenus = new System.Windows.Forms.ListViewItem();
                lvivRoleMenus.Tag = objvRoleMenusEN.mId;
                lvivRoleMenus.Text = objvRoleMenusEN.mId.ToString();
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.RoleId);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.RoleName);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.QxPrjId);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.MenuId);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.MenuName);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.PrjName);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.UpMenuId);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.LinkFile);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.qsParameters);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.ImgFile);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.OrderNum.ToString());
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.IsLeafNode.ToString());
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.MenuSetId);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.MenuSetName);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.MenuTitle);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.PageDispModeId);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.PageDispModeName);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.InUse.ToString());
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.UpMenuName);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.IsDisp.ToString());
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.UpdDate);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.UpdUserId);
                lvivRoleMenus.SubItems.Add(objvRoleMenusEN.Memo);
                lvvRoleMenus.Items.Add(lvivRoleMenus);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrvRoleMenusObjList.Count;
        }

        /// <summary>
        /// 根据条件获取数据表,用DataTable表示
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_vRoleMenusWs(string strWhereCond)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vRoleMenus_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "vRoleMenus_GetDataSet", "clsvQxRoleMenusWS:GetDataTable_vRoleMenusWs", objException.Message);
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
        public static DataTable GetDataTable_vRoleMenusByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vRoleMenus_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "vRoleMenus_GetDataSetByRange", "clsvQxRoleMenusWS:GetDataTable_vRoleMenusByRangeWs", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据对象的关键字值,获取对象的全部属性
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
        /// </summary>
        /// <param name = "objvRoleMenusEN">相关对象</param>
        /// <returns>是否成功</returns>
        public static bool GetvQxRoleMenusWs(ref clsvQxRoleMenusEN objvRoleMenusEN)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            bool bolResult = objvRoleMenusService.vRoleMenus_GetvQxRoleMenus(ref objvRoleMenusEN);
            return bolResult;
        }

        public static clsvQxRoleMenusEN GetvQxRoleMenusBymIdWs(long lngmId)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            clsvQxRoleMenusEN objvRoleMenusEN = objvRoleMenusService.vRoleMenus_GetvQxRoleMenusBymId(lngmId);
            return objvRoleMenusEN;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
        /// </summary>
        /// <param name = "strWhereCond">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static long GetFirstID_S(string strWhereCond)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            try
            {
                long lngmId = objvRoleMenusService.vRoleMenus_GetFirstID_S(strWhereCond);
                return lngmId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "vRoleMenus_GetFirstID_S", "clsvQxRoleMenusWS:GetFirstID_S", objException.Message);
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
        public static clsvQxRoleMenusEN GetFirstvRoleMenus_S(string strWhereCond)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            try
            {
                clsvQxRoleMenusEN objvRoleMenusEN = objvRoleMenusService.vRoleMenus_GetFirstvRoleMenus_S(strWhereCond);
                return objvRoleMenusEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(), "vRoleMenus_GetFirstvRoleMenus_S", "clsvQxRoleMenusWS:GetFirstvRoleMenus_S", objException.Message);
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
        public static clsvQxRoleMenusEN GetvQxRoleMenusObjBymId_Cache(long lngmId)
        {
            string strWhereCond = string.Format("1 = 1 order by mId");
            if (arrvRoleMenusObjLst_Cache == null)
            {
                arrvRoleMenusObjLst_Cache = clsvQxRoleMenusWS.GetvQxRoleMenusObjList(strWhereCond);
            }
            int intStart = 0;
            int intEnd = arrvRoleMenusObjLst_Cache.Count - 1;
            int intMid = 0;
            clsvQxRoleMenusEN objvRoleMenusEN = null;
            while (intEnd >= intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objvRoleMenusEN = arrvRoleMenusObjLst_Cache[intMid];
                if (objvRoleMenusEN.mId == lngmId)
                {
                    intFindFailCount = 0;
                    return objvRoleMenusEN;
                }
                else if (objvRoleMenusEN.mId.CompareTo(lngmId) > 0)
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
            arrvRoleMenusObjLst_Cache = null;
            if (intFindFailCount == 1) return GetvQxRoleMenusObjBymId_Cache(lngmId);
            string strErrMsgForGetObjById = string.Format("在vRoleMenus对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:GetvQxRoleMenusObjBymId_Cache)", lngmId, intFindFailCount);
            if (objvRoleMenusEN != null)
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvRoleMenusEN.mId, intMid);
            }
            else
            {
                strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
            }
            clsGeneralTab2.LogErrorS2("clsvQxRoleMenusBL", "GetvQxRoleMenusObjBymId_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        public static List<clsvQxRoleMenusEN> GetvQxRoleMenusObjList(string strWhereCond)
        {
            List<clsvQxRoleMenusEN> arrObjList = new List<clsvQxRoleMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vRoleMenusWs(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvQxRoleMenusEN objvRoleMenusEN = new clsvQxRoleMenusEN();
                objvRoleMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvRoleMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objvRoleMenusEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
                objvRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
                objvRoleMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objvRoleMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
                objvRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRoleMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
                objvRoleMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
                objvRoleMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
                objvRoleMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
                objvRoleMenusEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objvRoleMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
                objvRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
                objvRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
                objvRoleMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
                objvRoleMenusEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
                objvRoleMenusEN.IsDisp = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objvRoleMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
                objvRoleMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
                objvRoleMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objvRoleMenusEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static List<clsvQxRoleMenusEN> GetvQxRoleMenusObjListByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            List<clsvQxRoleMenusEN> arrObjList = new List<clsvQxRoleMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vRoleMenusByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvQxRoleMenusEN objvRoleMenusEN = new clsvQxRoleMenusEN();
                objvRoleMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvRoleMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objvRoleMenusEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
                objvRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
                objvRoleMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objvRoleMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
                objvRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRoleMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
                objvRoleMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
                objvRoleMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
                objvRoleMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
                objvRoleMenusEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objvRoleMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
                objvRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
                objvRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
                objvRoleMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
                objvRoleMenusEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
                objvRoleMenusEN.IsDisp = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objvRoleMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
                objvRoleMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
                objvRoleMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objvRoleMenusEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool IsExistRecordWs(string strWhereCond)
        {
            //检测记录是否存在
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            bool bolIsExist = objvRoleMenusService.vRoleMenus_IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            bool bolIsExist = objvRoleMenusService.vRoleMenus_IsExist(lngmId);
            return bolIsExist;
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
                strServiceUrl = String.Format("http://{0}/{1}/vRoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
            }
            else
            {
                strServiceUrl = String.Format("http://{0}/vRoleMenusService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
            }
            return strServiceUrl;
        }


        /// <summary>
        /// 获取当前角色列表的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            //sbCondition.AppendFormat(" RoleId in ({0}) And UpMenuId <> '00000000' and ", sstrRoleId);
            //sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenusObjListByRoleIdsEx(sstrRoleId, strPrjId, strMenuSetId, false);
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
        /// 获取当前角色列表的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            //sbCondition.AppendFormat(" RoleId in ({0}) AND UpMenuId = '00000000' AND ",
            //    sstrRoleId);
            //sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetvQxRoleMenusObjListByRoleIdsEx(sstrRoleId, strPrjId, strMenuSetId, true);
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
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="strCondition">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvQxRoleMenusEN> GetvQxRoleMenusObjListEx(string strRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
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
                //objvRoleMenusEN.IsDisp = TransNullToBool(objRow["IsDisp"].ToString().Trim()); //是否显示
                //objvRoleMenusEN.IsLeafNode = TransNullToBool(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
                objvRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
                objvRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
                objvRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目编号

                objvRoleMenusEN.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objvRoleMenusEN.IsDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objvRoleMenusEN.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.InUse = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否叶子
                arrObjList.Add(objvRoleMenusEN);
            }
            objDT = null;
            return arrObjList;
        }


        public static DataTable GetDataTable_vRoleMenusWsEx(string strRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vRoleMenus_GetDataSetEx(strRoleId, strPrjId, strMenuSetId, bolIsUpMenuId);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}.\r\n出错信息:{2}",
                    GetServiceUrl(), "vRoleMenus_GetDataSetEx", objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static DataTable GetDataTable_vRoleMenusWsByRoleIdsEx(string sstrRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            vRoleMenusServiceSoapClient objvRoleMenusService = GetvQxRoleMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRoleMenusService.vRoleMenus_GetDataSetByRoleIdsEx(sstrRoleId, strPrjId, strMenuSetId, bolIsUpMenuId);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址：{0},函数名:{1}.\r\n出错信息:{2}",
                   GetServiceUrl(), "vRoleMenus_GetDataSetByRoleIdsEx", objException.Message);
                throw new Exception(strMsg);

            }
        }
        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="strCondition">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvQxRoleMenusEN> GetvQxRoleMenusObjListByRoleIdsEx(string sstrRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
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
                //objvRoleMenusEN.IsDisp = TransNullToBool(objRow["IsDisp"].ToString().Trim()); //是否显示
                //objvRoleMenusEN.IsLeafNode = TransNullToBool(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
                objvRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
                objvRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
                objvRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
                objvRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
                objvRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目编号

                objvRoleMenusEN.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objvRoleMenusEN.IsDisp = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
                objvRoleMenusEN.IsLeafNode = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                objvRoleMenusEN.InUse = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否叶子
                arrObjList.Add(objvRoleMenusEN);
            }
            objDT = null;
            return arrObjList;
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
            //sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenusObjListEx(strRoleId, strPrjId, strMenuSetId, false);
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
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            //sbCondition.AppendFormat(" PrjId = '{0}'", strPrjId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenusObjListEx(strRoleId, strPrjId, "", false);
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
            //sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId='{1}'",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetvQxRoleMenusObjListEx(strRoleId, strPrjId, strMenuSetId, true);
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
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
            //    strRoleId);
            //sbCondition.AppendFormat(" PrjId = '{0}' ",
            //    strPrjId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetvQxRoleMenusObjListEx(strRoleId, strPrjId, "", true);
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
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" UpMenuId = '00000000' AND ");
            //sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId={1}",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetvQxRoleMenusObjListEx("", strPrjId, strMenuSetId, true);
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
            //sbCondition.AppendFormat(" PrjId = '{0}' And MenuSetId={1}", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetvQxRoleMenusObjListEx("", strPrjId, strMenuSetId, false);
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

    }
}