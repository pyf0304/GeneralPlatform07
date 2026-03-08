
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRelaOfPotenceAndSymbolWS
 表名:QxRelaOfPotenceAndSymbol(00140020)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:57
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
using GeneralPlatform4WS.ServiceReferenceQxRelaOfPotenceAndSymbol;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 权限编程标志关系表(QxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxRelaOfPotenceAndSymbolWS
{
private static string mstrPageName = "QxRelaOfPotenceAndSymbolService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxRelaOfPotenceAndSymbolEN> arrQxRelaOfPotenceAndSymbolObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxRelaOfPotenceAndSymbolServiceSoapClient GetQxRelaOfPotenceAndSymbolServiceSoapClient()
{
if (objQxRelaOfPotenceAndSymbolServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxRelaOfPotenceAndSymbolServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxRelaOfPotenceAndSymbolServiceSoapClient(binding, address);
}
else
{
return objQxRelaOfPotenceAndSymbolServiceSoapClient;
}
}

 public clsQxRelaOfPotenceAndSymbolWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxRelaOfPotenceAndSymbol(System.Windows.Forms.ListView lvQxRelaOfPotenceAndSymbol, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxRelaOfPotenceAndSymbol; 
List<clsQxRelaOfPotenceAndSymbolEN> arrQxRelaOfPotenceAndSymbolObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxRelaOfPotenceAndSymbolObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxRelaOfPotenceAndSymbol.Items.Clear();//清除原来所有Item
lvQxRelaOfPotenceAndSymbol.Columns.Clear();//清除原来所有列头信息
lvQxRelaOfPotenceAndSymbol.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.Columns.Add("权限ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.Columns.Add("编程标志", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.Columns.Add("标志名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxRelaOfPotenceAndSymbol.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN in arrQxRelaOfPotenceAndSymbolObjLst)
{
lviQxRelaOfPotenceAndSymbol = new System.Windows.Forms.ListViewItem();
lviQxRelaOfPotenceAndSymbol.Tag = objQxRelaOfPotenceAndSymbolEN.RelaMid;
lviQxRelaOfPotenceAndSymbol.Text = objQxRelaOfPotenceAndSymbolEN.RelaMid.ToString();
lviQxRelaOfPotenceAndSymbol.SubItems.Add(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme);
lviQxRelaOfPotenceAndSymbol.SubItems.Add(objQxRelaOfPotenceAndSymbolEN.SymbolName);
lviQxRelaOfPotenceAndSymbol.SubItems.Add(objQxRelaOfPotenceAndSymbolEN.Memo);
lviQxRelaOfPotenceAndSymbol.SubItems.Add(objQxRelaOfPotenceAndSymbolEN.UpdDate);
lviQxRelaOfPotenceAndSymbol.SubItems.Add(objQxRelaOfPotenceAndSymbolEN.UpdUserId);
lvQxRelaOfPotenceAndSymbol.Items.Add(lviQxRelaOfPotenceAndSymbol);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxRelaOfPotenceAndSymbolObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.PotenceId) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.PotenceId) > 8)
{
 throw new Exception("字段[权限ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme) > 20)
{
 throw new Exception("字段[编程标志]的长度不能超过20!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.SymbolName) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.SymbolName) > 200)
{
 throw new Exception("字段[标志名称]的长度不能超过200!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.Memo) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.QxPrjId) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.UpdDate) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxRelaOfPotenceAndSymbolEN.UpdUserId) && GetStrLen(objQxRelaOfPotenceAndSymbolEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
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
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_GetDataSet", "clsQxRelaOfPotenceAndSymbolWS:GetDataTableWs", objException.Message);
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
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_GetTopDataSet", "clsQxRelaOfPotenceAndSymbolWS:GetDataTable_TopWs", objException.Message);
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
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_GetDataSetByRange", "clsQxRelaOfPotenceAndSymbolWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_GetDataSetV", "clsQxRelaOfPotenceAndSymbolWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxRelaOfPotenceAndSymbolVWs(string strWhereCond)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_GetDataSetV", "clsQxRelaOfPotenceAndSymbolWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxRelaOfPotenceAndSymbolWs(ref clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
bool bolResult = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetQxRelaOfPotenceAndSymbol(ref objQxRelaOfPotenceAndSymbolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRelaOfPotenceAndSymbolEN GetObjByRelaMidWs(long lngRelaMid)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetObjByRelaMid(lngRelaMid);
return objQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
long lngRelaMid = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetFirstID_S(strWhereCond);
return lngRelaMid;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_GetFirstID_S", "clsQxRelaOfPotenceAndSymbolWS:GetFirstID_S", objException.Message);
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
public static clsQxRelaOfPotenceAndSymbolEN GetFirstQxRelaOfPotenceAndSymbol_S(string strWhereCond)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_GetFirstObj_S(strWhereCond);
return objQxRelaOfPotenceAndSymbolEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_GetFirstObj_S", "clsQxRelaOfPotenceAndSymbolWS:GetFirstObj_S", objException.Message);
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
if (arrQxRelaOfPotenceAndSymbolObjLst_Cache == null)
{
arrQxRelaOfPotenceAndSymbolObjLst_Cache = clsQxRelaOfPotenceAndSymbolWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngRelaMid">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRelaOfPotenceAndSymbolEN GetObjByRelaMid_Cache(long lngRelaMid)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxRelaOfPotenceAndSymbolObjLst_Cache.Count - 1;
int intMid = 0;
clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxRelaOfPotenceAndSymbolEN = arrQxRelaOfPotenceAndSymbolObjLst_Cache[intMid];
if (objQxRelaOfPotenceAndSymbolEN.RelaMid == lngRelaMid)
{
intFindFailCount = 0;
return objQxRelaOfPotenceAndSymbolEN;
}
else if (objQxRelaOfPotenceAndSymbolEN.RelaMid.CompareTo(lngRelaMid) > 0)
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
arrQxRelaOfPotenceAndSymbolObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByRelaMid_Cache(lngRelaMid);
string strErrMsgForGetObjById = string.Format("在QxRelaOfPotenceAndSymbol对象缓存列表中,找不到记录[RelaMid = {0}][intFindFailCount = {1}](函数:{2})", lngRelaMid, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxRelaOfPotenceAndSymbolEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxRelaOfPotenceAndSymbolEN.RelaMid, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxRelaOfPotenceAndSymbolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRelaOfPotenceAndSymbolEN> GetObjLst(string strWhereCond)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
objQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
objQxRelaOfPotenceAndSymbolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
	arrObjLst.Add(objQxRelaOfPotenceAndSymbolEN);
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
public static List<clsQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN = new clsQxRelaOfPotenceAndSymbolEN();
objQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow["RelaMid"].ToString().Trim()); //流水号
objQxRelaOfPotenceAndSymbolEN.PotenceId = objRow["PotenceId"].ToString().Trim(); //权限ID
objQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow["SymbolForProgramme"].ToString().Trim(); //编程标志
objQxRelaOfPotenceAndSymbolEN.SymbolName = objRow["SymbolName"].ToString().Trim(); //标志名称
objQxRelaOfPotenceAndSymbolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxRelaOfPotenceAndSymbolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
	arrObjLst.Add(objQxRelaOfPotenceAndSymbolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(long lngRelaMid)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
int intResult = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_DelRecord(lngRelaMid);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_DelRecord", "clsQxRelaOfPotenceAndSymbolWS:DelRecordWs", objException.Message);
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
public static int DelQxRelaOfPotenceAndSymbolsWs(List<string> arrRelaMid)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrRelaMid);
int intResult = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_DelQxRelaOfPotenceAndSymbols(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_DelQxRelaOfPotenceAndSymbols", "clsQxRelaOfPotenceAndSymbolWS:DelQxRelaOfPotenceAndSymbolsWs", objException.Message);
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
public static int DelQxRelaOfPotenceAndSymbolsByCondWs(string strWhereCond)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
int intRecNum = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_DelQxRelaOfPotenceAndSymbolsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_DelQxRelaOfPotenceAndSymbolsByCond", "clsQxRelaOfPotenceAndSymbolWS:DelQxRelaOfPotenceAndSymbolsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
bool bolResult = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_AddNewRecordBySql2(objQxRelaOfPotenceAndSymbolEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_AddNewRecordBySql2", "clsQxRelaOfPotenceAndSymbolWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
string strKey = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_AddNewRecordBySql2WithReturnKey(objQxRelaOfPotenceAndSymbolEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_AddNewRecordBySql2WithReturnKey", "clsQxRelaOfPotenceAndSymbolWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
bool bolResult = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_UpdateBySql2(objQxRelaOfPotenceAndSymbolEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_UpdateBySql2", "clsQxRelaOfPotenceAndSymbolWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxRelaOfPotenceAndSymbolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxRelaOfPotenceAndSymbolEN objQxRelaOfPotenceAndSymbolEN, string strWhereCond)
{
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
try
{
bool bolResult = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_UpdateBySqlWithCondition(objQxRelaOfPotenceAndSymbolEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxRelaOfPotenceAndSymbol_UpdateBySqlWithCondition", "clsQxRelaOfPotenceAndSymbolWS:UpdateBySqlWithCondition", objException.Message);
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
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
bool bolIsExist = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_IsExistRecord(strWhereCond);
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
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
bool bolIsExist = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_IsExist(lngRelaMid);
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
QxRelaOfPotenceAndSymbolServiceSoapClient objQxRelaOfPotenceAndSymbolService = GetQxRelaOfPotenceAndSymbolServiceSoapClient();
int intRecCount = objQxRelaOfPotenceAndSymbolService.QxRelaOfPotenceAndSymbol_funGetRecCountByCond(strWhereCond);
return intRecCount;
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