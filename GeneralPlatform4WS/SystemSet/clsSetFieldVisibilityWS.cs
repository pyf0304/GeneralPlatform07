
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSetFieldVisibilityWS
 表名:SetFieldVisibility(00140069)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:15
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
using GeneralPlatform4WS.ServiceReferenceSetFieldVisibility;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 设置字段可视性(SetFieldVisibility)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsSetFieldVisibilityWS
{
private static string mstrPageName = "SetFieldVisibilityService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static SetFieldVisibilityServiceSoapClient objSetFieldVisibilityServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static SetFieldVisibilityServiceSoapClient GetSetFieldVisibilityServiceSoapClient()
{
if (objSetFieldVisibilityServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "SetFieldVisibilityServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new SetFieldVisibilityServiceSoapClient(binding, address);
}
else
{
return objSetFieldVisibilityServiceSoapClient;
}
}

 public clsSetFieldVisibilityWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_SetFieldVisibility(System.Windows.Forms.ListView lvSetFieldVisibility, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviSetFieldVisibility; 
List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrSetFieldVisibilityObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvSetFieldVisibility.Items.Clear();//清除原来所有Item
lvSetFieldVisibility.Columns.Clear();//清除原来所有列头信息
lvSetFieldVisibility.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("学校流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("界面名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("字段名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("控件类型", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("是否显示", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("模块Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.Columns.Add("Caption", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvSetFieldVisibility.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsSetFieldVisibilityEN objSetFieldVisibilityEN in arrSetFieldVisibilityObjLst)
{
lviSetFieldVisibility = new System.Windows.Forms.ListViewItem();
lviSetFieldVisibility.Tag = objSetFieldVisibilityEN.mId;
lviSetFieldVisibility.Text = objSetFieldVisibilityEN.mId.ToString();
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.ViewName);
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.FieldName);
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.CtrlType);
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.IsVisible.ToString());
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.Memo);
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.UpdDate);
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.UpdUserId);
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.FuncModuleId);
lviSetFieldVisibility.SubItems.Add(objSetFieldVisibilityEN.Caption);
lvSetFieldVisibility.Items.Add(lviSetFieldVisibility);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrSetFieldVisibilityObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
if (!Object.Equals(null, objSetFieldVisibilityEN.id_School) && GetStrLen(objSetFieldVisibilityEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.ViewName) && GetStrLen(objSetFieldVisibilityEN.ViewName) > 100)
{
 throw new Exception("字段[界面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.FieldName) && GetStrLen(objSetFieldVisibilityEN.FieldName) > 50)
{
 throw new Exception("字段[字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.CtrlType) && GetStrLen(objSetFieldVisibilityEN.CtrlType) > 50)
{
 throw new Exception("字段[控件类型]的长度不能超过50!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.Memo) && GetStrLen(objSetFieldVisibilityEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UpdDate) && GetStrLen(objSetFieldVisibilityEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.UpdUserId) && GetStrLen(objSetFieldVisibilityEN.UpdUserId) > 18)
{
 throw new Exception("字段[修改用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.FuncModuleId) && GetStrLen(objSetFieldVisibilityEN.FuncModuleId) > 4)
{
 throw new Exception("字段[模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSetFieldVisibilityEN.Caption) && GetStrLen(objSetFieldVisibilityEN.Caption) > 200)
{
 throw new Exception("字段[Caption]的长度不能超过200!");
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
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objSetFieldVisibilityService.SetFieldVisibility_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_GetDataSet", "clsSetFieldVisibilityWS:GetDataTableWs", objException.Message);
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
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objSetFieldVisibilityService.SetFieldVisibility_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_GetTopDataSet", "clsSetFieldVisibilityWS:GetDataTable_TopWs", objException.Message);
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
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objSetFieldVisibilityService.SetFieldVisibility_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_GetDataSetByRange", "clsSetFieldVisibilityWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objSetFieldVisibilityService.SetFieldVisibility_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_GetDataSetV", "clsSetFieldVisibilityWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetSetFieldVisibilityVWs(string strWhereCond)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objSetFieldVisibilityService.SetFieldVisibility_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_GetDataSetV", "clsSetFieldVisibilityWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSetFieldVisibilityWs(ref clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
bool bolResult = objSetFieldVisibilityService.SetFieldVisibility_GetSetFieldVisibility(ref objSetFieldVisibilityEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSetFieldVisibilityEN GetObjBymIdWs(long lngmId)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
clsSetFieldVisibilityEN objSetFieldVisibilityEN = objSetFieldVisibilityService.SetFieldVisibility_GetObjBymId(lngmId);
return objSetFieldVisibilityEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
long lngmId = objSetFieldVisibilityService.SetFieldVisibility_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_GetFirstID_S", "clsSetFieldVisibilityWS:GetFirstID_S", objException.Message);
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
public static clsSetFieldVisibilityEN GetFirstSetFieldVisibility_S(string strWhereCond)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
clsSetFieldVisibilityEN objSetFieldVisibilityEN = objSetFieldVisibilityService.SetFieldVisibility_GetFirstObj_S(strWhereCond);
return objSetFieldVisibilityEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_GetFirstObj_S", "clsSetFieldVisibilityWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by mId");
if (arrSetFieldVisibilityObjLst_Cache == null)
{
arrSetFieldVisibilityObjLst_Cache = clsSetFieldVisibilityWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSetFieldVisibilityEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrSetFieldVisibilityObjLst_Cache.Count - 1;
int intMid = 0;
clsSetFieldVisibilityEN objSetFieldVisibilityEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objSetFieldVisibilityEN = arrSetFieldVisibilityObjLst_Cache[intMid];
if (objSetFieldVisibilityEN.mId == lngmId)
{
intFindFailCount = 0;
return objSetFieldVisibilityEN;
}
else if (objSetFieldVisibilityEN.mId.CompareTo(lngmId) > 0)
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
arrSetFieldVisibilityObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在SetFieldVisibility对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objSetFieldVisibilityEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objSetFieldVisibilityEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsSetFieldVisibilityBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSetFieldVisibilityEN> GetObjLst(string strWhereCond)
{
 List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
objSetFieldVisibilityEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objSetFieldVisibilityEN.id_School = objRow["id_School"].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow["FieldName"].ToString().Trim(); //字段名
objSetFieldVisibilityEN.CtrlType = objRow["CtrlType"].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objSetFieldVisibilityEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objSetFieldVisibilityEN.Caption = objRow["Caption"].ToString().Trim(); //Caption
	arrObjLst.Add(objSetFieldVisibilityEN);
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
public static List<clsSetFieldVisibilityEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsSetFieldVisibilityEN> arrObjLst = new List<clsSetFieldVisibilityEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
objSetFieldVisibilityEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objSetFieldVisibilityEN.id_School = objRow["id_School"].ToString().Trim(); //学校流水号
objSetFieldVisibilityEN.ViewName = objRow["ViewName"].ToString().Trim(); //界面名称
objSetFieldVisibilityEN.FieldName = objRow["FieldName"].ToString().Trim(); //字段名
objSetFieldVisibilityEN.CtrlType = objRow["CtrlType"].ToString().Trim(); //控件类型
objSetFieldVisibilityEN.IsVisible = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsVisible"].ToString().Trim()); //是否显示
objSetFieldVisibilityEN.Memo = objRow["Memo"].ToString().Trim(); //备注
objSetFieldVisibilityEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objSetFieldVisibilityEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objSetFieldVisibilityEN.FuncModuleId = objRow["FuncModuleId"].ToString().Trim(); //模块Id
objSetFieldVisibilityEN.Caption = objRow["Caption"].ToString().Trim(); //Caption
	arrObjLst.Add(objSetFieldVisibilityEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecordWs(long lngmId)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
int intResult = objSetFieldVisibilityService.SetFieldVisibility_DelRecord(lngmId);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_DelRecord", "clsSetFieldVisibilityWS:DelRecordWs", objException.Message);
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
public static int DelSetFieldVisibilitysWs(List<string> arrmId)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
string strJSON = clsJSON.GetJsonFromObjLst<string>(arrmId);
int intResult = objSetFieldVisibilityService.SetFieldVisibility_DelSetFieldVisibilitys(strJSON);
return intResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_DelSetFieldVisibilitys", "clsSetFieldVisibilityWS:DelSetFieldVisibilitysWs", objException.Message);
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
public static int DelSetFieldVisibilitysByCondWs(string strWhereCond)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
int intRecNum = objSetFieldVisibilityService.SetFieldVisibility_DelSetFieldVisibilitysByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_DelSetFieldVisibilitysByCond", "clsSetFieldVisibilityWS:DelSetFieldVisibilitysByCondWs", objException.Message);
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
public static bool AddNewRecordBySql2Ws(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
bool bolResult = objSetFieldVisibilityService.SetFieldVisibility_AddNewRecordBySql2(objSetFieldVisibilityEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_AddNewRecordBySql2", "clsSetFieldVisibilityWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
string strKey = objSetFieldVisibilityService.SetFieldVisibility_AddNewRecordBySql2WithReturnKey(objSetFieldVisibilityEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_AddNewRecordBySql2WithReturnKey", "clsSetFieldVisibilityWS:AddNewRecordBySql2WithReturnKey", objException.Message);
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
public static bool UpdateBySql2Ws(clsSetFieldVisibilityEN objSetFieldVisibilityEN)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
bool bolResult = objSetFieldVisibilityService.SetFieldVisibility_UpdateBySql2(objSetFieldVisibilityEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_UpdateBySql2", "clsSetFieldVisibilityWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objSetFieldVisibilityEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsSetFieldVisibilityEN objSetFieldVisibilityEN, string strWhereCond)
{
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
try
{
bool bolResult = objSetFieldVisibilityService.SetFieldVisibility_UpdateBySqlWithCondition(objSetFieldVisibilityEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "SetFieldVisibility_UpdateBySqlWithCondition", "clsSetFieldVisibilityWS:UpdateBySqlWithCondition", objException.Message);
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
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
bool bolIsExist = objSetFieldVisibilityService.SetFieldVisibility_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(long lngmId)
{
//检测记录是否存在
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
bool bolIsExist = objSetFieldVisibilityService.SetFieldVisibility_IsExist(lngmId);
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
SetFieldVisibilityServiceSoapClient objSetFieldVisibilityService = GetSetFieldVisibilityServiceSoapClient();
int intRecCount = objSetFieldVisibilityService.SetFieldVisibility_funGetRecCountByCond(strWhereCond);
return intRecCount;
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