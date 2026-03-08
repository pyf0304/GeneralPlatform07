
//类名:vQxRoleMenusService
///----------------------
///生成代码版本:2016.08.29.1
///生成日期:2016/09/07
///生成者:潘以锋
///工程名称:统一平台
///工程ID:0014
///模块中文名:菜单管理
///模块英文名:MenuManage
///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.08.11.01
///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.08.11.01
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using com.taishsoft.json;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using GeneralPlatform.Webform;

namespace GeneralPlatform.WebSrv
{
    /// <summary>
    /// vQxRoleMenusService 的摘要说明
    /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode4View)
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class vQxRoleMenusExService : System.Web.Services.WebService
    {
               
        [WebMethod]
        public DataSet vQxRoleMenus_GetDataSetEx(string strRoleId, string strPrjId, 
            string strMenuSetId, bool bolIsUpMenuId)
        {
            try
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("strRoleId", strRoleId);
                dictParam.Add("strPrjId", strPrjId);
                dictParam.Add("strMenuSetId", strMenuSetId);
                dictParam.Add("bolIsUpMenuId", bolIsUpMenuId.ToString());

                clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);

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
                sbCondition.AppendFormat(" AND QxPrjId = '{0}' ",
                    strPrjId);
                if (string.IsNullOrEmpty(strMenuSetId) == false)
                {
                    sbCondition.AppendFormat(" And MenuSetId='{0}'",
                        strMenuSetId);
                }
                sbCondition.Append(" ORDER BY OrderNum");
                sbCondition.Append("[exclude]or [/exclude]");

                clsPubVar.objLog.WriteDebugLog(sbCondition.ToString());
                DataSet objDS = clsvQxRoleMenusBL.GetDataSet(sbCondition.ToString());

                return objDS;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("根据角色Ids获取相关菜单出错：{0}.({1})", 
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsGeneralTab2.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                return new DataSet();
            }
        }


        [WebMethod]
        public DataSet vQxRoleMenus_GetDataSetByRoleIdsEx(string sstrRoleId, string strPrjId, string strMenuSetId, bool bolIsUpMenuId)
        {
            try
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = new Dictionary<string, string>();
                dictParam.Add("sstrRoleId", sstrRoleId);
                dictParam.Add("strPrjId", strPrjId);
                dictParam.Add("strMenuSetId", strMenuSetId);
                dictParam.Add("bolIsUpMenuId", bolIsUpMenuId.ToString());
                clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);


                StringBuilder sbCondition = new StringBuilder();
                sbCondition.Append(" 1=1 ");
                if (string.IsNullOrEmpty(sstrRoleId) == false)
                {
                    sbCondition.AppendFormat(" And RoleId in ({0}) ",
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
                sbCondition.AppendFormat(" AND QxPrjId = '{0}' ",
                    strPrjId);
                if (string.IsNullOrEmpty(strMenuSetId) == false)
                {
                    sbCondition.AppendFormat(" And MenuSetId='{0}'",
                        strMenuSetId);
                }
                sbCondition.Append(" ORDER BY OrderNum");
                sbCondition.Append("[exclude]or [/exclude]");

                clsPubVar.objLog.WriteDebugLog(sbCondition.ToString());
                DataSet objDS = clsvQxRoleMenusBL.GetDataSet(sbCondition.ToString());

                return objDS;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("根据角色Ids获取相关菜单出错：{0}.({1})", 
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar.objLog.WriteDebugLog(strMsg);
                clsGeneralTab2.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                return new DataSet();
            }
        }
        [WebMethod]
        public clsvQxRoleMenusEN ExposeLogicClass(clsvQxRoleMenusEN objvQxRoleMenusEN)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("objvQxRoleMenusEN", clsvQxRoleMenusBL.SerializeObjToXMLStr(objvQxRoleMenusEN));
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);
            return objvQxRoleMenusEN;
        }
    }
}