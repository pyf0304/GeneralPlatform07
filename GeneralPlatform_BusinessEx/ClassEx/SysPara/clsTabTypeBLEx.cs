
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabTypeBLEx
 表名:TabType(00140099)
 生成代码版本:2019.08.02.1
 生成日期:2019/08/05 00:04:27
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433GeneralPlatformTz
 PrjDataBaseId:0184
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using CommonTable.Entity;
using CommonTable.BusinessLogic;
using GeneralPlatform.Entity;
using System.Data; 
using System.Data.SqlClient; 
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Const;

namespace GeneralPlatform.BusinessLogicEx
{
public static class clsTabTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objTabTypeENS">源对象</param>
 /// <returns>目标对象=>clsTabTypeEN:objTabTypeENT</returns>
 public static clsTabTypeENEx CopyToEx(this clsTabTypeEN objTabTypeENS)
{
try
{
 clsTabTypeENEx objTabTypeENT = new clsTabTypeENEx();
clsTabTypeBL.TabTypeDA.CopyTo(objTabTypeENS, objTabTypeENT);
 return objTabTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objTabTypeENS">源对象</param>
 /// <returns>目标对象=>clsTabTypeEN:objTabTypeENT</returns>
 public static clsTabTypeEN CopyTo(this clsTabTypeENEx objTabTypeENS)
{
try
{
 clsTabTypeEN objTabTypeENT = new clsTabTypeEN();
clsTabTypeBL.TabTypeDA.CopyTo(objTabTypeENS, objTabTypeENT);
 return objTabTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 表类型(TabType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsTabTypeBLEx : clsTabTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsTabTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsTabTypeDAEx TabTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsTabTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
/// </summary>
/// <param name="strTabTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTabTypeId)
{
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsTabTypeDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[TabType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabType.TabTypeId,
//strTabTypeId);
//        clsTabTypeBL.DelTabTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabTypeBL.DelRecord(strTabTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
objException.Message,
strTabTypeId, clsStackTrace.GetCurrClassFunction());
clsPubVar4BLEx4CommonTable.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsTabTypeENEx> GetObjExLst(string strCondition)
{
List <clsTabTypeEN> arrObjLst = clsTabTypeBL.GetObjLst(strCondition);
List <clsTabTypeENEx> arrObjExLst = new List<clsTabTypeENEx>();
foreach (clsTabTypeEN objInFor in arrObjLst)
{
clsTabTypeENEx objTabTypeENEx = new clsTabTypeENEx();
clsTabTypeBL.CopyTo(objInFor, objTabTypeENEx);
arrObjExLst.Add(objTabTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTabTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsTabTypeENEx GetObjExByTabTypeId(string strTabTypeId)
{
clsTabTypeEN objTabTypeEN = clsTabTypeBL.GetObjByTabTypeId(strTabTypeId);
clsTabTypeENEx objTabTypeENEx = new clsTabTypeENEx();
clsTabTypeBL.CopyTo(objTabTypeEN, objTabTypeENEx);
return objTabTypeENEx;
}
}
}