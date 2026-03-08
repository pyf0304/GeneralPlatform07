
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelationWApi
 表名:vQxUserRoleRelation(00140023)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:52
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
public static class  clsvQxUserRoleRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetmId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, long lngmId, string strComparisonOp="")
	{
objvQxUserRoleRelationEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.mId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.mId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.mId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserRoleRelation.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserRoleRelation.UserId);
objvQxUserRoleRelationEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserRoleRelation.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserRoleRelation.UserName);
objvQxUserRoleRelationEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetDepartmentId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUserRoleRelation.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserRoleRelation.DepartmentId);
objvQxUserRoleRelationEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.DepartmentId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.DepartmentId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.DepartmentId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetDepartmentName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUserRoleRelation.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserRoleRelation.DepartmentName);
objvQxUserRoleRelationEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.DepartmentName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.DepartmentName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.DepartmentName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserStateId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUserRoleRelation.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserRoleRelation.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserRoleRelation.UserStateId);
objvQxUserRoleRelationEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserStateId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserStateId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserStateId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserStateName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUserRoleRelation.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserRoleRelation.UserStateName);
objvQxUserRoleRelationEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserStateName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserStateName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserStateName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetStuTeacherId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUserRoleRelation.StuTeacherId);
objvQxUserRoleRelationEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.StuTeacherId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.StuTeacherId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.StuTeacherId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdentityId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUserRoleRelation.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUserRoleRelation.IdentityId);
objvQxUserRoleRelationEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdentityId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdentityId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdentityId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdentityDesc(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserRoleRelation.IdentityDesc);
objvQxUserRoleRelationEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdentityDesc) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdentityDesc, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdentityDesc] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetRoleId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRoleRelation.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRoleRelation.RoleId);
objvQxUserRoleRelationEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.RoleId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.RoleId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.RoleId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetRoleName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRoleRelation.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRoleRelation.RoleName);
objvQxUserRoleRelationEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.RoleName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.RoleName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.RoleName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetQxPrjId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserRoleRelation.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRoleRelation.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRoleRelation.QxPrjId);
objvQxUserRoleRelationEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.QxPrjId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetPrjName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserRoleRelation.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRoleRelation.PrjName);
objvQxUserRoleRelationEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.PrjName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.PrjName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.PrjName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetMemo(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRoleRelation.Memo);
objvQxUserRoleRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.Memo) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.Memo, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.Memo] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdXzCollege">IdXzCollege</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdXzCollege(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUserRoleRelation.IdXzCollege);
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUserRoleRelation.IdXzCollege);
objvQxUserRoleRelationEN.IdXzCollege = strIdXzCollege; //IdXzCollege
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdXzCollege) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdXzCollege, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdXzCollege] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strCollegeName">CollegeName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetCollegeName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convQxUserRoleRelation.CollegeName);
objvQxUserRoleRelationEN.CollegeName = strCollegeName; //CollegeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.CollegeName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.CollegeName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.CollegeName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetPassword(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUserRoleRelation.Password);
objvQxUserRoleRelationEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.Password) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.Password, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.Password] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRoleRelationEN objvQxUserRoleRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.mId) == true)
{
string strComparisonOpmId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRoleRelation.mId, objvQxUserRoleRelationCond.mId, strComparisonOpmId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserId) == true)
{
string strComparisonOpUserId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserId, objvQxUserRoleRelationCond.UserId, strComparisonOpUserId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserName) == true)
{
string strComparisonOpUserName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserName, objvQxUserRoleRelationCond.UserName, strComparisonOpUserName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.DepartmentId, objvQxUserRoleRelationCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.DepartmentName, objvQxUserRoleRelationCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserStateId, objvQxUserRoleRelationCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserStateName, objvQxUserRoleRelationCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.StuTeacherId, objvQxUserRoleRelationCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdentityId, objvQxUserRoleRelationCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdentityDesc, objvQxUserRoleRelationCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.RoleId, objvQxUserRoleRelationCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.RoleName, objvQxUserRoleRelationCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.QxPrjId, objvQxUserRoleRelationCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.PrjName, objvQxUserRoleRelationCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.Memo, objvQxUserRoleRelationCond.Memo, strComparisonOpMemo);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdXzCollege, objvQxUserRoleRelationCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.CollegeName) == true)
{
string strComparisonOpCollegeName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.CollegeName, objvQxUserRoleRelationCond.CollegeName, strComparisonOpCollegeName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.Password) == true)
{
string strComparisonOpPassword = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.Password, objvQxUserRoleRelationCond.Password, strComparisonOpPassword);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户角色关系(vQxUserRoleRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRoleRelationWApi
{
private static readonly string mstrApiControllerName = "vQxUserRoleRelationApi";

 public clsvQxUserRoleRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN;
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
objvQxUserRoleRelationEN = JsonConvert.DeserializeObject<clsvQxUserRoleRelationEN>(strJson);
return objvQxUserRoleRelationEN;
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
public static clsvQxUserRoleRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN;
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
objvQxUserRoleRelationEN = JsonConvert.DeserializeObject<clsvQxUserRoleRelationEN>(strJson);
return objvQxUserRoleRelationEN;
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
public static List<clsvQxUserRoleRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRoleRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>(strJson);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxUserRoleRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>(strJson);
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
public static List<clsvQxUserRoleRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>(strJson);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>(strJson);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>(strJson);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserRoleRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelationEN>>(strJson);
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
 /// <param name = "objvQxUserRoleRelationENS">源对象</param>
 /// <param name = "objvQxUserRoleRelationENT">目标对象</param>
 public static void CopyTo(clsvQxUserRoleRelationEN objvQxUserRoleRelationENS, clsvQxUserRoleRelationEN objvQxUserRoleRelationENT)
{
try
{
objvQxUserRoleRelationENT.mId = objvQxUserRoleRelationENS.mId; //流水号
objvQxUserRoleRelationENT.UserId = objvQxUserRoleRelationENS.UserId; //用户ID
objvQxUserRoleRelationENT.UserName = objvQxUserRoleRelationENS.UserName; //用户名
objvQxUserRoleRelationENT.DepartmentId = objvQxUserRoleRelationENS.DepartmentId; //部门Id
objvQxUserRoleRelationENT.DepartmentName = objvQxUserRoleRelationENS.DepartmentName; //部门名
objvQxUserRoleRelationENT.UserStateId = objvQxUserRoleRelationENS.UserStateId; //用户状态Id
objvQxUserRoleRelationENT.UserStateName = objvQxUserRoleRelationENS.UserStateName; //用户状态名
objvQxUserRoleRelationENT.StuTeacherId = objvQxUserRoleRelationENS.StuTeacherId; //学工号
objvQxUserRoleRelationENT.IdentityId = objvQxUserRoleRelationENS.IdentityId; //身份编号
objvQxUserRoleRelationENT.IdentityDesc = objvQxUserRoleRelationENS.IdentityDesc; //身份描述
objvQxUserRoleRelationENT.RoleId = objvQxUserRoleRelationENS.RoleId; //角色Id
objvQxUserRoleRelationENT.RoleName = objvQxUserRoleRelationENS.RoleName; //角色名称
objvQxUserRoleRelationENT.QxPrjId = objvQxUserRoleRelationENS.QxPrjId; //项目Id
objvQxUserRoleRelationENT.PrjName = objvQxUserRoleRelationENS.PrjName; //工程名
objvQxUserRoleRelationENT.Memo = objvQxUserRoleRelationENS.Memo; //备注
objvQxUserRoleRelationENT.IdXzCollege = objvQxUserRoleRelationENS.IdXzCollege; //IdXzCollege
objvQxUserRoleRelationENT.CollegeName = objvQxUserRoleRelationENS.CollegeName; //CollegeName
objvQxUserRoleRelationENT.Password = objvQxUserRoleRelationENS.Password; //口令
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
public static DataTable ToDataTable(List<clsvQxUserRoleRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserRoleRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserRoleRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserRoleRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserRoleRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserRoleRelationEN.AttributeName)
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
public static void ReFreshThisCache(string strQxPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvQxUserRoleRelationEN._CurrTabName, strQxPrjId);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUserRoleRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserRoleRelation.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUserRoleRelation.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.IdXzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation.Password, Type.GetType("System.String"));
foreach (clsvQxUserRoleRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserRoleRelation.mId] = objInFor[convQxUserRoleRelation.mId];
objDR[convQxUserRoleRelation.UserId] = objInFor[convQxUserRoleRelation.UserId];
objDR[convQxUserRoleRelation.UserName] = objInFor[convQxUserRoleRelation.UserName];
objDR[convQxUserRoleRelation.DepartmentId] = objInFor[convQxUserRoleRelation.DepartmentId];
objDR[convQxUserRoleRelation.DepartmentName] = objInFor[convQxUserRoleRelation.DepartmentName];
objDR[convQxUserRoleRelation.UserStateId] = objInFor[convQxUserRoleRelation.UserStateId];
objDR[convQxUserRoleRelation.UserStateName] = objInFor[convQxUserRoleRelation.UserStateName];
objDR[convQxUserRoleRelation.StuTeacherId] = objInFor[convQxUserRoleRelation.StuTeacherId];
objDR[convQxUserRoleRelation.IdentityId] = objInFor[convQxUserRoleRelation.IdentityId];
objDR[convQxUserRoleRelation.IdentityDesc] = objInFor[convQxUserRoleRelation.IdentityDesc];
objDR[convQxUserRoleRelation.RoleId] = objInFor[convQxUserRoleRelation.RoleId];
objDR[convQxUserRoleRelation.RoleName] = objInFor[convQxUserRoleRelation.RoleName];
objDR[convQxUserRoleRelation.QxPrjId] = objInFor[convQxUserRoleRelation.QxPrjId];
objDR[convQxUserRoleRelation.PrjName] = objInFor[convQxUserRoleRelation.PrjName];
objDR[convQxUserRoleRelation.Memo] = objInFor[convQxUserRoleRelation.Memo];
objDR[convQxUserRoleRelation.IdXzCollege] = objInFor[convQxUserRoleRelation.IdXzCollege];
objDR[convQxUserRoleRelation.CollegeName] = objInFor[convQxUserRoleRelation.CollegeName];
objDR[convQxUserRoleRelation.Password] = objInFor[convQxUserRoleRelation.Password];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}