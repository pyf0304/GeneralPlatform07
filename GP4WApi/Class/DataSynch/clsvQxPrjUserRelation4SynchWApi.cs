
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjUserRelation4SynchWApi
 表名:vQxPrjUserRelation4Synch(00140094)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:29:38
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:数据同步(DataSynch)
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

namespace GP4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxPrjUserRelation4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetmId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, long lngmId, string strComparisonOp="")
	{
objvQxPrjUserRelation4SynchEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.mId) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.mId, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.mId] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIpAddress">IP地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetIpAddress(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 23, convQxPrjUserRelation4Synch.IpAddress);
objvQxPrjUserRelation4SynchEN.IpAddress = strIpAddress; //IP地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.IpAddress) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.IpAddress, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.IpAddress] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetQxPrjId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjUserRelation4Synch.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjUserRelation4Synch.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjUserRelation4Synch.QxPrjId);
objvQxPrjUserRelation4SynchEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.QxPrjId) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetPrjName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjUserRelation4Synch.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjUserRelation4Synch.PrjName);
objvQxPrjUserRelation4SynchEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.PrjName) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.PrjName, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.PrjName] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUserId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxPrjUserRelation4Synch.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxPrjUserRelation4Synch.UserId);
objvQxPrjUserRelation4SynchEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.UserId) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.UserId, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.UserId] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUserName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxPrjUserRelation4Synch.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxPrjUserRelation4Synch.UserName);
objvQxPrjUserRelation4SynchEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.UserName) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.UserName, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.UserName] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetDepartmentId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxPrjUserRelation4Synch.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxPrjUserRelation4Synch.DepartmentId);
objvQxPrjUserRelation4SynchEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.DepartmentId) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.DepartmentId, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.DepartmentId] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetDepartmentName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxPrjUserRelation4Synch.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxPrjUserRelation4Synch.DepartmentName);
objvQxPrjUserRelation4SynchEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.DepartmentName) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.DepartmentName, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.DepartmentName] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUserStateName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxPrjUserRelation4Synch.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxPrjUserRelation4Synch.UserStateName);
objvQxPrjUserRelation4SynchEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.UserStateName) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.UserStateName, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.UserStateName] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetIdentityDesc(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxPrjUserRelation4Synch.IdentityDesc);
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxPrjUserRelation4Synch.IdentityDesc);
objvQxPrjUserRelation4SynchEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.IdentityDesc) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.IdentityDesc, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.IdentityDesc] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUpdDate(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxPrjUserRelation4Synch.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjUserRelation4Synch.UpdDate);
objvQxPrjUserRelation4SynchEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.UpdDate) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.UpdDate, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.UpdDate] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUpdUserId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjUserRelation4Synch.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjUserRelation4Synch.UpdUserId);
objvQxPrjUserRelation4SynchEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.UpdUserId) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetMemo(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjUserRelation4Synch.Memo);
objvQxPrjUserRelation4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation4Synch.Memo) == false)
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp.Add(convQxPrjUserRelation4Synch.Memo, strComparisonOp);
}
else
{
objvQxPrjUserRelation4SynchEN.dicFldComparisonOp[convQxPrjUserRelation4Synch.Memo] = strComparisonOp;
}
}
return objvQxPrjUserRelation4SynchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.mId) == true)
{
string strComparisonOpmId = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjUserRelation4Synch.mId, objvQxPrjUserRelation4SynchCond.mId, strComparisonOpmId);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.IpAddress) == true)
{
string strComparisonOpIpAddress = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.IpAddress, objvQxPrjUserRelation4SynchCond.IpAddress, strComparisonOpIpAddress);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.QxPrjId, objvQxPrjUserRelation4SynchCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.PrjName, objvQxPrjUserRelation4SynchCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.UserId) == true)
{
string strComparisonOpUserId = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.UserId, objvQxPrjUserRelation4SynchCond.UserId, strComparisonOpUserId);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.UserName) == true)
{
string strComparisonOpUserName = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.UserName, objvQxPrjUserRelation4SynchCond.UserName, strComparisonOpUserName);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.DepartmentId, objvQxPrjUserRelation4SynchCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.DepartmentName, objvQxPrjUserRelation4SynchCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.UserStateName, objvQxPrjUserRelation4SynchCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.IdentityDesc, objvQxPrjUserRelation4SynchCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.UpdDate, objvQxPrjUserRelation4SynchCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.UpdUserId, objvQxPrjUserRelation4SynchCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjUserRelation4SynchCond.IsUpdated(convQxPrjUserRelation4Synch.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[convQxPrjUserRelation4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation4Synch.Memo, objvQxPrjUserRelation4SynchCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程用户关系4同步(vQxPrjUserRelation4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjUserRelation4SynchWApi
{
private static readonly string mstrApiControllerName = "vQxPrjUserRelation4SynchApi";

 public clsvQxPrjUserRelation4SynchWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN;
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
objvQxPrjUserRelation4SynchEN = JsonConvert.DeserializeObject<clsvQxPrjUserRelation4SynchEN>(strJson);
return objvQxPrjUserRelation4SynchEN;
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
public static clsvQxPrjUserRelation4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN;
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
objvQxPrjUserRelation4SynchEN = JsonConvert.DeserializeObject<clsvQxPrjUserRelation4SynchEN>(strJson);
return objvQxPrjUserRelation4SynchEN;
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjUserRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelation4SynchEN>>(strJson);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxPrjUserRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelation4SynchEN>>(strJson);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjUserRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelation4SynchEN>>(strJson);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjUserRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelation4SynchEN>>(strJson);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjUserRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelation4SynchEN>>(strJson);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjUserRelation4SynchEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelation4SynchEN>>(strJson);
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
 /// <param name = "objvQxPrjUserRelation4SynchENS">源对象</param>
 /// <param name = "objvQxPrjUserRelation4SynchENT">目标对象</param>
 public static void CopyTo(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchENS, clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchENT)
{
try
{
objvQxPrjUserRelation4SynchENT.mId = objvQxPrjUserRelation4SynchENS.mId; //流水号
objvQxPrjUserRelation4SynchENT.IpAddress = objvQxPrjUserRelation4SynchENS.IpAddress; //IP地址
objvQxPrjUserRelation4SynchENT.QxPrjId = objvQxPrjUserRelation4SynchENS.QxPrjId; //项目Id
objvQxPrjUserRelation4SynchENT.PrjName = objvQxPrjUserRelation4SynchENS.PrjName; //工程名
objvQxPrjUserRelation4SynchENT.UserId = objvQxPrjUserRelation4SynchENS.UserId; //用户ID
objvQxPrjUserRelation4SynchENT.UserName = objvQxPrjUserRelation4SynchENS.UserName; //用户名
objvQxPrjUserRelation4SynchENT.DepartmentId = objvQxPrjUserRelation4SynchENS.DepartmentId; //部门Id
objvQxPrjUserRelation4SynchENT.DepartmentName = objvQxPrjUserRelation4SynchENS.DepartmentName; //部门名
objvQxPrjUserRelation4SynchENT.UserStateName = objvQxPrjUserRelation4SynchENS.UserStateName; //用户状态名
objvQxPrjUserRelation4SynchENT.IdentityDesc = objvQxPrjUserRelation4SynchENS.IdentityDesc; //身份描述
objvQxPrjUserRelation4SynchENT.UpdDate = objvQxPrjUserRelation4SynchENS.UpdDate; //修改日期
objvQxPrjUserRelation4SynchENT.UpdUserId = objvQxPrjUserRelation4SynchENS.UpdUserId; //修改用户Id
objvQxPrjUserRelation4SynchENT.Memo = objvQxPrjUserRelation4SynchENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxPrjUserRelation4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjUserRelation4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjUserRelation4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjUserRelation4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjUserRelation4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjUserRelation4SynchEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjUserRelation4SynchEN._CurrTabName);
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

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxPrjUserRelation4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjUserRelation4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation4Synch.Memo, Type.GetType("System.String"));
foreach (clsvQxPrjUserRelation4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjUserRelation4Synch.mId] = objInFor[convQxPrjUserRelation4Synch.mId];
objDR[convQxPrjUserRelation4Synch.IpAddress] = objInFor[convQxPrjUserRelation4Synch.IpAddress];
objDR[convQxPrjUserRelation4Synch.QxPrjId] = objInFor[convQxPrjUserRelation4Synch.QxPrjId];
objDR[convQxPrjUserRelation4Synch.PrjName] = objInFor[convQxPrjUserRelation4Synch.PrjName];
objDR[convQxPrjUserRelation4Synch.UserId] = objInFor[convQxPrjUserRelation4Synch.UserId];
objDR[convQxPrjUserRelation4Synch.UserName] = objInFor[convQxPrjUserRelation4Synch.UserName];
objDR[convQxPrjUserRelation4Synch.DepartmentId] = objInFor[convQxPrjUserRelation4Synch.DepartmentId];
objDR[convQxPrjUserRelation4Synch.DepartmentName] = objInFor[convQxPrjUserRelation4Synch.DepartmentName];
objDR[convQxPrjUserRelation4Synch.UserStateName] = objInFor[convQxPrjUserRelation4Synch.UserStateName];
objDR[convQxPrjUserRelation4Synch.IdentityDesc] = objInFor[convQxPrjUserRelation4Synch.IdentityDesc];
objDR[convQxPrjUserRelation4Synch.UpdDate] = objInFor[convQxPrjUserRelation4Synch.UpdDate];
objDR[convQxPrjUserRelation4Synch.UpdUserId] = objInFor[convQxPrjUserRelation4Synch.UpdUserId];
objDR[convQxPrjUserRelation4Synch.Memo] = objInFor[convQxPrjUserRelation4Synch.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}