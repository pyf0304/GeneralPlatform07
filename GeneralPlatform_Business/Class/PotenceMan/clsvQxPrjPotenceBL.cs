
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjPotenceBL
 表名:vQxPrjPotence(00140027)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:46
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using GeneralPlatform.Entity;
using System.Data; 
using System.Data.SqlClient; 
using GeneralPlatform.DAL;

namespace GeneralPlatform.BusinessLogic
{
public static class  clsvQxPrjPotenceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjPotenceEN GetObj(this K_PotenceId_vQxPrjPotence myKey)
{
clsvQxPrjPotenceEN objvQxPrjPotenceEN = clsvQxPrjPotenceBL.vQxPrjPotenceDA.GetObjByPotenceId(myKey.Value);
return objvQxPrjPotenceEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxPrjPotence.PotenceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxPrjPotence.PotenceId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxPrjPotence.PotenceName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxPrjPotence.PotenceName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetQxPrjId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjPotence.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjPotence.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjPotence.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPrjName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjPotence.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjPotence.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetFuncModuleId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxPrjPotence.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxPrjPotence.FuncModuleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceTypeId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeId, convQxPrjPotence.PotenceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxPrjPotence.PotenceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxPrjPotence.PotenceTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetPotenceTypeName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxPrjPotence.PotenceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxPrjPotence.PotenceTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetFuncModuleName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxPrjPotence.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetFuncModuleNameSim(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxPrjPotence.FuncModuleNameSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetMenuId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxPrjPotence.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxPrjPotence.MenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetMenuName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxPrjPotence.MenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpMenuId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxPrjPotence.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxPrjPotence.UpMenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpMenuName(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuName, 30, convQxPrjPotence.UpMenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpdDate(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxPrjPotence.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjPotence.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetUpdUserId(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjPotence.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjPotence.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetMemo(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjPotence.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjPotenceEN SetSymbolNum(this clsvQxPrjPotenceEN objvQxPrjPotenceEN, int? intSymbolNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjPotenceENS">源对象</param>
 /// <param name = "objvQxPrjPotenceENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjPotenceEN objvQxPrjPotenceENS, clsvQxPrjPotenceEN objvQxPrjPotenceENT)
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvQxPrjPotenceENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjPotenceEN:objvQxPrjPotenceENT</returns>
 public static clsvQxPrjPotenceEN CopyTo(this clsvQxPrjPotenceEN objvQxPrjPotenceENS)
{
try
{
 clsvQxPrjPotenceEN objvQxPrjPotenceENT = new clsvQxPrjPotenceEN()
{
PotenceId = objvQxPrjPotenceENS.PotenceId, //权限ID
PotenceName = objvQxPrjPotenceENS.PotenceName, //权限名称
QxPrjId = objvQxPrjPotenceENS.QxPrjId, //项目Id
PrjName = objvQxPrjPotenceENS.PrjName, //工程名
FuncModuleId = objvQxPrjPotenceENS.FuncModuleId, //模块Id
PotenceTypeId = objvQxPrjPotenceENS.PotenceTypeId, //权限类型Id
PotenceTypeName = objvQxPrjPotenceENS.PotenceTypeName, //权限类型名
FuncModuleName = objvQxPrjPotenceENS.FuncModuleName, //模块名
FuncModuleNameSim = objvQxPrjPotenceENS.FuncModuleNameSim, //模块名_Sim
InUse = objvQxPrjPotenceENS.InUse, //是否在用
IsVisible = objvQxPrjPotenceENS.IsVisible, //是否显示
MenuId = objvQxPrjPotenceENS.MenuId, //菜单Id
MenuName = objvQxPrjPotenceENS.MenuName, //菜单名
UpMenuId = objvQxPrjPotenceENS.UpMenuId, //上级菜单Id
IsLeafNode = objvQxPrjPotenceENS.IsLeafNode, //是否叶子
UpMenuName = objvQxPrjPotenceENS.UpMenuName, //上级菜单名
UpdDate = objvQxPrjPotenceENS.UpdDate, //修改日期
UpdUserId = objvQxPrjPotenceENS.UpdUserId, //修改用户Id
Memo = objvQxPrjPotenceENS.Memo, //备注
SymbolNum = objvQxPrjPotenceENS.SymbolNum, //标志数
};
 return objvQxPrjPotenceENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
 clsvQxPrjPotenceBL.vQxPrjPotenceDA.CheckProperty4Condition(objvQxPrjPotenceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjPotence
{
public virtual bool UpdRelaTabDate(string strPotenceId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程权限(vQxPrjPotence)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjPotenceBL
{
public static RelatedActions_vQxPrjPotence relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjPotenceListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjPotenceList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjPotenceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjPotenceDA vQxPrjPotenceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjPotenceDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjPotenceBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvQxPrjPotenceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjPotenceEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vQxPrjPotenceDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vQxPrjPotenceDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vQxPrjPotenceDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vQxPrjPotence(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable_vQxPrjPotence(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vQxPrjPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrPotenceIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByPotenceIdLst(List<string> arrPotenceIdLst)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPotenceIdLst, true);
 string strWhereCond = string.Format("PotenceId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPotenceIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjPotenceEN> GetObjLstByPotenceIdLstCache(List<string> arrPotenceIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjPotenceEN._CurrTabName);
List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLst_Sel =
arrvQxPrjPotenceObjLstCache
.Where(x => arrPotenceIdLst.Contains(x.PotenceId));
return arrvQxPrjPotenceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjPotenceEN> GetSubObjLstCache(clsvQxPrjPotenceEN objvQxPrjPotenceCond)
{
List<clsvQxPrjPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjPotence.AttributeName)
{
if (objvQxPrjPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjPotenceCond[strFldName].ToString());
}
else
{
if (objvQxPrjPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjPotenceCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvQxPrjPotenceEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjPotenceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvQxPrjPotenceEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjPotenceEN objvQxPrjPotenceCond, string strOrderBy)
{
List<clsvQxPrjPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjPotence.AttributeName)
{
if (objvQxPrjPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjPotenceCond[strFldName].ToString());
}
else
{
if (objvQxPrjPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjPotenceCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvQxPrjPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjPotenceEN objvQxPrjPotenceCond = JsonConvert.DeserializeObject<clsvQxPrjPotenceEN>(objPagerPara.whereCond);
if (objvQxPrjPotenceCond.sfFldComparisonOp == null)
{
objvQxPrjPotenceCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjPotenceCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjPotenceCond.sfFldComparisonOp);
}
clsvQxPrjPotenceBL.SetUpdFlag(objvQxPrjPotenceCond);
 try
{
CheckProperty4Condition(objvQxPrjPotenceCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjPotenceBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjPotenceCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjPotenceEN> arrObjLst = new List<clsvQxPrjPotenceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
try
{
objvQxPrjPotenceEN.PotenceId = objRow[convQxPrjPotence.PotenceId].ToString().Trim(); //权限ID
objvQxPrjPotenceEN.PotenceName = objRow[convQxPrjPotence.PotenceName].ToString().Trim(); //权限名称
objvQxPrjPotenceEN.QxPrjId = objRow[convQxPrjPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjPotenceEN.PrjName = objRow[convQxPrjPotence.PrjName].ToString().Trim(); //工程名
objvQxPrjPotenceEN.FuncModuleId = objRow[convQxPrjPotence.FuncModuleId] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleId].ToString().Trim(); //模块Id
objvQxPrjPotenceEN.PotenceTypeId = objRow[convQxPrjPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPrjPotenceEN.PotenceTypeName = objRow[convQxPrjPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPrjPotenceEN.FuncModuleName = objRow[convQxPrjPotence.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjPotenceEN.FuncModuleNameSim = objRow[convQxPrjPotence.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxPrjPotence.FuncModuleNameSim].ToString().Trim(); //模块名_Sim
objvQxPrjPotenceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.InUse].ToString().Trim()); //是否在用
objvQxPrjPotenceEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsVisible].ToString().Trim()); //是否显示
objvQxPrjPotenceEN.MenuId = objRow[convQxPrjPotence.MenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuId].ToString().Trim(); //菜单Id
objvQxPrjPotenceEN.MenuName = objRow[convQxPrjPotence.MenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.MenuName].ToString().Trim(); //菜单名
objvQxPrjPotenceEN.UpMenuId = objRow[convQxPrjPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxPrjPotenceEN.IsLeafNode = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjPotence.IsLeafNode].ToString().Trim()); //是否叶子
objvQxPrjPotenceEN.UpMenuName = objRow[convQxPrjPotence.UpMenuName] == DBNull.Value ? null : objRow[convQxPrjPotence.UpMenuName].ToString().Trim(); //上级菜单名
objvQxPrjPotenceEN.UpdDate = objRow[convQxPrjPotence.UpdDate].ToString().Trim(); //修改日期
objvQxPrjPotenceEN.UpdUserId = objRow[convQxPrjPotence.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjPotenceEN.Memo = objRow[convQxPrjPotence.Memo] == DBNull.Value ? null : objRow[convQxPrjPotence.Memo].ToString().Trim(); //备注
objvQxPrjPotenceEN.SymbolNum = objRow[convQxPrjPotence.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxPrjPotence.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjPotenceEN.PotenceId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjPotenceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjPotence(ref clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
bool bolResult = vQxPrjPotenceDA.GetvQxPrjPotence(ref objvQxPrjPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjPotenceEN GetObjByPotenceId(string strPotenceId)
{
if (strPotenceId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPotenceId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPotenceId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPotenceId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjPotenceEN objvQxPrjPotenceEN = vQxPrjPotenceDA.GetObjByPotenceId(strPotenceId);
return objvQxPrjPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjPotenceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjPotenceEN objvQxPrjPotenceEN = vQxPrjPotenceDA.GetFirstObj(strWhereCond);
 return objvQxPrjPotenceEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvQxPrjPotenceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjPotenceEN objvQxPrjPotenceEN = vQxPrjPotenceDA.GetObjByDataRow(objRow);
 return objvQxPrjPotenceEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvQxPrjPotenceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjPotenceEN objvQxPrjPotenceEN = vQxPrjPotenceDA.GetObjByDataRow(objRow);
 return objvQxPrjPotenceEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strPotenceId">所给的关键字</param>
 /// <param name = "lstvQxPrjPotenceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjPotenceEN GetObjByPotenceIdFromList(string strPotenceId, List<clsvQxPrjPotenceEN> lstvQxPrjPotenceObjLst)
{
foreach (clsvQxPrjPotenceEN objvQxPrjPotenceEN in lstvQxPrjPotenceObjLst)
{
if (objvQxPrjPotenceEN.PotenceId == strPotenceId)
{
return objvQxPrjPotenceEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strPotenceId;
 try
 {
 strPotenceId = new clsvQxPrjPotenceDA().GetFirstID(strWhereCond);
 return strPotenceId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vQxPrjPotenceDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vQxPrjPotenceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPotenceId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPotenceId)
{
if (string.IsNullOrEmpty(strPotenceId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPotenceId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjPotenceDA.IsExist(strPotenceId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvQxPrjPotenceDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vQxPrjPotenceDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
try
{
objvQxPrjPotenceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjPotenceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjPotence.PotenceId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.PotenceId = objvQxPrjPotenceEN.PotenceId; //权限ID
}
if (arrFldSet.Contains(convQxPrjPotence.PotenceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.PotenceName = objvQxPrjPotenceEN.PotenceName; //权限名称
}
if (arrFldSet.Contains(convQxPrjPotence.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.QxPrjId = objvQxPrjPotenceEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjPotence.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.PrjName = objvQxPrjPotenceEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjPotence.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.FuncModuleId = objvQxPrjPotenceEN.FuncModuleId == "[null]" ? null :  objvQxPrjPotenceEN.FuncModuleId; //模块Id
}
if (arrFldSet.Contains(convQxPrjPotence.PotenceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.PotenceTypeId = objvQxPrjPotenceEN.PotenceTypeId; //权限类型Id
}
if (arrFldSet.Contains(convQxPrjPotence.PotenceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.PotenceTypeName = objvQxPrjPotenceEN.PotenceTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxPrjPotence.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.FuncModuleName = objvQxPrjPotenceEN.FuncModuleName == "[null]" ? null :  objvQxPrjPotenceEN.FuncModuleName; //模块名
}
if (arrFldSet.Contains(convQxPrjPotence.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.FuncModuleNameSim = objvQxPrjPotenceEN.FuncModuleNameSim == "[null]" ? null :  objvQxPrjPotenceEN.FuncModuleNameSim; //模块名_Sim
}
if (arrFldSet.Contains(convQxPrjPotence.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.InUse = objvQxPrjPotenceEN.InUse; //是否在用
}
if (arrFldSet.Contains(convQxPrjPotence.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.IsVisible = objvQxPrjPotenceEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convQxPrjPotence.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.MenuId = objvQxPrjPotenceEN.MenuId == "[null]" ? null :  objvQxPrjPotenceEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(convQxPrjPotence.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.MenuName = objvQxPrjPotenceEN.MenuName == "[null]" ? null :  objvQxPrjPotenceEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxPrjPotence.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.UpMenuId = objvQxPrjPotenceEN.UpMenuId == "[null]" ? null :  objvQxPrjPotenceEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxPrjPotence.IsLeafNode, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.IsLeafNode = objvQxPrjPotenceEN.IsLeafNode; //是否叶子
}
if (arrFldSet.Contains(convQxPrjPotence.UpMenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.UpMenuName = objvQxPrjPotenceEN.UpMenuName == "[null]" ? null :  objvQxPrjPotenceEN.UpMenuName; //上级菜单名
}
if (arrFldSet.Contains(convQxPrjPotence.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.UpdDate = objvQxPrjPotenceEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjPotence.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.UpdUserId = objvQxPrjPotenceEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjPotence.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.Memo = objvQxPrjPotenceEN.Memo == "[null]" ? null :  objvQxPrjPotenceEN.Memo; //备注
}
if (arrFldSet.Contains(convQxPrjPotence.SymbolNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjPotenceEN.SymbolNum = objvQxPrjPotenceEN.SymbolNum; //标志数
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
try
{
if (objvQxPrjPotenceEN.FuncModuleId == "[null]") objvQxPrjPotenceEN.FuncModuleId = null; //模块Id
if (objvQxPrjPotenceEN.FuncModuleName == "[null]") objvQxPrjPotenceEN.FuncModuleName = null; //模块名
if (objvQxPrjPotenceEN.FuncModuleNameSim == "[null]") objvQxPrjPotenceEN.FuncModuleNameSim = null; //模块名_Sim
if (objvQxPrjPotenceEN.MenuId == "[null]") objvQxPrjPotenceEN.MenuId = null; //菜单Id
if (objvQxPrjPotenceEN.MenuName == "[null]") objvQxPrjPotenceEN.MenuName = null; //菜单名
if (objvQxPrjPotenceEN.UpMenuId == "[null]") objvQxPrjPotenceEN.UpMenuId = null; //上级菜单Id
if (objvQxPrjPotenceEN.UpMenuName == "[null]") objvQxPrjPotenceEN.UpMenuName = null; //上级菜单名
if (objvQxPrjPotenceEN.Memo == "[null]") objvQxPrjPotenceEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
 vQxPrjPotenceDA.CheckProperty4Condition(objvQxPrjPotenceEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_PotenceId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjPotence.PotenceId); 
List<clsvQxPrjPotenceEN> arrObjLst = clsvQxPrjPotenceBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程权限]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxPrjPotence.PotenceId); 
IEnumerable<clsvQxPrjPotenceEN> arrObjLst = clsvQxPrjPotenceBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxPrjPotence.PotenceId;
objDDL.DataTextField = convQxPrjPotence.PotenceName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PotenceIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程权限]...","0");
List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLst = GetAllvQxPrjPotenceObjLstCache(); 
objDDL.DataValueField = convQxPrjPotence.PotenceId;
objDDL.DataTextField = convQxPrjPotence.PotenceName;
objDDL.DataSource = arrvQxPrjPotenceObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsQxPrjPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjPotenceBL没有刷新缓存机制(clsQxPrjPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPotenceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPotenceTypeBL没有刷新缓存机制(clsQxPotenceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxViewInfoBL没有刷新缓存机制(clsQxViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxFuncModuleBL没有刷新缓存机制(clsQxFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjMenusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenusBL没有刷新缓存机制(clsQxPrjMenusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPageDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPageDispModeBL没有刷新缓存机制(clsQxPageDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjMenuSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenuSetBL没有刷新缓存机制(clsQxPrjMenuSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxApplicationTypeBL没有刷新缓存机制(clsQxApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjTabBL没有刷新缓存机制(clsQxPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PotenceId");
//if (arrvQxPrjPotenceObjLstCache == null)
//{
//arrvQxPrjPotenceObjLstCache = vQxPrjPotenceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPotenceId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjPotenceEN GetObjByPotenceIdCache(string strPotenceId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjPotenceEN._CurrTabName);
List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLst_Sel =
arrvQxPrjPotenceObjLstCache
.Where(x=> x.PotenceId == strPotenceId 
);
if (arrvQxPrjPotenceObjLst_Sel.Count() == 0)
{
   clsvQxPrjPotenceEN obj = clsvQxPrjPotenceBL.GetObjByPotenceId(strPotenceId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjPotenceObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPotenceId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPotenceNameByPotenceIdCache(string strPotenceId)
{
if (string.IsNullOrEmpty(strPotenceId) == true) return "";
//获取缓存中的对象列表
clsvQxPrjPotenceEN objvQxPrjPotence = GetObjByPotenceIdCache(strPotenceId);
if (objvQxPrjPotence == null) return "";
return objvQxPrjPotence.PotenceName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPotenceId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPotenceIdCache(string strPotenceId)
{
if (string.IsNullOrEmpty(strPotenceId) == true) return "";
//获取缓存中的对象列表
clsvQxPrjPotenceEN objvQxPrjPotence = GetObjByPotenceIdCache(strPotenceId);
if (objvQxPrjPotence == null) return "";
return objvQxPrjPotence.PotenceName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetAllvQxPrjPotenceObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLstCache = GetObjLstCache(); 
return arrvQxPrjPotenceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjPotenceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjPotenceEN._CurrTabName);
List<clsvQxPrjPotenceEN> arrvQxPrjPotenceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjPotenceObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjPotenceEN> lstvQxPrjPotenceObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjPotenceObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvQxPrjPotenceObjLst">[clsvQxPrjPotenceEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjPotenceEN> lstvQxPrjPotenceObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjPotenceBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjPotenceBL.itemsXmlNode);
foreach (clsvQxPrjPotenceEN objvQxPrjPotenceEN in lstvQxPrjPotenceObjLst)
{
clsvQxPrjPotenceBL.SerializeXML(writer, objvQxPrjPotenceEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvQxPrjPotenceEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
writer.WriteStartElement(clsvQxPrjPotenceBL.itemXmlNode);
 
if (objvQxPrjPotenceEN.PotenceId != null)
{
writer.WriteElementString(convQxPrjPotence.PotenceId, objvQxPrjPotenceEN.PotenceId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.PotenceName != null)
{
writer.WriteElementString(convQxPrjPotence.PotenceName, objvQxPrjPotenceEN.PotenceName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjPotence.QxPrjId, objvQxPrjPotenceEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.PrjName != null)
{
writer.WriteElementString(convQxPrjPotence.PrjName, objvQxPrjPotenceEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.FuncModuleId != null)
{
writer.WriteElementString(convQxPrjPotence.FuncModuleId, objvQxPrjPotenceEN.FuncModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.PotenceTypeId != null)
{
writer.WriteElementString(convQxPrjPotence.PotenceTypeId, objvQxPrjPotenceEN.PotenceTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.PotenceTypeName != null)
{
writer.WriteElementString(convQxPrjPotence.PotenceTypeName, objvQxPrjPotenceEN.PotenceTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.FuncModuleName != null)
{
writer.WriteElementString(convQxPrjPotence.FuncModuleName, objvQxPrjPotenceEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.FuncModuleNameSim != null)
{
writer.WriteElementString(convQxPrjPotence.FuncModuleNameSim, objvQxPrjPotenceEN.FuncModuleNameSim.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjPotence.InUse, objvQxPrjPotenceEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convQxPrjPotence.IsVisible, objvQxPrjPotenceEN.IsVisible.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjPotenceEN.MenuId != null)
{
writer.WriteElementString(convQxPrjPotence.MenuId, objvQxPrjPotenceEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.MenuName != null)
{
writer.WriteElementString(convQxPrjPotence.MenuName, objvQxPrjPotenceEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.UpMenuId != null)
{
writer.WriteElementString(convQxPrjPotence.UpMenuId, objvQxPrjPotenceEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjPotence.IsLeafNode, objvQxPrjPotenceEN.IsLeafNode.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjPotenceEN.UpMenuName != null)
{
writer.WriteElementString(convQxPrjPotence.UpMenuName, objvQxPrjPotenceEN.UpMenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjPotence.UpdDate, objvQxPrjPotenceEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjPotence.UpdUserId, objvQxPrjPotenceEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjPotenceEN.Memo != null)
{
writer.WriteElementString(convQxPrjPotence.Memo, objvQxPrjPotenceEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjPotence.SymbolNum, objvQxPrjPotenceEN.SymbolNum.ToString());
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjPotenceEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
reader.Read();
while (!(reader.Name == clsvQxPrjPotenceBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjPotence.PotenceId))
{
objvQxPrjPotenceEN.PotenceId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.PotenceName))
{
objvQxPrjPotenceEN.PotenceName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.QxPrjId))
{
objvQxPrjPotenceEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.PrjName))
{
objvQxPrjPotenceEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.FuncModuleId))
{
objvQxPrjPotenceEN.FuncModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.PotenceTypeId))
{
objvQxPrjPotenceEN.PotenceTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.PotenceTypeName))
{
objvQxPrjPotenceEN.PotenceTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.FuncModuleName))
{
objvQxPrjPotenceEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.FuncModuleNameSim))
{
objvQxPrjPotenceEN.FuncModuleNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.InUse))
{
objvQxPrjPotenceEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjPotence.IsVisible))
{
objvQxPrjPotenceEN.IsVisible = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjPotence.MenuId))
{
objvQxPrjPotenceEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.MenuName))
{
objvQxPrjPotenceEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.UpMenuId))
{
objvQxPrjPotenceEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.IsLeafNode))
{
objvQxPrjPotenceEN.IsLeafNode = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjPotence.UpMenuName))
{
objvQxPrjPotenceEN.UpMenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.UpdDate))
{
objvQxPrjPotenceEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.UpdUserId))
{
objvQxPrjPotenceEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.Memo))
{
objvQxPrjPotenceEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjPotence.SymbolNum))
{
objvQxPrjPotenceEN.SymbolNum = reader.ReadElementContentAsInt();
}
}
return objvQxPrjPotenceEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjPotenceObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjPotenceEN GetObjFromXmlStr(string strvQxPrjPotenceObjXmlStr)
{
clsvQxPrjPotenceEN objvQxPrjPotenceEN = new clsvQxPrjPotenceEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjPotenceObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjPotenceBL.itemXmlNode))
{
objvQxPrjPotenceEN = GetObjFromXml(reader);
return objvQxPrjPotenceEN;
}
}
return objvQxPrjPotenceEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjPotenceEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPotenceId)
{
if (strInFldName != convQxPrjPotence.PotenceId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjPotence.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjPotence.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjPotence = clsvQxPrjPotenceBL.GetObjByPotenceIdCache(strPotenceId);
if (objvQxPrjPotence == null) return "";
return objvQxPrjPotence[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjPotenceEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjPotenceEN objvQxPrjPotenceEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjPotenceEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjPotenceEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvQxPrjPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjPotenceEN> lstvQxPrjPotenceObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjPotenceObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjPotenceEN objvQxPrjPotenceEN in lstvQxPrjPotenceObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjPotenceEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvQxPrjPotenceDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvQxPrjPotenceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjPotenceDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvQxPrjPotenceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjPotenceEN objvQxPrjPotenceCond)
{
List<clsvQxPrjPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjPotence.AttributeName)
{
if (objvQxPrjPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjPotenceCond[strFldName].ToString());
}
else
{
if (objvQxPrjPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjPotenceCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvQxPrjPotenceDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vQxPrjPotenceDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vQxPrjPotenceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}