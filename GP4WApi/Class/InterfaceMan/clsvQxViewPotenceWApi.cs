
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewPotenceWApi
 表名:vQxViewPotence(00140028)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:32:12
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
 框架-层名:WA_访问层(CS)(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using GeneralPlatform.Entity;

namespace GP4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxViewPotenceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetmId(this clsvQxViewPotenceEN objvQxViewPotenceEN, long lngmId, string strComparisonOp="")
	{
objvQxViewPotenceEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.mId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.mId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.mId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetQxPrjId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxViewPotence.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxViewPotence.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxViewPotence.QxPrjId);
objvQxViewPotenceEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.QxPrjId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.QxPrjId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.QxPrjId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceId">权限ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetPotenceId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxViewPotence.PotenceId);
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxViewPotence.PotenceId);
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxViewPotence.PotenceId);
objvQxViewPotenceEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.PotenceId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.PotenceId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.PotenceId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceName">权限名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetPotenceName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxViewPotence.PotenceName);
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxViewPotence.PotenceName);
objvQxViewPotenceEN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.PotenceName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.PotenceName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.PotenceName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetPrjName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxViewPotence.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxViewPotence.PrjName);
objvQxViewPotenceEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.PrjName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.PrjName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.PrjName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetViewId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convQxViewPotence.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convQxViewPotence.ViewId);
objvQxViewPotenceEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ViewId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ViewId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ViewId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetViewName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convQxViewPotence.ViewName);
clsCheckSql.CheckFieldLen(strViewName, 100, convQxViewPotence.ViewName);
objvQxViewPotenceEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ViewName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ViewName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ViewName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "intLevel">等级</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetLevel(this clsvQxViewPotenceEN objvQxViewPotenceEN, int intLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intLevel, convQxViewPotence.Level);
objvQxViewPotenceEN.Level = intLevel; //等级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.Level) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.Level, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.Level] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strModuleId">模块号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetModuleId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strModuleId, convQxViewPotence.ModuleId);
clsCheckSql.CheckFieldLen(strModuleId, 6, convQxViewPotence.ModuleId);
clsCheckSql.CheckFieldForeignKey(strModuleId, 6, convQxViewPotence.ModuleId);
objvQxViewPotenceEN.ModuleId = strModuleId; //模块号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ModuleId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ModuleId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ModuleId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strModuleName">模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetModuleName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strModuleName, convQxViewPotence.ModuleName);
clsCheckSql.CheckFieldLen(strModuleName, 100, convQxViewPotence.ModuleName);
objvQxViewPotenceEN.ModuleName = strModuleName; //模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ModuleName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ModuleName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ModuleName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetMemo(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxViewPotence.Memo);
objvQxViewPotenceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.Memo) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.Memo, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.Memo] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxViewPotenceEN objvQxViewPotenceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.mId) == true)
{
string strComparisonOpmId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxViewPotence.mId, objvQxViewPotenceCond.mId, strComparisonOpmId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.QxPrjId, objvQxViewPotenceCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.PotenceId) == true)
{
string strComparisonOpPotenceId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.PotenceId, objvQxViewPotenceCond.PotenceId, strComparisonOpPotenceId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.PotenceName) == true)
{
string strComparisonOpPotenceName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.PotenceName, objvQxViewPotenceCond.PotenceName, strComparisonOpPotenceName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.PrjName) == true)
{
string strComparisonOpPrjName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.PrjName, objvQxViewPotenceCond.PrjName, strComparisonOpPrjName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ViewId) == true)
{
string strComparisonOpViewId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ViewId, objvQxViewPotenceCond.ViewId, strComparisonOpViewId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ViewName) == true)
{
string strComparisonOpViewName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ViewName, objvQxViewPotenceCond.ViewName, strComparisonOpViewName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.Level) == true)
{
string strComparisonOpLevel = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.Level];
strWhereCond += string.Format(" And {0} {2} {1}", convQxViewPotence.Level, objvQxViewPotenceCond.Level, strComparisonOpLevel);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ModuleId) == true)
{
string strComparisonOpModuleId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ModuleId, objvQxViewPotenceCond.ModuleId, strComparisonOpModuleId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ModuleName) == true)
{
string strComparisonOpModuleName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ModuleName, objvQxViewPotenceCond.ModuleName, strComparisonOpModuleName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.Memo) == true)
{
string strComparisonOpMemo = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.Memo, objvQxViewPotenceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面权限(vQxViewPotence)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxViewPotenceWApi
{
private static readonly string mstrApiControllerName = "vQxViewPotenceApi";

 public clsvQxViewPotenceWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxViewPotenceEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxViewPotenceEN objvQxViewPotenceEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxViewPotenceEN = JsonConvert.DeserializeObject<clsvQxViewPotenceEN>(strJson);
return objvQxViewPotenceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvQxViewPotenceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxViewPotenceEN objvQxViewPotenceEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxViewPotenceEN = JsonConvert.DeserializeObject<clsvQxViewPotenceEN>(strJson);
return objvQxViewPotenceEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsvQxViewPotenceEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewPotenceEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxViewPotenceEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewPotenceEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxViewPotenceEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewPotenceEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxViewPotenceEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewPotenceEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxViewPotenceEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewPotenceEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxViewPotenceEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxViewPotenceEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxViewPotenceENS">源对象</param>
 /// <param name = "objvQxViewPotenceENT">目标对象</param>
 public static void CopyTo(clsvQxViewPotenceEN objvQxViewPotenceENS, clsvQxViewPotenceEN objvQxViewPotenceENT)
{
try
{
objvQxViewPotenceENT.mId = objvQxViewPotenceENS.mId; //流水号
objvQxViewPotenceENT.QxPrjId = objvQxViewPotenceENS.QxPrjId; //项目Id
objvQxViewPotenceENT.PotenceId = objvQxViewPotenceENS.PotenceId; //权限ID
objvQxViewPotenceENT.PotenceName = objvQxViewPotenceENS.PotenceName; //权限名称
objvQxViewPotenceENT.PrjName = objvQxViewPotenceENS.PrjName; //工程名
objvQxViewPotenceENT.ViewId = objvQxViewPotenceENS.ViewId; //界面编号
objvQxViewPotenceENT.ViewName = objvQxViewPotenceENS.ViewName; //界面名称
objvQxViewPotenceENT.Level = objvQxViewPotenceENS.Level; //等级
objvQxViewPotenceENT.ModuleId = objvQxViewPotenceENS.ModuleId; //模块号
objvQxViewPotenceENT.ModuleName = objvQxViewPotenceENS.ModuleName; //模块名称
objvQxViewPotenceENT.Memo = objvQxViewPotenceENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvQxViewPotenceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxViewPotenceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxViewPotenceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxViewPotenceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxViewPotenceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxViewPotenceEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvQxViewPotenceEN._CurrTabName);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxViewPotenceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxViewPotence.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxViewPotence.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.PotenceId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.PotenceName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.Level, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxViewPotence.ModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.ModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxViewPotence.Memo, Type.GetType("System.String"));
foreach (clsvQxViewPotenceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxViewPotence.mId] = objInFor[convQxViewPotence.mId];
objDR[convQxViewPotence.QxPrjId] = objInFor[convQxViewPotence.QxPrjId];
objDR[convQxViewPotence.PotenceId] = objInFor[convQxViewPotence.PotenceId];
objDR[convQxViewPotence.PotenceName] = objInFor[convQxViewPotence.PotenceName];
objDR[convQxViewPotence.PrjName] = objInFor[convQxViewPotence.PrjName];
objDR[convQxViewPotence.ViewId] = objInFor[convQxViewPotence.ViewId];
objDR[convQxViewPotence.ViewName] = objInFor[convQxViewPotence.ViewName];
objDR[convQxViewPotence.Level] = objInFor[convQxViewPotence.Level];
objDR[convQxViewPotence.ModuleId] = objInFor[convQxViewPotence.ModuleId];
objDR[convQxViewPotence.ModuleName] = objInFor[convQxViewPotence.ModuleName];
objDR[convQxViewPotence.Memo] = objInFor[convQxViewPotence.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}