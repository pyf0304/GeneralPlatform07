
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRelaOfPotenceAndSymbolBL
 表名:vQxRelaOfPotenceAndSymbol(00140049)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:08
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
public static class  clsvQxRelaOfPotenceAndSymbolBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObj(this K_RelaMid_vQxRelaOfPotenceAndSymbol myKey)
{
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = clsvQxRelaOfPotenceAndSymbolBL.vQxRelaOfPotenceAndSymbolDA.GetObjByRelaMid(myKey.Value);
return objvQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceTypeName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeName, convQxRelaOfPotenceAndSymbol.PotenceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxRelaOfPotenceAndSymbol.PotenceTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetQxPrjId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxRelaOfPotenceAndSymbol.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRelaOfPotenceAndSymbol.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRelaOfPotenceAndSymbol.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxRelaOfPotenceAndSymbol.PotenceId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxRelaOfPotenceAndSymbol.PotenceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxRelaOfPotenceAndSymbol.PotenceId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxRelaOfPotenceAndSymbol.PotenceName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxRelaOfPotenceAndSymbol.PotenceName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPrjName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxRelaOfPotenceAndSymbol.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxRelaOfPotenceAndSymbol.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetSymbolForProgramme(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strSymbolForProgramme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolForProgramme, convQxRelaOfPotenceAndSymbol.SymbolForProgramme);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolForProgramme, 20, convQxRelaOfPotenceAndSymbol.SymbolForProgramme);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetSymbolName(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strSymbolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolName, 200, convQxRelaOfPotenceAndSymbol.SymbolName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetMemo(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRelaOfPotenceAndSymbol.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetPotenceTypeId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strPotenceTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxRelaOfPotenceAndSymbol.PotenceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxRelaOfPotenceAndSymbol.PotenceTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetUpdDate(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQxRelaOfPotenceAndSymbol.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRelaOfPotenceAndSymbol.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetUpdUserId(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, convQxRelaOfPotenceAndSymbol.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxRelaOfPotenceAndSymbol.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRelaOfPotenceAndSymbolEN SetSymbolNum(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN, int? intSymbolNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolENS">源对象</param>
 /// <param name = "objvQxRelaOfPotenceAndSymbolENT">目标对象</param>
 public static void CopyTo(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolENS, clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolENT)
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
 /// <param name = "objvQxRelaOfPotenceAndSymbolENS">源对象</param>
 /// <returns>目标对象=>clsvQxRelaOfPotenceAndSymbolEN:objvQxRelaOfPotenceAndSymbolENT</returns>
 public static clsvQxRelaOfPotenceAndSymbolEN CopyTo(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolENS)
{
try
{
 clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolENT = new clsvQxRelaOfPotenceAndSymbolEN()
{
RelaMid = objvQxRelaOfPotenceAndSymbolENS.RelaMid, //流水号
PotenceTypeName = objvQxRelaOfPotenceAndSymbolENS.PotenceTypeName, //权限类型名
QxPrjId = objvQxRelaOfPotenceAndSymbolENS.QxPrjId, //项目Id
PotenceId = objvQxRelaOfPotenceAndSymbolENS.PotenceId, //权限ID
PotenceName = objvQxRelaOfPotenceAndSymbolENS.PotenceName, //权限名称
PrjName = objvQxRelaOfPotenceAndSymbolENS.PrjName, //工程名
SymbolForProgramme = objvQxRelaOfPotenceAndSymbolENS.SymbolForProgramme, //编程标志
SymbolName = objvQxRelaOfPotenceAndSymbolENS.SymbolName, //标志名称
Memo = objvQxRelaOfPotenceAndSymbolENS.Memo, //备注
PotenceTypeId = objvQxRelaOfPotenceAndSymbolENS.PotenceTypeId, //权限类型Id
UpdDate = objvQxRelaOfPotenceAndSymbolENS.UpdDate, //修改日期
UpdUserId = objvQxRelaOfPotenceAndSymbolENS.UpdUserId, //修改用户Id
SymbolNum = objvQxRelaOfPotenceAndSymbolENS.SymbolNum, //标志数
};
 return objvQxRelaOfPotenceAndSymbolENT;
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
public static void CheckProperty4Condition(this clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
 clsvQxRelaOfPotenceAndSymbolBL.vQxRelaOfPotenceAndSymbolDA.CheckProperty4Condition(objvQxRelaOfPotenceAndSymbolEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxRelaOfPotenceAndSymbol
{
public virtual bool UpdRelaTabDate(long lngRelaMid, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v权限编程标志关系(vQxRelaOfPotenceAndSymbol)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxRelaOfPotenceAndSymbolBL
{
public static RelatedActions_vQxRelaOfPotenceAndSymbol relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxRelaOfPotenceAndSymbolListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxRelaOfPotenceAndSymbolList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxRelaOfPotenceAndSymbolDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxRelaOfPotenceAndSymbolDA vQxRelaOfPotenceAndSymbolDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxRelaOfPotenceAndSymbolDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxRelaOfPotenceAndSymbolBL()
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
if (string.IsNullOrEmpty(clsvQxRelaOfPotenceAndSymbolEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRelaOfPotenceAndSymbolEN._ConnectString);
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
objDS = vQxRelaOfPotenceAndSymbolDA.GetDataSet(strWhereCond);
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
objDS = vQxRelaOfPotenceAndSymbolDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxRelaOfPotenceAndSymbolDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxRelaOfPotenceAndSymbol(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable_vQxRelaOfPotenceAndSymbol(strWhereCond);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable(strWhereCond);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable_Top(objTopPara);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxRelaOfPotenceAndSymbolDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrRelaMidLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRelaMidLst(List<long> arrRelaMidLst)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRelaMidLst);
 string strWhereCond = string.Format("RelaMid in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelaMidLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRelaMidLstCache(List<long> arrRelaMidLst)
{
string strKey = string.Format("{0}", clsvQxRelaOfPotenceAndSymbolEN._CurrTabName);
List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst_Sel =
arrvQxRelaOfPotenceAndSymbolObjLstCache
.Where(x => arrRelaMidLst.Contains(x.RelaMid));
return arrvQxRelaOfPotenceAndSymbolObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLst(string strWhereCond)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxRelaOfPotenceAndSymbolEN> GetSubObjLstCache(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolCond)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRelaOfPotenceAndSymbolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRelaOfPotenceAndSymbol.AttributeName)
{
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(strFldName) == false) continue;
if (objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString());
}
else
{
if (objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRelaOfPotenceAndSymbolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRelaOfPotenceAndSymbolCond[strFldName]));
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
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
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
public static IEnumerable<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolCond, string strOrderBy)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRelaOfPotenceAndSymbolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRelaOfPotenceAndSymbol.AttributeName)
{
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(strFldName) == false) continue;
if (objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString());
}
else
{
if (objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRelaOfPotenceAndSymbolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRelaOfPotenceAndSymbolCond[strFldName]));
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
public static IEnumerable<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolCond = JsonConvert.DeserializeObject<clsvQxRelaOfPotenceAndSymbolEN>(objPagerPara.whereCond);
if (objvQxRelaOfPotenceAndSymbolCond.sfFldComparisonOp == null)
{
objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp = null;
}
else
{
objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxRelaOfPotenceAndSymbolCond.sfFldComparisonOp);
}
clsvQxRelaOfPotenceAndSymbolBL.SetUpdFlag(objvQxRelaOfPotenceAndSymbolCond);
 try
{
CheckProperty4Condition(objvQxRelaOfPotenceAndSymbolCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxRelaOfPotenceAndSymbolBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxRelaOfPotenceAndSymbolCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
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
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLst = new List<clsvQxRelaOfPotenceAndSymbolEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
try
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = Int32.Parse(objRow[convQxRelaOfPotenceAndSymbol.RelaMid].ToString().Trim()); //流水号
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objRow[convQxRelaOfPotenceAndSymbol.QxPrjId].ToString().Trim(); //项目Id
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objRow[convQxRelaOfPotenceAndSymbol.PotenceId].ToString().Trim(); //权限ID
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objRow[convQxRelaOfPotenceAndSymbol.PotenceName].ToString().Trim(); //权限名称
objvQxRelaOfPotenceAndSymbolEN.PrjName = objRow[convQxRelaOfPotenceAndSymbol.PrjName].ToString().Trim(); //工程名
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objRow[convQxRelaOfPotenceAndSymbol.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objRow[convQxRelaOfPotenceAndSymbol.SymbolName] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.SymbolName].ToString().Trim(); //标志名称
objvQxRelaOfPotenceAndSymbolEN.Memo = objRow[convQxRelaOfPotenceAndSymbol.Memo] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.Memo].ToString().Trim(); //备注
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId] == DBNull.Value ? null : objRow[convQxRelaOfPotenceAndSymbol.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objRow[convQxRelaOfPotenceAndSymbol.UpdDate].ToString().Trim(); //修改日期
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objRow[convQxRelaOfPotenceAndSymbol.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objRow[convQxRelaOfPotenceAndSymbol.SymbolNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRelaOfPotenceAndSymbol.SymbolNum].ToString().Trim()); //标志数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRelaOfPotenceAndSymbolEN.RelaMid, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRelaOfPotenceAndSymbolEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRelaOfPotenceAndSymbol(ref clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
bool bolResult = vQxRelaOfPotenceAndSymbolDA.GetvQxRelaOfPotenceAndSymbol(ref objvQxRelaOfPotenceAndSymbolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngRelaMid">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByRelaMid(long lngRelaMid)
{
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = vQxRelaOfPotenceAndSymbolDA.GetObjByRelaMid(lngRelaMid);
return objvQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = vQxRelaOfPotenceAndSymbolDA.GetFirstObj(strWhereCond);
 return objvQxRelaOfPotenceAndSymbolEN;
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
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = vQxRelaOfPotenceAndSymbolDA.GetObjByDataRow(objRow);
 return objvQxRelaOfPotenceAndSymbolEN;
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
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = vQxRelaOfPotenceAndSymbolDA.GetObjByDataRow(objRow);
 return objvQxRelaOfPotenceAndSymbolEN;
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
 /// <param name = "lngRelaMid">所给的关键字</param>
 /// <param name = "lstvQxRelaOfPotenceAndSymbolObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByRelaMidFromList(long lngRelaMid, List<clsvQxRelaOfPotenceAndSymbolEN> lstvQxRelaOfPotenceAndSymbolObjLst)
{
foreach (clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN in lstvQxRelaOfPotenceAndSymbolObjLst)
{
if (objvQxRelaOfPotenceAndSymbolEN.RelaMid == lngRelaMid)
{
return objvQxRelaOfPotenceAndSymbolEN;
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
 long lngRelaMid;
 try
 {
 lngRelaMid = new clsvQxRelaOfPotenceAndSymbolDA().GetFirstID(strWhereCond);
 return lngRelaMid;
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
 arrList = vQxRelaOfPotenceAndSymbolDA.GetID(strWhereCond);
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
bool bolIsExist = vQxRelaOfPotenceAndSymbolDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngRelaMid">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngRelaMid)
{
//检测记录是否存在
bool bolIsExist = vQxRelaOfPotenceAndSymbolDA.IsExist(lngRelaMid);
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
 bolIsExist = clsvQxRelaOfPotenceAndSymbolDA.IsExistTable();
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
 bolIsExist = vQxRelaOfPotenceAndSymbolDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
try
{
objvQxRelaOfPotenceAndSymbolEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxRelaOfPotenceAndSymbolEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.RelaMid, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = objvQxRelaOfPotenceAndSymbolEN.RelaMid; //流水号
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.PotenceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = objvQxRelaOfPotenceAndSymbolEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.PotenceId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.PotenceId = objvQxRelaOfPotenceAndSymbolEN.PotenceId; //权限ID
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.PotenceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.PotenceName = objvQxRelaOfPotenceAndSymbolEN.PotenceName; //权限名称
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.PrjName = objvQxRelaOfPotenceAndSymbolEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.SymbolForProgramme, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme; //编程标志
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.SymbolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.SymbolName = objvQxRelaOfPotenceAndSymbolEN.SymbolName == "[null]" ? null :  objvQxRelaOfPotenceAndSymbolEN.SymbolName; //标志名称
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.Memo = objvQxRelaOfPotenceAndSymbolEN.Memo == "[null]" ? null :  objvQxRelaOfPotenceAndSymbolEN.Memo; //备注
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.PotenceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId == "[null]" ? null :  objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId; //权限类型Id
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.UpdDate = objvQxRelaOfPotenceAndSymbolEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = objvQxRelaOfPotenceAndSymbolEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxRelaOfPotenceAndSymbol.SymbolNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = objvQxRelaOfPotenceAndSymbolEN.SymbolNum; //标志数
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
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
try
{
if (objvQxRelaOfPotenceAndSymbolEN.SymbolName == "[null]") objvQxRelaOfPotenceAndSymbolEN.SymbolName = null; //标志名称
if (objvQxRelaOfPotenceAndSymbolEN.Memo == "[null]") objvQxRelaOfPotenceAndSymbolEN.Memo = null; //备注
if (objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId == "[null]") objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = null; //权限类型Id
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
public static void CheckProperty4Condition(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
 vQxRelaOfPotenceAndSymbolDA.CheckProperty4Condition(objvQxRelaOfPotenceAndSymbolEN);
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
if (clsQxRelaOfPotenceAndSymbolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRelaOfPotenceAndSymbolBL没有刷新缓存机制(clsQxRelaOfPotenceAndSymbolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjPotenceBL没有刷新缓存机制(clsQxPrjPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPotenceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPotenceTypeBL没有刷新缓存机制(clsQxPotenceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxViewInfoBL没有刷新缓存机制(clsQxViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxFuncModuleBL没有刷新缓存机制(clsQxFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjMenusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenusBL没有刷新缓存机制(clsQxPrjMenusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPageDispModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPageDispModeBL没有刷新缓存机制(clsQxPageDispModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjMenuSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjMenuSetBL没有刷新缓存机制(clsQxPrjMenuSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxApplicationTypeBL没有刷新缓存机制(clsQxApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjTabBL没有刷新缓存机制(clsQxPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelaMid");
//if (arrvQxRelaOfPotenceAndSymbolObjLstCache == null)
//{
//arrvQxRelaOfPotenceAndSymbolObjLstCache = vQxRelaOfPotenceAndSymbolDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngRelaMid">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObjByRelaMidCache(long lngRelaMid)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxRelaOfPotenceAndSymbolEN._CurrTabName);
List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLst_Sel =
arrvQxRelaOfPotenceAndSymbolObjLstCache
.Where(x=> x.RelaMid == lngRelaMid 
);
if (arrvQxRelaOfPotenceAndSymbolObjLst_Sel.Count() == 0)
{
   clsvQxRelaOfPotenceAndSymbolEN obj = clsvQxRelaOfPotenceAndSymbolBL.GetObjByRelaMid(lngRelaMid);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxRelaOfPotenceAndSymbolObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetAllvQxRelaOfPotenceAndSymbolObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLstCache = GetObjLstCache(); 
return arrvQxRelaOfPotenceAndSymbolObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRelaOfPotenceAndSymbolEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxRelaOfPotenceAndSymbolEN._CurrTabName);
List<clsvQxRelaOfPotenceAndSymbolEN> arrvQxRelaOfPotenceAndSymbolObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRelaOfPotenceAndSymbolObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxRelaOfPotenceAndSymbolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxRelaOfPotenceAndSymbolEN> lstvQxRelaOfPotenceAndSymbolObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxRelaOfPotenceAndSymbolObjLst, writer);
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
 /// <param name = "lstvQxRelaOfPotenceAndSymbolObjLst">[clsvQxRelaOfPotenceAndSymbolEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxRelaOfPotenceAndSymbolEN> lstvQxRelaOfPotenceAndSymbolObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxRelaOfPotenceAndSymbolBL.listXmlNode);
writer.WriteStartElement(clsvQxRelaOfPotenceAndSymbolBL.itemsXmlNode);
foreach (clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN in lstvQxRelaOfPotenceAndSymbolObjLst)
{
clsvQxRelaOfPotenceAndSymbolBL.SerializeXML(writer, objvQxRelaOfPotenceAndSymbolEN);
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
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
writer.WriteStartElement(clsvQxRelaOfPotenceAndSymbolBL.itemXmlNode);
 
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.RelaMid, objvQxRelaOfPotenceAndSymbolEN.RelaMid.ToString(CultureInfo.InvariantCulture));
 
if (objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.PotenceTypeName, objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.QxPrjId != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.QxPrjId, objvQxRelaOfPotenceAndSymbolEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.PotenceId != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.PotenceId, objvQxRelaOfPotenceAndSymbolEN.PotenceId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.PotenceName != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.PotenceName, objvQxRelaOfPotenceAndSymbolEN.PotenceName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.PrjName != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.PrjName, objvQxRelaOfPotenceAndSymbolEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.SymbolForProgramme, objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.SymbolName != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.SymbolName, objvQxRelaOfPotenceAndSymbolEN.SymbolName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.Memo != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.Memo, objvQxRelaOfPotenceAndSymbolEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.PotenceTypeId, objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.UpdDate != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.UpdDate, objvQxRelaOfPotenceAndSymbolEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRelaOfPotenceAndSymbolEN.UpdUserId != null)
{
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.UpdUserId, objvQxRelaOfPotenceAndSymbolEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRelaOfPotenceAndSymbol.SymbolNum, objvQxRelaOfPotenceAndSymbolEN.SymbolNum.ToString());
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
public static clsvQxRelaOfPotenceAndSymbolEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
reader.Read();
while (!(reader.Name == clsvQxRelaOfPotenceAndSymbolBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.RelaMid))
{
objvQxRelaOfPotenceAndSymbolEN.RelaMid = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.PotenceTypeName))
{
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.QxPrjId))
{
objvQxRelaOfPotenceAndSymbolEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.PotenceId))
{
objvQxRelaOfPotenceAndSymbolEN.PotenceId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.PotenceName))
{
objvQxRelaOfPotenceAndSymbolEN.PotenceName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.PrjName))
{
objvQxRelaOfPotenceAndSymbolEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.SymbolForProgramme))
{
objvQxRelaOfPotenceAndSymbolEN.SymbolForProgramme = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.SymbolName))
{
objvQxRelaOfPotenceAndSymbolEN.SymbolName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.Memo))
{
objvQxRelaOfPotenceAndSymbolEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.PotenceTypeId))
{
objvQxRelaOfPotenceAndSymbolEN.PotenceTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.UpdDate))
{
objvQxRelaOfPotenceAndSymbolEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.UpdUserId))
{
objvQxRelaOfPotenceAndSymbolEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRelaOfPotenceAndSymbol.SymbolNum))
{
objvQxRelaOfPotenceAndSymbolEN.SymbolNum = reader.ReadElementContentAsInt();
}
}
return objvQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxRelaOfPotenceAndSymbolObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxRelaOfPotenceAndSymbolEN GetObjFromXmlStr(string strvQxRelaOfPotenceAndSymbolObjXmlStr)
{
clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN = new clsvQxRelaOfPotenceAndSymbolEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxRelaOfPotenceAndSymbolObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxRelaOfPotenceAndSymbolBL.itemXmlNode))
{
objvQxRelaOfPotenceAndSymbolEN = GetObjFromXml(reader);
return objvQxRelaOfPotenceAndSymbolEN;
}
}
return objvQxRelaOfPotenceAndSymbolEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxRelaOfPotenceAndSymbolEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngRelaMid)
{
if (strInFldName != convQxRelaOfPotenceAndSymbol.RelaMid)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxRelaOfPotenceAndSymbol.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxRelaOfPotenceAndSymbol.AttributeName));
throw new Exception(strMsg);
}
var objvQxRelaOfPotenceAndSymbol = clsvQxRelaOfPotenceAndSymbolBL.GetObjByRelaMidCache(lngRelaMid);
if (objvQxRelaOfPotenceAndSymbol == null) return "";
return objvQxRelaOfPotenceAndSymbol[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxRelaOfPotenceAndSymbolEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxRelaOfPotenceAndSymbolEN[strField]);
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
 /// <param name = "lstvQxRelaOfPotenceAndSymbolObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxRelaOfPotenceAndSymbolEN> lstvQxRelaOfPotenceAndSymbolObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxRelaOfPotenceAndSymbolObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolEN in lstvQxRelaOfPotenceAndSymbolObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxRelaOfPotenceAndSymbolEN);
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
int intRecCount = clsvQxRelaOfPotenceAndSymbolDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxRelaOfPotenceAndSymbolDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxRelaOfPotenceAndSymbolDA.GetRecCount();
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
int intRecCount = clsvQxRelaOfPotenceAndSymbolDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxRelaOfPotenceAndSymbolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxRelaOfPotenceAndSymbolEN objvQxRelaOfPotenceAndSymbolCond)
{
List<clsvQxRelaOfPotenceAndSymbolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRelaOfPotenceAndSymbolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRelaOfPotenceAndSymbol.AttributeName)
{
if (objvQxRelaOfPotenceAndSymbolCond.IsUpdated(strFldName) == false) continue;
if (objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString());
}
else
{
if (objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRelaOfPotenceAndSymbolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRelaOfPotenceAndSymbolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRelaOfPotenceAndSymbolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRelaOfPotenceAndSymbolCond[strFldName]));
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
 List<string> arrList = clsvQxRelaOfPotenceAndSymbolDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxRelaOfPotenceAndSymbolDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxRelaOfPotenceAndSymbolDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}