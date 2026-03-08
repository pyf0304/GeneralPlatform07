
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserCodePathWS
 表名:QxUserCodePath(00140056)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:10
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
using GeneralPlatform4WS.ServiceReferenceQxUserCodePath;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户生成路径(QxUserCodePath)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserCodePathWS
{
private static string mstrPageName = "QxUserCodePathService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserCodePathEN> arrQxUserCodePathObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserCodePathServiceSoapClient objQxUserCodePathServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserCodePathServiceSoapClient GetQxUserCodePathServiceSoapClient()
{
if (objQxUserCodePathServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserCodePathServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserCodePathServiceSoapClient(binding, address);
}
else
{
return objQxUserCodePathServiceSoapClient;
}
}

 public clsQxUserCodePathWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUserCodePath(System.Windows.Forms.ListView lvQxUserCodePath, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserCodePath; 
List<clsQxUserCodePathEN> arrQxUserCodePathObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserCodePathObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserCodePath.Items.Clear();//清除原来所有Item
lvQxUserCodePath.Columns.Clear();//清除原来所有列头信息
lvQxUserCodePath.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("代码类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("代码路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("备份代码路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("是否模板", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.Columns.Add("IsGeneReport", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserCodePath.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserCodePathEN objQxUserCodePathEN in arrQxUserCodePathObjLst)
{
lviQxUserCodePath = new System.Windows.Forms.ListViewItem();
lviQxUserCodePath.Tag = objQxUserCodePathEN.mId;
lviQxUserCodePath.Text = objQxUserCodePathEN.mId.ToString();
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.QxPrjId);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.UserId);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.QxCodeTypeId);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.CodePath);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.CodePathBackup);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.IsTemplate.ToString());
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.UpdDate);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.UpdUserId);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.Memo);
lviQxUserCodePath.SubItems.Add(objQxUserCodePathEN.IsGeneReport.ToString());
lvQxUserCodePath.Items.Add(lviQxUserCodePath);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserCodePathObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserCodePathEN objQxUserCodePathEN)
{
if (!Object.Equals(null, objQxUserCodePathEN.QxPrjId) && GetStrLen(objQxUserCodePathEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserCodePathEN.UserId) && GetStrLen(objQxUserCodePathEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserCodePathEN.QxCodeTypeId) && GetStrLen(objQxUserCodePathEN.QxCodeTypeId) > 4)
{
 throw new Exception("字段[代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserCodePathEN.CodePath) && GetStrLen(objQxUserCodePathEN.CodePath) > 200)
{
 throw new Exception("字段[代码路径]的长度不能超过200!");
}
if (!Object.Equals(null, objQxUserCodePathEN.CodePathBackup) && GetStrLen(objQxUserCodePathEN.CodePathBackup) > 200)
{
 throw new Exception("字段[备份代码路径]的长度不能超过200!");
}
if (!Object.Equals(null, objQxUserCodePathEN.UpdDate) && GetStrLen(objQxUserCodePathEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUserCodePathEN.UpdUserId) && GetStrLen(objQxUserCodePathEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserCodePathEN.Memo) && GetStrLen(objQxUserCodePathEN.Memo) > 1000)
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
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserCodePathService.QxUserCodePath_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_GetDataSet", "clsQxUserCodePathWS:GetDataTableWs", objException.Message);
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
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserCodePathService.QxUserCodePath_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_GetTopDataSet", "clsQxUserCodePathWS:GetDataTable_TopWs", objException.Message);
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
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserCodePathService.QxUserCodePath_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_GetDataSetByRange", "clsQxUserCodePathWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserCodePathService.QxUserCodePath_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_GetDataSetV", "clsQxUserCodePathWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserCodePathVWs(string strWhereCond)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserCodePathService.QxUserCodePath_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_GetDataSetV", "clsQxUserCodePathWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserCodePathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserCodePathWs(ref clsQxUserCodePathEN objQxUserCodePathEN)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
bool bolResult = objQxUserCodePathService.QxUserCodePath_GetQxUserCodePath(ref objQxUserCodePathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserCodePathEN GetObjBymIdWs(long lngmId)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
clsQxUserCodePathEN objQxUserCodePathEN = objQxUserCodePathService.QxUserCodePath_GetObjBymId(lngmId);
return objQxUserCodePathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
long lngmId = objQxUserCodePathService.QxUserCodePath_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_GetFirstID_S", "clsQxUserCodePathWS:GetFirstID_S", objException.Message);
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
public static clsQxUserCodePathEN GetFirstQxUserCodePath_S(string strWhereCond)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
clsQxUserCodePathEN objQxUserCodePathEN = objQxUserCodePathService.QxUserCodePath_GetFirstObj_S(strWhereCond);
return objQxUserCodePathEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_GetFirstObj_S", "clsQxUserCodePathWS:GetFirstObj_S", objException.Message);
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
if (arrQxUserCodePathObjLst_Cache == null)
{
arrQxUserCodePathObjLst_Cache = clsQxUserCodePathWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserCodePathEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserCodePathObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserCodePathEN objQxUserCodePathEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserCodePathEN = arrQxUserCodePathObjLst_Cache[intMid];
if (objQxUserCodePathEN.mId == lngmId)
{
intFindFailCount = 0;
return objQxUserCodePathEN;
}
else if (objQxUserCodePathEN.mId.CompareTo(lngmId) > 0)
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
arrQxUserCodePathObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在QxUserCodePath对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserCodePathEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserCodePathEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserCodePathBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserCodePathEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserCodePathEN> arrObjLst = new List<clsQxUserCodePathEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserCodePathEN objQxUserCodePathEN = new clsQxUserCodePathEN();
objQxUserCodePathEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserCodePathEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserCodePathEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserCodePathEN.QxCodeTypeId = objRow["QxCodeTypeId"].ToString().Trim(); //代码类型Id
objQxUserCodePathEN.CodePath = objRow["CodePath"].ToString().Trim(); //代码路径
objQxUserCodePathEN.CodePathBackup = objRow["CodePathBackup"].ToString().Trim(); //备份代码路径
objQxUserCodePathEN.IsTemplate = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsTemplate"].ToString().Trim()); //是否模板
objQxUserCodePathEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserCodePathEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserCodePathEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objQxUserCodePathEN.IsGeneReport = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsGeneReport"].ToString().Trim()); //IsGeneReport
	arrObjLst.Add(objQxUserCodePathEN);
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
public static List<clsQxUserCodePathEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserCodePathEN> arrObjLst = new List<clsQxUserCodePathEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserCodePathEN objQxUserCodePathEN = new clsQxUserCodePathEN();
objQxUserCodePathEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserCodePathEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserCodePathEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserCodePathEN.QxCodeTypeId = objRow["QxCodeTypeId"].ToString().Trim(); //代码类型Id
objQxUserCodePathEN.CodePath = objRow["CodePath"].ToString().Trim(); //代码路径
objQxUserCodePathEN.CodePathBackup = objRow["CodePathBackup"].ToString().Trim(); //备份代码路径
objQxUserCodePathEN.IsTemplate = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsTemplate"].ToString().Trim()); //是否模板
objQxUserCodePathEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserCodePathEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserCodePathEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objQxUserCodePathEN.IsGeneReport = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsGeneReport"].ToString().Trim()); //IsGeneReport
	arrObjLst.Add(objQxUserCodePathEN);
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
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
int intResult = objQxUserCodePathService.QxUserCodePath_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_DelRecord", "clsQxUserCodePathWS:DelRecordWs", objException.Message);
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
public static int DelQxUserCodePathsWs(List<string> arrmId)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objQxUserCodePathService.QxUserCodePath_DelQxUserCodePaths(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_DelQxUserCodePaths", "clsQxUserCodePathWS:DelQxUserCodePathsWs", objException.Message);
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
public static int DelQxUserCodePathsByCondWs(string strWhereCond)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
int intRecNum = objQxUserCodePathService.QxUserCodePath_DelQxUserCodePathsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_DelQxUserCodePathsByCond", "clsQxUserCodePathWS:DelQxUserCodePathsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserCodePathEN objQxUserCodePathEN)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
bool bolResult = objQxUserCodePathService.QxUserCodePath_AddNewRecordBySql2(objQxUserCodePathEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_AddNewRecordBySql2", "clsQxUserCodePathWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserCodePathEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserCodePathEN objQxUserCodePathEN)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
string strKey = objQxUserCodePathService.QxUserCodePath_AddNewRecordBySql2WithReturnKey(objQxUserCodePathEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_AddNewRecordBySql2WithReturnKey", "clsQxUserCodePathWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserCodePathEN objQxUserCodePathEN)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
bool bolResult = objQxUserCodePathService.QxUserCodePath_UpdateBySql2(objQxUserCodePathEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_UpdateBySql2", "clsQxUserCodePathWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserCodePathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserCodePathEN objQxUserCodePathEN, string strWhereCond)
{
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
bool bolResult = objQxUserCodePathService.QxUserCodePath_UpdateBySqlWithCondition(objQxUserCodePathEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserCodePath_UpdateBySqlWithCondition", "clsQxUserCodePathWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
bool bolIsExist = objQxUserCodePathService.QxUserCodePath_IsExistRecord(strWhereCond);
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
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
bool bolIsExist = objQxUserCodePathService.QxUserCodePath_IsExist(lngmId);
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
QxUserCodePathServiceSoapClient objQxUserCodePathService = GetQxUserCodePathServiceSoapClient();
int intRecCount = objQxUserCodePathService.QxUserCodePath_funGetRecCountByCond(strWhereCond);
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