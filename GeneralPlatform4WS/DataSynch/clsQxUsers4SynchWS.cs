
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers4SynchWS
 表名:QxUsers4Synch(00140089)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:25
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
using GeneralPlatform4WS.ServiceReferenceQxUsers4Synch;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户4同步(QxUsers4Synch)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUsers4SynchWS
{
private static string mstrPageName = "QxUsers4SynchService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUsers4SynchEN> arrQxUsers4SynchObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUsers4SynchServiceSoapClient objQxUsers4SynchServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUsers4SynchServiceSoapClient GetQxUsers4SynchServiceSoapClient()
{
if (objQxUsers4SynchServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUsers4SynchServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUsers4SynchServiceSoapClient(binding, address);
}
else
{
return objQxUsers4SynchServiceSoapClient;
}
}

 public clsQxUsers4SynchWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUsers4Synch(System.Windows.Forms.ListView lvQxUsers4Synch, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUsers4Synch; 
List<clsQxUsers4SynchEN> arrQxUsers4SynchObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUsers4SynchObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUsers4Synch.Items.Clear();//清除原来所有Item
lvQxUsers4Synch.Columns.Clear();//清除原来所有列头信息
lvQxUsers4Synch.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("微信openid", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("学工号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("电话号码", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("学院流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("有效日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("有效开始日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("有效结束日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("邮箱", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("是否存档", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("修改用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers4Synch.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUsers4SynchEN objQxUsers4SynchEN in arrQxUsers4SynchObjLst)
{
lviQxUsers4Synch = new System.Windows.Forms.ListViewItem();
lviQxUsers4Synch.Tag = objQxUsers4SynchEN.mId;
lviQxUsers4Synch.Text = objQxUsers4SynchEN.mId.ToString();
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.IpAddress);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.UserId);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.UserName);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.UserStateId);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.openid);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.IdentityID);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.StuTeacherId);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.Password);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.PhoneNumber);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.DepartmentId);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.id_College);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.EffectiveDate);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.EffitiveBeginDate);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.EffitiveEndDate);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.Email);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.IsArchive.ToString());
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.UpdDate);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.UpdUser);
lviQxUsers4Synch.SubItems.Add(objQxUsers4SynchEN.Memo);
lvQxUsers4Synch.Items.Add(lviQxUsers4Synch);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUsers4SynchObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
if (!Object.Equals(null, objQxUsers4SynchEN.IpAddress) && GetStrLen(objQxUsers4SynchEN.IpAddress) > 23)
{
 throw new Exception("字段[IP地址]的长度不能超过23!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UserId) && GetStrLen(objQxUsers4SynchEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UserName) && GetStrLen(objQxUsers4SynchEN.UserName) > 30)
{
 throw new Exception("字段[用户名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UserStateId) && GetStrLen(objQxUsers4SynchEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.openid) && GetStrLen(objQxUsers4SynchEN.openid) > 50)
{
 throw new Exception("字段[微信openid]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.IdentityID) && GetStrLen(objQxUsers4SynchEN.IdentityID) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.StuTeacherId) && GetStrLen(objQxUsers4SynchEN.StuTeacherId) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.Password) && GetStrLen(objQxUsers4SynchEN.Password) > 20)
{
 throw new Exception("字段[口令]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.PhoneNumber) && GetStrLen(objQxUsers4SynchEN.PhoneNumber) > 15)
{
 throw new Exception("字段[电话号码]的长度不能超过15!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.DepartmentId) && GetStrLen(objQxUsers4SynchEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.id_College) && GetStrLen(objQxUsers4SynchEN.id_College) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.EffectiveDate) && GetStrLen(objQxUsers4SynchEN.EffectiveDate) > 8)
{
 throw new Exception("字段[有效日期]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.EffitiveBeginDate) && GetStrLen(objQxUsers4SynchEN.EffitiveBeginDate) > 14)
{
 throw new Exception("字段[有效开始日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.EffitiveEndDate) && GetStrLen(objQxUsers4SynchEN.EffitiveEndDate) > 14)
{
 throw new Exception("字段[有效结束日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.Email) && GetStrLen(objQxUsers4SynchEN.Email) > 100)
{
 throw new Exception("字段[邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UpdDate) && GetStrLen(objQxUsers4SynchEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.UpdUser) && GetStrLen(objQxUsers4SynchEN.UpdUser) > 18)
{
 throw new Exception("字段[修改用户]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsers4SynchEN.Memo) && GetStrLen(objQxUsers4SynchEN.Memo) > 1000)
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
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers4SynchService.QxUsers4Synch_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_GetDataSet", "clsQxUsers4SynchWS:GetDataTableWs", objException.Message);
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
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers4SynchService.QxUsers4Synch_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_GetTopDataSet", "clsQxUsers4SynchWS:GetDataTable_TopWs", objException.Message);
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
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers4SynchService.QxUsers4Synch_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_GetDataSetByRange", "clsQxUsers4SynchWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers4SynchService.QxUsers4Synch_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_GetDataSetV", "clsQxUsers4SynchWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUsers4SynchVWs(string strWhereCond)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsers4SynchService.QxUsers4Synch_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_GetDataSetV", "clsQxUsers4SynchWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUsers4SynchWs(ref clsQxUsers4SynchEN objQxUsers4SynchEN)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
bool bolResult = objQxUsers4SynchService.QxUsers4Synch_GetQxUsers4Synch(ref objQxUsers4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsers4SynchEN GetObjBymIdWs(long lngmId)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
clsQxUsers4SynchEN objQxUsers4SynchEN = objQxUsers4SynchService.QxUsers4Synch_GetObjBymId(lngmId);
return objQxUsers4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
long lngmId = objQxUsers4SynchService.QxUsers4Synch_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_GetFirstID_S", "clsQxUsers4SynchWS:GetFirstID_S", objException.Message);
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
public static clsQxUsers4SynchEN GetFirstQxUsers4Synch_S(string strWhereCond)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
clsQxUsers4SynchEN objQxUsers4SynchEN = objQxUsers4SynchService.QxUsers4Synch_GetFirstObj_S(strWhereCond);
return objQxUsers4SynchEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_GetFirstObj_S", "clsQxUsers4SynchWS:GetFirstObj_S", objException.Message);
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
if (arrQxUsers4SynchObjLst_Cache == null)
{
arrQxUsers4SynchObjLst_Cache = clsQxUsers4SynchWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsers4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUsers4SynchObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUsers4SynchEN objQxUsers4SynchEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUsers4SynchEN = arrQxUsers4SynchObjLst_Cache[intMid];
if (objQxUsers4SynchEN.mId == lngmId)
{
intFindFailCount = 0;
return objQxUsers4SynchEN;
}
else if (objQxUsers4SynchEN.mId.CompareTo(lngmId) > 0)
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
arrQxUsers4SynchObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在QxUsers4Synch对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUsers4SynchEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUsers4SynchEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUsers4SynchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsers4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
objQxUsers4SynchEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.openid = objRow["openid"].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow["Password"].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow["PhoneNumber"].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objQxUsers4SynchEN.id_College = objRow["id_College"].ToString().Trim(); //学院流水号
objQxUsers4SynchEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objQxUsers4SynchEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow["Email"].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsArchive"].ToString().Trim()); //是否存档
objQxUsers4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUsers4SynchEN);
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
public static List<clsQxUsers4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUsers4SynchEN> arrObjLst = new List<clsQxUsers4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
objQxUsers4SynchEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objQxUsers4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxUsers4SynchEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUsers4SynchEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objQxUsers4SynchEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objQxUsers4SynchEN.openid = objRow["openid"].ToString().Trim(); //微信openid
objQxUsers4SynchEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objQxUsers4SynchEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objQxUsers4SynchEN.Password = objRow["Password"].ToString().Trim(); //口令
objQxUsers4SynchEN.PhoneNumber = objRow["PhoneNumber"].ToString().Trim(); //电话号码
objQxUsers4SynchEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objQxUsers4SynchEN.id_College = objRow["id_College"].ToString().Trim(); //学院流水号
objQxUsers4SynchEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objQxUsers4SynchEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objQxUsers4SynchEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objQxUsers4SynchEN.Email = objRow["Email"].ToString().Trim(); //邮箱
objQxUsers4SynchEN.IsArchive = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsArchive"].ToString().Trim()); //是否存档
objQxUsers4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUsers4SynchEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxUsers4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUsers4SynchEN);
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
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
int intResult = objQxUsers4SynchService.QxUsers4Synch_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_DelRecord", "clsQxUsers4SynchWS:DelRecordWs", objException.Message);
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
public static int DelQxUsers4SynchsWs(List<string> arrmId)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objQxUsers4SynchService.QxUsers4Synch_DelQxUsers4Synchs(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_DelQxUsers4Synchs", "clsQxUsers4SynchWS:DelQxUsers4SynchsWs", objException.Message);
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
public static int DelQxUsers4SynchsByCondWs(string strWhereCond)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
int intRecNum = objQxUsers4SynchService.QxUsers4Synch_DelQxUsers4SynchsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_DelQxUsers4SynchsByCond", "clsQxUsers4SynchWS:DelQxUsers4SynchsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
bool bolResult = objQxUsers4SynchService.QxUsers4Synch_AddNewRecordBySql2(objQxUsers4SynchEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_AddNewRecordBySql2", "clsQxUsers4SynchWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
string strKey = objQxUsers4SynchService.QxUsers4Synch_AddNewRecordBySql2WithReturnKey(objQxUsers4SynchEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_AddNewRecordBySql2WithReturnKey", "clsQxUsers4SynchWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUsers4SynchEN objQxUsers4SynchEN)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
bool bolResult = objQxUsers4SynchService.QxUsers4Synch_UpdateBySql2(objQxUsers4SynchEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_UpdateBySql2", "clsQxUsers4SynchWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUsers4SynchEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUsers4SynchEN objQxUsers4SynchEN, string strWhereCond)
{
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
try
{
bool bolResult = objQxUsers4SynchService.QxUsers4Synch_UpdateBySqlWithCondition(objQxUsers4SynchEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers4Synch_UpdateBySqlWithCondition", "clsQxUsers4SynchWS:UpdateBySqlWithCondition", objException.Message);
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
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
bool bolIsExist = objQxUsers4SynchService.QxUsers4Synch_IsExistRecord(strWhereCond);
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
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
bool bolIsExist = objQxUsers4SynchService.QxUsers4Synch_IsExist(lngmId);
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
QxUsers4SynchServiceSoapClient objQxUsers4SynchService = GetQxUsers4SynchServiceSoapClient();
int intRecCount = objQxUsers4SynchService.QxUsers4Synch_funGetRecCountByCond(strWhereCond);
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