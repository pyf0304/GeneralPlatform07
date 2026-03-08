
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolWS
 表名:XzSchool(00140071)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:16
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
using GeneralPlatform4WS.ServiceReferenceXzSchool;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 学校(XzSchool)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzSchoolWS
{
private static string mstrPageName = "XzSchoolService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsXzSchoolEN> arrXzSchoolObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static XzSchoolServiceSoapClient objXzSchoolServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static XzSchoolServiceSoapClient GetXzSchoolServiceSoapClient()
{
if (objXzSchoolServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "XzSchoolServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new XzSchoolServiceSoapClient(binding, address);
}
else
{
return objXzSchoolServiceSoapClient;
}
}

 public clsXzSchoolWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_School(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsXzSchoolEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = "0";
objXzSchoolEN.SchoolName = "请选择[学校]...";
arrObjLst.Insert(0, objXzSchoolEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="id_School";
objComboBox.DisplayMember="SchoolName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_School(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[学校]...","0");
List<clsXzSchoolEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="id_School";
objDDL.DataTextField="SchoolName";
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
public static int BindLv_XzSchool(System.Windows.Forms.ListView lvXzSchool, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviXzSchool; 
List<clsXzSchoolEN> arrXzSchoolObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrXzSchoolObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvXzSchool.Items.Clear();//清除原来所有Item
lvXzSchool.Columns.Clear();//清除原来所有列头信息
lvXzSchool.Columns.Add("学校流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.Columns.Add("学校Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.Columns.Add("学校名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.Columns.Add("是否当前使用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.Columns.Add("SchoolNameA", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvXzSchool.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsXzSchoolEN objXzSchoolEN in arrXzSchoolObjLst)
{
lviXzSchool = new System.Windows.Forms.ListViewItem();
lviXzSchool.Tag = objXzSchoolEN.id_School;
lviXzSchool.Text = objXzSchoolEN.id_School.ToString();
lviXzSchool.SubItems.Add(objXzSchoolEN.SchoolId);
lviXzSchool.SubItems.Add(objXzSchoolEN.SchoolName);
lviXzSchool.SubItems.Add(objXzSchoolEN.IsCurrentUse.ToString());
lviXzSchool.SubItems.Add(objXzSchoolEN.Memo);
lviXzSchool.SubItems.Add(objXzSchoolEN.SchoolNameA);
lviXzSchool.SubItems.Add(objXzSchoolEN.UpdDate);
lviXzSchool.SubItems.Add(objXzSchoolEN.UpdUserId);
lvXzSchool.Items.Add(lviXzSchool);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrXzSchoolObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsXzSchoolEN objXzSchoolEN)
{
if (!Object.Equals(null, objXzSchoolEN.id_School) && GetStrLen(objXzSchoolEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolId) && GetStrLen(objXzSchoolEN.SchoolId) > 20)
{
 throw new Exception("字段[学校Id]的长度不能超过20!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolName) && GetStrLen(objXzSchoolEN.SchoolName) > 50)
{
 throw new Exception("字段[学校名称]的长度不能超过50!");
}
if (!Object.Equals(null, objXzSchoolEN.Memo) && GetStrLen(objXzSchoolEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolNameA) && GetStrLen(objXzSchoolEN.SchoolNameA) > 14)
{
 throw new Exception("字段[SchoolNameA]的长度不能超过14!");
}
if (!Object.Equals(null, objXzSchoolEN.UpdDate) && GetStrLen(objXzSchoolEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objXzSchoolEN.UpdUserId) && GetStrLen(objXzSchoolEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
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
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objXzSchoolService.XzSchool_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_GetDataSet", "clsXzSchoolWS:GetDataTableWs", objException.Message);
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
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objXzSchoolService.XzSchool_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_GetTopDataSet", "clsXzSchoolWS:GetDataTable_TopWs", objException.Message);
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
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objXzSchoolService.XzSchool_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_GetDataSetByRange", "clsXzSchoolWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objXzSchoolService.XzSchool_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_GetDataSetV", "clsXzSchoolWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetXzSchoolVWs(string strWhereCond)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objXzSchoolService.XzSchool_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_GetDataSetV", "clsXzSchoolWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objXzSchoolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzSchoolWs(ref clsXzSchoolEN objXzSchoolEN)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
bool bolResult = objXzSchoolService.XzSchool_GetXzSchool(ref objXzSchoolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_School">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchoolEN GetObjByid_SchoolWs(string strid_School)
{
strid_School = strid_School.Replace("'", "");
strid_School = strid_School.Replace(" ", "");
strid_School = strid_School.Replace("(", "");
strid_School = strid_School.Replace(")", "");
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
clsXzSchoolEN objXzSchoolEN = objXzSchoolService.XzSchool_GetObjByid_School(strid_School);
return objXzSchoolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
string strid_School = objXzSchoolService.XzSchool_GetFirstID_S(strWhereCond);
return strid_School;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_GetFirstID_S", "clsXzSchoolWS:GetFirstID_S", objException.Message);
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
public static clsXzSchoolEN GetFirstXzSchool_S(string strWhereCond)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
clsXzSchoolEN objXzSchoolEN = objXzSchoolService.XzSchool_GetFirstObj_S(strWhereCond);
return objXzSchoolEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_GetFirstObj_S", "clsXzSchoolWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrXzSchoolObjLst_Cache.Count - 1;
int intMid = 0;
clsXzSchoolEN objXzSchoolEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objXzSchoolEN = arrXzSchoolObjLst_Cache[intMid];
if (objXzSchoolEN.id_School == strid_School)
{
intFindFailCount = 0;
return objXzSchoolEN.SchoolName;
}
else if (objXzSchoolEN.id_School.CompareTo(strid_School) > 0)
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
arrXzSchoolObjLst_Cache = null;
if (intFindFailCount == 1) return GetSchoolNameByid_School_Cache(strid_School);
string strErrMsgForGetObjById = string.Format("在XzSchool对象缓存列表中,找不到记录[id_School = {0}][intFindFailCount = {1}](函数:{2})", strid_School, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objXzSchoolEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objXzSchoolEN.id_School, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by id_School");
if (arrXzSchoolObjLst_Cache == null)
{
arrXzSchoolObjLst_Cache = clsXzSchoolWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_School">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchoolEN GetObjByid_School_Cache(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrXzSchoolObjLst_Cache.Count - 1;
int intMid = 0;
clsXzSchoolEN objXzSchoolEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objXzSchoolEN = arrXzSchoolObjLst_Cache[intMid];
if (objXzSchoolEN.id_School == strid_School)
{
intFindFailCount = 0;
return objXzSchoolEN;
}
else if (objXzSchoolEN.id_School.CompareTo(strid_School) > 0)
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
arrXzSchoolObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByid_School_Cache(strid_School);
string strErrMsgForGetObjById = string.Format("在XzSchool对象缓存列表中,找不到记录[id_School = {0}][intFindFailCount = {1}](函数:{2})", strid_School, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objXzSchoolEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objXzSchoolEN.id_School, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLst(string strWhereCond)
{
 List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow["id_School"].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow["SchoolId"].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow["SchoolName"].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsCurrentUse"].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objXzSchoolEN.SchoolNameA = objRow["SchoolNameA"].ToString().Trim(); //SchoolNameA
objXzSchoolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
	arrObjLst.Add(objXzSchoolEN);
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
public static List<clsXzSchoolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsXzSchoolEN> arrObjLst = new List<clsXzSchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN();
objXzSchoolEN.id_School = objRow["id_School"].ToString().Trim(); //学校流水号
objXzSchoolEN.SchoolId = objRow["SchoolId"].ToString().Trim(); //学校Id
objXzSchoolEN.SchoolName = objRow["SchoolName"].ToString().Trim(); //学校名称
objXzSchoolEN.IsCurrentUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsCurrentUse"].ToString().Trim()); //是否当前使用
objXzSchoolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objXzSchoolEN.SchoolNameA = objRow["SchoolNameA"].ToString().Trim(); //SchoolNameA
objXzSchoolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objXzSchoolEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
	arrObjLst.Add(objXzSchoolEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strid_School)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
int intResult = objXzSchoolService.XzSchool_DelRecord(strid_School);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_DelRecord", "clsXzSchoolWS:DelRecordWs", objException.Message);
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
public static int DelXzSchoolsWs(List<string> arrid_School)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrid_School);
int intResult = objXzSchoolService.XzSchool_DelXzSchools(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_DelXzSchools", "clsXzSchoolWS:DelXzSchoolsWs", objException.Message);
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
public static int DelXzSchoolsByCondWs(string strWhereCond)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
int intRecNum = objXzSchoolService.XzSchool_DelXzSchoolsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_DelXzSchoolsByCond", "clsXzSchoolWS:DelXzSchoolsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsXzSchoolEN objXzSchoolEN)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
bool bolResult = objXzSchoolService.XzSchool_AddNewRecordBySql2(objXzSchoolEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_AddNewRecordBySql2", "clsXzSchoolWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsXzSchoolEN objXzSchoolEN)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
bool bolResult = objXzSchoolService.XzSchool_UpdateBySql2(objXzSchoolEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_UpdateBySql2", "clsXzSchoolWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsXzSchoolEN objXzSchoolEN, string strWhereCond)
{
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
try
{
bool bolResult = objXzSchoolService.XzSchool_UpdateBySqlWithCondition(objXzSchoolEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "XzSchool_UpdateBySqlWithCondition", "clsXzSchoolWS:UpdateBySqlWithCondition", objException.Message);
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
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
bool bolIsExist = objXzSchoolService.XzSchool_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strid_School)
{
//检测记录是否存在
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
bool bolIsExist = objXzSchoolService.XzSchool_IsExist(strid_School);
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
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
int intRecCount = objXzSchoolService.XzSchool_funGetRecCountByCond(strWhereCond);
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
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
string strMaxId_School = objXzSchoolService.XzSchool_GetMaxStrId();
return strMaxId_School;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
XzSchoolServiceSoapClient objXzSchoolService = GetXzSchoolServiceSoapClient();
string strMaxId_School = objXzSchoolService.XzSchool_GetMaxStrIdByPrefix(strPrefix);
return strMaxId_School;
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