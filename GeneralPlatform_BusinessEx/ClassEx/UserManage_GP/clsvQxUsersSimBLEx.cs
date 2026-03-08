
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersSimBLEx
 表名:vQxUsersSim(00140121)
 * 版本:2024.01.01.1(服务器:WIN-SRV103-116)
 日期:2024/01/10 01:46:11
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
 框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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

using com.taishsoft.comm_db_obj;
using GeneralPlatform.Entity;
using System.Data; 
using System.Data.SqlClient; 
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.BusinessLogicEx
{
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_vQxUsersSimEx: RelatedActions_vQxUsersSim
{
public override bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
public static class  clsvQxUsersSimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvQxUsersSimENS">源对象</param>
 /// <returns>目标对象=>clsvQxUsersSimEN:objvQxUsersSimENT</returns>
 public static clsvQxUsersSimENEx CopyToEx(this clsvQxUsersSimEN objvQxUsersSimENS)
{
try
{
 clsvQxUsersSimENEx objvQxUsersSimENT = new clsvQxUsersSimENEx();
clsvQxUsersSimBL.vQxUsersSimDA.CopyTo(objvQxUsersSimENS, objvQxUsersSimENT);
 return objvQxUsersSimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvQxUsersSimENS">源对象</param>
 /// <returns>目标对象=>clsvQxUsersSimEN:objvQxUsersSimENT</returns>
 public static clsvQxUsersSimEN CopyTo(this clsvQxUsersSimENEx objvQxUsersSimENS)
{
try
{
 clsvQxUsersSimEN objvQxUsersSimENT = new clsvQxUsersSimEN();
clsvQxUsersSimBL.CopyTo(objvQxUsersSimENS, objvQxUsersSimENT);
 return objvQxUsersSimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// v用户Sim(vQxUsersSim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsvQxUsersSimBLEx : clsvQxUsersSimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvQxUsersSimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvQxUsersSimDAEx vQxUsersSimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvQxUsersSimDAEx();
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
public static List<clsvQxUsersSimENEx> GetObjExLst(string strCondition)
{
List <clsvQxUsersSimEN> arrObjLst = clsvQxUsersSimBL.GetObjLst(strCondition);
List <clsvQxUsersSimENEx> arrObjExLst = new List<clsvQxUsersSimENEx>();
foreach (clsvQxUsersSimEN objInFor in arrObjLst)
{
clsvQxUsersSimENEx objvQxUsersSimENEx = new clsvQxUsersSimENEx();
clsvQxUsersSimBL.CopyTo(objInFor, objvQxUsersSimENEx);
arrObjExLst.Add(objvQxUsersSimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvQxUsersSimENEx GetObjExByUserId(string strUserId)
{
clsvQxUsersSimEN objvQxUsersSimEN = clsvQxUsersSimBL.GetObjByUserId(strUserId);
clsvQxUsersSimENEx objvQxUsersSimENEx = new clsvQxUsersSimENEx();
clsvQxUsersSimBL.CopyTo(objvQxUsersSimEN, objvQxUsersSimENEx);
return objvQxUsersSimENEx;
}
}
}