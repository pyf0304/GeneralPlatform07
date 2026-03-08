
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjUserRelationByRoleBL
 表名:vQxPrjUserRelationByRole(00140076)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:48:58
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
public static class  clsvQxPrjUserRelationByRoleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelationByRoleEN GetObj(this K_mId_vQxPrjUserRelationByRole myKey)
{
clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = clsvQxPrjUserRelationByRoleBL.vQxPrjUserRelationByRoleDA.GetObjBymId(myKey.Value);
return objvQxPrjUserRelationByRoleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetmId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, long lngmId, string strComparisonOp="")
	{
objvQxPrjUserRelationByRoleEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.mId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.mId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.mId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetQxPrjId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjUserRelationByRole.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjUserRelationByRole.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjUserRelationByRole.QxPrjId);
}
objvQxPrjUserRelationByRoleEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.QxPrjId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetIdentityId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxPrjUserRelationByRole.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxPrjUserRelationByRole.IdentityId);
}
objvQxPrjUserRelationByRoleEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.IdentityId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.IdentityId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetRoleId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxPrjUserRelationByRole.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxPrjUserRelationByRole.RoleId);
}
objvQxPrjUserRelationByRoleEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.RoleId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.RoleId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetRoleName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strRoleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxPrjUserRelationByRole.RoleName);
}
objvQxPrjUserRelationByRoleEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.RoleName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.RoleName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetPrjName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjUserRelationByRole.PrjName);
}
objvQxPrjUserRelationByRoleEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.PrjName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.PrjName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.PrjName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetUserId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxPrjUserRelationByRole.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxPrjUserRelationByRole.UserId);
}
objvQxPrjUserRelationByRoleEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.UserId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.UserId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.UserId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetUserName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxPrjUserRelationByRole.UserName);
}
objvQxPrjUserRelationByRoleEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.UserName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.UserName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.UserName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetDepartmentId(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxPrjUserRelationByRole.DepartmentId);
}
objvQxPrjUserRelationByRoleEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.DepartmentId) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.DepartmentId, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentId] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetDepartmentName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxPrjUserRelationByRole.DepartmentName);
}
objvQxPrjUserRelationByRoleEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.DepartmentName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.DepartmentName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetUserStateName(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strUserStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxPrjUserRelationByRole.UserStateName);
}
objvQxPrjUserRelationByRoleEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.UserStateName) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.UserStateName, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.UserStateName] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationByRoleEN SetIdentityDesc(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN, string strIdentityDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxPrjUserRelationByRole.IdentityDesc);
}
objvQxPrjUserRelationByRoleEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelationByRole.IdentityDesc) == false)
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp.Add(convQxPrjUserRelationByRole.IdentityDesc, strComparisonOp);
}
else
{
objvQxPrjUserRelationByRoleEN.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityDesc] = strComparisonOp;
}
}
return objvQxPrjUserRelationByRoleEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleENS">源对象</param>
 /// <param name = "objvQxPrjUserRelationByRoleENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENS, clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENT)
{
try
{
objvQxPrjUserRelationByRoleENT.mId = objvQxPrjUserRelationByRoleENS.mId; //流水号
objvQxPrjUserRelationByRoleENT.QxPrjId = objvQxPrjUserRelationByRoleENS.QxPrjId; //项目Id
objvQxPrjUserRelationByRoleENT.IdentityId = objvQxPrjUserRelationByRoleENS.IdentityId; //身份编号
objvQxPrjUserRelationByRoleENT.RoleId = objvQxPrjUserRelationByRoleENS.RoleId; //角色Id
objvQxPrjUserRelationByRoleENT.RoleName = objvQxPrjUserRelationByRoleENS.RoleName; //角色名称
objvQxPrjUserRelationByRoleENT.PrjName = objvQxPrjUserRelationByRoleENS.PrjName; //工程名
objvQxPrjUserRelationByRoleENT.UserId = objvQxPrjUserRelationByRoleENS.UserId; //用户ID
objvQxPrjUserRelationByRoleENT.UserName = objvQxPrjUserRelationByRoleENS.UserName; //用户名
objvQxPrjUserRelationByRoleENT.DepartmentId = objvQxPrjUserRelationByRoleENS.DepartmentId; //部门Id
objvQxPrjUserRelationByRoleENT.DepartmentName = objvQxPrjUserRelationByRoleENS.DepartmentName; //部门名
objvQxPrjUserRelationByRoleENT.UserStateName = objvQxPrjUserRelationByRoleENS.UserStateName; //用户状态名
objvQxPrjUserRelationByRoleENT.IdentityDesc = objvQxPrjUserRelationByRoleENS.IdentityDesc; //身份描述
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
 /// <param name = "objvQxPrjUserRelationByRoleENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjUserRelationByRoleEN:objvQxPrjUserRelationByRoleENT</returns>
 public static clsvQxPrjUserRelationByRoleEN CopyTo(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENS)
{
try
{
 clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENT = new clsvQxPrjUserRelationByRoleEN()
{
mId = objvQxPrjUserRelationByRoleENS.mId, //流水号
QxPrjId = objvQxPrjUserRelationByRoleENS.QxPrjId, //项目Id
IdentityId = objvQxPrjUserRelationByRoleENS.IdentityId, //身份编号
RoleId = objvQxPrjUserRelationByRoleENS.RoleId, //角色Id
RoleName = objvQxPrjUserRelationByRoleENS.RoleName, //角色名称
PrjName = objvQxPrjUserRelationByRoleENS.PrjName, //工程名
UserId = objvQxPrjUserRelationByRoleENS.UserId, //用户ID
UserName = objvQxPrjUserRelationByRoleENS.UserName, //用户名
DepartmentId = objvQxPrjUserRelationByRoleENS.DepartmentId, //部门Id
DepartmentName = objvQxPrjUserRelationByRoleENS.DepartmentName, //部门名
UserStateName = objvQxPrjUserRelationByRoleENS.UserStateName, //用户状态名
IdentityDesc = objvQxPrjUserRelationByRoleENS.IdentityDesc, //身份描述
};
 return objvQxPrjUserRelationByRoleENT;
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
public static void CheckProperty4Condition(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
 clsvQxPrjUserRelationByRoleBL.vQxPrjUserRelationByRoleDA.CheckProperty4Condition(objvQxPrjUserRelationByRoleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.mId) == true)
{
string strComparisonOpmId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjUserRelationByRole.mId, objvQxPrjUserRelationByRoleCond.mId, strComparisonOpmId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.QxPrjId, objvQxPrjUserRelationByRoleCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.IdentityId, objvQxPrjUserRelationByRoleCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.RoleId) == true)
{
string strComparisonOpRoleId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.RoleId, objvQxPrjUserRelationByRoleCond.RoleId, strComparisonOpRoleId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.RoleName) == true)
{
string strComparisonOpRoleName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.RoleName, objvQxPrjUserRelationByRoleCond.RoleName, strComparisonOpRoleName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.PrjName, objvQxPrjUserRelationByRoleCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.UserId) == true)
{
string strComparisonOpUserId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.UserId, objvQxPrjUserRelationByRoleCond.UserId, strComparisonOpUserId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.UserName) == true)
{
string strComparisonOpUserName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.UserName, objvQxPrjUserRelationByRoleCond.UserName, strComparisonOpUserName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.DepartmentId, objvQxPrjUserRelationByRoleCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.DepartmentName, objvQxPrjUserRelationByRoleCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.UserStateName, objvQxPrjUserRelationByRoleCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxPrjUserRelationByRoleCond.IsUpdated(convQxPrjUserRelationByRole.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[convQxPrjUserRelationByRole.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelationByRole.IdentityDesc, objvQxPrjUserRelationByRoleCond.IdentityDesc, strComparisonOpIdentityDesc);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjUserRelationByRole
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程用户关系ByRole(vQxPrjUserRelationByRole)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjUserRelationByRoleBL
{
public static RelatedActions_vQxPrjUserRelationByRole relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjUserRelationByRoleListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjUserRelationByRoleList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjUserRelationByRoleEN> arrvQxPrjUserRelationByRoleObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjUserRelationByRoleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjUserRelationByRoleDA vQxPrjUserRelationByRoleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjUserRelationByRoleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjUserRelationByRoleBL()
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
if (string.IsNullOrEmpty(clsvQxPrjUserRelationByRoleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjUserRelationByRoleEN._ConnectString);
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
objDS = vQxPrjUserRelationByRoleDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjUserRelationByRoleDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjUserRelationByRoleDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjUserRelationByRole(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjUserRelationByRoleDA.GetDataTable_vQxPrjUserRelationByRole(strWhereCond);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjUserRelationByRoleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjUserRelationByRoleEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjUserRelationByRoleEN._CurrTabName);
List<clsvQxPrjUserRelationByRoleEN> arrvQxPrjUserRelationByRoleObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationByRoleEN> arrvQxPrjUserRelationByRoleObjLst_Sel =
arrvQxPrjUserRelationByRoleObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxPrjUserRelationByRoleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjUserRelationByRoleEN> GetSubObjLstCache(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleCond)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationByRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelationByRole.AttributeName)
{
if (objvQxPrjUserRelationByRoleCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelationByRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationByRoleCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelationByRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationByRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelationByRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationByRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationByRoleCond[strFldName]));
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
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
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjUserRelationByRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
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
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
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
public static IEnumerable<clsvQxPrjUserRelationByRoleEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleCond, string strOrderBy)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationByRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelationByRole.AttributeName)
{
if (objvQxPrjUserRelationByRoleCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelationByRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationByRoleCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelationByRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationByRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelationByRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationByRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationByRoleCond[strFldName]));
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
public static IEnumerable<clsvQxPrjUserRelationByRoleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleCond = JsonConvert.DeserializeObject<clsvQxPrjUserRelationByRoleEN>(objPagerPara.whereCond);
if (objvQxPrjUserRelationByRoleCond.sfFldComparisonOp == null)
{
objvQxPrjUserRelationByRoleCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjUserRelationByRoleCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjUserRelationByRoleCond.sfFldComparisonOp);
}
clsvQxPrjUserRelationByRoleBL.SetUpdFlag(objvQxPrjUserRelationByRoleCond);
 try
{
CheckProperty4Condition(objvQxPrjUserRelationByRoleCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjUserRelationByRoleBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjUserRelationByRoleCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
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
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLst = new List<clsvQxPrjUserRelationByRoleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
try
{
objvQxPrjUserRelationByRoleEN.mId = Int32.Parse(objRow[convQxPrjUserRelationByRole.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationByRoleEN.QxPrjId = objRow[convQxPrjUserRelationByRole.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationByRoleEN.IdentityId = objRow[convQxPrjUserRelationByRole.IdentityId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityId].ToString().Trim(); //身份编号
objvQxPrjUserRelationByRoleEN.RoleId = objRow[convQxPrjUserRelationByRole.RoleId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleId].ToString().Trim(); //角色Id
objvQxPrjUserRelationByRoleEN.RoleName = objRow[convQxPrjUserRelationByRole.RoleName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.RoleName].ToString().Trim(); //角色名称
objvQxPrjUserRelationByRoleEN.PrjName = objRow[convQxPrjUserRelationByRole.PrjName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationByRoleEN.UserId = objRow[convQxPrjUserRelationByRole.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationByRoleEN.UserName = objRow[convQxPrjUserRelationByRole.UserName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationByRoleEN.DepartmentId = objRow[convQxPrjUserRelationByRole.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationByRoleEN.DepartmentName = objRow[convQxPrjUserRelationByRole.DepartmentName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationByRoleEN.UserStateName = objRow[convQxPrjUserRelationByRole.UserStateName] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationByRoleEN.IdentityDesc = objRow[convQxPrjUserRelationByRole.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelationByRole.IdentityDesc].ToString().Trim(); //身份描述
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationByRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationByRoleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjUserRelationByRole(ref clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
bool bolResult = vQxPrjUserRelationByRoleDA.GetvQxPrjUserRelationByRole(ref objvQxPrjUserRelationByRoleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelationByRoleEN GetObjBymId(long lngmId)
{
clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = vQxPrjUserRelationByRoleDA.GetObjBymId(lngmId);
return objvQxPrjUserRelationByRoleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjUserRelationByRoleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = vQxPrjUserRelationByRoleDA.GetFirstObj(strWhereCond);
 return objvQxPrjUserRelationByRoleEN;
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
public static clsvQxPrjUserRelationByRoleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = vQxPrjUserRelationByRoleDA.GetObjByDataRow(objRow);
 return objvQxPrjUserRelationByRoleEN;
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
public static clsvQxPrjUserRelationByRoleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = vQxPrjUserRelationByRoleDA.GetObjByDataRow(objRow);
 return objvQxPrjUserRelationByRoleEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvQxPrjUserRelationByRoleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjUserRelationByRoleEN GetObjBymIdFromList(long lngmId, List<clsvQxPrjUserRelationByRoleEN> lstvQxPrjUserRelationByRoleObjLst)
{
foreach (clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN in lstvQxPrjUserRelationByRoleObjLst)
{
if (objvQxPrjUserRelationByRoleEN.mId == lngmId)
{
return objvQxPrjUserRelationByRoleEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvQxPrjUserRelationByRoleDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vQxPrjUserRelationByRoleDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjUserRelationByRoleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vQxPrjUserRelationByRoleDA.IsExist(lngmId);
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
 bolIsExist = clsvQxPrjUserRelationByRoleDA.IsExistTable();
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
 bolIsExist = vQxPrjUserRelationByRoleDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjUserRelationByRoleENS">源对象</param>
 /// <param name = "objvQxPrjUserRelationByRoleENT">目标对象</param>
 public static void CopyTo(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENS, clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleENT)
{
try
{
objvQxPrjUserRelationByRoleENT.mId = objvQxPrjUserRelationByRoleENS.mId; //流水号
objvQxPrjUserRelationByRoleENT.QxPrjId = objvQxPrjUserRelationByRoleENS.QxPrjId; //项目Id
objvQxPrjUserRelationByRoleENT.IdentityId = objvQxPrjUserRelationByRoleENS.IdentityId; //身份编号
objvQxPrjUserRelationByRoleENT.RoleId = objvQxPrjUserRelationByRoleENS.RoleId; //角色Id
objvQxPrjUserRelationByRoleENT.RoleName = objvQxPrjUserRelationByRoleENS.RoleName; //角色名称
objvQxPrjUserRelationByRoleENT.PrjName = objvQxPrjUserRelationByRoleENS.PrjName; //工程名
objvQxPrjUserRelationByRoleENT.UserId = objvQxPrjUserRelationByRoleENS.UserId; //用户ID
objvQxPrjUserRelationByRoleENT.UserName = objvQxPrjUserRelationByRoleENS.UserName; //用户名
objvQxPrjUserRelationByRoleENT.DepartmentId = objvQxPrjUserRelationByRoleENS.DepartmentId; //部门Id
objvQxPrjUserRelationByRoleENT.DepartmentName = objvQxPrjUserRelationByRoleENS.DepartmentName; //部门名
objvQxPrjUserRelationByRoleENT.UserStateName = objvQxPrjUserRelationByRoleENS.UserStateName; //用户状态名
objvQxPrjUserRelationByRoleENT.IdentityDesc = objvQxPrjUserRelationByRoleENS.IdentityDesc; //身份描述
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
 /// <param name = "objvQxPrjUserRelationByRoleEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
try
{
objvQxPrjUserRelationByRoleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjUserRelationByRoleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjUserRelationByRole.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.mId = objvQxPrjUserRelationByRoleEN.mId; //流水号
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.QxPrjId = objvQxPrjUserRelationByRoleEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.IdentityId = objvQxPrjUserRelationByRoleEN.IdentityId == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.RoleId = objvQxPrjUserRelationByRoleEN.RoleId == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.RoleName = objvQxPrjUserRelationByRoleEN.RoleName == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.PrjName = objvQxPrjUserRelationByRoleEN.PrjName == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.UserId = objvQxPrjUserRelationByRoleEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.UserName = objvQxPrjUserRelationByRoleEN.UserName == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.DepartmentId = objvQxPrjUserRelationByRoleEN.DepartmentId == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.DepartmentName = objvQxPrjUserRelationByRoleEN.DepartmentName == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.UserStateName = objvQxPrjUserRelationByRoleEN.UserStateName == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxPrjUserRelationByRole.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationByRoleEN.IdentityDesc = objvQxPrjUserRelationByRoleEN.IdentityDesc == "[null]" ? null :  objvQxPrjUserRelationByRoleEN.IdentityDesc; //身份描述
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
 /// <param name = "objvQxPrjUserRelationByRoleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
try
{
if (objvQxPrjUserRelationByRoleEN.IdentityId == "[null]") objvQxPrjUserRelationByRoleEN.IdentityId = null; //身份编号
if (objvQxPrjUserRelationByRoleEN.RoleId == "[null]") objvQxPrjUserRelationByRoleEN.RoleId = null; //角色Id
if (objvQxPrjUserRelationByRoleEN.RoleName == "[null]") objvQxPrjUserRelationByRoleEN.RoleName = null; //角色名称
if (objvQxPrjUserRelationByRoleEN.PrjName == "[null]") objvQxPrjUserRelationByRoleEN.PrjName = null; //工程名
if (objvQxPrjUserRelationByRoleEN.UserName == "[null]") objvQxPrjUserRelationByRoleEN.UserName = null; //用户名
if (objvQxPrjUserRelationByRoleEN.DepartmentId == "[null]") objvQxPrjUserRelationByRoleEN.DepartmentId = null; //部门Id
if (objvQxPrjUserRelationByRoleEN.DepartmentName == "[null]") objvQxPrjUserRelationByRoleEN.DepartmentName = null; //部门名
if (objvQxPrjUserRelationByRoleEN.UserStateName == "[null]") objvQxPrjUserRelationByRoleEN.UserStateName = null; //用户状态名
if (objvQxPrjUserRelationByRoleEN.IdentityDesc == "[null]") objvQxPrjUserRelationByRoleEN.IdentityDesc = null; //身份描述
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
public static void CheckProperty4Condition(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
 vQxPrjUserRelationByRoleDA.CheckProperty4Condition(objvQxPrjUserRelationByRoleEN);
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
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserRoleRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRoleRelationBL没有刷新缓存机制(clsQxUserRoleRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjUserRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjUserRelationBL没有刷新缓存机制(clsQxPrjUserRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxPrjUserRelationByRoleObjLstCache == null)
//{
//arrvQxPrjUserRelationByRoleObjLstCache = vQxPrjUserRelationByRoleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjUserRelationByRoleEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjUserRelationByRoleEN._CurrTabName);
List<clsvQxPrjUserRelationByRoleEN> arrvQxPrjUserRelationByRoleObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationByRoleEN> arrvQxPrjUserRelationByRoleObjLst_Sel =
arrvQxPrjUserRelationByRoleObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxPrjUserRelationByRoleObjLst_Sel.Count() == 0)
{
   clsvQxPrjUserRelationByRoleEN obj = clsvQxPrjUserRelationByRoleBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjUserRelationByRoleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetAllvQxPrjUserRelationByRoleObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjUserRelationByRoleEN> arrvQxPrjUserRelationByRoleObjLstCache = GetObjLstCache(); 
return arrvQxPrjUserRelationByRoleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjUserRelationByRoleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjUserRelationByRoleEN._CurrTabName);
List<clsvQxPrjUserRelationByRoleEN> arrvQxPrjUserRelationByRoleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjUserRelationByRoleObjLstCache;
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
string strKey = string.Format("{0}", clsvQxPrjUserRelationByRoleEN._CurrTabName);
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
 /// <param name = "lstvQxPrjUserRelationByRoleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjUserRelationByRoleEN> lstvQxPrjUserRelationByRoleObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjUserRelationByRoleObjLst, writer);
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
 /// <param name = "lstvQxPrjUserRelationByRoleObjLst">[clsvQxPrjUserRelationByRoleEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjUserRelationByRoleEN> lstvQxPrjUserRelationByRoleObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjUserRelationByRoleBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjUserRelationByRoleBL.itemsXmlNode);
foreach (clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN in lstvQxPrjUserRelationByRoleObjLst)
{
clsvQxPrjUserRelationByRoleBL.SerializeXML(writer, objvQxPrjUserRelationByRoleEN);
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
 /// <param name = "objvQxPrjUserRelationByRoleEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
writer.WriteStartElement(clsvQxPrjUserRelationByRoleBL.itemXmlNode);
 
writer.WriteElementString(convQxPrjUserRelationByRole.mId, objvQxPrjUserRelationByRoleEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxPrjUserRelationByRoleEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.QxPrjId, objvQxPrjUserRelationByRoleEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.IdentityId != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.IdentityId, objvQxPrjUserRelationByRoleEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.RoleId != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.RoleId, objvQxPrjUserRelationByRoleEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.RoleName != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.RoleName, objvQxPrjUserRelationByRoleEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.PrjName != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.PrjName, objvQxPrjUserRelationByRoleEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.UserId != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.UserId, objvQxPrjUserRelationByRoleEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.UserName != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.UserName, objvQxPrjUserRelationByRoleEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.DepartmentId != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.DepartmentId, objvQxPrjUserRelationByRoleEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.DepartmentName != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.DepartmentName, objvQxPrjUserRelationByRoleEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.UserStateName != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.UserStateName, objvQxPrjUserRelationByRoleEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationByRoleEN.IdentityDesc != null)
{
writer.WriteElementString(convQxPrjUserRelationByRole.IdentityDesc, objvQxPrjUserRelationByRoleEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjUserRelationByRoleEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
reader.Read();
while (!(reader.Name == clsvQxPrjUserRelationByRoleBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjUserRelationByRole.mId))
{
objvQxPrjUserRelationByRoleEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.QxPrjId))
{
objvQxPrjUserRelationByRoleEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.IdentityId))
{
objvQxPrjUserRelationByRoleEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.RoleId))
{
objvQxPrjUserRelationByRoleEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.RoleName))
{
objvQxPrjUserRelationByRoleEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.PrjName))
{
objvQxPrjUserRelationByRoleEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.UserId))
{
objvQxPrjUserRelationByRoleEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.UserName))
{
objvQxPrjUserRelationByRoleEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.DepartmentId))
{
objvQxPrjUserRelationByRoleEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.DepartmentName))
{
objvQxPrjUserRelationByRoleEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.UserStateName))
{
objvQxPrjUserRelationByRoleEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelationByRole.IdentityDesc))
{
objvQxPrjUserRelationByRoleEN.IdentityDesc = reader.ReadElementContentAsString();
}
}
return objvQxPrjUserRelationByRoleEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjUserRelationByRoleObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjUserRelationByRoleEN GetObjFromXmlStr(string strvQxPrjUserRelationByRoleObjXmlStr)
{
clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN = new clsvQxPrjUserRelationByRoleEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjUserRelationByRoleObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjUserRelationByRoleBL.itemXmlNode))
{
objvQxPrjUserRelationByRoleEN = GetObjFromXml(reader);
return objvQxPrjUserRelationByRoleEN;
}
}
return objvQxPrjUserRelationByRoleEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjUserRelationByRoleEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convQxPrjUserRelationByRole.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjUserRelationByRole.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjUserRelationByRole.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjUserRelationByRole = clsvQxPrjUserRelationByRoleBL.GetObjBymIdCache(lngmId);
if (objvQxPrjUserRelationByRole == null) return "";
return objvQxPrjUserRelationByRole[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjUserRelationByRoleEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjUserRelationByRoleEN[strField]);
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
 /// <param name = "lstvQxPrjUserRelationByRoleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjUserRelationByRoleEN> lstvQxPrjUserRelationByRoleObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjUserRelationByRoleObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleEN in lstvQxPrjUserRelationByRoleObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjUserRelationByRoleEN);
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
int intRecCount = clsvQxPrjUserRelationByRoleDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjUserRelationByRoleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjUserRelationByRoleDA.GetRecCount();
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
int intRecCount = clsvQxPrjUserRelationByRoleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationByRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjUserRelationByRoleEN objvQxPrjUserRelationByRoleCond)
{
List<clsvQxPrjUserRelationByRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationByRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelationByRole.AttributeName)
{
if (objvQxPrjUserRelationByRoleCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelationByRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationByRoleCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelationByRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelationByRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationByRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelationByRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelationByRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationByRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationByRoleCond[strFldName]));
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
 List<string> arrList = clsvQxPrjUserRelationByRoleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjUserRelationByRoleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjUserRelationByRoleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}