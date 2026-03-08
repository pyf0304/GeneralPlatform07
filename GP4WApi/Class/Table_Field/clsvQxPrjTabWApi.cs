
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjTabWApi
 表名:vQxPrjTab(00140097)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:29:23
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvQxPrjTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabId(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convQxPrjTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convQxPrjTab.TabId);
objvQxPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.TabId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.TabId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.TabId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">TabName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convQxPrjTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convQxPrjTab.TabName);
objvQxPrjTabEN.TabName = strTabName; //TabName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.TabName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.TabName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.TabName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabCnName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCnName, convQxPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(strTabCnName, 200, convQxPrjTab.TabCnName);
objvQxPrjTabEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.TabCnName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.TabCnName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.TabCnName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetQxPrjId(this clsvQxPrjTabEN objvQxPrjTabEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjTab.QxPrjId);
objvQxPrjTabEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.QxPrjId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetPrjName(this clsvQxPrjTabEN objvQxPrjTabEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjTab.PrjName);
objvQxPrjTabEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.PrjName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.PrjName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.PrjName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSQLDSTypeId">数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetSQLDSTypeId(this clsvQxPrjTabEN objvQxPrjTabEN, string strSQLDSTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSQLDSTypeId, 2, convQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckFieldForeignKey(strSQLDSTypeId, 2, convQxPrjTab.SQLDSTypeId);
objvQxPrjTabEN.SQLDSTypeId = strSQLDSTypeId; //数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.SQLDSTypeId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.SQLDSTypeId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.SQLDSTypeId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeName">Sql数据源名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetSqlDsTypeName(this clsvQxPrjTabEN objvQxPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convQxPrjTab.SqlDsTypeName);
objvQxPrjTabEN.SqlDsTypeName = strSqlDsTypeName; //Sql数据源名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.SqlDsTypeName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.SqlDsTypeName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.SqlDsTypeName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabStateId(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convQxPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, convQxPrjTab.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convQxPrjTab.TabStateId);
objvQxPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.TabStateId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.TabStateId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.TabStateId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateName">表状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabStateName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convQxPrjTab.TabStateName);
objvQxPrjTabEN.TabStateName = strTabStateName; //表状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.TabStateName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.TabStateName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.TabStateName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParaTab">是否参数表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetIsParaTab(this clsvQxPrjTabEN objvQxPrjTabEN, bool bolIsParaTab, string strComparisonOp="")
	{
objvQxPrjTabEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.IsParaTab) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.IsParaTab, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.IsParaTab] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetFuncModuleAgcId(this clsvQxPrjTabEN objvQxPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convQxPrjTab.FuncModuleAgcId);
objvQxPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.FuncModuleAgcId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">模块名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetFuncModuleName(this clsvQxPrjTabEN objvQxPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxPrjTab.FuncModuleName);
objvQxPrjTabEN.FuncModuleName = strFuncModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.FuncModuleName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.FuncModuleName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.FuncModuleName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">模块英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetFuncModuleEnName(this clsvQxPrjTabEN objvQxPrjTabEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convQxPrjTab.FuncModuleEnName);
objvQxPrjTabEN.FuncModuleEnName = strFuncModuleEnName; //模块英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.FuncModuleEnName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.FuncModuleEnName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.FuncModuleEnName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOwner">拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetOwner(this clsvQxPrjTabEN objvQxPrjTabEN, string strOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwner, 50, convQxPrjTab.Owner);
objvQxPrjTabEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.Owner) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.Owner, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.Owner] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetKeyword(this clsvQxPrjTabEN objvQxPrjTabEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, convQxPrjTab.Keyword);
objvQxPrjTabEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.Keyword) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.Keyword, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.Keyword] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabTypeId(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convQxPrjTab.TabTypeId);
objvQxPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.TabTypeId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.TabTypeId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.TabTypeId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeName">表类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabTypeName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convQxPrjTab.TabTypeName);
objvQxPrjTabEN.TabTypeName = strTabTypeName; //表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.TabTypeName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.TabTypeName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.TabTypeName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetPrimaryTypeId(this clsvQxPrjTabEN objvQxPrjTabEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convQxPrjTab.PrimaryTypeId);
objvQxPrjTabEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.PrimaryTypeId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.PrimaryTypeId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.PrimaryTypeId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeName">主键类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetPrimaryTypeName(this clsvQxPrjTabEN objvQxPrjTabEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convQxPrjTab.PrimaryTypeName);
objvQxPrjTabEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.PrimaryTypeName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.PrimaryTypeName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.PrimaryTypeName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldId">关键字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetKeyFldId(this clsvQxPrjTabEN objvQxPrjTabEN, string strKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldId, 8, convQxPrjTab.KeyFldId);
objvQxPrjTabEN.KeyFldId = strKeyFldId; //关键字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.KeyFldId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.KeyFldId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.KeyFldId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldName">关键字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetKeyFldName(this clsvQxPrjTabEN objvQxPrjTabEN, string strKeyFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldName, 50, convQxPrjTab.KeyFldName);
objvQxPrjTabEN.KeyFldName = strKeyFldName; //关键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.KeyFldName) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.KeyFldName, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.KeyFldName] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetUpdUserId(this clsvQxPrjTabEN objvQxPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjTab.UpdUserId);
objvQxPrjTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.UpdUserId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.UpdUserId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.UpdUserId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetUpdDate(this clsvQxPrjTabEN objvQxPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjTab.UpdDate);
objvQxPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.UpdDate) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.UpdDate, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.UpdDate] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetMemo(this clsvQxPrjTabEN objvQxPrjTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjTab.Memo);
objvQxPrjTabEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.Memo) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.Memo, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.Memo] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate2">UpdDate2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetUpdDate2(this clsvQxPrjTabEN objvQxPrjTabEN, string strUpdDate2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate2, 14, convQxPrjTab.UpdDate2);
objvQxPrjTabEN.UpdDate2 = strUpdDate2; //UpdDate2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.UpdDate2) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.UpdDate2, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.UpdDate2] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaViewId">RelaViewId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetRelaViewId(this clsvQxPrjTabEN objvQxPrjTabEN, string strRelaViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaViewId, 8, convQxPrjTab.RelaViewId);
clsCheckSql.CheckFieldForeignKey(strRelaViewId, 8, convQxPrjTab.RelaViewId);
objvQxPrjTabEN.RelaViewId = strRelaViewId; //RelaViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjTabEN.dicFldComparisonOp.ContainsKey(convQxPrjTab.RelaViewId) == false)
{
objvQxPrjTabEN.dicFldComparisonOp.Add(convQxPrjTab.RelaViewId, strComparisonOp);
}
else
{
objvQxPrjTabEN.dicFldComparisonOp[convQxPrjTab.RelaViewId] = strComparisonOp;
}
}
return objvQxPrjTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjTabEN objvQxPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.TabId) == true)
{
string strComparisonOpTabId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.TabId, objvQxPrjTabCond.TabId, strComparisonOpTabId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.TabName) == true)
{
string strComparisonOpTabName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.TabName, objvQxPrjTabCond.TabName, strComparisonOpTabName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.TabCnName) == true)
{
string strComparisonOpTabCnName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.TabCnName, objvQxPrjTabCond.TabCnName, strComparisonOpTabCnName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.QxPrjId, objvQxPrjTabCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.PrjName, objvQxPrjTabCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.SQLDSTypeId) == true)
{
string strComparisonOpSQLDSTypeId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.SQLDSTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.SQLDSTypeId, objvQxPrjTabCond.SQLDSTypeId, strComparisonOpSQLDSTypeId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.SqlDsTypeName) == true)
{
string strComparisonOpSqlDsTypeName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.SqlDsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.SqlDsTypeName, objvQxPrjTabCond.SqlDsTypeName, strComparisonOpSqlDsTypeName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.TabStateId, objvQxPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.TabStateName) == true)
{
string strComparisonOpTabStateName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.TabStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.TabStateName, objvQxPrjTabCond.TabStateName, strComparisonOpTabStateName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.IsParaTab) == true)
{
if (objvQxPrjTabCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxPrjTab.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxPrjTab.IsParaTab);
}
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.FuncModuleAgcId, objvQxPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.FuncModuleName, objvQxPrjTabCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.FuncModuleEnName, objvQxPrjTabCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.Owner) == true)
{
string strComparisonOpOwner = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.Owner, objvQxPrjTabCond.Owner, strComparisonOpOwner);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.Keyword) == true)
{
string strComparisonOpKeyword = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.Keyword, objvQxPrjTabCond.Keyword, strComparisonOpKeyword);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.TabTypeId, objvQxPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.TabTypeName) == true)
{
string strComparisonOpTabTypeName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.TabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.TabTypeName, objvQxPrjTabCond.TabTypeName, strComparisonOpTabTypeName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.PrimaryTypeId, objvQxPrjTabCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.PrimaryTypeName, objvQxPrjTabCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.KeyFldId) == true)
{
string strComparisonOpKeyFldId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.KeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.KeyFldId, objvQxPrjTabCond.KeyFldId, strComparisonOpKeyFldId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.KeyFldName) == true)
{
string strComparisonOpKeyFldName = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.KeyFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.KeyFldName, objvQxPrjTabCond.KeyFldName, strComparisonOpKeyFldName);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.UpdUserId, objvQxPrjTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.UpdDate, objvQxPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.Memo, objvQxPrjTabCond.Memo, strComparisonOpMemo);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.UpdDate2) == true)
{
string strComparisonOpUpdDate2 = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.UpdDate2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.UpdDate2, objvQxPrjTabCond.UpdDate2, strComparisonOpUpdDate2);
}
if (objvQxPrjTabCond.IsUpdated(convQxPrjTab.RelaViewId) == true)
{
string strComparisonOpRelaViewId = objvQxPrjTabCond.dicFldComparisonOp[convQxPrjTab.RelaViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjTab.RelaViewId, objvQxPrjTabCond.RelaViewId, strComparisonOpRelaViewId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程表(vQxPrjTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjTabWApi
{
private static readonly string mstrApiControllerName = "vQxPrjTabApi";

 public clsvQxPrjTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjTabEN GetObjByTabId(string strTabId)
{
string strAction = "GetObjByTabId";
clsvQxPrjTabEN objvQxPrjTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabId"] = strTabId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPrjTabEN = JsonConvert.DeserializeObject<clsvQxPrjTabEN>(strJson);
return objvQxPrjTabEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsvQxPrjTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjTabEN objvQxPrjTabEN;
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
objvQxPrjTabEN = JsonConvert.DeserializeObject<clsvQxPrjTabEN>(strJson);
return objvQxPrjTabEN;
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
public static List<clsvQxPrjTabEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjTabEN>>(strJson);
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
 /// <param name = "arrTabId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvQxPrjTabEN> arrObjLst; 
string strAction = "GetObjLstByTabIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjTabEN>>(strJson);
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
public static List<clsvQxPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjTabEN>>(strJson);
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
public static List<clsvQxPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjTabEN>>(strJson);
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
public static List<clsvQxPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjTabEN>>(strJson);
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
public static List<clsvQxPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjTabEN>>(strJson);
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
public static bool IsExist(string strTabId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabId"] = strTabId
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
 /// <param name = "objvQxPrjTabENS">源对象</param>
 /// <param name = "objvQxPrjTabENT">目标对象</param>
 public static void CopyTo(clsvQxPrjTabEN objvQxPrjTabENS, clsvQxPrjTabEN objvQxPrjTabENT)
{
try
{
objvQxPrjTabENT.TabId = objvQxPrjTabENS.TabId; //表ID
objvQxPrjTabENT.TabName = objvQxPrjTabENS.TabName; //TabName
objvQxPrjTabENT.TabCnName = objvQxPrjTabENS.TabCnName; //表中文名
objvQxPrjTabENT.QxPrjId = objvQxPrjTabENS.QxPrjId; //项目Id
objvQxPrjTabENT.PrjName = objvQxPrjTabENS.PrjName; //工程名
objvQxPrjTabENT.SQLDSTypeId = objvQxPrjTabENS.SQLDSTypeId; //数据源类型
objvQxPrjTabENT.SqlDsTypeName = objvQxPrjTabENS.SqlDsTypeName; //Sql数据源名
objvQxPrjTabENT.TabStateId = objvQxPrjTabENS.TabStateId; //表状态ID
objvQxPrjTabENT.TabStateName = objvQxPrjTabENS.TabStateName; //表状态名称
objvQxPrjTabENT.IsParaTab = objvQxPrjTabENS.IsParaTab; //是否参数表
objvQxPrjTabENT.FuncModuleAgcId = objvQxPrjTabENS.FuncModuleAgcId; //功能模块Id
objvQxPrjTabENT.FuncModuleName = objvQxPrjTabENS.FuncModuleName; //模块名
objvQxPrjTabENT.FuncModuleEnName = objvQxPrjTabENS.FuncModuleEnName; //模块英文名
objvQxPrjTabENT.Owner = objvQxPrjTabENS.Owner; //拥有者
objvQxPrjTabENT.Keyword = objvQxPrjTabENS.Keyword; //关键字
objvQxPrjTabENT.TabTypeId = objvQxPrjTabENS.TabTypeId; //表类型Id
objvQxPrjTabENT.TabTypeName = objvQxPrjTabENS.TabTypeName; //表类型名
objvQxPrjTabENT.PrimaryTypeId = objvQxPrjTabENS.PrimaryTypeId; //主键类型ID
objvQxPrjTabENT.PrimaryTypeName = objvQxPrjTabENS.PrimaryTypeName; //主键类型名
objvQxPrjTabENT.KeyFldId = objvQxPrjTabENS.KeyFldId; //关键字段Id
objvQxPrjTabENT.KeyFldName = objvQxPrjTabENS.KeyFldName; //关键字段名
objvQxPrjTabENT.UpdUserId = objvQxPrjTabENS.UpdUserId; //修改用户Id
objvQxPrjTabENT.UpdDate = objvQxPrjTabENS.UpdDate; //修改日期
objvQxPrjTabENT.Memo = objvQxPrjTabENS.Memo; //备注
objvQxPrjTabENT.UpdDate2 = objvQxPrjTabENS.UpdDate2; //UpdDate2
objvQxPrjTabENT.RelaViewId = objvQxPrjTabENS.RelaViewId; //RelaViewId
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
public static DataTable ToDataTable(List<clsvQxPrjTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjTabEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjTabEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjTabEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjTabEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPrjTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.SQLDSTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.SqlDsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.TabStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.IsParaTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxPrjTab.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.Owner, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.TabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.PrimaryTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.KeyFldId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.KeyFldName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.UpdDate2, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjTab.RelaViewId, Type.GetType("System.String"));
foreach (clsvQxPrjTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjTab.TabId] = objInFor[convQxPrjTab.TabId];
objDR[convQxPrjTab.TabName] = objInFor[convQxPrjTab.TabName];
objDR[convQxPrjTab.TabCnName] = objInFor[convQxPrjTab.TabCnName];
objDR[convQxPrjTab.QxPrjId] = objInFor[convQxPrjTab.QxPrjId];
objDR[convQxPrjTab.PrjName] = objInFor[convQxPrjTab.PrjName];
objDR[convQxPrjTab.SQLDSTypeId] = objInFor[convQxPrjTab.SQLDSTypeId];
objDR[convQxPrjTab.SqlDsTypeName] = objInFor[convQxPrjTab.SqlDsTypeName];
objDR[convQxPrjTab.TabStateId] = objInFor[convQxPrjTab.TabStateId];
objDR[convQxPrjTab.TabStateName] = objInFor[convQxPrjTab.TabStateName];
objDR[convQxPrjTab.IsParaTab] = objInFor[convQxPrjTab.IsParaTab];
objDR[convQxPrjTab.FuncModuleAgcId] = objInFor[convQxPrjTab.FuncModuleAgcId];
objDR[convQxPrjTab.FuncModuleName] = objInFor[convQxPrjTab.FuncModuleName];
objDR[convQxPrjTab.FuncModuleEnName] = objInFor[convQxPrjTab.FuncModuleEnName];
objDR[convQxPrjTab.Owner] = objInFor[convQxPrjTab.Owner];
objDR[convQxPrjTab.Keyword] = objInFor[convQxPrjTab.Keyword];
objDR[convQxPrjTab.TabTypeId] = objInFor[convQxPrjTab.TabTypeId];
objDR[convQxPrjTab.TabTypeName] = objInFor[convQxPrjTab.TabTypeName];
objDR[convQxPrjTab.PrimaryTypeId] = objInFor[convQxPrjTab.PrimaryTypeId];
objDR[convQxPrjTab.PrimaryTypeName] = objInFor[convQxPrjTab.PrimaryTypeName];
objDR[convQxPrjTab.KeyFldId] = objInFor[convQxPrjTab.KeyFldId];
objDR[convQxPrjTab.KeyFldName] = objInFor[convQxPrjTab.KeyFldName];
objDR[convQxPrjTab.UpdUserId] = objInFor[convQxPrjTab.UpdUserId];
objDR[convQxPrjTab.UpdDate] = objInFor[convQxPrjTab.UpdDate];
objDR[convQxPrjTab.Memo] = objInFor[convQxPrjTab.Memo];
objDR[convQxPrjTab.UpdDate2] = objInFor[convQxPrjTab.UpdDate2];
objDR[convQxPrjTab.RelaViewId] = objInFor[convQxPrjTab.RelaViewId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}