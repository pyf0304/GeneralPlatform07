
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers_SchoolBL
 表名:vQxUsers_School(00140075)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:48
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
public static class  clsvQxUsers_SchoolBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers_SchoolEN GetObj(this K_UserId_vQxUsers_School myKey)
{
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = clsvQxUsers_SchoolBL.vQxUsers_SchoolDA.GetObjByUserId(myKey.Value);
return objvQxUsers_SchoolEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUsers_School.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers_School.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUsers_School.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUsers_School.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers_School.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUsers_School.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers_School.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentAbbrName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUsers_School.DepartmentAbbrName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentTypeId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeId, convQxUsers_School.DepartmentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers_School.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers_School.DepartmentTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetDepartmentTypeName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeName, convQxUsers_School.DepartmentTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers_School.DepartmentTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpDepartmentId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers_School.UpDepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpDepartmentName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers_School.UpDepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserStateId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers_School.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers_School.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers_School.UserStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUserStateName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUsers_School.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers_School.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIdentityId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convQxUsers_School.IdentityId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUsers_School.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUsers_School.IdentityId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIdentityDesc(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxUsers_School.IdentityDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers_School.IdentityDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetCardNo(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strCardNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardNo, 10, convQxUsers_School.CardNo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetStuTeacherId(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strStuTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUsers_School.StuTeacherId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetIdGradeBase(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strIdGradeBase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, convQxUsers_School.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, convQxUsers_School.IdGradeBase);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetGradeBaseName(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convQxUsers_School.GradeBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeBaseName, 20, convQxUsers_School.GradeBaseName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetEnterSchoolDate(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strEnterSchoolDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEnterSchoolDate, 8, convQxUsers_School.EnterSchoolDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEnterSchoolDate, 8, convQxUsers_School.EnterSchoolDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetBeginYearMonth(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strBeginYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBeginYearMonth, 8, convQxUsers_School.BeginYearMonth);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetEndYearMonth(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strEndYearMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndYearMonth, 8, convQxUsers_School.EndYearMonth);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetCardState(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strCardState, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCardState, 10, convQxUsers_School.CardState);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpdDate(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers_School.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetUpdUser(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers_School.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers_SchoolEN SetMemo(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers_School.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolENS">源对象</param>
 /// <param name = "objvQxUsers_SchoolENT">目标对象</param>
 public static void CopyTo(this clsvQxUsers_SchoolEN objvQxUsers_SchoolENS, clsvQxUsers_SchoolEN objvQxUsers_SchoolENT)
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
 /// <param name = "objvQxUsers_SchoolENS">源对象</param>
 /// <returns>目标对象=>clsvQxUsers_SchoolEN:objvQxUsers_SchoolENT</returns>
 public static clsvQxUsers_SchoolEN CopyTo(this clsvQxUsers_SchoolEN objvQxUsers_SchoolENS)
{
try
{
 clsvQxUsers_SchoolEN objvQxUsers_SchoolENT = new clsvQxUsers_SchoolEN()
{
UserId = objvQxUsers_SchoolENS.UserId, //用户ID
UserName = objvQxUsers_SchoolENS.UserName, //用户名
DepartmentId = objvQxUsers_SchoolENS.DepartmentId, //部门Id
DepartmentName = objvQxUsers_SchoolENS.DepartmentName, //部门名
DepartmentAbbrName = objvQxUsers_SchoolENS.DepartmentAbbrName, //名称缩写
DepartmentTypeId = objvQxUsers_SchoolENS.DepartmentTypeId, //部门类型ID
DepartmentTypeName = objvQxUsers_SchoolENS.DepartmentTypeName, //部门类型名
UpDepartmentId = objvQxUsers_SchoolENS.UpDepartmentId, //所属部门号
UpDepartmentName = objvQxUsers_SchoolENS.UpDepartmentName, //上级部门
UserStateId = objvQxUsers_SchoolENS.UserStateId, //用户状态Id
UserStateName = objvQxUsers_SchoolENS.UserStateName, //用户状态名
IdentityId = objvQxUsers_SchoolENS.IdentityId, //身份编号
IdentityDesc = objvQxUsers_SchoolENS.IdentityDesc, //身份描述
CardNo = objvQxUsers_SchoolENS.CardNo, //卡号
StuTeacherId = objvQxUsers_SchoolENS.StuTeacherId, //学工号
IdGradeBase = objvQxUsers_SchoolENS.IdGradeBase, //年级流水号
GradeBaseName = objvQxUsers_SchoolENS.GradeBaseName, //年级名称
EnterSchoolDate = objvQxUsers_SchoolENS.EnterSchoolDate, //进校日期
IsOffed = objvQxUsers_SchoolENS.IsOffed, //是否毕业
BeginYearMonth = objvQxUsers_SchoolENS.BeginYearMonth, //开始年月
EndYearMonth = objvQxUsers_SchoolENS.EndYearMonth, //结束年月
CardState = objvQxUsers_SchoolENS.CardState, //卡状态
IsLeaved = objvQxUsers_SchoolENS.IsLeaved, //IsLeaved
UpdDate = objvQxUsers_SchoolENS.UpdDate, //修改日期
UpdUser = objvQxUsers_SchoolENS.UpdUser, //修改用户
Memo = objvQxUsers_SchoolENS.Memo, //备注
};
 return objvQxUsers_SchoolENT;
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
public static void CheckProperty4Condition(this clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
 clsvQxUsers_SchoolBL.vQxUsers_SchoolDA.CheckProperty4Condition(objvQxUsers_SchoolEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUsers_School
{
public virtual bool UpdRelaTabDate(string strUserId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vUsers_School(vQxUsers_School)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsers_SchoolBL
{
public static RelatedActions_vQxUsers_School relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUsers_SchoolListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUsers_SchoolList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUsers_SchoolDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUsers_SchoolDA vQxUsers_SchoolDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUsers_SchoolDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUsers_SchoolBL()
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
if (string.IsNullOrEmpty(clsvQxUsers_SchoolEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsers_SchoolEN._ConnectString);
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
objDS = vQxUsers_SchoolDA.GetDataSet(strWhereCond);
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
objDS = vQxUsers_SchoolDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUsers_SchoolDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUsers_School(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUsers_SchoolDA.GetDataTable_vQxUsers_School(strWhereCond);
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
objDT = vQxUsers_SchoolDA.GetDataTable(strWhereCond);
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
objDT = vQxUsers_SchoolDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUsers_SchoolDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUsers_SchoolDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUsers_SchoolDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUsers_SchoolDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUsers_SchoolDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUsers_SchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUsers_SchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUsers_SchoolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUsers_SchoolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUsers_SchoolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUsers_SchoolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByUserIdLst(List<string> arrUserIdLst)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
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
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUsers_SchoolEN> GetObjLstByUserIdLstCache(List<string> arrUserIdLst)
{
string strKey = string.Format("{0}", clsvQxUsers_SchoolEN._CurrTabName);
List<clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLst_Sel =
arrvQxUsers_SchoolObjLstCache
.Where(x => arrUserIdLst.Contains(x.UserId));
return arrvQxUsers_SchoolObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetObjLst(string strWhereCond)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public static List<clsvQxUsers_SchoolEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUsers_SchoolEN> GetSubObjLstCache(clsvQxUsers_SchoolEN objvQxUsers_SchoolCond)
{
List<clsvQxUsers_SchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers_SchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers_School.AttributeName)
{
if (objvQxUsers_SchoolCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsers_SchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers_SchoolCond[strFldName].ToString());
}
else
{
if (objvQxUsers_SchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsers_SchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers_SchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsers_SchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsers_SchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsers_SchoolCond[strFldName]));
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
List<clsvQxUsers_SchoolEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUsers_SchoolEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUsers_SchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
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
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public static List<clsvQxUsers_SchoolEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public static IEnumerable<clsvQxUsers_SchoolEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUsers_SchoolEN objvQxUsers_SchoolCond, string strOrderBy)
{
List<clsvQxUsers_SchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers_SchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers_School.AttributeName)
{
if (objvQxUsers_SchoolCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsers_SchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers_SchoolCond[strFldName].ToString());
}
else
{
if (objvQxUsers_SchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsers_SchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers_SchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsers_SchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsers_SchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsers_SchoolCond[strFldName]));
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
public static IEnumerable<clsvQxUsers_SchoolEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUsers_SchoolEN objvQxUsers_SchoolCond = JsonConvert.DeserializeObject<clsvQxUsers_SchoolEN>(objPagerPara.whereCond);
if (objvQxUsers_SchoolCond.sfFldComparisonOp == null)
{
objvQxUsers_SchoolCond.dicFldComparisonOp = null;
}
else
{
objvQxUsers_SchoolCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUsers_SchoolCond.sfFldComparisonOp);
}
clsvQxUsers_SchoolBL.SetUpdFlag(objvQxUsers_SchoolCond);
 try
{
CheckProperty4Condition(objvQxUsers_SchoolCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUsers_SchoolBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUsers_SchoolCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
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
public static List<clsvQxUsers_SchoolEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUsers_SchoolEN> arrObjLst = new List<clsvQxUsers_SchoolEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
try
{
objvQxUsers_SchoolEN.UserId = objRow[convQxUsers_School.UserId].ToString().Trim(); //用户ID
objvQxUsers_SchoolEN.UserName = objRow[convQxUsers_School.UserName].ToString().Trim(); //用户名
objvQxUsers_SchoolEN.DepartmentId = objRow[convQxUsers_School.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers_SchoolEN.DepartmentName = objRow[convQxUsers_School.DepartmentName].ToString().Trim(); //部门名
objvQxUsers_SchoolEN.DepartmentAbbrName = objRow[convQxUsers_School.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers_School.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers_SchoolEN.DepartmentTypeId = objRow[convQxUsers_School.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers_SchoolEN.DepartmentTypeName = objRow[convQxUsers_School.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers_SchoolEN.UpDepartmentId = objRow[convQxUsers_School.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers_SchoolEN.UpDepartmentName = objRow[convQxUsers_School.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers_School.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers_SchoolEN.UserStateId = objRow[convQxUsers_School.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers_SchoolEN.UserStateName = objRow[convQxUsers_School.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers_SchoolEN.IdentityId = objRow[convQxUsers_School.IdentityId].ToString().Trim(); //身份编号
objvQxUsers_SchoolEN.IdentityDesc = objRow[convQxUsers_School.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers_SchoolEN.CardNo = objRow[convQxUsers_School.CardNo] == DBNull.Value ? null : objRow[convQxUsers_School.CardNo].ToString().Trim(); //卡号
objvQxUsers_SchoolEN.StuTeacherId = objRow[convQxUsers_School.StuTeacherId] == DBNull.Value ? null : objRow[convQxUsers_School.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers_SchoolEN.IdGradeBase = objRow[convQxUsers_School.IdGradeBase] == DBNull.Value ? null : objRow[convQxUsers_School.IdGradeBase].ToString().Trim(); //年级流水号
objvQxUsers_SchoolEN.GradeBaseName = objRow[convQxUsers_School.GradeBaseName].ToString().Trim(); //年级名称
objvQxUsers_SchoolEN.EnterSchoolDate = objRow[convQxUsers_School.EnterSchoolDate] == DBNull.Value ? null : objRow[convQxUsers_School.EnterSchoolDate].ToString().Trim(); //进校日期
objvQxUsers_SchoolEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsOffed].ToString().Trim()); //是否毕业
objvQxUsers_SchoolEN.BeginYearMonth = objRow[convQxUsers_School.BeginYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.BeginYearMonth].ToString().Trim(); //开始年月
objvQxUsers_SchoolEN.EndYearMonth = objRow[convQxUsers_School.EndYearMonth] == DBNull.Value ? null : objRow[convQxUsers_School.EndYearMonth].ToString().Trim(); //结束年月
objvQxUsers_SchoolEN.CardState = objRow[convQxUsers_School.CardState] == DBNull.Value ? null : objRow[convQxUsers_School.CardState].ToString().Trim(); //卡状态
objvQxUsers_SchoolEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers_School.IsLeaved].ToString().Trim()); //IsLeaved
objvQxUsers_SchoolEN.UpdDate = objRow[convQxUsers_School.UpdDate] == DBNull.Value ? null : objRow[convQxUsers_School.UpdDate].ToString().Trim(); //修改日期
objvQxUsers_SchoolEN.UpdUser = objRow[convQxUsers_School.UpdUser] == DBNull.Value ? null : objRow[convQxUsers_School.UpdUser].ToString().Trim(); //修改用户
objvQxUsers_SchoolEN.Memo = objRow[convQxUsers_School.Memo] == DBNull.Value ? null : objRow[convQxUsers_School.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers_SchoolEN.UserId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers_SchoolEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUsers_School(ref clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
bool bolResult = vQxUsers_SchoolDA.GetvQxUsers_School(ref objvQxUsers_SchoolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers_SchoolEN GetObjByUserId(string strUserId)
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
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = vQxUsers_SchoolDA.GetObjByUserId(strUserId);
return objvQxUsers_SchoolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUsers_SchoolEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = vQxUsers_SchoolDA.GetFirstObj(strWhereCond);
 return objvQxUsers_SchoolEN;
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
public static clsvQxUsers_SchoolEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = vQxUsers_SchoolDA.GetObjByDataRow(objRow);
 return objvQxUsers_SchoolEN;
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
public static clsvQxUsers_SchoolEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = vQxUsers_SchoolDA.GetObjByDataRow(objRow);
 return objvQxUsers_SchoolEN;
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
 /// <param name = "lstvQxUsers_SchoolObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsers_SchoolEN GetObjByUserIdFromList(string strUserId, List<clsvQxUsers_SchoolEN> lstvQxUsers_SchoolObjLst)
{
foreach (clsvQxUsers_SchoolEN objvQxUsers_SchoolEN in lstvQxUsers_SchoolObjLst)
{
if (objvQxUsers_SchoolEN.UserId == strUserId)
{
return objvQxUsers_SchoolEN;
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
 strUserId = new clsvQxUsers_SchoolDA().GetFirstID(strWhereCond);
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
 arrList = vQxUsers_SchoolDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUsers_SchoolDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUsers_SchoolDA.IsExist(strUserId);
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
 bolIsExist = clsvQxUsers_SchoolDA.IsExistTable();
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
 bolIsExist = vQxUsers_SchoolDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUsers_SchoolEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
try
{
objvQxUsers_SchoolEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUsers_SchoolEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUsers_School.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UserId = objvQxUsers_SchoolEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUsers_School.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UserName = objvQxUsers_SchoolEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUsers_School.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.DepartmentId = objvQxUsers_SchoolEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUsers_School.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.DepartmentName = objvQxUsers_SchoolEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxUsers_School.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.DepartmentAbbrName = objvQxUsers_SchoolEN.DepartmentAbbrName == "[null]" ? null :  objvQxUsers_SchoolEN.DepartmentAbbrName; //名称缩写
}
if (arrFldSet.Contains(convQxUsers_School.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.DepartmentTypeId = objvQxUsers_SchoolEN.DepartmentTypeId; //部门类型ID
}
if (arrFldSet.Contains(convQxUsers_School.DepartmentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.DepartmentTypeName = objvQxUsers_SchoolEN.DepartmentTypeName; //部门类型名
}
if (arrFldSet.Contains(convQxUsers_School.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UpDepartmentId = objvQxUsers_SchoolEN.UpDepartmentId == "[null]" ? null :  objvQxUsers_SchoolEN.UpDepartmentId; //所属部门号
}
if (arrFldSet.Contains(convQxUsers_School.UpDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UpDepartmentName = objvQxUsers_SchoolEN.UpDepartmentName == "[null]" ? null :  objvQxUsers_SchoolEN.UpDepartmentName; //上级部门
}
if (arrFldSet.Contains(convQxUsers_School.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UserStateId = objvQxUsers_SchoolEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUsers_School.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UserStateName = objvQxUsers_SchoolEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUsers_School.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.IdentityId = objvQxUsers_SchoolEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(convQxUsers_School.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.IdentityDesc = objvQxUsers_SchoolEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUsers_School.CardNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.CardNo = objvQxUsers_SchoolEN.CardNo == "[null]" ? null :  objvQxUsers_SchoolEN.CardNo; //卡号
}
if (arrFldSet.Contains(convQxUsers_School.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.StuTeacherId = objvQxUsers_SchoolEN.StuTeacherId == "[null]" ? null :  objvQxUsers_SchoolEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUsers_School.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.IdGradeBase = objvQxUsers_SchoolEN.IdGradeBase == "[null]" ? null :  objvQxUsers_SchoolEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(convQxUsers_School.GradeBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.GradeBaseName = objvQxUsers_SchoolEN.GradeBaseName; //年级名称
}
if (arrFldSet.Contains(convQxUsers_School.EnterSchoolDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.EnterSchoolDate = objvQxUsers_SchoolEN.EnterSchoolDate == "[null]" ? null :  objvQxUsers_SchoolEN.EnterSchoolDate; //进校日期
}
if (arrFldSet.Contains(convQxUsers_School.IsOffed, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.IsOffed = objvQxUsers_SchoolEN.IsOffed; //是否毕业
}
if (arrFldSet.Contains(convQxUsers_School.BeginYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.BeginYearMonth = objvQxUsers_SchoolEN.BeginYearMonth == "[null]" ? null :  objvQxUsers_SchoolEN.BeginYearMonth; //开始年月
}
if (arrFldSet.Contains(convQxUsers_School.EndYearMonth, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.EndYearMonth = objvQxUsers_SchoolEN.EndYearMonth == "[null]" ? null :  objvQxUsers_SchoolEN.EndYearMonth; //结束年月
}
if (arrFldSet.Contains(convQxUsers_School.CardState, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.CardState = objvQxUsers_SchoolEN.CardState == "[null]" ? null :  objvQxUsers_SchoolEN.CardState; //卡状态
}
if (arrFldSet.Contains(convQxUsers_School.IsLeaved, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.IsLeaved = objvQxUsers_SchoolEN.IsLeaved; //IsLeaved
}
if (arrFldSet.Contains(convQxUsers_School.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UpdDate = objvQxUsers_SchoolEN.UpdDate == "[null]" ? null :  objvQxUsers_SchoolEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUsers_School.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.UpdUser = objvQxUsers_SchoolEN.UpdUser == "[null]" ? null :  objvQxUsers_SchoolEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(convQxUsers_School.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers_SchoolEN.Memo = objvQxUsers_SchoolEN.Memo == "[null]" ? null :  objvQxUsers_SchoolEN.Memo; //备注
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
 /// <param name = "objvQxUsers_SchoolEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
try
{
if (objvQxUsers_SchoolEN.DepartmentAbbrName == "[null]") objvQxUsers_SchoolEN.DepartmentAbbrName = null; //名称缩写
if (objvQxUsers_SchoolEN.UpDepartmentId == "[null]") objvQxUsers_SchoolEN.UpDepartmentId = null; //所属部门号
if (objvQxUsers_SchoolEN.UpDepartmentName == "[null]") objvQxUsers_SchoolEN.UpDepartmentName = null; //上级部门
if (objvQxUsers_SchoolEN.CardNo == "[null]") objvQxUsers_SchoolEN.CardNo = null; //卡号
if (objvQxUsers_SchoolEN.StuTeacherId == "[null]") objvQxUsers_SchoolEN.StuTeacherId = null; //学工号
if (objvQxUsers_SchoolEN.IdGradeBase == "[null]") objvQxUsers_SchoolEN.IdGradeBase = null; //年级流水号
if (objvQxUsers_SchoolEN.EnterSchoolDate == "[null]") objvQxUsers_SchoolEN.EnterSchoolDate = null; //进校日期
if (objvQxUsers_SchoolEN.BeginYearMonth == "[null]") objvQxUsers_SchoolEN.BeginYearMonth = null; //开始年月
if (objvQxUsers_SchoolEN.EndYearMonth == "[null]") objvQxUsers_SchoolEN.EndYearMonth = null; //结束年月
if (objvQxUsers_SchoolEN.CardState == "[null]") objvQxUsers_SchoolEN.CardState = null; //卡状态
if (objvQxUsers_SchoolEN.UpdDate == "[null]") objvQxUsers_SchoolEN.UpdDate = null; //修改日期
if (objvQxUsers_SchoolEN.UpdUser == "[null]") objvQxUsers_SchoolEN.UpdUser = null; //修改用户
if (objvQxUsers_SchoolEN.Memo == "[null]") objvQxUsers_SchoolEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
 vQxUsers_SchoolDA.CheckProperty4Condition(objvQxUsers_SchoolEN);
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
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUsers_SchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsers_SchoolBL没有刷新缓存机制(clsQxUsers_SchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//if (arrvQxUsers_SchoolObjLstCache == null)
//{
//arrvQxUsers_SchoolObjLstCache = vQxUsers_SchoolDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsers_SchoolEN GetObjByUserIdCache(string strUserId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUsers_SchoolEN._CurrTabName);
List<clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLst_Sel =
arrvQxUsers_SchoolObjLstCache
.Where(x=> x.UserId == strUserId 
);
if (arrvQxUsers_SchoolObjLst_Sel.Count() == 0)
{
   clsvQxUsers_SchoolEN obj = clsvQxUsers_SchoolBL.GetObjByUserId(strUserId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUsers_SchoolObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetAllvQxUsers_SchoolObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLstCache = GetObjLstCache(); 
return arrvQxUsers_SchoolObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsers_SchoolEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUsers_SchoolEN._CurrTabName);
List<clsvQxUsers_SchoolEN> arrvQxUsers_SchoolObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUsers_SchoolObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUsers_SchoolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUsers_SchoolEN> lstvQxUsers_SchoolObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUsers_SchoolObjLst, writer);
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
 /// <param name = "lstvQxUsers_SchoolObjLst">[clsvQxUsers_SchoolEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUsers_SchoolEN> lstvQxUsers_SchoolObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUsers_SchoolBL.listXmlNode);
writer.WriteStartElement(clsvQxUsers_SchoolBL.itemsXmlNode);
foreach (clsvQxUsers_SchoolEN objvQxUsers_SchoolEN in lstvQxUsers_SchoolObjLst)
{
clsvQxUsers_SchoolBL.SerializeXML(writer, objvQxUsers_SchoolEN);
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
 /// <param name = "objvQxUsers_SchoolEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
writer.WriteStartElement(clsvQxUsers_SchoolBL.itemXmlNode);
 
if (objvQxUsers_SchoolEN.UserId != null)
{
writer.WriteElementString(convQxUsers_School.UserId, objvQxUsers_SchoolEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.UserName != null)
{
writer.WriteElementString(convQxUsers_School.UserName, objvQxUsers_SchoolEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.DepartmentId != null)
{
writer.WriteElementString(convQxUsers_School.DepartmentId, objvQxUsers_SchoolEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.DepartmentName != null)
{
writer.WriteElementString(convQxUsers_School.DepartmentName, objvQxUsers_SchoolEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.DepartmentAbbrName != null)
{
writer.WriteElementString(convQxUsers_School.DepartmentAbbrName, objvQxUsers_SchoolEN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.DepartmentTypeId != null)
{
writer.WriteElementString(convQxUsers_School.DepartmentTypeId, objvQxUsers_SchoolEN.DepartmentTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.DepartmentTypeName != null)
{
writer.WriteElementString(convQxUsers_School.DepartmentTypeName, objvQxUsers_SchoolEN.DepartmentTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.UpDepartmentId != null)
{
writer.WriteElementString(convQxUsers_School.UpDepartmentId, objvQxUsers_SchoolEN.UpDepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.UpDepartmentName != null)
{
writer.WriteElementString(convQxUsers_School.UpDepartmentName, objvQxUsers_SchoolEN.UpDepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.UserStateId != null)
{
writer.WriteElementString(convQxUsers_School.UserStateId, objvQxUsers_SchoolEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.UserStateName != null)
{
writer.WriteElementString(convQxUsers_School.UserStateName, objvQxUsers_SchoolEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.IdentityId != null)
{
writer.WriteElementString(convQxUsers_School.IdentityId, objvQxUsers_SchoolEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.IdentityDesc != null)
{
writer.WriteElementString(convQxUsers_School.IdentityDesc, objvQxUsers_SchoolEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.CardNo != null)
{
writer.WriteElementString(convQxUsers_School.CardNo, objvQxUsers_SchoolEN.CardNo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.StuTeacherId != null)
{
writer.WriteElementString(convQxUsers_School.StuTeacherId, objvQxUsers_SchoolEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.IdGradeBase != null)
{
writer.WriteElementString(convQxUsers_School.IdGradeBase, objvQxUsers_SchoolEN.IdGradeBase.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.GradeBaseName != null)
{
writer.WriteElementString(convQxUsers_School.GradeBaseName, objvQxUsers_SchoolEN.GradeBaseName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.EnterSchoolDate != null)
{
writer.WriteElementString(convQxUsers_School.EnterSchoolDate, objvQxUsers_SchoolEN.EnterSchoolDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUsers_School.IsOffed, objvQxUsers_SchoolEN.IsOffed.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUsers_SchoolEN.BeginYearMonth != null)
{
writer.WriteElementString(convQxUsers_School.BeginYearMonth, objvQxUsers_SchoolEN.BeginYearMonth.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.EndYearMonth != null)
{
writer.WriteElementString(convQxUsers_School.EndYearMonth, objvQxUsers_SchoolEN.EndYearMonth.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.CardState != null)
{
writer.WriteElementString(convQxUsers_School.CardState, objvQxUsers_SchoolEN.CardState.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUsers_School.IsLeaved, objvQxUsers_SchoolEN.IsLeaved.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUsers_SchoolEN.UpdDate != null)
{
writer.WriteElementString(convQxUsers_School.UpdDate, objvQxUsers_SchoolEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.UpdUser != null)
{
writer.WriteElementString(convQxUsers_School.UpdUser, objvQxUsers_SchoolEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers_SchoolEN.Memo != null)
{
writer.WriteElementString(convQxUsers_School.Memo, objvQxUsers_SchoolEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxUsers_SchoolEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
reader.Read();
while (!(reader.Name == clsvQxUsers_SchoolBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUsers_School.UserId))
{
objvQxUsers_SchoolEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.UserName))
{
objvQxUsers_SchoolEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.DepartmentId))
{
objvQxUsers_SchoolEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.DepartmentName))
{
objvQxUsers_SchoolEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.DepartmentAbbrName))
{
objvQxUsers_SchoolEN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.DepartmentTypeId))
{
objvQxUsers_SchoolEN.DepartmentTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.DepartmentTypeName))
{
objvQxUsers_SchoolEN.DepartmentTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.UpDepartmentId))
{
objvQxUsers_SchoolEN.UpDepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.UpDepartmentName))
{
objvQxUsers_SchoolEN.UpDepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.UserStateId))
{
objvQxUsers_SchoolEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.UserStateName))
{
objvQxUsers_SchoolEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.IdentityId))
{
objvQxUsers_SchoolEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.IdentityDesc))
{
objvQxUsers_SchoolEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.CardNo))
{
objvQxUsers_SchoolEN.CardNo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.StuTeacherId))
{
objvQxUsers_SchoolEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.IdGradeBase))
{
objvQxUsers_SchoolEN.IdGradeBase = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.GradeBaseName))
{
objvQxUsers_SchoolEN.GradeBaseName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.EnterSchoolDate))
{
objvQxUsers_SchoolEN.EnterSchoolDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.IsOffed))
{
objvQxUsers_SchoolEN.IsOffed = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUsers_School.BeginYearMonth))
{
objvQxUsers_SchoolEN.BeginYearMonth = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.EndYearMonth))
{
objvQxUsers_SchoolEN.EndYearMonth = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.CardState))
{
objvQxUsers_SchoolEN.CardState = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.IsLeaved))
{
objvQxUsers_SchoolEN.IsLeaved = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUsers_School.UpdDate))
{
objvQxUsers_SchoolEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.UpdUser))
{
objvQxUsers_SchoolEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers_School.Memo))
{
objvQxUsers_SchoolEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUsers_SchoolEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUsers_SchoolObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUsers_SchoolEN GetObjFromXmlStr(string strvQxUsers_SchoolObjXmlStr)
{
clsvQxUsers_SchoolEN objvQxUsers_SchoolEN = new clsvQxUsers_SchoolEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUsers_SchoolObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUsers_SchoolBL.itemXmlNode))
{
objvQxUsers_SchoolEN = GetObjFromXml(reader);
return objvQxUsers_SchoolEN;
}
}
return objvQxUsers_SchoolEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUsers_SchoolEN);
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
if (strInFldName != convQxUsers_School.UserId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUsers_School.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUsers_School.AttributeName));
throw new Exception(strMsg);
}
var objvQxUsers_School = clsvQxUsers_SchoolBL.GetObjByUserIdCache(strUserId);
if (objvQxUsers_School == null) return "";
return objvQxUsers_School[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUsers_SchoolEN objvQxUsers_SchoolEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUsers_SchoolEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUsers_SchoolEN[strField]);
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
 /// <param name = "lstvQxUsers_SchoolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUsers_SchoolEN> lstvQxUsers_SchoolObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUsers_SchoolObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUsers_SchoolEN objvQxUsers_SchoolEN in lstvQxUsers_SchoolObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUsers_SchoolEN);
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
int intRecCount = clsvQxUsers_SchoolDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUsers_SchoolDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUsers_SchoolDA.GetRecCount();
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
int intRecCount = clsvQxUsers_SchoolDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUsers_SchoolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUsers_SchoolEN objvQxUsers_SchoolCond)
{
List<clsvQxUsers_SchoolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers_SchoolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers_School.AttributeName)
{
if (objvQxUsers_SchoolCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsers_SchoolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers_SchoolCond[strFldName].ToString());
}
else
{
if (objvQxUsers_SchoolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsers_SchoolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers_SchoolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsers_SchoolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsers_SchoolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsers_SchoolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsers_SchoolCond[strFldName]));
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
 List<string> arrList = clsvQxUsers_SchoolDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUsers_SchoolDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUsers_SchoolDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}