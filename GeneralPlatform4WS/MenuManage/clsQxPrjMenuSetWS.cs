
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenuSetWS
 表名:QxPrjMenuSet(00140045)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:06
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:菜单管理
 模块英文名:MenuManage
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
using GeneralPlatform4WS.ServiceReferenceQxPrjMenuSet;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_GeneEnumConstList)
 /// </summary>
public class enumQxPrjMenuSetWS
{
 /// <summary>
 /// 课程学习
 /// </summary>
public const string CourseLearn_0024 = "0024";
 /// <summary>
 /// 后台总菜单
 /// </summary>
public const string BackgroundMenu_0001 = "0001";
 /// <summary>
 /// 学生微格维护子菜单
 /// </summary>
public const string StuMicroteachMaintenance_0002 = "0002";
 /// <summary>
 /// 书法教学评议
 /// </summary>
public const string WritingOnBB_0003 = "0003";
 /// <summary>
 /// 普通话教学评议
 /// </summary>
public const string Mandarin_0004 = "0004";
 /// <summary>
 /// 微格教学评议
 /// </summary>
public const string MicroTeach_0005 = "0005";
 /// <summary>
 /// 技能示范与评议
 /// </summary>
public const string SkillDemo_0006 = "0006";
 /// <summary>
 /// 课例点播与评议
 /// </summary>
public const string PubicClassSenate_0007 = "0007";
 /// <summary>
 /// 青教评优教学评议
 /// </summary>
public const string YoungTAppraised_0008 = "0008";
 /// <summary>
 /// 职后微格课例添加
 /// </summary>
public const string PostMicroTeachAdd_0009 = "0009";
 /// <summary>
 /// 职后微格教学评议扩展
 /// </summary>
public const string PostMicroTeachSenate_0010 = "0010";
 /// <summary>
 /// 学生微格维护
 /// </summary>
public const string StuMicroTeach_0011 = "0011";
 /// <summary>
 /// 学生板书案例维护
 /// </summary>
public const string StuWritingOnBB_0012 = "0012";
 /// <summary>
 /// 学生普通话案例维护
 /// </summary>
public const string StuMandarin_0013 = "0013";
 /// <summary>
 /// 后台案例维护
 /// </summary>
public const string BackgroundCaseMaintenance_0014 = "0014";
 /// <summary>
 /// 课件点播与评议
 /// </summary>
public const string Courseware_0015 = "0015";
 /// <summary>
 /// 课堂教学点播与评议
 /// </summary>
public const string ClsRmTeaching_0016 = "0016";
 /// <summary>
 /// 后台总菜单
 /// </summary>
public const string BackgroundMenu_0017 = "0017";
 /// <summary>
 /// 硕士优课评议
 /// </summary>
public const string EduMSTRGiftedCls_0023 = "0023";
}
 /// <summary>
 /// 菜单集(QxPrjMenuSet)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjMenuSetWS
{
private static string mstrPageName = "QxPrjMenuSetService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPrjMenuSetServiceSoapClient objQxPrjMenuSetServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPrjMenuSetServiceSoapClient GetQxPrjMenuSetServiceSoapClient()
{
if (objQxPrjMenuSetServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPrjMenuSetServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPrjMenuSetServiceSoapClient(binding, address);
}
else
{
return objQxPrjMenuSetServiceSoapClient;
}
}

 public clsQxPrjMenuSetWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_MenuSetId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxPrjMenuSetEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
objQxPrjMenuSetEN.MenuSetId = "0";
objQxPrjMenuSetEN.MenuSetName = "请选择[菜单集]...";
arrObjLst.Insert(0, objQxPrjMenuSetEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="MenuSetId";
objComboBox.DisplayMember="MenuSetName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MenuSetId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[菜单集]...","0");
List<clsQxPrjMenuSetEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="MenuSetId";
objDDL.DataTextField="MenuSetName";
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
public static int BindLv_QxPrjMenuSet(System.Windows.Forms.ListView lvQxPrjMenuSet, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPrjMenuSet; 
List<clsQxPrjMenuSetEN> arrQxPrjMenuSetObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPrjMenuSetObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPrjMenuSet.Items.Clear();//清除原来所有Item
lvQxPrjMenuSet.Columns.Clear();//清除原来所有列头信息
lvQxPrjMenuSet.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.Columns.Add("菜单集名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.Columns.Add("菜单集英文名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.Columns.Add("是否默认", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.Columns.Add("修改用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjMenuSet.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjMenuSetEN objQxPrjMenuSetEN in arrQxPrjMenuSetObjLst)
{
lviQxPrjMenuSet = new System.Windows.Forms.ListViewItem();
lviQxPrjMenuSet.Tag = objQxPrjMenuSetEN.MenuSetId;
lviQxPrjMenuSet.Text = objQxPrjMenuSetEN.MenuSetId.ToString();
lviQxPrjMenuSet.SubItems.Add(objQxPrjMenuSetEN.MenuSetName);
lviQxPrjMenuSet.SubItems.Add(objQxPrjMenuSetEN.MenuSetENName);
lviQxPrjMenuSet.SubItems.Add(objQxPrjMenuSetEN.QxPrjId);
lviQxPrjMenuSet.SubItems.Add(objQxPrjMenuSetEN.IsDefault.ToString());
lviQxPrjMenuSet.SubItems.Add(objQxPrjMenuSetEN.UpdDate);
lviQxPrjMenuSet.SubItems.Add(objQxPrjMenuSetEN.UpdUser);
lviQxPrjMenuSet.SubItems.Add(objQxPrjMenuSetEN.Memo);
lvQxPrjMenuSet.Items.Add(lviQxPrjMenuSet);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPrjMenuSetObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
if (!Object.Equals(null, objQxPrjMenuSetEN.MenuSetId) && GetStrLen(objQxPrjMenuSetEN.MenuSetId) > 4)
{
 throw new Exception("字段[菜单集Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.MenuSetName) && GetStrLen(objQxPrjMenuSetEN.MenuSetName) > 50)
{
 throw new Exception("字段[菜单集名称]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.MenuSetENName) && GetStrLen(objQxPrjMenuSetEN.MenuSetENName) > 50)
{
 throw new Exception("字段[菜单集英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.QxPrjId) && GetStrLen(objQxPrjMenuSetEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.UpdDate) && GetStrLen(objQxPrjMenuSetEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.UpdUser) && GetStrLen(objQxPrjMenuSetEN.UpdUser) > 18)
{
 throw new Exception("字段[修改用户]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjMenuSetEN.Memo) && GetStrLen(objQxPrjMenuSetEN.Memo) > 1000)
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
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenuSetService.QxPrjMenuSet_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetDataSet", "clsQxPrjMenuSetWS:GetDataTableWs", objException.Message);
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
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenuSetService.QxPrjMenuSet_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetTopDataSet", "clsQxPrjMenuSetWS:GetDataTable_TopWs", objException.Message);
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
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenuSetService.QxPrjMenuSet_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetDataSetByRange", "clsQxPrjMenuSetWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenuSetService.QxPrjMenuSet_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetDataSetV", "clsQxPrjMenuSetWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPrjMenuSetVWs(string strWhereCond)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjMenuSetService.QxPrjMenuSet_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetDataSetV", "clsQxPrjMenuSetWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjMenuSetWs(ref clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
bool bolResult = objQxPrjMenuSetService.QxPrjMenuSet_GetQxPrjMenuSet(ref objQxPrjMenuSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMenuSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjMenuSetEN GetObjByMenuSetIdWs(string strMenuSetId)
{
strMenuSetId = strMenuSetId.Replace("'", "");
strMenuSetId = strMenuSetId.Replace(" ", "");
strMenuSetId = strMenuSetId.Replace("(", "");
strMenuSetId = strMenuSetId.Replace(")", "");
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
clsQxPrjMenuSetEN objQxPrjMenuSetEN = objQxPrjMenuSetService.QxPrjMenuSet_GetObjByMenuSetId(strMenuSetId);
return objQxPrjMenuSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
string strMenuSetId = objQxPrjMenuSetService.QxPrjMenuSet_GetFirstID_S(strWhereCond);
return strMenuSetId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetFirstID_S", "clsQxPrjMenuSetWS:GetFirstID_S", objException.Message);
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
public static clsQxPrjMenuSetEN GetFirstQxPrjMenuSet_S(string strWhereCond)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
clsQxPrjMenuSetEN objQxPrjMenuSetEN = objQxPrjMenuSetService.QxPrjMenuSet_GetFirstObj_S(strWhereCond);
return objQxPrjMenuSetEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetFirstObj_S", "clsQxPrjMenuSetWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMenuSetNameByMenuSetId_Cache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjMenuSetObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjMenuSetEN objQxPrjMenuSetEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjMenuSetEN = arrQxPrjMenuSetObjLst_Cache[intMid];
if (objQxPrjMenuSetEN.MenuSetId == strMenuSetId)
{
intFindFailCount = 0;
return objQxPrjMenuSetEN.MenuSetName;
}
else if (objQxPrjMenuSetEN.MenuSetId.CompareTo(strMenuSetId) > 0)
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
arrQxPrjMenuSetObjLst_Cache = null;
if (intFindFailCount == 1) return GetMenuSetNameByMenuSetId_Cache(strMenuSetId);
string strErrMsgForGetObjById = string.Format("在QxPrjMenuSet对象缓存列表中,找不到记录[MenuSetId = {0}][intFindFailCount = {1}](函数:{2})", strMenuSetId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjMenuSetEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjMenuSetEN.MenuSetId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjMenuSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by MenuSetId");
if (arrQxPrjMenuSetObjLst_Cache == null)
{
arrQxPrjMenuSetObjLst_Cache = clsQxPrjMenuSetWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strMenuSetId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjMenuSetEN GetObjByMenuSetId_Cache(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjMenuSetObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjMenuSetEN objQxPrjMenuSetEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjMenuSetEN = arrQxPrjMenuSetObjLst_Cache[intMid];
if (objQxPrjMenuSetEN.MenuSetId == strMenuSetId)
{
intFindFailCount = 0;
return objQxPrjMenuSetEN;
}
else if (objQxPrjMenuSetEN.MenuSetId.CompareTo(strMenuSetId) > 0)
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
arrQxPrjMenuSetObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByMenuSetId_Cache(strMenuSetId);
string strErrMsgForGetObjById = string.Format("在QxPrjMenuSet对象缓存列表中,找不到记录[MenuSetId = {0}][intFindFailCount = {1}](函数:{2})", strMenuSetId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjMenuSetEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjMenuSetEN.MenuSetId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjMenuSetBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjMenuSetEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
objQxPrjMenuSetEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow["MenuSetENName"].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.IsDefault = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefault"].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjMenuSetEN);
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
public static List<clsQxPrjMenuSetEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPrjMenuSetEN> arrObjLst = new List<clsQxPrjMenuSetEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjMenuSetEN objQxPrjMenuSetEN = new clsQxPrjMenuSetEN();
objQxPrjMenuSetEN.MenuSetId = objRow["MenuSetId"].ToString().Trim(); //菜单集Id
objQxPrjMenuSetEN.MenuSetName = objRow["MenuSetName"].ToString().Trim(); //菜单集名称
objQxPrjMenuSetEN.MenuSetENName = objRow["MenuSetENName"].ToString().Trim(); //菜单集英文名
objQxPrjMenuSetEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjMenuSetEN.IsDefault = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsDefault"].ToString().Trim()); //是否默认
objQxPrjMenuSetEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjMenuSetEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objQxPrjMenuSetEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjMenuSetEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strMenuSetId)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
int intResult = objQxPrjMenuSetService.QxPrjMenuSet_DelRecord(strMenuSetId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_DelRecord", "clsQxPrjMenuSetWS:DelRecordWs", objException.Message);
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
public static int DelQxPrjMenuSetsWs(List<string> arrMenuSetId)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrMenuSetId);
int intResult = objQxPrjMenuSetService.QxPrjMenuSet_DelQxPrjMenuSets(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_DelQxPrjMenuSets", "clsQxPrjMenuSetWS:DelQxPrjMenuSetsWs", objException.Message);
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
public static int DelQxPrjMenuSetsByCondWs(string strWhereCond)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
int intRecNum = objQxPrjMenuSetService.QxPrjMenuSet_DelQxPrjMenuSetsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_DelQxPrjMenuSetsByCond", "clsQxPrjMenuSetWS:DelQxPrjMenuSetsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
bool bolResult = objQxPrjMenuSetService.QxPrjMenuSet_AddNewRecordBySql2(objQxPrjMenuSetEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_AddNewRecordBySql2", "clsQxPrjMenuSetWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxPrjMenuSetEN objQxPrjMenuSetEN)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
bool bolResult = objQxPrjMenuSetService.QxPrjMenuSet_UpdateBySql2(objQxPrjMenuSetEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_UpdateBySql2", "clsQxPrjMenuSetWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPrjMenuSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPrjMenuSetEN objQxPrjMenuSetEN, string strWhereCond)
{
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
try
{
bool bolResult = objQxPrjMenuSetService.QxPrjMenuSet_UpdateBySqlWithCondition(objQxPrjMenuSetEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_UpdateBySqlWithCondition", "clsQxPrjMenuSetWS:UpdateBySqlWithCondition", objException.Message);
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
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
bool bolIsExist = objQxPrjMenuSetService.QxPrjMenuSet_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strMenuSetId)
{
//检测记录是否存在
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
bool bolIsExist = objQxPrjMenuSetService.QxPrjMenuSet_IsExist(strMenuSetId);
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
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
int intRecCount = objQxPrjMenuSetService.QxPrjMenuSet_funGetRecCountByCond(strWhereCond);
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
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
string strMaxMenuSetId = objQxPrjMenuSetService.QxPrjMenuSet_GetMaxStrId();
return strMaxMenuSetId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
string strMaxMenuSetId = objQxPrjMenuSetService.QxPrjMenuSet_GetMaxStrIdByPrefix(strPrefix);
return strMaxMenuSetId;
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