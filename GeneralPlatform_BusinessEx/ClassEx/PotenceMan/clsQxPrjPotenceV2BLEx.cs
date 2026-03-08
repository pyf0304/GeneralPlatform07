
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjPotenceV2BLEx
 表名:QxPrjPotenceV2(00140115)
 * 版本:2023.05.10.1(服务器:WIN-SRV103-116)
 日期:2023/05/14 00:47:11
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
 /// </summary>
 public class RelatedActions_QxPrjPotenceV2Ex: RelatedActions_QxPrjPotenceV2
{
public override bool UpdRelaTabDate(int intPId, string strOpUser)
{
return true;
}
}
public static class clsQxPrjPotenceV2BLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjPotenceV2EN:objQxPrjPotenceV2ENT</returns>
 public static clsQxPrjPotenceV2ENEx CopyToEx(this clsQxPrjPotenceV2EN objQxPrjPotenceV2ENS)
{
try
{
 clsQxPrjPotenceV2ENEx objQxPrjPotenceV2ENT = new clsQxPrjPotenceV2ENEx();
clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.CopyTo(objQxPrjPotenceV2ENS, objQxPrjPotenceV2ENT);
 return objQxPrjPotenceV2ENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjPotenceV2EN:objQxPrjPotenceV2ENT</returns>
 public static clsQxPrjPotenceV2EN CopyTo(this clsQxPrjPotenceV2ENEx objQxPrjPotenceV2ENS)
{
try
{
 clsQxPrjPotenceV2EN objQxPrjPotenceV2ENT = new clsQxPrjPotenceV2EN();
clsQxPrjPotenceV2BL.CopyTo(objQxPrjPotenceV2ENS, objQxPrjPotenceV2ENT);
 return objQxPrjPotenceV2ENT;
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
 /// 工程权限V2(QxPrjPotenceV2)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsQxPrjPotenceV2BLEx : clsQxPrjPotenceV2BL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsQxPrjPotenceV2DAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsQxPrjPotenceV2DAEx QxPrjPotenceV2DAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsQxPrjPotenceV2DAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objQxPrjPotenceV2ENS">源对象</param>
 /// <returns>目标对象=>clsQxPrjPotenceV2EN:objQxPrjPotenceV2ENT</returns>
 public static clsQxPrjPotenceV2ENEx CopyToEx(clsQxPrjPotenceV2EN objQxPrjPotenceV2ENS)
{
try
{
 clsQxPrjPotenceV2ENEx objQxPrjPotenceV2ENT = new clsQxPrjPotenceV2ENEx();
clsQxPrjPotenceV2BL.QxPrjPotenceV2DA.CopyTo(objQxPrjPotenceV2ENS, objQxPrjPotenceV2ENT);
 return objQxPrjPotenceV2ENT;
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
public static List<clsQxPrjPotenceV2ENEx> GetObjExLst(string strCondition)
{
List <clsQxPrjPotenceV2EN> arrObjLst = clsQxPrjPotenceV2BL.GetObjLst(strCondition);
List <clsQxPrjPotenceV2ENEx> arrObjExLst = new List<clsQxPrjPotenceV2ENEx>();
foreach (clsQxPrjPotenceV2EN objInFor in arrObjLst)
{
clsQxPrjPotenceV2ENEx objQxPrjPotenceV2ENEx = new clsQxPrjPotenceV2ENEx();
clsQxPrjPotenceV2BL.CopyTo(objInFor, objQxPrjPotenceV2ENEx);
arrObjExLst.Add(objQxPrjPotenceV2ENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "intPId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsQxPrjPotenceV2ENEx GetObjExByPId(int intPId)
{
clsQxPrjPotenceV2EN objQxPrjPotenceV2EN = clsQxPrjPotenceV2BL.GetObjByPId(intPId);
clsQxPrjPotenceV2ENEx objQxPrjPotenceV2ENEx = new clsQxPrjPotenceV2ENEx();
clsQxPrjPotenceV2BL.CopyTo(objQxPrjPotenceV2EN, objQxPrjPotenceV2ENEx);
return objQxPrjPotenceV2ENEx;
}
}
}