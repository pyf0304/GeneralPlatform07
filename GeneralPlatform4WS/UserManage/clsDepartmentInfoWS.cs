
//类名:clsDepartmentInfoWS
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
using GeneralPlatform4WS.ServiceReferenceDepartmentInfo;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 部门信息(DepartmentInfo)
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public class clsDepartmentInfoWS
{
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public static List<clsDepartmentInfoEN> arrDepartmentInfoObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static DepartmentInfoServiceSoapClient objDepartmentInfoServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
 /// <returns></returns>
public static DepartmentInfoServiceSoapClient GetDepartmentInfoServiceSoapClient()
{
if (objDepartmentInfoServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "DepartmentInfoServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
String strServiceUrl = String.Empty;
if (clsSysPara4WS.bolIsLocalHost == false)
{
strServiceUrl = String.Format("http://{0}/{1}/DepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/DepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
}
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new DepartmentInfoServiceSoapClient(binding, address);
}
else
{
return objDepartmentInfoServiceSoapClient;
}
}

 public clsDepartmentInfoWS()
 {
 }



 ///生成绑定ListView的代码
 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenBindListView)
 /// </summary>
public static int BindLv_DepartmentInfo(System.Windows.Forms.ListView lvDepartmentInfo, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviDepartmentInfo; 
ArrayList arrDepartmentInfoObjList;
//	2、根据条件串获取该表满足条件的DataTable；
arrDepartmentInfoObjList = new clsDepartmentInfoBL.GetDepartmentInfoObjList(strWhereCond);
//	3、设置ListView的列头信息
lvDepartmentInfo.Items.Clear();//清除原来所有Item
lvDepartmentInfo.Columns.Clear();//清除原来所有列头信息
lvDepartmentInfo.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.Columns.Add("部门类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.Columns.Add("所属部门号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.Columns.Add("是否在用", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvDepartmentInfo.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsDepartmentInfoEN objDepartmentInfoEN in arrDepartmentInfoObjList)
{
lviDepartmentInfo = new System.Windows.Forms.ListViewItem();
lviDepartmentInfo.Tag = objDepartmentInfoEN.DepartmentId;
lviDepartmentInfo.Text = objDepartmentInfoEN.DepartmentId.ToString();
lviDepartmentInfo.SubItems.Add(objDepartmentInfoEN.DepartmentName);
lviDepartmentInfo.SubItems.Add(objDepartmentInfoEN.DepartmentAbbrName);
lviDepartmentInfo.SubItems.Add(objDepartmentInfoEN.OrderNum.ToString());
lviDepartmentInfo.SubItems.Add(objDepartmentInfoEN.InUse.ToString());
lviDepartmentInfo.SubItems.Add(objDepartmentInfoEN.Memo);
lvDepartmentInfo.Items.Add(lviDepartmentInfo);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrDepartmentInfoObjList.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDepartmentInfoEN objDepartmentInfoEN)
{
if (!Object.Equals(null, objDepartmentInfoEN.DepartmentId) && getStrLen(objDepartmentInfoEN.DepartmentId) > 8)
{
 throw new Exception("字段[部门Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDepartmentInfoEN.DepartmentName) && getStrLen(objDepartmentInfoEN.DepartmentName) > 100)
{
 throw new Exception("字段[部门名]的长度不能超过100!");
}
if (!Object.Equals(null, objDepartmentInfoEN.DepartmentAbbrName) && getStrLen(objDepartmentInfoEN.DepartmentAbbrName) > 8)
{
 throw new Exception("字段[名称缩写]的长度不能超过8!");
}
if (!Object.Equals(null, objDepartmentInfoEN.DepartmentTypeId) && getStrLen(objDepartmentInfoEN.DepartmentTypeId) > 2)
{
 throw new Exception("字段[部门类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objDepartmentInfoEN.UpDepartmentId) && getStrLen(objDepartmentInfoEN.UpDepartmentId) > 6)
{
 throw new Exception("字段[所属部门号]的长度不能超过6!");
}
if (!Object.Equals(null, objDepartmentInfoEN.Memo) && getStrLen(objDepartmentInfoEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objDepartmentInfoEN.IsCheckProperty = true;
 }

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_DepartmentInfoWs(string strWhereCond)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objDepartmentInfoService.DepartmentInfo_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_GetDataSet", "clsDepartmentInfoWS:GetDataTable_DepartmentInfoWs", objException.Message);
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
public static DataTable GetDataTable_DepartmentInfoByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objDepartmentInfoService.DepartmentInfo_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_GetDataSetByRange", "clsDepartmentInfoWS:GetDataTable_DepartmentInfoByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTable_DepartmentInfoVWs(string strWhereCond)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objDepartmentInfoService.DepartmentInfo_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_GetDataSetV", "clsDepartmentInfoWS:GetDataTable_DepartmentInfoVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDepartmentInfoVWs(string strWhereCond)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objDepartmentInfoService.DepartmentInfo_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_GetDataSetV", "clsDepartmentInfoWS:GetDataTable_DepartmentInfoVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4TabV2ByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lngMinNum">范围之最小值</param>
 /// <param name = "lngMaxNum">范围之最大值</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_DepartmentInfoVByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objDepartmentInfoService.DepartmentInfo_GetDataSetVByRange(strWhereCond, lngMinNum, lngMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_GetDataSetVByRange", "clsDepartmentInfoWS:GetDataTable_DepartmentInfoVByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDepartmentInfoWs(ref clsDepartmentInfoEN objDepartmentInfoEN)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
bool bolResult = objDepartmentInfoService.DepartmentInfo_GetDepartmentInfo(ref objDepartmentInfoEN);
return bolResult;
}

public static clsDepartmentInfoEN GetDepartmentInfoByDepartmentIdWs(string strDepartmentId)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
clsDepartmentInfoEN objDepartmentInfoEN = objDepartmentInfoService.DepartmentInfo_GetDepartmentInfoByDepartmentId(strDepartmentId);
return objDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
string strDepartmentId = objDepartmentInfoService.DepartmentInfo_GetFirstID_S(strWhereCond);
return strDepartmentId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_GetFirstID_S", "clsDepartmentInfoWS:GetFirstID_S", objException.Message);
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
public static clsDepartmentInfoEN GetFirstDepartmentInfo_S(string strWhereCond)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
clsDepartmentInfoEN objDepartmentInfoEN = objDepartmentInfoService.DepartmentInfo_GetFirstDepartmentInfo_S(strWhereCond);
return objDepartmentInfoEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_GetFirstDepartmentInfo_S", "clsDepartmentInfoWS:GetFirstDepartmentInfo_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}


 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetRecObjByKey_Cache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDepartmentInfoEN GetDepartmentInfoObjByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return null;
string strWhereCond = string.Format("1 = 1 order by DepartmentId");
if (arrDepartmentInfoObjLst_Cache == null)
{
arrDepartmentInfoObjLst_Cache = clsDepartmentInfoWS.GetDepartmentInfoObjList(strWhereCond);
}
int intStart = 0;
int intEnd = arrDepartmentInfoObjLst_Cache.Count - 1;
int intMid = 0;
clsDepartmentInfoEN objDepartmentInfoEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objDepartmentInfoEN = arrDepartmentInfoObjLst_Cache[intMid];
if (objDepartmentInfoEN.DepartmentId == strDepartmentId)
{
intFindFailCount = 0;
return objDepartmentInfoEN;
}
else if (objDepartmentInfoEN.DepartmentId.CompareTo(strDepartmentId) > 0)
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
arrDepartmentInfoObjLst_Cache = null;
if (intFindFailCount == 1) return GetDepartmentInfoObjByDepartmentId_Cache(strDepartmentId);
string strErrMsgForGetObjById = string.Format("在DepartmentInfo对象缓存列表中,找不到记录[DepartmentId = {0}][intFindFailCount = {1}](函数:GetDepartmentInfoObjByDepartmentId_Cache)", strDepartmentId, intFindFailCount);
if (objDepartmentInfoEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objDepartmentInfoEN.DepartmentId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsGeneralTab2.LogErrorS2("clsDepartmentInfoBL", "GetDepartmentInfoObjByDepartmentId_Cache", strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

public static List<clsDepartmentInfoEN> GetDepartmentInfoObjList(string strWhereCond)
{
 List<clsDepartmentInfoEN> arrObjList = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_DepartmentInfoWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
objDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objDepartmentInfoEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objDepartmentInfoEN);
	}
objDT = null;
return arrObjList;
}

public static List<clsDepartmentInfoEN> GetDepartmentInfoObjListByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
 List<clsDepartmentInfoEN> arrObjList = new List<clsDepartmentInfoEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTable_DepartmentInfoByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjList;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDepartmentInfoEN objDepartmentInfoEN = new clsDepartmentInfoEN();
objDepartmentInfoEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objDepartmentInfoEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objDepartmentInfoEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objDepartmentInfoEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objDepartmentInfoEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objDepartmentInfoEN.OrderNum = Int32.Parse(objRow["OrderNum"].ToString().Trim()); //排序号
objDepartmentInfoEN.InUse = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["InUse"].ToString().Trim()); //是否在用
objDepartmentInfoEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjList.Add(objDepartmentInfoEN);
	}
objDT = null;
return arrObjList;
}

public static bool DelRecordWs(string strDepartmentId)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
bool bolResult = objDepartmentInfoService.DepartmentInfo_DelRecord(strDepartmentId);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_DelRecord", "clsDepartmentInfoWS:DelRecordWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool DelDepartmentInfosWs(List<string> arrDepartmentId)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
string[] sstrDepartmentId = (string[])(arrDepartmentId.ToArray());
bool bolResult = objDepartmentInfoService.DepartmentInfo_DelDepartmentInfos(sstrDepartmentId);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_DelDepartmentInfos", "clsDepartmentInfoWS:DelDepartmentInfosWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static int DelDepartmentInfosByCondWs(string strWhereCond)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
int intRecNum = objDepartmentInfoService.DepartmentInfo_DelDepartmentInfosByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_DelDepartmentInfosByCond", "clsDepartmentInfoWS:DelDepartmentInfosByCondWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool AddNewRecordBySql2Ws(clsDepartmentInfoEN objDepartmentInfoEN)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
bool bolResult = objDepartmentInfoService.DepartmentInfo_AddNewRecordBySql2(objDepartmentInfoEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_AddNewRecordBySql2", "clsDepartmentInfoWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDepartmentInfoEN objDepartmentInfoEN)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
string strKey = objDepartmentInfoService.DepartmentInfo_AddNewRecordBySql2WithReturnKey(objDepartmentInfoEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_AddNewRecordBySql2WithReturnKey", "clsDepartmentInfoWS:AddNewRecordBySql2WithReturnKey", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool UpdateBySql2Ws(clsDepartmentInfoEN objDepartmentInfoEN)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
bool bolResult = objDepartmentInfoService.DepartmentInfo_UpdateBySql2(objDepartmentInfoEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_UpdateBySql2", "clsDepartmentInfoWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objDepartmentInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsDepartmentInfoEN objDepartmentInfoEN, string strWhereCond)
{
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
try
{
bool bolResult = objDepartmentInfoService.DepartmentInfo_UpdateBySqlWithCondition(objDepartmentInfoEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(), "DepartmentInfo_UpdateBySqlWithCondition", "clsDepartmentInfoWS:UpdateBySqlWithCondition", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
bool bolIsExist = objDepartmentInfoService.DepartmentInfo_IsExistRecord(strWhereCond);
return bolIsExist;
}

public static bool IsExistWs(string strDepartmentId)
{
//检测记录是否存在
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
bool bolIsExist = objDepartmentInfoService.DepartmentInfo_IsExist(strDepartmentId);
return bolIsExist;
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdWs()
{
//检测记录是否存在
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
string strMaxDepartmentId = objDepartmentInfoService.DepartmentInfo_GetMaxStrId();
return strMaxDepartmentId;
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefixWs(string strPrefix)
{
//检测记录是否存在
DepartmentInfoServiceSoapClient objDepartmentInfoService = GetDepartmentInfoServiceSoapClient();
string strMaxDepartmentId = objDepartmentInfoService.DepartmentInfo_GetMaxStrIdByPrefix(strPrefix);
return strMaxDepartmentId;
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int getStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
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
strServiceUrl = String.Format("http://{0}/{1}/DepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);
}
else
{
strServiceUrl = String.Format("http://{0}/DepartmentInfoService.asmx", clsSysPara4WS.strCurrIPAddressAndPort_Local);
}
 return strServiceUrl;
}
}
}