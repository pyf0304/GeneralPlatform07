
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusWS
 表名:QxPrjMenus(00140004)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:50
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
using GeneralPlatform4WS.ServiceReferenceQxPrjMenus;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 工程菜单(QxPrjMenus)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjMenusWS
{
private static string mstrPageName = "QxPrjMenusService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPrjMenusEN> arrQxPrjMenusObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPrjMenusServiceSoapClient objQxPrjMenusServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPrjMenusServiceSoapClient GetQxPrjMenusServiceSoapClient()
{
if (objQxPrjMenusServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPrjMenusServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPrjMenusServiceSoapClient(binding, address);
}
else
{
return objQxPrjMenusServiceSoapClient;
}
}

 public clsQxPrjMenusWS()
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
List<clsQxPrjMenusEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
objQxPrjMenusEN.MenuId = "0";
objQxPrjMenusEN.MenuName = "请选择[工程菜单]...";
arrObjLst.Insert(0, objQxPrjMenusEN);
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工程菜单]...","0");
List<clsQxPrjMenusEN> arrObjLst = GetObjLst("1 = 1");
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
public static int BindLv_QxPrjMenus(System.Windows.Forms.ListView lvQxPrjMenus, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPrjMenus; 
List<clsQxPrjMenusEN> arrQxPrjMenusObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPrjMenusObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPrjMenus.Items.Clear();//清除原来所有Item
lvQxPrjMenus.Columns.Clear();//清除原来所有列头信息
lvQxPrjMenus.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("qs参数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("MenuControlName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("应用程序类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenus.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjMenusEN objQxPrjMenusEN in arrQxPrjMenusObjLst)
{
lviQxPrjMenus = new System.Windows.Forms.ListViewItem();
lviQxPrjMenus.Tag = objQxPrjMenusEN.MenuId;
lviQxPrjMenus.Text = objQxPrjMenusEN.MenuId.ToString();
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.MenuName);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.LinkFile);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.qsParameters);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.ImgFile);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.OrderNum.ToString());
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.IsLeafNode.ToString());
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.MenuSetId);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.MenuTitle);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.PageDispModeId);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.InUse.ToString());
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.MenuControlName);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.ApplicationTypeId.ToString());
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.UpdDate);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.UpdUserId);
lviQxPrjMenus.SubItems.Add(objQxPrjMenusEN.Memo);
lvQxPrjMenus.Items.Add(lviQxPrjMenus);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPrjMenusObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjMenusEN objQxPrjMenusEN)
{
if (!Object.Equals(null, objQxPrjMenusEN.MenuId) && GetStrLen(objQxPrjMenusEN.MenuId) > 8)
{
 throw new Exception("字段[菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjMenusEN.MenuName) && GetStrLen(objQxPrjMenusEN.MenuName) > 50)
{
 throw new Exception("字段[菜单名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenusEN.QxPrjId) && GetStrLen(objQxPrjMenusEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjMenusEN.UpMenuId) && GetStrLen(objQxPrjMenusEN.UpMenuId) > 8)
{
 throw new Exception("字段[上级菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjMenusEN.LinkFile) && GetStrLen(objQxPrjMenusEN.LinkFile) > 500)
{
 throw new Exception("字段[链接文件]的长度不能超过500!");
}
if (!Object.Equals(null, objQxPrjMenusEN.qsParameters) && GetStrLen(objQxPrjMenusEN.qsParameters) > 200)
{
 throw new Exception("字段[qs参数]的长度不能超过200!");
}
if (!Object.Equals(null, objQxPrjMenusEN.ImgFile) && GetStrLen(objQxPrjMenusEN.ImgFile) > 300)
{
 throw new Exception("字段[图像文件]的长度不能超过300!");
}
if (!Object.Equals(null, objQxPrjMenusEN.RoleId) && GetStrLen(objQxPrjMenusEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjMenusEN.MenuSetId) && GetStrLen(objQxPrjMenusEN.MenuSetId) > 4)
{
 throw new Exception("字段[菜单集Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjMenusEN.MenuTitle) && GetStrLen(objQxPrjMenusEN.MenuTitle) > 50)
{
 throw new Exception("字段[菜单标题]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenusEN.PageDispModeId) && GetStrLen(objQxPrjMenusEN.PageDispModeId) > 2)
{
 throw new Exception("字段[页面显示模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPrjMenusEN.MenuControlName) && GetStrLen(objQxPrjMenusEN.MenuControlName) > 100)
{
 throw new Exception("字段[MenuControlName]的长度不能超过100!");
}
if (!Object.Equals(null, objQxPrjMenusEN.UpdDate) && GetStrLen(objQxPrjMenusEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxPrjMenusEN.UpdUserId) && GetStrLen(objQxPrjMenusEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjMenusEN.Memo) && GetStrLen(objQxPrjMenusEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 }

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenusService.QxPrjMenus_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_GetDataSet", "clsQxPrjMenusWS:GetDataTableWs", objException.Message);
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
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenusService.QxPrjMenus_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_GetTopDataSet", "clsQxPrjMenusWS:GetDataTable_TopWs", objException.Message);
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
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenusService.QxPrjMenus_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_GetDataSetByRange", "clsQxPrjMenusWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenusService.QxPrjMenus_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_GetDataSetV", "clsQxPrjMenusWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPrjMenusVWs(string strWhereCond)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenusService.QxPrjMenus_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_GetDataSetV", "clsQxPrjMenusWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjMenusWs(ref clsQxPrjMenusEN objQxPrjMenusEN)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
bool bolResult = objQxPrjMenusService.QxPrjMenus_GetQxPrjMenus(ref objQxPrjMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenusEN GetObjByMenuIdWs(string strMenuId)
{
strMenuId = strMenuId.Replace("'", "");
strMenuId = strMenuId.Replace(" ", "");
strMenuId = strMenuId.Replace("(", "");
strMenuId = strMenuId.Replace(")", "");
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
clsQxPrjMenusEN objQxPrjMenusEN = objQxPrjMenusService.QxPrjMenus_GetObjByMenuId(strMenuId);
return objQxPrjMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
string strMenuId = objQxPrjMenusService.QxPrjMenus_GetFirstID_S(strWhereCond);
return strMenuId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_GetFirstID_S", "clsQxPrjMenusWS:GetFirstID_S", objException.Message);
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
public static clsQxPrjMenusEN GetFirstQxPrjMenus_S(string strWhereCond)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
clsQxPrjMenusEN objQxPrjMenusEN = objQxPrjMenusService.QxPrjMenus_GetFirstObj_S(strWhereCond);
return objQxPrjMenusEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_GetFirstObj_S", "clsQxPrjMenusWS:GetFirstObj_S", objException.Message);
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
int intEnd = arrQxPrjMenusObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjMenusEN objQxPrjMenusEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjMenusEN = arrQxPrjMenusObjLst_Cache[intMid];
if (objQxPrjMenusEN.MenuId == strMenuId)
{
intFindFailCount = 0;
return objQxPrjMenusEN.MenuName;
}
else if (objQxPrjMenusEN.MenuId.CompareTo(strMenuId) > 0)
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
arrQxPrjMenusObjLst_Cache = null;
if (intFindFailCount == 1) return GetMenuNameByMenuId_Cache(strMenuId);
string strErrMsgForGetObjById = string.Format("在QxPrjMenus对象缓存列表中,找不到记录[MenuId = {0}][intFindFailCount = {1}](函数:{2})", strMenuId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjMenusEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjMenusEN.MenuId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
if (arrQxPrjMenusObjLst_Cache == null)
{
arrQxPrjMenusObjLst_Cache = clsQxPrjMenusWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenusEN GetObjByMenuId_Cache(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjMenusObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjMenusEN objQxPrjMenusEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjMenusEN = arrQxPrjMenusObjLst_Cache[intMid];
if (objQxPrjMenusEN.MenuId == strMenuId)
{
intFindFailCount = 0;
return objQxPrjMenusEN;
}
else if (objQxPrjMenusEN.MenuId.CompareTo(strMenuId) > 0)
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
arrQxPrjMenusObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByMenuId_Cache(strMenuId);
string strErrMsgForGetObjById = string.Format("在QxPrjMenus对象缓存列表中,找不到记录[MenuId = {0}][intFindFailCount = {1}](函数:{2})", strMenuId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjMenusEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjMenusEN.MenuId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenusEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
objQxPrjMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objQxPrjMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objQxPrjMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow["ApplicationTypeId"].ToString().Trim()); //应用程序类型ID
objQxPrjMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjMenusEN);
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
public static List<clsQxPrjMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPrjMenusEN> arrObjLst = new List<clsQxPrjMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenusEN objQxPrjMenusEN = new clsQxPrjMenusEN();
objQxPrjMenusEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objQxPrjMenusEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objQxPrjMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjMenusEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objQxPrjMenusEN.LinkFile = objRow["LinkFile"].ToString().Trim(); //链接文件
objQxPrjMenusEN.qsParameters = objRow["qsParameters"].ToString().Trim(); //qs参数
objQxPrjMenusEN.ImgFile = objRow["ImgFile"].ToString().Trim(); //图像文件
objQxPrjMenusEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objQxPrjMenusEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objQxPrjMenusEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objQxPrjMenusEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objQxPrjMenusEN.MenuTitle = objRow["MenuTitle"].ToString().Trim(); //菜单标题
objQxPrjMenusEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objQxPrjMenusEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objQxPrjMenusEN.MenuControlName = objRow["MenuControlName"].ToString().Trim(); //MenuControlName
objQxPrjMenusEN.ApplicationTypeId = Int32.Parse(objRow["ApplicationTypeId"].ToString().Trim()); //应用程序类型ID
objQxPrjMenusEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjMenusEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjMenusEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strMenuId)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
int intResult = objQxPrjMenusService.QxPrjMenus_DelRecord(strMenuId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_DelRecord", "clsQxPrjMenusWS:DelRecordWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxPrjMenussWs(List<string> arrMenuId)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrMenuId);
int intResult = objQxPrjMenusService.QxPrjMenus_DelQxPrjMenuss(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_DelQxPrjMenuss", "clsQxPrjMenusWS:DelQxPrjMenussWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxPrjMenussByCondWs(string strWhereCond)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
int intRecNum = objQxPrjMenusService.QxPrjMenus_DelQxPrjMenussByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_DelQxPrjMenussByCond", "clsQxPrjMenusWS:DelQxPrjMenussByCondWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecordBySql2Ws(clsQxPrjMenusEN objQxPrjMenusEN)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
bool bolResult = objQxPrjMenusService.QxPrjMenus_AddNewRecordBySql2(objQxPrjMenusEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_AddNewRecordBySql2", "clsQxPrjMenusWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateBySql2Ws(clsQxPrjMenusEN objQxPrjMenusEN)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
bool bolResult = objQxPrjMenusService.QxPrjMenus_UpdateBySql2(objQxPrjMenusEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_UpdateBySql2", "clsQxPrjMenusWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPrjMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPrjMenusEN objQxPrjMenusEN, string strWhereCond)
{
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
try
{
bool bolResult = objQxPrjMenusService.QxPrjMenus_UpdateBySqlWithCondition(objQxPrjMenusEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenus_UpdateBySqlWithCondition", "clsQxPrjMenusWS:UpdateBySqlWithCondition", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
bool bolIsExist = objQxPrjMenusService.QxPrjMenus_IsExistRecord(strWhereCond);
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
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
bool bolIsExist = objQxPrjMenusService.QxPrjMenus_IsExist(strMenuId);
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
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
int intRecCount = objQxPrjMenusService.QxPrjMenus_funGetRecCountByCond(strWhereCond);
return intRecCount;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdWs()
{
//检测记录是否存在
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
string strMaxMenuId = objQxPrjMenusService.QxPrjMenus_GetMaxStrId();
return strMaxMenuId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxPrjMenusServiceSoapClient objQxPrjMenusService = GetQxPrjMenusServiceSoapClient();
string strMaxMenuId = objQxPrjMenusService.QxPrjMenus_GetMaxStrIdByPrefix(strPrefix);
return strMaxMenuId;
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
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