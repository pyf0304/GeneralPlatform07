
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_LeafWS
 表名:vQxPrjMenus_Leaf(00140085)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:23
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
using GeneralPlatform4WS.ServiceReferencevQxPrjMenus_Leaf;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v三层菜单(vQxPrjMenus_Leaf)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_LeafWS
{
private static string mstrPageName = "vQxPrjMenus_LeafService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjMenus_LeafServiceSoapClient GetvQxPrjMenus_LeafServiceSoapClient()
{
if (objvQxPrjMenus_LeafServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjMenus_LeafServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjMenus_LeafServiceSoapClient(binding, address);
}
else
{
return objvQxPrjMenus_LeafServiceSoapClient;
}
}

 public clsvQxPrjMenus_LeafWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_MenuId_Leaf(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxPrjMenus_LeafEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
objvQxPrjMenus_LeafEN.MenuId_Leaf = "0";
objvQxPrjMenus_LeafEN.MenuName = "请选择[v三层菜单]...";
arrObjLst.Insert(0, objvQxPrjMenus_LeafEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="MenuId_Leaf";
objComboBox.DisplayMember="MenuName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuId_Leaf(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v三层菜单]...","0");
List<clsvQxPrjMenus_LeafEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="MenuId_Leaf";
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
public static int BindLv_vQxPrjMenus_Leaf(System.Windows.Forms.ListView lvvQxPrjMenus_Leaf, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjMenus_Leaf; 
List<clsvQxPrjMenus_LeafEN> arrvQxPrjMenus_LeafObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjMenus_LeafObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjMenus_Leaf.Items.Clear();//清除原来所有Item
lvvQxPrjMenus_Leaf.Columns.Clear();//清除原来所有列头信息
lvvQxPrjMenus_Leaf.Columns.Add("MenuId_Leaf", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("菜单集名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("页面显示模式名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.Columns.Add("MenuControlName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Leaf.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN in arrvQxPrjMenus_LeafObjLst)
{
lvivQxPrjMenus_Leaf = new System.Windows.Forms.ListViewItem();
lvivQxPrjMenus_Leaf.Tag = objvQxPrjMenus_LeafEN.MenuId_Leaf;
lvivQxPrjMenus_Leaf.Text = objvQxPrjMenus_LeafEN.MenuId_Leaf.ToString();
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.MenuName);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.QxPrjId);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.PrjName);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.UpMenuId);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.LinkFile);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.qsParameters);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.ImgFile);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.OrderNum.ToString());
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.IsLeafNode.ToString());
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.MenuSetId);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.MenuSetName);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.MenuTitle);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.PageDispModeId);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.PageDispModeName);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.InUse.ToString());
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.UpdDate);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.UpdUserId);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.Memo);
lvivQxPrjMenus_Leaf.SubItems.Add(objvQxPrjMenus_LeafEN.MenuControlName);
lvvQxPrjMenus_Leaf.Items.Add(lvivQxPrjMenus_Leaf);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjMenus_LeafObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Leaf_GetDataSet", "clsvQxPrjMenus_LeafWS:GetDataTableWs", objException.Message);
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
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Leaf_GetTopDataSet", "clsvQxPrjMenus_LeafWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Leaf_GetDataSetByRange", "clsvQxPrjMenus_LeafWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenus_LeafEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenus_LeafWs(ref clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN)
{
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
bool bolResult = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_GetvQxPrjMenus_Leaf(ref objvQxPrjMenus_LeafEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId_Leaf">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_LeafEN GetObjByMenuId_LeafWs(string strMenuId_Leaf)
{
strMenuId_Leaf = strMenuId_Leaf.Replace("'", "");
strMenuId_Leaf = strMenuId_Leaf.Replace(" ", "");
strMenuId_Leaf = strMenuId_Leaf.Replace("(", "");
strMenuId_Leaf = strMenuId_Leaf.Replace(")", "");
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_GetObjByMenuId_Leaf(strMenuId_Leaf);
return objvQxPrjMenus_LeafEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
try
{
string strMenuId_Leaf = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_GetFirstID_S(strWhereCond);
return strMenuId_Leaf;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Leaf_GetFirstID_S", "clsvQxPrjMenus_LeafWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjMenus_LeafEN GetFirstvQxPrjMenus_Leaf_S(string strWhereCond)
{
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
try
{
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_GetFirstObj_S(strWhereCond);
return objvQxPrjMenus_LeafEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Leaf_GetFirstObj_S", "clsvQxPrjMenus_LeafWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId_Leaf">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuId_Leaf_Cache(string strMenuId_Leaf)
{
if (string.IsNullOrEmpty(strMenuId_Leaf) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenus_LeafObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenus_LeafEN = arrvQxPrjMenus_LeafObjLst_Cache[intMid];
if (objvQxPrjMenus_LeafEN.MenuId_Leaf == strMenuId_Leaf)
{
intFindFailCount = 0;
return objvQxPrjMenus_LeafEN.MenuName;
}
else if (objvQxPrjMenus_LeafEN.MenuId_Leaf.CompareTo(strMenuId_Leaf) > 0)
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
arrvQxPrjMenus_LeafObjLst_Cache = null;
if (intFindFailCount == 1) return GetMenuNameByMenuId_Leaf_Cache(strMenuId_Leaf);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus_Leaf对象缓存列表中,找不到记录[MenuId_Leaf = {0}][intFindFailCount = {1}](函数:{2})", strMenuId_Leaf, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenus_LeafEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenus_LeafEN.MenuId_Leaf, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenus_LeafBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by MenuId_Leaf");
if (arrvQxPrjMenus_LeafObjLst_Cache == null)
{
arrvQxPrjMenus_LeafObjLst_Cache = clsvQxPrjMenus_LeafWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId_Leaf">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_LeafEN GetObjByMenuId_Leaf_Cache(string strMenuId_Leaf)
{
if (string.IsNullOrEmpty(strMenuId_Leaf) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenus_LeafObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenus_LeafEN = arrvQxPrjMenus_LeafObjLst_Cache[intMid];
if (objvQxPrjMenus_LeafEN.MenuId_Leaf == strMenuId_Leaf)
{
intFindFailCount = 0;
return objvQxPrjMenus_LeafEN;
}
else if (objvQxPrjMenus_LeafEN.MenuId_Leaf.CompareTo(strMenuId_Leaf) > 0)
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
arrvQxPrjMenus_LeafObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByMenuId_Leaf_Cache(strMenuId_Leaf);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus_Leaf对象缓存列表中,找不到记录[MenuId_Leaf = {0}][intFindFailCount = {1}](函数:{2})", strMenuId_Leaf, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenus_LeafEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenus_LeafEN.MenuId_Leaf, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenus_LeafBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_LeafEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
objvQxPrjMenus_LeafEN.MenuId_Leaf = objRow["MenuId_Leaf"].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
public static List<clsvQxPrjMenus_LeafEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjMenus_LeafEN> arrObjLst = new List<clsvQxPrjMenus_LeafEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_LeafEN objvQxPrjMenus_LeafEN = new clsvQxPrjMenus_LeafEN();
objvQxPrjMenus_LeafEN.MenuId_Leaf = objRow["MenuId_Leaf"].ToString().Trim(); //MenuId_Leaf
objvQxPrjMenus_LeafEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenus_LeafEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenus_LeafEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenus_LeafEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_LeafEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenus_LeafEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenus_LeafEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenus_LeafEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenus_LeafEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenus_LeafEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenus_LeafEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenus_LeafEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenus_LeafEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_LeafEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_LeafEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenus_LeafEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenus_LeafEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenus_LeafEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenus_LeafEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
	arrObjLst.Add(objvQxPrjMenus_LeafEN);
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
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
bool bolIsExist = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strMenuId_Leaf)
{
//检测记录是否存在
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
bool bolIsExist = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_IsExist(strMenuId_Leaf);
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
vQxPrjMenus_LeafServiceSoapClient objvQxPrjMenus_LeafService = GetvQxPrjMenus_LeafServiceSoapClient();
int intRecCount = objvQxPrjMenus_LeafService.vQxPrjMenus_Leaf_funGetRecCountByCond(strWhereCond);
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