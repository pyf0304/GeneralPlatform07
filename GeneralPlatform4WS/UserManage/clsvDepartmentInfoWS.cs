
//类名:clsvDepartmentInfoWS
 ///----------------------
 ///生成代码版本:2017.01.19.1
 ///生成日期:2017/01/23
 ///生成者:
 ///工程名称:统一平台
 ///工程ID:0014
 ///模块中文名:用户管理
 ///模块英文名:UserManage
 ///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.12.13.01
 ///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 /// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferencevDepartmentInfo;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v部门信息(vDepartmentInfo)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public class clsvDepartmentInfoWS
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public static List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vDepartmentInfoServiceSoapClient objvDepartmentInfoServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
 /// <returns></returns>
public static vDepartmentInfoServiceSoapClient GetvDepartmentInfoServiceSoapClient()
{
if (objvDepartmentInfoServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vDepartmentInfoServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
String strServiceUrl = String.Empty;
if (clsSysPara4WS.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/vDepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/vDepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vDepartmentInfoServiceSoapClient(binding, address);
}
else
{
return objvDepartmentInfoServiceSoapClient;
}
}

 public clsvDepartmentInfoWS()
 {
 }


 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...","0");
System.Data.DataTable objDT = GetDepartmentId();
objDDL.DataValueField = clsvDepartmentInfoEN.con_DepartmentId;
objDDL.DataTextField = clsvDepartmentInfoEN.con_DepartmentName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 ///生成绑定ListView的代码
 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenBindListView)
 /// </summary>
public static int BindLv_vDepartmentInfo(System.Windows.Forms.ListView lvvDepartmentInfo, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivDepartmentInfo; 
ArrayList arrvDepartmentInfoObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrvDepartmentInfoObjList = new clsvDepartmentInfoBL.GetvDepartmentInfoObjList(strWhereCond);
//	3、设置ListView的列头信息
lvvDepartmentInfo.Items.Clear();//清除原来所有Item
lvvDepartmentInfo.Columns.Clear();//清除原来所有列头信息
lvvDepartmentInfo.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("部门类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("部门类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("所属部门号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("UserNum", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.Columns.Add("上级部门", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvDepartmentInfo.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvDepartmentInfoEN objvDepartmentInfoEN in arrvDepartmentInfoObjList)
{
lvivDepartmentInfo = new System.Windows.Forms.ListViewItem();
lvivDepartmentInfo.Tag = objvDepartmentInfoEN.DepartmentId;
lvivDepartmentInfo.Text = objvDepartmentInfoEN.DepartmentId.ToString();
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.DepartmentName);
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.DepartmentAbbrName);
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.DepartmentTypeId);
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.DepartmentTypeName);
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.UpDepartmentId);
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.OrderNum.ToString());
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.InUse.ToString());
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.Memo);
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.UserNum.ToString());
lvivDepartmentInfo.SubItems.Add(objvDepartmentInfoEN.UpDepartmentName);
lvvDepartmentInfo.Items.Add(lvivDepartmentInfo);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvDepartmentInfoObjList.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_vDepartmentInfoWs(string strWhereCond)
{
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvDepartmentInfoService.vDepartmentInfo_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "vDepartmentInfo_GetDataSet", "clsvDepartmentInfoWS:GetDataTable_vDepartmentInfoWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4TabByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lngMinNum">范围之最小值</param>
 /// <param name = "lngMaxNum">范围之最大值</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_vDepartmentInfoByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
{
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvDepartmentInfoService.vDepartmentInfo_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "vDepartmentInfo_GetDataSetByRange", "clsvDepartmentInfoWS:GetDataTable_vDepartmentInfoByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDepartmentInfoWs(ref clsvDepartmentInfoEN objvDepartmentInfoEN)
{
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
bool bolResult = objvDepartmentInfoService.vDepartmentInfo_GetvDepartmentInfo(ref objvDepartmentInfoEN);
return bolResult;
}

public static clsvDepartmentInfoEN GetvDepartmentInfoByDepartmentIdWs(string strDepartmentId)
{
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
clsvDepartmentInfoEN objvDepartmentInfoEN = objvDepartmentInfoService.vDepartmentInfo_GetvDepartmentInfoByDepartmentId(strDepartmentId);
return objvDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
try
{
string strDepartmentId = objvDepartmentInfoService.vDepartmentInfo_GetFirstID_S(strWhereCond);
return strDepartmentId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "vDepartmentInfo_GetFirstID_S", "clsvDepartmentInfoWS:GetFirstID_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvDepartmentInfoEN GetFirstvDepartmentInfo_S(string strWhereCond)
{
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
try
{
clsvDepartmentInfoEN objvDepartmentInfoEN = objvDepartmentInfoService.vDepartmentInfo_GetFirstvDepartmentInfo_S(strWhereCond);
return objvDepartmentInfoEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "vDepartmentInfo_GetFirstvDepartmentInfo_S", "clsvDepartmentInfoWS:GetFirstvDepartmentInfo_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDepartmentNameByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return "";
string strWhereCond = string.Format("1 = 1 order by DepartmentId");
if (arrvDepartmentInfoObjLst_Cache == null)
{
arrvDepartmentInfoObjLst_Cache = clsvDepartmentInfoWS.GetvDepartmentInfoObjList(strWhereCond);
}
int intStart = 0;
int intEnd = arrvDepartmentInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsvDepartmentInfoEN objvDepartmentInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvDepartmentInfoEN = arrvDepartmentInfoObjLst_Cache[intMid];
if (objvDepartmentInfoEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objvDepartmentInfoEN.DepartmentName;
}
else if (objvDepartmentInfoEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrvDepartmentInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetDepartmentNameByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在vDepartmentInfo对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:GetDepartmentNameByDepartmentId_Cache)", strDepartmentId, intFindFailCount);
if (objvDepartmentInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvDepartmentInfoEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsGeneralTab2.LogErrorS2("clsvDepartmentInfoBL", "GetDepartmentNameByDepartmentId_Cache", strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecObjByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDepartmentInfoEN GetvDepartmentInfoObjByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return null;
string strWhereCond = string.Format("1 = 1 order by DepartmentId");
if (arrvDepartmentInfoObjLst_Cache == null)
{
arrvDepartmentInfoObjLst_Cache = clsvDepartmentInfoWS.GetvDepartmentInfoObjList(strWhereCond);
}
int intStart = 0;
int intEnd = arrvDepartmentInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsvDepartmentInfoEN objvDepartmentInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvDepartmentInfoEN = arrvDepartmentInfoObjLst_Cache[intMid];
if (objvDepartmentInfoEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objvDepartmentInfoEN;
}
else if (objvDepartmentInfoEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrvDepartmentInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetvDepartmentInfoObjByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在vDepartmentInfo对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:GetvDepartmentInfoObjByDepartmentId_Cache)", strDepartmentId, intFindFailCount);
if (objvDepartmentInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvDepartmentInfoEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsGeneralTab2.LogErrorS2("clsvDepartmentInfoBL", "GetvDepartmentInfoObjByDepartmentId_Cache", strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

public static List<clsvDepartmentInfoEN> GetvDepartmentInfoObjList(string strWhereCond)
{
 List<clsvDepartmentInfoEN> arrObjList = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_vDepartmentInfoWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
objvDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvDepartmentInfoEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvDepartmentInfoEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvDepartmentInfoEN.UserNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["UserNum"].ToString().Trim()); //UserNum
objvDepartmentInfoEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
	arrObjList.Add(objvDepartmentInfoEN);
	}
objDT = null;
return arrObjList;
}

public static List<clsvDepartmentInfoEN> GetvDepartmentInfoObjListByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
 List<clsvDepartmentInfoEN> arrObjList = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_vDepartmentInfoByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
objvDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvDepartmentInfoEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvDepartmentInfoEN.OrderNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["OrderNum"].ToString().Trim()); //排序号
objvDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objvDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objvDepartmentInfoEN.UserNum = com.taishsoft.common.clsTranslate.TransNullToInt_S(objRow["UserNum"].ToString().Trim()); //UserNum
objvDepartmentInfoEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
	arrObjList.Add(objvDepartmentInfoEN);
	}
objDT = null;
return arrObjList;
}

public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
bool bolIsExist = objvDepartmentInfoService.vDepartmentInfo_IsExistRecord(strWhereCond);
return bolIsExist;
}

public static bool IsExistWs(string strDepartmentId)
{
//检测记录是否存在
vDepartmentInfoServiceSoapClient objvDepartmentInfoService = GetvDepartmentInfoServiceSoapClient();
bool bolIsExist = objvDepartmentInfoService.vDepartmentInfo_IsExist(strDepartmentId);
return bolIsExist;
}

 /// <summary>
 /// 获取Web服务的地址
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
 /// </summary>
 /// <returns>返回当前文件中Web服务的地址</returns>
public static string GetServiceUrl()
{
String strServiceUrl = String.Empty;
if (clsSysPara4WS.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/vDepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/vDepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
}
 return strServiceUrl;
}
}
}