
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
using GeneralPlatform4WS.ServiceReferencePrjSite4DownLoad;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
/// <summary>
/// 文件下载站点(PrjSite4DownLoad)
/// </summary>
public class clsQxPrjSite4DownLoadWS
{
private static PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadServiceSoapClient = null;
/// <summary>
/// 
/// </summary>
/// <returns></returns>
public static PrjSite4DownLoadServiceSoapClient GetQxPrjSite4DownLoadServiceSoapClient()
{
if (objPrjSite4DownLoadServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "PrjSite4DownLoadServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
String strServiceUrl = String.Empty;
if (clsSysPara.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/PrjSite4DownLoadService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/PrjSite4DownLoadService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new PrjSite4DownLoadServiceSoapClient(binding, address);
}
else
{
return objPrjSite4DownLoadServiceSoapClient;
}
}

 public clsQxPrjSite4DownLoadWS()
 {
 }

public static System.Data.DataTable GetQxPrjSiteId()
{
//获取某学院所有专业信息
string strSQL = "select PrjSiteId, PrjSiteName from PrjSite4DownLoad ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public static void BindCbo_QxPrjSiteId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetDataTable_QxPrjSite4DownLoadWs("1=1");
clsQxPrjSite4DownLoadEN objPrjSite4DownLoadEN;
//初始化一个对象列表
ArrayList PrjSite4DownLoadList = new ArrayList();
//插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
objPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
objPrjSite4DownLoadEN.PrjSiteId = "0";
objPrjSite4DownLoadEN.PrjSiteName = "请选择...";
PrjSite4DownLoadList.Add(objPrjSite4DownLoadEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
objPrjSite4DownLoadEN.PrjSiteId = objRow["PrjSiteId"].ToString();
objPrjSite4DownLoadEN.PrjSiteName = objRow["PrjSiteName"].ToString();
PrjSite4DownLoadList.Add(objPrjSite4DownLoadEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = PrjSite4DownLoadList;
objComboBox.ValueMember="PrjSiteId";
objComboBox.DisplayMember="PrjSiteName";
objComboBox.SelectedIndex = 0;
}

///绑定下拉框的函数代码
public static void BindDdl_QxPrjSiteId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li=new System.Web.UI.WebControls.ListItem("请选择...","0");
System.Data.DataTable objDT = GetDataTable_QxPrjSite4DownLoadWs("1=1");
objDDL.DataValueField="PrjSiteId";
objDDL.DataTextField="PrjSiteName";
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

///生成绑定ListView的代码
/// <summary>
/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
///			 并显示在ListView中。
/// </summary>
public static int BindLv_QxPrjSite4DownLoad(System.Windows.Forms.ListView lvPrjSite4DownLoad, string strWhereCond)
{
//操作步骤：(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviPrjSite4DownLoad; 
ArrayList arrPrjSite4DownLoadObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrPrjSite4DownLoadObjList = GetQxPrjSite4DownLoadObjList(strWhereCond);
//	3、设置ListView的列头信息
lvPrjSite4DownLoad.Items.Clear();//清除原来所有Item
lvPrjSite4DownLoad.Columns.Clear();//清除原来所有列头信息
lvPrjSite4DownLoad.Columns.Add("工程站点Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("工程站点名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("Ftp服务器", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("Ftp用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("Ftp用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjSite4DownLoad.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjSite4DownLoadEN objPrjSite4DownLoadEN in arrPrjSite4DownLoadObjList)
{
lviPrjSite4DownLoad = new System.Windows.Forms.ListViewItem();
lviPrjSite4DownLoad.Tag = objPrjSite4DownLoadEN.PrjSiteId;
lviPrjSite4DownLoad.Text = objPrjSite4DownLoadEN.PrjSiteId.ToString();
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.PrjSiteName);
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.QxPrjId);
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.FtpServer);
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.FtpUserId);
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.FtpUserPassword);
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.UpdDate);
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.UpdUserId);
lviPrjSite4DownLoad.SubItems.Add(objPrjSite4DownLoadEN.Memo);
lvPrjSite4DownLoad.Items.Add(lviPrjSite4DownLoad);
}
//	4、设置记录数的状态，
//		在本界面中是把状态显示在控件txtRecCount中。
return arrPrjSite4DownLoadObjList.Count;
}

public static DataTable GetDataTable_QxPrjSite4DownLoadWs(string strWhereCond)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objPrjSite4DownLoadService.PrjSite4DownLoad_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:PrjSite4DownLoad 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetDataTable_QxPrjSite4DownLoadVWs(string strWhereCond)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objPrjSite4DownLoadService.PrjSite4DownLoad_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:PrjSite4DownLoad View 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetQxPrjSite4DownLoadVWs(string strWhereCond)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objPrjSite4DownLoadService.PrjSite4DownLoad_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception ("获取表View数据出错！\r\n" + objException.Message);
}
}

public static bool GetQxPrjSite4DownLoadWs(ref clsQxPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
bool bolResult = objPrjSite4DownLoadService.PrjSite4DownLoad_GetQxPrjSite4DownLoad(ref objPrjSite4DownLoadEN);
return bolResult;
}

public static ArrayList GetQxPrjSite4DownLoadObjList(string strCondition)
{
ArrayList arrObjList = new ArrayList(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_QxPrjSite4DownLoadWs(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjSite4DownLoadEN objPrjSite4DownLoadEN = new clsQxPrjSite4DownLoadEN();
objPrjSite4DownLoadEN.PrjSiteId = objRow["PrjSiteId"].ToString().Trim(); //工程站点Id
objPrjSite4DownLoadEN.PrjSiteName = objRow["PrjSiteName"].ToString().Trim(); //工程站点名
objPrjSite4DownLoadEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
objPrjSite4DownLoadEN.FtpServer = objRow["FtpServer"].ToString().Trim(); //Ftp服务器
objPrjSite4DownLoadEN.FtpUserId = objRow["FtpUserId"].ToString().Trim(); //Ftp用户Id
objPrjSite4DownLoadEN.FtpUserPassword = objRow["FtpUserPassword"].ToString().Trim(); //Ftp用户口令
objPrjSite4DownLoadEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objPrjSite4DownLoadEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objPrjSite4DownLoadEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objPrjSite4DownLoadEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(string strPrjSiteId)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
bool bolResult = objPrjSite4DownLoadService.PrjSite4DownLoad_DelRecord(strPrjSiteId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool DelPrjSite4DownLoadsWs(List<string> arrPrjSiteId)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
string[] sstrPrjSiteId = (string[])(arrPrjSiteId.ToArray());
bool bolResult = objPrjSite4DownLoadService.PrjSite4DownLoad_DelPrjSite4DownLoads(sstrPrjSiteId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static int DelPrjSite4DownLoadsByCondWs(string strWhereCond)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
int intRecNum = objPrjSite4DownLoadService.PrjSite4DownLoad_DelPrjSite4DownLoadsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2Ws(clsQxPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
bool bolResult = objPrjSite4DownLoadService.PrjSite4DownLoad_AddNewRecordBySql2(objPrjSite4DownLoadEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("添加记录出错！\r\n" + objException.Message);
}
}

public static bool UpdateBySql2Ws(clsQxPrjSite4DownLoadEN objPrjSite4DownLoadEN)
{
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
try
{
bool bolResult = objPrjSite4DownLoadService.PrjSite4DownLoad_UpdateBySql2(objPrjSite4DownLoadEN);
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
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
bool bolIsExist = objPrjSite4DownLoadService.PrjSite4DownLoad_IsExistRecordByCond(strCondition);
return bolIsExist;
}

public static bool IsExistWs(string strPrjSiteId)
{
//检测记录是否存在
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
bool bolIsExist = objPrjSite4DownLoadService.PrjSite4DownLoad_IsExist(strPrjSiteId);
return bolIsExist;
}

public static string GetMaxStrIdWs()
{
//检测记录是否存在
PrjSite4DownLoadServiceSoapClient objPrjSite4DownLoadService = GetQxPrjSite4DownLoadServiceSoapClient();
string strMaxPrjSiteId = objPrjSite4DownLoadService.PrjSite4DownLoad_GetMaxStrId();
return strMaxPrjSiteId;
}
}
}