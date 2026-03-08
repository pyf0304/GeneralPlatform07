
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewPotenceWS
 表名:vQxViewPotence(00140028)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:00
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:界面管理
 模块英文名:InterfaceMan
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
using GeneralPlatform4WS.ServiceReferencevQxViewPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v界面权限(vQxViewPotence)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxViewPotenceWS
{
private static string mstrPageName = "vQxViewPotenceService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxViewPotenceEN> arrvQxViewPotenceObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxViewPotenceServiceSoapClient objvQxViewPotenceServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxViewPotenceServiceSoapClient GetvQxViewPotenceServiceSoapClient()
{
if (objvQxViewPotenceServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxViewPotenceServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxViewPotenceServiceSoapClient(binding, address);
}
else
{
return objvQxViewPotenceServiceSoapClient;
}
}

 public clsvQxViewPotenceWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxViewPotence(System.Windows.Forms.ListView lvvQxViewPotence, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxViewPotence; 
List<clsvQxViewPotenceEN> arrvQxViewPotenceObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxViewPotenceObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxViewPotence.Items.Clear();//清除原来所有Item
lvvQxViewPotence.Columns.Clear();//清除原来所有列头信息
lvvQxViewPotence.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("权限名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("界面编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("等级", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("模块号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("模块名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewPotence.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxViewPotenceEN objvQxViewPotenceEN in arrvQxViewPotenceObjLst)
{
lvivQxViewPotence = new System.Windows.Forms.ListViewItem();
lvivQxViewPotence.Tag = objvQxViewPotenceEN.mId;
lvivQxViewPotence.Text = objvQxViewPotenceEN.mId.ToString();
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.QxPrjId);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.PotenceId);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.PotenceName);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.PrjName);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.ViewId);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.ViewName);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.Level.ToString());
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.ModuleId);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.ModuleName);
lvivQxViewPotence.SubItems.Add(objvQxViewPotenceEN.Memo);
lvvQxViewPotence.Items.Add(lvivQxViewPotence);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxViewPotenceObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxViewPotenceService.vQxViewPotence_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewPotence_GetDataSet", "clsvQxViewPotenceWS:GetDataTableWs", objException.Message);
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
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxViewPotenceService.vQxViewPotence_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewPotence_GetTopDataSet", "clsvQxViewPotenceWS:GetDataTable_TopWs", objException.Message);
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
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxViewPotenceService.vQxViewPotence_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewPotence_GetDataSetByRange", "clsvQxViewPotenceWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxViewPotenceWs(ref clsvQxViewPotenceEN objvQxViewPotenceEN)
{
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
bool bolResult = objvQxViewPotenceService.vQxViewPotence_GetvQxViewPotence(ref objvQxViewPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxViewPotenceEN GetObjBymIdWs(long lngmId)
{
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
clsvQxViewPotenceEN objvQxViewPotenceEN = objvQxViewPotenceService.vQxViewPotence_GetObjBymId(lngmId);
return objvQxViewPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
try
{
long lngmId = objvQxViewPotenceService.vQxViewPotence_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewPotence_GetFirstID_S", "clsvQxViewPotenceWS:GetFirstID_S", objException.Message);
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
public static clsvQxViewPotenceEN GetFirstvQxViewPotence_S(string strWhereCond)
{
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
try
{
clsvQxViewPotenceEN objvQxViewPotenceEN = objvQxViewPotenceService.vQxViewPotence_GetFirstObj_S(strWhereCond);
return objvQxViewPotenceEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewPotence_GetFirstObj_S", "clsvQxViewPotenceWS:GetFirstObj_S", objException.Message);
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
if (arrvQxViewPotenceObjLst_Cache == null)
{
arrvQxViewPotenceObjLst_Cache = clsvQxViewPotenceWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxViewPotenceEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxViewPotenceObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxViewPotenceEN objvQxViewPotenceEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxViewPotenceEN = arrvQxViewPotenceObjLst_Cache[intMid];
if (objvQxViewPotenceEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxViewPotenceEN;
}
else if (objvQxViewPotenceEN.mId.CompareTo(lngmId) > 0)
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
arrvQxViewPotenceObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxViewPotence对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxViewPotenceEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxViewPotenceEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxViewPotenceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
objvQxViewPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow["Level"].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow["ModuleId"].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow["ModuleName"].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxViewPotenceEN);
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
public static List<clsvQxViewPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
objvQxViewPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow["Level"].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow["ModuleId"].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow["ModuleName"].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxViewPotenceEN);
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
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
bool bolIsExist = objvQxViewPotenceService.vQxViewPotence_IsExistRecord(strWhereCond);
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
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
bool bolIsExist = objvQxViewPotenceService.vQxViewPotence_IsExist(lngmId);
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
vQxViewPotenceServiceSoapClient objvQxViewPotenceService = GetvQxViewPotenceServiceSoapClient();
int intRecCount = objvQxViewPotenceService.vQxViewPotence_funGetRecCountByCond(strWhereCond);
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