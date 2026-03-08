///----------------------
///生成代码版本：2010.05.04.1
///生成日期：2010/06/03
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
using GeneralPlatform4WS.ServiceReferencePrjMenus;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 工程菜单(PrjMenus)
    /// </summary>
    public class clsPrjMenusWS
    {
        private static PrjMenusServiceSoapClient objPrjMenusServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static PrjMenusServiceSoapClient GetPrjMenusServiceSoapClient()
        {
            if (objPrjMenusServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "PrjMenusServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 200000;
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/PrjMenusService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/PrjMenusService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new PrjMenusServiceSoapClient(binding, address);
            }
            else
            {
                return objPrjMenusServiceSoapClient;
            }
        }

        public clsPrjMenusWS()
        {
        }


        /////绑定下拉框的函数代码

        /////生成绑定ListView的代码
        ///// <summary>
        ///// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        /////			 并显示在ListView中。
        ///// </summary>
        //public static int BindLv_PrjMenus(System.Windows.Forms.ListView lvPrjMenus, string strWhereCond)
        //{
        //    ///	操作步骤：(共4步)
        //    ///	1、组合界面条件串；
        //    ///	2、根据条件串获取该表满足条件的DataTable；
        //    ///	3、设置ListView的列头信息
        //    ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
        //    ///		在本界面中是把状态显示在控件lblRecCount中。

        //    System.Windows.Forms.ListViewItem lviPrjMenus;
        //    ArrayList arrPrjMenusObjList;
        //    ///	2、根据条件串获取该表满足条件的DataTable；
        //    arrPrjMenusObjList = new clsPrjMenusEN().GetPrjMenusObjList(strWhereCond);
        //    ///	3、设置ListView的列头信息
        //    lvPrjMenus.Items.Clear();//清除原来所有Item
        //    lvPrjMenus.Columns.Clear();//清除原来所有列头信息
        //    lvPrjMenus.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("项目编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
        //    lvPrjMenus.View = System.Windows.Forms.View.Details;
        //    ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
        //    foreach (clsPrjMenusEN objPrjMenus in arrPrjMenusObjList)
        //    {
        //        lviPrjMenus = new System.Windows.Forms.ListViewItem();
        //        lviPrjMenus.Tag = objPrjMenus.MenuId;
        //        lviPrjMenus.Text = objPrjMenus.MenuId.ToString();
        //        lviPrjMenus.SubItems.Add(objPrjMenus.MenuName);
        //        lviPrjMenus.SubItems.Add(objPrjMenus.PrjId);
        //        lviPrjMenus.SubItems.Add(objPrjMenus.UpMenuId);
        //        lviPrjMenus.SubItems.Add(objPrjMenus.LinkFile);
        //        lviPrjMenus.SubItems.Add(objPrjMenus.ImgFile);
        //        lviPrjMenus.SubItems.Add(objPrjMenus.RoleId);
        //        lviPrjMenus.SubItems.Add(objPrjMenus.OrderNum.ToString());
        //        lviPrjMenus.SubItems.Add(objPrjMenus.IsLeafNode.ToString());
        //        lvPrjMenus.Items.Add(lviPrjMenus);
        //    }
        //    ///	4、设置记录数的状态，
        //    ///		在本界面中是把状态显示在控件txtRecCount中。
        //    return arrPrjMenusObjList.Count;
        //}

        public static DataTable GetDataTable_PrjMenusWs(string strWhereCond)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjMenusService.PrjMenus_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:PrjMenus 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_PrjMenusVWs(string strWhereCond)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjMenusService.PrjMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:PrjMenus View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetPrjMenusVWs(string strWhereCond)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjMenusService.PrjMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetPrjMenusWs(ref clsPrjMenusEN objPrjMenus)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            bool bolResult = objPrjMenusService.PrjMenus_GetPrjMenus(ref objPrjMenus);
            return bolResult;
        }

        public static List<clsPrjMenusEN> GetPrjMenusObjList(string strCondition)
        {
            List<clsPrjMenusEN> arrObjList = new List<clsPrjMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_PrjMenusWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPrjMenusEN objPrjMenus = new clsPrjMenusEN();
                objPrjMenus.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
                objPrjMenus.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
                objPrjMenus.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objPrjMenus.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
                objPrjMenus.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
                objPrjMenus.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
                objPrjMenus.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objPrjMenus.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objPrjMenus.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
                arrObjList.Add(objPrjMenus);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(string strMenuId)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            try
            {
                bool bolResult = objPrjMenusService.PrjMenus_DelRecord(strMenuId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelPrjMenussWs(List<string>  arrStdId)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            try
            {
                string[] sstrMenuId = (string[])(arrStdId.ToArray());
                bool bolResult = objPrjMenusService.PrjMenus_DelPrjMenuss(sstrMenuId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static int DelPrjMenussByCondWs(string strWhereCond)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            try
            {
                int intRecNum = objPrjMenusService.PrjMenus_DelPrjMenussByCond(strWhereCond);
                return intRecNum;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsPrjMenusEN objPrjMenus)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            try
            {
                bool bolResult = objPrjMenusService.PrjMenus_AddNewRecordBySql2(objPrjMenus);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsPrjMenusEN objPrjMenus)
        {
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            try
            {
                bool bolResult = objPrjMenusService.PrjMenus_UpdateBySql2(objPrjMenus);
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
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            bool bolIsExist = objPrjMenusService.PrjMenus_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(string strMenuId)
        {
            //检测记录是否存在
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            bool bolIsExist = objPrjMenusService.PrjMenus_IsExist(strMenuId);
            return bolIsExist;
        }

        public static string GetMaxStrIdWs()
        {
            //检测记录是否存在
            PrjMenusServiceSoapClient objPrjMenusService = GetPrjMenusServiceSoapClient();
            string strMaxMenuId = objPrjMenusService.PrjMenus_GetMaxStrId();
            return strMaxMenuId;
        }
    }
}