
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserCodePathWApi
 表名:vQxUserCodePath(00140064)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:46
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统设置(SystemSet)
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
public static class  clsvQxUserCodePathWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetmId(this clsvQxUserCodePathEN objvQxUserCodePathEN, long lngmId, string strComparisonOp="")
	{
objvQxUserCodePathEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.mId) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.mId, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.mId] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetQxPrjId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserCodePath.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserCodePath.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserCodePath.QxPrjId);
objvQxUserCodePathEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.QxPrjId) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.QxPrjId, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.QxPrjId] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetPrjName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserCodePath.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserCodePath.PrjName);
objvQxUserCodePathEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.PrjName) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.PrjName, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.PrjName] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserCodePath.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserCodePath.UserId);
objvQxUserCodePathEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.UserId) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.UserId, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.UserId] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserCodePath.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserCodePath.UserName);
objvQxUserCodePathEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.UserName) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.UserName, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.UserName] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodePath">代码路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetCodePath(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePath, convQxUserCodePath.CodePath);
clsCheckSql.CheckFieldLen(strCodePath, 200, convQxUserCodePath.CodePath);
objvQxUserCodePathEN.CodePath = strCodePath; //代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.CodePath) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.CodePath, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.CodePath] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodePathBackup">备份代码路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetCodePathBackup(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePathBackup, convQxUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldLen(strCodePathBackup, 200, convQxUserCodePath.CodePathBackup);
objvQxUserCodePathEN.CodePathBackup = strCodePathBackup; //备份代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.CodePathBackup) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.CodePathBackup, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.CodePathBackup] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetDepartmentId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUserCodePath.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserCodePath.DepartmentId);
objvQxUserCodePathEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.DepartmentId) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.DepartmentId, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.DepartmentId] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetDepartmentName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUserCodePath.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserCodePath.DepartmentName);
objvQxUserCodePathEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.DepartmentName) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.DepartmentName, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.DepartmentName] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetQxCodeTypeId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strQxCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxCodeTypeId, convQxUserCodePath.QxCodeTypeId);
clsCheckSql.CheckFieldLen(strQxCodeTypeId, 4, convQxUserCodePath.QxCodeTypeId);
clsCheckSql.CheckFieldForeignKey(strQxCodeTypeId, 4, convQxUserCodePath.QxCodeTypeId);
objvQxUserCodePathEN.QxCodeTypeId = strQxCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.QxCodeTypeId) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.QxCodeTypeId, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.QxCodeTypeId] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetCodeTypeName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convQxUserCodePath.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 30, convQxUserCodePath.CodeTypeName);
objvQxUserCodePathEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.CodeTypeName) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.CodeTypeName, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.CodeTypeName] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetIsTemplate(this clsvQxUserCodePathEN objvQxUserCodePathEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convQxUserCodePath.IsTemplate);
objvQxUserCodePathEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.IsTemplate) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.IsTemplate, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.IsTemplate] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUpdUserId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxUserCodePath.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserCodePath.UpdUserId);
objvQxUserCodePathEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.UpdUserId) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.UpdUserId, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.UpdUserId] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUpdDate(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserCodePath.UpdDate);
objvQxUserCodePathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.UpdDate) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.UpdDate, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.UpdDate] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserStateName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUserCodePath.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserCodePath.UserStateName);
objvQxUserCodePathEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.UserStateName) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.UserStateName, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.UserStateName] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateId">用户状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserStateId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUserCodePath.UserStateId);
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserCodePath.UserStateId);
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserCodePath.UserStateId);
objvQxUserCodePathEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.UserStateId) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.UserStateId, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.UserStateId] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetMemo(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserCodePath.Memo);
objvQxUserCodePathEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserCodePathEN.dicFldComparisonOp.ContainsKey(convQxUserCodePath.Memo) == false)
{
objvQxUserCodePathEN.dicFldComparisonOp.Add(convQxUserCodePath.Memo, strComparisonOp);
}
else
{
objvQxUserCodePathEN.dicFldComparisonOp[convQxUserCodePath.Memo] = strComparisonOp;
}
}
return objvQxUserCodePathEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserCodePathEN objvQxUserCodePathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.mId) == true)
{
string strComparisonOpmId = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserCodePath.mId, objvQxUserCodePathCond.mId, strComparisonOpmId);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.QxPrjId, objvQxUserCodePathCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.PrjName, objvQxUserCodePathCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.UserId) == true)
{
string strComparisonOpUserId = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.UserId, objvQxUserCodePathCond.UserId, strComparisonOpUserId);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.UserName) == true)
{
string strComparisonOpUserName = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.UserName, objvQxUserCodePathCond.UserName, strComparisonOpUserName);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.CodePath) == true)
{
string strComparisonOpCodePath = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.CodePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.CodePath, objvQxUserCodePathCond.CodePath, strComparisonOpCodePath);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.CodePathBackup) == true)
{
string strComparisonOpCodePathBackup = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.CodePathBackup];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.CodePathBackup, objvQxUserCodePathCond.CodePathBackup, strComparisonOpCodePathBackup);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.DepartmentId, objvQxUserCodePathCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.DepartmentName, objvQxUserCodePathCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.QxCodeTypeId) == true)
{
string strComparisonOpQxCodeTypeId = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.QxCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.QxCodeTypeId, objvQxUserCodePathCond.QxCodeTypeId, strComparisonOpQxCodeTypeId);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.CodeTypeName, objvQxUserCodePathCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.IsTemplate) == true)
{
if (objvQxUserCodePathCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUserCodePath.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUserCodePath.IsTemplate);
}
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.UpdUserId, objvQxUserCodePathCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.UpdDate, objvQxUserCodePathCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.UserStateName, objvQxUserCodePathCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.UserStateId, objvQxUserCodePathCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUserCodePathCond.IsUpdated(convQxUserCodePath.Memo) == true)
{
string strComparisonOpMemo = objvQxUserCodePathCond.dicFldComparisonOp[convQxUserCodePath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserCodePath.Memo, objvQxUserCodePathCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户生成路径(vQxUserCodePath)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserCodePathWApi
{
private static readonly string mstrApiControllerName = "vQxUserCodePathApi";

 public clsvQxUserCodePathWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserCodePathEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxUserCodePathEN objvQxUserCodePathEN;
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
objvQxUserCodePathEN = JsonConvert.DeserializeObject<clsvQxUserCodePathEN>(strJson);
return objvQxUserCodePathEN;
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
public static clsvQxUserCodePathEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserCodePathEN objvQxUserCodePathEN;
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
objvQxUserCodePathEN = JsonConvert.DeserializeObject<clsvQxUserCodePathEN>(strJson);
return objvQxUserCodePathEN;
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
public static List<clsvQxUserCodePathEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserCodePathEN>>(strJson);
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
public static List<clsvQxUserCodePathEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserCodePathEN>>(strJson);
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
public static List<clsvQxUserCodePathEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserCodePathEN>>(strJson);
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
public static List<clsvQxUserCodePathEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserCodePathEN>>(strJson);
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
public static List<clsvQxUserCodePathEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserCodePathEN>>(strJson);
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
public static List<clsvQxUserCodePathEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserCodePathEN>>(strJson);
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
 /// <param name = "objvQxUserCodePathENS">源对象</param>
 /// <param name = "objvQxUserCodePathENT">目标对象</param>
 public static void CopyTo(clsvQxUserCodePathEN objvQxUserCodePathENS, clsvQxUserCodePathEN objvQxUserCodePathENT)
{
try
{
objvQxUserCodePathENT.mId = objvQxUserCodePathENS.mId; //流水号
objvQxUserCodePathENT.QxPrjId = objvQxUserCodePathENS.QxPrjId; //项目Id
objvQxUserCodePathENT.PrjName = objvQxUserCodePathENS.PrjName; //工程名
objvQxUserCodePathENT.UserId = objvQxUserCodePathENS.UserId; //用户ID
objvQxUserCodePathENT.UserName = objvQxUserCodePathENS.UserName; //用户名
objvQxUserCodePathENT.CodePath = objvQxUserCodePathENS.CodePath; //代码路径
objvQxUserCodePathENT.CodePathBackup = objvQxUserCodePathENS.CodePathBackup; //备份代码路径
objvQxUserCodePathENT.DepartmentId = objvQxUserCodePathENS.DepartmentId; //部门Id
objvQxUserCodePathENT.DepartmentName = objvQxUserCodePathENS.DepartmentName; //部门名
objvQxUserCodePathENT.QxCodeTypeId = objvQxUserCodePathENS.QxCodeTypeId; //代码类型Id
objvQxUserCodePathENT.CodeTypeName = objvQxUserCodePathENS.CodeTypeName; //代码类型名
objvQxUserCodePathENT.IsTemplate = objvQxUserCodePathENS.IsTemplate; //是否模板
objvQxUserCodePathENT.UpdUserId = objvQxUserCodePathENS.UpdUserId; //修改用户Id
objvQxUserCodePathENT.UpdDate = objvQxUserCodePathENS.UpdDate; //修改日期
objvQxUserCodePathENT.UserStateName = objvQxUserCodePathENS.UserStateName; //用户状态名
objvQxUserCodePathENT.UserStateId = objvQxUserCodePathENS.UserStateId; //用户状态Id
objvQxUserCodePathENT.Memo = objvQxUserCodePathENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUserCodePathEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserCodePathEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserCodePathEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserCodePathEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserCodePathEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserCodePathEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserCodePathEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUserCodePathEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserCodePath.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxUserCodePath.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.CodePath, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.CodePathBackup, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.QxCodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUserCodePath.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.UserStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserCodePath.Memo, Type.GetType("System.String"));
foreach (clsvQxUserCodePathEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserCodePath.mId] = objInFor[convQxUserCodePath.mId];
objDR[convQxUserCodePath.QxPrjId] = objInFor[convQxUserCodePath.QxPrjId];
objDR[convQxUserCodePath.PrjName] = objInFor[convQxUserCodePath.PrjName];
objDR[convQxUserCodePath.UserId] = objInFor[convQxUserCodePath.UserId];
objDR[convQxUserCodePath.UserName] = objInFor[convQxUserCodePath.UserName];
objDR[convQxUserCodePath.CodePath] = objInFor[convQxUserCodePath.CodePath];
objDR[convQxUserCodePath.CodePathBackup] = objInFor[convQxUserCodePath.CodePathBackup];
objDR[convQxUserCodePath.DepartmentId] = objInFor[convQxUserCodePath.DepartmentId];
objDR[convQxUserCodePath.DepartmentName] = objInFor[convQxUserCodePath.DepartmentName];
objDR[convQxUserCodePath.QxCodeTypeId] = objInFor[convQxUserCodePath.QxCodeTypeId];
objDR[convQxUserCodePath.CodeTypeName] = objInFor[convQxUserCodePath.CodeTypeName];
objDR[convQxUserCodePath.IsTemplate] = objInFor[convQxUserCodePath.IsTemplate];
objDR[convQxUserCodePath.UpdUserId] = objInFor[convQxUserCodePath.UpdUserId];
objDR[convQxUserCodePath.UpdDate] = objInFor[convQxUserCodePath.UpdDate];
objDR[convQxUserCodePath.UserStateName] = objInFor[convQxUserCodePath.UserStateName];
objDR[convQxUserCodePath.UserStateId] = objInFor[convQxUserCodePath.UserStateId];
objDR[convQxUserCodePath.Memo] = objInFor[convQxUserCodePath.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}