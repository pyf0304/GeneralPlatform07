
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserCodePathBL
 表名:vQxUserCodePath(00140064)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:28
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统设置(SystemSet)
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
public static class  clsvQxUserCodePathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserCodePathEN GetObj(this K_mId_vQxUserCodePath myKey)
{
clsvQxUserCodePathEN objvQxUserCodePathEN = clsvQxUserCodePathBL.vQxUserCodePathDA.GetObjBymId(myKey.Value);
return objvQxUserCodePathEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetQxPrjId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserCodePath.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserCodePath.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserCodePath.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetPrjName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserCodePath.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserCodePath.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxUserCodePath.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxUserCodePath.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxUserCodePath.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxUserCodePath.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetCodePath(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePath, convQxUserCodePath.CodePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePath, 200, convQxUserCodePath.CodePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetCodePathBackup(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePathBackup, convQxUserCodePath.CodePathBackup);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePathBackup, 200, convQxUserCodePath.CodePathBackup);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetDepartmentId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convQxUserCodePath.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxUserCodePath.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetDepartmentName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxUserCodePath.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxUserCodePath.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetQxCodeTypeId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strQxCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxCodeTypeId, convQxUserCodePath.QxCodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxCodeTypeId, 4, convQxUserCodePath.QxCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxCodeTypeId, 4, convQxUserCodePath.QxCodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetCodeTypeName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convQxUserCodePath.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 30, convQxUserCodePath.CodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUpdUserId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxUserCodePath.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserCodePath.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUpdDate(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserCodePath.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserStateName(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxUserCodePath.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxUserCodePath.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetUserStateId(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strUserStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateId, convQxUserCodePath.UserStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateId, 2, convQxUserCodePath.UserStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserStateId, 2, convQxUserCodePath.UserStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserCodePathEN SetMemo(this clsvQxUserCodePathEN objvQxUserCodePathEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserCodePath.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserCodePathENS">源对象</param>
 /// <param name = "objvQxUserCodePathENT">目标对象</param>
 public static void CopyTo(this clsvQxUserCodePathEN objvQxUserCodePathENS, clsvQxUserCodePathEN objvQxUserCodePathENT)
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
 /// <param name = "objvQxUserCodePathENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserCodePathEN:objvQxUserCodePathENT</returns>
 public static clsvQxUserCodePathEN CopyTo(this clsvQxUserCodePathEN objvQxUserCodePathENS)
{
try
{
 clsvQxUserCodePathEN objvQxUserCodePathENT = new clsvQxUserCodePathEN()
{
mId = objvQxUserCodePathENS.mId, //流水号
QxPrjId = objvQxUserCodePathENS.QxPrjId, //项目Id
PrjName = objvQxUserCodePathENS.PrjName, //工程名
UserId = objvQxUserCodePathENS.UserId, //用户ID
UserName = objvQxUserCodePathENS.UserName, //用户名
CodePath = objvQxUserCodePathENS.CodePath, //代码路径
CodePathBackup = objvQxUserCodePathENS.CodePathBackup, //备份代码路径
DepartmentId = objvQxUserCodePathENS.DepartmentId, //部门Id
DepartmentName = objvQxUserCodePathENS.DepartmentName, //部门名
QxCodeTypeId = objvQxUserCodePathENS.QxCodeTypeId, //代码类型Id
CodeTypeName = objvQxUserCodePathENS.CodeTypeName, //代码类型名
IsTemplate = objvQxUserCodePathENS.IsTemplate, //是否模板
UpdUserId = objvQxUserCodePathENS.UpdUserId, //修改用户Id
UpdDate = objvQxUserCodePathENS.UpdDate, //修改日期
UserStateName = objvQxUserCodePathENS.UserStateName, //用户状态名
UserStateId = objvQxUserCodePathENS.UserStateId, //用户状态Id
Memo = objvQxUserCodePathENS.Memo, //备注
};
 return objvQxUserCodePathENT;
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
public static void CheckProperty4Condition(this clsvQxUserCodePathEN objvQxUserCodePathEN)
{
 clsvQxUserCodePathBL.vQxUserCodePathDA.CheckProperty4Condition(objvQxUserCodePathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserCodePath
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户生成路径(vQxUserCodePath)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserCodePathBL
{
public static RelatedActions_vQxUserCodePath relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserCodePathListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserCodePathList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserCodePathEN> arrvQxUserCodePathObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserCodePathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserCodePathDA vQxUserCodePathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserCodePathDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserCodePathBL()
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
if (string.IsNullOrEmpty(clsvQxUserCodePathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserCodePathEN._ConnectString);
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
objDS = vQxUserCodePathDA.GetDataSet(strWhereCond);
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
objDS = vQxUserCodePathDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserCodePathDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserCodePath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserCodePathDA.GetDataTable_vQxUserCodePath(strWhereCond);
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
objDT = vQxUserCodePathDA.GetDataTable(strWhereCond);
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
objDT = vQxUserCodePathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserCodePathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserCodePathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserCodePathDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserCodePathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserCodePathDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserCodePathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserCodePathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserCodePathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserCodePathDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserCodePathDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserCodePathDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUserCodePathEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
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
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserCodePathEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxUserCodePathEN._CurrTabName);
List<clsvQxUserCodePathEN> arrvQxUserCodePathObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserCodePathEN> arrvQxUserCodePathObjLst_Sel =
arrvQxUserCodePathObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxUserCodePathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserCodePathEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
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
public static List<clsvQxUserCodePathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserCodePathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserCodePathEN> GetSubObjLstCache(clsvQxUserCodePathEN objvQxUserCodePathCond)
{
List<clsvQxUserCodePathEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserCodePathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserCodePath.AttributeName)
{
if (objvQxUserCodePathCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserCodePathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserCodePathCond[strFldName].ToString());
}
else
{
if (objvQxUserCodePathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserCodePathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserCodePathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserCodePathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserCodePathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserCodePathCond[strFldName]));
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
public static List<clsvQxUserCodePathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
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
public static List<clsvQxUserCodePathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
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
List<clsvQxUserCodePathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserCodePathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserCodePathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserCodePathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
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
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
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
public static List<clsvQxUserCodePathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserCodePathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserCodePathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
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
public static List<clsvQxUserCodePathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
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
public static IEnumerable<clsvQxUserCodePathEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserCodePathEN objvQxUserCodePathCond, string strOrderBy)
{
List<clsvQxUserCodePathEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserCodePathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserCodePath.AttributeName)
{
if (objvQxUserCodePathCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserCodePathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserCodePathCond[strFldName].ToString());
}
else
{
if (objvQxUserCodePathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserCodePathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserCodePathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserCodePathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserCodePathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserCodePathCond[strFldName]));
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
public static IEnumerable<clsvQxUserCodePathEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserCodePathEN objvQxUserCodePathCond = JsonConvert.DeserializeObject<clsvQxUserCodePathEN>(objPagerPara.whereCond);
if (objvQxUserCodePathCond.sfFldComparisonOp == null)
{
objvQxUserCodePathCond.dicFldComparisonOp = null;
}
else
{
objvQxUserCodePathCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserCodePathCond.sfFldComparisonOp);
}
clsvQxUserCodePathBL.SetUpdFlag(objvQxUserCodePathCond);
 try
{
CheckProperty4Condition(objvQxUserCodePathCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserCodePathBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserCodePathCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserCodePathEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserCodePathEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
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
public static List<clsvQxUserCodePathEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserCodePathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserCodePathEN> arrObjLst = new List<clsvQxUserCodePathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
try
{
objvQxUserCodePathEN.mId = Int32.Parse(objRow[convQxUserCodePath.mId].ToString().Trim()); //流水号
objvQxUserCodePathEN.QxPrjId = objRow[convQxUserCodePath.QxPrjId].ToString().Trim(); //项目Id
objvQxUserCodePathEN.PrjName = objRow[convQxUserCodePath.PrjName].ToString().Trim(); //工程名
objvQxUserCodePathEN.UserId = objRow[convQxUserCodePath.UserId].ToString().Trim(); //用户ID
objvQxUserCodePathEN.UserName = objRow[convQxUserCodePath.UserName].ToString().Trim(); //用户名
objvQxUserCodePathEN.CodePath = objRow[convQxUserCodePath.CodePath].ToString().Trim(); //代码路径
objvQxUserCodePathEN.CodePathBackup = objRow[convQxUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvQxUserCodePathEN.DepartmentId = objRow[convQxUserCodePath.DepartmentId].ToString().Trim(); //部门Id
objvQxUserCodePathEN.DepartmentName = objRow[convQxUserCodePath.DepartmentName].ToString().Trim(); //部门名
objvQxUserCodePathEN.QxCodeTypeId = objRow[convQxUserCodePath.QxCodeTypeId].ToString().Trim(); //代码类型Id
objvQxUserCodePathEN.CodeTypeName = objRow[convQxUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvQxUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convQxUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvQxUserCodePathEN.UpdUserId = objRow[convQxUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserCodePathEN.UpdDate = objRow[convQxUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convQxUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvQxUserCodePathEN.UserStateName = objRow[convQxUserCodePath.UserStateName].ToString().Trim(); //用户状态名
objvQxUserCodePathEN.UserStateId = objRow[convQxUserCodePath.UserStateId].ToString().Trim(); //用户状态Id
objvQxUserCodePathEN.Memo = objRow[convQxUserCodePath.Memo] == DBNull.Value ? null : objRow[convQxUserCodePath.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserCodePathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserCodePath(ref clsvQxUserCodePathEN objvQxUserCodePathEN)
{
bool bolResult = vQxUserCodePathDA.GetvQxUserCodePath(ref objvQxUserCodePathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserCodePathEN GetObjBymId(long lngmId)
{
clsvQxUserCodePathEN objvQxUserCodePathEN = vQxUserCodePathDA.GetObjBymId(lngmId);
return objvQxUserCodePathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserCodePathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserCodePathEN objvQxUserCodePathEN = vQxUserCodePathDA.GetFirstObj(strWhereCond);
 return objvQxUserCodePathEN;
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
public static clsvQxUserCodePathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserCodePathEN objvQxUserCodePathEN = vQxUserCodePathDA.GetObjByDataRow(objRow);
 return objvQxUserCodePathEN;
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
public static clsvQxUserCodePathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserCodePathEN objvQxUserCodePathEN = vQxUserCodePathDA.GetObjByDataRow(objRow);
 return objvQxUserCodePathEN;
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
 /// <param name = "lstvQxUserCodePathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserCodePathEN GetObjBymIdFromList(long lngmId, List<clsvQxUserCodePathEN> lstvQxUserCodePathObjLst)
{
foreach (clsvQxUserCodePathEN objvQxUserCodePathEN in lstvQxUserCodePathObjLst)
{
if (objvQxUserCodePathEN.mId == lngmId)
{
return objvQxUserCodePathEN;
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
 lngmId = new clsvQxUserCodePathDA().GetFirstID(strWhereCond);
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
 arrList = vQxUserCodePathDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserCodePathDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUserCodePathDA.IsExist(lngmId);
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
 bolIsExist = clsvQxUserCodePathDA.IsExistTable();
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
 bolIsExist = vQxUserCodePathDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserCodePathEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserCodePathEN objvQxUserCodePathEN)
{
try
{
objvQxUserCodePathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserCodePathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserCodePath.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.mId = objvQxUserCodePathEN.mId; //流水号
}
if (arrFldSet.Contains(convQxUserCodePath.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.QxPrjId = objvQxUserCodePathEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxUserCodePath.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.PrjName = objvQxUserCodePathEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxUserCodePath.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.UserId = objvQxUserCodePathEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxUserCodePath.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.UserName = objvQxUserCodePathEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxUserCodePath.CodePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.CodePath = objvQxUserCodePathEN.CodePath; //代码路径
}
if (arrFldSet.Contains(convQxUserCodePath.CodePathBackup, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.CodePathBackup = objvQxUserCodePathEN.CodePathBackup; //备份代码路径
}
if (arrFldSet.Contains(convQxUserCodePath.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.DepartmentId = objvQxUserCodePathEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxUserCodePath.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.DepartmentName = objvQxUserCodePathEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxUserCodePath.QxCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.QxCodeTypeId = objvQxUserCodePathEN.QxCodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convQxUserCodePath.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.CodeTypeName = objvQxUserCodePathEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convQxUserCodePath.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.IsTemplate = objvQxUserCodePathEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convQxUserCodePath.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.UpdUserId = objvQxUserCodePathEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxUserCodePath.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.UpdDate = objvQxUserCodePathEN.UpdDate == "[null]" ? null :  objvQxUserCodePathEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUserCodePath.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.UserStateName = objvQxUserCodePathEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxUserCodePath.UserStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.UserStateId = objvQxUserCodePathEN.UserStateId; //用户状态Id
}
if (arrFldSet.Contains(convQxUserCodePath.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserCodePathEN.Memo = objvQxUserCodePathEN.Memo == "[null]" ? null :  objvQxUserCodePathEN.Memo; //备注
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
 /// <param name = "objvQxUserCodePathEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserCodePathEN objvQxUserCodePathEN)
{
try
{
if (objvQxUserCodePathEN.UpdDate == "[null]") objvQxUserCodePathEN.UpdDate = null; //修改日期
if (objvQxUserCodePathEN.Memo == "[null]") objvQxUserCodePathEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUserCodePathEN objvQxUserCodePathEN)
{
 vQxUserCodePathDA.CheckProperty4Condition(objvQxUserCodePathEN);
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
if (clsQxUserCodePathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserCodePathBL没有刷新缓存机制(clsQxUserCodePathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxCodeTypeBL没有刷新缓存机制(clsQxCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvQxUserCodePathObjLstCache == null)
//{
//arrvQxUserCodePathObjLstCache = vQxUserCodePathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserCodePathEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserCodePathEN._CurrTabName);
List<clsvQxUserCodePathEN> arrvQxUserCodePathObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserCodePathEN> arrvQxUserCodePathObjLst_Sel =
arrvQxUserCodePathObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxUserCodePathObjLst_Sel.Count() == 0)
{
   clsvQxUserCodePathEN obj = clsvQxUserCodePathBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserCodePathObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserCodePathEN> GetAllvQxUserCodePathObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserCodePathEN> arrvQxUserCodePathObjLstCache = GetObjLstCache(); 
return arrvQxUserCodePathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserCodePathEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserCodePathEN._CurrTabName);
List<clsvQxUserCodePathEN> arrvQxUserCodePathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserCodePathObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUserCodePathObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserCodePathEN> lstvQxUserCodePathObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserCodePathObjLst, writer);
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
 /// <param name = "lstvQxUserCodePathObjLst">[clsvQxUserCodePathEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserCodePathEN> lstvQxUserCodePathObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserCodePathBL.listXmlNode);
writer.WriteStartElement(clsvQxUserCodePathBL.itemsXmlNode);
foreach (clsvQxUserCodePathEN objvQxUserCodePathEN in lstvQxUserCodePathObjLst)
{
clsvQxUserCodePathBL.SerializeXML(writer, objvQxUserCodePathEN);
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
 /// <param name = "objvQxUserCodePathEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserCodePathEN objvQxUserCodePathEN)
{
writer.WriteStartElement(clsvQxUserCodePathBL.itemXmlNode);
 
writer.WriteElementString(convQxUserCodePath.mId, objvQxUserCodePathEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxUserCodePathEN.QxPrjId != null)
{
writer.WriteElementString(convQxUserCodePath.QxPrjId, objvQxUserCodePathEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.PrjName != null)
{
writer.WriteElementString(convQxUserCodePath.PrjName, objvQxUserCodePathEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.UserId != null)
{
writer.WriteElementString(convQxUserCodePath.UserId, objvQxUserCodePathEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.UserName != null)
{
writer.WriteElementString(convQxUserCodePath.UserName, objvQxUserCodePathEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.CodePath != null)
{
writer.WriteElementString(convQxUserCodePath.CodePath, objvQxUserCodePathEN.CodePath.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.CodePathBackup != null)
{
writer.WriteElementString(convQxUserCodePath.CodePathBackup, objvQxUserCodePathEN.CodePathBackup.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.DepartmentId != null)
{
writer.WriteElementString(convQxUserCodePath.DepartmentId, objvQxUserCodePathEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.DepartmentName != null)
{
writer.WriteElementString(convQxUserCodePath.DepartmentName, objvQxUserCodePathEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.QxCodeTypeId != null)
{
writer.WriteElementString(convQxUserCodePath.QxCodeTypeId, objvQxUserCodePathEN.QxCodeTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.CodeTypeName != null)
{
writer.WriteElementString(convQxUserCodePath.CodeTypeName, objvQxUserCodePathEN.CodeTypeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserCodePath.IsTemplate, objvQxUserCodePathEN.IsTemplate.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUserCodePathEN.UpdUserId != null)
{
writer.WriteElementString(convQxUserCodePath.UpdUserId, objvQxUserCodePathEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.UpdDate != null)
{
writer.WriteElementString(convQxUserCodePath.UpdDate, objvQxUserCodePathEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.UserStateName != null)
{
writer.WriteElementString(convQxUserCodePath.UserStateName, objvQxUserCodePathEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.UserStateId != null)
{
writer.WriteElementString(convQxUserCodePath.UserStateId, objvQxUserCodePathEN.UserStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserCodePathEN.Memo != null)
{
writer.WriteElementString(convQxUserCodePath.Memo, objvQxUserCodePathEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxUserCodePathEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
reader.Read();
while (!(reader.Name == clsvQxUserCodePathBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserCodePath.mId))
{
objvQxUserCodePathEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxUserCodePath.QxPrjId))
{
objvQxUserCodePathEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.PrjName))
{
objvQxUserCodePathEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.UserId))
{
objvQxUserCodePathEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.UserName))
{
objvQxUserCodePathEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.CodePath))
{
objvQxUserCodePathEN.CodePath = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.CodePathBackup))
{
objvQxUserCodePathEN.CodePathBackup = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.DepartmentId))
{
objvQxUserCodePathEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.DepartmentName))
{
objvQxUserCodePathEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.QxCodeTypeId))
{
objvQxUserCodePathEN.QxCodeTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.CodeTypeName))
{
objvQxUserCodePathEN.CodeTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.IsTemplate))
{
objvQxUserCodePathEN.IsTemplate = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUserCodePath.UpdUserId))
{
objvQxUserCodePathEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.UpdDate))
{
objvQxUserCodePathEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.UserStateName))
{
objvQxUserCodePathEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.UserStateId))
{
objvQxUserCodePathEN.UserStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserCodePath.Memo))
{
objvQxUserCodePathEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxUserCodePathEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserCodePathObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserCodePathEN GetObjFromXmlStr(string strvQxUserCodePathObjXmlStr)
{
clsvQxUserCodePathEN objvQxUserCodePathEN = new clsvQxUserCodePathEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserCodePathObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserCodePathBL.itemXmlNode))
{
objvQxUserCodePathEN = GetObjFromXml(reader);
return objvQxUserCodePathEN;
}
}
return objvQxUserCodePathEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserCodePathEN objvQxUserCodePathEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserCodePathEN);
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
if (strInFldName != convQxUserCodePath.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserCodePath.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserCodePath.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserCodePath = clsvQxUserCodePathBL.GetObjBymIdCache(lngmId);
if (objvQxUserCodePath == null) return "";
return objvQxUserCodePath[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserCodePathEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserCodePathEN objvQxUserCodePathEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserCodePathEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserCodePathEN[strField]);
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
 /// <param name = "lstvQxUserCodePathObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserCodePathEN> lstvQxUserCodePathObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserCodePathObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserCodePathEN objvQxUserCodePathEN in lstvQxUserCodePathObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserCodePathEN);
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
int intRecCount = clsvQxUserCodePathDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserCodePathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserCodePathDA.GetRecCount();
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
int intRecCount = clsvQxUserCodePathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserCodePathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserCodePathEN objvQxUserCodePathCond)
{
List<clsvQxUserCodePathEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserCodePathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserCodePath.AttributeName)
{
if (objvQxUserCodePathCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserCodePathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserCodePathCond[strFldName].ToString());
}
else
{
if (objvQxUserCodePathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserCodePathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserCodePathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserCodePathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserCodePathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserCodePathCond[strFldName]));
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
 List<string> arrList = clsvQxUserCodePathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserCodePathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserCodePathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}