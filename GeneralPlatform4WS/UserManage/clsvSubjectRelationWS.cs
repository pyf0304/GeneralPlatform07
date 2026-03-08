
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSubjectRelationWS
 表名:vSubjectRelation(00140053)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:09
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
using GeneralPlatform4WS.ServiceReferencevSubjectRelation;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v隶属关系(vSubjectRelation)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSubjectRelationWS
{
private static string mstrPageName = "vSubjectRelationService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvSubjectRelationEN> arrvSubjectRelationObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vSubjectRelationServiceSoapClient objvSubjectRelationServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vSubjectRelationServiceSoapClient GetvSubjectRelationServiceSoapClient()
{
if (objvSubjectRelationServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vSubjectRelationServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vSubjectRelationServiceSoapClient(binding, address);
}
else
{
return objvSubjectRelationServiceSoapClient;
}
}

 public clsvSubjectRelationWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vSubjectRelation(System.Windows.Forms.ListView lvvSubjectRelation, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivSubjectRelation; 
List<clsvSubjectRelationEN> arrvSubjectRelationObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvSubjectRelationObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvSubjectRelation.Items.Clear();//清除原来所有Item
lvvSubjectRelation.Columns.Clear();//清除原来所有列头信息
lvvSubjectRelation.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("领导Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("是否直接领导", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("LeaderUserName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("LeaderDepartmentId", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.Columns.Add("LeaderDepartmentName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSubjectRelation.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvSubjectRelationEN objvSubjectRelationEN in arrvSubjectRelationObjLst)
{
lvivSubjectRelation = new System.Windows.Forms.ListViewItem();
lvivSubjectRelation.Tag = objvSubjectRelationEN.mId;
lvivSubjectRelation.Text = objvSubjectRelationEN.mId.ToString();
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.UserId);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.UserName);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.DepartmentId);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.DepartmentName);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.LeaderId);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.IsDirectLeader.ToString());
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.Memo);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.LeaderUserName);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.LeaderDepartmentId);
lvivSubjectRelation.SubItems.Add(objvSubjectRelationEN.LeaderDepartmentName);
lvvSubjectRelation.Items.Add(lvivSubjectRelation);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvSubjectRelationObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvSubjectRelationService.vSubjectRelation_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSubjectRelation_GetDataSet", "clsvSubjectRelationWS:GetDataTableWs", objException.Message);
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
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvSubjectRelationService.vSubjectRelation_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSubjectRelation_GetTopDataSet", "clsvSubjectRelationWS:GetDataTable_TopWs", objException.Message);
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
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvSubjectRelationService.vSubjectRelation_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSubjectRelation_GetDataSetByRange", "clsvSubjectRelationWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSubjectRelationWs(ref clsvSubjectRelationEN objvSubjectRelationEN)
{
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
bool bolResult = objvSubjectRelationService.vSubjectRelation_GetvSubjectRelation(ref objvSubjectRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSubjectRelationEN GetObjBymIdWs(long lngmId)
{
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
clsvSubjectRelationEN objvSubjectRelationEN = objvSubjectRelationService.vSubjectRelation_GetObjBymId(lngmId);
return objvSubjectRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
try
{
long lngmId = objvSubjectRelationService.vSubjectRelation_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSubjectRelation_GetFirstID_S", "clsvSubjectRelationWS:GetFirstID_S", objException.Message);
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
public static clsvSubjectRelationEN GetFirstvSubjectRelation_S(string strWhereCond)
{
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
try
{
clsvSubjectRelationEN objvSubjectRelationEN = objvSubjectRelationService.vSubjectRelation_GetFirstObj_S(strWhereCond);
return objvSubjectRelationEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSubjectRelation_GetFirstObj_S", "clsvSubjectRelationWS:GetFirstObj_S", objException.Message);
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
if (arrvSubjectRelationObjLst_Cache == null)
{
arrvSubjectRelationObjLst_Cache = clsvSubjectRelationWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSubjectRelationEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvSubjectRelationObjLst_Cache.Count - 1;
int intMid = 0;
clsvSubjectRelationEN objvSubjectRelationEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvSubjectRelationEN = arrvSubjectRelationObjLst_Cache[intMid];
if (objvSubjectRelationEN.mId == lngmId)
{
intFindFailCount = 0;
return objvSubjectRelationEN;
}
else if (objvSubjectRelationEN.mId.CompareTo(lngmId) > 0)
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
arrvSubjectRelationObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vSubjectRelation对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvSubjectRelationEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvSubjectRelationEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvSubjectRelationBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSubjectRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
objvSubjectRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow["LeaderId"].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDirectLeader"].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow["LeaderUserName"].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow["LeaderDepartmentId"].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow["LeaderDepartmentName"].ToString().Trim(); //LeaderDepartmentName
	arrObjLst.Add(objvSubjectRelationEN);
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
public static List<clsvSubjectRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
objvSubjectRelationEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow["LeaderId"].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDirectLeader"].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow["LeaderUserName"].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow["LeaderDepartmentId"].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow["LeaderDepartmentName"].ToString().Trim(); //LeaderDepartmentName
	arrObjLst.Add(objvSubjectRelationEN);
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
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
bool bolIsExist = objvSubjectRelationService.vSubjectRelation_IsExistRecord(strWhereCond);
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
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
bool bolIsExist = objvSubjectRelationService.vSubjectRelation_IsExist(lngmId);
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
vSubjectRelationServiceSoapClient objvSubjectRelationService = GetvSubjectRelationServiceSoapClient();
int intRecCount = objvSubjectRelationService.vSubjectRelation_funGetRecCountByCond(strWhereCond);
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