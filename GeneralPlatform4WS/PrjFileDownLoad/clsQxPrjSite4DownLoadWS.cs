
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjSite4DownLoadWS
 表名:QxPrjSite4DownLoad(00140055)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:09
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
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
using GeneralPlatform4WS.ServiceReferenceQxPrjSite4DownLoad;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 文件下载站点(QxPrjSite4DownLoad)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjSite4DownLoadWS
{
private static string mstrPageName = "QxPrjSite4DownLoadService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static QxPrjSite4DownLoadServiceSoapClient GetQxPrjSite4DownLoadServiceSoapClient()
{
if (objQxPrjSite4DownLoadServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "QxPrjSite4DownLoadServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new QxPrjSite4DownLoadServiceSoapClient(binding, address);
}
else
{
return objQxPrjSite4DownLoadServiceSoapClient;
}
}

 public clsQxPrjSite4DownLoadWS()
 {
 }

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_ComboBoxBindFunction)
 /// </summary>
 /// <param name="objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_PrjSiteId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
//初始化一个对象列表
List<clsQxPrjSite4DownLoadEN> arrObjLst = GetObjLst("1 = 1");
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
objQxPrjSite4DownLoadEN.PrjSiteId = "0";
objQxPrjSite4DownLoadEN.PrjSiteName = "请选择[文件下载站点]...";
arrObjLst.Insert(0, objQxPrjSite4DownLoadEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = arrObjLst;
objComboBox.ValueMember="PrjSiteId";
objComboBox.DisplayMember="PrjSiteName";
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjSiteId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[文件下载站点]...","0");
List<clsQxPrjSite4DownLoadEN> arrObjLst = GetObjLst("1 = 1");
objDDL.DataValueField="PrjSiteId";
objDDL.DataTextField="PrjSiteName";
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
public static int BindLv_QxPrjSite4DownLoad(System.Windows.Forms.ListView lvQxPrjSite4DownLoad, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviQxPrjSite4DownLoad; 
List<clsQxPrjSite4DownLoadEN> arrQxPrjSite4DownLoadObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrQxPrjSite4DownLoadObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvQxPrjSite4DownLoad.Items.Clear();//清除原来所有Item
lvQxPrjSite4DownLoad.Columns.Clear();//清除原来所有列头信息
lvQxPrjSite4DownLoad.Columns.Add("工程站点Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("工程站点名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("Ftp服务器", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("Ftp用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("Ftp用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvQxPrjSite4DownLoad.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN in arrQxPrjSite4DownLoadObjLst)
{
lviQxPrjSite4DownLoad = new System.Windows.Forms.ListViewItem();
lviQxPrjSite4DownLoad.Tag = objQxPrjSite4DownLoadEN.PrjSiteId;
lviQxPrjSite4DownLoad.Text = objQxPrjSite4DownLoadEN.PrjSiteId.ToString();
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.PrjSiteName);
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.QxPrjId);
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.FtpServer);
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.FtpUserId);
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.FtpUserPassword);
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.UpdDate);
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.UpdUserId);
lviQxPrjSite4DownLoad.SubItems.Add(objQxPrjSite4DownLoadEN.Memo);
lvQxPrjSite4DownLoad.Items.Add(lviQxPrjSite4DownLoad);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrQxPrjSite4DownLoadObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.PrjSiteId) && GetStrLen(objQxPrjSite4DownLoadEN.PrjSiteId) > 6)
{
 throw new Exception("字段[工程站点Id]的长度不能超过6!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.PrjSiteName) && GetStrLen(objQxPrjSite4DownLoadEN.PrjSiteName) > 50)
{
 throw new Exception("字段[工程站点名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.QxPrjId) && GetStrLen(objQxPrjSite4DownLoadEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.FtpServer) && GetStrLen(objQxPrjSite4DownLoadEN.FtpServer) > 50)
{
 throw new Exception("字段[Ftp服务器]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.FtpUserId) && GetStrLen(objQxPrjSite4DownLoadEN.FtpUserId) > 20)
{
 throw new Exception("字段[Ftp用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.FtpUserPassword) && GetStrLen(objQxPrjSite4DownLoadEN.FtpUserPassword) > 50)
{
 throw new Exception("字段[Ftp用户口令]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.UpdDate) && GetStrLen(objQxPrjSite4DownLoadEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.UpdUserId) && GetStrLen(objQxPrjSite4DownLoadEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objQxPrjSite4DownLoadEN.Memo) && GetStrLen(objQxPrjSite4DownLoadEN.Memo) > 1000)
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
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_GetDataSet", "clsQxPrjSite4DownLoadWS:GetDataTableWs", objException.Message);
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
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_GetTopDataSet", "clsQxPrjSite4DownLoadWS:GetDataTable_TopWs", objException.Message);
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
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_GetDataSetByRange", "clsQxPrjSite4DownLoadWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_GetDataSetV", "clsQxPrjSite4DownLoadWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetQxPrjSite4DownLoadVWs(string strWhereCond)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_GetDataSetV", "clsQxPrjSite4DownLoadWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxPrjSite4DownLoadWs(ref clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
bool bolResult = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetQxPrjSite4DownLoad(ref objQxPrjSite4DownLoadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjSiteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjSite4DownLoadEN GetObjByPrjSiteIdWs(string strPrjSiteId)
{
strPrjSiteId = strPrjSiteId.Replace("'", "");
strPrjSiteId = strPrjSiteId.Replace(" ", "");
strPrjSiteId = strPrjSiteId.Replace("(", "");
strPrjSiteId = strPrjSiteId.Replace(")", "");
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetObjByPrjSiteId(strPrjSiteId);
return objQxPrjSite4DownLoadEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
string strPrjSiteId = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetFirstID_S(strWhereCond);
return strPrjSiteId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_GetFirstID_S", "clsQxPrjSite4DownLoadWS:GetFirstID_S", objException.Message);
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
public static clsQxPrjSite4DownLoadEN GetFirstQxPrjSite4DownLoad_S(string strWhereCond)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetFirstObj_S(strWhereCond);
return objQxPrjSite4DownLoadEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_GetFirstObj_S", "clsQxPrjSite4DownLoadWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjSiteNameByPrjSiteId_Cache(string strPrjSiteId)
{
if (string.IsNullOrEmpty(strPrjSiteId) == true) return "";
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjSite4DownLoadObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjSite4DownLoadEN = arrQxPrjSite4DownLoadObjLst_Cache[intMid];
if (objQxPrjSite4DownLoadEN.PrjSiteId == strPrjSiteId)
{
intFindFailCount = 0;
return objQxPrjSite4DownLoadEN.PrjSiteName;
}
else if (objQxPrjSite4DownLoadEN.PrjSiteId.CompareTo(strPrjSiteId) > 0)
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
arrQxPrjSite4DownLoadObjLst_Cache = null;
if (intFindFailCount == 1) return GetPrjSiteNameByPrjSiteId_Cache(strPrjSiteId);
string strErrMsgForGetObjById = string.Format("在QxPrjSite4DownLoad对象缓存列表中,找不到记录[PrjSiteId = {0}][intFindFailCount = {1}](函数:{2})", strPrjSiteId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjSite4DownLoadEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjSite4DownLoadEN.PrjSiteId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjSite4DownLoadBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by PrjSiteId");
if (arrQxPrjSite4DownLoadObjLst_Cache == null)
{
arrQxPrjSite4DownLoadObjLst_Cache = clsQxPrjSite4DownLoadWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strPrjSiteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxPrjSite4DownLoadEN GetObjByPrjSiteId_Cache(string strPrjSiteId)
{
if (string.IsNullOrEmpty(strPrjSiteId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrQxPrjSite4DownLoadObjLst_Cache.Count - 1;
int intMid = 0;
clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objQxPrjSite4DownLoadEN = arrQxPrjSite4DownLoadObjLst_Cache[intMid];
if (objQxPrjSite4DownLoadEN.PrjSiteId == strPrjSiteId)
{
intFindFailCount = 0;
return objQxPrjSite4DownLoadEN;
}
else if (objQxPrjSite4DownLoadEN.PrjSiteId.CompareTo(strPrjSiteId) > 0)
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
arrQxPrjSite4DownLoadObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByPrjSiteId_Cache(strPrjSiteId);
string strErrMsgForGetObjById = string.Format("在QxPrjSite4DownLoad对象缓存列表中,找不到记录[PrjSiteId = {0}][intFindFailCount = {1}](函数:{2})", strPrjSiteId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objQxPrjSite4DownLoadEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objQxPrjSite4DownLoadEN.PrjSiteId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsQxPrjSite4DownLoadBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjSite4DownLoadEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
objQxPrjSite4DownLoadEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow["PrjSiteName"].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow["FtpServer"].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow["FtpUserId"].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow["FtpUserPassword"].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
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
public static List<clsQxPrjSite4DownLoadEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsQxPrjSite4DownLoadEN> arrObjLst = new List<clsQxPrjSite4DownLoadEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
objQxPrjSite4DownLoadEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objQxPrjSite4DownLoadEN.PrjSiteName = objRow["PrjSiteName"].ToString().Trim(); //工程站点名
objQxPrjSite4DownLoadEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objQxPrjSite4DownLoadEN.FtpServer = objRow["FtpServer"].ToString().Trim(); //Ftp服务器
objQxPrjSite4DownLoadEN.FtpUserId = objRow["FtpUserId"].ToString().Trim(); //Ftp用户Id
objQxPrjSite4DownLoadEN.FtpUserPassword = objRow["FtpUserPassword"].ToString().Trim(); //Ftp用户口令
objQxPrjSite4DownLoadEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objQxPrjSite4DownLoadEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objQxPrjSite4DownLoadEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objQxPrjSite4DownLoadEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(string strPrjSiteId)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
int intResult = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_DelRecord(strPrjSiteId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_DelRecord", "clsQxPrjSite4DownLoadWS:DelRecordWs", objException.Message);
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
public static int DelQxPrjSite4DownLoadsWs(List<string> arrPrjSiteId)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrPrjSiteId);
int intResult = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_DelQxPrjSite4DownLoads(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_DelQxPrjSite4DownLoads", "clsQxPrjSite4DownLoadWS:DelQxPrjSite4DownLoadsWs", objException.Message);
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
public static int DelQxPrjSite4DownLoadsByCondWs(string strWhereCond)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
int intRecNum = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_DelQxPrjSite4DownLoadsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_DelQxPrjSite4DownLoadsByCond", "clsQxPrjSite4DownLoadWS:DelQxPrjSite4DownLoadsByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
bool bolResult = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_AddNewRecordBySql2(objQxPrjSite4DownLoadEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_AddNewRecordBySql2", "clsQxPrjSite4DownLoadWS:AddNewRecordBySql2Ws", objException.Message);
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
public static bool UpdateBySql2Ws(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
bool bolResult = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_UpdateBySql2(objQxPrjSite4DownLoadEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_UpdateBySql2", "clsQxPrjSite4DownLoadWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objQxPrjSite4DownLoadEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsQxPrjSite4DownLoadEN objQxPrjSite4DownLoadEN, string strWhereCond)
{
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
bool bolResult = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_UpdateBySqlWithCondition(objQxPrjSite4DownLoadEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjSite4DownLoad_UpdateBySqlWithCondition", "clsQxPrjSite4DownLoadWS:UpdateBySqlWithCondition", objException.Message);
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
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
bool bolIsExist = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strPrjSiteId)
{
//检测记录是否存在
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
bool bolIsExist = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_IsExist(strPrjSiteId);
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
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
int intRecCount = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_funGetRecCountByCond(strWhereCond);
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
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
string strMaxPrjSiteId = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetMaxStrId();
return strMaxPrjSiteId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
QxPrjSite4DownLoadServiceSoapClient objQxPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
string strMaxPrjSiteId = objQxPrjSite4DownLoadService.QxPrjSite4DownLoad_GetMaxStrIdByPrefix(strPrefix);
return strMaxPrjSiteId;
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