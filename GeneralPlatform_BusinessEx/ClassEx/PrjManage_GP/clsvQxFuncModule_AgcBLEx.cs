
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxFuncModule_AgcBLEx
 表名:vQxFuncModule_Agc(00140102)
 生成代码版本:2019.08.02.1
 生成日期:2019/08/05 03:10:53
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433GeneralPlatformTz
 PrjDataBaseId:0184
 模块中文名:工程管理
 模块英文名:PrjManage
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
public static class clsvQxFuncModule_AgcBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvQxFuncModule_AgcENS">源对象</param>
 /// <returns>目标对象=>clsvQxFuncModule_AgcEN:objvQxFuncModule_AgcENT</returns>
 public static clsvQxFuncModule_AgcENEx CopyToEx(this clsvQxFuncModule_AgcEN objvQxFuncModule_AgcENS)
{
try
{
 clsvQxFuncModule_AgcENEx objvQxFuncModule_AgcENT = new clsvQxFuncModule_AgcENEx();
clsvQxFuncModule_AgcBL.vQxFuncModule_AgcDA.CopyTo(objvQxFuncModule_AgcENS, objvQxFuncModule_AgcENT);
 return objvQxFuncModule_AgcENT;
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
 /// <param name = "objvQxFuncModule_AgcENS">源对象</param>
 /// <returns>目标对象=>clsvQxFuncModule_AgcEN:objvQxFuncModule_AgcENT</returns>
 public static clsvQxFuncModule_AgcEN CopyTo(this clsvQxFuncModule_AgcENEx objvQxFuncModule_AgcENS)
{
try
{
 clsvQxFuncModule_AgcEN objvQxFuncModule_AgcENT = new clsvQxFuncModule_AgcEN();
clsvQxFuncModule_AgcBL.vQxFuncModule_AgcDA.CopyTo(objvQxFuncModule_AgcENS, objvQxFuncModule_AgcENT);
 return objvQxFuncModule_AgcENT;
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
 /// v功能模块_Agc(vQxFuncModule_Agc)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvQxFuncModule_AgcBLEx : clsvQxFuncModule_AgcBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvQxFuncModule_AgcDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvQxFuncModule_AgcDAEx vQxFuncModule_AgcDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvQxFuncModule_AgcDAEx();
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
public static List<clsvQxFuncModule_AgcENEx> GetObjExLst(string strCondition)
{
List <clsvQxFuncModule_AgcEN> arrObjLst = clsvQxFuncModule_AgcBL.GetObjLst(strCondition);
List <clsvQxFuncModule_AgcENEx> arrObjExLst = new List<clsvQxFuncModule_AgcENEx>();
foreach (clsvQxFuncModule_AgcEN objInFor in arrObjLst)
{
clsvQxFuncModule_AgcENEx objvQxFuncModule_AgcENEx = new clsvQxFuncModule_AgcENEx();
clsvQxFuncModule_AgcBL.CopyTo(objInFor, objvQxFuncModule_AgcENEx);
arrObjExLst.Add(objvQxFuncModule_AgcENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvQxFuncModule_AgcENEx GetObjExByFuncModuleAgcId(string strFuncModuleAgcId)
{
clsvQxFuncModule_AgcEN objvQxFuncModule_AgcEN = clsvQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
clsvQxFuncModule_AgcENEx objvQxFuncModule_AgcENEx = new clsvQxFuncModule_AgcENEx();
clsvQxFuncModule_AgcBL.CopyTo(objvQxFuncModule_AgcEN, objvQxFuncModule_AgcENEx);
return objvQxFuncModule_AgcENEx;
}
}
}