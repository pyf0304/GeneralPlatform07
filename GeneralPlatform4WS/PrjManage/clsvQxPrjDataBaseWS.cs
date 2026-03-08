
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjDataBaseWS
 表名:vQxPrjDataBase(00140040)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:04
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程管理
 模块英文名:PrjManage
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
using GeneralPlatform4WS.ServiceReferencevQxPrjDataBase;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v数据库对象(vQxPrjDataBase)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjDataBaseWS
{
private static string mstrPageName = "vQxPrjDataBaseService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjDataBaseEN> arrvQxPrjDataBaseObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjDataBaseServiceSoapClient GetvQxPrjDataBaseServiceSoapClient()
{
if (objvQxPrjDataBaseServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjDataBaseServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjDataBaseServiceSoapClient(binding, address);
}
else
{
return objvQxPrjDataBaseServiceSoapClient;
}
}

 public clsvQxPrjDataBaseWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_QxPrjDataBaseId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsvQxPrjDataBaseEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
objvQxPrjDataBaseEN.QxPrjDataBaseId = "0";
objvQxPrjDataBaseEN.PrjDataBaseName = "请选择[v数据库对象]...";
arrObjLst.Insert(0, objvQxPrjDataBaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="QxPrjDataBaseId";
objComboBox.DisplayMember="PrjDataBaseName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QxPrjDataBaseId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[v数据库对象]...","0");
List<clsvQxPrjDataBaseEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="QxPrjDataBaseId";
objDDL.DataTextField="PrjDataBaseName";
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
public static int BindLv_vQxPrjDataBase(System.Windows.Forms.ListView lvvQxPrjDataBase, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjDataBase; 
List<clsvQxPrjDataBaseEN> arrvQxPrjDataBaseObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjDataBaseObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjDataBase.Items.Clear();//清除原来所有Item
lvvQxPrjDataBase.Columns.Clear();//清除原来所有列头信息
lvvQxPrjDataBase.Columns.Add("项目数据库Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("项目数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("数据库用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("数据库用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("数据库名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("数据库类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("数据库类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("数据库拥有者", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("表空间", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("SID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjDataBase.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjDataBaseEN objvQxPrjDataBaseEN in arrvQxPrjDataBaseObjLst)
{
lvivQxPrjDataBase = new System.Windows.Forms.ListViewItem();
lvivQxPrjDataBase.Tag = objvQxPrjDataBaseEN.QxPrjDataBaseId;
lvivQxPrjDataBase.Text = objvQxPrjDataBaseEN.QxPrjDataBaseId.ToString();
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.PrjDataBaseName);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.IpAddress);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.DataBaseUserId);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.DataBasePwd);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.DataBaseName);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.DataBaseTypeName);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.DataBaseTypeId);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.DatabaseOwner);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.TableSpace);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.UpdDate);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.SID);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.UserId);
lvivQxPrjDataBase.SubItems.Add(objvQxPrjDataBaseEN.Memo);
lvvQxPrjDataBase.Items.Add(lvivQxPrjDataBase);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjDataBaseObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjDataBaseService.vQxPrjDataBase_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjDataBase_GetDataSet", "clsvQxPrjDataBaseWS:GetDataTableWs", objException.Message);
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
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjDataBaseService.vQxPrjDataBase_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjDataBase_GetTopDataSet", "clsvQxPrjDataBaseWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjDataBaseService.vQxPrjDataBase_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjDataBase_GetDataSetByRange", "clsvQxPrjDataBaseWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjDataBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjDataBaseWs(ref clsvQxPrjDataBaseEN objvQxPrjDataBaseEN)
{
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
bool bolResult = objvQxPrjDataBaseService.vQxPrjDataBase_GetvQxPrjDataBase(ref objvQxPrjDataBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjDataBaseEN GetObjByQxPrjDataBaseIdWs(string strQxPrjDataBaseId)
{
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("'", "");
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace(" ", "");
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("(", "");
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace(")", "");
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = objvQxPrjDataBaseService.vQxPrjDataBase_GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);
return objvQxPrjDataBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
try
{
string strQxPrjDataBaseId = objvQxPrjDataBaseService.vQxPrjDataBase_GetFirstID_S(strWhereCond);
return strQxPrjDataBaseId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjDataBase_GetFirstID_S", "clsvQxPrjDataBaseWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjDataBaseEN GetFirstvQxPrjDataBase_S(string strWhereCond)
{
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
try
{
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = objvQxPrjDataBaseService.vQxPrjDataBase_GetFirstObj_S(strWhereCond);
return objvQxPrjDataBaseEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjDataBase_GetFirstObj_S", "clsvQxPrjDataBaseWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjDataBaseNameByQxPrjDataBaseId_Cache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjDataBaseObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjDataBaseEN = arrvQxPrjDataBaseObjLst_Cache[intMid];
if (objvQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId)
{
intFindFailCount = 0;
return objvQxPrjDataBaseEN.PrjDataBaseName;
}
else if (objvQxPrjDataBaseEN.QxPrjDataBaseId.CompareTo(strQxPrjDataBaseId) > 0)
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
arrvQxPrjDataBaseObjLst_Cache = null;
if (intFindFailCount == 1) return GetPrjDataBaseNameByQxPrjDataBaseId_Cache(strQxPrjDataBaseId);
string strErrMsgForGetObjById = string.Format("在vQxPrjDataBase对象缓存列表中,找不到记录[QxPrjDataBaseId = {0}][intFindFailCount = {1}](函数:{2})", strQxPrjDataBaseId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjDataBaseEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjDataBaseEN.QxPrjDataBaseId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by QxPrjDataBaseId");
if (arrvQxPrjDataBaseObjLst_Cache == null)
{
arrvQxPrjDataBaseObjLst_Cache = clsvQxPrjDataBaseWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjDataBaseEN GetObjByQxPrjDataBaseId_Cache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjDataBaseObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjDataBaseEN = arrvQxPrjDataBaseObjLst_Cache[intMid];
if (objvQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId)
{
intFindFailCount = 0;
return objvQxPrjDataBaseEN;
}
else if (objvQxPrjDataBaseEN.QxPrjDataBaseId.CompareTo(strQxPrjDataBaseId) > 0)
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
arrvQxPrjDataBaseObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByQxPrjDataBaseId_Cache(strQxPrjDataBaseId);
string strErrMsgForGetObjById = string.Format("在vQxPrjDataBase对象缓存列表中,找不到记录[QxPrjDataBaseId = {0}][intFindFailCount = {1}](函数:{2})", strQxPrjDataBaseId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjDataBaseEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjDataBaseEN.QxPrjDataBaseId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjDataBaseEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjDataBaseEN> arrObjLst = new List<clsvQxPrjDataBaseEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow["QxPrjDataBaseId"].ToString().Trim(); //项目数据库Id
objvQxPrjDataBaseEN.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim(); //项目数据库名
objvQxPrjDataBaseEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objvQxPrjDataBaseEN.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim(); //数据库用户Id
objvQxPrjDataBaseEN.DataBasePwd = objRow["DataBasePwd"].ToString().Trim(); //数据库用户口令
objvQxPrjDataBaseEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
objvQxPrjDataBaseEN.DataBaseTypeName = objRow["DataBaseTypeName"].ToString().Trim(); //数据库类型名
objvQxPrjDataBaseEN.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim(); //数据库类型ID
objvQxPrjDataBaseEN.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim(); //数据库拥有者
objvQxPrjDataBaseEN.TableSpace = objRow["TableSpace"].ToString().Trim(); //表空间
objvQxPrjDataBaseEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjDataBaseEN.SID = objRow["SID"].ToString().Trim(); //SID
objvQxPrjDataBaseEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxPrjDataBaseEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxPrjDataBaseEN);
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
public static List<clsvQxPrjDataBaseEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjDataBaseEN> arrObjLst = new List<clsvQxPrjDataBaseEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjDataBaseEN objvQxPrjDataBaseEN = new clsvQxPrjDataBaseEN();
objvQxPrjDataBaseEN.QxPrjDataBaseId = objRow["QxPrjDataBaseId"].ToString().Trim(); //项目数据库Id
objvQxPrjDataBaseEN.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim(); //项目数据库名
objvQxPrjDataBaseEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objvQxPrjDataBaseEN.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim(); //数据库用户Id
objvQxPrjDataBaseEN.DataBasePwd = objRow["DataBasePwd"].ToString().Trim(); //数据库用户口令
objvQxPrjDataBaseEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
objvQxPrjDataBaseEN.DataBaseTypeName = objRow["DataBaseTypeName"].ToString().Trim(); //数据库类型名
objvQxPrjDataBaseEN.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim(); //数据库类型ID
objvQxPrjDataBaseEN.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim(); //数据库拥有者
objvQxPrjDataBaseEN.TableSpace = objRow["TableSpace"].ToString().Trim(); //表空间
objvQxPrjDataBaseEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjDataBaseEN.SID = objRow["SID"].ToString().Trim(); //SID
objvQxPrjDataBaseEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxPrjDataBaseEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxPrjDataBaseEN);
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
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
bool bolIsExist = objvQxPrjDataBaseService.vQxPrjDataBase_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strQxPrjDataBaseId)
{
//检测记录是否存在
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
bool bolIsExist = objvQxPrjDataBaseService.vQxPrjDataBase_IsExist(strQxPrjDataBaseId);
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
vQxPrjDataBaseServiceSoapClient objvQxPrjDataBaseService = GetvQxPrjDataBaseServiceSoapClient();
int intRecCount = objvQxPrjDataBaseService.vQxPrjDataBase_funGetRecCountByCond(strWhereCond);
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