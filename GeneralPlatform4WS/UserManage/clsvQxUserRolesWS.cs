
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesWS
 表名:vQxUserRoles(00140025)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:59
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
using GeneralPlatform4WS.ServiceReferencevQxUserRoles;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v角色(vQxUserRoles)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRolesWS
{
private static string mstrPageName = "vQxUserRolesService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUserRolesEN> arrvQxUserRolesObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUserRolesServiceSoapClient objvQxUserRolesServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUserRolesServiceSoapClient GetvQxUserRolesServiceSoapClient()
{
if (objvQxUserRolesServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUserRolesServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUserRolesServiceSoapClient(binding, address);
}
else
{
return objvQxUserRolesServiceSoapClient;
}
}

 public clsvQxUserRolesWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxUserRoles(System.Windows.Forms.ListView lvvQxUserRoles, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUserRoles; 
List<clsvQxUserRolesEN> arrvQxUserRolesObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUserRolesObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUserRoles.Items.Clear();//清除原来所有Item
lvvQxUserRoles.Columns.Clear();//清除原来所有列头信息
lvvQxUserRoles.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("角色英文名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("角色序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("是否在使用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoles.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUserRolesEN objvQxUserRolesEN in arrvQxUserRolesObjLst)
{
lvivQxUserRoles = new System.Windows.Forms.ListViewItem();
lvivQxUserRoles.Tag = objvQxUserRolesEN.RoleId;
lvivQxUserRoles.Text = objvQxUserRolesEN.RoleId.ToString();
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.RoleName);
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.RoleENName);
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.RoleIndex.ToString());
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.QxPrjId);
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.PrjName);
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.IsInUse.ToString());
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.UpdDate);
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.UpdUserId);
lvivQxUserRoles.SubItems.Add(objvQxUserRolesEN.Memo);
lvvQxUserRoles.Items.Add(lvivQxUserRoles);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUserRolesObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRolesService.vQxUserRoles_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoles_GetDataSet", "clsvQxUserRolesWS:GetDataTableWs", objException.Message);
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
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRolesService.vQxUserRoles_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoles_GetTopDataSet", "clsvQxUserRolesWS:GetDataTable_TopWs", objException.Message);
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
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRolesService.vQxUserRoles_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoles_GetDataSetByRange", "clsvQxUserRolesWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRolesWs(ref clsvQxUserRolesEN objvQxUserRolesEN)
{
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
bool bolResult = objvQxUserRolesService.vQxUserRoles_GetvQxUserRoles(ref objvQxUserRolesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesEN GetObjByRoleIdWs(string strRoleId)
{
strRoleId = strRoleId.Replace("'", "");
strRoleId = strRoleId.Replace(" ", "");
strRoleId = strRoleId.Replace("(", "");
strRoleId = strRoleId.Replace(")", "");
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
clsvQxUserRolesEN objvQxUserRolesEN = objvQxUserRolesService.vQxUserRoles_GetObjByRoleId(strRoleId);
return objvQxUserRolesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
try
{
string strRoleId = objvQxUserRolesService.vQxUserRoles_GetFirstID_S(strWhereCond);
return strRoleId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoles_GetFirstID_S", "clsvQxUserRolesWS:GetFirstID_S", objException.Message);
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
public static clsvQxUserRolesEN GetFirstvQxUserRoles_S(string strWhereCond)
{
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
try
{
clsvQxUserRolesEN objvQxUserRolesEN = objvQxUserRolesService.vQxUserRoles_GetFirstObj_S(strWhereCond);
return objvQxUserRolesEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoles_GetFirstObj_S", "clsvQxUserRolesWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by RoleId");
if (arrvQxUserRolesObjLst_Cache == null)
{
arrvQxUserRolesObjLst_Cache = clsvQxUserRolesWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRolesEN GetObjByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUserRolesObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUserRolesEN objvQxUserRolesEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUserRolesEN = arrvQxUserRolesObjLst_Cache[intMid];
if (objvQxUserRolesEN.RoleId == strRoleId)
{
intFindFailCount = 0;
return objvQxUserRolesEN;
}
else if (objvQxUserRolesEN.RoleId.CompareTo(strRoleId) > 0)
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
arrvQxUserRolesObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByRoleId_Cache(strRoleId);
string strErrMsgForGetObjById = string.Format("在vQxUserRoles对象缓存列表中,找不到记录[RoleId = {0}][intFindFailCount = {1}](函数:{2})", strRoleId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUserRolesEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUserRolesEN.RoleId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUserRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRolesEN> arrObjLst = new List<clsvQxUserRolesEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesEN objvQxUserRolesEN = new clsvQxUserRolesEN();
objvQxUserRolesEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserRolesEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserRolesEN.RoleENName = objRow["RoleENName"].ToString().Trim(); //角色英文名
objvQxUserRolesEN.RoleIndex = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleIndex"].ToString().Trim()); //角色序号
objvQxUserRolesEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserRolesEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserRolesEN.IsInUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsInUse"].ToString().Trim()); //是否在使用
objvQxUserRolesEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUserRolesEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxUserRolesEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserRolesEN);
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
public static List<clsvQxUserRolesEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUserRolesEN> arrObjLst = new List<clsvQxUserRolesEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesEN objvQxUserRolesEN = new clsvQxUserRolesEN();
objvQxUserRolesEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserRolesEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserRolesEN.RoleENName = objRow["RoleENName"].ToString().Trim(); //角色英文名
objvQxUserRolesEN.RoleIndex = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleIndex"].ToString().Trim()); //角色序号
objvQxUserRolesEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserRolesEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserRolesEN.IsInUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsInUse"].ToString().Trim()); //是否在使用
objvQxUserRolesEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUserRolesEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxUserRolesEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserRolesEN);
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
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
bool bolIsExist = objvQxUserRolesService.vQxUserRoles_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strRoleId)
{
//检测记录是否存在
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
bool bolIsExist = objvQxUserRolesService.vQxUserRoles_IsExist(strRoleId);
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
vQxUserRolesServiceSoapClient objvQxUserRolesService = GetvQxUserRolesServiceSoapClient();
int intRecCount = objvQxUserRolesService.vQxUserRoles_funGetRecCountByCond(strWhereCond);
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