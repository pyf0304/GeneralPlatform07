
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsersBL
 表名:vQxUsers(00140024)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:52
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsvQxUsersBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsersEN GetObj(this K_UserId_vQxUsers myKey)
{
clsvQxUsersEN objvQxUsersEN = clsvQxUsersBL.vQxUsersDA.GetObjByUserId(myKey.Value);
return objvQxUsersEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserId(this clsvQxUsersEN objvQxUsersEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUsers.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserName(this clsvQxUsersEN objvQxUsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUsers.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUsers.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUsers.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentAbbrName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUsers.DepartmentAbbrName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeId(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers.DepartmentTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetDepartmentTypeName(this clsvQxUsersEN objvQxUsersEN, string strDepartmentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers.DepartmentTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentId(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers.UpDepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpDepartmentName(this clsvQxUsersEN objvQxUsersEN, string strUpDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers.UpDepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserStateId(this clsvQxUsersEN objvQxUsersEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers.UserStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUserStateName(this clsvQxUsersEN objvQxUsersEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUsers.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetPassword(this clsvQxUsersEN objvQxUsersEN, string strPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUsers.Password);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveBeginDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, convQxUsers.EffitiveBeginDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUsers.EffitiveBeginDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetEffitiveEndDate(this clsvQxUsersEN objvQxUsersEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, convQxUsers.EffitiveEndDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUsers.EffitiveEndDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetStuTeacherId(this clsvQxUsersEN objvQxUsersEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convQxUsers.StuTeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUsers.StuTeacherId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdentityId(this clsvQxUsersEN objvQxUsersEN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUsers.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUsers.IdentityId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdentityDesc(this clsvQxUsersEN objvQxUsersEN, string strIdentityDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers.IdentityDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetOpenId(this clsvQxUsersEN objvQxUsersEN, string strOpenId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpenId, 50, convQxUsers.OpenId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetSynchDate(this clsvQxUsersEN objvQxUsersEN, string strSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchDate, 14, convQxUsers.SynchDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpdDate(this clsvQxUsersEN objvQxUsersEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetUpdUser(this clsvQxUsersEN objvQxUsersEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetIdXzCollege(this clsvQxUsersEN objvQxUsersEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUsers.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUsers.IdXzCollege);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsersEN SetMemo(this clsvQxUsersEN objvQxUsersEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <param name = "objvQxUsersENT">目标对象</param>
 public static void CopyTo(this clsvQxUsersEN objvQxUsersENS, clsvQxUsersEN objvQxUsersENT)
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
 /// <param name = "objvQxUsersENS">源对象</param>
 /// <returns>目标对象=>clsvQxUsersEN:objvQxUsersENT</returns>
 public static clsvQxUsersEN CopyTo(this clsvQxUsersEN objvQxUsersENS)
{
try
{
 clsvQxUsersEN objvQxUsersENT = new clsvQxUsersEN()
{
UserId = objvQxUsersENS.UserId, //用户ID
UserName = objvQxUsersENS.UserName, //用户名
DepartmentId = objvQxUsersENS.DepartmentId, //部门Id
DepartmentName = objvQxUsersENS.DepartmentName, //部门名
DepartmentAbbrName = objvQxUsersENS.DepartmentAbbrName, //名称缩写
DepartmentTypeId = objvQxUsersENS.DepartmentTypeId, //部门类型ID
DepartmentTypeName = objvQxUsersENS.DepartmentTypeName, //部门类型名
UpDepartmentId = objvQxUsersENS.UpDepartmentId, //所属部门号
UpDepartmentName = objvQxUsersENS.UpDepartmentName, //上级部门
UserStateId = objvQxUsersENS.UserStateId, //用户状态Id
UserStateName = objvQxUsersENS.UserStateName, //用户状态名
Password = objvQxUsersENS.Password, //口令
EffitiveBeginDate = objvQxUsersENS.EffitiveBeginDate, //有效开始日期
EffitiveEndDate = objvQxUsersENS.EffitiveEndDate, //有效结束日期
StuTeacherId = objvQxUsersENS.StuTeacherId, //学工号
IdentityId = objvQxUsersENS.IdentityId, //身份编号
IdentityDesc = objvQxUsersENS.IdentityDesc, //身份描述
OpenId = objvQxUsersENS.OpenId, //微信openid
IsSynch = objvQxUsersENS.IsSynch, //是否同步
SynchDate = objvQxUsersENS.SynchDate, //同步日期
UpdDate = objvQxUsersENS.UpdDate, //修改日期
UpdUser = objvQxUsersENS.UpdUser, //修改用户
IdXzCollege = objvQxUsersENS.IdXzCollege, //IdXzCollege
Memo = objvQxUsersENS.Memo, //备注
};
 return objvQxUsersENT;
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
public static void CheckProperty4Condition(this clsvQxUsersEN objvQxUsersEN)
{
 clsvQxUsersBL.vQxUsersDA.CheckProperty4Condition(objvQxUsersEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUsers
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户(vQxUsers)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsersBL
{
public static RelatedActions_vQxUsers relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUsersListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUsersList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUsersEN> arrvQxUsersObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUsersDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUsersDA vQxUsersDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUsersDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUsersBL()
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
if (string.IsNullOrEmpty(clsvQxUsersEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsersEN._ConnectString);
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
objDS = vQxUsersDA.GetDataSet(strWhereCond);
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
objDS = vQxUsersDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUsersDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUsers(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUsersDA.GetDataTable_vQxUsers(strWhereCond);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUsersDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUsersDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUsersDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUsersDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUsersDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUsersDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserIdLst, true);
 string strWhereCond = string.Format("UserId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUsersEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
List<clsvQxUsersEN> arrvQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrvQxUsersObjLst_Sel =
arrvQxUsersObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrvQxUsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLst(string strWhereCond)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUsersEN> GetSubObjLstCache(clsvQxUsersEN objvQxUsersCond)
{
List<clsvQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers.AttributeName)
{
if (objvQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else
{
if (objvQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
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
public static List<clsvQxUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
List<clsvQxUsersEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUsersEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
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
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static IEnumerable<clsvQxUsersEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUsersEN objvQxUsersCond, string strOrderBy)
{
List<clsvQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers.AttributeName)
{
if (objvQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else
{
if (objvQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
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
public static IEnumerable<clsvQxUsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUsersEN objvQxUsersCond = JsonConvert.DeserializeObject<clsvQxUsersEN>(objPagerPara.whereCond);
if (objvQxUsersCond.sfFldComparisonOp == null)
{
objvQxUsersCond.dicFldComparisonOp = null;
}
else
{
objvQxUsersCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUsersCond.sfFldComparisonOp);
}
clsvQxUsersBL.SetUpdFlag(objvQxUsersCond);
 try
{
CheckProperty4Condition(objvQxUsersCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUsersBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUsersCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUsersEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
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
public static List<clsvQxUsersEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUsersEN> arrObjLst = new List<clsvQxUsersEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
try
{
objvQxUsersEN.UserId = objRow[convQxUsers.UserId].ToString().Trim(); //用户ID
objvQxUsersEN.UserName = objRow[convQxUsers.UserName].ToString().Trim(); //用户名
objvQxUsersEN.DepartmentId = objRow[convQxUsers.DepartmentId].ToString().Trim(); //部门Id
objvQxUsersEN.DepartmentName = objRow[convQxUsers.DepartmentName].ToString().Trim(); //部门名
objvQxUsersEN.DepartmentAbbrName = objRow[convQxUsers.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsersEN.DepartmentTypeId = objRow[convQxUsers.DepartmentTypeId] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsersEN.DepartmentTypeName = objRow[convQxUsers.DepartmentTypeName] == DBNull.Value ? null : objRow[convQxUsers.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsersEN.UpDepartmentId = objRow[convQxUsers.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsersEN.UpDepartmentName = objRow[convQxUsers.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsersEN.UserStateId = objRow[convQxUsers.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsersEN.UserStateName = objRow[convQxUsers.UserStateName].ToString().Trim(); //用户状态名
objvQxUsersEN.Password = objRow[convQxUsers.Password] == DBNull.Value ? null : objRow[convQxUsers.Password].ToString().Trim(); //口令
objvQxUsersEN.EffitiveBeginDate = objRow[convQxUsers.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsersEN.EffitiveEndDate = objRow[convQxUsers.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsersEN.StuTeacherId = objRow[convQxUsers.StuTeacherId].ToString().Trim(); //学工号
objvQxUsersEN.IdentityId = objRow[convQxUsers.IdentityId] == DBNull.Value ? null : objRow[convQxUsers.IdentityId].ToString().Trim(); //身份编号
objvQxUsersEN.IdentityDesc = objRow[convQxUsers.IdentityDesc] == DBNull.Value ? null : objRow[convQxUsers.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsersEN.OpenId = objRow[convQxUsers.OpenId] == DBNull.Value ? null : objRow[convQxUsers.OpenId].ToString().Trim(); //微信openid
objvQxUsersEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers.IsSynch].ToString().Trim()); //是否同步
objvQxUsersEN.SynchDate = objRow[convQxUsers.SynchDate] == DBNull.Value ? null : objRow[convQxUsers.SynchDate].ToString().Trim(); //同步日期
objvQxUsersEN.UpdDate = objRow[convQxUsers.UpdDate] == DBNull.Value ? null : objRow[convQxUsers.UpdDate].ToString().Trim(); //修改日期
objvQxUsersEN.UpdUser = objRow[convQxUsers.UpdUser] == DBNull.Value ? null : objRow[convQxUsers.UpdUser].ToString().Trim(); //修改用户
objvQxUsersEN.IdXzCollege = objRow[convQxUsers.IdXzCollege] == DBNull.Value ? null : objRow[convQxUsers.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsersEN.Memo = objRow[convQxUsers.Memo] == DBNull.Value ? null : objRow[convQxUsers.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsersEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsersEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUsersEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUsers(ref clsvQxUsersEN objvQxUsersEN)
{
bool bolResult = vQxUsersDA.GetvQxUsers(ref objvQxUsersEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsersEN GetObjByUserId(string strUserId)
{
if (strUserId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetObjByUserId(strUserId);
return objvQxUsersEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUsersEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetFirstObj(strWhereCond);
 return objvQxUsersEN;
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
public static clsvQxUsersEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetObjByDataRow(objRow);
 return objvQxUsersEN;
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
public static clsvQxUsersEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUsersEN objvQxUsersEN = vQxUsersDA.GetObjByDataRow(objRow);
 return objvQxUsersEN;
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
 /// <param name = "strUserId">所给的关键字</param>
 /// <param name = "lstvQxUsersObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsersEN GetObjByUserIdFromList(string strUserId, List<clsvQxUsersEN> lstvQxUsersObjLst)
{
foreach (clsvQxUsersEN objvQxUsersEN in lstvQxUsersObjLst)
{
if (objvQxUsersEN.UserId == strUserId)
{
return objvQxUsersEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strUserId;
 try
 {
 strUserId = new clsvQxUsersDA().GetFirstID(strWhereCond);
 return strUserId;
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
 arrList = vQxUsersDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUsersDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserId)
{
if (string.IsNullOrEmpty(strUserId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxUsersDA.IsExist(strUserId);
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
 bolIsExist = clsvQxUsersDA.IsExistTable();
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
 bolIsExist = vQxUsersDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUsersEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUsersEN objvQxUsersEN)
{
try
{
objvQxUsersEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUsersEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUsers.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserId = objvQxUsersEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUsers.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserName = objvQxUsersEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUsers.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentId = objvQxUsersEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUsers.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentName = objvQxUsersEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxUsers.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentAbbrName = objvQxUsersEN.DepartmentAbbrName == "[null]" ? null :  objvQxUsersEN.DepartmentAbbrName; //名称缩写
}
if (arrFldSet.Contains(convQxUsers.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentTypeId = objvQxUsersEN.DepartmentTypeId == "[null]" ? null :  objvQxUsersEN.DepartmentTypeId; //部门类型ID
}
if (arrFldSet.Contains(convQxUsers.DepartmentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.DepartmentTypeName = objvQxUsersEN.DepartmentTypeName == "[null]" ? null :  objvQxUsersEN.DepartmentTypeName; //部门类型名
}
if (arrFldSet.Contains(convQxUsers.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpDepartmentId = objvQxUsersEN.UpDepartmentId == "[null]" ? null :  objvQxUsersEN.UpDepartmentId; //所属部门号
}
if (arrFldSet.Contains(convQxUsers.UpDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpDepartmentName = objvQxUsersEN.UpDepartmentName == "[null]" ? null :  objvQxUsersEN.UpDepartmentName; //上级部门
}
if (arrFldSet.Contains(convQxUsers.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserStateId = objvQxUsersEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUsers.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UserStateName = objvQxUsersEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUsers.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.Password = objvQxUsersEN.Password == "[null]" ? null :  objvQxUsersEN.Password; //口令
}
if (arrFldSet.Contains(convQxUsers.EffitiveBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.EffitiveBeginDate = objvQxUsersEN.EffitiveBeginDate; //有效开始日期
}
if (arrFldSet.Contains(convQxUsers.EffitiveEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.EffitiveEndDate = objvQxUsersEN.EffitiveEndDate; //有效结束日期
}
if (arrFldSet.Contains(convQxUsers.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.StuTeacherId = objvQxUsersEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUsers.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IdentityId = objvQxUsersEN.IdentityId == "[null]" ? null :  objvQxUsersEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(convQxUsers.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IdentityDesc = objvQxUsersEN.IdentityDesc == "[null]" ? null :  objvQxUsersEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUsers.OpenId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.OpenId = objvQxUsersEN.OpenId == "[null]" ? null :  objvQxUsersEN.OpenId; //微信openid
}
if (arrFldSet.Contains(convQxUsers.IsSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IsSynch = objvQxUsersEN.IsSynch; //是否同步
}
if (arrFldSet.Contains(convQxUsers.SynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.SynchDate = objvQxUsersEN.SynchDate == "[null]" ? null :  objvQxUsersEN.SynchDate; //同步日期
}
if (arrFldSet.Contains(convQxUsers.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpdDate = objvQxUsersEN.UpdDate == "[null]" ? null :  objvQxUsersEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUsers.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.UpdUser = objvQxUsersEN.UpdUser == "[null]" ? null :  objvQxUsersEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(convQxUsers.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.IdXzCollege = objvQxUsersEN.IdXzCollege == "[null]" ? null :  objvQxUsersEN.IdXzCollege; //IdXzCollege
}
if (arrFldSet.Contains(convQxUsers.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsersEN.Memo = objvQxUsersEN.Memo == "[null]" ? null :  objvQxUsersEN.Memo; //备注
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
 /// <param name = "objvQxUsersEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUsersEN objvQxUsersEN)
{
try
{
if (objvQxUsersEN.DepartmentAbbrName == "[null]") objvQxUsersEN.DepartmentAbbrName = null; //名称缩写
if (objvQxUsersEN.DepartmentTypeId == "[null]") objvQxUsersEN.DepartmentTypeId = null; //部门类型ID
if (objvQxUsersEN.DepartmentTypeName == "[null]") objvQxUsersEN.DepartmentTypeName = null; //部门类型名
if (objvQxUsersEN.UpDepartmentId == "[null]") objvQxUsersEN.UpDepartmentId = null; //所属部门号
if (objvQxUsersEN.UpDepartmentName == "[null]") objvQxUsersEN.UpDepartmentName = null; //上级部门
if (objvQxUsersEN.Password == "[null]") objvQxUsersEN.Password = null; //口令
if (objvQxUsersEN.IdentityId == "[null]") objvQxUsersEN.IdentityId = null; //身份编号
if (objvQxUsersEN.IdentityDesc == "[null]") objvQxUsersEN.IdentityDesc = null; //身份描述
if (objvQxUsersEN.OpenId == "[null]") objvQxUsersEN.OpenId = null; //微信openid
if (objvQxUsersEN.SynchDate == "[null]") objvQxUsersEN.SynchDate = null; //同步日期
if (objvQxUsersEN.UpdDate == "[null]") objvQxUsersEN.UpdDate = null; //修改日期
if (objvQxUsersEN.UpdUser == "[null]") objvQxUsersEN.UpdUser = null; //修改用户
if (objvQxUsersEN.IdXzCollege == "[null]") objvQxUsersEN.IdXzCollege = null; //IdXzCollege
if (objvQxUsersEN.Memo == "[null]") objvQxUsersEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUsersEN objvQxUsersEN)
{
 vQxUsersDA.CheckProperty4Condition(objvQxUsersEN);
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
if (clsQxUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersBL没有刷新缓存机制(clsQxUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserStateBL没有刷新缓存机制(clsQxUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentInfoBL没有刷新缓存机制(clsQxDepartmentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentTypeBL没有刷新缓存机制(clsQxDepartmentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserId");
//if (arrvQxUsersObjLstCache == null)
//{
//arrvQxUsersObjLstCache = vQxUsersDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsersEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
List<clsvQxUsersEN> arrvQxUsersObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrvQxUsersObjLst_Sel =
arrvQxUsersObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrvQxUsersObjLst_Sel.Count() == 0)
{
   clsvQxUsersEN obj = clsvQxUsersBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUsersObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsersEN> GetAllvQxUsersObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUsersEN> arrvQxUsersObjLstCache = GetObjLstCache(); 
return arrvQxUsersObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsersEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUsersEN._CurrTabName);
List<clsvQxUsersEN> arrvQxUsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUsersObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUsersEN> lstvQxUsersObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUsersObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvQxUsersObjLst">[clsvQxUsersEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUsersEN> lstvQxUsersObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUsersBL.listXmlNode);
writer.WriteStartElement(clsvQxUsersBL.itemsXmlNode);
foreach (clsvQxUsersEN objvQxUsersEN in lstvQxUsersObjLst)
{
clsvQxUsersBL.SerializeXML(writer, objvQxUsersEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvQxUsersEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUsersEN objvQxUsersEN)
{
writer.WriteStartElement(clsvQxUsersBL.itemXmlNode);
 
if (objvQxUsersEN.UserId != null)
{
writer.WriteElementString(convQxUsers.UserId, objvQxUsersEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.UserName != null)
{
writer.WriteElementString(convQxUsers.UserName, objvQxUsersEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.DepartmentId != null)
{
writer.WriteElementString(convQxUsers.DepartmentId, objvQxUsersEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.DepartmentName != null)
{
writer.WriteElementString(convQxUsers.DepartmentName, objvQxUsersEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.DepartmentAbbrName != null)
{
writer.WriteElementString(convQxUsers.DepartmentAbbrName, objvQxUsersEN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.DepartmentTypeId != null)
{
writer.WriteElementString(convQxUsers.DepartmentTypeId, objvQxUsersEN.DepartmentTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.DepartmentTypeName != null)
{
writer.WriteElementString(convQxUsers.DepartmentTypeName, objvQxUsersEN.DepartmentTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.UpDepartmentId != null)
{
writer.WriteElementString(convQxUsers.UpDepartmentId, objvQxUsersEN.UpDepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.UpDepartmentName != null)
{
writer.WriteElementString(convQxUsers.UpDepartmentName, objvQxUsersEN.UpDepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.UserStateId != null)
{
writer.WriteElementString(convQxUsers.UserStateId, objvQxUsersEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.UserStateName != null)
{
writer.WriteElementString(convQxUsers.UserStateName, objvQxUsersEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.Password != null)
{
writer.WriteElementString(convQxUsers.Password, objvQxUsersEN.Password.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.EffitiveBeginDate != null)
{
writer.WriteElementString(convQxUsers.EffitiveBeginDate, objvQxUsersEN.EffitiveBeginDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.EffitiveEndDate != null)
{
writer.WriteElementString(convQxUsers.EffitiveEndDate, objvQxUsersEN.EffitiveEndDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.StuTeacherId != null)
{
writer.WriteElementString(convQxUsers.StuTeacherId, objvQxUsersEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.IdentityId != null)
{
writer.WriteElementString(convQxUsers.IdentityId, objvQxUsersEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.IdentityDesc != null)
{
writer.WriteElementString(convQxUsers.IdentityDesc, objvQxUsersEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.OpenId != null)
{
writer.WriteElementString(convQxUsers.OpenId, objvQxUsersEN.OpenId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUsers.IsSynch, objvQxUsersEN.IsSynch.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUsersEN.SynchDate != null)
{
writer.WriteElementString(convQxUsers.SynchDate, objvQxUsersEN.SynchDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.UpdDate != null)
{
writer.WriteElementString(convQxUsers.UpdDate, objvQxUsersEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.UpdUser != null)
{
writer.WriteElementString(convQxUsers.UpdUser, objvQxUsersEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.IdXzCollege != null)
{
writer.WriteElementString(convQxUsers.IdXzCollege, objvQxUsersEN.IdXzCollege.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsersEN.Memo != null)
{
writer.WriteElementString(convQxUsers.Memo, objvQxUsersEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUsersEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
reader.Read();
while (!(reader.Name == clsvQxUsersBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUsers.UserId))
{
objvQxUsersEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.UserName))
{
objvQxUsersEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.DepartmentId))
{
objvQxUsersEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.DepartmentName))
{
objvQxUsersEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.DepartmentAbbrName))
{
objvQxUsersEN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.DepartmentTypeId))
{
objvQxUsersEN.DepartmentTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.DepartmentTypeName))
{
objvQxUsersEN.DepartmentTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.UpDepartmentId))
{
objvQxUsersEN.UpDepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.UpDepartmentName))
{
objvQxUsersEN.UpDepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.UserStateId))
{
objvQxUsersEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.UserStateName))
{
objvQxUsersEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.Password))
{
objvQxUsersEN.Password = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.EffitiveBeginDate))
{
objvQxUsersEN.EffitiveBeginDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.EffitiveEndDate))
{
objvQxUsersEN.EffitiveEndDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.StuTeacherId))
{
objvQxUsersEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.IdentityId))
{
objvQxUsersEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.IdentityDesc))
{
objvQxUsersEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.OpenId))
{
objvQxUsersEN.OpenId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.IsSynch))
{
objvQxUsersEN.IsSynch = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUsers.SynchDate))
{
objvQxUsersEN.SynchDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.UpdDate))
{
objvQxUsersEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.UpdUser))
{
objvQxUsersEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.IdXzCollege))
{
objvQxUsersEN.IdXzCollege = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers.Memo))
{
objvQxUsersEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUsersEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUsersObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUsersEN GetObjFromXmlStr(string strvQxUsersObjXmlStr)
{
clsvQxUsersEN objvQxUsersEN = new clsvQxUsersEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUsersObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUsersBL.itemXmlNode))
{
objvQxUsersEN = GetObjFromXml(reader);
return objvQxUsersEN;
}
}
return objvQxUsersEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUsersEN objvQxUsersEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUsersEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserId)
{
if (strInFldName != convQxUsers.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUsers.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUsers.AttributeName));
throw new Exception(strMsg);
}
var objvQxUsers = clsvQxUsersBL.GetObjByUserIdCache(strUserId);
if (objvQxUsers == null) return "";
return objvQxUsers[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUsersEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUsersEN objvQxUsersEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUsersEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUsersEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvQxUsersObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUsersEN> lstvQxUsersObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUsersObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUsersEN objvQxUsersEN in lstvQxUsersObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUsersEN);
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
int intRecCount = clsvQxUsersDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUsersDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUsersDA.GetRecCount();
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
int intRecCount = clsvQxUsersDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUsersCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUsersEN objvQxUsersCond)
{
List<clsvQxUsersEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsersEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers.AttributeName)
{
if (objvQxUsersCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsersCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else
{
if (objvQxUsersCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsersCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsersCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsersCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsersCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsersCond[strFldName]));
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
 List<string> arrList = clsvQxUsersDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUsersDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUsersDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}