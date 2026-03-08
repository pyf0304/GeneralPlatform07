
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenusWS
 表名:vQxRoleMenus(00140034)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:02
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:菜单管理
 模块英文名:MenuManage
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
using GeneralPlatform4WS.ServiceReferencevQxRoleMenus;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v角色菜单(vQxRoleMenus)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRoleMenusWS
{
private static string mstrPageName = "vQxRoleMenusService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxRoleMenusServiceSoapClient objvQxRoleMenusServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxRoleMenusServiceSoapClient GetvQxRoleMenusServiceSoapClient()
{
if (objvQxRoleMenusServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxRoleMenusServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxRoleMenusServiceSoapClient(binding, address);
}
else
{
return objvQxRoleMenusServiceSoapClient;
}
}

 public clsvQxRoleMenusWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxRoleMenus(System.Windows.Forms.ListView lvvQxRoleMenus, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxRoleMenus; 
List<clsvQxRoleMenusEN> arrvQxRoleMenusObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxRoleMenusObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxRoleMenus.Items.Clear();//清除原来所有Item
lvvQxRoleMenus.Columns.Clear();//清除原来所有列头信息
lvvQxRoleMenus.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("菜单集名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("页面显示模式名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("上级菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("角色数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxRoleMenusEN objvQxRoleMenusEN in arrvQxRoleMenusObjLst)
{
lvivQxRoleMenus = new System.Windows.Forms.ListViewItem();
lvivQxRoleMenus.Tag = objvQxRoleMenusEN.mId;
lvivQxRoleMenus.Text = objvQxRoleMenusEN.mId.ToString();
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.RoleId);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.RoleName);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.QxPrjId);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.MenuId);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.MenuName);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.PrjName);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.UpMenuId);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.LinkFile);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.qsParameters);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.ImgFile);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.OrderNum.ToString());
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.IsLeafNode.ToString());
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.MenuSetId);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.MenuSetName);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.MenuTitle);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.PageDispModeId);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.PageDispModeName);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.InUse.ToString());
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.UpMenuName);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.RoleNum.ToString());
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.IsDisp.ToString());
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.UpdDate);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.UpdUserId);
lvivQxRoleMenus.SubItems.Add(objvQxRoleMenusEN.Memo);
lvvQxRoleMenus.Items.Add(lvivQxRoleMenus);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxRoleMenusObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRoleMenusService.vQxRoleMenus_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_GetDataSet", "clsvQxRoleMenusWS:GetDataTableWs", objException.Message);
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
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRoleMenusService.vQxRoleMenus_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_GetTopDataSet", "clsvQxRoleMenusWS:GetDataTable_TopWs", objException.Message);
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
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRoleMenusService.vQxRoleMenus_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_GetDataSetByRange", "clsvQxRoleMenusWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxRoleMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRoleMenusWs(ref clsvQxRoleMenusEN objvQxRoleMenusEN)
{
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
bool bolResult = objvQxRoleMenusService.vQxRoleMenus_GetvQxRoleMenus(ref objvQxRoleMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenusEN GetObjBymIdWs(long lngmId)
{
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
clsvQxRoleMenusEN objvQxRoleMenusEN = objvQxRoleMenusService.vQxRoleMenus_GetObjBymId(lngmId);
return objvQxRoleMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
try
{
long lngmId = objvQxRoleMenusService.vQxRoleMenus_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_GetFirstID_S", "clsvQxRoleMenusWS:GetFirstID_S", objException.Message);
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
public static clsvQxRoleMenusEN GetFirstvQxRoleMenus_S(string strWhereCond)
{
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
try
{
clsvQxRoleMenusEN objvQxRoleMenusEN = objvQxRoleMenusService.vQxRoleMenus_GetFirstObj_S(strWhereCond);
return objvQxRoleMenusEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_GetFirstObj_S", "clsvQxRoleMenusWS:GetFirstObj_S", objException.Message);
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
if (arrvQxRoleMenusObjLst_Cache == null)
{
arrvQxRoleMenusObjLst_Cache = clsvQxRoleMenusWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRoleMenusEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxRoleMenusObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxRoleMenusEN objvQxRoleMenusEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxRoleMenusEN = arrvQxRoleMenusObjLst_Cache[intMid];
if (objvQxRoleMenusEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxRoleMenusEN;
}
else if (objvQxRoleMenusEN.mId.CompareTo(lngmId) > 0)
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
arrvQxRoleMenusObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxRoleMenus对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxRoleMenusEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxRoleMenusEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxRoleMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenusEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
objvQxRoleMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleNum"].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxRoleMenusEN);
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
public static List<clsvQxRoleMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxRoleMenusEN> arrObjLst = new List<clsvQxRoleMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenusEN objvQxRoleMenusEN = new clsvQxRoleMenusEN();
objvQxRoleMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxRoleMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxRoleMenusEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxRoleMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxRoleMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxRoleMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxRoleMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxRoleMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxRoleMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxRoleMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxRoleMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxRoleMenusEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxRoleMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxRoleMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxRoleMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxRoleMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxRoleMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxRoleMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxRoleMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxRoleMenusEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
objvQxRoleMenusEN.RoleNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleNum"].ToString().Trim()); //角色数
objvQxRoleMenusEN.IsDisp = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDisp"].ToString().Trim()); //是否显示
objvQxRoleMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxRoleMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxRoleMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxRoleMenusEN);
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
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
bool bolIsExist = objvQxRoleMenusService.vQxRoleMenus_IsExistRecord(strWhereCond);
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
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
bool bolIsExist = objvQxRoleMenusService.vQxRoleMenus_IsExist(lngmId);
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
vQxRoleMenusServiceSoapClient objvQxRoleMenusService = GetvQxRoleMenusServiceSoapClient();
int intRecCount = objvQxRoleMenusService.vQxRoleMenus_funGetRecCountByCond(strWhereCond);
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