
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserLoginNameWS
 表名:QxUserLoginName(00140051)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:08
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
using GeneralPlatform4WS.ServiceReferenceQxUserLoginName;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户登录名(QxUserLoginName)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserLoginNameWS
{
private static string mstrPageName = "QxUserLoginNameService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserLoginNameEN> arrQxUserLoginNameObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserLoginNameServiceSoapClient objQxUserLoginNameServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserLoginNameServiceSoapClient GetQxUserLoginNameServiceSoapClient()
{
if (objQxUserLoginNameServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserLoginNameServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserLoginNameServiceSoapClient(binding, address);
}
else
{
return objQxUserLoginNameServiceSoapClient;
}
}

 public clsQxUserLoginNameWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUserLoginName(System.Windows.Forms.ListView lvQxUserLoginName, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserLoginName; 
List<clsQxUserLoginNameEN> arrQxUserLoginNameObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserLoginNameObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserLoginName.Items.Clear();//清除原来所有Item
lvQxUserLoginName.Columns.Clear();//清除原来所有列头信息
lvQxUserLoginName.Columns.Add("用户登录名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserLoginName.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserLoginName.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserLoginName.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserLoginName.Columns.Add("修改时间", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserLoginName.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserLoginName.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserLoginNameEN objQxUserLoginNameEN in arrQxUserLoginNameObjLst)
{
lviQxUserLoginName = new System.Windows.Forms.ListViewItem();
lviQxUserLoginName.Tag = objQxUserLoginNameEN.UserLoginName;
lviQxUserLoginName.Text = objQxUserLoginNameEN.UserLoginName.ToString();
lviQxUserLoginName.SubItems.Add(objQxUserLoginNameEN.UserId);
lviQxUserLoginName.SubItems.Add(objQxUserLoginNameEN.UpdUserId);
lviQxUserLoginName.SubItems.Add(objQxUserLoginNameEN.UpdDate);
lviQxUserLoginName.SubItems.Add(objQxUserLoginNameEN.UpdTime);
lviQxUserLoginName.SubItems.Add(objQxUserLoginNameEN.Memo);
lvQxUserLoginName.Items.Add(lviQxUserLoginName);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserLoginNameObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
if (!Object.Equals(null, objQxUserLoginNameEN.UserLoginName) && GetStrLen(objQxUserLoginNameEN.UserLoginName) > 30)
{
 throw new Exception("字段[用户登录名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUserLoginNameEN.UserId) && GetStrLen(objQxUserLoginNameEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserLoginNameEN.UpdUserId) && GetStrLen(objQxUserLoginNameEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserLoginNameEN.UpdDate) && GetStrLen(objQxUserLoginNameEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUserLoginNameEN.UpdTime) && GetStrLen(objQxUserLoginNameEN.UpdTime) > 6)
{
 throw new Exception("字段[修改时间]的长度不能超过6!");
}
if (!Object.Equals(null, objQxUserLoginNameEN.Memo) && GetStrLen(objQxUserLoginNameEN.Memo) > 1000)
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
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserLoginNameService.QxUserLoginName_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_GetDataSet", "clsQxUserLoginNameWS:GetDataTableWs", objException.Message);
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
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserLoginNameService.QxUserLoginName_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_GetTopDataSet", "clsQxUserLoginNameWS:GetDataTable_TopWs", objException.Message);
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
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserLoginNameService.QxUserLoginName_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_GetDataSetByRange", "clsQxUserLoginNameWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserLoginNameService.QxUserLoginName_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_GetDataSetV", "clsQxUserLoginNameWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserLoginNameVWs(string strWhereCond)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserLoginNameService.QxUserLoginName_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_GetDataSetV", "clsQxUserLoginNameWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserLoginNameWs(ref clsQxUserLoginNameEN objQxUserLoginNameEN)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
bool bolResult = objQxUserLoginNameService.QxUserLoginName_GetQxUserLoginName(ref objQxUserLoginNameEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserLoginNameEN GetObjByUserLoginNameWs(string strUserLoginName)
{
strUserLoginName = strUserLoginName.Replace("'", "");
strUserLoginName = strUserLoginName.Replace(" ", "");
strUserLoginName = strUserLoginName.Replace("(", "");
strUserLoginName = strUserLoginName.Replace(")", "");
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
clsQxUserLoginNameEN objQxUserLoginNameEN = objQxUserLoginNameService.QxUserLoginName_GetObjByUserLoginName(strUserLoginName);
return objQxUserLoginNameEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
string strUserLoginName = objQxUserLoginNameService.QxUserLoginName_GetFirstID_S(strWhereCond);
return strUserLoginName;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_GetFirstID_S", "clsQxUserLoginNameWS:GetFirstID_S", objException.Message);
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
public static clsQxUserLoginNameEN GetFirstQxUserLoginName_S(string strWhereCond)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
clsQxUserLoginNameEN objQxUserLoginNameEN = objQxUserLoginNameService.QxUserLoginName_GetFirstObj_S(strWhereCond);
return objQxUserLoginNameEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_GetFirstObj_S", "clsQxUserLoginNameWS:GetFirstObj_S", objException.Message);
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
if (arrQxUserLoginNameObjLst_Cache == null)
{
arrQxUserLoginNameObjLst_Cache = clsQxUserLoginNameWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserLoginName">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserLoginNameEN GetObjByUserLoginName_Cache(string strUserLoginName)
{
if (string.IsNullOrEmpty(strUserLoginName) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserLoginNameObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserLoginNameEN objQxUserLoginNameEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserLoginNameEN = arrQxUserLoginNameObjLst_Cache[intMid];
if (objQxUserLoginNameEN.UserLoginName == strUserLoginName)
{
intFindFailCount = 0;
return objQxUserLoginNameEN;
}
else if (objQxUserLoginNameEN.UserLoginName.CompareTo(strUserLoginName) > 0)
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
arrQxUserLoginNameObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserLoginName_Cache(strUserLoginName);
string strErrMsgForGetObjById = string.Format("在QxUserLoginName对象缓存列表中,找不到记录[UserLoginName = {0}][intFindFailCount = {1}](函数:{2})", strUserLoginName, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserLoginNameEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserLoginNameEN.UserLoginName, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserLoginNameBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserLoginNameEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
objQxUserLoginNameEN.UserLoginName = objRow["UserLoginName"].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow["UpdTime"].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserLoginNameEN);
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
public static List<clsQxUserLoginNameEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserLoginNameEN> arrObjLst = new List<clsQxUserLoginNameEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserLoginNameEN objQxUserLoginNameEN = new clsQxUserLoginNameEN();
objQxUserLoginNameEN.UserLoginName = objRow["UserLoginName"].ToString().Trim(); //用户登录名
objQxUserLoginNameEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUserLoginNameEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserLoginNameEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserLoginNameEN.UpdTime = objRow["UpdTime"].ToString().Trim(); //修改时间
objQxUserLoginNameEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserLoginNameEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strUserLoginName)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
int intResult = objQxUserLoginNameService.QxUserLoginName_DelRecord(strUserLoginName);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_DelRecord", "clsQxUserLoginNameWS:DelRecordWs", objException.Message);
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
public static int DelQxUserLoginNamesWs(List<string> arrUserLoginName)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrUserLoginName);
int intResult = objQxUserLoginNameService.QxUserLoginName_DelQxUserLoginNames(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_DelQxUserLoginNames", "clsQxUserLoginNameWS:DelQxUserLoginNamesWs", objException.Message);
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
public static int DelQxUserLoginNamesByCondWs(string strWhereCond)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
int intRecNum = objQxUserLoginNameService.QxUserLoginName_DelQxUserLoginNamesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_DelQxUserLoginNamesByCond", "clsQxUserLoginNameWS:DelQxUserLoginNamesByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
bool bolResult = objQxUserLoginNameService.QxUserLoginName_AddNewRecordBySql2(objQxUserLoginNameEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_AddNewRecordBySql2", "clsQxUserLoginNameWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserLoginNameEN objQxUserLoginNameEN)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
bool bolResult = objQxUserLoginNameService.QxUserLoginName_UpdateBySql2(objQxUserLoginNameEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_UpdateBySql2", "clsQxUserLoginNameWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserLoginNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserLoginNameEN objQxUserLoginNameEN, string strWhereCond)
{
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
try
{
bool bolResult = objQxUserLoginNameService.QxUserLoginName_UpdateBySqlWithCondition(objQxUserLoginNameEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserLoginName_UpdateBySqlWithCondition", "clsQxUserLoginNameWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
bool bolIsExist = objQxUserLoginNameService.QxUserLoginName_IsExistRecord(strWhereCond);
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
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
bool bolIsExist = objQxUserLoginNameService.QxUserLoginName_IsExist(strUserLoginName);
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
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
int intRecCount = objQxUserLoginNameService.QxUserLoginName_funGetRecCountByCond(strWhereCond);
return intRecCount;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdWs()
{
//检测记录是否存在
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
string strMaxUserLoginName = objQxUserLoginNameService.QxUserLoginName_GetMaxStrId();
return strMaxUserLoginName;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxUserLoginNameServiceSoapClient objQxUserLoginNameService = GetQxUserLoginNameServiceSoapClient();
string strMaxUserLoginName = objQxUserLoginNameService.QxUserLoginName_GetMaxStrIdByPrefix(strPrefix);
return strMaxUserLoginName;
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