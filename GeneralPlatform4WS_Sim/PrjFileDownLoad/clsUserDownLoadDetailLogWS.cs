
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
using GeneralPlatform4WS.ServiceReferenceUserDownLoadDetailLog;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
/// <summary>
/// 用户下载日志细节(UserDownLoadDetailLog)
/// </summary>
public class clsQxUserDownLoadDetailLogWS
{
private static UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogServiceSoapClient = null;
/// <summary>
/// 
/// </summary>
/// <returns></returns>
public static UserDownLoadDetailLogServiceSoapClient GetQxUserDownLoadDetailLogServiceSoapClient()
{
if (objUserDownLoadDetailLogServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "UserDownLoadDetailLogServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
String strServiceUrl = String.Empty;
if (clsSysPara.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/UserDownLoadDetailLogService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/UserDownLoadDetailLogService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new UserDownLoadDetailLogServiceSoapClient(binding, address);
}
else
{
return objUserDownLoadDetailLogServiceSoapClient;
}
}

 public clsQxUserDownLoadDetailLogWS()
 {
 }


///绑定下拉框的函数代码

///生成绑定ListView的代码
/// <summary>
/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
///			 并显示在ListView中。
/// </summary>
public static int BindLv_QxUserDownLoadDetailLog(System.Windows.Forms.ListView lvUserDownLoadDetailLog, string strWhereCond)
{
//操作步骤：(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviUserDownLoadDetailLog; 
ArrayList arrUserDownLoadDetailLogObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrUserDownLoadDetailLogObjList = GetQxUserDownLoadDetailLogObjList(strWhereCond);
//	3、设置ListView的列头信息
lvUserDownLoadDetailLog.Items.Clear();//清除原来所有Item
lvUserDownLoadDetailLog.Columns.Clear();//清除原来所有列头信息
lvUserDownLoadDetailLog.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadDetailLog.Columns.Add("用户下载日志Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadDetailLog.Columns.Add("文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadDetailLog.Columns.Add("版本", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadDetailLog.Columns.Add("是否成功", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadDetailLog.Columns.Add("日志信息", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadDetailLog.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserDownLoadDetailLog.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserDownLoadDetailLogEN objUserDownLoadDetailLogEN in arrUserDownLoadDetailLogObjList)
{
lviUserDownLoadDetailLog = new System.Windows.Forms.ListViewItem();
lviUserDownLoadDetailLog.Tag = objUserDownLoadDetailLogEN.mId;
lviUserDownLoadDetailLog.Text = objUserDownLoadDetailLogEN.mId.ToString();
lviUserDownLoadDetailLog.SubItems.Add(objUserDownLoadDetailLogEN.UserDownLoadLogId);
lviUserDownLoadDetailLog.SubItems.Add(objUserDownLoadDetailLogEN.FileName);
lviUserDownLoadDetailLog.SubItems.Add(objUserDownLoadDetailLogEN.Version);
lviUserDownLoadDetailLog.SubItems.Add(objUserDownLoadDetailLogEN.IsSuccess.ToString());
lviUserDownLoadDetailLog.SubItems.Add(objUserDownLoadDetailLogEN.LogInfo);
lviUserDownLoadDetailLog.SubItems.Add(objUserDownLoadDetailLogEN.Memo);
lvUserDownLoadDetailLog.Items.Add(lviUserDownLoadDetailLog);
}
//	4、设置记录数的状态，
//		在本界面中是把状态显示在控件txtRecCount中。
return arrUserDownLoadDetailLogObjList.Count;
}

public static DataTable GetDataTable_QxUserDownLoadDetailLogWs(string strWhereCond)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserDownLoadDetailLogService.UserDownLoadDetailLog_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:UserDownLoadDetailLog 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetDataTable_QxUserDownLoadDetailLogVWs(string strWhereCond)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserDownLoadDetailLogService.UserDownLoadDetailLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:UserDownLoadDetailLog View 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetQxUserDownLoadDetailLogVWs(string strWhereCond)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserDownLoadDetailLogService.UserDownLoadDetailLog_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception ("获取表View数据出错！\r\n" + objException.Message);
}
}

public static bool GetQxUserDownLoadDetailLogWs(ref clsQxUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
bool bolResult = objUserDownLoadDetailLogService.UserDownLoadDetailLog_GetQxUserDownLoadDetailLog(ref objUserDownLoadDetailLogEN);
return bolResult;
}

public static ArrayList GetQxUserDownLoadDetailLogObjList(string strCondition)
{
ArrayList arrObjList = new ArrayList(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_QxUserDownLoadDetailLogWs(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserDownLoadDetailLogEN objUserDownLoadDetailLogEN = new clsQxUserDownLoadDetailLogEN();
objUserDownLoadDetailLogEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objUserDownLoadDetailLogEN.UserDownLoadLogId = objRow["UserDownLoadLogId"].ToString().Trim(); //用户下载日志Id
objUserDownLoadDetailLogEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objUserDownLoadDetailLogEN.Version = objRow["Version"].ToString().Trim(); //版本
objUserDownLoadDetailLogEN.IsSuccess = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSuccess"].ToString().Trim()); //是否成功
objUserDownLoadDetailLogEN.LogInfo = objRow["LogInfo"].ToString().Trim(); //日志信息
objUserDownLoadDetailLogEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objUserDownLoadDetailLogEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(long lngmId)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
bool bolResult = objUserDownLoadDetailLogService.UserDownLoadDetailLog_DelRecord(lngmId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool DelQxUserDownLoadDetailLogsWs(List<string> arrmId)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
string[] slngmId = (string[])(arrmId.ToArray());
bool bolResult = objUserDownLoadDetailLogService.UserDownLoadDetailLog_DelQxUserDownLoadDetailLogs(slngmId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static int DelQxUserDownLoadDetailLogsByCondWs(string strWhereCond)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
int intRecNum = objUserDownLoadDetailLogService.UserDownLoadDetailLog_DelQxUserDownLoadDetailLogsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2Ws(clsQxUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
bool bolResult = objUserDownLoadDetailLogService.UserDownLoadDetailLog_AddNewRecordBySql2(objUserDownLoadDetailLogEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("添加记录出错！\r\n" + objException.Message);
}
}

public static bool UpdateBySql2Ws(clsQxUserDownLoadDetailLogEN objUserDownLoadDetailLogEN)
{
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
try
{
bool bolResult = objUserDownLoadDetailLogService.UserDownLoadDetailLog_UpdateBySql2(objUserDownLoadDetailLogEN);
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
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
bool bolIsExist = objUserDownLoadDetailLogService.UserDownLoadDetailLog_IsExistRecordByCond(strCondition);
return bolIsExist;
}

public static bool IsExistWs(long lngmId)
{
//检测记录是否存在
UserDownLoadDetailLogServiceSoapClient objUserDownLoadDetailLogService = GetQxUserDownLoadDetailLogServiceSoapClient();
bool bolIsExist = objUserDownLoadDetailLogService.UserDownLoadDetailLog_IsExist(lngmId);
return bolIsExist;
}

}
}