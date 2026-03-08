
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRoleRightRelationBLEx
 表名:QxRoleRightRelation(00140118)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 15:41:38
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
 public class RelatedActions_QxRoleRightRelationEx: RelatedActions_QxRoleRightRelation
{
public override bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
public static class  clsQxRoleRightRelationBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objQxRoleRightRelationENS">源对象</param>
 /// <returns>目标对象=>clsQxRoleRightRelationEN:objQxRoleRightRelationENT</returns>
 public static clsQxRoleRightRelationENEx CopyToEx(this clsQxRoleRightRelationEN objQxRoleRightRelationENS)
{
try
{
 clsQxRoleRightRelationENEx objQxRoleRightRelationENT = new clsQxRoleRightRelationENEx();
clsQxRoleRightRelationBL.QxRoleRightRelationDA.CopyTo(objQxRoleRightRelationENS, objQxRoleRightRelationENT);
 return objQxRoleRightRelationENT;
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
 /// <param name = "objQxRoleRightRelationENS">源对象</param>
 /// <returns>目标对象=>clsQxRoleRightRelationEN:objQxRoleRightRelationENT</returns>
 public static clsQxRoleRightRelationEN CopyTo(this clsQxRoleRightRelationENEx objQxRoleRightRelationENS)
{
try
{
 clsQxRoleRightRelationEN objQxRoleRightRelationENT = new clsQxRoleRightRelationEN();
clsQxRoleRightRelationBL.CopyTo(objQxRoleRightRelationENS, objQxRoleRightRelationENT);
 return objQxRoleRightRelationENT;
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
 /// 角色赋权关系(QxRoleRightRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class  clsQxRoleRightRelationBLEx : clsQxRoleRightRelationBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsQxRoleRightRelationDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsQxRoleRightRelationDAEx QxRoleRightRelationDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsQxRoleRightRelationDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objQxRoleRightRelationENS">源对象</param>
 /// <returns>目标对象=>clsQxRoleRightRelationEN:objQxRoleRightRelationENT</returns>
 public static clsQxRoleRightRelationENEx CopyToEx(clsQxRoleRightRelationEN objQxRoleRightRelationENS)
{
try
{
 clsQxRoleRightRelationENEx objQxRoleRightRelationENT = new clsQxRoleRightRelationENEx();
clsQxRoleRightRelationBL.QxRoleRightRelationDA.CopyTo(objQxRoleRightRelationENS, objQxRoleRightRelationENT);
 return objQxRoleRightRelationENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsQxRoleRightRelationENEx> GetObjExLst(string strCondition)
{
List <clsQxRoleRightRelationEN> arrObjLst = clsQxRoleRightRelationBL.GetObjLst(strCondition);
List <clsQxRoleRightRelationENEx> arrObjExLst = new List<clsQxRoleRightRelationENEx>();
foreach (clsQxRoleRightRelationEN objInFor in arrObjLst)
{
clsQxRoleRightRelationENEx objQxRoleRightRelationENEx = new clsQxRoleRightRelationENEx();
clsQxRoleRightRelationBL.CopyTo(objInFor, objQxRoleRightRelationENEx);
arrObjExLst.Add(objQxRoleRightRelationENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsQxRoleRightRelationENEx GetObjExBymId(long lngmId)
{
clsQxRoleRightRelationEN objQxRoleRightRelationEN = clsQxRoleRightRelationBL.GetObjBymId(lngmId);
clsQxRoleRightRelationENEx objQxRoleRightRelationENEx = new clsQxRoleRightRelationENEx();
clsQxRoleRightRelationBL.CopyTo(objQxRoleRightRelationEN, objQxRoleRightRelationENEx);
return objQxRoleRightRelationENEx;
}
}
}