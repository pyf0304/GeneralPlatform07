
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:vQxRelaOfPotenceAndSymbolService
 表名:vQxRelaOfPotenceAndSymbol(00140049)
 生成代码版本:2020.02.10.2
 生成日期:2020/02/13 22:39:24
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:统一平台
 工程ID:0014
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:权限管理
 模块英文名:PotenceMan
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
 /// vQxRelaOfPotenceAndSymbolService 的摘要说明
 /// (AutoGCLib.WS_Srv4CSharp:GeneCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class vQxRelaOfPotenceAndSymbolService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vQxRelaOfPotenceAndSymbol_GetvQxRelaOfPotenceAndSymbol(ref clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
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
["objvQxRelaOfPotenceAndSymbolEN"] = clsvQxRelaOfPotenceAndSymbolBL.SerializeObjToXMLStr(objvQxRelaOfPotenceAndSymbolEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvQxRelaOfPotenceAndSymbolBL.GetvQxRelaOfPotenceAndSymbol(ref objvQxRelaOfPotenceAndSymbolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsvQxRelaOfPotenceAndSymbolEN vQxRelaOfPotenceAndSymbol_GetObjByRelaMid(long lngRelaMid)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString()
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = clsvQxRelaOfPotenceAndSymbolBL.GetObjByRelaMid(lngRelaMid);
return objvQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vQxRelaOfPotenceAndSymbol_GetvQxRelaOfPotenceAndSymbolV(ref clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
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
["objvQxRelaOfPotenceAndSymbolEN"] = clsvQxRelaOfPotenceAndSymbolBL.SerializeObjToXMLStr(objvQxRelaOfPotenceAndSymbolEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvQxRelaOfPotenceAndSymbolBL.GetvQxRelaOfPotenceAndSymbol(ref objvQxRelaOfPotenceAndSymbolEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsvQxRelaOfPotenceAndSymbolEN> vQxRelaOfPotenceAndSymbol_GetObjLst(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLst(strWhereCond);
return arrvQxRelaOfPotenceAndSymbolObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsvQxRelaOfPotenceAndSymbolEN> vQxRelaOfPotenceAndSymbol_GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
return arrvQxRelaOfPotenceAndSymbolObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public long vQxRelaOfPotenceAndSymbol_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 long lngRelaMid;
 try
 {
 lngRelaMid = clsvQxRelaOfPotenceAndSymbolBL.GetFirstID_S(strWhereCond);
 return lngRelaMid;
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
public clsvQxRelaOfPotenceAndSymbolEN vQxRelaOfPotenceAndSymbol_GetFirstObj_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = clsvQxRelaOfPotenceAndSymbolBL.GetFirstObj_S(strWhereCond);
 return objvQxRelaOfPotenceAndSymbolEN;
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
 /// <param name = "strvQxRelaOfPotenceAndSymbolId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetJSONObjByRelaMid(long lngRelaMid)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString()
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = null;
 try
 {
 objvQxRelaOfPotenceAndSymbolEN = clsvQxRelaOfPotenceAndSymbolBL.GetObjByRelaMid(lngRelaMid);
 if (objvQxRelaOfPotenceAndSymbolEN == null) return "";
 }
 catch (Exception objException)
 {
string strMsg = "根据关键字获取对象出错!(vQxRelaOfPotenceAndSymbolService:GetJSONObjByRelaMid)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsvQxRelaOfPotenceAndSymbolEN>(objvQxRelaOfPotenceAndSymbolEN);
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
 clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = null;
 try
 {
 objvQxRelaOfPotenceAndSymbolEN = clsvQxRelaOfPotenceAndSymbolBL.GetFirstObj_S(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取第一条记录的对象出错!(vQxRelaOfPotenceAndSymbolService:GetFirstJSONObj)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsvQxRelaOfPotenceAndSymbolEN>(objvQxRelaOfPotenceAndSymbolEN);
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
 List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst = null;
 try
 {
 arrvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLst(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(vQxRelaOfPotenceAndSymbolService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxRelaOfPotenceAndSymbolObjLst);
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
 List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst = null;
 try
 {
 arrvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(vQxRelaOfPotenceAndSymbolService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxRelaOfPotenceAndSymbolObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool vQxRelaOfPotenceAndSymbol_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvQxRelaOfPotenceAndSymbolBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "lngRelaMid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool vQxRelaOfPotenceAndSymbol_IsExist(long lngRelaMid)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString()
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvQxRelaOfPotenceAndSymbolBL.IsExist(lngRelaMid);
return bolIsExist;
}

[WebMethod]
public clsvQxRelaOfPotenceAndSymbolEN ExposeLogicClass(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
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
["objvQxRelaOfPotenceAndSymbolEN"] = clsvQxRelaOfPotenceAndSymbolBL.SerializeObjToXMLStr(objvQxRelaOfPotenceAndSymbolEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
return objvQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:20200213223924
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "lngRelaMid">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsvQxRelaOfPotenceAndSymbolEN>对象XML串</returns>
[WebMethod]
public string vQxRelaOfPotenceAndSymbol_SerializeObjToXMLStr(long lngRelaMid)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString()
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN(lngRelaMid);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsvQxRelaOfPotenceAndSymbolBL.GetvQxRelaOfPotenceAndSymbol(ref objvQxRelaOfPotenceAndSymbolEN);
strXmlString = clsvQxRelaOfPotenceAndSymbolBL.SerializeObjToXMLStr(objvQxRelaOfPotenceAndSymbolEN);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "vQxRelaOfPotenceAndSymbolService"); 
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223924
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsvQxRelaOfPotenceAndSymbolEN>对象列表XML串</returns>
[WebMethod]
public string vQxRelaOfPotenceAndSymbol_SerializeObjLstToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsvQxRelaOfPotenceAndSymbolEN> lstvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLst(strWhereCond);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsvQxRelaOfPotenceAndSymbolBL.SerializeObjLstToXMLStr(lstvQxRelaOfPotenceAndSymbolObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "vQxRelaOfPotenceAndSymbolService");
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223924
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeTopObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsvQxRelaOfPotenceAndSymbolEN>对象列表XML串</returns>
[WebMethod]
public string vQxRelaOfPotenceAndSymbol_SerializeTopObjLstToXMLStr(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsvQxRelaOfPotenceAndSymbolEN> lstvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsvQxRelaOfPotenceAndSymbolBL.SerializeObjLstToXMLStr(lstvQxRelaOfPotenceAndSymbolObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "vQxRelaOfPotenceAndSymbolService");
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
 List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst = null;
 try
 {
 arrvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件分页获取的对象列表出错!(vQxRelaOfPotenceAndSymbolService:GetJSONObjLstByPager)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxRelaOfPotenceAndSymbolObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// (AutoGCLib.WS_Srv4CSharp:Gen_funGetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>某一条件的记录数</returns>
[WebMethod]
public int vQxRelaOfPotenceAndSymbol_funGetRecCountByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intCount = clsvQxRelaOfPotenceAndSymbolBL.GetRecCountByCond(strWhereCond);
return intCount;
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
 List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst = null;
 try
 {
 arrvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(vQxRelaOfPotenceAndSymbolService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxRelaOfPotenceAndSymbolObjLst);
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
 public List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
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
 List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst = null;
 try
 {
 arrvQxRelaOfPotenceAndSymbolObjLst = clsvQxRelaOfPotenceAndSymbolBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(vQxRelaOfPotenceAndSymbolService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 return arrvQxRelaOfPotenceAndSymbolObjLst;
 }

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet vQxRelaOfPotenceAndSymbol_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvQxRelaOfPotenceAndSymbolBL.GetDataSet(strWhereCond);
return objDS;
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet vQxRelaOfPotenceAndSymbol_GetTopDataSet(int intTopSize, string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvQxRelaOfPotenceAndSymbolBL.GetDataSet_Top(intTopSize, strWhereCond);
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
public DataSet vQxRelaOfPotenceAndSymbol_GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
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
DataSet objDS = clsvQxRelaOfPotenceAndSymbolBL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
}
}