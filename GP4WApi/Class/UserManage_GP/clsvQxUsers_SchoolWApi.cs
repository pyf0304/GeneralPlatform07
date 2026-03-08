
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers_SchoolWApi
 表名:vQxUsers_School(00140075)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:03:26
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
public static class  clsvQxUsers_SchoolWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUsers_School.UserId);
objvQxUsers_SchoolEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UserId) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UserId, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UserId] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers_School.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUsers_School.UserName);
objvQxUsers_SchoolEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UserName) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UserName, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UserName] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUsers_School.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers_School.DepartmentId);
objvQxUsers_SchoolEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.DepartmentId) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.DepartmentId, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.DepartmentId] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUsers_School.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers_School.DepartmentName);
objvQxUsers_SchoolEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.DepartmentName) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.DepartmentName, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.DepartmentName] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentAbbrName">名称缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentAbbrName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUsers_School.DepartmentAbbrName);
objvQxUsers_SchoolEN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.DepartmentAbbrName) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeId">部门类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentTypeId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeId, convQxUsers_School.DepartmentTypeId);
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers_School.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers_School.DepartmentTypeId);
objvQxUsers_SchoolEN.DepartmentTypeId = strDepartmentTypeId; //部门类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.DepartmentTypeId) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.DepartmentTypeId, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.DepartmentTypeId] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentTypeName">部门类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentTypeName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeName, convQxUsers_School.DepartmentTypeName);
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers_School.DepartmentTypeName);
objvQxUsers_SchoolEN.DepartmentTypeName = strDepartmentTypeName; //部门类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.DepartmentTypeName) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.DepartmentTypeName, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.DepartmentTypeName] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentId">所属部门号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpDepartmentId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers_School.UpDepartmentId);
objvQxUsers_SchoolEN.UpDepartmentId = strUpDepartmentId; //所属部门号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UpDepartmentId) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UpDepartmentId, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UpDepartmentId] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpDepartmentName">上级部门</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpDepartmentName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers_School.UpDepartmentName);
objvQxUsers_SchoolEN.UpDepartmentName = strUpDepartmentName; //上级部门
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UpDepartmentName) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UpDepartmentName, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UpDepartmentName] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserStateId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers_School.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers_School.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers_School.UserStateId);
objvQxUsers_SchoolEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UserStateId) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UserStateId, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UserStateId] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserStateName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUsers_School.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers_School.UserStateName);
objvQxUsers_SchoolEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UserStateName) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UserStateName, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UserStateName] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIdentityId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convQxUsers_School.IdentityId);
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUsers_School.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUsers_School.IdentityId);
objvQxUsers_SchoolEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.IdentityId) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.IdentityId, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.IdentityId] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIdentityDesc(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxUsers_School.IdentityDesc);
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers_School.IdentityDesc);
objvQxUsers_SchoolEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.IdentityDesc) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.IdentityDesc, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.IdentityDesc] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strCardNo">卡号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetCardNo(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strCardNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardNo, 10, convQxUsers_School.CardNo);
objvQxUsers_SchoolEN.CardNo = strCardNo; //卡号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.CardNo) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.CardNo, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.CardNo] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetStuTeacherId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUsers_School.StuTeacherId);
objvQxUsers_SchoolEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.StuTeacherId) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.StuTeacherId, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.StuTeacherId] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdGradeBase">年级流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIdGradeBase(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convQxUsers_School.IdGradeBase);
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convQxUsers_School.IdGradeBase);
objvQxUsers_SchoolEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.IdGradeBase) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.IdGradeBase, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.IdGradeBase] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strGradeBaseName">年级名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetGradeBaseName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convQxUsers_School.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 20, convQxUsers_School.GradeBaseName);
objvQxUsers_SchoolEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.GradeBaseName) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.GradeBaseName, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.GradeBaseName] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strEnterSchoolDate">进校日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetEnterSchoolDate(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strEnterSchoolDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEnterSchoolDate, 8, convQxUsers_School.EnterSchoolDate);
clsCheckSql.CheckFieldForeignKey(strEnterSchoolDate, 8, convQxUsers_School.EnterSchoolDate);
objvQxUsers_SchoolEN.EnterSchoolDate = strEnterSchoolDate; //进校日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.EnterSchoolDate) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.EnterSchoolDate, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.EnterSchoolDate] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOffed">是否毕业</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIsOffed(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, bool bolIsOffed, string strComparisonOp="")
	{
objvQxUsers_SchoolEN.IsOffed = bolIsOffed; //是否毕业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.IsOffed) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.IsOffed, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.IsOffed] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strBeginYearMonth">开始年月</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetBeginYearMonth(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strBeginYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, convQxUsers_School.BeginYearMonth);
objvQxUsers_SchoolEN.BeginYearMonth = strBeginYearMonth; //开始年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.BeginYearMonth) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.BeginYearMonth, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.BeginYearMonth] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strEndYearMonth">结束年月</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetEndYearMonth(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strEndYearMonth, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, convQxUsers_School.EndYearMonth);
objvQxUsers_SchoolEN.EndYearMonth = strEndYearMonth; //结束年月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.EndYearMonth) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.EndYearMonth, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.EndYearMonth] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strCardState">卡状态</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetCardState(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strCardState, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCardState, 10, convQxUsers_School.CardState);
objvQxUsers_SchoolEN.CardState = strCardState; //卡状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.CardState) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.CardState, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.CardState] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsLeaved">IsLeaved</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIsLeaved(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvQxUsers_SchoolEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.IsLeaved) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.IsLeaved, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.IsLeaved] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpdDate(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers_School.UpdDate);
objvQxUsers_SchoolEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UpdDate) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UpdDate, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UpdDate] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpdUser(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers_School.UpdUser);
objvQxUsers_SchoolEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.UpdUser) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.UpdUser, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.UpdUser] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetMemo(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers_School.Memo);
objvQxUsers_SchoolEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUsers_SchoolEN.dicFldComparisonOp.ContainsKey(convQxUsers_School.Memo) == false)
{
objvQxUsers_SchoolEN.dicFldComparisonOp.Add(convQxUsers_School.Memo, strComparisonOp);
}
else
{
objvQxUsers_SchoolEN.dicFldComparisonOp[convQxUsers_School.Memo] = strComparisonOp;
}
}
return objvQxUsers_SchoolEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUsers_SchoolEN objvQxUsers_SchoolCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UserId) == true)
{
string strComparisonOpUserId = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UserId, objvQxUsers_SchoolCond.UserId, strComparisonOpUserId);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UserName) == true)
{
string strComparisonOpUserName = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UserName, objvQxUsers_SchoolCond.UserName, strComparisonOpUserName);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.DepartmentId, objvQxUsers_SchoolCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.DepartmentName, objvQxUsers_SchoolCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.DepartmentAbbrName, objvQxUsers_SchoolCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.DepartmentTypeId, objvQxUsers_SchoolCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.DepartmentTypeName, objvQxUsers_SchoolCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UpDepartmentId, objvQxUsers_SchoolCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UpDepartmentName, objvQxUsers_SchoolCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UserStateId, objvQxUsers_SchoolCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UserStateName, objvQxUsers_SchoolCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.IdentityId, objvQxUsers_SchoolCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.IdentityDesc, objvQxUsers_SchoolCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.CardNo) == true)
{
string strComparisonOpCardNo = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.CardNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.CardNo, objvQxUsers_SchoolCond.CardNo, strComparisonOpCardNo);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.StuTeacherId, objvQxUsers_SchoolCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.IdGradeBase, objvQxUsers_SchoolCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.GradeBaseName) == true)
{
string strComparisonOpGradeBaseName = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.GradeBaseName, objvQxUsers_SchoolCond.GradeBaseName, strComparisonOpGradeBaseName);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.EnterSchoolDate) == true)
{
string strComparisonOpEnterSchoolDate = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.EnterSchoolDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.EnterSchoolDate, objvQxUsers_SchoolCond.EnterSchoolDate, strComparisonOpEnterSchoolDate);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.IsOffed) == true)
{
if (objvQxUsers_SchoolCond.IsOffed == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers_School.IsOffed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers_School.IsOffed);
}
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.BeginYearMonth) == true)
{
string strComparisonOpBeginYearMonth = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.BeginYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.BeginYearMonth, objvQxUsers_SchoolCond.BeginYearMonth, strComparisonOpBeginYearMonth);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.EndYearMonth) == true)
{
string strComparisonOpEndYearMonth = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.EndYearMonth];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.EndYearMonth, objvQxUsers_SchoolCond.EndYearMonth, strComparisonOpEndYearMonth);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.CardState) == true)
{
string strComparisonOpCardState = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.CardState];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.CardState, objvQxUsers_SchoolCond.CardState, strComparisonOpCardState);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.IsLeaved) == true)
{
if (objvQxUsers_SchoolCond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUsers_School.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUsers_School.IsLeaved);
}
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UpdDate, objvQxUsers_SchoolCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.UpdUser, objvQxUsers_SchoolCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxUsers_SchoolCond.IsUpdated(convQxUsers_School.Memo) == true)
{
string strComparisonOpMemo = objvQxUsers_SchoolCond.dicFldComparisonOp[convQxUsers_School.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUsers_School.Memo, objvQxUsers_SchoolCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vUsers_School(vQxUsers_School)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsers_SchoolWApi
{
private static readonly string mstrApiControllerName = "vQxUsers_SchoolApi";

 public clsvQxUsers_SchoolWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers_SchoolEN GetObjByUserId(string strUserId)
{
string strAction = "GetObjByUserId";
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN;
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
objvQxUsers_SchoolEN = JsonConvert.DeserializeObject<clsvQxUsers_SchoolEN>(strJson);
return objvQxUsers_SchoolEN;
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
public static clsvQxUsers_SchoolEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN;
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
objvQxUsers_SchoolEN = JsonConvert.DeserializeObject<clsvQxUsers_SchoolEN>(strJson);
return objvQxUsers_SchoolEN;
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
public static List<clsvQxUsers_SchoolEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUsers_SchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers_SchoolEN>>(strJson);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByUserIdLst(List<string> arrUserId)
{
 List<clsvQxUsers_SchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers_SchoolEN>>(strJson);
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
public static List<clsvQxUsers_SchoolEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUsers_SchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers_SchoolEN>>(strJson);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUsers_SchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers_SchoolEN>>(strJson);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUsers_SchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers_SchoolEN>>(strJson);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUsers_SchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUsers_SchoolEN>>(strJson);
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
 /// <param name = "objvQxUsers_SchoolENS">源对象</param>
 /// <param name = "objvQxUsers_SchoolENT">目标对象</param>
 public static void CopyTo(clsvQxUsers_SchoolEN objvQxUsers_SchoolENS, clsvQxUsers_SchoolEN objvQxUsers_SchoolENT)
{
try
{
objvQxUsers_SchoolENT.UserId = objvQxUsers_SchoolENS.UserId; //用户ID
objvQxUsers_SchoolENT.UserName = objvQxUsers_SchoolENS.UserName; //用户名
objvQxUsers_SchoolENT.DepartmentId = objvQxUsers_SchoolENS.DepartmentId; //部门Id
objvQxUsers_SchoolENT.DepartmentName = objvQxUsers_SchoolENS.DepartmentName; //部门名
objvQxUsers_SchoolENT.DepartmentAbbrName = objvQxUsers_SchoolENS.DepartmentAbbrName; //名称缩写
objvQxUsers_SchoolENT.DepartmentTypeId = objvQxUsers_SchoolENS.DepartmentTypeId; //部门类型ID
objvQxUsers_SchoolENT.DepartmentTypeName = objvQxUsers_SchoolENS.DepartmentTypeName; //部门类型名
objvQxUsers_SchoolENT.UpDepartmentId = objvQxUsers_SchoolENS.UpDepartmentId; //所属部门号
objvQxUsers_SchoolENT.UpDepartmentName = objvQxUsers_SchoolENS.UpDepartmentName; //上级部门
objvQxUsers_SchoolENT.UserStateId = objvQxUsers_SchoolENS.UserStateId; //用户状态Id
objvQxUsers_SchoolENT.UserStateName = objvQxUsers_SchoolENS.UserStateName; //用户状态名
objvQxUsers_SchoolENT.IdentityId = objvQxUsers_SchoolENS.IdentityId; //身份编号
objvQxUsers_SchoolENT.IdentityDesc = objvQxUsers_SchoolENS.IdentityDesc; //身份描述
objvQxUsers_SchoolENT.CardNo = objvQxUsers_SchoolENS.CardNo; //卡号
objvQxUsers_SchoolENT.StuTeacherId = objvQxUsers_SchoolENS.StuTeacherId; //学工号
objvQxUsers_SchoolENT.IdGradeBase = objvQxUsers_SchoolENS.IdGradeBase; //年级流水号
objvQxUsers_SchoolENT.GradeBaseName = objvQxUsers_SchoolENS.GradeBaseName; //年级名称
objvQxUsers_SchoolENT.EnterSchoolDate = objvQxUsers_SchoolENS.EnterSchoolDate; //进校日期
objvQxUsers_SchoolENT.IsOffed = objvQxUsers_SchoolENS.IsOffed; //是否毕业
objvQxUsers_SchoolENT.BeginYearMonth = objvQxUsers_SchoolENS.BeginYearMonth; //开始年月
objvQxUsers_SchoolENT.EndYearMonth = objvQxUsers_SchoolENS.EndYearMonth; //结束年月
objvQxUsers_SchoolENT.CardState = objvQxUsers_SchoolENS.CardState; //卡状态
objvQxUsers_SchoolENT.IsLeaved = objvQxUsers_SchoolENS.IsLeaved; //IsLeaved
objvQxUsers_SchoolENT.UpdDate = objvQxUsers_SchoolENS.UpdDate; //修改日期
objvQxUsers_SchoolENT.UpdUser = objvQxUsers_SchoolENS.UpdUser; //修改用户
objvQxUsers_SchoolENT.Memo = objvQxUsers_SchoolENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUsers_SchoolEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUsers_SchoolEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUsers_SchoolEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUsers_SchoolEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUsers_SchoolEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUsers_SchoolEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUsers_SchoolEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUsers_SchoolEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUsers_School.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.UpDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.CardNo, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.IdGradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.EnterSchoolDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.IsOffed, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUsers_School.BeginYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.EndYearMonth, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.CardState, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUsers_School.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxUsers_School.Memo, Type.GetType("System.String"));
foreach (clsvQxUsers_SchoolEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUsers_School.UserId] = objInFor[convQxUsers_School.UserId];
objDR[convQxUsers_School.UserName] = objInFor[convQxUsers_School.UserName];
objDR[convQxUsers_School.DepartmentId] = objInFor[convQxUsers_School.DepartmentId];
objDR[convQxUsers_School.DepartmentName] = objInFor[convQxUsers_School.DepartmentName];
objDR[convQxUsers_School.DepartmentAbbrName] = objInFor[convQxUsers_School.DepartmentAbbrName];
objDR[convQxUsers_School.DepartmentTypeId] = objInFor[convQxUsers_School.DepartmentTypeId];
objDR[convQxUsers_School.DepartmentTypeName] = objInFor[convQxUsers_School.DepartmentTypeName];
objDR[convQxUsers_School.UpDepartmentId] = objInFor[convQxUsers_School.UpDepartmentId];
objDR[convQxUsers_School.UpDepartmentName] = objInFor[convQxUsers_School.UpDepartmentName];
objDR[convQxUsers_School.UserStateId] = objInFor[convQxUsers_School.UserStateId];
objDR[convQxUsers_School.UserStateName] = objInFor[convQxUsers_School.UserStateName];
objDR[convQxUsers_School.IdentityId] = objInFor[convQxUsers_School.IdentityId];
objDR[convQxUsers_School.IdentityDesc] = objInFor[convQxUsers_School.IdentityDesc];
objDR[convQxUsers_School.CardNo] = objInFor[convQxUsers_School.CardNo];
objDR[convQxUsers_School.StuTeacherId] = objInFor[convQxUsers_School.StuTeacherId];
objDR[convQxUsers_School.IdGradeBase] = objInFor[convQxUsers_School.IdGradeBase];
objDR[convQxUsers_School.GradeBaseName] = objInFor[convQxUsers_School.GradeBaseName];
objDR[convQxUsers_School.EnterSchoolDate] = objInFor[convQxUsers_School.EnterSchoolDate];
objDR[convQxUsers_School.IsOffed] = objInFor[convQxUsers_School.IsOffed];
objDR[convQxUsers_School.BeginYearMonth] = objInFor[convQxUsers_School.BeginYearMonth];
objDR[convQxUsers_School.EndYearMonth] = objInFor[convQxUsers_School.EndYearMonth];
objDR[convQxUsers_School.CardState] = objInFor[convQxUsers_School.CardState];
objDR[convQxUsers_School.IsLeaved] = objInFor[convQxUsers_School.IsLeaved];
objDR[convQxUsers_School.UpdDate] = objInFor[convQxUsers_School.UpdDate];
objDR[convQxUsers_School.UpdUser] = objInFor[convQxUsers_School.UpdUser];
objDR[convQxUsers_School.Memo] = objInFor[convQxUsers_School.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}