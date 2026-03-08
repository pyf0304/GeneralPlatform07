
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcelSetWS
 表名:ExportExcelSet(00140065)
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
using GeneralPlatform4WS.ServiceReferenceExportExcelSet;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 导出Excel设置(ExportExcelSet)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsExportExcelSetWS
{
private static string mstrPageName = "ExportExcelSetService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsExportExcelSetEN> arrExportExcelSetObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static ExportExcelSetServiceSoapClient objExportExcelSetServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static ExportExcelSetServiceSoapClient GetExportExcelSetServiceSoapClient()
{
if (objExportExcelSetServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "ExportExcelSetServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new ExportExcelSetServiceSoapClient(binding, address);
}
else
{
return objExportExcelSetServiceSoapClient;
}
}

 public clsExportExcelSetWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_ExportExcelSet(System.Windows.Forms.ListView lvExportExcelSet, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviExportExcelSet; 
List<clsExportExcelSetEN> arrExportExcelSetObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrExportExcelSetObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvExportExcelSet.Items.Clear();//清除原来所有Item
lvExportExcelSet.Columns.Clear();//清除原来所有列头信息
lvExportExcelSet.Columns.Add("导出Excel用户字段流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("TabName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("是否缺省用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("导出文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvExportExcelSet.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsExportExcelSetEN objExportExcelSetEN in arrExportExcelSetObjLst)
{
lviExportExcelSet = new System.Windows.Forms.ListViewItem();
lviExportExcelSet.Tag = objExportExcelSetEN.id_ExportExcel4Users;
lviExportExcelSet.Text = objExportExcelSetEN.id_ExportExcel4Users.ToString();
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.ViewName);
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.TabName);
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.UserId);
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.IsDefaultUser.ToString());
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.ExportFileName);
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.UpdDate);
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.UpdUserId);
lviExportExcelSet.SubItems.Add(objExportExcelSetEN.Memo);
lvExportExcelSet.Items.Add(lviExportExcelSet);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrExportExcelSetObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsExportExcelSetEN objExportExcelSetEN)
{
if (!Object.Equals(null, objExportExcelSetEN.id_ExportExcel4Users) && GetStrLen(objExportExcelSetEN.id_ExportExcel4Users) > 8)
{
 throw new Exception("字段[导出Excel用户字段流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objExportExcelSetEN.ViewName) && GetStrLen(objExportExcelSetEN.ViewName) > 100)
{
 throw new Exception("字段[界面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objExportExcelSetEN.TabName) && GetStrLen(objExportExcelSetEN.TabName) > 100)
{
 throw new Exception("字段[TabName]的长度不能超过100!");
}
if (!Object.Equals(null, objExportExcelSetEN.UserId) && GetStrLen(objExportExcelSetEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objExportExcelSetEN.ExportFileName) && GetStrLen(objExportExcelSetEN.ExportFileName) > 100)
{
 throw new Exception("字段[导出文件名]的长度不能超过100!");
}
if (!Object.Equals(null, objExportExcelSetEN.UpdDate) && GetStrLen(objExportExcelSetEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objExportExcelSetEN.UpdUserId) && GetStrLen(objExportExcelSetEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objExportExcelSetEN.Memo) && GetStrLen(objExportExcelSetEN.Memo) > 1000)
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
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objExportExcelSetService.ExportExcelSet_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_GetDataSet", "clsExportExcelSetWS:GetDataTableWs", objException.Message);
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
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objExportExcelSetService.ExportExcelSet_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_GetTopDataSet", "clsExportExcelSetWS:GetDataTable_TopWs", objException.Message);
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
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objExportExcelSetService.ExportExcelSet_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_GetDataSetByRange", "clsExportExcelSetWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objExportExcelSetService.ExportExcelSet_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_GetDataSetV", "clsExportExcelSetWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetExportExcelSetVWs(string strWhereCond)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objExportExcelSetService.ExportExcelSet_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_GetDataSetV", "clsExportExcelSetWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objExportExcelSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetExportExcelSetWs(ref clsExportExcelSetEN objExportExcelSetEN)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
bool bolResult = objExportExcelSetService.ExportExcelSet_GetExportExcelSet(ref objExportExcelSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public static clsExportExcelSetEN GetObjByid_ExportExcel4UsersWs(string strid_ExportExcel4Users)
{
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace("'", "");
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace(" ", "");
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace("(", "");
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace(")", "");
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
clsExportExcelSetEN objExportExcelSetEN = objExportExcelSetService.ExportExcelSet_GetObjByid_ExportExcel4Users(strid_ExportExcel4Users);
return objExportExcelSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
string strid_ExportExcel4Users = objExportExcelSetService.ExportExcelSet_GetFirstID_S(strWhereCond);
return strid_ExportExcel4Users;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_GetFirstID_S", "clsExportExcelSetWS:GetFirstID_S", objException.Message);
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
public static clsExportExcelSetEN GetFirstExportExcelSet_S(string strWhereCond)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
clsExportExcelSetEN objExportExcelSetEN = objExportExcelSetService.ExportExcelSet_GetFirstObj_S(strWhereCond);
return objExportExcelSetEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_GetFirstObj_S", "clsExportExcelSetWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by id_ExportExcel4Users");
if (arrExportExcelSetObjLst_Cache == null)
{
arrExportExcelSetObjLst_Cache = clsExportExcelSetWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_ExportExcel4Users">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsExportExcelSetEN GetObjByid_ExportExcel4Users_Cache(string strid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrExportExcelSetObjLst_Cache.Count - 1;
int intMid = 0;
clsExportExcelSetEN objExportExcelSetEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objExportExcelSetEN = arrExportExcelSetObjLst_Cache[intMid];
if (objExportExcelSetEN.id_ExportExcel4Users == strid_ExportExcel4Users)
{
intFindFailCount = 0;
return objExportExcelSetEN;
}
else if (objExportExcelSetEN.id_ExportExcel4Users.CompareTo(strid_ExportExcel4Users) > 0)
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
arrExportExcelSetObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByid_ExportExcel4Users_Cache(strid_ExportExcel4Users);
string strErrMsgForGetObjById = string.Format("在ExportExcelSet对象缓存列表中,找不到记录[id_ExportExcel4Users = {0}][intFindFailCount = {1}](函数:{2})", strid_ExportExcel4Users, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objExportExcelSetEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objExportExcelSetEN.id_ExportExcel4Users, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsExportExcelSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcelSetEN> GetObjLst(string strWhereCond)
{
 List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
objExportExcelSetEN.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow["TabName"].ToString().Trim(); //TabName
objExportExcelSetEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objExportExcelSetEN.IsDefaultUser = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefaultUser"].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow["ExportFileName"].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objExportExcelSetEN);
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
public static List<clsExportExcelSetEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
objExportExcelSetEN.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow["TabName"].ToString().Trim(); //TabName
objExportExcelSetEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objExportExcelSetEN.IsDefaultUser = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefaultUser"].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow["ExportFileName"].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objExportExcelSetEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strid_ExportExcel4Users)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
int intResult = objExportExcelSetService.ExportExcelSet_DelRecord(strid_ExportExcel4Users);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_DelRecord", "clsExportExcelSetWS:DelRecordWs", objException.Message);
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
public static int DelExportExcelSetsWs(List<string> arrid_ExportExcel4Users)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrid_ExportExcel4Users);
int intResult = objExportExcelSetService.ExportExcelSet_DelExportExcelSets(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_DelExportExcelSets", "clsExportExcelSetWS:DelExportExcelSetsWs", objException.Message);
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
public static int DelExportExcelSetsByCondWs(string strWhereCond)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
int intRecNum = objExportExcelSetService.ExportExcelSet_DelExportExcelSetsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_DelExportExcelSetsByCond", "clsExportExcelSetWS:DelExportExcelSetsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsExportExcelSetEN objExportExcelSetEN)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
bool bolResult = objExportExcelSetService.ExportExcelSet_AddNewRecordBySql2(objExportExcelSetEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_AddNewRecordBySql2", "clsExportExcelSetWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsExportExcelSetEN objExportExcelSetEN)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
bool bolResult = objExportExcelSetService.ExportExcelSet_UpdateBySql2(objExportExcelSetEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_UpdateBySql2", "clsExportExcelSetWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsExportExcelSetEN objExportExcelSetEN, string strWhereCond)
{
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
try
{
bool bolResult = objExportExcelSetService.ExportExcelSet_UpdateBySqlWithCondition(objExportExcelSetEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "ExportExcelSet_UpdateBySqlWithCondition", "clsExportExcelSetWS:UpdateBySqlWithCondition", objException.Message);
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
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
bool bolIsExist = objExportExcelSetService.ExportExcelSet_IsExistRecord(strWhereCond);
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
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
bool bolIsExist = objExportExcelSetService.ExportExcelSet_IsExist(strid_ExportExcel4Users);
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
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
int intRecCount = objExportExcelSetService.ExportExcelSet_funGetRecCountByCond(strWhereCond);
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
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
string strMaxId_ExportExcel4Users = objExportExcelSetService.ExportExcelSet_GetMaxStrId();
return strMaxId_ExportExcel4Users;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
ExportExcelSetServiceSoapClient objExportExcelSetService = GetExportExcelSetServiceSoapClient();
string strMaxId_ExportExcel4Users = objExportExcelSetService.ExportExcelSet_GetMaxStrIdByPrefix(strPrefix);
return strMaxId_ExportExcel4Users;
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