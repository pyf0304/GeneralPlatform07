
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRolesWS
 表名:QxUserRoles(00140014)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:02:55
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
using GeneralPlatform4WS.ServiceReferenceQxUserRoles;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_GeneEnumConstList)
 /// </summary>
public class enumQxUserRolesWS
{
 /// <summary>
 /// 统一平台总管理员
 /// </summary>
public const string _00010001 = "00010001";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string _00010002 = "00010002";
 /// <summary>
 /// 高级用户
 /// </summary>
public const string _00010003 = "00010003";
 /// <summary>
 /// 普通用户
 /// </summary>
public const string _00010004 = "00010004";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _00620001 = "00620001";
 /// <summary>
 /// 普通教师
 /// </summary>
public const string _00620002 = "00620002";
 /// <summary>
 /// 普通学生
 /// </summary>
public const string _00620003 = "00620003";
 /// <summary>
 /// 小组长(微格)
 /// </summary>
public const string _00620005 = "00620005";
 /// <summary>
 /// 中小学实习指导老师
 /// </summary>
public const string _00620006 = "00620006";
 /// <summary>
 /// 学工办辅导员
 /// </summary>
public const string _00620007 = "00620007";
 /// <summary>
 /// 实习指导老师
 /// </summary>
public const string _00620008 = "00620008";
 /// <summary>
 /// 指导老师（微格）
 /// </summary>
public const string _00620009 = "00620009";
 /// <summary>
 /// 评审专家
 /// </summary>
public const string _00620010 = "00620010";
 /// <summary>
 /// 教务处
 /// </summary>
public const string _00620011 = "00620011";
 /// <summary>
 /// 案例维护
 /// </summary>
public const string _00620012 = "00620012";
 /// <summary>
 /// 中小学教师
 /// </summary>
public const string _00620013 = "00620013";
 /// <summary>
 /// 教师(交建)
 /// </summary>
public const string _00620014 = "00620014";
 /// <summary>
 /// 交建答题学生
 /// </summary>
public const string _00620015 = "00620015";
 /// <summary>
 /// 语音学生
 /// </summary>
public const string _00620016 = "00620016";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _01030001 = "01030001";
}
 /// <summary>
 /// 角色(QxUserRoles)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRolesWS
{
private static string mstrPageName = "QxUserRolesService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxUserRolesEN> arrQxUserRolesObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxUserRolesServiceSoapClient objQxUserRolesServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxUserRolesServiceSoapClient GetQxUserRolesServiceSoapClient()
{
if (objQxUserRolesServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxUserRolesServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxUserRolesServiceSoapClient(binding, address);
}
else
{
return objQxUserRolesServiceSoapClient;
}
}

 public clsQxUserRolesWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxUserRolesEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxUserRolesEN objQxUserRolesEN = new clsQxUserRolesEN();
objQxUserRolesEN.RoleId = "0";
objQxUserRolesEN.RoleName = "请选择[角色]...";
arrObjLst.Insert(0, objQxUserRolesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="RoleId";
objComboBox.DisplayMember="RoleName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[角色]...","0");
List<clsQxUserRolesEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="RoleId";
objDDL.DataTextField="RoleName";
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
public static int BindLv_QxUserRoles(System.Windows.Forms.ListView lvQxUserRoles, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxUserRoles; 
List<clsQxUserRolesEN> arrQxUserRolesObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxUserRolesObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxUserRoles.Items.Clear();//清除原来所有Item
lvQxUserRoles.Columns.Clear();//清除原来所有列头信息
lvQxUserRoles.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("角色英文名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("角色序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("是否在使用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxUserRoles.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserRolesEN objQxUserRolesEN in arrQxUserRolesObjLst)
{
lviQxUserRoles = new System.Windows.Forms.ListViewItem();
lviQxUserRoles.Tag = objQxUserRolesEN.RoleId;
lviQxUserRoles.Text = objQxUserRolesEN.RoleId.ToString();
lviQxUserRoles.SubItems.Add(objQxUserRolesEN.RoleName);
lviQxUserRoles.SubItems.Add(objQxUserRolesEN.RoleENName);
lviQxUserRoles.SubItems.Add(objQxUserRolesEN.RoleIndex.ToString());
lviQxUserRoles.SubItems.Add(objQxUserRolesEN.IsInUse.ToString());
lviQxUserRoles.SubItems.Add(objQxUserRolesEN.UpdDate);
lviQxUserRoles.SubItems.Add(objQxUserRolesEN.UpdUserId);
lviQxUserRoles.SubItems.Add(objQxUserRolesEN.Memo);
lvQxUserRoles.Items.Add(lviQxUserRoles);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxUserRolesObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxUserRolesEN objQxUserRolesEN)
{
if (!Object.Equals(null, objQxUserRolesEN.RoleId) && GetStrLen(objQxUserRolesEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxUserRolesEN.RoleName) && GetStrLen(objQxUserRolesEN.RoleName) > 50)
{
 throw new Exception("字段[角色名称]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUserRolesEN.RoleENName) && GetStrLen(objQxUserRolesEN.RoleENName) > 50)
{
 throw new Exception("字段[角色英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxUserRolesEN.QxPrjId) && GetStrLen(objQxUserRolesEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxUserRolesEN.UpdDate) && GetStrLen(objQxUserRolesEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxUserRolesEN.UpdUserId) && GetStrLen(objQxUserRolesEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxUserRolesEN.Memo) && GetStrLen(objQxUserRolesEN.Memo) > 1000)
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
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRolesService.QxUserRoles_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_GetDataSet", "clsQxUserRolesWS:GetDataTableWs", objException.Message);
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
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRolesService.QxUserRoles_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_GetTopDataSet", "clsQxUserRolesWS:GetDataTable_TopWs", objException.Message);
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
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRolesService.QxUserRoles_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_GetDataSetByRange", "clsQxUserRolesWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRolesService.QxUserRoles_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_GetDataSetV", "clsQxUserRolesWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxUserRolesVWs(string strWhereCond)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxUserRolesService.QxUserRoles_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_GetDataSetV", "clsQxUserRolesWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxUserRolesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxUserRolesWs(ref clsQxUserRolesEN objQxUserRolesEN)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
bool bolResult = objQxUserRolesService.QxUserRoles_GetQxUserRoles(ref objQxUserRolesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxUserRolesEN GetObjByRoleIdWs(string strRoleId)
{
strRoleId = strRoleId.Replace("'", "");
strRoleId = strRoleId.Replace(" ", "");
strRoleId = strRoleId.Replace("(", "");
strRoleId = strRoleId.Replace(")", "");
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
clsQxUserRolesEN objQxUserRolesEN = objQxUserRolesService.QxUserRoles_GetObjByRoleId(strRoleId);
return objQxUserRolesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
string strRoleId = objQxUserRolesService.QxUserRoles_GetFirstID_S(strWhereCond);
return strRoleId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_GetFirstID_S", "clsQxUserRolesWS:GetFirstID_S", objException.Message);
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
public static clsQxUserRolesEN GetFirstQxUserRoles_S(string strWhereCond)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
clsQxUserRolesEN objQxUserRolesEN = objQxUserRolesService.QxUserRoles_GetFirstObj_S(strWhereCond);
return objQxUserRolesEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_GetFirstObj_S", "clsQxUserRolesWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRoleNameByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserRolesObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserRolesEN objQxUserRolesEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserRolesEN = arrQxUserRolesObjLst_Cache[intMid];
if (objQxUserRolesEN.RoleId == strRoleId)
{
intFindFailCount = 0;
return objQxUserRolesEN.RoleName;
}
else if (objQxUserRolesEN.RoleId.CompareTo(strRoleId) > 0)
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
arrQxUserRolesObjLst_Cache = null;
if (intFindFailCount == 1) return GetRoleNameByRoleId_Cache(strRoleId);
string strErrMsgForGetObjById = string.Format("在QxUserRoles对象缓存列表中,找不到记录[RoleId = {0}][intFindFailCount = {1}](函数:{2})", strRoleId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserRolesEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserRolesEN.RoleId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by RoleId");
if (arrQxUserRolesObjLst_Cache == null)
{
arrQxUserRolesObjLst_Cache = clsQxUserRolesWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxUserRolesEN GetObjByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxUserRolesObjLst_Cache.Count - 1;
int intMid = 0;
clsQxUserRolesEN objQxUserRolesEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxUserRolesEN = arrQxUserRolesObjLst_Cache[intMid];
if (objQxUserRolesEN.RoleId == strRoleId)
{
intFindFailCount = 0;
return objQxUserRolesEN;
}
else if (objQxUserRolesEN.RoleId.CompareTo(strRoleId) > 0)
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
arrQxUserRolesObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByRoleId_Cache(strRoleId);
string strErrMsgForGetObjById = string.Format("在QxUserRoles对象缓存列表中,找不到记录[RoleId = {0}][intFindFailCount = {1}](函数:{2})", strRoleId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxUserRolesEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxUserRolesEN.RoleId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxUserRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxUserRolesEN> GetObjLst(string strWhereCond)
{
 List<clsQxUserRolesEN> arrObjLst = new List<clsQxUserRolesEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRolesEN objQxUserRolesEN = new clsQxUserRolesEN();
objQxUserRolesEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objQxUserRolesEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objQxUserRolesEN.RoleENName = objRow["RoleENName"].ToString().Trim(); //角色英文名
objQxUserRolesEN.RoleIndex = Int32.Parse(objRow["RoleIndex"].ToString().Trim()); //角色序号
objQxUserRolesEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserRolesEN.IsInUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsInUse"].ToString().Trim()); //是否在使用
objQxUserRolesEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserRolesEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserRolesEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserRolesEN);
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
public static List<clsQxUserRolesEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxUserRolesEN> arrObjLst = new List<clsQxUserRolesEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserRolesEN objQxUserRolesEN = new clsQxUserRolesEN();
objQxUserRolesEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objQxUserRolesEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objQxUserRolesEN.RoleENName = objRow["RoleENName"].ToString().Trim(); //角色英文名
objQxUserRolesEN.RoleIndex = Int32.Parse(objRow["RoleIndex"].ToString().Trim()); //角色序号
objQxUserRolesEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxUserRolesEN.IsInUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsInUse"].ToString().Trim()); //是否在使用
objQxUserRolesEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxUserRolesEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxUserRolesEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxUserRolesEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strRoleId)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
int intResult = objQxUserRolesService.QxUserRoles_DelRecord(strRoleId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_DelRecord", "clsQxUserRolesWS:DelRecordWs", objException.Message);
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
public static int DelQxUserRolessWs(List<string> arrRoleId)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrRoleId);
int intResult = objQxUserRolesService.QxUserRoles_DelQxUserRoless(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_DelQxUserRoless", "clsQxUserRolesWS:DelQxUserRolessWs", objException.Message);
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
public static int DelQxUserRolessByCondWs(string strWhereCond)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
int intRecNum = objQxUserRolesService.QxUserRoles_DelQxUserRolessByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_DelQxUserRolessByCond", "clsQxUserRolesWS:DelQxUserRolessByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxUserRolesEN objQxUserRolesEN)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
bool bolResult = objQxUserRolesService.QxUserRoles_AddNewRecordBySql2(objQxUserRolesEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_AddNewRecordBySql2", "clsQxUserRolesWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxUserRolesEN objQxUserRolesEN)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
bool bolResult = objQxUserRolesService.QxUserRoles_UpdateBySql2(objQxUserRolesEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_UpdateBySql2", "clsQxUserRolesWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxUserRolesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxUserRolesEN objQxUserRolesEN, string strWhereCond)
{
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
try
{
bool bolResult = objQxUserRolesService.QxUserRoles_UpdateBySqlWithCondition(objQxUserRolesEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxUserRoles_UpdateBySqlWithCondition", "clsQxUserRolesWS:UpdateBySqlWithCondition", objException.Message);
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
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
bool bolIsExist = objQxUserRolesService.QxUserRoles_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strRoleId)
{
//检测记录是否存在
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
bool bolIsExist = objQxUserRolesService.QxUserRoles_IsExist(strRoleId);
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
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
int intRecCount = objQxUserRolesService.QxUserRoles_funGetRecCountByCond(strWhereCond);
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
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
string strMaxRoleId = objQxUserRolesService.QxUserRoles_GetMaxStrId();
return strMaxRoleId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxUserRolesServiceSoapClient objQxUserRolesService = GetQxUserRolesServiceSoapClient();
string strMaxRoleId = objQxUserRolesService.QxUserRoles_GetMaxStrIdByPrefix(strPrefix);
return strMaxRoleId;
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