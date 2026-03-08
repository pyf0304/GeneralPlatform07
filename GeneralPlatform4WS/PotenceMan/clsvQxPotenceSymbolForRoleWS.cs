
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceSymbolForRoleWS
 表名:vQxPotenceSymbolForRole(00140047)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:06
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:PotenceMan
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
using GeneralPlatform4WS.ServiceReferencevQxPotenceSymbolForRole;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// vPotenceSymbolForRole(vQxPotenceSymbolForRole)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPotenceSymbolForRoleWS
{
private static string mstrPageName = "vQxPotenceSymbolForRoleService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPotenceSymbolForRoleServiceSoapClient GetvQxPotenceSymbolForRoleServiceSoapClient()
{
if (objvQxPotenceSymbolForRoleServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPotenceSymbolForRoleServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPotenceSymbolForRoleServiceSoapClient(binding, address);
}
else
{
return objvQxPotenceSymbolForRoleServiceSoapClient;
}
}

 public clsvQxPotenceSymbolForRoleWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxPotenceSymbolForRole(System.Windows.Forms.ListView lvvQxPotenceSymbolForRole, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPotenceSymbolForRole; 
List<clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPotenceSymbolForRoleObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPotenceSymbolForRole.Items.Clear();//清除原来所有Item
lvvQxPotenceSymbolForRole.Columns.Clear();//清除原来所有列头信息
lvvQxPotenceSymbolForRole.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("编程标志", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("权限名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("权限类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("权限类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.Columns.Add("标志名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPotenceSymbolForRole.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN in arrvQxPotenceSymbolForRoleObjLst)
{
lvivQxPotenceSymbolForRole = new System.Windows.Forms.ListViewItem();
lvivQxPotenceSymbolForRole.Tag = objvQxPotenceSymbolForRoleEN.mId;
lvivQxPotenceSymbolForRole.Text = objvQxPotenceSymbolForRoleEN.mId.ToString();
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.RoleId);
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.RelaMid.ToString());
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.PotenceId);
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.SymbolForProgramme);
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.PotenceName);
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.PotenceTypeId);
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.PotenceTypeName);
lvivQxPotenceSymbolForRole.SubItems.Add(objvQxPotenceSymbolForRoleEN.SymbolName);
lvvQxPotenceSymbolForRole.Items.Add(lvivQxPotenceSymbolForRole);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPotenceSymbolForRoleObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPotenceSymbolForRole_GetDataSet", "clsvQxPotenceSymbolForRoleWS:GetDataTableWs", objException.Message);
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
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPotenceSymbolForRole_GetTopDataSet", "clsvQxPotenceSymbolForRoleWS:GetDataTable_TopWs", objException.Message);
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
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPotenceSymbolForRole_GetDataSetByRange", "clsvQxPotenceSymbolForRoleWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPotenceSymbolForRoleWs(ref clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
bool bolResult = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_GetvQxPotenceSymbolForRole(ref objvQxPotenceSymbolForRoleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObjBymIdWs(long lngmId)
{
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_GetObjBymId(lngmId);
return objvQxPotenceSymbolForRoleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
try
{
long lngmId = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPotenceSymbolForRole_GetFirstID_S", "clsvQxPotenceSymbolForRoleWS:GetFirstID_S", objException.Message);
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
public static clsvQxPotenceSymbolForRoleEN GetFirstvQxPotenceSymbolForRole_S(string strWhereCond)
{
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
try
{
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_GetFirstObj_S(strWhereCond);
return objvQxPotenceSymbolForRoleEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPotenceSymbolForRole_GetFirstObj_S", "clsvQxPotenceSymbolForRoleWS:GetFirstObj_S", objException.Message);
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
if (arrvQxPotenceSymbolForRoleObjLst_Cache == null)
{
arrvQxPotenceSymbolForRoleObjLst_Cache = clsvQxPotenceSymbolForRoleWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPotenceSymbolForRoleObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPotenceSymbolForRoleEN = arrvQxPotenceSymbolForRoleObjLst_Cache[intMid];
if (objvQxPotenceSymbolForRoleEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxPotenceSymbolForRoleEN;
}
else if (objvQxPotenceSymbolForRoleEN.mId.CompareTo(lngmId) > 0)
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
arrvQxPotenceSymbolForRoleObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxPotenceSymbolForRole对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPotenceSymbolForRoleEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPotenceSymbolForRoleEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPotenceSymbolForRoleBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
bool bolIsExist = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_IsExistRecord(strWhereCond);
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
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
bool bolIsExist = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_IsExist(lngmId);
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
vQxPotenceSymbolForRoleServiceSoapClient objvQxPotenceSymbolForRoleService = GetvQxPotenceSymbolForRoleServiceSoapClient();
int intRecCount = objvQxPotenceSymbolForRoleService.vQxPotenceSymbolForRole_funGetRecCountByCond(strWhereCond);
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