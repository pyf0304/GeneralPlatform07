
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserGroupPotenceWS
 表名:vQxUserGroupPotence(00140022)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:58
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户权限管理
 模块英文名:UserPotenceMan
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
using GeneralPlatform4WS.ServiceReferencevQxUserGroupPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v用户权限关系(vQxUserGroupPotence)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserGroupPotenceWS
{
private static string mstrPageName = "vQxUserGroupPotenceService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUserGroupPotenceServiceSoapClient GetvQxUserGroupPotenceServiceSoapClient()
{
if (objvQxUserGroupPotenceServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUserGroupPotenceServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUserGroupPotenceServiceSoapClient(binding, address);
}
else
{
return objvQxUserGroupPotenceServiceSoapClient;
}
}

 public clsvQxUserGroupPotenceWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxUserGroupPotence(System.Windows.Forms.ListView lvvQxUserGroupPotence, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUserGroupPotence; 
List<clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUserGroupPotenceObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUserGroupPotence.Items.Clear();//清除原来所有Item
lvvQxUserGroupPotence.Columns.Clear();//清除原来所有列头信息
lvvQxUserGroupPotence.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("组Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("组名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("权限名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("权限类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("权限类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("编程标志", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("标志名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserGroupPotence.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN in arrvQxUserGroupPotenceObjLst)
{
lvivQxUserGroupPotence = new System.Windows.Forms.ListViewItem();
lvivQxUserGroupPotence.Tag = objvQxUserGroupPotenceEN.mId;
lvivQxUserGroupPotence.Text = objvQxUserGroupPotenceEN.mId.ToString();
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.UserId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.UserName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.GroupId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.GroupName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.RoleId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.RoleName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.QxPrjId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.PrjName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.PotenceId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.PotenceName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.PotenceTypeId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.PotenceTypeName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.MenuId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.MenuName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.UpMenuId);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.RelaMid.ToString());
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.SymbolForProgramme);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.SymbolName);
lvivQxUserGroupPotence.SubItems.Add(objvQxUserGroupPotenceEN.Memo);
lvvQxUserGroupPotence.Items.Add(lvivQxUserGroupPotence);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUserGroupPotenceObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserGroupPotenceService.vQxUserGroupPotence_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserGroupPotence_GetDataSet", "clsvQxUserGroupPotenceWS:GetDataTableWs", objException.Message);
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
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserGroupPotenceService.vQxUserGroupPotence_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserGroupPotence_GetTopDataSet", "clsvQxUserGroupPotenceWS:GetDataTable_TopWs", objException.Message);
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
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserGroupPotenceService.vQxUserGroupPotence_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserGroupPotence_GetDataSetByRange", "clsvQxUserGroupPotenceWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserGroupPotenceWs(ref clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
bool bolResult = objvQxUserGroupPotenceService.vQxUserGroupPotence_GetvQxUserGroupPotence(ref objvQxUserGroupPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserGroupPotenceEN GetObjBymIdWs(long lngmId)
{
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = objvQxUserGroupPotenceService.vQxUserGroupPotence_GetObjBymId(lngmId);
return objvQxUserGroupPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
try
{
long lngmId = objvQxUserGroupPotenceService.vQxUserGroupPotence_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserGroupPotence_GetFirstID_S", "clsvQxUserGroupPotenceWS:GetFirstID_S", objException.Message);
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
public static clsvQxUserGroupPotenceEN GetFirstvQxUserGroupPotence_S(string strWhereCond)
{
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
try
{
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = objvQxUserGroupPotenceService.vQxUserGroupPotence_GetFirstObj_S(strWhereCond);
return objvQxUserGroupPotenceEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserGroupPotence_GetFirstObj_S", "clsvQxUserGroupPotenceWS:GetFirstObj_S", objException.Message);
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
if (arrvQxUserGroupPotenceObjLst_Cache == null)
{
arrvQxUserGroupPotenceObjLst_Cache = clsvQxUserGroupPotenceWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserGroupPotenceEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUserGroupPotenceObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUserGroupPotenceEN = arrvQxUserGroupPotenceObjLst_Cache[intMid];
if (objvQxUserGroupPotenceEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxUserGroupPotenceEN;
}
else if (objvQxUserGroupPotenceEN.mId.CompareTo(lngmId) > 0)
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
arrvQxUserGroupPotenceObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxUserGroupPotence对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUserGroupPotenceEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUserGroupPotenceEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUserGroupPotenceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow["GroupName"].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RelaMid"].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow["GroupName"].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RelaMid"].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
bool bolIsExist = objvQxUserGroupPotenceService.vQxUserGroupPotence_IsExistRecord(strWhereCond);
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
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
bool bolIsExist = objvQxUserGroupPotenceService.vQxUserGroupPotence_IsExist(lngmId);
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
vQxUserGroupPotenceServiceSoapClient objvQxUserGroupPotenceService = GetvQxUserGroupPotenceServiceSoapClient();
int intRecCount = objvQxUserGroupPotenceService.vQxUserGroupPotence_funGetRecCountByCond(strWhereCond);
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