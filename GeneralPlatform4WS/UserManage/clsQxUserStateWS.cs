
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserStateWS
 表名:QxUserState(00140016)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:56
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
using GeneralPlatform4WS.ServiceReferenceQxUserState;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户状态(QxUserState)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserStateWS
{
private static string mstrPageName = "QxUserStateService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserStateEN> arrQxUserStateObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserStateServiceSoapClient objQxUserStateServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserStateServiceSoapClient GetQxUserStateServiceSoapClient()
{
if (objQxUserStateServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserStateServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserStateServiceSoapClient(binding, address);
}
else
{
return objQxUserStateServiceSoapClient;
}
}

 public clsQxUserStateWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_UserStateId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxUserStateEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxUserStateEN objQxUserStateEN = new clsQxUserStateEN();
objQxUserStateEN.UserStateId = "0";
objQxUserStateEN.UserStateName = "请选择[用户状态]...";
arrObjLst.Insert(0, objQxUserStateEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="UserStateId";
objComboBox.DisplayMember="UserStateName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[用户状态]...","0");
List<clsQxUserStateEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="UserStateId";
objDDL.DataTextField="UserStateName";
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
public static int BindLv_QxUserState(System.Windows.Forms.ListView lvQxUserState, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserState; 
List<clsQxUserStateEN> arrQxUserStateObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserStateObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserState.Items.Clear();//清除原来所有Item
lvQxUserState.Columns.Clear();//清除原来所有列头信息
lvQxUserState.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserState.Columns.Add("用户状态名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserState.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserState.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserStateEN objQxUserStateEN in arrQxUserStateObjLst)
{
lviQxUserState = new System.Windows.Forms.ListViewItem();
lviQxUserState.Tag = objQxUserStateEN.UserStateId;
lviQxUserState.Text = objQxUserStateEN.UserStateId.ToString();
lviQxUserState.SubItems.Add(objQxUserStateEN.UserStateName);
lviQxUserState.SubItems.Add(objQxUserStateEN.Memo);
lvQxUserState.Items.Add(lviQxUserState);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserStateObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserStateEN objQxUserStateEN)
{
if (!Object.Equals(null, objQxUserStateEN.UserStateId) && GetStrLen(objQxUserStateEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUserStateEN.UserStateName) && GetStrLen(objQxUserStateEN.UserStateName) > 20)
{
 throw new Exception("字段[用户状态名]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUserStateEN.Memo) && GetStrLen(objQxUserStateEN.Memo) > 1000)
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
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserStateService.QxUserState_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_GetDataSet", "clsQxUserStateWS:GetDataTableWs", objException.Message);
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
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserStateService.QxUserState_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_GetTopDataSet", "clsQxUserStateWS:GetDataTable_TopWs", objException.Message);
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
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserStateService.QxUserState_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_GetDataSetByRange", "clsQxUserStateWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserStateService.QxUserState_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_GetDataSetV", "clsQxUserStateWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserStateVWs(string strWhereCond)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserStateService.QxUserState_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_GetDataSetV", "clsQxUserStateWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserStateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserStateWs(ref clsQxUserStateEN objQxUserStateEN)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
bool bolResult = objQxUserStateService.QxUserState_GetQxUserState(ref objQxUserStateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserStateId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserStateEN GetObjByUserStateIdWs(string strUserStateId)
{
strUserStateId = strUserStateId.Replace("'", "");
strUserStateId = strUserStateId.Replace(" ", "");
strUserStateId = strUserStateId.Replace("(", "");
strUserStateId = strUserStateId.Replace(")", "");
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
clsQxUserStateEN objQxUserStateEN = objQxUserStateService.QxUserState_GetObjByUserStateId(strUserStateId);
return objQxUserStateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
string strUserStateId = objQxUserStateService.QxUserState_GetFirstID_S(strWhereCond);
return strUserStateId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_GetFirstID_S", "clsQxUserStateWS:GetFirstID_S", objException.Message);
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
public static clsQxUserStateEN GetFirstQxUserState_S(string strWhereCond)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
clsQxUserStateEN objQxUserStateEN = objQxUserStateService.QxUserState_GetFirstObj_S(strWhereCond);
return objQxUserStateEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_GetFirstObj_S", "clsQxUserStateWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strUserStateId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserStateNameByUserStateId_Cache(string strUserStateId)
{
if (string.IsNullOrEmpty(strUserStateId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserStateObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserStateEN objQxUserStateEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserStateEN = arrQxUserStateObjLst_Cache[intMid];
if (objQxUserStateEN.UserStateId == strUserStateId)
{
intFindFailCount = 0;
return objQxUserStateEN.UserStateName;
}
else if (objQxUserStateEN.UserStateId.CompareTo(strUserStateId) > 0)
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
arrQxUserStateObjLst_Cache = null;
if (intFindFailCount == 1) return GetUserStateNameByUserStateId_Cache(strUserStateId);
string strErrMsgForGetObjById = string.Format("在QxUserState对象缓存列表中,找不到记录[UserStateId = {0}][intFindFailCount = {1}](函数:{2})", strUserStateId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserStateEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserStateEN.UserStateId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserStateBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by UserStateId");
if (arrQxUserStateObjLst_Cache == null)
{
arrQxUserStateObjLst_Cache = clsQxUserStateWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserStateId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserStateEN GetObjByUserStateId_Cache(string strUserStateId)
{
if (string.IsNullOrEmpty(strUserStateId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserStateObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserStateEN objQxUserStateEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserStateEN = arrQxUserStateObjLst_Cache[intMid];
if (objQxUserStateEN.UserStateId == strUserStateId)
{
intFindFailCount = 0;
return objQxUserStateEN;
}
else if (objQxUserStateEN.UserStateId.CompareTo(strUserStateId) > 0)
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
arrQxUserStateObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserStateId_Cache(strUserStateId);
string strErrMsgForGetObjById = string.Format("在QxUserState对象缓存列表中,找不到记录[UserStateId = {0}][intFindFailCount = {1}](函数:{2})", strUserStateId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserStateEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserStateEN.UserStateId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserStateBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserStateEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserStateEN> arrObjLst = new List<clsQxUserStateEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserStateEN objQxUserStateEN = new clsQxUserStateEN();
objQxUserStateEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objQxUserStateEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objQxUserStateEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserStateEN);
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
public static List<clsQxUserStateEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserStateEN> arrObjLst = new List<clsQxUserStateEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserStateEN objQxUserStateEN = new clsQxUserStateEN();
objQxUserStateEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objQxUserStateEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objQxUserStateEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserStateEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strUserStateId)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
int intResult = objQxUserStateService.QxUserState_DelRecord(strUserStateId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_DelRecord", "clsQxUserStateWS:DelRecordWs", objException.Message);
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
public static int DelQxUserStatesWs(List<string> arrUserStateId)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrUserStateId);
int intResult = objQxUserStateService.QxUserState_DelQxUserStates(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_DelQxUserStates", "clsQxUserStateWS:DelQxUserStatesWs", objException.Message);
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
public static int DelQxUserStatesByCondWs(string strWhereCond)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
int intRecNum = objQxUserStateService.QxUserState_DelQxUserStatesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_DelQxUserStatesByCond", "clsQxUserStateWS:DelQxUserStatesByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserStateEN objQxUserStateEN)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
bool bolResult = objQxUserStateService.QxUserState_AddNewRecordBySql2(objQxUserStateEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_AddNewRecordBySql2", "clsQxUserStateWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserStateEN objQxUserStateEN)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
bool bolResult = objQxUserStateService.QxUserState_UpdateBySql2(objQxUserStateEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_UpdateBySql2", "clsQxUserStateWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserStateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserStateEN objQxUserStateEN, string strWhereCond)
{
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
try
{
bool bolResult = objQxUserStateService.QxUserState_UpdateBySqlWithCondition(objQxUserStateEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserState_UpdateBySqlWithCondition", "clsQxUserStateWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
bool bolIsExist = objQxUserStateService.QxUserState_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strUserStateId)
{
//检测记录是否存在
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
bool bolIsExist = objQxUserStateService.QxUserState_IsExist(strUserStateId);
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
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
int intRecCount = objQxUserStateService.QxUserState_funGetRecCountByCond(strWhereCond);
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
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
string strMaxUserStateId = objQxUserStateService.QxUserState_GetMaxStrId();
return strMaxUserStateId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxUserStateServiceSoapClient objQxUserStateService = GetQxUserStateServiceSoapClient();
string strMaxUserStateId = objQxUserStateService.QxUserState_GetMaxStrIdByPrefix(strPrefix);
return strMaxUserStateId;
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