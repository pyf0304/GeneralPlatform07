
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelationWS
 表名:vQxUserRoleRelation(00140023)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:58
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
using GeneralPlatform4WS.ServiceReferencevQxUserRoleRelation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v用户角色关系(vQxUserRoleRelation)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRoleRelationWS
{
private static string mstrPageName = "vQxUserRoleRelationService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUserRoleRelationServiceSoapClient GetvQxUserRoleRelationServiceSoapClient()
{
if (objvQxUserRoleRelationServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUserRoleRelationServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUserRoleRelationServiceSoapClient(binding, address);
}
else
{
return objvQxUserRoleRelationServiceSoapClient;
}
}

 public clsvQxUserRoleRelationWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxUserRoleRelation(System.Windows.Forms.ListView lvvQxUserRoleRelation, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUserRoleRelation; 
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUserRoleRelationObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUserRoleRelation.Items.Clear();//清除原来所有Item
lvvQxUserRoleRelation.Columns.Clear();//清除原来所有列头信息
lvvQxUserRoleRelation.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("用户状态名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("学工号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("身份描述", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRoleRelation.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUserRoleRelationEN objvQxUserRoleRelationEN in arrvQxUserRoleRelationObjLst)
{
lvivQxUserRoleRelation = new System.Windows.Forms.ListViewItem();
lvivQxUserRoleRelation.Tag = objvQxUserRoleRelationEN.mId;
lvivQxUserRoleRelation.Text = objvQxUserRoleRelationEN.mId.ToString();
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.UserId);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.UserName);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.DepartmentId);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.DepartmentName);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.UserStateId);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.UserStateName);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.StuTeacherId);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.IdentityID);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.IdentityDesc);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.RoleId);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.RoleName);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.QxPrjId);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.PrjName);
lvivQxUserRoleRelation.SubItems.Add(objvQxUserRoleRelationEN.Memo);
lvvQxUserRoleRelation.Items.Add(lvivQxUserRoleRelation);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUserRoleRelationObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRoleRelationService.vQxUserRoleRelation_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoleRelation_GetDataSet", "clsvQxUserRoleRelationWS:GetDataTableWs", objException.Message);
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
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRoleRelationService.vQxUserRoleRelation_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoleRelation_GetTopDataSet", "clsvQxUserRoleRelationWS:GetDataTable_TopWs", objException.Message);
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
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRoleRelationService.vQxUserRoleRelation_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoleRelation_GetDataSetByRange", "clsvQxUserRoleRelationWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRoleRelationWs(ref clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
bool bolResult = objvQxUserRoleRelationService.vQxUserRoleRelation_GetvQxUserRoleRelation(ref objvQxUserRoleRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymIdWs(long lngmId)
{
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = objvQxUserRoleRelationService.vQxUserRoleRelation_GetObjBymId(lngmId);
return objvQxUserRoleRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
try
{
long lngmId = objvQxUserRoleRelationService.vQxUserRoleRelation_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoleRelation_GetFirstID_S", "clsvQxUserRoleRelationWS:GetFirstID_S", objException.Message);
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
public static clsvQxUserRoleRelationEN GetFirstvQxUserRoleRelation_S(string strWhereCond)
{
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
try
{
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = objvQxUserRoleRelationService.vQxUserRoleRelation_GetFirstObj_S(strWhereCond);
return objvQxUserRoleRelationEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRoleRelation_GetFirstObj_S", "clsvQxUserRoleRelationWS:GetFirstObj_S", objException.Message);
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
if (arrvQxUserRoleRelationObjLst_Cache == null)
{
arrvQxUserRoleRelationObjLst_Cache = clsvQxUserRoleRelationWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUserRoleRelationObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUserRoleRelationEN = arrvQxUserRoleRelationObjLst_Cache[intMid];
if (objvQxUserRoleRelationEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxUserRoleRelationEN;
}
else if (objvQxUserRoleRelationEN.mId.CompareTo(lngmId) > 0)
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
arrvQxUserRoleRelationObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxUserRoleRelation对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUserRoleRelationEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUserRoleRelationEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUserRoleRelationBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
bool bolIsExist = objvQxUserRoleRelationService.vQxUserRoleRelation_IsExistRecord(strWhereCond);
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
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
bool bolIsExist = objvQxUserRoleRelationService.vQxUserRoleRelation_IsExist(lngmId);
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
vQxUserRoleRelationServiceSoapClient objvQxUserRoleRelationService = GetvQxUserRoleRelationServiceSoapClient();
int intRecCount = objvQxUserRoleRelationService.vQxUserRoleRelation_funGetRecCountByCond(strWhereCond);
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