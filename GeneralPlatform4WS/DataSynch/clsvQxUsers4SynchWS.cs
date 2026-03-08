
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers4SynchWS
 表名:vQxUsers4Synch(00140090)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:25
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
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
using GeneralPlatform4WS.ServiceReferencevQxUsers4Synch;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v用户4同步(vQxUsers4Synch)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsers4SynchWS
{
private static string mstrPageName = "vQxUsers4SynchService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUsers4SynchServiceSoapClient objvQxUsers4SynchServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUsers4SynchServiceSoapClient GetvQxUsers4SynchServiceSoapClient()
{
if (objvQxUsers4SynchServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUsers4SynchServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUsers4SynchServiceSoapClient(binding, address);
}
else
{
return objvQxUsers4SynchServiceSoapClient;
}
}

 public clsvQxUsers4SynchWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxUsers4Synch(System.Windows.Forms.ListView lvvQxUsers4Synch, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUsers4Synch; 
List<clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUsers4SynchObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUsers4Synch.Items.Clear();//清除原来所有Item
lvvQxUsers4Synch.Columns.Clear();//清除原来所有列头信息
lvvQxUsers4Synch.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("部门类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("部门类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("所属部门号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("上级部门", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("用户状态名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("有效日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("学院流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("有效开始日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("有效结束日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("学工号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("身份描述", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("修改用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers4Synch.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUsers4SynchEN objvQxUsers4SynchEN in arrvQxUsers4SynchObjLst)
{
lvivQxUsers4Synch = new System.Windows.Forms.ListViewItem();
lvivQxUsers4Synch.Tag = objvQxUsers4SynchEN.mId;
lvivQxUsers4Synch.Text = objvQxUsers4SynchEN.mId.ToString();
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.IpAddress);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UserId);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UserName);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.DepartmentId);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.DepartmentName);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.DepartmentAbbrName);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.DepartmentTypeId);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.DepartmentTypeName);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UpDepartmentId);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UpDepartmentName);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UserStateId);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UserStateName);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.EffectiveDate);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.Password);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.id_College);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.EffitiveBeginDate);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.EffitiveEndDate);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.StuTeacherId);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.IdentityID);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.IdentityDesc);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UpdDate);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.UpdUser);
lvivQxUsers4Synch.SubItems.Add(objvQxUsers4SynchEN.Memo);
lvvQxUsers4Synch.Items.Add(lvivQxUsers4Synch);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUsers4SynchObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUsers4SynchService.vQxUsers4Synch_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers4Synch_GetDataSet", "clsvQxUsers4SynchWS:GetDataTableWs", objException.Message);
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
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUsers4SynchService.vQxUsers4Synch_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers4Synch_GetTopDataSet", "clsvQxUsers4SynchWS:GetDataTable_TopWs", objException.Message);
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
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUsers4SynchService.vQxUsers4Synch_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers4Synch_GetDataSetByRange", "clsvQxUsers4SynchWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUsers4SynchWs(ref clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
bool bolResult = objvQxUsers4SynchService.vQxUsers4Synch_GetvQxUsers4Synch(ref objvQxUsers4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers4SynchEN GetObjBymIdWs(long lngmId)
{
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
clsvQxUsers4SynchEN objvQxUsers4SynchEN = objvQxUsers4SynchService.vQxUsers4Synch_GetObjBymId(lngmId);
return objvQxUsers4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
try
{
long lngmId = objvQxUsers4SynchService.vQxUsers4Synch_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers4Synch_GetFirstID_S", "clsvQxUsers4SynchWS:GetFirstID_S", objException.Message);
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
public static clsvQxUsers4SynchEN GetFirstvQxUsers4Synch_S(string strWhereCond)
{
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
try
{
clsvQxUsers4SynchEN objvQxUsers4SynchEN = objvQxUsers4SynchService.vQxUsers4Synch_GetFirstObj_S(strWhereCond);
return objvQxUsers4SynchEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers4Synch_GetFirstObj_S", "clsvQxUsers4SynchWS:GetFirstObj_S", objException.Message);
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
if (arrvQxUsers4SynchObjLst_Cache == null)
{
arrvQxUsers4SynchObjLst_Cache = clsvQxUsers4SynchWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsers4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUsers4SynchObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUsers4SynchEN objvQxUsers4SynchEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUsers4SynchEN = arrvQxUsers4SynchObjLst_Cache[intMid];
if (objvQxUsers4SynchEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxUsers4SynchEN;
}
else if (objvQxUsers4SynchEN.mId.CompareTo(lngmId) > 0)
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
arrvQxUsers4SynchObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxUsers4Synch对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUsers4SynchEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUsers4SynchEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUsers4SynchBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
objvQxUsers4SynchEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUsers4SynchEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objvQxUsers4SynchEN.Password = objRow["Password"].ToString().Trim(); //口令
objvQxUsers4SynchEN.id_College = objRow["id_College"].ToString().Trim(); //学院流水号
objvQxUsers4SynchEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUsers4SynchEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
objvQxUsers4SynchEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow["IpAddress"].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUsers4SynchEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objvQxUsers4SynchEN.Password = objRow["Password"].ToString().Trim(); //口令
objvQxUsers4SynchEN.id_College = objRow["id_College"].ToString().Trim(); //学院流水号
objvQxUsers4SynchEN.EffitiveBeginDate = objRow["EffitiveBeginDate"].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow["EffitiveEndDate"].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUsers4SynchEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
objDT = null;
return arrObjLst;
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
bool bolIsExist = objvQxUsers4SynchService.vQxUsers4Synch_IsExistRecord(strWhereCond);
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
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
bool bolIsExist = objvQxUsers4SynchService.vQxUsers4Synch_IsExist(lngmId);
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
vQxUsers4SynchServiceSoapClient objvQxUsers4SynchService = GetvQxUsers4SynchServiceSoapClient();
int intRecCount = objvQxUsers4SynchService.vQxUsers4Synch_funGetRecCountByCond(strWhereCond);
return intRecCount;
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