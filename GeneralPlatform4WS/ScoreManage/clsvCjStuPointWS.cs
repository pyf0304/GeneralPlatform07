
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCjStuPointWS
 表名:vCjStuPoint
 生成代码版本:2017.11.11.1
 生成日期:2017/11/22 05:20:03
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
using GeneralPlatform4WS.ServiceReferencevCjStuPoint;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// vCjStuPoint(vCjStuPoint)
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public class clsvCjStuPointWS
{
private static string mstrPageName = "vCjStuPointService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
public static List<clsvCjStuPointEN> arrvCjStuPointObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vCjStuPointServiceSoapClient objvCjStuPointServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
 /// </summary>
 /// <returns></returns>
public static vCjStuPointServiceSoapClient GetvCjStuPointServiceSoapClient()
{
if (objvCjStuPointServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vCjStuPointServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vCjStuPointServiceSoapClient(binding, address);
}
else
{
return objvCjStuPointServiceSoapClient;
}
}

 public clsvCjStuPointWS()
 {
 }

 ///生成绑定ListView的代码
 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vCjStuPoint(System.Windows.Forms.ListView lvvCjStuPoint, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivCjStuPoint; 
List<clsvCjStuPointEN> arrvCjStuPointObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvCjStuPointObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvCjStuPoint.Items.Clear();//清除原来所有Item
lvvCjStuPoint.Columns.Clear();//清除原来所有列头信息
lvvCjStuPoint.Columns.Add("学号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("姓名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("性别编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("行政班流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("行政班代号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("行政班名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("年级流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("年级代号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("年级名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("EntryDay", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("GradeName", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("SelCrsGroup", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("学生绩点流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("学生流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("成绩学期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("学年", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("SchoolTerm", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("总分(不详)", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("平均绩点学分", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("累积绩点学分", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("总绩点学分", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("OperateMode", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.Columns.Add("UpdDate", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvCjStuPoint.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvCjStuPointEN objvCjStuPointEN in arrvCjStuPointObjLst)
{
lvivCjStuPoint = new System.Windows.Forms.ListViewItem();
lvivCjStuPoint.Tag = objvCjStuPointEN.id_CjStuPoint;
lvivCjStuPoint.Text = objvCjStuPointEN.id_CjStuPoint.ToString();
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.StuID);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.StuName);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.SexID);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.id_AdminClass);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.AdminClassID);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.AdminClassName);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.id_GradeBase);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.GradeBaseID);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.GradeBaseName);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.EntryDay);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.GradeName);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.SelCrsGroup);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.id_Stu);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.ScrTermSeq.ToString());
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.SchoolYear);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.SchoolTerm);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.TotalMark.ToString());
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.AveragePointMark.ToString());
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.AggregatePointMark.ToString());
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.TotalPointMark.ToString());
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.OperateMode);
lvivCjStuPoint.SubItems.Add(objvCjStuPointEN.UpdDate.ToString());
lvvCjStuPoint.Items.Add(lvivCjStuPoint);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvCjStuPointObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvCjStuPointService.vCjStuPoint_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vCjStuPoint_GetDataSet", "clsvCjStuPointWS:GetDataTableWs", objException.Message);
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
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvCjStuPointService.vCjStuPoint_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vCjStuPoint_GetTopDataSet", "clsvCjStuPointWS:GetDataTable_TopWs", objException.Message);
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
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvCjStuPointService.vCjStuPoint_GetDataSetByRange(strWhereCond, lngMinNum, lngMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vCjStuPoint_GetDataSetByRange", "clsvCjStuPointWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvCjStuPointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCjStuPointWs(ref clsvCjStuPointEN objvCjStuPointEN)
{
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
bool bolResult = objvCjStuPointService.vCjStuPoint_GetvCjStuPoint(ref objvCjStuPointEN);
return bolResult;
}

public static clsvCjStuPointEN GetObjByid_CjStuPointWs(long lngid_CjStuPoint)
{
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
clsvCjStuPointEN objvCjStuPointEN = objvCjStuPointService.vCjStuPoint_GetObjByid_CjStuPoint(lngid_CjStuPoint);
return objvCjStuPointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
try
{
long lngid_CjStuPoint = objvCjStuPointService.vCjStuPoint_GetFirstID_S(strWhereCond);
return lngid_CjStuPoint;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vCjStuPoint_GetFirstID_S", "clsvCjStuPointWS:GetFirstID_S", objException.Message);
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
public static clsvCjStuPointEN GetFirstvCjStuPoint_S(string strWhereCond)
{
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
try
{
clsvCjStuPointEN objvCjStuPointEN = objvCjStuPointService.vCjStuPoint_GetFirstObj_S(strWhereCond);
return objvCjStuPointEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vCjStuPoint_GetFirstObj_S", "clsvCjStuPointWS:GetFirstObj_S", objException.Message);
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
if (arrvCjStuPointObjLst_Cache == null)
{
arrvCjStuPointObjLst_Cache = clsvCjStuPointWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngid_CjStuPoint">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCjStuPointEN GetObjByid_CjStuPoint_Cache(long lngid_CjStuPoint)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvCjStuPointObjLst_Cache.Count - 1;
int intMid = 0;
clsvCjStuPointEN objvCjStuPointEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvCjStuPointEN = arrvCjStuPointObjLst_Cache[intMid];
if (objvCjStuPointEN.id_CjStuPoint == lngid_CjStuPoint)
{
intFindFailCount = 0;
return objvCjStuPointEN;
}
else if (objvCjStuPointEN.id_CjStuPoint.CompareTo(lngid_CjStuPoint) > 0)
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
arrvCjStuPointObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjByid_CjStuPoint_Cache(lngid_CjStuPoint);
string strErrMsgForGetObjById = string.Format("在vCjStuPoint对象缓存列表中,找不到记录[id_CjStuPoint = {0}][intFindFailCount = {1}](函数:{2})", lngid_CjStuPoint, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvCjStuPointEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvCjStuPointEN.id_CjStuPoint, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvCjStuPointBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

public static List<clsvCjStuPointEN> GetObjLst(string strWhereCond)
{
 List<clsvCjStuPointEN> arrObjLst = new List<clsvCjStuPointEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjStuPointEN objvCjStuPointEN = new clsvCjStuPointEN();
objvCjStuPointEN.StuID = objRow["StuID"].ToString().Trim(); //学号
objvCjStuPointEN.StuName = objRow["StuName"].ToString().Trim(); //姓名
objvCjStuPointEN.SexID = objRow["SexID"].ToString().Trim(); //性别编号
objvCjStuPointEN.id_AdminClass = objRow["id_AdminClass"].ToString().Trim(); //行政班流水号
objvCjStuPointEN.AdminClassID = objRow["AdminClassID"].ToString().Trim(); //行政班代号
objvCjStuPointEN.AdminClassName = objRow["AdminClassName"].ToString().Trim(); //行政班名称
objvCjStuPointEN.id_GradeBase = objRow["id_GradeBase"].ToString().Trim(); //年级流水号
objvCjStuPointEN.GradeBaseID = objRow["GradeBaseID"].ToString().Trim(); //年级代号
objvCjStuPointEN.GradeBaseName = objRow["GradeBaseName"].ToString().Trim(); //年级名称
objvCjStuPointEN.EntryDay = objRow["EntryDay"].ToString().Trim(); //EntryDay
objvCjStuPointEN.GradeName = objRow["GradeName"].ToString().Trim(); //GradeName
objvCjStuPointEN.SelCrsGroup = objRow["SelCrsGroup"].ToString().Trim(); //SelCrsGroup
objvCjStuPointEN.id_CjStuPoint = Int32.Parse(objRow["id_CjStuPoint"].ToString().Trim()); //学生绩点流水号
objvCjStuPointEN.id_Stu = objRow["id_Stu"].ToString().Trim(); //学生流水号
objvCjStuPointEN.ScrTermSeq = Int32.Parse(objRow["ScrTermSeq"].ToString().Trim()); //成绩学期
objvCjStuPointEN.SchoolYear = objRow["SchoolYear"].ToString().Trim(); //学年
objvCjStuPointEN.SchoolTerm = objRow["SchoolTerm"].ToString().Trim(); //SchoolTerm
objvCjStuPointEN.TotalMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["TotalMark"].ToString().Trim()); //总分(不详)
objvCjStuPointEN.AveragePointMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["AveragePointMark"].ToString().Trim()); //平均绩点学分
objvCjStuPointEN.AggregatePointMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["AggregatePointMark"].ToString().Trim()); //累积绩点学分
objvCjStuPointEN.TotalPointMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["TotalPointMark"].ToString().Trim()); //总绩点学分
objvCjStuPointEN.OperateMode = objRow["OperateMode"].ToString().Trim(); //OperateMode
objvCjStuPointEN.UpdDate = com.taishsoft.common.clsTranslate.TransNullToDate_S(objRow["UpdDate"].ToString().Trim()); //UpdDate
	arrObjLst.Add(objvCjStuPointEN);
	}
objDT = null;
return arrObjLst;
}

public static List<clsvCjStuPointEN> GetObjLstByRange(string strWhereCond, long lngMinNum, long lngMaxNum)
{
 List<clsvCjStuPointEN> arrObjLst = new List<clsvCjStuPointEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, lngMinNum, lngMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCjStuPointEN objvCjStuPointEN = new clsvCjStuPointEN();
objvCjStuPointEN.StuID = objRow["StuID"].ToString().Trim(); //学号
objvCjStuPointEN.StuName = objRow["StuName"].ToString().Trim(); //姓名
objvCjStuPointEN.SexID = objRow["SexID"].ToString().Trim(); //性别编号
objvCjStuPointEN.id_AdminClass = objRow["id_AdminClass"].ToString().Trim(); //行政班流水号
objvCjStuPointEN.AdminClassID = objRow["AdminClassID"].ToString().Trim(); //行政班代号
objvCjStuPointEN.AdminClassName = objRow["AdminClassName"].ToString().Trim(); //行政班名称
objvCjStuPointEN.id_GradeBase = objRow["id_GradeBase"].ToString().Trim(); //年级流水号
objvCjStuPointEN.GradeBaseID = objRow["GradeBaseID"].ToString().Trim(); //年级代号
objvCjStuPointEN.GradeBaseName = objRow["GradeBaseName"].ToString().Trim(); //年级名称
objvCjStuPointEN.EntryDay = objRow["EntryDay"].ToString().Trim(); //EntryDay
objvCjStuPointEN.GradeName = objRow["GradeName"].ToString().Trim(); //GradeName
objvCjStuPointEN.SelCrsGroup = objRow["SelCrsGroup"].ToString().Trim(); //SelCrsGroup
objvCjStuPointEN.id_CjStuPoint = Int32.Parse(objRow["id_CjStuPoint"].ToString().Trim()); //学生绩点流水号
objvCjStuPointEN.id_Stu = objRow["id_Stu"].ToString().Trim(); //学生流水号
objvCjStuPointEN.ScrTermSeq = Int32.Parse(objRow["ScrTermSeq"].ToString().Trim()); //成绩学期
objvCjStuPointEN.SchoolYear = objRow["SchoolYear"].ToString().Trim(); //学年
objvCjStuPointEN.SchoolTerm = objRow["SchoolTerm"].ToString().Trim(); //SchoolTerm
objvCjStuPointEN.TotalMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["TotalMark"].ToString().Trim()); //总分(不详)
objvCjStuPointEN.AveragePointMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["AveragePointMark"].ToString().Trim()); //平均绩点学分
objvCjStuPointEN.AggregatePointMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["AggregatePointMark"].ToString().Trim()); //累积绩点学分
objvCjStuPointEN.TotalPointMark = com.taishsoft.common.clsTranslate.TransNullToDouble_S(objRow["TotalPointMark"].ToString().Trim()); //总绩点学分
objvCjStuPointEN.OperateMode = objRow["OperateMode"].ToString().Trim(); //OperateMode
objvCjStuPointEN.UpdDate = com.taishsoft.common.clsTranslate.TransNullToDate_S(objRow["UpdDate"].ToString().Trim()); //UpdDate
	arrObjLst.Add(objvCjStuPointEN);
	}
objDT = null;
return arrObjLst;
}

public static bool IsExistRecordWs(string strWhereCond)
{
//检测记录是否存在
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
bool bolIsExist = objvCjStuPointService.vCjStuPoint_IsExistRecord(strWhereCond);
return bolIsExist;
}

public static bool IsExistWs(long lngid_CjStuPoint)
{
//检测记录是否存在
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
bool bolIsExist = objvCjStuPointService.vCjStuPoint_IsExist(lngid_CjStuPoint);
return bolIsExist;
}

public static int funGetRecCountByCondWs(string strWhereCond)
{
//检测记录是否存在
vCjStuPointServiceSoapClient objvCjStuPointService = GetvCjStuPointServiceSoapClient();
int intRecCount = objvCjStuPointService.vCjStuPoint_funGetRecCountByCond(strWhereCond);
return intRecCount;
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