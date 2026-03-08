
//类名:DepartmentTypeService
 ///----------------------
 ///生成代码版本:2017.01.19.1
 ///生成日期:2017/01/23
 ///生成者:
 ///工程名称:统一平台
 ///工程ID:0014
 ///模块中文名:系统参数
 ///模块英文名:SysPara
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
 /// DepartmentTypeService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class DepartmentTypeService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet DepartmentType_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentTypeBL.GetDataSet_DepartmentType(strWhereCond);
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
public DataSet DepartmentType_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentTypeBL.GetDataSet_DepartmentTypeByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
[WebMethod]
public DataSet DepartmentType_GetDataSetV(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentTypeBL.GetDataSet_DepartmentTypeV(strWhereCond);
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
public DataSet DepartmentType_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentTypeBL.GetDataSet_DepartmentTypeVByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objDepartmentTypeEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentType_GetDepartmentType(ref clsDepartmentTypeEN objDepartmentTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentTypeEN", clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentTypeBL.GetDepartmentType(ref objDepartmentTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "strDepartmentTypeId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsDepartmentTypeEN DepartmentType_GetDepartmentTypeByDepartmentTypeId(string strDepartmentTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeId", strDepartmentTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsDepartmentTypeEN objDepartmentTypeEN = clsDepartmentTypeBL.GetDepartmentTypeByDepartmentTypeId(strDepartmentTypeId);
return objDepartmentTypeEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objDepartmentTypeEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentType_GetDepartmentTypeV(ref clsDepartmentTypeEN objDepartmentTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentTypeEN", clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentTypeBL.GetDepartmentType(ref objDepartmentTypeEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsDepartmentTypeEN> DepartmentType_GetDepartmentTypeObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsDepartmentTypeEN> arrDepartmentTypeObjLst = clsDepartmentTypeBL.GetDepartmentTypeObjList(strWhereCond);
return arrDepartmentTypeObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string DepartmentType_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 string strDepartmentTypeId;
 try
 {
 strDepartmentTypeId = clsDepartmentTypeBL.GetFirstID_S(strWhereCond);
 return strDepartmentTypeId;
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
public clsDepartmentTypeEN DepartmentType_GetFirstDepartmentType_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsDepartmentTypeEN objDepartmentTypeEN = clsDepartmentTypeBL.GetFirstDepartmentType_S(strWhereCond);
 return objDepartmentTypeEN;
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
 /// <param name = "strDepartmentTypeId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetDepartmentTypeJSONObjByDepartmentTypeId(string strDepartmentTypeId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeId", strDepartmentTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsDepartmentTypeEN objDepartmentTypeEN = null;
 try
 {
 objDepartmentTypeEN = clsDepartmentTypeBL.GetDepartmentTypeByDepartmentTypeId(strDepartmentTypeId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(DepartmentTypeService:GetDepartmentTypeJSONObjByDepartmentTypeId)\r\n" + objException.Message);
 }
 clsDepartmentTypeEN_Sim objDepartmentTypeEN_Sim = clsDepartmentTypeBL.GetDepartmentTypeObj_SimFromDepartmentTypeObj(objDepartmentTypeEN);
 string strJSON = clsJSON.GetJsonFromObj<clsDepartmentTypeEN_Sim>(objDepartmentTypeEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstDepartmentTypeJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsDepartmentTypeEN objDepartmentTypeEN = null;
 try
 {
 objDepartmentTypeEN = clsDepartmentTypeBL.GetFirstDepartmentType_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(DepartmentTypeService:GetFirstDepartmentTypeJSONObj)\r\n" + objException.Message);
 }
 clsDepartmentTypeEN_Sim objDepartmentTypeEN_Sim = clsDepartmentTypeBL.GetDepartmentTypeObj_SimFromDepartmentTypeObj(objDepartmentTypeEN);
 string strJSON = clsJSON.GetJsonFromObj<clsDepartmentTypeEN_Sim>(objDepartmentTypeEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetDepartmentTypeJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsDepartmentTypeEN> arrDepartmentTypeObjLst = null;
 try
 {
 arrDepartmentTypeObjLst = clsDepartmentTypeBL.GetDepartmentTypeObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(DepartmentTypeService:GetDepartmentTypeJSONObjLst)\r\n" + objException.Message);
 }
 List<clsDepartmentTypeEN_Sim> arrDepartmentTypeObj_SimLst = clsDepartmentTypeBL.GetDepartmentTypeObj_SimLstFromDepartmentTypeObjLst(arrDepartmentTypeObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrDepartmentTypeObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool DepartmentType_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsDepartmentTypeBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "strDepartmentTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool DepartmentType_IsExist(string strDepartmentTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeId", strDepartmentTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsDepartmentTypeBL.IsExist(strDepartmentTypeId);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string DepartmentType_GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrDepartmentTypeId = clsDepartmentTypeBL.GetMaxStrId_S();
return strMaxstrDepartmentTypeId;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string DepartmentType_GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrDepartmentTypeId = clsDepartmentTypeBL.GetMaxStrIdByPrefix_S(strPrefix);
return strMaxstrDepartmentTypeId;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objDepartmentTypeEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentType_AddNewRecordBySql2(clsDepartmentTypeEN objDepartmentTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentTypeEN", clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentTypeBL.AddNewRecordBySql2(objDepartmentTypeEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strDepartmentTypeJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentType_AddNewRecordBySql2ByJSON(string strDepartmentTypeJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeJSONObj", strDepartmentTypeJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsDepartmentTypeEN_Sim objDepartmentTypeEN_Sim = clsJSON.GetObjFromJson<clsDepartmentTypeEN_Sim>(strDepartmentTypeJSONObj);
clsDepartmentTypeEN objDepartmentTypeEN = clsDepartmentTypeBL.GetDepartmentTypeObjFromObj_Sim(objDepartmentTypeEN_Sim);
 try
 {
bool bolResult = clsDepartmentTypeBL.AddNewRecordBySql2(objDepartmentTypeEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来添加记录对象出错!(DepartmentTypeService:DepartmentType_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public string DepartmentType_AddNewRecordBySql2WithReturnKey(clsDepartmentTypeEN objDepartmentTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentTypeEN", clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsDepartmentTypeBL.AddNewRecordBySql2WithReturnKey(objDepartmentTypeEN);
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
 /// <param name = "strDepartmentTypeENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool DepartmentType_AddNewRecordBySql_XML(string strDepartmentTypeENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeENObjXml", strDepartmentTypeENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentTypeBL.AddNewRecordBySql_XML(strDepartmentTypeENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strDepartmentTypeJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentType_UpdateBySql2(clsDepartmentTypeEN objDepartmentTypeEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentTypeEN", clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentTypeBL.UpdateBySql2(objDepartmentTypeEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strDepartmentTypeJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentType_UpdateBySql2ByJSON(string strDepartmentTypeJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeJSONObj", strDepartmentTypeJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsDepartmentTypeEN_Sim objDepartmentTypeEN_Sim = clsJSON.GetObjFromJson<clsDepartmentTypeEN_Sim>(strDepartmentTypeJSONObj);
clsDepartmentTypeEN objDepartmentTypeEN = clsDepartmentTypeBL.GetDepartmentTypeObjFromObj_Sim4Upd(objDepartmentTypeEN_Sim);
 try
 {
bool bolResult = clsDepartmentTypeBL.UpdateBySql2(objDepartmentTypeEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来修改记录对象出错!(DepartmentTypeService:DepartmentType_UpdateBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public bool DepartmentType_UpdateBySqlWithCondition(clsDepartmentTypeEN objDepartmentTypeEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentTypeEN", clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = clsDepartmentTypeBL.UpdateBySqlWithCondition(objDepartmentTypeEN, strWhereCond);
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
 /// <param name = "strDepartmentTypeENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool DepartmentType_UpdateBySql_XML(string strDepartmentTypeENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeENObjXml", strDepartmentTypeENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentTypeBL.UpdateBySql_XML(strDepartmentTypeENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "strDepartmentTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool DepartmentType_DelRecord(string strDepartmentTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeId", strDepartmentTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentTypeBL.DelRecord(strDepartmentTypeId);
return bolResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrDepartmentTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public bool DepartmentType_DelDepartmentTypes(List<string> arrDepartmentTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrDepartmentTypeId", clsArray.GetSqlInStrByArray(arrDepartmentTypeId, true));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentTypeBL.DelDepartmentTypes(arrDepartmentTypeId);
return bolResult;
}

 /// <summary>
 /// 功能:删除多条记录,带条件的删除
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int DepartmentType_DelDepartmentTypesByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsDepartmentTypeBL.DelDepartmentTypesByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsDepartmentTypeEN ExposeLogicClass(clsDepartmentTypeEN objDepartmentTypeEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentTypeEN", clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objDepartmentTypeEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/23
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strDepartmentTypeId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsDepartmentTypeEN>对象XML串</returns>
[WebMethod]
public string DepartmentType_SerializeObjToXMLStr(string strDepartmentTypeId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentTypeId", strDepartmentTypeId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsDepartmentTypeEN objDepartmentTypeEN = new clsDepartmentTypeEN(strDepartmentTypeId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsDepartmentTypeBL.GetDepartmentType(ref objDepartmentTypeEN);
strXmlString = clsDepartmentTypeBL.SerializeObjToXMLStr(objDepartmentTypeEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "DepartmentTypeService"); 
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
 /// <returns>返回一个<clsDepartmentTypeEN>对象列表XML串</returns>
[WebMethod]
public string DepartmentType_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsDepartmentTypeEN> lstDepartmentTypeENObjList = clsDepartmentTypeBL.GetDepartmentTypeObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsDepartmentTypeBL.SerializeObjListToXMLStr(lstDepartmentTypeENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "DepartmentTypeService");
}
return strXmlString;
}
}
}