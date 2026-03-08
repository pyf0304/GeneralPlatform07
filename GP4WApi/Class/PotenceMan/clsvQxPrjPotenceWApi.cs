
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjPotenceWApi
 表名:vQxPrjPotence(00140027)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:36:58
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
public static class  clsvQxPrjPotenceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceId">权限ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxPrjPotence.PotenceId);
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxPrjPotence.PotenceId);
objvQxPrjPotenceEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.PotenceId) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.PotenceId, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.PotenceId] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceName">权限名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxPrjPotence.PotenceName);
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxPrjPotence.PotenceName);
objvQxPrjPotenceEN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.PotenceName) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.PotenceName, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.PotenceName] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetQxPrjId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjPotence.QxPrjId);
objvQxPrjPotenceEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.QxPrjId) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPrjName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjPotence.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjPotence.PrjName);
objvQxPrjPotenceEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.PrjName) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.PrjName, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.PrjName] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleId">模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetFuncModuleId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxPrjPotence.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxPrjPotence.FuncModuleId);
objvQxPrjPotenceEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.FuncModuleId) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.FuncModuleId, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.FuncModuleId] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeId">权限类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceTypeId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeId, convQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxPrjPotence.PotenceTypeId);
objvQxPrjPotenceEN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.PotenceTypeId) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.PotenceTypeId, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.PotenceTypeId] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeName">权限类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceTypeName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxPrjPotence.PotenceTypeName);
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxPrjPotence.PotenceTypeName);
objvQxPrjPotenceEN.PotenceTypeName = strPotenceTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.PotenceTypeName) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.PotenceTypeName, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.PotenceTypeName] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">模块名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetFuncModuleName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxPrjPotence.FuncModuleName);
objvQxPrjPotenceEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.FuncModuleName) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.FuncModuleName, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.FuncModuleName] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">模块名_Sim</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetFuncModuleNameSim(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxPrjPotence.FuncModuleNameSim);
objvQxPrjPotenceEN.FuncModuleNameSim = strFuncModuleNameSim; //模块名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.FuncModuleNameSim) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetInUse(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, bool bolInUse, string strComparisonOp="")
	{
objvQxPrjPotenceEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.InUse) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.InUse, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.InUse] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetIsVisible(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, bool bolIsVisible, string strComparisonOp="")
	{
objvQxPrjPotenceEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.IsVisible) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.IsVisible, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.IsVisible] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetMenuId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxPrjPotence.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxPrjPotence.MenuId);
objvQxPrjPotenceEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.MenuId) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.MenuId, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.MenuId] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetMenuName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjPotence.MenuName);
objvQxPrjPotenceEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.MenuName) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.MenuName, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.MenuName] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpMenuId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjPotence.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjPotence.UpMenuId);
objvQxPrjPotenceEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.UpMenuId) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.UpMenuId, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.UpMenuId] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeafNode">是否叶子</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetIsLeafNode(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, bool bolIsLeafNode, string strComparisonOp="")
	{
objvQxPrjPotenceEN.IsLeafNode = bolIsLeafNode; //是否叶子
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.IsLeafNode) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.IsLeafNode, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.IsLeafNode] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuName">上级菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpMenuName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxPrjPotence.UpMenuName);
objvQxPrjPotenceEN.UpMenuName = strUpMenuName; //上级菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.UpMenuName) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.UpMenuName, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.UpMenuName] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpdDate(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxPrjPotence.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjPotence.UpdDate);
objvQxPrjPotenceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.UpdDate) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.UpdDate, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.UpdDate] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpdUserId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjPotence.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjPotence.UpdUserId);
objvQxPrjPotenceEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.UpdUserId) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetMemo(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjPotence.Memo);
objvQxPrjPotenceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.Memo) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.Memo, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.Memo] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "intSymbolNum">标志数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetSymbolNum(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, int intSymbolNum, string strComparisonOp="")
	{
objvQxPrjPotenceEN.SymbolNum = intSymbolNum; //标志数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(convQxPrjPotence.SymbolNum) == false)
{
objvQxPrjPotenceEN.dicFldComparisonOp.Add(convQxPrjPotence.SymbolNum, strComparisonOp);
}
else
{
objvQxPrjPotenceEN.dicFldComparisonOp[convQxPrjPotence.SymbolNum] = strComparisonOp;
}
}
return objvQxPrjPotenceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjPotenceEN objvQxPrjPotenceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.PotenceId) == true)
{
string strComparisonOpPotenceId = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.PotenceId, objvQxPrjPotenceCond.PotenceId, strComparisonOpPotenceId);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.PotenceName) == true)
{
string strComparisonOpPotenceName = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.PotenceName, objvQxPrjPotenceCond.PotenceName, strComparisonOpPotenceName);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.QxPrjId, objvQxPrjPotenceCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.PrjName, objvQxPrjPotenceCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.FuncModuleId, objvQxPrjPotenceCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.PotenceTypeId, objvQxPrjPotenceCond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.PotenceTypeName) == true)
{
string strComparisonOpPotenceTypeName = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.PotenceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.PotenceTypeName, objvQxPrjPotenceCond.PotenceTypeName, strComparisonOpPotenceTypeName);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.FuncModuleName, objvQxPrjPotenceCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.FuncModuleNameSim, objvQxPrjPotenceCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.InUse) == true)
{
if (objvQxPrjPotenceCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjPotence.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjPotence.InUse);
}
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.IsVisible) == true)
{
if (objvQxPrjPotenceCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjPotence.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjPotence.IsVisible);
}
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.MenuId) == true)
{
string strComparisonOpMenuId = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.MenuId, objvQxPrjPotenceCond.MenuId, strComparisonOpMenuId);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.MenuName) == true)
{
string strComparisonOpMenuName = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.MenuName, objvQxPrjPotenceCond.MenuName, strComparisonOpMenuName);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.UpMenuId, objvQxPrjPotenceCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.IsLeafNode) == true)
{
if (objvQxPrjPotenceCond.IsLeafNode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjPotence.IsLeafNode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjPotence.IsLeafNode);
}
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.UpMenuName) == true)
{
string strComparisonOpUpMenuName = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.UpMenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.UpMenuName, objvQxPrjPotenceCond.UpMenuName, strComparisonOpUpMenuName);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.UpdDate, objvQxPrjPotenceCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.UpdUserId, objvQxPrjPotenceCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjPotence.Memo, objvQxPrjPotenceCond.Memo, strComparisonOpMemo);
}
if (objvQxPrjPotenceCond.IsUpdated(convQxPrjPotence.SymbolNum) == true)
{
string strComparisonOpSymbolNum = objvQxPrjPotenceCond.dicFldComparisonOp[convQxPrjPotence.SymbolNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjPotence.SymbolNum, objvQxPrjPotenceCond.SymbolNum, strComparisonOpSymbolNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程权限(vQxPrjPotence)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjPotenceWApi
{
private static readonly string mstrApiControllerName = "vQxPrjPotenceApi";

 public clsvQxPrjPotenceWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程权限]...","0");
List<clsvQxPrjPotenceEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PotenceId";
objDDL.DataTextField="PotenceName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PotenceId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjPotence.PotenceId); 
List<clsvQxPrjPotenceEN> arrObjLst = clsvQxPrjPotenceWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN()
{
PotenceId = "0",
PotenceName = "选[v工程权限]..."
};
arrObjLst.Insert(0, objvQxPrjPotenceEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxPrjPotence.PotenceId;
objComboBox.DisplayMember = convQxPrjPotence.PotenceName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjPotenceEN GetObjByPotenceId(string strPotenceId)
{
string strAction = "GetObjByPotenceId";
clsvQxPrjPotenceEN objvQxPrjPotenceEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPotenceId"] = strPotenceId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPrjPotenceEN = JsonConvert.DeserializeObject<clsvQxPrjPotenceEN>(strJson);
return objvQxPrjPotenceEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsvQxPrjPotenceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjPotenceEN objvQxPrjPotenceEN;
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
objvQxPrjPotenceEN = JsonConvert.DeserializeObject<clsvQxPrjPotenceEN>(strJson);
return objvQxPrjPotenceEN;
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
//该表没有使用Cache,不需要生成[GetPotenceNameByPotenceIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjPotenceEN>>(strJson);
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
 /// <param name = "arrPotenceId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByPotenceIdLst(List<string> arrPotenceId)
{
 List<clsvQxPrjPotenceEN> arrObjLst; 
string strAction = "GetObjLstByPotenceIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPotenceId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjPotenceEN>>(strJson);
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
public static List<clsvQxPrjPotenceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjPotenceEN>>(strJson);
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
public static List<clsvQxPrjPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjPotenceEN>>(strJson);
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
public static List<clsvQxPrjPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjPotenceEN>>(strJson);
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
public static List<clsvQxPrjPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjPotenceEN>>(strJson);
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
public static bool IsExist(string strPotenceId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPotenceId"] = strPotenceId
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
 /// <param name = "objvQxPrjPotenceENS">源对象</param>
 /// <param name = "objvQxPrjPotenceENT">目标对象</param>
 public static void CopyTo(clsvQxPrjPotenceEN objvQxPrjPotenceENS, clsvQxPrjPotenceEN objvQxPrjPotenceENT)
{
try
{
objvQxPrjPotenceENT.PotenceId = objvQxPrjPotenceENS.PotenceId; //权限ID
objvQxPrjPotenceENT.PotenceName = objvQxPrjPotenceENS.PotenceName; //权限名称
objvQxPrjPotenceENT.QxPrjId = objvQxPrjPotenceENS.QxPrjId; //项目Id
objvQxPrjPotenceENT.PrjName = objvQxPrjPotenceENS.PrjName; //工程名
objvQxPrjPotenceENT.FuncModuleId = objvQxPrjPotenceENS.FuncModuleId; //模块Id
objvQxPrjPotenceENT.PotenceTypeId = objvQxPrjPotenceENS.PotenceTypeId; //权限类型Id
objvQxPrjPotenceENT.PotenceTypeName = objvQxPrjPotenceENS.PotenceTypeName; //权限类型名
objvQxPrjPotenceENT.FuncModuleName = objvQxPrjPotenceENS.FuncModuleName; //模块名
objvQxPrjPotenceENT.FuncModuleNameSim = objvQxPrjPotenceENS.FuncModuleNameSim; //模块名_Sim
objvQxPrjPotenceENT.InUse = objvQxPrjPotenceENS.InUse; //是否在用
objvQxPrjPotenceENT.IsVisible = objvQxPrjPotenceENS.IsVisible; //是否显示
objvQxPrjPotenceENT.MenuId = objvQxPrjPotenceENS.MenuId; //菜单Id
objvQxPrjPotenceENT.MenuName = objvQxPrjPotenceENS.MenuName; //菜单名
objvQxPrjPotenceENT.UpMenuId = objvQxPrjPotenceENS.UpMenuId; //上级菜单Id
objvQxPrjPotenceENT.IsLeafNode = objvQxPrjPotenceENS.IsLeafNode; //是否叶子
objvQxPrjPotenceENT.UpMenuName = objvQxPrjPotenceENS.UpMenuName; //上级菜单名
objvQxPrjPotenceENT.UpdDate = objvQxPrjPotenceENS.UpdDate; //修改日期
objvQxPrjPotenceENT.UpdUserId = objvQxPrjPotenceENS.UpdUserId; //修改用户Id
objvQxPrjPotenceENT.Memo = objvQxPrjPotenceENS.Memo; //备注
objvQxPrjPotenceENT.SymbolNum = objvQxPrjPotenceENS.SymbolNum; //标志数
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
public static DataTable ToDataTable(List<clsvQxPrjPotenceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjPotenceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjPotenceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjPotenceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjPotenceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjPotenceEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjPotenceEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPrjPotenceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjPotence.PotenceId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.PotenceName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.PotenceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.PotenceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjPotence.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjPotence.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.IsLeafNode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjPotence.UpMenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjPotence.SymbolNum, Type.GetType("System.Int32"));
foreach (clsvQxPrjPotenceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjPotence.PotenceId] = objInFor[convQxPrjPotence.PotenceId];
objDR[convQxPrjPotence.PotenceName] = objInFor[convQxPrjPotence.PotenceName];
objDR[convQxPrjPotence.QxPrjId] = objInFor[convQxPrjPotence.QxPrjId];
objDR[convQxPrjPotence.PrjName] = objInFor[convQxPrjPotence.PrjName];
objDR[convQxPrjPotence.FuncModuleId] = objInFor[convQxPrjPotence.FuncModuleId];
objDR[convQxPrjPotence.PotenceTypeId] = objInFor[convQxPrjPotence.PotenceTypeId];
objDR[convQxPrjPotence.PotenceTypeName] = objInFor[convQxPrjPotence.PotenceTypeName];
objDR[convQxPrjPotence.FuncModuleName] = objInFor[convQxPrjPotence.FuncModuleName];
objDR[convQxPrjPotence.FuncModuleNameSim] = objInFor[convQxPrjPotence.FuncModuleNameSim];
objDR[convQxPrjPotence.InUse] = objInFor[convQxPrjPotence.InUse];
objDR[convQxPrjPotence.IsVisible] = objInFor[convQxPrjPotence.IsVisible];
objDR[convQxPrjPotence.MenuId] = objInFor[convQxPrjPotence.MenuId];
objDR[convQxPrjPotence.MenuName] = objInFor[convQxPrjPotence.MenuName];
objDR[convQxPrjPotence.UpMenuId] = objInFor[convQxPrjPotence.UpMenuId];
objDR[convQxPrjPotence.IsLeafNode] = objInFor[convQxPrjPotence.IsLeafNode];
objDR[convQxPrjPotence.UpMenuName] = objInFor[convQxPrjPotence.UpMenuName];
objDR[convQxPrjPotence.UpdDate] = objInFor[convQxPrjPotence.UpdDate];
objDR[convQxPrjPotence.UpdUserId] = objInFor[convQxPrjPotence.UpdUserId];
objDR[convQxPrjPotence.Memo] = objInFor[convQxPrjPotence.Memo];
objDR[convQxPrjPotence.SymbolNum] = objInFor[convQxPrjPotence.SymbolNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}