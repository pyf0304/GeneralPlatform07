
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesByPotenceNumWS
 表名:vQxUserRolesByPotenceNum(00140084)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:23
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
using GeneralPlatform4WS.ServiceReferencevQxUserRolesByPotenceNum;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v角色By权限数(vQxUserRolesByPotenceNum)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRolesByPotenceNumWS
{
private static string mstrPageName = "vQxUserRolesByPotenceNumService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUserRolesByPotenceNumServiceSoapClient GetvQxUserRolesByPotenceNumServiceSoapClient()
{
if (objvQxUserRolesByPotenceNumServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUserRolesByPotenceNumServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUserRolesByPotenceNumServiceSoapClient(binding, address);
}
else
{
return objvQxUserRolesByPotenceNumServiceSoapClient;
}
}

 public clsvQxUserRolesByPotenceNumWS()
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
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
objvQxUserRolesByPotenceNumEN.RoleId = "0";
objvQxUserRolesByPotenceNumEN.RoleName = "请选择[v角色By权限数]...";
arrObjLst.Insert(0, objvQxUserRolesByPotenceNumEN);
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v角色By权限数]...","0");
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = GetObjLst("1 = 1");
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
public static int BindLv_vQxUserRolesByPotenceNum(System.Windows.Forms.ListView lvvQxUserRolesByPotenceNum, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUserRolesByPotenceNum; 
List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUserRolesByPotenceNumObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUserRolesByPotenceNum.Items.Clear();//清除原来所有Item
lvvQxUserRolesByPotenceNum.Columns.Clear();//清除原来所有列头信息
lvvQxUserRolesByPotenceNum.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("角色名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("角色英文名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("角色序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("是否在使用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.Columns.Add("PotenceNum", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUserRolesByPotenceNum.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN in arrvQxUserRolesByPotenceNumObjLst)
{
lvivQxUserRolesByPotenceNum = new System.Windows.Forms.ListViewItem();
lvivQxUserRolesByPotenceNum.Tag = objvQxUserRolesByPotenceNumEN.RoleId;
lvivQxUserRolesByPotenceNum.Text = objvQxUserRolesByPotenceNumEN.RoleId.ToString();
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.RoleName);
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.RoleENName);
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.RoleIndex.ToString());
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.QxPrjId);
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.PrjName);
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.IsInUse.ToString());
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.UpdDate);
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.UpdUserId);
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.Memo);
lvivQxUserRolesByPotenceNum.SubItems.Add(objvQxUserRolesByPotenceNumEN.PotenceNum.ToString());
lvvQxUserRolesByPotenceNum.Items.Add(lvivQxUserRolesByPotenceNum);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUserRolesByPotenceNumObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRolesByPotenceNum_GetDataSet", "clsvQxUserRolesByPotenceNumWS:GetDataTableWs", objException.Message);
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
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRolesByPotenceNum_GetTopDataSet", "clsvQxUserRolesByPotenceNumWS:GetDataTable_TopWs", objException.Message);
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
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRolesByPotenceNum_GetDataSetByRange", "clsvQxUserRolesByPotenceNumWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRolesByPotenceNumWs(ref clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
bool bolResult = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_GetvQxUserRolesByPotenceNum(ref objvQxUserRolesByPotenceNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObjByRoleIdWs(string strRoleId)
{
strRoleId = strRoleId.Replace("'", "");
strRoleId = strRoleId.Replace(" ", "");
strRoleId = strRoleId.Replace("(", "");
strRoleId = strRoleId.Replace(")", "");
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_GetObjByRoleId(strRoleId);
return objvQxUserRolesByPotenceNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
try
{
string strRoleId = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_GetFirstID_S(strWhereCond);
return strRoleId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRolesByPotenceNum_GetFirstID_S", "clsvQxUserRolesByPotenceNumWS:GetFirstID_S", objException.Message);
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
public static clsvQxUserRolesByPotenceNumEN GetFirstvQxUserRolesByPotenceNum_S(string strWhereCond)
{
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
try
{
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_GetFirstObj_S(strWhereCond);
return objvQxUserRolesByPotenceNumEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUserRolesByPotenceNum_GetFirstObj_S", "clsvQxUserRolesByPotenceNumWS:GetFirstObj_S", objException.Message);
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
int intEnd = arrvQxUserRolesByPotenceNumObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUserRolesByPotenceNumEN = arrvQxUserRolesByPotenceNumObjLst_Cache[intMid];
if (objvQxUserRolesByPotenceNumEN.RoleId == strRoleId)
{
intFindFailCount = 0;
return objvQxUserRolesByPotenceNumEN.RoleName;
}
else if (objvQxUserRolesByPotenceNumEN.RoleId.CompareTo(strRoleId) > 0)
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
arrvQxUserRolesByPotenceNumObjLst_Cache = null;
if (intFindFailCount == 1) return GetRoleNameByRoleId_Cache(strRoleId);
string strErrMsgForGetObjById = string.Format("在vQxUserRolesByPotenceNum对象缓存列表中,找不到记录[RoleId = {0}][intFindFailCount = {1}](函数:{2})", strRoleId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUserRolesByPotenceNumEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUserRolesByPotenceNumEN.RoleId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUserRolesByPotenceNumBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
if (arrvQxUserRolesByPotenceNumObjLst_Cache == null)
{
arrvQxUserRolesByPotenceNumObjLst_Cache = clsvQxUserRolesByPotenceNumWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObjByRoleId_Cache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUserRolesByPotenceNumObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUserRolesByPotenceNumEN = arrvQxUserRolesByPotenceNumObjLst_Cache[intMid];
if (objvQxUserRolesByPotenceNumEN.RoleId == strRoleId)
{
intFindFailCount = 0;
return objvQxUserRolesByPotenceNumEN;
}
else if (objvQxUserRolesByPotenceNumEN.RoleId.CompareTo(strRoleId) > 0)
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
arrvQxUserRolesByPotenceNumObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByRoleId_Cache(strRoleId);
string strErrMsgForGetObjById = string.Format("在vQxUserRolesByPotenceNum对象缓存列表中,找不到记录[RoleId = {0}][intFindFailCount = {1}](函数:{2})", strRoleId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUserRolesByPotenceNumEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUserRolesByPotenceNumEN.RoleId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUserRolesByPotenceNumBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
objvQxUserRolesByPotenceNumEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow["RoleENName"].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleIndex"].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsInUse"].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["PotenceNum"].ToString().Trim()); //PotenceNum
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
objvQxUserRolesByPotenceNumEN.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow["RoleName"].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow["RoleENName"].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["RoleIndex"].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsInUse"].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["PotenceNum"].ToString().Trim()); //PotenceNum
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
bool bolIsExist = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_IsExistRecord(strWhereCond);
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
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
bool bolIsExist = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_IsExist(strRoleId);
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
vQxUserRolesByPotenceNumServiceSoapClient objvQxUserRolesByPotenceNumService = GetvQxUserRolesByPotenceNumServiceSoapClient();
int intRecCount = objvQxUserRolesByPotenceNumService.vQxUserRolesByPotenceNum_funGetRecCountByCond(strWhereCond);
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