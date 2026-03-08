
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
using GeneralPlatform4WS.ServiceReferenceUserCodePath;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
/// <summary>
/// 用户生成路径(UserCodePath)
/// </summary>
public class clsQxUserCodePathWS
{
private static UserCodePathServiceSoapClient objUserCodePathServiceSoapClient = null;
/// <summary>
/// 
/// </summary>
/// <returns></returns>
public static UserCodePathServiceSoapClient GetQxUserCodePathServiceSoapClient()
{
if (objUserCodePathServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "UserCodePathServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
String strServiceUrl = String.Empty;
if (clsSysPara.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/UserCodePathService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/UserCodePathService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new UserCodePathServiceSoapClient(binding, address);
}
else
{
return objUserCodePathServiceSoapClient;
}
}

 public clsQxUserCodePathWS()
 {
 }


///绑定下拉框的函数代码

///生成绑定ListView的代码
/// <summary>
/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
///			 并显示在ListView中。
/// </summary>
public static int BindLv_QxUserCodePath(System.Windows.Forms.ListView lvUserCodePath, string strWhereCond)
{
//操作步骤：(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviUserCodePath; 
ArrayList arrUserCodePathObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrUserCodePathObjList = GetQxUserCodePathObjList(strWhereCond);
//	3、设置ListView的列头信息
lvUserCodePath.Items.Clear();//清除原来所有Item
lvUserCodePath.Columns.Clear();//清除原来所有列头信息
lvUserCodePath.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("代码类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("代码路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("备份代码路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("是否模板", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvUserCodePath.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxUserCodePathEN objUserCodePathEN in arrUserCodePathObjList)
{
lviUserCodePath = new System.Windows.Forms.ListViewItem();
lviUserCodePath.Tag = objUserCodePathEN.mId;
lviUserCodePath.Text = objUserCodePathEN.mId.ToString();
lviUserCodePath.SubItems.Add(objUserCodePathEN.QxPrjId);
lviUserCodePath.SubItems.Add(objUserCodePathEN.UserId);
lviUserCodePath.SubItems.Add(objUserCodePathEN.QxCodeTypeId);
lviUserCodePath.SubItems.Add(objUserCodePathEN.CodePath);
lviUserCodePath.SubItems.Add(objUserCodePathEN.CodePathBackup);
lviUserCodePath.SubItems.Add(objUserCodePathEN.IsTemplate.ToString());
lviUserCodePath.SubItems.Add(objUserCodePathEN.UpdDate);
lviUserCodePath.SubItems.Add(objUserCodePathEN.UpdUserId);
lviUserCodePath.SubItems.Add(objUserCodePathEN.Memo);
lvUserCodePath.Items.Add(lviUserCodePath);
}
//	4、设置记录数的状态，
//		在本界面中是把状态显示在控件txtRecCount中。
return arrUserCodePathObjList.Count;
}

public static DataTable GetDataTable_QxUserCodePathWs(string strWhereCond)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserCodePathService.UserCodePath_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:UserCodePath 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetDataTable_QxUserCodePathVWs(string strWhereCond)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserCodePathService.UserCodePath_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:UserCodePath View 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetQxUserCodePathVWs(string strWhereCond)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objUserCodePathService.UserCodePath_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception ("获取表View数据出错！\r\n" + objException.Message);
}
}

public static bool GetQxUserCodePathWs(ref clsQxUserCodePathEN objUserCodePathEN)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
bool bolResult = objUserCodePathService.UserCodePath_GetQxUserCodePath(ref objUserCodePathEN);
return bolResult;
}

public static ArrayList GetQxUserCodePathObjList(string strCondition)
{
ArrayList arrObjList = new ArrayList(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_QxUserCodePathWs(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxUserCodePathEN objUserCodePathEN = new clsQxUserCodePathEN();
objUserCodePathEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objUserCodePathEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
objUserCodePathEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objUserCodePathEN.QxCodeTypeId = objRow["QxCodeTypeId"].ToString().Trim(); //代码类型Id
objUserCodePathEN.CodePath = objRow["CodePath"].ToString().Trim(); //代码路径
objUserCodePathEN.CodePathBackup = objRow["CodePathBackup"].ToString().Trim(); //备份代码路径
objUserCodePathEN.IsTemplate = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsTemplate"].ToString().Trim()); //是否模板
objUserCodePathEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objUserCodePathEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(long lngmId)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
bool bolResult = objUserCodePathService.UserCodePath_DelRecord(lngmId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool DelQxUserCodePathsWs(List<string> arrmId)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
string[] slngmId = (string[])(arrmId.ToArray());
bool bolResult = objUserCodePathService.UserCodePath_DelQxUserCodePaths(slngmId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static int DelQxUserCodePathsByCondWs(string strWhereCond)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
int intRecNum = objUserCodePathService.UserCodePath_DelQxUserCodePathsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2Ws(clsQxUserCodePathEN objUserCodePathEN)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
bool bolResult = objUserCodePathService.UserCodePath_AddNewRecordBySql2(objUserCodePathEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("添加记录出错！\r\n" + objException.Message);
}
}

public static bool UpdateBySql2Ws(clsQxUserCodePathEN objUserCodePathEN)
{
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
try
{
bool bolResult = objUserCodePathService.UserCodePath_UpdateBySql2(objUserCodePathEN);
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
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
bool bolIsExist = objUserCodePathService.UserCodePath_IsExistRecordByCond(strCondition);
return bolIsExist;
}

public static bool IsExistWs(long lngmId)
{
//检测记录是否存在
UserCodePathServiceSoapClient objUserCodePathService = GetQxUserCodePathServiceSoapClient();
bool bolIsExist = objUserCodePathService.UserCodePath_IsExist(lngmId);
return bolIsExist;
}

}
}