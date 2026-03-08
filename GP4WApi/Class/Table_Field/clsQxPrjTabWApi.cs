
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjTabWApi
 表名:QxPrjTab(00140096)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:29:13
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
public static class  clsQxPrjTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabId(this clsQxPrjTabEN objQxPrjTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conQxPrjTab.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conQxPrjTab.TabId);
objQxPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">TabName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabName(this clsQxPrjTabEN objQxPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conQxPrjTab.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, conQxPrjTab.TabName);
objQxPrjTabEN.TabName = strTabName; //TabName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabCnName(this clsQxPrjTabEN objQxPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, conQxPrjTab.TabCnName);
objQxPrjTabEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabCnName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabCnName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabCnName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetQxPrjId(this clsQxPrjTabEN objQxPrjTabEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjTab.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjTab.QxPrjId);
objQxPrjTabEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.QxPrjId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.QxPrjId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.QxPrjId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSQLDSTypeId">数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetSQLDSTypeId(this clsQxPrjTabEN objQxPrjTabEN, string strSQLDSTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSQLDSTypeId, 2, conQxPrjTab.SQLDSTypeId);
clsCheckSql.CheckFieldForeignKey(strSQLDSTypeId, 2, conQxPrjTab.SQLDSTypeId);
objQxPrjTabEN.SQLDSTypeId = strSQLDSTypeId; //数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.SQLDSTypeId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.SQLDSTypeId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.SQLDSTypeId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabStateId(this clsQxPrjTabEN objQxPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, conQxPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, conQxPrjTab.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, conQxPrjTab.TabStateId);
objQxPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabStateId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabStateId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabStateId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParaTab">是否参数表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetIsParaTab(this clsQxPrjTabEN objQxPrjTabEN, bool bolIsParaTab, string strComparisonOp="")
	{
objQxPrjTabEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.IsParaTab) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.IsParaTab, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.IsParaTab] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetFuncModuleAgcId(this clsQxPrjTabEN objQxPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conQxPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conQxPrjTab.FuncModuleAgcId);
objQxPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.FuncModuleAgcId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOwner">拥有者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetOwner(this clsQxPrjTabEN objQxPrjTabEN, string strOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwner, 50, conQxPrjTab.Owner);
objQxPrjTabEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.Owner) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.Owner, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.Owner] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetKeyword(this clsQxPrjTabEN objQxPrjTabEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 50, conQxPrjTab.Keyword);
objQxPrjTabEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.Keyword) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.Keyword, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.Keyword] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetTabTypeId(this clsQxPrjTabEN objQxPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, conQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, conQxPrjTab.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, conQxPrjTab.TabTypeId);
objQxPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.TabTypeId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.TabTypeId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.TabTypeId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaViewId">RelaViewId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetRelaViewId(this clsQxPrjTabEN objQxPrjTabEN, string strRelaViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelaViewId, 8, conQxPrjTab.RelaViewId);
clsCheckSql.CheckFieldForeignKey(strRelaViewId, 8, conQxPrjTab.RelaViewId);
objQxPrjTabEN.RelaViewId = strRelaViewId; //RelaViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.RelaViewId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.RelaViewId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.RelaViewId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetPrimaryTypeId(this clsQxPrjTabEN objQxPrjTabEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conQxPrjTab.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conQxPrjTab.PrimaryTypeId);
objQxPrjTabEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.PrimaryTypeId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.PrimaryTypeId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.PrimaryTypeId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeName">主键类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetPrimaryTypeName(this clsQxPrjTabEN objQxPrjTabEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, conQxPrjTab.PrimaryTypeName);
objQxPrjTabEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.PrimaryTypeName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.PrimaryTypeName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.PrimaryTypeName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldId">关键字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetKeyFldId(this clsQxPrjTabEN objQxPrjTabEN, string strKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldId, 8, conQxPrjTab.KeyFldId);
objQxPrjTabEN.KeyFldId = strKeyFldId; //关键字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.KeyFldId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.KeyFldId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.KeyFldId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldName">关键字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetKeyFldName(this clsQxPrjTabEN objQxPrjTabEN, string strKeyFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldName, 50, conQxPrjTab.KeyFldName);
objQxPrjTabEN.KeyFldName = strKeyFldName; //关键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.KeyFldName) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.KeyFldName, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.KeyFldName] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetUpdUserId(this clsQxPrjTabEN objQxPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjTab.UpdUserId);
objQxPrjTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.UpdUserId) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.UpdUserId, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.UpdUserId] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetUpdDate(this clsQxPrjTabEN objQxPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjTab.UpdDate);
objQxPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.UpdDate) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.UpdDate, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.UpdDate] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetMemo(this clsQxPrjTabEN objQxPrjTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjTab.Memo);
objQxPrjTabEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.Memo) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.Memo, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.Memo] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchDate">同步日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjTabEN SetSynchDate(this clsQxPrjTabEN objQxPrjTabEN, string strSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchDate, 14, conQxPrjTab.SynchDate);
objQxPrjTabEN.SynchDate = strSynchDate; //同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjTabEN.dicFldComparisonOp.ContainsKey(conQxPrjTab.SynchDate) == false)
{
objQxPrjTabEN.dicFldComparisonOp.Add(conQxPrjTab.SynchDate, strComparisonOp);
}
else
{
objQxPrjTabEN.dicFldComparisonOp[conQxPrjTab.SynchDate] = strComparisonOp;
}
}
return objQxPrjTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjTabEN objQxPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabId) == true)
{
string strComparisonOpTabId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabId, objQxPrjTabCond.TabId, strComparisonOpTabId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabName) == true)
{
string strComparisonOpTabName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabName, objQxPrjTabCond.TabName, strComparisonOpTabName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabCnName) == true)
{
string strComparisonOpTabCnName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabCnName, objQxPrjTabCond.TabCnName, strComparisonOpTabCnName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.QxPrjId, objQxPrjTabCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.SQLDSTypeId) == true)
{
string strComparisonOpSQLDSTypeId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.SQLDSTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.SQLDSTypeId, objQxPrjTabCond.SQLDSTypeId, strComparisonOpSQLDSTypeId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabStateId, objQxPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.IsParaTab) == true)
{
if (objQxPrjTabCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxPrjTab.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxPrjTab.IsParaTab);
}
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.FuncModuleAgcId, objQxPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.Owner) == true)
{
string strComparisonOpOwner = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.Owner, objQxPrjTabCond.Owner, strComparisonOpOwner);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.Keyword) == true)
{
string strComparisonOpKeyword = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.Keyword, objQxPrjTabCond.Keyword, strComparisonOpKeyword);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.TabTypeId, objQxPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.RelaViewId) == true)
{
string strComparisonOpRelaViewId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.RelaViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.RelaViewId, objQxPrjTabCond.RelaViewId, strComparisonOpRelaViewId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.PrimaryTypeId, objQxPrjTabCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.PrimaryTypeName, objQxPrjTabCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.KeyFldId) == true)
{
string strComparisonOpKeyFldId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.KeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.KeyFldId, objQxPrjTabCond.KeyFldId, strComparisonOpKeyFldId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.KeyFldName) == true)
{
string strComparisonOpKeyFldName = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.KeyFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.KeyFldName, objQxPrjTabCond.KeyFldName, strComparisonOpKeyFldName);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.UpdUserId, objQxPrjTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.UpdDate, objQxPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.Memo) == true)
{
string strComparisonOpMemo = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.Memo, objQxPrjTabCond.Memo, strComparisonOpMemo);
}
if (objQxPrjTabCond.IsUpdated(conQxPrjTab.SynchDate) == true)
{
string strComparisonOpSynchDate = objQxPrjTabCond.dicFldComparisonOp[conQxPrjTab.SynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjTab.SynchDate, objQxPrjTabCond.SynchDate, strComparisonOpSynchDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxPrjTabEN.sfUpdFldSetStr = objQxPrjTabEN.getsfUpdFldSetStr();
clsQxPrjTabWApi.CheckPropertyNew(objQxPrjTabEN); 
bool bolResult = clsQxPrjTabWApi.UpdateRecord(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--QxPrjTab(工程表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabName_QxPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxPrjTabEN objQxPrjTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjTabEN == null) return "";
if (objQxPrjTabEN.TabId == null || objQxPrjTabEN.TabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objQxPrjTabEN.TabName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjTabEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabId !=  '{0}'", objQxPrjTabEN.TabId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objQxPrjTabEN.TabName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxPrjTabEN.QxPrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjTabEN objQxPrjTabEN)
{
 if (string.IsNullOrEmpty(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjTabWApi.IsExist(objQxPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxPrjTabWApi.CheckPropertyNew(objQxPrjTabEN); 
bool bolResult = clsQxPrjTabWApi.AddNewRecord(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjTabEN objQxPrjTabEN)
{
try
{
clsQxPrjTabWApi.CheckPropertyNew(objQxPrjTabEN); 
string strTabId = clsQxPrjTabWApi.AddNewRecordWithMaxId(objQxPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabWApi.ReFreshCache();
return strTabId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjTabEN objQxPrjTabEN, string strWhereCond)
{
try
{
clsQxPrjTabWApi.CheckPropertyNew(objQxPrjTabEN); 
bool bolResult = clsQxPrjTabWApi.UpdateWithCondition(objQxPrjTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 工程表(QxPrjTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjTabWApi
{
private static readonly string mstrApiControllerName = "QxPrjTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxPrjTabWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...","0");
List<clsQxPrjTabEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TabId";
objDDL.DataTextField="TabName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjTab.TabId); 
List<clsQxPrjTabEN> arrObjLst = clsQxPrjTabWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjTabEN objQxPrjTabEN = new clsQxPrjTabEN()
{
TabId = "0",
TabName = "选[工程表]..."
};
arrObjLst.Insert(0, objQxPrjTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjTab.TabId;
objComboBox.DisplayMember = conQxPrjTab.TabName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxPrjTabEN objQxPrjTabEN)
{
if (!Object.Equals(null, objQxPrjTabEN.TabId) && GetStrLen(objQxPrjTabEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjTabEN.TabName) && GetStrLen(objQxPrjTabEN.TabName) > 100)
{
 throw new Exception("字段[TabName]的长度不能超过100!");
}
if (!Object.Equals(null, objQxPrjTabEN.TabCnName) && GetStrLen(objQxPrjTabEN.TabCnName) > 200)
{
 throw new Exception("字段[表中文名]的长度不能超过200!");
}
if (!Object.Equals(null, objQxPrjTabEN.QxPrjId) && GetStrLen(objQxPrjTabEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjTabEN.SQLDSTypeId) && GetStrLen(objQxPrjTabEN.SQLDSTypeId) > 2)
{
 throw new Exception("字段[数据源类型]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPrjTabEN.TabStateId) && GetStrLen(objQxPrjTabEN.TabStateId) > 2)
{
 throw new Exception("字段[表状态ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPrjTabEN.FuncModuleAgcId) && GetStrLen(objQxPrjTabEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjTabEN.Owner) && GetStrLen(objQxPrjTabEN.Owner) > 50)
{
 throw new Exception("字段[拥有者]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjTabEN.Keyword) && GetStrLen(objQxPrjTabEN.Keyword) > 50)
{
 throw new Exception("字段[关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjTabEN.TabTypeId) && GetStrLen(objQxPrjTabEN.TabTypeId) > 4)
{
 throw new Exception("字段[表类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjTabEN.RelaViewId) && GetStrLen(objQxPrjTabEN.RelaViewId) > 8)
{
 throw new Exception("字段[RelaViewId]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjTabEN.PrimaryTypeId) && GetStrLen(objQxPrjTabEN.PrimaryTypeId) > 2)
{
 throw new Exception("字段[主键类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objQxPrjTabEN.PrimaryTypeName) && GetStrLen(objQxPrjTabEN.PrimaryTypeName) > 30)
{
 throw new Exception("字段[主键类型名]的长度不能超过30!");
}
if (!Object.Equals(null, objQxPrjTabEN.KeyFldId) && GetStrLen(objQxPrjTabEN.KeyFldId) > 8)
{
 throw new Exception("字段[关键字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjTabEN.KeyFldName) && GetStrLen(objQxPrjTabEN.KeyFldName) > 50)
{
 throw new Exception("字段[关键字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxPrjTabEN.UpdUserId) && GetStrLen(objQxPrjTabEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjTabEN.UpdDate) && GetStrLen(objQxPrjTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjTabEN.Memo) && GetStrLen(objQxPrjTabEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objQxPrjTabEN.SynchDate) && GetStrLen(objQxPrjTabEN.SynchDate) > 14)
{
 throw new Exception("字段[同步日期]的长度不能超过14!");
}
 objQxPrjTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjTabEN GetObjByTabId(string strTabId)
{
string strAction = "GetObjByTabId";
clsQxPrjTabEN objQxPrjTabEN;
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
objQxPrjTabEN = JsonConvert.DeserializeObject<clsQxPrjTabEN>(strJson);
return objQxPrjTabEN;
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
public static clsQxPrjTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxPrjTabEN objQxPrjTabEN;
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
objQxPrjTabEN = JsonConvert.DeserializeObject<clsQxPrjTabEN>(strJson);
return objQxPrjTabEN;
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
//该表没有使用Cache,不需要生成[GetTabNameByTabIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjTabEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjTabEN>>(strJson);
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
public static List<clsQxPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjTabEN>>(strJson);
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
public static List<clsQxPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjTabEN>>(strJson);
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
public static List<clsQxPrjTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjTabEN>>(strJson);
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
public static List<clsQxPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjTabEN>>(strJson);
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
public static List<clsQxPrjTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxPrjTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjTabEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strTabId)
{
string strAction = "DelRecord";
try
{
 clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabWApi.GetObjByTabId(strTabId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTabId.ToString(), out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxPrjTabs(List<string> arrTabId)
{
string strAction = "DelQxPrjTabs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelQxPrjTabsByCond(string strWhereCond)
{
string strAction = "DelQxPrjTabsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsQxPrjTabEN objQxPrjTabEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjTabEN>(objQxPrjTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsQxPrjTabEN objQxPrjTabEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjTabEN>(objQxPrjTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strTabId = (string)jobjReturn0["returnStr"];
return strTabId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsQxPrjTabEN objQxPrjTabEN)
{
if (string.IsNullOrEmpty(objQxPrjTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjTabEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjTabEN>(objQxPrjTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objQxPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxPrjTabEN objQxPrjTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxPrjTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjTabEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjTabEN.TabId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjTabEN>(objQxPrjTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objQxPrjTabENS">源对象</param>
 /// <param name = "objQxPrjTabENT">目标对象</param>
 public static void CopyTo(clsQxPrjTabEN objQxPrjTabENS, clsQxPrjTabEN objQxPrjTabENT)
{
try
{
objQxPrjTabENT.TabId = objQxPrjTabENS.TabId; //表ID
objQxPrjTabENT.TabName = objQxPrjTabENS.TabName; //TabName
objQxPrjTabENT.TabCnName = objQxPrjTabENS.TabCnName; //表中文名
objQxPrjTabENT.QxPrjId = objQxPrjTabENS.QxPrjId; //项目Id
objQxPrjTabENT.SQLDSTypeId = objQxPrjTabENS.SQLDSTypeId; //数据源类型
objQxPrjTabENT.TabStateId = objQxPrjTabENS.TabStateId; //表状态ID
objQxPrjTabENT.IsParaTab = objQxPrjTabENS.IsParaTab; //是否参数表
objQxPrjTabENT.FuncModuleAgcId = objQxPrjTabENS.FuncModuleAgcId; //功能模块Id
objQxPrjTabENT.Owner = objQxPrjTabENS.Owner; //拥有者
objQxPrjTabENT.Keyword = objQxPrjTabENS.Keyword; //关键字
objQxPrjTabENT.TabTypeId = objQxPrjTabENS.TabTypeId; //表类型Id
objQxPrjTabENT.RelaViewId = objQxPrjTabENS.RelaViewId; //RelaViewId
objQxPrjTabENT.PrimaryTypeId = objQxPrjTabENS.PrimaryTypeId; //主键类型ID
objQxPrjTabENT.PrimaryTypeName = objQxPrjTabENS.PrimaryTypeName; //主键类型名
objQxPrjTabENT.KeyFldId = objQxPrjTabENS.KeyFldId; //关键字段Id
objQxPrjTabENT.KeyFldName = objQxPrjTabENS.KeyFldName; //关键字段名
objQxPrjTabENT.UpdUserId = objQxPrjTabENS.UpdUserId; //修改用户Id
objQxPrjTabENT.UpdDate = objQxPrjTabENS.UpdDate; //修改日期
objQxPrjTabENT.Memo = objQxPrjTabENS.Memo; //备注
objQxPrjTabENT.SynchDate = objQxPrjTabENS.SynchDate; //同步日期
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
public static DataTable ToDataTable(List<clsQxPrjTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxPrjTabEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxPrjTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxPrjTabEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxPrjTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxPrjTabEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxPrjTabEN._CurrTabName);
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

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQxPrjTabWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjTabWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxPrjTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxPrjTab.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.TabName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.SQLDSTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.IsParaTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxPrjTab.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.Owner, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.RelaViewId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.PrimaryTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.KeyFldId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.KeyFldName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjTab.SynchDate, Type.GetType("System.String"));
foreach (clsQxPrjTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxPrjTab.TabId] = objInFor[conQxPrjTab.TabId];
objDR[conQxPrjTab.TabName] = objInFor[conQxPrjTab.TabName];
objDR[conQxPrjTab.TabCnName] = objInFor[conQxPrjTab.TabCnName];
objDR[conQxPrjTab.QxPrjId] = objInFor[conQxPrjTab.QxPrjId];
objDR[conQxPrjTab.SQLDSTypeId] = objInFor[conQxPrjTab.SQLDSTypeId];
objDR[conQxPrjTab.TabStateId] = objInFor[conQxPrjTab.TabStateId];
objDR[conQxPrjTab.IsParaTab] = objInFor[conQxPrjTab.IsParaTab];
objDR[conQxPrjTab.FuncModuleAgcId] = objInFor[conQxPrjTab.FuncModuleAgcId];
objDR[conQxPrjTab.Owner] = objInFor[conQxPrjTab.Owner];
objDR[conQxPrjTab.Keyword] = objInFor[conQxPrjTab.Keyword];
objDR[conQxPrjTab.TabTypeId] = objInFor[conQxPrjTab.TabTypeId];
objDR[conQxPrjTab.RelaViewId] = objInFor[conQxPrjTab.RelaViewId];
objDR[conQxPrjTab.PrimaryTypeId] = objInFor[conQxPrjTab.PrimaryTypeId];
objDR[conQxPrjTab.PrimaryTypeName] = objInFor[conQxPrjTab.PrimaryTypeName];
objDR[conQxPrjTab.KeyFldId] = objInFor[conQxPrjTab.KeyFldId];
objDR[conQxPrjTab.KeyFldName] = objInFor[conQxPrjTab.KeyFldName];
objDR[conQxPrjTab.UpdUserId] = objInFor[conQxPrjTab.UpdUserId];
objDR[conQxPrjTab.UpdDate] = objInFor[conQxPrjTab.UpdDate];
objDR[conQxPrjTab.Memo] = objInFor[conQxPrjTab.Memo];
objDR[conQxPrjTab.SynchDate] = objInFor[conQxPrjTab.SynchDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程表(QxPrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxPrjTab : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjTabWApi.ReFreshThisCache();
}
}

}