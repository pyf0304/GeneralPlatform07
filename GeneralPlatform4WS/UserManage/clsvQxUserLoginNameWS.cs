
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserLoginNameWS
 表名:vQxUserLoginName(00140077)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:19
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
using GeneralPlatform4WS.ServiceReferencevQxUserLoginName;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// vUserLoginName(vQxUserLoginName)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserLoginNameWS
{
private static string mstrPageName = "vQxUserLoginNameService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUserLoginNameServiceSoapClient objvQxUserLoginNameServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUserLoginNameServiceSoapClient GetvQxUserLoginNameServiceSoapClient()
{
if (objvQxUserLoginNameServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUserLoginNameServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUserLoginNameServiceSoapClient(binding, address);
}
else
{
return objvQxUserLoginNameServiceSoapClient;
}
}

 public clsvQxUserLoginNameWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxUserLoginName(System.Windows.Forms.ListView lvvQxUserLoginName, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUserLoginName; 
List<clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUserLoginNameObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUserLoginName.Items.Clear();//清除原来所有Item
lvvQxUserLoginName.Columns.Clear();//清除原来所有列头信息
lvvQxUserLoginName.Columns.Add("用户登录名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("用户状态名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("有效开始日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("有效结束日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("学工号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("身份描述", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserLoginName.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUserLoginNameEN objvQxUserLoginNameEN in arrvQxUserLoginNameObjLst)
{
lvivQxUserLoginName = new System.Windows.Forms.ListViewItem();
lvivQxUserLoginName.Tag = objvQxUserLoginNameEN.UserLoginName;
lvivQxUserLoginName.Text = objvQxUserLoginNameEN.UserLoginName.ToString();
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.UserId);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.UserName);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.DepartmentId);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.DepartmentName);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.DepartmentAbbrName);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.UserStateId);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.UserStateName);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.Password);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.EffitiveBeginDate);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.EffitiveEndDate);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.StuTeacherId);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.IdentityID);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.IdentityDesc);
lvivQxUserLoginName.SubItems.Add(objvQxUserLoginNameEN.Memo);
lvvQxUserLoginName.Items.Add(lvivQxUserLoginName);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUserLoginNameObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserLoginNameService.vQxUserLoginName_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserLoginName_GetDataSet", "clsvQxUserLoginNameWS:GetDataTableWs", objException.Message);
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
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserLoginNameService.vQxUserLoginName_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserLoginName_GetTopDataSet", "clsvQxUserLoginNameWS:GetDataTable_TopWs", objException.Message);
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
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserLoginNameService.vQxUserLoginName_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserLoginName_GetDataSetByRange", "clsvQxUserLoginNameWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserLoginNameWs(ref clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
bool bolResult = objvQxUserLoginNameService.vQxUserLoginName_GetvQxUserLoginName(ref objvQxUserLoginNameEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserLoginNameEN GetObjByUserLoginNameWs(string strUserLoginName)
{
strUserLoginName = strUserLoginName.Replace("'", "");
strUserLoginName = strUserLoginName.Replace(" ", "");
strUserLoginName = strUserLoginName.Replace("(", "");
strUserLoginName = strUserLoginName.Replace(")", "");
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
clsvQxUserLoginNameEN objvQxUserLoginNameEN = objvQxUserLoginNameService.vQxUserLoginName_GetObjByUserLoginName(strUserLoginName);
return objvQxUserLoginNameEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
try
{
string strUserLoginName = objvQxUserLoginNameService.vQxUserLoginName_GetFirstID_S(strWhereCond);
return strUserLoginName;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserLoginName_GetFirstID_S", "clsvQxUserLoginNameWS:GetFirstID_S", objException.Message);
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
public static clsvQxUserLoginNameEN GetFirstvQxUserLoginName_S(string strWhereCond)
{
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
try
{
clsvQxUserLoginNameEN objvQxUserLoginNameEN = objvQxUserLoginNameService.vQxUserLoginName_GetFirstObj_S(strWhereCond);
return objvQxUserLoginNameEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserLoginName_GetFirstObj_S", "clsvQxUserLoginNameWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by UserLoginName");
if (arrvQxUserLoginNameObjLst_Cache == null)
{
arrvQxUserLoginNameObjLst_Cache = clsvQxUserLoginNameWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserLoginName">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserLoginNameEN GetObjByUserLoginName_Cache(string strUserLoginName)
{
if (string.IsNullOrEmpty(strUserLoginName) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUserLoginNameObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUserLoginNameEN objvQxUserLoginNameEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUserLoginNameEN = arrvQxUserLoginNameObjLst_Cache[intMid];
if (objvQxUserLoginNameEN.UserLoginName == strUserLoginName)
{
intFindFailCount = 0;
return objvQxUserLoginNameEN;
}
else if (objvQxUserLoginNameEN.UserLoginName.CompareTo(strUserLoginName) > 0)
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
arrvQxUserLoginNameObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserLoginName_Cache(strUserLoginName);
string strErrMsgForGetObjById = string.Format("在vQxUserLoginName对象缓存列表中,找不到记录[UserLoginName = {0}][intFindFailCount = {1}](函数:{2})", strUserLoginName, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUserLoginNameEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUserLoginNameEN.UserLoginName, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUserLoginNameBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
objvQxUserLoginNameEN.UserLoginName = objRow["UserLoginName"].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow["Password"].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public static List<clsvQxUserLoginNameEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
objvQxUserLoginNameEN.UserLoginName = objRow["UserLoginName"].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow["Password"].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUserLoginNameEN);
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
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
bool bolIsExist = objvQxUserLoginNameService.vQxUserLoginName_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strUserLoginName)
{
//检测记录是否存在
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
bool bolIsExist = objvQxUserLoginNameService.vQxUserLoginName_IsExist(strUserLoginName);
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
vQxUserLoginNameServiceSoapClient objvQxUserLoginNameService = GetvQxUserLoginNameServiceSoapClient();
int intRecCount = objvQxUserLoginNameService.vQxUserLoginName_funGetRecCountByCond(strWhereCond);
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