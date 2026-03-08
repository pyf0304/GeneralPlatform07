
/*-- -- -- -- -- -- -- -- -- -- --
类名:ExportExcel4UsersService
表名:ExportExcel4Users
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:04:55
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:Web服务层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
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


namespace GeneralPlatform.WebSrv
{
 /// <summary>
 /// ExportExcel4UsersService 的摘要说明
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceCode)
 /// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
public class ExportExcel4UsersService : System.Web.Services.WebService
{ 

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
//[WebMethod]
//public DataSet ExportExcel4Users_GetDataSet(string strWhereCond)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//DataSet objDS = clsExportExcel4UsersBL.GetDataSet_ExportExcel4Users(strWhereCond);
//return objDS;
//}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetTopDataSet)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
//[WebMethod]
//public DataSet ExportExcel4Users_GetTopDataSet(int intTopSize, string strWhereCond)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//DataSet objDS = clsExportExcel4UsersBL.GetDataSet_TopExportExcel4Users(intTopSize, strWhereCond);
//return objDS;
//}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetDataSetByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lngMinNum">范围之最小值</param>
 /// <param name = "lngMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
//[WebMethod]
//public DataSet ExportExcel4Users_GetDataSetByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//dictParam.Add("lngMinNum", lngMinNum.ToString());
//dictParam.Add("lngMaxNum", lngMaxNum.ToString());
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//DataSet objDS = clsExportExcel4UsersBL.GetDataSet_ExportExcel4UsersByRange(strWhereCond, lngMinNum, lngMaxNum);
//return objDS;
//}

 /// <summary>
 /// 根据条件获取当前表视图的数据集,用DataSet表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetDataSetV)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回当前表视图的数据集,用DataSet表示</returns>
//[WebMethod]
//public DataSet ExportExcel4Users_GetDataSetV(string strWhereCond)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//DataSet objDS = clsExportExcel4UsersBL.GetDataSet_ExportExcel4UsersV(strWhereCond);
//return objDS;
//}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetRecordProperty)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcel4Users_GetExportExcel4Users(ref clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcel4UsersEN", clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN));
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcel4UsersBL.GetExportExcel4Users(ref objExportExcel4UsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetTabObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
//[WebMethod]
//public clsExportExcel4UsersEN ExportExcel4Users_GetExportExcel4UsersBymId(long lngmId)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("lngmId", lngmId.ToString());
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetExportExcel4UsersBymId(lngmId);
//return objExportExcel4UsersEN;
//}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetRecordPropertyV)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">相关对象</param>
/// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcel4Users_GetExportExcel4UsersV(ref clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcel4UsersEN", clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN));
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcel4UsersBL.GetExportExcel4Users(ref objExportExcel4UsersEN);
return bolResult;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
//[WebMethod]
//public List<clsExportExcel4UsersEN> ExportExcel4Users_GetExportExcel4UsersObjList(string strWhereCond)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLst = clsExportExcel4UsersBL.GetExportExcel4UsersObjList(strWhereCond);
//return arrExportExcel4UsersObjLst;
//}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetTopCondRecObjList)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
[WebMethod]
public List<clsExportExcel4UsersEN> ExportExcel4Users_GetTopExportExcel4UsersObjList(int intTopSize, string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLst = clsExportExcel4UsersBL.GetTopObjLst(intTopSize, strWhereCond,"");
return arrExportExcel4UsersObjLst;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
[WebMethod]
public long ExportExcel4Users_GetFirstID_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 long lngmId;
 try
 {
 lngmId = clsExportExcel4UsersBL.GetFirstID_S(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
 throw new Exception("获取First关键字出错!\r\n" + objException.Message);
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
[WebMethod]
public clsExportExcel4UsersEN ExportExcel4Users_GetFirstExportExcel4Users_S(string strWhereCond) 
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 try
 {
 clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetFirstObj_S(strWhereCond);
 return objExportExcel4UsersEN;
 }
 catch (Exception objException)
 {
 throw new Exception("获取First记录对象出错!\r\n" + objException.Message);
 }
}

   /// <summary>
 /// 获取当前关键字的记录对象,用对象的JSON形式表示.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetJSONObjByKeyId_S)
 /// </summary>
 /// <param name = "strExportExcel4UsersId">表关键字</param>
 /// <returns>表对象的JSON形式</returns>
// [WebMethod]
// public string GetExportExcel4UsersJSONObjBymId(long lngmId)
// {
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("lngmId", lngmId.ToString());
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
// clsExportExcel4UsersEN objExportExcel4UsersEN = null;
// try
// {
// objExportExcel4UsersEN = clsExportExcel4UsersBL.GetExportExcel4UsersBymId(lngmId);
// }
// catch (Exception objException)
// {
// throw new Exception("根据关键字获取对象出错!(ExportExcel4UsersService:GetExportExcel4UsersJSONObjBymId)\r\n" + objException.Message);
// }
// clsExportExcel4UsersEN_Sim objExportExcel4UsersEN_Sim = clsExportExcel4UsersBL.GetExportExcel4UsersObj_SimFromExportExcel4UsersObj(objExportExcel4UsersEN);
// string strJSON = clsJSON.GetJsonFromObj<clsExportExcel4UsersEN_Sim>(objExportExcel4UsersEN_Sim);
// return strJSON;
//     }

 /// <summary>
 /// 获取当前表满足条件的第一条记录的JSON对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetFirstJSONObjByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的JSON对象</returns>
// [WebMethod]
// public string GetFirstExportExcel4UsersJSONObj(string strWhereCond)
// {
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
// clsExportExcel4UsersEN objExportExcel4UsersEN = null;
// try
// {
// objExportExcel4UsersEN = clsExportExcel4UsersBL.GetFirstExportExcel4Users_S(strWhereCond);
// }
// catch (Exception objException)
// {
// throw new Exception("根据条件获取第一条记录的对象出错!(ExportExcel4UsersService:GetFirstExportExcel4UsersJSONObj)\r\n" + objException.Message);
// }
// clsExportExcel4UsersEN_Sim objExportExcel4UsersEN_Sim = clsExportExcel4UsersBL.GetExportExcel4UsersObj_SimFromExportExcel4UsersObj(objExportExcel4UsersEN);
// string strJSON = clsJSON.GetJsonFromObj<clsExportExcel4UsersEN_Sim>(objExportExcel4UsersEN_Sim);
// return strJSON;
// }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
// [WebMethod]
// public string GetExportExcel4UsersJSONObjLst(string strWhereCond)
// {
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
// List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLst = null;
// try
// {
// arrExportExcel4UsersObjLst = clsExportExcel4UsersBL.GetObjLst(strWhereCond);
// }
// catch (Exception objException)
// {
// throw new Exception("根据条件获取的对象列表出错!(ExportExcel4UsersService:GetExportExcel4UsersJSONObjLst)\r\n" + objException.Message);
// }
// List<clsExportExcel4UsersEN_Sim> arrExportExcel4UsersObj_SimLst = clsExportExcel4UsersBL.GetObjLst_SimLstFromObjLst(arrExportExcel4UsersObjLst);
// string strJSON = clsJSON.GetJsonFromObjLst(arrExportExcel4UsersObj_SimLst);
// return strJSON;
// }

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_GetTopJSONObjLstByCondition_S)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回JSON对象列表</returns>
// [WebMethod]
// public string GetTopExportExcel4UsersJSONObjLst(int intTopSize, string strWhereCond)
// {
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
// List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLst = null;
// try
// {
// arrExportExcel4UsersObjLst = clsExportExcel4UsersBL.GetTopExportExcel4UsersObjList(intTopSize, strWhereCond);
// }
// catch (Exception objException)
// {
// throw new Exception("根据条件获取的对象列表出错!(ExportExcel4UsersService:GetExportExcel4UsersJSONObjLst)\r\n" + objException.Message);
// }
// List<clsExportExcel4UsersEN_Sim> arrExportExcel4UsersObj_SimLst = clsExportExcel4UsersBL.GetExportExcel4UsersObj_SimLstFromExportExcel4UsersObjLst(arrExportExcel4UsersObjLst);
// string strJSON = clsJSON.GetJsonFromObjLst(arrExportExcel4UsersObj_SimLst);
// return strJSON;
// }

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_IsExistRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
[WebMethod]
public bool ExportExcel4Users_IsExistRecord(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsExportExcel4UsersBL.IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
[WebMethod]
public bool ExportExcel4Users_IsExist(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolIsExist = clsExportExcel4UsersBL.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 通过对象来添加记录对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcel4Users_AddNewRecordBySql2(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcel4UsersEN", clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN));
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcel4UsersBL.AddNewRecordBySql2(objExportExcel4UsersEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来添加记录对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_AddNewRecordBySql2ByJSON)
 /// </summary>
 /// <param name = "strExportExcel4UsersJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
//[WebMethod]
//public bool ExportExcel4Users_AddNewRecordBySql2ByJSON(string strExportExcel4UsersJSONObj)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strExportExcel4UsersJSONObj", strExportExcel4UsersJSONObj);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//clsExportExcel4UsersEN_Sim objExportExcel4UsersEN_Sim = clsJSON.GetObjFromJson<clsExportExcel4UsersEN_Sim>(strExportExcel4UsersJSONObj);
//clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetExportExcel4UsersObjFromObj_Sim(objExportExcel4UsersEN_Sim);
// try
// {
//bool bolResult = clsExportExcel4UsersBL.AddNewRecordBySql2(objExportExcel4UsersEN);
//return bolResult;
// }
// catch (Exception objException)
// {
// throw new Exception("通过JSON对象来添加记录对象出错!(ExportExcel4UsersService:ExportExcel4Users_AddNewRecordBySql2ByJSON)\r\n" + objException.Message);
// }
//}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
[WebMethod]
public string ExportExcel4Users_AddNewRecordBySql2WithReturnKey(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcel4UsersEN", clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN));
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
string strKey = clsExportExcel4UsersBL.AddNewRecordBySql2WithReturnKey(objExportExcel4UsersEN);
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
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strExportExcel4UsersENObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool ExportExcel4Users_AddNewRecordBySql_XML(string strExportExcel4UsersENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strExportExcel4UsersENObjXml", strExportExcel4UsersENObjXml);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcel4UsersBL.AddNewRecordBySql_XML(strExportExcel4UsersENObjXml);
return bolResult;
}

 /// <summary>
 /// 通过对象来修改记录对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_UpdateBySql2)
 /// </summary>
 /// <param name = "strExportExcel4UsersJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
[WebMethod]
public bool ExportExcel4Users_UpdateBySql2(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcel4UsersEN", clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN));
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
bool bolResult = clsExportExcel4UsersBL.UpdateBySql2(objExportExcel4UsersEN);
return bolResult;
}

 /// <summary>
 /// 通过JSON对象来修改记录对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_UpdateBySql2ByJSON)
 /// </summary>
 /// <param name = "strExportExcel4UsersJSONObj">JSON对象字符串</param>
 /// <returns>是否成功</returns>
//[WebMethod]
//public bool ExportExcel4Users_UpdateBySql2ByJSON(string strExportExcel4UsersJSONObj)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strExportExcel4UsersJSONObj", strExportExcel4UsersJSONObj);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//clsExportExcel4UsersEN_Sim objExportExcel4UsersEN_Sim = clsJSON.GetObjFromJson<clsExportExcel4UsersEN_Sim>(strExportExcel4UsersJSONObj);
//clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetExportExcel4UsersObjFromObj_Sim4Upd(objExportExcel4UsersEN_Sim);
// try
// {
//bool bolResult = clsExportExcel4UsersBL.UpdateBySql2(objExportExcel4UsersEN);
//return bolResult;
// }
// catch (Exception objException)
// {
// throw new Exception("通过JSON对象来修改记录对象出错!(ExportExcel4UsersService:ExportExcel4Users_UpdateBySql2ByJSON)\r\n" + objException.Message);
// }
//}

[WebMethod]
public bool ExportExcel4Users_UpdateBySqlWithCondition(clsExportExcel4UsersEN objExportExcel4UsersEN, string strWhereCond)
{
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcel4UsersEN", clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN));
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
try
{
bool bolResult = objExportExcel4UsersEN.UpdateWithCondition(strWhereCond);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("修改记录出错!\r\n" + objException.Message);
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strExportExcel4UsersENObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public bool ExportExcel4Users_UpdateBySql_XML(string strExportExcel4UsersENObjXml)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strExportExcel4UsersENObjXml", strExportExcel4UsersENObjXml);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
bool bolResult = clsExportExcel4UsersBL.UpdateBySql_XML(strExportExcel4UsersENObjXml);
return bolResult;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_DelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
[WebMethod]
public int ExportExcel4Users_DelRecord(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intResult = clsExportExcel4UsersBL.DelRecord(lngmId);
return intResult;
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_DelMultiRecord)
 /// </summary>
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
[WebMethod]
public int ExportExcel4Users_DelExportExcel4Userss(List<string> arrmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("arrmId", clsArray.GetSqlInStrByArray(arrmId, true));
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intResult = clsExportExcel4UsersBL.DelExportExcel4Userss(arrmId);
return intResult;
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
[WebMethod]
public int ExportExcel4Users_DelExportExcel4UserssByCond(string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
int intRecNum = clsExportExcel4UsersBL.DelExportExcel4UserssByCond(strWhereCond);
return intRecNum;
}

[WebMethod]
public clsExportExcel4UsersEN ExposeLogicClass(clsExportExcel4UsersEN objExportExcel4UsersEN)
{ 
 if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)
{
   clsPubVar_WS.objLog.WriteDebugLog("clsSysParaEN.strTempXMLFileName为空，请检查!");
 }
 else
 {
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("objExportExcel4UsersEN", clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN));
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
 }
return objExportExcel4UsersEN;
}

 /// <summary>
 /// 序列化一个对象到Xml串
 /// 作者:
 /// 日期:2017/05/08
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_Ws_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "lngmId">需要序列化的对象关键字</param>
 /// <returns>返回一个<clsExportExcel4UsersEN>对象XML串</returns>
[WebMethod]
public string ExportExcel4Users_SerializeObjToXMLStr(long lngmId)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN(lngmId);
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
clsExportExcel4UsersBL.GetExportExcel4Users(ref objExportExcel4UsersEN);
strXmlString = clsExportExcel4UsersBL.SerializeObjToXMLStr(objExportExcel4UsersEN);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message); 
clsLog.LogErrorS(objException, "ExportExcel4UsersService"); 
}
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:2017/05/08
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_Ws_SerializeObjListToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsExportExcel4UsersEN>对象列表XML串</returns>
//[WebMethod]
//public string ExportExcel4Users_SerializeObjListToXMLStr(string strWhereCond)
//{
//string strFunctionName = clsStackTrace.GetCurrFunction();
//Dictionary<string, string> dictParam = new Dictionary<string, string>();
//dictParam.Add("strWhereCond", strWhereCond);
//clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
//string strXmlString = "";
//List<clsExportExcel4UsersEN> lstExportExcel4UsersENObjList = clsExportExcel4UsersBL.GetExportExcel4UsersObjList(strWhereCond);
//try
//{
//clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
////strXmlString = clsExportExcel4UsersBL.SerializeObjListToXMLStr(lstExportExcel4UsersENObjList);
//}
//catch (Exception objException)
//{
//clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
//clsLog.LogErrorS(objException, "ExportExcel4UsersService");
//}
//return strXmlString;
//}

 /// <summary>
 /// 序列化一个对象列表到Xml串
 /// 作者:
 /// 日期:2017/05/08
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_Ws_SerializeTopObjListToXMLStr)
 /// </summary>
 /// <param name = "strWhereCond">需要序列化的对象列表的条件串</param>
 /// <returns>返回一个<clsExportExcel4UsersEN>对象列表XML串</returns>
[WebMethod]
public string ExportExcel4Users_SerializeTopObjListToXMLStr(int intTopSize, string strWhereCond)
{
string strFunctionName = clsStackTrace.GetCurrFunction();
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);
string strXmlString = "";
List<clsExportExcel4UsersEN> lstExportExcel4UsersENObjList = clsExportExcel4UsersBL.GetTopObjLst(intTopSize, strWhereCond,"");
try
{
clsPubVar_WS.objLog.WriteDebugLog("XML输出文件:" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));
//strXmlString = clsExportExcel4UsersBL.SerializeObjListToXMLStr(lstExportExcel4UsersENObjList);
}
catch (Exception objException)
{
clsPubVar_WS.objLog.WriteDebugLog(objException.Message);
clsLog.LogErrorS(objException, "ExportExcel4UsersService");
}
return strXmlString;
}
}
}