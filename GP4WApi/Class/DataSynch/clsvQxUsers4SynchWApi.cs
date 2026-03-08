
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers4SynchWApi
 表名:vQxUsers4Synch(00140090)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:57:45
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
public static class  clsvQxUsers4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetmId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, long lngmId, string strComparisonOp="")
	{
objvQxUsers4SynchEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.mId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.mId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.mId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">IP地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIpAddress(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 23, convQxUsers4Synch.IpAddress);
objvQxUsers4SynchEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.IpAddress) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.IpAddress, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.IpAddress] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUsers4Synch.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUsers4Synch.UserId);
objvQxUsers4SynchEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UserId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UserId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UserId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers4Synch.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUsers4Synch.UserName);
objvQxUsers4SynchEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UserName) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UserName, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UserName] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserStateId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers4Synch.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers4Synch.UserStateId);
objvQxUsers4SynchEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UserStateId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UserStateId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UserStateId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserStateName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUsers4Synch.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers4Synch.UserStateName);
objvQxUsers4SynchEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UserStateName) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UserStateName, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UserStateName] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIdentityId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convQxUsers4Synch.IdentityId);
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUsers4Synch.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUsers4Synch.IdentityId);
objvQxUsers4SynchEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.IdentityId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.IdentityId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.IdentityId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIdentityDesc(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxUsers4Synch.IdentityDesc);
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers4Synch.IdentityDesc);
objvQxUsers4SynchEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.IdentityDesc) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.IdentityDesc, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.IdentityDesc] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetStuTeacherId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convQxUsers4Synch.StuTeacherId);
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUsers4Synch.StuTeacherId);
objvQxUsers4SynchEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.StuTeacherId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.StuTeacherId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.StuTeacherId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetPassword(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, convQxUsers4Synch.Password);
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUsers4Synch.Password);
objvQxUsers4SynchEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.Password) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.Password, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.Password] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUsers4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers4Synch.DepartmentId);
objvQxUsers4SynchEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.DepartmentId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.DepartmentId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.DepartmentId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUsers4Synch.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers4Synch.DepartmentName);
objvQxUsers4SynchEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.DepartmentName) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.DepartmentName, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.DepartmentName] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentAbbrName">名称缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentAbbrName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUsers4Synch.DepartmentAbbrName);
objvQxUsers4SynchEN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.DepartmentAbbrName) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeId">部门类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentTypeId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeId, convQxUsers4Synch.DepartmentTypeId);
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers4Synch.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers4Synch.DepartmentTypeId);
objvQxUsers4SynchEN.DepartmentTypeId = strDepartmentTypeId; //部门类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.DepartmentTypeId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.DepartmentTypeId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.DepartmentTypeId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeName">部门类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentTypeName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeName, convQxUsers4Synch.DepartmentTypeName);
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers4Synch.DepartmentTypeName);
objvQxUsers4SynchEN.DepartmentTypeName = strDepartmentTypeName; //部门类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.DepartmentTypeName) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.DepartmentTypeName, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.DepartmentTypeName] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentId">所属部门号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpDepartmentId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers4Synch.UpDepartmentId);
objvQxUsers4SynchEN.UpDepartmentId = strUpDepartmentId; //所属部门号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UpDepartmentId) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UpDepartmentId, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UpDepartmentId] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentName">上级部门</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpDepartmentName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers4Synch.UpDepartmentName);
objvQxUsers4SynchEN.UpDepartmentName = strUpDepartmentName; //上级部门
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UpDepartmentName) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UpDepartmentName, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UpDepartmentName] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdXzCollege">IdXzCollege</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIdXzCollege(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUsers4Synch.IdXzCollege);
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUsers4Synch.IdXzCollege);
objvQxUsers4SynchEN.IdXzCollege = strIdXzCollege; //IdXzCollege
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.IdXzCollege) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.IdXzCollege, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.IdXzCollege] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetEffitiveBeginDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, convQxUsers4Synch.EffitiveBeginDate);
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUsers4Synch.EffitiveBeginDate);
objvQxUsers4SynchEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.EffitiveBeginDate) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.EffitiveBeginDate, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.EffitiveBeginDate] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetEffitiveEndDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, convQxUsers4Synch.EffitiveEndDate);
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUsers4Synch.EffitiveEndDate);
objvQxUsers4SynchEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.EffitiveEndDate) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.EffitiveEndDate, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.EffitiveEndDate] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAccessSynch">是否处理同步</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIsAccessSynch(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, bool bolIsAccessSynch, string strComparisonOp="")
	{
objvQxUsers4SynchEN.IsAccessSynch = bolIsAccessSynch; //是否处理同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.IsAccessSynch) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.IsAccessSynch, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.IsAccessSynch] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strAccessSynchDate">处理同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetAccessSynchDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, convQxUsers4Synch.AccessSynchDate);
objvQxUsers4SynchEN.AccessSynchDate = strAccessSynchDate; //处理同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.AccessSynchDate) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.AccessSynchDate, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.AccessSynchDate] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExistUserInCurr">当前是否存在用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIsExistUserInCurr(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, bool bolIsExistUserInCurr, string strComparisonOp="")
	{
objvQxUsers4SynchEN.IsExistUserInCurr = bolIsExistUserInCurr; //当前是否存在用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.IsExistUserInCurr) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.IsExistUserInCurr, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.IsExistUserInCurr] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSamePwd">是否相同密码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIsSamePwd(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, bool bolIsSamePwd, string strComparisonOp="")
	{
objvQxUsers4SynchEN.IsSamePwd = bolIsSamePwd; //是否相同密码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.IsSamePwd) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.IsSamePwd, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.IsSamePwd] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpdDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxUsers4Synch.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers4Synch.UpdDate);
objvQxUsers4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UpdDate) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UpdDate, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UpdDate] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpdUser(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers4Synch.UpdUser);
objvQxUsers4SynchEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.UpdUser) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.UpdUser, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.UpdUser] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetMemo(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers4Synch.Memo);
objvQxUsers4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers4SynchEN.dicFldComparisonOp.ContainsKey(convQxUsers4Synch.Memo) == false)
{
objvQxUsers4SynchEN.dicFldComparisonOp.Add(convQxUsers4Synch.Memo, strComparisonOp);
}
else
{
objvQxUsers4SynchEN.dicFldComparisonOp[convQxUsers4Synch.Memo] = strComparisonOp;
}
}
return objvQxUsers4SynchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUsers4SynchEN objvQxUsers4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.mId) == true)
{
string strComparisonOpmId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUsers4Synch.mId, objvQxUsers4SynchCond.mId, strComparisonOpmId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.IpAddress, objvQxUsers4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UserId) == true)
{
string strComparisonOpUserId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UserId, objvQxUsers4SynchCond.UserId, strComparisonOpUserId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UserName) == true)
{
string strComparisonOpUserName = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UserName, objvQxUsers4SynchCond.UserName, strComparisonOpUserName);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UserStateId, objvQxUsers4SynchCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UserStateName, objvQxUsers4SynchCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.IdentityId, objvQxUsers4SynchCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.IdentityDesc, objvQxUsers4SynchCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.StuTeacherId, objvQxUsers4SynchCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.Password) == true)
{
string strComparisonOpPassword = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.Password, objvQxUsers4SynchCond.Password, strComparisonOpPassword);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.DepartmentId, objvQxUsers4SynchCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.DepartmentName, objvQxUsers4SynchCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.DepartmentAbbrName, objvQxUsers4SynchCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.DepartmentTypeId, objvQxUsers4SynchCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.DepartmentTypeName, objvQxUsers4SynchCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UpDepartmentId, objvQxUsers4SynchCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UpDepartmentName, objvQxUsers4SynchCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.IdXzCollege, objvQxUsers4SynchCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.EffitiveBeginDate, objvQxUsers4SynchCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.EffitiveEndDate, objvQxUsers4SynchCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.IsAccessSynch) == true)
{
if (objvQxUsers4SynchCond.IsAccessSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers4Synch.IsAccessSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers4Synch.IsAccessSynch);
}
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.AccessSynchDate) == true)
{
string strComparisonOpAccessSynchDate = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.AccessSynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.AccessSynchDate, objvQxUsers4SynchCond.AccessSynchDate, strComparisonOpAccessSynchDate);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.IsExistUserInCurr) == true)
{
if (objvQxUsers4SynchCond.IsExistUserInCurr == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers4Synch.IsExistUserInCurr);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers4Synch.IsExistUserInCurr);
}
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.IsSamePwd) == true)
{
if (objvQxUsers4SynchCond.IsSamePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers4Synch.IsSamePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers4Synch.IsSamePwd);
}
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UpdDate, objvQxUsers4SynchCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.UpdUser, objvQxUsers4SynchCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxUsers4SynchCond.IsUpdated(convQxUsers4Synch.Memo) == true)
{
string strComparisonOpMemo = objvQxUsers4SynchCond.dicFldComparisonOp[convQxUsers4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers4Synch.Memo, objvQxUsers4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户4同步(vQxUsers4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsers4SynchWApi
{
private static readonly string mstrApiControllerName = "vQxUsers4SynchApi";

 public clsvQxUsers4SynchWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxUsers4SynchEN objvQxUsers4SynchEN;
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
objvQxUsers4SynchEN = JsonConvert.DeserializeObject<clsvQxUsers4SynchEN>(strJson);
return objvQxUsers4SynchEN;
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
public static clsvQxUsers4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUsers4SynchEN objvQxUsers4SynchEN;
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
objvQxUsers4SynchEN = JsonConvert.DeserializeObject<clsvQxUsers4SynchEN>(strJson);
return objvQxUsers4SynchEN;
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
public static List<clsvQxUsers4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers4SynchEN>>(strJson);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers4SynchEN>>(strJson);
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
public static List<clsvQxUsers4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers4SynchEN>>(strJson);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers4SynchEN>>(strJson);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers4SynchEN>>(strJson);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUsers4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers4SynchEN>>(strJson);
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
 /// <param name = "objvQxUsers4SynchENS">源对象</param>
 /// <param name = "objvQxUsers4SynchENT">目标对象</param>
 public static void CopyTo(clsvQxUsers4SynchEN objvQxUsers4SynchENS, clsvQxUsers4SynchEN objvQxUsers4SynchENT)
{
try
{
objvQxUsers4SynchENT.mId = objvQxUsers4SynchENS.mId; //流水号
objvQxUsers4SynchENT.IpAddress = objvQxUsers4SynchENS.IpAddress; //IP地址
objvQxUsers4SynchENT.UserId = objvQxUsers4SynchENS.UserId; //用户ID
objvQxUsers4SynchENT.UserName = objvQxUsers4SynchENS.UserName; //用户名
objvQxUsers4SynchENT.UserStateId = objvQxUsers4SynchENS.UserStateId; //用户状态Id
objvQxUsers4SynchENT.UserStateName = objvQxUsers4SynchENS.UserStateName; //用户状态名
objvQxUsers4SynchENT.IdentityId = objvQxUsers4SynchENS.IdentityId; //身份编号
objvQxUsers4SynchENT.IdentityDesc = objvQxUsers4SynchENS.IdentityDesc; //身份描述
objvQxUsers4SynchENT.StuTeacherId = objvQxUsers4SynchENS.StuTeacherId; //学工号
objvQxUsers4SynchENT.Password = objvQxUsers4SynchENS.Password; //口令
objvQxUsers4SynchENT.DepartmentId = objvQxUsers4SynchENS.DepartmentId; //部门Id
objvQxUsers4SynchENT.DepartmentName = objvQxUsers4SynchENS.DepartmentName; //部门名
objvQxUsers4SynchENT.DepartmentAbbrName = objvQxUsers4SynchENS.DepartmentAbbrName; //名称缩写
objvQxUsers4SynchENT.DepartmentTypeId = objvQxUsers4SynchENS.DepartmentTypeId; //部门类型ID
objvQxUsers4SynchENT.DepartmentTypeName = objvQxUsers4SynchENS.DepartmentTypeName; //部门类型名
objvQxUsers4SynchENT.UpDepartmentId = objvQxUsers4SynchENS.UpDepartmentId; //所属部门号
objvQxUsers4SynchENT.UpDepartmentName = objvQxUsers4SynchENS.UpDepartmentName; //上级部门
objvQxUsers4SynchENT.IdXzCollege = objvQxUsers4SynchENS.IdXzCollege; //IdXzCollege
objvQxUsers4SynchENT.EffitiveBeginDate = objvQxUsers4SynchENS.EffitiveBeginDate; //有效开始日期
objvQxUsers4SynchENT.EffitiveEndDate = objvQxUsers4SynchENS.EffitiveEndDate; //有效结束日期
objvQxUsers4SynchENT.IsAccessSynch = objvQxUsers4SynchENS.IsAccessSynch; //是否处理同步
objvQxUsers4SynchENT.AccessSynchDate = objvQxUsers4SynchENS.AccessSynchDate; //处理同步日期
objvQxUsers4SynchENT.IsExistUserInCurr = objvQxUsers4SynchENS.IsExistUserInCurr; //当前是否存在用户
objvQxUsers4SynchENT.IsSamePwd = objvQxUsers4SynchENS.IsSamePwd; //是否相同密码
objvQxUsers4SynchENT.UpdDate = objvQxUsers4SynchENS.UpdDate; //修改日期
objvQxUsers4SynchENT.UpdUser = objvQxUsers4SynchENS.UpdUser; //修改用户
objvQxUsers4SynchENT.Memo = objvQxUsers4SynchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUsers4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUsers4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUsers4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUsers4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUsers4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUsers4SynchEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUsers4SynchEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUsers4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUsers4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUsers4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.Password, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.UpDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.IdXzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.IsAccessSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUsers4Synch.AccessSynchDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.IsExistUserInCurr, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUsers4Synch.IsSamePwd, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUsers4Synch.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers4Synch.Memo, Type.GetType("System.String"));
foreach (clsvQxUsers4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUsers4Synch.mId] = objInFor[convQxUsers4Synch.mId];
objDR[convQxUsers4Synch.IpAddress] = objInFor[convQxUsers4Synch.IpAddress];
objDR[convQxUsers4Synch.UserId] = objInFor[convQxUsers4Synch.UserId];
objDR[convQxUsers4Synch.UserName] = objInFor[convQxUsers4Synch.UserName];
objDR[convQxUsers4Synch.UserStateId] = objInFor[convQxUsers4Synch.UserStateId];
objDR[convQxUsers4Synch.UserStateName] = objInFor[convQxUsers4Synch.UserStateName];
objDR[convQxUsers4Synch.IdentityId] = objInFor[convQxUsers4Synch.IdentityId];
objDR[convQxUsers4Synch.IdentityDesc] = objInFor[convQxUsers4Synch.IdentityDesc];
objDR[convQxUsers4Synch.StuTeacherId] = objInFor[convQxUsers4Synch.StuTeacherId];
objDR[convQxUsers4Synch.Password] = objInFor[convQxUsers4Synch.Password];
objDR[convQxUsers4Synch.DepartmentId] = objInFor[convQxUsers4Synch.DepartmentId];
objDR[convQxUsers4Synch.DepartmentName] = objInFor[convQxUsers4Synch.DepartmentName];
objDR[convQxUsers4Synch.DepartmentAbbrName] = objInFor[convQxUsers4Synch.DepartmentAbbrName];
objDR[convQxUsers4Synch.DepartmentTypeId] = objInFor[convQxUsers4Synch.DepartmentTypeId];
objDR[convQxUsers4Synch.DepartmentTypeName] = objInFor[convQxUsers4Synch.DepartmentTypeName];
objDR[convQxUsers4Synch.UpDepartmentId] = objInFor[convQxUsers4Synch.UpDepartmentId];
objDR[convQxUsers4Synch.UpDepartmentName] = objInFor[convQxUsers4Synch.UpDepartmentName];
objDR[convQxUsers4Synch.IdXzCollege] = objInFor[convQxUsers4Synch.IdXzCollege];
objDR[convQxUsers4Synch.EffitiveBeginDate] = objInFor[convQxUsers4Synch.EffitiveBeginDate];
objDR[convQxUsers4Synch.EffitiveEndDate] = objInFor[convQxUsers4Synch.EffitiveEndDate];
objDR[convQxUsers4Synch.IsAccessSynch] = objInFor[convQxUsers4Synch.IsAccessSynch];
objDR[convQxUsers4Synch.AccessSynchDate] = objInFor[convQxUsers4Synch.AccessSynchDate];
objDR[convQxUsers4Synch.IsExistUserInCurr] = objInFor[convQxUsers4Synch.IsExistUserInCurr];
objDR[convQxUsers4Synch.IsSamePwd] = objInFor[convQxUsers4Synch.IsSamePwd];
objDR[convQxUsers4Synch.UpdDate] = objInFor[convQxUsers4Synch.UpdDate];
objDR[convQxUsers4Synch.UpdUser] = objInFor[convQxUsers4Synch.UpdUser];
objDR[convQxUsers4Synch.Memo] = objInFor[convQxUsers4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}