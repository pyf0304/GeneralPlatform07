
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelation4SynchWApi
 表名:vQxUserRoleRelation4Synch(00140095)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:53
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
public static class  clsvQxUserRoleRelation4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetmId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, long lngmId, string strComparisonOp="")
	{
objvQxUserRoleRelation4SynchEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.mId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.mId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.mId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">IP地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetIpAddress(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 23, convQxUserRoleRelation4Synch.IpAddress);
objvQxUserRoleRelation4SynchEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.IpAddress) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.IpAddress, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.IpAddress] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserRoleRelation4Synch.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserRoleRelation4Synch.UserId);
objvQxUserRoleRelation4SynchEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserRoleRelation4Synch.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserRoleRelation4Synch.UserName);
objvQxUserRoleRelation4SynchEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetDepartmentId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUserRoleRelation4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserRoleRelation4Synch.DepartmentId);
objvQxUserRoleRelation4SynchEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.DepartmentId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.DepartmentId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetDepartmentName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUserRoleRelation4Synch.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserRoleRelation4Synch.DepartmentName);
objvQxUserRoleRelation4SynchEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.DepartmentName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.DepartmentName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserStateId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUserRoleRelation4Synch.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserRoleRelation4Synch.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserRoleRelation4Synch.UserStateId);
objvQxUserRoleRelation4SynchEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserStateId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserStateId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserStateName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUserRoleRelation4Synch.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserRoleRelation4Synch.UserStateName);
objvQxUserRoleRelation4SynchEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserStateName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserStateName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetStuTeacherId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convQxUserRoleRelation4Synch.StuTeacherId);
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUserRoleRelation4Synch.StuTeacherId);
objvQxUserRoleRelation4SynchEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.StuTeacherId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.StuTeacherId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.StuTeacherId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetIdentityId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convQxUserRoleRelation4Synch.IdentityId);
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUserRoleRelation4Synch.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUserRoleRelation4Synch.IdentityId);
objvQxUserRoleRelation4SynchEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.IdentityId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.IdentityId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetIdentityDesc(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxUserRoleRelation4Synch.IdentityDesc);
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserRoleRelation4Synch.IdentityDesc);
objvQxUserRoleRelation4SynchEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.IdentityDesc) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.IdentityDesc, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityDesc] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetRoleId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRoleRelation4Synch.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRoleRelation4Synch.RoleId);
objvQxUserRoleRelation4SynchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.RoleId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.RoleId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetRoleName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRoleRelation4Synch.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRoleRelation4Synch.RoleName);
objvQxUserRoleRelation4SynchEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.RoleName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.RoleName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetQxPrjId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserRoleRelation4Synch.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRoleRelation4Synch.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRoleRelation4Synch.QxPrjId);
objvQxUserRoleRelation4SynchEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.QxPrjId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetPrjName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserRoleRelation4Synch.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRoleRelation4Synch.PrjName);
objvQxUserRoleRelation4SynchEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.PrjName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.PrjName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.PrjName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUpdDate(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxUserRoleRelation4Synch.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserRoleRelation4Synch.UpdDate);
objvQxUserRoleRelation4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UpdDate) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UpdDate, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdDate] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUpdUserId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxUserRoleRelation4Synch.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserRoleRelation4Synch.UpdUserId);
objvQxUserRoleRelation4SynchEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UpdUserId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UpdUserId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdUserId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetMemo(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRoleRelation4Synch.Memo);
objvQxUserRoleRelation4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.Memo) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.Memo, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.Memo] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.mId) == true)
{
string strComparisonOpmId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRoleRelation4Synch.mId, objvQxUserRoleRelation4SynchCond.mId, strComparisonOpmId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.IpAddress, objvQxUserRoleRelation4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserId) == true)
{
string strComparisonOpUserId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserId, objvQxUserRoleRelation4SynchCond.UserId, strComparisonOpUserId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserName) == true)
{
string strComparisonOpUserName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserName, objvQxUserRoleRelation4SynchCond.UserName, strComparisonOpUserName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.DepartmentId, objvQxUserRoleRelation4SynchCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.DepartmentName, objvQxUserRoleRelation4SynchCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserStateId, objvQxUserRoleRelation4SynchCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserStateName, objvQxUserRoleRelation4SynchCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.StuTeacherId, objvQxUserRoleRelation4SynchCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.IdentityId, objvQxUserRoleRelation4SynchCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.IdentityDesc, objvQxUserRoleRelation4SynchCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.RoleId, objvQxUserRoleRelation4SynchCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.RoleName, objvQxUserRoleRelation4SynchCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.QxPrjId, objvQxUserRoleRelation4SynchCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.PrjName, objvQxUserRoleRelation4SynchCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UpdDate, objvQxUserRoleRelation4SynchCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UpdUserId, objvQxUserRoleRelation4SynchCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.Memo, objvQxUserRoleRelation4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户角色关系4同步(vQxUserRoleRelation4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRoleRelation4SynchWApi
{
private static readonly string mstrApiControllerName = "vQxUserRoleRelation4SynchApi";

 public clsvQxUserRoleRelation4SynchWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelation4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN;
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
objvQxUserRoleRelation4SynchEN = JsonConvert.DeserializeObject<clsvQxUserRoleRelation4SynchEN>(strJson);
return objvQxUserRoleRelation4SynchEN;
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
public static clsvQxUserRoleRelation4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN;
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
objvQxUserRoleRelation4SynchEN = JsonConvert.DeserializeObject<clsvQxUserRoleRelation4SynchEN>(strJson);
return objvQxUserRoleRelation4SynchEN;
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRoleRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelation4SynchEN>>(strJson);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxUserRoleRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelation4SynchEN>>(strJson);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserRoleRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelation4SynchEN>>(strJson);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserRoleRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelation4SynchEN>>(strJson);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserRoleRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelation4SynchEN>>(strJson);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserRoleRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRoleRelation4SynchEN>>(strJson);
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
 /// <param name = "objvQxUserRoleRelation4SynchENS">源对象</param>
 /// <param name = "objvQxUserRoleRelation4SynchENT">目标对象</param>
 public static void CopyTo(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENS, clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENT)
{
try
{
objvQxUserRoleRelation4SynchENT.mId = objvQxUserRoleRelation4SynchENS.mId; //流水号
objvQxUserRoleRelation4SynchENT.IpAddress = objvQxUserRoleRelation4SynchENS.IpAddress; //IP地址
objvQxUserRoleRelation4SynchENT.UserId = objvQxUserRoleRelation4SynchENS.UserId; //用户ID
objvQxUserRoleRelation4SynchENT.UserName = objvQxUserRoleRelation4SynchENS.UserName; //用户名
objvQxUserRoleRelation4SynchENT.DepartmentId = objvQxUserRoleRelation4SynchENS.DepartmentId; //部门Id
objvQxUserRoleRelation4SynchENT.DepartmentName = objvQxUserRoleRelation4SynchENS.DepartmentName; //部门名
objvQxUserRoleRelation4SynchENT.UserStateId = objvQxUserRoleRelation4SynchENS.UserStateId; //用户状态Id
objvQxUserRoleRelation4SynchENT.UserStateName = objvQxUserRoleRelation4SynchENS.UserStateName; //用户状态名
objvQxUserRoleRelation4SynchENT.StuTeacherId = objvQxUserRoleRelation4SynchENS.StuTeacherId; //学工号
objvQxUserRoleRelation4SynchENT.IdentityId = objvQxUserRoleRelation4SynchENS.IdentityId; //身份编号
objvQxUserRoleRelation4SynchENT.IdentityDesc = objvQxUserRoleRelation4SynchENS.IdentityDesc; //身份描述
objvQxUserRoleRelation4SynchENT.RoleId = objvQxUserRoleRelation4SynchENS.RoleId; //角色Id
objvQxUserRoleRelation4SynchENT.RoleName = objvQxUserRoleRelation4SynchENS.RoleName; //角色名称
objvQxUserRoleRelation4SynchENT.QxPrjId = objvQxUserRoleRelation4SynchENS.QxPrjId; //项目Id
objvQxUserRoleRelation4SynchENT.PrjName = objvQxUserRoleRelation4SynchENS.PrjName; //工程名
objvQxUserRoleRelation4SynchENT.UpdDate = objvQxUserRoleRelation4SynchENS.UpdDate; //修改日期
objvQxUserRoleRelation4SynchENT.UpdUserId = objvQxUserRoleRelation4SynchENS.UpdUserId; //修改用户Id
objvQxUserRoleRelation4SynchENT.Memo = objvQxUserRoleRelation4SynchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUserRoleRelation4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserRoleRelation4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserRoleRelation4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserRoleRelation4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserRoleRelation4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserRoleRelation4SynchEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserRoleRelation4SynchEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUserRoleRelation4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserRoleRelation4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoleRelation4Synch.Memo, Type.GetType("System.String"));
foreach (clsvQxUserRoleRelation4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserRoleRelation4Synch.mId] = objInFor[convQxUserRoleRelation4Synch.mId];
objDR[convQxUserRoleRelation4Synch.IpAddress] = objInFor[convQxUserRoleRelation4Synch.IpAddress];
objDR[convQxUserRoleRelation4Synch.UserId] = objInFor[convQxUserRoleRelation4Synch.UserId];
objDR[convQxUserRoleRelation4Synch.UserName] = objInFor[convQxUserRoleRelation4Synch.UserName];
objDR[convQxUserRoleRelation4Synch.DepartmentId] = objInFor[convQxUserRoleRelation4Synch.DepartmentId];
objDR[convQxUserRoleRelation4Synch.DepartmentName] = objInFor[convQxUserRoleRelation4Synch.DepartmentName];
objDR[convQxUserRoleRelation4Synch.UserStateId] = objInFor[convQxUserRoleRelation4Synch.UserStateId];
objDR[convQxUserRoleRelation4Synch.UserStateName] = objInFor[convQxUserRoleRelation4Synch.UserStateName];
objDR[convQxUserRoleRelation4Synch.StuTeacherId] = objInFor[convQxUserRoleRelation4Synch.StuTeacherId];
objDR[convQxUserRoleRelation4Synch.IdentityId] = objInFor[convQxUserRoleRelation4Synch.IdentityId];
objDR[convQxUserRoleRelation4Synch.IdentityDesc] = objInFor[convQxUserRoleRelation4Synch.IdentityDesc];
objDR[convQxUserRoleRelation4Synch.RoleId] = objInFor[convQxUserRoleRelation4Synch.RoleId];
objDR[convQxUserRoleRelation4Synch.RoleName] = objInFor[convQxUserRoleRelation4Synch.RoleName];
objDR[convQxUserRoleRelation4Synch.QxPrjId] = objInFor[convQxUserRoleRelation4Synch.QxPrjId];
objDR[convQxUserRoleRelation4Synch.PrjName] = objInFor[convQxUserRoleRelation4Synch.PrjName];
objDR[convQxUserRoleRelation4Synch.UpdDate] = objInFor[convQxUserRoleRelation4Synch.UpdDate];
objDR[convQxUserRoleRelation4Synch.UpdUserId] = objInFor[convQxUserRoleRelation4Synch.UpdUserId];
objDR[convQxUserRoleRelation4Synch.Memo] = objInFor[convQxUserRoleRelation4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}