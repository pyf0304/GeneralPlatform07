
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcelSetWS
 表名:vExportExcelSet(00140067)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:14
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
using GeneralPlatform4WS.ServiceReferencevExportExcelSet;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v导出Excel设置(vExportExcelSet)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvExportExcelSetWS
{
private static string mstrPageName = "vExportExcelSetService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvExportExcelSetEN> arrvExportExcelSetObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vExportExcelSetServiceSoapClient objvExportExcelSetServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vExportExcelSetServiceSoapClient GetvExportExcelSetServiceSoapClient()
{
if (objvExportExcelSetServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vExportExcelSetServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vExportExcelSetServiceSoapClient(binding, address);
}
else
{
return objvExportExcelSetServiceSoapClient;
}
}

 public clsvExportExcelSetWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_ExportExcel4Users(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvExportExcelSetEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
objvExportExcelSetEN.id_ExportExcel4Users = "0";
objvExportExcelSetEN.ViewTabName = "请选择[v导出Excel设置]...";
arrObjLst.Insert(0, objvExportExcelSetEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="id_ExportExcel4Users";
objComboBox.DisplayMember="ViewTabName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_ExportExcel4Users(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v导出Excel设置]...","0");
List<clsvExportExcelSetEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="id_ExportExcel4Users";
objDDL.DataTextField="ViewTabName";
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
public static int BindLv_vExportExcelSet(System.Windows.Forms.ListView lvvExportExcelSet, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivExportExcelSet; 
List<clsvExportExcelSetEN> arrvExportExcelSetObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvExportExcelSetObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvExportExcelSet.Items.Clear();//清除原来所有Item
lvvExportExcelSet.Columns.Clear();//清除原来所有列头信息
lvvExportExcelSet.Columns.Add("导出Excel用户字段流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("TabName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("是否缺省用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("导出文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.Columns.Add("ViewTabName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcelSet.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvExportExcelSetEN objvExportExcelSetEN in arrvExportExcelSetObjLst)
{
lvivExportExcelSet = new System.Windows.Forms.ListViewItem();
lvivExportExcelSet.Tag = objvExportExcelSetEN.id_ExportExcel4Users;
lvivExportExcelSet.Text = objvExportExcelSetEN.id_ExportExcel4Users.ToString();
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.ViewName);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.TabName);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.IsDefaultUser.ToString());
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.UserName);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.ExportFileName);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.UpdUserId);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.UpdDate);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.Memo);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.UserId);
lvivExportExcelSet.SubItems.Add(objvExportExcelSetEN.ViewTabName);
lvvExportExcelSet.Items.Add(lvivExportExcelSet);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvExportExcelSetObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvExportExcelSetService.vExportExcelSet_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcelSet_GetDataSet", "clsvExportExcelSetWS:GetDataTableWs", objException.Message);
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
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvExportExcelSetService.vExportExcelSet_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcelSet_GetTopDataSet", "clsvExportExcelSetWS:GetDataTable_TopWs", objException.Message);
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
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvExportExcelSetService.vExportExcelSet_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcelSet_GetDataSetByRange", "clsvExportExcelSetWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvExportExcelSetWs(ref clsvExportExcelSetEN objvExportExcelSetEN)
{
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
bool bolResult = objvExportExcelSetService.vExportExcelSet_GetvExportExcelSet(ref objvExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcelSetEN GetObjByid_ExportExcel4UsersWs(string strid_ExportExcel4Users)
{
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace("'", "");
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace(" ", "");
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace("(", "");
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace(")", "");
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
clsvExportExcelSetEN objvExportExcelSetEN = objvExportExcelSetService.vExportExcelSet_GetObjByid_ExportExcel4Users(strid_ExportExcel4Users);
return objvExportExcelSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
try
{
string strid_ExportExcel4Users = objvExportExcelSetService.vExportExcelSet_GetFirstID_S(strWhereCond);
return strid_ExportExcel4Users;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcelSet_GetFirstID_S", "clsvExportExcelSetWS:GetFirstID_S", objException.Message);
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
public static clsvExportExcelSetEN GetFirstvExportExcelSet_S(string strWhereCond)
{
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
try
{
clsvExportExcelSetEN objvExportExcelSetEN = objvExportExcelSetService.vExportExcelSet_GetFirstObj_S(strWhereCond);
return objvExportExcelSetEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcelSet_GetFirstObj_S", "clsvExportExcelSetWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewTabNameByid_ExportExcel4Users_Cache(string strid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvExportExcelSetObjLst_Cache.Count - 1;
int intMid = 0;
clsvExportExcelSetEN objvExportExcelSetEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvExportExcelSetEN = arrvExportExcelSetObjLst_Cache[intMid];
if (objvExportExcelSetEN.id_ExportExcel4Users == strid_ExportExcel4Users)
{
intFindFailCount = 0;
return objvExportExcelSetEN.ViewTabName;
}
else if (objvExportExcelSetEN.id_ExportExcel4Users.CompareTo(strid_ExportExcel4Users) > 0)
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
arrvExportExcelSetObjLst_Cache = null;
if (intFindFailCount == 1) return GetViewTabNameByid_ExportExcel4Users_Cache(strid_ExportExcel4Users);
string strErrMsgForGetObjById = string.Format("在vExportExcelSet对象缓存列表中,找不到记录[id_ExportExcel4Users = {0}][intFindFailCount = {1}](函数:{2})", strid_ExportExcel4Users, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvExportExcelSetEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvExportExcelSetEN.id_ExportExcel4Users, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvExportExcelSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by id_ExportExcel4Users");
if (arrvExportExcelSetObjLst_Cache == null)
{
arrvExportExcelSetObjLst_Cache = clsvExportExcelSetWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcelSetEN GetObjByid_ExportExcel4Users_Cache(string strid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvExportExcelSetObjLst_Cache.Count - 1;
int intMid = 0;
clsvExportExcelSetEN objvExportExcelSetEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvExportExcelSetEN = arrvExportExcelSetObjLst_Cache[intMid];
if (objvExportExcelSetEN.id_ExportExcel4Users == strid_ExportExcel4Users)
{
intFindFailCount = 0;
return objvExportExcelSetEN;
}
else if (objvExportExcelSetEN.id_ExportExcel4Users.CompareTo(strid_ExportExcel4Users) > 0)
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
arrvExportExcelSetObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByid_ExportExcel4Users_Cache(strid_ExportExcel4Users);
string strErrMsgForGetObjById = string.Format("在vExportExcelSet对象缓存列表中,找不到记录[id_ExportExcel4Users = {0}][intFindFailCount = {1}](函数:{2})", strid_ExportExcel4Users, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvExportExcelSetEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvExportExcelSetEN.id_ExportExcel4Users, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvExportExcelSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcelSetEN> GetObjLst(string strWhereCond)
{
 List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
objvExportExcelSetEN.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow["TabName"].ToString().Trim(); //TabName
objvExportExcelSetEN.IsDefaultUser = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefaultUser"].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow["ExportFileName"].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvExportExcelSetEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvExportExcelSetEN.ViewTabName = objRow["ViewTabName"].ToString().Trim(); //ViewTabName
	arrObjLst.Add(objvExportExcelSetEN);
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
public static List<clsvExportExcelSetEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
objvExportExcelSetEN.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow["TabName"].ToString().Trim(); //TabName
objvExportExcelSetEN.IsDefaultUser = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefaultUser"].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow["ExportFileName"].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvExportExcelSetEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvExportExcelSetEN.ViewTabName = objRow["ViewTabName"].ToString().Trim(); //ViewTabName
	arrObjLst.Add(objvExportExcelSetEN);
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
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
bool bolIsExist = objvExportExcelSetService.vExportExcelSet_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strid_ExportExcel4Users)
{
//检测记录是否存在
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
bool bolIsExist = objvExportExcelSetService.vExportExcelSet_IsExist(strid_ExportExcel4Users);
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
vExportExcelSetServiceSoapClient objvExportExcelSetService = GetvExportExcelSetServiceSoapClient();
int intRecCount = objvExportExcelSetService.vExportExcelSet_funGetRecCountByCond(strWhereCond);
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