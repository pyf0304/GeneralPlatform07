
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentInfoWS
 表名:QxDepartmentInfo(00140030)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:01
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
using GeneralPlatform4WS.ServiceReferenceQxDepartmentInfo;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 部门(QxDepartmentInfo)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxDepartmentInfoWS
{
private static string mstrPageName = "QxDepartmentInfoService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxDepartmentInfoEN> arrQxDepartmentInfoObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxDepartmentInfoServiceSoapClient objQxDepartmentInfoServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxDepartmentInfoServiceSoapClient GetQxDepartmentInfoServiceSoapClient()
{
if (objQxDepartmentInfoServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxDepartmentInfoServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxDepartmentInfoServiceSoapClient(binding, address);
}
else
{
return objQxDepartmentInfoServiceSoapClient;
}
}

 public clsQxDepartmentInfoWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_DepartmentId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxDepartmentInfoEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
objQxDepartmentInfoEN.DepartmentId = "0";
objQxDepartmentInfoEN.DepartmentName = "请选择[部门]...";
arrObjLst.Insert(0, objQxDepartmentInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="DepartmentId";
objComboBox.DisplayMember="DepartmentName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[部门]...","0");
List<clsQxDepartmentInfoEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="DepartmentId";
objDDL.DataTextField="DepartmentName";
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
public static int BindLv_QxDepartmentInfo(System.Windows.Forms.ListView lvQxDepartmentInfo, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxDepartmentInfo; 
List<clsQxDepartmentInfoEN> arrQxDepartmentInfoObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxDepartmentInfoObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxDepartmentInfo.Items.Clear();//清除原来所有Item
lvQxDepartmentInfo.Columns.Clear();//清除原来所有列头信息
lvQxDepartmentInfo.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.Columns.Add("部门类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.Columns.Add("所属部门号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxDepartmentInfo.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxDepartmentInfoEN objQxDepartmentInfoEN in arrQxDepartmentInfoObjLst)
{
lviQxDepartmentInfo = new System.Windows.Forms.ListViewItem();
lviQxDepartmentInfo.Tag = objQxDepartmentInfoEN.DepartmentId;
lviQxDepartmentInfo.Text = objQxDepartmentInfoEN.DepartmentId.ToString();
lviQxDepartmentInfo.SubItems.Add(objQxDepartmentInfoEN.DepartmentName);
lviQxDepartmentInfo.SubItems.Add(objQxDepartmentInfoEN.DepartmentAbbrName);
lviQxDepartmentInfo.SubItems.Add(objQxDepartmentInfoEN.OrderNum.ToString());
lviQxDepartmentInfo.SubItems.Add(objQxDepartmentInfoEN.InUse.ToString());
lviQxDepartmentInfo.SubItems.Add(objQxDepartmentInfoEN.Memo);
lvQxDepartmentInfo.Items.Add(lviQxDepartmentInfo);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxDepartmentInfoObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
if (!Object.Equals(null, objQxDepartmentInfoEN.DepartmentId) && GetStrLen(objQxDepartmentInfoEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxDepartmentInfoEN.DepartmentName) && GetStrLen(objQxDepartmentInfoEN.DepartmentName) > 100)
{
 throw new Exception("字段[部门名]的长度不能超过100!");
}
if (!Object.Equals(null, objQxDepartmentInfoEN.DepartmentAbbrName) && GetStrLen(objQxDepartmentInfoEN.DepartmentAbbrName) > 8)
{
 throw new Exception("字段[名称缩写]的长度不能超过8!");
}
if (!Object.Equals(null, objQxDepartmentInfoEN.DepartmentTypeId) && GetStrLen(objQxDepartmentInfoEN.DepartmentTypeId) > 2)
{
 throw new Exception("字段[部门类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQxDepartmentInfoEN.UpDepartmentId) && GetStrLen(objQxDepartmentInfoEN.UpDepartmentId) > 6)
{
 throw new Exception("字段[所属部门号]的长度不能超过6!");
}
if (!Object.Equals(null, objQxDepartmentInfoEN.Memo) && GetStrLen(objQxDepartmentInfoEN.Memo) > 1000)
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
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxDepartmentInfoService.QxDepartmentInfo_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_GetDataSet", "clsQxDepartmentInfoWS:GetDataTableWs", objException.Message);
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
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxDepartmentInfoService.QxDepartmentInfo_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_GetTopDataSet", "clsQxDepartmentInfoWS:GetDataTable_TopWs", objException.Message);
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
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxDepartmentInfoService.QxDepartmentInfo_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_GetDataSetByRange", "clsQxDepartmentInfoWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxDepartmentInfoService.QxDepartmentInfo_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_GetDataSetV", "clsQxDepartmentInfoWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxDepartmentInfoVWs(string strWhereCond)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxDepartmentInfoService.QxDepartmentInfo_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_GetDataSetV", "clsQxDepartmentInfoWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxDepartmentInfoWs(ref clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
bool bolResult = objQxDepartmentInfoService.QxDepartmentInfo_GetQxDepartmentInfo(ref objQxDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxDepartmentInfoEN GetObjByDepartmentIdWs(string strDepartmentId)
{
strDepartmentId = strDepartmentId.Replace("'", "");
strDepartmentId = strDepartmentId.Replace(" ", "");
strDepartmentId = strDepartmentId.Replace("(", "");
strDepartmentId = strDepartmentId.Replace(")", "");
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
clsQxDepartmentInfoEN objQxDepartmentInfoEN = objQxDepartmentInfoService.QxDepartmentInfo_GetObjByDepartmentId(strDepartmentId);
return objQxDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
string strDepartmentId = objQxDepartmentInfoService.QxDepartmentInfo_GetFirstID_S(strWhereCond);
return strDepartmentId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_GetFirstID_S", "clsQxDepartmentInfoWS:GetFirstID_S", objException.Message);
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
public static clsQxDepartmentInfoEN GetFirstQxDepartmentInfo_S(string strWhereCond)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
clsQxDepartmentInfoEN objQxDepartmentInfoEN = objQxDepartmentInfoService.QxDepartmentInfo_GetFirstObj_S(strWhereCond);
return objQxDepartmentInfoEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_GetFirstObj_S", "clsQxDepartmentInfoWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDepartmentNameByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxDepartmentInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsQxDepartmentInfoEN objQxDepartmentInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxDepartmentInfoEN = arrQxDepartmentInfoObjLst_Cache[intMid];
if (objQxDepartmentInfoEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objQxDepartmentInfoEN.DepartmentName;
}
else if (objQxDepartmentInfoEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrQxDepartmentInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetDepartmentNameByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在QxDepartmentInfo对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:{2})", strDepartmentId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxDepartmentInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxDepartmentInfoEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxDepartmentInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by DepartmentId");
if (arrQxDepartmentInfoObjLst_Cache == null)
{
arrQxDepartmentInfoObjLst_Cache = clsQxDepartmentInfoWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxDepartmentInfoEN GetObjByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxDepartmentInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsQxDepartmentInfoEN objQxDepartmentInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxDepartmentInfoEN = arrQxDepartmentInfoObjLst_Cache[intMid];
if (objQxDepartmentInfoEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objQxDepartmentInfoEN;
}
else if (objQxDepartmentInfoEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrQxDepartmentInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在QxDepartmentInfo对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:{2})", strDepartmentId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxDepartmentInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxDepartmentInfoEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxDepartmentInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxDepartmentInfoEN> GetObjLst(string strWhereCond)
{
 List<clsQxDepartmentInfoEN> arrObjLst = new List<clsQxDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
objQxDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objQxDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objQxDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objQxDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objQxDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objQxDepartmentInfoEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objQxDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objQxDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxDepartmentInfoEN);
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
public static List<clsQxDepartmentInfoEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxDepartmentInfoEN> arrObjLst = new List<clsQxDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxDepartmentInfoEN objQxDepartmentInfoEN = new clsQxDepartmentInfoEN();
objQxDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objQxDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objQxDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objQxDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objQxDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objQxDepartmentInfoEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objQxDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objQxDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxDepartmentInfoEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strDepartmentId)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
int intResult = objQxDepartmentInfoService.QxDepartmentInfo_DelRecord(strDepartmentId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_DelRecord", "clsQxDepartmentInfoWS:DelRecordWs", objException.Message);
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
public static int DelQxDepartmentInfosWs(List<string> arrDepartmentId)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrDepartmentId);
int intResult = objQxDepartmentInfoService.QxDepartmentInfo_DelQxDepartmentInfos(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_DelQxDepartmentInfos", "clsQxDepartmentInfoWS:DelQxDepartmentInfosWs", objException.Message);
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
public static int DelQxDepartmentInfosByCondWs(string strWhereCond)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
int intRecNum = objQxDepartmentInfoService.QxDepartmentInfo_DelQxDepartmentInfosByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_DelQxDepartmentInfosByCond", "clsQxDepartmentInfoWS:DelQxDepartmentInfosByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
bool bolResult = objQxDepartmentInfoService.QxDepartmentInfo_AddNewRecordBySql2(objQxDepartmentInfoEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_AddNewRecordBySql2", "clsQxDepartmentInfoWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxDepartmentInfoEN objQxDepartmentInfoEN)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
bool bolResult = objQxDepartmentInfoService.QxDepartmentInfo_UpdateBySql2(objQxDepartmentInfoEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_UpdateBySql2", "clsQxDepartmentInfoWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxDepartmentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxDepartmentInfoEN objQxDepartmentInfoEN, string strWhereCond)
{
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
try
{
bool bolResult = objQxDepartmentInfoService.QxDepartmentInfo_UpdateBySqlWithCondition(objQxDepartmentInfoEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxDepartmentInfo_UpdateBySqlWithCondition", "clsQxDepartmentInfoWS:UpdateBySqlWithCondition", objException.Message);
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
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
bool bolIsExist = objQxDepartmentInfoService.QxDepartmentInfo_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strDepartmentId)
{
//检测记录是否存在
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
bool bolIsExist = objQxDepartmentInfoService.QxDepartmentInfo_IsExist(strDepartmentId);
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
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
int intRecCount = objQxDepartmentInfoService.QxDepartmentInfo_funGetRecCountByCond(strWhereCond);
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
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
string strMaxDepartmentId = objQxDepartmentInfoService.QxDepartmentInfo_GetMaxStrId();
return strMaxDepartmentId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxDepartmentInfoServiceSoapClient objQxDepartmentInfoService = GetQxDepartmentInfoServiceSoapClient();
string strMaxDepartmentId = objQxDepartmentInfoService.QxDepartmentInfo_GetMaxStrIdByPrefix(strPrefix);
return strMaxDepartmentId;
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