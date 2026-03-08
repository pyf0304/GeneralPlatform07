
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxApplicationTypeWS
 表名:QxApplicationType(00140088)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:24
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
using GeneralPlatform4WS.ServiceReferenceQxApplicationType;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_GeneEnumConstList)
 /// </summary>
public enum enumQxApplicationType : int
{
}
 /// <summary>
 /// 应用程序类型(QxApplicationType)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxApplicationTypeWS
{
private static string mstrPageName = "QxApplicationTypeService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxApplicationTypeEN> arrQxApplicationTypeObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxApplicationTypeServiceSoapClient objQxApplicationTypeServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxApplicationTypeServiceSoapClient GetQxApplicationTypeServiceSoapClient()
{
if (objQxApplicationTypeServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxApplicationTypeServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxApplicationTypeServiceSoapClient(binding, address);
}
else
{
return objQxApplicationTypeServiceSoapClient;
}
}

 public clsQxApplicationTypeWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ApplicationTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxApplicationTypeEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
objQxApplicationTypeEN.ApplicationTypeId = "0";
objQxApplicationTypeEN.ApplicationTypeName = "请选择[应用程序类型]...";
arrObjLst.Insert(0, objQxApplicationTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="ApplicationTypeId";
objComboBox.DisplayMember="ApplicationTypeName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[应用程序类型]...","0");
List<clsQxApplicationTypeEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="ApplicationTypeId";
objDDL.DataTextField="ApplicationTypeName";
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
public static int BindLv_QxApplicationType(System.Windows.Forms.ListView lvQxApplicationType, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxApplicationType; 
List<clsQxApplicationTypeEN> arrQxApplicationTypeObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxApplicationTypeObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxApplicationType.Items.Clear();//清除原来所有Item
lvQxApplicationType.Columns.Clear();//清除原来所有列头信息
lvQxApplicationType.Columns.Add("应用程序类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("应用程序类型名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("应用类型英文名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("编程语言类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("编程语言类型Id2", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("编程语言类型Id3", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("编程语言类型Id4", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("编程语言类型Id5", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxApplicationType.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxApplicationTypeEN objQxApplicationTypeEN in arrQxApplicationTypeObjLst)
{
lviQxApplicationType = new System.Windows.Forms.ListViewItem();
lviQxApplicationType.Tag = objQxApplicationTypeEN.ApplicationTypeId;
lviQxApplicationType.Text = objQxApplicationTypeEN.ApplicationTypeId.ToString();
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.ApplicationTypeName);
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.ApplicationTypeENName);
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.ProgLangTypeId);
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.ProgLangTypeId2);
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.ProgLangTypeId3);
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.ProgLangTypeId4);
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.ProgLangTypeId5);
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.IsVisible.ToString());
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.OrderNum.ToString());
lviQxApplicationType.SubItems.Add(objQxApplicationTypeEN.Memo);
lvQxApplicationType.Items.Add(lviQxApplicationType);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxApplicationTypeObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
if (!Object.Equals(null, objQxApplicationTypeEN.ApplicationTypeName) && GetStrLen(objQxApplicationTypeEN.ApplicationTypeName) > 30)
{
 throw new Exception("字段[应用程序类型名称]的长度不能超过30!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ApplicationTypeENName) && GetStrLen(objQxApplicationTypeEN.ApplicationTypeENName) > 30)
{
 throw new Exception("字段[应用类型英文名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId2) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId2) > 2)
{
 throw new Exception("字段[编程语言类型Id2]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId3) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId3) > 2)
{
 throw new Exception("字段[编程语言类型Id3]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId4) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId4) > 2)
{
 throw new Exception("字段[编程语言类型Id4]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.ProgLangTypeId5) && GetStrLen(objQxApplicationTypeEN.ProgLangTypeId5) > 2)
{
 throw new Exception("字段[编程语言类型Id5]的长度不能超过2!");
}
if (!Object.Equals(null, objQxApplicationTypeEN.Memo) && GetStrLen(objQxApplicationTypeEN.Memo) > 1000)
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
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxApplicationTypeService.QxApplicationType_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_GetDataSet", "clsQxApplicationTypeWS:GetDataTableWs", objException.Message);
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
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxApplicationTypeService.QxApplicationType_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_GetTopDataSet", "clsQxApplicationTypeWS:GetDataTable_TopWs", objException.Message);
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
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxApplicationTypeService.QxApplicationType_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_GetDataSetByRange", "clsQxApplicationTypeWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxApplicationTypeService.QxApplicationType_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_GetDataSetV", "clsQxApplicationTypeWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxApplicationTypeVWs(string strWhereCond)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxApplicationTypeService.QxApplicationType_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_GetDataSetV", "clsQxApplicationTypeWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxApplicationTypeWs(ref clsQxApplicationTypeEN objQxApplicationTypeEN)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
bool bolResult = objQxApplicationTypeService.QxApplicationType_GetQxApplicationType(ref objQxApplicationTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxApplicationTypeEN GetObjByApplicationTypeIdWs(int intApplicationTypeId)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
clsQxApplicationTypeEN objQxApplicationTypeEN = objQxApplicationTypeService.QxApplicationType_GetObjByApplicationTypeId(intApplicationTypeId);
return objQxApplicationTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static int GetFirstID_S(string strWhereCond)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
int intApplicationTypeId = objQxApplicationTypeService.QxApplicationType_GetFirstID_S(strWhereCond);
return intApplicationTypeId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_GetFirstID_S", "clsQxApplicationTypeWS:GetFirstID_S", objException.Message);
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
public static clsQxApplicationTypeEN GetFirstQxApplicationType_S(string strWhereCond)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
clsQxApplicationTypeEN objQxApplicationTypeEN = objQxApplicationTypeService.QxApplicationType_GetFirstObj_S(strWhereCond);
return objQxApplicationTypeEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_GetFirstObj_S", "clsQxApplicationTypeWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetApplicationTypeNameByApplicationTypeId_Cache(int intApplicationTypeId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxApplicationTypeObjLst_Cache.Count - 1;
int intMid = 0;
clsQxApplicationTypeEN objQxApplicationTypeEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxApplicationTypeEN = arrQxApplicationTypeObjLst_Cache[intMid];
if (objQxApplicationTypeEN.ApplicationTypeId == intApplicationTypeId)
{
intFindFailCount = 0;
return objQxApplicationTypeEN.ApplicationTypeName;
}
else if (objQxApplicationTypeEN.ApplicationTypeId.CompareTo(intApplicationTypeId) > 0)
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
arrQxApplicationTypeObjLst_Cache = null;
if (intFindFailCount == 1) return GetApplicationTypeNameByApplicationTypeId_Cache(intApplicationTypeId);
string strErrMsgForGetObjById = string.Format("在QxApplicationType对象缓存列表中,找不到记录[ApplicationTypeId = {0}][intFindFailCount = {1}](函数:{2})", intApplicationTypeId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxApplicationTypeEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxApplicationTypeEN.ApplicationTypeId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxApplicationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by ApplicationTypeId");
if (arrQxApplicationTypeObjLst_Cache == null)
{
arrQxApplicationTypeObjLst_Cache = clsQxApplicationTypeWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxApplicationTypeEN GetObjByApplicationTypeId_Cache(int intApplicationTypeId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxApplicationTypeObjLst_Cache.Count - 1;
int intMid = 0;
clsQxApplicationTypeEN objQxApplicationTypeEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxApplicationTypeEN = arrQxApplicationTypeObjLst_Cache[intMid];
if (objQxApplicationTypeEN.ApplicationTypeId == intApplicationTypeId)
{
intFindFailCount = 0;
return objQxApplicationTypeEN;
}
else if (objQxApplicationTypeEN.ApplicationTypeId.CompareTo(intApplicationTypeId) > 0)
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
arrQxApplicationTypeObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByApplicationTypeId_Cache(intApplicationTypeId);
string strErrMsgForGetObjById = string.Format("在QxApplicationType对象缓存列表中,找不到记录[ApplicationTypeId = {0}][intFindFailCount = {1}](函数:{2})", intApplicationTypeId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxApplicationTypeEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxApplicationTypeEN.ApplicationTypeId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxApplicationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxApplicationTypeEN> GetObjLst(string strWhereCond)
{
 List<clsQxApplicationTypeEN> arrObjLst = new List<clsQxApplicationTypeEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
objQxApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow["ApplicationTypeId"].ToString().Trim()); //应用程序类型ID
objQxApplicationTypeEN.ApplicationTypeName = objRow["ApplicationTypeName"].ToString().Trim(); //应用程序类型名称
objQxApplicationTypeEN.ApplicationTypeENName = objRow["ApplicationTypeENName"].ToString().Trim(); //应用类型英文名
objQxApplicationTypeEN.ProgLangTypeId = objRow["ProgLangTypeId"].ToString().Trim(); //编程语言类型Id
objQxApplicationTypeEN.ProgLangTypeId2 = objRow["ProgLangTypeId2"].ToString().Trim(); //编程语言类型Id2
objQxApplicationTypeEN.ProgLangTypeId3 = objRow["ProgLangTypeId3"].ToString().Trim(); //编程语言类型Id3
objQxApplicationTypeEN.ProgLangTypeId4 = objRow["ProgLangTypeId4"].ToString().Trim(); //编程语言类型Id4
objQxApplicationTypeEN.ProgLangTypeId5 = objRow["ProgLangTypeId5"].ToString().Trim(); //编程语言类型Id5
objQxApplicationTypeEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objQxApplicationTypeEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objQxApplicationTypeEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxApplicationTypeEN);
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
public static List<clsQxApplicationTypeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxApplicationTypeEN> arrObjLst = new List<clsQxApplicationTypeEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxApplicationTypeEN objQxApplicationTypeEN = new clsQxApplicationTypeEN();
objQxApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow["ApplicationTypeId"].ToString().Trim()); //应用程序类型ID
objQxApplicationTypeEN.ApplicationTypeName = objRow["ApplicationTypeName"].ToString().Trim(); //应用程序类型名称
objQxApplicationTypeEN.ApplicationTypeENName = objRow["ApplicationTypeENName"].ToString().Trim(); //应用类型英文名
objQxApplicationTypeEN.ProgLangTypeId = objRow["ProgLangTypeId"].ToString().Trim(); //编程语言类型Id
objQxApplicationTypeEN.ProgLangTypeId2 = objRow["ProgLangTypeId2"].ToString().Trim(); //编程语言类型Id2
objQxApplicationTypeEN.ProgLangTypeId3 = objRow["ProgLangTypeId3"].ToString().Trim(); //编程语言类型Id3
objQxApplicationTypeEN.ProgLangTypeId4 = objRow["ProgLangTypeId4"].ToString().Trim(); //编程语言类型Id4
objQxApplicationTypeEN.ProgLangTypeId5 = objRow["ProgLangTypeId5"].ToString().Trim(); //编程语言类型Id5
objQxApplicationTypeEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objQxApplicationTypeEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objQxApplicationTypeEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxApplicationTypeEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(int intApplicationTypeId)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
int intResult = objQxApplicationTypeService.QxApplicationType_DelRecord(intApplicationTypeId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_DelRecord", "clsQxApplicationTypeWS:DelRecordWs", objException.Message);
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
public static int DelQxApplicationTypesWs(List<string> arrApplicationTypeId)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrApplicationTypeId);
int intResult = objQxApplicationTypeService.QxApplicationType_DelQxApplicationTypes(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_DelQxApplicationTypes", "clsQxApplicationTypeWS:DelQxApplicationTypesWs", objException.Message);
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
public static int DelQxApplicationTypesByCondWs(string strWhereCond)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
int intRecNum = objQxApplicationTypeService.QxApplicationType_DelQxApplicationTypesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_DelQxApplicationTypesByCond", "clsQxApplicationTypeWS:DelQxApplicationTypesByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
bool bolResult = objQxApplicationTypeService.QxApplicationType_AddNewRecordBySql2(objQxApplicationTypeEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_AddNewRecordBySql2", "clsQxApplicationTypeWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
string strKey = objQxApplicationTypeService.QxApplicationType_AddNewRecordBySql2WithReturnKey(objQxApplicationTypeEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_AddNewRecordBySql2WithReturnKey", "clsQxApplicationTypeWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxApplicationTypeEN objQxApplicationTypeEN)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
bool bolResult = objQxApplicationTypeService.QxApplicationType_UpdateBySql2(objQxApplicationTypeEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_UpdateBySql2", "clsQxApplicationTypeWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxApplicationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxApplicationTypeEN objQxApplicationTypeEN, string strWhereCond)
{
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
try
{
bool bolResult = objQxApplicationTypeService.QxApplicationType_UpdateBySqlWithCondition(objQxApplicationTypeEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxApplicationType_UpdateBySqlWithCondition", "clsQxApplicationTypeWS:UpdateBySqlWithCondition", objException.Message);
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
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
bool bolIsExist = objQxApplicationTypeService.QxApplicationType_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(int intApplicationTypeId)
{
//检测记录是否存在
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
bool bolIsExist = objQxApplicationTypeService.QxApplicationType_IsExist(intApplicationTypeId);
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
QxApplicationTypeServiceSoapClient objQxApplicationTypeService = GetQxApplicationTypeServiceSoapClient();
int intRecCount = objQxApplicationTypeService.QxApplicationType_funGetRecCountByCond(strWhereCond);
return intRecCount;
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