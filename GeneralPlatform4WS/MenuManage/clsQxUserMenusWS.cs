
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserMenusWS
 表名:QxUserMenus(00140012)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:54
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:菜单管理
 模块英文名:MenuManage
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
using GeneralPlatform4WS.ServiceReferenceQxUserMenus;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户菜单(QxUserMenus)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserMenusWS
{
private static string mstrPageName = "QxUserMenusService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserMenusEN> arrQxUserMenusObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserMenusServiceSoapClient objQxUserMenusServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserMenusServiceSoapClient GetQxUserMenusServiceSoapClient()
{
if (objQxUserMenusServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserMenusServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserMenusServiceSoapClient(binding, address);
}
else
{
return objQxUserMenusServiceSoapClient;
}
}

 public clsQxUserMenusWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUserMenus(System.Windows.Forms.ListView lvQxUserMenus, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserMenus; 
List<clsQxUserMenusEN> arrQxUserMenusObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserMenusObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserMenus.Items.Clear();//清除原来所有Item
lvQxUserMenus.Columns.Clear();//清除原来所有列头信息
lvQxUserMenus.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserMenus.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserMenus.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserMenus.Columns.Add("是否使用角色菜单", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserMenus.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserMenus.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserMenusEN objQxUserMenusEN in arrQxUserMenusObjLst)
{
lviQxUserMenus = new System.Windows.Forms.ListViewItem();
lviQxUserMenus.Tag = objQxUserMenusEN.mId;
lviQxUserMenus.Text = objQxUserMenusEN.mId.ToString();
lviQxUserMenus.SubItems.Add(objQxUserMenusEN.UserId);
lviQxUserMenus.SubItems.Add(objQxUserMenusEN.IsUseRoleMenu.ToString());
lviQxUserMenus.SubItems.Add(objQxUserMenusEN.Memo);
lvQxUserMenus.Items.Add(lviQxUserMenus);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserMenusObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserMenusEN objQxUserMenusEN)
{
if (!Object.Equals(null, objQxUserMenusEN.UserId) && GetStrLen(objQxUserMenusEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserMenusEN.QxPrjId) && GetStrLen(objQxUserMenusEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserMenusEN.Memo) && GetStrLen(objQxUserMenusEN.Memo) > 1000)
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
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserMenusService.QxUserMenus_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_GetDataSet", "clsQxUserMenusWS:GetDataTableWs", objException.Message);
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
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserMenusService.QxUserMenus_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_GetTopDataSet", "clsQxUserMenusWS:GetDataTable_TopWs", objException.Message);
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
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserMenusService.QxUserMenus_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_GetDataSetByRange", "clsQxUserMenusWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserMenusService.QxUserMenus_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_GetDataSetV", "clsQxUserMenusWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserMenusVWs(string strWhereCond)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserMenusService.QxUserMenus_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_GetDataSetV", "clsQxUserMenusWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserMenusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserMenusWs(ref clsQxUserMenusEN objQxUserMenusEN)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
bool bolResult = objQxUserMenusService.QxUserMenus_GetQxUserMenus(ref objQxUserMenusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserMenusEN GetObjBymIdWs(long lngmId)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
clsQxUserMenusEN objQxUserMenusEN = objQxUserMenusService.QxUserMenus_GetObjBymId(lngmId);
return objQxUserMenusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
long lngmId = objQxUserMenusService.QxUserMenus_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_GetFirstID_S", "clsQxUserMenusWS:GetFirstID_S", objException.Message);
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
public static clsQxUserMenusEN GetFirstQxUserMenus_S(string strWhereCond)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
clsQxUserMenusEN objQxUserMenusEN = objQxUserMenusService.QxUserMenus_GetFirstObj_S(strWhereCond);
return objQxUserMenusEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_GetFirstObj_S", "clsQxUserMenusWS:GetFirstObj_S", objException.Message);
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
if (arrQxUserMenusObjLst_Cache == null)
{
arrQxUserMenusObjLst_Cache = clsQxUserMenusWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserMenusEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserMenusObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserMenusEN objQxUserMenusEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserMenusEN = arrQxUserMenusObjLst_Cache[intMid];
if (objQxUserMenusEN.mId == lngmId)
{
intFindFailCount = 0;
return objQxUserMenusEN;
}
else if (objQxUserMenusEN.mId.CompareTo(lngmId) > 0)
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
arrQxUserMenusObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在QxUserMenus对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserMenusEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserMenusEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserMenusBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserMenusEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserMenusEN> arrObjLst = new List<clsQxUserMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenusEN objQxUserMenusEN = new clsQxUserMenusEN();
objQxUserMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserMenusEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserMenusEN.IsUseRoleMenu = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsUseRoleMenu"].ToString().Trim()); //是否使用角色菜单
objQxUserMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserMenusEN);
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
public static List<clsQxUserMenusEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserMenusEN> arrObjLst = new List<clsQxUserMenusEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserMenusEN objQxUserMenusEN = new clsQxUserMenusEN();
objQxUserMenusEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserMenusEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserMenusEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserMenusEN.IsUseRoleMenu = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsUseRoleMenu"].ToString().Trim()); //是否使用角色菜单
objQxUserMenusEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserMenusEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(long lngmId)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
int intResult = objQxUserMenusService.QxUserMenus_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_DelRecord", "clsQxUserMenusWS:DelRecordWs", objException.Message);
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
public static int DelQxUserMenussWs(List<string> arrmId)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objQxUserMenusService.QxUserMenus_DelQxUserMenuss(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_DelQxUserMenuss", "clsQxUserMenusWS:DelQxUserMenussWs", objException.Message);
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
public static int DelQxUserMenussByCondWs(string strWhereCond)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
int intRecNum = objQxUserMenusService.QxUserMenus_DelQxUserMenussByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_DelQxUserMenussByCond", "clsQxUserMenusWS:DelQxUserMenussByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserMenusEN objQxUserMenusEN)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
bool bolResult = objQxUserMenusService.QxUserMenus_AddNewRecordBySql2(objQxUserMenusEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_AddNewRecordBySql2", "clsQxUserMenusWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserMenusEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserMenusEN objQxUserMenusEN)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
string strKey = objQxUserMenusService.QxUserMenus_AddNewRecordBySql2WithReturnKey(objQxUserMenusEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_AddNewRecordBySql2WithReturnKey", "clsQxUserMenusWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserMenusEN objQxUserMenusEN)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
bool bolResult = objQxUserMenusService.QxUserMenus_UpdateBySql2(objQxUserMenusEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_UpdateBySql2", "clsQxUserMenusWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserMenusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserMenusEN objQxUserMenusEN, string strWhereCond)
{
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
try
{
bool bolResult = objQxUserMenusService.QxUserMenus_UpdateBySqlWithCondition(objQxUserMenusEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserMenus_UpdateBySqlWithCondition", "clsQxUserMenusWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
bool bolIsExist = objQxUserMenusService.QxUserMenus_IsExistRecord(strWhereCond);
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
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
bool bolIsExist = objQxUserMenusService.QxUserMenus_IsExist(lngmId);
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
QxUserMenusServiceSoapClient objQxUserMenusService = GetQxUserMenusServiceSoapClient();
int intRecCount = objQxUserMenusService.QxUserMenus_funGetRecCountByCond(strWhereCond);
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