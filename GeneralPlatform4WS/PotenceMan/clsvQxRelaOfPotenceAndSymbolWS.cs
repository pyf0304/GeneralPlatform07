
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRelaOfPotenceAndSymbolWS
 表名:vQxRelaOfPotenceAndSymbol(00140049)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:07
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:PotenceMan
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
using GeneralPlatform4WS.ServiceReferencevQxRelaOfPotenceAndSymbol;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v权限编程标志关系表(vQxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRelaOfPotenceAndSymbolWS
{
private static string mstrPageName = "vQxRelaOfPotenceAndSymbolService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxRelaOfPotenceAndSymbolServiceSoapClient GetvQxRelaOfPotenceAndSymbolServiceSoapClient()
{
if (objvQxRelaOfPotenceAndSymbolServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxRelaOfPotenceAndSymbolServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxRelaOfPotenceAndSymbolServiceSoapClient(binding, address);
}
else
{
return objvQxRelaOfPotenceAndSymbolServiceSoapClient;
}
}

 public clsvQxRelaOfPotenceAndSymbolWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxRelaOfPotenceAndSymbol(System.Windows.Forms.ListView lvvQxRelaOfPotenceAndSymbol, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxRelaOfPotenceAndSymbol; 
List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxRelaOfPotenceAndSymbolObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxRelaOfPotenceAndSymbol.Items.Clear();//清除原来所有Item
lvvQxRelaOfPotenceAndSymbol.Columns.Clear();//清除原来所有列头信息
lvvQxRelaOfPotenceAndSymbol.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("权限类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("权限名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("编程标志", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("标志名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("权限类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.Columns.Add("标志数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxRelaOfPotenceAndSymbol.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN in arrvQxRelaOfPotenceAndSymbolObjLst)
{
lvivQxRelaOfPotenceAndSymbol = new System.Windows.Forms.ListViewItem();
lvivQxRelaOfPotenceAndSymbol.Tag = objvQxRelaOfPotenceAndSymbolEN.RelaMid;
lvivQxRelaOfPotenceAndSymbol.Text = objvQxRelaOfPotenceAndSymbolEN.RelaMid.ToString();
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.QxPrjId);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.PotenceId);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.PotenceName);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.PrjName);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.SymbolName);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.Memo);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.UpdDate);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.UpdUserId);
lvivQxRelaOfPotenceAndSymbol.SubItems.Add(objvQxRelaOfPotenceAndSymbolEN.SymbolNum.ToString());
lvvQxRelaOfPotenceAndSymbol.Items.Add(lvivQxRelaOfPotenceAndSymbol);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxRelaOfPotenceAndSymbolObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRelaOfPotenceAndSymbol_GetDataSet", "clsvQxRelaOfPotenceAndSymbolWS:GetDataTableWs", objException.Message);
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
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRelaOfPotenceAndSymbol_GetTopDataSet", "clsvQxRelaOfPotenceAndSymbolWS:GetDataTable_TopWs", objException.Message);
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
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRelaOfPotenceAndSymbol_GetDataSetByRange", "clsvQxRelaOfPotenceAndSymbolWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRelaOfPotenceAndSymbolWs(ref clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
bool bolResult = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_GetvQxRelaOfPotenceAndSymbol(ref objvQxRelaOfPotenceAndSymbolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByRelaMidWs(long lngRelaMid)
{
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_GetObjByRelaMid(lngRelaMid);
return objvQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
long lngRelaMid = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_GetFirstID_S(strWhereCond);
return lngRelaMid;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRelaOfPotenceAndSymbol_GetFirstID_S", "clsvQxRelaOfPotenceAndSymbolWS:GetFirstID_S", objException.Message);
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
public static clsvQxRelaOfPotenceAndSymbolEN GetFirstvQxRelaOfPotenceAndSymbol_S(string strWhereCond)
{
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_GetFirstObj_S(strWhereCond);
return objvQxRelaOfPotenceAndSymbolEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxRelaOfPotenceAndSymbol_GetFirstObj_S", "clsvQxRelaOfPotenceAndSymbolWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by RelaMid");
if (arrvQxRelaOfPotenceAndSymbolObjLst_Cache == null)
{
arrvQxRelaOfPotenceAndSymbolObjLst_Cache = clsvQxRelaOfPotenceAndSymbolWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngRelaMid">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByRelaMid_Cache(long lngRelaMid)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxRelaOfPotenceAndSymbolObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxRelaOfPotenceAndSymbolEN = arrvQxRelaOfPotenceAndSymbolObjLst_Cache[intMid];
if (objvQxRelaOfPotenceAndSymbolEN.RelaMid == lngRelaMid)
{
intFindFailCount = 0;
return objvQxRelaOfPotenceAndSymbolEN;
}
else if (objvQxRelaOfPotenceAndSymbolEN.RelaMid.CompareTo(lngRelaMid) > 0)
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
arrvQxRelaOfPotenceAndSymbolObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByRelaMid_Cache(lngRelaMid);
string strErrMsgForGetObjById = string.Format("在vQxRelaOfPotenceAndSymbol对象缓存列表中,找不到记录[RelaMid = {0}][intFindFailCount = {1}](函数:{2})", lngRelaMid, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxRelaOfPotenceAndSymbolEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxRelaOfPotenceAndSymbolEN.RelaMid, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxRelaOfPotenceAndSymbolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["SymbolNum"].ToString().Trim()); //标志数
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow["PotenceTypeName"].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow["PotenceName"].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow["PotenceTypeId"].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["SymbolNum"].ToString().Trim()); //标志数
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
bool bolIsExist = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(long lngRelaMid)
{
//检测记录是否存在
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
bool bolIsExist = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_IsExist(lngRelaMid);
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
vQxRelaOfPotenceAndSymbolServiceSoapClient objvQxRelaOfPotenceAndSymbolService = GetvQxRelaOfPotenceAndSymbolServiceSoapClient();
int intRecCount = objvQxRelaOfPotenceAndSymbolService.vQxRelaOfPotenceAndSymbol_funGetRecCountByCond(strWhereCond);
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