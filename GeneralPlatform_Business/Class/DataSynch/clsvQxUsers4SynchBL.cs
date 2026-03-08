
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers4SynchBL
 表名:vQxUsers4Synch(00140090)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:01:00
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
public static class  clsvQxUsers4SynchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers4SynchEN GetObj(this K_mId_vQxUsers4Synch myKey)
{
clsvQxUsers4SynchEN objvQxUsers4SynchEN = clsvQxUsers4SynchBL.vQxUsers4SynchDA.GetObjBymId(myKey.Value);
return objvQxUsers4SynchEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIpAddress(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 23, convQxUsers4Synch.IpAddress);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUsers4Synch.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUsers4Synch.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUsers4Synch.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUsers4Synch.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserStateId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUsers4Synch.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUsers4Synch.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUsers4Synch.UserStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUserStateName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUsers4Synch.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUsers4Synch.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIdentityId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIdentityId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityId, convQxUsers4Synch.IdentityId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityId, 2, convQxUsers4Synch.IdentityId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdentityId, 2, convQxUsers4Synch.IdentityId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIdentityDesc(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxUsers4Synch.IdentityDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxUsers4Synch.IdentityDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetStuTeacherId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strStuTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStuTeacherId, convQxUsers4Synch.StuTeacherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuTeacherId, 20, convQxUsers4Synch.StuTeacherId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetPassword(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strPassword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPassword, convQxUsers4Synch.Password);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPassword, 20, convQxUsers4Synch.Password);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUsers4Synch.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUsers4Synch.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUsers4Synch.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUsers4Synch.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentAbbrName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convQxUsers4Synch.DepartmentAbbrName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentTypeId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeId, convQxUsers4Synch.DepartmentTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convQxUsers4Synch.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convQxUsers4Synch.DepartmentTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetDepartmentTypeName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentTypeName, convQxUsers4Synch.DepartmentTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convQxUsers4Synch.DepartmentTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpDepartmentId(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convQxUsers4Synch.UpDepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpDepartmentName(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 100, convQxUsers4Synch.UpDepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetIdXzCollege(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, convQxUsers4Synch.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convQxUsers4Synch.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convQxUsers4Synch.IdXzCollege);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetEffitiveBeginDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strEffitiveBeginDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveBeginDate, convQxUsers4Synch.EffitiveBeginDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveBeginDate, 14, convQxUsers4Synch.EffitiveBeginDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetEffitiveEndDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strEffitiveEndDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEffitiveEndDate, convQxUsers4Synch.EffitiveEndDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEffitiveEndDate, 14, convQxUsers4Synch.EffitiveEndDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetAccessSynchDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, convQxUsers4Synch.AccessSynchDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpdDate(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxUsers4Synch.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUsers4Synch.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetUpdUser(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxUsers4Synch.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUsers4SynchEN SetMemo(this clsvQxUsers4SynchEN objvQxUsers4SynchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUsers4Synch.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUsers4SynchENS">源对象</param>
 /// <param name = "objvQxUsers4SynchENT">目标对象</param>
 public static void CopyTo(this clsvQxUsers4SynchEN objvQxUsers4SynchENS, clsvQxUsers4SynchEN objvQxUsers4SynchENT)
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
 /// <param name = "objvQxUsers4SynchENS">源对象</param>
 /// <returns>目标对象=>clsvQxUsers4SynchEN:objvQxUsers4SynchENT</returns>
 public static clsvQxUsers4SynchEN CopyTo(this clsvQxUsers4SynchEN objvQxUsers4SynchENS)
{
try
{
 clsvQxUsers4SynchEN objvQxUsers4SynchENT = new clsvQxUsers4SynchEN()
{
mId = objvQxUsers4SynchENS.mId, //流水号
IpAddress = objvQxUsers4SynchENS.IpAddress, //IP地址
UserId = objvQxUsers4SynchENS.UserId, //用户ID
UserName = objvQxUsers4SynchENS.UserName, //用户名
UserStateId = objvQxUsers4SynchENS.UserStateId, //用户状态Id
UserStateName = objvQxUsers4SynchENS.UserStateName, //用户状态名
IdentityId = objvQxUsers4SynchENS.IdentityId, //身份编号
IdentityDesc = objvQxUsers4SynchENS.IdentityDesc, //身份描述
StuTeacherId = objvQxUsers4SynchENS.StuTeacherId, //学工号
Password = objvQxUsers4SynchENS.Password, //口令
DepartmentId = objvQxUsers4SynchENS.DepartmentId, //部门Id
DepartmentName = objvQxUsers4SynchENS.DepartmentName, //部门名
DepartmentAbbrName = objvQxUsers4SynchENS.DepartmentAbbrName, //名称缩写
DepartmentTypeId = objvQxUsers4SynchENS.DepartmentTypeId, //部门类型ID
DepartmentTypeName = objvQxUsers4SynchENS.DepartmentTypeName, //部门类型名
UpDepartmentId = objvQxUsers4SynchENS.UpDepartmentId, //所属部门号
UpDepartmentName = objvQxUsers4SynchENS.UpDepartmentName, //上级部门
IdXzCollege = objvQxUsers4SynchENS.IdXzCollege, //IdXzCollege
EffitiveBeginDate = objvQxUsers4SynchENS.EffitiveBeginDate, //有效开始日期
EffitiveEndDate = objvQxUsers4SynchENS.EffitiveEndDate, //有效结束日期
IsAccessSynch = objvQxUsers4SynchENS.IsAccessSynch, //是否处理同步
AccessSynchDate = objvQxUsers4SynchENS.AccessSynchDate, //处理同步日期
IsExistUserInCurr = objvQxUsers4SynchENS.IsExistUserInCurr, //当前是否存在用户
IsSamePwd = objvQxUsers4SynchENS.IsSamePwd, //是否相同密码
UpdDate = objvQxUsers4SynchENS.UpdDate, //修改日期
UpdUser = objvQxUsers4SynchENS.UpdUser, //修改用户
Memo = objvQxUsers4SynchENS.Memo, //备注
};
 return objvQxUsers4SynchENT;
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
public static void CheckProperty4Condition(this clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
 clsvQxUsers4SynchBL.vQxUsers4SynchDA.CheckProperty4Condition(objvQxUsers4SynchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUsers4Synch
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户4同步(vQxUsers4Synch)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUsers4SynchBL
{
public static RelatedActions_vQxUsers4Synch relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUsers4SynchListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUsers4SynchList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUsers4SynchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUsers4SynchDA vQxUsers4SynchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUsers4SynchDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUsers4SynchBL()
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
if (string.IsNullOrEmpty(clsvQxUsers4SynchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUsers4SynchEN._ConnectString);
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
objDS = vQxUsers4SynchDA.GetDataSet(strWhereCond);
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
objDS = vQxUsers4SynchDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUsers4SynchDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUsers4Synch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUsers4SynchDA.GetDataTable_vQxUsers4Synch(strWhereCond);
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
objDT = vQxUsers4SynchDA.GetDataTable(strWhereCond);
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
objDT = vQxUsers4SynchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUsers4SynchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUsers4SynchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUsers4SynchDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUsers4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUsers4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUsers4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUsers4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUsers4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUsers4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUsers4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUsers4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
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
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUsers4SynchEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxUsers4SynchEN._CurrTabName);
List<clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLst_Sel =
arrvQxUsers4SynchObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxUsers4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetObjLst(string strWhereCond)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public static List<clsvQxUsers4SynchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUsers4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUsers4SynchEN> GetSubObjLstCache(clsvQxUsers4SynchEN objvQxUsers4SynchCond)
{
List<clsvQxUsers4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers4Synch.AttributeName)
{
if (objvQxUsers4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsers4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers4SynchCond[strFldName].ToString());
}
else
{
if (objvQxUsers4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsers4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsers4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsers4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsers4SynchCond[strFldName]));
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
public static List<clsvQxUsers4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
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
List<clsvQxUsers4SynchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUsers4SynchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUsers4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
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
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public static List<clsvQxUsers4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUsers4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public static IEnumerable<clsvQxUsers4SynchEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUsers4SynchEN objvQxUsers4SynchCond, string strOrderBy)
{
List<clsvQxUsers4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers4Synch.AttributeName)
{
if (objvQxUsers4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsers4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers4SynchCond[strFldName].ToString());
}
else
{
if (objvQxUsers4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsers4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsers4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsers4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsers4SynchCond[strFldName]));
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
public static IEnumerable<clsvQxUsers4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUsers4SynchEN objvQxUsers4SynchCond = JsonConvert.DeserializeObject<clsvQxUsers4SynchEN>(objPagerPara.whereCond);
if (objvQxUsers4SynchCond.sfFldComparisonOp == null)
{
objvQxUsers4SynchCond.dicFldComparisonOp = null;
}
else
{
objvQxUsers4SynchCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUsers4SynchCond.sfFldComparisonOp);
}
clsvQxUsers4SynchBL.SetUpdFlag(objvQxUsers4SynchCond);
 try
{
CheckProperty4Condition(objvQxUsers4SynchCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUsers4SynchBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUsers4SynchCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUsers4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
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
public static List<clsvQxUsers4SynchEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUsers4SynchEN> arrObjLst = new List<clsvQxUsers4SynchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
try
{
objvQxUsers4SynchEN.mId = Int32.Parse(objRow[convQxUsers4Synch.mId].ToString().Trim()); //流水号
objvQxUsers4SynchEN.IpAddress = objRow[convQxUsers4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxUsers4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxUsers4SynchEN.UserId = objRow[convQxUsers4Synch.UserId].ToString().Trim(); //用户ID
objvQxUsers4SynchEN.UserName = objRow[convQxUsers4Synch.UserName].ToString().Trim(); //用户名
objvQxUsers4SynchEN.UserStateId = objRow[convQxUsers4Synch.UserStateId].ToString().Trim(); //用户状态Id
objvQxUsers4SynchEN.UserStateName = objRow[convQxUsers4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxUsers4SynchEN.IdentityId = objRow[convQxUsers4Synch.IdentityId].ToString().Trim(); //身份编号
objvQxUsers4SynchEN.IdentityDesc = objRow[convQxUsers4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxUsers4SynchEN.StuTeacherId = objRow[convQxUsers4Synch.StuTeacherId].ToString().Trim(); //学工号
objvQxUsers4SynchEN.Password = objRow[convQxUsers4Synch.Password].ToString().Trim(); //口令
objvQxUsers4SynchEN.DepartmentId = objRow[convQxUsers4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxUsers4SynchEN.DepartmentName = objRow[convQxUsers4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxUsers4SynchEN.DepartmentAbbrName = objRow[convQxUsers4Synch.DepartmentAbbrName] == DBNull.Value ? null : objRow[convQxUsers4Synch.DepartmentAbbrName].ToString().Trim(); //名称缩写
objvQxUsers4SynchEN.DepartmentTypeId = objRow[convQxUsers4Synch.DepartmentTypeId].ToString().Trim(); //部门类型ID
objvQxUsers4SynchEN.DepartmentTypeName = objRow[convQxUsers4Synch.DepartmentTypeName].ToString().Trim(); //部门类型名
objvQxUsers4SynchEN.UpDepartmentId = objRow[convQxUsers4Synch.UpDepartmentId] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentId].ToString().Trim(); //所属部门号
objvQxUsers4SynchEN.UpDepartmentName = objRow[convQxUsers4Synch.UpDepartmentName] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpDepartmentName].ToString().Trim(); //上级部门
objvQxUsers4SynchEN.IdXzCollege = objRow[convQxUsers4Synch.IdXzCollege].ToString().Trim(); //IdXzCollege
objvQxUsers4SynchEN.EffitiveBeginDate = objRow[convQxUsers4Synch.EffitiveBeginDate].ToString().Trim(); //有效开始日期
objvQxUsers4SynchEN.EffitiveEndDate = objRow[convQxUsers4Synch.EffitiveEndDate].ToString().Trim(); //有效结束日期
objvQxUsers4SynchEN.IsAccessSynch = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsAccessSynch].ToString().Trim()); //是否处理同步
objvQxUsers4SynchEN.AccessSynchDate = objRow[convQxUsers4Synch.AccessSynchDate] == DBNull.Value ? null : objRow[convQxUsers4Synch.AccessSynchDate].ToString().Trim(); //处理同步日期
objvQxUsers4SynchEN.IsExistUserInCurr = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsExistUserInCurr].ToString().Trim()); //当前是否存在用户
objvQxUsers4SynchEN.IsSamePwd = clsEntityBase2.TransNullToBool_S(objRow[convQxUsers4Synch.IsSamePwd].ToString().Trim()); //是否相同密码
objvQxUsers4SynchEN.UpdDate = objRow[convQxUsers4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxUsers4SynchEN.UpdUser = objRow[convQxUsers4Synch.UpdUser] == DBNull.Value ? null : objRow[convQxUsers4Synch.UpdUser].ToString().Trim(); //修改用户
objvQxUsers4SynchEN.Memo = objRow[convQxUsers4Synch.Memo] == DBNull.Value ? null : objRow[convQxUsers4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUsers4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUsers4SynchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUsers4Synch(ref clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
bool bolResult = vQxUsers4SynchDA.GetvQxUsers4Synch(ref objvQxUsers4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUsers4SynchEN GetObjBymId(long lngmId)
{
clsvQxUsers4SynchEN objvQxUsers4SynchEN = vQxUsers4SynchDA.GetObjBymId(lngmId);
return objvQxUsers4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUsers4SynchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUsers4SynchEN objvQxUsers4SynchEN = vQxUsers4SynchDA.GetFirstObj(strWhereCond);
 return objvQxUsers4SynchEN;
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
public static clsvQxUsers4SynchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUsers4SynchEN objvQxUsers4SynchEN = vQxUsers4SynchDA.GetObjByDataRow(objRow);
 return objvQxUsers4SynchEN;
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
public static clsvQxUsers4SynchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUsers4SynchEN objvQxUsers4SynchEN = vQxUsers4SynchDA.GetObjByDataRow(objRow);
 return objvQxUsers4SynchEN;
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
 /// <param name = "lstvQxUsers4SynchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsers4SynchEN GetObjBymIdFromList(long lngmId, List<clsvQxUsers4SynchEN> lstvQxUsers4SynchObjLst)
{
foreach (clsvQxUsers4SynchEN objvQxUsers4SynchEN in lstvQxUsers4SynchObjLst)
{
if (objvQxUsers4SynchEN.mId == lngmId)
{
return objvQxUsers4SynchEN;
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
 lngmId = new clsvQxUsers4SynchDA().GetFirstID(strWhereCond);
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
 arrList = vQxUsers4SynchDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUsers4SynchDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUsers4SynchDA.IsExist(lngmId);
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
 bolIsExist = clsvQxUsers4SynchDA.IsExistTable();
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
 bolIsExist = vQxUsers4SynchDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUsers4SynchEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
try
{
objvQxUsers4SynchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUsers4SynchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUsers4Synch.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.mId = objvQxUsers4SynchEN.mId; //流水号
}
if (arrFldSet.Contains(convQxUsers4Synch.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.IpAddress = objvQxUsers4SynchEN.IpAddress == "[null]" ? null :  objvQxUsers4SynchEN.IpAddress; //IP地址
}
if (arrFldSet.Contains(convQxUsers4Synch.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UserId = objvQxUsers4SynchEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUsers4Synch.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UserName = objvQxUsers4SynchEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUsers4Synch.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UserStateId = objvQxUsers4SynchEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUsers4Synch.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UserStateName = objvQxUsers4SynchEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUsers4Synch.IdentityId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.IdentityId = objvQxUsers4SynchEN.IdentityId; //身份编号
}
if (arrFldSet.Contains(convQxUsers4Synch.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.IdentityDesc = objvQxUsers4SynchEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxUsers4Synch.StuTeacherId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.StuTeacherId = objvQxUsers4SynchEN.StuTeacherId; //学工号
}
if (arrFldSet.Contains(convQxUsers4Synch.Password, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.Password = objvQxUsers4SynchEN.Password; //口令
}
if (arrFldSet.Contains(convQxUsers4Synch.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.DepartmentId = objvQxUsers4SynchEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUsers4Synch.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.DepartmentName = objvQxUsers4SynchEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxUsers4Synch.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.DepartmentAbbrName = objvQxUsers4SynchEN.DepartmentAbbrName == "[null]" ? null :  objvQxUsers4SynchEN.DepartmentAbbrName; //名称缩写
}
if (arrFldSet.Contains(convQxUsers4Synch.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.DepartmentTypeId = objvQxUsers4SynchEN.DepartmentTypeId; //部门类型ID
}
if (arrFldSet.Contains(convQxUsers4Synch.DepartmentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.DepartmentTypeName = objvQxUsers4SynchEN.DepartmentTypeName; //部门类型名
}
if (arrFldSet.Contains(convQxUsers4Synch.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UpDepartmentId = objvQxUsers4SynchEN.UpDepartmentId == "[null]" ? null :  objvQxUsers4SynchEN.UpDepartmentId; //所属部门号
}
if (arrFldSet.Contains(convQxUsers4Synch.UpDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UpDepartmentName = objvQxUsers4SynchEN.UpDepartmentName == "[null]" ? null :  objvQxUsers4SynchEN.UpDepartmentName; //上级部门
}
if (arrFldSet.Contains(convQxUsers4Synch.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.IdXzCollege = objvQxUsers4SynchEN.IdXzCollege; //IdXzCollege
}
if (arrFldSet.Contains(convQxUsers4Synch.EffitiveBeginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.EffitiveBeginDate = objvQxUsers4SynchEN.EffitiveBeginDate; //有效开始日期
}
if (arrFldSet.Contains(convQxUsers4Synch.EffitiveEndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.EffitiveEndDate = objvQxUsers4SynchEN.EffitiveEndDate; //有效结束日期
}
if (arrFldSet.Contains(convQxUsers4Synch.IsAccessSynch, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.IsAccessSynch = objvQxUsers4SynchEN.IsAccessSynch; //是否处理同步
}
if (arrFldSet.Contains(convQxUsers4Synch.AccessSynchDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.AccessSynchDate = objvQxUsers4SynchEN.AccessSynchDate == "[null]" ? null :  objvQxUsers4SynchEN.AccessSynchDate; //处理同步日期
}
if (arrFldSet.Contains(convQxUsers4Synch.IsExistUserInCurr, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.IsExistUserInCurr = objvQxUsers4SynchEN.IsExistUserInCurr; //当前是否存在用户
}
if (arrFldSet.Contains(convQxUsers4Synch.IsSamePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.IsSamePwd = objvQxUsers4SynchEN.IsSamePwd; //是否相同密码
}
if (arrFldSet.Contains(convQxUsers4Synch.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UpdDate = objvQxUsers4SynchEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUsers4Synch.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.UpdUser = objvQxUsers4SynchEN.UpdUser == "[null]" ? null :  objvQxUsers4SynchEN.UpdUser; //修改用户
}
if (arrFldSet.Contains(convQxUsers4Synch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUsers4SynchEN.Memo = objvQxUsers4SynchEN.Memo == "[null]" ? null :  objvQxUsers4SynchEN.Memo; //备注
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
 /// <param name = "objvQxUsers4SynchEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
try
{
if (objvQxUsers4SynchEN.IpAddress == "[null]") objvQxUsers4SynchEN.IpAddress = null; //IP地址
if (objvQxUsers4SynchEN.DepartmentAbbrName == "[null]") objvQxUsers4SynchEN.DepartmentAbbrName = null; //名称缩写
if (objvQxUsers4SynchEN.UpDepartmentId == "[null]") objvQxUsers4SynchEN.UpDepartmentId = null; //所属部门号
if (objvQxUsers4SynchEN.UpDepartmentName == "[null]") objvQxUsers4SynchEN.UpDepartmentName = null; //上级部门
if (objvQxUsers4SynchEN.AccessSynchDate == "[null]") objvQxUsers4SynchEN.AccessSynchDate = null; //处理同步日期
if (objvQxUsers4SynchEN.UpdUser == "[null]") objvQxUsers4SynchEN.UpdUser = null; //修改用户
if (objvQxUsers4SynchEN.Memo == "[null]") objvQxUsers4SynchEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
 vQxUsers4SynchDA.CheckProperty4Condition(objvQxUsers4SynchEN);
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
if (clsQxUsers4SynchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsers4SynchBL没有刷新缓存机制(clsQxUsers4SynchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvQxUsers4SynchObjLstCache == null)
//{
//arrvQxUsers4SynchObjLstCache = vQxUsers4SynchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUsers4SynchEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUsers4SynchEN._CurrTabName);
List<clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLst_Sel =
arrvQxUsers4SynchObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxUsers4SynchObjLst_Sel.Count() == 0)
{
   clsvQxUsers4SynchEN obj = clsvQxUsers4SynchBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUsers4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetAllvQxUsers4SynchObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLstCache = GetObjLstCache(); 
return arrvQxUsers4SynchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUsers4SynchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUsers4SynchEN._CurrTabName);
List<clsvQxUsers4SynchEN> arrvQxUsers4SynchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUsers4SynchObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUsers4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUsers4SynchEN> lstvQxUsers4SynchObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUsers4SynchObjLst, writer);
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
 /// <param name = "lstvQxUsers4SynchObjLst">[clsvQxUsers4SynchEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUsers4SynchEN> lstvQxUsers4SynchObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUsers4SynchBL.listXmlNode);
writer.WriteStartElement(clsvQxUsers4SynchBL.itemsXmlNode);
foreach (clsvQxUsers4SynchEN objvQxUsers4SynchEN in lstvQxUsers4SynchObjLst)
{
clsvQxUsers4SynchBL.SerializeXML(writer, objvQxUsers4SynchEN);
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
 /// <param name = "objvQxUsers4SynchEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
writer.WriteStartElement(clsvQxUsers4SynchBL.itemXmlNode);
 
writer.WriteElementString(convQxUsers4Synch.mId, objvQxUsers4SynchEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxUsers4SynchEN.IpAddress != null)
{
writer.WriteElementString(convQxUsers4Synch.IpAddress, objvQxUsers4SynchEN.IpAddress.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.UserId != null)
{
writer.WriteElementString(convQxUsers4Synch.UserId, objvQxUsers4SynchEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.UserName != null)
{
writer.WriteElementString(convQxUsers4Synch.UserName, objvQxUsers4SynchEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.UserStateId != null)
{
writer.WriteElementString(convQxUsers4Synch.UserStateId, objvQxUsers4SynchEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.UserStateName != null)
{
writer.WriteElementString(convQxUsers4Synch.UserStateName, objvQxUsers4SynchEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.IdentityId != null)
{
writer.WriteElementString(convQxUsers4Synch.IdentityId, objvQxUsers4SynchEN.IdentityId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.IdentityDesc != null)
{
writer.WriteElementString(convQxUsers4Synch.IdentityDesc, objvQxUsers4SynchEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.StuTeacherId != null)
{
writer.WriteElementString(convQxUsers4Synch.StuTeacherId, objvQxUsers4SynchEN.StuTeacherId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.Password != null)
{
writer.WriteElementString(convQxUsers4Synch.Password, objvQxUsers4SynchEN.Password.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.DepartmentId != null)
{
writer.WriteElementString(convQxUsers4Synch.DepartmentId, objvQxUsers4SynchEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.DepartmentName != null)
{
writer.WriteElementString(convQxUsers4Synch.DepartmentName, objvQxUsers4SynchEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.DepartmentAbbrName != null)
{
writer.WriteElementString(convQxUsers4Synch.DepartmentAbbrName, objvQxUsers4SynchEN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.DepartmentTypeId != null)
{
writer.WriteElementString(convQxUsers4Synch.DepartmentTypeId, objvQxUsers4SynchEN.DepartmentTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.DepartmentTypeName != null)
{
writer.WriteElementString(convQxUsers4Synch.DepartmentTypeName, objvQxUsers4SynchEN.DepartmentTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.UpDepartmentId != null)
{
writer.WriteElementString(convQxUsers4Synch.UpDepartmentId, objvQxUsers4SynchEN.UpDepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.UpDepartmentName != null)
{
writer.WriteElementString(convQxUsers4Synch.UpDepartmentName, objvQxUsers4SynchEN.UpDepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.IdXzCollege != null)
{
writer.WriteElementString(convQxUsers4Synch.IdXzCollege, objvQxUsers4SynchEN.IdXzCollege.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.EffitiveBeginDate != null)
{
writer.WriteElementString(convQxUsers4Synch.EffitiveBeginDate, objvQxUsers4SynchEN.EffitiveBeginDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.EffitiveEndDate != null)
{
writer.WriteElementString(convQxUsers4Synch.EffitiveEndDate, objvQxUsers4SynchEN.EffitiveEndDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUsers4Synch.IsAccessSynch, objvQxUsers4SynchEN.IsAccessSynch.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUsers4SynchEN.AccessSynchDate != null)
{
writer.WriteElementString(convQxUsers4Synch.AccessSynchDate, objvQxUsers4SynchEN.AccessSynchDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUsers4Synch.IsExistUserInCurr, objvQxUsers4SynchEN.IsExistUserInCurr.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convQxUsers4Synch.IsSamePwd, objvQxUsers4SynchEN.IsSamePwd.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUsers4SynchEN.UpdDate != null)
{
writer.WriteElementString(convQxUsers4Synch.UpdDate, objvQxUsers4SynchEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.UpdUser != null)
{
writer.WriteElementString(convQxUsers4Synch.UpdUser, objvQxUsers4SynchEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUsers4SynchEN.Memo != null)
{
writer.WriteElementString(convQxUsers4Synch.Memo, objvQxUsers4SynchEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxUsers4SynchEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
reader.Read();
while (!(reader.Name == clsvQxUsers4SynchBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUsers4Synch.mId))
{
objvQxUsers4SynchEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxUsers4Synch.IpAddress))
{
objvQxUsers4SynchEN.IpAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.UserId))
{
objvQxUsers4SynchEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.UserName))
{
objvQxUsers4SynchEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.UserStateId))
{
objvQxUsers4SynchEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.UserStateName))
{
objvQxUsers4SynchEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.IdentityId))
{
objvQxUsers4SynchEN.IdentityId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.IdentityDesc))
{
objvQxUsers4SynchEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.StuTeacherId))
{
objvQxUsers4SynchEN.StuTeacherId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.Password))
{
objvQxUsers4SynchEN.Password = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.DepartmentId))
{
objvQxUsers4SynchEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.DepartmentName))
{
objvQxUsers4SynchEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.DepartmentAbbrName))
{
objvQxUsers4SynchEN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.DepartmentTypeId))
{
objvQxUsers4SynchEN.DepartmentTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.DepartmentTypeName))
{
objvQxUsers4SynchEN.DepartmentTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.UpDepartmentId))
{
objvQxUsers4SynchEN.UpDepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.UpDepartmentName))
{
objvQxUsers4SynchEN.UpDepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.IdXzCollege))
{
objvQxUsers4SynchEN.IdXzCollege = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.EffitiveBeginDate))
{
objvQxUsers4SynchEN.EffitiveBeginDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.EffitiveEndDate))
{
objvQxUsers4SynchEN.EffitiveEndDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.IsAccessSynch))
{
objvQxUsers4SynchEN.IsAccessSynch = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUsers4Synch.AccessSynchDate))
{
objvQxUsers4SynchEN.AccessSynchDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.IsExistUserInCurr))
{
objvQxUsers4SynchEN.IsExistUserInCurr = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUsers4Synch.IsSamePwd))
{
objvQxUsers4SynchEN.IsSamePwd = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUsers4Synch.UpdDate))
{
objvQxUsers4SynchEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.UpdUser))
{
objvQxUsers4SynchEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUsers4Synch.Memo))
{
objvQxUsers4SynchEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUsers4SynchEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUsers4SynchObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUsers4SynchEN GetObjFromXmlStr(string strvQxUsers4SynchObjXmlStr)
{
clsvQxUsers4SynchEN objvQxUsers4SynchEN = new clsvQxUsers4SynchEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUsers4SynchObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUsers4SynchBL.itemXmlNode))
{
objvQxUsers4SynchEN = GetObjFromXml(reader);
return objvQxUsers4SynchEN;
}
}
return objvQxUsers4SynchEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUsers4SynchEN);
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
if (strInFldName != convQxUsers4Synch.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUsers4Synch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUsers4Synch.AttributeName));
throw new Exception(strMsg);
}
var objvQxUsers4Synch = clsvQxUsers4SynchBL.GetObjBymIdCache(lngmId);
if (objvQxUsers4Synch == null) return "";
return objvQxUsers4Synch[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-12-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUsers4SynchEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUsers4SynchEN objvQxUsers4SynchEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUsers4SynchEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUsers4SynchEN[strField]);
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
 /// <param name = "lstvQxUsers4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUsers4SynchEN> lstvQxUsers4SynchObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUsers4SynchObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUsers4SynchEN objvQxUsers4SynchEN in lstvQxUsers4SynchObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUsers4SynchEN);
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
int intRecCount = clsvQxUsers4SynchDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUsers4SynchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUsers4SynchDA.GetRecCount();
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
int intRecCount = clsvQxUsers4SynchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUsers4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUsers4SynchEN objvQxUsers4SynchCond)
{
List<clsvQxUsers4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUsers4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUsers4Synch.AttributeName)
{
if (objvQxUsers4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxUsers4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers4SynchCond[strFldName].ToString());
}
else
{
if (objvQxUsers4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUsers4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUsers4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUsers4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUsers4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUsers4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUsers4SynchCond[strFldName]));
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
 List<string> arrList = clsvQxUsers4SynchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUsers4SynchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUsers4SynchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}