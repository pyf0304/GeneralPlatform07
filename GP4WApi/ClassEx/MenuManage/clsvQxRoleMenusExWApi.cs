
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvQxRoleMenusExWApi
表名:vQxRoleMenus(00140034)
生成代码版本:2019.03.24.1
生成日期:2019/03/24 09:23:55
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:菜单管理
模块英文名:MenuManage
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using GeneralPlatform.Entity;

using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using GP4WApi;

namespace GP4WApi
{
    /// <summary>
    /// v角色菜单(vQxRoleMenus)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvQxRoleMenusExWApi
    {
        private static readonly string mstrApiControllerName = "vQxRoleMenusExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;



        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="strRoleId">提供的条件</param>
        /// <param name="strPrjId">提供的条件</param>
        /// <param name="strMenuSetId">提供的条件</param>
        /// <param name="bolIsUpMenuId">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvQxRoleMenusEN> GetObjLstEx(stuRoleMenuPara objRoleMenuPara)
        {
            List<clsvQxRoleMenusEN> arrObjLst = null;
            string strAction = "GetObjLstEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objRoleMenuPara.GetDictParam();

            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuRoleMenuPara>(objRoleMenuPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    //arrObjLst = clsJSON.GetObjLstFromJson1<clsvQxRoleMenusEN>(strResult);
                    //return arrObjLst;
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
                        arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
                        return arrObjLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }

        }



        /// <summary>
        /// 根据条件获取角色菜单对象列表
        /// </summary>
        /// <param name="sstrRoleId">提供的条件</param>
        /// <param name="strPrjId">提供的条件</param>
        /// <param name="strMenuSetId">提供的条件</param>
        /// <param name="bolIsUpMenuId">提供的条件</param>
        /// <returns>返回：角色菜单对象列表</returns>
        public static List<clsvQxRoleMenusEN> GetObjLstByRoleIdsEx(stuRoleMenuByRoleIdsPara objRoleMenuByRoleIdsPara)
        {
            List<clsvQxRoleMenusEN> arrObjLst = null;
            string strAction = "GetObjLstByRoleIdsEx";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objRoleMenuByRoleIdsPara.GetDictParam();

            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuRoleMenuByRoleIdsPara>(objRoleMenuByRoleIdsPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    //arrObjLst = clsJSON.GetObjLstFromJson1<clsvQxRoleMenusEN>(strResult);
                    //return arrObjLst;
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
                        arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRoleMenusEN>>(strJson);
                        return arrObjLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
                     HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
               clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
            //    strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' ",
            //    strPrjId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = strRoleId,
                QxPrjId = strPrjId,
                MenuSetId = "",
                IsUpMenuId = "true"
            };
            try
            {
                arrUpMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }

        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.Append(" UpMenuId = '00000000' AND ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}' ",
            //    strPrjId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = "",
                QxPrjId = strPrjId,
                MenuSetId = "",
                IsUpMenuId = "true"
            };
            try
            {
                arrUpMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }


        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}'", strPrjId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = strRoleId,
                QxPrjId = strPrjId,
                MenuSetId = "",
                IsUpMenuId = "false"
            };
            try
            {
                arrSubMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }

        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(string strPrjId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.Append(" UpMenuId <> '00000000' and ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}'", strPrjId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = "",
                QxPrjId = strPrjId,
                MenuSetId = "",
                IsUpMenuId = "false"
            };
            try
            {
                arrSubMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }


        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" RoleId = '{0}' AND UpMenuId = '00000000' AND ",
            //    strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = strRoleId,
                QxPrjId = strPrjId,
                MenuSetId = strMenuSetId,
                IsUpMenuId = "true"
            };
            try
            {
                arrUpMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjList(string strRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.AppendFormat(" RoleId = '{0}' And UpMenuId <> '00000000' and ", strRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = strRoleId,
                QxPrjId = strPrjId,
                MenuSetId = strMenuSetId,
                IsUpMenuId = "false"
            };
            try
            {
                arrSubMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }



        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat(" UpMenuId = '00000000' AND ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId={1}",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = "",
                QxPrjId = strPrjId,
                MenuSetId = strMenuSetId,
                IsUpMenuId = "true"
            };
            try
            {
                arrUpMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvQxRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvQxRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();

            //sbCondition.AppendFormat(" UpMenuId <> '00000000' and ");
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId={1}", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuPara objRoleMenuPara = new stuRoleMenuPara()
            {
                RoleId = "",
                QxPrjId = strPrjId,
                MenuSetId = strMenuSetId,
                IsUpMenuId = "false"
            };
            try
            {
                arrSubMenuObjList = GetObjLstEx(objRoleMenuPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }


        /// <summary>
        /// 获取当前角色列表的子层菜单列表，以List[clsvQxRoleMenusEN]的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List[clsvQxRoleMenusEN]形式表示的子层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetSubMenuObjListByRoleIds(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrSubMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            //sbCondition.AppendFormat(" RoleId in ({0}) And UpMenuId <> '00000000' and ", sstrRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'", strPrjId, strMenuSetId);
            //sbCondition.Append(" Order By OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuByRoleIdsPara objRoleMenuByRoleIdsPara = new stuRoleMenuByRoleIdsPara()
            {
                RoleIdLst = arrRoleId,
                QxPrjId = strPrjId,
                MenuSetId = strMenuSetId,
                IsUpMenuId = "false"
            };
            try
            {
                arrSubMenuObjList = GetObjLstByRoleIdsEx(objRoleMenuByRoleIdsPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }

        /// <summary>
        /// 获取当前角色列表的顶层菜单列表，以List[clsvQxRoleMenusEN]的形式返回
        /// </summary>
        /// <param name="arrRoleId">角色Id 列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List[clsvQxRoleMenusEN]形式表示的顶层菜单列表</returns>
        public static List<clsvQxRoleMenusEN> GetUpMenuObjListByRoleIds(List<string> arrRoleId, string strPrjId, string strMenuSetId)
        {
            List<clsvQxRoleMenusEN> arrUpMenuObjList = null;
            //StringBuilder sbCondition = new StringBuilder();
            string sstrRoleId = clsArray.GetSqlInStrByArray(arrRoleId, true);
            //sbCondition.AppendFormat(" RoleId in ({0}) AND UpMenuId = '00000000' AND ",
            //    sstrRoleId);
            //sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId='{1}'",
            //    strPrjId, strMenuSetId);
            //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[E1xclude]or [/Exclude]");
            stuRoleMenuByRoleIdsPara objRoleMenuByRoleIdsPara = new stuRoleMenuByRoleIdsPara()
            {
                RoleIdLst = arrRoleId,
                QxPrjId = strPrjId,
                MenuSetId = strMenuSetId,
                IsUpMenuId = "true"
            };
            try
            {
                arrUpMenuObjList = GetObjLstByRoleIdsEx(objRoleMenuByRoleIdsPara);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsvQxRoleMenusWS");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }



        //静态的处理错误日志的函数

        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="objException">异常对象</param>
        /// <param name="strModuleName">模块名称</param>
        public static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }


    }
}
