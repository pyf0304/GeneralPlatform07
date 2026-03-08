
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:vQxFuncModule_AgcService
 表名:vQxFuncModule_Agc(00140102)
 生成代码版本:2020.02.10.2
 生成日期:2020/02/13 22:39:36
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:统一平台
 工程ID:0014
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:工程管理
 模块英文名:PrjManage
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
using CommonTable.Entity;
using CommonTable.BusinessLogic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace GeneralPlatform.WebSrv
{
 /// <summary>
 /// vQxFuncModule_AgcService 的摘要说明
 /// (AutoGCLib.WS_Srv4CSharp:GeneCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class vQxFuncModule_AgcService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vQxFuncModule_Agc_GetvQxFuncModule_Agc(ref clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN)
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
["objvQxFuncModule_AgcEN"] = clsvQxFuncModule_AgcBL.SerializeObjToXMLStr(objvQxFuncModule_AgcEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvQxFuncModule_AgcBL.GetvQxFuncModule_Agc(ref objvQxFuncModule_AgcEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsvQxFuncModule_AgcEN vQxFuncModule_Agc_GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN = clsvQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
return objvQxFuncModule_AgcEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vQxFuncModule_Agc_GetvQxFuncModule_AgcV(ref clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN)
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
["objvQxFuncModule_AgcEN"] = clsvQxFuncModule_AgcBL.SerializeObjToXMLStr(objvQxFuncModule_AgcEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvQxFuncModule_AgcBL.GetvQxFuncModule_Agc(ref objvQxFuncModule_AgcEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsvQxFuncModule_AgcEN> vQxFuncModule_Agc_GetObjLst(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsvQxFuncModule_AgcEN> arrvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetObjLst(strWhereCond);
return arrvQxFuncModule_AgcObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsvQxFuncModule_AgcEN> vQxFuncModule_Agc_GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsvQxFuncModule_AgcEN> arrvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
return arrvQxFuncModule_AgcObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string vQxFuncModule_Agc_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 string strFuncModuleAgcId;
 try
 {
 strFuncModuleAgcId = clsvQxFuncModule_AgcBL.GetFirstID_S(strWhereCond);
 return strFuncModuleAgcId;
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
public clsvQxFuncModule_AgcEN vQxFuncModule_Agc_GetFirstObj_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN = clsvQxFuncModule_AgcBL.GetFirstObj_S(strWhereCond);
 return objvQxFuncModule_AgcEN;
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
 /// <param name = "strvQxFuncModule_AgcId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetJSONObjByFuncModuleAgcId(string strFuncModuleAgcId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN = null;
 try
 {
 objvQxFuncModule_AgcEN = clsvQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
 if (objvQxFuncModule_AgcEN == null) return "";
 }
 catch (Exception objException)
 {
string strMsg = "根据关键字获取对象出错!(vQxFuncModule_AgcService:GetJSONObjByFuncModuleAgcId)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsvQxFuncModule_AgcEN>(objvQxFuncModule_AgcEN);
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
 clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN = null;
 try
 {
 objvQxFuncModule_AgcEN = clsvQxFuncModule_AgcBL.GetFirstObj_S(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取第一条记录的对象出错!(vQxFuncModule_AgcService:GetFirstJSONObj)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsvQxFuncModule_AgcEN>(objvQxFuncModule_AgcEN);
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
 List<clsvQxFuncModule_AgcEN> arrvQxFuncModule_AgcObjLst = null;
 try
 {
 arrvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetObjLst(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(vQxFuncModule_AgcService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxFuncModule_AgcObjLst);
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
 List<clsvQxFuncModule_AgcEN> arrvQxFuncModule_AgcObjLst = null;
 try
 {
 arrvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(vQxFuncModule_AgcService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxFuncModule_AgcObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool vQxFuncModule_Agc_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvQxFuncModule_AgcBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool vQxFuncModule_Agc_IsExist(string strFuncModuleAgcId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvQxFuncModule_AgcBL.IsExist(strFuncModuleAgcId);
return bolIsExist;
}

[WebMethod]
public clsvQxFuncModule_AgcEN ExposeLogicClass(clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN)
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
["objvQxFuncModule_AgcEN"] = clsvQxFuncModule_AgcBL.SerializeObjToXMLStr(objvQxFuncModule_AgcEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
return objvQxFuncModule_AgcEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:20200213223936
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsvQxFuncModule_AgcEN>对象XML串</returns>
[WebMethod]
public string vQxFuncModule_Agc_SerializeObjToXMLStr(string strFuncModuleAgcId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN = new clsvQxFuncModule_AgcEN(strFuncModuleAgcId);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsvQxFuncModule_AgcBL.GetvQxFuncModule_Agc(ref objvQxFuncModule_AgcEN);
strXmlString = clsvQxFuncModule_AgcBL.SerializeObjToXMLStr(objvQxFuncModule_AgcEN);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "vQxFuncModule_AgcService"); 
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223936
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsvQxFuncModule_AgcEN>对象列表XML串</returns>
[WebMethod]
public string vQxFuncModule_Agc_SerializeObjLstToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsvQxFuncModule_AgcEN> lstvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetObjLst(strWhereCond);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsvQxFuncModule_AgcBL.SerializeObjLstToXMLStr(lstvQxFuncModule_AgcObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "vQxFuncModule_AgcService");
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223936
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeTopObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsvQxFuncModule_AgcEN>对象列表XML串</returns>
[WebMethod]
public string vQxFuncModule_Agc_SerializeTopObjLstToXMLStr(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsvQxFuncModule_AgcEN> lstvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsvQxFuncModule_AgcBL.SerializeObjLstToXMLStr(lstvQxFuncModule_AgcObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "vQxFuncModule_AgcService");
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
 List<clsvQxFuncModule_AgcEN> arrvQxFuncModule_AgcObjLst = null;
 try
 {
 arrvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件分页获取的对象列表出错!(vQxFuncModule_AgcService:GetJSONObjLstByPager)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxFuncModule_AgcObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// (AutoGCLib.WS_Srv4CSharp:Gen_funGetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>某一条件的记录数</returns>
[WebMethod]
public int vQxFuncModule_Agc_funGetRecCountByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intCount = clsvQxFuncModule_AgcBL.GetRecCountByCond(strWhereCond);
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
 List<clsvQxFuncModule_AgcEN> arrvQxFuncModule_AgcObjLst = null;
 try
 {
 arrvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(vQxFuncModule_AgcService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrvQxFuncModule_AgcObjLst);
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
 public List<clsvQxFuncModule_AgcEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
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
 List<clsvQxFuncModule_AgcEN> arrvQxFuncModule_AgcObjLst = null;
 try
 {
 arrvQxFuncModule_AgcObjLst = clsvQxFuncModule_AgcBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(vQxFuncModule_AgcService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 return arrvQxFuncModule_AgcObjLst;
 }

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet vQxFuncModule_Agc_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvQxFuncModule_AgcBL.GetDataSet(strWhereCond);
return objDS;
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet vQxFuncModule_Agc_GetTopDataSet(int intTopSize, string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvQxFuncModule_AgcBL.GetDataSet_Top(intTopSize, strWhereCond);
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
public DataSet vQxFuncModule_Agc_GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
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
DataSet objDS = clsvQxFuncModule_AgcBL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
}
}