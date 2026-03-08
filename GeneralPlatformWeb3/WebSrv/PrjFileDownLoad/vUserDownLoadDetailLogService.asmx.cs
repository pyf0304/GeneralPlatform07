
//类名:vUserDownLoadDetailLogService
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
 /// vUserDownLoadDetailLogService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class vUserDownLoadDetailLogService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet vUserDownLoadDetailLog_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvUserDownLoadDetailLogBL.GetDataSet_vUserDownLoadDetailLog(strWhereCond);
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
public DataSet vUserDownLoadDetailLog_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvUserDownLoadDetailLogBL.GetDataSet_vUserDownLoadDetailLogByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objvUserDownLoadDetailLogEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vUserDownLoadDetailLog_GetvUserDownLoadDetailLog(ref clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvUserDownLoadDetailLogEN", clsvUserDownLoadDetailLogBL.SerializeObjToXMLStr(objvUserDownLoadDetailLogEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLog(ref objvUserDownLoadDetailLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsvUserDownLoadDetailLogEN vUserDownLoadDetailLog_GetvUserDownLoadDetailLogBymId(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogBymId(lngmId);
return objvUserDownLoadDetailLogEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objvUserDownLoadDetailLogEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vUserDownLoadDetailLog_GetvUserDownLoadDetailLogV(ref clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvUserDownLoadDetailLogEN", clsvUserDownLoadDetailLogBL.SerializeObjToXMLStr(objvUserDownLoadDetailLogEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLog(ref objvUserDownLoadDetailLogEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsvUserDownLoadDetailLogEN> vUserDownLoadDetailLog_GetvUserDownLoadDetailLogObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsvUserDownLoadDetailLogEN> arrvUserDownLoadDetailLogObjLst = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObjList(strWhereCond);
return arrvUserDownLoadDetailLogObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public long vUserDownLoadDetailLog_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 long lngmId;
 try
 {
 lngmId = clsvUserDownLoadDetailLogBL.GetFirstID_S(strWhereCond);
 return lngmId;
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
public clsvUserDownLoadDetailLogEN vUserDownLoadDetailLog_GetFirstvUserDownLoadDetailLog_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = clsvUserDownLoadDetailLogBL.GetFirstvUserDownLoadDetailLog_S(strWhereCond);
 return objvUserDownLoadDetailLogEN;
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
 /// <param name = "strvUserDownLoadDetailLogId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetvUserDownLoadDetailLogJSONObjBymId(long lngmId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = null;
 try
 {
 objvUserDownLoadDetailLogEN = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogBymId(lngmId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(vUserDownLoadDetailLogService:GetvUserDownLoadDetailLogJSONObjBymId)\r\n" + objException.Message);
 }
 clsvUserDownLoadDetailLogEN_Sim objvUserDownLoadDetailLogEN_Sim = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObj_SimFromvUserDownLoadDetailLogObj(objvUserDownLoadDetailLogEN);
 string strJSON = clsJSON.GetJsonFromObj<clsvUserDownLoadDetailLogEN_Sim>(objvUserDownLoadDetailLogEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstvUserDownLoadDetailLogJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = null;
 try
 {
 objvUserDownLoadDetailLogEN = clsvUserDownLoadDetailLogBL.GetFirstvUserDownLoadDetailLog_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(vUserDownLoadDetailLogService:GetFirstvUserDownLoadDetailLogJSONObj)\r\n" + objException.Message);
 }
 clsvUserDownLoadDetailLogEN_Sim objvUserDownLoadDetailLogEN_Sim = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObj_SimFromvUserDownLoadDetailLogObj(objvUserDownLoadDetailLogEN);
 string strJSON = clsJSON.GetJsonFromObj<clsvUserDownLoadDetailLogEN_Sim>(objvUserDownLoadDetailLogEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetvUserDownLoadDetailLogJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsvUserDownLoadDetailLogEN> arrvUserDownLoadDetailLogObjLst = null;
 try
 {
 arrvUserDownLoadDetailLogObjLst = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(vUserDownLoadDetailLogService:GetvUserDownLoadDetailLogJSONObjLst)\r\n" + objException.Message);
 }
 List<clsvUserDownLoadDetailLogEN_Sim> arrvUserDownLoadDetailLogObj_SimLst = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObj_SimLstFromvUserDownLoadDetailLogObjLst(arrvUserDownLoadDetailLogObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrvUserDownLoadDetailLogObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool vUserDownLoadDetailLog_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvUserDownLoadDetailLogBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool vUserDownLoadDetailLog_IsExist(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvUserDownLoadDetailLogBL.IsExist(lngmId);
return bolIsExist;
}

[WebMethod]
public clsvUserDownLoadDetailLogEN ExposeLogicClass(clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvUserDownLoadDetailLogEN", clsvUserDownLoadDetailLogBL.SerializeObjToXMLStr(objvUserDownLoadDetailLogEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objvUserDownLoadDetailLogEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/27
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "lngmId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsvUserDownLoadDetailLogEN>对象XML串</returns>
[WebMethod]
public string vUserDownLoadDetailLog_SerializeObjToXMLStr(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsvUserDownLoadDetailLogEN objvUserDownLoadDetailLogEN = new clsvUserDownLoadDetailLogEN(lngmId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLog(ref objvUserDownLoadDetailLogEN);
strXmlString = clsvUserDownLoadDetailLogBL.SerializeObjToXMLStr(objvUserDownLoadDetailLogEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "vUserDownLoadDetailLogService"); 
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
 /// <returns>返回一个<clsvUserDownLoadDetailLogEN>对象列表XML串</returns>
[WebMethod]
public string vUserDownLoadDetailLog_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsvUserDownLoadDetailLogEN> lstvUserDownLoadDetailLogENObjList = clsvUserDownLoadDetailLogBL.GetvUserDownLoadDetailLogObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsvUserDownLoadDetailLogBL.SerializeObjListToXMLStr(lstvUserDownLoadDetailLogENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "vUserDownLoadDetailLogService");
}
return strXmlString;
}
}
}