
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPageDispModeWS
 表名:QxPageDispMode(00140044)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:05
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
using GeneralPlatform4WS.ServiceReferenceQxPageDispMode;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 页面显示模式(QxPageDispMode)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPageDispModeWS
{
private static string mstrPageName = "QxPageDispModeService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPageDispModeEN> arrQxPageDispModeObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPageDispModeServiceSoapClient objQxPageDispModeServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPageDispModeServiceSoapClient GetQxPageDispModeServiceSoapClient()
{
if (objQxPageDispModeServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPageDispModeServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPageDispModeServiceSoapClient(binding, address);
}
else
{
return objQxPageDispModeServiceSoapClient;
}
}

 public clsQxPageDispModeWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_PageDispModeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxPageDispModeEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPageDispModeEN objQxPageDispModeEN = new clsQxPageDispModeEN();
objQxPageDispModeEN.PageDispModeId = "0";
objQxPageDispModeEN.PageDispModeName = "请选择[页面显示模式]...";
arrObjLst.Insert(0, objQxPageDispModeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="PageDispModeId";
objComboBox.DisplayMember="PageDispModeName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PageDispModeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[页面显示模式]...","0");
List<clsQxPageDispModeEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="PageDispModeId";
objDDL.DataTextField="PageDispModeName";
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
public static int BindLv_QxPageDispMode(System.Windows.Forms.ListView lvQxPageDispMode, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPageDispMode; 
List<clsQxPageDispModeEN> arrQxPageDispModeObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPageDispModeObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPageDispMode.Items.Clear();//清除原来所有Item
lvQxPageDispMode.Columns.Clear();//清除原来所有列头信息
lvQxPageDispMode.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPageDispMode.Columns.Add("页面显示模式名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPageDispMode.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPageDispMode.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPageDispModeEN objQxPageDispModeEN in arrQxPageDispModeObjLst)
{
lviQxPageDispMode = new System.Windows.Forms.ListViewItem();
lviQxPageDispMode.Tag = objQxPageDispModeEN.PageDispModeId;
lviQxPageDispMode.Text = objQxPageDispModeEN.PageDispModeId.ToString();
lviQxPageDispMode.SubItems.Add(objQxPageDispModeEN.PageDispModeName);
lviQxPageDispMode.SubItems.Add(objQxPageDispModeEN.Memo);
lvQxPageDispMode.Items.Add(lviQxPageDispMode);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPageDispModeObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPageDispModeEN objQxPageDispModeEN)
{
if (!Object.Equals(null, objQxPageDispModeEN.PageDispModeId) && GetStrLen(objQxPageDispModeEN.PageDispModeId) > 2)
{
 throw new Exception("字段[页面显示模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPageDispModeEN.PageDispModeName) && GetStrLen(objQxPageDispModeEN.PageDispModeName) > 50)
{
 throw new Exception("字段[页面显示模式名称]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPageDispModeEN.Memo) && GetStrLen(objQxPageDispModeEN.Memo) > 1000)
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
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPageDispModeService.QxPageDispMode_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_GetDataSet", "clsQxPageDispModeWS:GetDataTableWs", objException.Message);
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
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPageDispModeService.QxPageDispMode_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_GetTopDataSet", "clsQxPageDispModeWS:GetDataTable_TopWs", objException.Message);
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
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPageDispModeService.QxPageDispMode_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_GetDataSetByRange", "clsQxPageDispModeWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPageDispModeService.QxPageDispMode_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_GetDataSetV", "clsQxPageDispModeWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPageDispModeVWs(string strWhereCond)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPageDispModeService.QxPageDispMode_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_GetDataSetV", "clsQxPageDispModeWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPageDispModeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPageDispModeWs(ref clsQxPageDispModeEN objQxPageDispModeEN)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
bool bolResult = objQxPageDispModeService.QxPageDispMode_GetQxPageDispMode(ref objQxPageDispModeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPageDispModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPageDispModeEN GetObjByPageDispModeIdWs(string strPageDispModeId)
{
strPageDispModeId = strPageDispModeId.Replace("'", "");
strPageDispModeId = strPageDispModeId.Replace(" ", "");
strPageDispModeId = strPageDispModeId.Replace("(", "");
strPageDispModeId = strPageDispModeId.Replace(")", "");
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
clsQxPageDispModeEN objQxPageDispModeEN = objQxPageDispModeService.QxPageDispMode_GetObjByPageDispModeId(strPageDispModeId);
return objQxPageDispModeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
string strPageDispModeId = objQxPageDispModeService.QxPageDispMode_GetFirstID_S(strWhereCond);
return strPageDispModeId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_GetFirstID_S", "clsQxPageDispModeWS:GetFirstID_S", objException.Message);
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
public static clsQxPageDispModeEN GetFirstQxPageDispMode_S(string strWhereCond)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
clsQxPageDispModeEN objQxPageDispModeEN = objQxPageDispModeService.QxPageDispMode_GetFirstObj_S(strWhereCond);
return objQxPageDispModeEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_GetFirstObj_S", "clsQxPageDispModeWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPageDispModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPageDispModeNameByPageDispModeId_Cache(string strPageDispModeId)
{
if (string.IsNullOrEmpty(strPageDispModeId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPageDispModeObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPageDispModeEN objQxPageDispModeEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPageDispModeEN = arrQxPageDispModeObjLst_Cache[intMid];
if (objQxPageDispModeEN.PageDispModeId == strPageDispModeId)
{
intFindFailCount = 0;
return objQxPageDispModeEN.PageDispModeName;
}
else if (objQxPageDispModeEN.PageDispModeId.CompareTo(strPageDispModeId) > 0)
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
arrQxPageDispModeObjLst_Cache = null;
if (intFindFailCount == 1) return GetPageDispModeNameByPageDispModeId_Cache(strPageDispModeId);
string strErrMsgForGetObjById = string.Format("在QxPageDispMode对象缓存列表中,找不到记录[PageDispModeId = {0}][intFindFailCount = {1}](函数:{2})", strPageDispModeId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPageDispModeEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPageDispModeEN.PageDispModeId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPageDispModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by PageDispModeId");
if (arrQxPageDispModeObjLst_Cache == null)
{
arrQxPageDispModeObjLst_Cache = clsQxPageDispModeWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strPageDispModeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPageDispModeEN GetObjByPageDispModeId_Cache(string strPageDispModeId)
{
if (string.IsNullOrEmpty(strPageDispModeId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPageDispModeObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPageDispModeEN objQxPageDispModeEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPageDispModeEN = arrQxPageDispModeObjLst_Cache[intMid];
if (objQxPageDispModeEN.PageDispModeId == strPageDispModeId)
{
intFindFailCount = 0;
return objQxPageDispModeEN;
}
else if (objQxPageDispModeEN.PageDispModeId.CompareTo(strPageDispModeId) > 0)
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
arrQxPageDispModeObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByPageDispModeId_Cache(strPageDispModeId);
string strErrMsgForGetObjById = string.Format("在QxPageDispMode对象缓存列表中,找不到记录[PageDispModeId = {0}][intFindFailCount = {1}](函数:{2})", strPageDispModeId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPageDispModeEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPageDispModeEN.PageDispModeId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPageDispModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPageDispModeEN> GetObjLst(string strWhereCond)
{
 List<clsQxPageDispModeEN> arrObjLst = new List<clsQxPageDispModeEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPageDispModeEN objQxPageDispModeEN = new clsQxPageDispModeEN();
objQxPageDispModeEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objQxPageDispModeEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objQxPageDispModeEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPageDispModeEN);
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
public static List<clsQxPageDispModeEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPageDispModeEN> arrObjLst = new List<clsQxPageDispModeEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPageDispModeEN objQxPageDispModeEN = new clsQxPageDispModeEN();
objQxPageDispModeEN.PageDispModeId = objRow["PageDispModeId"].ToString().Trim(); //页面显示模式Id
objQxPageDispModeEN.PageDispModeName = objRow["PageDispModeName"].ToString().Trim(); //页面显示模式名称
objQxPageDispModeEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPageDispModeEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strPageDispModeId)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
int intResult = objQxPageDispModeService.QxPageDispMode_DelRecord(strPageDispModeId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_DelRecord", "clsQxPageDispModeWS:DelRecordWs", objException.Message);
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
public static int DelQxPageDispModesWs(List<string> arrPageDispModeId)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrPageDispModeId);
int intResult = objQxPageDispModeService.QxPageDispMode_DelQxPageDispModes(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_DelQxPageDispModes", "clsQxPageDispModeWS:DelQxPageDispModesWs", objException.Message);
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
public static int DelQxPageDispModesByCondWs(string strWhereCond)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
int intRecNum = objQxPageDispModeService.QxPageDispMode_DelQxPageDispModesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_DelQxPageDispModesByCond", "clsQxPageDispModeWS:DelQxPageDispModesByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxPageDispModeEN objQxPageDispModeEN)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
bool bolResult = objQxPageDispModeService.QxPageDispMode_AddNewRecordBySql2(objQxPageDispModeEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_AddNewRecordBySql2", "clsQxPageDispModeWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxPageDispModeEN objQxPageDispModeEN)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
bool bolResult = objQxPageDispModeService.QxPageDispMode_UpdateBySql2(objQxPageDispModeEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_UpdateBySql2", "clsQxPageDispModeWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPageDispModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPageDispModeEN objQxPageDispModeEN, string strWhereCond)
{
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
try
{
bool bolResult = objQxPageDispModeService.QxPageDispMode_UpdateBySqlWithCondition(objQxPageDispModeEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPageDispMode_UpdateBySqlWithCondition", "clsQxPageDispModeWS:UpdateBySqlWithCondition", objException.Message);
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
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
bool bolIsExist = objQxPageDispModeService.QxPageDispMode_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strPageDispModeId)
{
//检测记录是否存在
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
bool bolIsExist = objQxPageDispModeService.QxPageDispMode_IsExist(strPageDispModeId);
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
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
int intRecCount = objQxPageDispModeService.QxPageDispMode_funGetRecCountByCond(strWhereCond);
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
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
string strMaxPageDispModeId = objQxPageDispModeService.QxPageDispMode_GetMaxStrId();
return strMaxPageDispModeId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxPageDispModeServiceSoapClient objQxPageDispModeService = GetQxPageDispModeServiceSoapClient();
string strMaxPageDispModeId = objQxPageDispModeService.QxPageDispMode_GetMaxStrIdByPrefix(strPrefix);
return strMaxPageDispModeId;
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