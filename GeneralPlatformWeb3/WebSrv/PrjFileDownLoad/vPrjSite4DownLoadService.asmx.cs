
//类名:vPrjSite4DownLoadService
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
 /// vPrjSite4DownLoadService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class vPrjSite4DownLoadService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet vPrjSite4DownLoad_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvPrjSite4DownLoadBL.GetDataSet_vPrjSite4DownLoad(strWhereCond);
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
public DataSet vPrjSite4DownLoad_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvPrjSite4DownLoadBL.GetDataSet_vPrjSite4DownLoadByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objvPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vPrjSite4DownLoad_GetvPrjSite4DownLoad(ref clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvPrjSite4DownLoadEN", clsvPrjSite4DownLoadBL.SerializeObjToXMLStr(objvPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoad(ref objvPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsvPrjSite4DownLoadEN vPrjSite4DownLoad_GetvPrjSite4DownLoadByPrjSiteId(string strPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadByPrjSiteId(strPrjSiteId);
return objvPrjSite4DownLoadEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objvPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vPrjSite4DownLoad_GetvPrjSite4DownLoadV(ref clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvPrjSite4DownLoadEN", clsvPrjSite4DownLoadBL.SerializeObjToXMLStr(objvPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoad(ref objvPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsvPrjSite4DownLoadEN> vPrjSite4DownLoad_GetvPrjSite4DownLoadObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsvPrjSite4DownLoadEN> arrvPrjSite4DownLoadObjLst = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObjList(strWhereCond);
return arrvPrjSite4DownLoadObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string vPrjSite4DownLoad_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 string strPrjSiteId;
 try
 {
 strPrjSiteId = clsvPrjSite4DownLoadBL.GetFirstID_S(strWhereCond);
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
public clsvPrjSite4DownLoadEN vPrjSite4DownLoad_GetFirstvPrjSite4DownLoad_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = clsvPrjSite4DownLoadBL.GetFirstvPrjSite4DownLoad_S(strWhereCond);
 return objvPrjSite4DownLoadEN;
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
 /// <param name = "strvPrjSite4DownLoadId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetvPrjSite4DownLoadJSONObjByPrjSiteId(string strPrjSiteId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = null;
 try
 {
 objvPrjSite4DownLoadEN = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadByPrjSiteId(strPrjSiteId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(vPrjSite4DownLoadService:GetvPrjSite4DownLoadJSONObjByPrjSiteId)\r\n" + objException.Message);
 }
 clsvPrjSite4DownLoadEN_Sim objvPrjSite4DownLoadEN_Sim = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObj_SimFromvPrjSite4DownLoadObj(objvPrjSite4DownLoadEN);
 string strJSON = clsJSON.GetJsonFromObj<clsvPrjSite4DownLoadEN_Sim>(objvPrjSite4DownLoadEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstvPrjSite4DownLoadJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = null;
 try
 {
 objvPrjSite4DownLoadEN = clsvPrjSite4DownLoadBL.GetFirstvPrjSite4DownLoad_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(vPrjSite4DownLoadService:GetFirstvPrjSite4DownLoadJSONObj)\r\n" + objException.Message);
 }
 clsvPrjSite4DownLoadEN_Sim objvPrjSite4DownLoadEN_Sim = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObj_SimFromvPrjSite4DownLoadObj(objvPrjSite4DownLoadEN);
 string strJSON = clsJSON.GetJsonFromObj<clsvPrjSite4DownLoadEN_Sim>(objvPrjSite4DownLoadEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetvPrjSite4DownLoadJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsvPrjSite4DownLoadEN> arrvPrjSite4DownLoadObjLst = null;
 try
 {
 arrvPrjSite4DownLoadObjLst = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(vPrjSite4DownLoadService:GetvPrjSite4DownLoadJSONObjLst)\r\n" + objException.Message);
 }
 List<clsvPrjSite4DownLoadEN_Sim> arrvPrjSite4DownLoadObj_SimLst = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObj_SimLstFromvPrjSite4DownLoadObjLst(arrvPrjSite4DownLoadObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrvPrjSite4DownLoadObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool vPrjSite4DownLoad_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvPrjSite4DownLoadBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "strPrjSiteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool vPrjSite4DownLoad_IsExist(string strPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvPrjSite4DownLoadBL.IsExist(strPrjSiteId);
return bolIsExist;
}

[WebMethod]
public clsvPrjSite4DownLoadEN ExposeLogicClass(clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvPrjSite4DownLoadEN", clsvPrjSite4DownLoadBL.SerializeObjToXMLStr(objvPrjSite4DownLoadEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objvPrjSite4DownLoadEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/27
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strPrjSiteId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsvPrjSite4DownLoadEN>对象XML串</returns>
[WebMethod]
public string vPrjSite4DownLoad_SerializeObjToXMLStr(string strPrjSiteId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrjSiteId", strPrjSiteId);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsvPrjSite4DownLoadEN objvPrjSite4DownLoadEN = new clsvPrjSite4DownLoadEN(strPrjSiteId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoad(ref objvPrjSite4DownLoadEN);
strXmlString = clsvPrjSite4DownLoadBL.SerializeObjToXMLStr(objvPrjSite4DownLoadEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "vPrjSite4DownLoadService"); 
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
 /// <returns>返回一个<clsvPrjSite4DownLoadEN>对象列表XML串</returns>
[WebMethod]
public string vPrjSite4DownLoad_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsvPrjSite4DownLoadEN> lstvPrjSite4DownLoadENObjList = clsvPrjSite4DownLoadBL.GetvPrjSite4DownLoadObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsvPrjSite4DownLoadBL.SerializeObjListToXMLStr(lstvPrjSite4DownLoadENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "vPrjSite4DownLoadService");
}
return strXmlString;
}
}
}