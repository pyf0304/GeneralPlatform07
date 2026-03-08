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
using GeneralPlatform4WS.ServiceReferencePrjPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 工程权限(PrjPotence)
    /// </summary>
    public class clsPrjPotenceWS
    {
        private static PrjPotenceServiceSoapClient objPrjPotenceServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static PrjPotenceServiceSoapClient GetPrjPotenceServiceSoapClient()
        {
            if (objPrjPotenceServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "PrjPotenceServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/PrjPotenceService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/PrjPotenceService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new PrjPotenceServiceSoapClient(binding, address);
            }
            else
            {
                return objPrjPotenceServiceSoapClient;
            }
        }

        public clsPrjPotenceWS()
        {
        }

        public static System.Data.DataTable GetPotenceId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PotenceId, PotenceName from PrjPotence ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindCbo_PotenceId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetDataTable_PrjPotenceWs("1=1");
            clsPrjPotenceEN objPrjPotence;
            //初始化一个对象列表
            List<clsPrjPotenceEN> PrjPotenceList = new List<clsPrjPotenceEN>();
            //插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
            objPrjPotence = new clsPrjPotenceEN();
            objPrjPotence.PotenceId = "0";
            objPrjPotence.PotenceName = "请选择...";
            PrjPotenceList.Add(objPrjPotence);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objPrjPotence = new clsPrjPotenceEN();
                objPrjPotence.PotenceId = objRow["PotenceId"].ToString();
                objPrjPotence.PotenceName = objRow["PotenceName"].ToString();
                PrjPotenceList.Add(objPrjPotence);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjPotenceList;
            objComboBox.ValueMember = "PotenceId";
            objComboBox.DisplayMember = "PotenceName";
            objComboBox.SelectedIndex = 0;
        }

        /////绑定下拉框的函数代码
        //public static void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
        //    System.Data.DataTable objDT = GetDataTable_PrjPotenceWs("1=1");
        //    objDDL.DataValueField = "PotenceId";
        //    objDDL.DataTextField = "PotenceName";
        //    objDDL.DataSource = objDT;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_PrjPotence(System.Windows.Forms.ListView lvPrjPotence, string strWhereCond)
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviPrjPotence;
            List<clsPrjPotenceEN> arrPrjPotenceObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrPrjPotenceObjList =  clsPrjPotenceWS.GetPrjPotenceObjList(strWhereCond);
            ///	3、设置ListView的列头信息
            lvPrjPotence.Items.Clear();//清除原来所有Item
            lvPrjPotence.Columns.Clear();//清除原来所有列头信息
            lvPrjPotence.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjPotence.Columns.Add("项目编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjPotence.Columns.Add("权限名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjPotence.Columns.Add("权限类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjPotence.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjPotence.View = System.Windows.Forms.View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsPrjPotenceEN objPrjPotence in arrPrjPotenceObjList)
            {
                lviPrjPotence = new System.Windows.Forms.ListViewItem();
                lviPrjPotence.Tag = objPrjPotence.PotenceId;
                lviPrjPotence.Text = objPrjPotence.PotenceId.ToString();
                lviPrjPotence.SubItems.Add(objPrjPotence.PotenceName);
                lviPrjPotence.SubItems.Add(objPrjPotence.Memo);
                lvPrjPotence.Items.Add(lviPrjPotence);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrPrjPotenceObjList.Count;
        }

        public static DataTable GetDataTable_PrjPotenceWs(string strWhereCond)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjPotenceService.PrjPotence_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:PrjPotence 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_PrjPotenceVWs(string strWhereCond)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjPotenceService.PrjPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:PrjPotence View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetPrjPotenceVWs(string strWhereCond)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objPrjPotenceService.PrjPotence_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetPrjPotenceWs(ref clsPrjPotenceEN objPrjPotence)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            bool bolResult = objPrjPotenceService.PrjPotence_GetPrjPotence(ref objPrjPotence);
            return bolResult;
        }

        public static List<clsPrjPotenceEN> GetPrjPotenceObjList(string strCondition)
        {
            List<clsPrjPotenceEN> arrObjList = new List<clsPrjPotenceEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_PrjPotenceWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPrjPotenceEN objPrjPotence = new clsPrjPotenceEN();
                objPrjPotence.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
                objPrjPotence.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objPrjPotence.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
                objPrjPotence.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
                objPrjPotence.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objPrjPotence);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(string strPotenceId)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            try
            {
                bool bolResult = objPrjPotenceService.PrjPotence_DelRecord(strPotenceId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelPrjPotencesWs(List<string>  arrStdId)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            try
            {
                string[] sstrPotenceId = (string[])(arrStdId.ToArray());
                bool bolResult = objPrjPotenceService.PrjPotence_DelPrjPotences(sstrPotenceId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool AddNewRecordBySql2Ws(clsPrjPotenceEN objPrjPotence)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            try
            {
                bool bolResult = objPrjPotenceService.PrjPotence_AddNewRecordBySql2(objPrjPotence);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }

        public static bool UpdateBySql2Ws(clsPrjPotenceEN objPrjPotence)
        {
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            try
            {
                bool bolResult = objPrjPotenceService.PrjPotence_UpdateBySql2(objPrjPotence);
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
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            bool bolIsExist = objPrjPotenceService.PrjPotence_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(string strPotenceId)
        {
            //检测记录是否存在
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            bool bolIsExist = objPrjPotenceService.PrjPotence_IsExist(strPotenceId);
            return bolIsExist;
        }

        public static string GetMaxStrIdWs()
        {
            //检测记录是否存在
            PrjPotenceServiceSoapClient objPrjPotenceService = GetPrjPotenceServiceSoapClient();
            string strMaxPotenceId = objPrjPotenceService.PrjPotence_GetMaxStrId();
            return strMaxPotenceId;
        }
    }
}