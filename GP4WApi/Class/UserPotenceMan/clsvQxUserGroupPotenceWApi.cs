
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserGroupPotenceWApi
 表名:vQxUserGroupPotence(00140022)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:50
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户权限管理(UserPotenceMan)
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
using GP4WApi;

namespace GeneralPlatform4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxUserGroupPotenceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetmId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, long lngmId, string strComparisonOp="")
	{
objvQxUserGroupPotenceEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.mId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.mId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.mId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetUserId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserGroupPotence.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserGroupPotence.UserId);
objvQxUserGroupPotenceEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.UserId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.UserId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.UserId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetUserName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserGroupPotence.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserGroupPotence.UserName);
objvQxUserGroupPotenceEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.UserName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.UserName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.UserName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupId">组Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetGroupId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupId, 8, convQxUserGroupPotence.GroupId);
clsCheckSql.CheckFieldForeignKey(strGroupId, 8, convQxUserGroupPotence.GroupId);
objvQxUserGroupPotenceEN.GroupId = strGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.GroupId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.GroupId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.GroupId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupName">组名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetGroupName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convQxUserGroupPotence.GroupName);
clsCheckSql.CheckFieldLen(strGroupName, 30, convQxUserGroupPotence.GroupName);
objvQxUserGroupPotenceEN.GroupName = strGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.GroupName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.GroupName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.GroupName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetRoleId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserGroupPotence.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserGroupPotence.RoleId);
objvQxUserGroupPotenceEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.RoleId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.RoleId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.RoleId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetRoleName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserGroupPotence.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserGroupPotence.RoleName);
objvQxUserGroupPotenceEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.RoleName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.RoleName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.RoleName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetQxPrjId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserGroupPotence.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserGroupPotence.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserGroupPotence.QxPrjId);
objvQxUserGroupPotenceEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.QxPrjId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.QxPrjId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.QxPrjId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPrjName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserGroupPotence.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserGroupPotence.PrjName);
objvQxUserGroupPotenceEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.PrjName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.PrjName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.PrjName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceId">权限ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxUserGroupPotence.PotenceId);
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxUserGroupPotence.PotenceId);
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxUserGroupPotence.PotenceId);
objvQxUserGroupPotenceEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.PotenceId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.PotenceId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.PotenceId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceName">权限名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxUserGroupPotence.PotenceName);
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxUserGroupPotence.PotenceName);
objvQxUserGroupPotenceEN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.PotenceName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.PotenceName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.PotenceName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeId">权限类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceTypeId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxUserGroupPotence.PotenceTypeId);
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxUserGroupPotence.PotenceTypeId);
objvQxUserGroupPotenceEN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.PotenceTypeId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.PotenceTypeId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.PotenceTypeId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeName">权限类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceTypeName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxUserGroupPotence.PotenceTypeName);
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxUserGroupPotence.PotenceTypeName);
objvQxUserGroupPotenceEN.PotenceTypeName = strPotenceTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.PotenceTypeName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.PotenceTypeName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.PotenceTypeName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetMenuId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxUserGroupPotence.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxUserGroupPotence.MenuId);
objvQxUserGroupPotenceEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.MenuId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.MenuId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.MenuId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuName">菜单名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetMenuName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strMenuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxUserGroupPotence.MenuName);
objvQxUserGroupPotenceEN.MenuName = strMenuName; //菜单名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.MenuName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.MenuName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.MenuName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpMenuId">上级菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetUpMenuId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strUpMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxUserGroupPotence.UpMenuId);
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxUserGroupPotence.UpMenuId);
objvQxUserGroupPotenceEN.UpMenuId = strUpMenuId; //上级菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.UpMenuId) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.UpMenuId, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.UpMenuId] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "lngRelaMid">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetRelaMid(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, long lngRelaMid, string strComparisonOp="")
	{
objvQxUserGroupPotenceEN.RelaMid = lngRelaMid; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.RelaMid) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.RelaMid, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.RelaMid] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolForProgramme">编程标志</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetSymbolForProgramme(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strSymbolForProgramme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSymbolForProgramme, 20, convQxUserGroupPotence.SymbolForProgramme);
objvQxUserGroupPotenceEN.SymbolForProgramme = strSymbolForProgramme; //编程标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.SymbolForProgramme) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.SymbolForProgramme, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.SymbolForProgramme] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolName">标志名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetSymbolName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strSymbolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSymbolName, 200, convQxUserGroupPotence.SymbolName);
objvQxUserGroupPotenceEN.SymbolName = strSymbolName; //标志名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.SymbolName) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.SymbolName, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.SymbolName] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetMemo(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserGroupPotence.Memo);
objvQxUserGroupPotenceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserGroupPotenceEN.dicFldComparisonOp.ContainsKey(convQxUserGroupPotence.Memo) == false)
{
objvQxUserGroupPotenceEN.dicFldComparisonOp.Add(convQxUserGroupPotence.Memo, strComparisonOp);
}
else
{
objvQxUserGroupPotenceEN.dicFldComparisonOp[convQxUserGroupPotence.Memo] = strComparisonOp;
}
}
return objvQxUserGroupPotenceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.mId) == true)
{
string strComparisonOpmId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserGroupPotence.mId, objvQxUserGroupPotenceCond.mId, strComparisonOpmId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.UserId) == true)
{
string strComparisonOpUserId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.UserId, objvQxUserGroupPotenceCond.UserId, strComparisonOpUserId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.UserName) == true)
{
string strComparisonOpUserName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.UserName, objvQxUserGroupPotenceCond.UserName, strComparisonOpUserName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.GroupId) == true)
{
string strComparisonOpGroupId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.GroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.GroupId, objvQxUserGroupPotenceCond.GroupId, strComparisonOpGroupId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.GroupName) == true)
{
string strComparisonOpGroupName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.GroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.GroupName, objvQxUserGroupPotenceCond.GroupName, strComparisonOpGroupName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.RoleId, objvQxUserGroupPotenceCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.RoleName, objvQxUserGroupPotenceCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.QxPrjId, objvQxUserGroupPotenceCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.PrjName, objvQxUserGroupPotenceCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.PotenceId) == true)
{
string strComparisonOpPotenceId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.PotenceId, objvQxUserGroupPotenceCond.PotenceId, strComparisonOpPotenceId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.PotenceName) == true)
{
string strComparisonOpPotenceName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.PotenceName, objvQxUserGroupPotenceCond.PotenceName, strComparisonOpPotenceName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.PotenceTypeId, objvQxUserGroupPotenceCond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.PotenceTypeName) == true)
{
string strComparisonOpPotenceTypeName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.PotenceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.PotenceTypeName, objvQxUserGroupPotenceCond.PotenceTypeName, strComparisonOpPotenceTypeName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.MenuId) == true)
{
string strComparisonOpMenuId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.MenuId, objvQxUserGroupPotenceCond.MenuId, strComparisonOpMenuId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.MenuName) == true)
{
string strComparisonOpMenuName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.MenuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.MenuName, objvQxUserGroupPotenceCond.MenuName, strComparisonOpMenuName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.UpMenuId) == true)
{
string strComparisonOpUpMenuId = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.UpMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.UpMenuId, objvQxUserGroupPotenceCond.UpMenuId, strComparisonOpUpMenuId);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.RelaMid) == true)
{
string strComparisonOpRelaMid = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.RelaMid];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserGroupPotence.RelaMid, objvQxUserGroupPotenceCond.RelaMid, strComparisonOpRelaMid);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.SymbolForProgramme) == true)
{
string strComparisonOpSymbolForProgramme = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.SymbolForProgramme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.SymbolForProgramme, objvQxUserGroupPotenceCond.SymbolForProgramme, strComparisonOpSymbolForProgramme);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.SymbolName) == true)
{
string strComparisonOpSymbolName = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.SymbolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.SymbolName, objvQxUserGroupPotenceCond.SymbolName, strComparisonOpSymbolName);
}
if (objvQxUserGroupPotenceCond.IsUpdated(convQxUserGroupPotence.Memo) == true)
{
string strComparisonOpMemo = objvQxUserGroupPotenceCond.dicFldComparisonOp[convQxUserGroupPotence.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserGroupPotence.Memo, objvQxUserGroupPotenceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户权限关系(vQxUserGroupPotence)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserGroupPotenceWApi
{
private static readonly string mstrApiControllerName = "vQxUserGroupPotenceApi";

 public clsvQxUserGroupPotenceWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserGroupPotenceEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN;
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
objvQxUserGroupPotenceEN = JsonConvert.DeserializeObject<clsvQxUserGroupPotenceEN>(strJson);
return objvQxUserGroupPotenceEN;
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
public static clsvQxUserGroupPotenceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN;
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
objvQxUserGroupPotenceEN = JsonConvert.DeserializeObject<clsvQxUserGroupPotenceEN>(strJson);
return objvQxUserGroupPotenceEN;
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
public static List<clsvQxUserGroupPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserGroupPotenceEN>>(strJson);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserGroupPotenceEN>>(strJson);
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
public static List<clsvQxUserGroupPotenceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserGroupPotenceEN>>(strJson);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserGroupPotenceEN>>(strJson);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserGroupPotenceEN>>(strJson);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserGroupPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserGroupPotenceEN>>(strJson);
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
 /// <param name = "objvQxUserGroupPotenceENS">源对象</param>
 /// <param name = "objvQxUserGroupPotenceENT">目标对象</param>
 public static void CopyTo(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceENS, clsvQxUserGroupPotenceEN objvQxUserGroupPotenceENT)
{
try
{
objvQxUserGroupPotenceENT.mId = objvQxUserGroupPotenceENS.mId; //流水号
objvQxUserGroupPotenceENT.UserId = objvQxUserGroupPotenceENS.UserId; //用户ID
objvQxUserGroupPotenceENT.UserName = objvQxUserGroupPotenceENS.UserName; //用户名
objvQxUserGroupPotenceENT.GroupId = objvQxUserGroupPotenceENS.GroupId; //组Id
objvQxUserGroupPotenceENT.GroupName = objvQxUserGroupPotenceENS.GroupName; //组名
objvQxUserGroupPotenceENT.RoleId = objvQxUserGroupPotenceENS.RoleId; //角色Id
objvQxUserGroupPotenceENT.RoleName = objvQxUserGroupPotenceENS.RoleName; //角色名称
objvQxUserGroupPotenceENT.QxPrjId = objvQxUserGroupPotenceENS.QxPrjId; //项目Id
objvQxUserGroupPotenceENT.PrjName = objvQxUserGroupPotenceENS.PrjName; //工程名
objvQxUserGroupPotenceENT.PotenceId = objvQxUserGroupPotenceENS.PotenceId; //权限ID
objvQxUserGroupPotenceENT.PotenceName = objvQxUserGroupPotenceENS.PotenceName; //权限名称
objvQxUserGroupPotenceENT.PotenceTypeId = objvQxUserGroupPotenceENS.PotenceTypeId; //权限类型Id
objvQxUserGroupPotenceENT.PotenceTypeName = objvQxUserGroupPotenceENS.PotenceTypeName; //权限类型名
objvQxUserGroupPotenceENT.MenuId = objvQxUserGroupPotenceENS.MenuId; //菜单Id
objvQxUserGroupPotenceENT.MenuName = objvQxUserGroupPotenceENS.MenuName; //菜单名
objvQxUserGroupPotenceENT.UpMenuId = objvQxUserGroupPotenceENS.UpMenuId; //上级菜单Id
objvQxUserGroupPotenceENT.RelaMid = objvQxUserGroupPotenceENS.RelaMid; //流水号
objvQxUserGroupPotenceENT.SymbolForProgramme = objvQxUserGroupPotenceENS.SymbolForProgramme; //编程标志
objvQxUserGroupPotenceENT.SymbolName = objvQxUserGroupPotenceENS.SymbolName; //标志名称
objvQxUserGroupPotenceENT.Memo = objvQxUserGroupPotenceENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUserGroupPotenceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserGroupPotenceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserGroupPotenceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserGroupPotenceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserGroupPotenceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserGroupPotenceEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserGroupPotenceEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxUserGroupPotenceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserGroupPotence.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUserGroupPotence.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.GroupId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.GroupName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.PotenceId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.PotenceName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.PotenceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.PotenceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.MenuName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.UpMenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.RelaMid, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUserGroupPotence.SymbolForProgramme, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.SymbolName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserGroupPotence.Memo, Type.GetType("System.String"));
foreach (clsvQxUserGroupPotenceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserGroupPotence.mId] = objInFor[convQxUserGroupPotence.mId];
objDR[convQxUserGroupPotence.UserId] = objInFor[convQxUserGroupPotence.UserId];
objDR[convQxUserGroupPotence.UserName] = objInFor[convQxUserGroupPotence.UserName];
objDR[convQxUserGroupPotence.GroupId] = objInFor[convQxUserGroupPotence.GroupId];
objDR[convQxUserGroupPotence.GroupName] = objInFor[convQxUserGroupPotence.GroupName];
objDR[convQxUserGroupPotence.RoleId] = objInFor[convQxUserGroupPotence.RoleId];
objDR[convQxUserGroupPotence.RoleName] = objInFor[convQxUserGroupPotence.RoleName];
objDR[convQxUserGroupPotence.QxPrjId] = objInFor[convQxUserGroupPotence.QxPrjId];
objDR[convQxUserGroupPotence.PrjName] = objInFor[convQxUserGroupPotence.PrjName];
objDR[convQxUserGroupPotence.PotenceId] = objInFor[convQxUserGroupPotence.PotenceId];
objDR[convQxUserGroupPotence.PotenceName] = objInFor[convQxUserGroupPotence.PotenceName];
objDR[convQxUserGroupPotence.PotenceTypeId] = objInFor[convQxUserGroupPotence.PotenceTypeId];
objDR[convQxUserGroupPotence.PotenceTypeName] = objInFor[convQxUserGroupPotence.PotenceTypeName];
objDR[convQxUserGroupPotence.MenuId] = objInFor[convQxUserGroupPotence.MenuId];
objDR[convQxUserGroupPotence.MenuName] = objInFor[convQxUserGroupPotence.MenuName];
objDR[convQxUserGroupPotence.UpMenuId] = objInFor[convQxUserGroupPotence.UpMenuId];
objDR[convQxUserGroupPotence.RelaMid] = objInFor[convQxUserGroupPotence.RelaMid];
objDR[convQxUserGroupPotence.SymbolForProgramme] = objInFor[convQxUserGroupPotence.SymbolForProgramme];
objDR[convQxUserGroupPotence.SymbolName] = objInFor[convQxUserGroupPotence.SymbolName];
objDR[convQxUserGroupPotence.Memo] = objInFor[convQxUserGroupPotence.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}