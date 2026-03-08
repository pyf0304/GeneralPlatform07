
//----------------------
//生成代码版本：2014.10.06.1
//生成日期：2014/10/17
//生成者：潘以锋
//工程名称：统一平台
//工程ID：0014
//模块中文名：用户管理
//模块英文名：UserManage
//注意：1、需要数据底层（PubDataBase.dll）的版本：2014.10.06.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2014.10.06.1
//========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferencevUserRoleRelation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// v用户角色关系(vUserRoleRelation)
    /// </summary>
    public class clsvUserRoleRelationWS
    {
        private static vUserRoleRelationServiceSoapClient objvUserRoleRelationServiceSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static vUserRoleRelationServiceSoapClient GetvUserRoleRelationServiceSoapClient()
        {
            if (objvUserRoleRelationServiceSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "vUserRoleRelationServiceSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                binding.MaxReceivedMessageSize = 2147483647;
                String strServiceUrl = String.Empty;
                if (clsSysPara4WS.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/vUserRoleRelationService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/vUserRoleRelationService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new vUserRoleRelationServiceSoapClient(binding, address);
            }
            else
            {
                return objvUserRoleRelationServiceSoapClient;
            }
        }

        public clsvUserRoleRelationWS()
        {
        }



        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_vUserRoleRelation(System.Windows.Forms.ListView lvvUserRoleRelation, string strWhereCond)
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lvivUserRoleRelation;
            List<clsvUserRoleRelationEN> arrvUserRoleRelationObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrvUserRoleRelationObjList = GetvUserRoleRelationObjList(strWhereCond);
            //	3、设置ListView的列头信息
            lvvUserRoleRelation.Items.Clear();//清除原来所有Item
            lvvUserRoleRelation.Columns.Clear();//清除原来所有列头信息
            lvvUserRoleRelation.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("用户状态名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvvUserRoleRelation.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsvUserRoleRelationEN objvUserRoleRelationEN in arrvUserRoleRelationObjList)
            {
                lvivUserRoleRelation = new System.Windows.Forms.ListViewItem();
                lvivUserRoleRelation.Tag = objvUserRoleRelationEN.mId;
                lvivUserRoleRelation.Text = objvUserRoleRelationEN.mId.ToString();
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.UserId);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.UserName);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.DepartmentId);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.DepartmentName);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.UserStateId);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.UserStateName);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.RoleId);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.RoleName);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.PrjId);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.PrjName);
                lvivUserRoleRelation.SubItems.Add(objvUserRoleRelationEN.Memo);
                lvvUserRoleRelation.Items.Add(lvivUserRoleRelation);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrvUserRoleRelationObjList.Count;
        }

        /// <summary>
        /// 根据条件获取数据表，用DataTable表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_vUserRoleRelationWs(string strWhereCond)
        {
            vUserRoleRelationServiceSoapClient objvUserRoleRelationService = GetvUserRoleRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvUserRoleRelationService.vUserRoleRelation_GetDataSet(strWhereCond);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vUserRoleRelation 数据出错！\r\n(clsvUserRoleRelationWS:GetDataTable_vUserRoleRelationWs)" + objException.Message);
            }
        }

        /// <summary>
        /// 根据条件获取一定范围的数据表，用DataTable表示
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <param name="lngMinNum">范围之最小值</param>
        /// <param name="lngMaxNum">范围之最大值</param>
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public static DataTable GetDataTable_vUserRoleRelationByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
        {
            vUserRoleRelationServiceSoapClient objvUserRoleRelationService = GetvUserRoleRelationServiceSoapClient();
            DataSet objDS = null;
            try
            {
                objDS = objvUserRoleRelationService.vUserRoleRelation_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
                DataTable objDT = objDS.Tables[0];
                return objDT;
            }
            catch (Exception objException)
            {
                throw new Exception("获取表:vUserRoleRelation 数据出错！\r\n(clsvUserRoleRelationWS:GetDataTable_vUserRoleRelationByRangeWs)" + objException.Message);
            }
        }

        /// <summary>
        /// 根据对象的关键字值，获取对象的全部属性
        /// </summary>
        /// <param name="objvUserRoleRelationEN">相关对象</param>
        /// <returns>是否成功</returns>
        public static bool GetvUserRoleRelationWs(ref clsvUserRoleRelationEN objvUserRoleRelationEN)
        {
            vUserRoleRelationServiceSoapClient objvUserRoleRelationService = GetvUserRoleRelationServiceSoapClient();
            bool bolResult = objvUserRoleRelationService.vUserRoleRelation_GetvUserRoleRelation(ref objvUserRoleRelationEN);
            return bolResult;
        }

        public static List<clsvUserRoleRelationEN> GetvUserRoleRelationObjList(string strCondition)
        {
            List<clsvUserRoleRelationEN> arrObjList = new List<clsvUserRoleRelationEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vUserRoleRelationWs(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvUserRoleRelationEN objvUserRoleRelationEN = new clsvUserRoleRelationEN();
                objvUserRoleRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvUserRoleRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objvUserRoleRelationEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
                objvUserRoleRelationEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
                objvUserRoleRelationEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
                objvUserRoleRelationEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
                objvUserRoleRelationEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
                objvUserRoleRelationEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objvUserRoleRelationEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
                objvUserRoleRelationEN.PrjId = objRow["PrjId"].ToString().Trim(); //项目Id
                objvUserRoleRelationEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvUserRoleRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objvUserRoleRelationEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static List<clsvUserRoleRelationEN> GetvUserRoleRelationObjListByRange(string strCondition, long lngMinNum, long lngMaxNum)
        {
            List<clsvUserRoleRelationEN> arrObjList = new List<clsvUserRoleRelationEN>();
            System.Data.DataTable objDT = null;
            objDT = GetDataTable_vUserRoleRelationByRangeWs(strCondition, lngMinNum, lngMaxNum);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvUserRoleRelationEN objvUserRoleRelationEN = new clsvUserRoleRelationEN();
                objvUserRoleRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
                objvUserRoleRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objvUserRoleRelationEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
                objvUserRoleRelationEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
                objvUserRoleRelationEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
                objvUserRoleRelationEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
                objvUserRoleRelationEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
                objvUserRoleRelationEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objvUserRoleRelationEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
                objvUserRoleRelationEN.PrjId = objRow["PrjId"].ToString().Trim(); //项目Id
                objvUserRoleRelationEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
                objvUserRoleRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
                arrObjList.Add(objvUserRoleRelationEN);
            }
            objDT = null;
            return arrObjList;
        }

        public static bool IsExistRecordWs(string strCondition)
        {
            //检测记录是否存在
            vUserRoleRelationServiceSoapClient objvUserRoleRelationService = GetvUserRoleRelationServiceSoapClient();
            bool bolIsExist = objvUserRoleRelationService.vUserRoleRelation_IsExistRecord(strCondition);
            return bolIsExist;
        }

        public static bool IsExistWs(long lngmId)
        {
            //检测记录是否存在
            vUserRoleRelationServiceSoapClient objvUserRoleRelationService = GetvUserRoleRelationServiceSoapClient();
            bool bolIsExist = objvUserRoleRelationService.vUserRoleRelation_IsExist(lngmId);
            return bolIsExist;
        }
    }
}