
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2013/01/19
///生成者：潘以锋
///工程名称：统一平台
///工程ID：0014
///模块中文名：工程文件下载
///模块英文名：PrjFileDownLoad
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.23.1
///========================
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceUserDownLoadLog;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
/// <summary>
/// 用户下载日志(UserDownLoadLog)
/// </summary>
public class clsQxUserDownLoadLogWS
{
private static UserDownLoadLogServiceSoapClient objUserDownLoadLogServiceSoapClient = null;
/// <summary>
/// 
/// </summary>
/// <returns></returns>
public static UserDownLoadLogServiceSoapClient GetQxUserDownLoadLogServiceSoapClient()
{
if (objUserDownLoadLogServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "UserDownLoadLogServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
String strServiceUrl = String.Empty;
if (clsSysPara.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/UserDownLoadLogService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/UserDownLoadLogService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new UserDownLoadLogServiceSoapClient(binding, address);
}
else
{
return objUserDownLoadLogServiceSoapClient;
}
}

 public clsQxUserDownLoadLogWS()
 {
 }


///绑定下拉框的函数代码

///生成绑定ListView的代码
/// <summary>
/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
///			 并显示在ListView中。
/// </summary>
public static int BindLv_QxUserDownLoadLog(System.Windows.Forms.ListView lvUserDownLoadLog, string strWhereCond)
{
//操作步骤：(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviUserDownLoadLog; 
ArrayList arrUserDownLoadLogObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrUserDownLoadLogObjList = GetQxUserDownLoadLogObjList(strWhereCond);
//	3、设置ListView的列头信息
lvUserDownLoadLog.Items.Clear();//清除原来所有Item
lvUserDownLoadLog.Columns.Clear();//清除原来所有列头信息
lvUserDownLoadLog.Columns.Add("用户下载日志Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadLog.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadLog.Columns.Add("工程站点Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadLog.Columns.Add("下载日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadLog.Columns.Add("是否成功", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadLog.Columns.Add("日志信息", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadLog.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadLog.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserDownLoadLogEN objUserDownLoadLogEN in arrUserDownLoadLogObjList)
{
lviUserDownLoadLog = new System.Windows.Forms.ListViewItem();
lviUserDownLoadLog.Tag = objUserDownLoadLogEN.UserDownLoadLogId;
lviUserDownLoadLog.Text = objUserDownLoadLogEN.UserDownLoadLogId.ToString();
lviUserDownLoadLog.SubItems.Add(objUserDownLoadLogEN.UserId);
lviUserDownLoadLog.SubItems.Add(objUserDownLoadLogEN.PrjSiteId);
lviUserDownLoadLog.SubItems.Add(objUserDownLoadLogEN.DownLownDate);
lviUserDownLoadLog.SubItems.Add(objUserDownLoadLogEN.IsSuccess.ToString());
lviUserDownLoadLog.SubItems.Add(objUserDownLoadLogEN.LogInfo);
lviUserDownLoadLog.SubItems.Add(objUserDownLoadLogEN.Memo);
lvUserDownLoadLog.Items.Add(lviUserDownLoadLog);
}
//	4、设置记录数的状态，
//		在本界面中是把状态显示在控件txtRecCount中。
return arrUserDownLoadLogObjList.Count;
}

public static DataTable GetDataTable_QxUserDownLoadLogWs(string strWhereCond)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserDownLoadLogService.UserDownLoadLog_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:UserDownLoadLog 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetDataTable_QxUserDownLoadLogVWs(string strWhereCond)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserDownLoadLogService.UserDownLoadLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:UserDownLoadLog View 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetQxUserDownLoadLogVWs(string strWhereCond)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserDownLoadLogService.UserDownLoadLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception ("获取表View数据出错！\r\n" + objException.Message);
}
}

public static bool GetQxUserDownLoadLogWs(ref clsQxUserDownLoadLogEN objUserDownLoadLogEN)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
bool bolResult = objUserDownLoadLogService.UserDownLoadLog_GetQxUserDownLoadLog(ref objUserDownLoadLogEN);
return bolResult;
}

public static ArrayList GetQxUserDownLoadLogObjList(string strCondition)
{
ArrayList arrObjList = new ArrayList(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_QxUserDownLoadLogWs(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadLogEN objUserDownLoadLogEN = new clsQxUserDownLoadLogEN();
objUserDownLoadLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objUserDownLoadLogEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objUserDownLoadLogEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objUserDownLoadLogEN.DownLownDate = objRow["DownLownDate"].ToString().Trim(); //下载日期
objUserDownLoadLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objUserDownLoadLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objUserDownLoadLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objUserDownLoadLogEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(string strUserDownLoadLogId)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
bool bolResult = objUserDownLoadLogService.UserDownLoadLog_DelRecord(strUserDownLoadLogId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool DelQxUserDownLoadLogsWs(List<string> arrUserDownLoadLogId)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
string[] sstrUserDownLoadLogId = (string[])(arrUserDownLoadLogId.ToArray());
bool bolResult = objUserDownLoadLogService.UserDownLoadLog_DelQxUserDownLoadLogs(sstrUserDownLoadLogId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static int DelQxUserDownLoadLogsByCondWs(string strWhereCond)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
int intRecNum = objUserDownLoadLogService.UserDownLoadLog_DelQxUserDownLoadLogsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2Ws(clsQxUserDownLoadLogEN objUserDownLoadLogEN)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
bool bolResult = objUserDownLoadLogService.UserDownLoadLog_AddNewRecordBySql2(objUserDownLoadLogEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("添加记录出错！\r\n" + objException.Message);
}
}

public static bool UpdateBySql2Ws(clsQxUserDownLoadLogEN objUserDownLoadLogEN)
{
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
try
{
bool bolResult = objUserDownLoadLogService.UserDownLoadLog_UpdateBySql2(objUserDownLoadLogEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("添加记录出错！\r\n" + objException.Message);
}
}

public static bool IsExistRecordWs(string strCondition)
{
//检测记录是否存在
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
bool bolIsExist = objUserDownLoadLogService.UserDownLoadLog_IsExistRecordByCond(strCondition);
return bolIsExist;
}

public static bool IsExistWs(string strUserDownLoadLogId)
{
//检测记录是否存在
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
bool bolIsExist = objUserDownLoadLogService.UserDownLoadLog_IsExist(strUserDownLoadLogId);
return bolIsExist;
}

public static string GetMaxStrIdWs()
{
//检测记录是否存在
UserDownLoadLogServiceSoapClient objUserDownLoadLogService = GetQxUserDownLoadLogServiceSoapClient();
string strMaxUserDownLoadLogId = objUserDownLoadLogService.UserDownLoadLog_GetMaxStrId();
return strMaxUserDownLoadLogId;
}
}
}