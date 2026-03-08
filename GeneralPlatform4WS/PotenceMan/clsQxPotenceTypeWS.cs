
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPotenceTypeWS
 表名:QxPotenceType(00140003)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:49
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
using GeneralPlatform4WS.ServiceReferenceQxPotenceType;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 权限类型(QxPotenceType)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPotenceTypeWS
{
private static string mstrPageName = "QxPotenceTypeService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPotenceTypeServiceSoapClient objQxPotenceTypeServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPotenceTypeServiceSoapClient GetQxPotenceTypeServiceSoapClient()
{
if (objQxPotenceTypeServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPotenceTypeServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPotenceTypeServiceSoapClient(binding, address);
}
else
{
return objQxPotenceTypeServiceSoapClient;
}
}

 public clsQxPotenceTypeWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_PotenceTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxPotenceTypeEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
objQxPotenceTypeEN.PotenceTypeId = "0";
objQxPotenceTypeEN.PotenceTypeName = "请选择[权限类型]...";
arrObjLst.Insert(0, objQxPotenceTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="PotenceTypeId";
objComboBox.DisplayMember="PotenceTypeName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PotenceTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[权限类型]...","0");
List<clsQxPotenceTypeEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="PotenceTypeId";
objDDL.DataTextField="PotenceTypeName";
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
public static int BindLv_QxPotenceType(System.Windows.Forms.ListView lvQxPotenceType, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPotenceType; 
List<clsQxPotenceTypeEN> arrQxPotenceTypeObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPotenceTypeObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPotenceType.Items.Clear();//清除原来所有Item
lvQxPotenceType.Columns.Clear();//清除原来所有列头信息
lvQxPotenceType.Columns.Add("权限类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("权限类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("模块Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("界面编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPotenceType.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPotenceTypeEN objQxPotenceTypeEN in arrQxPotenceTypeObjLst)
{
lviQxPotenceType = new System.Windows.Forms.ListViewItem();
lviQxPotenceType.Tag = objQxPotenceTypeEN.PotenceTypeId;
lviQxPotenceType.Text = objQxPotenceTypeEN.PotenceTypeId.ToString();
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.PotenceTypeName);
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.FuncModuleId);
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.MenuId);
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.ViewId);
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.IsVisible.ToString());
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.UpdDate);
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.UpdUserId);
lviQxPotenceType.SubItems.Add(objQxPotenceTypeEN.Memo);
lvQxPotenceType.Items.Add(lviQxPotenceType);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPotenceTypeObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
if (!Object.Equals(null, objQxPotenceTypeEN.PotenceTypeId) && GetStrLen(objQxPotenceTypeEN.PotenceTypeId) > 6)
{
 throw new Exception("字段[权限类型Id]的长度不能超过6!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.PotenceTypeName) && GetStrLen(objQxPotenceTypeEN.PotenceTypeName) > 50)
{
 throw new Exception("字段[权限类型名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.QxPrjId) && GetStrLen(objQxPotenceTypeEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.FuncModuleId) && GetStrLen(objQxPotenceTypeEN.FuncModuleId) > 4)
{
 throw new Exception("字段[模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.MenuId) && GetStrLen(objQxPotenceTypeEN.MenuId) > 8)
{
 throw new Exception("字段[菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.ViewId) && GetStrLen(objQxPotenceTypeEN.ViewId) > 8)
{
 throw new Exception("字段[界面编号]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.UpdDate) && GetStrLen(objQxPotenceTypeEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.UpdUserId) && GetStrLen(objQxPotenceTypeEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPotenceTypeEN.Memo) && GetStrLen(objQxPotenceTypeEN.Memo) > 1000)
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
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPotenceTypeService.QxPotenceType_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_GetDataSet", "clsQxPotenceTypeWS:GetDataTableWs", objException.Message);
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
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPotenceTypeService.QxPotenceType_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_GetTopDataSet", "clsQxPotenceTypeWS:GetDataTable_TopWs", objException.Message);
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
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPotenceTypeService.QxPotenceType_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_GetDataSetByRange", "clsQxPotenceTypeWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPotenceTypeService.QxPotenceType_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_GetDataSetV", "clsQxPotenceTypeWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPotenceTypeVWs(string strWhereCond)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPotenceTypeService.QxPotenceType_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_GetDataSetV", "clsQxPotenceTypeWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPotenceTypeWs(ref clsQxPotenceTypeEN objQxPotenceTypeEN)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
bool bolResult = objQxPotenceTypeService.QxPotenceType_GetQxPotenceType(ref objQxPotenceTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPotenceTypeEN GetObjByPotenceTypeIdWs(string strPotenceTypeId)
{
strPotenceTypeId = strPotenceTypeId.Replace("'", "");
strPotenceTypeId = strPotenceTypeId.Replace(" ", "");
strPotenceTypeId = strPotenceTypeId.Replace("(", "");
strPotenceTypeId = strPotenceTypeId.Replace(")", "");
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
clsQxPotenceTypeEN objQxPotenceTypeEN = objQxPotenceTypeService.QxPotenceType_GetObjByPotenceTypeId(strPotenceTypeId);
return objQxPotenceTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
string strPotenceTypeId = objQxPotenceTypeService.QxPotenceType_GetFirstID_S(strWhereCond);
return strPotenceTypeId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_GetFirstID_S", "clsQxPotenceTypeWS:GetFirstID_S", objException.Message);
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
public static clsQxPotenceTypeEN GetFirstQxPotenceType_S(string strWhereCond)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
clsQxPotenceTypeEN objQxPotenceTypeEN = objQxPotenceTypeService.QxPotenceType_GetFirstObj_S(strWhereCond);
return objQxPotenceTypeEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_GetFirstObj_S", "clsQxPotenceTypeWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPotenceTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPotenceTypeNameByPotenceTypeId_Cache(string strPotenceTypeId)
{
if (string.IsNullOrEmpty(strPotenceTypeId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPotenceTypeObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPotenceTypeEN objQxPotenceTypeEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPotenceTypeEN = arrQxPotenceTypeObjLst_Cache[intMid];
if (objQxPotenceTypeEN.PotenceTypeId == strPotenceTypeId)
{
intFindFailCount = 0;
return objQxPotenceTypeEN.PotenceTypeName;
}
else if (objQxPotenceTypeEN.PotenceTypeId.CompareTo(strPotenceTypeId) > 0)
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
arrQxPotenceTypeObjLst_Cache = null;
if (intFindFailCount == 1) return GetPotenceTypeNameByPotenceTypeId_Cache(strPotenceTypeId);
string strErrMsgForGetObjById = string.Format("在QxPotenceType对象缓存列表中,找不到记录[PotenceTypeId = {0}][intFindFailCount = {1}](函数:{2})", strPotenceTypeId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPotenceTypeEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPotenceTypeEN.PotenceTypeId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPotenceTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by PotenceTypeId");
if (arrQxPotenceTypeObjLst_Cache == null)
{
arrQxPotenceTypeObjLst_Cache = clsQxPotenceTypeWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strPotenceTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPotenceTypeEN GetObjByPotenceTypeId_Cache(string strPotenceTypeId)
{
if (string.IsNullOrEmpty(strPotenceTypeId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPotenceTypeObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPotenceTypeEN objQxPotenceTypeEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPotenceTypeEN = arrQxPotenceTypeObjLst_Cache[intMid];
if (objQxPotenceTypeEN.PotenceTypeId == strPotenceTypeId)
{
intFindFailCount = 0;
return objQxPotenceTypeEN;
}
else if (objQxPotenceTypeEN.PotenceTypeId.CompareTo(strPotenceTypeId) > 0)
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
arrQxPotenceTypeObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByPotenceTypeId_Cache(strPotenceTypeId);
string strErrMsgForGetObjById = string.Format("在QxPotenceType对象缓存列表中,找不到记录[PotenceTypeId = {0}][intFindFailCount = {1}](函数:{2})", strPotenceTypeId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPotenceTypeEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPotenceTypeEN.PotenceTypeId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPotenceTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPotenceTypeEN> GetObjLst(string strWhereCond)
{
 List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
objQxPotenceTypeEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPotenceTypeEN);
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
public static List<clsQxPotenceTypeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPotenceTypeEN> arrObjLst = new List<clsQxPotenceTypeEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPotenceTypeEN objQxPotenceTypeEN = new clsQxPotenceTypeEN();
objQxPotenceTypeEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objQxPotenceTypeEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objQxPotenceTypeEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPotenceTypeEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objQxPotenceTypeEN.MenuId = objRow["MenuId"].ToString().Trim(); //菜单Id
objQxPotenceTypeEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
objQxPotenceTypeEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objQxPotenceTypeEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPotenceTypeEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPotenceTypeEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPotenceTypeEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strPotenceTypeId)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
int intResult = objQxPotenceTypeService.QxPotenceType_DelRecord(strPotenceTypeId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_DelRecord", "clsQxPotenceTypeWS:DelRecordWs", objException.Message);
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
public static int DelQxPotenceTypesWs(List<string> arrPotenceTypeId)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrPotenceTypeId);
int intResult = objQxPotenceTypeService.QxPotenceType_DelQxPotenceTypes(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_DelQxPotenceTypes", "clsQxPotenceTypeWS:DelQxPotenceTypesWs", objException.Message);
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
public static int DelQxPotenceTypesByCondWs(string strWhereCond)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
int intRecNum = objQxPotenceTypeService.QxPotenceType_DelQxPotenceTypesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_DelQxPotenceTypesByCond", "clsQxPotenceTypeWS:DelQxPotenceTypesByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
bool bolResult = objQxPotenceTypeService.QxPotenceType_AddNewRecordBySql2(objQxPotenceTypeEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_AddNewRecordBySql2", "clsQxPotenceTypeWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxPotenceTypeEN objQxPotenceTypeEN)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
bool bolResult = objQxPotenceTypeService.QxPotenceType_UpdateBySql2(objQxPotenceTypeEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_UpdateBySql2", "clsQxPotenceTypeWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPotenceTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPotenceTypeEN objQxPotenceTypeEN, string strWhereCond)
{
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
try
{
bool bolResult = objQxPotenceTypeService.QxPotenceType_UpdateBySqlWithCondition(objQxPotenceTypeEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPotenceType_UpdateBySqlWithCondition", "clsQxPotenceTypeWS:UpdateBySqlWithCondition", objException.Message);
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
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
bool bolIsExist = objQxPotenceTypeService.QxPotenceType_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strPotenceTypeId)
{
//检测记录是否存在
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
bool bolIsExist = objQxPotenceTypeService.QxPotenceType_IsExist(strPotenceTypeId);
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
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
int intRecCount = objQxPotenceTypeService.QxPotenceType_funGetRecCountByCond(strWhereCond);
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
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
string strMaxPotenceTypeId = objQxPotenceTypeService.QxPotenceType_GetMaxStrId();
return strMaxPotenceTypeId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxPotenceTypeServiceSoapClient objQxPotenceTypeService = GetQxPotenceTypeServiceSoapClient();
string strMaxPotenceTypeId = objQxPotenceTypeService.QxPotenceType_GetMaxStrIdByPrefix(strPrefix);
return strMaxPotenceTypeId;
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