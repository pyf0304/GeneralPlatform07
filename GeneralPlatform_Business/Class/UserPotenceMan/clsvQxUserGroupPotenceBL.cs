
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserGroupPotenceBL
 表名:vQxUserGroupPotence(00140022)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:42:35
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户权限管理(UserPotenceMan)
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
public static class  clsvQxUserGroupPotenceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserGroupPotenceEN GetObj(this K_mId_vQxUserGroupPotence myKey)
{
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = clsvQxUserGroupPotenceBL.vQxUserGroupPotenceDA.GetObjBymId(myKey.Value);
return objvQxUserGroupPotenceEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetUserId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserGroupPotence.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserGroupPotence.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetUserName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserGroupPotence.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserGroupPotence.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetGroupId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupId, 8, convQxUserGroupPotence.GroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupId, 8, convQxUserGroupPotence.GroupId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetGroupName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupName, convQxUserGroupPotence.GroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupName, 30, convQxUserGroupPotence.GroupName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetRoleId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserGroupPotence.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserGroupPotence.RoleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetRoleName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserGroupPotence.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserGroupPotence.RoleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetQxPrjId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserGroupPotence.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserGroupPotence.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserGroupPotence.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPrjName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserGroupPotence.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserGroupPotence.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxUserGroupPotence.PotenceId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxUserGroupPotence.PotenceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxUserGroupPotence.PotenceId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxUserGroupPotence.PotenceName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxUserGroupPotence.PotenceName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceTypeId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxUserGroupPotence.PotenceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxUserGroupPotence.PotenceTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetPotenceTypeName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxUserGroupPotence.PotenceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxUserGroupPotence.PotenceTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetMenuId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxUserGroupPotence.MenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, convQxUserGroupPotence.MenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetMenuName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strMenuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuName, 50, convQxUserGroupPotence.MenuName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetUpMenuId(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strUpMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpMenuId, 8, convQxUserGroupPotence.UpMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpMenuId, 8, convQxUserGroupPotence.UpMenuId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetRelaMid(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, long? lngRelaMid, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetSymbolForProgramme(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strSymbolForProgramme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolForProgramme, 20, convQxUserGroupPotence.SymbolForProgramme);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetSymbolName(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strSymbolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolName, 200, convQxUserGroupPotence.SymbolName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserGroupPotenceEN SetMemo(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserGroupPotence.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceENS">源对象</param>
 /// <param name = "objvQxUserGroupPotenceENT">目标对象</param>
 public static void CopyTo(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceENS, clsvQxUserGroupPotenceEN objvQxUserGroupPotenceENT)
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
 /// <param name = "objvQxUserGroupPotenceENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserGroupPotenceEN:objvQxUserGroupPotenceENT</returns>
 public static clsvQxUserGroupPotenceEN CopyTo(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceENS)
{
try
{
 clsvQxUserGroupPotenceEN objvQxUserGroupPotenceENT = new clsvQxUserGroupPotenceEN()
{
mId = objvQxUserGroupPotenceENS.mId, //流水号
UserId = objvQxUserGroupPotenceENS.UserId, //用户ID
UserName = objvQxUserGroupPotenceENS.UserName, //用户名
GroupId = objvQxUserGroupPotenceENS.GroupId, //组Id
GroupName = objvQxUserGroupPotenceENS.GroupName, //组名
RoleId = objvQxUserGroupPotenceENS.RoleId, //角色Id
RoleName = objvQxUserGroupPotenceENS.RoleName, //角色名称
QxPrjId = objvQxUserGroupPotenceENS.QxPrjId, //项目Id
PrjName = objvQxUserGroupPotenceENS.PrjName, //工程名
PotenceId = objvQxUserGroupPotenceENS.PotenceId, //权限ID
PotenceName = objvQxUserGroupPotenceENS.PotenceName, //权限名称
PotenceTypeId = objvQxUserGroupPotenceENS.PotenceTypeId, //权限类型Id
PotenceTypeName = objvQxUserGroupPotenceENS.PotenceTypeName, //权限类型名
MenuId = objvQxUserGroupPotenceENS.MenuId, //菜单Id
MenuName = objvQxUserGroupPotenceENS.MenuName, //菜单名
UpMenuId = objvQxUserGroupPotenceENS.UpMenuId, //上级菜单Id
RelaMid = objvQxUserGroupPotenceENS.RelaMid, //流水号
SymbolForProgramme = objvQxUserGroupPotenceENS.SymbolForProgramme, //编程标志
SymbolName = objvQxUserGroupPotenceENS.SymbolName, //标志名称
Memo = objvQxUserGroupPotenceENS.Memo, //备注
};
 return objvQxUserGroupPotenceENT;
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
public static void CheckProperty4Condition(this clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
 clsvQxUserGroupPotenceBL.vQxUserGroupPotenceDA.CheckProperty4Condition(objvQxUserGroupPotenceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserGroupPotence
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户权限关系(vQxUserGroupPotence)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserGroupPotenceBL
{
public static RelatedActions_vQxUserGroupPotence relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserGroupPotenceListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserGroupPotenceList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserGroupPotenceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserGroupPotenceDA vQxUserGroupPotenceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserGroupPotenceDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserGroupPotenceBL()
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
if (string.IsNullOrEmpty(clsvQxUserGroupPotenceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserGroupPotenceEN._ConnectString);
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
objDS = vQxUserGroupPotenceDA.GetDataSet(strWhereCond);
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
objDS = vQxUserGroupPotenceDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserGroupPotenceDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserGroupPotence(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserGroupPotenceDA.GetDataTable_vQxUserGroupPotence(strWhereCond);
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
objDT = vQxUserGroupPotenceDA.GetDataTable(strWhereCond);
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
objDT = vQxUserGroupPotenceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserGroupPotenceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserGroupPotenceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserGroupPotenceDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserGroupPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserGroupPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserGroupPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserGroupPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserGroupPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserGroupPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserGroupPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserGroupPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserGroupPotenceEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxUserGroupPotenceEN._CurrTabName);
List<clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLst_Sel =
arrvQxUserGroupPotenceObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxUserGroupPotenceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserGroupPotenceEN> GetSubObjLstCache(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceCond)
{
List<clsvQxUserGroupPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserGroupPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserGroupPotence.AttributeName)
{
if (objvQxUserGroupPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserGroupPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserGroupPotenceCond[strFldName].ToString());
}
else
{
if (objvQxUserGroupPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserGroupPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserGroupPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserGroupPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserGroupPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserGroupPotenceCond[strFldName]));
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
List<clsvQxUserGroupPotenceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserGroupPotenceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserGroupPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
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
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
public static List<clsvQxUserGroupPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
public static IEnumerable<clsvQxUserGroupPotenceEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserGroupPotenceEN objvQxUserGroupPotenceCond, string strOrderBy)
{
List<clsvQxUserGroupPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserGroupPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserGroupPotence.AttributeName)
{
if (objvQxUserGroupPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserGroupPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserGroupPotenceCond[strFldName].ToString());
}
else
{
if (objvQxUserGroupPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserGroupPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserGroupPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserGroupPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserGroupPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserGroupPotenceCond[strFldName]));
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
public static IEnumerable<clsvQxUserGroupPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceCond = JsonConvert.DeserializeObject<clsvQxUserGroupPotenceEN>(objPagerPara.whereCond);
if (objvQxUserGroupPotenceCond.sfFldComparisonOp == null)
{
objvQxUserGroupPotenceCond.dicFldComparisonOp = null;
}
else
{
objvQxUserGroupPotenceCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserGroupPotenceCond.sfFldComparisonOp);
}
clsvQxUserGroupPotenceBL.SetUpdFlag(objvQxUserGroupPotenceCond);
 try
{
CheckProperty4Condition(objvQxUserGroupPotenceCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserGroupPotenceBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserGroupPotenceCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
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
public static List<clsvQxUserGroupPotenceEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserGroupPotenceEN> arrObjLst = new List<clsvQxUserGroupPotenceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
try
{
objvQxUserGroupPotenceEN.mId = Int32.Parse(objRow[convQxUserGroupPotence.mId].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.UserId = objRow[convQxUserGroupPotence.UserId].ToString().Trim(); //用户ID
objvQxUserGroupPotenceEN.UserName = objRow[convQxUserGroupPotence.UserName].ToString().Trim(); //用户名
objvQxUserGroupPotenceEN.GroupId = objRow[convQxUserGroupPotence.GroupId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.GroupId].ToString().Trim(); //组Id
objvQxUserGroupPotenceEN.GroupName = objRow[convQxUserGroupPotence.GroupName].ToString().Trim(); //组名
objvQxUserGroupPotenceEN.RoleId = objRow[convQxUserGroupPotence.RoleId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.RoleId].ToString().Trim(); //角色Id
objvQxUserGroupPotenceEN.RoleName = objRow[convQxUserGroupPotence.RoleName].ToString().Trim(); //角色名称
objvQxUserGroupPotenceEN.QxPrjId = objRow[convQxUserGroupPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxUserGroupPotenceEN.PrjName = objRow[convQxUserGroupPotence.PrjName].ToString().Trim(); //工程名
objvQxUserGroupPotenceEN.PotenceId = objRow[convQxUserGroupPotence.PotenceId].ToString().Trim(); //权限ID
objvQxUserGroupPotenceEN.PotenceName = objRow[convQxUserGroupPotence.PotenceName].ToString().Trim(); //权限名称
objvQxUserGroupPotenceEN.PotenceTypeId = objRow[convQxUserGroupPotence.PotenceTypeId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxUserGroupPotenceEN.PotenceTypeName = objRow[convQxUserGroupPotence.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxUserGroupPotenceEN.MenuId = objRow[convQxUserGroupPotence.MenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuId].ToString().Trim(); //菜单Id
objvQxUserGroupPotenceEN.MenuName = objRow[convQxUserGroupPotence.MenuName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.MenuName].ToString().Trim(); //菜单名
objvQxUserGroupPotenceEN.UpMenuId = objRow[convQxUserGroupPotence.UpMenuId] == DBNull.Value ? null : objRow[convQxUserGroupPotence.UpMenuId].ToString().Trim(); //上级菜单Id
objvQxUserGroupPotenceEN.RelaMid = objRow[convQxUserGroupPotence.RelaMid] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserGroupPotence.RelaMid].ToString().Trim()); //流水号
objvQxUserGroupPotenceEN.SymbolForProgramme = objRow[convQxUserGroupPotence.SymbolForProgramme] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxUserGroupPotenceEN.SymbolName = objRow[convQxUserGroupPotence.SymbolName] == DBNull.Value ? null : objRow[convQxUserGroupPotence.SymbolName].ToString().Trim(); //标志名称
objvQxUserGroupPotenceEN.Memo = objRow[convQxUserGroupPotence.Memo] == DBNull.Value ? null : objRow[convQxUserGroupPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserGroupPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserGroupPotenceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserGroupPotence(ref clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
bool bolResult = vQxUserGroupPotenceDA.GetvQxUserGroupPotence(ref objvQxUserGroupPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserGroupPotenceEN GetObjBymId(long lngmId)
{
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = vQxUserGroupPotenceDA.GetObjBymId(lngmId);
return objvQxUserGroupPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserGroupPotenceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = vQxUserGroupPotenceDA.GetFirstObj(strWhereCond);
 return objvQxUserGroupPotenceEN;
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
public static clsvQxUserGroupPotenceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = vQxUserGroupPotenceDA.GetObjByDataRow(objRow);
 return objvQxUserGroupPotenceEN;
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
public static clsvQxUserGroupPotenceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = vQxUserGroupPotenceDA.GetObjByDataRow(objRow);
 return objvQxUserGroupPotenceEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvQxUserGroupPotenceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserGroupPotenceEN GetObjBymIdFromList(long lngmId, List<clsvQxUserGroupPotenceEN> lstvQxUserGroupPotenceObjLst)
{
foreach (clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN in lstvQxUserGroupPotenceObjLst)
{
if (objvQxUserGroupPotenceEN.mId == lngmId)
{
return objvQxUserGroupPotenceEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvQxUserGroupPotenceDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vQxUserGroupPotenceDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserGroupPotenceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vQxUserGroupPotenceDA.IsExist(lngmId);
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
 bolIsExist = clsvQxUserGroupPotenceDA.IsExistTable();
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
 bolIsExist = vQxUserGroupPotenceDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserGroupPotenceEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
try
{
objvQxUserGroupPotenceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserGroupPotenceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserGroupPotence.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.mId = objvQxUserGroupPotenceEN.mId; //流水号
}
if (arrFldSet.Contains(convQxUserGroupPotence.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.UserId = objvQxUserGroupPotenceEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUserGroupPotence.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.UserName = objvQxUserGroupPotenceEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUserGroupPotence.GroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.GroupId = objvQxUserGroupPotenceEN.GroupId == "[null]" ? null :  objvQxUserGroupPotenceEN.GroupId; //组Id
}
if (arrFldSet.Contains(convQxUserGroupPotence.GroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.GroupName = objvQxUserGroupPotenceEN.GroupName; //组名
}
if (arrFldSet.Contains(convQxUserGroupPotence.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.RoleId = objvQxUserGroupPotenceEN.RoleId == "[null]" ? null :  objvQxUserGroupPotenceEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxUserGroupPotence.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.RoleName = objvQxUserGroupPotenceEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxUserGroupPotence.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.QxPrjId = objvQxUserGroupPotenceEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxUserGroupPotence.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.PrjName = objvQxUserGroupPotenceEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxUserGroupPotence.PotenceId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.PotenceId = objvQxUserGroupPotenceEN.PotenceId; //权限ID
}
if (arrFldSet.Contains(convQxUserGroupPotence.PotenceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.PotenceName = objvQxUserGroupPotenceEN.PotenceName; //权限名称
}
if (arrFldSet.Contains(convQxUserGroupPotence.PotenceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.PotenceTypeId = objvQxUserGroupPotenceEN.PotenceTypeId == "[null]" ? null :  objvQxUserGroupPotenceEN.PotenceTypeId; //权限类型Id
}
if (arrFldSet.Contains(convQxUserGroupPotence.PotenceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.PotenceTypeName = objvQxUserGroupPotenceEN.PotenceTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxUserGroupPotence.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.MenuId = objvQxUserGroupPotenceEN.MenuId == "[null]" ? null :  objvQxUserGroupPotenceEN.MenuId; //菜单Id
}
if (arrFldSet.Contains(convQxUserGroupPotence.MenuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.MenuName = objvQxUserGroupPotenceEN.MenuName == "[null]" ? null :  objvQxUserGroupPotenceEN.MenuName; //菜单名
}
if (arrFldSet.Contains(convQxUserGroupPotence.UpMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.UpMenuId = objvQxUserGroupPotenceEN.UpMenuId == "[null]" ? null :  objvQxUserGroupPotenceEN.UpMenuId; //上级菜单Id
}
if (arrFldSet.Contains(convQxUserGroupPotence.RelaMid, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.RelaMid = objvQxUserGroupPotenceEN.RelaMid; //流水号
}
if (arrFldSet.Contains(convQxUserGroupPotence.SymbolForProgramme, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.SymbolForProgramme = objvQxUserGroupPotenceEN.SymbolForProgramme == "[null]" ? null :  objvQxUserGroupPotenceEN.SymbolForProgramme; //编程标志
}
if (arrFldSet.Contains(convQxUserGroupPotence.SymbolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.SymbolName = objvQxUserGroupPotenceEN.SymbolName == "[null]" ? null :  objvQxUserGroupPotenceEN.SymbolName; //标志名称
}
if (arrFldSet.Contains(convQxUserGroupPotence.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserGroupPotenceEN.Memo = objvQxUserGroupPotenceEN.Memo == "[null]" ? null :  objvQxUserGroupPotenceEN.Memo; //备注
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
 /// <param name = "objvQxUserGroupPotenceEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
try
{
if (objvQxUserGroupPotenceEN.GroupId == "[null]") objvQxUserGroupPotenceEN.GroupId = null; //组Id
if (objvQxUserGroupPotenceEN.RoleId == "[null]") objvQxUserGroupPotenceEN.RoleId = null; //角色Id
if (objvQxUserGroupPotenceEN.PotenceTypeId == "[null]") objvQxUserGroupPotenceEN.PotenceTypeId = null; //权限类型Id
if (objvQxUserGroupPotenceEN.MenuId == "[null]") objvQxUserGroupPotenceEN.MenuId = null; //菜单Id
if (objvQxUserGroupPotenceEN.MenuName == "[null]") objvQxUserGroupPotenceEN.MenuName = null; //菜单名
if (objvQxUserGroupPotenceEN.UpMenuId == "[null]") objvQxUserGroupPotenceEN.UpMenuId = null; //上级菜单Id
if (objvQxUserGroupPotenceEN.SymbolForProgramme == "[null]") objvQxUserGroupPotenceEN.SymbolForProgramme = null; //编程标志
if (objvQxUserGroupPotenceEN.SymbolName == "[null]") objvQxUserGroupPotenceEN.SymbolName = null; //标志名称
if (objvQxUserGroupPotenceEN.Memo == "[null]") objvQxUserGroupPotenceEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
 vQxUserGroupPotenceDA.CheckProperty4Condition(objvQxUserGroupPotenceEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserGroupPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserGroupPotenceBL没有刷新缓存机制(clsQxUserGroupPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserGroupsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserGroupsBL没有刷新缓存机制(clsQxUserGroupsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersBL没有刷新缓存机制(clsQxUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRelaOfPotenceAndSymbolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRelaOfPotenceAndSymbolBL没有刷新缓存机制(clsQxRelaOfPotenceAndSymbolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjPotenceBL没有刷新缓存机制(clsQxPrjPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxUserGroupPotenceObjLstCache == null)
//{
//arrvQxUserGroupPotenceObjLstCache = vQxUserGroupPotenceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserGroupPotenceEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserGroupPotenceEN._CurrTabName);
List<clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLst_Sel =
arrvQxUserGroupPotenceObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxUserGroupPotenceObjLst_Sel.Count() == 0)
{
   clsvQxUserGroupPotenceEN obj = clsvQxUserGroupPotenceBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserGroupPotenceObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetAllvQxUserGroupPotenceObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLstCache = GetObjLstCache(); 
return arrvQxUserGroupPotenceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserGroupPotenceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserGroupPotenceEN._CurrTabName);
List<clsvQxUserGroupPotenceEN> arrvQxUserGroupPotenceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserGroupPotenceObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUserGroupPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserGroupPotenceEN> lstvQxUserGroupPotenceObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserGroupPotenceObjLst, writer);
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
 /// <param name = "lstvQxUserGroupPotenceObjLst">[clsvQxUserGroupPotenceEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserGroupPotenceEN> lstvQxUserGroupPotenceObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserGroupPotenceBL.listXmlNode);
writer.WriteStartElement(clsvQxUserGroupPotenceBL.itemsXmlNode);
foreach (clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN in lstvQxUserGroupPotenceObjLst)
{
clsvQxUserGroupPotenceBL.SerializeXML(writer, objvQxUserGroupPotenceEN);
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
 /// <param name = "objvQxUserGroupPotenceEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
writer.WriteStartElement(clsvQxUserGroupPotenceBL.itemXmlNode);
 
writer.WriteElementString(convQxUserGroupPotence.mId, objvQxUserGroupPotenceEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxUserGroupPotenceEN.UserId != null)
{
writer.WriteElementString(convQxUserGroupPotence.UserId, objvQxUserGroupPotenceEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.UserName != null)
{
writer.WriteElementString(convQxUserGroupPotence.UserName, objvQxUserGroupPotenceEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.GroupId != null)
{
writer.WriteElementString(convQxUserGroupPotence.GroupId, objvQxUserGroupPotenceEN.GroupId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.GroupName != null)
{
writer.WriteElementString(convQxUserGroupPotence.GroupName, objvQxUserGroupPotenceEN.GroupName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.RoleId != null)
{
writer.WriteElementString(convQxUserGroupPotence.RoleId, objvQxUserGroupPotenceEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.RoleName != null)
{
writer.WriteElementString(convQxUserGroupPotence.RoleName, objvQxUserGroupPotenceEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.QxPrjId != null)
{
writer.WriteElementString(convQxUserGroupPotence.QxPrjId, objvQxUserGroupPotenceEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.PrjName != null)
{
writer.WriteElementString(convQxUserGroupPotence.PrjName, objvQxUserGroupPotenceEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.PotenceId != null)
{
writer.WriteElementString(convQxUserGroupPotence.PotenceId, objvQxUserGroupPotenceEN.PotenceId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.PotenceName != null)
{
writer.WriteElementString(convQxUserGroupPotence.PotenceName, objvQxUserGroupPotenceEN.PotenceName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.PotenceTypeId != null)
{
writer.WriteElementString(convQxUserGroupPotence.PotenceTypeId, objvQxUserGroupPotenceEN.PotenceTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.PotenceTypeName != null)
{
writer.WriteElementString(convQxUserGroupPotence.PotenceTypeName, objvQxUserGroupPotenceEN.PotenceTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.MenuId != null)
{
writer.WriteElementString(convQxUserGroupPotence.MenuId, objvQxUserGroupPotenceEN.MenuId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.MenuName != null)
{
writer.WriteElementString(convQxUserGroupPotence.MenuName, objvQxUserGroupPotenceEN.MenuName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.UpMenuId != null)
{
writer.WriteElementString(convQxUserGroupPotence.UpMenuId, objvQxUserGroupPotenceEN.UpMenuId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserGroupPotence.RelaMid, objvQxUserGroupPotenceEN.RelaMid.ToString());
 
if (objvQxUserGroupPotenceEN.SymbolForProgramme != null)
{
writer.WriteElementString(convQxUserGroupPotence.SymbolForProgramme, objvQxUserGroupPotenceEN.SymbolForProgramme.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.SymbolName != null)
{
writer.WriteElementString(convQxUserGroupPotence.SymbolName, objvQxUserGroupPotenceEN.SymbolName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserGroupPotenceEN.Memo != null)
{
writer.WriteElementString(convQxUserGroupPotence.Memo, objvQxUserGroupPotenceEN.Memo.ToString(CultureInfo.InvariantCulture));
}
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
public static clsvQxUserGroupPotenceEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
reader.Read();
while (!(reader.Name == clsvQxUserGroupPotenceBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserGroupPotence.mId))
{
objvQxUserGroupPotenceEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxUserGroupPotence.UserId))
{
objvQxUserGroupPotenceEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.UserName))
{
objvQxUserGroupPotenceEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.GroupId))
{
objvQxUserGroupPotenceEN.GroupId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.GroupName))
{
objvQxUserGroupPotenceEN.GroupName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.RoleId))
{
objvQxUserGroupPotenceEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.RoleName))
{
objvQxUserGroupPotenceEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.QxPrjId))
{
objvQxUserGroupPotenceEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.PrjName))
{
objvQxUserGroupPotenceEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.PotenceId))
{
objvQxUserGroupPotenceEN.PotenceId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.PotenceName))
{
objvQxUserGroupPotenceEN.PotenceName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.PotenceTypeId))
{
objvQxUserGroupPotenceEN.PotenceTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.PotenceTypeName))
{
objvQxUserGroupPotenceEN.PotenceTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.MenuId))
{
objvQxUserGroupPotenceEN.MenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.MenuName))
{
objvQxUserGroupPotenceEN.MenuName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.UpMenuId))
{
objvQxUserGroupPotenceEN.UpMenuId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.RelaMid))
{
objvQxUserGroupPotenceEN.RelaMid = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxUserGroupPotence.SymbolForProgramme))
{
objvQxUserGroupPotenceEN.SymbolForProgramme = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.SymbolName))
{
objvQxUserGroupPotenceEN.SymbolName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserGroupPotence.Memo))
{
objvQxUserGroupPotenceEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUserGroupPotenceEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserGroupPotenceObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserGroupPotenceEN GetObjFromXmlStr(string strvQxUserGroupPotenceObjXmlStr)
{
clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN = new clsvQxUserGroupPotenceEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserGroupPotenceObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserGroupPotenceBL.itemXmlNode))
{
objvQxUserGroupPotenceEN = GetObjFromXml(reader);
return objvQxUserGroupPotenceEN;
}
}
return objvQxUserGroupPotenceEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserGroupPotenceEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convQxUserGroupPotence.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserGroupPotence.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserGroupPotence.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserGroupPotence = clsvQxUserGroupPotenceBL.GetObjBymIdCache(lngmId);
if (objvQxUserGroupPotence == null) return "";
return objvQxUserGroupPotence[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserGroupPotenceEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserGroupPotenceEN[strField]);
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
 /// <param name = "lstvQxUserGroupPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserGroupPotenceEN> lstvQxUserGroupPotenceObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserGroupPotenceObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserGroupPotenceEN objvQxUserGroupPotenceEN in lstvQxUserGroupPotenceObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserGroupPotenceEN);
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
int intRecCount = clsvQxUserGroupPotenceDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserGroupPotenceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserGroupPotenceDA.GetRecCount();
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
int intRecCount = clsvQxUserGroupPotenceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserGroupPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserGroupPotenceEN objvQxUserGroupPotenceCond)
{
List<clsvQxUserGroupPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserGroupPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserGroupPotence.AttributeName)
{
if (objvQxUserGroupPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserGroupPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserGroupPotenceCond[strFldName].ToString());
}
else
{
if (objvQxUserGroupPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserGroupPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserGroupPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserGroupPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserGroupPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserGroupPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserGroupPotenceCond[strFldName]));
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
 List<string> arrList = clsvQxUserGroupPotenceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserGroupPotenceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserGroupPotenceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}