
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
using GeneralPlatform4WS.ServiceReferencePrjFileRela;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
/// <summary>
/// 项目相关文件(PrjFileRela)
/// </summary>
public class clsQxPrjFileRelaWS
{
private static PrjFileRelaServiceSoapClient objPrjFileRelaServiceSoapClient = null;
/// <summary>
/// 
/// </summary>
/// <returns></returns>
public static PrjFileRelaServiceSoapClient GetQxPrjFileRelaServiceSoapClient()
{
if (objPrjFileRelaServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "PrjFileRelaServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
String strServiceUrl = String.Empty;
if (clsSysPara.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/PrjFileRelaService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/PrjFileRelaService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new PrjFileRelaServiceSoapClient(binding, address);
}
else
{
return objPrjFileRelaServiceSoapClient;
}
}

 public clsQxPrjFileRelaWS()
 {
 }


///绑定下拉框的函数代码

///生成绑定ListView的代码
/// <summary>
/// 函数功能：根据界面上查询控件中所设置内容查询表记录，
///			 并显示在ListView中。
/// </summary>
public static int BindLv_QxPrjFileRela(System.Windows.Forms.ListView lvPrjFileRela, string strWhereCond)
{
//操作步骤：(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviPrjFileRela; 
ArrayList arrPrjFileRelaObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrPrjFileRelaObjList = GetQxPrjFileRelaObjList(strWhereCond);
//	3、设置ListView的列头信息
lvPrjFileRela.Items.Clear();//清除原来所有Item
lvPrjFileRela.Columns.Clear();//清除原来所有列头信息
lvPrjFileRela.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("文件路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("是否需要下载", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("版本", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvPrjFileRela.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxPrjFileRelaEN objPrjFileRelaEN in arrPrjFileRelaObjList)
{
lviPrjFileRela = new System.Windows.Forms.ListViewItem();
lviPrjFileRela.Tag = objPrjFileRelaEN.mId;
lviPrjFileRela.Text = objPrjFileRelaEN.mId.ToString();
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.QxPrjId);
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.FileName);
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.FilePath);
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.IsNeedDownLoad.ToString());
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.Version);
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.UpdDate);
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.UpdUserId);
lviPrjFileRela.SubItems.Add(objPrjFileRelaEN.Memo);
lvPrjFileRela.Items.Add(lviPrjFileRela);
}
//	4、设置记录数的状态，
//		在本界面中是把状态显示在控件txtRecCount中。
return arrPrjFileRelaObjList.Count;
}

public static DataTable GetDataTable_QxPrjFileRelaWs(string strWhereCond)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objPrjFileRelaService.PrjFileRela_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:PrjFileRela 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetDataTable_QxPrjFileRelaVWs(string strWhereCond)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objPrjFileRelaService.PrjFileRela_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:PrjFileRela View 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetQxPrjFileRelaVWs(string strWhereCond)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objPrjFileRelaService.PrjFileRela_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception ("获取表View数据出错！\r\n" + objException.Message);
}
}

public static bool GetQxPrjFileRelaWs(ref clsQxPrjFileRelaEN objPrjFileRelaEN)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
bool bolResult = objPrjFileRelaService.PrjFileRela_GetQxPrjFileRela(ref objPrjFileRelaEN);
return bolResult;
}

public static ArrayList GetQxPrjFileRelaObjList(string strCondition)
{
ArrayList arrObjList = new ArrayList(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_QxPrjFileRelaWs(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxPrjFileRelaEN objPrjFileRelaEN = new clsQxPrjFileRelaEN();
objPrjFileRelaEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objPrjFileRelaEN.QxPrjId = objRow[clsQxProjectsEN.con_QxPrjId].ToString().Trim(); //项目Id
objPrjFileRelaEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objPrjFileRelaEN.FilePath = objRow["FilePath"].ToString().Trim(); //文件路径
objPrjFileRelaEN.IsNeedDownLoad = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsNeedDownLoad"].ToString().Trim()); //是否需要下载
objPrjFileRelaEN.Version = objRow["Version"].ToString().Trim(); //版本
objPrjFileRelaEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objPrjFileRelaEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objPrjFileRelaEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objPrjFileRelaEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(long lngmId)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
try
{
bool bolResult = objPrjFileRelaService.PrjFileRela_DelRecord(lngmId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool DelPrjFileRelasWs(List<string> arrmId)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
try
{
string[] slngmId = (string[])(arrmId.ToArray());
bool bolResult = objPrjFileRelaService.PrjFileRela_DelPrjFileRelas(slngmId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static int DelPrjFileRelasByCondWs(string strWhereCond)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
try
{
int intRecNum = objPrjFileRelaService.PrjFileRela_DelPrjFileRelasByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2Ws(clsQxPrjFileRelaEN objPrjFileRelaEN)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
try
{
bool bolResult = objPrjFileRelaService.PrjFileRela_AddNewRecordBySql2(objPrjFileRelaEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("添加记录出错！\r\n" + objException.Message);
}
}

public static bool UpdateBySql2Ws(clsQxPrjFileRelaEN objPrjFileRelaEN)
{
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
try
{
bool bolResult = objPrjFileRelaService.PrjFileRela_UpdateBySql2(objPrjFileRelaEN);
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
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
bool bolIsExist = objPrjFileRelaService.PrjFileRela_IsExistRecordByCond(strCondition);
return bolIsExist;
}

public static bool IsExistWs(long lngmId)
{
//检测记录是否存在
PrjFileRelaServiceSoapClient objPrjFileRelaService = GetQxPrjFileRelaServiceSoapClient();
bool bolIsExist = objPrjFileRelaService.PrjFileRela_IsExist(lngmId);
return bolIsExist;
}

}
}