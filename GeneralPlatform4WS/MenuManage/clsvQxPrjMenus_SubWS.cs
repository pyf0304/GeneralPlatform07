
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_SubWS
 表名:vQxPrjMenus_Sub(00140079)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:21
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
using GeneralPlatform4WS.ServiceReferencevQxPrjMenus_Sub;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v子层菜单(vQxPrjMenus_Sub)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_SubWS
{
private static string mstrPageName = "vQxPrjMenus_SubService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjMenus_SubServiceSoapClient GetvQxPrjMenus_SubServiceSoapClient()
{
if (objvQxPrjMenus_SubServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjMenus_SubServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjMenus_SubServiceSoapClient(binding, address);
}
else
{
return objvQxPrjMenus_SubServiceSoapClient;
}
}

 public clsvQxPrjMenus_SubWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_MenuId_Sub(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxPrjMenus_SubEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
objvQxPrjMenus_SubEN.MenuId_Sub = "0";
objvQxPrjMenus_SubEN.MenuName = "请选择[v子层菜单]...";
arrObjLst.Insert(0, objvQxPrjMenus_SubEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="MenuId_Sub";
objComboBox.DisplayMember="MenuName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuId_Sub(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v子层菜单]...","0");
List<clsvQxPrjMenus_SubEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="MenuId_Sub";
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
public static int BindLv_vQxPrjMenus_Sub(System.Windows.Forms.ListView lvvQxPrjMenus_Sub, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjMenus_Sub; 
List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjMenus_SubObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjMenus_Sub.Items.Clear();//清除原来所有Item
lvvQxPrjMenus_Sub.Columns.Clear();//清除原来所有列头信息
lvvQxPrjMenus_Sub.Columns.Add("MenuId_Sub", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("菜单集名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("页面显示模式名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.Columns.Add("MenuControlName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Sub.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN in arrvQxPrjMenus_SubObjLst)
{
lvivQxPrjMenus_Sub = new System.Windows.Forms.ListViewItem();
lvivQxPrjMenus_Sub.Tag = objvQxPrjMenus_SubEN.MenuId_Sub;
lvivQxPrjMenus_Sub.Text = objvQxPrjMenus_SubEN.MenuId_Sub.ToString();
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.MenuName);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.QxPrjId);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.PrjName);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.UpMenuId);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.LinkFile);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.qsParameters);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.ImgFile);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.OrderNum.ToString());
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.IsLeafNode.ToString());
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.MenuSetId);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.MenuSetName);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.MenuTitle);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.PageDispModeId);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.PageDispModeName);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.InUse.ToString());
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.UpdDate);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.UpdUserId);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.Memo);
lvivQxPrjMenus_Sub.SubItems.Add(objvQxPrjMenus_SubEN.MenuControlName);
lvvQxPrjMenus_Sub.Items.Add(lvivQxPrjMenus_Sub);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjMenus_SubObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Sub_GetDataSet", "clsvQxPrjMenus_SubWS:GetDataTableWs", objException.Message);
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
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Sub_GetTopDataSet", "clsvQxPrjMenus_SubWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Sub_GetDataSetByRange", "clsvQxPrjMenus_SubWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenus_SubEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenus_SubWs(ref clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN)
{
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
bool bolResult = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_GetvQxPrjMenus_Sub(ref objvQxPrjMenus_SubEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId_Sub">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_SubEN GetObjByMenuId_SubWs(string strMenuId_Sub)
{
strMenuId_Sub = strMenuId_Sub.Replace("'", "");
strMenuId_Sub = strMenuId_Sub.Replace(" ", "");
strMenuId_Sub = strMenuId_Sub.Replace("(", "");
strMenuId_Sub = strMenuId_Sub.Replace(")", "");
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_GetObjByMenuId_Sub(strMenuId_Sub);
return objvQxPrjMenus_SubEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
try
{
string strMenuId_Sub = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_GetFirstID_S(strWhereCond);
return strMenuId_Sub;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Sub_GetFirstID_S", "clsvQxPrjMenus_SubWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjMenus_SubEN GetFirstvQxPrjMenus_Sub_S(string strWhereCond)
{
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
try
{
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_GetFirstObj_S(strWhereCond);
return objvQxPrjMenus_SubEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Sub_GetFirstObj_S", "clsvQxPrjMenus_SubWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId_Sub">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuId_Sub_Cache(string strMenuId_Sub)
{
if (string.IsNullOrEmpty(strMenuId_Sub) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenus_SubObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenus_SubEN = arrvQxPrjMenus_SubObjLst_Cache[intMid];
if (objvQxPrjMenus_SubEN.MenuId_Sub == strMenuId_Sub)
{
intFindFailCount = 0;
return objvQxPrjMenus_SubEN.MenuName;
}
else if (objvQxPrjMenus_SubEN.MenuId_Sub.CompareTo(strMenuId_Sub) > 0)
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
arrvQxPrjMenus_SubObjLst_Cache = null;
if (intFindFailCount == 1) return GetMenuNameByMenuId_Sub_Cache(strMenuId_Sub);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus_Sub对象缓存列表中,找不到记录[MenuId_Sub = {0}][intFindFailCount = {1}](函数:{2})", strMenuId_Sub, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenus_SubEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenus_SubEN.MenuId_Sub, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenus_SubBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by MenuId_Sub");
if (arrvQxPrjMenus_SubObjLst_Cache == null)
{
arrvQxPrjMenus_SubObjLst_Cache = clsvQxPrjMenus_SubWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId_Sub">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_SubEN GetObjByMenuId_Sub_Cache(string strMenuId_Sub)
{
if (string.IsNullOrEmpty(strMenuId_Sub) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenus_SubObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenus_SubEN = arrvQxPrjMenus_SubObjLst_Cache[intMid];
if (objvQxPrjMenus_SubEN.MenuId_Sub == strMenuId_Sub)
{
intFindFailCount = 0;
return objvQxPrjMenus_SubEN;
}
else if (objvQxPrjMenus_SubEN.MenuId_Sub.CompareTo(strMenuId_Sub) > 0)
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
arrvQxPrjMenus_SubObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByMenuId_Sub_Cache(strMenuId_Sub);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus_Sub对象缓存列表中,找不到记录[MenuId_Sub = {0}][intFindFailCount = {1}](函数:{2})", strMenuId_Sub, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenus_SubEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenus_SubEN.MenuId_Sub, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenus_SubBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_SubEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
objvQxPrjMenus_SubEN.MenuId_Sub = objRow["MenuId_Sub"].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
public static List<clsvQxPrjMenus_SubEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjMenus_SubEN> arrObjLst = new List<clsvQxPrjMenus_SubEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_SubEN objvQxPrjMenus_SubEN = new clsvQxPrjMenus_SubEN();
objvQxPrjMenus_SubEN.MenuId_Sub = objRow["MenuId_Sub"].ToString().Trim(); //MenuId_Sub
objvQxPrjMenus_SubEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenus_SubEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenus_SubEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenus_SubEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_SubEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenus_SubEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenus_SubEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenus_SubEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenus_SubEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenus_SubEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenus_SubEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenus_SubEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenus_SubEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_SubEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_SubEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenus_SubEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenus_SubEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenus_SubEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenus_SubEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
	arrObjLst.Add(objvQxPrjMenus_SubEN);
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
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
bool bolIsExist = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strMenuId_Sub)
{
//检测记录是否存在
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
bool bolIsExist = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_IsExist(strMenuId_Sub);
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
vQxPrjMenus_SubServiceSoapClient objvQxPrjMenus_SubService = GetvQxPrjMenus_SubServiceSoapClient();
int intRecCount = objvQxPrjMenus_SubService.vQxPrjMenus_Sub_funGetRecCountByCond(strWhereCond);
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