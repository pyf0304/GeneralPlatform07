
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersWS
 表名:QxUsers(00140015)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:56
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
using GeneralPlatform4WS.ServiceReferenceQxUsers;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 用户(QxUsers)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUsersWS
{
private static string mstrPageName = "QxUsersService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUsersEN> arrQxUsersObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUsersServiceSoapClient objQxUsersServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUsersServiceSoapClient GetQxUsersServiceSoapClient()
{
if (objQxUsersServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUsersServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUsersServiceSoapClient(binding, address);
}
else
{
return objQxUsersServiceSoapClient;
}
}

 public clsQxUsersWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_UserId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxUsersEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
objQxUsersEN.UserId = "0";
objQxUsersEN.UserName = "请选择[用户]...";
arrObjLst.Insert(0, objQxUsersEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="UserId";
objComboBox.DisplayMember="UserName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[用户]...","0");
List<clsQxUsersEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="UserId";
objDDL.DataTextField="UserName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_QxUsers(System.Windows.Forms.ListView lvQxUsers, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUsers; 
List<clsQxUsersEN> arrQxUsersObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUsersObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUsers.Items.Clear();//清除原来所有Item
lvQxUsers.Columns.Clear();//清除原来所有列头信息
lvQxUsers.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("有效日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("学院流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("有效开始日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("有效结束日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("学工号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("是否存档", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("微信openid", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("邮箱", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("电话号码", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("是否同步", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("同步日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("修改用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUsers.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUsersEN objQxUsersEN in arrQxUsersObjLst)
{
lviQxUsers = new System.Windows.Forms.ListViewItem();
lviQxUsers.Tag = objQxUsersEN.UserId;
lviQxUsers.Text = objQxUsersEN.UserId.ToString();
lviQxUsers.SubItems.Add(objQxUsersEN.UserName);
lviQxUsers.SubItems.Add(objQxUsersEN.DepartmentId);
lviQxUsers.SubItems.Add(objQxUsersEN.EffectiveDate);
lviQxUsers.SubItems.Add(objQxUsersEN.Password);
lviQxUsers.SubItems.Add(objQxUsersEN.id_College);
lviQxUsers.SubItems.Add(objQxUsersEN.EffitiveBeginDate);
lviQxUsers.SubItems.Add(objQxUsersEN.EffitiveEndDate);
lviQxUsers.SubItems.Add(objQxUsersEN.StuTeacherId);
lviQxUsers.SubItems.Add(objQxUsersEN.IdentityID);
lviQxUsers.SubItems.Add(objQxUsersEN.IsArchive.ToString());
lviQxUsers.SubItems.Add(objQxUsersEN.openid);
lviQxUsers.SubItems.Add(objQxUsersEN.Email);
lviQxUsers.SubItems.Add(objQxUsersEN.PhoneNumber);
lviQxUsers.SubItems.Add(objQxUsersEN.IsSynch.ToString());
lviQxUsers.SubItems.Add(objQxUsersEN.SynchDate);
lviQxUsers.SubItems.Add(objQxUsersEN.UpdDate);
lviQxUsers.SubItems.Add(objQxUsersEN.UpdUser);
lviQxUsers.SubItems.Add(objQxUsersEN.Memo);
lvQxUsers.Items.Add(lviQxUsers);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUsersObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUsersEN objQxUsersEN)
{
if (!Object.Equals(null, objQxUsersEN.UserId) && GetStrLen(objQxUsersEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsersEN.UserName) && GetStrLen(objQxUsersEN.UserName) > 30)
{
 throw new Exception("字段[用户名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxUsersEN.DepartmentId) && GetStrLen(objQxUsersEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsersEN.UserStateId) && GetStrLen(objQxUsersEN.UserStateId) > 2)
{
 throw new Exception("字段[用户状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsersEN.EffectiveDate) && GetStrLen(objQxUsersEN.EffectiveDate) > 8)
{
 throw new Exception("字段[有效日期]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUsersEN.Password) && GetStrLen(objQxUsersEN.Password) > 20)
{
 throw new Exception("字段[口令]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.id_College) && GetStrLen(objQxUsersEN.id_College) > 4)
{
 throw new Exception("字段[学院流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUsersEN.EffitiveBeginDate) && GetStrLen(objQxUsersEN.EffitiveBeginDate) > 14)
{
 throw new Exception("字段[有效开始日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.EffitiveEndDate) && GetStrLen(objQxUsersEN.EffitiveEndDate) > 14)
{
 throw new Exception("字段[有效结束日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.StuTeacherId) && GetStrLen(objQxUsersEN.StuTeacherId) > 20)
{
 throw new Exception("字段[学工号]的长度不能超过20!");
}
if (!Object.Equals(null, objQxUsersEN.IdentityID) && GetStrLen(objQxUsersEN.IdentityID) > 2)
{
 throw new Exception("字段[身份编号]的长度不能超过2!");
}
if (!Object.Equals(null, objQxUsersEN.openid) && GetStrLen(objQxUsersEN.openid) > 50)
{
 throw new Exception("字段[微信openid]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUsersEN.Email) && GetStrLen(objQxUsersEN.Email) > 100)
{
 throw new Exception("字段[邮箱]的长度不能超过100!");
}
if (!Object.Equals(null, objQxUsersEN.PhoneNumber) && GetStrLen(objQxUsersEN.PhoneNumber) > 15)
{
 throw new Exception("字段[电话号码]的长度不能超过15!");
}
if (!Object.Equals(null, objQxUsersEN.SynchDate) && GetStrLen(objQxUsersEN.SynchDate) > 14)
{
 throw new Exception("字段[同步日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.UpdDate) && GetStrLen(objQxUsersEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUsersEN.UpdUser) && GetStrLen(objQxUsersEN.UpdUser) > 18)
{
 throw new Exception("字段[修改用户]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUsersEN.Memo) && GetStrLen(objQxUsersEN.Memo) > 1000)
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsersService.QxUsers_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_GetDataSet", "clsQxUsersWS:GetDataTableWs", objException.Message);
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsersService.QxUsers_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_GetTopDataSet", "clsQxUsersWS:GetDataTable_TopWs", objException.Message);
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsersService.QxUsers_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_GetDataSetByRange", "clsQxUsersWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsersService.QxUsers_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_GetDataSetV", "clsQxUsersWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUsersVWs(string strWhereCond)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUsersService.QxUsers_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_GetDataSetV", "clsQxUsersWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUsersWs(ref clsQxUsersEN objQxUsersEN)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
bool bolResult = objQxUsersService.QxUsers_GetQxUsers(ref objQxUsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUsersEN GetObjByUserIdWs(string strUserId)
{
strUserId = strUserId.Replace("'", "");
strUserId = strUserId.Replace(" ", "");
strUserId = strUserId.Replace("(", "");
strUserId = strUserId.Replace(")", "");
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
clsQxUsersEN objQxUsersEN = objQxUsersService.QxUsers_GetObjByUserId(strUserId);
return objQxUsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
string strUserId = objQxUsersService.QxUsers_GetFirstID_S(strWhereCond);
return strUserId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_GetFirstID_S", "clsQxUsersWS:GetFirstID_S", objException.Message);
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
public static clsQxUsersEN GetFirstQxUsers_S(string strWhereCond)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
clsQxUsersEN objQxUsersEN = objQxUsersService.QxUsers_GetFirstObj_S(strWhereCond);
return objQxUsersEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_GetFirstObj_S", "clsQxUsersWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserNameByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUsersObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUsersEN objQxUsersEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUsersEN = arrQxUsersObjLst_Cache[intMid];
if (objQxUsersEN.UserId == strUserId)
{
intFindFailCount = 0;
return objQxUsersEN.UserName;
}
else if (objQxUsersEN.UserId.CompareTo(strUserId) > 0)
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
arrQxUsersObjLst_Cache = null;
if (intFindFailCount == 1) return GetUserNameByUserId_Cache(strUserId);
string strErrMsgForGetObjById = string.Format("在QxUsers对象缓存列表中,找不到记录[UserId = {0}][intFindFailCount = {1}](函数:{2})", strUserId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUsersEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUsersEN.UserId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by UserId");
if (arrQxUsersObjLst_Cache == null)
{
arrQxUsersObjLst_Cache = clsQxUsersWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUsersEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUsersObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUsersEN objQxUsersEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUsersEN = arrQxUsersObjLst_Cache[intMid];
if (objQxUsersEN.UserId == strUserId)
{
intFindFailCount = 0;
return objQxUsersEN;
}
else if (objQxUsersEN.UserId.CompareTo(strUserId) > 0)
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
arrQxUsersObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserId_Cache(strUserId);
string strErrMsgForGetObjById = string.Format("在QxUsers对象缓存列表中,找不到记录[UserId = {0}][intFindFailCount = {1}](函数:{2})", strUserId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUsersEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUsersEN.UserId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUsersBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUsersEN> GetObjLst(string strWhereCond)
{
 List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
objQxUsersEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objQxUsersEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objQxUsersEN.Password = objRow["Password"].ToString().Trim(); //口令
objQxUsersEN.id_College = objRow["id_College"].ToString().Trim(); //学院流水号
objQxUsersEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objQxUsersEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsArchive"].ToString().Trim()); //是否存档
objQxUsersEN.openid = objRow["openid"].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow["Email"].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow["PhoneNumber"].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSynch"].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow["SynchDate"].ToString().Trim(); //同步日期
objQxUsersEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUsersEN);
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
public static List<clsQxUsersEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUsersEN> arrObjLst = new List<clsQxUsersEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUsersEN objQxUsersEN = new clsQxUsersEN();
objQxUsersEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxUsersEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objQxUsersEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objQxUsersEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objQxUsersEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objQxUsersEN.Password = objRow["Password"].ToString().Trim(); //口令
objQxUsersEN.id_College = objRow["id_College"].ToString().Trim(); //学院流水号
objQxUsersEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objQxUsersEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objQxUsersEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objQxUsersEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objQxUsersEN.IsArchive = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsArchive"].ToString().Trim()); //是否存档
objQxUsersEN.openid = objRow["openid"].ToString().Trim(); //微信openid
objQxUsersEN.Email = objRow["Email"].ToString().Trim(); //邮箱
objQxUsersEN.PhoneNumber = objRow["PhoneNumber"].ToString().Trim(); //电话号码
objQxUsersEN.IsSynch = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSynch"].ToString().Trim()); //是否同步
objQxUsersEN.SynchDate = objRow["SynchDate"].ToString().Trim(); //同步日期
objQxUsersEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUsersEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxUsersEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUsersEN);
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
int intResult = objQxUsersService.QxUsers_DelRecord(strUserId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_DelRecord", "clsQxUsersWS:DelRecordWs", objException.Message);
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
public static int DelQxUserssWs(List<string> arrUserId)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrUserId);
int intResult = objQxUsersService.QxUsers_DelQxUserss(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_DelQxUserss", "clsQxUsersWS:DelQxUserssWs", objException.Message);
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
public static int DelQxUserssByCondWs(string strWhereCond)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
int intRecNum = objQxUsersService.QxUsers_DelQxUserssByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_DelQxUserssByCond", "clsQxUsersWS:DelQxUserssByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUsersEN objQxUsersEN)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
bool bolResult = objQxUsersService.QxUsers_AddNewRecordBySql2(objQxUsersEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_AddNewRecordBySql2", "clsQxUsersWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUsersEN objQxUsersEN)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
bool bolResult = objQxUsersService.QxUsers_UpdateBySql2(objQxUsersEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_UpdateBySql2", "clsQxUsersWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUsersEN objQxUsersEN, string strWhereCond)
{
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
try
{
bool bolResult = objQxUsersService.QxUsers_UpdateBySqlWithCondition(objQxUsersEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUsers_UpdateBySqlWithCondition", "clsQxUsersWS:UpdateBySqlWithCondition", objException.Message);
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
bool bolIsExist = objQxUsersService.QxUsers_IsExistRecord(strWhereCond);
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
bool bolIsExist = objQxUsersService.QxUsers_IsExist(strUserId);
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
int intRecCount = objQxUsersService.QxUsers_funGetRecCountByCond(strWhereCond);
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
string strMaxUserId = objQxUsersService.QxUsers_GetMaxStrId();
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
QxUsersServiceSoapClient objQxUsersService = GetQxUsersServiceSoapClient();
string strMaxUserId = objQxUsersService.QxUsers_GetMaxStrIdByPrefix(strPrefix);
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