
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_UpWS
 表名:vQxPrjMenus_Up(00140080)
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
using GeneralPlatform4WS.ServiceReferencevQxPrjMenus_Up;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v顶层菜单(vQxPrjMenus_Up)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_UpWS
{
private static string mstrPageName = "vQxPrjMenus_UpService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjMenus_UpServiceSoapClient GetvQxPrjMenus_UpServiceSoapClient()
{
if (objvQxPrjMenus_UpServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjMenus_UpServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjMenus_UpServiceSoapClient(binding, address);
}
else
{
return objvQxPrjMenus_UpServiceSoapClient;
}
}

 public clsvQxPrjMenus_UpWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_MenuId_Up(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxPrjMenus_UpEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
objvQxPrjMenus_UpEN.MenuId_Up = "0";
objvQxPrjMenus_UpEN.MenuName = "请选择[v顶层菜单]...";
arrObjLst.Insert(0, objvQxPrjMenus_UpEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="MenuId_Up";
objComboBox.DisplayMember="MenuName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuId_Up(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v顶层菜单]...","0");
List<clsvQxPrjMenus_UpEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="MenuId_Up";
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
public static int BindLv_vQxPrjMenus_Up(System.Windows.Forms.ListView lvvQxPrjMenus_Up, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjMenus_Up; 
List<clsvQxPrjMenus_UpEN> arrvQxPrjMenus_UpObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjMenus_UpObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjMenus_Up.Items.Clear();//清除原来所有Item
lvvQxPrjMenus_Up.Columns.Clear();//清除原来所有列头信息
lvvQxPrjMenus_Up.Columns.Add("MenuId_Up", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("菜单集名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("页面显示模式名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.Columns.Add("MenuControlName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjMenus_Up.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN in arrvQxPrjMenus_UpObjLst)
{
lvivQxPrjMenus_Up = new System.Windows.Forms.ListViewItem();
lvivQxPrjMenus_Up.Tag = objvQxPrjMenus_UpEN.MenuId_Up;
lvivQxPrjMenus_Up.Text = objvQxPrjMenus_UpEN.MenuId_Up.ToString();
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.MenuName);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.QxPrjId);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.PrjName);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.UpMenuId);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.LinkFile);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.qsParameters);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.ImgFile);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.OrderNum.ToString());
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.IsLeafNode.ToString());
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.MenuSetId);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.MenuSetName);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.MenuTitle);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.PageDispModeId);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.PageDispModeName);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.InUse.ToString());
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.UpdDate);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.UpdUserId);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.Memo);
lvivQxPrjMenus_Up.SubItems.Add(objvQxPrjMenus_UpEN.MenuControlName);
lvvQxPrjMenus_Up.Items.Add(lvivQxPrjMenus_Up);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjMenus_UpObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_UpService.vQxPrjMenus_Up_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Up_GetDataSet", "clsvQxPrjMenus_UpWS:GetDataTableWs", objException.Message);
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
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_UpService.vQxPrjMenus_Up_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Up_GetTopDataSet", "clsvQxPrjMenus_UpWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjMenus_UpService.vQxPrjMenus_Up_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Up_GetDataSetByRange", "clsvQxPrjMenus_UpWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjMenus_UpEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjMenus_UpWs(ref clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN)
{
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
bool bolResult = objvQxPrjMenus_UpService.vQxPrjMenus_Up_GetvQxPrjMenus_Up(ref objvQxPrjMenus_UpEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId_Up">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjMenus_UpEN GetObjByMenuId_UpWs(string strMenuId_Up)
{
strMenuId_Up = strMenuId_Up.Replace("'", "");
strMenuId_Up = strMenuId_Up.Replace(" ", "");
strMenuId_Up = strMenuId_Up.Replace("(", "");
strMenuId_Up = strMenuId_Up.Replace(")", "");
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = objvQxPrjMenus_UpService.vQxPrjMenus_Up_GetObjByMenuId_Up(strMenuId_Up);
return objvQxPrjMenus_UpEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
try
{
string strMenuId_Up = objvQxPrjMenus_UpService.vQxPrjMenus_Up_GetFirstID_S(strWhereCond);
return strMenuId_Up;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Up_GetFirstID_S", "clsvQxPrjMenus_UpWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjMenus_UpEN GetFirstvQxPrjMenus_Up_S(string strWhereCond)
{
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
try
{
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = objvQxPrjMenus_UpService.vQxPrjMenus_Up_GetFirstObj_S(strWhereCond);
return objvQxPrjMenus_UpEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjMenus_Up_GetFirstObj_S", "clsvQxPrjMenus_UpWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId_Up">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuNameByMenuId_Up_Cache(string strMenuId_Up)
{
if (string.IsNullOrEmpty(strMenuId_Up) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenus_UpObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenus_UpEN = arrvQxPrjMenus_UpObjLst_Cache[intMid];
if (objvQxPrjMenus_UpEN.MenuId_Up == strMenuId_Up)
{
intFindFailCount = 0;
return objvQxPrjMenus_UpEN.MenuName;
}
else if (objvQxPrjMenus_UpEN.MenuId_Up.CompareTo(strMenuId_Up) > 0)
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
arrvQxPrjMenus_UpObjLst_Cache = null;
if (intFindFailCount == 1) return GetMenuNameByMenuId_Up_Cache(strMenuId_Up);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus_Up对象缓存列表中,找不到记录[MenuId_Up = {0}][intFindFailCount = {1}](函数:{2})", strMenuId_Up, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenus_UpEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenus_UpEN.MenuId_Up, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenus_UpBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by MenuId_Up");
if (arrvQxPrjMenus_UpObjLst_Cache == null)
{
arrvQxPrjMenus_UpObjLst_Cache = clsvQxPrjMenus_UpWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId_Up">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjMenus_UpEN GetObjByMenuId_Up_Cache(string strMenuId_Up)
{
if (string.IsNullOrEmpty(strMenuId_Up) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjMenus_UpObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjMenus_UpEN = arrvQxPrjMenus_UpObjLst_Cache[intMid];
if (objvQxPrjMenus_UpEN.MenuId_Up == strMenuId_Up)
{
intFindFailCount = 0;
return objvQxPrjMenus_UpEN;
}
else if (objvQxPrjMenus_UpEN.MenuId_Up.CompareTo(strMenuId_Up) > 0)
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
arrvQxPrjMenus_UpObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByMenuId_Up_Cache(strMenuId_Up);
string strErrMsgForGetObjById = string.Format("在vQxPrjMenus_Up对象缓存列表中,找不到记录[MenuId_Up = {0}][intFindFailCount = {1}](函数:{2})", strMenuId_Up, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjMenus_UpEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjMenus_UpEN.MenuId_Up, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjMenus_UpBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjMenus_UpEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
objvQxPrjMenus_UpEN.MenuId_Up = objRow["MenuId_Up"].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
public static List<clsvQxPrjMenus_UpEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjMenus_UpEN> arrObjLst = new List<clsvQxPrjMenus_UpEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjMenus_UpEN objvQxPrjMenus_UpEN = new clsvQxPrjMenus_UpEN();
objvQxPrjMenus_UpEN.MenuId_Up = objRow["MenuId_Up"].ToString().Trim(); //MenuId_Up
objvQxPrjMenus_UpEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjMenus_UpEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjMenus_UpEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjMenus_UpEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjMenus_UpEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objvQxPrjMenus_UpEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objvQxPrjMenus_UpEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objvQxPrjMenus_UpEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxPrjMenus_UpEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjMenus_UpEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objvQxPrjMenus_UpEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objvQxPrjMenus_UpEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objvQxPrjMenus_UpEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objvQxPrjMenus_UpEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objvQxPrjMenus_UpEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjMenus_UpEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjMenus_UpEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjMenus_UpEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjMenus_UpEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
	arrObjLst.Add(objvQxPrjMenus_UpEN);
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
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
bool bolIsExist = objvQxPrjMenus_UpService.vQxPrjMenus_Up_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strMenuId_Up)
{
//检测记录是否存在
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
bool bolIsExist = objvQxPrjMenus_UpService.vQxPrjMenus_Up_IsExist(strMenuId_Up);
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
vQxPrjMenus_UpServiceSoapClient objvQxPrjMenus_UpService = GetvQxPrjMenus_UpServiceSoapClient();
int intRecCount = objvQxPrjMenus_UpService.vQxPrjMenus_Up_funGetRecCountByCond(strWhereCond);
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