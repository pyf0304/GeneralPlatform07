
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjUserRelation4SynchBL
 表名:vQxPrjUserRelation4Synch(00140094)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:03
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
public static class  clsvQxPrjUserRelation4SynchBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetObj(this K_mId_vQxPrjUserRelation4Synch myKey)
{
clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = clsvQxPrjUserRelation4SynchBL.vQxPrjUserRelation4SynchDA.GetObjBymId(myKey.Value);
return objvQxPrjUserRelation4SynchEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetIpAddress(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 23, convQxPrjUserRelation4Synch.IpAddress);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetQxPrjId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjUserRelation4Synch.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjUserRelation4Synch.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjUserRelation4Synch.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetPrjName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjUserRelation4Synch.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjUserRelation4Synch.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUserId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxPrjUserRelation4Synch.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxPrjUserRelation4Synch.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUserName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxPrjUserRelation4Synch.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxPrjUserRelation4Synch.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetDepartmentId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxPrjUserRelation4Synch.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxPrjUserRelation4Synch.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetDepartmentName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxPrjUserRelation4Synch.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxPrjUserRelation4Synch.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUserStateName(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxPrjUserRelation4Synch.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxPrjUserRelation4Synch.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetIdentityDesc(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdentityDesc, convQxPrjUserRelation4Synch.IdentityDesc);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxPrjUserRelation4Synch.IdentityDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUpdDate(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxPrjUserRelation4Synch.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjUserRelation4Synch.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetUpdUserId(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxPrjUserRelation4Synch.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjUserRelation4Synch.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelation4SynchEN SetMemo(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjUserRelation4Synch.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchENS">源对象</param>
 /// <param name = "objvQxPrjUserRelation4SynchENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchENS, clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchENT)
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
 /// <param name = "objvQxPrjUserRelation4SynchENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjUserRelation4SynchEN:objvQxPrjUserRelation4SynchENT</returns>
 public static clsvQxPrjUserRelation4SynchEN CopyTo(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchENS)
{
try
{
 clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchENT = new clsvQxPrjUserRelation4SynchEN()
{
mId = objvQxPrjUserRelation4SynchENS.mId, //流水号
IpAddress = objvQxPrjUserRelation4SynchENS.IpAddress, //IP地址
QxPrjId = objvQxPrjUserRelation4SynchENS.QxPrjId, //项目Id
PrjName = objvQxPrjUserRelation4SynchENS.PrjName, //工程名
UserId = objvQxPrjUserRelation4SynchENS.UserId, //用户ID
UserName = objvQxPrjUserRelation4SynchENS.UserName, //用户名
DepartmentId = objvQxPrjUserRelation4SynchENS.DepartmentId, //部门Id
DepartmentName = objvQxPrjUserRelation4SynchENS.DepartmentName, //部门名
UserStateName = objvQxPrjUserRelation4SynchENS.UserStateName, //用户状态名
IdentityDesc = objvQxPrjUserRelation4SynchENS.IdentityDesc, //身份描述
UpdDate = objvQxPrjUserRelation4SynchENS.UpdDate, //修改日期
UpdUserId = objvQxPrjUserRelation4SynchENS.UpdUserId, //修改用户Id
Memo = objvQxPrjUserRelation4SynchENS.Memo, //备注
};
 return objvQxPrjUserRelation4SynchENT;
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
public static void CheckProperty4Condition(this clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
 clsvQxPrjUserRelation4SynchBL.vQxPrjUserRelation4SynchDA.CheckProperty4Condition(objvQxPrjUserRelation4SynchEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjUserRelation4Synch
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程用户关系4同步(vQxPrjUserRelation4Synch)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjUserRelation4SynchBL
{
public static RelatedActions_vQxPrjUserRelation4Synch relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjUserRelation4SynchListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjUserRelation4SynchList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjUserRelation4SynchEN> arrvQxPrjUserRelation4SynchObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjUserRelation4SynchDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjUserRelation4SynchDA vQxPrjUserRelation4SynchDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjUserRelation4SynchDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjUserRelation4SynchBL()
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
if (string.IsNullOrEmpty(clsvQxPrjUserRelation4SynchEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjUserRelation4SynchEN._ConnectString);
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
objDS = vQxPrjUserRelation4SynchDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjUserRelation4SynchDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjUserRelation4SynchDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjUserRelation4Synch(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjUserRelation4SynchDA.GetDataTable_vQxPrjUserRelation4Synch(strWhereCond);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjUserRelation4SynchDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
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
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjUserRelation4SynchEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjUserRelation4SynchEN._CurrTabName);
List<clsvQxPrjUserRelation4SynchEN> arrvQxPrjUserRelation4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelation4SynchEN> arrvQxPrjUserRelation4SynchObjLst_Sel =
arrvQxPrjUserRelation4SynchObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxPrjUserRelation4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjUserRelation4SynchEN> GetSubObjLstCache(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchCond)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelation4Synch.AttributeName)
{
if (objvQxPrjUserRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelation4SynchCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelation4SynchCond[strFldName]));
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
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
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelation4SynchEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjUserRelation4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
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
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
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
public static IEnumerable<clsvQxPrjUserRelation4SynchEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchCond, string strOrderBy)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelation4Synch.AttributeName)
{
if (objvQxPrjUserRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelation4SynchCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelation4SynchCond[strFldName]));
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
public static IEnumerable<clsvQxPrjUserRelation4SynchEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchCond = JsonConvert.DeserializeObject<clsvQxPrjUserRelation4SynchEN>(objPagerPara.whereCond);
if (objvQxPrjUserRelation4SynchCond.sfFldComparisonOp == null)
{
objvQxPrjUserRelation4SynchCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjUserRelation4SynchCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjUserRelation4SynchCond.sfFldComparisonOp);
}
clsvQxPrjUserRelation4SynchBL.SetUpdFlag(objvQxPrjUserRelation4SynchCond);
 try
{
CheckProperty4Condition(objvQxPrjUserRelation4SynchCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjUserRelation4SynchBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjUserRelation4SynchCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
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
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLst = new List<clsvQxPrjUserRelation4SynchEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
try
{
objvQxPrjUserRelation4SynchEN.mId = Int32.Parse(objRow[convQxPrjUserRelation4Synch.mId].ToString().Trim()); //流水号
objvQxPrjUserRelation4SynchEN.IpAddress = objRow[convQxPrjUserRelation4Synch.IpAddress] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.IpAddress].ToString().Trim(); //IP地址
objvQxPrjUserRelation4SynchEN.QxPrjId = objRow[convQxPrjUserRelation4Synch.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelation4SynchEN.PrjName = objRow[convQxPrjUserRelation4Synch.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelation4SynchEN.UserId = objRow[convQxPrjUserRelation4Synch.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelation4SynchEN.UserName = objRow[convQxPrjUserRelation4Synch.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelation4SynchEN.DepartmentId = objRow[convQxPrjUserRelation4Synch.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelation4SynchEN.DepartmentName = objRow[convQxPrjUserRelation4Synch.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelation4SynchEN.UserStateName = objRow[convQxPrjUserRelation4Synch.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelation4SynchEN.IdentityDesc = objRow[convQxPrjUserRelation4Synch.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelation4SynchEN.UpdDate = objRow[convQxPrjUserRelation4Synch.UpdDate].ToString().Trim(); //修改日期
objvQxPrjUserRelation4SynchEN.UpdUserId = objRow[convQxPrjUserRelation4Synch.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjUserRelation4SynchEN.Memo = objRow[convQxPrjUserRelation4Synch.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation4Synch.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelation4SynchEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelation4SynchEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjUserRelation4Synch(ref clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
bool bolResult = vQxPrjUserRelation4SynchDA.GetvQxPrjUserRelation4Synch(ref objvQxPrjUserRelation4SynchEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetObjBymId(long lngmId)
{
clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = vQxPrjUserRelation4SynchDA.GetObjBymId(lngmId);
return objvQxPrjUserRelation4SynchEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = vQxPrjUserRelation4SynchDA.GetFirstObj(strWhereCond);
 return objvQxPrjUserRelation4SynchEN;
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
public static clsvQxPrjUserRelation4SynchEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = vQxPrjUserRelation4SynchDA.GetObjByDataRow(objRow);
 return objvQxPrjUserRelation4SynchEN;
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
public static clsvQxPrjUserRelation4SynchEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = vQxPrjUserRelation4SynchDA.GetObjByDataRow(objRow);
 return objvQxPrjUserRelation4SynchEN;
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
 /// <param name = "lstvQxPrjUserRelation4SynchObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetObjBymIdFromList(long lngmId, List<clsvQxPrjUserRelation4SynchEN> lstvQxPrjUserRelation4SynchObjLst)
{
foreach (clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN in lstvQxPrjUserRelation4SynchObjLst)
{
if (objvQxPrjUserRelation4SynchEN.mId == lngmId)
{
return objvQxPrjUserRelation4SynchEN;
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
 lngmId = new clsvQxPrjUserRelation4SynchDA().GetFirstID(strWhereCond);
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
 arrList = vQxPrjUserRelation4SynchDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjUserRelation4SynchDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxPrjUserRelation4SynchDA.IsExist(lngmId);
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
 bolIsExist = clsvQxPrjUserRelation4SynchDA.IsExistTable();
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
 bolIsExist = vQxPrjUserRelation4SynchDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjUserRelation4SynchEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
try
{
objvQxPrjUserRelation4SynchEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjUserRelation4SynchEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.mId = objvQxPrjUserRelation4SynchEN.mId; //流水号
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.IpAddress = objvQxPrjUserRelation4SynchEN.IpAddress == "[null]" ? null :  objvQxPrjUserRelation4SynchEN.IpAddress; //IP地址
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.QxPrjId = objvQxPrjUserRelation4SynchEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.PrjName = objvQxPrjUserRelation4SynchEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.UserId = objvQxPrjUserRelation4SynchEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.UserName = objvQxPrjUserRelation4SynchEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.DepartmentId = objvQxPrjUserRelation4SynchEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.DepartmentName = objvQxPrjUserRelation4SynchEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.UserStateName = objvQxPrjUserRelation4SynchEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.IdentityDesc = objvQxPrjUserRelation4SynchEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.UpdDate = objvQxPrjUserRelation4SynchEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.UpdUserId = objvQxPrjUserRelation4SynchEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjUserRelation4Synch.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelation4SynchEN.Memo = objvQxPrjUserRelation4SynchEN.Memo == "[null]" ? null :  objvQxPrjUserRelation4SynchEN.Memo; //备注
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
 /// <param name = "objvQxPrjUserRelation4SynchEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
try
{
if (objvQxPrjUserRelation4SynchEN.IpAddress == "[null]") objvQxPrjUserRelation4SynchEN.IpAddress = null; //IP地址
if (objvQxPrjUserRelation4SynchEN.Memo == "[null]") objvQxPrjUserRelation4SynchEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
 vQxPrjUserRelation4SynchDA.CheckProperty4Condition(objvQxPrjUserRelation4SynchEN);
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
if (clsQxPrjUserRelation4SynchBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjUserRelation4SynchBL没有刷新缓存机制(clsQxPrjUserRelation4SynchBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvQxPrjUserRelation4SynchObjLstCache == null)
//{
//arrvQxPrjUserRelation4SynchObjLstCache = vQxPrjUserRelation4SynchDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjUserRelation4SynchEN._CurrTabName);
List<clsvQxPrjUserRelation4SynchEN> arrvQxPrjUserRelation4SynchObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelation4SynchEN> arrvQxPrjUserRelation4SynchObjLst_Sel =
arrvQxPrjUserRelation4SynchObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxPrjUserRelation4SynchObjLst_Sel.Count() == 0)
{
   clsvQxPrjUserRelation4SynchEN obj = clsvQxPrjUserRelation4SynchBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjUserRelation4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjUserRelation4SynchEN> GetAllvQxPrjUserRelation4SynchObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjUserRelation4SynchEN> arrvQxPrjUserRelation4SynchObjLstCache = GetObjLstCache(); 
return arrvQxPrjUserRelation4SynchObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjUserRelation4SynchEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjUserRelation4SynchEN._CurrTabName);
List<clsvQxPrjUserRelation4SynchEN> arrvQxPrjUserRelation4SynchObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjUserRelation4SynchObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjUserRelation4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjUserRelation4SynchEN> lstvQxPrjUserRelation4SynchObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjUserRelation4SynchObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvQxPrjUserRelation4SynchObjLst">[clsvQxPrjUserRelation4SynchEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjUserRelation4SynchEN> lstvQxPrjUserRelation4SynchObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjUserRelation4SynchBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjUserRelation4SynchBL.itemsXmlNode);
foreach (clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN in lstvQxPrjUserRelation4SynchObjLst)
{
clsvQxPrjUserRelation4SynchBL.SerializeXML(writer, objvQxPrjUserRelation4SynchEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvQxPrjUserRelation4SynchEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
writer.WriteStartElement(clsvQxPrjUserRelation4SynchBL.itemXmlNode);
 
writer.WriteElementString(convQxPrjUserRelation4Synch.mId, objvQxPrjUserRelation4SynchEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxPrjUserRelation4SynchEN.IpAddress != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.IpAddress, objvQxPrjUserRelation4SynchEN.IpAddress.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.QxPrjId, objvQxPrjUserRelation4SynchEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.PrjName != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.PrjName, objvQxPrjUserRelation4SynchEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.UserId != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.UserId, objvQxPrjUserRelation4SynchEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.UserName != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.UserName, objvQxPrjUserRelation4SynchEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.DepartmentId != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.DepartmentId, objvQxPrjUserRelation4SynchEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.DepartmentName != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.DepartmentName, objvQxPrjUserRelation4SynchEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.UserStateName != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.UserStateName, objvQxPrjUserRelation4SynchEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.IdentityDesc != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.IdentityDesc, objvQxPrjUserRelation4SynchEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.UpdDate, objvQxPrjUserRelation4SynchEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.UpdUserId, objvQxPrjUserRelation4SynchEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelation4SynchEN.Memo != null)
{
writer.WriteElementString(convQxPrjUserRelation4Synch.Memo, objvQxPrjUserRelation4SynchEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
reader.Read();
while (!(reader.Name == clsvQxPrjUserRelation4SynchBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjUserRelation4Synch.mId))
{
objvQxPrjUserRelation4SynchEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.IpAddress))
{
objvQxPrjUserRelation4SynchEN.IpAddress = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.QxPrjId))
{
objvQxPrjUserRelation4SynchEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.PrjName))
{
objvQxPrjUserRelation4SynchEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.UserId))
{
objvQxPrjUserRelation4SynchEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.UserName))
{
objvQxPrjUserRelation4SynchEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.DepartmentId))
{
objvQxPrjUserRelation4SynchEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.DepartmentName))
{
objvQxPrjUserRelation4SynchEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.UserStateName))
{
objvQxPrjUserRelation4SynchEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.IdentityDesc))
{
objvQxPrjUserRelation4SynchEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.UpdDate))
{
objvQxPrjUserRelation4SynchEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.UpdUserId))
{
objvQxPrjUserRelation4SynchEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation4Synch.Memo))
{
objvQxPrjUserRelation4SynchEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxPrjUserRelation4SynchEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjUserRelation4SynchObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjUserRelation4SynchEN GetObjFromXmlStr(string strvQxPrjUserRelation4SynchObjXmlStr)
{
clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN = new clsvQxPrjUserRelation4SynchEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjUserRelation4SynchObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjUserRelation4SynchBL.itemXmlNode))
{
objvQxPrjUserRelation4SynchEN = GetObjFromXml(reader);
return objvQxPrjUserRelation4SynchEN;
}
}
return objvQxPrjUserRelation4SynchEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjUserRelation4SynchEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convQxPrjUserRelation4Synch.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjUserRelation4Synch.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjUserRelation4Synch.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjUserRelation4Synch = clsvQxPrjUserRelation4SynchBL.GetObjBymIdCache(lngmId);
if (objvQxPrjUserRelation4Synch == null) return "";
return objvQxPrjUserRelation4Synch[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjUserRelation4SynchEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjUserRelation4SynchEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvQxPrjUserRelation4SynchObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjUserRelation4SynchEN> lstvQxPrjUserRelation4SynchObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjUserRelation4SynchObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchEN in lstvQxPrjUserRelation4SynchObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjUserRelation4SynchEN);
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
int intRecCount = clsvQxPrjUserRelation4SynchDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjUserRelation4SynchDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjUserRelation4SynchDA.GetRecCount();
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
int intRecCount = clsvQxPrjUserRelation4SynchDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjUserRelation4SynchCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjUserRelation4SynchEN objvQxPrjUserRelation4SynchCond)
{
List<clsvQxPrjUserRelation4SynchEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelation4SynchEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelation4Synch.AttributeName)
{
if (objvQxPrjUserRelation4SynchCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelation4SynchCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelation4SynchCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelation4SynchCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelation4SynchCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelation4SynchCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelation4SynchCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelation4SynchCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelation4SynchCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelation4SynchCond[strFldName]));
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
 List<string> arrList = clsvQxPrjUserRelation4SynchDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjUserRelation4SynchDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjUserRelation4SynchDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}