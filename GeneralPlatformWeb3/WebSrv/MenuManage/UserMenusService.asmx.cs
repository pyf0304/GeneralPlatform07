
//类名:UserMenusService
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
 /// UserMenusService 的摘要说明
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class UserMenusService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
[WebMethod]
public DataSet UserMenus_GetDataSet(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenusBL.GetDataSet_UserMenus(strWhereCond);
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
public DataSet UserMenus_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenusBL.GetDataSet_UserMenusByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
[WebMethod]
public DataSet UserMenus_GetDataSetV(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenusBL.GetDataSet_UserMenusV(strWhereCond);
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
public DataSet UserMenus_GetDataSetVByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("lngMinNum", lngMinNum.ToString());
dictParam.Add("lngMaxNum", lngMaxNum.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
DataSet objDS = clsUserMenusBL.GetDataSet_UserMenusVByRange(strWhereCond, lngMinNum, lngMaxNum);
return objDS;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objUserMenusEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool UserMenus_GetUserMenus(ref clsUserMenusEN objUserMenusEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenusEN", clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenusBL.GetUserMenus(ref objUserMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
[WebMethod]
public clsUserMenusEN UserMenus_GetUserMenusBymId(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsUserMenusEN objUserMenusEN = clsUserMenusBL.GetUserMenusBymId(lngmId);
return objUserMenusEN;
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objUserMenusEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool UserMenus_GetUserMenusV(ref clsUserMenusEN objUserMenusEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenusEN", clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenusBL.GetUserMenus(ref objUserMenusEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsUserMenusEN> UserMenus_GetUserMenusObjList(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
List<clsUserMenusEN> arrUserMenusObjLst = clsUserMenusBL.GetUserMenusObjList(strWhereCond);
return arrUserMenusObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public long UserMenus_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 long lngmId;
 try
 {
 lngmId = clsUserMenusBL.GetFirstID_S(strWhereCond);
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
public clsUserMenusEN UserMenus_GetFirstUserMenus_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsUserMenusEN objUserMenusEN = clsUserMenusBL.GetFirstUserMenus_S(strWhereCond);
 return objUserMenusEN;
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
 /// <param name = "strUserMenusId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
 [WebMethod]
 public string GetUserMenusJSONObjBymId(long lngmId)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsUserMenusEN objUserMenusEN = null;
 try
 {
 objUserMenusEN = clsUserMenusBL.GetUserMenusBymId(lngmId);
 }
 catch (Exception objException)
 {
 throw new Exception("根据关键字获取对象出错!(UserMenusService:GetUserMenusJSONObjBymId)\r\n" + objException.Message);
 }
 clsUserMenusEN_Sim objUserMenusEN_Sim = clsUserMenusBL.GetUserMenusObj_SimFromUserMenusObj(objUserMenusEN);
 string strJSON = clsJSON.GetJsonFromObj<clsUserMenusEN_Sim>(objUserMenusEN_Sim);
 return strJSON;
     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
 [WebMethod]
 public string GetFirstUserMenusJSONObj(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 clsUserMenusEN objUserMenusEN = null;
 try
 {
 objUserMenusEN = clsUserMenusBL.GetFirstUserMenus_S(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取第一条记录的对象出错!(UserMenusService:GetFirstUserMenusJSONObj)\r\n" + objException.Message);
 }
 clsUserMenusEN_Sim objUserMenusEN_Sim = clsUserMenusBL.GetUserMenusObj_SimFromUserMenusObj(objUserMenusEN);
 string strJSON = clsJSON.GetJsonFromObj<clsUserMenusEN_Sim>(objUserMenusEN_Sim);
 return strJSON;
 }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
 [WebMethod]
 public string GetUserMenusJSONObjLst(string strWhereCond)
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 List<clsUserMenusEN> arrUserMenusObjLst = null;
 try
 {
 arrUserMenusObjLst = clsUserMenusBL.GetUserMenusObjList(strWhereCond);
 }
 catch (Exception objException)
 {
 throw new Exception("根据条件获取的对象列表出错!(UserMenusService:GetUserMenusJSONObjLst)\r\n" + objException.Message);
 }
 List<clsUserMenusEN_Sim> arrUserMenusObj_SimLst = clsUserMenusBL.GetUserMenusObj_SimLstFromUserMenusObjLst(arrUserMenusObjLst);
 string strJSON = clsJSON.GetJsonFromObjLst(arrUserMenusObj_SimLst);
 return strJSON;
 }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool UserMenus_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsUserMenusBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool UserMenus_IsExist(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsUserMenusBL.IsExist(lngmId);
return bolIsExist;
}



 /// <summary>
 /// 通过对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objUserMenusEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenus_AddNewRecordBySql2(clsUserMenusEN objUserMenusEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenusEN", clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenusBL.AddNewRecordBySql2(objUserMenusEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strUserMenusJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenus_AddNewRecordBySql2ByJSON(string strUserMenusJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenusJSONObj", strUserMenusJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsUserMenusEN_Sim objUserMenusEN_Sim = clsJSON.GetObjFromJson<clsUserMenusEN_Sim>(strUserMenusJSONObj);
clsUserMenusEN objUserMenusEN = clsUserMenusBL.GetUserMenusObjFromObj_Sim(objUserMenusEN_Sim);
 try
 {
bool bolResult = clsUserMenusBL.AddNewRecordBySql2(objUserMenusEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来添加记录对象出错!(UserMenusService:UserMenus_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public string UserMenus_AddNewRecordBySql2WithReturnKey(clsUserMenusEN objUserMenusEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenusEN", clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsUserMenusBL.AddNewRecordBySql2WithReturnKey(objUserMenusEN);
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
 /// <param name = "strUserMenusENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool UserMenus_AddNewRecordBySql_XML(string strUserMenusENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenusENObjXml", strUserMenusENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenusBL.AddNewRecordBySql_XML(strUserMenusENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strUserMenusJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenus_UpdateBySql2(clsUserMenusEN objUserMenusEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenusEN", clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsUserMenusBL.UpdateBySql2(objUserMenusEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strUserMenusJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool UserMenus_UpdateBySql2ByJSON(string strUserMenusJSONObj)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenusJSONObj", strUserMenusJSONObj);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
clsUserMenusEN_Sim objUserMenusEN_Sim = clsJSON.GetObjFromJson<clsUserMenusEN_Sim>(strUserMenusJSONObj);
clsUserMenusEN objUserMenusEN = clsUserMenusBL.GetUserMenusObjFromObj_Sim4Upd(objUserMenusEN_Sim);
 try
 {
bool bolResult = clsUserMenusBL.UpdateBySql2(objUserMenusEN);
return bolResult;
 }
 catch (Exception objException)
 {
 throw new Exception("通过JSON对象来修改记录对象出错!(UserMenusService:UserMenus_UpdateBySql2ByJSON)\r\n" + objException.Message);
 }
}

[WebMethod]
public bool UserMenus_UpdateBySqlWithCondition(clsUserMenusEN objUserMenusEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenusEN", clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = clsUserMenusBL.UpdateBySqlWithCondition(objUserMenusEN, strWhereCond);
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
 /// <param name = "strUserMenusENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool UserMenus_UpdateBySql_XML(string strUserMenusENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strUserMenusENObjXml", strUserMenusENObjXml);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenusBL.UpdateBySql_XML(strUserMenusENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool UserMenus_DelRecord(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenusBL.DelRecord(lngmId);
return bolResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public bool UserMenus_DelUserMenuss(List<string> arrmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrmId, true));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsUserMenusBL.DelUserMenuss(arrmId);
return bolResult;
}

 /// <summary>
 /// 功能:删除多条记录,带条件的删除
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int UserMenus_DelUserMenussByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsUserMenusBL.DelUserMenussByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsUserMenusEN ExposeLogicClass(clsUserMenusEN objUserMenusEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objUserMenusEN", clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN));
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
 }
return objUserMenusEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/01/27
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "lngmId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsUserMenusEN>对象XML串</returns>
[WebMethod]
public string UserMenus_SerializeObjToXMLStr(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsUserMenusEN objUserMenusEN = new clsUserMenusEN(lngmId);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsUserMenusBL.GetUserMenus(ref objUserMenusEN);
strXmlString = clsUserMenusBL.SerializeObjToXMLStr(objUserMenusEN);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "UserMenusService"); 
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
 /// <returns>返回一个<clsUserMenusEN>对象列表XML串</returns>
[WebMethod]
public string UserMenus_SerializeObjListToXMLStr(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsUserMenusEN> lstUserMenusENObjList = clsUserMenusBL.GetUserMenusObjList(strWhereCond);
try
{
clsPubVar.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
strXmlString = clsUserMenusBL.SerializeObjListToXMLStr(lstUserMenusENObjList);
}
catch (Exception objException)
{
clsPubVar.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "UserMenusService");
}
return strXmlString;
}
}
}