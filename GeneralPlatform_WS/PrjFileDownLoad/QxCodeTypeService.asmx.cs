
//类名:QxCodeTypeService
 ///----------------------
 ///生成代码版本:2017.01.19.1
 ///生成日期:2017/01/23
 ///生成者:
 ///工程名称:统一平台
 ///工程ID:0014
 ///模块中文名:工程文件下载
 ///模块英文名:PrjFileDownLoad
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
 /// QxCodeTypeService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class QxCodeTypeService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet QxCodeType_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsQxCodeTypeBL.GetDataSet_QxCodeType(strWhereCond);
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
public DataSet QxCodeType_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsQxCodeTypeBL.GetDataSet_QxCodeTypeByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
[WebMethod]
public DataSet QxCodeType_GetDataSetV(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsQxCodeTypeBL.GetDataSet_QxCodeTypeV(strWhereCond);
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
public DataSet QxCodeType_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsQxCodeTypeBL.GetDataSet_QxCodeTypeVByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objQxCodeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool QxCodeType_GetQxCodeType(ref clsQxCodeTypeEN objQxCodeTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objQxCodeTypeEN", clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsQxCodeTypeBL.GetQxCodeType(ref objQxCodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "strQxCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsQxCodeTypeEN QxCodeType_GetQxCodeTypeByQxCodeTypeId(string strQxCodeTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeId", strQxCodeTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsQxCodeTypeEN objQxCodeTypeEN = clsQxCodeTypeBL.GetQxCodeTypeByQxCodeTypeId(strQxCodeTypeId);
return objQxCodeTypeEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objQxCodeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool QxCodeType_GetQxCodeTypeV(ref clsQxCodeTypeEN objQxCodeTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objQxCodeTypeEN", clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsQxCodeTypeBL.GetQxCodeType(ref objQxCodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsQxCodeTypeEN> QxCodeType_GetQxCodeTypeObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsQxCodeTypeEN> arrQxCodeTypeObjLst = clsQxCodeTypeBL.GetQxCodeTypeObjList(strWhereCond);
return arrQxCodeTypeObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string QxCodeType_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 string strQxCodeTypeId;
 try
 {
 strQxCodeTypeId = clsQxCodeTypeBL.GetFirstID_S(strWhereCond);
 return strQxCodeTypeId;
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
public clsQxCodeTypeEN QxCodeType_GetFirstQxCodeType_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsQxCodeTypeEN objQxCodeTypeEN = clsQxCodeTypeBL.GetFirstQxCodeType_S(strWhereCond);
 return objQxCodeTypeEN;
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
 /// <param name = "strQxCodeTypeId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetQxCodeTypeJSONObjByQxCodeTypeId(string strQxCodeTypeId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeId", strQxCodeTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsQxCodeTypeEN objQxCodeTypeEN = null;
 try
 {
 objQxCodeTypeEN = clsQxCodeTypeBL.GetQxCodeTypeByQxCodeTypeId(strQxCodeTypeId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(QxCodeTypeService:GetQxCodeTypeJSONObjByQxCodeTypeId)\r\n" + objException.Message);
 }
 clsQxCodeTypeEN_Sim objQxCodeTypeEN_Sim = clsQxCodeTypeBL.GetQxCodeTypeObj_SimFromQxCodeTypeObj(objQxCodeTypeEN);
 string strJSON = clsJSON.GetJsonFromObj<clsQxCodeTypeEN_Sim>(objQxCodeTypeEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstQxCodeTypeJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsQxCodeTypeEN objQxCodeTypeEN = null;
 try
 {
 objQxCodeTypeEN = clsQxCodeTypeBL.GetFirstQxCodeType_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(QxCodeTypeService:GetFirstQxCodeTypeJSONObj)\r\n" + objException.Message);
 }
 clsQxCodeTypeEN_Sim objQxCodeTypeEN_Sim = clsQxCodeTypeBL.GetQxCodeTypeObj_SimFromQxCodeTypeObj(objQxCodeTypeEN);
 string strJSON = clsJSON.GetJsonFromObj<clsQxCodeTypeEN_Sim>(objQxCodeTypeEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetQxCodeTypeJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsQxCodeTypeEN> arrQxCodeTypeObjLst = null;
 try
 {
 arrQxCodeTypeObjLst = clsQxCodeTypeBL.GetQxCodeTypeObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(QxCodeTypeService:GetQxCodeTypeJSONObjLst)\r\n" + objException.Message);
 }
 List<clsQxCodeTypeEN_Sim> arrQxCodeTypeObj_SimLst = clsQxCodeTypeBL.GetQxCodeTypeObj_SimLstFromQxCodeTypeObjLst(arrQxCodeTypeObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrQxCodeTypeObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool QxCodeType_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsQxCodeTypeBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "strQxCodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool QxCodeType_IsExist(string strQxCodeTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeId", strQxCodeTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsQxCodeTypeBL.IsExist(strQxCodeTypeId);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string QxCodeType_GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrQxCodeTypeId = clsQxCodeTypeBL.GetMaxStrId_S();
return strMaxstrQxCodeTypeId;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string QxCodeType_GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrQxCodeTypeId = clsQxCodeTypeBL.GetMaxStrIdByPrefix_S(strPrefix);
return strMaxstrQxCodeTypeId;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objQxCodeTypeEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxCodeType_AddNewRecordBySql2(clsQxCodeTypeEN objQxCodeTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objQxCodeTypeEN", clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsQxCodeTypeBL.AddNewRecordBySql2(objQxCodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strQxCodeTypeJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxCodeType_AddNewRecordBySql2ByJSON(string strQxCodeTypeJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeJSONObj", strQxCodeTypeJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsQxCodeTypeEN_Sim objQxCodeTypeEN_Sim = clsJSON.GetObjFromJson<clsQxCodeTypeEN_Sim>(strQxCodeTypeJSONObj);
clsQxCodeTypeEN objQxCodeTypeEN = clsQxCodeTypeBL.GetQxCodeTypeObjFromObj_Sim(objQxCodeTypeEN_Sim);
 try
 {
bool bolResult = clsQxCodeTypeBL.AddNewRecordBySql2(objQxCodeTypeEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来添加记录对象出错!(QxCodeTypeService:QxCodeType_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public string QxCodeType_AddNewRecordBySql2WithReturnKey(clsQxCodeTypeEN objQxCodeTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objQxCodeTypeEN", clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsQxCodeTypeBL.AddNewRecordBySql2WithReturnKey(objQxCodeTypeEN);
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
 /// <param name = "strQxCodeTypeENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool QxCodeType_AddNewRecordBySql_XML(string strQxCodeTypeENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeENObjXml", strQxCodeTypeENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsQxCodeTypeBL.AddNewRecordBySql_XML(strQxCodeTypeENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strQxCodeTypeJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxCodeType_UpdateBySql2(clsQxCodeTypeEN objQxCodeTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objQxCodeTypeEN", clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsQxCodeTypeBL.UpdateBySql2(objQxCodeTypeEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strQxCodeTypeJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool QxCodeType_UpdateBySql2ByJSON(string strQxCodeTypeJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeJSONObj", strQxCodeTypeJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsQxCodeTypeEN_Sim objQxCodeTypeEN_Sim = clsJSON.GetObjFromJson<clsQxCodeTypeEN_Sim>(strQxCodeTypeJSONObj);
clsQxCodeTypeEN objQxCodeTypeEN = clsQxCodeTypeBL.GetQxCodeTypeObjFromObj_Sim4Upd(objQxCodeTypeEN_Sim);
 try
 {
bool bolResult = clsQxCodeTypeBL.UpdateBySql2(objQxCodeTypeEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来修改记录对象出错!(QxCodeTypeService:QxCodeType_UpdateBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public bool QxCodeType_UpdateBySqlWithCondition(clsQxCodeTypeEN objQxCodeTypeEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objQxCodeTypeEN", clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = clsQxCodeTypeBL.UpdateBySqlWithCondition(objQxCodeTypeEN, strWhereCond);
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
 /// <param name = "strQxCodeTypeENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool QxCodeType_UpdateBySql_XML(string strQxCodeTypeENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeENObjXml", strQxCodeTypeENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsQxCodeTypeBL.UpdateBySql_XML(strQxCodeTypeENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "strQxCodeTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool QxCodeType_DelRecord(string strQxCodeTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeId", strQxCodeTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsQxCodeTypeBL.DelRecord(strQxCodeTypeId);
return bolResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrQxCodeTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public bool QxCodeType_DelQxCodeTypes(List<string> arrQxCodeTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrQxCodeTypeId", clsArray.GetSqlInStrByArray(arrQxCodeTypeId, true));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsQxCodeTypeBL.DelQxCodeTypes(arrQxCodeTypeId);
return bolResult;
}

 /// <summary>
 /// 功能:删除多条记录,带条件的删除
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int QxCodeType_DelQxCodeTypesByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsQxCodeTypeBL.DelQxCodeTypesByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsQxCodeTypeEN ExposeLogicClass(clsQxCodeTypeEN objQxCodeTypeEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objQxCodeTypeEN", clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objQxCodeTypeEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/23
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strQxCodeTypeId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsQxCodeTypeEN>对象XML串</returns>
[WebMethod]
public string QxCodeType_SerializeObjToXMLStr(string strQxCodeTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strQxCodeTypeId", strQxCodeTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsQxCodeTypeEN objQxCodeTypeEN = new clsQxCodeTypeEN(strQxCodeTypeId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsQxCodeTypeBL.GetQxCodeType(ref objQxCodeTypeEN);
strXmlString = clsQxCodeTypeBL.SerializeObjToXMLStr(objQxCodeTypeEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "QxCodeTypeService"); 
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
 /// <returns>返回一个<clsQxCodeTypeEN>对象列表XML串</returns>
[WebMethod]
public string QxCodeType_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsQxCodeTypeEN> lstQxCodeTypeENObjList = clsQxCodeTypeBL.GetQxCodeTypeObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsQxCodeTypeBL.SerializeObjListToXMLStr(lstQxCodeTypeENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "QxCodeTypeService");
}
return strXmlString;
}
}
}