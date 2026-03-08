
//类名:vUserLoginNameService
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
 /// vUserLoginNameService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class vUserLoginNameService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet vUserLoginName_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvUserLoginNameBL.GetDataSet_vUserLoginName(strWhereCond);
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
public DataSet vUserLoginName_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsvUserLoginNameBL.GetDataSet_vUserLoginNameByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objvUserLoginNameEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vUserLoginName_GetvUserLoginName(ref clsvUserLoginNameEN objvUserLoginNameEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvUserLoginNameEN", clsvUserLoginNameBL.SerializeObjToXMLStr(objvUserLoginNameEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvUserLoginNameBL.GetvUserLoginName(ref objvUserLoginNameEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsvUserLoginNameEN vUserLoginName_GetvUserLoginNameByUserLoginName(string strUserLoginName)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserLoginName", strUserLoginName);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsvUserLoginNameEN objvUserLoginNameEN = clsvUserLoginNameBL.GetvUserLoginNameByUserLoginName(strUserLoginName);
return objvUserLoginNameEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objvUserLoginNameEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool vUserLoginName_GetvUserLoginNameV(ref clsvUserLoginNameEN objvUserLoginNameEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvUserLoginNameEN", clsvUserLoginNameBL.SerializeObjToXMLStr(objvUserLoginNameEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsvUserLoginNameBL.GetvUserLoginName(ref objvUserLoginNameEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsvUserLoginNameEN> vUserLoginName_GetvUserLoginNameObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsvUserLoginNameEN> arrvUserLoginNameObjLst = clsvUserLoginNameBL.GetvUserLoginNameObjList(strWhereCond);
return arrvUserLoginNameObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public string vUserLoginName_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 string strUserLoginName;
 try
 {
 strUserLoginName = clsvUserLoginNameBL.GetFirstID_S(strWhereCond);
 return strUserLoginName;
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
public clsvUserLoginNameEN vUserLoginName_GetFirstvUserLoginName_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsvUserLoginNameEN objvUserLoginNameEN = clsvUserLoginNameBL.GetFirstvUserLoginName_S(strWhereCond);
 return objvUserLoginNameEN;
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
 /// <param name = "strvUserLoginNameId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetvUserLoginNameJSONObjByUserLoginName(string strUserLoginName)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserLoginName", strUserLoginName);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsvUserLoginNameEN objvUserLoginNameEN = null;
 try
 {
 objvUserLoginNameEN = clsvUserLoginNameBL.GetvUserLoginNameByUserLoginName(strUserLoginName);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(vUserLoginNameService:GetvUserLoginNameJSONObjByUserLoginName)\r\n" + objException.Message);
 }
 clsvUserLoginNameEN_Sim objvUserLoginNameEN_Sim = clsvUserLoginNameBL.GetvUserLoginNameObj_SimFromvUserLoginNameObj(objvUserLoginNameEN);
 string strJSON = clsJSON.GetJsonFromObj<clsvUserLoginNameEN_Sim>(objvUserLoginNameEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstvUserLoginNameJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsvUserLoginNameEN objvUserLoginNameEN = null;
 try
 {
 objvUserLoginNameEN = clsvUserLoginNameBL.GetFirstvUserLoginName_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(vUserLoginNameService:GetFirstvUserLoginNameJSONObj)\r\n" + objException.Message);
 }
 clsvUserLoginNameEN_Sim objvUserLoginNameEN_Sim = clsvUserLoginNameBL.GetvUserLoginNameObj_SimFromvUserLoginNameObj(objvUserLoginNameEN);
 string strJSON = clsJSON.GetJsonFromObj<clsvUserLoginNameEN_Sim>(objvUserLoginNameEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetvUserLoginNameJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsvUserLoginNameEN> arrvUserLoginNameObjLst = null;
 try
 {
 arrvUserLoginNameObjLst = clsvUserLoginNameBL.GetvUserLoginNameObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(vUserLoginNameService:GetvUserLoginNameJSONObjLst)\r\n" + objException.Message);
 }
 List<clsvUserLoginNameEN_Sim> arrvUserLoginNameObj_SimLst = clsvUserLoginNameBL.GetvUserLoginNameObj_SimLstFromvUserLoginNameObjLst(arrvUserLoginNameObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrvUserLoginNameObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool vUserLoginName_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvUserLoginNameBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool vUserLoginName_IsExist(string strUserLoginName)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserLoginName", strUserLoginName);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsvUserLoginNameBL.IsExist(strUserLoginName);
return bolIsExist;
}

[WebMethod]
public clsvUserLoginNameEN ExposeLogicClass(clsvUserLoginNameEN objvUserLoginNameEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objvUserLoginNameEN", clsvUserLoginNameBL.SerializeObjToXMLStr(objvUserLoginNameEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objvUserLoginNameEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/23
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "strUserLoginName">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsvUserLoginNameEN>对象XML串</returns>
[WebMethod]
public string vUserLoginName_SerializeObjToXMLStr(string strUserLoginName)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserLoginName", strUserLoginName);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsvUserLoginNameEN objvUserLoginNameEN = new clsvUserLoginNameEN(strUserLoginName);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsvUserLoginNameBL.GetvUserLoginName(ref objvUserLoginNameEN);
strXmlString = clsvUserLoginNameBL.SerializeObjToXMLStr(objvUserLoginNameEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "vUserLoginNameService"); 
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
 /// <returns>返回一个<clsvUserLoginNameEN>对象列表XML串</returns>
[WebMethod]
public string vUserLoginName_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsvUserLoginNameEN> lstvUserLoginNameENObjList = clsvUserLoginNameBL.GetvUserLoginNameObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsvUserLoginNameBL.SerializeObjListToXMLStr(lstvUserLoginNameENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "vUserLoginNameService");
}
return strXmlString;
}
}
}