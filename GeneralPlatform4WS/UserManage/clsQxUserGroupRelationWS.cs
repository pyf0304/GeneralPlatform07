
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserGroupRelationWS
 表名:QxUserGroupRelation(00140009)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:53
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
using GeneralPlatform4WS.ServiceReferenceQxUserGroupRelation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户/组关系(QxUserGroupRelation)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserGroupRelationWS
{
private static string mstrPageName = "QxUserGroupRelationService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserGroupRelationEN> arrQxUserGroupRelationObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserGroupRelationServiceSoapClient objQxUserGroupRelationServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserGroupRelationServiceSoapClient GetQxUserGroupRelationServiceSoapClient()
{
if (objQxUserGroupRelationServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserGroupRelationServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserGroupRelationServiceSoapClient(binding, address);
}
else
{
return objQxUserGroupRelationServiceSoapClient;
}
}

 public clsQxUserGroupRelationWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUserGroupRelation(System.Windows.Forms.ListView lvQxUserGroupRelation, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserGroupRelation; 
List<clsQxUserGroupRelationEN> arrQxUserGroupRelationObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserGroupRelationObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserGroupRelation.Items.Clear();//清除原来所有Item
lvQxUserGroupRelation.Columns.Clear();//清除原来所有列头信息
lvQxUserGroupRelation.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.Columns.Add("组Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.Columns.Add("ManageId", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.Columns.Add("ManageTypeId", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.Columns.Add("是否默认", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserGroupRelation.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserGroupRelationEN objQxUserGroupRelationEN in arrQxUserGroupRelationObjLst)
{
lviQxUserGroupRelation = new System.Windows.Forms.ListViewItem();
lviQxUserGroupRelation.Tag = objQxUserGroupRelationEN.mId;
lviQxUserGroupRelation.Text = objQxUserGroupRelationEN.mId.ToString();
lviQxUserGroupRelation.SubItems.Add(objQxUserGroupRelationEN.UserId);
lviQxUserGroupRelation.SubItems.Add(objQxUserGroupRelationEN.Memo);
lviQxUserGroupRelation.SubItems.Add(objQxUserGroupRelationEN.ManageId);
lviQxUserGroupRelation.SubItems.Add(objQxUserGroupRelationEN.ManageTypeId);
lviQxUserGroupRelation.SubItems.Add(objQxUserGroupRelationEN.IsDefault.ToString());
lvQxUserGroupRelation.Items.Add(lviQxUserGroupRelation);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserGroupRelationObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
if (!Object.Equals(null, objQxUserGroupRelationEN.UserId) && GetStrLen(objQxUserGroupRelationEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserGroupRelationEN.GroupId) && GetStrLen(objQxUserGroupRelationEN.GroupId) > 8)
{
 throw new Exception("字段[组Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserGroupRelationEN.Memo) && GetStrLen(objQxUserGroupRelationEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxUserGroupRelationEN.QxPrjId) && GetStrLen(objQxUserGroupRelationEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserGroupRelationEN.ManageId) && GetStrLen(objQxUserGroupRelationEN.ManageId) > 18)
{
 throw new Exception("字段[ManageId]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserGroupRelationEN.ManageTypeId) && GetStrLen(objQxUserGroupRelationEN.ManageTypeId) > 4)
{
 throw new Exception("字段[ManageTypeId]的长度不能超过4!");
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
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupRelationService.QxUserGroupRelation_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_GetDataSet", "clsQxUserGroupRelationWS:GetDataTableWs", objException.Message);
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
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupRelationService.QxUserGroupRelation_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_GetTopDataSet", "clsQxUserGroupRelationWS:GetDataTable_TopWs", objException.Message);
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
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupRelationService.QxUserGroupRelation_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_GetDataSetByRange", "clsQxUserGroupRelationWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupRelationService.QxUserGroupRelation_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_GetDataSetV", "clsQxUserGroupRelationWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserGroupRelationVWs(string strWhereCond)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserGroupRelationService.QxUserGroupRelation_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_GetDataSetV", "clsQxUserGroupRelationWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserGroupRelationWs(ref clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
bool bolResult = objQxUserGroupRelationService.QxUserGroupRelation_GetQxUserGroupRelation(ref objQxUserGroupRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserGroupRelationEN GetObjBymIdWs(long lngmId)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
clsQxUserGroupRelationEN objQxUserGroupRelationEN = objQxUserGroupRelationService.QxUserGroupRelation_GetObjBymId(lngmId);
return objQxUserGroupRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
long lngmId = objQxUserGroupRelationService.QxUserGroupRelation_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_GetFirstID_S", "clsQxUserGroupRelationWS:GetFirstID_S", objException.Message);
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
public static clsQxUserGroupRelationEN GetFirstQxUserGroupRelation_S(string strWhereCond)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
clsQxUserGroupRelationEN objQxUserGroupRelationEN = objQxUserGroupRelationService.QxUserGroupRelation_GetFirstObj_S(strWhereCond);
return objQxUserGroupRelationEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_GetFirstObj_S", "clsQxUserGroupRelationWS:GetFirstObj_S", objException.Message);
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
if (arrQxUserGroupRelationObjLst_Cache == null)
{
arrQxUserGroupRelationObjLst_Cache = clsQxUserGroupRelationWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserGroupRelationEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserGroupRelationObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserGroupRelationEN objQxUserGroupRelationEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserGroupRelationEN = arrQxUserGroupRelationObjLst_Cache[intMid];
if (objQxUserGroupRelationEN.mId == lngmId)
{
intFindFailCount = 0;
return objQxUserGroupRelationEN;
}
else if (objQxUserGroupRelationEN.mId.CompareTo(lngmId) > 0)
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
arrQxUserGroupRelationObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在QxUserGroupRelation对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserGroupRelationEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserGroupRelationEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserGroupRelationBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserGroupRelationEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserGroupRelationEN> arrObjLst = new List<clsQxUserGroupRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
objQxUserGroupRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserGroupRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserGroupRelationEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
objQxUserGroupRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objQxUserGroupRelationEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserGroupRelationEN.ManageId = objRow["ManageId"].ToString().Trim(); //ManageId
objQxUserGroupRelationEN.ManageTypeId = objRow["ManageTypeId"].ToString().Trim(); //ManageTypeId
objQxUserGroupRelationEN.IsDefault = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefault"].ToString().Trim()); //是否默认
	arrObjLst.Add(objQxUserGroupRelationEN);
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
public static List<clsQxUserGroupRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserGroupRelationEN> arrObjLst = new List<clsQxUserGroupRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserGroupRelationEN objQxUserGroupRelationEN = new clsQxUserGroupRelationEN();
objQxUserGroupRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserGroupRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserGroupRelationEN.GroupId = objRow["GroupId"].ToString().Trim(); //组Id
objQxUserGroupRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objQxUserGroupRelationEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserGroupRelationEN.ManageId = objRow["ManageId"].ToString().Trim(); //ManageId
objQxUserGroupRelationEN.ManageTypeId = objRow["ManageTypeId"].ToString().Trim(); //ManageTypeId
objQxUserGroupRelationEN.IsDefault = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefault"].ToString().Trim()); //是否默认
	arrObjLst.Add(objQxUserGroupRelationEN);
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
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
int intResult = objQxUserGroupRelationService.QxUserGroupRelation_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_DelRecord", "clsQxUserGroupRelationWS:DelRecordWs", objException.Message);
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
public static int DelQxUserGroupRelationsWs(List<string> arrmId)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objQxUserGroupRelationService.QxUserGroupRelation_DelQxUserGroupRelations(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_DelQxUserGroupRelations", "clsQxUserGroupRelationWS:DelQxUserGroupRelationsWs", objException.Message);
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
public static int DelQxUserGroupRelationsByCondWs(string strWhereCond)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
int intRecNum = objQxUserGroupRelationService.QxUserGroupRelation_DelQxUserGroupRelationsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_DelQxUserGroupRelationsByCond", "clsQxUserGroupRelationWS:DelQxUserGroupRelationsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
bool bolResult = objQxUserGroupRelationService.QxUserGroupRelation_AddNewRecordBySql2(objQxUserGroupRelationEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_AddNewRecordBySql2", "clsQxUserGroupRelationWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
string strKey = objQxUserGroupRelationService.QxUserGroupRelation_AddNewRecordBySql2WithReturnKey(objQxUserGroupRelationEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_AddNewRecordBySql2WithReturnKey", "clsQxUserGroupRelationWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserGroupRelationEN objQxUserGroupRelationEN)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
bool bolResult = objQxUserGroupRelationService.QxUserGroupRelation_UpdateBySql2(objQxUserGroupRelationEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_UpdateBySql2", "clsQxUserGroupRelationWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserGroupRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserGroupRelationEN objQxUserGroupRelationEN, string strWhereCond)
{
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
try
{
bool bolResult = objQxUserGroupRelationService.QxUserGroupRelation_UpdateBySqlWithCondition(objQxUserGroupRelationEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserGroupRelation_UpdateBySqlWithCondition", "clsQxUserGroupRelationWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
bool bolIsExist = objQxUserGroupRelationService.QxUserGroupRelation_IsExistRecord(strWhereCond);
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
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
bool bolIsExist = objQxUserGroupRelationService.QxUserGroupRelation_IsExist(lngmId);
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
QxUserGroupRelationServiceSoapClient objQxUserGroupRelationService = GetQxUserGroupRelationServiceSoapClient();
int intRecCount = objQxUserGroupRelationService.QxUserGroupRelation_funGetRecCountByCond(strWhereCond);
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