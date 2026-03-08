///----------------------
///生成代码版本：8.2.0.0
///生成日期：2009/06/07
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：09.01.02.2
///========================
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.commdb;

namespace GeneralPlatform_WS
{
    /// <summary>
    /// DepartmentInfoService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class DepartmentInfoService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet DepartmentInfo_GetDataSet(string strWhereCond)
        {
            DataSet objDS = clsDepartmentInfoBL.GetDataSet_DepartmentInfo(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public DataSet DepartmentInfo_GetDataSetV(string strWhereCond)
        {
            DataSet objDS = clsDepartmentInfoBL.GetDataSet_DepartmentInfoV(strWhereCond);
            return objDS;
        }

        [WebMethod]
        public bool DepartmentInfo_GetDepartmentInfo(ref clsDepartmentInfo objDepartmentInfo)
        {
            bool bolResult = clsDepartmentInfoBL.GetDepartmentInfo(ref objDepartmentInfo);
            return bolResult;
        }

        [WebMethod]
        public bool DepartmentInfo_GetDepartmentInfoV(ref clsDepartmentInfo objDepartmentInfo)
        {
            bool bolResult = clsDepartmentInfoBL.GetDepartmentInfo(ref objDepartmentInfo);
            return bolResult;
        }

        [WebMethod]
        public bool DepartmentInfo_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsDepartmentInfoBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool DepartmentInfo_IsExist(string strDepartmentId)
        {
            bool bolIsExist = clsDepartmentInfoBL.IsExist(strDepartmentId);
            return bolIsExist;
        }

        [WebMethod]
        public bool DepartmentInfo_AddNewRecordBySql2(clsDepartmentInfo objDepartmentInfo)
        {
            bool bolResult = clsDepartmentInfoBL.AddNewRecordBySql2(objDepartmentInfo);
            return bolResult;
        }

        [WebMethod]
        public bool DepartmentInfo_UpdateBySql2(clsDepartmentInfo objDepartmentInfo)
        {
            bool bolResult = clsDepartmentInfoBL.UpdateBySql2(objDepartmentInfo);
            return bolResult;
        }

        [WebMethod]
        public bool DepartmentInfo_DelRecord(string strDepartmentId)
        {
            bool bolResult = clsDepartmentInfoBL.DelRecord(strDepartmentId);
            return bolResult;
        }

        [WebMethod]
        public bool DepartmentInfo_DelDepartmentInfos(ArrayList arrStdId)
        {
            bool bolResult = clsDepartmentInfoBL.DelDepartmentInfos(arrStdId);
            return bolResult;
        }

        [WebMethod]
        public clsDepartmentInfo ExposeLogicClass(clsDepartmentInfo objDepartmentInfo)
        {
            return objDepartmentInfo;
        }
    }
}