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
using GeneralPlatform4WS.ServiceReferencevRelaOfPotenceAndSymbol;
using System.ServiceModel;
using System.Collections.Generic;
namespace GeneralPlatform4WS
{
    /// <summary>
    /// vRelaOfPotenceAndSymbol(vRelaOfPotenceAndSymbol)
    /// </summary>
    public class clsvQxRelaOfPotenceAndSymbolWS
    {
        private static vRelaOfPotenceAndSymbolServiceSoapClient objvRelaOfPotenceAndSymbolServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static vRelaOfPotenceAndSymbolServiceSoapClient GetvQxRelaOfPotenceAndSymbolServiceSoapClient()
        {
            if (objvRelaOfPotenceAndSymbolServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vRelaOfPotenceAndSymbolServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/vRelaOfPotenceAndSymbolService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/vRelaOfPotenceAndSymbolService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/vRelaOfPotenceAndSymbolService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/vRelaOfPotenceAndSymbolService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new vRelaOfPotenceAndSymbolServiceSoapClient(binding, address);
            }
            else
            {
                return objvRelaOfPotenceAndSymbolServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsvQxRelaOfPotenceAndSymbolWS()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhereCond"></param>
        /// <returns></returns>
        public static DataTable GetDataTable_vRelaOfPotenceAndSymbolWs(string strWhereCond)
        {
            vRelaOfPotenceAndSymbolServiceSoapClient objvRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvRelaOfPotenceAndSymbolService.vRelaOfPotenceAndSymbol_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vRelaOfPotenceAndSymbol 数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetvQxRelaOfPotenceAndSymbolWs(ref clsvQxRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbol)
        {
            vRelaOfPotenceAndSymbolServiceSoapClient objvRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
            bool bolResult = objvRelaOfPotenceAndSymbolService.vRelaOfPotenceAndSymbol_GetvQxRelaOfPotenceAndSymbol(ref objvRelaOfPotenceAndSymbol);
            return bolResult;
        }

        public static List<clsvQxRelaOfPotenceAndSymbolEN> GetvQxRelaOfPotenceAndSymbolObjList(string strCondition)
        {
            List<clsvQxRelaOfPotenceAndSymbolEN> arrObjList = new List<clsvQxRelaOfPotenceAndSymbolEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vRelaOfPotenceAndSymbolWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvQxRelaOfPotenceAndSymbolEN objvRelaOfPotenceAndSymbol = new clsvQxRelaOfPotenceAndSymbolEN();
                objvRelaOfPotenceAndSymbol.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
                objvRelaOfPotenceAndSymbol.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目编号
                objvRelaOfPotenceAndSymbol.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvRelaOfPotenceAndSymbol.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
                objvRelaOfPotenceAndSymbol.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
                objvRelaOfPotenceAndSymbol.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
                objvRelaOfPotenceAndSymbol.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
                objvRelaOfPotenceAndSymbol.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objvRelaOfPotenceAndSymbol);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            vRelaOfPotenceAndSymbolServiceSoapClient objvRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
            bool bolIsExist = objvRelaOfPotenceAndSymbolService.vRelaOfPotenceAndSymbol_IsExistRecord(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngRelaMid)
        {
            //检测记录是否存在
            vRelaOfPotenceAndSymbolServiceSoapClient objvRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
            bool bolIsExist = objvRelaOfPotenceAndSymbolService.vRelaOfPotenceAndSymbol_IsExist(lngRelaMid);
            return bolIsExist;
        }
    }
}