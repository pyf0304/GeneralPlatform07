
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
using GeneralPlatform4WS.ServiceReferenceCodeType;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
/// <summary>
/// 代码类型(CodeType)
/// </summary>
public class clsQxCodeTypeWS
{
private static CodeTypeServiceSoapClient objCodeTypeServiceSoapClient = null;
/// <summary>
/// 
/// </summary>
/// <returns></returns>
public static CodeTypeServiceSoapClient GetCodeTypeServiceSoapClient()
{
if (objCodeTypeServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "CodeTypeServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
String strServiceUrl = String.Empty;
if (clsSysPara.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/CodeTypeService.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/CodeTypeService.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new CodeTypeServiceSoapClient(binding, address);
}
else
{
return objCodeTypeServiceSoapClient;
}
}

 public clsQxCodeTypeWS()
 {
 }

public static System.Data.DataTable GetCodeTypeId()
{
//获取某学院所有专业信息
string strSQL = "select QxCodeTypeId, CodeTypeName from CodeType ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public static void BindCbo_CodeTypeId(System.Windows.Forms.ComboBox objComboBox)
{
//为数据源为表的下拉框设置内容
System.Data.DataTable objDT = GetDataTable_CodeTypeWs("1=1");
clsQxCodeTypeEN objCodeTypeEN;
//初始化一个对象列表
ArrayList CodeTypeList = new ArrayList();
//插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
objCodeTypeEN = new clsQxCodeTypeEN();
objCodeTypeEN.QxCodeTypeId = "0";
objCodeTypeEN.CodeTypeName = "请选择...";
CodeTypeList.Add(objCodeTypeEN);
//把DataTable中的所有项均加到对象列表中
foreach(DataRow objRow in objDT.Rows)
{
objCodeTypeEN = new clsQxCodeTypeEN();
objCodeTypeEN.QxCodeTypeId = objRow["QxCodeTypeId"].ToString();
objCodeTypeEN.CodeTypeName = objRow["CodeTypeName"].ToString();
CodeTypeList.Add(objCodeTypeEN);
}
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.DataSource = CodeTypeList;
objComboBox.ValueMember="QxCodeTypeId";
objComboBox.DisplayMember="CodeTypeName";
objComboBox.SelectedIndex = 0;
}

///绑定下拉框的函数代码
public static void BindDdl_CodeTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li=new System.Web.UI.WebControls.ListItem("请选择...","0");
System.Data.DataTable objDT = GetDataTable_CodeTypeWs("1=1");
objDDL.DataValueField="QxCodeTypeId";
objDDL.DataTextField="CodeTypeName";
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
public static int BindLv_CodeType(System.Windows.Forms.ListView lvCodeType, string strWhereCond)
{
//操作步骤：(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviCodeType; 
ArrayList arrCodeTypeObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrCodeTypeObjList = GetCodeTypeObjList(strWhereCond);
//	3、设置ListView的列头信息
lvCodeType.Items.Clear();//清除原来所有Item
lvCodeType.Columns.Clear();//清除原来所有列头信息
lvCodeType.Columns.Add("代码类型Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCodeType.Columns.Add("代码类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCodeType.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCodeType.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsQxCodeTypeEN objCodeTypeEN in arrCodeTypeObjList)
{
lviCodeType = new System.Windows.Forms.ListViewItem();
lviCodeType.Tag = objCodeTypeEN.QxCodeTypeId;
lviCodeType.Text = objCodeTypeEN.QxCodeTypeId.ToString();
lviCodeType.SubItems.Add(objCodeTypeEN.CodeTypeName);
lviCodeType.SubItems.Add(objCodeTypeEN.Memo);
lvCodeType.Items.Add(lviCodeType);
}
//	4、设置记录数的状态，
//		在本界面中是把状态显示在控件txtRecCount中。
return arrCodeTypeObjList.Count;
}

public static DataTable GetDataTable_CodeTypeWs(string strWhereCond)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCodeTypeService.CodeType_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:CodeType 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetDataTable_CodeTypeVWs(string strWhereCond)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCodeTypeService.CodeType_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception("获取表:CodeType View 数据出错！\r\n" + objException.Message);
}
}

public static DataTable GetCodeTypeVWs(string strWhereCond)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCodeTypeService.CodeType_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
throw new Exception ("获取表View数据出错！\r\n" + objException.Message);
}
}

public static bool GetCodeTypeWs(ref clsQxCodeTypeEN objCodeTypeEN)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
bool bolResult = objCodeTypeService.CodeType_GetCodeType(ref objCodeTypeEN);
return bolResult;
}

public static ArrayList GetCodeTypeObjList(string strCondition)
{
ArrayList arrObjList = new ArrayList(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_CodeTypeWs(strCondition);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxCodeTypeEN objCodeTypeEN = new clsQxCodeTypeEN();
objCodeTypeEN.QxCodeTypeId = objRow["QxCodeTypeId"].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow["CodeTypeName"].ToString().Trim(); //代码类型名
objCodeTypeEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objCodeTypeEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(string strCodeTypeId)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
try
{
bool bolResult = objCodeTypeService.CodeType_DelRecord(strCodeTypeId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool DelCodeTypesWs(List<string> arrCodeTypeId)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
try
{
string[] sstrCodeTypeId = (string[])(arrCodeTypeId.ToArray());
bool bolResult = objCodeTypeService.CodeType_DelCodeTypes(sstrCodeTypeId);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static int DelCodeTypesByCondWs(string strWhereCond)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
try
{
int intRecNum = objCodeTypeService.CodeType_DelCodeTypesByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
throw new Exception("删除记录出错！\r\n" + objException.Message);
}
}

public static bool AddNewRecordBySql2Ws(clsQxCodeTypeEN objCodeTypeEN)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
try
{
bool bolResult = objCodeTypeService.CodeType_AddNewRecordBySql2(objCodeTypeEN);
return bolResult;
}
catch (Exception objException)
{
throw new Exception("添加记录出错！\r\n" + objException.Message);
}
}

public static bool UpdateBySql2Ws(clsQxCodeTypeEN objCodeTypeEN)
{
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
try
{
bool bolResult = objCodeTypeService.CodeType_UpdateBySql2(objCodeTypeEN);
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
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
bool bolIsExist = objCodeTypeService.CodeType_IsExistRecordByCond(strCondition);
return bolIsExist;
}

public static bool IsExistWs(string strCodeTypeId)
{
//检测记录是否存在
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
bool bolIsExist = objCodeTypeService.CodeType_IsExist(strCodeTypeId);
return bolIsExist;
}

public static string GetMaxStrIdWs()
{
//检测记录是否存在
CodeTypeServiceSoapClient objCodeTypeService = GetCodeTypeServiceSoapClient();
string strMaxCodeTypeId = objCodeTypeService.CodeType_GetMaxStrId();
return strMaxCodeTypeId;
}
}
}