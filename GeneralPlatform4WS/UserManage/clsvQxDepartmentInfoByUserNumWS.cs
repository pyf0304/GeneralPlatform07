
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxDepartmentInfoByUserNumWS
 表名:vQxDepartmentInfoByUserNum(00140082)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:22
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
using GeneralPlatform4WS.ServiceReferencevQxDepartmentInfoByUserNum;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v部门信息By用户数(vQxDepartmentInfoByUserNum)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxDepartmentInfoByUserNumWS
{
private static string mstrPageName = "vQxDepartmentInfoByUserNumService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxDepartmentInfoByUserNumServiceSoapClient GetvQxDepartmentInfoByUserNumServiceSoapClient()
{
if (objvQxDepartmentInfoByUserNumServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxDepartmentInfoByUserNumServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxDepartmentInfoByUserNumServiceSoapClient(binding, address);
}
else
{
return objvQxDepartmentInfoByUserNumServiceSoapClient;
}
}

 public clsvQxDepartmentInfoByUserNumWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_DepartmentId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
objvQxDepartmentInfoByUserNumEN.DepartmentId = "0";
objvQxDepartmentInfoByUserNumEN.DepartmentName = "请选择[v部门信息By用户数]...";
arrObjLst.Insert(0, objvQxDepartmentInfoByUserNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="DepartmentId";
objComboBox.DisplayMember="DepartmentName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v部门信息By用户数]...","0");
List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="DepartmentId";
objDDL.DataTextField="DepartmentName";
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
public static int BindLv_vQxDepartmentInfoByUserNum(System.Windows.Forms.ListView lvvQxDepartmentInfoByUserNum, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxDepartmentInfoByUserNum; 
List<clsvQxDepartmentInfoByUserNumEN> arrvQxDepartmentInfoByUserNumObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxDepartmentInfoByUserNumObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxDepartmentInfoByUserNum.Items.Clear();//清除原来所有Item
lvvQxDepartmentInfoByUserNum.Columns.Clear();//清除原来所有列头信息
lvvQxDepartmentInfoByUserNum.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("部门类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("部门类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("所属部门号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("用户数", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.Columns.Add("上级部门", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxDepartmentInfoByUserNum.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN in arrvQxDepartmentInfoByUserNumObjLst)
{
lvivQxDepartmentInfoByUserNum = new System.Windows.Forms.ListViewItem();
lvivQxDepartmentInfoByUserNum.Tag = objvQxDepartmentInfoByUserNumEN.DepartmentId;
lvivQxDepartmentInfoByUserNum.Text = objvQxDepartmentInfoByUserNumEN.DepartmentId.ToString();
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.DepartmentName);
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName);
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.DepartmentTypeId);
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.DepartmentTypeName);
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.UpDepartmentId);
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.OrderNum.ToString());
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.InUse.ToString());
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.Memo);
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.UserNum.ToString());
lvivQxDepartmentInfoByUserNum.SubItems.Add(objvQxDepartmentInfoByUserNumEN.UpDepartmentName);
lvvQxDepartmentInfoByUserNum.Items.Add(lvivQxDepartmentInfoByUserNum);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxDepartmentInfoByUserNumObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfoByUserNum_GetDataSet", "clsvQxDepartmentInfoByUserNumWS:GetDataTableWs", objException.Message);
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
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfoByUserNum_GetTopDataSet", "clsvQxDepartmentInfoByUserNumWS:GetDataTable_TopWs", objException.Message);
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
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfoByUserNum_GetDataSetByRange", "clsvQxDepartmentInfoByUserNumWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxDepartmentInfoByUserNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxDepartmentInfoByUserNumWs(ref clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN)
{
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
bool bolResult = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_GetvQxDepartmentInfoByUserNum(ref objvQxDepartmentInfoByUserNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObjByDepartmentIdWs(string strDepartmentId)
{
strDepartmentId = strDepartmentId.Replace("'", "");
strDepartmentId = strDepartmentId.Replace(" ", "");
strDepartmentId = strDepartmentId.Replace("(", "");
strDepartmentId = strDepartmentId.Replace(")", "");
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_GetObjByDepartmentId(strDepartmentId);
return objvQxDepartmentInfoByUserNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
try
{
string strDepartmentId = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_GetFirstID_S(strWhereCond);
return strDepartmentId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfoByUserNum_GetFirstID_S", "clsvQxDepartmentInfoByUserNumWS:GetFirstID_S", objException.Message);
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
public static clsvQxDepartmentInfoByUserNumEN GetFirstvQxDepartmentInfoByUserNum_S(string strWhereCond)
{
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
try
{
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_GetFirstObj_S(strWhereCond);
return objvQxDepartmentInfoByUserNumEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxDepartmentInfoByUserNum_GetFirstObj_S", "clsvQxDepartmentInfoByUserNumWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDepartmentNameByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxDepartmentInfoByUserNumObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxDepartmentInfoByUserNumEN = arrvQxDepartmentInfoByUserNumObjLst_Cache[intMid];
if (objvQxDepartmentInfoByUserNumEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objvQxDepartmentInfoByUserNumEN.DepartmentName;
}
else if (objvQxDepartmentInfoByUserNumEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrvQxDepartmentInfoByUserNumObjLst_Cache = null;
if (intFindFailCount == 1) return GetDepartmentNameByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在vQxDepartmentInfoByUserNum对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:{2})", strDepartmentId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxDepartmentInfoByUserNumEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxDepartmentInfoByUserNumEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxDepartmentInfoByUserNumBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by DepartmentId");
if (arrvQxDepartmentInfoByUserNumObjLst_Cache == null)
{
arrvQxDepartmentInfoByUserNumObjLst_Cache = clsvQxDepartmentInfoByUserNumWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxDepartmentInfoByUserNumEN GetObjByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxDepartmentInfoByUserNumObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxDepartmentInfoByUserNumEN = arrvQxDepartmentInfoByUserNumObjLst_Cache[intMid];
if (objvQxDepartmentInfoByUserNumEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objvQxDepartmentInfoByUserNumEN;
}
else if (objvQxDepartmentInfoByUserNumEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrvQxDepartmentInfoByUserNumObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在vQxDepartmentInfoByUserNum对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:{2})", strDepartmentId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxDepartmentInfoByUserNumEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxDepartmentInfoByUserNumEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxDepartmentInfoByUserNumBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLst(string strWhereCond)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["UserNum"].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
public static List<clsvQxDepartmentInfoByUserNumEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxDepartmentInfoByUserNumEN> arrObjLst = new List<clsvQxDepartmentInfoByUserNumEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxDepartmentInfoByUserNumEN objvQxDepartmentInfoByUserNumEN = new clsvQxDepartmentInfoByUserNumEN();
objvQxDepartmentInfoByUserNumEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxDepartmentInfoByUserNumEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxDepartmentInfoByUserNumEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxDepartmentInfoByUserNumEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxDepartmentInfoByUserNumEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxDepartmentInfoByUserNumEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxDepartmentInfoByUserNumEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvQxDepartmentInfoByUserNumEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvQxDepartmentInfoByUserNumEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvQxDepartmentInfoByUserNumEN.UserNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["UserNum"].ToString().Trim()); //用户数
objvQxDepartmentInfoByUserNumEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
	arrObjLst.Add(objvQxDepartmentInfoByUserNumEN);
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
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
bool bolIsExist = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strDepartmentId)
{
//检测记录是否存在
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
bool bolIsExist = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_IsExist(strDepartmentId);
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
vQxDepartmentInfoByUserNumServiceSoapClient objvQxDepartmentInfoByUserNumService = GetvQxDepartmentInfoByUserNumServiceSoapClient();
int intRecCount = objvQxDepartmentInfoByUserNumService.vQxDepartmentInfoByUserNum_funGetRecCountByCond(strWhereCond);
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