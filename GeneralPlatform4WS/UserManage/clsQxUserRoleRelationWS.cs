
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRoleRelationWS
 表名:QxUserRoleRelation(00140013)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:54
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
using GeneralPlatform4WS.ServiceReferenceQxUserRoleRelation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户角色关系(QxUserRoleRelation)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRoleRelationWS
{
private static string mstrPageName = "QxUserRoleRelationService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserRoleRelationEN> arrQxUserRoleRelationObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserRoleRelationServiceSoapClient objQxUserRoleRelationServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserRoleRelationServiceSoapClient GetQxUserRoleRelationServiceSoapClient()
{
if (objQxUserRoleRelationServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserRoleRelationServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserRoleRelationServiceSoapClient(binding, address);
}
else
{
return objQxUserRoleRelationServiceSoapClient;
}
}

 public clsQxUserRoleRelationWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUserRoleRelation(System.Windows.Forms.ListView lvQxUserRoleRelation, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserRoleRelation; 
List<clsQxUserRoleRelationEN> arrQxUserRoleRelationObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserRoleRelationObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserRoleRelation.Items.Clear();//清除原来所有Item
lvQxUserRoleRelation.Columns.Clear();//清除原来所有列头信息
lvQxUserRoleRelation.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoleRelation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoleRelation.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoleRelation.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoleRelation.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoleRelation.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoleRelation.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoleRelation.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserRoleRelationEN objQxUserRoleRelationEN in arrQxUserRoleRelationObjLst)
{
lviQxUserRoleRelation = new System.Windows.Forms.ListViewItem();
lviQxUserRoleRelation.Tag = objQxUserRoleRelationEN.mId;
lviQxUserRoleRelation.Text = objQxUserRoleRelationEN.mId.ToString();
lviQxUserRoleRelation.SubItems.Add(objQxUserRoleRelationEN.UserId);
lviQxUserRoleRelation.SubItems.Add(objQxUserRoleRelationEN.UpdDate);
lviQxUserRoleRelation.SubItems.Add(objQxUserRoleRelationEN.UpdUserId);
lviQxUserRoleRelation.SubItems.Add(objQxUserRoleRelationEN.Memo);
lvQxUserRoleRelation.Items.Add(lviQxUserRoleRelation);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserRoleRelationObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserRoleRelationEN objQxUserRoleRelationEN)
{
if (!Object.Equals(null, objQxUserRoleRelationEN.UserId) && GetStrLen(objQxUserRoleRelationEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserRoleRelationEN.RoleId) && GetStrLen(objQxUserRoleRelationEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserRoleRelationEN.QxPrjId) && GetStrLen(objQxUserRoleRelationEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserRoleRelationEN.UpdDate) && GetStrLen(objQxUserRoleRelationEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUserRoleRelationEN.UpdUserId) && GetStrLen(objQxUserRoleRelationEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserRoleRelationEN.Memo) && GetStrLen(objQxUserRoleRelationEN.Memo) > 1000)
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
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRoleRelationService.QxUserRoleRelation_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_GetDataSet", "clsQxUserRoleRelationWS:GetDataTableWs", objException.Message);
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
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRoleRelationService.QxUserRoleRelation_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_GetTopDataSet", "clsQxUserRoleRelationWS:GetDataTable_TopWs", objException.Message);
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
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRoleRelationService.QxUserRoleRelation_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_GetDataSetByRange", "clsQxUserRoleRelationWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRoleRelationService.QxUserRoleRelation_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_GetDataSetV", "clsQxUserRoleRelationWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserRoleRelationVWs(string strWhereCond)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRoleRelationService.QxUserRoleRelation_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_GetDataSetV", "clsQxUserRoleRelationWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserRoleRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserRoleRelationWs(ref clsQxUserRoleRelationEN objQxUserRoleRelationEN)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
bool bolResult = objQxUserRoleRelationService.QxUserRoleRelation_GetQxUserRoleRelation(ref objQxUserRoleRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRoleRelationEN GetObjBymIdWs(long lngmId)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
clsQxUserRoleRelationEN objQxUserRoleRelationEN = objQxUserRoleRelationService.QxUserRoleRelation_GetObjBymId(lngmId);
return objQxUserRoleRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
long lngmId = objQxUserRoleRelationService.QxUserRoleRelation_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_GetFirstID_S", "clsQxUserRoleRelationWS:GetFirstID_S", objException.Message);
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
public static clsQxUserRoleRelationEN GetFirstQxUserRoleRelation_S(string strWhereCond)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
clsQxUserRoleRelationEN objQxUserRoleRelationEN = objQxUserRoleRelationService.QxUserRoleRelation_GetFirstObj_S(strWhereCond);
return objQxUserRoleRelationEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_GetFirstObj_S", "clsQxUserRoleRelationWS:GetFirstObj_S", objException.Message);
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
if (arrQxUserRoleRelationObjLst_Cache == null)
{
arrQxUserRoleRelationObjLst_Cache = clsQxUserRoleRelationWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRoleRelationEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserRoleRelationObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserRoleRelationEN objQxUserRoleRelationEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserRoleRelationEN = arrQxUserRoleRelationObjLst_Cache[intMid];
if (objQxUserRoleRelationEN.mId == lngmId)
{
intFindFailCount = 0;
return objQxUserRoleRelationEN;
}
else if (objQxUserRoleRelationEN.mId.CompareTo(lngmId) > 0)
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
arrQxUserRoleRelationObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在QxUserRoleRelation对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserRoleRelationEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserRoleRelationEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserRoleRelationBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRoleRelationEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserRoleRelationEN> arrObjLst = new List<clsQxUserRoleRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationEN objQxUserRoleRelationEN = new clsQxUserRoleRelationEN();
objQxUserRoleRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserRoleRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserRoleRelationEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objQxUserRoleRelationEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserRoleRelationEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserRoleRelationEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserRoleRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserRoleRelationEN);
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
public static List<clsQxUserRoleRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserRoleRelationEN> arrObjLst = new List<clsQxUserRoleRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRoleRelationEN objQxUserRoleRelationEN = new clsQxUserRoleRelationEN();
objQxUserRoleRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUserRoleRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserRoleRelationEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objQxUserRoleRelationEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserRoleRelationEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserRoleRelationEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserRoleRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserRoleRelationEN);
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
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
int intResult = objQxUserRoleRelationService.QxUserRoleRelation_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_DelRecord", "clsQxUserRoleRelationWS:DelRecordWs", objException.Message);
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
public static int DelQxUserRoleRelationsWs(List<string> arrmId)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objQxUserRoleRelationService.QxUserRoleRelation_DelQxUserRoleRelations(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_DelQxUserRoleRelations", "clsQxUserRoleRelationWS:DelQxUserRoleRelationsWs", objException.Message);
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
public static int DelQxUserRoleRelationsByCondWs(string strWhereCond)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
int intRecNum = objQxUserRoleRelationService.QxUserRoleRelation_DelQxUserRoleRelationsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_DelQxUserRoleRelationsByCond", "clsQxUserRoleRelationWS:DelQxUserRoleRelationsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserRoleRelationEN objQxUserRoleRelationEN)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
bool bolResult = objQxUserRoleRelationService.QxUserRoleRelation_AddNewRecordBySql2(objQxUserRoleRelationEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_AddNewRecordBySql2", "clsQxUserRoleRelationWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUserRoleRelationEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUserRoleRelationEN objQxUserRoleRelationEN)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
string strKey = objQxUserRoleRelationService.QxUserRoleRelation_AddNewRecordBySql2WithReturnKey(objQxUserRoleRelationEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_AddNewRecordBySql2WithReturnKey", "clsQxUserRoleRelationWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserRoleRelationEN objQxUserRoleRelationEN)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
bool bolResult = objQxUserRoleRelationService.QxUserRoleRelation_UpdateBySql2(objQxUserRoleRelationEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_UpdateBySql2", "clsQxUserRoleRelationWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserRoleRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserRoleRelationEN objQxUserRoleRelationEN, string strWhereCond)
{
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
try
{
bool bolResult = objQxUserRoleRelationService.QxUserRoleRelation_UpdateBySqlWithCondition(objQxUserRoleRelationEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoleRelation_UpdateBySqlWithCondition", "clsQxUserRoleRelationWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
bool bolIsExist = objQxUserRoleRelationService.QxUserRoleRelation_IsExistRecord(strWhereCond);
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
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
bool bolIsExist = objQxUserRoleRelationService.QxUserRoleRelation_IsExist(lngmId);
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
QxUserRoleRelationServiceSoapClient objQxUserRoleRelationService = GetQxUserRoleRelationServiceSoapClient();
int intRecCount = objQxUserRoleRelationService.QxUserRoleRelation_funGetRecCountByCond(strWhereCond);
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