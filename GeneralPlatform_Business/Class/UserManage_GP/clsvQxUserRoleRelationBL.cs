
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelationBL
 表名:vQxUserRoleRelation(00140023)
 * 版本:2023.12.07.1(服务器:WIN-SRV103-116)
 日期:2023/12/20 22:54:52
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
public static class  clsvQxUserRoleRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelationEN GetObj(this K_mId_vQxUserRoleRelation myKey)
{
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = clsvQxUserRoleRelationBL.vQxUserRoleRelationDA.GetObjBymId(myKey.Value);
return objvQxUserRoleRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetmId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, long lngmId, string strComparisonOp="")
	{
objvQxUserRoleRelationEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.mId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.mId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.mId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserRoleRelation.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserRoleRelation.UserId);
}
objvQxUserRoleRelationEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserRoleRelation.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserRoleRelation.UserName);
}
objvQxUserRoleRelationEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetDepartmentId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUserRoleRelation.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserRoleRelation.DepartmentId);
}
objvQxUserRoleRelationEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.DepartmentId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.DepartmentId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.DepartmentId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetDepartmentName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUserRoleRelation.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserRoleRelation.DepartmentName);
}
objvQxUserRoleRelationEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.DepartmentName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.DepartmentName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.DepartmentName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserStateId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUserRoleRelation.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserRoleRelation.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserRoleRelation.UserStateId);
}
objvQxUserRoleRelationEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserStateId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserStateId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserStateId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetUserStateName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUserRoleRelation.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserRoleRelation.UserStateName);
}
objvQxUserRoleRelationEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.UserStateName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.UserStateName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.UserStateName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetStuTeacherId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strStuTeacherId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUserRoleRelation.StuTeacherId);
}
objvQxUserRoleRelationEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.StuTeacherId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.StuTeacherId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.StuTeacherId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdentityId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdentityId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUserRoleRelation.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUserRoleRelation.IdentityId);
}
objvQxUserRoleRelationEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdentityId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdentityId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdentityId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdentityDesc(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdentityDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserRoleRelation.IdentityDesc);
}
objvQxUserRoleRelationEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdentityDesc) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdentityDesc, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdentityDesc] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetRoleId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRoleRelation.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRoleRelation.RoleId);
}
objvQxUserRoleRelationEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.RoleId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.RoleId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.RoleId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetRoleName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRoleRelation.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRoleRelation.RoleName);
}
objvQxUserRoleRelationEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.RoleName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.RoleName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.RoleName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetQxPrjId(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserRoleRelation.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRoleRelation.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRoleRelation.QxPrjId);
}
objvQxUserRoleRelationEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.QxPrjId) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetPrjName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserRoleRelation.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRoleRelation.PrjName);
}
objvQxUserRoleRelationEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.PrjName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.PrjName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.PrjName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetMemo(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRoleRelation.Memo);
}
objvQxUserRoleRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.Memo) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.Memo, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.Memo] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetIdXzCollege(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUserRoleRelation.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUserRoleRelation.IdXzCollege);
}
objvQxUserRoleRelationEN.IdXzCollege = strIdXzCollege; //IdXzCollege
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.IdXzCollege) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.IdXzCollege, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.IdXzCollege] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetCollegeName(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convQxUserRoleRelation.CollegeName);
}
objvQxUserRoleRelationEN.CollegeName = strCollegeName; //CollegeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.CollegeName) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.CollegeName, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.CollegeName] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelationEN SetPassword(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN, string strPassword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUserRoleRelation.Password);
}
objvQxUserRoleRelationEN.Password = strPassword; //口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelationEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation.Password) == false)
{
objvQxUserRoleRelationEN.dicFldComparisonOp.Add(convQxUserRoleRelation.Password, strComparisonOp);
}
else
{
objvQxUserRoleRelationEN.dicFldComparisonOp[convQxUserRoleRelation.Password] = strComparisonOp;
}
}
return objvQxUserRoleRelationEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationENS">源对象</param>
 /// <param name = "objvQxUserRoleRelationENT">目标对象</param>
 public static void CopyTo(this clsvQxUserRoleRelationEN objvQxUserRoleRelationENS, clsvQxUserRoleRelationEN objvQxUserRoleRelationENT)
{
try
{
objvQxUserRoleRelationENT.mId = objvQxUserRoleRelationENS.mId; //流水号
objvQxUserRoleRelationENT.UserId = objvQxUserRoleRelationENS.UserId; //用户ID
objvQxUserRoleRelationENT.UserName = objvQxUserRoleRelationENS.UserName; //用户名
objvQxUserRoleRelationENT.DepartmentId = objvQxUserRoleRelationENS.DepartmentId; //部门Id
objvQxUserRoleRelationENT.DepartmentName = objvQxUserRoleRelationENS.DepartmentName; //部门名
objvQxUserRoleRelationENT.UserStateId = objvQxUserRoleRelationENS.UserStateId; //用户状态Id
objvQxUserRoleRelationENT.UserStateName = objvQxUserRoleRelationENS.UserStateName; //用户状态名
objvQxUserRoleRelationENT.StuTeacherId = objvQxUserRoleRelationENS.StuTeacherId; //学工号
objvQxUserRoleRelationENT.IdentityId = objvQxUserRoleRelationENS.IdentityId; //身份编号
objvQxUserRoleRelationENT.IdentityDesc = objvQxUserRoleRelationENS.IdentityDesc; //身份描述
objvQxUserRoleRelationENT.RoleId = objvQxUserRoleRelationENS.RoleId; //角色Id
objvQxUserRoleRelationENT.RoleName = objvQxUserRoleRelationENS.RoleName; //角色名称
objvQxUserRoleRelationENT.QxPrjId = objvQxUserRoleRelationENS.QxPrjId; //项目Id
objvQxUserRoleRelationENT.PrjName = objvQxUserRoleRelationENS.PrjName; //工程名
objvQxUserRoleRelationENT.Memo = objvQxUserRoleRelationENS.Memo; //备注
objvQxUserRoleRelationENT.IdXzCollege = objvQxUserRoleRelationENS.IdXzCollege; //IdXzCollege
objvQxUserRoleRelationENT.CollegeName = objvQxUserRoleRelationENS.CollegeName; //CollegeName
objvQxUserRoleRelationENT.Password = objvQxUserRoleRelationENS.Password; //口令
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
 /// <param name = "objvQxUserRoleRelationENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserRoleRelationEN:objvQxUserRoleRelationENT</returns>
 public static clsvQxUserRoleRelationEN CopyTo(this clsvQxUserRoleRelationEN objvQxUserRoleRelationENS)
{
try
{
 clsvQxUserRoleRelationEN objvQxUserRoleRelationENT = new clsvQxUserRoleRelationEN()
{
mId = objvQxUserRoleRelationENS.mId, //流水号
UserId = objvQxUserRoleRelationENS.UserId, //用户ID
UserName = objvQxUserRoleRelationENS.UserName, //用户名
DepartmentId = objvQxUserRoleRelationENS.DepartmentId, //部门Id
DepartmentName = objvQxUserRoleRelationENS.DepartmentName, //部门名
UserStateId = objvQxUserRoleRelationENS.UserStateId, //用户状态Id
UserStateName = objvQxUserRoleRelationENS.UserStateName, //用户状态名
StuTeacherId = objvQxUserRoleRelationENS.StuTeacherId, //学工号
IdentityId = objvQxUserRoleRelationENS.IdentityId, //身份编号
IdentityDesc = objvQxUserRoleRelationENS.IdentityDesc, //身份描述
RoleId = objvQxUserRoleRelationENS.RoleId, //角色Id
RoleName = objvQxUserRoleRelationENS.RoleName, //角色名称
QxPrjId = objvQxUserRoleRelationENS.QxPrjId, //项目Id
PrjName = objvQxUserRoleRelationENS.PrjName, //工程名
Memo = objvQxUserRoleRelationENS.Memo, //备注
IdXzCollege = objvQxUserRoleRelationENS.IdXzCollege, //IdXzCollege
CollegeName = objvQxUserRoleRelationENS.CollegeName, //CollegeName
Password = objvQxUserRoleRelationENS.Password, //口令
};
 return objvQxUserRoleRelationENT;
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
public static void CheckProperty4Condition(this clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
 clsvQxUserRoleRelationBL.vQxUserRoleRelationDA.CheckProperty4Condition(objvQxUserRoleRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRoleRelationEN objvQxUserRoleRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.mId) == true)
{
string strComparisonOpmId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRoleRelation.mId, objvQxUserRoleRelationCond.mId, strComparisonOpmId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserId) == true)
{
string strComparisonOpUserId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserId, objvQxUserRoleRelationCond.UserId, strComparisonOpUserId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserName) == true)
{
string strComparisonOpUserName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserName, objvQxUserRoleRelationCond.UserName, strComparisonOpUserName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.DepartmentId, objvQxUserRoleRelationCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.DepartmentName, objvQxUserRoleRelationCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserStateId, objvQxUserRoleRelationCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.UserStateName, objvQxUserRoleRelationCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.StuTeacherId, objvQxUserRoleRelationCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdentityId, objvQxUserRoleRelationCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdentityDesc, objvQxUserRoleRelationCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.RoleId, objvQxUserRoleRelationCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.RoleName, objvQxUserRoleRelationCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.QxPrjId, objvQxUserRoleRelationCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.PrjName, objvQxUserRoleRelationCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.Memo, objvQxUserRoleRelationCond.Memo, strComparisonOpMemo);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.IdXzCollege, objvQxUserRoleRelationCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.CollegeName) == true)
{
string strComparisonOpCollegeName = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.CollegeName, objvQxUserRoleRelationCond.CollegeName, strComparisonOpCollegeName);
}
if (objvQxUserRoleRelationCond.IsUpdated(convQxUserRoleRelation.Password) == true)
{
string strComparisonOpPassword = objvQxUserRoleRelationCond.dicFldComparisonOp[convQxUserRoleRelation.Password];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation.Password, objvQxUserRoleRelationCond.Password, strComparisonOpPassword);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserRoleRelation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户角色关系(vQxUserRoleRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRoleRelationBL
{
public static RelatedActions_vQxUserRoleRelation relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserRoleRelationListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserRoleRelationList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserRoleRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserRoleRelationDA vQxUserRoleRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserRoleRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserRoleRelationBL()
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
if (string.IsNullOrEmpty(clsvQxUserRoleRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRoleRelationEN._ConnectString);
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
objDS = vQxUserRoleRelationDA.GetDataSet(strWhereCond);
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
objDS = vQxUserRoleRelationDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserRoleRelationDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserRoleRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserRoleRelationDA.GetDataTable_vQxUserRoleRelation(strWhereCond);
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
objDT = vQxUserRoleRelationDA.GetDataTable(strWhereCond);
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
objDT = vQxUserRoleRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserRoleRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserRoleRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserRoleRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserRoleRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserRoleRelationDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserRoleRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserRoleRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserRoleRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserRoleRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserRoleRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserRoleRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
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
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserRoleRelationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strQxPrjId)
{
string strKey = string.Format("{0}_{1}", clsvQxUserRoleRelationEN._CurrTabName, strQxPrjId);
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Sel =
arrvQxUserRoleRelationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxUserRoleRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public static List<clsvQxUserRoleRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserRoleRelationEN> GetSubObjLstCache(clsvQxUserRoleRelationEN objvQxUserRoleRelationCond)
{
 string strQxPrjId = objvQxUserRoleRelationCond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQxUserRoleRelationBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQxUserRoleRelationEN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsvQxUserRoleRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRoleRelation.AttributeName)
{
if (objvQxUserRoleRelationCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRoleRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelationCond[strFldName].ToString());
}
else
{
if (objvQxUserRoleRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRoleRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRoleRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelationCond[strFldName]));
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
List<clsvQxUserRoleRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserRoleRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserRoleRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
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
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public static List<clsvQxUserRoleRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public static IEnumerable<clsvQxUserRoleRelationEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserRoleRelationEN objvQxUserRoleRelationCond, string strOrderBy)
{
 string strQxPrjId = objvQxUserRoleRelationCond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000173)在表中,缓存分类字段值不能为空!(clsvQxUserRoleRelationBL:GetObjLstByPagerCache)");
throw new Exception(strMsg);
}
List<clsvQxUserRoleRelationEN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsvQxUserRoleRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRoleRelation.AttributeName)
{
if (objvQxUserRoleRelationCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRoleRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelationCond[strFldName].ToString());
}
else
{
if (objvQxUserRoleRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRoleRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRoleRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelationCond[strFldName]));
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
public static IEnumerable<clsvQxUserRoleRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserRoleRelationEN objvQxUserRoleRelationCond = JsonConvert.DeserializeObject<clsvQxUserRoleRelationEN>(objPagerPara.whereCond);
if (objvQxUserRoleRelationCond.sfFldComparisonOp == null)
{
objvQxUserRoleRelationCond.dicFldComparisonOp = null;
}
else
{
objvQxUserRoleRelationCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserRoleRelationCond.sfFldComparisonOp);
}
clsvQxUserRoleRelationBL.SetUpdFlag(objvQxUserRoleRelationCond);
 try
{
CheckProperty4Condition(objvQxUserRoleRelationCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserRoleRelationBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserRoleRelationCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
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
public static List<clsvQxUserRoleRelationEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserRoleRelationEN> arrObjLst = new List<clsvQxUserRoleRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
objvQxUserRoleRelationEN.mId = Int32.Parse(objRow[convQxUserRoleRelation.mId].ToString().Trim()); //流水号
objvQxUserRoleRelationEN.UserId = objRow[convQxUserRoleRelation.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelationEN.UserName = objRow[convQxUserRoleRelation.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelationEN.DepartmentId = objRow[convQxUserRoleRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelationEN.DepartmentName = objRow[convQxUserRoleRelation.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelationEN.UserStateId = objRow[convQxUserRoleRelation.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelationEN.UserStateName = objRow[convQxUserRoleRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelationEN.StuTeacherId = objRow[convQxUserRoleRelation.StuTeacherId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelationEN.IdentityId = objRow[convQxUserRoleRelation.IdentityId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelationEN.IdentityDesc = objRow[convQxUserRoleRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelationEN.RoleId = objRow[convQxUserRoleRelation.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelationEN.RoleName = objRow[convQxUserRoleRelation.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelationEN.QxPrjId = objRow[convQxUserRoleRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelationEN.PrjName = objRow[convQxUserRoleRelation.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelationEN.Memo = objRow[convQxUserRoleRelation.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Memo].ToString().Trim(); //备注
objvQxUserRoleRelationEN.IdXzCollege = objRow[convQxUserRoleRelation.IdXzCollege] == DBNull.Value ? null : objRow[convQxUserRoleRelation.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUserRoleRelationEN.CollegeName = objRow[convQxUserRoleRelation.CollegeName] == DBNull.Value ? null : objRow[convQxUserRoleRelation.CollegeName].ToString().Trim(); //CollegeName
objvQxUserRoleRelationEN.Password = objRow[convQxUserRoleRelation.Password] == DBNull.Value ? null : objRow[convQxUserRoleRelation.Password].ToString().Trim(); //口令
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRoleRelation(ref clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
bool bolResult = vQxUserRoleRelationDA.GetvQxUserRoleRelation(ref objvQxUserRoleRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymId(long lngmId)
{
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = vQxUserRoleRelationDA.GetObjBymId(lngmId);
return objvQxUserRoleRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserRoleRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = vQxUserRoleRelationDA.GetFirstObj(strWhereCond);
 return objvQxUserRoleRelationEN;
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
public static clsvQxUserRoleRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = vQxUserRoleRelationDA.GetObjByDataRow(objRow);
 return objvQxUserRoleRelationEN;
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
public static clsvQxUserRoleRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = vQxUserRoleRelationDA.GetObjByDataRow(objRow);
 return objvQxUserRoleRelationEN;
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
 /// <param name = "lstvQxUserRoleRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymIdFromList(long lngmId, List<clsvQxUserRoleRelationEN> lstvQxUserRoleRelationObjLst)
{
foreach (clsvQxUserRoleRelationEN objvQxUserRoleRelationEN in lstvQxUserRoleRelationObjLst)
{
if (objvQxUserRoleRelationEN.mId == lngmId)
{
return objvQxUserRoleRelationEN;
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
 lngmId = new clsvQxUserRoleRelationDA().GetFirstID(strWhereCond);
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
 arrList = vQxUserRoleRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserRoleRelationDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUserRoleRelationDA.IsExist(lngmId);
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
 bolIsExist = clsvQxUserRoleRelationDA.IsExistTable();
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
 bolIsExist = vQxUserRoleRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserRoleRelationENS">源对象</param>
 /// <param name = "objvQxUserRoleRelationENT">目标对象</param>
 public static void CopyTo(clsvQxUserRoleRelationEN objvQxUserRoleRelationENS, clsvQxUserRoleRelationEN objvQxUserRoleRelationENT)
{
try
{
objvQxUserRoleRelationENT.mId = objvQxUserRoleRelationENS.mId; //流水号
objvQxUserRoleRelationENT.UserId = objvQxUserRoleRelationENS.UserId; //用户ID
objvQxUserRoleRelationENT.UserName = objvQxUserRoleRelationENS.UserName; //用户名
objvQxUserRoleRelationENT.DepartmentId = objvQxUserRoleRelationENS.DepartmentId; //部门Id
objvQxUserRoleRelationENT.DepartmentName = objvQxUserRoleRelationENS.DepartmentName; //部门名
objvQxUserRoleRelationENT.UserStateId = objvQxUserRoleRelationENS.UserStateId; //用户状态Id
objvQxUserRoleRelationENT.UserStateName = objvQxUserRoleRelationENS.UserStateName; //用户状态名
objvQxUserRoleRelationENT.StuTeacherId = objvQxUserRoleRelationENS.StuTeacherId; //学工号
objvQxUserRoleRelationENT.IdentityId = objvQxUserRoleRelationENS.IdentityId; //身份编号
objvQxUserRoleRelationENT.IdentityDesc = objvQxUserRoleRelationENS.IdentityDesc; //身份描述
objvQxUserRoleRelationENT.RoleId = objvQxUserRoleRelationENS.RoleId; //角色Id
objvQxUserRoleRelationENT.RoleName = objvQxUserRoleRelationENS.RoleName; //角色名称
objvQxUserRoleRelationENT.QxPrjId = objvQxUserRoleRelationENS.QxPrjId; //项目Id
objvQxUserRoleRelationENT.PrjName = objvQxUserRoleRelationENS.PrjName; //工程名
objvQxUserRoleRelationENT.Memo = objvQxUserRoleRelationENS.Memo; //备注
objvQxUserRoleRelationENT.IdXzCollege = objvQxUserRoleRelationENS.IdXzCollege; //IdXzCollege
objvQxUserRoleRelationENT.CollegeName = objvQxUserRoleRelationENS.CollegeName; //CollegeName
objvQxUserRoleRelationENT.Password = objvQxUserRoleRelationENS.Password; //口令
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
 /// <param name = "objvQxUserRoleRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
try
{
objvQxUserRoleRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserRoleRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserRoleRelation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.mId = objvQxUserRoleRelationEN.mId; //流水号
}
if (arrFldSet.Contains(convQxUserRoleRelation.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.UserId = objvQxUserRoleRelationEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUserRoleRelation.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.UserName = objvQxUserRoleRelationEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUserRoleRelation.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.DepartmentId = objvQxUserRoleRelationEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUserRoleRelation.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.DepartmentName = objvQxUserRoleRelationEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxUserRoleRelation.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.UserStateId = objvQxUserRoleRelationEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUserRoleRelation.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.UserStateName = objvQxUserRoleRelationEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUserRoleRelation.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.StuTeacherId = objvQxUserRoleRelationEN.StuTeacherId == "[null]" ? null :  objvQxUserRoleRelationEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUserRoleRelation.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.IdentityId = objvQxUserRoleRelationEN.IdentityId == "[null]" ? null :  objvQxUserRoleRelationEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(convQxUserRoleRelation.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.IdentityDesc = objvQxUserRoleRelationEN.IdentityDesc == "[null]" ? null :  objvQxUserRoleRelationEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUserRoleRelation.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.RoleId = objvQxUserRoleRelationEN.RoleId == "[null]" ? null :  objvQxUserRoleRelationEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxUserRoleRelation.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.RoleName = objvQxUserRoleRelationEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxUserRoleRelation.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.QxPrjId = objvQxUserRoleRelationEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxUserRoleRelation.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.PrjName = objvQxUserRoleRelationEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxUserRoleRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.Memo = objvQxUserRoleRelationEN.Memo == "[null]" ? null :  objvQxUserRoleRelationEN.Memo; //备注
}
if (arrFldSet.Contains(convQxUserRoleRelation.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.IdXzCollege = objvQxUserRoleRelationEN.IdXzCollege == "[null]" ? null :  objvQxUserRoleRelationEN.IdXzCollege; //IdXzCollege
}
if (arrFldSet.Contains(convQxUserRoleRelation.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.CollegeName = objvQxUserRoleRelationEN.CollegeName == "[null]" ? null :  objvQxUserRoleRelationEN.CollegeName; //CollegeName
}
if (arrFldSet.Contains(convQxUserRoleRelation.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelationEN.Password = objvQxUserRoleRelationEN.Password == "[null]" ? null :  objvQxUserRoleRelationEN.Password; //口令
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
 /// <param name = "objvQxUserRoleRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
try
{
if (objvQxUserRoleRelationEN.StuTeacherId == "[null]") objvQxUserRoleRelationEN.StuTeacherId = null; //学工号
if (objvQxUserRoleRelationEN.IdentityId == "[null]") objvQxUserRoleRelationEN.IdentityId = null; //身份编号
if (objvQxUserRoleRelationEN.IdentityDesc == "[null]") objvQxUserRoleRelationEN.IdentityDesc = null; //身份描述
if (objvQxUserRoleRelationEN.RoleId == "[null]") objvQxUserRoleRelationEN.RoleId = null; //角色Id
if (objvQxUserRoleRelationEN.Memo == "[null]") objvQxUserRoleRelationEN.Memo = null; //备注
if (objvQxUserRoleRelationEN.IdXzCollege == "[null]") objvQxUserRoleRelationEN.IdXzCollege = null; //IdXzCollege
if (objvQxUserRoleRelationEN.CollegeName == "[null]") objvQxUserRoleRelationEN.CollegeName = null; //CollegeName
if (objvQxUserRoleRelationEN.Password == "[null]") objvQxUserRoleRelationEN.Password = null; //口令
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
public static void CheckProperty4Condition(clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
 vQxUserRoleRelationDA.CheckProperty4Condition(objvQxUserRoleRelationEN);
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
//if (arrvQxUserRoleRelationObjLstCache == null)
//{
//arrvQxUserRoleRelationObjLstCache = vQxUserRoleRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRoleRelationEN GetObjBymIdCache(long lngmId, string strQxPrjId)
{

if (string.IsNullOrEmpty(strQxPrjId) == true)
{
  var strMsg = string.Format("参数:[strQxPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strQxPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strQxPrjId]的长度:[{0}]不正确!(In {1})", strQxPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvQxUserRoleRelationEN._CurrTabName, strQxPrjId);
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst_Sel =
arrvQxUserRoleRelationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxUserRoleRelationObjLst_Sel.Count() == 0)
{
   clsvQxUserRoleRelationEN obj = clsvQxUserRoleRelationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.QxPrjId == strQxPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strQxPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvQxUserRoleRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetAllvQxUserRoleRelationObjLstCache(string strQxPrjId)
{
//获取缓存中的对象列表
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLstCache = GetObjLstCache(strQxPrjId); 
return arrvQxUserRoleRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRoleRelationEN> GetObjLstCache(string strQxPrjId)
{

if (string.IsNullOrEmpty(strQxPrjId) == true)
{
  var strMsg = string.Format("参数:[strQxPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strQxPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strQxPrjId]的长度:[{0}]不正确!(In {1})", strQxPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQxUserRoleRelationEN._CurrTabName, strQxPrjId);
string strCondition = string.Format("QxPrjId='{0}'", strQxPrjId);
List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQxUserRoleRelationObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strQxPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvQxUserRoleRelationEN._CurrTabName, strQxPrjId);
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
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUserRoleRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserRoleRelationEN> lstvQxUserRoleRelationObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserRoleRelationObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvQxUserRoleRelationObjLst">[clsvQxUserRoleRelationEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserRoleRelationEN> lstvQxUserRoleRelationObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserRoleRelationBL.listXmlNode);
writer.WriteStartElement(clsvQxUserRoleRelationBL.itemsXmlNode);
foreach (clsvQxUserRoleRelationEN objvQxUserRoleRelationEN in lstvQxUserRoleRelationObjLst)
{
clsvQxUserRoleRelationBL.SerializeXML(writer, objvQxUserRoleRelationEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvQxUserRoleRelationEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
writer.WriteStartElement(clsvQxUserRoleRelationBL.itemXmlNode);
 
writer.WriteElementString(convQxUserRoleRelation.mId, objvQxUserRoleRelationEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxUserRoleRelationEN.UserId != null)
{
writer.WriteElementString(convQxUserRoleRelation.UserId, objvQxUserRoleRelationEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.UserName != null)
{
writer.WriteElementString(convQxUserRoleRelation.UserName, objvQxUserRoleRelationEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.DepartmentId != null)
{
writer.WriteElementString(convQxUserRoleRelation.DepartmentId, objvQxUserRoleRelationEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.DepartmentName != null)
{
writer.WriteElementString(convQxUserRoleRelation.DepartmentName, objvQxUserRoleRelationEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.UserStateId != null)
{
writer.WriteElementString(convQxUserRoleRelation.UserStateId, objvQxUserRoleRelationEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.UserStateName != null)
{
writer.WriteElementString(convQxUserRoleRelation.UserStateName, objvQxUserRoleRelationEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.StuTeacherId != null)
{
writer.WriteElementString(convQxUserRoleRelation.StuTeacherId, objvQxUserRoleRelationEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.IdentityId != null)
{
writer.WriteElementString(convQxUserRoleRelation.IdentityId, objvQxUserRoleRelationEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.IdentityDesc != null)
{
writer.WriteElementString(convQxUserRoleRelation.IdentityDesc, objvQxUserRoleRelationEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.RoleId != null)
{
writer.WriteElementString(convQxUserRoleRelation.RoleId, objvQxUserRoleRelationEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.RoleName != null)
{
writer.WriteElementString(convQxUserRoleRelation.RoleName, objvQxUserRoleRelationEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.QxPrjId != null)
{
writer.WriteElementString(convQxUserRoleRelation.QxPrjId, objvQxUserRoleRelationEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.PrjName != null)
{
writer.WriteElementString(convQxUserRoleRelation.PrjName, objvQxUserRoleRelationEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.Memo != null)
{
writer.WriteElementString(convQxUserRoleRelation.Memo, objvQxUserRoleRelationEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.IdXzCollege != null)
{
writer.WriteElementString(convQxUserRoleRelation.IdXzCollege, objvQxUserRoleRelationEN.IdXzCollege.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.CollegeName != null)
{
writer.WriteElementString(convQxUserRoleRelation.CollegeName, objvQxUserRoleRelationEN.CollegeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelationEN.Password != null)
{
writer.WriteElementString(convQxUserRoleRelation.Password, objvQxUserRoleRelationEN.Password.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserRoleRelationEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
reader.Read();
while (!(reader.Name == clsvQxUserRoleRelationBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserRoleRelation.mId))
{
objvQxUserRoleRelationEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxUserRoleRelation.UserId))
{
objvQxUserRoleRelationEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.UserName))
{
objvQxUserRoleRelationEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.DepartmentId))
{
objvQxUserRoleRelationEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.DepartmentName))
{
objvQxUserRoleRelationEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.UserStateId))
{
objvQxUserRoleRelationEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.UserStateName))
{
objvQxUserRoleRelationEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.StuTeacherId))
{
objvQxUserRoleRelationEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.IdentityId))
{
objvQxUserRoleRelationEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.IdentityDesc))
{
objvQxUserRoleRelationEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.RoleId))
{
objvQxUserRoleRelationEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.RoleName))
{
objvQxUserRoleRelationEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.QxPrjId))
{
objvQxUserRoleRelationEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.PrjName))
{
objvQxUserRoleRelationEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.Memo))
{
objvQxUserRoleRelationEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.IdXzCollege))
{
objvQxUserRoleRelationEN.IdXzCollege = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.CollegeName))
{
objvQxUserRoleRelationEN.CollegeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation.Password))
{
objvQxUserRoleRelationEN.Password = reader.ReadElementContentAsString();
}
}
return objvQxUserRoleRelationEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserRoleRelationObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserRoleRelationEN GetObjFromXmlStr(string strvQxUserRoleRelationObjXmlStr)
{
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserRoleRelationObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserRoleRelationBL.itemXmlNode))
{
objvQxUserRoleRelationEN = GetObjFromXml(reader);
return objvQxUserRoleRelationEN;
}
}
return objvQxUserRoleRelationEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserRoleRelationEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strQxPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strQxPrjId)
{
if (strInFldName != convQxUserRoleRelation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserRoleRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserRoleRelation.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserRoleRelation = clsvQxUserRoleRelationBL.GetObjBymIdCache(lngmId, strQxPrjId);
if (objvQxUserRoleRelation == null) return "";
return objvQxUserRoleRelation[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserRoleRelationEN objvQxUserRoleRelationEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserRoleRelationEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserRoleRelationEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-12-20
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvQxUserRoleRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserRoleRelationEN> lstvQxUserRoleRelationObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserRoleRelationObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserRoleRelationEN objvQxUserRoleRelationEN in lstvQxUserRoleRelationObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserRoleRelationEN);
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
int intRecCount = clsvQxUserRoleRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserRoleRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserRoleRelationDA.GetRecCount();
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
int intRecCount = clsvQxUserRoleRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserRoleRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserRoleRelationEN objvQxUserRoleRelationCond)
{
 string strQxPrjId = objvQxUserRoleRelationCond.QxPrjId;
 if (string.IsNullOrEmpty(strQxPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQxUserRoleRelationBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQxUserRoleRelationEN> arrObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsvQxUserRoleRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRoleRelation.AttributeName)
{
if (objvQxUserRoleRelationCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRoleRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelationCond[strFldName].ToString());
}
else
{
if (objvQxUserRoleRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRoleRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRoleRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRoleRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelationCond[strFldName]));
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
 List<string> arrList = clsvQxUserRoleRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRoleRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRoleRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}