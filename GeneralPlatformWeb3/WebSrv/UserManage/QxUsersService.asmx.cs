
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:QxUsersService
 表名:QxUsers(00140015)
 生成代码版本:2020.02.10.2
 生成日期:2020/02/13 22:39:21
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:统一平台
 工程ID:0014
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:WEB服务层(WS_Srv)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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

namespace GeneralPlatform.WebSrv
{
 /// <summary>
 /// QxUsersService 的摘要说明
 /// (AutoGCLib.WS_Srv4CSharp:GeneCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class QxUsersService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objQxUsersEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool QxUsers_GetQxUsers(ref clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
 {
["objQxUsersEN"] = clsQxUsersBL.SerializeObjToXMLStr(objQxUsersEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsQxUsersBL.GetQxUsers(ref objQxUsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsQxUsersEN QxUsers_GetObjByUserId(string strUserId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
clsQxUsersEN objQxUsersEN = clsQxUsersBL.GetObjByUserId(strUserId);
return objQxUsersEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objQxUsersEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool QxUsers_GetQxUsersV(ref clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
 {
["objQxUsersEN"] = clsQxUsersBL.SerializeObjToXMLStr(objQxUsersEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsQxUsersBL.GetQxUsers(ref objQxUsersEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsQxUsersEN> QxUsers_GetObjLst(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsQxUsersEN> arrQxUsersObjLst = clsQxUsersBL.GetObjLst(strWhereCond);
return arrQxUsersObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsQxUsersEN> QxUsers_GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsQxUsersEN> arrQxUsersObjLst = clsQxUsersBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
return arrQxUsersObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string QxUsers_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 string strUserId;
 try
 {
 strUserId = clsQxUsersBL.GetFirstID_S(strWhereCond);
 return strUserId;
 }
 catch (Exception objException)
 {
string strMsg = "获取First关键字出错!\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
[WebMethod]
public clsQxUsersEN QxUsers_GetFirstObj_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsQxUsersEN objQxUsersEN = clsQxUsersBL.GetFirstObj_S(strWhereCond);
 return objQxUsersEN;
 }
 catch (Exception objException)
 {
string strMsg = "获取First记录对象出错!\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
}

   /// <summary>
 /// 获取当前关键字的记录对象,用对象的JSON形式表示.
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetJSONObjByKeyId_S)
 /// </summary>
 /// <param name = "strQxUsersId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetJSONObjByUserId(string strUserId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 clsQxUsersEN objQxUsersEN = null;
 try
 {
 objQxUsersEN = clsQxUsersBL.GetObjByUserId(strUserId);
 if (objQxUsersEN == null) return "";
 }
 catch (Exception objException)
 {
string strMsg = "根据关键字获取对象出错!(QxUsersService:GetJSONObjByUserId)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetFirstJSONObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 clsQxUsersEN objQxUsersEN = null;
 try
 {
 objQxUsersEN = clsQxUsersBL.GetFirstObj_S(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取第一条记录的对象出错!(QxUsersService:GetFirstJSONObj)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsQxUsersEN>(objQxUsersEN);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 List<clsQxUsersEN> arrQxUsersObjLst = null;
 try
 {
 arrQxUsersObjLst = clsQxUsersBL.GetObjLst(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(QxUsersService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrQxUsersObjLst);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopJSONObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶点记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序表达式</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetTopJSONObjLst(int intTopSize, string strWhereCond, string strOrderBy = "")
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond,
["strOrderBy"] = strOrderBy, 
["intTopSize"] = intTopSize.ToString()
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 List<clsQxUsersEN> arrQxUsersObjLst = null;
 try
 {
 arrQxUsersObjLst = clsQxUsersBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(QxUsersService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrQxUsersObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool QxUsers_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsQxUsersBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool QxUsers_IsExist(string strUserId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsQxUsersBL.IsExist(strUserId);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string QxUsers_GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrUserId = clsQxUsersBL.GetMaxStrId_S();
return strMaxstrUserId;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string QxUsers_GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrUserId = clsQxUsersBL.GetMaxStrIdByPrefix_S(strPrefix);
return strMaxstrUserId;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objQxUsersEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxUsers_AddNewRecordBySql2(clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["objQxUsersEN"] = clsQxUsersBL.SerializeObjToXMLStr(objQxUsersEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = objQxUsersEN.AddNewRecord();
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strQxUsersJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxUsers_AddNewRecordBySql2ByJSON(string strQxUsersJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strQxUsersJSONObj"] = strQxUsersJSONObj
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clsQxUsersEN objQxUsersEN = clsJSON.GetObjFromJson<clsQxUsersEN>(strQxUsersJSONObj);
bool bolResult = objQxUsersEN.AddNewRecord();
return bolResult;
 }
 catch (Exception objException)
 {
string strMsg = "通过JSON对象来添加记录对象出错!(QxUsersService:QxUsers_AddNewRecordBySql2ByJSON)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.WS_Srv4CSharp:Gen_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strQxUsersObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool QxUsers_AddNewRecordBySql_XML(string strQxUsersObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strQxUsersObjXml"] = strQxUsersObjXml
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsQxUsersBL.AddNewRecordBySql_XML(strQxUsersObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strQxUsersJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxUsers_UpdateBySql2(clsQxUsersEN objQxUsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["objQxUsersEN"] = clsQxUsersBL.SerializeObjToXMLStr(objQxUsersEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = objQxUsersEN.Update();
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strQxUsersJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxUsers_UpdateBySql2ByJSON(string strQxUsersJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strQxUsersJSONObj"] = strQxUsersJSONObj
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clsQxUsersEN objQxUsersEN = clsJSON.GetObjFromJson<clsQxUsersEN>(strQxUsersJSONObj);
clsQxUsersBL.SetUpdFlag(objQxUsersEN);
bool bolResult = objQxUsersEN.Update();
return bolResult;
 }
 catch (Exception objException)
 {
string strMsg = "通过JSON对象来修改记录对象出错!(QxUsersService:QxUsers_UpdateBySql2ByJSON)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
}

 /// <summary>
 /// 根据条件修改记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUsersEN">JSON对象字符串</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回是否成功?</returns>
[WebMethod]
public bool QxUsers_UpdateBySqlWithCondition(clsQxUsersEN objQxUsersEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["objQxUsersEN"] = clsQxUsersBL.SerializeObjToXMLStr(objQxUsersEN),
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = objQxUsersEN.UpdateWithCondition(strWhereCond);
return bolResult;
}
catch (Exception objException)
{
string strMsg = "修改记录出错!\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strQxUsersObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool QxUsers_UpdateBySql_XML(string strQxUsersObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strQxUsersObjXml"] = strQxUsersObjXml
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsQxUsersBL.UpdateBySql_XML(strQxUsersObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[WebMethod]
public int QxUsers_DelRecord(string strUserId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsQxUsersBL.DelRecord(strUserId);
return intRecNum;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrUserIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
[WebMethod]
public int QxUsers_DelQxUserss(string strJSON4Keys)
{
List<string> arrUserId = clsJSON.GetObjLstFromJson<string>(strJSON4Keys);
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["arrUserId"] = clsArray.GetSqlInStrByArray(arrUserId, true)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsQxUsersBL.DelQxUserss(arrUserId);
return intRecNum;
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int QxUsers_DelQxUserssByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsQxUsersBL.DelQxUserssByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsQxUsersEN ExposeLogicClass(clsQxUsersEN objQxUsersEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["objQxUsersEN"] = clsQxUsersBL.SerializeObjToXMLStr(objQxUsersEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
return objQxUsersEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:20200213223921
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strUserId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsQxUsersEN>对象XML串</returns>
[WebMethod]
public string QxUsers_SerializeObjToXMLStr(string strUserId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsQxUsersEN objQxUsersEN = new clsQxUsersEN(strUserId);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsQxUsersBL.GetQxUsers(ref objQxUsersEN);
strXmlString = clsQxUsersBL.SerializeObjToXMLStr(objQxUsersEN);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "QxUsersService"); 
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223921
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsQxUsersEN>对象列表XML串</returns>
[WebMethod]
public string QxUsers_SerializeObjLstToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsQxUsersEN> lstQxUsersObjLst = clsQxUsersBL.GetObjLst(strWhereCond);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsQxUsersBL.SerializeObjLstToXMLStr(lstQxUsersObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "QxUsersService");
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223921
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeTopObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsQxUsersEN>对象列表XML串</returns>
[WebMethod]
public string QxUsers_SerializeTopObjLstToXMLStr(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsQxUsersEN> lstQxUsersObjLst = clsQxUsersBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsQxUsersBL.SerializeObjLstToXMLStr(lstQxUsersObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "QxUsersService");
}
return strXmlString;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetJSONObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetJSONObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond,
["strOrderBy"] = strOrderBy, 
["intPageIndex"] = intPageIndex.ToString(),
["intPageSize"] = intPageSize.ToString()
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 List<clsQxUsersEN> arrQxUsersObjLst = null;
 try
 {
 arrQxUsersObjLst = clsQxUsersBL.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件分页获取的对象列表出错!(QxUsersService:GetJSONObjLstByPager)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrQxUsersObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// (AutoGCLib.WS_Srv4CSharp:Gen_funGetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>某一条件的记录数</returns>
[WebMethod]
public int QxUsers_funGetRecCountByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intCount = clsQxUsersBL.GetRecCountByCond(strWhereCond);
return intCount;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串
 /// (AutoGCLib.WS_Srv4CSharp:Gen_DelMultiRecordByJSON)
 /// </summary>
 /// <param name = "strKeyIdLst">给定的关键字值列表的JSON串</param>
 /// <returns>返回删除的记录数</returns>
[WebMethod]
public int DelRecordsByJSON(string strKeyIdLst)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strKeyIdLst"] = strKeyIdLst
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string[] sstrUserId = strKeyIdLst.Trim().Split(',');
List <string> arrUserId = new List<string>();
foreach (string strUserId in sstrUserId)
{
if (string.IsNullOrEmpty(strUserId) == false)
{
arrUserId.Add(strUserId);
}
}
int intRecNum = clsQxUsersBL.DelQxUserss(arrUserId);
return intRecNum;
}

 /// <summary>
 /// 根据条件获取范围内的JSON对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetJSONObjLstByRange)
 /// </summary>
 /// <param name = "intMinNum">最小记录号</param>
 /// <param name = "intMaxNum">最大记录号</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetJSONObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond,
["strOrderBy"] = strOrderBy, 
["intMinNum"] = intMinNum.ToString(),
["intMaxNum"] = intMaxNum.ToString()
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 List<clsQxUsersEN> arrQxUsersObjLst = null;
 try
 {
 arrQxUsersObjLst = clsQxUsersBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(QxUsersService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrQxUsersObjLst);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjLstByRange)
 /// </summary>
 /// <param name = "intMinNum">最小记录号</param>
 /// <param name = "intMaxNum">最大记录号</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回范围内的对象列表</returns>
 [WebMethod]
 public List<clsQxUsersEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond,
["strOrderBy"] = strOrderBy, 
["intMinNum"] = intMinNum.ToString(),
["intMaxNum"] = intMaxNum.ToString()
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 List<clsQxUsersEN> arrQxUsersObjLst = null;
 try
 {
 arrQxUsersObjLst = clsQxUsersBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(QxUsersService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 return arrQxUsersObjLst;
 }

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet QxUsers_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsQxUsersBL.GetDataSet(strWhereCond);
return objDS;
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet QxUsers_GetTopDataSet(int intTopSize, string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsQxUsersBL.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetDataSetByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet QxUsers_GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond,
["strOrderBy"] = strOrderBy, 
["intMinNum"] = intMinNum.ToString(),
["intMaxNum"] = intMaxNum.ToString()
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsQxUsersBL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
}
}