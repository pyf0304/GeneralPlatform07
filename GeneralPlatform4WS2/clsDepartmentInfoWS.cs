///----------------------
///生成代码版本：7.0.0.0
///生成日期：2008/11/11
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：8.0.0.5
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using GeneralPlatform4WS.ServiceReferenceDepartmentInfo;
using System.ServiceModel;
using System.Collections.Generic;


namespace GeneralPlatform4WS
{
    /// <summary>
    /// 
    /// </summary>
    public class clsDepartmentInfoWS
    {
        public static List<clsDepartmentInfoEN> arrDepartmentInfoObjLst = null;


        
        private static DepartmentInfoServiceSoapClient objDepartmentInfoServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DepartmentInfoServiceSoapClient GetDepartmentInfoServiceSoapClient()
        {
            if (objDepartmentInfoServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "DepartmentInfoServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/DepartmentInfoService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/DepartmentInfoService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/DepartmentInfoService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/DepartmentInfoService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new DepartmentInfoServiceSoapClient(binding, address);
            }
            else
            {
                return objDepartmentInfoServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsDepartmentInfoWS()
        {
        }        
     
        public static DataTable GetDataTable_DepartmentInfoWs(string strWhereCond)
        {
                        DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objDepartmentInfoService.DepartmentInfo_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:DepartmentInfo 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_DepartmentInfoVWs(string strWhereCond)
        {
                        DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objDepartmentInfoService.DepartmentInfo_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:DepartmentInfo View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDepartmentInfoVWs(string strWhereCond)
        {
                        DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objDepartmentInfoService.DepartmentInfo_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        //public static bool GetDepartmentInfoWs(ref clsDepartmentInfoEN objDepartmentInfo)
        //{
        //                DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
        //    bool bolResult = objDepartmentInfoService.DepartmentInfo_GetDepartmentInfo(ref objDepartmentInfo);
        //    return bolResult;
        //}

        public static List<clsDepartmentInfoEN> GetDepartmentInfoObjList(string strCondition)
        {
            List<clsDepartmentInfoEN> arrObjList = new List<clsDepartmentInfoEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_DepartmentInfoWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsDepartmentInfoEN objDepartmentInfo = new clsDepartmentInfoEN();
                objDepartmentInfo.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
                objDepartmentInfo.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
                objDepartmentInfo.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
                objDepartmentInfo.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
                objDepartmentInfo.DepartMentId4Card = objRow["DepartMentId4Card"].ToString().Trim(); //一卡通部门ID
                objDepartmentInfo.IsAcademy = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsAcademy"].ToString().Trim()); //是否学院
                objDepartmentInfo.SubjectTypeId = objRow["SubjectTypeId"].ToString().Trim(); //学科类型ID
                objDepartmentInfo.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
                objDepartmentInfo.OrderNum = com.taishsoft.commdb.clsGeneralTab.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
                objDepartmentInfo.IsExam = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsExam"].ToString().Trim()); //是否参与考核
                objDepartmentInfo.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objDepartmentInfo);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool DelRecordWs(string strDepartmentId)
        {
                        DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            try
            {
                bool bolResult = objDepartmentInfoService.DepartmentInfo_DelRecord(strDepartmentId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        public static bool DelDepartmentInfosWs(List<string>  arrStdId)
        {
                        DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            try
            {
                string[] sstrDepartmentId = (string[])(arrStdId.ToArray());
                bool bolResult = objDepartmentInfoService.DepartmentInfo_DelDepartmentInfos(sstrDepartmentId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("删除记录出错！\r\n" + objException.Message);
            }
        }

        //public static bool AddNewRecordBySql2Ws(clsDepartmentInfoEN objDepartmentInfo)
        //{
        //                DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
        //    try
        //    {
        //        bool bolResult = objDepartmentInfoService.DepartmentInfo_AddNewRecordBySql2(objDepartmentInfo);
        //        return bolResult;
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("添加记录出错！\r\n" + objException.Message);
        //    }
        //}

        //public static bool UpdateBySql2Ws(clsDepartmentInfoEN objDepartmentInfo)
        //{
        //                DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
        //    try
        //    {
        //        bool bolResult = objDepartmentInfoService.DepartmentInfo_UpdateBySql2(objDepartmentInfo);
        //        return bolResult;
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("添加记录出错！\r\n" + objException.Message);
        //    }
        //}

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
                        DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            bool bolIsExist = objDepartmentInfoService.DepartmentInfo_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(string strDepartmentId)
        {
            //检测记录是否存在
                        DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            bool bolIsExist = objDepartmentInfoService.DepartmentInfo_IsExist(strDepartmentId);
            return bolIsExist;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strDepartmentId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDepartmentInfoEN GetDepartmentInfoObjByDepartmentId(string strDepartmentId)
        {
            if (arrDepartmentInfoObjLst == null)
            {
                arrDepartmentInfoObjLst = clsDepartmentInfoWS.GetDepartmentInfoObjList("1=1");
            }
            foreach (clsDepartmentInfoEN objDepartmentInfo in arrDepartmentInfoObjLst)
            {
                if (objDepartmentInfo.DepartmentId == strDepartmentId)
                {
                    return objDepartmentInfo;
                }
            }
            return null;
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="objDepartmentInfo"></param>
        /// <returns></returns>
        public static bool AddNewRecordBySql2Ws(clsDepartmentInfoEN objDepartmentInfo)
        {
            DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            try
            {
                bool bolResult = objDepartmentInfoService.DepartmentInfo_AddNewRecordBySql2(objDepartmentInfo);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="objDepartmentInfo"></param>
        /// <returns></returns>
        public static bool UpdateBySql2Ws(clsDepartmentInfoEN objDepartmentInfo)
        {
            DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
            try
            {
                bool bolResult = objDepartmentInfoService.DepartmentInfo_UpdateBySql2(objDepartmentInfo);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("添加记录出错！\r\n" + objException.Message);
            }
        }


    }
}