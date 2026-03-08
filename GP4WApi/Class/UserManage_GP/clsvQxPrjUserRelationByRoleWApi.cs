
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjUserRelationByRoleWApi
 表名:vQxPrjUserRelationByRole(00140076)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:08:34
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsvQxPrjUserRelationByRoleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetmId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, long lngmId, string strComparisonOp="")
	{
objvQxPrjUserRelationByRoleEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.mId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.mId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.mId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetQxPrjId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjUserRelationByRole.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjUserRelationByRole.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjUserRelationByRole.QxPrjId);
objvQxPrjUserRelationByRoleEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.QxPrjId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetIdentityId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxPrjUserRelationByRole.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxPrjUserRelationByRole.IdentityId);
objvQxPrjUserRelationByRoleEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.IdentityId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.IdentityId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetRoleId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxPrjUserRelationByRole.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxPrjUserRelationByRole.RoleId);
objvQxPrjUserRelationByRoleEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.RoleId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.RoleId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetRoleName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxPrjUserRelationByRole.RoleName);
objvQxPrjUserRelationByRoleEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.RoleName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.RoleName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetPrjName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjUserRelationByRole.PrjName);
objvQxPrjUserRelationByRoleEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.PrjName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.PrjName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.PrjName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetUserId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxPrjUserRelationByRole.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxPrjUserRelationByRole.UserId);
objvQxPrjUserRelationByRoleEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.UserId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.UserId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.UserId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetUserName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxPrjUserRelationByRole.UserName);
objvQxPrjUserRelationByRoleEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.UserName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.UserName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.UserName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetDepartmentId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxPrjUserRelationByRole.DepartmentId);
objvQxPrjUserRelationByRoleEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.DepartmentId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.DepartmentId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetDepartmentName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxPrjUserRelationByRole.DepartmentName);
objvQxPrjUserRelationByRoleEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.DepartmentName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.DepartmentName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetUserStateName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxPrjUserRelationByRole.UserStateName);
objvQxPrjUserRelationByRoleEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.UserStateName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.UserStateName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.UserStateName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetIdentityDesc(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxPrjUserRelationByRole.IdentityDesc);
objvQxPrjUserRelationByRoleEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.IdentityDesc) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.IdentityDesc, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityDesc] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.mId) == true)
{
string strComparisonOpmId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjUserRelationByRole.mId, objvQxPrjUserRelationByRoleCond.mId, strComparisonOpmId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.QxPrjId, objvQxPrjUserRelationByRoleCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.IdentityId, objvQxPrjUserRelationByRoleCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.RoleId) == true)
{
string strComparisonOpRoleId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.RoleId, objvQxPrjUserRelationByRoleCond.RoleId, strComparisonOpRoleId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.RoleName) == true)
{
string strComparisonOpRoleName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.RoleName, objvQxPrjUserRelationByRoleCond.RoleName, strComparisonOpRoleName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.PrjName, objvQxPrjUserRelationByRoleCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.UserId) == true)
{
string strComparisonOpUserId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.UserId, objvQxPrjUserRelationByRoleCond.UserId, strComparisonOpUserId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.UserName) == true)
{
string strComparisonOpUserName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.UserName, objvQxPrjUserRelationByRoleCond.UserName, strComparisonOpUserName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.DepartmentId, objvQxPrjUserRelationByRoleCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.DepartmentName, objvQxPrjUserRelationByRoleCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.UserStateName, objvQxPrjUserRelationByRoleCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.IdentityDesc, objvQxPrjUserRelationByRoleCond.IdentityDesc, strComparisonOpIdentityDesc);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程用户关系ByRole(vQxPrjUserRelationByRole)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjUserRelationByRoleWApi
{
private static readonly string mstrApiControllerName = "vQxPrjUserRelationByRoleApi";

 public clsvQxPrjUserRelationByRoleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelationByRoleEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN;
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
objvQxPrjUserRelationByRoleEN = JsonConvert.DeserializeObject<clsvQxPrjUserRelationByRoleEN>(strJson);
return objvQxPrjUserRelationByRoleEN;
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
public static clsvQxPrjUserRelationByRoleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN;
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
objvQxPrjUserRelationByRoleEN = JsonConvert.DeserializeObject<clsvQxPrjUserRelationByRoleEN>(strJson);
return objvQxPrjUserRelationByRoleEN;
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjUserRelationByRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationByRoleEN>>(strJson);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxPrjUserRelationByRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationByRoleEN>>(strJson);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjUserRelationByRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationByRoleEN>>(strJson);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjUserRelationByRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationByRoleEN>>(strJson);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjUserRelationByRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationByRoleEN>>(strJson);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjUserRelationByRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationByRoleEN>>(strJson);
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
 /// <param name = "objvQxPrjUserRelationByRoleENS">源对象</param>
 /// <param name = "objvQxPrjUserRelationByRoleENT">目标对象</param>
 public static void CopyTo(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENS, clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENT)
{
try
{
objvQxPrjUserRelationByRoleENT.mId = objvQxPrjUserRelationByRoleENS.mId; //流水号
objvQxPrjUserRelationByRoleENT.QxPrjId = objvQxPrjUserRelationByRoleENS.QxPrjId; //项目Id
objvQxPrjUserRelationByRoleENT.IdentityId = objvQxPrjUserRelationByRoleENS.IdentityId; //身份编号
objvQxPrjUserRelationByRoleENT.RoleId = objvQxPrjUserRelationByRoleENS.RoleId; //角色Id
objvQxPrjUserRelationByRoleENT.RoleName = objvQxPrjUserRelationByRoleENS.RoleName; //角色名称
objvQxPrjUserRelationByRoleENT.PrjName = objvQxPrjUserRelationByRoleENS.PrjName; //工程名
objvQxPrjUserRelationByRoleENT.UserId = objvQxPrjUserRelationByRoleENS.UserId; //用户ID
objvQxPrjUserRelationByRoleENT.UserName = objvQxPrjUserRelationByRoleENS.UserName; //用户名
objvQxPrjUserRelationByRoleENT.DepartmentId = objvQxPrjUserRelationByRoleENS.DepartmentId; //部门Id
objvQxPrjUserRelationByRoleENT.DepartmentName = objvQxPrjUserRelationByRoleENS.DepartmentName; //部门名
objvQxPrjUserRelationByRoleENT.UserStateName = objvQxPrjUserRelationByRoleENS.UserStateName; //用户状态名
objvQxPrjUserRelationByRoleENT.IdentityDesc = objvQxPrjUserRelationByRoleENS.IdentityDesc; //身份描述
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
public static DataTable ToDataTable(List<clsvQxPrjUserRelationByRoleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjUserRelationByRoleEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjUserRelationByRoleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjUserRelationByRoleEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjUserRelationByRoleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjUserRelationByRoleEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjUserRelationByRoleEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPrjUserRelationByRoleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjUserRelationByRole.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxPrjUserRelationByRole.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelationByRole.IdentityDesc, Type.GetType("System.String"));
foreach (clsvQxPrjUserRelationByRoleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjUserRelationByRole.mId] = objInFor[convQxPrjUserRelationByRole.mId];
objDR[convQxPrjUserRelationByRole.QxPrjId] = objInFor[convQxPrjUserRelationByRole.QxPrjId];
objDR[convQxPrjUserRelationByRole.IdentityId] = objInFor[convQxPrjUserRelationByRole.IdentityId];
objDR[convQxPrjUserRelationByRole.RoleId] = objInFor[convQxPrjUserRelationByRole.RoleId];
objDR[convQxPrjUserRelationByRole.RoleName] = objInFor[convQxPrjUserRelationByRole.RoleName];
objDR[convQxPrjUserRelationByRole.PrjName] = objInFor[convQxPrjUserRelationByRole.PrjName];
objDR[convQxPrjUserRelationByRole.UserId] = objInFor[convQxPrjUserRelationByRole.UserId];
objDR[convQxPrjUserRelationByRole.UserName] = objInFor[convQxPrjUserRelationByRole.UserName];
objDR[convQxPrjUserRelationByRole.DepartmentId] = objInFor[convQxPrjUserRelationByRole.DepartmentId];
objDR[convQxPrjUserRelationByRole.DepartmentName] = objInFor[convQxPrjUserRelationByRole.DepartmentName];
objDR[convQxPrjUserRelationByRole.UserStateName] = objInFor[convQxPrjUserRelationByRole.UserStateName];
objDR[convQxPrjUserRelationByRole.IdentityDesc] = objInFor[convQxPrjUserRelationByRole.IdentityDesc];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}