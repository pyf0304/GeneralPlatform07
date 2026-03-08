
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcel4UsersWS
 表名:vExportExcel4Users(00140068)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:15
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
using GeneralPlatform4WS.ServiceReferencevExportExcel4Users;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v导出Excel用户字段表(vExportExcel4Users)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvExportExcel4UsersWS
{
private static string mstrPageName = "vExportExcel4UsersService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vExportExcel4UsersServiceSoapClient objvExportExcel4UsersServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vExportExcel4UsersServiceSoapClient GetvExportExcel4UsersServiceSoapClient()
{
if (objvExportExcel4UsersServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vExportExcel4UsersServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vExportExcel4UsersServiceSoapClient(binding, address);
}
else
{
return objvExportExcel4UsersServiceSoapClient;
}
}

 public clsvExportExcel4UsersWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vExportExcel4Users(System.Windows.Forms.ListView lvvExportExcel4Users, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivExportExcel4Users; 
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvExportExcel4UsersObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvExportExcel4Users.Items.Clear();//清除原来所有Item
lvvExportExcel4Users.Columns.Clear();//清除原来所有列头信息
lvvExportExcel4Users.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("导出Excel用户字段流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("TabName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("是否缺省用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("导出文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("字段名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("字段中文名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("是否导出", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvExportExcel4Users.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvExportExcel4UsersEN objvExportExcel4UsersEN in arrvExportExcel4UsersObjLst)
{
lvivExportExcel4Users = new System.Windows.Forms.ListViewItem();
lvivExportExcel4Users.Tag = objvExportExcel4UsersEN.mId;
lvivExportExcel4Users.Text = objvExportExcel4UsersEN.mId.ToString();
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.id_ExportExcel4Users);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.ViewName);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.TabName);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.IsDefaultUser.ToString());
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.UserId);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.UserName);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.ExportFileName);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.FieldName);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.FieldCnName);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.IsExport.ToString());
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.OrderNum.ToString());
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.UpdDate);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.UpdUserId);
lvivExportExcel4Users.SubItems.Add(objvExportExcel4UsersEN.Memo);
lvvExportExcel4Users.Items.Add(lvivExportExcel4Users);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvExportExcel4UsersObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvExportExcel4UsersService.vExportExcel4Users_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcel4Users_GetDataSet", "clsvExportExcel4UsersWS:GetDataTableWs", objException.Message);
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
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvExportExcel4UsersService.vExportExcel4Users_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcel4Users_GetTopDataSet", "clsvExportExcel4UsersWS:GetDataTable_TopWs", objException.Message);
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
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvExportExcel4UsersService.vExportExcel4Users_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcel4Users_GetDataSetByRange", "clsvExportExcel4UsersWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvExportExcel4UsersWs(ref clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
bool bolResult = objvExportExcel4UsersService.vExportExcel4Users_GetvExportExcel4Users(ref objvExportExcel4UsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcel4UsersEN GetObjBymIdWs(long lngmId)
{
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
clsvExportExcel4UsersEN objvExportExcel4UsersEN = objvExportExcel4UsersService.vExportExcel4Users_GetObjBymId(lngmId);
return objvExportExcel4UsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
try
{
long lngmId = objvExportExcel4UsersService.vExportExcel4Users_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcel4Users_GetFirstID_S", "clsvExportExcel4UsersWS:GetFirstID_S", objException.Message);
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
public static clsvExportExcel4UsersEN GetFirstvExportExcel4Users_S(string strWhereCond)
{
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
try
{
clsvExportExcel4UsersEN objvExportExcel4UsersEN = objvExportExcel4UsersService.vExportExcel4Users_GetFirstObj_S(strWhereCond);
return objvExportExcel4UsersEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vExportExcel4Users_GetFirstObj_S", "clsvExportExcel4UsersWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by mId");
if (arrvExportExcel4UsersObjLst_Cache == null)
{
arrvExportExcel4UsersObjLst_Cache = clsvExportExcel4UsersWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcel4UsersEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvExportExcel4UsersObjLst_Cache.Count - 1;
int intMid = 0;
clsvExportExcel4UsersEN objvExportExcel4UsersEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvExportExcel4UsersEN = arrvExportExcel4UsersObjLst_Cache[intMid];
if (objvExportExcel4UsersEN.mId == lngmId)
{
intFindFailCount = 0;
return objvExportExcel4UsersEN;
}
else if (objvExportExcel4UsersEN.mId.CompareTo(lngmId) > 0)
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
arrvExportExcel4UsersObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vExportExcel4Users对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvExportExcel4UsersEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvExportExcel4UsersEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvExportExcel4UsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLst(string strWhereCond)
{
 List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
objvExportExcel4UsersEN.mId = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["mId"].ToString().Trim()); //流水号
objvExportExcel4UsersEN.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow["TabName"].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefaultUser"].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow["ExportFileName"].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow["FieldName"].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow["FieldCnName"].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsExport"].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
objvExportExcel4UsersEN.mId = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["mId"].ToString().Trim()); //流水号
objvExportExcel4UsersEN.id_ExportExcel4Users = objRow["id_ExportExcel4Users"].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow["TabName"].ToString().Trim(); //TabName
objvExportExcel4UsersEN.IsDefaultUser = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefaultUser"].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvExportExcel4UsersEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow["ExportFileName"].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow["FieldName"].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow["FieldCnName"].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsExport"].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvExportExcel4UsersEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvExportExcel4UsersEN);
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
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
bool bolIsExist = objvExportExcel4UsersService.vExportExcel4Users_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(long lngmId)
{
//检测记录是否存在
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
bool bolIsExist = objvExportExcel4UsersService.vExportExcel4Users_IsExist(lngmId);
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
vExportExcel4UsersServiceSoapClient objvExportExcel4UsersService = GetvExportExcel4UsersServiceSoapClient();
int intRecCount = objvExportExcel4UsersService.vExportExcel4Users_funGetRecCountByCond(strWhereCond);
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