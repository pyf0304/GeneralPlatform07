
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjSite4DownLoadWS
 表名:vQxPrjSite4DownLoad(00140061)
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
using GeneralPlatform4WS.ServiceReferencevQxPrjSite4DownLoad;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v文件下载站点(vQxPrjSite4DownLoad)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjSite4DownLoadWS
{
private static string mstrPageName = "vQxPrjSite4DownLoadService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjSite4DownLoadServiceSoapClient GetvQxPrjSite4DownLoadServiceSoapClient()
{
if (objvQxPrjSite4DownLoadServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjSite4DownLoadServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjSite4DownLoadServiceSoapClient(binding, address);
}
else
{
return objvQxPrjSite4DownLoadServiceSoapClient;
}
}

 public clsvQxPrjSite4DownLoadWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxPrjSite4DownLoad(System.Windows.Forms.ListView lvvQxPrjSite4DownLoad, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjSite4DownLoad; 
List<clsvQxPrjSite4DownLoadEN> arrvQxPrjSite4DownLoadObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjSite4DownLoadObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjSite4DownLoad.Items.Clear();//清除原来所有Item
lvvQxPrjSite4DownLoad.Columns.Clear();//清除原来所有列头信息
lvvQxPrjSite4DownLoad.Columns.Add("工程站点Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("工程站点名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("Ftp服务器", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("Ftp用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("Ftp用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjSite4DownLoad.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN in arrvQxPrjSite4DownLoadObjLst)
{
lvivQxPrjSite4DownLoad = new System.Windows.Forms.ListViewItem();
lvivQxPrjSite4DownLoad.Tag = objvQxPrjSite4DownLoadEN.PrjSiteId;
lvivQxPrjSite4DownLoad.Text = objvQxPrjSite4DownLoadEN.PrjSiteId.ToString();
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.PrjSiteName);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.QxPrjId);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.PrjName);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.FtpServer);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.FtpUserId);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.FtpUserPassword);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.UpdUserId);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.UpdDate);
lvivQxPrjSite4DownLoad.SubItems.Add(objvQxPrjSite4DownLoadEN.Memo);
lvvQxPrjSite4DownLoad.Items.Add(lvivQxPrjSite4DownLoad);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjSite4DownLoadObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjSite4DownLoad_GetDataSet", "clsvQxPrjSite4DownLoadWS:GetDataTableWs", objException.Message);
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
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjSite4DownLoad_GetTopDataSet", "clsvQxPrjSite4DownLoadWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjSite4DownLoad_GetDataSetByRange", "clsvQxPrjSite4DownLoadWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjSite4DownLoadWs(ref clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN)
{
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
bool bolResult = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_GetvQxPrjSite4DownLoad(ref objvQxPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObjByPrjSiteIdWs(string strPrjSiteId)
{
strPrjSiteId = strPrjSiteId.Replace("'", "");
strPrjSiteId = strPrjSiteId.Replace(" ", "");
strPrjSiteId = strPrjSiteId.Replace("(", "");
strPrjSiteId = strPrjSiteId.Replace(")", "");
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_GetObjByPrjSiteId(strPrjSiteId);
return objvQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
try
{
string strPrjSiteId = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_GetFirstID_S(strWhereCond);
return strPrjSiteId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjSite4DownLoad_GetFirstID_S", "clsvQxPrjSite4DownLoadWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjSite4DownLoadEN GetFirstvQxPrjSite4DownLoad_S(string strWhereCond)
{
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
try
{
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_GetFirstObj_S(strWhereCond);
return objvQxPrjSite4DownLoadEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjSite4DownLoad_GetFirstObj_S", "clsvQxPrjSite4DownLoadWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by PrjSiteId");
if (arrvQxPrjSite4DownLoadObjLst_Cache == null)
{
arrvQxPrjSite4DownLoadObjLst_Cache = clsvQxPrjSite4DownLoadWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjSite4DownLoadEN GetObjByPrjSiteId_Cache(string strPrjSiteId)
{
if (string.IsNullOrEmpty(strPrjSiteId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjSite4DownLoadObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjSite4DownLoadEN = arrvQxPrjSite4DownLoadObjLst_Cache[intMid];
if (objvQxPrjSite4DownLoadEN.PrjSiteId == strPrjSiteId)
{
intFindFailCount = 0;
return objvQxPrjSite4DownLoadEN;
}
else if (objvQxPrjSite4DownLoadEN.PrjSiteId.CompareTo(strPrjSiteId) > 0)
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
arrvQxPrjSite4DownLoadObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByPrjSiteId_Cache(strPrjSiteId);
string strErrMsgForGetObjById = string.Format("在vQxPrjSite4DownLoad对象缓存列表中,找不到记录[PrjSiteId = {0}][intFindFailCount = {1}](函数:{2})", strPrjSiteId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjSite4DownLoadEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjSite4DownLoadEN.PrjSiteId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjSite4DownLoadBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjSite4DownLoadEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow["PrjSiteName"].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow["FtpServer"].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow["FtpUserId"].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow["FtpUserPassword"].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
public static List<clsvQxPrjSite4DownLoadEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjSite4DownLoadEN> arrObjLst = new List<clsvQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjSite4DownLoadEN objvQxPrjSite4DownLoadEN = new clsvQxPrjSite4DownLoadEN();
objvQxPrjSite4DownLoadEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objvQxPrjSite4DownLoadEN.PrjSiteName = objRow["PrjSiteName"].ToString().Trim(); //工程站点名
objvQxPrjSite4DownLoadEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjSite4DownLoadEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjSite4DownLoadEN.FtpServer = objRow["FtpServer"].ToString().Trim(); //Ftp服务器
objvQxPrjSite4DownLoadEN.FtpUserId = objRow["FtpUserId"].ToString().Trim(); //Ftp用户Id
objvQxPrjSite4DownLoadEN.FtpUserPassword = objRow["FtpUserPassword"].ToString().Trim(); //Ftp用户口令
objvQxPrjSite4DownLoadEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjSite4DownLoadEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjSite4DownLoadEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxPrjSite4DownLoadEN);
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
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
bool bolIsExist = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strPrjSiteId)
{
//检测记录是否存在
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
bool bolIsExist = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_IsExist(strPrjSiteId);
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
vQxPrjSite4DownLoadServiceSoapClient objvQxPrjSite4DownLoadService = GetvQxPrjSite4DownLoadServiceSoapClient();
int intRecCount = objvQxPrjSite4DownLoadService.vQxPrjSite4DownLoad_funGetRecCountByCond(strWhereCond);
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