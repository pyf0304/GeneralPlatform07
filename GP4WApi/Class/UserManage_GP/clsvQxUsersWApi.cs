
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersWApi
 表名:vQxUsers(00140024)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:57:44
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
public static class  clsvQxUsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserId(this clsvQxUsersEN objvQxUsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUsers.UserId);
objvQxUsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserName(this clsvQxUsersEN objvQxUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUsers.UserName);
objvQxUsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUsers.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers.DepartmentId);
objvQxUsersEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUsers.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers.DepartmentName);
objvQxUsersEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentAbbrName">名称缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentAbbrName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUsers.DepartmentAbbrName);
objvQxUsersEN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentAbbrName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeId">部门类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
objvQxUsersEN.DepartmentTypeId = strDepartmentTypeId; //部门类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentTypeId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentTypeId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentTypeId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeName">部门类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers.DepartmentTypeName);
objvQxUsersEN.DepartmentTypeName = strDepartmentTypeName; //部门类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.DepartmentTypeName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.DepartmentTypeName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.DepartmentTypeName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentId">所属部门号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers.UpDepartmentId);
objvQxUsersEN.UpDepartmentId = strUpDepartmentId; //所属部门号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpDepartmentId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpDepartmentId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpDepartmentId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentName">上级部门</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers.UpDepartmentName);
objvQxUsersEN.UpDepartmentName = strUpDepartmentName; //上级部门
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpDepartmentName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpDepartmentName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpDepartmentName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserStateId(this clsvQxUsersEN objvQxUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers.UserStateId);
objvQxUsersEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserStateId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserStateId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserStateId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserStateName(this clsvQxUsersEN objvQxUsersEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUsers.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers.UserStateName);
objvQxUsersEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UserStateName) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UserStateName, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UserStateName] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetPassword(this clsvQxUsersEN objvQxUsersEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUsers.Password);
objvQxUsersEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.Password) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.Password, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.Password] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveBeginDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, convQxUsers.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUsers.EffitiveBeginDate);
objvQxUsersEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.EffitiveBeginDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.EffitiveBeginDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.EffitiveBeginDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveEndDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, convQxUsers.EffitiveEndDate);
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUsers.EffitiveEndDate);
objvQxUsersEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.EffitiveEndDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.EffitiveEndDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.EffitiveEndDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetStuTeacherId(this clsvQxUsersEN objvQxUsersEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convQxUsers.StuTeacherId);
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUsers.StuTeacherId);
objvQxUsersEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.StuTeacherId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.StuTeacherId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.StuTeacherId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdentityId(this clsvQxUsersEN objvQxUsersEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUsers.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUsers.IdentityId);
objvQxUsersEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IdentityId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IdentityId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IdentityId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdentityDesc(this clsvQxUsersEN objvQxUsersEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers.IdentityDesc);
objvQxUsersEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IdentityDesc) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IdentityDesc, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IdentityDesc] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strOpenId">微信openid</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetOpenId(this clsvQxUsersEN objvQxUsersEN, string strOpenId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOpenId, 50, convQxUsers.OpenId);
objvQxUsersEN.OpenId = strOpenId; //微信openid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.OpenId) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.OpenId, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.OpenId] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynch">是否同步</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIsSynch(this clsvQxUsersEN objvQxUsersEN, bool bolIsSynch, string strComparisonOp="")
	{
objvQxUsersEN.IsSynch = bolIsSynch; //是否同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IsSynch) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IsSynch, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IsSynch] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchDate">同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetSynchDate(this clsvQxUsersEN objvQxUsersEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchDate, 14, convQxUsers.SynchDate);
objvQxUsersEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.SynchDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.SynchDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.SynchDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpdDate(this clsvQxUsersEN objvQxUsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers.UpdDate);
objvQxUsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpdDate) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpdDate, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpdDate] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpdUser(this clsvQxUsersEN objvQxUsersEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers.UpdUser);
objvQxUsersEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.UpdUser) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.UpdUser, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.UpdUser] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdXzCollege">IdXzCollege</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdXzCollege(this clsvQxUsersEN objvQxUsersEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUsers.IdXzCollege);
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUsers.IdXzCollege);
objvQxUsersEN.IdXzCollege = strIdXzCollege; //IdXzCollege
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.IdXzCollege) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.IdXzCollege, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.IdXzCollege] = strComparisonOp;
}
}
return objvQxUsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetMemo(this clsvQxUsersEN objvQxUsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers.Memo);
objvQxUsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsersEN.dicFldComparisonOp.ContainsKey(convQxUsers.Memo) == false)
{
objvQxUsersEN.dicFldComparisonOp.Add(convQxUsers.Memo, strComparisonOp);
}
else
{
objvQxUsersEN.dicFldComparisonOp[convQxUsers.Memo] = strComparisonOp;
}
}
return objvQxUsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUsersEN objvQxUsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUsersCond.IsUpdated(convQxUsers.UserId) == true)
{
string strComparisonOpUserId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserId, objvQxUsersCond.UserId, strComparisonOpUserId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UserName) == true)
{
string strComparisonOpUserName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserName, objvQxUsersCond.UserName, strComparisonOpUserName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentId, objvQxUsersCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentName, objvQxUsersCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentAbbrName, objvQxUsersCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentTypeId, objvQxUsersCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.DepartmentTypeName, objvQxUsersCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpDepartmentId, objvQxUsersCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpDepartmentName, objvQxUsersCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserStateId, objvQxUsersCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UserStateName, objvQxUsersCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.Password) == true)
{
string strComparisonOpPassword = objvQxUsersCond.dicFldComparisonOp[convQxUsers.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Password, objvQxUsersCond.Password, strComparisonOpPassword);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.EffitiveBeginDate, objvQxUsersCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.EffitiveEndDate, objvQxUsersCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.StuTeacherId, objvQxUsersCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdentityId, objvQxUsersCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUsersCond.dicFldComparisonOp[convQxUsers.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdentityDesc, objvQxUsersCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.OpenId) == true)
{
string strComparisonOpOpenId = objvQxUsersCond.dicFldComparisonOp[convQxUsers.OpenId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.OpenId, objvQxUsersCond.OpenId, strComparisonOpOpenId);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IsSynch) == true)
{
if (objvQxUsersCond.IsSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers.IsSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers.IsSynch);
}
}
if (objvQxUsersCond.IsUpdated(convQxUsers.SynchDate) == true)
{
string strComparisonOpSynchDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.SynchDate, objvQxUsersCond.SynchDate, strComparisonOpSynchDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpdDate, objvQxUsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxUsersCond.dicFldComparisonOp[convQxUsers.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.UpdUser, objvQxUsersCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvQxUsersCond.dicFldComparisonOp[convQxUsers.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.IdXzCollege, objvQxUsersCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvQxUsersCond.IsUpdated(convQxUsers.Memo) == true)
{
string strComparisonOpMemo = objvQxUsersCond.dicFldComparisonOp[convQxUsers.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers.Memo, objvQxUsersCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户(vQxUsers)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsersWApi
{
private static readonly string mstrApiControllerName = "vQxUsersApi";

 public clsvQxUsersWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsersEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
clsvQxUsersEN objvQxUsersEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxUsersEN = JsonConvert.DeserializeObject<clsvQxUsersEN>(strJson);
return objvQxUsersEN;
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
public static clsvQxUsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUsersEN objvQxUsersEN;
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
objvQxUsersEN = JsonConvert.DeserializeObject<clsvQxUsersEN>(strJson);
return objvQxUsersEN;
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
public static List<clsvQxUsersEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>(strJson);
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
 /// <param name = "arrUserId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsvQxUsersEN> arrObjLst; 
string strAction = "GetObjLstByUserIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>(strJson);
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
public static List<clsvQxUsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>(strJson);
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
public static List<clsvQxUsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>(strJson);
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
public static List<clsvQxUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>(strJson);
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
public static List<clsvQxUsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsersEN>>(strJson);
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
public static bool IsExist(string strUserId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserId"] = strUserId
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
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <param name = "objvQxUsersENT">目标对象</param>
 public static void CopyTo(clsvQxUsersEN objvQxUsersENS, clsvQxUsersEN objvQxUsersENT)
{
try
{
objvQxUsersENT.UserId = objvQxUsersENS.UserId; //用户ID
objvQxUsersENT.UserName = objvQxUsersENS.UserName; //用户名
objvQxUsersENT.DepartmentId = objvQxUsersENS.DepartmentId; //部门Id
objvQxUsersENT.DepartmentName = objvQxUsersENS.DepartmentName; //部门名
objvQxUsersENT.DepartmentAbbrName = objvQxUsersENS.DepartmentAbbrName; //名称缩写
objvQxUsersENT.DepartmentTypeId = objvQxUsersENS.DepartmentTypeId; //部门类型ID
objvQxUsersENT.DepartmentTypeName = objvQxUsersENS.DepartmentTypeName; //部门类型名
objvQxUsersENT.UpDepartmentId = objvQxUsersENS.UpDepartmentId; //所属部门号
objvQxUsersENT.UpDepartmentName = objvQxUsersENS.UpDepartmentName; //上级部门
objvQxUsersENT.UserStateId = objvQxUsersENS.UserStateId; //用户状态Id
objvQxUsersENT.UserStateName = objvQxUsersENS.UserStateName; //用户状态名
objvQxUsersENT.Password = objvQxUsersENS.Password; //口令
objvQxUsersENT.EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate; //有效开始日期
objvQxUsersENT.EffitiveEndDate = objvQxUsersENS.EffitiveEndDate; //有效结束日期
objvQxUsersENT.StuTeacherId = objvQxUsersENS.StuTeacherId; //学工号
objvQxUsersENT.IdentityId = objvQxUsersENS.IdentityId; //身份编号
objvQxUsersENT.IdentityDesc = objvQxUsersENS.IdentityDesc; //身份描述
objvQxUsersENT.OpenId = objvQxUsersENS.OpenId; //微信openid
objvQxUsersENT.IsSynch = objvQxUsersENS.IsSynch; //是否同步
objvQxUsersENT.SynchDate = objvQxUsersENS.SynchDate; //同步日期
objvQxUsersENT.UpdDate = objvQxUsersENS.UpdDate; //修改日期
objvQxUsersENT.UpdUser = objvQxUsersENS.UpdUser; //修改用户
objvQxUsersENT.IdXzCollege = objvQxUsersENS.IdXzCollege; //IdXzCollege
objvQxUsersENT.Memo = objvQxUsersENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUsersEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUsersEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUsersEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUsers.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.Password, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.OpenId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.IsSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUsers.SynchDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.IdXzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers.Memo, Type.GetType("System.String"));
foreach (clsvQxUsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUsers.UserId] = objInFor[convQxUsers.UserId];
objDR[convQxUsers.UserName] = objInFor[convQxUsers.UserName];
objDR[convQxUsers.DepartmentId] = objInFor[convQxUsers.DepartmentId];
objDR[convQxUsers.DepartmentName] = objInFor[convQxUsers.DepartmentName];
objDR[convQxUsers.DepartmentAbbrName] = objInFor[convQxUsers.DepartmentAbbrName];
objDR[convQxUsers.DepartmentTypeId] = objInFor[convQxUsers.DepartmentTypeId];
objDR[convQxUsers.DepartmentTypeName] = objInFor[convQxUsers.DepartmentTypeName];
objDR[convQxUsers.UpDepartmentId] = objInFor[convQxUsers.UpDepartmentId];
objDR[convQxUsers.UpDepartmentName] = objInFor[convQxUsers.UpDepartmentName];
objDR[convQxUsers.UserStateId] = objInFor[convQxUsers.UserStateId];
objDR[convQxUsers.UserStateName] = objInFor[convQxUsers.UserStateName];
objDR[convQxUsers.Password] = objInFor[convQxUsers.Password];
objDR[convQxUsers.EffitiveBeginDate] = objInFor[convQxUsers.EffitiveBeginDate];
objDR[convQxUsers.EffitiveEndDate] = objInFor[convQxUsers.EffitiveEndDate];
objDR[convQxUsers.StuTeacherId] = objInFor[convQxUsers.StuTeacherId];
objDR[convQxUsers.IdentityId] = objInFor[convQxUsers.IdentityId];
objDR[convQxUsers.IdentityDesc] = objInFor[convQxUsers.IdentityDesc];
objDR[convQxUsers.OpenId] = objInFor[convQxUsers.OpenId];
objDR[convQxUsers.IsSynch] = objInFor[convQxUsers.IsSynch];
objDR[convQxUsers.SynchDate] = objInFor[convQxUsers.SynchDate];
objDR[convQxUsers.UpdDate] = objInFor[convQxUsers.UpdDate];
objDR[convQxUsers.UpdUser] = objInFor[convQxUsers.UpdUser];
objDR[convQxUsers.IdXzCollege] = objInFor[convQxUsers.IdXzCollege];
objDR[convQxUsers.Memo] = objInFor[convQxUsers.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}