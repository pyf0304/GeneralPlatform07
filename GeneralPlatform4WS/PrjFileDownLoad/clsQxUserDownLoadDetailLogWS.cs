
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserDownLoadDetailLogWS
 表名:QxUserDownLoadDetailLog(00140059)
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
using GeneralPlatform4WS.ServiceReferenceQxUserDownLoadDetailLog;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户下载日志细节(QxUserDownLoadDetailLog)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserDownLoadDetailLogWS
{
private static string mstrPageName = "QxUserDownLoadDetailLogService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserDownLoadDetailLogEN> arrQxUserDownLoadDetailLogObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserDownLoadDetailLogServiceSoapClient GetQxUserDownLoadDetailLogServiceSoapClient()
{
if (objQxUserDownLoadDetailLogServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserDownLoadDetailLogServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserDownLoadDetailLogServiceSoapClient(binding, address);
}
else
{
return objQxUserDownLoadDetailLogServiceSoapClient;
}
}

 public clsQxUserDownLoadDetailLogWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUserDownLoadDetailLog(System.Windows.Forms.ListView lvQxUserDownLoadDetailLog, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserDownLoadDetailLog; 
List<clsQxUserDownLoadDetailLogEN> arrQxUserDownLoadDetailLogObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserDownLoadDetailLogObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserDownLoadDetailLog.Items.Clear();//清除原来所有Item
lvQxUserDownLoadDetailLog.Columns.Clear();//清除原来所有列头信息
lvQxUserDownLoadDetailLog.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadDetailLog.Columns.Add("用户下载日志Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadDetailLog.Columns.Add("文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadDetailLog.Columns.Add("版本", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadDetailLog.Columns.Add("是否成功", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadDetailLog.Columns.Add("日志信息", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadDetailLog.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserDownLoadDetailLog.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN in arrQxUserDownLoadDetailLogObjLst)
{
lviQxUserDownLoadDetailLog = new System.Windows.Forms.ListViewItem();
lviQxUserDownLoadDetailLog.Tag = objQxUserDownLoadDetailLogEN.mId;
lviQxUserDownLoadDetailLog.Text = objQxUserDownLoadDetailLogEN.mId.ToString();
lviQxUserDownLoadDetailLog.SubItems.Add(objQxUserDownLoadDetailLogEN.UserDownLoadLogId);
lviQxUserDownLoadDetailLog.SubItems.Add(objQxUserDownLoadDetailLogEN.FileName);
lviQxUserDownLoadDetailLog.SubItems.Add(objQxUserDownLoadDetailLogEN.Version);
lviQxUserDownLoadDetailLog.SubItems.Add(objQxUserDownLoadDetailLogEN.IsSuccess.ToString());
lviQxUserDownLoadDetailLog.SubItems.Add(objQxUserDownLoadDetailLogEN.LogInfo);
lviQxUserDownLoadDetailLog.SubItems.Add(objQxUserDownLoadDetailLogEN.Memo);
lvQxUserDownLoadDetailLog.Items.Add(lviQxUserDownLoadDetailLog);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserDownLoadDetailLogObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN)
{
if (!Object.Equals(null, objQxUserDownLoadDetailLogEN.UserDownLoadLogId) && GetStrLen(objQxUserDownLoadDetailLogEN.UserDownLoadLogId) > 8)
{
 throw new Exception("字段[用户下载日志Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserDownLoadDetailLogEN.FileName) && GetStrLen(objQxUserDownLoadDetailLogEN.FileName) > 500)
{
 throw new Exception("字段[文件名]的长度不能超过500!");
}
if (!Object.Equals(null, objQxUserDownLoadDetailLogEN.Version) && GetStrLen(objQxUserDownLoadDetailLogEN.Version) > 30)
{
 throw new Exception("字段[版本]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUserDownLoadDetailLogEN.LogInfo) && GetStrLen(objQxUserDownLoadDetailLogEN.LogInfo) > 500)
{
 throw new Exception("字段[日志信息]的长度不能超过500!");
}
if (!Object.Equals(null, objQxUserDownLoadDetailLogEN.Memo) && GetStrLen(objQxUserDownLoadDetailLogEN.Memo) > 1000)
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
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_GetDataSet", "clsQxUserDownLoadDetailLogWS:GetDataTableWs", objException.Message);
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
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_GetTopDataSet", "clsQxUserDownLoadDetailLogWS:GetDataTable_TopWs", objException.Message);
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
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_GetDataSetByRange", "clsQxUserDownLoadDetailLogWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_GetDataSetV", "clsQxUserDownLoadDetailLogWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserDownLoadDetailLogVWs(string strWhereCond)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_GetDataSetV", "clsQxUserDownLoadDetailLogWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserDownLoadDetailLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserDownLoadDetailLogWs(ref clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
bool bolResult = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetQxUserDownLoadDetailLog(ref objQxUserDownLoadDetailLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserDownLoadDetailLogEN GetObjBymIdWs(long lngmId)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetObjBymId(lngmId);
return objQxUserDownLoadDetailLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
long lngmId = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_GetFirstID_S", "clsQxUserDownLoadDetailLogWS:GetFirstID_S", objException.Message);
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
public static clsQxUserDownLoadDetailLogEN GetFirstQxUserDownLoadDetailLog_S(string strWhereCond)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_GetFirstObj_S(strWhereCond);
return objQxUserDownLoadDetailLogEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_GetFirstObj_S", "clsQxUserDownLoadDetailLogWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by mId");
if (arrQxUserDownLoadDetailLogObjLst_Cache == null)
{
arrQxUserDownLoadDetailLogObjLst_Cache = clsQxUserDownLoadDetailLogWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserDownLoadDetailLogEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserDownLoadDetailLogObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserDownLoadDetailLogEN = arrQxUserDownLoadDetailLogObjLst_Cache[intMid];
if (objQxUserDownLoadDetailLogEN.mId == lngmId)
{
intFindFailCount = 0;
return objQxUserDownLoadDetailLogEN;
}
else if (objQxUserDownLoadDetailLogEN.mId.CompareTo(lngmId) > 0)
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
arrQxUserDownLoadDetailLogObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在QxUserDownLoadDetailLog对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserDownLoadDetailLogEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserDownLoadDetailLogEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserDownLoadDetailLogBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserDownLoadDetailLogEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserDownLoadDetailLogEN> arrObjLst = new List<clsQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN = new clsQxUserDownLoadDetailLogEN();
objQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadDetailLogEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objQxUserDownLoadDetailLogEN.Version = objRow["Version"].ToString().Trim(); //版本
objQxUserDownLoadDetailLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objQxUserDownLoadDetailLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objQxUserDownLoadDetailLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserDownLoadDetailLogEN);
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
public static List<clsQxUserDownLoadDetailLogEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserDownLoadDetailLogEN> arrObjLst = new List<clsQxUserDownLoadDetailLogEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN = new clsQxUserDownLoadDetailLogEN();
objQxUserDownLoadDetailLogEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserDownLoadDetailLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objQxUserDownLoadDetailLogEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objQxUserDownLoadDetailLogEN.Version = objRow["Version"].ToString().Trim(); //版本
objQxUserDownLoadDetailLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objQxUserDownLoadDetailLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objQxUserDownLoadDetailLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserDownLoadDetailLogEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(long lngmId)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
int intResult = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_DelRecord", "clsQxUserDownLoadDetailLogWS:DelRecordWs", objException.Message);
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
public static int DelQxUserDownLoadDetailLogsWs(List<string> arrmId)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_DelQxUserDownLoadDetailLogs(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_DelQxUserDownLoadDetailLogs", "clsQxUserDownLoadDetailLogWS:DelQxUserDownLoadDetailLogsWs", objException.Message);
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
public static int DelQxUserDownLoadDetailLogsByCondWs(string strWhereCond)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
int intRecNum = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_DelQxUserDownLoadDetailLogsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_DelQxUserDownLoadDetailLogsByCond", "clsQxUserDownLoadDetailLogWS:DelQxUserDownLoadDetailLogsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
bool bolResult = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_AddNewRecordBySql2(objQxUserDownLoadDetailLogEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_AddNewRecordBySql2", "clsQxUserDownLoadDetailLogWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserDownLoadDetailLogEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
string strKey = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_AddNewRecordBySql2WithReturnKey(objQxUserDownLoadDetailLogEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_AddNewRecordBySql2WithReturnKey", "clsQxUserDownLoadDetailLogWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
bool bolResult = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_UpdateBySql2(objQxUserDownLoadDetailLogEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_UpdateBySql2", "clsQxUserDownLoadDetailLogWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserDownLoadDetailLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserDownLoadDetailLogEN objQxUserDownLoadDetailLogEN, string strWhereCond)
{
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
bool bolResult = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_UpdateBySqlWithCondition(objQxUserDownLoadDetailLogEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserDownLoadDetailLog_UpdateBySqlWithCondition", "clsQxUserDownLoadDetailLogWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
bool bolIsExist = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(long lngmId)
{
//检测记录是否存在
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
bool bolIsExist = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_IsExist(lngmId);
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
QxUserDownLoadDetailLogServiceSoapClient objQxUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
int intRecCount = objQxUserDownLoadDetailLogService.QxUserDownLoadDetailLog_funGetRecCountByCond(strWhereCond);
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