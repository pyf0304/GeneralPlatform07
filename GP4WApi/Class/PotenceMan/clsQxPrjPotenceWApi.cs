
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjPotenceWApi
 表名:QxPrjPotence(00140005)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:21:51
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
public static class  clsQxPrjPotenceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceId">权限ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetPotenceId(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceId, 8, conQxPrjPotence.PotenceId);
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, conQxPrjPotence.PotenceId);
objQxPrjPotenceEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.PotenceId) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.PotenceId, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.PotenceId] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceName">权限名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetPotenceName(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, conQxPrjPotence.PotenceName);
clsCheckSql.CheckFieldLen(strPotenceName, 200, conQxPrjPotence.PotenceName);
objQxPrjPotenceEN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.PotenceName) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.PotenceName, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.PotenceName] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetQxPrjId(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxPrjPotence.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxPrjPotence.QxPrjId);
objQxPrjPotenceEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.QxPrjId) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.QxPrjId, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.QxPrjId] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleId">模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetFuncModuleId(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conQxPrjPotence.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conQxPrjPotence.FuncModuleId);
objQxPrjPotenceEN.FuncModuleId = strFuncModuleId; //模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.FuncModuleId) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.FuncModuleId, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.FuncModuleId] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeId">权限类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetPotenceTypeId(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strPotenceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceTypeId, conQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, conQxPrjPotence.PotenceTypeId);
objQxPrjPotenceEN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.PotenceTypeId) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.PotenceTypeId, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.PotenceTypeId] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId">菜单Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetMenuId(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuId, 8, conQxPrjPotence.MenuId);
clsCheckSql.CheckFieldForeignKey(strMenuId, 8, conQxPrjPotence.MenuId);
objQxPrjPotenceEN.MenuId = strMenuId; //菜单Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.MenuId) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.MenuId, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.MenuId] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMenuId4Win">菜单Id4Win</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetMenuId4Win(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strMenuId4Win, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuId4Win, 8, conQxPrjPotence.MenuId4Win);
clsCheckSql.CheckFieldForeignKey(strMenuId4Win, 8, conQxPrjPotence.MenuId4Win);
objQxPrjPotenceEN.MenuId4Win = strMenuId4Win; //菜单Id4Win
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.MenuId4Win) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.MenuId4Win, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.MenuId4Win] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetUpdDate(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxPrjPotence.UpdDate);
objQxPrjPotenceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.UpdDate) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.UpdDate, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.UpdDate] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetUpdUserId(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxPrjPotence.UpdUserId);
objQxPrjPotenceEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.UpdUserId) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.UpdUserId, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.UpdUserId] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxPrjPotenceEN SetMemo(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxPrjPotence.Memo);
objQxPrjPotenceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxPrjPotenceEN.dicFldComparisonOp.ContainsKey(conQxPrjPotence.Memo) == false)
{
objQxPrjPotenceEN.dicFldComparisonOp.Add(conQxPrjPotence.Memo, strComparisonOp);
}
else
{
objQxPrjPotenceEN.dicFldComparisonOp[conQxPrjPotence.Memo] = strComparisonOp;
}
}
return objQxPrjPotenceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxPrjPotenceEN objQxPrjPotenceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.PotenceId) == true)
{
string strComparisonOpPotenceId = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.PotenceId, objQxPrjPotenceCond.PotenceId, strComparisonOpPotenceId);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.PotenceName) == true)
{
string strComparisonOpPotenceName = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.PotenceName, objQxPrjPotenceCond.PotenceName, strComparisonOpPotenceName);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.QxPrjId, objQxPrjPotenceCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.FuncModuleId, objQxPrjPotenceCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.PotenceTypeId, objQxPrjPotenceCond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.MenuId) == true)
{
string strComparisonOpMenuId = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.MenuId, objQxPrjPotenceCond.MenuId, strComparisonOpMenuId);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.MenuId4Win) == true)
{
string strComparisonOpMenuId4Win = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.MenuId4Win];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.MenuId4Win, objQxPrjPotenceCond.MenuId4Win, strComparisonOpMenuId4Win);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.UpdDate, objQxPrjPotenceCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.UpdUserId, objQxPrjPotenceCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxPrjPotenceCond.IsUpdated(conQxPrjPotence.Memo) == true)
{
string strComparisonOpMemo = objQxPrjPotenceCond.dicFldComparisonOp[conQxPrjPotence.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxPrjPotence.Memo, objQxPrjPotenceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxPrjPotenceEN objQxPrjPotenceEN)
{
 if (string.IsNullOrEmpty(objQxPrjPotenceEN.PotenceId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxPrjPotenceEN.sfUpdFldSetStr = objQxPrjPotenceEN.getsfUpdFldSetStr();
clsQxPrjPotenceWApi.CheckPropertyNew(objQxPrjPotenceEN); 
bool bolResult = clsQxPrjPotenceWApi.UpdateRecord(objQxPrjPotenceEN);
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
 /// 获取唯一性条件串--QxPrjPotence(工程权限), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PotenceTypeId_PotenceName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxPrjPotenceEN objQxPrjPotenceEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxPrjPotenceEN == null) return "";
if (objQxPrjPotenceEN.PotenceId == null || objQxPrjPotenceEN.PotenceId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PotenceTypeId = '{0}'", objQxPrjPotenceEN.PotenceTypeId);
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceEN.PotenceName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PotenceId !=  '{0}'", objQxPrjPotenceEN.PotenceId);
 sbCondition.AppendFormat(" and PotenceTypeId = '{0}'", objQxPrjPotenceEN.PotenceTypeId);
 sbCondition.AppendFormat(" and PotenceName = '{0}'", objQxPrjPotenceEN.PotenceName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxPrjPotenceEN objQxPrjPotenceEN)
{
 if (string.IsNullOrEmpty(objQxPrjPotenceEN.PotenceId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxPrjPotenceWApi.IsExist(objQxPrjPotenceEN.PotenceId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxPrjPotenceEN.PotenceId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxPrjPotenceWApi.CheckPropertyNew(objQxPrjPotenceEN); 
bool bolResult = clsQxPrjPotenceWApi.AddNewRecord(objQxPrjPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceWApi.ReFreshCache();
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
 /// <param name = "objQxPrjPotenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxPrjPotenceEN objQxPrjPotenceEN)
{
try
{
clsQxPrjPotenceWApi.CheckPropertyNew(objQxPrjPotenceEN); 
string strPotenceId = clsQxPrjPotenceWApi.AddNewRecordWithMaxId(objQxPrjPotenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceWApi.ReFreshCache();
return strPotenceId;
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
 /// <param name = "objQxPrjPotenceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxPrjPotenceEN objQxPrjPotenceEN, string strWhereCond)
{
try
{
clsQxPrjPotenceWApi.CheckPropertyNew(objQxPrjPotenceEN); 
bool bolResult = clsQxPrjPotenceWApi.UpdateWithCondition(objQxPrjPotenceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjPotenceWApi.ReFreshCache();
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
 /// 工程权限(QxPrjPotence)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjPotenceWApi
{
private static readonly string mstrApiControllerName = "QxPrjPotenceApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsQxPrjPotenceWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程权限]...","0");
List<clsQxPrjPotenceEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PotenceId";
objDDL.DataTextField="PotenceName";
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

public static void BindCbo_PotenceId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxPrjPotence.PotenceId); 
List<clsQxPrjPotenceEN> arrObjLst = clsQxPrjPotenceWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxPrjPotenceEN objQxPrjPotenceEN = new clsQxPrjPotenceEN()
{
PotenceId = "0",
PotenceName = "选[工程权限]..."
};
arrObjLst.Insert(0, objQxPrjPotenceEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxPrjPotence.PotenceId;
objComboBox.DisplayMember = conQxPrjPotence.PotenceName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
if (!Object.Equals(null, objQxPrjPotenceEN.PotenceId) && GetStrLen(objQxPrjPotenceEN.PotenceId) > 8)
{
 throw new Exception("字段[权限ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.PotenceName) && GetStrLen(objQxPrjPotenceEN.PotenceName) > 200)
{
 throw new Exception("字段[权限名称]的长度不能超过200!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.QxPrjId) && GetStrLen(objQxPrjPotenceEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.FuncModuleId) && GetStrLen(objQxPrjPotenceEN.FuncModuleId) > 4)
{
 throw new Exception("字段[模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.PotenceTypeId) && GetStrLen(objQxPrjPotenceEN.PotenceTypeId) > 6)
{
 throw new Exception("字段[权限类型Id]的长度不能超过6!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.MenuId) && GetStrLen(objQxPrjPotenceEN.MenuId) > 8)
{
 throw new Exception("字段[菜单Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.MenuId4Win) && GetStrLen(objQxPrjPotenceEN.MenuId4Win) > 8)
{
 throw new Exception("字段[菜单Id4Win]的长度不能超过8!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.UpdDate) && GetStrLen(objQxPrjPotenceEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.UpdUserId) && GetStrLen(objQxPrjPotenceEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxPrjPotenceEN.Memo) && GetStrLen(objQxPrjPotenceEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxPrjPotenceEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPotenceId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxPrjPotenceEN GetObjByPotenceId(string strPotenceId)
{
string strAction = "GetObjByPotenceId";
clsQxPrjPotenceEN objQxPrjPotenceEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPotenceId"] = strPotenceId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxPrjPotenceEN = JsonConvert.DeserializeObject<clsQxPrjPotenceEN>(strJson);
return objQxPrjPotenceEN;
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
public static clsQxPrjPotenceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxPrjPotenceEN objQxPrjPotenceEN;
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
objQxPrjPotenceEN = JsonConvert.DeserializeObject<clsQxPrjPotenceEN>(strJson);
return objQxPrjPotenceEN;
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
//该表没有使用Cache,不需要生成[GetPotenceNameByPotenceIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjPotenceEN> GetObjLst(string strWhereCond)
{
 List<clsQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjPotenceEN>>(strJson);
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
 /// <param name = "arrPotenceId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxPrjPotenceEN> GetObjLstByPotenceIdLst(List<string> arrPotenceId)
{
 List<clsQxPrjPotenceEN> arrObjLst; 
string strAction = "GetObjLstByPotenceIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPotenceId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjPotenceEN>>(strJson);
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
public static List<clsQxPrjPotenceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjPotenceEN>>(strJson);
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
public static List<clsQxPrjPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjPotenceEN>>(strJson);
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
public static List<clsQxPrjPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjPotenceEN>>(strJson);
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
public static List<clsQxPrjPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxPrjPotenceEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxPrjPotenceEN>>(strJson);
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
public static int DelRecord(string strPotenceId)
{
string strAction = "DelRecord";
try
{
 clsQxPrjPotenceEN objQxPrjPotenceEN = clsQxPrjPotenceWApi.GetObjByPotenceId(strPotenceId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPotenceId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelQxPrjPotences(List<string> arrPotenceId)
{
string strAction = "DelQxPrjPotences";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPotenceId);
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
public static int DelQxPrjPotencesByCond(string strWhereCond)
{
string strAction = "DelQxPrjPotencesByCond";
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
public static bool AddNewRecord(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjPotenceEN>(objQxPrjPotenceEN);
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
public static string AddNewRecordWithMaxId(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjPotenceEN>(objQxPrjPotenceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strPotenceId = (string)jobjReturn0["returnStr"];
return strPotenceId;
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
public static bool UpdateRecord(clsQxPrjPotenceEN objQxPrjPotenceEN)
{
if (string.IsNullOrEmpty(objQxPrjPotenceEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjPotenceEN.PotenceId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjPotenceEN>(objQxPrjPotenceEN);
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
 /// <param name = "objQxPrjPotenceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxPrjPotenceEN objQxPrjPotenceEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxPrjPotenceEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjPotenceEN.PotenceId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxPrjPotenceEN.PotenceId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxPrjPotenceEN>(objQxPrjPotenceEN);
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
public static bool IsExist(string strPotenceId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPotenceId"] = strPotenceId
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
 /// <param name = "objQxPrjPotenceENS">源对象</param>
 /// <param name = "objQxPrjPotenceENT">目标对象</param>
 public static void CopyTo(clsQxPrjPotenceEN objQxPrjPotenceENS, clsQxPrjPotenceEN objQxPrjPotenceENT)
{
try
{
objQxPrjPotenceENT.PotenceId = objQxPrjPotenceENS.PotenceId; //权限ID
objQxPrjPotenceENT.PotenceName = objQxPrjPotenceENS.PotenceName; //权限名称
objQxPrjPotenceENT.QxPrjId = objQxPrjPotenceENS.QxPrjId; //项目Id
objQxPrjPotenceENT.FuncModuleId = objQxPrjPotenceENS.FuncModuleId; //模块Id
objQxPrjPotenceENT.PotenceTypeId = objQxPrjPotenceENS.PotenceTypeId; //权限类型Id
objQxPrjPotenceENT.MenuId = objQxPrjPotenceENS.MenuId; //菜单Id
objQxPrjPotenceENT.MenuId4Win = objQxPrjPotenceENS.MenuId4Win; //菜单Id4Win
objQxPrjPotenceENT.UpdDate = objQxPrjPotenceENS.UpdDate; //修改日期
objQxPrjPotenceENT.UpdUserId = objQxPrjPotenceENS.UpdUserId; //修改用户Id
objQxPrjPotenceENT.Memo = objQxPrjPotenceENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxPrjPotenceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxPrjPotenceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxPrjPotenceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxPrjPotenceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxPrjPotenceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxPrjPotenceEN.AttributeName)
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
string strKey = string.Format("{0}", clsQxPrjPotenceEN._CurrTabName);
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
if (clsQxPrjPotenceWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxPrjPotenceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxPrjPotenceWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxPrjPotenceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxPrjPotence.PotenceId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.PotenceName, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.PotenceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.MenuId4Win, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxPrjPotence.Memo, Type.GetType("System.String"));
foreach (clsQxPrjPotenceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxPrjPotence.PotenceId] = objInFor[conQxPrjPotence.PotenceId];
objDR[conQxPrjPotence.PotenceName] = objInFor[conQxPrjPotence.PotenceName];
objDR[conQxPrjPotence.QxPrjId] = objInFor[conQxPrjPotence.QxPrjId];
objDR[conQxPrjPotence.FuncModuleId] = objInFor[conQxPrjPotence.FuncModuleId];
objDR[conQxPrjPotence.PotenceTypeId] = objInFor[conQxPrjPotence.PotenceTypeId];
objDR[conQxPrjPotence.MenuId] = objInFor[conQxPrjPotence.MenuId];
objDR[conQxPrjPotence.MenuId4Win] = objInFor[conQxPrjPotence.MenuId4Win];
objDR[conQxPrjPotence.UpdDate] = objInFor[conQxPrjPotence.UpdDate];
objDR[conQxPrjPotence.UpdUserId] = objInFor[conQxPrjPotence.UpdUserId];
objDR[conQxPrjPotence.Memo] = objInFor[conQxPrjPotence.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程权限(QxPrjPotence)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxPrjPotence : clsCommFun4BL
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
clsQxPrjPotenceWApi.ReFreshThisCache();
}
}

}