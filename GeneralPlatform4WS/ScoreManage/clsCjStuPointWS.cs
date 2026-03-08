
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjStuPointWS
 表名:CjStuPoint
 生成代码版本:2017.11.11.1
 生成日期:2017/11/22 05:20:07
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 模块中文名:成绩管理
 模块英文名:ScoreManage
 框架-层名:Web服务转换层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.09.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.11.09.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceCjStuPoint;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// 成绩学生绩点(CjStuPoint)
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public class clsCjStuPointWS
{
private static string mstrPageName = "CjStuPointService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public static List<clsCjStuPointEN> arrCjStuPointObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static CjStuPointServiceSoapClient objCjStuPointServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
 /// <returns></returns>
public static CjStuPointServiceSoapClient GetCjStuPointServiceSoapClient()
{
if (objCjStuPointServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "CjStuPointServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new CjStuPointServiceSoapClient(binding, address);
}
else
{
return objCjStuPointServiceSoapClient;
}
}

 public clsCjStuPointWS()
 {
 }

 ///生成绑定ListView的代码
 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_CjStuPoint(System.Windows.Forms.ListView lvCjStuPoint, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lviCjStuPoint; 
List<clsCjStuPointEN> arrCjStuPointObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrCjStuPointObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvCjStuPoint.Items.Clear();//清除原来所有Item
lvCjStuPoint.Columns.Clear();//清除原来所有列头信息
lvCjStuPoint.Columns.Add("学生绩点流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("学生流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("成绩学期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("学年", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("SchoolTerm", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("总分(不详)", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("平均绩点学分", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("累积绩点学分", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("总绩点学分", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("OperateMode", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("是否同步Web", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("同步Web日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("同步Web用户", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("UpdDate", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.Columns.Add("修改人", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvCjStuPoint.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsCjStuPointEN objCjStuPointEN in arrCjStuPointObjLst)
{
lviCjStuPoint = new System.Windows.Forms.ListViewItem();
lviCjStuPoint.Tag = objCjStuPointEN.id_CjStuPoint;
lviCjStuPoint.Text = objCjStuPointEN.id_CjStuPoint.ToString();
lviCjStuPoint.SubItems.Add(objCjStuPointEN.id_Stu);
lviCjStuPoint.SubItems.Add(objCjStuPointEN.ScrTermSeq.ToString());
lviCjStuPoint.SubItems.Add(objCjStuPointEN.SchoolYear);
lviCjStuPoint.SubItems.Add(objCjStuPointEN.SchoolTerm);
lviCjStuPoint.SubItems.Add(objCjStuPointEN.TotalMark.ToString());
lviCjStuPoint.SubItems.Add(objCjStuPointEN.AveragePointMark.ToString());
lviCjStuPoint.SubItems.Add(objCjStuPointEN.AggregatePointMark.ToString());
lviCjStuPoint.SubItems.Add(objCjStuPointEN.TotalPointMark.ToString());
lviCjStuPoint.SubItems.Add(objCjStuPointEN.OperateMode);
lviCjStuPoint.SubItems.Add(objCjStuPointEN.IsSynchToWeb.ToString());
lviCjStuPoint.SubItems.Add(objCjStuPointEN.SynchToWebDate);
lviCjStuPoint.SubItems.Add(objCjStuPointEN.SynchToWebUser);
lviCjStuPoint.SubItems.Add(objCjStuPointEN.UpdDate.ToString());
lviCjStuPoint.SubItems.Add(objCjStuPointEN.ModifyDate);
lviCjStuPoint.SubItems.Add(objCjStuPointEN.ModifyUserID);
lvCjStuPoint.Items.Add(lviCjStuPoint);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrCjStuPointObjLst.Count;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4WS_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCjStuPointEN objCjStuPointEN)
{
if (!Object.Equals(null, objCjStuPointEN.id_Stu) && getStrLen(objCjStuPointEN.id_Stu) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCjStuPointEN.SchoolYear) && getStrLen(objCjStuPointEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objCjStuPointEN.SchoolTerm) && getStrLen(objCjStuPointEN.SchoolTerm) > 2)
{
 throw new Exception("字段[SchoolTerm]的长度不能超过2!");
}
if (!Object.Equals(null, objCjStuPointEN.OperateMode) && getStrLen(objCjStuPointEN.OperateMode) > 50)
{
 throw new Exception("字段[OperateMode]的长度不能超过50!");
}
if (!Object.Equals(null, objCjStuPointEN.SynchToWebDate) && getStrLen(objCjStuPointEN.SynchToWebDate) > 20)
{
 throw new Exception("字段[同步Web日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCjStuPointEN.SynchToWebUser) && getStrLen(objCjStuPointEN.SynchToWebUser) > 18)
{
 throw new Exception("字段[同步Web用户]的长度不能超过18!");
}
if (!Object.Equals(null, objCjStuPointEN.ModifyDate) && getStrLen(objCjStuPointEN.ModifyDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objCjStuPointEN.ModifyUserID) && getStrLen(objCjStuPointEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
 objCjStuPointEN.IsCheckProperty = true;
 }

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCjStuPointService.CjStuPoint_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_GetDataSet", "clsCjStuPointWS:GetDataTableWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetTopDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTable_TopWs(int intTopSize, string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCjStuPointService.CjStuPoint_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_GetTopDataSet", "clsCjStuPointWS:GetDataTable_TopWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4TabByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lngMinNum">范围之最小值</param>
 /// <param name = "lngMaxNum">范围之最大值</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableByRangeWs(string strWhereCond, long lngMinNum, long lngMaxNum)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCjStuPointService.CjStuPoint_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_GetDataSetByRange", "clsCjStuPointWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetDataTableVWs(string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCjStuPointService.CjStuPoint_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_GetDataSetV", "clsCjStuPointWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static DataTable GetCjStuPointVWs(string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objCjStuPointService.CjStuPoint_GetDataSetV(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_GetDataSetV", "clsCjStuPointWS:GetDataTableVWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objCjStuPointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCjStuPointWs(ref clsCjStuPointEN objCjStuPointEN)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
bool bolResult = objCjStuPointService.CjStuPoint_GetCjStuPoint(ref objCjStuPointEN);
return bolResult;
}

public static clsCjStuPointEN GetObjByid_CjStuPointWs(long lngid_CjStuPoint)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
clsCjStuPointEN objCjStuPointEN = objCjStuPointService.CjStuPoint_GetObjByid_CjStuPoint(lngid_CjStuPoint);
return objCjStuPointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
long lngid_CjStuPoint = objCjStuPointService.CjStuPoint_GetFirstID_S(strWhereCond);
return lngid_CjStuPoint;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_GetFirstID_S", "clsCjStuPointWS:GetFirstID_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsCjStuPointEN GetFirstCjStuPoint_S(string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
clsCjStuPointEN objCjStuPointEN = objCjStuPointService.CjStuPoint_GetFirstObj_S(strWhereCond);
return objCjStuPointEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_GetFirstObj_S", "clsCjStuPointWS:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by id_CjStuPoint");
if (arrCjStuPointObjLst_Cache == null)
{
arrCjStuPointObjLst_Cache = clsCjStuPointWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngid_CjStuPoint">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCjStuPointEN GetObjByid_CjStuPoint_Cache(long lngid_CjStuPoint)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrCjStuPointObjLst_Cache.Count - 1;
int intMid = 0;
clsCjStuPointEN objCjStuPointEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objCjStuPointEN = arrCjStuPointObjLst_Cache[intMid];
if (objCjStuPointEN.id_CjStuPoint == lngid_CjStuPoint)
{
intFindFailCount = 0;
return objCjStuPointEN;
}
else if (objCjStuPointEN.id_CjStuPoint.CompareTo(lngid_CjStuPoint) > 0)
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
arrCjStuPointObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByid_CjStuPoint_Cache(lngid_CjStuPoint);
string strErrMsgForGetObjById = string.Format("在CjStuPoint对象缓存列表中,找不到记录[id_CjStuPoint = {0}][intFindFailCount = {1}](函数:{2})", lngid_CjStuPoint, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objCjStuPointEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objCjStuPointEN.id_CjStuPoint, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsCjStuPointBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

public static List<clsCjStuPointEN> GetObjLst(string strWhereCond)
{
 List<clsCjStuPointEN> arrObjLst = new List<clsCjStuPointEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjStuPointEN objCjStuPointEN = new clsCjStuPointEN();
objCjStuPointEN.id_CjStuPoint = Int32.Parse(objRow["id_CjStuPoint"].ToString().Trim()); //学生绩点流水号
objCjStuPointEN.id_Stu = objRow["id_Stu"].ToString().Trim(); //学生流水号
objCjStuPointEN.ScrTermSeq = Int32.Parse(objRow["ScrTermSeq"].ToString().Trim()); //成绩学期
objCjStuPointEN.SchoolYear = objRow["SchoolYear"].ToString().Trim(); //学年
objCjStuPointEN.SchoolTerm = objRow["SchoolTerm"].ToString().Trim(); //SchoolTerm
objCjStuPointEN.TotalMark = Double.Parse(objRow["TotalMark"].ToString().Trim()); //总分(不详)
objCjStuPointEN.AveragePointMark = Double.Parse(objRow["AveragePointMark"].ToString().Trim()); //平均绩点学分
objCjStuPointEN.AggregatePointMark = Double.Parse(objRow["AggregatePointMark"].ToString().Trim()); //累积绩点学分
objCjStuPointEN.TotalPointMark = Double.Parse(objRow["TotalPointMark"].ToString().Trim()); //总绩点学分
objCjStuPointEN.OperateMode = objRow["OperateMode"].ToString().Trim(); //OperateMode
objCjStuPointEN.IsSynchToWeb = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSynchToWeb"].ToString().Trim()); //是否同步Web
objCjStuPointEN.SynchToWebDate = objRow["SynchToWebDate"].ToString().Trim(); //同步Web日期
objCjStuPointEN.SynchToWebUser = objRow["SynchToWebUser"].ToString().Trim(); //同步Web用户
objCjStuPointEN.UpdDate = System.DateTime.Parse(objRow["UpdDate"].ToString().Trim()); //UpdDate
objCjStuPointEN.ModifyDate = objRow["ModifyDate"].ToString().Trim(); //修改日期
objCjStuPointEN.ModifyUserID = objRow["ModifyUserID"].ToString().Trim(); //修改人
	arrObjLst.Add(objCjStuPointEN);
	}
objDT = null;
return arrObjLst;
}

public static List<clsCjStuPointEN> GetObjLstByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
 List<clsCjStuPointEN> arrObjLst = new List<clsCjStuPointEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCjStuPointEN objCjStuPointEN = new clsCjStuPointEN();
objCjStuPointEN.id_CjStuPoint = Int32.Parse(objRow["id_CjStuPoint"].ToString().Trim()); //学生绩点流水号
objCjStuPointEN.id_Stu = objRow["id_Stu"].ToString().Trim(); //学生流水号
objCjStuPointEN.ScrTermSeq = Int32.Parse(objRow["ScrTermSeq"].ToString().Trim()); //成绩学期
objCjStuPointEN.SchoolYear = objRow["SchoolYear"].ToString().Trim(); //学年
objCjStuPointEN.SchoolTerm = objRow["SchoolTerm"].ToString().Trim(); //SchoolTerm
objCjStuPointEN.TotalMark = Double.Parse(objRow["TotalMark"].ToString().Trim()); //总分(不详)
objCjStuPointEN.AveragePointMark = Double.Parse(objRow["AveragePointMark"].ToString().Trim()); //平均绩点学分
objCjStuPointEN.AggregatePointMark = Double.Parse(objRow["AggregatePointMark"].ToString().Trim()); //累积绩点学分
objCjStuPointEN.TotalPointMark = Double.Parse(objRow["TotalPointMark"].ToString().Trim()); //总绩点学分
objCjStuPointEN.OperateMode = objRow["OperateMode"].ToString().Trim(); //OperateMode
objCjStuPointEN.IsSynchToWeb = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsSynchToWeb"].ToString().Trim()); //是否同步Web
objCjStuPointEN.SynchToWebDate = objRow["SynchToWebDate"].ToString().Trim(); //同步Web日期
objCjStuPointEN.SynchToWebUser = objRow["SynchToWebUser"].ToString().Trim(); //同步Web用户
objCjStuPointEN.UpdDate = System.DateTime.Parse(objRow["UpdDate"].ToString().Trim()); //UpdDate
objCjStuPointEN.ModifyDate = objRow["ModifyDate"].ToString().Trim(); //修改日期
objCjStuPointEN.ModifyUserID = objRow["ModifyUserID"].ToString().Trim(); //修改人
	arrObjLst.Add(objCjStuPointEN);
	}
objDT = null;
return arrObjLst;
}

public static bool DelRecordWs(long lngid_CjStuPoint)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
bool bolResult = objCjStuPointService.CjStuPoint_DelRecord(lngid_CjStuPoint);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_DelRecord", "clsCjStuPointWS:DelRecordWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool DelCjStuPointsWs(List<string> arrid_CjStuPoint)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
string[] slngid_CjStuPoint = (string[])(arrid_CjStuPoint.ToArray());
bool bolResult = objCjStuPointService.CjStuPoint_DelCjStuPoints(slngid_CjStuPoint);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_DelCjStuPoints", "clsCjStuPointWS:DelCjStuPointsWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static int DelCjStuPointsByCondWs(string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
int intRecNum = objCjStuPointService.CjStuPoint_DelCjStuPointsByCond(strWhereCond);
return intRecNum;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_DelCjStuPointsByCond", "clsCjStuPointWS:DelCjStuPointsByCondWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool AddNewRecordBySql2Ws(clsCjStuPointEN objCjStuPointEN)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
bool bolResult = objCjStuPointService.CjStuPoint_AddNewRecordBySql2(objCjStuPointEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_AddNewRecordBySql2", "clsCjStuPointWS:AddNewRecordBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objCjStuPointEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCjStuPointEN objCjStuPointEN)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
string strKey = objCjStuPointService.CjStuPoint_AddNewRecordBySql2WithReturnKey(objCjStuPointEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_AddNewRecordBySql2WithReturnKey", "clsCjStuPointWS:AddNewRecordBySql2WithReturnKey", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool UpdateBySql2Ws(clsCjStuPointEN objCjStuPointEN)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
bool bolResult = objCjStuPointService.CjStuPoint_UpdateBySql2(objCjStuPointEN);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_UpdateBySql2", "clsCjStuPointWS:UpdateBySql2Ws", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objCjStuPointEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateBySqlWithCondition(clsCjStuPointEN objCjStuPointEN, string strWhereCond)
{
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
try
{
bool bolResult = objCjStuPointService.CjStuPoint_UpdateBySqlWithCondition(objCjStuPointEN, strWhereCond);
return bolResult;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "CjStuPoint_UpdateBySqlWithCondition", "clsCjStuPointWS:UpdateBySqlWithCondition", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
bool bolIsExist = objCjStuPointService.CjStuPoint_IsExistRecord(strWhereCond);
return bolIsExist;
}

public static bool IsExistWs(long lngid_CjStuPoint)
{
//检测记录是否存在
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
bool bolIsExist = objCjStuPointService.CjStuPoint_IsExist(lngid_CjStuPoint);
return bolIsExist;
}

public static int funGetRecCountByCondWs(string strWhereCond)
{
//检测记录是否存在
CjStuPointServiceSoapClient objCjStuPointService = GetCjStuPointServiceSoapClient();
int intRecCount = objCjStuPointService.CjStuPoint_funGetRecCountByCond(strWhereCond);
return intRecCount;
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.AutoGCPubFuncV6:GengetStrLen)
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
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
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