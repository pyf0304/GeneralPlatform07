
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModuleBLEx
 表名:vFuncModule(00140105)
 生成代码版本:2020.05.27.2
 生成日期:2020/05/28 01:07:02
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:统一平台
 工程ID:0014
 相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
 PrjDataBaseId:0122
 模块中文名:系统管理
 模块英文名:SysManage
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

using GeneralPlatform.Entity;
using System.Data; 
using System.Data.SqlClient; 
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;


namespace GeneralPlatform.BusinessLogicEx
{
public static class clsvFuncModuleBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFuncModuleENS">源对象</param>
 /// <returns>目标对象=>clsvFuncModuleEN:objvFuncModuleENT</returns>
 public static clsvFuncModuleENEx CopyToEx(this clsvFuncModuleEN objvFuncModuleENS)
{
try
{
 clsvFuncModuleENEx objvFuncModuleENT = new clsvFuncModuleENEx();
clsvFuncModuleBL.vFuncModuleDA.CopyTo(objvFuncModuleENS, objvFuncModuleENT);
 return objvFuncModuleENT;
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
 /// <param name = "objvFuncModuleENS">源对象</param>
 /// <returns>目标对象=>clsvFuncModuleEN:objvFuncModuleENT</returns>
 public static clsvFuncModuleEN CopyTo(this clsvFuncModuleENEx objvFuncModuleENS)
{
try
{
 clsvFuncModuleEN objvFuncModuleENT = new clsvFuncModuleEN();
clsvFuncModuleBL.CopyTo(objvFuncModuleENS, objvFuncModuleENT);
 return objvFuncModuleENT;
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
 /// v功能模块(vFuncModule)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFuncModuleBLEx : clsvFuncModuleBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFuncModuleDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFuncModuleDAEx vFuncModuleDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFuncModuleDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvFuncModuleENEx> GetObjExLst(string strCondition)
{
List <clsvFuncModuleEN> arrObjLst = clsvFuncModuleBL.GetObjLst(strCondition);
List <clsvFuncModuleENEx> arrObjExLst = new List<clsvFuncModuleENEx>();
foreach (clsvFuncModuleEN objInFor in arrObjLst)
{
clsvFuncModuleENEx objvFuncModuleENEx = new clsvFuncModuleENEx();
clsvFuncModuleBL.CopyTo(objInFor, objvFuncModuleENEx);
arrObjExLst.Add(objvFuncModuleENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFuncModuleENEx GetObjExByFuncModuleId(string strFuncModuleId)
{
clsvFuncModuleEN objvFuncModuleEN = clsvFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
clsvFuncModuleENEx objvFuncModuleENEx = new clsvFuncModuleENEx();
clsvFuncModuleBL.CopyTo(objvFuncModuleEN, objvFuncModuleENEx);
return objvFuncModuleENEx;
}
}
}