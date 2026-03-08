
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenus_SimWS
 表名:vQxRoleMenus_Sim(00140073)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:17
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
using GeneralPlatform4WS.ServiceReferencevQxRoleMenus_Sim;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v角色菜单_Sim(vQxRoleMenus_Sim)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRoleMenus_SimWS
{
private static string mstrPageName = "vQxRoleMenus_SimService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxRoleMenus_SimServiceSoapClient GetvQxRoleMenus_SimServiceSoapClient()
{
if (objvQxRoleMenus_SimServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxRoleMenus_SimServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxRoleMenus_SimServiceSoapClient(binding, address);
}
else
{
return objvQxRoleMenus_SimServiceSoapClient;
}
}

 public clsvQxRoleMenus_SimWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxRoleMenus_Sim(System.Windows.Forms.ListView lvvQxRoleMenus_Sim, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxRoleMenus_Sim; 
List<clsvQxRoleMenus_SimEN> arrvQxRoleMenus_SimObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxRoleMenus_SimObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxRoleMenus_Sim.Items.Clear();//清除原来所有Item
lvvQxRoleMenus_Sim.Columns.Clear();//清除原来所有列头信息
lvvQxRoleMenus_Sim.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.Columns.Add("上级菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRoleMenus_Sim.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN in arrvQxRoleMenus_SimObjLst)
{
lvivQxRoleMenus_Sim = new System.Windows.Forms.ListViewItem();
lvivQxRoleMenus_Sim.Tag = objvQxRoleMenus_SimEN.mId;
lvivQxRoleMenus_Sim.Text = objvQxRoleMenus_SimEN.mId.ToString();
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.RoleId);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.QxPrjId);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.MenuId);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.MenuName);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.UpMenuId);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.LinkFile);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.qsParameters);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.ImgFile);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.OrderNum.ToString());
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.IsLeafNode.ToString());
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.MenuSetId);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.MenuTitle);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.PageDispModeId);
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.InUse.ToString());
lvivQxRoleMenus_Sim.SubItems.Add(objvQxRoleMenus_SimEN.UpMenuName);
lvvQxRoleMenus_Sim.Items.Add(lvivQxRoleMenus_Sim);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxRoleMenus_SimObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_Sim_GetDataSet", "clsvQxRoleMenus_SimWS:GetDataTableWs", objException.Message);
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
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_Sim_GetTopDataSet", "clsvQxRoleMenus_SimWS:GetDataTable_TopWs", objException.Message);
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
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_Sim_GetDataSetByRange", "clsvQxRoleMenus_SimWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxRoleMenus_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRoleMenus_SimWs(ref clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN)
{
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
bool bolResult = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_GetvQxRoleMenus_Sim(ref objvQxRoleMenus_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRoleMenus_SimEN GetObjBymIdWs(long lngmId)
{
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_GetObjBymId(lngmId);
return objvQxRoleMenus_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
try
{
long lngmId = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_Sim_GetFirstID_S", "clsvQxRoleMenus_SimWS:GetFirstID_S", objException.Message);
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
public static clsvQxRoleMenus_SimEN GetFirstvQxRoleMenus_Sim_S(string strWhereCond)
{
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
try
{
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_GetFirstObj_S(strWhereCond);
return objvQxRoleMenus_SimEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRoleMenus_Sim_GetFirstObj_S", "clsvQxRoleMenus_SimWS:GetFirstObj_S", objException.Message);
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
if (arrvQxRoleMenus_SimObjLst_Cache == null)
{
arrvQxRoleMenus_SimObjLst_Cache = clsvQxRoleMenus_SimWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRoleMenus_SimEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxRoleMenus_SimObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxRoleMenus_SimEN = arrvQxRoleMenus_SimObjLst_Cache[intMid];
if (objvQxRoleMenus_SimEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxRoleMenus_SimEN;
}
else if (objvQxRoleMenus_SimEN.mId.CompareTo(lngmId) > 0)
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
arrvQxRoleMenus_SimObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxRoleMenus_Sim对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxRoleMenus_SimEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxRoleMenus_SimEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxRoleMenus_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRoleMenus_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
public static List<clsvQxRoleMenus_SimEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxRoleMenus_SimEN> arrObjLst = new List<clsvQxRoleMenus_SimEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRoleMenus_SimEN objvQxRoleMenus_SimEN = new clsvQxRoleMenus_SimEN();
objvQxRoleMenus_SimEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxRoleMenus_SimEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxRoleMenus_SimEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxRoleMenus_SimEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxRoleMenus_SimEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxRoleMenus_SimEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxRoleMenus_SimEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxRoleMenus_SimEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxRoleMenus_SimEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxRoleMenus_SimEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxRoleMenus_SimEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxRoleMenus_SimEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxRoleMenus_SimEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxRoleMenus_SimEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxRoleMenus_SimEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxRoleMenus_SimEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
	arrObjLst.Add(objvQxRoleMenus_SimEN);
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
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
bool bolIsExist = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_IsExistRecord(strWhereCond);
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
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
bool bolIsExist = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_IsExist(lngmId);
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
vQxRoleMenus_SimServiceSoapClient objvQxRoleMenus_SimService = GetvQxRoleMenus_SimServiceSoapClient();
int intRecCount = objvQxRoleMenus_SimService.vQxRoleMenus_Sim_funGetRecCountByCond(strWhereCond);
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