
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjFileRelaWS
 表名:vQxPrjFileRela(00140060)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 09:03:12
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
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
using GeneralPlatform4WS.ServiceReferencevQxPrjFileRela;
using System.Collections.Generic;

namespace GeneralPlatform4WS
{
 /// <summary>
 /// v项目相关文件(vQxPrjFileRela)
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjFileRelaWS
{
private static string mstrPageName = "vQxPrjFileRelaService.asmx";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
private static vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaServiceSoapClient = null;
 /// <summary>
 /// 
 /// (AutoGCLib.WS_Access4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public static vQxPrjFileRelaServiceSoapClient GetvQxPrjFileRelaServiceSoapClient()
{
if (objvQxPrjFileRelaServiceSoapClient == null)
{
BasicHttpBinding binding = new BasicHttpBinding();
binding.Name = "vQxPrjFileRelaServiceSoap";
binding.CloseTimeout = new System.TimeSpan(6000);
binding.MaxReceivedMessageSize = 2147483647;
string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);
EndpointAddress address = new EndpointAddress(strServiceUrl);
return new vQxPrjFileRelaServiceSoapClient(binding, address);
}
else
{
return objvQxPrjFileRelaServiceSoapClient;
}
}

 public clsvQxPrjFileRelaWS()
 {
 }

 /// <summary>
 /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在ListView中。
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_BindListView)
 /// </summary>
public static int BindLv_vQxPrjFileRela(System.Windows.Forms.ListView lvvQxPrjFileRela, string strWhereCond)
{
//操作步骤:(共4步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	3、设置ListView的列头信息
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
//		在本界面中是把状态显示在控件lblRecCount中。

System.Windows.Forms.ListViewItem lvivQxPrjFileRela; 
List<clsvQxPrjFileRelaEN> arrvQxPrjFileRelaObjLst;
//	2、根据条件串获取该表满足条件的DataTable；
arrvQxPrjFileRelaObjLst = GetObjLst(strWhereCond);
//	3、设置ListView的列头信息
lvvQxPrjFileRela.Items.Clear();//清除原来所有Item
lvvQxPrjFileRela.Columns.Clear();//清除原来所有列头信息
lvvQxPrjFileRela.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("项目Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("工程名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("文件名", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("版本", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("文件路径", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("修改日期", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("修改用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("是否需要下载", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
lvvQxPrjFileRela.View = System.Windows.Forms.View.Details;
//	4、设置ListView的Item信息。即把所有记录显示在ListView中
foreach (clsvQxPrjFileRelaEN objvQxPrjFileRelaEN in arrvQxPrjFileRelaObjLst)
{
lvivQxPrjFileRela = new System.Windows.Forms.ListViewItem();
lvivQxPrjFileRela.Tag = objvQxPrjFileRelaEN.mId;
lvivQxPrjFileRela.Text = objvQxPrjFileRelaEN.mId.ToString();
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.QxPrjId);
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.PrjName);
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.FileName);
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.Version);
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.FilePath);
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.UpdDate);
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.UpdUserId);
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.IsNeedDownLoad.ToString());
lvivQxPrjFileRela.SubItems.Add(objvQxPrjFileRelaEN.Memo);
lvvQxPrjFileRela.Items.Add(lvivQxPrjFileRela);
}
//	4、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。
return arrvQxPrjFileRelaObjLst.Count;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetDataTable4Tab)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件一定范围的DataTable</returns>
public static DataTable GetDataTableWs(string strWhereCond)
{
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjFileRelaService.vQxPrjFileRela_GetDataSet(strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjFileRela_GetDataSet", "clsvQxPrjFileRelaWS:GetDataTableWs", objException.Message);
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
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjFileRelaService.vQxPrjFileRela_GetTopDataSet(intTopSize, strWhereCond);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjFileRela_GetTopDataSet", "clsvQxPrjFileRelaWS:GetDataTable_TopWs", objException.Message);
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
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
DataSet objDS = null;
try
{
objDS = objvQxPrjFileRelaService.vQxPrjFileRela_GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
DataTable objDT = objDS.Tables[0];
return objDT;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjFileRela_GetDataSetByRange", "clsvQxPrjFileRelaWS:GetDataTableByRangeWs", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetRecordProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjFileRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjFileRelaWs(ref clsvQxPrjFileRelaEN objvQxPrjFileRelaEN)
{
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
bool bolResult = objvQxPrjFileRelaService.vQxPrjFileRela_GetvQxPrjFileRela(ref objvQxPrjFileRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjFileRelaEN GetObjBymIdWs(long lngmId)
{
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = objvQxPrjFileRelaService.vQxPrjFileRela_GetObjBymId(lngmId);
return objvQxPrjFileRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
try
{
long lngmId = objvQxPrjFileRelaService.vQxPrjFileRela_GetFirstID_S(strWhereCond);
return lngmId;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjFileRela_GetFirstID_S", "clsvQxPrjFileRelaWS:GetFirstID_S", objException.Message);
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
public static clsvQxPrjFileRelaEN GetFirstvQxPrjFileRela_S(string strWhereCond)
{
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
try
{
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = objvQxPrjFileRelaService.vQxPrjFileRela_GetFirstObj_S(strWhereCond);
return objvQxPrjFileRelaEN;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebSrv功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.", 
      GetServiceUrl(mstrPageName, ref mstrDir), "vQxPrjFileRela_GetFirstObj_S", "clsvQxPrjFileRelaWS:GetFirstObj_S", objException.Message);
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
if (arrvQxPrjFileRelaObjLst_Cache == null)
{
arrvQxPrjFileRelaObjLst_Cache = clsvQxPrjFileRelaWS.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjFileRelaEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrvQxPrjFileRelaObjLst_Cache.Count - 1;
int intMid = 0;
clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objvQxPrjFileRelaEN = arrvQxPrjFileRelaObjLst_Cache[intMid];
if (objvQxPrjFileRelaEN.mId == lngmId)
{
intFindFailCount = 0;
return objvQxPrjFileRelaEN;
}
else if (objvQxPrjFileRelaEN.mId.CompareTo(lngmId) > 0)
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
arrvQxPrjFileRelaObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在vQxPrjFileRela对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objvQxPrjFileRelaEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvQxPrjFileRelaEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsvQxPrjFileRelaBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WS_Access4CSharp:Gen_4Ws_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjFileRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableWs(strWhereCond);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow["Version"].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow["FilePath"].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsNeedDownLoad"].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
public static List<clsvQxPrjFileRelaEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsvQxPrjFileRelaEN> arrObjLst = new List<clsvQxPrjFileRelaEN>(); 
System.Data.DataTable objDT = null; 
 objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
objDT = null;
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjFileRelaEN objvQxPrjFileRelaEN = new clsvQxPrjFileRelaEN();
objvQxPrjFileRelaEN.mId = Int32.Parse(objRow["mId"].ToString().Trim()); //流水号
objvQxPrjFileRelaEN.QxPrjId = objRow["QxPrjId"].ToString().Trim(); //项目Id
objvQxPrjFileRelaEN.PrjName = objRow["PrjName"].ToString().Trim(); //工程名
objvQxPrjFileRelaEN.FileName = objRow["FileName"].ToString().Trim(); //文件名
objvQxPrjFileRelaEN.Version = objRow["Version"].ToString().Trim(); //版本
objvQxPrjFileRelaEN.FilePath = objRow["FilePath"].ToString().Trim(); //文件路径
objvQxPrjFileRelaEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
objvQxPrjFileRelaEN.UpdUserId = objRow["UpdUserId"].ToString().Trim(); //修改用户Id
objvQxPrjFileRelaEN.IsNeedDownLoad = com.taishsoft.common.clsTranslate.TransNullToBool_S(objRow["IsNeedDownLoad"].ToString().Trim()); //是否需要下载
objvQxPrjFileRelaEN.Memo = objRow["Memo"].ToString().Trim(); //备注
	arrObjLst.Add(objvQxPrjFileRelaEN);
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
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
bool bolIsExist = objvQxPrjFileRelaService.vQxPrjFileRela_IsExistRecord(strWhereCond);
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
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
bool bolIsExist = objvQxPrjFileRelaService.vQxPrjFileRela_IsExist(lngmId);
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
vQxPrjFileRelaServiceSoapClient objvQxPrjFileRelaService = GetvQxPrjFileRelaServiceSoapClient();
int intRecCount = objvQxPrjFileRelaService.vQxPrjFileRela_funGetRecCountByCond(strWhereCond);
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