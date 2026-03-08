
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRoleRelation4SynchBL
 表名:vQxUserRoleRelation4Synch(00140095)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:46:19
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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
public static class  clsvQxUserRoleRelation4SynchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelation4SynchEN GetObj(this K_mId_vQxUserRoleRelation4Synch myKey)
{
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = clsvQxUserRoleRelation4SynchBL.vQxUserRoleRelation4SynchDA.GetObjBymId(myKey.Value);
return objvQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetmId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, long lngmId, string strComparisonOp="")
	{
objvQxUserRoleRelation4SynchEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.mId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.mId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.mId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetIpAddress(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 23, convQxUserRoleRelation4Synch.IpAddress);
}
objvQxUserRoleRelation4SynchEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.IpAddress) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.IpAddress, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.IpAddress] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserRoleRelation4Synch.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserRoleRelation4Synch.UserId);
}
objvQxUserRoleRelation4SynchEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserRoleRelation4Synch.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserRoleRelation4Synch.UserName);
}
objvQxUserRoleRelation4SynchEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetDepartmentId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUserRoleRelation4Synch.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserRoleRelation4Synch.DepartmentId);
}
objvQxUserRoleRelation4SynchEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.DepartmentId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.DepartmentId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetDepartmentName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUserRoleRelation4Synch.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserRoleRelation4Synch.DepartmentName);
}
objvQxUserRoleRelation4SynchEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.DepartmentName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.DepartmentName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserStateId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUserRoleRelation4Synch.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserRoleRelation4Synch.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserRoleRelation4Synch.UserStateId);
}
objvQxUserRoleRelation4SynchEN.UserStateId = strUserStateId; //用户状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserStateId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserStateId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUserStateName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUserRoleRelation4Synch.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserRoleRelation4Synch.UserStateName);
}
objvQxUserRoleRelation4SynchEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UserStateName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UserStateName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetStuTeacherId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convQxUserRoleRelation4Synch.StuTeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUserRoleRelation4Synch.StuTeacherId);
}
objvQxUserRoleRelation4SynchEN.StuTeacherId = strStuTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.StuTeacherId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.StuTeacherId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.StuTeacherId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetIdentityId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convQxUserRoleRelation4Synch.IdentityId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUserRoleRelation4Synch.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUserRoleRelation4Synch.IdentityId);
}
objvQxUserRoleRelation4SynchEN.IdentityId = strIdentityId; //身份编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.IdentityId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.IdentityId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetIdentityDesc(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxUserRoleRelation4Synch.IdentityDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUserRoleRelation4Synch.IdentityDesc);
}
objvQxUserRoleRelation4SynchEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.IdentityDesc) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.IdentityDesc, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityDesc] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetRoleId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRoleRelation4Synch.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRoleRelation4Synch.RoleId);
}
objvQxUserRoleRelation4SynchEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.RoleId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.RoleId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetRoleName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRoleRelation4Synch.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRoleRelation4Synch.RoleName);
}
objvQxUserRoleRelation4SynchEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.RoleName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.RoleName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetQxPrjId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserRoleRelation4Synch.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRoleRelation4Synch.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRoleRelation4Synch.QxPrjId);
}
objvQxUserRoleRelation4SynchEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.QxPrjId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetPrjName(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserRoleRelation4Synch.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRoleRelation4Synch.PrjName);
}
objvQxUserRoleRelation4SynchEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.PrjName) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.PrjName, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.PrjName] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUpdDate(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxUserRoleRelation4Synch.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserRoleRelation4Synch.UpdDate);
}
objvQxUserRoleRelation4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UpdDate) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UpdDate, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdDate] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetUpdUserId(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxUserRoleRelation4Synch.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserRoleRelation4Synch.UpdUserId);
}
objvQxUserRoleRelation4SynchEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.UpdUserId) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.UpdUserId, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdUserId] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRoleRelation4SynchEN SetMemo(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRoleRelation4Synch.Memo);
}
objvQxUserRoleRelation4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxUserRoleRelation4Synch.Memo) == false)
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp.Add(convQxUserRoleRelation4Synch.Memo, strComparisonOp);
}
else
{
objvQxUserRoleRelation4SynchEN.dicFldComparisonOp[convQxUserRoleRelation4Synch.Memo] = strComparisonOp;
}
}
return objvQxUserRoleRelation4SynchEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchENS">源对象</param>
 /// <param name = "objvQxUserRoleRelation4SynchENT">目标对象</param>
 public static void CopyTo(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENS, clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENT)
{
try
{
objvQxUserRoleRelation4SynchENT.mId = objvQxUserRoleRelation4SynchENS.mId; //流水号
objvQxUserRoleRelation4SynchENT.IpAddress = objvQxUserRoleRelation4SynchENS.IpAddress; //IP地址
objvQxUserRoleRelation4SynchENT.UserId = objvQxUserRoleRelation4SynchENS.UserId; //用户ID
objvQxUserRoleRelation4SynchENT.UserName = objvQxUserRoleRelation4SynchENS.UserName; //用户名
objvQxUserRoleRelation4SynchENT.DepartmentId = objvQxUserRoleRelation4SynchENS.DepartmentId; //部门Id
objvQxUserRoleRelation4SynchENT.DepartmentName = objvQxUserRoleRelation4SynchENS.DepartmentName; //部门名
objvQxUserRoleRelation4SynchENT.UserStateId = objvQxUserRoleRelation4SynchENS.UserStateId; //用户状态Id
objvQxUserRoleRelation4SynchENT.UserStateName = objvQxUserRoleRelation4SynchENS.UserStateName; //用户状态名
objvQxUserRoleRelation4SynchENT.StuTeacherId = objvQxUserRoleRelation4SynchENS.StuTeacherId; //学工号
objvQxUserRoleRelation4SynchENT.IdentityId = objvQxUserRoleRelation4SynchENS.IdentityId; //身份编号
objvQxUserRoleRelation4SynchENT.IdentityDesc = objvQxUserRoleRelation4SynchENS.IdentityDesc; //身份描述
objvQxUserRoleRelation4SynchENT.RoleId = objvQxUserRoleRelation4SynchENS.RoleId; //角色Id
objvQxUserRoleRelation4SynchENT.RoleName = objvQxUserRoleRelation4SynchENS.RoleName; //角色名称
objvQxUserRoleRelation4SynchENT.QxPrjId = objvQxUserRoleRelation4SynchENS.QxPrjId; //项目Id
objvQxUserRoleRelation4SynchENT.PrjName = objvQxUserRoleRelation4SynchENS.PrjName; //工程名
objvQxUserRoleRelation4SynchENT.UpdDate = objvQxUserRoleRelation4SynchENS.UpdDate; //修改日期
objvQxUserRoleRelation4SynchENT.UpdUserId = objvQxUserRoleRelation4SynchENS.UpdUserId; //修改用户Id
objvQxUserRoleRelation4SynchENT.Memo = objvQxUserRoleRelation4SynchENS.Memo; //备注
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
 /// <param name = "objvQxUserRoleRelation4SynchENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserRoleRelation4SynchEN:objvQxUserRoleRelation4SynchENT</returns>
 public static clsvQxUserRoleRelation4SynchEN CopyTo(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENS)
{
try
{
 clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENT = new clsvQxUserRoleRelation4SynchEN()
{
mId = objvQxUserRoleRelation4SynchENS.mId, //流水号
IpAddress = objvQxUserRoleRelation4SynchENS.IpAddress, //IP地址
UserId = objvQxUserRoleRelation4SynchENS.UserId, //用户ID
UserName = objvQxUserRoleRelation4SynchENS.UserName, //用户名
DepartmentId = objvQxUserRoleRelation4SynchENS.DepartmentId, //部门Id
DepartmentName = objvQxUserRoleRelation4SynchENS.DepartmentName, //部门名
UserStateId = objvQxUserRoleRelation4SynchENS.UserStateId, //用户状态Id
UserStateName = objvQxUserRoleRelation4SynchENS.UserStateName, //用户状态名
StuTeacherId = objvQxUserRoleRelation4SynchENS.StuTeacherId, //学工号
IdentityId = objvQxUserRoleRelation4SynchENS.IdentityId, //身份编号
IdentityDesc = objvQxUserRoleRelation4SynchENS.IdentityDesc, //身份描述
RoleId = objvQxUserRoleRelation4SynchENS.RoleId, //角色Id
RoleName = objvQxUserRoleRelation4SynchENS.RoleName, //角色名称
QxPrjId = objvQxUserRoleRelation4SynchENS.QxPrjId, //项目Id
PrjName = objvQxUserRoleRelation4SynchENS.PrjName, //工程名
UpdDate = objvQxUserRoleRelation4SynchENS.UpdDate, //修改日期
UpdUserId = objvQxUserRoleRelation4SynchENS.UpdUserId, //修改用户Id
Memo = objvQxUserRoleRelation4SynchENS.Memo, //备注
};
 return objvQxUserRoleRelation4SynchENT;
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
public static void CheckProperty4Condition(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
 clsvQxUserRoleRelation4SynchBL.vQxUserRoleRelation4SynchDA.CheckProperty4Condition(objvQxUserRoleRelation4SynchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.mId) == true)
{
string strComparisonOpmId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRoleRelation4Synch.mId, objvQxUserRoleRelation4SynchCond.mId, strComparisonOpmId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.IpAddress, objvQxUserRoleRelation4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserId) == true)
{
string strComparisonOpUserId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserId, objvQxUserRoleRelation4SynchCond.UserId, strComparisonOpUserId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserName) == true)
{
string strComparisonOpUserName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserName, objvQxUserRoleRelation4SynchCond.UserName, strComparisonOpUserName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.DepartmentId, objvQxUserRoleRelation4SynchCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.DepartmentName, objvQxUserRoleRelation4SynchCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserStateId) == true)
{
string strComparisonOpUserStateId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserStateId, objvQxUserRoleRelation4SynchCond.UserStateId, strComparisonOpUserStateId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UserStateName, objvQxUserRoleRelation4SynchCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.StuTeacherId) == true)
{
string strComparisonOpStuTeacherId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.StuTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.StuTeacherId, objvQxUserRoleRelation4SynchCond.StuTeacherId, strComparisonOpStuTeacherId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.IdentityId) == true)
{
string strComparisonOpIdentityId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.IdentityId, objvQxUserRoleRelation4SynchCond.IdentityId, strComparisonOpIdentityId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.IdentityDesc, objvQxUserRoleRelation4SynchCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.RoleId, objvQxUserRoleRelation4SynchCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.RoleName, objvQxUserRoleRelation4SynchCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.QxPrjId, objvQxUserRoleRelation4SynchCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.PrjName, objvQxUserRoleRelation4SynchCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UpdDate, objvQxUserRoleRelation4SynchCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.UpdUserId, objvQxUserRoleRelation4SynchCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxUserRoleRelation4SynchCond.IsUpdated(convQxUserRoleRelation4Synch.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[convQxUserRoleRelation4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoleRelation4Synch.Memo, objvQxUserRoleRelation4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserRoleRelation4Synch
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户角色关系4同步(vQxUserRoleRelation4Synch)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRoleRelation4SynchBL
{
public static RelatedActions_vQxUserRoleRelation4Synch relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserRoleRelation4SynchListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserRoleRelation4SynchList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserRoleRelation4SynchEN> arrvQxUserRoleRelation4SynchObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserRoleRelation4SynchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserRoleRelation4SynchDA vQxUserRoleRelation4SynchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserRoleRelation4SynchDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserRoleRelation4SynchBL()
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
if (string.IsNullOrEmpty(clsvQxUserRoleRelation4SynchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRoleRelation4SynchEN._ConnectString);
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
objDS = vQxUserRoleRelation4SynchDA.GetDataSet(strWhereCond);
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
objDS = vQxUserRoleRelation4SynchDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserRoleRelation4SynchDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserRoleRelation4Synch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserRoleRelation4SynchDA.GetDataTable_vQxUserRoleRelation4Synch(strWhereCond);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTable(strWhereCond);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserRoleRelation4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
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
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserRoleRelation4SynchEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxUserRoleRelation4SynchEN._CurrTabName);
List<clsvQxUserRoleRelation4SynchEN> arrvQxUserRoleRelation4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRoleRelation4SynchEN> arrvQxUserRoleRelation4SynchObjLst_Sel =
arrvQxUserRoleRelation4SynchObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxUserRoleRelation4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserRoleRelation4SynchEN> GetSubObjLstCache(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchCond)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRoleRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRoleRelation4Synch.AttributeName)
{
if (objvQxUserRoleRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRoleRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else
{
if (objvQxUserRoleRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRoleRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelation4SynchCond[strFldName]));
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelation4SynchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserRoleRelation4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
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
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
public static IEnumerable<clsvQxUserRoleRelation4SynchEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchCond, string strOrderBy)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRoleRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRoleRelation4Synch.AttributeName)
{
if (objvQxUserRoleRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRoleRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else
{
if (objvQxUserRoleRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRoleRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelation4SynchCond[strFldName]));
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
public static IEnumerable<clsvQxUserRoleRelation4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchCond = JsonConvert.DeserializeObject<clsvQxUserRoleRelation4SynchEN>(objPagerPara.whereCond);
if (objvQxUserRoleRelation4SynchCond.sfFldComparisonOp == null)
{
objvQxUserRoleRelation4SynchCond.dicFldComparisonOp = null;
}
else
{
objvQxUserRoleRelation4SynchCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserRoleRelation4SynchCond.sfFldComparisonOp);
}
clsvQxUserRoleRelation4SynchBL.SetUpdFlag(objvQxUserRoleRelation4SynchCond);
 try
{
CheckProperty4Condition(objvQxUserRoleRelation4SynchCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserRoleRelation4SynchBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserRoleRelation4SynchCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
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
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLst = new List<clsvQxUserRoleRelation4SynchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
try
{
objvQxUserRoleRelation4SynchEN.mId = Int32.Parse(objRow[convQxUserRoleRelation4Synch.mId].ToString().Trim()); //流水号
objvQxUserRoleRelation4SynchEN.IpAddress = objRow[convQxUserRoleRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUserRoleRelation4SynchEN.UserId = objRow[convQxUserRoleRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxUserRoleRelation4SynchEN.UserName = objRow[convQxUserRoleRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxUserRoleRelation4SynchEN.DepartmentId = objRow[convQxUserRoleRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUserRoleRelation4SynchEN.DepartmentName = objRow[convQxUserRoleRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUserRoleRelation4SynchEN.UserStateId = objRow[convQxUserRoleRelation4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserRoleRelation4SynchEN.UserStateName = objRow[convQxUserRoleRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUserRoleRelation4SynchEN.StuTeacherId = objRow[convQxUserRoleRelation4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUserRoleRelation4SynchEN.IdentityId = objRow[convQxUserRoleRelation4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUserRoleRelation4SynchEN.IdentityDesc = objRow[convQxUserRoleRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUserRoleRelation4SynchEN.RoleId = objRow[convQxUserRoleRelation4Synch.RoleId] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.RoleId].ToString().Trim(); //角色Id
objvQxUserRoleRelation4SynchEN.RoleName = objRow[convQxUserRoleRelation4Synch.RoleName].ToString().Trim(); //角色名称
objvQxUserRoleRelation4SynchEN.QxPrjId = objRow[convQxUserRoleRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRoleRelation4SynchEN.PrjName = objRow[convQxUserRoleRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxUserRoleRelation4SynchEN.UpdDate = objRow[convQxUserRoleRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUserRoleRelation4SynchEN.UpdUserId = objRow[convQxUserRoleRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRoleRelation4SynchEN.Memo = objRow[convQxUserRoleRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxUserRoleRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRoleRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRoleRelation4SynchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRoleRelation4Synch(ref clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
bool bolResult = vQxUserRoleRelation4SynchDA.GetvQxUserRoleRelation4Synch(ref objvQxUserRoleRelation4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRoleRelation4SynchEN GetObjBymId(long lngmId)
{
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = vQxUserRoleRelation4SynchDA.GetObjBymId(lngmId);
return objvQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserRoleRelation4SynchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = vQxUserRoleRelation4SynchDA.GetFirstObj(strWhereCond);
 return objvQxUserRoleRelation4SynchEN;
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
public static clsvQxUserRoleRelation4SynchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = vQxUserRoleRelation4SynchDA.GetObjByDataRow(objRow);
 return objvQxUserRoleRelation4SynchEN;
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
public static clsvQxUserRoleRelation4SynchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = vQxUserRoleRelation4SynchDA.GetObjByDataRow(objRow);
 return objvQxUserRoleRelation4SynchEN;
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
 /// <param name = "lstvQxUserRoleRelation4SynchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRoleRelation4SynchEN GetObjBymIdFromList(long lngmId, List<clsvQxUserRoleRelation4SynchEN> lstvQxUserRoleRelation4SynchObjLst)
{
foreach (clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN in lstvQxUserRoleRelation4SynchObjLst)
{
if (objvQxUserRoleRelation4SynchEN.mId == lngmId)
{
return objvQxUserRoleRelation4SynchEN;
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
 lngmId = new clsvQxUserRoleRelation4SynchDA().GetFirstID(strWhereCond);
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
 arrList = vQxUserRoleRelation4SynchDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserRoleRelation4SynchDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUserRoleRelation4SynchDA.IsExist(lngmId);
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
 bolIsExist = clsvQxUserRoleRelation4SynchDA.IsExistTable();
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
 bolIsExist = vQxUserRoleRelation4SynchDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserRoleRelation4SynchENS">源对象</param>
 /// <param name = "objvQxUserRoleRelation4SynchENT">目标对象</param>
 public static void CopyTo(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENS, clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchENT)
{
try
{
objvQxUserRoleRelation4SynchENT.mId = objvQxUserRoleRelation4SynchENS.mId; //流水号
objvQxUserRoleRelation4SynchENT.IpAddress = objvQxUserRoleRelation4SynchENS.IpAddress; //IP地址
objvQxUserRoleRelation4SynchENT.UserId = objvQxUserRoleRelation4SynchENS.UserId; //用户ID
objvQxUserRoleRelation4SynchENT.UserName = objvQxUserRoleRelation4SynchENS.UserName; //用户名
objvQxUserRoleRelation4SynchENT.DepartmentId = objvQxUserRoleRelation4SynchENS.DepartmentId; //部门Id
objvQxUserRoleRelation4SynchENT.DepartmentName = objvQxUserRoleRelation4SynchENS.DepartmentName; //部门名
objvQxUserRoleRelation4SynchENT.UserStateId = objvQxUserRoleRelation4SynchENS.UserStateId; //用户状态Id
objvQxUserRoleRelation4SynchENT.UserStateName = objvQxUserRoleRelation4SynchENS.UserStateName; //用户状态名
objvQxUserRoleRelation4SynchENT.StuTeacherId = objvQxUserRoleRelation4SynchENS.StuTeacherId; //学工号
objvQxUserRoleRelation4SynchENT.IdentityId = objvQxUserRoleRelation4SynchENS.IdentityId; //身份编号
objvQxUserRoleRelation4SynchENT.IdentityDesc = objvQxUserRoleRelation4SynchENS.IdentityDesc; //身份描述
objvQxUserRoleRelation4SynchENT.RoleId = objvQxUserRoleRelation4SynchENS.RoleId; //角色Id
objvQxUserRoleRelation4SynchENT.RoleName = objvQxUserRoleRelation4SynchENS.RoleName; //角色名称
objvQxUserRoleRelation4SynchENT.QxPrjId = objvQxUserRoleRelation4SynchENS.QxPrjId; //项目Id
objvQxUserRoleRelation4SynchENT.PrjName = objvQxUserRoleRelation4SynchENS.PrjName; //工程名
objvQxUserRoleRelation4SynchENT.UpdDate = objvQxUserRoleRelation4SynchENS.UpdDate; //修改日期
objvQxUserRoleRelation4SynchENT.UpdUserId = objvQxUserRoleRelation4SynchENS.UpdUserId; //修改用户Id
objvQxUserRoleRelation4SynchENT.Memo = objvQxUserRoleRelation4SynchENS.Memo; //备注
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
 /// <param name = "objvQxUserRoleRelation4SynchEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
try
{
objvQxUserRoleRelation4SynchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserRoleRelation4SynchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.mId = objvQxUserRoleRelation4SynchEN.mId; //流水号
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.IpAddress = objvQxUserRoleRelation4SynchEN.IpAddress == "[null]" ? null :  objvQxUserRoleRelation4SynchEN.IpAddress; //IP地址
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.UserId = objvQxUserRoleRelation4SynchEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.UserName = objvQxUserRoleRelation4SynchEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.DepartmentId = objvQxUserRoleRelation4SynchEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.DepartmentName = objvQxUserRoleRelation4SynchEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.UserStateId = objvQxUserRoleRelation4SynchEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.UserStateName = objvQxUserRoleRelation4SynchEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.StuTeacherId = objvQxUserRoleRelation4SynchEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.IdentityId = objvQxUserRoleRelation4SynchEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.IdentityDesc = objvQxUserRoleRelation4SynchEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.RoleId = objvQxUserRoleRelation4SynchEN.RoleId == "[null]" ? null :  objvQxUserRoleRelation4SynchEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.RoleName = objvQxUserRoleRelation4SynchEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.QxPrjId = objvQxUserRoleRelation4SynchEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.PrjName = objvQxUserRoleRelation4SynchEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.UpdDate = objvQxUserRoleRelation4SynchEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.UpdUserId = objvQxUserRoleRelation4SynchEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxUserRoleRelation4Synch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRoleRelation4SynchEN.Memo = objvQxUserRoleRelation4SynchEN.Memo == "[null]" ? null :  objvQxUserRoleRelation4SynchEN.Memo; //备注
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
 /// <param name = "objvQxUserRoleRelation4SynchEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
try
{
if (objvQxUserRoleRelation4SynchEN.IpAddress == "[null]") objvQxUserRoleRelation4SynchEN.IpAddress = null; //IP地址
if (objvQxUserRoleRelation4SynchEN.RoleId == "[null]") objvQxUserRoleRelation4SynchEN.RoleId = null; //角色Id
if (objvQxUserRoleRelation4SynchEN.Memo == "[null]") objvQxUserRoleRelation4SynchEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
 vQxUserRoleRelation4SynchDA.CheckProperty4Condition(objvQxUserRoleRelation4SynchEN);
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
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserRoleRelation4SynchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserRoleRelation4SynchBL没有刷新缓存机制(clsQxUserRoleRelation4SynchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvQxUserRoleRelation4SynchObjLstCache == null)
//{
//arrvQxUserRoleRelation4SynchObjLstCache = vQxUserRoleRelation4SynchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRoleRelation4SynchEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserRoleRelation4SynchEN._CurrTabName);
List<clsvQxUserRoleRelation4SynchEN> arrvQxUserRoleRelation4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRoleRelation4SynchEN> arrvQxUserRoleRelation4SynchObjLst_Sel =
arrvQxUserRoleRelation4SynchObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxUserRoleRelation4SynchObjLst_Sel.Count() == 0)
{
   clsvQxUserRoleRelation4SynchEN obj = clsvQxUserRoleRelation4SynchBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserRoleRelation4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRoleRelation4SynchEN> GetAllvQxUserRoleRelation4SynchObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserRoleRelation4SynchEN> arrvQxUserRoleRelation4SynchObjLstCache = GetObjLstCache(); 
return arrvQxUserRoleRelation4SynchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRoleRelation4SynchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserRoleRelation4SynchEN._CurrTabName);
List<clsvQxUserRoleRelation4SynchEN> arrvQxUserRoleRelation4SynchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserRoleRelation4SynchObjLstCache;
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
string strKey = string.Format("{0}", clsvQxUserRoleRelation4SynchEN._CurrTabName);
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
 /// <param name = "lstvQxUserRoleRelation4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserRoleRelation4SynchEN> lstvQxUserRoleRelation4SynchObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserRoleRelation4SynchObjLst, writer);
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
 /// <param name = "lstvQxUserRoleRelation4SynchObjLst">[clsvQxUserRoleRelation4SynchEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserRoleRelation4SynchEN> lstvQxUserRoleRelation4SynchObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserRoleRelation4SynchBL.listXmlNode);
writer.WriteStartElement(clsvQxUserRoleRelation4SynchBL.itemsXmlNode);
foreach (clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN in lstvQxUserRoleRelation4SynchObjLst)
{
clsvQxUserRoleRelation4SynchBL.SerializeXML(writer, objvQxUserRoleRelation4SynchEN);
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
 /// <param name = "objvQxUserRoleRelation4SynchEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
writer.WriteStartElement(clsvQxUserRoleRelation4SynchBL.itemXmlNode);
 
writer.WriteElementString(convQxUserRoleRelation4Synch.mId, objvQxUserRoleRelation4SynchEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxUserRoleRelation4SynchEN.IpAddress != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.IpAddress, objvQxUserRoleRelation4SynchEN.IpAddress.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.UserId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.UserId, objvQxUserRoleRelation4SynchEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.UserName != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.UserName, objvQxUserRoleRelation4SynchEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.DepartmentId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.DepartmentId, objvQxUserRoleRelation4SynchEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.DepartmentName != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.DepartmentName, objvQxUserRoleRelation4SynchEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.UserStateId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.UserStateId, objvQxUserRoleRelation4SynchEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.UserStateName != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.UserStateName, objvQxUserRoleRelation4SynchEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.StuTeacherId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.StuTeacherId, objvQxUserRoleRelation4SynchEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.IdentityId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.IdentityId, objvQxUserRoleRelation4SynchEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.IdentityDesc != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.IdentityDesc, objvQxUserRoleRelation4SynchEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.RoleId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.RoleId, objvQxUserRoleRelation4SynchEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.RoleName != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.RoleName, objvQxUserRoleRelation4SynchEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.QxPrjId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.QxPrjId, objvQxUserRoleRelation4SynchEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.PrjName != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.PrjName, objvQxUserRoleRelation4SynchEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.UpdDate != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.UpdDate, objvQxUserRoleRelation4SynchEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.UpdUserId != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.UpdUserId, objvQxUserRoleRelation4SynchEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRoleRelation4SynchEN.Memo != null)
{
writer.WriteElementString(convQxUserRoleRelation4Synch.Memo, objvQxUserRoleRelation4SynchEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxUserRoleRelation4SynchEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
reader.Read();
while (!(reader.Name == clsvQxUserRoleRelation4SynchBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserRoleRelation4Synch.mId))
{
objvQxUserRoleRelation4SynchEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.IpAddress))
{
objvQxUserRoleRelation4SynchEN.IpAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.UserId))
{
objvQxUserRoleRelation4SynchEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.UserName))
{
objvQxUserRoleRelation4SynchEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.DepartmentId))
{
objvQxUserRoleRelation4SynchEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.DepartmentName))
{
objvQxUserRoleRelation4SynchEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.UserStateId))
{
objvQxUserRoleRelation4SynchEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.UserStateName))
{
objvQxUserRoleRelation4SynchEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.StuTeacherId))
{
objvQxUserRoleRelation4SynchEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.IdentityId))
{
objvQxUserRoleRelation4SynchEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.IdentityDesc))
{
objvQxUserRoleRelation4SynchEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.RoleId))
{
objvQxUserRoleRelation4SynchEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.RoleName))
{
objvQxUserRoleRelation4SynchEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.QxPrjId))
{
objvQxUserRoleRelation4SynchEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.PrjName))
{
objvQxUserRoleRelation4SynchEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.UpdDate))
{
objvQxUserRoleRelation4SynchEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.UpdUserId))
{
objvQxUserRoleRelation4SynchEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRoleRelation4Synch.Memo))
{
objvQxUserRoleRelation4SynchEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserRoleRelation4SynchObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserRoleRelation4SynchEN GetObjFromXmlStr(string strvQxUserRoleRelation4SynchObjXmlStr)
{
clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN = new clsvQxUserRoleRelation4SynchEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserRoleRelation4SynchObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserRoleRelation4SynchBL.itemXmlNode))
{
objvQxUserRoleRelation4SynchEN = GetObjFromXml(reader);
return objvQxUserRoleRelation4SynchEN;
}
}
return objvQxUserRoleRelation4SynchEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserRoleRelation4SynchEN);
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
if (strInFldName != convQxUserRoleRelation4Synch.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserRoleRelation4Synch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserRoleRelation4Synch.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserRoleRelation4Synch = clsvQxUserRoleRelation4SynchBL.GetObjBymIdCache(lngmId);
if (objvQxUserRoleRelation4Synch == null) return "";
return objvQxUserRoleRelation4Synch[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserRoleRelation4SynchEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserRoleRelation4SynchEN[strField]);
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
 /// <param name = "lstvQxUserRoleRelation4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserRoleRelation4SynchEN> lstvQxUserRoleRelation4SynchObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserRoleRelation4SynchObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchEN in lstvQxUserRoleRelation4SynchObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserRoleRelation4SynchEN);
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
int intRecCount = clsvQxUserRoleRelation4SynchDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserRoleRelation4SynchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserRoleRelation4SynchDA.GetRecCount();
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
int intRecCount = clsvQxUserRoleRelation4SynchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserRoleRelation4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserRoleRelation4SynchEN objvQxUserRoleRelation4SynchCond)
{
List<clsvQxUserRoleRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRoleRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRoleRelation4Synch.AttributeName)
{
if (objvQxUserRoleRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRoleRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else
{
if (objvQxUserRoleRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRoleRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRoleRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRoleRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRoleRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRoleRelation4SynchCond[strFldName]));
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
 List<string> arrList = clsvQxUserRoleRelation4SynchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRoleRelation4SynchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRoleRelation4SynchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}