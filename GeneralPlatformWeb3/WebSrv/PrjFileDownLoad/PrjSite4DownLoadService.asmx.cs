
//类名:PrjSite4DownLoadService
 ///----------------------
 ///生成代码版本:2017.01.19.1
 ///生成日期:2017/01/27
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
 /// PrjSite4DownLoadService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class PrjSite4DownLoadService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet PrjSite4DownLoad_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsPrjSite4DownLoadBL.GetDataSet_PrjSite4DownLoad(strWhereCond);
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
public DataSet PrjSite4DownLoad_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsPrjSite4DownLoadBL.GetDataSet_PrjSite4DownLoadByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
[WebMethod]
public DataSet PrjSite4DownLoad_GetDataSetV(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsPrjSite4DownLoadBL.GetDataSet_PrjSite4DownLoadV(strWhereCond);
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
public DataSet PrjSite4DownLoad_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsPrjSite4DownLoadBL.GetDataSet_PrjSite4DownLoadVByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool PrjSite4DownLoad_GetPrjSite4DownLoad(ref clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objPrjSite4DownLoadEN", clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsPrjSite4DownLoadBL.GetPrjSite4DownLoad(ref objPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsPrjSite4DownLoadEN PrjSite4DownLoad_GetPrjSite4DownLoadByPrjSiteId(string strPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadByPrjSiteId(strPrjSiteId);
return objPrjSite4DownLoadEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool PrjSite4DownLoad_GetPrjSite4DownLoadV(ref clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objPrjSite4DownLoadEN", clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsPrjSite4DownLoadBL.GetPrjSite4DownLoad(ref objPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsPrjSite4DownLoadEN> PrjSite4DownLoad_GetPrjSite4DownLoadObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsPrjSite4DownLoadEN> arrPrjSite4DownLoadObjLst = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObjList(strWhereCond);
return arrPrjSite4DownLoadObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string PrjSite4DownLoad_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 string strPrjSiteId;
 try
 {
 strPrjSiteId = clsPrjSite4DownLoadBL.GetFirstID_S(strWhereCond);
 return strPrjSiteId;
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
public clsPrjSite4DownLoadEN PrjSite4DownLoad_GetFirstPrjSite4DownLoad_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = clsPrjSite4DownLoadBL.GetFirstPrjSite4DownLoad_S(strWhereCond);
 return objPrjSite4DownLoadEN;
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
 /// <param name = "strPrjSite4DownLoadId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetPrjSite4DownLoadJSONObjByPrjSiteId(string strPrjSiteId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = null;
 try
 {
 objPrjSite4DownLoadEN = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadByPrjSiteId(strPrjSiteId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(PrjSite4DownLoadService:GetPrjSite4DownLoadJSONObjByPrjSiteId)\r\n" + objException.Message);
 }
 clsPrjSite4DownLoadEN_Sim objPrjSite4DownLoadEN_Sim = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObj_SimFromPrjSite4DownLoadObj(objPrjSite4DownLoadEN);
 string strJSON = clsJSON.GetJsonFromObj<clsPrjSite4DownLoadEN_Sim>(objPrjSite4DownLoadEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstPrjSite4DownLoadJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = null;
 try
 {
 objPrjSite4DownLoadEN = clsPrjSite4DownLoadBL.GetFirstPrjSite4DownLoad_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(PrjSite4DownLoadService:GetFirstPrjSite4DownLoadJSONObj)\r\n" + objException.Message);
 }
 clsPrjSite4DownLoadEN_Sim objPrjSite4DownLoadEN_Sim = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObj_SimFromPrjSite4DownLoadObj(objPrjSite4DownLoadEN);
 string strJSON = clsJSON.GetJsonFromObj<clsPrjSite4DownLoadEN_Sim>(objPrjSite4DownLoadEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetPrjSite4DownLoadJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsPrjSite4DownLoadEN> arrPrjSite4DownLoadObjLst = null;
 try
 {
 arrPrjSite4DownLoadObjLst = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(PrjSite4DownLoadService:GetPrjSite4DownLoadJSONObjLst)\r\n" + objException.Message);
 }
 List<clsPrjSite4DownLoadEN_Sim> arrPrjSite4DownLoadObj_SimLst = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObj_SimLstFromPrjSite4DownLoadObjLst(arrPrjSite4DownLoadObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrPrjSite4DownLoadObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool PrjSite4DownLoad_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsPrjSite4DownLoadBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool PrjSite4DownLoad_IsExist(string strPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsPrjSite4DownLoadBL.IsExist(strPrjSiteId);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string PrjSite4DownLoad_GetMaxStrId()
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrPrjSiteId = clsPrjSite4DownLoadBL.GetMaxStrId_S();
return strMaxstrPrjSiteId;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
[WebMethod]
public string PrjSite4DownLoad_GetMaxStrIdByPrefix(string strPrefix)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strMaxstrPrjSiteId = clsPrjSite4DownLoadBL.GetMaxStrIdByPrefix_S(strPrefix);
return strMaxstrPrjSiteId;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objPrjSite4DownLoadEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool PrjSite4DownLoad_AddNewRecordBySql2(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objPrjSite4DownLoadEN", clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsPrjSite4DownLoadBL.AddNewRecordBySql2(objPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strPrjSite4DownLoadJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool PrjSite4DownLoad_AddNewRecordBySql2ByJSON(string strPrjSite4DownLoadJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSite4DownLoadJSONObj", strPrjSite4DownLoadJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsPrjSite4DownLoadEN_Sim objPrjSite4DownLoadEN_Sim = clsJSON.GetObjFromJson<clsPrjSite4DownLoadEN_Sim>(strPrjSite4DownLoadJSONObj);
clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObjFromObj_Sim(objPrjSite4DownLoadEN_Sim);
 try
 {
bool bolResult = clsPrjSite4DownLoadBL.AddNewRecordBySql2(objPrjSite4DownLoadEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来添加记录对象出错!(PrjSite4DownLoadService:PrjSite4DownLoad_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public string PrjSite4DownLoad_AddNewRecordBySql2WithReturnKey(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objPrjSite4DownLoadEN", clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsPrjSite4DownLoadBL.AddNewRecordBySql2WithReturnKey(objPrjSite4DownLoadEN);
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
 /// <param name = "strPrjSite4DownLoadENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool PrjSite4DownLoad_AddNewRecordBySql_XML(string strPrjSite4DownLoadENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSite4DownLoadENObjXml", strPrjSite4DownLoadENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsPrjSite4DownLoadBL.AddNewRecordBySql_XML(strPrjSite4DownLoadENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strPrjSite4DownLoadJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool PrjSite4DownLoad_UpdateBySql2(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objPrjSite4DownLoadEN", clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsPrjSite4DownLoadBL.UpdateBySql2(objPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strPrjSite4DownLoadJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool PrjSite4DownLoad_UpdateBySql2ByJSON(string strPrjSite4DownLoadJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSite4DownLoadJSONObj", strPrjSite4DownLoadJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsPrjSite4DownLoadEN_Sim objPrjSite4DownLoadEN_Sim = clsJSON.GetObjFromJson<clsPrjSite4DownLoadEN_Sim>(strPrjSite4DownLoadJSONObj);
clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObjFromObj_Sim4Upd(objPrjSite4DownLoadEN_Sim);
 try
 {
bool bolResult = clsPrjSite4DownLoadBL.UpdateBySql2(objPrjSite4DownLoadEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来修改记录对象出错!(PrjSite4DownLoadService:PrjSite4DownLoad_UpdateBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public bool PrjSite4DownLoad_UpdateBySqlWithCondition(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objPrjSite4DownLoadEN", clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = clsPrjSite4DownLoadBL.UpdateBySqlWithCondition(objPrjSite4DownLoadEN, strWhereCond);
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
 /// <param name = "strPrjSite4DownLoadENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool PrjSite4DownLoad_UpdateBySql_XML(string strPrjSite4DownLoadENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSite4DownLoadENObjXml", strPrjSite4DownLoadENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsPrjSite4DownLoadBL.UpdateBySql_XML(strPrjSite4DownLoadENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool PrjSite4DownLoad_DelRecord(string strPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsPrjSite4DownLoadBL.DelRecord(strPrjSiteId);
return bolResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrPrjSiteIdLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public bool PrjSite4DownLoad_DelPrjSite4DownLoads(List<string> arrPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrPrjSiteId", clsArray.GetSqlInStrByArray(arrPrjSiteId, true));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsPrjSite4DownLoadBL.DelPrjSite4DownLoads(arrPrjSiteId);
return bolResult;
}

 /// <summary>
 /// 功能:删除多条记录,带条件的删除
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int PrjSite4DownLoad_DelPrjSite4DownLoadsByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsPrjSite4DownLoadBL.DelPrjSite4DownLoadsByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsPrjSite4DownLoadEN ExposeLogicClass(clsPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objPrjSite4DownLoadEN", clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objPrjSite4DownLoadEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/27
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strPrjSiteId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsPrjSite4DownLoadEN>对象XML串</returns>
[WebMethod]
public string PrjSite4DownLoad_SerializeObjToXMLStr(string strPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsPrjSite4DownLoadEN objPrjSite4DownLoadEN = new clsPrjSite4DownLoadEN(strPrjSiteId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsPrjSite4DownLoadBL.GetPrjSite4DownLoad(ref objPrjSite4DownLoadEN);
strXmlString = clsPrjSite4DownLoadBL.SerializeObjToXMLStr(objPrjSite4DownLoadEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "PrjSite4DownLoadService"); 
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:2017/01/27
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjListToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsPrjSite4DownLoadEN>对象列表XML串</returns>
[WebMethod]
public string PrjSite4DownLoad_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsPrjSite4DownLoadEN> lstPrjSite4DownLoadENObjList = clsPrjSite4DownLoadBL.GetPrjSite4DownLoadObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsPrjSite4DownLoadBL.SerializeObjListToXMLStr(lstPrjSite4DownLoadENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "PrjSite4DownLoadService");
}
return strXmlString;
}
}
}