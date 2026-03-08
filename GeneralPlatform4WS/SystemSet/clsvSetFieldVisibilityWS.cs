
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityWS
 表名:vSetFieldVisibility(00140070)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:16
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
using GeneralPlatform4WS.ServiceReferencevSetFieldVisibility;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSetFieldVisibilityWS
{
private static string mstrPageName = "vSetFieldVisibilityService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vSetFieldVisibilityServiceSoapClient GetvSetFieldVisibilityServiceSoapClient()
{
if (objvSetFieldVisibilityServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vSetFieldVisibilityServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vSetFieldVisibilityServiceSoapClient(binding, address);
}
else
{
return objvSetFieldVisibilityServiceSoapClient;
}
}

 public clsvSetFieldVisibilityWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vSetFieldVisibility(System.Windows.Forms.ListView lvvSetFieldVisibility, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivSetFieldVisibility; 
List<clsvSetFieldVisibilityEN> arrvSetFieldVisibilityObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvSetFieldVisibilityObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvSetFieldVisibility.Items.Clear();//清除原来所有Item
lvvSetFieldVisibility.Columns.Clear();//清除原来所有列头信息
lvvSetFieldVisibility.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("学校流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("学校Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("学校名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("控件类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("字段名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvSetFieldVisibility.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvSetFieldVisibilityEN objvSetFieldVisibilityEN in arrvSetFieldVisibilityObjLst)
{
lvivSetFieldVisibility = new System.Windows.Forms.ListViewItem();
lvivSetFieldVisibility.Tag = objvSetFieldVisibilityEN.mId;
lvivSetFieldVisibility.Text = objvSetFieldVisibilityEN.mId.ToString();
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.id_School);
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.SchoolId);
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.SchoolName);
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.ViewName);
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.CtrlType);
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.FieldName);
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.IsVisible.ToString());
lvivSetFieldVisibility.SubItems.Add(objvSetFieldVisibilityEN.Memo);
lvvSetFieldVisibility.Items.Add(lvivSetFieldVisibility);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvSetFieldVisibilityObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvSetFieldVisibilityService.vSetFieldVisibility_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSetFieldVisibility_GetDataSet", "clsvSetFieldVisibilityWS:GetDataTableWs", objException.Message);
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
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvSetFieldVisibilityService.vSetFieldVisibility_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSetFieldVisibility_GetTopDataSet", "clsvSetFieldVisibilityWS:GetDataTable_TopWs", objException.Message);
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
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvSetFieldVisibilityService.vSetFieldVisibility_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSetFieldVisibility_GetDataSetByRange", "clsvSetFieldVisibilityWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvSetFieldVisibilityEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSetFieldVisibilityWs(ref clsvSetFieldVisibilityEN objvSetFieldVisibilityEN)
{
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
bool bolResult = objvSetFieldVisibilityService.vSetFieldVisibility_GetvSetFieldVisibility(ref objvSetFieldVisibilityEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSetFieldVisibilityEN GetObjBymIdWs(long lngmId)
{
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = objvSetFieldVisibilityService.vSetFieldVisibility_GetObjBymId(lngmId);
return objvSetFieldVisibilityEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
try
{
long lngmId = objvSetFieldVisibilityService.vSetFieldVisibility_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSetFieldVisibility_GetFirstID_S", "clsvSetFieldVisibilityWS:GetFirstID_S", objException.Message);
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
public static clsvSetFieldVisibilityEN GetFirstvSetFieldVisibility_S(string strWhereCond)
{
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
try
{
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = objvSetFieldVisibilityService.vSetFieldVisibility_GetFirstObj_S(strWhereCond);
return objvSetFieldVisibilityEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vSetFieldVisibility_GetFirstObj_S", "clsvSetFieldVisibilityWS:GetFirstObj_S", objException.Message);
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
if (arrvSetFieldVisibilityObjLst_Cache == null)
{
arrvSetFieldVisibilityObjLst_Cache = clsvSetFieldVisibilityWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSetFieldVisibilityEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvSetFieldVisibilityObjLst_Cache.Count - 1;
int intMid = 0;
clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvSetFieldVisibilityEN = arrvSetFieldVisibilityObjLst_Cache[intMid];
if (objvSetFieldVisibilityEN.mId == lngmId)
{
intFindFailCount = 0;
return objvSetFieldVisibilityEN;
}
else if (objvSetFieldVisibilityEN.mId.CompareTo(lngmId) > 0)
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
arrvSetFieldVisibilityObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vSetFieldVisibility对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvSetFieldVisibilityEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvSetFieldVisibilityEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvSetFieldVisibilityBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
objvSetFieldVisibilityEN.mId = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["mId"].ToString().Trim()); //流水号
objvSetFieldVisibilityEN.id_School = objRow["id_School"].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow["SchoolId"].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow["SchoolName"].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.CtrlType = objRow["CtrlType"].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.FieldName = objRow["FieldName"].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
public static List<clsvSetFieldVisibilityEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvSetFieldVisibilityEN> arrObjLst = new List<clsvSetFieldVisibilityEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSetFieldVisibilityEN objvSetFieldVisibilityEN = new clsvSetFieldVisibilityEN();
objvSetFieldVisibilityEN.mId = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["mId"].ToString().Trim()); //流水号
objvSetFieldVisibilityEN.id_School = objRow["id_School"].ToString().Trim(); //学校流水号
objvSetFieldVisibilityEN.SchoolId = objRow["SchoolId"].ToString().Trim(); //学校Id
objvSetFieldVisibilityEN.SchoolName = objRow["SchoolName"].ToString().Trim(); //学校名称
objvSetFieldVisibilityEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvSetFieldVisibilityEN.CtrlType = objRow["CtrlType"].ToString().Trim(); //控件类型
objvSetFieldVisibilityEN.FieldName = objRow["FieldName"].ToString().Trim(); //字段名
objvSetFieldVisibilityEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objvSetFieldVisibilityEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvSetFieldVisibilityEN);
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
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
bool bolIsExist = objvSetFieldVisibilityService.vSetFieldVisibility_IsExistRecord(strWhereCond);
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
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
bool bolIsExist = objvSetFieldVisibilityService.vSetFieldVisibility_IsExist(lngmId);
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
vSetFieldVisibilityServiceSoapClient objvSetFieldVisibilityService = GetvSetFieldVisibilityServiceSoapClient();
int intRecCount = objvSetFieldVisibilityService.vSetFieldVisibility_funGetRecCountByCond(strWhereCond);
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