
//类名:UserMenuDetailService
 ///----------------------
 ///生成代码版本:2017.01.19.1
 ///生成日期:2017/01/27
 ///生成者:
 ///工程名称:统一平台
 ///工程ID:0014
 ///模块中文名:菜单管理
 ///模块英文名:MenuManage
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
 /// UserMenuDetailService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class UserMenuDetailService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet UserMenuDetail_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenuDetailBL.GetDataSet_UserMenuDetail(strWhereCond);
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
public DataSet UserMenuDetail_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenuDetailBL.GetDataSet_UserMenuDetailByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
[WebMethod]
public DataSet UserMenuDetail_GetDataSetV(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenuDetailBL.GetDataSet_UserMenuDetailV(strWhereCond);
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
public DataSet UserMenuDetail_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenuDetailBL.GetDataSet_UserMenuDetailVByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objUserMenuDetailEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool UserMenuDetail_GetUserMenuDetail(ref clsUserMenuDetailEN objUserMenuDetailEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenuDetailEN", clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenuDetailBL.GetUserMenuDetail(ref objUserMenuDetailEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsUserMenuDetailEN UserMenuDetail_GetUserMenuDetailBymId(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsUserMenuDetailEN objUserMenuDetailEN = clsUserMenuDetailBL.GetUserMenuDetailBymId(lngmId);
return objUserMenuDetailEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objUserMenuDetailEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool UserMenuDetail_GetUserMenuDetailV(ref clsUserMenuDetailEN objUserMenuDetailEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenuDetailEN", clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenuDetailBL.GetUserMenuDetail(ref objUserMenuDetailEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsUserMenuDetailEN> UserMenuDetail_GetUserMenuDetailObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsUserMenuDetailEN> arrUserMenuDetailObjLst = clsUserMenuDetailBL.GetUserMenuDetailObjList(strWhereCond);
return arrUserMenuDetailObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public long UserMenuDetail_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 long lngmId;
 try
 {
 lngmId = clsUserMenuDetailBL.GetFirstID_S(strWhereCond);
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
public clsUserMenuDetailEN UserMenuDetail_GetFirstUserMenuDetail_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsUserMenuDetailEN objUserMenuDetailEN = clsUserMenuDetailBL.GetFirstUserMenuDetail_S(strWhereCond);
 return objUserMenuDetailEN;
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
 /// <param name = "strUserMenuDetailId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetUserMenuDetailJSONObjBymId(long lngmId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsUserMenuDetailEN objUserMenuDetailEN = null;
 try
 {
 objUserMenuDetailEN = clsUserMenuDetailBL.GetUserMenuDetailBymId(lngmId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(UserMenuDetailService:GetUserMenuDetailJSONObjBymId)\r\n" + objException.Message);
 }
 clsUserMenuDetailEN_Sim objUserMenuDetailEN_Sim = clsUserMenuDetailBL.GetUserMenuDetailObj_SimFromUserMenuDetailObj(objUserMenuDetailEN);
 string strJSON = clsJSON.GetJsonFromObj<clsUserMenuDetailEN_Sim>(objUserMenuDetailEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstUserMenuDetailJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsUserMenuDetailEN objUserMenuDetailEN = null;
 try
 {
 objUserMenuDetailEN = clsUserMenuDetailBL.GetFirstUserMenuDetail_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(UserMenuDetailService:GetFirstUserMenuDetailJSONObj)\r\n" + objException.Message);
 }
 clsUserMenuDetailEN_Sim objUserMenuDetailEN_Sim = clsUserMenuDetailBL.GetUserMenuDetailObj_SimFromUserMenuDetailObj(objUserMenuDetailEN);
 string strJSON = clsJSON.GetJsonFromObj<clsUserMenuDetailEN_Sim>(objUserMenuDetailEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetUserMenuDetailJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsUserMenuDetailEN> arrUserMenuDetailObjLst = null;
 try
 {
 arrUserMenuDetailObjLst = clsUserMenuDetailBL.GetUserMenuDetailObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(UserMenuDetailService:GetUserMenuDetailJSONObjLst)\r\n" + objException.Message);
 }
 List<clsUserMenuDetailEN_Sim> arrUserMenuDetailObj_SimLst = clsUserMenuDetailBL.GetUserMenuDetailObj_SimLstFromUserMenuDetailObjLst(arrUserMenuDetailObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrUserMenuDetailObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool UserMenuDetail_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsUserMenuDetailBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool UserMenuDetail_IsExist(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsUserMenuDetailBL.IsExist(lngmId);
return bolIsExist;
}



 /// <summary>
 /// 通过对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objUserMenuDetailEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenuDetail_AddNewRecordBySql2(clsUserMenuDetailEN objUserMenuDetailEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenuDetailEN", clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenuDetailBL.AddNewRecordBySql2(objUserMenuDetailEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strUserMenuDetailJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenuDetail_AddNewRecordBySql2ByJSON(string strUserMenuDetailJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenuDetailJSONObj", strUserMenuDetailJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsUserMenuDetailEN_Sim objUserMenuDetailEN_Sim = clsJSON.GetObjFromJson<clsUserMenuDetailEN_Sim>(strUserMenuDetailJSONObj);
clsUserMenuDetailEN objUserMenuDetailEN = clsUserMenuDetailBL.GetUserMenuDetailObjFromObj_Sim(objUserMenuDetailEN_Sim);
 try
 {
bool bolResult = clsUserMenuDetailBL.AddNewRecordBySql2(objUserMenuDetailEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来添加记录对象出错!(UserMenuDetailService:UserMenuDetail_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public string UserMenuDetail_AddNewRecordBySql2WithReturnKey(clsUserMenuDetailEN objUserMenuDetailEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenuDetailEN", clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsUserMenuDetailBL.AddNewRecordBySql2WithReturnKey(objUserMenuDetailEN);
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
 /// <param name = "strUserMenuDetailENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool UserMenuDetail_AddNewRecordBySql_XML(string strUserMenuDetailENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenuDetailENObjXml", strUserMenuDetailENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenuDetailBL.AddNewRecordBySql_XML(strUserMenuDetailENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strUserMenuDetailJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenuDetail_UpdateBySql2(clsUserMenuDetailEN objUserMenuDetailEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenuDetailEN", clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenuDetailBL.UpdateBySql2(objUserMenuDetailEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strUserMenuDetailJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenuDetail_UpdateBySql2ByJSON(string strUserMenuDetailJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenuDetailJSONObj", strUserMenuDetailJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsUserMenuDetailEN_Sim objUserMenuDetailEN_Sim = clsJSON.GetObjFromJson<clsUserMenuDetailEN_Sim>(strUserMenuDetailJSONObj);
clsUserMenuDetailEN objUserMenuDetailEN = clsUserMenuDetailBL.GetUserMenuDetailObjFromObj_Sim4Upd(objUserMenuDetailEN_Sim);
 try
 {
bool bolResult = clsUserMenuDetailBL.UpdateBySql2(objUserMenuDetailEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来修改记录对象出错!(UserMenuDetailService:UserMenuDetail_UpdateBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public bool UserMenuDetail_UpdateBySqlWithCondition(clsUserMenuDetailEN objUserMenuDetailEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenuDetailEN", clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = clsUserMenuDetailBL.UpdateBySqlWithCondition(objUserMenuDetailEN, strWhereCond);
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
 /// <param name = "strUserMenuDetailENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool UserMenuDetail_UpdateBySql_XML(string strUserMenuDetailENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenuDetailENObjXml", strUserMenuDetailENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenuDetailBL.UpdateBySql_XML(strUserMenuDetailENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool UserMenuDetail_DelRecord(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenuDetailBL.DelRecord(lngmId);
return bolResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public bool UserMenuDetail_DelUserMenuDetails(List<string> arrmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrmId, true));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenuDetailBL.DelUserMenuDetails(arrmId);
return bolResult;
}

 /// <summary>
 /// 功能:删除多条记录,带条件的删除
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int UserMenuDetail_DelUserMenuDetailsByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsUserMenuDetailBL.DelUserMenuDetailsByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsUserMenuDetailEN ExposeLogicClass(clsUserMenuDetailEN objUserMenuDetailEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenuDetailEN", clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objUserMenuDetailEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/27
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "lngmId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsUserMenuDetailEN>对象XML串</returns>
[WebMethod]
public string UserMenuDetail_SerializeObjToXMLStr(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsUserMenuDetailEN objUserMenuDetailEN = new clsUserMenuDetailEN(lngmId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsUserMenuDetailBL.GetUserMenuDetail(ref objUserMenuDetailEN);
strXmlString = clsUserMenuDetailBL.SerializeObjToXMLStr(objUserMenuDetailEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "UserMenuDetailService"); 
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
 /// <returns>返回一个<clsUserMenuDetailEN>对象列表XML串</returns>
[WebMethod]
public string UserMenuDetail_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsUserMenuDetailEN> lstUserMenuDetailENObjList = clsUserMenuDetailBL.GetUserMenuDetailObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsUserMenuDetailBL.SerializeObjListToXMLStr(lstUserMenuDetailENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "UserMenuDetailService");
}
return strXmlString;
}
}
}