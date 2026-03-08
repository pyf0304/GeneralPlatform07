
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserDownLoadLogWS
 表名:QxUserDownLoadLog(00140058)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:11
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
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
using GeneralPlatform4WS.ServiceReferenceQxUserDownLoadLog;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户下载日志(QxUserDownLoadLog)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserDownLoadLogWS
{
private static string mstrPageName = "QxUserDownLoadLogService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserDownLoadLogEN> arrQxUserDownLoadLogObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserDownLoadLogServiceSoapClient GetQxUserDownLoadLogServiceSoapClient()
{
if (objQxUserDownLoadLogServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserDownLoadLogServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserDownLoadLogServiceSoapClient(binding, address);
}
else
{
return objQxUserDownLoadLogServiceSoapClient;
}
}

 public clsQxUserDownLoadLogWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUserDownLoadLog(System.Windows.Forms.ListView lvQxUserDownLoadLog, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserDownLoadLog; 
List<clsQxUserDownLoadLogEN> arrQxUserDownLoadLogObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserDownLoadLogObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserDownLoadLog.Items.Clear();//清除原来所有Item
lvQxUserDownLoadLog.Columns.Clear();//清除原来所有列头信息
lvQxUserDownLoadLog.Columns.Add("用户下载日志Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadLog.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadLog.Columns.Add("工程站点Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadLog.Columns.Add("下载日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadLog.Columns.Add("是否成功", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadLog.Columns.Add("日志信息", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadLog.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadLog.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserDownLoadLogEN objQxUserDownLoadLogEN in arrQxUserDownLoadLogObjLst)
{
lviQxUserDownLoadLog = new System.Windows.Forms.ListViewItem();
lviQxUserDownLoadLog.Tag = objQxUserDownLoadLogEN.UserDownLoadLogId;
lviQxUserDownLoadLog.Text = objQxUserDownLoadLogEN.UserDownLoadLogId.ToString();
lviQxUserDownLoadLog.SubItems.Add(objQxUserDownLoadLogEN.UserId);
lviQxUserDownLoadLog.SubItems.Add(objQxUserDownLoadLogEN.PrjSiteId);
lviQxUserDownLoadLog.SubItems.Add(objQxUserDownLoadLogEN.DownLownDate);
lviQxUserDownLoadLog.SubItems.Add(objQxUserDownLoadLogEN.IsSuccess.ToString());
lviQxUserDownLoadLog.SubItems.Add(objQxUserDownLoadLogEN.LogInfo);
lviQxUserDownLoadLog.SubItems.Add(objQxUserDownLoadLogEN.Memo);
lvQxUserDownLoadLog.Items.Add(lviQxUserDownLoadLog);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserDownLoadLogObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
if (!Object.Equals(null, objQxUserDownLoadLogEN.UserDownLoadLogId) && GetStrLen(objQxUserDownLoadLogEN.UserDownLoadLogId) > 8)
{
 throw new Exception("字段[用户下载日志Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.UserId) && GetStrLen(objQxUserDownLoadLogEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.PrjSiteId) && GetStrLen(objQxUserDownLoadLogEN.PrjSiteId) > 6)
{
 throw new Exception("字段[工程站点Id]的长度不能超过6!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.DownLownDate) && GetStrLen(objQxUserDownLoadLogEN.DownLownDate) > 20)
{
 throw new Exception("字段[下载日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.LogInfo) && GetStrLen(objQxUserDownLoadLogEN.LogInfo) > 500)
{
 throw new Exception("字段[日志信息]的长度不能超过500!");
}
if (!Object.Equals(null, objQxUserDownLoadLogEN.Memo) && GetStrLen(objQxUserDownLoadLogEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
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
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadLogService.QxUserDownLoadLog_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_GetDataSet", "clsQxUserDownLoadLogWS:GetDataTableWs", objException.Message);
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
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadLogService.QxUserDownLoadLog_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_GetTopDataSet", "clsQxUserDownLoadLogWS:GetDataTable_TopWs", objException.Message);
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
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadLogService.QxUserDownLoadLog_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_GetDataSetByRange", "clsQxUserDownLoadLogWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadLogService.QxUserDownLoadLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_GetDataSetV", "clsQxUserDownLoadLogWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserDownLoadLogVWs(string strWhereCond)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadLogService.QxUserDownLoadLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_GetDataSetV", "clsQxUserDownLoadLogWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserDownLoadLogWs(ref clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
bool bolResult = objQxUserDownLoadLogService.QxUserDownLoadLog_GetQxUserDownLoadLog(ref objQxUserDownLoadLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserDownLoadLogEN GetObjByUserDownLoadLogIdWs(string strUserDownLoadLogId)
{
strUserDownLoadLogId = strUserDownLoadLogId.Replace("'", "");
strUserDownLoadLogId = strUserDownLoadLogId.Replace(" ", "");
strUserDownLoadLogId = strUserDownLoadLogId.Replace("(", "");
strUserDownLoadLogId = strUserDownLoadLogId.Replace(")", "");
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = objQxUserDownLoadLogService.QxUserDownLoadLog_GetObjByUserDownLoadLogId(strUserDownLoadLogId);
return objQxUserDownLoadLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
string strUserDownLoadLogId = objQxUserDownLoadLogService.QxUserDownLoadLog_GetFirstID_S(strWhereCond);
return strUserDownLoadLogId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_GetFirstID_S", "clsQxUserDownLoadLogWS:GetFirstID_S", objException.Message);
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
public static clsQxUserDownLoadLogEN GetFirstQxUserDownLoadLog_S(string strWhereCond)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = objQxUserDownLoadLogService.QxUserDownLoadLog_GetFirstObj_S(strWhereCond);
return objQxUserDownLoadLogEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_GetFirstObj_S", "clsQxUserDownLoadLogWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by UserDownLoadLogId");
if (arrQxUserDownLoadLogObjLst_Cache == null)
{
arrQxUserDownLoadLogObjLst_Cache = clsQxUserDownLoadLogWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserDownLoadLogEN GetObjByUserDownLoadLogId_Cache(string strUserDownLoadLogId)
{
if (string.IsNullOrEmpty(strUserDownLoadLogId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserDownLoadLogObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserDownLoadLogEN = arrQxUserDownLoadLogObjLst_Cache[intMid];
if (objQxUserDownLoadLogEN.UserDownLoadLogId == strUserDownLoadLogId)
{
intFindFailCount = 0;
return objQxUserDownLoadLogEN;
}
else if (objQxUserDownLoadLogEN.UserDownLoadLogId.CompareTo(strUserDownLoadLogId) > 0)
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
arrQxUserDownLoadLogObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserDownLoadLogId_Cache(strUserDownLoadLogId);
string strErrMsgForGetObjById = string.Format("在QxUserDownLoadLog对象缓存列表中,找不到记录[UserDownLoadLogId = {0}][intFindFailCount = {1}](函数:{2})", strUserDownLoadLogId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserDownLoadLogEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserDownLoadLogEN.UserDownLoadLogId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserDownLoadLogBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserDownLoadLogEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserDownLoadLogEN> arrObjLst = new List<clsQxUserDownLoadLogEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
objQxUserDownLoadLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadLogEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserDownLoadLogEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objQxUserDownLoadLogEN.DownLownDate = objRow["DownLownDate"].ToString().Trim(); //下载日期
objQxUserDownLoadLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objQxUserDownLoadLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objQxUserDownLoadLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserDownLoadLogEN);
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
public static List<clsQxUserDownLoadLogEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserDownLoadLogEN> arrObjLst = new List<clsQxUserDownLoadLogEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadLogEN objQxUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
objQxUserDownLoadLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadLogEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserDownLoadLogEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objQxUserDownLoadLogEN.DownLownDate = objRow["DownLownDate"].ToString().Trim(); //下载日期
objQxUserDownLoadLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objQxUserDownLoadLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objQxUserDownLoadLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserDownLoadLogEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strUserDownLoadLogId)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
int intResult = objQxUserDownLoadLogService.QxUserDownLoadLog_DelRecord(strUserDownLoadLogId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_DelRecord", "clsQxUserDownLoadLogWS:DelRecordWs", objException.Message);
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
public static int DelQxUserDownLoadLogsWs(List<string> arrUserDownLoadLogId)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrUserDownLoadLogId);
int intResult = objQxUserDownLoadLogService.QxUserDownLoadLog_DelQxUserDownLoadLogs(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_DelQxUserDownLoadLogs", "clsQxUserDownLoadLogWS:DelQxUserDownLoadLogsWs", objException.Message);
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
public static int DelQxUserDownLoadLogsByCondWs(string strWhereCond)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
int intRecNum = objQxUserDownLoadLogService.QxUserDownLoadLog_DelQxUserDownLoadLogsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_DelQxUserDownLoadLogsByCond", "clsQxUserDownLoadLogWS:DelQxUserDownLoadLogsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
bool bolResult = objQxUserDownLoadLogService.QxUserDownLoadLog_AddNewRecordBySql2(objQxUserDownLoadLogEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_AddNewRecordBySql2", "clsQxUserDownLoadLogWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
bool bolResult = objQxUserDownLoadLogService.QxUserDownLoadLog_UpdateBySql2(objQxUserDownLoadLogEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_UpdateBySql2", "clsQxUserDownLoadLogWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserDownLoadLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserDownLoadLogEN objQxUserDownLoadLogEN, string strWhereCond)
{
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
bool bolResult = objQxUserDownLoadLogService.QxUserDownLoadLog_UpdateBySqlWithCondition(objQxUserDownLoadLogEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadLog_UpdateBySqlWithCondition", "clsQxUserDownLoadLogWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
bool bolIsExist = objQxUserDownLoadLogService.QxUserDownLoadLog_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strUserDownLoadLogId)
{
//检测记录是否存在
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
bool bolIsExist = objQxUserDownLoadLogService.QxUserDownLoadLog_IsExist(strUserDownLoadLogId);
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
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
int intRecCount = objQxUserDownLoadLogService.QxUserDownLoadLog_funGetRecCountByCond(strWhereCond);
return intRecCount;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdWs()
{
//检测记录是否存在
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
string strMaxUserDownLoadLogId = objQxUserDownLoadLogService.QxUserDownLoadLog_GetMaxStrId();
return strMaxUserDownLoadLogId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxUserDownLoadLogServiceSoapClient objQxUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
string strMaxUserDownLoadLogId = objQxUserDownLoadLogService.QxUserDownLoadLog_GetMaxStrIdByPrefix(strPrefix);
return strMaxUserDownLoadLogId;
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