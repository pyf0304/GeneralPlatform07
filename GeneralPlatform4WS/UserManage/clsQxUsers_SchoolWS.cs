
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers_SchoolWS
 表名:QxUsers_School(00140074)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:18
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
using GeneralPlatform4WS.ServiceReferenceQxUsers_School;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户_学校(QxUsers_School)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUsers_SchoolWS
{
private static string mstrPageName = "QxUsers_SchoolService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUsers_SchoolServiceSoapClient objQxUsers_SchoolServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUsers_SchoolServiceSoapClient GetQxUsers_SchoolServiceSoapClient()
{
if (objQxUsers_SchoolServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUsers_SchoolServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUsers_SchoolServiceSoapClient(binding, address);
}
else
{
return objQxUsers_SchoolServiceSoapClient;
}
}

 public clsQxUsers_SchoolWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUsers_School(System.Windows.Forms.ListView lvQxUsers_School, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUsers_School; 
List<clsQxUsers_SchoolEN> arrQxUsers_SchoolObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUsers_SchoolObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUsers_School.Items.Clear();//清除原来所有Item
lvQxUsers_School.Columns.Clear();//清除原来所有列头信息
lvQxUsers_School.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("卡号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("学工号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("年级流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("卡状态", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("IsLeaved", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("修改用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers_School.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUsers_SchoolEN objQxUsers_SchoolEN in arrQxUsers_SchoolObjLst)
{
lviQxUsers_School = new System.Windows.Forms.ListViewItem();
lviQxUsers_School.Tag = objQxUsers_SchoolEN.UserId;
lviQxUsers_School.Text = objQxUsers_SchoolEN.UserId.ToString();
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.CardNo);
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.StuTeacherId);
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.id_GradeBase);
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.Card_State);
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.IsLeaved.ToString());
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.UpdDate);
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.UpdUser);
lviQxUsers_School.SubItems.Add(objQxUsers_SchoolEN.Memo);
lvQxUsers_School.Items.Add(lviQxUsers_School);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUsers_SchoolObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
if (!Object.Equals(null, objQxUsers_SchoolEN.UserId) && GetStrLen(objQxUsers_SchoolEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.IdentityID) && GetStrLen(objQxUsers_SchoolEN.IdentityID) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.CardNo) && GetStrLen(objQxUsers_SchoolEN.CardNo) > 10)
{
 throw new Exception("字段[卡号]的长度不能超过10!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.StuTeacherId) && GetStrLen(objQxUsers_SchoolEN.StuTeacherId) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.id_GradeBase) && GetStrLen(objQxUsers_SchoolEN.id_GradeBase) > 4)
{
 throw new Exception("字段[年级流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.Card_State) && GetStrLen(objQxUsers_SchoolEN.Card_State) > 10)
{
 throw new Exception("字段[卡状态]的长度不能超过10!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.UpdDate) && GetStrLen(objQxUsers_SchoolEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.UpdUser) && GetStrLen(objQxUsers_SchoolEN.UpdUser) > 18)
{
 throw new Exception("字段[修改用户]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsers_SchoolEN.Memo) && GetStrLen(objQxUsers_SchoolEN.Memo) > 1000)
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
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers_SchoolService.QxUsers_School_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_GetDataSet", "clsQxUsers_SchoolWS:GetDataTableWs", objException.Message);
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
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers_SchoolService.QxUsers_School_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_GetTopDataSet", "clsQxUsers_SchoolWS:GetDataTable_TopWs", objException.Message);
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
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers_SchoolService.QxUsers_School_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_GetDataSetByRange", "clsQxUsers_SchoolWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers_SchoolService.QxUsers_School_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_GetDataSetV", "clsQxUsers_SchoolWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUsers_SchoolVWs(string strWhereCond)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers_SchoolService.QxUsers_School_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_GetDataSetV", "clsQxUsers_SchoolWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUsers_SchoolWs(ref clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
bool bolResult = objQxUsers_SchoolService.QxUsers_School_GetQxUsers_School(ref objQxUsers_SchoolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsers_SchoolEN GetObjByUserIdWs(string strUserId)
{
strUserId = strUserId.Replace("'", "");
strUserId = strUserId.Replace(" ", "");
strUserId = strUserId.Replace("(", "");
strUserId = strUserId.Replace(")", "");
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
clsQxUsers_SchoolEN objQxUsers_SchoolEN = objQxUsers_SchoolService.QxUsers_School_GetObjByUserId(strUserId);
return objQxUsers_SchoolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
string strUserId = objQxUsers_SchoolService.QxUsers_School_GetFirstID_S(strWhereCond);
return strUserId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_GetFirstID_S", "clsQxUsers_SchoolWS:GetFirstID_S", objException.Message);
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
public static clsQxUsers_SchoolEN GetFirstQxUsers_School_S(string strWhereCond)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
clsQxUsers_SchoolEN objQxUsers_SchoolEN = objQxUsers_SchoolService.QxUsers_School_GetFirstObj_S(strWhereCond);
return objQxUsers_SchoolEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_GetFirstObj_S", "clsQxUsers_SchoolWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by UserId");
if (arrQxUsers_SchoolObjLst_Cache == null)
{
arrQxUsers_SchoolObjLst_Cache = clsQxUsers_SchoolWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsers_SchoolEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUsers_SchoolObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUsers_SchoolEN objQxUsers_SchoolEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUsers_SchoolEN = arrQxUsers_SchoolObjLst_Cache[intMid];
if (objQxUsers_SchoolEN.UserId == strUserId)
{
intFindFailCount = 0;
return objQxUsers_SchoolEN;
}
else if (objQxUsers_SchoolEN.UserId.CompareTo(strUserId) > 0)
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
arrQxUsers_SchoolObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserId_Cache(strUserId);
string strErrMsgForGetObjById = string.Format("在QxUsers_School对象缓存列表中,找不到记录[UserId = {0}][intFindFailCount = {1}](函数:{2})", strUserId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUsers_SchoolEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUsers_SchoolEN.UserId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUsers_SchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers_SchoolEN> GetObjLst(string strWhereCond)
{
 List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
objQxUsers_SchoolEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow["CardNo"].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objQxUsers_SchoolEN.id_GradeBase = objRow["id_GradeBase"].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.Card_State = objRow["Card_State"].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeaved"].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUsers_SchoolEN);
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
public static List<clsQxUsers_SchoolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUsers_SchoolEN> arrObjLst = new List<clsQxUsers_SchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers_SchoolEN objQxUsers_SchoolEN = new clsQxUsers_SchoolEN();
objQxUsers_SchoolEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUsers_SchoolEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objQxUsers_SchoolEN.CardNo = objRow["CardNo"].ToString().Trim(); //卡号
objQxUsers_SchoolEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objQxUsers_SchoolEN.id_GradeBase = objRow["id_GradeBase"].ToString().Trim(); //年级流水号
objQxUsers_SchoolEN.Card_State = objRow["Card_State"].ToString().Trim(); //卡状态
objQxUsers_SchoolEN.IsLeaved = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeaved"].ToString().Trim()); //IsLeaved
objQxUsers_SchoolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUsers_SchoolEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxUsers_SchoolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUsers_SchoolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strUserId)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
int intResult = objQxUsers_SchoolService.QxUsers_School_DelRecord(strUserId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_DelRecord", "clsQxUsers_SchoolWS:DelRecordWs", objException.Message);
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
public static int DelQxUsers_SchoolsWs(List<string> arrUserId)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrUserId);
int intResult = objQxUsers_SchoolService.QxUsers_School_DelQxUsers_Schools(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_DelQxUsers_Schools", "clsQxUsers_SchoolWS:DelQxUsers_SchoolsWs", objException.Message);
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
public static int DelQxUsers_SchoolsByCondWs(string strWhereCond)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
int intRecNum = objQxUsers_SchoolService.QxUsers_School_DelQxUsers_SchoolsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_DelQxUsers_SchoolsByCond", "clsQxUsers_SchoolWS:DelQxUsers_SchoolsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
bool bolResult = objQxUsers_SchoolService.QxUsers_School_AddNewRecordBySql2(objQxUsers_SchoolEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_AddNewRecordBySql2", "clsQxUsers_SchoolWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUsers_SchoolEN objQxUsers_SchoolEN)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
bool bolResult = objQxUsers_SchoolService.QxUsers_School_UpdateBySql2(objQxUsers_SchoolEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_UpdateBySql2", "clsQxUsers_SchoolWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUsers_SchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUsers_SchoolEN objQxUsers_SchoolEN, string strWhereCond)
{
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
try
{
bool bolResult = objQxUsers_SchoolService.QxUsers_School_UpdateBySqlWithCondition(objQxUsers_SchoolEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_School_UpdateBySqlWithCondition", "clsQxUsers_SchoolWS:UpdateBySqlWithCondition", objException.Message);
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
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
bool bolIsExist = objQxUsers_SchoolService.QxUsers_School_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strUserId)
{
//检测记录是否存在
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
bool bolIsExist = objQxUsers_SchoolService.QxUsers_School_IsExist(strUserId);
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
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
int intRecCount = objQxUsers_SchoolService.QxUsers_School_funGetRecCountByCond(strWhereCond);
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
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
string strMaxUserId = objQxUsers_SchoolService.QxUsers_School_GetMaxStrId();
return strMaxUserId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxUsers_SchoolServiceSoapClient objQxUsers_SchoolService = GetQxUsers_SchoolServiceSoapClient();
string strMaxUserId = objQxUsers_SchoolService.QxUsers_School_GetMaxStrIdByPrefix(strPrefix);
return strMaxUserId;
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