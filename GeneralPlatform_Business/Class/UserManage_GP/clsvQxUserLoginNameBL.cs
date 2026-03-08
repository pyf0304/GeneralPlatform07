
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserLoginNameBL
 表名:vQxUserLoginName(00140077)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:51:36
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
public static class  clsvQxUserLoginNameBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserLoginNameEN GetObj(this K_UserLoginName_vQxUserLoginName myKey)
{
clsvQxUserLoginNameEN objvQxUserLoginNameEN = clsvQxUserLoginNameBL.vQxUserLoginNameDA.GetObjByUserLoginName(myKey.Value);
return objvQxUserLoginNameEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserLoginName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserLoginName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserLoginName, 30, convQxUserLoginName.UserLoginName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserLoginName.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserLoginName.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserLoginName.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetDepartmentId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserLoginName.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetDepartmentName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserLoginName.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetDepartmentAbbrName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUserLoginName.DepartmentAbbrName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserStateId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserLoginName.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserLoginName.UserStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetUserStateName(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strUserStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserLoginName.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetPassword(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUserLoginName.Password);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetEffitiveBeginDate(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUserLoginName.EffitiveBeginDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetEffitiveEndDate(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strEffitiveEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUserLoginName.EffitiveEndDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetStuTeacherId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strStuTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUserLoginName.StuTeacherId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetIdentityId(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUserLoginName.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUserLoginName.IdentityId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetIdentityDesc(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strIdentityDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserLoginName.IdentityDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserLoginNameEN SetMemo(this clsvQxUserLoginNameEN objvQxUserLoginNameEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserLoginName.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserLoginNameENS">源对象</param>
 /// <param name = "objvQxUserLoginNameENT">目标对象</param>
 public static void CopyTo(this clsvQxUserLoginNameEN objvQxUserLoginNameENS, clsvQxUserLoginNameEN objvQxUserLoginNameENT)
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
 /// <param name = "objvQxUserLoginNameENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserLoginNameEN:objvQxUserLoginNameENT</returns>
 public static clsvQxUserLoginNameEN CopyTo(this clsvQxUserLoginNameEN objvQxUserLoginNameENS)
{
try
{
 clsvQxUserLoginNameEN objvQxUserLoginNameENT = new clsvQxUserLoginNameEN()
{
UserLoginName = objvQxUserLoginNameENS.UserLoginName, //用户登录名
UserId = objvQxUserLoginNameENS.UserId, //用户ID
UserName = objvQxUserLoginNameENS.UserName, //用户名
DepartmentId = objvQxUserLoginNameENS.DepartmentId, //部门Id
DepartmentName = objvQxUserLoginNameENS.DepartmentName, //部门名
DepartmentAbbrName = objvQxUserLoginNameENS.DepartmentAbbrName, //名称缩写
UserStateId = objvQxUserLoginNameENS.UserStateId, //用户状态Id
UserStateName = objvQxUserLoginNameENS.UserStateName, //用户状态名
Password = objvQxUserLoginNameENS.Password, //口令
EffitiveBeginDate = objvQxUserLoginNameENS.EffitiveBeginDate, //有效开始日期
EffitiveEndDate = objvQxUserLoginNameENS.EffitiveEndDate, //有效结束日期
StuTeacherId = objvQxUserLoginNameENS.StuTeacherId, //学工号
IdentityId = objvQxUserLoginNameENS.IdentityId, //身份编号
IdentityDesc = objvQxUserLoginNameENS.IdentityDesc, //身份描述
Memo = objvQxUserLoginNameENS.Memo, //备注
};
 return objvQxUserLoginNameENT;
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
public static void CheckProperty4Condition(this clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
 clsvQxUserLoginNameBL.vQxUserLoginNameDA.CheckProperty4Condition(objvQxUserLoginNameEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserLoginName
{
public virtual bool UpdRelaTabDate(string strUserLoginName, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vUserLoginName(vQxUserLoginName)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserLoginNameBL
{
public static RelatedActions_vQxUserLoginName relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserLoginNameListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserLoginNameList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserLoginNameDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserLoginNameDA vQxUserLoginNameDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserLoginNameDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserLoginNameBL()
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
if (string.IsNullOrEmpty(clsvQxUserLoginNameEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserLoginNameEN._ConnectString);
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
objDS = vQxUserLoginNameDA.GetDataSet(strWhereCond);
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
objDS = vQxUserLoginNameDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserLoginNameDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserLoginName(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserLoginNameDA.GetDataTable_vQxUserLoginName(strWhereCond);
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
objDT = vQxUserLoginNameDA.GetDataTable(strWhereCond);
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
objDT = vQxUserLoginNameDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserLoginNameDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserLoginNameDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserLoginNameDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserLoginNameDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserLoginNameDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserLoginNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserLoginNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserLoginNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserLoginNameDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserLoginNameDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserLoginNameDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrUserLoginNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLstByUserLoginNameLst(List<string> arrUserLoginNameLst)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserLoginNameLst, true);
 string strWhereCond = string.Format("UserLoginName in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserLoginNameLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserLoginNameEN> GetObjLstByUserLoginNameLstCache(List<string> arrUserLoginNameLst)
{
string strKey = string.Format("{0}", clsvQxUserLoginNameEN._CurrTabName);
List<clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLst_Sel =
arrvQxUserLoginNameObjLstCache
.Where(x => arrUserLoginNameLst.Contains(x.UserLoginName));
return arrvQxUserLoginNameObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public static List<clsvQxUserLoginNameEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserLoginNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserLoginNameEN> GetSubObjLstCache(clsvQxUserLoginNameEN objvQxUserLoginNameCond)
{
List<clsvQxUserLoginNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserLoginNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserLoginName.AttributeName)
{
if (objvQxUserLoginNameCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserLoginNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserLoginNameCond[strFldName].ToString());
}
else
{
if (objvQxUserLoginNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserLoginNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserLoginNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserLoginNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserLoginNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserLoginNameCond[strFldName]));
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
public static List<clsvQxUserLoginNameEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public static List<clsvQxUserLoginNameEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
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
List<clsvQxUserLoginNameEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserLoginNameEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserLoginNameEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
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
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public static List<clsvQxUserLoginNameEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserLoginNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public static List<clsvQxUserLoginNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public static IEnumerable<clsvQxUserLoginNameEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserLoginNameEN objvQxUserLoginNameCond, string strOrderBy)
{
List<clsvQxUserLoginNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserLoginNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserLoginName.AttributeName)
{
if (objvQxUserLoginNameCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserLoginNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserLoginNameCond[strFldName].ToString());
}
else
{
if (objvQxUserLoginNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserLoginNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserLoginNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserLoginNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserLoginNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserLoginNameCond[strFldName]));
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
public static IEnumerable<clsvQxUserLoginNameEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserLoginNameEN objvQxUserLoginNameCond = JsonConvert.DeserializeObject<clsvQxUserLoginNameEN>(objPagerPara.whereCond);
if (objvQxUserLoginNameCond.sfFldComparisonOp == null)
{
objvQxUserLoginNameCond.dicFldComparisonOp = null;
}
else
{
objvQxUserLoginNameCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserLoginNameCond.sfFldComparisonOp);
}
clsvQxUserLoginNameBL.SetUpdFlag(objvQxUserLoginNameCond);
 try
{
CheckProperty4Condition(objvQxUserLoginNameCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserLoginNameBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserLoginNameCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserLoginNameEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
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
public static List<clsvQxUserLoginNameEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserLoginNameEN> arrObjLst = new List<clsvQxUserLoginNameEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
try
{
objvQxUserLoginNameEN.UserLoginName = objRow[convQxUserLoginName.UserLoginName].ToString().Trim(); //用户登录名
objvQxUserLoginNameEN.UserId = objRow[convQxUserLoginName.UserId].ToString().Trim(); //用户ID
objvQxUserLoginNameEN.UserName = objRow[convQxUserLoginName.UserName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserName].ToString().Trim(); //用户名
objvQxUserLoginNameEN.DepartmentId = objRow[convQxUserLoginName.DepartmentId] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentId].ToString().Trim(); //部门Id
objvQxUserLoginNameEN.DepartmentName = objRow[convQxUserLoginName.DepartmentName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentName].ToString().Trim(); //部门名
objvQxUserLoginNameEN.DepartmentAbbrName = objRow[convQxUserLoginName.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUserLoginName.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUserLoginNameEN.UserStateId = objRow[convQxUserLoginName.UserStateId] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserLoginNameEN.UserStateName = objRow[convQxUserLoginName.UserStateName] == DBNull.Value ? null : objRow[convQxUserLoginName.UserStateName].ToString().Trim(); //用户状态名
objvQxUserLoginNameEN.Password = objRow[convQxUserLoginName.Password] == DBNull.Value ? null : objRow[convQxUserLoginName.Password].ToString().Trim(); //口令
objvQxUserLoginNameEN.EffitiveBeginDate = objRow[convQxUserLoginName.EffitiveBeginDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUserLoginNameEN.EffitiveEndDate = objRow[convQxUserLoginName.EffitiveEndDate] == DBNull.Value ? null : objRow[convQxUserLoginName.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUserLoginNameEN.StuTeacherId = objRow[convQxUserLoginName.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserLoginName.StuTeacherId].ToString().Trim(); //学工号
objvQxUserLoginNameEN.IdentityId = objRow[convQxUserLoginName.IdentityId] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityId].ToString().Trim(); //身份编号
objvQxUserLoginNameEN.IdentityDesc = objRow[convQxUserLoginName.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserLoginName.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserLoginNameEN.Memo = objRow[convQxUserLoginName.Memo] == DBNull.Value ? null : objRow[convQxUserLoginName.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserLoginNameEN.UserLoginName, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserLoginNameEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserLoginName(ref clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
bool bolResult = vQxUserLoginNameDA.GetvQxUserLoginName(ref objvQxUserLoginNameEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserLoginName">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserLoginNameEN GetObjByUserLoginName(string strUserLoginName)
{
if (strUserLoginName.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserLoginName]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserLoginName) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserLoginName]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxUserLoginNameEN objvQxUserLoginNameEN = vQxUserLoginNameDA.GetObjByUserLoginName(strUserLoginName);
return objvQxUserLoginNameEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserLoginNameEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserLoginNameEN objvQxUserLoginNameEN = vQxUserLoginNameDA.GetFirstObj(strWhereCond);
 return objvQxUserLoginNameEN;
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
public static clsvQxUserLoginNameEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserLoginNameEN objvQxUserLoginNameEN = vQxUserLoginNameDA.GetObjByDataRow(objRow);
 return objvQxUserLoginNameEN;
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
public static clsvQxUserLoginNameEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserLoginNameEN objvQxUserLoginNameEN = vQxUserLoginNameDA.GetObjByDataRow(objRow);
 return objvQxUserLoginNameEN;
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
 /// <param name = "strUserLoginName">所给的关键字</param>
 /// <param name = "lstvQxUserLoginNameObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserLoginNameEN GetObjByUserLoginNameFromList(string strUserLoginName, List<clsvQxUserLoginNameEN> lstvQxUserLoginNameObjLst)
{
foreach (clsvQxUserLoginNameEN objvQxUserLoginNameEN in lstvQxUserLoginNameObjLst)
{
if (objvQxUserLoginNameEN.UserLoginName == strUserLoginName)
{
return objvQxUserLoginNameEN;
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
 string strUserLoginName;
 try
 {
 strUserLoginName = new clsvQxUserLoginNameDA().GetFirstID(strWhereCond);
 return strUserLoginName;
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
 arrList = vQxUserLoginNameDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserLoginNameDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserLoginName">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserLoginName)
{
if (string.IsNullOrEmpty(strUserLoginName) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserLoginName]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxUserLoginNameDA.IsExist(strUserLoginName);
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
 bolIsExist = clsvQxUserLoginNameDA.IsExistTable();
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
 bolIsExist = vQxUserLoginNameDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserLoginNameEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
try
{
objvQxUserLoginNameEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserLoginNameEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserLoginName.UserLoginName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.UserLoginName = objvQxUserLoginNameEN.UserLoginName; //用户登录名
}
if (arrFldSet.Contains(convQxUserLoginName.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.UserId = objvQxUserLoginNameEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUserLoginName.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.UserName = objvQxUserLoginNameEN.UserName == "[null]" ? null :  objvQxUserLoginNameEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUserLoginName.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.DepartmentId = objvQxUserLoginNameEN.DepartmentId == "[null]" ? null :  objvQxUserLoginNameEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUserLoginName.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.DepartmentName = objvQxUserLoginNameEN.DepartmentName == "[null]" ? null :  objvQxUserLoginNameEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxUserLoginName.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.DepartmentAbbrName = objvQxUserLoginNameEN.DepartmentAbbrName == "[null]" ? null :  objvQxUserLoginNameEN.DepartmentAbbrName; //名称缩写
}
if (arrFldSet.Contains(convQxUserLoginName.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.UserStateId = objvQxUserLoginNameEN.UserStateId == "[null]" ? null :  objvQxUserLoginNameEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUserLoginName.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.UserStateName = objvQxUserLoginNameEN.UserStateName == "[null]" ? null :  objvQxUserLoginNameEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUserLoginName.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.Password = objvQxUserLoginNameEN.Password == "[null]" ? null :  objvQxUserLoginNameEN.Password; //口令
}
if (arrFldSet.Contains(convQxUserLoginName.EffitiveBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.EffitiveBeginDate = objvQxUserLoginNameEN.EffitiveBeginDate == "[null]" ? null :  objvQxUserLoginNameEN.EffitiveBeginDate; //有效开始日期
}
if (arrFldSet.Contains(convQxUserLoginName.EffitiveEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.EffitiveEndDate = objvQxUserLoginNameEN.EffitiveEndDate == "[null]" ? null :  objvQxUserLoginNameEN.EffitiveEndDate; //有效结束日期
}
if (arrFldSet.Contains(convQxUserLoginName.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.StuTeacherId = objvQxUserLoginNameEN.StuTeacherId == "[null]" ? null :  objvQxUserLoginNameEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUserLoginName.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.IdentityId = objvQxUserLoginNameEN.IdentityId == "[null]" ? null :  objvQxUserLoginNameEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(convQxUserLoginName.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.IdentityDesc = objvQxUserLoginNameEN.IdentityDesc == "[null]" ? null :  objvQxUserLoginNameEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUserLoginName.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserLoginNameEN.Memo = objvQxUserLoginNameEN.Memo == "[null]" ? null :  objvQxUserLoginNameEN.Memo; //备注
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
 /// <param name = "objvQxUserLoginNameEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
try
{
if (objvQxUserLoginNameEN.UserName == "[null]") objvQxUserLoginNameEN.UserName = null; //用户名
if (objvQxUserLoginNameEN.DepartmentId == "[null]") objvQxUserLoginNameEN.DepartmentId = null; //部门Id
if (objvQxUserLoginNameEN.DepartmentName == "[null]") objvQxUserLoginNameEN.DepartmentName = null; //部门名
if (objvQxUserLoginNameEN.DepartmentAbbrName == "[null]") objvQxUserLoginNameEN.DepartmentAbbrName = null; //名称缩写
if (objvQxUserLoginNameEN.UserStateId == "[null]") objvQxUserLoginNameEN.UserStateId = null; //用户状态Id
if (objvQxUserLoginNameEN.UserStateName == "[null]") objvQxUserLoginNameEN.UserStateName = null; //用户状态名
if (objvQxUserLoginNameEN.Password == "[null]") objvQxUserLoginNameEN.Password = null; //口令
if (objvQxUserLoginNameEN.EffitiveBeginDate == "[null]") objvQxUserLoginNameEN.EffitiveBeginDate = null; //有效开始日期
if (objvQxUserLoginNameEN.EffitiveEndDate == "[null]") objvQxUserLoginNameEN.EffitiveEndDate = null; //有效结束日期
if (objvQxUserLoginNameEN.StuTeacherId == "[null]") objvQxUserLoginNameEN.StuTeacherId = null; //学工号
if (objvQxUserLoginNameEN.IdentityId == "[null]") objvQxUserLoginNameEN.IdentityId = null; //身份编号
if (objvQxUserLoginNameEN.IdentityDesc == "[null]") objvQxUserLoginNameEN.IdentityDesc = null; //身份描述
if (objvQxUserLoginNameEN.Memo == "[null]") objvQxUserLoginNameEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
 vQxUserLoginNameDA.CheckProperty4Condition(objvQxUserLoginNameEN);
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
if (clsQxUserLoginNameBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserLoginNameBL没有刷新缓存机制(clsQxUserLoginNameBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by UserLoginName");
//if (arrvQxUserLoginNameObjLstCache == null)
//{
//arrvQxUserLoginNameObjLstCache = vQxUserLoginNameDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserLoginName">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserLoginNameEN GetObjByUserLoginNameCache(string strUserLoginName)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserLoginNameEN._CurrTabName);
List<clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLst_Sel =
arrvQxUserLoginNameObjLstCache
.Where(x=> x.UserLoginName == strUserLoginName 
);
if (arrvQxUserLoginNameObjLst_Sel.Count() == 0)
{
   clsvQxUserLoginNameEN obj = clsvQxUserLoginNameBL.GetObjByUserLoginName(strUserLoginName);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserLoginNameObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetAllvQxUserLoginNameObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLstCache = GetObjLstCache(); 
return arrvQxUserLoginNameObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserLoginNameEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserLoginNameEN._CurrTabName);
List<clsvQxUserLoginNameEN> arrvQxUserLoginNameObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserLoginNameObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUserLoginNameObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserLoginNameEN> lstvQxUserLoginNameObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserLoginNameObjLst, writer);
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
 /// <param name = "lstvQxUserLoginNameObjLst">[clsvQxUserLoginNameEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserLoginNameEN> lstvQxUserLoginNameObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserLoginNameBL.listXmlNode);
writer.WriteStartElement(clsvQxUserLoginNameBL.itemsXmlNode);
foreach (clsvQxUserLoginNameEN objvQxUserLoginNameEN in lstvQxUserLoginNameObjLst)
{
clsvQxUserLoginNameBL.SerializeXML(writer, objvQxUserLoginNameEN);
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
 /// <param name = "objvQxUserLoginNameEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
writer.WriteStartElement(clsvQxUserLoginNameBL.itemXmlNode);
 
if (objvQxUserLoginNameEN.UserLoginName != null)
{
writer.WriteElementString(convQxUserLoginName.UserLoginName, objvQxUserLoginNameEN.UserLoginName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.UserId != null)
{
writer.WriteElementString(convQxUserLoginName.UserId, objvQxUserLoginNameEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.UserName != null)
{
writer.WriteElementString(convQxUserLoginName.UserName, objvQxUserLoginNameEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.DepartmentId != null)
{
writer.WriteElementString(convQxUserLoginName.DepartmentId, objvQxUserLoginNameEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.DepartmentName != null)
{
writer.WriteElementString(convQxUserLoginName.DepartmentName, objvQxUserLoginNameEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.DepartmentAbbrName != null)
{
writer.WriteElementString(convQxUserLoginName.DepartmentAbbrName, objvQxUserLoginNameEN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.UserStateId != null)
{
writer.WriteElementString(convQxUserLoginName.UserStateId, objvQxUserLoginNameEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.UserStateName != null)
{
writer.WriteElementString(convQxUserLoginName.UserStateName, objvQxUserLoginNameEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.Password != null)
{
writer.WriteElementString(convQxUserLoginName.Password, objvQxUserLoginNameEN.Password.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.EffitiveBeginDate != null)
{
writer.WriteElementString(convQxUserLoginName.EffitiveBeginDate, objvQxUserLoginNameEN.EffitiveBeginDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.EffitiveEndDate != null)
{
writer.WriteElementString(convQxUserLoginName.EffitiveEndDate, objvQxUserLoginNameEN.EffitiveEndDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.StuTeacherId != null)
{
writer.WriteElementString(convQxUserLoginName.StuTeacherId, objvQxUserLoginNameEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.IdentityId != null)
{
writer.WriteElementString(convQxUserLoginName.IdentityId, objvQxUserLoginNameEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.IdentityDesc != null)
{
writer.WriteElementString(convQxUserLoginName.IdentityDesc, objvQxUserLoginNameEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserLoginNameEN.Memo != null)
{
writer.WriteElementString(convQxUserLoginName.Memo, objvQxUserLoginNameEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxUserLoginNameEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
reader.Read();
while (!(reader.Name == clsvQxUserLoginNameBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserLoginName.UserLoginName))
{
objvQxUserLoginNameEN.UserLoginName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.UserId))
{
objvQxUserLoginNameEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.UserName))
{
objvQxUserLoginNameEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.DepartmentId))
{
objvQxUserLoginNameEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.DepartmentName))
{
objvQxUserLoginNameEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.DepartmentAbbrName))
{
objvQxUserLoginNameEN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.UserStateId))
{
objvQxUserLoginNameEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.UserStateName))
{
objvQxUserLoginNameEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.Password))
{
objvQxUserLoginNameEN.Password = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.EffitiveBeginDate))
{
objvQxUserLoginNameEN.EffitiveBeginDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.EffitiveEndDate))
{
objvQxUserLoginNameEN.EffitiveEndDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.StuTeacherId))
{
objvQxUserLoginNameEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.IdentityId))
{
objvQxUserLoginNameEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.IdentityDesc))
{
objvQxUserLoginNameEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserLoginName.Memo))
{
objvQxUserLoginNameEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUserLoginNameEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserLoginNameObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserLoginNameEN GetObjFromXmlStr(string strvQxUserLoginNameObjXmlStr)
{
clsvQxUserLoginNameEN objvQxUserLoginNameEN = new clsvQxUserLoginNameEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserLoginNameObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserLoginNameBL.itemXmlNode))
{
objvQxUserLoginNameEN = GetObjFromXml(reader);
return objvQxUserLoginNameEN;
}
}
return objvQxUserLoginNameEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserLoginNameEN);
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
public static string Func(string strInFldName, string strOutFldName, string strUserLoginName)
{
if (strInFldName != convQxUserLoginName.UserLoginName)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserLoginName.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserLoginName.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserLoginName = clsvQxUserLoginNameBL.GetObjByUserLoginNameCache(strUserLoginName);
if (objvQxUserLoginName == null) return "";
return objvQxUserLoginName[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserLoginNameEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserLoginNameEN objvQxUserLoginNameEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserLoginNameEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserLoginNameEN[strField]);
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
 /// <param name = "lstvQxUserLoginNameObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserLoginNameEN> lstvQxUserLoginNameObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserLoginNameObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserLoginNameEN objvQxUserLoginNameEN in lstvQxUserLoginNameObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserLoginNameEN);
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
int intRecCount = clsvQxUserLoginNameDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserLoginNameDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserLoginNameDA.GetRecCount();
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
int intRecCount = clsvQxUserLoginNameDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserLoginNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserLoginNameEN objvQxUserLoginNameCond)
{
List<clsvQxUserLoginNameEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserLoginNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserLoginName.AttributeName)
{
if (objvQxUserLoginNameCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserLoginNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserLoginNameCond[strFldName].ToString());
}
else
{
if (objvQxUserLoginNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserLoginNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserLoginNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserLoginNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserLoginNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserLoginNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserLoginNameCond[strFldName]));
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
 List<string> arrList = clsvQxUserLoginNameDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserLoginNameDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserLoginNameDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}