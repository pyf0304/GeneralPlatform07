
//类名:ExportExcelSetService
 ///----------------------
 ///生成代码版本:2017.01.19.1
 ///生成日期:2017/01/23
 ///生成者:
 ///工程名称:统一平台
 ///工程ID:0014
 ///模块中文名:系统设置
 ///模块英文名:SystemSet
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.12.13.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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

namespace GeneralPlatform_WS
{
 /// <summary>
 /// ExportExcelSetService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class ExportExcelSetService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet ExportExcelSet_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsExportExcelSetBL.GetDataSet_ExportExcelSet(strWhereCond);
return objDS;
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lngMinNum">范围之最小值</param>
 /// <param name = "lngMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet ExportExcelSet_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsExportExcelSetBL.GetDataSet_ExportExcelSetByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
[WebMethod]
public DataSet ExportExcelSet_GetDataSetV(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsExportExcelSetBL.GetDataSet_ExportExcelSetV(strWhereCond);
return objDS;
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetVByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lngMinNum">范围之最小值</param>
 /// <param name = "lngMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet ExportExcelSet_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsExportExcelSetBL.GetDataSet_ExportExcelSetVByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_GetExportExcelSet(ref clsExportExcelSetEN objExportExcelSetEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcelSetEN", clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsExportExcelSetEN ExportExcelSet_GetExportExcelSetByid_ExportExcel4Users(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strid_ExportExcel4Users", strid_ExportExcel4Users);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetExportExcelSetByid_ExportExcel4Users(strid_ExportExcel4Users);
return objExportExcelSetEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_GetExportExcelSetV(ref clsExportExcelSetEN objExportExcelSetEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcelSetEN", clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsExportExcelSetEN> ExportExcelSet_GetExportExcelSetObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsExportExcelSetEN> arrExportExcelSetObjLst = clsExportExcelSetBL.GetExportExcelSetObjList(strWhereCond);
return arrExportExcelSetObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string ExportExcelSet_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 string strid_ExportExcel4Users;
 try
 {
 strid_ExportExcel4Users = clsExportExcelSetBL.GetFirstID_S(strWhereCond);
 return strid_ExportExcel4Users;
 }
 catch (Exception objException)
 {
 throw new Exception("获取First关键字出错!\r\n" + objException.Message);
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
[WebMethod]
public clsExportExcelSetEN ExportExcelSet_GetFirstExportExcelSet_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetFirstExportExcelSet_S(strWhereCond);
 return objExportExcelSetEN;
 }
 catch (Exception objException)
 {
 throw new Exception("获取First记录对象出错!\r\n" + objException.Message);
 }
}

   /// <summary>
 /// 获取当前关键字的记录对象,用对象的JSON形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjByKeyId_S)
 /// </summary>
 /// <param name = "strExportExcelSetId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetExportExcelSetJSONObjByid_ExportExcel4Users(string strid_ExportExcel4Users)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strid_ExportExcel4Users", strid_ExportExcel4Users);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsExportExcelSetEN objExportExcelSetEN = null;
 try
 {
 objExportExcelSetEN = clsExportExcelSetBL.GetExportExcelSetByid_ExportExcel4Users(strid_ExportExcel4Users);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(ExportExcelSetService:GetExportExcelSetJSONObjByid_ExportExcel4Users)\r\n" + objException.Message);
 }
 clsExportExcelSetEN_Sim objExportExcelSetEN_Sim = clsExportExcelSetBL.GetExportExcelSetObj_SimFromExportExcelSetObj(objExportExcelSetEN);
 string strJSON = clsJSON.GetJsonFromObj<clsExportExcelSetEN_Sim>(objExportExcelSetEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstExportExcelSetJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsExportExcelSetEN objExportExcelSetEN = null;
 try
 {
 objExportExcelSetEN = clsExportExcelSetBL.GetFirstExportExcelSet_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(ExportExcelSetService:GetFirstExportExcelSetJSONObj)\r\n" + objException.Message);
 }
 clsExportExcelSetEN_Sim objExportExcelSetEN_Sim = clsExportExcelSetBL.GetExportExcelSetObj_SimFromExportExcelSetObj(objExportExcelSetEN);
 string strJSON = clsJSON.GetJsonFromObj<clsExportExcelSetEN_Sim>(objExportExcelSetEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetExportExcelSetJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsExportExcelSetEN> arrExportExcelSetObjLst = null;
 try
 {
 arrExportExcelSetObjLst = clsExportExcelSetBL.GetExportExcelSetObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(ExportExcelSetService:GetExportExcelSetJSONObjLst)\r\n" + objException.Message);
 }
 List<clsExportExcelSetEN_Sim> arrExportExcelSetObj_SimLst = clsExportExcelSetBL.GetExportExcelSetObj_SimLstFromExportExcelSetObjLst(arrExportExcelSetObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrExportExcelSetObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool ExportExcelSet_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsExportExcelSetBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool ExportExcelSet_IsExist(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strid_ExportExcel4Users", strid_ExportExcel4Users);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsExportExcelSetBL.IsExist(strid_ExportExcel4Users);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string ExportExcelSet_GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrid_ExportExcel4Users = clsExportExcelSetBL.GetMaxStrId_S();
return strMaxstrid_ExportExcel4Users;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string ExportExcelSet_GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrid_ExportExcel4Users = clsExportExcelSetBL.GetMaxStrIdByPrefix_S(strPrefix);
return strMaxstrid_ExportExcel4Users;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objExportExcelSetEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_AddNewRecordBySql2(clsExportExcelSetEN objExportExcelSetEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcelSetEN", clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strExportExcelSetJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_AddNewRecordBySql2ByJSON(string strExportExcelSetJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strExportExcelSetJSONObj", strExportExcelSetJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsExportExcelSetEN_Sim objExportExcelSetEN_Sim = clsJSON.GetObjFromJson<clsExportExcelSetEN_Sim>(strExportExcelSetJSONObj);
clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetExportExcelSetObjFromObj_Sim(objExportExcelSetEN_Sim);
 try
 {
bool bolResult = clsExportExcelSetBL.AddNewRecordBySql2(objExportExcelSetEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来添加记录对象出错!(ExportExcelSetService:ExportExcelSet_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public string ExportExcelSet_AddNewRecordBySql2WithReturnKey(clsExportExcelSetEN objExportExcelSetEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcelSetEN", clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsExportExcelSetBL.AddNewRecordBySql2WithReturnKey(objExportExcelSetEN);
return strKey;
}
catch (Exception objException)
{
throw new Exception("添加记录出错!\r\n" + objException.Message);
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strExportExcelSetENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool ExportExcelSet_AddNewRecordBySql_XML(string strExportExcelSetENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strExportExcelSetENObjXml", strExportExcelSetENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcelSetBL.AddNewRecordBySql_XML(strExportExcelSetENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strExportExcelSetJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_UpdateBySql2(clsExportExcelSetEN objExportExcelSetEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcelSetEN", clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcelSetBL.UpdateBySql2(objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strExportExcelSetJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcelSet_UpdateBySql2ByJSON(string strExportExcelSetJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strExportExcelSetJSONObj", strExportExcelSetJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsExportExcelSetEN_Sim objExportExcelSetEN_Sim = clsJSON.GetObjFromJson<clsExportExcelSetEN_Sim>(strExportExcelSetJSONObj);
clsExportExcelSetEN objExportExcelSetEN = clsExportExcelSetBL.GetExportExcelSetObjFromObj_Sim4Upd(objExportExcelSetEN_Sim);
 try
 {
bool bolResult = clsExportExcelSetBL.UpdateBySql2(objExportExcelSetEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来修改记录对象出错!(ExportExcelSetService:ExportExcelSet_UpdateBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public bool ExportExcelSet_UpdateBySqlWithCondition(clsExportExcelSetEN objExportExcelSetEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcelSetEN", clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = clsExportExcelSetBL.UpdateBySqlWithCondition(objExportExcelSetEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("修改记录出错!\r\n" + objException.Message);
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strExportExcelSetENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool ExportExcelSet_UpdateBySql_XML(string strExportExcelSetENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strExportExcelSetENObjXml", strExportExcelSetENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcelSetBL.UpdateBySql_XML(strExportExcelSetENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool ExportExcelSet_DelRecord(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strid_ExportExcel4Users", strid_ExportExcel4Users);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcelSetBL.DelRecord(strid_ExportExcel4Users);
return bolResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrid_ExportExcel4UsersLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public bool ExportExcelSet_DelExportExcelSets(List<string> arrid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrid_ExportExcel4Users", clsArray.GetSqlInStrByArray(arrid_ExportExcel4Users, true));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcelSetBL.DelExportExcelSets(arrid_ExportExcel4Users);
return bolResult;
}

 /// <summary>
 /// 功能:删除多条记录,带条件的删除
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int ExportExcelSet_DelExportExcelSetsByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsExportExcelSetBL.DelExportExcelSetsByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsExportExcelSetEN ExposeLogicClass(clsExportExcelSetEN objExportExcelSetEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcelSetEN", clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objExportExcelSetEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/23
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsExportExcelSetEN>对象XML串</returns>
[WebMethod]
public string ExportExcelSet_SerializeObjToXMLStr(string strid_ExportExcel4Users)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strid_ExportExcel4Users", strid_ExportExcel4Users);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN(strid_ExportExcel4Users);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsExportExcelSetBL.GetExportExcelSet(ref objExportExcelSetEN);
strXmlString = clsExportExcelSetBL.SerializeObjToXMLStr(objExportExcelSetEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "ExportExcelSetService"); 
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:2017/01/23
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjListToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsExportExcelSetEN>对象列表XML串</returns>
[WebMethod]
public string ExportExcelSet_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsExportExcelSetEN> lstExportExcelSetENObjList = clsExportExcelSetBL.GetExportExcelSetObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsExportExcelSetBL.SerializeObjListToXMLStr(lstExportExcelSetENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "ExportExcelSetService");
}
return strXmlString;
}
}
}