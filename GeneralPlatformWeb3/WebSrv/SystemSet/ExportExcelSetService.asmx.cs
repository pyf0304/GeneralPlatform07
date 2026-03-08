
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:ExportExcelSetService
 表名:ExportExcelSet(00140065)
 生成代码版本:2020.02.10.2
 生成日期:2020/02/13 22:39:35
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:统一平台
 工程ID:0014
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:系统设置
 模块英文名:SystemSet
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
 /// ExportExcelSetService 的摘要说明
 /// (AutoGCLib.WS_Srv4CSharp:GeneCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class ExportExcelSetService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_GetExportExcelSet(ref clsExportExcelSetEN objExportExcelSetEN)
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
["objExportExcelSetEN"] = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsExportExcelSetEN ExportExcelSet_GetObjByid_ExportExcel4Users(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strid_ExportExcel4Users"] = strid_ExportExcel4Users
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetObjByid_ExportExcel4Users(strid_ExportExcel4Users);
return objExportExcelSetEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_GetExportExcelSetV(ref clsExportExcelSetEN objExportExcelSetEN)
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
["objExportExcelSetEN"] = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsExportExcelSetEN> ExportExcelSet_GetObjLst(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsExportExcelSetEN> arrExportExcelSetObjLst = clsExportExcelSetBL.GetObjLst(strWhereCond);
return arrExportExcelSetObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsExportExcelSetEN> ExportExcelSet_GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsExportExcelSetEN> arrExportExcelSetObjLst = clsExportExcelSetBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
return arrExportExcelSetObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string ExportExcelSet_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 string strid_ExportExcel4Users;
 try
 {
 strid_ExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(strWhereCond);
 return strid_ExportExcel4Users;
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
public clsExportExcelSetEN ExportExcelSet_GetFirstObj_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetFirstObj_S(strWhereCond);
 return objExportExcelSetEN;
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
 /// <param name = "strExportExcelSetId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetJSONObjByid_ExportExcel4Users(string strid_ExportExcel4Users)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strid_ExportExcel4Users"] = strid_ExportExcel4Users
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 clsExportExcelSetEN objExportExcelSetEN = null;
 try
 {
 objExportExcelSetEN = clsExportExcelSetBL.GetObjByid_ExportExcel4Users(strid_ExportExcel4Users);
 if (objExportExcelSetEN == null) return "";
 }
 catch (Exception objException)
 {
string strMsg = "根据关键字获取对象出错!(ExportExcelSetService:GetJSONObjByid_ExportExcel4Users)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsExportExcelSetEN>(objExportExcelSetEN);
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
 clsExportExcelSetEN objExportExcelSetEN = null;
 try
 {
 objExportExcelSetEN = clsExportExcelSetBL.GetFirstObj_S(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取第一条记录的对象出错!(ExportExcelSetService:GetFirstJSONObj)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObj<clsExportExcelSetEN>(objExportExcelSetEN);
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
 List<clsExportExcelSetEN> arrExportExcelSetObjLst = null;
 try
 {
 arrExportExcelSetObjLst = clsExportExcelSetBL.GetObjLst(strWhereCond);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(ExportExcelSetService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrExportExcelSetObjLst);
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
 List<clsExportExcelSetEN> arrExportExcelSetObjLst = null;
 try
 {
 arrExportExcelSetObjLst = clsExportExcelSetBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取的对象列表出错!(ExportExcelSetService:GetJSONObjLst)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrExportExcelSetObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool ExportExcelSet_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsExportExcelSetBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_IsExist)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool ExportExcelSet_IsExist(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strid_ExportExcel4Users"] = strid_ExportExcel4Users
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsExportExcelSetBL.IsExist(strid_ExportExcel4Users);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string ExportExcelSet_GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrid_ExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
return strMaxstrid_ExportExcel4Users;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string ExportExcelSet_GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrid_ExportExcel4Users = clsExportExcelSetBL.GetMaxStrIdByPrefix_S(strPrefix);
return strMaxstrid_ExportExcel4Users;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objExportExcelSetEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_AddNewRecordBySql2(clsExportExcelSetEN objExportExcelSetEN)
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
["objExportExcelSetEN"] = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = objExportExcelSetEN.AddNewRecord();
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strExportExcelSetJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_AddNewRecordBySql2ByJSON(string strExportExcelSetJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strExportExcelSetJSONObj"] = strExportExcelSetJSONObj
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clsExportExcelSetEN objExportExcelSetEN = clsJSON.GetObjFromJson<clsExportExcelSetEN>(strExportExcelSetJSONObj);
bool bolResult = objExportExcelSetEN.AddNewRecord();
return bolResult;
 }
 catch (Exception objException)
 {
string strMsg = "通过JSON对象来添加记录对象出错!(ExportExcelSetService:ExportExcelSet_AddNewRecordBySql2ByJSON)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.WS_Srv4CSharp:Gen_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strExportExcelSetObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool ExportExcelSet_AddNewRecordBySql_XML(string strExportExcelSetObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strExportExcelSetObjXml"] = strExportExcelSetObjXml
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcelSetBL.AddNewRecordBySql_XML(strExportExcelSetObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strExportExcelSetJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_UpdateBySql2(clsExportExcelSetEN objExportExcelSetEN)
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
["objExportExcelSetEN"] = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = objExportExcelSetEN.Update();
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AutoGCLib.WS_Srv4CSharp:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strExportExcelSetJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_UpdateBySql2ByJSON(string strExportExcelSetJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strExportExcelSetJSONObj"] = strExportExcelSetJSONObj
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
clsExportExcelSetEN objExportExcelSetEN = clsJSON.GetObjFromJson<clsExportExcelSetEN>(strExportExcelSetJSONObj);
clsExportExcelSetBL.SetUpdFlag(objExportExcelSetEN);
bool bolResult = objExportExcelSetEN.Update();
return bolResult;
 }
 catch (Exception objException)
 {
string strMsg = "通过JSON对象来修改记录对象出错!(ExportExcelSetService:ExportExcelSet_UpdateBySql2ByJSON)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
}

 /// <summary>
 /// 根据条件修改记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objExportExcelSetEN">JSON对象字符串</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回是否成功?</returns>
[WebMethod]
public bool ExportExcelSet_UpdateBySqlWithCondition(clsExportExcelSetEN objExportExcelSetEN, string strWhereCond)
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
["objExportExcelSetEN"] = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN),
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = objExportExcelSetEN.UpdateWithCondition(strWhereCond);
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
 /// <param name = "strExportExcelSetObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool ExportExcelSet_UpdateBySql_XML(string strExportExcelSetObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strExportExcelSetObjXml"] = strExportExcelSetObjXml
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcelSetBL.UpdateBySql_XML(strExportExcelSetObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_DelRecord)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
[WebMethod]
public int ExportExcelSet_DelRecord(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strid_ExportExcel4Users"] = strid_ExportExcel4Users
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsExportExcelSetBL.DelRecord(strid_ExportExcel4Users);
return intRecNum;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrid_ExportExcel4UsersLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
[WebMethod]
public int ExportExcelSet_DelExportExcelSets(string strJSON4Keys)
{
List<string> arrid_ExportExcel4Users = clsJSON.GetObjLstFromJson<string>(strJSON4Keys);
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["arrid_ExportExcel4Users"] = clsArray.GetSqlInStrByArray(arrid_ExportExcel4Users, true)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsExportExcelSetBL.DelExportExcelSets(arrid_ExportExcel4Users);
return intRecNum;
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.WS_Srv4CSharp:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int ExportExcelSet_DelExportExcelSetsByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsExportExcelSetBL.DelExportExcelSetsByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsExportExcelSetEN ExposeLogicClass(clsExportExcelSetEN objExportExcelSetEN)
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
["objExportExcelSetEN"] = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN)
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
return objExportExcelSetEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:20200213223935
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsExportExcelSetEN>对象XML串</returns>
[WebMethod]
public string ExportExcelSet_SerializeObjToXMLStr(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strid_ExportExcel4Users"] = strid_ExportExcel4Users
 };
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN(strid_ExportExcel4Users);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
strXmlString = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "ExportExcelSetService"); 
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223935
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsExportExcelSetEN>对象列表XML串</returns>
[WebMethod]
public string ExportExcelSet_SerializeObjLstToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsExportExcelSetEN> lstExportExcelSetObjLst = clsExportExcelSetBL.GetObjLst(strWhereCond);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsExportExcelSetBL.SerializeObjLstToXMLStr(lstExportExcelSetObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "ExportExcelSetService");
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:20200213223935
 /// (AutoGCLib.WS_Srv4CSharp:Gen_Ws_SerializeTopObjLstToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsExportExcelSetEN>对象列表XML串</returns>
[WebMethod]
public string ExportExcelSet_SerializeTopObjLstToXMLStr(int intTopSize, string strWhereCond, string strOrderBy = "")
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsExportExcelSetEN> lstExportExcelSetObjLst = clsExportExcelSetBL.GetTopObjLst(intTopSize, strWhereCond, strOrderBy);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsExportExcelSetBL.SerializeObjLstToXMLStr(lstExportExcelSetObjLst);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "ExportExcelSetService");
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
 List<clsExportExcelSetEN> arrExportExcelSetObjLst = null;
 try
 {
 arrExportExcelSetObjLst = clsExportExcelSetBL.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件分页获取的对象列表出错!(ExportExcelSetService:GetJSONObjLstByPager)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrExportExcelSetObjLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:获取某一条件的记录数
 /// (AutoGCLib.WS_Srv4CSharp:Gen_funGetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>某一条件的记录数</returns>
[WebMethod]
public int ExportExcelSet_funGetRecCountByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intCount = clsExportExcelSetBL.GetRecCountByCond(strWhereCond);
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
string[] sstrid_ExportExcel4Users = strKeyIdLst.Trim().Split(',');
List <string> arrid_ExportExcel4Users = new List<string>();
foreach (string strid_ExportExcel4Users in sstrid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == false)
{
arrid_ExportExcel4Users.Add(strid_ExportExcel4Users);
}
}
int intRecNum = clsExportExcelSetBL.DelExportExcelSets(arrid_ExportExcel4Users);
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
 List<clsExportExcelSetEN> arrExportExcelSetObjLst = null;
 try
 {
 arrExportExcelSetObjLst = clsExportExcelSetBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(ExportExcelSetService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 string strJSON = clsJSON.GetJsonFromObjLst(arrExportExcelSetObjLst);
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
 public List<clsExportExcelSetEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
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
 List<clsExportExcelSetEN> arrExportExcelSetObjLst = null;
 try
 {
 arrExportExcelSetObjLst = clsExportExcelSetBL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
 }
 catch (Exception objException)
 {
string strMsg = "根据条件获取指定范围内的对象列表出错!(ExportExcelSetService:GetJSONObjLstByRange)\r\n" + objException.Message;
clsPubVar_WS.objLog.WriteDebugLog(strMsg);
 throw new Exception(strMsg);
 }
 return arrExportExcelSetObjLst;
 }

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet ExportExcelSet_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsExportExcelSetBL.GetDataSet(strWhereCond);
return objDS;
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.WS_Srv4CSharp:Gen_GetTopDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet ExportExcelSet_GetTopDataSet(int intTopSize, string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsExportExcelSetBL.GetDataSet_Top(intTopSize, strWhereCond);
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
public DataSet ExportExcelSet_GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
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
DataSet objDS = clsExportExcelSetBL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
}
}