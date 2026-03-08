
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers_SchoolWS
 表名:vQxUsers_School(00140075)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:18
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
using GeneralPlatform4WS.ServiceReferencevQxUsers_School;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// vUsers_School(vQxUsers_School)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsers_SchoolWS
{
private static string mstrPageName = "vQxUsers_SchoolService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxUsers_SchoolServiceSoapClient GetvQxUsers_SchoolServiceSoapClient()
{
if (objvQxUsers_SchoolServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxUsers_SchoolServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxUsers_SchoolServiceSoapClient(binding, address);
}
else
{
return objvQxUsers_SchoolServiceSoapClient;
}
}

 public clsvQxUsers_SchoolWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxUsers_School(System.Windows.Forms.ListView lvvQxUsers_School, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxUsers_School; 
List<clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxUsers_SchoolObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxUsers_School.Items.Clear();//清除原来所有Item
lvvQxUsers_School.Columns.Clear();//清除原来所有列头信息
lvvQxUsers_School.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("用户名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("部门Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("部门名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("名称缩写", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("部门类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("部门类型名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("所属部门号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("上级部门", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("用户状态Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("用户状态名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("有效日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("身份描述", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("卡号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("学工号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("年级流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("年级代号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("年级名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("进校日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("是否毕业", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("开始年月", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("结束年月", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("卡状态", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("IsLeaved", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("修改用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxUsers_School.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxUsers_SchoolEN objvQxUsers_SchoolEN in arrvQxUsers_SchoolObjLst)
{
lvivQxUsers_School = new System.Windows.Forms.ListViewItem();
lvivQxUsers_School.Tag = objvQxUsers_SchoolEN.UserId;
lvivQxUsers_School.Text = objvQxUsers_SchoolEN.UserId.ToString();
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.UserName);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.DepartmentId);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.DepartmentName);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.DepartmentAbbrName);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.DepartmentTypeId);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.DepartmentTypeName);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.UpDepartmentId);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.UpDepartmentName);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.UserStateId);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.UserStateName);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.EffectiveDate);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.IdentityID);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.IdentityDesc);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.CardNo);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.StuTeacherId);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.id_GradeBase);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.GradeBaseID);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.GradeBaseName);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.EnterSchoolDate);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.IsOffed.ToString());
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.BeginYearMonth);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.EndYearMonth);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.Card_State);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.IsLeaved.ToString());
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.UpdDate);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.UpdUser);
lvivQxUsers_School.SubItems.Add(objvQxUsers_SchoolEN.Memo);
lvvQxUsers_School.Items.Add(lvivQxUsers_School);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxUsers_SchoolObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUsers_SchoolService.vQxUsers_School_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers_School_GetDataSet", "clsvQxUsers_SchoolWS:GetDataTableWs", objException.Message);
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
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUsers_SchoolService.vQxUsers_School_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers_School_GetTopDataSet", "clsvQxUsers_SchoolWS:GetDataTable_TopWs", objException.Message);
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
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxUsers_SchoolService.vQxUsers_School_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers_School_GetDataSetByRange", "clsvQxUsers_SchoolWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUsers_SchoolWs(ref clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
bool bolResult = objvQxUsers_SchoolService.vQxUsers_School_GetvQxUsers_School(ref objvQxUsers_SchoolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers_SchoolEN GetObjByUserIdWs(string strUserId)
{
strUserId = strUserId.Replace("'", "");
strUserId = strUserId.Replace(" ", "");
strUserId = strUserId.Replace("(", "");
strUserId = strUserId.Replace(")", "");
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = objvQxUsers_SchoolService.vQxUsers_School_GetObjByUserId(strUserId);
return objvQxUsers_SchoolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond)
{
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
try
{
string strUserId = objvQxUsers_SchoolService.vQxUsers_School_GetFirstID_S(strWhereCond);
return strUserId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers_School_GetFirstID_S", "clsvQxUsers_SchoolWS:GetFirstID_S", objException.Message);
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
public static clsvQxUsers_SchoolEN GetFirstvQxUsers_School_S(string strWhereCond)
{
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
try
{
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = objvQxUsers_SchoolService.vQxUsers_School_GetFirstObj_S(strWhereCond);
return objvQxUsers_SchoolEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxUsers_School_GetFirstObj_S", "clsvQxUsers_SchoolWS:GetFirstObj_S", objException.Message);
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
string strWhereCond = string.Format("1 = 1 order by UserId");
if (arrvQxUsers_SchoolObjLst_Cache == null)
{
arrvQxUsers_SchoolObjLst_Cache = clsvQxUsers_SchoolWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsers_SchoolEN GetObjByUserId_Cache(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true) return null;
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxUsers_SchoolObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxUsers_SchoolEN = arrvQxUsers_SchoolObjLst_Cache[intMid];
if (objvQxUsers_SchoolEN.UserId == strUserId)
{
intFindFailCount = 0;
return objvQxUsers_SchoolEN;
}
else if (objvQxUsers_SchoolEN.UserId.CompareTo(strUserId) > 0)
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
arrvQxUsers_SchoolObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByUserId_Cache(strUserId);
string strErrMsgForGetObjById = string.Format("在vQxUsers_School对象缓存列表中,找不到记录[UserId = {0}][intFindFailCount = {1}](函数:{2})", strUserId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxUsers_SchoolEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxUsers_SchoolEN.UserId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxUsers_SchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
objvQxUsers_SchoolEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objvQxUsers_SchoolEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow["CardNo"].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.id_GradeBase = objRow["id_GradeBase"].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseID = objRow["GradeBaseID"].ToString().Trim(); //年级代号
objvQxUsers_SchoolEN.GradeBaseName = objRow["GradeBaseName"].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow["EnterSchoolDate"].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsOffed"].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow["BeginYearMonth"].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow["EndYearMonth"].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.Card_State = objRow["Card_State"].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeaved"].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
objvQxUsers_SchoolEN.UserId = objRow["UserId"].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow["UserName"].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow["DepartmentId"].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow["DepartmentName"].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow["DepartmentAbbrName"].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow["DepartmentTypeId"].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow["DepartmentTypeName"].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow["UpDepartmentId"].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow["UpDepartmentName"].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow["UserStateId"].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow["UserStateName"].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.EffectiveDate = objRow["EffectiveDate"].ToString().Trim(); //有效日期
objvQxUsers_SchoolEN.IdentityID = objRow["IdentityID"].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow["IdentityDesc"].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow["CardNo"].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow["StuTeacherId"].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.id_GradeBase = objRow["id_GradeBase"].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseID = objRow["GradeBaseID"].ToString().Trim(); //年级代号
objvQxUsers_SchoolEN.GradeBaseName = objRow["GradeBaseName"].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow["EnterSchoolDate"].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsOffed"].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow["BeginYearMonth"].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow["EndYearMonth"].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.Card_State = objRow["Card_State"].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsLeaved"].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
bool bolIsExist = objvQxUsers_SchoolService.vQxUsers_School_IsExistRecord(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistWs(string strUserId)
{
//检测记录是否存在
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
bool bolIsExist = objvQxUsers_SchoolService.vQxUsers_School_IsExist(strUserId);
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
vQxUsers_SchoolServiceSoapClient objvQxUsers_SchoolService = GetvQxUsers_SchoolServiceSoapClient();
int intRecCount = objvQxUsers_SchoolService.vQxUsers_School_funGetRecCountByCond(strWhereCond);
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