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
using GeneralPlatform4WS.ServiceReferenceUserMenus;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 用户菜单(UserMenus)
    /// </summary>
    public class clsUserMenusWS
    {
        private static UserMenusServiceSoapClient objUserMenusServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserMenusServiceSoapClient GetUserMenusServiceSoapClient()
        {
            if (objUserMenusServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UserMenusServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UserMenusService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UserMenusService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new UserMenusServiceSoapClient(binding, address);
            }
            else
            {
                return objUserMenusServiceSoapClient;
            }
        }

        public clsUserMenusWS()
        {
        }


        ///绑定下拉框的函数代码

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_UserMenus(System.Windows.Forms.ListView lvUserMenus, string strWhereCond)
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviUserMenus;
            List<clsUserMenusEN> arrUserMenusObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrUserMenusObjList = clsUserMenusWS.GetUserMenusObjList(strWhereCond);
            ///	3、设置ListView的列头信息
            lvUserMenus.Items.Clear();//清除原来所有Item
            lvUserMenus.Columns.Clear();//清除原来所有列头信息
            lvUserMenus.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserMenus.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserMenus.Columns.Add("项目编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserMenus.Columns.Add("是否使用角色菜单", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserMenus.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvUserMenus.View = System.Windows.Forms.View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsUserMenusEN objUserMenus in arrUserMenusObjList)
            {
                lviUserMenus = new System.Windows.Forms.ListViewItem();
                lviUserMenus.Tag = objUserMenus.mId;
                lviUserMenus.Text = objUserMenus.mId.ToString();
                lviUserMenus.SubItems.Add(objUserMenus.UserId);
                lviUserMenus.SubItems.Add(objUserMenus.PrjId);
                lviUserMenus.SubItems.Add(objUserMenus.IsUseRoleMenu.ToString());
                lviUserMenus.SubItems.Add(objUserMenus.Memo);
                lvUserMenus.Items.Add(lviUserMenus);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrUserMenusObjList.Count;
        }

        public static DataTable GetDataTable_UserMenusWs(string strWhereCond)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserMenusService.UserMenus_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserMenus 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_UserMenusVWs(string strWhereCond)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserMenusService.UserMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:UserMenus View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetUserMenusVWs(string strWhereCond)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objUserMenusService.UserMenus_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetUserMenusWs(ref clsUserMenusEN objUserMenus)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            bool bolResult = objUserMenusService.UserMenus_GetUserMenus(ref objUserMenus);
            return bolResult;
        }

        public static List<clsUserMenusEN> GetUserMenusObjList(string strCondition)
        {
            List<clsUserMenusEN> arrObjList = new List<clsUserMenusEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_UserMenusWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUserMenusEN objUserMenus = new clsUserMenusEN();
                objUserMenus.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objUserMenus.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserMenus.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objUserMenus.IsUseRoleMenu = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsUseRoleMenu"].ToString().Trim()); //是否使用角色菜单
                objUserMenus.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objUserMenus);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(long lngmId)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            try
            {
                bool bolResult = objUserMenusService.UserMenus_DelRecord(lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelUserMenussWs(List<string>  arrStdId)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            try
            {
                string[] slngmId = (string[])(arrStdId.ToArray());
                bool bolResult = objUserMenusService.UserMenus_DelUserMenuss(slngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsUserMenusEN objUserMenus)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            try
            {
                bool bolResult = objUserMenusService.UserMenus_AddNewRecordBySql2(objUserMenus);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsUserMenusEN objUserMenus)
        {
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            try
            {
                bool bolResult = objUserMenusService.UserMenus_UpdateBySql2(objUserMenus);
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
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            bool bolIsExist = objUserMenusService.UserMenus_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            bool bolIsExist = objUserMenusService.UserMenus_IsExist(lngmId);
            return bolIsExist;
        }

        public static string GetMaxStrIdWs()
        {
            //检测记录是否存在
            UserMenusServiceSoapClient objUserMenusService = GetUserMenusServiceSoapClient();
            string strMaxMId = objUserMenusService.UserMenus_GetMaxStrId();
            return strMaxMId;
        }
    }
}