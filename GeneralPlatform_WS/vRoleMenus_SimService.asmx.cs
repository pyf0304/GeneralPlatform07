///----------------------
///生成代码版本：8.2.0.0
///生成日期：2009/06/15
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
    /// vRoleMenus_SimService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vRoleMenus_SimService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vRoleMenus_Sim_GetDataSet(string strWhereCond)
        {
            try
            {
                clsPubVar.objLog.WriteDebugLog(strWhereCond);
                DataSet objDS = clsvRoleMenus_SimBL.GetDataSet_vRoleMenus_Sim(strWhereCond);
              
                return objDS;
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("在函数：【vRoleMenus_SimService】的【vRoleMenus_Sim_GetDataSet】中出错：{0}",objException.Message );
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsGeneralTab2.LogErrorS(objException, "vRoleMenus_Sim_GetDataSet");
                return new DataSet();
            }
        }

        [WebMethod]
        public DataSet vRoleMenus_Sim_GetDataSetEx(string strRoleId, string strPrjId, string strMenuSetId)
        {
            try
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
                    strRoleId);
                sbCondition.AppendFormat(" PrjId = '{0}' ",
                    strPrjId);
                if (string.IsNullOrEmpty(strMenuSetId) == false)
                {
                    sbCondition.AppendFormat(" And MenuSetId='{1}'",
                        strMenuSetId);
                }
                sbCondition.Append(" ORDER BY OrderNum");
                sbCondition.Append("[Exclude]or [/Exclude]");

                clsPubVar.objLog.WriteDebugLog(sbCondition.ToString());
                DataSet objDS = clsvRoleMenus_SimBL.GetDataSet_vRoleMenus_Sim(sbCondition.ToString());

                return objDS;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在函数：【vRoleMenus_SimService】的【vRoleMenus_Sim_GetDataSetEx】中出错：{0}", objException.Message);
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsGeneralTab2.LogErrorS(objException, "vRoleMenus_Sim_GetDataSetEx");
                return new DataSet();
            }
        }


        [WebMethod]
        public bool vRoleMenus_Sim_GetvRoleMenus_Sim(ref clsvRoleMenus_SimEN objvRoleMenus_Sim)
        {
            bool bolResult = clsvRoleMenus_SimBL.GetvRoleMenus_Sim(ref objvRoleMenus_Sim);
            return bolResult;
        }

        [WebMethod]
        public bool vRoleMenus_Sim_GetvRoleMenus_SimV(ref clsvRoleMenus_SimEN objvRoleMenus_Sim)
        {
            bool bolResult = clsvRoleMenus_SimBL.GetvRoleMenus_Sim(ref objvRoleMenus_Sim);
            return bolResult;
        }

        [WebMethod]
        public bool vRoleMenus_Sim_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsvRoleMenus_SimBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vRoleMenus_Sim_IsExist(long lngmId)
        {
            bool bolIsExist = clsvRoleMenus_SimBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public clsvRoleMenus_SimEN ExposeLogicClass(clsvRoleMenus_SimEN objvRoleMenus_Sim)
        {
            return objvRoleMenus_Sim;
        }
    }
}