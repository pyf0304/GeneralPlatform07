
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersExWApi
表名:QxUsers(00140015)
生成代码版本:2019.03.24.1
生成日期:2019/03/24 09:23:44
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:用户管理
模块英文名:UserManage
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
using com.taishsoft.datetime;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using GeneralPlatform4WApi;

namespace GP4WApi
{
    /// <summary>
    /// 用户(QxUsers)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsQxUsersExWApi
    {
        private static readonly string mstrApiControllerName = "QxUsersExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsQxUsersEN> arrQxUsersObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;



        /// <summary>
        /// 根据关键字列表删除记录
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
        /// </summary>
        /// <returns>实际删除记录的个数</returns>
        public static int SynDataToOtherServer(List<string> arrUserId, string strServerId)
        {
            string strAction = "SynDataToOtherServer";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strServerId"] = strServerId
            };
            try
            {
                string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    //int intResult = int1.Parse(strResult);
                    //return intResult;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (int)jobjReturn["returnInt"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return 0;
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
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetRoleIdLstByUserId(string strUserId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            string strAction = "GetRoleIdLstByUserId";
            string strErrMsg = string.Empty;
            string strResult = "";
            //List<string> arrRoleId = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //arrRoleId = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return arrRoleId;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>( strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                    
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> GetRoleNameLstByUserId(string strUserId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            string strAction = "GetRoleNameLstByUserId";
            string strErrMsg = string.Empty;
            string strResult = "";
            //List<string> arrRoleName = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //arrRoleName = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return arrRoleName;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetPotenceIdLstByUserId(string strUserId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            string strAction = "GetPotenceIdLstByUserId";
            string strErrMsg = string.Empty;
            string strResult = "";
            //List<string> arrPotenceId = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //arrPotenceId = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return arrPotenceId;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> GetPotenceNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            string strAction = "GetPotenceNameLstByUserId";
            string strErrMsg = string.Empty;
            string strResult = "";
            List<string> arrPotenceName = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //arrPotenceName = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return arrPotenceName;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            string strAction = "IsHavePotenceName";
            string strErrMsg = string.Empty;
            string strResult = "";
            //bool bolIsHave = false;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
                ["strPotenceName"] = strPotenceName
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //bolIsHave = bool1.Parse(strResult);
                    //return bolIsHave;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 是否包含某权限Id
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceId">给定的权限ID</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceId(string strPrjId, string strUserId, string strPotenceId)
        {
            string strAction = "IsHavePotenceId";
            string strErrMsg = string.Empty;
            string strResult = "";
            //bool bolIsHave = false;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
                ["strPotenceName"] = strPotenceId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //bolIsHave = bool1.Parse(strResult);
                    //return bolIsHave;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            string strAction = "GetQxPrjPotenceObjByPotenceName";
            string strErrMsg = string.Empty;
            string strResult = "";
            clsQxPrjPotenceEN objQxPrjPotenceEN = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
                ["strPotenceName"] = strPotenceName
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //objQxPrjPotenceEN = clsJSON.GetObjFromJson<clsQxPrjPotenceEN>(strResult);
                    //return objQxPrjPotenceEN;
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
                        objQxPrjPotenceEN = JsonConvert.DeserializeObject<clsQxPrjPotenceEN>(strJson);
                        return objQxPrjPotenceEN;
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
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取当前角色中包含某权限名称的权限对象
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static clsQxPrjPotenceEN GetQxPrjPotenceObjByPotenceName4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName)
        {
            string strAction = "GetQxPrjPotenceObjByPotenceName4CurrRole";
            string strErrMsg = string.Empty;
            string strResult = "";
            clsQxPrjPotenceEN objQxPrjPotenceEN = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
                ["strRoleId"] = strRoleId,
                ["strPotenceName"] = strPotenceName
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //objQxPrjPotenceEN = clsJSON.GetObjFromJson<clsQxPrjPotenceEN>(strResult);
                    //return objQxPrjPotenceEN;
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
                        objQxPrjPotenceEN = JsonConvert.DeserializeObject<clsQxPrjPotenceEN>(strJson);
                        return objQxPrjPotenceEN;
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
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }



        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceId">权限ID</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolIdLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            string strAction = "GetSymbolIdLstByPotenceId";
            string strErrMsg = string.Empty;
            string strResult = "";
            List<string> lstSymbolId = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPotenceId"] = strPotenceId,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //lstSymbolId = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return lstSymbolId;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceId">权限ID</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            string strAction = "GetSymbolNameLstByPotenceId";
            string strErrMsg = string.Empty;
            string strResult = "";
            List<string> lstSymbolName = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPotenceId"] = strPotenceId,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //lstSymbolName = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return lstSymbolName;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolIdLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            string strAction = "GetSymbolIdLstByPotenceName";
            string strErrMsg = string.Empty;
            string strResult = "";
            List<string> lstSymbolId = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPotenceName"] = strPotenceName,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //lstSymbolId = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return lstSymbolId;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            string strAction = "GetSymbolNameLstByPotenceName";
            string strErrMsg = string.Empty;
            string strResult = "";
            List<string> lstSymbolName = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPotenceName"] = strPotenceName,
                ["strPrjId"] = strPrjId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //lstSymbolName = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return lstSymbolName;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">当前默认角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceName4CurrRoleId(string strUserId, string strPotenceName, string strPrjId, string strRoleId)
        {
            string strAction = "GetSymbolNameLstByPotenceName4CurrRoleId";
            string strErrMsg = string.Empty;
            string strResult = "";
            List<string> lstSymbolName = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strPotenceName"] = strPotenceName,
                ["strPrjId"] = strPrjId,
                ["strRoleId"] = strRoleId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //lstSymbolName = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return lstSymbolName;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">当前默认角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceName4CurrRoleId2(string strPotenceName, string strPrjId, string strRoleId)
        {
            string strAction = "GetSymbolNameLstByPotenceName4CurrRoleId2";
            string strErrMsg = string.Empty;
            string strResult = "";
            List<string> lstSymbolName = null;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPotenceName"] = strPotenceName,
                ["strPrjId"] = strPrjId,
                ["strRoleId"] = strRoleId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //lstSymbolName = clsJSON.GetObjFromJson<List1<string>>(strResult);
                    //return lstSymbolName;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var strReturnStrLst = (string)jobjReturn["returnStrLst"];
                        var arrLst = new List<string>(strReturnStrLst.Split(",".ToCharArray()));
                        return arrLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }


        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <param name="strSymbolName">权限标志</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceNameAndSymbol(string strPrjId, string strUserId, string strPotenceName, string strSymbolName)
        {
            string strAction = "IsHavePotenceNameAndSymbol";
            string strErrMsg = string.Empty;
            string strResult = "";
            bool bolIsHave = false;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
                ["strPotenceName"] = strPotenceName,
                ["strSymbolName"] = strSymbolName
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //bolIsHave = bool1.Parse(strResult);
                    //return bolIsHave;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <param name="strSymbolName">权限标志</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceNameAndSymbol4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName, string strSymbolName)
        {
            string strAction = "IsHavePotenceNameAndSymbol4CurrRole";
            string strErrMsg = string.Empty;
            string strResult = "";
            bool bolIsHave = false;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strPrjId"] = strPrjId,
                ["strUserId"] = strUserId,
                ["strRoleId"] = strRoleId,
                ["strPotenceName"] = strPotenceName,
                ["strSymbolName"] = strSymbolName
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //bolIsHave = bool1.Parse(strResult);
                    //return bolIsHave;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strOldPassword">用户当前的密码，用以验证</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        public bool Change_QxUserPassword(stuChangePasswordPara objChangePasswordPara)
        {

            string strAction = "Change_QxUserPassword";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objChangePasswordPara.GetDictParam();
            //bool bolIsSuccess = false;
            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuChangePasswordPara>(objChangePasswordPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    //bolIsSuccess = bool1.Parse(strResult);
                    //return bolIsSuccess;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
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
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        public bool Change_QxUserPassword2(stuChangePasswordPara objChangePasswordPara)
        {
            string strAction = "Change_QxUserPassword2";
            string strErrMsg = string.Empty;
            string strResult = "";
            Dictionary<string, string> dictParam = objChangePasswordPara.GetDictParam();
            bool bolIsSuccess = false;
            try
            {
                string strJSON = clsJSON.GetJsonFromObj<stuChangePasswordPara>(objChangePasswordPara);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
                {
                    //bolIsSuccess = bool1.Parse(strResult);
                    //return bolIsSuccess;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
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
        /// 根据用户Id（UserId）获取入校年月
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年月</returns>
        public static string GetEnterSchoolDateByUserId(string strUserId)
        {
            string strAction = "GetEnterSchoolDateByUserId";
            string strErrMsg = string.Empty;
            string strResult = "";
            //string strEnterSchoolDate = "";

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //strEnterSchoolDate = strResult;
                    //return strEnterSchoolDate;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (string)jobjReturn["returnStr"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return "";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }


        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年</returns>
        public static string GetEnterSchoolYearByUserId(string strUserId)
        {
            string strAction = "GetEnterSchoolYearByUserId";
            string strErrMsg = string.Empty;
            string strResult = "";
            string strEnterSchoolYear = "";

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //strEnterSchoolYear = strResult;
                    //return strEnterSchoolYear;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (string)jobjReturn["returnStr"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return "";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 根据用户Id（UserId）获取用户名
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>用户名</returns>
        public static string GetUserNameByUserId(string strUserId)
        {
            string strAction = "GetUserNameByUserId";
            string strErrMsg = string.Empty;
            string strResult = "";
            //string strUserName = "";

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //strUserName = strResult;
                    //return strUserName;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (string)jobjReturn["returnStr"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return "";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strUserId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        //public static clsQxUsersEN GetQxUsersObjByUserIdWithObjList(string strUserId)
        //{
        //    if (arrUsersObjLst == null)
        //    {
        //        arrUsersObjLst = clsQxUsersWS.GetObjLst("1=1");
        //    }
        //    foreach (clsQxUsersEN objUsers in arrUsersObjLst)
        //    {
        //        if (objUsers.UserId == strUserId)
        //        {
        //            return objUsers;
        //        }
        //    }
        //    return null;
        //}
        /// <summary>
        /// 添加新的用户
        /// </summary>
        /// <param name="objUsers">用户对象</param>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <returns>是否成功？</returns>
        public static bool AddNewUsers(clsQxUsersEN objUsers, string strPrjId, string strRoleId)
        {
            //1、判断用户是否存在，如果存在就退出
            if (clsQxUsersWApi.IsExist(objUsers.UserId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("用户:{0}({1})已经存在,不能再添加！", objUsers.UserId, objUsers.UserName);
                //                throw new Exception("");

            }
            else
            {
                clsQxUsersWApi.AddNewRecord(objUsers);
            }
            AddPrjUserRelation(objUsers.UserId, strPrjId);
            AddUserRoleRelation(objUsers.UserId, strRoleId);

            return true;
        }
        /// <summary>
        /// 添加新的用户, 如果存在相同的用户，就修改信息，这样可以初始化口令
        /// </summary>
        /// <param name="objUsers">用户对象</param>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <returns>是否成功？</returns>
        public static bool AddNewUsersAndUpdate(clsQxUsersEN objUsers, string strPrjId, string strRoleId)
        {
            ///1、判断用户是否存在，如果存在就退出
            if (clsQxUsersWApi.IsExist(objUsers.UserId) == true)
            {
                //StringBuilder sbMsg = new StringBuilder();
                //sbMsg.AppendFormat("用户:{0}({1})已经存在,不能再添加！", objUsers.UserId, objUsers.UserName);
                //                throw new Exception("");
                clsQxUsersWApi.UpdateRecord(objUsers);
            }
            else
            {
                clsQxUsersWApi.AddNewRecord(objUsers);
            }
            AddPrjUserRelation(objUsers.UserId, strPrjId);
            AddUserRoleRelation(objUsers.UserId, strRoleId);

            return true;
        }
        /// <summary>
        /// 建立工程用户关系
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPrjId">工程ID</param>
        /// <returns></returns>
        public static bool AddPrjUserRelation(string strUserId, string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("QxPrjId='{0}' and UserId='{1}'", strPrjId, strUserId);
            if (clsQxPrjUserRelationWApi.IsExistRecord(sbCondition.ToString()) == false)
            {
                clsQxPrjUserRelationEN objPrjUserRelation = new clsQxPrjUserRelationEN();
                objPrjUserRelation.QxPrjId = strPrjId;
                objPrjUserRelation.UserId = strUserId;
                objPrjUserRelation.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objPrjUserRelation.UpdUser = "WebService";

                objPrjUserRelation.Memo = "由WebService同步！";
                clsQxPrjUserRelationWApi.AddNewRecord(objPrjUserRelation);
            }
            return true;

        }
        /// <summary>
        /// 建立用户角色关系
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strRoleId">工程ID</param>
        /// <returns></returns>
        public static bool AddUserRoleRelation(string strUserId, string strRoleId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("RoleId='{0}' and UserId='{1}'", strRoleId, strUserId);
            if (clsQxUserRoleRelationWApi.IsExistRecord(sbCondition.ToString()) == false)
            {
                clsQxUserRoleRelationEN objUserRoleRelation = new clsQxUserRoleRelationEN();
                objUserRoleRelation.RoleId = strRoleId;
                objUserRoleRelation.UserId = strUserId;
                objUserRoleRelation.QxPrjId = strRoleId.Substring(0, 4);
                objUserRoleRelation.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objUserRoleRelation.UpdUser = "WebService";

                objUserRoleRelation.Memo = "由WebService同步！";
                clsQxUserRoleRelationWApi.AddNewRecord(objUserRoleRelation);
            }
            return true;

        }

        /// <summary>
        /// 为用户设置角色
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strRoleId">当前角色</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>是否成功？</returns>
        public static bool CreateUserRoleRelation(string strUserId, string strRoleId, string strPrjId)
        {
            string strAction = "CreateUserRoleRelation";
            string strErrMsg = string.Empty;
            string strResult = "";
            bool bolIsSuccess = false;

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strUserId"] = strUserId,
                ["strRoleId"] = strRoleId,
                ["strPrjId"] = strPrjId,
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //bolIsSuccess = bool1.Parse(strResult);
                    //return bolIsSuccess;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (bool)jobjReturn["returnBool"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return false;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }
        /// <summary>
        /// 根据部门ID获取该部门的二级管理员ID
        /// </summary>
        /// <param name="strDepartmentId">部门ID</param>
        /// <returns>二级管理员ID？</returns>

        public static string GetManager2IdByDepartmentId(string strDepartmentId)
        {
            string strAction = "GetManager2IdByDepartmentId";
            string strErrMsg = string.Empty;
            string strResult = "";
            string strUserId = "";

            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strDepartmentId"] = strDepartmentId
            };
            try
            {
                if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
                {
                    //strUserId = strResult;
                    //return strUserId;
                    JObject jobjReturn = JObject.Parse(strResult);
                    if ((int)jobjReturn["errorId"] == 0)
                    {
                        var varResult = (string)jobjReturn["returnStr"];
                        return varResult;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
                        throw new Exception(strMsg);
                    }

                }
                else return "";
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

        }


    }
}
