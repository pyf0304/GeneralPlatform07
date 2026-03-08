///----------------------
///生成代码版本：8.2.0.0
///生成日期：2009/06/10
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.01.02.2
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferencevUsers;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// vUsers(vUsers)
    /// </summary>
    public class clsvUsersWS
    {

        private static vUsersServiceSoapClient objvUsersServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static vUsersServiceSoapClient GetvUsersServiceSoapClient()
        {
            if (objvUsersServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vUsersServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/vUsersService.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/vUsersService.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/vUsersService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/vUsersService.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new vUsersServiceSoapClient(binding, address);
            }
            else
            {
                return objvUsersServiceSoapClient;
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
    
        public clsvUsersWS()
        {
        }


        public static DataTable GetDataTable_vUsersWs(string strWhereCond)
        {
            vUsersServiceSoapClient objvUsersService = GetvUsersServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvUsersService.vUsers_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vUsers 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetDataTable_vUsersVWs(string strWhereCond)
        {
            vUsersServiceSoapClient objvUsersService = GetvUsersServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvUsersService.vUsers_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vUsers View 数据出错！\r\n" + objException.Message);
            }
        }

        public static DataTable GetvUsersVWs(string strWhereCond)
        {
            vUsersServiceSoapClient objvUsersService = GetvUsersServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvUsersService.vUsers_GetDataSetV(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表View数据出错！\r\n" + objException.Message);
            }
        }

        public static bool GetvUsersWs(ref clsvUsersEN objvUsers)
        {
            vUsersServiceSoapClient objvUsersService = GetvUsersServiceSoapClient();
            bool bolResult = objvUsersService.vUsers_GetvUsers(ref objvUsers);
            return bolResult;
        }

        public static clsvUsersEN GetvUsersWs(string strUserId)
        {
            vUsersServiceSoapClient objvUsersService = GetvUsersServiceSoapClient();
            clsvUsersEN objvUsers = new clsvUsersEN();
            objvUsers.UserId = strUserId;
            bool bolResult = objvUsersService.vUsers_GetvUsers(ref objvUsers);
            return objvUsers;
        }

        public static List<clsvUsersEN> GetvUsersObjList(string strCondition)
        {
            List<clsvUsersEN> arrObjList = new List<clsvUsersEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vUsersWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvUsersEN objvUsers = new clsvUsersEN();
                objvUsers.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objvUsers.UserName = objRow["UserName"].ToString().Trim(); //用户名
                objvUsers.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
                objvUsers.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
                objvUsers.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
                objvUsers.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
                objvUsers.Memo = objRow["Memo"].ToString().Trim(); //备注
                objvUsers.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
                objvUsers.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
                objvUsers.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
                objvUsers.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
                objvUsers.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
                objvUsers.SubjectTypeName = objRow["SubjectTypeName"].ToString().Trim(); //学科类型
                objvUsers.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
                objvUsers.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
                objvUsers.BeginYearMonth = objRow["BeginYearMonth"].ToString().Trim(); //开始年月
                objvUsers.EndYearMonth = objRow["EndYearMonth"].ToString().Trim(); //结束年月
                objvUsers.GradeBaseID = objRow["GradeBaseID"].ToString().Trim(); //年级代号
                objvUsers.GradeBaseName = objRow["GradeBaseName"].ToString().Trim(); //年级名称
                objvUsers.id_GradeBase = objRow["id_GradeBase"].ToString().Trim(); //年级流水号
                objvUsers.IsOffed = com.taishsoft.commdb.clsGeneralTab.TransNullToBool_S(objRow["IsOffed"].ToString().Trim()); //是否毕业
                arrObjList.Add(objvUsers);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            vUsersServiceSoapClient objvUsersService = GetvUsersServiceSoapClient();
            bool bolIsExist = objvUsersService.vUsers_IsExistRecordByCond(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(string strUserId)
        {
            //检测记录是否存在
            vUsersServiceSoapClient objvUsersService = GetvUsersServiceSoapClient();
            bool bolIsExist = objvUsersService.vUsers_IsExist(strUserId);
            return bolIsExist;
        }
    }
}