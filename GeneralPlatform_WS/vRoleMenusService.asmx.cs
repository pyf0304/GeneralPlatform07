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
    /// vRoleMenusService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vRoleMenusService : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet vRoleMenus_GetDataSet(string strWhereCond)
        {
            try
            {
                clsPubVar.objLog.WriteDebugLog(strWhereCond);
                DataSet objDS = clsvRoleMenusBL.GetDataSet_vRoleMenus(strWhereCond);
 
                return objDS;
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("在函数：【vRoleMenusService】的【vRoleMenus_GetDataSet】中出错：{0}",objException.Message );
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsGeneralTab2.LogErrorS(objException, "vRoleMenus_GetDataSet");
                return new DataSet();
            }
        }

        [WebMethod]
        public DataSet vRoleMenus_GetDataSetEx(string strRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            try
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.Append(" 1=1 ");
                if (string.IsNullOrEmpty(strRoleId) == false)
                {
                    sbCondition.AppendFormat(" And RoleId = '{0}' ",
                        strRoleId);
                }
                if (bolIsUpMenuId == true)
                {
                    sbCondition.AppendFormat("  AND UpMenuId = '00000000' ");
                }
                else
                {
                    sbCondition.AppendFormat("  AND UpMenuId <> '00000000' ");
                }
                sbCondition.AppendFormat(" AND PrjId = '{0}' ",
                    strPrjId);
                if (string.IsNullOrEmpty(strMenuSetId) == false)
                {
                    sbCondition.AppendFormat(" And MenuSetId='{1}'",
                        strMenuSetId);
                }
                sbCondition.Append(" ORDER BY OrderNum");
                sbCondition.Append("[Exclude]or [/Exclude]");

                clsPubVar.objLog.WriteDebugLog(sbCondition.ToString());
                DataSet objDS = clsvRoleMenusBL.GetDataSet_vRoleMenus(sbCondition.ToString());

                return objDS;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在函数：【vRoleMenusService】的【vRoleMenus_GetDataSetEx】中出错：{0}", objException.Message);
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsGeneralTab2.LogErrorS(objException, "vRoleMenus_GetDataSetEx");
                return new DataSet();
            }
        }


        [WebMethod]
        public DataSet vRoleMenus_GetDataSetByRoleIdsEx(string sstrRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            try
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.Append(" 1=1 ");
                if (string.IsNullOrEmpty(sstrRoleId) == false)
                {
                    sbCondition.AppendFormat(" And RoleId in ('{0}') ",
                        sstrRoleId);
                }
                if (bolIsUpMenuId == true)
                {
                    sbCondition.AppendFormat("  AND UpMenuId = '00000000' ");
                }
                else
                {
                    sbCondition.AppendFormat("  AND UpMenuId <> '00000000' ");
                }
                sbCondition.AppendFormat(" AND PrjId = '{0}' ",
                    strPrjId);
                if (string.IsNullOrEmpty(strMenuSetId) == false)
                {
                    sbCondition.AppendFormat(" And MenuSetId='{1}'",
                        strMenuSetId);
                }
                sbCondition.Append(" ORDER BY OrderNum");
                sbCondition.Append("[Exclude]or [/Exclude]");

                clsPubVar.objLog.WriteDebugLog(sbCondition.ToString());
                DataSet objDS = clsvRoleMenusBL.GetDataSet_vRoleMenus(sbCondition.ToString());

                return objDS;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在函数：【vRoleMenusService】的【vRoleMenus_GetDataSetEx】中出错：{0}", objException.Message);
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsGeneralTab2.LogErrorS(objException, "vRoleMenus_GetDataSetEx");
                return new DataSet();
            }
        }

        [WebMethod]
        public bool vRoleMenus_GetvRoleMenus(ref clsvRoleMenusEN objvRoleMenus)
        {
            bool bolResult = clsvRoleMenusBL.GetvRoleMenus(ref objvRoleMenus);
            return bolResult;
        }

        [WebMethod]
        public bool vRoleMenus_GetvRoleMenusV(ref clsvRoleMenusEN objvRoleMenus)
        {
            bool bolResult = clsvRoleMenusBL.GetvRoleMenus(ref objvRoleMenus);
            return bolResult;
        }

        [WebMethod]
        public bool vRoleMenus_IsExistRecordByCond(string strWhereCond)
        {
            bool bolIsExist = clsvRoleMenusBL.IsExistRecord(strWhereCond);
            return bolIsExist;
        }

        [WebMethod]
        public bool vRoleMenus_IsExist(long lngmId)
        {
            bool bolIsExist = clsvRoleMenusBL.IsExist(lngmId);
            return bolIsExist;
        }

        [WebMethod]
        public clsvRoleMenusEN ExposeLogicClass(clsvRoleMenusEN objvRoleMenus)
        {
            return objvRoleMenus;
        }
    }
}