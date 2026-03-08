
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjDataBaseWS
 表名:QxPrjDataBase(00140039)
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
using GeneralPlatform4WS.ServiceReferenceQxPrjDataBase;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 数据库对象(QxPrjDataBase)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjDataBaseWS
{
private static string mstrPageName = "QxPrjDataBaseService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPrjDataBaseServiceSoapClient objQxPrjDataBaseServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPrjDataBaseServiceSoapClient GetQxPrjDataBaseServiceSoapClient()
{
if (objQxPrjDataBaseServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPrjDataBaseServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPrjDataBaseServiceSoapClient(binding, address);
}
else
{
return objQxPrjDataBaseServiceSoapClient;
}
}

 public clsQxPrjDataBaseWS()
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
List<clsQxPrjDataBaseEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
objQxPrjDataBaseEN.QxPrjDataBaseId = "0";
objQxPrjDataBaseEN.PrjDataBaseName = "请选择[数据库对象]...";
arrObjLst.Insert(0, objQxPrjDataBaseEN);
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[数据库对象]...","0");
List<clsQxPrjDataBaseEN> arrObjLst = GetObjLst("1 = 1");
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
public static int BindLv_QxPrjDataBase(System.Windows.Forms.ListView lvQxPrjDataBase, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPrjDataBase; 
List<clsQxPrjDataBaseEN> arrQxPrjDataBaseObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPrjDataBaseObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPrjDataBase.Items.Clear();//清除原来所有Item
lvQxPrjDataBase.Columns.Clear();//清除原来所有列头信息
lvQxPrjDataBase.Columns.Add("项目数据库Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("项目数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("数据库名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("数据库拥有者", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("数据库用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("数据库类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("数据库用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("SID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("表空间", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjDataBase.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjDataBaseEN objQxPrjDataBaseEN in arrQxPrjDataBaseObjLst)
{
lviQxPrjDataBase = new System.Windows.Forms.ListViewItem();
lviQxPrjDataBase.Tag = objQxPrjDataBaseEN.QxPrjDataBaseId;
lviQxPrjDataBase.Text = objQxPrjDataBaseEN.QxPrjDataBaseId.ToString();
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.PrjDataBaseName);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.DataBaseName);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.DatabaseOwner);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.DataBasePwd);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.DataBaseUserId);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.IpAddress);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.SID);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.TableSpace);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.UserId);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.UpdDate);
lviQxPrjDataBase.SubItems.Add(objQxPrjDataBaseEN.Memo);
lvQxPrjDataBase.Items.Add(lviQxPrjDataBase);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPrjDataBaseObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
if (!Object.Equals(null, objQxPrjDataBaseEN.QxPrjDataBaseId) && GetStrLen(objQxPrjDataBaseEN.QxPrjDataBaseId) > 4)
{
 throw new Exception("字段[项目数据库Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.PrjDataBaseName) && GetStrLen(objQxPrjDataBaseEN.PrjDataBaseName) > 50)
{
 throw new Exception("字段[项目数据库名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBaseName) && GetStrLen(objQxPrjDataBaseEN.DataBaseName) > 30)
{
 throw new Exception("字段[数据库名称]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DatabaseOwner) && GetStrLen(objQxPrjDataBaseEN.DatabaseOwner) > 30)
{
 throw new Exception("字段[数据库拥有者]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBasePwd) && GetStrLen(objQxPrjDataBaseEN.DataBasePwd) > 20)
{
 throw new Exception("字段[数据库用户口令]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBaseTypeId) && GetStrLen(objQxPrjDataBaseEN.DataBaseTypeId) > 2)
{
 throw new Exception("字段[数据库类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.DataBaseUserId) && GetStrLen(objQxPrjDataBaseEN.DataBaseUserId) > 18)
{
 throw new Exception("字段[数据库用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.IpAddress) && GetStrLen(objQxPrjDataBaseEN.IpAddress) > 23)
{
 throw new Exception("字段[IP地址]的长度不能超过23!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.SID) && GetStrLen(objQxPrjDataBaseEN.SID) > 30)
{
 throw new Exception("字段[SID]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.TableSpace) && GetStrLen(objQxPrjDataBaseEN.TableSpace) > 30)
{
 throw new Exception("字段[表空间]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.UserId) && GetStrLen(objQxPrjDataBaseEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.UpdDate) && GetStrLen(objQxPrjDataBaseEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxPrjDataBaseEN.Memo) && GetStrLen(objQxPrjDataBaseEN.Memo) > 1000)
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
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjDataBaseService.QxPrjDataBase_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_GetDataSet", "clsQxPrjDataBaseWS:GetDataTableWs", objException.Message);
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
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjDataBaseService.QxPrjDataBase_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_GetTopDataSet", "clsQxPrjDataBaseWS:GetDataTable_TopWs", objException.Message);
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
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjDataBaseService.QxPrjDataBase_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_GetDataSetByRange", "clsQxPrjDataBaseWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjDataBaseService.QxPrjDataBase_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_GetDataSetV", "clsQxPrjDataBaseWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPrjDataBaseVWs(string strWhereCond)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjDataBaseService.QxPrjDataBase_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_GetDataSetV", "clsQxPrjDataBaseWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjDataBaseWs(ref clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
bool bolResult = objQxPrjDataBaseService.QxPrjDataBase_GetQxPrjDataBase(ref objQxPrjDataBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjDataBaseEN GetObjByQxPrjDataBaseIdWs(string strQxPrjDataBaseId)
{
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("'", "");
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace(" ", "");
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("(", "");
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace(")", "");
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
clsQxPrjDataBaseEN objQxPrjDataBaseEN = objQxPrjDataBaseService.QxPrjDataBase_GetObjByQxPrjDataBaseId(strQxPrjDataBaseId);
return objQxPrjDataBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
string strQxPrjDataBaseId = objQxPrjDataBaseService.QxPrjDataBase_GetFirstID_S(strWhereCond);
return strQxPrjDataBaseId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_GetFirstID_S", "clsQxPrjDataBaseWS:GetFirstID_S", objException.Message);
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
public static clsQxPrjDataBaseEN GetFirstQxPrjDataBase_S(string strWhereCond)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
clsQxPrjDataBaseEN objQxPrjDataBaseEN = objQxPrjDataBaseService.QxPrjDataBase_GetFirstObj_S(strWhereCond);
return objQxPrjDataBaseEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_GetFirstObj_S", "clsQxPrjDataBaseWS:GetFirstObj_S", objException.Message);
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
int intEnd = arrQxPrjDataBaseObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjDataBaseEN objQxPrjDataBaseEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjDataBaseEN = arrQxPrjDataBaseObjLst_Cache[intMid];
if (objQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId)
{
intFindFailCount = 0;
return objQxPrjDataBaseEN.PrjDataBaseName;
}
else if (objQxPrjDataBaseEN.QxPrjDataBaseId.CompareTo(strQxPrjDataBaseId) > 0)
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
arrQxPrjDataBaseObjLst_Cache = null;
if (intFindFailCount == 1) return GetPrjDataBaseNameByQxPrjDataBaseId_Cache(strQxPrjDataBaseId);
string strErrMsgForGetObjById = string.Format("在QxPrjDataBase对象缓存列表中,找不到记录[QxPrjDataBaseId = {0}][intFindFailCount = {1}](函数:{2})", strQxPrjDataBaseId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjDataBaseEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjDataBaseEN.QxPrjDataBaseId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
if (arrQxPrjDataBaseObjLst_Cache == null)
{
arrQxPrjDataBaseObjLst_Cache = clsQxPrjDataBaseWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strQxPrjDataBaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjDataBaseEN GetObjByQxPrjDataBaseId_Cache(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjDataBaseObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjDataBaseEN objQxPrjDataBaseEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjDataBaseEN = arrQxPrjDataBaseObjLst_Cache[intMid];
if (objQxPrjDataBaseEN.QxPrjDataBaseId == strQxPrjDataBaseId)
{
intFindFailCount = 0;
return objQxPrjDataBaseEN;
}
else if (objQxPrjDataBaseEN.QxPrjDataBaseId.CompareTo(strQxPrjDataBaseId) > 0)
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
arrQxPrjDataBaseObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByQxPrjDataBaseId_Cache(strQxPrjDataBaseId);
string strErrMsgForGetObjById = string.Format("在QxPrjDataBase对象缓存列表中,找不到记录[QxPrjDataBaseId = {0}][intFindFailCount = {1}](函数:{2})", strQxPrjDataBaseId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjDataBaseEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjDataBaseEN.QxPrjDataBaseId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjDataBaseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjDataBaseEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow["QxPrjDataBaseId"].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow["DataBasePwd"].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow["SID"].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow["TableSpace"].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjDataBaseEN);
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
public static List<clsQxPrjDataBaseEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPrjDataBaseEN> arrObjLst = new List<clsQxPrjDataBaseEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjDataBaseEN objQxPrjDataBaseEN = new clsQxPrjDataBaseEN();
objQxPrjDataBaseEN.QxPrjDataBaseId = objRow["QxPrjDataBaseId"].ToString().Trim(); //项目数据库Id
objQxPrjDataBaseEN.PrjDataBaseName = objRow["PrjDataBaseName"].ToString().Trim(); //项目数据库名
objQxPrjDataBaseEN.DataBaseName = objRow["DataBaseName"].ToString().Trim(); //数据库名称
objQxPrjDataBaseEN.DatabaseOwner = objRow["DatabaseOwner"].ToString().Trim(); //数据库拥有者
objQxPrjDataBaseEN.DataBasePwd = objRow["DataBasePwd"].ToString().Trim(); //数据库用户口令
objQxPrjDataBaseEN.DataBaseTypeId = objRow["DataBaseTypeId"].ToString().Trim(); //数据库类型ID
objQxPrjDataBaseEN.DataBaseUserId = objRow["DataBaseUserId"].ToString().Trim(); //数据库用户Id
objQxPrjDataBaseEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objQxPrjDataBaseEN.SID = objRow["SID"].ToString().Trim(); //SID
objQxPrjDataBaseEN.TableSpace = objRow["TableSpace"].ToString().Trim(); //表空间
objQxPrjDataBaseEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objQxPrjDataBaseEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjDataBaseEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjDataBaseEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strQxPrjDataBaseId)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
int intResult = objQxPrjDataBaseService.QxPrjDataBase_DelRecord(strQxPrjDataBaseId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_DelRecord", "clsQxPrjDataBaseWS:DelRecordWs", objException.Message);
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
public static int DelQxPrjDataBasesWs(List<string> arrQxPrjDataBaseId)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrQxPrjDataBaseId);
int intResult = objQxPrjDataBaseService.QxPrjDataBase_DelQxPrjDataBases(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_DelQxPrjDataBases", "clsQxPrjDataBaseWS:DelQxPrjDataBasesWs", objException.Message);
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
public static int DelQxPrjDataBasesByCondWs(string strWhereCond)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
int intRecNum = objQxPrjDataBaseService.QxPrjDataBase_DelQxPrjDataBasesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_DelQxPrjDataBasesByCond", "clsQxPrjDataBaseWS:DelQxPrjDataBasesByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
bool bolResult = objQxPrjDataBaseService.QxPrjDataBase_AddNewRecordBySql2(objQxPrjDataBaseEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_AddNewRecordBySql2", "clsQxPrjDataBaseWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxPrjDataBaseEN objQxPrjDataBaseEN)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
bool bolResult = objQxPrjDataBaseService.QxPrjDataBase_UpdateBySql2(objQxPrjDataBaseEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_UpdateBySql2", "clsQxPrjDataBaseWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPrjDataBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPrjDataBaseEN objQxPrjDataBaseEN, string strWhereCond)
{
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
try
{
bool bolResult = objQxPrjDataBaseService.QxPrjDataBase_UpdateBySqlWithCondition(objQxPrjDataBaseEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjDataBase_UpdateBySqlWithCondition", "clsQxPrjDataBaseWS:UpdateBySqlWithCondition", objException.Message);
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
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
bool bolIsExist = objQxPrjDataBaseService.QxPrjDataBase_IsExistRecord(strWhereCond);
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
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
bool bolIsExist = objQxPrjDataBaseService.QxPrjDataBase_IsExist(strQxPrjDataBaseId);
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
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
int intRecCount = objQxPrjDataBaseService.QxPrjDataBase_funGetRecCountByCond(strWhereCond);
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
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
string strMaxQxPrjDataBaseId = objQxPrjDataBaseService.QxPrjDataBase_GetMaxStrId();
return strMaxQxPrjDataBaseId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxPrjDataBaseServiceSoapClient objQxPrjDataBaseService = GetQxPrjDataBaseServiceSoapClient();
string strMaxQxPrjDataBaseId = objQxPrjDataBaseService.QxPrjDataBase_GetMaxStrIdByPrefix(strPrefix);
return strMaxQxPrjDataBaseId;
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