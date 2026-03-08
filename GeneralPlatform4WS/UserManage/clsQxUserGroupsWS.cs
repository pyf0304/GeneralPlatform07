
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserGroupsWS
 表名:QxUserGroups(00140010)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:53
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
using GeneralPlatform4WS.ServiceReferenceQxUserGroups;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户组(QxUserGroups)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserGroupsWS
{
private static string mstrPageName = "QxUserGroupsService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserGroupsEN> arrQxUserGroupsObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserGroupsServiceSoapClient objQxUserGroupsServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserGroupsServiceSoapClient GetQxUserGroupsServiceSoapClient()
{
if (objQxUserGroupsServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserGroupsServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserGroupsServiceSoapClient(binding, address);
}
else
{
return objQxUserGroupsServiceSoapClient;
}
}

 public clsQxUserGroupsWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_GroupId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxUserGroupsEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxUserGroupsEN objQxUserGroupsEN = new clsQxUserGroupsEN();
objQxUserGroupsEN.GroupId = "0";
objQxUserGroupsEN.GroupName = "请选择[用户组]...";
arrObjLst.Insert(0, objQxUserGroupsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="GroupId";
objComboBox.DisplayMember="GroupName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_GroupId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[用户组]...","0");
List<clsQxUserGroupsEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="GroupId";
objDDL.DataTextField="GroupName";
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
public static int BindLv_QxUserGroups(System.Windows.Forms.ListView lvQxUserGroups, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserGroups; 
List<clsQxUserGroupsEN> arrQxUserGroupsObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserGroupsObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserGroups.Items.Clear();//清除原来所有Item
lvQxUserGroups.Columns.Clear();//清除原来所有列头信息
lvQxUserGroups.Columns.Add("组Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroups.Columns.Add("组名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroups.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroups.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroups.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserGroupsEN objQxUserGroupsEN in arrQxUserGroupsObjLst)
{
lviQxUserGroups = new System.Windows.Forms.ListViewItem();
lviQxUserGroups.Tag = objQxUserGroupsEN.GroupId;
lviQxUserGroups.Text = objQxUserGroupsEN.GroupId.ToString();
lviQxUserGroups.SubItems.Add(objQxUserGroupsEN.GroupName);
lviQxUserGroups.SubItems.Add(objQxUserGroupsEN.Memo);
lvQxUserGroups.Items.Add(lviQxUserGroups);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserGroupsObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserGroupsEN objQxUserGroupsEN)
{
if (!Object.Equals(null, objQxUserGroupsEN.GroupId) && GetStrLen(objQxUserGroupsEN.GroupId) > 8)
{
 throw new Exception("字段[组Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserGroupsEN.GroupName) && GetStrLen(objQxUserGroupsEN.GroupName) > 30)
{
 throw new Exception("字段[组名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUserGroupsEN.QxPrjId) && GetStrLen(objQxUserGroupsEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserGroupsEN.Memo) && GetStrLen(objQxUserGroupsEN.Memo) > 1000)
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
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupsService.QxUserGroups_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_GetDataSet", "clsQxUserGroupsWS:GetDataTableWs", objException.Message);
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
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupsService.QxUserGroups_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_GetTopDataSet", "clsQxUserGroupsWS:GetDataTable_TopWs", objException.Message);
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
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupsService.QxUserGroups_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_GetDataSetByRange", "clsQxUserGroupsWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupsService.QxUserGroups_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_GetDataSetV", "clsQxUserGroupsWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserGroupsVWs(string strWhereCond)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupsService.QxUserGroups_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_GetDataSetV", "clsQxUserGroupsWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserGroupsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserGroupsWs(ref clsQxUserGroupsEN objQxUserGroupsEN)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
bool bolResult = objQxUserGroupsService.QxUserGroups_GetQxUserGroups(ref objQxUserGroupsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserGroupsEN GetObjByGroupIdWs(string strGroupId)
{
strGroupId = strGroupId.Replace("'", "");
strGroupId = strGroupId.Replace(" ", "");
strGroupId = strGroupId.Replace("(", "");
strGroupId = strGroupId.Replace(")", "");
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
clsQxUserGroupsEN objQxUserGroupsEN = objQxUserGroupsService.QxUserGroups_GetObjByGroupId(strGroupId);
return objQxUserGroupsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
string strGroupId = objQxUserGroupsService.QxUserGroups_GetFirstID_S(strWhereCond);
return strGroupId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_GetFirstID_S", "clsQxUserGroupsWS:GetFirstID_S", objException.Message);
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
public static clsQxUserGroupsEN GetFirstQxUserGroups_S(string strWhereCond)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
clsQxUserGroupsEN objQxUserGroupsEN = objQxUserGroupsService.QxUserGroups_GetFirstObj_S(strWhereCond);
return objQxUserGroupsEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_GetFirstObj_S", "clsQxUserGroupsWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetGroupNameByGroupId_Cache(string strGroupId)
{
if (string.IsNullOrEmpty(strGroupId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserGroupsObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserGroupsEN objQxUserGroupsEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserGroupsEN = arrQxUserGroupsObjLst_Cache[intMid];
if (objQxUserGroupsEN.GroupId == strGroupId)
{
intFindFailCount = 0;
return objQxUserGroupsEN.GroupName;
}
else if (objQxUserGroupsEN.GroupId.CompareTo(strGroupId) > 0)
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
arrQxUserGroupsObjLst_Cache = null;
if (intFindFailCount == 1) return GetGroupNameByGroupId_Cache(strGroupId);
string strErrMsgForGetObjById = string.Format("在QxUserGroups对象缓存列表中,找不到记录[GroupId = {0}][intFindFailCount = {1}](函数:{2})", strGroupId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserGroupsEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserGroupsEN.GroupId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserGroupsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by GroupId");
if (arrQxUserGroupsObjLst_Cache == null)
{
arrQxUserGroupsObjLst_Cache = clsQxUserGroupsWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserGroupsEN GetObjByGroupId_Cache(string strGroupId)
{
if (string.IsNullOrEmpty(strGroupId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserGroupsObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserGroupsEN objQxUserGroupsEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserGroupsEN = arrQxUserGroupsObjLst_Cache[intMid];
if (objQxUserGroupsEN.GroupId == strGroupId)
{
intFindFailCount = 0;
return objQxUserGroupsEN;
}
else if (objQxUserGroupsEN.GroupId.CompareTo(strGroupId) > 0)
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
arrQxUserGroupsObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByGroupId_Cache(strGroupId);
string strErrMsgForGetObjById = string.Format("在QxUserGroups对象缓存列表中,找不到记录[GroupId = {0}][intFindFailCount = {1}](函数:{2})", strGroupId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserGroupsEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserGroupsEN.GroupId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserGroupsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserGroupsEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserGroupsEN> arrObjLst = new List<clsQxUserGroupsEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupsEN objQxUserGroupsEN = new clsQxUserGroupsEN();
objQxUserGroupsEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
objQxUserGroupsEN.GroupName = objRow["GroupName"].ToString().Trim(); //组名
objQxUserGroupsEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserGroupsEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserGroupsEN);
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
public static List<clsQxUserGroupsEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserGroupsEN> arrObjLst = new List<clsQxUserGroupsEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupsEN objQxUserGroupsEN = new clsQxUserGroupsEN();
objQxUserGroupsEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
objQxUserGroupsEN.GroupName = objRow["GroupName"].ToString().Trim(); //组名
objQxUserGroupsEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserGroupsEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserGroupsEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strGroupId)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
int intResult = objQxUserGroupsService.QxUserGroups_DelRecord(strGroupId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_DelRecord", "clsQxUserGroupsWS:DelRecordWs", objException.Message);
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
public static int DelQxUserGroupssWs(List<string> arrGroupId)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrGroupId);
int intResult = objQxUserGroupsService.QxUserGroups_DelQxUserGroupss(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_DelQxUserGroupss", "clsQxUserGroupsWS:DelQxUserGroupssWs", objException.Message);
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
public static int DelQxUserGroupssByCondWs(string strWhereCond)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
int intRecNum = objQxUserGroupsService.QxUserGroups_DelQxUserGroupssByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_DelQxUserGroupssByCond", "clsQxUserGroupsWS:DelQxUserGroupssByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserGroupsEN objQxUserGroupsEN)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
bool bolResult = objQxUserGroupsService.QxUserGroups_AddNewRecordBySql2(objQxUserGroupsEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_AddNewRecordBySql2", "clsQxUserGroupsWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserGroupsEN objQxUserGroupsEN)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
bool bolResult = objQxUserGroupsService.QxUserGroups_UpdateBySql2(objQxUserGroupsEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_UpdateBySql2", "clsQxUserGroupsWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserGroupsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserGroupsEN objQxUserGroupsEN, string strWhereCond)
{
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
try
{
bool bolResult = objQxUserGroupsService.QxUserGroups_UpdateBySqlWithCondition(objQxUserGroupsEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroups_UpdateBySqlWithCondition", "clsQxUserGroupsWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
bool bolIsExist = objQxUserGroupsService.QxUserGroups_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strGroupId)
{
//检测记录是否存在
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
bool bolIsExist = objQxUserGroupsService.QxUserGroups_IsExist(strGroupId);
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
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
int intRecCount = objQxUserGroupsService.QxUserGroups_funGetRecCountByCond(strWhereCond);
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
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
string strMaxGroupId = objQxUserGroupsService.QxUserGroups_GetMaxStrId();
return strMaxGroupId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxUserGroupsServiceSoapClient objQxUserGroupsService = GetQxUserGroupsServiceSoapClient();
string strMaxGroupId = objQxUserGroupsService.QxUserGroups_GetMaxStrIdByPrefix(strPrefix);
return strMaxGroupId;
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