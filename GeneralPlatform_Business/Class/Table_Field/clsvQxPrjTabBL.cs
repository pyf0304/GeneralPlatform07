
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjTabBL
 表名:vQxPrjTab(00140097)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:46:53
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvQxPrjTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjTabEN GetObj(this K_TabId_vQxPrjTab myKey)
{
clsvQxPrjTabEN objvQxPrjTabEN = clsvQxPrjTabBL.vQxPrjTabDA.GetObjByTabId(myKey.Value);
return objvQxPrjTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabId(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convQxPrjTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convQxPrjTab.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convQxPrjTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convQxPrjTab.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabCnName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCnName, convQxPrjTab.TabCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convQxPrjTab.TabCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetQxPrjId(this clsvQxPrjTabEN objvQxPrjTabEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjTab.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjTab.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjTab.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetPrjName(this clsvQxPrjTabEN objvQxPrjTabEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjTab.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetSQLDSTypeId(this clsvQxPrjTabEN objvQxPrjTabEN, string strSQLDSTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSQLDSTypeId, 2, convQxPrjTab.SQLDSTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSQLDSTypeId, 2, convQxPrjTab.SQLDSTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetSqlDsTypeName(this clsvQxPrjTabEN objvQxPrjTabEN, string strSqlDsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeName, 20, convQxPrjTab.SqlDsTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabStateId(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convQxPrjTab.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convQxPrjTab.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convQxPrjTab.TabStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabStateName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateName, 30, convQxPrjTab.TabStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetFuncModuleAgcId(this clsvQxPrjTabEN objvQxPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convQxPrjTab.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convQxPrjTab.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetFuncModuleName(this clsvQxPrjTabEN objvQxPrjTabEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxPrjTab.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetFuncModuleEnName(this clsvQxPrjTabEN objvQxPrjTabEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convQxPrjTab.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetOwner(this clsvQxPrjTabEN objvQxPrjTabEN, string strOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwner, 50, convQxPrjTab.Owner);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetKeyword(this clsvQxPrjTabEN objvQxPrjTabEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, convQxPrjTab.Keyword);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabTypeId(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convQxPrjTab.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convQxPrjTab.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convQxPrjTab.TabTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetTabTypeName(this clsvQxPrjTabEN objvQxPrjTabEN, string strTabTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeName, 30, convQxPrjTab.TabTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetPrimaryTypeId(this clsvQxPrjTabEN objvQxPrjTabEN, string strPrimaryTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convQxPrjTab.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convQxPrjTab.PrimaryTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetPrimaryTypeName(this clsvQxPrjTabEN objvQxPrjTabEN, string strPrimaryTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convQxPrjTab.PrimaryTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetKeyFldId(this clsvQxPrjTabEN objvQxPrjTabEN, string strKeyFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldId, 8, convQxPrjTab.KeyFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetKeyFldName(this clsvQxPrjTabEN objvQxPrjTabEN, string strKeyFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldName, 50, convQxPrjTab.KeyFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetUpdUserId(this clsvQxPrjTabEN objvQxPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxPrjTab.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetUpdDate(this clsvQxPrjTabEN objvQxPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxPrjTab.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetMemo(this clsvQxPrjTabEN objvQxPrjTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjTab.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetUpdDate2(this clsvQxPrjTabEN objvQxPrjTabEN, string strUpdDate2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate2, 14, convQxPrjTab.UpdDate2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjTabEN SetRelaViewId(this clsvQxPrjTabEN objvQxPrjTabEN, string strRelaViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaViewId, 8, convQxPrjTab.RelaViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaViewId, 8, convQxPrjTab.RelaViewId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjTabENS">源对象</param>
 /// <param name = "objvQxPrjTabENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjTabEN objvQxPrjTabENS, clsvQxPrjTabEN objvQxPrjTabENT)
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
 /// <param name = "objvQxPrjTabENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjTabEN:objvQxPrjTabENT</returns>
 public static clsvQxPrjTabEN CopyTo(this clsvQxPrjTabEN objvQxPrjTabENS)
{
try
{
 clsvQxPrjTabEN objvQxPrjTabENT = new clsvQxPrjTabEN()
{
TabId = objvQxPrjTabENS.TabId, //表ID
TabName = objvQxPrjTabENS.TabName, //TabName
TabCnName = objvQxPrjTabENS.TabCnName, //表中文名
QxPrjId = objvQxPrjTabENS.QxPrjId, //项目Id
PrjName = objvQxPrjTabENS.PrjName, //工程名
SQLDSTypeId = objvQxPrjTabENS.SQLDSTypeId, //数据源类型
SqlDsTypeName = objvQxPrjTabENS.SqlDsTypeName, //Sql数据源名
TabStateId = objvQxPrjTabENS.TabStateId, //表状态ID
TabStateName = objvQxPrjTabENS.TabStateName, //表状态名称
IsParaTab = objvQxPrjTabENS.IsParaTab, //是否参数表
FuncModuleAgcId = objvQxPrjTabENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvQxPrjTabENS.FuncModuleName, //模块名
FuncModuleEnName = objvQxPrjTabENS.FuncModuleEnName, //模块英文名
Owner = objvQxPrjTabENS.Owner, //拥有者
Keyword = objvQxPrjTabENS.Keyword, //关键字
TabTypeId = objvQxPrjTabENS.TabTypeId, //表类型Id
TabTypeName = objvQxPrjTabENS.TabTypeName, //表类型名
PrimaryTypeId = objvQxPrjTabENS.PrimaryTypeId, //主键类型ID
PrimaryTypeName = objvQxPrjTabENS.PrimaryTypeName, //主键类型名
KeyFldId = objvQxPrjTabENS.KeyFldId, //关键字段Id
KeyFldName = objvQxPrjTabENS.KeyFldName, //关键字段名
UpdUserId = objvQxPrjTabENS.UpdUserId, //修改用户Id
UpdDate = objvQxPrjTabENS.UpdDate, //修改日期
Memo = objvQxPrjTabENS.Memo, //备注
UpdDate2 = objvQxPrjTabENS.UpdDate2, //UpdDate2
RelaViewId = objvQxPrjTabENS.RelaViewId, //RelaViewId
};
 return objvQxPrjTabENT;
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
public static void CheckProperty4Condition(this clsvQxPrjTabEN objvQxPrjTabEN)
{
 clsvQxPrjTabBL.vQxPrjTabDA.CheckProperty4Condition(objvQxPrjTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjTab
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程表(vQxPrjTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjTabBL
{
public static RelatedActions_vQxPrjTab relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjTabListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjTabList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjTabEN> arrvQxPrjTabObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjTabDA vQxPrjTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjTabBL()
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
if (string.IsNullOrEmpty(clsvQxPrjTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjTabEN._ConnectString);
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
objDS = vQxPrjTabDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjTabDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjTabDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjTabDA.GetDataTable_vQxPrjTab(strWhereCond);
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
objDT = vQxPrjTabDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjTabDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjTabDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjTabDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjTabDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjTabEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjTabEN._CurrTabName);
List<clsvQxPrjTabEN> arrvQxPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjTabEN> arrvQxPrjTabObjLst_Sel =
arrvQxPrjTabObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvQxPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjTabEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
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
public static List<clsvQxPrjTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjTabEN> GetSubObjLstCache(clsvQxPrjTabEN objvQxPrjTabCond)
{
List<clsvQxPrjTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjTab.AttributeName)
{
if (objvQxPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjTabCond[strFldName].ToString());
}
else
{
if (objvQxPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjTabCond[strFldName]));
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
public static List<clsvQxPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
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
public static List<clsvQxPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
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
List<clsvQxPrjTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
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
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
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
public static List<clsvQxPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
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
public static List<clsvQxPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
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
public static IEnumerable<clsvQxPrjTabEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjTabEN objvQxPrjTabCond, string strOrderBy)
{
List<clsvQxPrjTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjTab.AttributeName)
{
if (objvQxPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjTabCond[strFldName].ToString());
}
else
{
if (objvQxPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjTabCond[strFldName]));
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
public static IEnumerable<clsvQxPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjTabEN objvQxPrjTabCond = JsonConvert.DeserializeObject<clsvQxPrjTabEN>(objPagerPara.whereCond);
if (objvQxPrjTabCond.sfFldComparisonOp == null)
{
objvQxPrjTabCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjTabCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjTabCond.sfFldComparisonOp);
}
clsvQxPrjTabBL.SetUpdFlag(objvQxPrjTabCond);
 try
{
CheckProperty4Condition(objvQxPrjTabCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjTabBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjTabCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjTabEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
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
public static List<clsvQxPrjTabEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjTabEN> arrObjLst = new List<clsvQxPrjTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
try
{
objvQxPrjTabEN.TabId = objRow[convQxPrjTab.TabId].ToString().Trim(); //表ID
objvQxPrjTabEN.TabName = objRow[convQxPrjTab.TabName].ToString().Trim(); //TabName
objvQxPrjTabEN.TabCnName = objRow[convQxPrjTab.TabCnName].ToString().Trim(); //表中文名
objvQxPrjTabEN.QxPrjId = objRow[convQxPrjTab.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjTabEN.PrjName = objRow[convQxPrjTab.PrjName] == DBNull.Value ? null : objRow[convQxPrjTab.PrjName].ToString().Trim(); //工程名
objvQxPrjTabEN.SQLDSTypeId = objRow[convQxPrjTab.SQLDSTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.SQLDSTypeId].ToString().Trim(); //数据源类型
objvQxPrjTabEN.SqlDsTypeName = objRow[convQxPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvQxPrjTabEN.TabStateId = objRow[convQxPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvQxPrjTabEN.TabStateName = objRow[convQxPrjTab.TabStateName] == DBNull.Value ? null : objRow[convQxPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvQxPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convQxPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvQxPrjTabEN.FuncModuleAgcId = objRow[convQxPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvQxPrjTabEN.FuncModuleName = objRow[convQxPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleName].ToString().Trim(); //模块名
objvQxPrjTabEN.FuncModuleEnName = objRow[convQxPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convQxPrjTab.FuncModuleEnName].ToString().Trim(); //模块英文名
objvQxPrjTabEN.Owner = objRow[convQxPrjTab.Owner] == DBNull.Value ? null : objRow[convQxPrjTab.Owner].ToString().Trim(); //拥有者
objvQxPrjTabEN.Keyword = objRow[convQxPrjTab.Keyword] == DBNull.Value ? null : objRow[convQxPrjTab.Keyword].ToString().Trim(); //关键字
objvQxPrjTabEN.TabTypeId = objRow[convQxPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvQxPrjTabEN.TabTypeName = objRow[convQxPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvQxPrjTabEN.PrimaryTypeId = objRow[convQxPrjTab.PrimaryTypeId] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvQxPrjTabEN.PrimaryTypeName = objRow[convQxPrjTab.PrimaryTypeName] == DBNull.Value ? null : objRow[convQxPrjTab.PrimaryTypeName].ToString().Trim(); //主键类型名
objvQxPrjTabEN.KeyFldId = objRow[convQxPrjTab.KeyFldId] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldId].ToString().Trim(); //关键字段Id
objvQxPrjTabEN.KeyFldName = objRow[convQxPrjTab.KeyFldName] == DBNull.Value ? null : objRow[convQxPrjTab.KeyFldName].ToString().Trim(); //关键字段名
objvQxPrjTabEN.UpdUserId = objRow[convQxPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convQxPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvQxPrjTabEN.UpdDate = objRow[convQxPrjTab.UpdDate] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate].ToString().Trim(); //修改日期
objvQxPrjTabEN.Memo = objRow[convQxPrjTab.Memo] == DBNull.Value ? null : objRow[convQxPrjTab.Memo].ToString().Trim(); //备注
objvQxPrjTabEN.UpdDate2 = objRow[convQxPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convQxPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvQxPrjTabEN.RelaViewId = objRow[convQxPrjTab.RelaViewId] == DBNull.Value ? null : objRow[convQxPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjTab(ref clsvQxPrjTabEN objvQxPrjTabEN)
{
bool bolResult = vQxPrjTabDA.GetvQxPrjTab(ref objvQxPrjTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjTabEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxPrjTabEN objvQxPrjTabEN = vQxPrjTabDA.GetObjByTabId(strTabId);
return objvQxPrjTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjTabEN objvQxPrjTabEN = vQxPrjTabDA.GetFirstObj(strWhereCond);
 return objvQxPrjTabEN;
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
public static clsvQxPrjTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjTabEN objvQxPrjTabEN = vQxPrjTabDA.GetObjByDataRow(objRow);
 return objvQxPrjTabEN;
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
public static clsvQxPrjTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjTabEN objvQxPrjTabEN = vQxPrjTabDA.GetObjByDataRow(objRow);
 return objvQxPrjTabEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstvQxPrjTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjTabEN GetObjByTabIdFromList(string strTabId, List<clsvQxPrjTabEN> lstvQxPrjTabObjLst)
{
foreach (clsvQxPrjTabEN objvQxPrjTabEN in lstvQxPrjTabObjLst)
{
if (objvQxPrjTabEN.TabId == strTabId)
{
return objvQxPrjTabEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strTabId;
 try
 {
 strTabId = new clsvQxPrjTabDA().GetFirstID(strWhereCond);
 return strTabId;
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
 arrList = vQxPrjTabDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxPrjTabDA.IsExist(strTabId);
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
 bolIsExist = clsvQxPrjTabDA.IsExistTable();
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
 bolIsExist = vQxPrjTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjTabEN objvQxPrjTabEN)
{
try
{
objvQxPrjTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.TabId = objvQxPrjTabEN.TabId; //表ID
}
if (arrFldSet.Contains(convQxPrjTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.TabName = objvQxPrjTabEN.TabName; //TabName
}
if (arrFldSet.Contains(convQxPrjTab.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.TabCnName = objvQxPrjTabEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convQxPrjTab.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.QxPrjId = objvQxPrjTabEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjTab.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.PrjName = objvQxPrjTabEN.PrjName == "[null]" ? null :  objvQxPrjTabEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjTab.SQLDSTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.SQLDSTypeId = objvQxPrjTabEN.SQLDSTypeId == "[null]" ? null :  objvQxPrjTabEN.SQLDSTypeId; //数据源类型
}
if (arrFldSet.Contains(convQxPrjTab.SqlDsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.SqlDsTypeName = objvQxPrjTabEN.SqlDsTypeName == "[null]" ? null :  objvQxPrjTabEN.SqlDsTypeName; //Sql数据源名
}
if (arrFldSet.Contains(convQxPrjTab.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.TabStateId = objvQxPrjTabEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convQxPrjTab.TabStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.TabStateName = objvQxPrjTabEN.TabStateName == "[null]" ? null :  objvQxPrjTabEN.TabStateName; //表状态名称
}
if (arrFldSet.Contains(convQxPrjTab.IsParaTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.IsParaTab = objvQxPrjTabEN.IsParaTab; //是否参数表
}
if (arrFldSet.Contains(convQxPrjTab.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.FuncModuleAgcId = objvQxPrjTabEN.FuncModuleAgcId == "[null]" ? null :  objvQxPrjTabEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convQxPrjTab.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.FuncModuleName = objvQxPrjTabEN.FuncModuleName == "[null]" ? null :  objvQxPrjTabEN.FuncModuleName; //模块名
}
if (arrFldSet.Contains(convQxPrjTab.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.FuncModuleEnName = objvQxPrjTabEN.FuncModuleEnName == "[null]" ? null :  objvQxPrjTabEN.FuncModuleEnName; //模块英文名
}
if (arrFldSet.Contains(convQxPrjTab.Owner, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.Owner = objvQxPrjTabEN.Owner == "[null]" ? null :  objvQxPrjTabEN.Owner; //拥有者
}
if (arrFldSet.Contains(convQxPrjTab.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.Keyword = objvQxPrjTabEN.Keyword == "[null]" ? null :  objvQxPrjTabEN.Keyword; //关键字
}
if (arrFldSet.Contains(convQxPrjTab.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.TabTypeId = objvQxPrjTabEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(convQxPrjTab.TabTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.TabTypeName = objvQxPrjTabEN.TabTypeName == "[null]" ? null :  objvQxPrjTabEN.TabTypeName; //表类型名
}
if (arrFldSet.Contains(convQxPrjTab.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.PrimaryTypeId = objvQxPrjTabEN.PrimaryTypeId == "[null]" ? null :  objvQxPrjTabEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(convQxPrjTab.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.PrimaryTypeName = objvQxPrjTabEN.PrimaryTypeName == "[null]" ? null :  objvQxPrjTabEN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(convQxPrjTab.KeyFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.KeyFldId = objvQxPrjTabEN.KeyFldId == "[null]" ? null :  objvQxPrjTabEN.KeyFldId; //关键字段Id
}
if (arrFldSet.Contains(convQxPrjTab.KeyFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.KeyFldName = objvQxPrjTabEN.KeyFldName == "[null]" ? null :  objvQxPrjTabEN.KeyFldName; //关键字段名
}
if (arrFldSet.Contains(convQxPrjTab.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.UpdUserId = objvQxPrjTabEN.UpdUserId == "[null]" ? null :  objvQxPrjTabEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxPrjTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.UpdDate = objvQxPrjTabEN.UpdDate == "[null]" ? null :  objvQxPrjTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxPrjTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.Memo = objvQxPrjTabEN.Memo == "[null]" ? null :  objvQxPrjTabEN.Memo; //备注
}
if (arrFldSet.Contains(convQxPrjTab.UpdDate2, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.UpdDate2 = objvQxPrjTabEN.UpdDate2 == "[null]" ? null :  objvQxPrjTabEN.UpdDate2; //UpdDate2
}
if (arrFldSet.Contains(convQxPrjTab.RelaViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjTabEN.RelaViewId = objvQxPrjTabEN.RelaViewId == "[null]" ? null :  objvQxPrjTabEN.RelaViewId; //RelaViewId
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
 /// <param name = "objvQxPrjTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjTabEN objvQxPrjTabEN)
{
try
{
if (objvQxPrjTabEN.PrjName == "[null]") objvQxPrjTabEN.PrjName = null; //工程名
if (objvQxPrjTabEN.SQLDSTypeId == "[null]") objvQxPrjTabEN.SQLDSTypeId = null; //数据源类型
if (objvQxPrjTabEN.SqlDsTypeName == "[null]") objvQxPrjTabEN.SqlDsTypeName = null; //Sql数据源名
if (objvQxPrjTabEN.TabStateName == "[null]") objvQxPrjTabEN.TabStateName = null; //表状态名称
if (objvQxPrjTabEN.FuncModuleAgcId == "[null]") objvQxPrjTabEN.FuncModuleAgcId = null; //功能模块Id
if (objvQxPrjTabEN.FuncModuleName == "[null]") objvQxPrjTabEN.FuncModuleName = null; //模块名
if (objvQxPrjTabEN.FuncModuleEnName == "[null]") objvQxPrjTabEN.FuncModuleEnName = null; //模块英文名
if (objvQxPrjTabEN.Owner == "[null]") objvQxPrjTabEN.Owner = null; //拥有者
if (objvQxPrjTabEN.Keyword == "[null]") objvQxPrjTabEN.Keyword = null; //关键字
if (objvQxPrjTabEN.TabTypeName == "[null]") objvQxPrjTabEN.TabTypeName = null; //表类型名
if (objvQxPrjTabEN.PrimaryTypeId == "[null]") objvQxPrjTabEN.PrimaryTypeId = null; //主键类型ID
if (objvQxPrjTabEN.PrimaryTypeName == "[null]") objvQxPrjTabEN.PrimaryTypeName = null; //主键类型名
if (objvQxPrjTabEN.KeyFldId == "[null]") objvQxPrjTabEN.KeyFldId = null; //关键字段Id
if (objvQxPrjTabEN.KeyFldName == "[null]") objvQxPrjTabEN.KeyFldName = null; //关键字段名
if (objvQxPrjTabEN.UpdUserId == "[null]") objvQxPrjTabEN.UpdUserId = null; //修改用户Id
if (objvQxPrjTabEN.UpdDate == "[null]") objvQxPrjTabEN.UpdDate = null; //修改日期
if (objvQxPrjTabEN.Memo == "[null]") objvQxPrjTabEN.Memo = null; //备注
if (objvQxPrjTabEN.UpdDate2 == "[null]") objvQxPrjTabEN.UpdDate2 = null; //UpdDate2
if (objvQxPrjTabEN.RelaViewId == "[null]") objvQxPrjTabEN.RelaViewId = null; //RelaViewId
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
public static void CheckProperty4Condition(clsvQxPrjTabEN objvQxPrjTabEN)
{
 vQxPrjTabDA.CheckProperty4Condition(objvQxPrjTabEN);
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
if (clsQxFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxFuncModuleBL没有刷新缓存机制(clsQxFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjTabBL没有刷新缓存机制(clsQxPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvQxPrjTabObjLstCache == null)
//{
//arrvQxPrjTabObjLstCache = vQxPrjTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjTabEN GetObjByTabIdCache(string strTabId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjTabEN._CurrTabName);
List<clsvQxPrjTabEN> arrvQxPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjTabEN> arrvQxPrjTabObjLst_Sel =
arrvQxPrjTabObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvQxPrjTabObjLst_Sel.Count() == 0)
{
   clsvQxPrjTabEN obj = clsvQxPrjTabBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjTabEN> GetAllvQxPrjTabObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjTabEN> arrvQxPrjTabObjLstCache = GetObjLstCache(); 
return arrvQxPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjTabEN._CurrTabName);
List<clsvQxPrjTabEN> arrvQxPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjTabObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:QxPrjId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrvQxPrjTabObjLst">需要排序的对象列表</param>
public static List <clsvQxPrjTabEN> GetSubSet4vQxPrjTabObjLstByQxPrjIdCache(string strQxPrjId)
{
   if (string.IsNullOrEmpty(strQxPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxPrjTabEN._CurrTabName);
List<clsvQxPrjTabEN> arrvQxPrjTabObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjTabEN> arrvQxPrjTabObjLst_Sel1 =
from objvQxPrjTabEN in arrvQxPrjTabObjLstCache
where objvQxPrjTabEN.QxPrjId == strQxPrjId
select objvQxPrjTabEN;
List <clsvQxPrjTabEN> arrvQxPrjTabObjLst_Sel = new List<clsvQxPrjTabEN>();
foreach (clsvQxPrjTabEN obj in arrvQxPrjTabObjLst_Sel1)
{
arrvQxPrjTabObjLst_Sel.Add(obj);
}
return arrvQxPrjTabObjLst_Sel;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjTabObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjTabEN> lstvQxPrjTabObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjTabObjLst, writer);
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
 /// <param name = "lstvQxPrjTabObjLst">[clsvQxPrjTabEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjTabEN> lstvQxPrjTabObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjTabBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjTabBL.itemsXmlNode);
foreach (clsvQxPrjTabEN objvQxPrjTabEN in lstvQxPrjTabObjLst)
{
clsvQxPrjTabBL.SerializeXML(writer, objvQxPrjTabEN);
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
 /// <param name = "objvQxPrjTabEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjTabEN objvQxPrjTabEN)
{
writer.WriteStartElement(clsvQxPrjTabBL.itemXmlNode);
 
if (objvQxPrjTabEN.TabId != null)
{
writer.WriteElementString(convQxPrjTab.TabId, objvQxPrjTabEN.TabId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.TabName != null)
{
writer.WriteElementString(convQxPrjTab.TabName, objvQxPrjTabEN.TabName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.TabCnName != null)
{
writer.WriteElementString(convQxPrjTab.TabCnName, objvQxPrjTabEN.TabCnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjTab.QxPrjId, objvQxPrjTabEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.PrjName != null)
{
writer.WriteElementString(convQxPrjTab.PrjName, objvQxPrjTabEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.SQLDSTypeId != null)
{
writer.WriteElementString(convQxPrjTab.SQLDSTypeId, objvQxPrjTabEN.SQLDSTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.SqlDsTypeName != null)
{
writer.WriteElementString(convQxPrjTab.SqlDsTypeName, objvQxPrjTabEN.SqlDsTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.TabStateId != null)
{
writer.WriteElementString(convQxPrjTab.TabStateId, objvQxPrjTabEN.TabStateId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.TabStateName != null)
{
writer.WriteElementString(convQxPrjTab.TabStateName, objvQxPrjTabEN.TabStateName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPrjTab.IsParaTab, objvQxPrjTabEN.IsParaTab.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxPrjTabEN.FuncModuleAgcId != null)
{
writer.WriteElementString(convQxPrjTab.FuncModuleAgcId, objvQxPrjTabEN.FuncModuleAgcId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.FuncModuleName != null)
{
writer.WriteElementString(convQxPrjTab.FuncModuleName, objvQxPrjTabEN.FuncModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.FuncModuleEnName != null)
{
writer.WriteElementString(convQxPrjTab.FuncModuleEnName, objvQxPrjTabEN.FuncModuleEnName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.Owner != null)
{
writer.WriteElementString(convQxPrjTab.Owner, objvQxPrjTabEN.Owner.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.Keyword != null)
{
writer.WriteElementString(convQxPrjTab.Keyword, objvQxPrjTabEN.Keyword.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.TabTypeId != null)
{
writer.WriteElementString(convQxPrjTab.TabTypeId, objvQxPrjTabEN.TabTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.TabTypeName != null)
{
writer.WriteElementString(convQxPrjTab.TabTypeName, objvQxPrjTabEN.TabTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.PrimaryTypeId != null)
{
writer.WriteElementString(convQxPrjTab.PrimaryTypeId, objvQxPrjTabEN.PrimaryTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.PrimaryTypeName != null)
{
writer.WriteElementString(convQxPrjTab.PrimaryTypeName, objvQxPrjTabEN.PrimaryTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.KeyFldId != null)
{
writer.WriteElementString(convQxPrjTab.KeyFldId, objvQxPrjTabEN.KeyFldId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.KeyFldName != null)
{
writer.WriteElementString(convQxPrjTab.KeyFldName, objvQxPrjTabEN.KeyFldName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.UpdUserId != null)
{
writer.WriteElementString(convQxPrjTab.UpdUserId, objvQxPrjTabEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.UpdDate != null)
{
writer.WriteElementString(convQxPrjTab.UpdDate, objvQxPrjTabEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.Memo != null)
{
writer.WriteElementString(convQxPrjTab.Memo, objvQxPrjTabEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.UpdDate2 != null)
{
writer.WriteElementString(convQxPrjTab.UpdDate2, objvQxPrjTabEN.UpdDate2.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjTabEN.RelaViewId != null)
{
writer.WriteElementString(convQxPrjTab.RelaViewId, objvQxPrjTabEN.RelaViewId.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjTabEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
reader.Read();
while (!(reader.Name == clsvQxPrjTabBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjTab.TabId))
{
objvQxPrjTabEN.TabId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.TabName))
{
objvQxPrjTabEN.TabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.TabCnName))
{
objvQxPrjTabEN.TabCnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.QxPrjId))
{
objvQxPrjTabEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.PrjName))
{
objvQxPrjTabEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.SQLDSTypeId))
{
objvQxPrjTabEN.SQLDSTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.SqlDsTypeName))
{
objvQxPrjTabEN.SqlDsTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.TabStateId))
{
objvQxPrjTabEN.TabStateId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.TabStateName))
{
objvQxPrjTabEN.TabStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.IsParaTab))
{
objvQxPrjTabEN.IsParaTab = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxPrjTab.FuncModuleAgcId))
{
objvQxPrjTabEN.FuncModuleAgcId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.FuncModuleName))
{
objvQxPrjTabEN.FuncModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.FuncModuleEnName))
{
objvQxPrjTabEN.FuncModuleEnName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.Owner))
{
objvQxPrjTabEN.Owner = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.Keyword))
{
objvQxPrjTabEN.Keyword = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.TabTypeId))
{
objvQxPrjTabEN.TabTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.TabTypeName))
{
objvQxPrjTabEN.TabTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.PrimaryTypeId))
{
objvQxPrjTabEN.PrimaryTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.PrimaryTypeName))
{
objvQxPrjTabEN.PrimaryTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.KeyFldId))
{
objvQxPrjTabEN.KeyFldId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.KeyFldName))
{
objvQxPrjTabEN.KeyFldName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.UpdUserId))
{
objvQxPrjTabEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.UpdDate))
{
objvQxPrjTabEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.Memo))
{
objvQxPrjTabEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.UpdDate2))
{
objvQxPrjTabEN.UpdDate2 = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjTab.RelaViewId))
{
objvQxPrjTabEN.RelaViewId = reader.ReadElementContentAsString();
}
}
return objvQxPrjTabEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjTabObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjTabEN GetObjFromXmlStr(string strvQxPrjTabObjXmlStr)
{
clsvQxPrjTabEN objvQxPrjTabEN = new clsvQxPrjTabEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjTabObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjTabBL.itemXmlNode))
{
objvQxPrjTabEN = GetObjFromXml(reader);
return objvQxPrjTabEN;
}
}
return objvQxPrjTabEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjTabEN objvQxPrjTabEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjTabEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTabId)
{
if (strInFldName != convQxPrjTab.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjTab.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjTab.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjTab = clsvQxPrjTabBL.GetObjByTabIdCache(strTabId);
if (objvQxPrjTab == null) return "";
return objvQxPrjTab[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjTabEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjTabEN objvQxPrjTabEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjTabEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjTabEN[strField]);
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
 /// <param name = "lstvQxPrjTabObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjTabEN> lstvQxPrjTabObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjTabObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjTabEN objvQxPrjTabEN in lstvQxPrjTabObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjTabEN);
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
int intRecCount = clsvQxPrjTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjTabDA.GetRecCount();
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
int intRecCount = clsvQxPrjTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjTabEN objvQxPrjTabCond)
{
List<clsvQxPrjTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjTab.AttributeName)
{
if (objvQxPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjTabCond[strFldName].ToString());
}
else
{
if (objvQxPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjTabCond[strFldName]));
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
 List<string> arrList = clsvQxPrjTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}