
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRelaOfPotenceAndSymbolWApi
 表名:vQxRelaOfPotenceAndSymbol(00140049)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:37:12
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
public static class  clsvQxRelaOfPotenceAndSymbolWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "lngRelaMid">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetRelaMid(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, long lngRelaMid, string strComparisonOp="")
	{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = lngRelaMid; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.RelaMid) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.RelaMid, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.RelaMid] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeName">权限类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceTypeName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxRelaOfPotenceAndSymbol.PotenceTypeName);
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxRelaOfPotenceAndSymbol.PotenceTypeName);
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = strPotenceTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.PotenceTypeName) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.PotenceTypeName, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceTypeName] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetQxPrjId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRelaOfPotenceAndSymbol.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRelaOfPotenceAndSymbol.QxPrjId);
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.QxPrjId) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.QxPrjId, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.QxPrjId] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceId">权限ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxRelaOfPotenceAndSymbol.PotenceId);
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxRelaOfPotenceAndSymbol.PotenceId);
objvQxRelaOfPotenceAndSymbolEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.PotenceId) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.PotenceId, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceId] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceName">权限名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxRelaOfPotenceAndSymbol.PotenceName);
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxRelaOfPotenceAndSymbol.PotenceName);
objvQxRelaOfPotenceAndSymbolEN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.PotenceName) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.PotenceName, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceName] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPrjName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxRelaOfPotenceAndSymbol.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxRelaOfPotenceAndSymbol.PrjName);
objvQxRelaOfPotenceAndSymbolEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.PrjName) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.PrjName, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PrjName] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolForProgramme">编程标志</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetSymbolForProgramme(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strSymbolForProgramme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolForProgramme, convQxRelaOfPotenceAndSymbol.SymbolForProgramme);
clsCheckSql.CheckFieldLen(strSymbolForProgramme, 20, convQxRelaOfPotenceAndSymbol.SymbolForProgramme);
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = strSymbolForProgramme; //编程标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.SymbolForProgramme) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.SymbolForProgramme, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.SymbolForProgramme] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolName">标志名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetSymbolName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strSymbolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSymbolName, 200, convQxRelaOfPotenceAndSymbol.SymbolName);
objvQxRelaOfPotenceAndSymbolEN.SymbolName = strSymbolName; //标志名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.SymbolName) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.SymbolName, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.SymbolName] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetMemo(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRelaOfPotenceAndSymbol.Memo);
objvQxRelaOfPotenceAndSymbolEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.Memo) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.Memo, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.Memo] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeId">权限类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceTypeId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxRelaOfPotenceAndSymbol.PotenceTypeId);
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxRelaOfPotenceAndSymbol.PotenceTypeId);
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.PotenceTypeId) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.PotenceTypeId, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceTypeId] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetUpdDate(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxRelaOfPotenceAndSymbol.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRelaOfPotenceAndSymbol.UpdDate);
objvQxRelaOfPotenceAndSymbolEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.UpdDate) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.UpdDate, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.UpdDate] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetUpdUserId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxRelaOfPotenceAndSymbol.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxRelaOfPotenceAndSymbol.UpdUserId);
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.UpdUserId) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.UpdUserId, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.UpdUserId] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "intSymbolNum">标志数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetSymbolNum(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, int intSymbolNum, string strComparisonOp="")
	{
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = intSymbolNum; //标志数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.ContainsKey(convQxRelaOfPotenceAndSymbol.SymbolNum) == false)
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp.Add(convQxRelaOfPotenceAndSymbol.SymbolNum, strComparisonOp);
}
else
{
objvQxRelaOfPotenceAndSymbolEN.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.SymbolNum] = strComparisonOp;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.RelaMid) == true)
{
string strComparisonOpRelaMid = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.RelaMid];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRelaOfPotenceAndSymbol.RelaMid, objvQxRelaOfPotenceAndSymbolCond.RelaMid, strComparisonOpRelaMid);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.PotenceTypeName) == true)
{
string strComparisonOpPotenceTypeName = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.PotenceTypeName, objvQxRelaOfPotenceAndSymbolCond.PotenceTypeName, strComparisonOpPotenceTypeName);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.QxPrjId, objvQxRelaOfPotenceAndSymbolCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.PotenceId) == true)
{
string strComparisonOpPotenceId = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.PotenceId, objvQxRelaOfPotenceAndSymbolCond.PotenceId, strComparisonOpPotenceId);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.PotenceName) == true)
{
string strComparisonOpPotenceName = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.PotenceName, objvQxRelaOfPotenceAndSymbolCond.PotenceName, strComparisonOpPotenceName);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.PrjName) == true)
{
string strComparisonOpPrjName = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.PrjName, objvQxRelaOfPotenceAndSymbolCond.PrjName, strComparisonOpPrjName);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.SymbolForProgramme) == true)
{
string strComparisonOpSymbolForProgramme = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.SymbolForProgramme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.SymbolForProgramme, objvQxRelaOfPotenceAndSymbolCond.SymbolForProgramme, strComparisonOpSymbolForProgramme);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.SymbolName) == true)
{
string strComparisonOpSymbolName = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.SymbolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.SymbolName, objvQxRelaOfPotenceAndSymbolCond.SymbolName, strComparisonOpSymbolName);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.Memo) == true)
{
string strComparisonOpMemo = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.Memo, objvQxRelaOfPotenceAndSymbolCond.Memo, strComparisonOpMemo);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.PotenceTypeId, objvQxRelaOfPotenceAndSymbolCond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.UpdDate, objvQxRelaOfPotenceAndSymbolCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRelaOfPotenceAndSymbol.UpdUserId, objvQxRelaOfPotenceAndSymbolCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(convQxRelaOfPotenceAndSymbol.SymbolNum) == true)
{
string strComparisonOpSymbolNum = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[convQxRelaOfPotenceAndSymbol.SymbolNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRelaOfPotenceAndSymbol.SymbolNum, objvQxRelaOfPotenceAndSymbolCond.SymbolNum, strComparisonOpSymbolNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v权限编程标志关系(vQxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRelaOfPotenceAndSymbolWApi
{
private static readonly string mstrApiControllerName = "vQxRelaOfPotenceAndSymbolApi";

 public clsvQxRelaOfPotenceAndSymbolWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByRelaMid(long lngRelaMid)
{
string strAction = "GetObjByRelaMid";
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxRelaOfPotenceAndSymbolEN = JsonConvert.DeserializeObject<clsvQxRelaOfPotenceAndSymbolEN>(strJson);
return objvQxRelaOfPotenceAndSymbolEN;
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
public static clsvQxRelaOfPotenceAndSymbolEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN;
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
objvQxRelaOfPotenceAndSymbolEN = JsonConvert.DeserializeObject<clsvQxRelaOfPotenceAndSymbolEN>(strJson);
return objvQxRelaOfPotenceAndSymbolEN;
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRelaOfPotenceAndSymbolEN>>(strJson);
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
 /// <param name = "arrRelaMid">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRelaMidLst(List<long> arrRelaMid)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst; 
string strAction = "GetObjLstByRelaMidLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelaMid);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRelaOfPotenceAndSymbolEN>>(strJson);
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
public static bool IsExist(long lngRelaMid)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngRelaMid"] = lngRelaMid.ToString()
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
 /// <param name = "objvQxRelaOfPotenceAndSymbolENS">源对象</param>
 /// <param name = "objvQxRelaOfPotenceAndSymbolENT">目标对象</param>
 public static void CopyTo(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolENS, clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolENT)
{
try
{
objvQxRelaOfPotenceAndSymbolENT.RelaMid = objvQxRelaOfPotenceAndSymbolENS.RelaMid; //流水号
objvQxRelaOfPotenceAndSymbolENT.PotenceTypeName = objvQxRelaOfPotenceAndSymbolENS.PotenceTypeName; //权限类型名
objvQxRelaOfPotenceAndSymbolENT.QxPrjId = objvQxRelaOfPotenceAndSymbolENS.QxPrjId; //项目Id
objvQxRelaOfPotenceAndSymbolENT.PotenceId = objvQxRelaOfPotenceAndSymbolENS.PotenceId; //权限ID
objvQxRelaOfPotenceAndSymbolENT.PotenceName = objvQxRelaOfPotenceAndSymbolENS.PotenceName; //权限名称
objvQxRelaOfPotenceAndSymbolENT.PrjName = objvQxRelaOfPotenceAndSymbolENS.PrjName; //工程名
objvQxRelaOfPotenceAndSymbolENT.SymbolForProgramme = objvQxRelaOfPotenceAndSymbolENS.SymbolForProgramme; //编程标志
objvQxRelaOfPotenceAndSymbolENT.SymbolName = objvQxRelaOfPotenceAndSymbolENS.SymbolName; //标志名称
objvQxRelaOfPotenceAndSymbolENT.Memo = objvQxRelaOfPotenceAndSymbolENS.Memo; //备注
objvQxRelaOfPotenceAndSymbolENT.PotenceTypeId = objvQxRelaOfPotenceAndSymbolENS.PotenceTypeId; //权限类型Id
objvQxRelaOfPotenceAndSymbolENT.UpdDate = objvQxRelaOfPotenceAndSymbolENS.UpdDate; //修改日期
objvQxRelaOfPotenceAndSymbolENT.UpdUserId = objvQxRelaOfPotenceAndSymbolENS.UpdUserId; //修改用户Id
objvQxRelaOfPotenceAndSymbolENT.SymbolNum = objvQxRelaOfPotenceAndSymbolENS.SymbolNum; //标志数
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
public static DataTable ToDataTable(List<clsvQxRelaOfPotenceAndSymbolEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxRelaOfPotenceAndSymbolEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxRelaOfPotenceAndSymbolEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxRelaOfPotenceAndSymbolEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxRelaOfPotenceAndSymbolEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxRelaOfPotenceAndSymbolEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxRelaOfPotenceAndSymbolEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.RelaMid, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.PotenceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.PotenceId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.PotenceName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.SymbolForProgramme, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.SymbolName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.PotenceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRelaOfPotenceAndSymbol.SymbolNum, Type.GetType("System.Int32"));
foreach (clsvQxRelaOfPotenceAndSymbolEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxRelaOfPotenceAndSymbol.RelaMid] = objInFor[convQxRelaOfPotenceAndSymbol.RelaMid];
objDR[convQxRelaOfPotenceAndSymbol.PotenceTypeName] = objInFor[convQxRelaOfPotenceAndSymbol.PotenceTypeName];
objDR[convQxRelaOfPotenceAndSymbol.QxPrjId] = objInFor[convQxRelaOfPotenceAndSymbol.QxPrjId];
objDR[convQxRelaOfPotenceAndSymbol.PotenceId] = objInFor[convQxRelaOfPotenceAndSymbol.PotenceId];
objDR[convQxRelaOfPotenceAndSymbol.PotenceName] = objInFor[convQxRelaOfPotenceAndSymbol.PotenceName];
objDR[convQxRelaOfPotenceAndSymbol.PrjName] = objInFor[convQxRelaOfPotenceAndSymbol.PrjName];
objDR[convQxRelaOfPotenceAndSymbol.SymbolForProgramme] = objInFor[convQxRelaOfPotenceAndSymbol.SymbolForProgramme];
objDR[convQxRelaOfPotenceAndSymbol.SymbolName] = objInFor[convQxRelaOfPotenceAndSymbol.SymbolName];
objDR[convQxRelaOfPotenceAndSymbol.Memo] = objInFor[convQxRelaOfPotenceAndSymbol.Memo];
objDR[convQxRelaOfPotenceAndSymbol.PotenceTypeId] = objInFor[convQxRelaOfPotenceAndSymbol.PotenceTypeId];
objDR[convQxRelaOfPotenceAndSymbol.UpdDate] = objInFor[convQxRelaOfPotenceAndSymbol.UpdDate];
objDR[convQxRelaOfPotenceAndSymbol.UpdUserId] = objInFor[convQxRelaOfPotenceAndSymbol.UpdUserId];
objDR[convQxRelaOfPotenceAndSymbol.SymbolNum] = objInFor[convQxRelaOfPotenceAndSymbol.SymbolNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}