
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2013/01/19
///生成者：潘以锋
///工程名称：统一平台
///工程ID：0014
///模块中文名：工程文件下载
///模块英文名：PrjFileDownLoad
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.23.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferencevPrjFileRela;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// vPrjFileRela(vPrjFileRela)
    /// </summary>
    public class clsvQxPrjFileRelaWS
    {
        private static vPrjFileRelaServiceSoapClient objvPrjFileRelaServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static vPrjFileRelaServiceSoapClient GetvPrjFileRelaServiceSoapClient()
        {
            if (objvPrjFileRelaServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vPrjFileRelaServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/vPrjFileRelaService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/vPrjFileRelaService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new vPrjFileRelaServiceSoapClient(binding, address);
            }
            else
            {
                return objvPrjFileRelaServiceSoapClient;
            }
        }

        public clsvQxPrjFileRelaWS()
        {
        }


        ///绑定下拉框的函数代码

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_vPrjFileRela(System.Windows.Forms.ListView lvvPrjFileRela, string strWhereCond)
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lvivPrjFileRela;
            ArrayList arrvPrjFileRelaObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvPrjFileRelaObjList = GetvPrjFileRelaObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvvPrjFileRela.Items.Clear();//清除原来所有Item
            lvvPrjFileRela.Columns.Clear();//清除原来所有列头信息
            lvvPrjFileRela.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("版本", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("文件路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("UpdDate", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("是否需要下载", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvPrjFileRela.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvQxPrjFileRelaEN objvPrjFileRelaEN in arrvPrjFileRelaObjList)
            {
                lvivPrjFileRela = new System.Windows.Forms.ListViewItem();
                lvivPrjFileRela.Tag = objvPrjFileRelaEN.mId;
                lvivPrjFileRela.Text = objvPrjFileRelaEN.mId.ToString();
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.QxPrjId);
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.PrjName);
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.FileName);
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.Version);
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.FilePath);
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.UpdDate);
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.UpdUserId);
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.IsNeedDownLoad.ToString());
                lvivPrjFileRela.SubItems.Add(objvPrjFileRelaEN.Memo);
                lvvPrjFileRela.Items.Add(lvivPrjFileRela);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrvPrjFileRelaObjList.Count;
        }

        public static DataTable GetDataTable_vPrjFileRelaWs(string strWhereCond)
        {
            vPrjFileRelaServiceSoapClient objvPrjFileRelaService = GetvPrjFileRelaServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvPrjFileRelaService.vPrjFileRela_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vPrjFileRela 数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetvPrjFileRelaWs(ref clsvQxPrjFileRelaEN objvPrjFileRelaEN)
        {
            vPrjFileRelaServiceSoapClient objvPrjFileRelaService = GetvPrjFileRelaServiceSoapClient();
            bool bolResult = objvPrjFileRelaService.vPrjFileRela_GetvPrjFileRela(ref objvPrjFileRelaEN);
            return bolResult;
        }

        public static ArrayList GetvPrjFileRelaObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vPrjFileRelaWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvQxPrjFileRelaEN objvPrjFileRelaEN = new clsvQxPrjFileRelaEN();
                objvPrjFileRelaEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvPrjFileRelaEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
                objvPrjFileRelaEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvPrjFileRelaEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
                objvPrjFileRelaEN.Version = objRow["Version"].ToString().Trim(); //版本
                objvPrjFileRelaEN.FilePath = objRow["FilePath"].ToString().Trim(); //文件路径
                objvPrjFileRelaEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //UpdDate
                objvPrjFileRelaEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
                objvPrjFileRelaEN.IsNeedDownLoad = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsNeedDownLoad"].ToString().Trim()); //是否需要下载
                objvPrjFileRelaEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objvPrjFileRelaEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            vPrjFileRelaServiceSoapClient objvPrjFileRelaService = GetvPrjFileRelaServiceSoapClient();
            bool bolIsExist = objvPrjFileRelaService.vPrjFileRela_IsExistRecord(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            vPrjFileRelaServiceSoapClient objvPrjFileRelaService = GetvPrjFileRelaServiceSoapClient();
            bool bolIsExist = objvPrjFileRelaService.vPrjFileRela_IsExist(lngmId);
            return bolIsExist;
        }
    }
}