
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjUserRelation4SynchWS
 表名:QxPrjUserRelation4Synch(00140093)
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
using GeneralPlatform4WS.ServiceReferenceQxPrjUserRelation4Synch;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 工程用户关系4同步(QxPrjUserRelation4Synch)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjUserRelation4SynchWS
{
private static string mstrPageName = "QxPrjUserRelation4SynchService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPrjUserRelation4SynchEN> arrQxPrjUserRelation4SynchObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPrjUserRelation4SynchServiceSoapClient GetQxPrjUserRelation4SynchServiceSoapClient()
{
if (objQxPrjUserRelation4SynchServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPrjUserRelation4SynchServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPrjUserRelation4SynchServiceSoapClient(binding, address);
}
else
{
return objQxPrjUserRelation4SynchServiceSoapClient;
}
}

 public clsQxPrjUserRelation4SynchWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxPrjUserRelation4Synch(System.Windows.Forms.ListView lvQxPrjUserRelation4Synch, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPrjUserRelation4Synch; 
List<clsQxPrjUserRelation4SynchEN> arrQxPrjUserRelation4SynchObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPrjUserRelation4SynchObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPrjUserRelation4Synch.Items.Clear();//清除原来所有Item
lvQxPrjUserRelation4Synch.Columns.Clear();//清除原来所有列头信息
lvQxPrjUserRelation4Synch.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjUserRelation4Synch.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjUserRelation4Synch.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjUserRelation4Synch.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjUserRelation4Synch.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjUserRelation4Synch.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjUserRelation4Synch.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjUserRelation4Synch.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN in arrQxPrjUserRelation4SynchObjLst)
{
lviQxPrjUserRelation4Synch = new System.Windows.Forms.ListViewItem();
lviQxPrjUserRelation4Synch.Tag = objQxPrjUserRelation4SynchEN.mId;
lviQxPrjUserRelation4Synch.Text = objQxPrjUserRelation4SynchEN.mId.ToString();
lviQxPrjUserRelation4Synch.SubItems.Add(objQxPrjUserRelation4SynchEN.IpAddress);
lviQxPrjUserRelation4Synch.SubItems.Add(objQxPrjUserRelation4SynchEN.UserId);
lviQxPrjUserRelation4Synch.SubItems.Add(objQxPrjUserRelation4SynchEN.UpdDate);
lviQxPrjUserRelation4Synch.SubItems.Add(objQxPrjUserRelation4SynchEN.UpdUserId);
lviQxPrjUserRelation4Synch.SubItems.Add(objQxPrjUserRelation4SynchEN.Memo);
lvQxPrjUserRelation4Synch.Items.Add(lviQxPrjUserRelation4Synch);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPrjUserRelation4SynchObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN)
{
if (!Object.Equals(null, objQxPrjUserRelation4SynchEN.IpAddress) && GetStrLen(objQxPrjUserRelation4SynchEN.IpAddress) > 23)
{
 throw new Exception("字段[IP地址]的长度不能超过23!");
}
if (!Object.Equals(null, objQxPrjUserRelation4SynchEN.QxPrjId) && GetStrLen(objQxPrjUserRelation4SynchEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjUserRelation4SynchEN.UserId) && GetStrLen(objQxPrjUserRelation4SynchEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjUserRelation4SynchEN.UpdDate) && GetStrLen(objQxPrjUserRelation4SynchEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxPrjUserRelation4SynchEN.UpdUserId) && GetStrLen(objQxPrjUserRelation4SynchEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjUserRelation4SynchEN.Memo) && GetStrLen(objQxPrjUserRelation4SynchEN.Memo) > 1000)
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
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_GetDataSet", "clsQxPrjUserRelation4SynchWS:GetDataTableWs", objException.Message);
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
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_GetTopDataSet", "clsQxPrjUserRelation4SynchWS:GetDataTable_TopWs", objException.Message);
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
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_GetDataSetByRange", "clsQxPrjUserRelation4SynchWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_GetDataSetV", "clsQxPrjUserRelation4SynchWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPrjUserRelation4SynchVWs(string strWhereCond)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_GetDataSetV", "clsQxPrjUserRelation4SynchWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjUserRelation4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjUserRelation4SynchWs(ref clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
bool bolResult = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetQxPrjUserRelation4Synch(ref objQxPrjUserRelation4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjUserRelation4SynchEN GetObjBymIdWs(long lngmId)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetObjBymId(lngmId);
return objQxPrjUserRelation4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
long lngmId = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_GetFirstID_S", "clsQxPrjUserRelation4SynchWS:GetFirstID_S", objException.Message);
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
public static clsQxPrjUserRelation4SynchEN GetFirstQxPrjUserRelation4Synch_S(string strWhereCond)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_GetFirstObj_S(strWhereCond);
return objQxPrjUserRelation4SynchEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_GetFirstObj_S", "clsQxPrjUserRelation4SynchWS:GetFirstObj_S", objException.Message);
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
if (arrQxPrjUserRelation4SynchObjLst_Cache == null)
{
arrQxPrjUserRelation4SynchObjLst_Cache = clsQxPrjUserRelation4SynchWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjUserRelation4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjUserRelation4SynchObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjUserRelation4SynchEN = arrQxPrjUserRelation4SynchObjLst_Cache[intMid];
if (objQxPrjUserRelation4SynchEN.mId == lngmId)
{
intFindFailCount = 0;
return objQxPrjUserRelation4SynchEN;
}
else if (objQxPrjUserRelation4SynchEN.mId.CompareTo(lngmId) > 0)
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
arrQxPrjUserRelation4SynchObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在QxPrjUserRelation4Synch对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjUserRelation4SynchEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjUserRelation4SynchEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjUserRelation4SynchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjUserRelation4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjUserRelation4SynchEN> arrObjLst = new List<clsQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN = new clsQxPrjUserRelation4SynchEN();
objQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxPrjUserRelation4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxPrjUserRelation4SynchEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjUserRelation4SynchEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxPrjUserRelation4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjUserRelation4SynchEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjUserRelation4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjUserRelation4SynchEN);
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
public static List<clsQxPrjUserRelation4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPrjUserRelation4SynchEN> arrObjLst = new List<clsQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN = new clsQxPrjUserRelation4SynchEN();
objQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxPrjUserRelation4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxPrjUserRelation4SynchEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjUserRelation4SynchEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxPrjUserRelation4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjUserRelation4SynchEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjUserRelation4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjUserRelation4SynchEN);
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
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
int intResult = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_DelRecord", "clsQxPrjUserRelation4SynchWS:DelRecordWs", objException.Message);
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
public static int DelQxPrjUserRelation4SynchsWs(List<string> arrmId)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_DelQxPrjUserRelation4Synchs(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_DelQxPrjUserRelation4Synchs", "clsQxPrjUserRelation4SynchWS:DelQxPrjUserRelation4SynchsWs", objException.Message);
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
public static int DelQxPrjUserRelation4SynchsByCondWs(string strWhereCond)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
int intRecNum = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_DelQxPrjUserRelation4SynchsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_DelQxPrjUserRelation4SynchsByCond", "clsQxPrjUserRelation4SynchWS:DelQxPrjUserRelation4SynchsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
bool bolResult = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_AddNewRecordBySql2(objQxPrjUserRelation4SynchEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_AddNewRecordBySql2", "clsQxPrjUserRelation4SynchWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxPrjUserRelation4SynchEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
string strKey = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_AddNewRecordBySql2WithReturnKey(objQxPrjUserRelation4SynchEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_AddNewRecordBySql2WithReturnKey", "clsQxPrjUserRelation4SynchWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
bool bolResult = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_UpdateBySql2(objQxPrjUserRelation4SynchEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_UpdateBySql2", "clsQxPrjUserRelation4SynchWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPrjUserRelation4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN, string strWhereCond)
{
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
try
{
bool bolResult = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_UpdateBySqlWithCondition(objQxPrjUserRelation4SynchEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjUserRelation4Synch_UpdateBySqlWithCondition", "clsQxPrjUserRelation4SynchWS:UpdateBySqlWithCondition", objException.Message);
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
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
bool bolIsExist = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_IsExistRecord(strWhereCond);
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
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
bool bolIsExist = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_IsExist(lngmId);
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
QxPrjUserRelation4SynchServiceSoapClient objQxPrjUserRelation4SynchService = GetQxPrjUserRelation4SynchServiceSoapClient();
int intRecCount = objQxPrjUserRelation4SynchService.QxPrjUserRelation4Synch_funGetRecCountByCond(strWhereCond);
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