
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenusWS
 表名:vQxPrjMenus(00140046)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:06
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
using GeneralPlatform4WS.ServiceReferencevQxPrjMenus;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v工程菜单(vQxPrjMenus)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenusWS
{
private static string mstrPageName = "vQxPrjMenusService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjMenusServiceSoapClient objvQxPrjMenusServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjMenusServiceSoapClient GetvQxPrjMenusServiceSoapClient()
{
if (objvQxPrjMenusServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjMenusServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjMenusServiceSoapClient(binding, address);
}
else
{
return objvQxPrjMenusServiceSoapClient;
}
}

 public clsvQxPrjMenusWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_MenuId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxPrjMenusEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
objvQxPrjMenusEN.MenuId = "0";
objvQxPrjMenusEN.MenuName = "请选择[v工程菜单]...";
arrObjLst.Insert(0, objvQxPrjMenusEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="MenuId";
objComboBox.DisplayMember="MenuName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v工程菜单]...","0");
List<clsvQxPrjMenusEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="MenuId";
objDDL.DataTextField="MenuName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxPrjMenus(System.Windows.Forms.ListView lvvQxPrjMenus, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjMenus; 
List<clsvQxPrjMenusEN> arrvQxPrjMenusObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjMenusObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjMenus.Items.Clear();//清除原来所有Item
lvvQxPrjMenus.Columns.Clear();//清除原来所有列头信息
lvvQxPrjMenus.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("菜单集名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("页面显示模式名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("MenuControlName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("应用程序类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("应用程序类型名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("上级菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("子菜单数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.Columns.Add("角色数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjMenusEN objvQxPrjMenusEN in arrvQxPrjMenusObjLst)
{
lvivQxPrjMenus = new System.Windows.Forms.ListViewItem();
lvivQxPrjMenus.Tag = objvQxPrjMenusEN.MenuId;
lvivQxPrjMenus.Text = objvQxPrjMenusEN.MenuId.ToString();
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.MenuName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.QxPrjId);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.PrjName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.UpMenuId);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.LinkFile);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.qsParameters);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.ImgFile);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.RoleId);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.RoleName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.OrderNum.ToString());
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.IsLeafNode.ToString());
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.MenuSetId);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.MenuSetName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.MenuTitle);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.PageDispModeId);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.PageDispModeName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.InUse.ToString());
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.MenuControlName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.ApplicationTypeId.ToString());
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.ApplicationTypeName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.UpdDate);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.UpdUserId);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.Memo);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.UpMenuName);
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.SubMenusNum.ToString());
lvivQxPrjMenus.SubItems.Add(objvQxPrjMenusEN.RoleNum.ToString());
lvvQxPrjMenus.Items.Add(lvivQxPrjMenus);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjMenusObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenusService.vQxPrjMenus_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_GetDataSet", "clsvQxPrjMenusWS:GetDataTableWs", objException.Message);
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
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenusService.vQxPrjMenus_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_GetTopDataSet", "clsvQxPrjMenusWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenusService.vQxPrjMenus_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_GetDataSetByRange", "clsvQxPrjMenusWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenusWs(ref clsvQxPrjMenusEN objvQxPrjMenusEN)
{
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
bool bolResult = objvQxPrjMenusService.vQxPrjMenus_GetvQxPrjMenus(ref objvQxPrjMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenusEN GetObjByMenuIdWs(string strMenuId)
{
strMenuId = strMenuId.Replace("'", "");
strMenuId = strMenuId.Replace(" ", "");
strMenuId = strMenuId.Replace("(", "");
strMenuId = strMenuId.Replace(")", "");
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
clsvQxPrjMenusEN objvQxPrjMenusEN = objvQxPrjMenusService.vQxPrjMenus_GetObjByMenuId(strMenuId);
return objvQxPrjMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
try
{
string strMenuId = objvQxPrjMenusService.vQxPrjMenus_GetFirstID_S(strWhereCond);
return strMenuId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_GetFirstID_S", "clsvQxPrjMenusWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjMenusEN GetFirstvQxPrjMenus_S(string strWhereCond)
{
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
try
{
clsvQxPrjMenusEN objvQxPrjMenusEN = objvQxPrjMenusService.vQxPrjMenus_GetFirstObj_S(strWhereCond);
return objvQxPrjMenusEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_GetFirstObj_S", "clsvQxPrjMenusWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuId_Cache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenusObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenusEN objvQxPrjMenusEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenusEN = arrvQxPrjMenusObjLst_Cache[intMid];
if (objvQxPrjMenusEN.MenuId == strMenuId)
{
intFindFailCount = 0;
return objvQxPrjMenusEN.MenuName;
}
else if (objvQxPrjMenusEN.MenuId.CompareTo(strMenuId) > 0)
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
arrvQxPrjMenusObjLst_Cache = null;
if (intFindFailCount == 1) return GetMenuNameByMenuId_Cache(strMenuId);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus对象缓存列表中,找不到记录[MenuId = {0}][intFindFailCount = {1}](函数:{2})", strMenuId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenusEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenusEN.MenuId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by MenuId");
if (arrvQxPrjMenusObjLst_Cache == null)
{
arrvQxPrjMenusObjLst_Cache = clsvQxPrjMenusWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenusEN GetObjByMenuId_Cache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenusObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenusEN objvQxPrjMenusEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenusEN = arrvQxPrjMenusObjLst_Cache[intMid];
if (objvQxPrjMenusEN.MenuId == strMenuId)
{
intFindFailCount = 0;
return objvQxPrjMenusEN;
}
else if (objvQxPrjMenusEN.MenuId.CompareTo(strMenuId) > 0)
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
arrvQxPrjMenusObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByMenuId_Cache(strMenuId);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus对象缓存列表中,找不到记录[MenuId = {0}][intFindFailCount = {1}](函数:{2})", strMenuId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenusEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenusEN.MenuId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenusEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
objvQxPrjMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow["ApplicationTypeId"].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow["ApplicationTypeName"].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["SubMenusNum"].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleNum"].ToString().Trim()); //角色数
	arrObjLst.Add(objvQxPrjMenusEN);
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
public static List<clsvQxPrjMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjMenusEN> arrObjLst = new List<clsvQxPrjMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenusEN objvQxPrjMenusEN = new clsvQxPrjMenusEN();
objvQxPrjMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxPrjMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenusEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxPrjMenusEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxPrjMenusEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenusEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenusEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenusEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
objvQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow["ApplicationTypeId"].ToString().Trim()); //应用程序类型ID
objvQxPrjMenusEN.ApplicationTypeName = objRow["ApplicationTypeName"].ToString().Trim(); //应用程序类型名称
objvQxPrjMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenusEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
objvQxPrjMenusEN.SubMenusNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["SubMenusNum"].ToString().Trim()); //子菜单数
objvQxPrjMenusEN.RoleNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleNum"].ToString().Trim()); //角色数
	arrObjLst.Add(objvQxPrjMenusEN);
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
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
bool bolIsExist = objvQxPrjMenusService.vQxPrjMenus_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strMenuId)
{
//检测记录是否存在
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
bool bolIsExist = objvQxPrjMenusService.vQxPrjMenus_IsExist(strMenuId);
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
vQxPrjMenusServiceSoapClient objvQxPrjMenusService = GetvQxPrjMenusServiceSoapClient();
int intRecCount = objvQxPrjMenusService.vQxPrjMenus_funGetRecCountByCond(strWhereCond);
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