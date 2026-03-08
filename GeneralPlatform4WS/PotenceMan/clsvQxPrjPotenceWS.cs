
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjPotenceWS
 表名:vQxPrjPotence(00140027)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:00
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
using GeneralPlatform4WS.ServiceReferencevQxPrjPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v工程权限(vQxPrjPotence)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjPotenceWS
{
private static string mstrPageName = "vQxPrjPotenceService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjPotenceServiceSoapClient objvQxPrjPotenceServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjPotenceServiceSoapClient GetvQxPrjPotenceServiceSoapClient()
{
if (objvQxPrjPotenceServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjPotenceServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjPotenceServiceSoapClient(binding, address);
}
else
{
return objvQxPrjPotenceServiceSoapClient;
}
}

 public clsvQxPrjPotenceWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_PotenceId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxPrjPotenceEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
objvQxPrjPotenceEN.PotenceId = "0";
objvQxPrjPotenceEN.PotenceName = "请选择[v工程权限]...";
arrObjLst.Insert(0, objvQxPrjPotenceEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="PotenceId";
objComboBox.DisplayMember="PotenceName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v工程权限]...","0");
List<clsvQxPrjPotenceEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="PotenceId";
objDDL.DataTextField="PotenceName";
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
public static int BindLv_vQxPrjPotence(System.Windows.Forms.ListView lvvQxPrjPotence, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjPotence; 
List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjPotenceObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjPotence.Items.Clear();//清除原来所有Item
lvvQxPrjPotence.Columns.Clear();//清除原来所有列头信息
lvvQxPrjPotence.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("权限名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("模块Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("权限类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("权限类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("模块名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("模块名_Sim", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("上级菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.Columns.Add("标志数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjPotence.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjPotenceEN objvQxPrjPotenceEN in arrvQxPrjPotenceObjLst)
{
lvivQxPrjPotence = new System.Windows.Forms.ListViewItem();
lvivQxPrjPotence.Tag = objvQxPrjPotenceEN.PotenceId;
lvivQxPrjPotence.Text = objvQxPrjPotenceEN.PotenceId.ToString();
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.PotenceName);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.QxPrjId);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.PrjName);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.FuncModuleId);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.PotenceTypeId);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.PotenceTypeName);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.FuncModuleName);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.FuncModuleName_Sim);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.InUse.ToString());
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.IsVisible.ToString());
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.MenuId);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.MenuName);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.UpMenuId);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.IsLeafNode.ToString());
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.UpMenuName);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.UpdDate);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.UpdUserId);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.Memo);
lvivQxPrjPotence.SubItems.Add(objvQxPrjPotenceEN.SymbolNum.ToString());
lvvQxPrjPotence.Items.Add(lvivQxPrjPotence);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjPotenceObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjPotenceService.vQxPrjPotence_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjPotence_GetDataSet", "clsvQxPrjPotenceWS:GetDataTableWs", objException.Message);
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
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjPotenceService.vQxPrjPotence_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjPotence_GetTopDataSet", "clsvQxPrjPotenceWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjPotenceService.vQxPrjPotence_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjPotence_GetDataSetByRange", "clsvQxPrjPotenceWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjPotenceWs(ref clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
bool bolResult = objvQxPrjPotenceService.vQxPrjPotence_GetvQxPrjPotence(ref objvQxPrjPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjPotenceEN GetObjByPotenceIdWs(string strPotenceId)
{
strPotenceId = strPotenceId.Replace("'", "");
strPotenceId = strPotenceId.Replace(" ", "");
strPotenceId = strPotenceId.Replace("(", "");
strPotenceId = strPotenceId.Replace(")", "");
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
clsvQxPrjPotenceEN objvQxPrjPotenceEN = objvQxPrjPotenceService.vQxPrjPotence_GetObjByPotenceId(strPotenceId);
return objvQxPrjPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
try
{
string strPotenceId = objvQxPrjPotenceService.vQxPrjPotence_GetFirstID_S(strWhereCond);
return strPotenceId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjPotence_GetFirstID_S", "clsvQxPrjPotenceWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjPotenceEN GetFirstvQxPrjPotence_S(string strWhereCond)
{
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
try
{
clsvQxPrjPotenceEN objvQxPrjPotenceEN = objvQxPrjPotenceService.vQxPrjPotence_GetFirstObj_S(strWhereCond);
return objvQxPrjPotenceEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjPotence_GetFirstObj_S", "clsvQxPrjPotenceWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPotenceId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPotenceNameByPotenceId_Cache(string strPotenceId)
{
if (string.IsNullOrEmpty(strPotenceId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjPotenceObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjPotenceEN objvQxPrjPotenceEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjPotenceEN = arrvQxPrjPotenceObjLst_Cache[intMid];
if (objvQxPrjPotenceEN.PotenceId == strPotenceId)
{
intFindFailCount = 0;
return objvQxPrjPotenceEN.PotenceName;
}
else if (objvQxPrjPotenceEN.PotenceId.CompareTo(strPotenceId) > 0)
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
arrvQxPrjPotenceObjLst_Cache = null;
if (intFindFailCount == 1) return GetPotenceNameByPotenceId_Cache(strPotenceId);
string strErrMsgForGetObjById = string.Format("在vQxPrjPotence对象缓存列表中,找不到记录[PotenceId = {0}][intFindFailCount = {1}](函数:{2})", strPotenceId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjPotenceEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjPotenceEN.PotenceId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjPotenceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by PotenceId");
if (arrvQxPrjPotenceObjLst_Cache == null)
{
arrvQxPrjPotenceObjLst_Cache = clsvQxPrjPotenceWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strPotenceId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjPotenceEN GetObjByPotenceId_Cache(string strPotenceId)
{
if (string.IsNullOrEmpty(strPotenceId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjPotenceObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjPotenceEN objvQxPrjPotenceEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjPotenceEN = arrvQxPrjPotenceObjLst_Cache[intMid];
if (objvQxPrjPotenceEN.PotenceId == strPotenceId)
{
intFindFailCount = 0;
return objvQxPrjPotenceEN;
}
else if (objvQxPrjPotenceEN.PotenceId.CompareTo(strPotenceId) > 0)
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
arrvQxPrjPotenceObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByPotenceId_Cache(strPotenceId);
string strErrMsgForGetObjById = string.Format("在vQxPrjPotence对象缓存列表中,找不到记录[PotenceId = {0}][intFindFailCount = {1}](函数:{2})", strPotenceId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjPotenceEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjPotenceEN.PotenceId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjPotenceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
objvQxPrjPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow["FuncModuleName"].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleName_Sim = objRow["FuncModuleName_Sim"].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["SymbolNum"].ToString().Trim()); //标志数
	arrObjLst.Add(objvQxPrjPotenceEN);
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
public static List<clsvQxPrjPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
objvQxPrjPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow["FuncModuleName"].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleName_Sim = objRow["FuncModuleName_Sim"].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow["MenuName"].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow["UpMenuId"].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeafNode"].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow["UpMenuName"].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["SymbolNum"].ToString().Trim()); //标志数
	arrObjLst.Add(objvQxPrjPotenceEN);
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
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
bool bolIsExist = objvQxPrjPotenceService.vQxPrjPotence_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strPotenceId)
{
//检测记录是否存在
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
bool bolIsExist = objvQxPrjPotenceService.vQxPrjPotence_IsExist(strPotenceId);
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
vQxPrjPotenceServiceSoapClient objvQxPrjPotenceService = GetvQxPrjPotenceServiceSoapClient();
int intRecCount = objvQxPrjPotenceService.vQxPrjPotence_funGetRecCountByCond(strWhereCond);
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