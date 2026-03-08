
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxDepartmentInfoWS
 表名:vQxDepartmentInfo(00140035)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:02
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
using GeneralPlatform4WS.ServiceReferencevQxDepartmentInfo;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v部门(vQxDepartmentInfo)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxDepartmentInfoWS
{
private static string mstrPageName = "vQxDepartmentInfoService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxDepartmentInfoServiceSoapClient GetvQxDepartmentInfoServiceSoapClient()
{
if (objvQxDepartmentInfoServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxDepartmentInfoServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxDepartmentInfoServiceSoapClient(binding, address);
}
else
{
return objvQxDepartmentInfoServiceSoapClient;
}
}

 public clsvQxDepartmentInfoWS()
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
List<clsvQxDepartmentInfoEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
objvQxDepartmentInfoEN.DepartmentId = "0";
objvQxDepartmentInfoEN.DepartmentName = "请选择[v部门]...";
arrObjLst.Insert(0, objvQxDepartmentInfoEN);
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v部门]...","0");
List<clsvQxDepartmentInfoEN> arrObjLst = GetObjLst("1 = 1");
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
public static int BindLv_vQxDepartmentInfo(System.Windows.Forms.ListView lvvQxDepartmentInfo, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxDepartmentInfo; 
List<clsvQxDepartmentInfoEN> arrvQxDepartmentInfoObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxDepartmentInfoObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxDepartmentInfo.Items.Clear();//清除原来所有Item
lvvQxDepartmentInfo.Columns.Clear();//清除原来所有列头信息
lvvQxDepartmentInfo.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("部门类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("部门类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("所属部门号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("用户数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.Columns.Add("上级部门", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfo.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxDepartmentInfoEN objvQxDepartmentInfoEN in arrvQxDepartmentInfoObjLst)
{
lvivQxDepartmentInfo = new System.Windows.Forms.ListViewItem();
lvivQxDepartmentInfo.Tag = objvQxDepartmentInfoEN.DepartmentId;
lvivQxDepartmentInfo.Text = objvQxDepartmentInfoEN.DepartmentId.ToString();
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.DepartmentName);
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.DepartmentAbbrName);
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.DepartmentTypeId);
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.DepartmentTypeName);
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.UpDepartmentId);
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.OrderNum.ToString());
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.InUse.ToString());
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.Memo);
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.UserNum.ToString());
lvivQxDepartmentInfo.SubItems.Add(objvQxDepartmentInfoEN.UpDepartmentName);
lvvQxDepartmentInfo.Items.Add(lvivQxDepartmentInfo);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxDepartmentInfoObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxDepartmentInfoService.vQxDepartmentInfo_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfo_GetDataSet", "clsvQxDepartmentInfoWS:GetDataTableWs", objException.Message);
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
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxDepartmentInfoService.vQxDepartmentInfo_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfo_GetTopDataSet", "clsvQxDepartmentInfoWS:GetDataTable_TopWs", objException.Message);
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
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxDepartmentInfoService.vQxDepartmentInfo_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfo_GetDataSetByRange", "clsvQxDepartmentInfoWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxDepartmentInfoWs(ref clsvQxDepartmentInfoEN objvQxDepartmentInfoEN)
{
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
bool bolResult = objvQxDepartmentInfoService.vQxDepartmentInfo_GetvQxDepartmentInfo(ref objvQxDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoEN GetObjByDepartmentIdWs(string strDepartmentId)
{
strDepartmentId = strDepartmentId.Replace("'", "");
strDepartmentId = strDepartmentId.Replace(" ", "");
strDepartmentId = strDepartmentId.Replace("(", "");
strDepartmentId = strDepartmentId.Replace(")", "");
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = objvQxDepartmentInfoService.vQxDepartmentInfo_GetObjByDepartmentId(strDepartmentId);
return objvQxDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
try
{
string strDepartmentId = objvQxDepartmentInfoService.vQxDepartmentInfo_GetFirstID_S(strWhereCond);
return strDepartmentId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfo_GetFirstID_S", "clsvQxDepartmentInfoWS:GetFirstID_S", objException.Message);
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
public static clsvQxDepartmentInfoEN GetFirstvQxDepartmentInfo_S(string strWhereCond)
{
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
try
{
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = objvQxDepartmentInfoService.vQxDepartmentInfo_GetFirstObj_S(strWhereCond);
return objvQxDepartmentInfoEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfo_GetFirstObj_S", "clsvQxDepartmentInfoWS:GetFirstObj_S", objException.Message);
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
int intEnd = arrvQxDepartmentInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxDepartmentInfoEN = arrvQxDepartmentInfoObjLst_Cache[intMid];
if (objvQxDepartmentInfoEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objvQxDepartmentInfoEN.DepartmentName;
}
else if (objvQxDepartmentInfoEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrvQxDepartmentInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetDepartmentNameByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在vQxDepartmentInfo对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:{2})", strDepartmentId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxDepartmentInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxDepartmentInfoEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxDepartmentInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
if (arrvQxDepartmentInfoObjLst_Cache == null)
{
arrvQxDepartmentInfoObjLst_Cache = clsvQxDepartmentInfoWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxDepartmentInfoEN GetObjByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxDepartmentInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxDepartmentInfoEN = arrvQxDepartmentInfoObjLst_Cache[intMid];
if (objvQxDepartmentInfoEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objvQxDepartmentInfoEN;
}
else if (objvQxDepartmentInfoEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrvQxDepartmentInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在vQxDepartmentInfo对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:{2})", strDepartmentId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxDepartmentInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxDepartmentInfoEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxDepartmentInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
objvQxDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["UserNum"].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
public static List<clsvQxDepartmentInfoEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxDepartmentInfoEN> arrObjLst = new List<clsvQxDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoEN objvQxDepartmentInfoEN = new clsvQxDepartmentInfoEN();
objvQxDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxDepartmentInfoEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxDepartmentInfoEN.UserNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["UserNum"].ToString().Trim()); //用户数
objvQxDepartmentInfoEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
	arrObjLst.Add(objvQxDepartmentInfoEN);
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
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
bool bolIsExist = objvQxDepartmentInfoService.vQxDepartmentInfo_IsExistRecord(strWhereCond);
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
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
bool bolIsExist = objvQxDepartmentInfoService.vQxDepartmentInfo_IsExist(strDepartmentId);
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
vQxDepartmentInfoServiceSoapClient objvQxDepartmentInfoService = GetvQxDepartmentInfoServiceSoapClient();
int intRecCount = objvQxDepartmentInfoService.vQxDepartmentInfo_funGetRecCountByCond(strWhereCond);
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