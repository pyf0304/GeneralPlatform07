
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewInfoWS
 表名:vQxViewInfo(00140029)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:00
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:界面管理
 模块英文名:InterfaceMan
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
using GeneralPlatform4WS.ServiceReferencevQxViewInfo;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v界面信息(vQxViewInfo)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxViewInfoWS
{
private static string mstrPageName = "vQxViewInfoService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxViewInfoEN> arrvQxViewInfoObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxViewInfoServiceSoapClient objvQxViewInfoServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxViewInfoServiceSoapClient GetvQxViewInfoServiceSoapClient()
{
if (objvQxViewInfoServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxViewInfoServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxViewInfoServiceSoapClient(binding, address);
}
else
{
return objvQxViewInfoServiceSoapClient;
}
}

 public clsvQxViewInfoWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ViewId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxViewInfoEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxViewInfoEN objvQxViewInfoEN = new clsvQxViewInfoEN();
objvQxViewInfoEN.ViewId = "0";
objvQxViewInfoEN.ViewName = "请选择[v界面信息]...";
arrObjLst.Insert(0, objvQxViewInfoEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="ViewId";
objComboBox.DisplayMember="ViewName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v界面信息]...","0");
List<clsvQxViewInfoEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="ViewId";
objDDL.DataTextField="ViewName";
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
public static int BindLv_vQxViewInfo(System.Windows.Forms.ListView lvvQxViewInfo, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxViewInfo; 
List<clsvQxViewInfoEN> arrvQxViewInfoObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxViewInfoObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxViewInfo.Items.Clear();//清除原来所有Item
lvvQxViewInfo.Columns.Clear();//清除原来所有列头信息
lvvQxViewInfo.Columns.Add("界面编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("界面中文名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("文件路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("缺省菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("界面类型码", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("数据库名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("界面功能", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("界面详细信息", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("模块号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("模块名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxViewInfo.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxViewInfoEN objvQxViewInfoEN in arrvQxViewInfoObjLst)
{
lvivQxViewInfo = new System.Windows.Forms.ListViewItem();
lvivQxViewInfo.Tag = objvQxViewInfoEN.ViewId;
lvivQxViewInfo.Text = objvQxViewInfoEN.ViewId.ToString();
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.ViewName);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.ViewCnName);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.FileName);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.FilePath);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.DefaMenuName);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.ViewTypeCode);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.DataBaseName);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.QxPrjId);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.PrjName);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.ViewFunction);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.ViewDetail);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.ModuleId);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.ModuleName);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.UpdDate);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.UpdUserId);
lvivQxViewInfo.SubItems.Add(objvQxViewInfoEN.Memo);
lvvQxViewInfo.Items.Add(lvivQxViewInfo);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxViewInfoObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxViewInfoService.vQxViewInfo_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewInfo_GetDataSet", "clsvQxViewInfoWS:GetDataTableWs", objException.Message);
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
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxViewInfoService.vQxViewInfo_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewInfo_GetTopDataSet", "clsvQxViewInfoWS:GetDataTable_TopWs", objException.Message);
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
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxViewInfoService.vQxViewInfo_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewInfo_GetDataSetByRange", "clsvQxViewInfoWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxViewInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxViewInfoWs(ref clsvQxViewInfoEN objvQxViewInfoEN)
{
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
bool bolResult = objvQxViewInfoService.vQxViewInfo_GetvQxViewInfo(ref objvQxViewInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxViewInfoEN GetObjByViewIdWs(string strViewId)
{
strViewId = strViewId.Replace("'", "");
strViewId = strViewId.Replace(" ", "");
strViewId = strViewId.Replace("(", "");
strViewId = strViewId.Replace(")", "");
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
clsvQxViewInfoEN objvQxViewInfoEN = objvQxViewInfoService.vQxViewInfo_GetObjByViewId(strViewId);
return objvQxViewInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
try
{
string strViewId = objvQxViewInfoService.vQxViewInfo_GetFirstID_S(strWhereCond);
return strViewId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewInfo_GetFirstID_S", "clsvQxViewInfoWS:GetFirstID_S", objException.Message);
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
public static clsvQxViewInfoEN GetFirstvQxViewInfo_S(string strWhereCond)
{
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
try
{
clsvQxViewInfoEN objvQxViewInfoEN = objvQxViewInfoService.vQxViewInfo_GetFirstObj_S(strWhereCond);
return objvQxViewInfoEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxViewInfo_GetFirstObj_S", "clsvQxViewInfoWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewNameByViewId_Cache(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxViewInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxViewInfoEN objvQxViewInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxViewInfoEN = arrvQxViewInfoObjLst_Cache[intMid];
if (objvQxViewInfoEN.ViewId == strViewId)
{
intFindFailCount = 0;
return objvQxViewInfoEN.ViewName;
}
else if (objvQxViewInfoEN.ViewId.CompareTo(strViewId) > 0)
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
arrvQxViewInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetViewNameByViewId_Cache(strViewId);
string strErrMsgForGetObjById = string.Format("在vQxViewInfo对象缓存列表中,找不到记录[ViewId = {0}][intFindFailCount = {1}](函数:{2})", strViewId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxViewInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxViewInfoEN.ViewId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxViewInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by ViewId");
if (arrvQxViewInfoObjLst_Cache == null)
{
arrvQxViewInfoObjLst_Cache = clsvQxViewInfoWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxViewInfoEN GetObjByViewId_Cache(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxViewInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxViewInfoEN objvQxViewInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxViewInfoEN = arrvQxViewInfoObjLst_Cache[intMid];
if (objvQxViewInfoEN.ViewId == strViewId)
{
intFindFailCount = 0;
return objvQxViewInfoEN;
}
else if (objvQxViewInfoEN.ViewId.CompareTo(strViewId) > 0)
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
arrvQxViewInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByViewId_Cache(strViewId);
string strErrMsgForGetObjById = string.Format("在vQxViewInfo对象缓存列表中,找不到记录[ViewId = {0}][intFindFailCount = {1}](函数:{2})", strViewId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxViewInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxViewInfoEN.ViewId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxViewInfoBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvQxViewInfoEN> arrObjLst = new List<clsvQxViewInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewInfoEN objvQxViewInfoEN = new clsvQxViewInfoEN();
objvQxViewInfoEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
objvQxViewInfoEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvQxViewInfoEN.ViewCnName = objRow["ViewCnName"].ToString().Trim(); //界面中文名称
objvQxViewInfoEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objvQxViewInfoEN.FilePath = objRow["FilePath"].ToString().Trim(); //文件路径
objvQxViewInfoEN.DefaMenuName = objRow["DefaMenuName"].ToString().Trim(); //缺省菜单名
objvQxViewInfoEN.ViewTypeCode = objRow["ViewTypeCode"].ToString().Trim(); //界面类型码
objvQxViewInfoEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
objvQxViewInfoEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxViewInfoEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxViewInfoEN.ViewFunction = objRow["ViewFunction"].ToString().Trim(); //界面功能
objvQxViewInfoEN.ViewDetail = objRow["ViewDetail"].ToString().Trim(); //界面详细信息
objvQxViewInfoEN.ModuleId = objRow["ModuleId"].ToString().Trim(); //模块号
objvQxViewInfoEN.ModuleName = objRow["ModuleName"].ToString().Trim(); //模块名称
objvQxViewInfoEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxViewInfoEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxViewInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxViewInfoEN);
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
public static List<clsvQxViewInfoEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxViewInfoEN> arrObjLst = new List<clsvQxViewInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewInfoEN objvQxViewInfoEN = new clsvQxViewInfoEN();
objvQxViewInfoEN.ViewId = objRow["ViewId"].ToString().Trim(); //界面编号
objvQxViewInfoEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objvQxViewInfoEN.ViewCnName = objRow["ViewCnName"].ToString().Trim(); //界面中文名称
objvQxViewInfoEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objvQxViewInfoEN.FilePath = objRow["FilePath"].ToString().Trim(); //文件路径
objvQxViewInfoEN.DefaMenuName = objRow["DefaMenuName"].ToString().Trim(); //缺省菜单名
objvQxViewInfoEN.ViewTypeCode = objRow["ViewTypeCode"].ToString().Trim(); //界面类型码
objvQxViewInfoEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
objvQxViewInfoEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxViewInfoEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxViewInfoEN.ViewFunction = objRow["ViewFunction"].ToString().Trim(); //界面功能
objvQxViewInfoEN.ViewDetail = objRow["ViewDetail"].ToString().Trim(); //界面详细信息
objvQxViewInfoEN.ModuleId = objRow["ModuleId"].ToString().Trim(); //模块号
objvQxViewInfoEN.ModuleName = objRow["ModuleName"].ToString().Trim(); //模块名称
objvQxViewInfoEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxViewInfoEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxViewInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxViewInfoEN);
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
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
bool bolIsExist = objvQxViewInfoService.vQxViewInfo_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strViewId)
{
//检测记录是否存在
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
bool bolIsExist = objvQxViewInfoService.vQxViewInfo_IsExist(strViewId);
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
vQxViewInfoServiceSoapClient objvQxViewInfoService = GetvQxViewInfoServiceSoapClient();
int intRecCount = objvQxViewInfoService.vQxViewInfo_funGetRecCountByCond(strWhereCond);
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