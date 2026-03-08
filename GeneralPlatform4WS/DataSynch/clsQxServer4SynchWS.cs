
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxServer4SynchWS
 表名:QxServer4Synch(00140091)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:26
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
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
using GeneralPlatform4WS.ServiceReferenceQxServer4Synch;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 同步服务器(QxServer4Synch)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxServer4SynchWS
{
private static string mstrPageName = "QxServer4SynchService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxServer4SynchEN> arrQxServer4SynchObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxServer4SynchServiceSoapClient objQxServer4SynchServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxServer4SynchServiceSoapClient GetQxServer4SynchServiceSoapClient()
{
if (objQxServer4SynchServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxServer4SynchServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxServer4SynchServiceSoapClient(binding, address);
}
else
{
return objQxServer4SynchServiceSoapClient;
}
}

 public clsQxServer4SynchWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ServerId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxServer4SynchEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
objQxServer4SynchEN.ServerId = "0";
objQxServer4SynchEN.ServerName = "请选择[同步服务器]...";
arrObjLst.Insert(0, objQxServer4SynchEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="ServerId";
objComboBox.DisplayMember="ServerName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ServerId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[同步服务器]...","0");
List<clsQxServer4SynchEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="ServerId";
objDDL.DataTextField="ServerName";
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
public static int BindLv_QxServer4Synch(System.Windows.Forms.ListView lvQxServer4Synch, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxServer4Synch; 
List<clsQxServer4SynchEN> arrQxServer4SynchObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxServer4SynchObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxServer4Synch.Items.Clear();//清除原来所有Item
lvQxServer4Synch.Columns.Clear();//清除原来所有列头信息
lvQxServer4Synch.Columns.Add("服务器Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("服务器名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("WApi地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("是否当前服务器", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("修改用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxServer4Synch.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxServer4SynchEN objQxServer4SynchEN in arrQxServer4SynchObjLst)
{
lviQxServer4Synch = new System.Windows.Forms.ListViewItem();
lviQxServer4Synch.Tag = objQxServer4SynchEN.ServerId;
lviQxServer4Synch.Text = objQxServer4SynchEN.ServerId.ToString();
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.ServerName);
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.IpAddress);
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.WebApiAddress);
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.IsSelf.ToString());
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.InUse.ToString());
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.UpdDate);
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.UpdUser);
lviQxServer4Synch.SubItems.Add(objQxServer4SynchEN.Memo);
lvQxServer4Synch.Items.Add(lviQxServer4Synch);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxServer4SynchObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxServer4SynchEN objQxServer4SynchEN)
{
if (!Object.Equals(null, objQxServer4SynchEN.ServerId) && GetStrLen(objQxServer4SynchEN.ServerId) > 4)
{
 throw new Exception("字段[服务器Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxServer4SynchEN.ServerName) && GetStrLen(objQxServer4SynchEN.ServerName) > 50)
{
 throw new Exception("字段[服务器名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxServer4SynchEN.IpAddress) && GetStrLen(objQxServer4SynchEN.IpAddress) > 23)
{
 throw new Exception("字段[IP地址]的长度不能超过23!");
}
if (!Object.Equals(null, objQxServer4SynchEN.WebApiAddress) && GetStrLen(objQxServer4SynchEN.WebApiAddress) > 50)
{
 throw new Exception("字段[WApi地址]的长度不能超过50!");
}
if (!Object.Equals(null, objQxServer4SynchEN.UpdDate) && GetStrLen(objQxServer4SynchEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxServer4SynchEN.UpdUser) && GetStrLen(objQxServer4SynchEN.UpdUser) > 18)
{
 throw new Exception("字段[修改用户]的长度不能超过18!");
}
if (!Object.Equals(null, objQxServer4SynchEN.Memo) && GetStrLen(objQxServer4SynchEN.Memo) > 1000)
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
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxServer4SynchService.QxServer4Synch_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_GetDataSet", "clsQxServer4SynchWS:GetDataTableWs", objException.Message);
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
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxServer4SynchService.QxServer4Synch_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_GetTopDataSet", "clsQxServer4SynchWS:GetDataTable_TopWs", objException.Message);
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
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxServer4SynchService.QxServer4Synch_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_GetDataSetByRange", "clsQxServer4SynchWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxServer4SynchService.QxServer4Synch_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_GetDataSetV", "clsQxServer4SynchWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxServer4SynchVWs(string strWhereCond)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxServer4SynchService.QxServer4Synch_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_GetDataSetV", "clsQxServer4SynchWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxServer4SynchWs(ref clsQxServer4SynchEN objQxServer4SynchEN)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
bool bolResult = objQxServer4SynchService.QxServer4Synch_GetQxServer4Synch(ref objQxServer4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strServerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxServer4SynchEN GetObjByServerIdWs(string strServerId)
{
strServerId = strServerId.Replace("'", "");
strServerId = strServerId.Replace(" ", "");
strServerId = strServerId.Replace("(", "");
strServerId = strServerId.Replace(")", "");
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
clsQxServer4SynchEN objQxServer4SynchEN = objQxServer4SynchService.QxServer4Synch_GetObjByServerId(strServerId);
return objQxServer4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
string strServerId = objQxServer4SynchService.QxServer4Synch_GetFirstID_S(strWhereCond);
return strServerId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_GetFirstID_S", "clsQxServer4SynchWS:GetFirstID_S", objException.Message);
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
public static clsQxServer4SynchEN GetFirstQxServer4Synch_S(string strWhereCond)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
clsQxServer4SynchEN objQxServer4SynchEN = objQxServer4SynchService.QxServer4Synch_GetFirstObj_S(strWhereCond);
return objQxServer4SynchEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_GetFirstObj_S", "clsQxServer4SynchWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strServerId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetServerNameByServerId_Cache(string strServerId)
{
if (string.IsNullOrEmpty(strServerId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxServer4SynchObjLst_Cache.Count - 1;
int intMid = 0;
clsQxServer4SynchEN objQxServer4SynchEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxServer4SynchEN = arrQxServer4SynchObjLst_Cache[intMid];
if (objQxServer4SynchEN.ServerId == strServerId)
{
intFindFailCount = 0;
return objQxServer4SynchEN.ServerName;
}
else if (objQxServer4SynchEN.ServerId.CompareTo(strServerId) > 0)
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
arrQxServer4SynchObjLst_Cache = null;
if (intFindFailCount == 1) return GetServerNameByServerId_Cache(strServerId);
string strErrMsgForGetObjById = string.Format("在QxServer4Synch对象缓存列表中,找不到记录[ServerId = {0}][intFindFailCount = {1}](函数:{2})", strServerId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxServer4SynchEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxServer4SynchEN.ServerId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxServer4SynchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by ServerId");
if (arrQxServer4SynchObjLst_Cache == null)
{
arrQxServer4SynchObjLst_Cache = clsQxServer4SynchWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strServerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxServer4SynchEN GetObjByServerId_Cache(string strServerId)
{
if (string.IsNullOrEmpty(strServerId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxServer4SynchObjLst_Cache.Count - 1;
int intMid = 0;
clsQxServer4SynchEN objQxServer4SynchEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxServer4SynchEN = arrQxServer4SynchObjLst_Cache[intMid];
if (objQxServer4SynchEN.ServerId == strServerId)
{
intFindFailCount = 0;
return objQxServer4SynchEN;
}
else if (objQxServer4SynchEN.ServerId.CompareTo(strServerId) > 0)
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
arrQxServer4SynchObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByServerId_Cache(strServerId);
string strErrMsgForGetObjById = string.Format("在QxServer4Synch对象缓存列表中,找不到记录[ServerId = {0}][intFindFailCount = {1}](函数:{2})", strServerId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxServer4SynchEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxServer4SynchEN.ServerId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxServer4SynchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxServer4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
objQxServer4SynchEN.ServerId = objRow["ServerId"].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow["ServerName"].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow["WebApiAddress"].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSelf"].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxServer4SynchEN);
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
public static List<clsQxServer4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxServer4SynchEN> arrObjLst = new List<clsQxServer4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxServer4SynchEN objQxServer4SynchEN = new clsQxServer4SynchEN();
objQxServer4SynchEN.ServerId = objRow["ServerId"].ToString().Trim(); //服务器Id
objQxServer4SynchEN.ServerName = objRow["ServerName"].ToString().Trim(); //服务器名
objQxServer4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxServer4SynchEN.WebApiAddress = objRow["WebApiAddress"].ToString().Trim(); //WApi地址
objQxServer4SynchEN.IsSelf = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSelf"].ToString().Trim()); //是否当前服务器
objQxServer4SynchEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objQxServer4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxServer4SynchEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxServer4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxServer4SynchEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strServerId)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
int intResult = objQxServer4SynchService.QxServer4Synch_DelRecord(strServerId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_DelRecord", "clsQxServer4SynchWS:DelRecordWs", objException.Message);
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
public static int DelQxServer4SynchsWs(List<string> arrServerId)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrServerId);
int intResult = objQxServer4SynchService.QxServer4Synch_DelQxServer4Synchs(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_DelQxServer4Synchs", "clsQxServer4SynchWS:DelQxServer4SynchsWs", objException.Message);
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
public static int DelQxServer4SynchsByCondWs(string strWhereCond)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
int intRecNum = objQxServer4SynchService.QxServer4Synch_DelQxServer4SynchsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_DelQxServer4SynchsByCond", "clsQxServer4SynchWS:DelQxServer4SynchsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxServer4SynchEN objQxServer4SynchEN)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
bool bolResult = objQxServer4SynchService.QxServer4Synch_AddNewRecordBySql2(objQxServer4SynchEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_AddNewRecordBySql2", "clsQxServer4SynchWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxServer4SynchEN objQxServer4SynchEN)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
bool bolResult = objQxServer4SynchService.QxServer4Synch_UpdateBySql2(objQxServer4SynchEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_UpdateBySql2", "clsQxServer4SynchWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxServer4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxServer4SynchEN objQxServer4SynchEN, string strWhereCond)
{
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
try
{
bool bolResult = objQxServer4SynchService.QxServer4Synch_UpdateBySqlWithCondition(objQxServer4SynchEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxServer4Synch_UpdateBySqlWithCondition", "clsQxServer4SynchWS:UpdateBySqlWithCondition", objException.Message);
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
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
bool bolIsExist = objQxServer4SynchService.QxServer4Synch_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strServerId)
{
//检测记录是否存在
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
bool bolIsExist = objQxServer4SynchService.QxServer4Synch_IsExist(strServerId);
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
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
int intRecCount = objQxServer4SynchService.QxServer4Synch_funGetRecCountByCond(strWhereCond);
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
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
string strMaxServerId = objQxServer4SynchService.QxServer4Synch_GetMaxStrId();
return strMaxServerId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxServer4SynchServiceSoapClient objQxServer4SynchService = GetQxServer4SynchServiceSoapClient();
string strMaxServerId = objQxServer4SynchService.QxServer4Synch_GetMaxStrIdByPrefix(strPrefix);
return strMaxServerId;
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