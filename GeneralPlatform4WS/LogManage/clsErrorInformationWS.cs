
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorInformationWS
 表名:ErrorInformation(00140050)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:08
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:WEB服务访问层(WS_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using com.taishsoft.common;
using com.taishsoft.json;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceErrorInformation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 错误(ErrorInformation)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsErrorInformationWS
{
private static string mstrPageName = "ErrorInformationService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsErrorInformationEN> arrErrorInformationObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static ErrorInformationServiceSoapClient objErrorInformationServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static ErrorInformationServiceSoapClient GetErrorInformationServiceSoapClient()
{
if (objErrorInformationServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "ErrorInformationServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new ErrorInformationServiceSoapClient(binding, address);
}
else
{
return objErrorInformationServiceSoapClient;
}
}

 public clsErrorInformationWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_ErrorInformation(System.Windows.Forms.ListView lvErrorInformation, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviErrorInformation; 
List<clsErrorInformationEN> arrErrorInformationObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrErrorInformationObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvErrorInformation.Items.Clear();//清除原来所有Item
lvErrorInformation.Columns.Clear();//清除原来所有列头信息
lvErrorInformation.Columns.Add("ErrorID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorInformation.Columns.Add("PageName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorInformation.Columns.Add("FunctionName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorInformation.Columns.Add("ErrorInformation", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorInformation.Columns.Add("CreateTime", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorInformation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvErrorInformation.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsErrorInformationEN objErrorInformationEN in arrErrorInformationObjLst)
{
lviErrorInformation = new System.Windows.Forms.ListViewItem();
lviErrorInformation.Tag = objErrorInformationEN.ErrorID;
lviErrorInformation.Text = objErrorInformationEN.ErrorID.ToString();
lviErrorInformation.SubItems.Add(objErrorInformationEN.PageName);
lviErrorInformation.SubItems.Add(objErrorInformationEN.FunctionName);
lviErrorInformation.SubItems.Add(objErrorInformationEN.ErrorInformation);
lviErrorInformation.SubItems.Add(objErrorInformationEN.CreateTime.ToString());
lviErrorInformation.SubItems.Add(objErrorInformationEN.UserId);
lvErrorInformation.Items.Add(lviErrorInformation);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrErrorInformationObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsErrorInformationEN objErrorInformationEN)
{
if (!Object.Equals(null, objErrorInformationEN.PageName) && GetStrLen(objErrorInformationEN.PageName) > 100)
{
 throw new Exception("字段[PageName]的长度不能超过100!");
}
if (!Object.Equals(null, objErrorInformationEN.FunctionName) && GetStrLen(objErrorInformationEN.FunctionName) > 100)
{
 throw new Exception("字段[FunctionName]的长度不能超过100!");
}
if (!Object.Equals(null, objErrorInformationEN.ErrorInformation) && GetStrLen(objErrorInformationEN.ErrorInformation) > 5000)
{
 throw new Exception("字段[ErrorInformation]的长度不能超过5000!");
}
if (!Object.Equals(null, objErrorInformationEN.UserId) && GetStrLen(objErrorInformationEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
 }

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorInformationService.ErrorInformation_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_GetDataSet", "clsErrorInformationWS:GetDataTableWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetTopDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_TopWs(int intTopSize, string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorInformationService.ErrorInformation_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_GetTopDataSet", "clsErrorInformationWS:GetDataTable_TopWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4TabByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableByRangeWs(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorInformationService.ErrorInformation_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_GetDataSetByRange", "clsErrorInformationWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorInformationService.ErrorInformation_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_GetDataSetV", "clsErrorInformationWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetErrorInformationVWs(string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objErrorInformationService.ErrorInformation_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_GetDataSetV", "clsErrorInformationWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objErrorInformationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetErrorInformationWs(ref clsErrorInformationEN objErrorInformationEN)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
bool bolResult = objErrorInformationService.ErrorInformation_GetErrorInformation(ref objErrorInformationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngErrorID">表关键字</param>
 /// <returns>表对象</returns>
public static clsErrorInformationEN GetObjByErrorIDWs(long lngErrorID)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
clsErrorInformationEN objErrorInformationEN = objErrorInformationService.ErrorInformation_GetObjByErrorID(lngErrorID);
return objErrorInformationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
long lngErrorID = objErrorInformationService.ErrorInformation_GetFirstID_S(strWhereCond);
return lngErrorID;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_GetFirstID_S", "clsErrorInformationWS:GetFirstID_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsErrorInformationEN GetFirstErrorInformation_S(string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
clsErrorInformationEN objErrorInformationEN = objErrorInformationService.ErrorInformation_GetFirstObj_S(strWhereCond);
return objErrorInformationEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_GetFirstObj_S", "clsErrorInformationWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by ErrorID");
if (arrErrorInformationObjLst_Cache == null)
{
arrErrorInformationObjLst_Cache = clsErrorInformationWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngErrorID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsErrorInformationEN GetObjByErrorID_Cache(long lngErrorID)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrErrorInformationObjLst_Cache.Count - 1;
int intMid = 0;
clsErrorInformationEN objErrorInformationEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objErrorInformationEN = arrErrorInformationObjLst_Cache[intMid];
if (objErrorInformationEN.ErrorID == lngErrorID)
{
intFindFailCount = 0;
return objErrorInformationEN;
}
else if (objErrorInformationEN.ErrorID.CompareTo(lngErrorID) > 0)
{
intEnd = intMid - 1;
}
else
{
intStart = intMid + 1;
}
}
intFindFailCount++;
// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
arrErrorInformationObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByErrorID_Cache(lngErrorID);
string strErrMsgForGetObjById = string.Format("在ErrorInformation对象缓存列表中,找不到记录[ErrorID = {0}][intFindFailCount = {1}](函数:{2})", lngErrorID, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objErrorInformationEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objErrorInformationEN.ErrorID, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsErrorInformationBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsErrorInformationEN> GetObjLst(string strWhereCond)
{
 List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
objErrorInformationEN.ErrorID = Int32.Parse(objRow["ErrorID"].ToString().Trim()); //ErrorID
objErrorInformationEN.PageName = objRow["PageName"].ToString().Trim(); //PageName
objErrorInformationEN.FunctionName = objRow["FunctionName"].ToString().Trim(); //FunctionName
objErrorInformationEN.ErrorInformation = objRow["ErrorInformation"].ToString().Trim(); //ErrorInformation
objErrorInformationEN.CreateTime = System.DateTime.Parse(objRow["CreateTime"].ToString().Trim()); //CreateTime
objErrorInformationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
	arrObjLst.Add(objErrorInformationEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLstByRange)
 /// </summary>
 /// <param name = "intMinNum">最小记录号</param>
 /// <param name = "intMaxNum">最大记录号</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回范围内的对象列表</returns>
public static List<clsErrorInformationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsErrorInformationEN> arrObjLst = new List<clsErrorInformationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorInformationEN objErrorInformationEN = new clsErrorInformationEN();
objErrorInformationEN.ErrorID = Int32.Parse(objRow["ErrorID"].ToString().Trim()); //ErrorID
objErrorInformationEN.PageName = objRow["PageName"].ToString().Trim(); //PageName
objErrorInformationEN.FunctionName = objRow["FunctionName"].ToString().Trim(); //FunctionName
objErrorInformationEN.ErrorInformation = objRow["ErrorInformation"].ToString().Trim(); //ErrorInformation
objErrorInformationEN.CreateTime = System.DateTime.Parse(objRow["CreateTime"].ToString().Trim()); //CreateTime
objErrorInformationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
	arrObjLst.Add(objErrorInformationEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(long lngErrorID)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
int intResult = objErrorInformationService.ErrorInformation_DelRecord(lngErrorID);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_DelRecord", "clsErrorInformationWS:DelRecordWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelErrorInformationsWs(List<string> arrErrorID)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrErrorID);
int intResult = objErrorInformationService.ErrorInformation_DelErrorInformations(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_DelErrorInformations", "clsErrorInformationWS:DelErrorInformationsWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelErrorInformationsByCondWs(string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
int intRecNum = objErrorInformationService.ErrorInformation_DelErrorInformationsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_DelErrorInformationsByCond", "clsErrorInformationWS:DelErrorInformationsByCondWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecordBySql2Ws(clsErrorInformationEN objErrorInformationEN)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
bool bolResult = objErrorInformationService.ErrorInformation_AddNewRecordBySql2(objErrorInformationEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_AddNewRecordBySql2", "clsErrorInformationWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsErrorInformationEN objErrorInformationEN)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
string strKey = objErrorInformationService.ErrorInformation_AddNewRecordBySql2WithReturnKey(objErrorInformationEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_AddNewRecordBySql2WithReturnKey", "clsErrorInformationWS:AddNewRecordBySql2WithReturnKey", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateBySql2Ws(clsErrorInformationEN objErrorInformationEN)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
bool bolResult = objErrorInformationService.ErrorInformation_UpdateBySql2(objErrorInformationEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_UpdateBySql2", "clsErrorInformationWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objErrorInformationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsErrorInformationEN objErrorInformationEN, string strWhereCond)
{
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
try
{
bool bolResult = objErrorInformationService.ErrorInformation_UpdateBySqlWithCondition(objErrorInformationEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ErrorInformation_UpdateBySqlWithCondition", "clsErrorInformationWS:UpdateBySqlWithCondition", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
bool bolIsExist = objErrorInformationService.ErrorInformation_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(long lngErrorID)
{
//检测记录是否存在
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
bool bolIsExist = objErrorInformationService.ErrorInformation_IsExist(lngErrorID);
return bolIsExist;
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_funGetRecCountByCond)
 /// </summary>
 /// <returns>记录数</returns>
public static int GetRecCountByCondWs(string strWhereCond)
{
//检测记录是否存在
ErrorInformationServiceSoapClient objErrorInformationService = GetErrorInformationServiceSoapClient();
int intRecCount = objErrorInformationService.ErrorInformation_funGetRecCountByCond(strWhereCond);
return intRecCount;
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 获取Web服务的地址
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetServiceUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
public static string GetServiceUrl(string strPageName, ref string strDir)
{
String strServiceUrl = String.Empty;
if (strDir == "0")
{
strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);
}
if (clsSysPara4WS.bolIsLocalHost == false)
{
if (string.IsNullOrEmpty(strDir) == true)
{
strServiceUrl = String.Format("http://{0}/{1}/{2}",
clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strPageName);
}
else
{
strServiceUrl = String.Format("http://{0}/{1}/{2}/{3}",
clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strDir, strPageName);
}
}
else
{
if (string.IsNullOrEmpty(strDir) == true)
{
strServiceUrl = String.Format("http://{0}/{1}",
clsSysPara4WS.strCurrIPAddressAndPort_Local,
strPageName);
}
else
{
strServiceUrl = String.Format("http://{0}/{1}/{2}",
clsSysPara4WS.strCurrIPAddressAndPort_Local, strDir, strPageName);
}
}
return strServiceUrl;
}
}
}