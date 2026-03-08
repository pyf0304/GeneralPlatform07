
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjPotenceWS
 表名:QxPrjPotence(00140005)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:51
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
using GeneralPlatform4WS.ServiceReferenceQxPrjPotence;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 工程权限(QxPrjPotence)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjPotenceWS
{
private static string mstrPageName = "QxPrjPotenceService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPrjPotenceEN> arrQxPrjPotenceObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPrjPotenceServiceSoapClient objQxPrjPotenceServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPrjPotenceServiceSoapClient GetQxPrjPotenceServiceSoapClient()
{
if (objQxPrjPotenceServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPrjPotenceServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPrjPotenceServiceSoapClient(binding, address);
}
else
{
return objQxPrjPotenceServiceSoapClient;
}
}

 public clsQxPrjPotenceWS()
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
List<clsQxPrjPotenceEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
objQxPrjPotenceEN.PotenceId = "0";
objQxPrjPotenceEN.PotenceName = "请选择[工程权限]...";
arrObjLst.Insert(0, objQxPrjPotenceEN);
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工程权限]...","0");
List<clsQxPrjPotenceEN> arrObjLst = GetObjLst("1 = 1");
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
public static int BindLv_QxPrjPotence(System.Windows.Forms.ListView lvQxPrjPotence, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPrjPotence; 
List<clsQxPrjPotenceEN> arrQxPrjPotenceObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPrjPotenceObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPrjPotence.Items.Clear();//清除原来所有Item
lvQxPrjPotence.Columns.Clear();//清除原来所有列头信息
lvQxPrjPotence.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("权限名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("模块Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("权限类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("菜单Id4Win", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjPotence.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjPotenceEN objQxPrjPotenceEN in arrQxPrjPotenceObjLst)
{
lviQxPrjPotence = new System.Windows.Forms.ListViewItem();
lviQxPrjPotence.Tag = objQxPrjPotenceEN.PotenceId;
lviQxPrjPotence.Text = objQxPrjPotenceEN.PotenceId.ToString();
lviQxPrjPotence.SubItems.Add(objQxPrjPotenceEN.PotenceName);
lviQxPrjPotence.SubItems.Add(objQxPrjPotenceEN.FuncModuleId);
lviQxPrjPotence.SubItems.Add(objQxPrjPotenceEN.MenuId);
lviQxPrjPotence.SubItems.Add(objQxPrjPotenceEN.MenuId4Win);
lviQxPrjPotence.SubItems.Add(objQxPrjPotenceEN.UpdDate);
lviQxPrjPotence.SubItems.Add(objQxPrjPotenceEN.UpdUserId);
lviQxPrjPotence.SubItems.Add(objQxPrjPotenceEN.Memo);
lvQxPrjPotence.Items.Add(lviQxPrjPotence);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPrjPotenceObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
if (!Object.Equals(null, objQxPrjPotenceEN.PotenceId) && GetStrLen(objQxPrjPotenceEN.PotenceId) > 8)
{
 throw new Exception("字段[权限ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.PotenceName) && GetStrLen(objQxPrjPotenceEN.PotenceName) > 200)
{
 throw new Exception("字段[权限名称]的长度不能超过200!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.QxPrjId) && GetStrLen(objQxPrjPotenceEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.FuncModuleId) && GetStrLen(objQxPrjPotenceEN.FuncModuleId) > 4)
{
 throw new Exception("字段[模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.PotenceTypeId) && GetStrLen(objQxPrjPotenceEN.PotenceTypeId) > 6)
{
 throw new Exception("字段[权限类型Id]的长度不能超过6!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.MenuId) && GetStrLen(objQxPrjPotenceEN.MenuId) > 8)
{
 throw new Exception("字段[菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.MenuId4Win) && GetStrLen(objQxPrjPotenceEN.MenuId4Win) > 8)
{
 throw new Exception("字段[菜单Id4Win]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.UpdDate) && GetStrLen(objQxPrjPotenceEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.UpdUserId) && GetStrLen(objQxPrjPotenceEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.Memo) && GetStrLen(objQxPrjPotenceEN.Memo) > 1000)
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
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjPotenceService.QxPrjPotence_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_GetDataSet", "clsQxPrjPotenceWS:GetDataTableWs", objException.Message);
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
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjPotenceService.QxPrjPotence_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_GetTopDataSet", "clsQxPrjPotenceWS:GetDataTable_TopWs", objException.Message);
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
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjPotenceService.QxPrjPotence_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_GetDataSetByRange", "clsQxPrjPotenceWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjPotenceService.QxPrjPotence_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_GetDataSetV", "clsQxPrjPotenceWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPrjPotenceVWs(string strWhereCond)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjPotenceService.QxPrjPotence_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_GetDataSetV", "clsQxPrjPotenceWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjPotenceWs(ref clsQxPrjPotenceEN objQxPrjPotenceEN)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
bool bolResult = objQxPrjPotenceService.QxPrjPotence_GetQxPrjPotence(ref objQxPrjPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjPotenceEN GetObjByPotenceIdWs(string strPotenceId)
{
strPotenceId = strPotenceId.Replace("'", "");
strPotenceId = strPotenceId.Replace(" ", "");
strPotenceId = strPotenceId.Replace("(", "");
strPotenceId = strPotenceId.Replace(")", "");
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
clsQxPrjPotenceEN objQxPrjPotenceEN = objQxPrjPotenceService.QxPrjPotence_GetObjByPotenceId(strPotenceId);
return objQxPrjPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
string strPotenceId = objQxPrjPotenceService.QxPrjPotence_GetFirstID_S(strWhereCond);
return strPotenceId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_GetFirstID_S", "clsQxPrjPotenceWS:GetFirstID_S", objException.Message);
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
public static clsQxPrjPotenceEN GetFirstQxPrjPotence_S(string strWhereCond)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
clsQxPrjPotenceEN objQxPrjPotenceEN = objQxPrjPotenceService.QxPrjPotence_GetFirstObj_S(strWhereCond);
return objQxPrjPotenceEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_GetFirstObj_S", "clsQxPrjPotenceWS:GetFirstObj_S", objException.Message);
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
int intEnd = arrQxPrjPotenceObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjPotenceEN objQxPrjPotenceEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjPotenceEN = arrQxPrjPotenceObjLst_Cache[intMid];
if (objQxPrjPotenceEN.PotenceId == strPotenceId)
{
intFindFailCount = 0;
return objQxPrjPotenceEN.PotenceName;
}
else if (objQxPrjPotenceEN.PotenceId.CompareTo(strPotenceId) > 0)
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
arrQxPrjPotenceObjLst_Cache = null;
if (intFindFailCount == 1) return GetPotenceNameByPotenceId_Cache(strPotenceId);
string strErrMsgForGetObjById = string.Format("在QxPrjPotence对象缓存列表中,找不到记录[PotenceId = {0}][intFindFailCount = {1}](函数:{2})", strPotenceId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjPotenceEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjPotenceEN.PotenceId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjPotenceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
if (arrQxPrjPotenceObjLst_Cache == null)
{
arrQxPrjPotenceObjLst_Cache = clsQxPrjPotenceWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strPotenceId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjPotenceEN GetObjByPotenceId_Cache(string strPotenceId)
{
if (string.IsNullOrEmpty(strPotenceId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjPotenceObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjPotenceEN objQxPrjPotenceEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjPotenceEN = arrQxPrjPotenceObjLst_Cache[intMid];
if (objQxPrjPotenceEN.PotenceId == strPotenceId)
{
intFindFailCount = 0;
return objQxPrjPotenceEN;
}
else if (objQxPrjPotenceEN.PotenceId.CompareTo(strPotenceId) > 0)
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
arrQxPrjPotenceObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByPotenceId_Cache(strPotenceId);
string strErrMsgForGetObjById = string.Format("在QxPrjPotence对象缓存列表中,找不到记录[PotenceId = {0}][intFindFailCount = {1}](函数:{2})", strPotenceId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjPotenceEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjPotenceEN.PotenceId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjPotenceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjPotenceEN> arrObjLst = new List<clsQxPrjPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
objQxPrjPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objQxPrjPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objQxPrjPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjPotenceEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objQxPrjPotenceEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objQxPrjPotenceEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objQxPrjPotenceEN.MenuId4Win = objRow["MenuId4Win"].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjPotenceEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjPotenceEN);
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
public static List<clsQxPrjPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPrjPotenceEN> arrObjLst = new List<clsQxPrjPotenceEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN();
objQxPrjPotenceEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objQxPrjPotenceEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objQxPrjPotenceEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjPotenceEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objQxPrjPotenceEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objQxPrjPotenceEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objQxPrjPotenceEN.MenuId4Win = objRow["MenuId4Win"].ToString().Trim(); //菜单Id4Win
objQxPrjPotenceEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjPotenceEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjPotenceEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjPotenceEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strPotenceId)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
int intResult = objQxPrjPotenceService.QxPrjPotence_DelRecord(strPotenceId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_DelRecord", "clsQxPrjPotenceWS:DelRecordWs", objException.Message);
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
public static int DelQxPrjPotencesWs(List<string> arrPotenceId)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrPotenceId);
int intResult = objQxPrjPotenceService.QxPrjPotence_DelQxPrjPotences(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_DelQxPrjPotences", "clsQxPrjPotenceWS:DelQxPrjPotencesWs", objException.Message);
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
public static int DelQxPrjPotencesByCondWs(string strWhereCond)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
int intRecNum = objQxPrjPotenceService.QxPrjPotence_DelQxPrjPotencesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_DelQxPrjPotencesByCond", "clsQxPrjPotenceWS:DelQxPrjPotencesByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
bool bolResult = objQxPrjPotenceService.QxPrjPotence_AddNewRecordBySql2(objQxPrjPotenceEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_AddNewRecordBySql2", "clsQxPrjPotenceWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
bool bolResult = objQxPrjPotenceService.QxPrjPotence_UpdateBySql2(objQxPrjPotenceEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_UpdateBySql2", "clsQxPrjPotenceWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPrjPotenceEN objQxPrjPotenceEN, string strWhereCond)
{
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
try
{
bool bolResult = objQxPrjPotenceService.QxPrjPotence_UpdateBySqlWithCondition(objQxPrjPotenceEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjPotence_UpdateBySqlWithCondition", "clsQxPrjPotenceWS:UpdateBySqlWithCondition", objException.Message);
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
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
bool bolIsExist = objQxPrjPotenceService.QxPrjPotence_IsExistRecord(strWhereCond);
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
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
bool bolIsExist = objQxPrjPotenceService.QxPrjPotence_IsExist(strPotenceId);
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
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
int intRecCount = objQxPrjPotenceService.QxPrjPotence_funGetRecCountByCond(strWhereCond);
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
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
string strMaxPotenceId = objQxPrjPotenceService.QxPrjPotence_GetMaxStrId();
return strMaxPotenceId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxPrjPotenceServiceSoapClient objQxPrjPotenceService = GetQxPrjPotenceServiceSoapClient();
string strMaxPotenceId = objQxPrjPotenceService.QxPrjPotence_GetMaxStrIdByPrefix(strPrefix);
return strMaxPotenceId;
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