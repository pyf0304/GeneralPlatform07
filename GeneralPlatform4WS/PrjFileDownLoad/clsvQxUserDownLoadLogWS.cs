
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserDownLoadLogWS
 表名:vQxUserDownLoadLog(00140062)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:12
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
using GeneralPlatform4WS.ServiceReferencevQxUserDownLoadLog;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v用户下载日志(vQxUserDownLoadLog)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserDownLoadLogWS
{
private static string mstrPageName = "vQxUserDownLoadLogService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUserDownLoadLogEN> arrvQxUserDownLoadLogObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUserDownLoadLogServiceSoapClient GetvQxUserDownLoadLogServiceSoapClient()
{
if (objvQxUserDownLoadLogServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUserDownLoadLogServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUserDownLoadLogServiceSoapClient(binding, address);
}
else
{
return objvQxUserDownLoadLogServiceSoapClient;
}
}

 public clsvQxUserDownLoadLogWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxUserDownLoadLog(System.Windows.Forms.ListView lvvQxUserDownLoadLog, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUserDownLoadLog; 
List<clsvQxUserDownLoadLogEN> arrvQxUserDownLoadLogObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUserDownLoadLogObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUserDownLoadLog.Items.Clear();//清除原来所有Item
lvvQxUserDownLoadLog.Columns.Clear();//清除原来所有列头信息
lvvQxUserDownLoadLog.Columns.Add("用户下载日志Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("工程站点Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("工程站点名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("下载日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("日志信息", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("是否成功", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("Ftp服务器", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("Ftp用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("Ftp用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserDownLoadLog.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN in arrvQxUserDownLoadLogObjLst)
{
lvivQxUserDownLoadLog = new System.Windows.Forms.ListViewItem();
lvivQxUserDownLoadLog.Tag = objvQxUserDownLoadLogEN.UserDownLoadLogId;
lvivQxUserDownLoadLog.Text = objvQxUserDownLoadLogEN.UserDownLoadLogId.ToString();
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.PrjSiteId);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.PrjSiteName);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.QxPrjId);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.PrjName);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.UserId);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.DownLownDate);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.LogInfo);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.IsSuccess.ToString());
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.FtpServer);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.FtpUserId);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.FtpUserPassword);
lvivQxUserDownLoadLog.SubItems.Add(objvQxUserDownLoadLogEN.Memo);
lvvQxUserDownLoadLog.Items.Add(lvivQxUserDownLoadLog);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUserDownLoadLogObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserDownLoadLogService.vQxUserDownLoadLog_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserDownLoadLog_GetDataSet", "clsvQxUserDownLoadLogWS:GetDataTableWs", objException.Message);
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
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserDownLoadLogService.vQxUserDownLoadLog_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserDownLoadLog_GetTopDataSet", "clsvQxUserDownLoadLogWS:GetDataTable_TopWs", objException.Message);
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
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserDownLoadLogService.vQxUserDownLoadLog_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserDownLoadLog_GetDataSetByRange", "clsvQxUserDownLoadLogWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserDownLoadLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserDownLoadLogWs(ref clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN)
{
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
bool bolResult = objvQxUserDownLoadLogService.vQxUserDownLoadLog_GetvQxUserDownLoadLog(ref objvQxUserDownLoadLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserDownLoadLogEN GetObjByUserDownLoadLogIdWs(string strUserDownLoadLogId)
{
strUserDownLoadLogId = strUserDownLoadLogId.Replace("'", "");
strUserDownLoadLogId = strUserDownLoadLogId.Replace(" ", "");
strUserDownLoadLogId = strUserDownLoadLogId.Replace("(", "");
strUserDownLoadLogId = strUserDownLoadLogId.Replace(")", "");
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN = objvQxUserDownLoadLogService.vQxUserDownLoadLog_GetObjByUserDownLoadLogId(strUserDownLoadLogId);
return objvQxUserDownLoadLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
try
{
string strUserDownLoadLogId = objvQxUserDownLoadLogService.vQxUserDownLoadLog_GetFirstID_S(strWhereCond);
return strUserDownLoadLogId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserDownLoadLog_GetFirstID_S", "clsvQxUserDownLoadLogWS:GetFirstID_S", objException.Message);
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
public static clsvQxUserDownLoadLogEN GetFirstvQxUserDownLoadLog_S(string strWhereCond)
{
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
try
{
clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN = objvQxUserDownLoadLogService.vQxUserDownLoadLog_GetFirstObj_S(strWhereCond);
return objvQxUserDownLoadLogEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserDownLoadLog_GetFirstObj_S", "clsvQxUserDownLoadLogWS:GetFirstObj_S", objException.Message);
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
if (arrvQxUserDownLoadLogObjLst_Cache == null)
{
arrvQxUserDownLoadLogObjLst_Cache = clsvQxUserDownLoadLogWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserDownLoadLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserDownLoadLogEN GetObjByUserDownLoadLogId_Cache(string strUserDownLoadLogId)
{
if (string.IsNullOrEmpty(strUserDownLoadLogId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUserDownLoadLogObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUserDownLoadLogEN = arrvQxUserDownLoadLogObjLst_Cache[intMid];
if (objvQxUserDownLoadLogEN.UserDownLoadLogId == strUserDownLoadLogId)
{
intFindFailCount = 0;
return objvQxUserDownLoadLogEN;
}
else if (objvQxUserDownLoadLogEN.UserDownLoadLogId.CompareTo(strUserDownLoadLogId) > 0)
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
arrvQxUserDownLoadLogObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserDownLoadLogId_Cache(strUserDownLoadLogId);
string strErrMsgForGetObjById = string.Format("在vQxUserDownLoadLog对象缓存列表中,找不到记录[UserDownLoadLogId = {0}][intFindFailCount = {1}](函数:{2})", strUserDownLoadLogId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUserDownLoadLogEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUserDownLoadLogEN.UserDownLoadLogId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUserDownLoadLogBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserDownLoadLogEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst = new List<clsvQxUserDownLoadLogEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN = new clsvQxUserDownLoadLogEN();
objvQxUserDownLoadLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadLogEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objvQxUserDownLoadLogEN.PrjSiteName = objRow["PrjSiteName"].ToString().Trim(); //工程站点名
objvQxUserDownLoadLogEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserDownLoadLogEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserDownLoadLogEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserDownLoadLogEN.DownLownDate = objRow["DownLownDate"].ToString().Trim(); //下载日期
objvQxUserDownLoadLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objvQxUserDownLoadLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objvQxUserDownLoadLogEN.FtpServer = objRow["FtpServer"].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadLogEN.FtpUserId = objRow["FtpUserId"].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadLogEN.FtpUserPassword = objRow["FtpUserPassword"].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserDownLoadLogEN);
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
public static List<clsvQxUserDownLoadLogEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUserDownLoadLogEN> arrObjLst = new List<clsvQxUserDownLoadLogEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserDownLoadLogEN objvQxUserDownLoadLogEN = new clsvQxUserDownLoadLogEN();
objvQxUserDownLoadLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objvQxUserDownLoadLogEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objvQxUserDownLoadLogEN.PrjSiteName = objRow["PrjSiteName"].ToString().Trim(); //工程站点名
objvQxUserDownLoadLogEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserDownLoadLogEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserDownLoadLogEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserDownLoadLogEN.DownLownDate = objRow["DownLownDate"].ToString().Trim(); //下载日期
objvQxUserDownLoadLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objvQxUserDownLoadLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objvQxUserDownLoadLogEN.FtpServer = objRow["FtpServer"].ToString().Trim(); //Ftp服务器
objvQxUserDownLoadLogEN.FtpUserId = objRow["FtpUserId"].ToString().Trim(); //Ftp用户Id
objvQxUserDownLoadLogEN.FtpUserPassword = objRow["FtpUserPassword"].ToString().Trim(); //Ftp用户口令
objvQxUserDownLoadLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserDownLoadLogEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
bool bolIsExist = objvQxUserDownLoadLogService.vQxUserDownLoadLog_IsExistRecord(strWhereCond);
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
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
bool bolIsExist = objvQxUserDownLoadLogService.vQxUserDownLoadLog_IsExist(strUserDownLoadLogId);
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
vQxUserDownLoadLogServiceSoapClient objvQxUserDownLoadLogService = GetvQxUserDownLoadLogServiceSoapClient();
int intRecCount = objvQxUserDownLoadLogService.vQxUserDownLoadLog_funGetRecCountByCond(strWhereCond);
return intRecCount;
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