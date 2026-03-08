
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserLoginNameWApi
 表名:vQxUserLoginName(00140077)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:51
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
public static class  clsvQxUserLoginNameWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserLoginName">用户登录名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserLoginName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserLoginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserLoginName, 30, convQxUserLoginName.UserLoginName);
objvQxUserLoginNameEN.UserLoginName = strUserLoginName; //用户登录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.UserLoginName) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.UserLoginName, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.UserLoginName] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserLoginName.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserLoginName.UserId);
objvQxUserLoginNameEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.UserId) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.UserId, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.UserId] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserLoginName.UserName);
objvQxUserLoginNameEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.UserName) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.UserName, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.UserName] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetDepartmentId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserLoginName.DepartmentId);
objvQxUserLoginNameEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.DepartmentId) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.DepartmentId, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.DepartmentId] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetDepartmentName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserLoginName.DepartmentName);
objvQxUserLoginNameEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.DepartmentName) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.DepartmentName, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.DepartmentName] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentAbbrName">名称缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetDepartmentAbbrName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUserLoginName.DepartmentAbbrName);
objvQxUserLoginNameEN.DepartmentAbbrName = strDepartmentAbbrName; //名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.DepartmentAbbrName) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.DepartmentAbbrName, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.DepartmentAbbrName] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserStateId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserLoginName.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserLoginName.UserStateId);
objvQxUserLoginNameEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.UserStateId) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.UserStateId, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.UserStateId] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserStateName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserLoginName.UserStateName);
objvQxUserLoginNameEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.UserStateName) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.UserStateName, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.UserStateName] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strPassword">口令</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetPassword(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUserLoginName.Password);
objvQxUserLoginNameEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.Password) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.Password, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.Password] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveBeginDate">有效开始日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetEffitiveBeginDate(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUserLoginName.EffitiveBeginDate);
objvQxUserLoginNameEN.EffitiveBeginDate = strEffitiveBeginDate; //有效开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.EffitiveBeginDate) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.EffitiveBeginDate, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.EffitiveBeginDate] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strEffitiveEndDate">有效结束日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetEffitiveEndDate(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUserLoginName.EffitiveEndDate);
objvQxUserLoginNameEN.EffitiveEndDate = strEffitiveEndDate; //有效结束日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.EffitiveEndDate) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.EffitiveEndDate, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.EffitiveEndDate] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strStuTeacherId">学工号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetStuTeacherId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUserLoginName.StuTeacherId);
objvQxUserLoginNameEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.StuTeacherId) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.StuTeacherId, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.StuTeacherId] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityId">身份编号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetIdentityId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUserLoginName.IdentityId);
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUserLoginName.IdentityId);
objvQxUserLoginNameEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.IdentityId) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.IdentityId, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.IdentityId] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetIdentityDesc(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserLoginName.IdentityDesc);
objvQxUserLoginNameEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.IdentityDesc) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.IdentityDesc, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.IdentityDesc] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetMemo(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserLoginName.Memo);
objvQxUserLoginNameEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserLoginNameEN.dicFldComparisonOp.ContainsKey(convQxUserLoginName.Memo) == false)
{
objvQxUserLoginNameEN.dicFldComparisonOp.Add(convQxUserLoginName.Memo, strComparisonOp);
}
else
{
objvQxUserLoginNameEN.dicFldComparisonOp[convQxUserLoginName.Memo] = strComparisonOp;
}
}
return objvQxUserLoginNameEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserLoginNameEN objvQxUserLoginNameCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.UserLoginName) == true)
{
string strComparisonOpUserLoginName = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.UserLoginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.UserLoginName, objvQxUserLoginNameCond.UserLoginName, strComparisonOpUserLoginName);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.UserId) == true)
{
string strComparisonOpUserId = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.UserId, objvQxUserLoginNameCond.UserId, strComparisonOpUserId);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.UserName) == true)
{
string strComparisonOpUserName = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.UserName, objvQxUserLoginNameCond.UserName, strComparisonOpUserName);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.DepartmentId, objvQxUserLoginNameCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.DepartmentName, objvQxUserLoginNameCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.DepartmentAbbrName, objvQxUserLoginNameCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.UserStateId, objvQxUserLoginNameCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.UserStateName, objvQxUserLoginNameCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.Password) == true)
{
string strComparisonOpPassword = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.Password, objvQxUserLoginNameCond.Password, strComparisonOpPassword);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.EffitiveBeginDate) == true)
{
string strComparisonOpEffitiveBeginDate = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.EffitiveBeginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.EffitiveBeginDate, objvQxUserLoginNameCond.EffitiveBeginDate, strComparisonOpEffitiveBeginDate);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.EffitiveEndDate) == true)
{
string strComparisonOpEffitiveEndDate = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.EffitiveEndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.EffitiveEndDate, objvQxUserLoginNameCond.EffitiveEndDate, strComparisonOpEffitiveEndDate);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.StuTeacherId, objvQxUserLoginNameCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.IdentityId, objvQxUserLoginNameCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.IdentityDesc, objvQxUserLoginNameCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUserLoginNameCond.IsUpdated(convQxUserLoginName.Memo) == true)
{
string strComparisonOpMemo = objvQxUserLoginNameCond.dicFldComparisonOp[convQxUserLoginName.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserLoginName.Memo, objvQxUserLoginNameCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vUserLoginName(vQxUserLoginName)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserLoginNameWApi
{
private static readonly string mstrApiControllerName = "vQxUserLoginNameApi";

 public clsvQxUserLoginNameWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserLoginNameEN GetObjByUserLoginName(string strUserLoginName)
{
string strAction = "GetObjByUserLoginName";
clsvQxUserLoginNameEN objvQxUserLoginNameEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserLoginName"] = strUserLoginName,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxUserLoginNameEN = JsonConvert.DeserializeObject<clsvQxUserLoginNameEN>(strJson);
return objvQxUserLoginNameEN;
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
public static clsvQxUserLoginNameEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserLoginNameEN objvQxUserLoginNameEN;
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
objvQxUserLoginNameEN = JsonConvert.DeserializeObject<clsvQxUserLoginNameEN>(strJson);
return objvQxUserLoginNameEN;
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
public static List<clsvQxUserLoginNameEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserLoginNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserLoginNameEN>>(strJson);
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
 /// <param name = "arrUserLoginName">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLstByUserLoginNameLst(List<string> arrUserLoginName)
{
 List<clsvQxUserLoginNameEN> arrObjLst; 
string strAction = "GetObjLstByUserLoginNameLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrUserLoginName);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserLoginNameEN>>(strJson);
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
public static List<clsvQxUserLoginNameEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserLoginNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserLoginNameEN>>(strJson);
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
public static List<clsvQxUserLoginNameEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserLoginNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserLoginNameEN>>(strJson);
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
public static List<clsvQxUserLoginNameEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserLoginNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserLoginNameEN>>(strJson);
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
public static List<clsvQxUserLoginNameEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserLoginNameEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserLoginNameEN>>(strJson);
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
public static bool IsExist(string strUserLoginName)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strUserLoginName"] = strUserLoginName
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
 /// <param name = "objvQxUserLoginNameENS">源对象</param>
 /// <param name = "objvQxUserLoginNameENT">目标对象</param>
 public static void CopyTo(clsvQxUserLoginNameEN objvQxUserLoginNameENS, clsvQxUserLoginNameEN objvQxUserLoginNameENT)
{
try
{
objvQxUserLoginNameENT.UserLoginName = objvQxUserLoginNameENS.UserLoginName; //用户登录名
objvQxUserLoginNameENT.UserId = objvQxUserLoginNameENS.UserId; //用户ID
objvQxUserLoginNameENT.UserName = objvQxUserLoginNameENS.UserName; //用户名
objvQxUserLoginNameENT.DepartmentId = objvQxUserLoginNameENS.DepartmentId; //部门Id
objvQxUserLoginNameENT.DepartmentName = objvQxUserLoginNameENS.DepartmentName; //部门名
objvQxUserLoginNameENT.DepartmentAbbrName = objvQxUserLoginNameENS.DepartmentAbbrName; //名称缩写
objvQxUserLoginNameENT.UserStateId = objvQxUserLoginNameENS.UserStateId; //用户状态Id
objvQxUserLoginNameENT.UserStateName = objvQxUserLoginNameENS.UserStateName; //用户状态名
objvQxUserLoginNameENT.Password = objvQxUserLoginNameENS.Password; //口令
objvQxUserLoginNameENT.EffitiveBeginDate = objvQxUserLoginNameENS.EffitiveBeginDate; //有效开始日期
objvQxUserLoginNameENT.EffitiveEndDate = objvQxUserLoginNameENS.EffitiveEndDate; //有效结束日期
objvQxUserLoginNameENT.StuTeacherId = objvQxUserLoginNameENS.StuTeacherId; //学工号
objvQxUserLoginNameENT.IdentityId = objvQxUserLoginNameENS.IdentityId; //身份编号
objvQxUserLoginNameENT.IdentityDesc = objvQxUserLoginNameENS.IdentityDesc; //身份描述
objvQxUserLoginNameENT.Memo = objvQxUserLoginNameENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUserLoginNameEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserLoginNameEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserLoginNameEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserLoginNameEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserLoginNameEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserLoginNameEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserLoginNameEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUserLoginNameEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserLoginName.UserLoginName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.Password, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.EffitiveBeginDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.EffitiveEndDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.StuTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.IdentityId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserLoginName.Memo, Type.GetType("System.String"));
foreach (clsvQxUserLoginNameEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserLoginName.UserLoginName] = objInFor[convQxUserLoginName.UserLoginName];
objDR[convQxUserLoginName.UserId] = objInFor[convQxUserLoginName.UserId];
objDR[convQxUserLoginName.UserName] = objInFor[convQxUserLoginName.UserName];
objDR[convQxUserLoginName.DepartmentId] = objInFor[convQxUserLoginName.DepartmentId];
objDR[convQxUserLoginName.DepartmentName] = objInFor[convQxUserLoginName.DepartmentName];
objDR[convQxUserLoginName.DepartmentAbbrName] = objInFor[convQxUserLoginName.DepartmentAbbrName];
objDR[convQxUserLoginName.UserStateId] = objInFor[convQxUserLoginName.UserStateId];
objDR[convQxUserLoginName.UserStateName] = objInFor[convQxUserLoginName.UserStateName];
objDR[convQxUserLoginName.Password] = objInFor[convQxUserLoginName.Password];
objDR[convQxUserLoginName.EffitiveBeginDate] = objInFor[convQxUserLoginName.EffitiveBeginDate];
objDR[convQxUserLoginName.EffitiveEndDate] = objInFor[convQxUserLoginName.EffitiveEndDate];
objDR[convQxUserLoginName.StuTeacherId] = objInFor[convQxUserLoginName.StuTeacherId];
objDR[convQxUserLoginName.IdentityId] = objInFor[convQxUserLoginName.IdentityId];
objDR[convQxUserLoginName.IdentityDesc] = objInFor[convQxUserLoginName.IdentityDesc];
objDR[convQxUserLoginName.Memo] = objInFor[convQxUserLoginName.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}