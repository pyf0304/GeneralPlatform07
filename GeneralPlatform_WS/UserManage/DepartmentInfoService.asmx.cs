
//类名:DepartmentInfoService
 ///----------------------
 ///生成代码版本:2017.01.19.1
 ///生成日期:2017/01/23
 ///生成者:
 ///工程名称:统一平台
 ///工程ID:0014
 ///模块中文名:用户管理
 ///模块英文名:UserManage
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
 /// DepartmentInfoService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class DepartmentInfoService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet DepartmentInfo_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentInfoBL.GetDataSet_DepartmentInfo(strWhereCond);
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
public DataSet DepartmentInfo_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentInfoBL.GetDataSet_DepartmentInfoByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
[WebMethod]
public DataSet DepartmentInfo_GetDataSetV(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentInfoBL.GetDataSet_DepartmentInfoV(strWhereCond);
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
public DataSet DepartmentInfo_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsDepartmentInfoBL.GetDataSet_DepartmentInfoVByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentInfo_GetDepartmentInfo(ref clsDepartmentInfoEN objDepartmentInfoEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentInfoEN", clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentInfoBL.GetDepartmentInfo(ref objDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsDepartmentInfoEN DepartmentInfo_GetDepartmentInfoByDepartmentId(string strDepartmentId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentId", strDepartmentId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsDepartmentInfoEN objDepartmentInfoEN = clsDepartmentInfoBL.GetDepartmentInfoByDepartmentId(strDepartmentId);
return objDepartmentInfoEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentInfo_GetDepartmentInfoV(ref clsDepartmentInfoEN objDepartmentInfoEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentInfoEN", clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentInfoBL.GetDepartmentInfo(ref objDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsDepartmentInfoEN> DepartmentInfo_GetDepartmentInfoObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsDepartmentInfoEN> arrDepartmentInfoObjLst = clsDepartmentInfoBL.GetDepartmentInfoObjList(strWhereCond);
return arrDepartmentInfoObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string DepartmentInfo_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 string strDepartmentId;
 try
 {
 strDepartmentId = clsDepartmentInfoBL.GetFirstID_S(strWhereCond);
 return strDepartmentId;
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
public clsDepartmentInfoEN DepartmentInfo_GetFirstDepartmentInfo_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsDepartmentInfoEN objDepartmentInfoEN = clsDepartmentInfoBL.GetFirstDepartmentInfo_S(strWhereCond);
 return objDepartmentInfoEN;
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
 /// <param name = "strDepartmentInfoId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetDepartmentInfoJSONObjByDepartmentId(string strDepartmentId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentId", strDepartmentId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsDepartmentInfoEN objDepartmentInfoEN = null;
 try
 {
 objDepartmentInfoEN = clsDepartmentInfoBL.GetDepartmentInfoByDepartmentId(strDepartmentId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(DepartmentInfoService:GetDepartmentInfoJSONObjByDepartmentId)\r\n" + objException.Message);
 }
 clsDepartmentInfoEN_Sim objDepartmentInfoEN_Sim = clsDepartmentInfoBL.GetDepartmentInfoObj_SimFromDepartmentInfoObj(objDepartmentInfoEN);
 string strJSON = clsJSON.GetJsonFromObj<clsDepartmentInfoEN_Sim>(objDepartmentInfoEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstDepartmentInfoJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsDepartmentInfoEN objDepartmentInfoEN = null;
 try
 {
 objDepartmentInfoEN = clsDepartmentInfoBL.GetFirstDepartmentInfo_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(DepartmentInfoService:GetFirstDepartmentInfoJSONObj)\r\n" + objException.Message);
 }
 clsDepartmentInfoEN_Sim objDepartmentInfoEN_Sim = clsDepartmentInfoBL.GetDepartmentInfoObj_SimFromDepartmentInfoObj(objDepartmentInfoEN);
 string strJSON = clsJSON.GetJsonFromObj<clsDepartmentInfoEN_Sim>(objDepartmentInfoEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetDepartmentInfoJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsDepartmentInfoEN> arrDepartmentInfoObjLst = null;
 try
 {
 arrDepartmentInfoObjLst = clsDepartmentInfoBL.GetDepartmentInfoObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(DepartmentInfoService:GetDepartmentInfoJSONObjLst)\r\n" + objException.Message);
 }
 List<clsDepartmentInfoEN_Sim> arrDepartmentInfoObj_SimLst = clsDepartmentInfoBL.GetDepartmentInfoObj_SimLstFromDepartmentInfoObjLst(arrDepartmentInfoObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrDepartmentInfoObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool DepartmentInfo_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsDepartmentInfoBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool DepartmentInfo_IsExist(string strDepartmentId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentId", strDepartmentId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsDepartmentInfoBL.IsExist(strDepartmentId);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string DepartmentInfo_GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrDepartmentId = clsDepartmentInfoBL.GetMaxStrId_S();
return strMaxstrDepartmentId;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string DepartmentInfo_GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrDepartmentId = clsDepartmentInfoBL.GetMaxStrIdByPrefix_S(strPrefix);
return strMaxstrDepartmentId;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentInfo_AddNewRecordBySql2(clsDepartmentInfoEN objDepartmentInfoEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentInfoEN", clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentInfoBL.AddNewRecordBySql2(objDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strDepartmentInfoJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentInfo_AddNewRecordBySql2ByJSON(string strDepartmentInfoJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentInfoJSONObj", strDepartmentInfoJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsDepartmentInfoEN_Sim objDepartmentInfoEN_Sim = clsJSON.GetObjFromJson<clsDepartmentInfoEN_Sim>(strDepartmentInfoJSONObj);
clsDepartmentInfoEN objDepartmentInfoEN = clsDepartmentInfoBL.GetDepartmentInfoObjFromObj_Sim(objDepartmentInfoEN_Sim);
 try
 {
bool bolResult = clsDepartmentInfoBL.AddNewRecordBySql2(objDepartmentInfoEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来添加记录对象出错!(DepartmentInfoService:DepartmentInfo_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public string DepartmentInfo_AddNewRecordBySql2WithReturnKey(clsDepartmentInfoEN objDepartmentInfoEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentInfoEN", clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsDepartmentInfoBL.AddNewRecordBySql2WithReturnKey(objDepartmentInfoEN);
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
 /// <param name = "strDepartmentInfoENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool DepartmentInfo_AddNewRecordBySql_XML(string strDepartmentInfoENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentInfoENObjXml", strDepartmentInfoENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentInfoBL.AddNewRecordBySql_XML(strDepartmentInfoENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strDepartmentInfoJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentInfo_UpdateBySql2(clsDepartmentInfoEN objDepartmentInfoEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentInfoEN", clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsDepartmentInfoBL.UpdateBySql2(objDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strDepartmentInfoJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool DepartmentInfo_UpdateBySql2ByJSON(string strDepartmentInfoJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentInfoJSONObj", strDepartmentInfoJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsDepartmentInfoEN_Sim objDepartmentInfoEN_Sim = clsJSON.GetObjFromJson<clsDepartmentInfoEN_Sim>(strDepartmentInfoJSONObj);
clsDepartmentInfoEN objDepartmentInfoEN = clsDepartmentInfoBL.GetDepartmentInfoObjFromObj_Sim4Upd(objDepartmentInfoEN_Sim);
 try
 {
bool bolResult = clsDepartmentInfoBL.UpdateBySql2(objDepartmentInfoEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来修改记录对象出错!(DepartmentInfoService:DepartmentInfo_UpdateBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public bool DepartmentInfo_UpdateBySqlWithCondition(clsDepartmentInfoEN objDepartmentInfoEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentInfoEN", clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = clsDepartmentInfoBL.UpdateBySqlWithCondition(objDepartmentInfoEN, strWhereCond);
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
 /// <param name = "strDepartmentInfoENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool DepartmentInfo_UpdateBySql_XML(string strDepartmentInfoENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentInfoENObjXml", strDepartmentInfoENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentInfoBL.UpdateBySql_XML(strDepartmentInfoENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool DepartmentInfo_DelRecord(string strDepartmentId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentId", strDepartmentId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentInfoBL.DelRecord(strDepartmentId);
return bolResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrDepartmentIdLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public bool DepartmentInfo_DelDepartmentInfos(List<string> arrDepartmentId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrDepartmentId", clsArray.GetSqlInStrByArray(arrDepartmentId, true));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsDepartmentInfoBL.DelDepartmentInfos(arrDepartmentId);
return bolResult;
}

 /// <summary>
 /// 功能:删除多条记录,带条件的删除
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int DepartmentInfo_DelDepartmentInfosByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsDepartmentInfoBL.DelDepartmentInfosByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsDepartmentInfoEN ExposeLogicClass(clsDepartmentInfoEN objDepartmentInfoEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objDepartmentInfoEN", clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objDepartmentInfoEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/23
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strDepartmentId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsDepartmentInfoEN>对象XML串</returns>
[WebMethod]
public string DepartmentInfo_SerializeObjToXMLStr(string strDepartmentId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strDepartmentId", strDepartmentId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN(strDepartmentId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsDepartmentInfoBL.GetDepartmentInfo(ref objDepartmentInfoEN);
strXmlString = clsDepartmentInfoBL.SerializeObjToXMLStr(objDepartmentInfoEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "DepartmentInfoService"); 
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
 /// <returns>返回一个<clsDepartmentInfoEN>对象列表XML串</returns>
[WebMethod]
public string DepartmentInfo_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsDepartmentInfoEN> lstDepartmentInfoENObjList = clsDepartmentInfoBL.GetDepartmentInfoObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsDepartmentInfoBL.SerializeObjListToXMLStr(lstDepartmentInfoENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "DepartmentInfoService");
}
return strXmlString;
}
}
}