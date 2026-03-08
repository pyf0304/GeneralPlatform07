
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceSymbolForRoleBL
 表名:vQxPotenceSymbolForRole(00140047)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:37
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
public static class  clsvQxPotenceSymbolForRoleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObj(this K_mId_vQxPotenceSymbolForRole myKey)
{
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = clsvQxPotenceSymbolForRoleBL.vQxPotenceSymbolForRoleDA.GetObjBymId(myKey.Value);
return objvQxPotenceSymbolForRoleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetmId(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, long lngmId, string strComparisonOp="")
	{
objvQxPotenceSymbolForRoleEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.mId) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.mId, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.mId] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetRoleId(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxPotenceSymbolForRole.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxPotenceSymbolForRole.RoleId);
}
objvQxPotenceSymbolForRoleEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.RoleId) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.RoleId, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.RoleId] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetRelaMid(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, long lngRelaMid, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngRelaMid, convQxPotenceSymbolForRole.RelaMid);
objvQxPotenceSymbolForRoleEN.RelaMid = lngRelaMid; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.RelaMid) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.RelaMid, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.RelaMid] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceId(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxPotenceSymbolForRole.PotenceId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxPotenceSymbolForRole.PotenceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxPotenceSymbolForRole.PotenceId);
}
objvQxPotenceSymbolForRoleEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.PotenceId) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.PotenceId, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceId] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetSymbolForProgramme(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strSymbolForProgramme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolForProgramme, convQxPotenceSymbolForRole.SymbolForProgramme);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolForProgramme, 20, convQxPotenceSymbolForRole.SymbolForProgramme);
}
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = strSymbolForProgramme; //编程标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.SymbolForProgramme) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.SymbolForProgramme, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.SymbolForProgramme] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceName(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxPotenceSymbolForRole.PotenceName);
}
objvQxPotenceSymbolForRoleEN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.PotenceName) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.PotenceName, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceName] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceTypeId(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxPotenceSymbolForRole.PotenceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxPotenceSymbolForRole.PotenceTypeId);
}
objvQxPotenceSymbolForRoleEN.PotenceTypeId = strPotenceTypeId; //权限类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.PotenceTypeId) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.PotenceTypeId, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceTypeId] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceTypeName(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxPotenceSymbolForRole.PotenceTypeName);
}
objvQxPotenceSymbolForRoleEN.PotenceTypeName = strPotenceTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.PotenceTypeName) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.PotenceTypeName, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceTypeName] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetSymbolName(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strSymbolName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolName, 200, convQxPotenceSymbolForRole.SymbolName);
}
objvQxPotenceSymbolForRoleEN.SymbolName = strSymbolName; //标志名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.ContainsKey(convQxPotenceSymbolForRole.SymbolName) == false)
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp.Add(convQxPotenceSymbolForRole.SymbolName, strComparisonOp);
}
else
{
objvQxPotenceSymbolForRoleEN.dicFldComparisonOp[convQxPotenceSymbolForRole.SymbolName] = strComparisonOp;
}
}
return objvQxPotenceSymbolForRoleEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleENS">源对象</param>
 /// <param name = "objvQxPotenceSymbolForRoleENT">目标对象</param>
 public static void CopyTo(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleENS, clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleENT)
{
try
{
objvQxPotenceSymbolForRoleENT.mId = objvQxPotenceSymbolForRoleENS.mId; //流水号
objvQxPotenceSymbolForRoleENT.RoleId = objvQxPotenceSymbolForRoleENS.RoleId; //角色Id
objvQxPotenceSymbolForRoleENT.RelaMid = objvQxPotenceSymbolForRoleENS.RelaMid; //流水号
objvQxPotenceSymbolForRoleENT.PotenceId = objvQxPotenceSymbolForRoleENS.PotenceId; //权限ID
objvQxPotenceSymbolForRoleENT.SymbolForProgramme = objvQxPotenceSymbolForRoleENS.SymbolForProgramme; //编程标志
objvQxPotenceSymbolForRoleENT.PotenceName = objvQxPotenceSymbolForRoleENS.PotenceName; //权限名称
objvQxPotenceSymbolForRoleENT.PotenceTypeId = objvQxPotenceSymbolForRoleENS.PotenceTypeId; //权限类型Id
objvQxPotenceSymbolForRoleENT.PotenceTypeName = objvQxPotenceSymbolForRoleENS.PotenceTypeName; //权限类型名
objvQxPotenceSymbolForRoleENT.SymbolName = objvQxPotenceSymbolForRoleENS.SymbolName; //标志名称
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
 /// <param name = "objvQxPotenceSymbolForRoleENS">源对象</param>
 /// <returns>目标对象=>clsvQxPotenceSymbolForRoleEN:objvQxPotenceSymbolForRoleENT</returns>
 public static clsvQxPotenceSymbolForRoleEN CopyTo(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleENS)
{
try
{
 clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleENT = new clsvQxPotenceSymbolForRoleEN()
{
mId = objvQxPotenceSymbolForRoleENS.mId, //流水号
RoleId = objvQxPotenceSymbolForRoleENS.RoleId, //角色Id
RelaMid = objvQxPotenceSymbolForRoleENS.RelaMid, //流水号
PotenceId = objvQxPotenceSymbolForRoleENS.PotenceId, //权限ID
SymbolForProgramme = objvQxPotenceSymbolForRoleENS.SymbolForProgramme, //编程标志
PotenceName = objvQxPotenceSymbolForRoleENS.PotenceName, //权限名称
PotenceTypeId = objvQxPotenceSymbolForRoleENS.PotenceTypeId, //权限类型Id
PotenceTypeName = objvQxPotenceSymbolForRoleENS.PotenceTypeName, //权限类型名
SymbolName = objvQxPotenceSymbolForRoleENS.SymbolName, //标志名称
};
 return objvQxPotenceSymbolForRoleENT;
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
public static void CheckProperty4Condition(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
 clsvQxPotenceSymbolForRoleBL.vQxPotenceSymbolForRoleDA.CheckProperty4Condition(objvQxPotenceSymbolForRoleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.mId) == true)
{
string strComparisonOpmId = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPotenceSymbolForRole.mId, objvQxPotenceSymbolForRoleCond.mId, strComparisonOpmId);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.RoleId) == true)
{
string strComparisonOpRoleId = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceSymbolForRole.RoleId, objvQxPotenceSymbolForRoleCond.RoleId, strComparisonOpRoleId);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.RelaMid) == true)
{
string strComparisonOpRelaMid = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.RelaMid];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPotenceSymbolForRole.RelaMid, objvQxPotenceSymbolForRoleCond.RelaMid, strComparisonOpRelaMid);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.PotenceId) == true)
{
string strComparisonOpPotenceId = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceSymbolForRole.PotenceId, objvQxPotenceSymbolForRoleCond.PotenceId, strComparisonOpPotenceId);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.SymbolForProgramme) == true)
{
string strComparisonOpSymbolForProgramme = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.SymbolForProgramme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceSymbolForRole.SymbolForProgramme, objvQxPotenceSymbolForRoleCond.SymbolForProgramme, strComparisonOpSymbolForProgramme);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.PotenceName) == true)
{
string strComparisonOpPotenceName = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceSymbolForRole.PotenceName, objvQxPotenceSymbolForRoleCond.PotenceName, strComparisonOpPotenceName);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.PotenceTypeId) == true)
{
string strComparisonOpPotenceTypeId = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceSymbolForRole.PotenceTypeId, objvQxPotenceSymbolForRoleCond.PotenceTypeId, strComparisonOpPotenceTypeId);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.PotenceTypeName) == true)
{
string strComparisonOpPotenceTypeName = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.PotenceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceSymbolForRole.PotenceTypeName, objvQxPotenceSymbolForRoleCond.PotenceTypeName, strComparisonOpPotenceTypeName);
}
if (objvQxPotenceSymbolForRoleCond.IsUpdated(convQxPotenceSymbolForRole.SymbolName) == true)
{
string strComparisonOpSymbolName = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[convQxPotenceSymbolForRole.SymbolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPotenceSymbolForRole.SymbolName, objvQxPotenceSymbolForRoleCond.SymbolName, strComparisonOpSymbolName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPotenceSymbolForRole
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPotenceSymbolForRole(vQxPotenceSymbolForRole)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPotenceSymbolForRoleBL
{
public static RelatedActions_vQxPotenceSymbolForRole relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPotenceSymbolForRoleListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPotenceSymbolForRoleList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPotenceSymbolForRoleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPotenceSymbolForRoleDA vQxPotenceSymbolForRoleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPotenceSymbolForRoleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPotenceSymbolForRoleBL()
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
if (string.IsNullOrEmpty(clsvQxPotenceSymbolForRoleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPotenceSymbolForRoleEN._ConnectString);
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
objDS = vQxPotenceSymbolForRoleDA.GetDataSet(strWhereCond);
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
objDS = vQxPotenceSymbolForRoleDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPotenceSymbolForRoleDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPotenceSymbolForRole(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPotenceSymbolForRoleDA.GetDataTable_vQxPotenceSymbolForRole(strWhereCond);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTable(strWhereCond);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPotenceSymbolForRoleDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
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
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPotenceSymbolForRoleEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxPotenceSymbolForRoleEN._CurrTabName);
List<clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLst_Sel =
arrvQxPotenceSymbolForRoleObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxPotenceSymbolForRoleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLst(string strWhereCond)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPotenceSymbolForRoleEN> GetSubObjLstCache(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleCond)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceSymbolForRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPotenceSymbolForRole.AttributeName)
{
if (objvQxPotenceSymbolForRoleCond.IsUpdated(strFldName) == false) continue;
if (objvQxPotenceSymbolForRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceSymbolForRoleCond[strFldName].ToString());
}
else
{
if (objvQxPotenceSymbolForRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceSymbolForRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPotenceSymbolForRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPotenceSymbolForRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPotenceSymbolForRoleCond[strFldName]));
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPotenceSymbolForRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
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
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
public static IEnumerable<clsvQxPotenceSymbolForRoleEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleCond, string strOrderBy)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceSymbolForRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPotenceSymbolForRole.AttributeName)
{
if (objvQxPotenceSymbolForRoleCond.IsUpdated(strFldName) == false) continue;
if (objvQxPotenceSymbolForRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceSymbolForRoleCond[strFldName].ToString());
}
else
{
if (objvQxPotenceSymbolForRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceSymbolForRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPotenceSymbolForRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPotenceSymbolForRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPotenceSymbolForRoleCond[strFldName]));
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
public static IEnumerable<clsvQxPotenceSymbolForRoleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleCond = JsonConvert.DeserializeObject<clsvQxPotenceSymbolForRoleEN>(objPagerPara.whereCond);
if (objvQxPotenceSymbolForRoleCond.sfFldComparisonOp == null)
{
objvQxPotenceSymbolForRoleCond.dicFldComparisonOp = null;
}
else
{
objvQxPotenceSymbolForRoleCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPotenceSymbolForRoleCond.sfFldComparisonOp);
}
clsvQxPotenceSymbolForRoleBL.SetUpdFlag(objvQxPotenceSymbolForRoleCond);
 try
{
CheckProperty4Condition(objvQxPotenceSymbolForRoleCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPotenceSymbolForRoleBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPotenceSymbolForRoleCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLst = new List<clsvQxPotenceSymbolForRoleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
try
{
objvQxPotenceSymbolForRoleEN.mId = Int32.Parse(objRow[convQxPotenceSymbolForRole.mId].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.RoleId = objRow[convQxPotenceSymbolForRole.RoleId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.RoleId].ToString().Trim(); //角色Id
objvQxPotenceSymbolForRoleEN.RelaMid = Int32.Parse(objRow[convQxPotenceSymbolForRole.RelaMid].ToString().Trim()); //流水号
objvQxPotenceSymbolForRoleEN.PotenceId = objRow[convQxPotenceSymbolForRole.PotenceId].ToString().Trim(); //权限ID
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objRow[convQxPotenceSymbolForRole.SymbolForProgramme].ToString().Trim(); //编程标志
objvQxPotenceSymbolForRoleEN.PotenceName = objRow[convQxPotenceSymbolForRole.PotenceName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceName].ToString().Trim(); //权限名称
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objRow[convQxPotenceSymbolForRole.PotenceTypeId] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeId].ToString().Trim(); //权限类型Id
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objRow[convQxPotenceSymbolForRole.PotenceTypeName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.PotenceTypeName].ToString().Trim(); //权限类型名
objvQxPotenceSymbolForRoleEN.SymbolName = objRow[convQxPotenceSymbolForRole.SymbolName] == DBNull.Value ? null : objRow[convQxPotenceSymbolForRole.SymbolName].ToString().Trim(); //标志名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPotenceSymbolForRoleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPotenceSymbolForRoleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPotenceSymbolForRole(ref clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
bool bolResult = vQxPotenceSymbolForRoleDA.GetvQxPotenceSymbolForRole(ref objvQxPotenceSymbolForRoleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObjBymId(long lngmId)
{
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = vQxPotenceSymbolForRoleDA.GetObjBymId(lngmId);
return objvQxPotenceSymbolForRoleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = vQxPotenceSymbolForRoleDA.GetFirstObj(strWhereCond);
 return objvQxPotenceSymbolForRoleEN;
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
public static clsvQxPotenceSymbolForRoleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = vQxPotenceSymbolForRoleDA.GetObjByDataRow(objRow);
 return objvQxPotenceSymbolForRoleEN;
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
public static clsvQxPotenceSymbolForRoleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = vQxPotenceSymbolForRoleDA.GetObjByDataRow(objRow);
 return objvQxPotenceSymbolForRoleEN;
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
 /// <param name = "lstvQxPotenceSymbolForRoleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObjBymIdFromList(long lngmId, List<clsvQxPotenceSymbolForRoleEN> lstvQxPotenceSymbolForRoleObjLst)
{
foreach (clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN in lstvQxPotenceSymbolForRoleObjLst)
{
if (objvQxPotenceSymbolForRoleEN.mId == lngmId)
{
return objvQxPotenceSymbolForRoleEN;
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
 lngmId = new clsvQxPotenceSymbolForRoleDA().GetFirstID(strWhereCond);
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
 arrList = vQxPotenceSymbolForRoleDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPotenceSymbolForRoleDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxPotenceSymbolForRoleDA.IsExist(lngmId);
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
 bolIsExist = clsvQxPotenceSymbolForRoleDA.IsExistTable();
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
 bolIsExist = vQxPotenceSymbolForRoleDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPotenceSymbolForRoleENS">源对象</param>
 /// <param name = "objvQxPotenceSymbolForRoleENT">目标对象</param>
 public static void CopyTo(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleENS, clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleENT)
{
try
{
objvQxPotenceSymbolForRoleENT.mId = objvQxPotenceSymbolForRoleENS.mId; //流水号
objvQxPotenceSymbolForRoleENT.RoleId = objvQxPotenceSymbolForRoleENS.RoleId; //角色Id
objvQxPotenceSymbolForRoleENT.RelaMid = objvQxPotenceSymbolForRoleENS.RelaMid; //流水号
objvQxPotenceSymbolForRoleENT.PotenceId = objvQxPotenceSymbolForRoleENS.PotenceId; //权限ID
objvQxPotenceSymbolForRoleENT.SymbolForProgramme = objvQxPotenceSymbolForRoleENS.SymbolForProgramme; //编程标志
objvQxPotenceSymbolForRoleENT.PotenceName = objvQxPotenceSymbolForRoleENS.PotenceName; //权限名称
objvQxPotenceSymbolForRoleENT.PotenceTypeId = objvQxPotenceSymbolForRoleENS.PotenceTypeId; //权限类型Id
objvQxPotenceSymbolForRoleENT.PotenceTypeName = objvQxPotenceSymbolForRoleENS.PotenceTypeName; //权限类型名
objvQxPotenceSymbolForRoleENT.SymbolName = objvQxPotenceSymbolForRoleENS.SymbolName; //标志名称
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
 /// <param name = "objvQxPotenceSymbolForRoleEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
try
{
objvQxPotenceSymbolForRoleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPotenceSymbolForRoleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPotenceSymbolForRole.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.mId = objvQxPotenceSymbolForRoleEN.mId; //流水号
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.RoleId = objvQxPotenceSymbolForRoleEN.RoleId == "[null]" ? null :  objvQxPotenceSymbolForRoleEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.RelaMid, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.RelaMid = objvQxPotenceSymbolForRoleEN.RelaMid; //流水号
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.PotenceId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.PotenceId = objvQxPotenceSymbolForRoleEN.PotenceId; //权限ID
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.SymbolForProgramme, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = objvQxPotenceSymbolForRoleEN.SymbolForProgramme; //编程标志
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.PotenceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.PotenceName = objvQxPotenceSymbolForRoleEN.PotenceName == "[null]" ? null :  objvQxPotenceSymbolForRoleEN.PotenceName; //权限名称
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.PotenceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.PotenceTypeId = objvQxPotenceSymbolForRoleEN.PotenceTypeId == "[null]" ? null :  objvQxPotenceSymbolForRoleEN.PotenceTypeId; //权限类型Id
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.PotenceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.PotenceTypeName = objvQxPotenceSymbolForRoleEN.PotenceTypeName == "[null]" ? null :  objvQxPotenceSymbolForRoleEN.PotenceTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxPotenceSymbolForRole.SymbolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPotenceSymbolForRoleEN.SymbolName = objvQxPotenceSymbolForRoleEN.SymbolName == "[null]" ? null :  objvQxPotenceSymbolForRoleEN.SymbolName; //标志名称
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
 /// <param name = "objvQxPotenceSymbolForRoleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
try
{
if (objvQxPotenceSymbolForRoleEN.RoleId == "[null]") objvQxPotenceSymbolForRoleEN.RoleId = null; //角色Id
if (objvQxPotenceSymbolForRoleEN.PotenceName == "[null]") objvQxPotenceSymbolForRoleEN.PotenceName = null; //权限名称
if (objvQxPotenceSymbolForRoleEN.PotenceTypeId == "[null]") objvQxPotenceSymbolForRoleEN.PotenceTypeId = null; //权限类型Id
if (objvQxPotenceSymbolForRoleEN.PotenceTypeName == "[null]") objvQxPotenceSymbolForRoleEN.PotenceTypeName = null; //权限类型名
if (objvQxPotenceSymbolForRoleEN.SymbolName == "[null]") objvQxPotenceSymbolForRoleEN.SymbolName = null; //标志名称
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
public static void CheckProperty4Condition(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
 vQxPotenceSymbolForRoleDA.CheckProperty4Condition(objvQxPotenceSymbolForRoleEN);
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
if (clsQxUserGroupPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserGroupPotenceBL没有刷新缓存机制(clsQxUserGroupPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxPotenceSymbolForRoleObjLstCache == null)
//{
//arrvQxPotenceSymbolForRoleObjLstCache = vQxPotenceSymbolForRoleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPotenceSymbolForRoleEN._CurrTabName);
List<clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLst_Sel =
arrvQxPotenceSymbolForRoleObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxPotenceSymbolForRoleObjLst_Sel.Count() == 0)
{
   clsvQxPotenceSymbolForRoleEN obj = clsvQxPotenceSymbolForRoleBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPotenceSymbolForRoleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetAllvQxPotenceSymbolForRoleObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLstCache = GetObjLstCache(); 
return arrvQxPotenceSymbolForRoleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPotenceSymbolForRoleEN._CurrTabName);
List<clsvQxPotenceSymbolForRoleEN> arrvQxPotenceSymbolForRoleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPotenceSymbolForRoleObjLstCache;
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
string strKey = string.Format("{0}", clsvQxPotenceSymbolForRoleEN._CurrTabName);
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
 /// <param name = "lstvQxPotenceSymbolForRoleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPotenceSymbolForRoleEN> lstvQxPotenceSymbolForRoleObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPotenceSymbolForRoleObjLst, writer);
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
 /// <param name = "lstvQxPotenceSymbolForRoleObjLst">[clsvQxPotenceSymbolForRoleEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPotenceSymbolForRoleEN> lstvQxPotenceSymbolForRoleObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPotenceSymbolForRoleBL.listXmlNode);
writer.WriteStartElement(clsvQxPotenceSymbolForRoleBL.itemsXmlNode);
foreach (clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN in lstvQxPotenceSymbolForRoleObjLst)
{
clsvQxPotenceSymbolForRoleBL.SerializeXML(writer, objvQxPotenceSymbolForRoleEN);
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
 /// <param name = "objvQxPotenceSymbolForRoleEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
writer.WriteStartElement(clsvQxPotenceSymbolForRoleBL.itemXmlNode);
 
writer.WriteElementString(convQxPotenceSymbolForRole.mId, objvQxPotenceSymbolForRoleEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxPotenceSymbolForRoleEN.RoleId != null)
{
writer.WriteElementString(convQxPotenceSymbolForRole.RoleId, objvQxPotenceSymbolForRoleEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxPotenceSymbolForRole.RelaMid, objvQxPotenceSymbolForRoleEN.RelaMid.ToString(CultureInfo.InvariantCulture));
 
if (objvQxPotenceSymbolForRoleEN.PotenceId != null)
{
writer.WriteElementString(convQxPotenceSymbolForRole.PotenceId, objvQxPotenceSymbolForRoleEN.PotenceId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceSymbolForRoleEN.SymbolForProgramme != null)
{
writer.WriteElementString(convQxPotenceSymbolForRole.SymbolForProgramme, objvQxPotenceSymbolForRoleEN.SymbolForProgramme.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceSymbolForRoleEN.PotenceName != null)
{
writer.WriteElementString(convQxPotenceSymbolForRole.PotenceName, objvQxPotenceSymbolForRoleEN.PotenceName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceSymbolForRoleEN.PotenceTypeId != null)
{
writer.WriteElementString(convQxPotenceSymbolForRole.PotenceTypeId, objvQxPotenceSymbolForRoleEN.PotenceTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceSymbolForRoleEN.PotenceTypeName != null)
{
writer.WriteElementString(convQxPotenceSymbolForRole.PotenceTypeName, objvQxPotenceSymbolForRoleEN.PotenceTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPotenceSymbolForRoleEN.SymbolName != null)
{
writer.WriteElementString(convQxPotenceSymbolForRole.SymbolName, objvQxPotenceSymbolForRoleEN.SymbolName.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPotenceSymbolForRoleEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
reader.Read();
while (!(reader.Name == clsvQxPotenceSymbolForRoleBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPotenceSymbolForRole.mId))
{
objvQxPotenceSymbolForRoleEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.RoleId))
{
objvQxPotenceSymbolForRoleEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.RelaMid))
{
objvQxPotenceSymbolForRoleEN.RelaMid = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.PotenceId))
{
objvQxPotenceSymbolForRoleEN.PotenceId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.SymbolForProgramme))
{
objvQxPotenceSymbolForRoleEN.SymbolForProgramme = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.PotenceName))
{
objvQxPotenceSymbolForRoleEN.PotenceName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.PotenceTypeId))
{
objvQxPotenceSymbolForRoleEN.PotenceTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.PotenceTypeName))
{
objvQxPotenceSymbolForRoleEN.PotenceTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPotenceSymbolForRole.SymbolName))
{
objvQxPotenceSymbolForRoleEN.SymbolName = reader.ReadElementContentAsString();
}
}
return objvQxPotenceSymbolForRoleEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPotenceSymbolForRoleObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObjFromXmlStr(string strvQxPotenceSymbolForRoleObjXmlStr)
{
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN = new clsvQxPotenceSymbolForRoleEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPotenceSymbolForRoleObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPotenceSymbolForRoleBL.itemXmlNode))
{
objvQxPotenceSymbolForRoleEN = GetObjFromXml(reader);
return objvQxPotenceSymbolForRoleEN;
}
}
return objvQxPotenceSymbolForRoleEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPotenceSymbolForRoleEN);
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
if (strInFldName != convQxPotenceSymbolForRole.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPotenceSymbolForRole.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPotenceSymbolForRole.AttributeName));
throw new Exception(strMsg);
}
var objvQxPotenceSymbolForRole = clsvQxPotenceSymbolForRoleBL.GetObjBymIdCache(lngmId);
if (objvQxPotenceSymbolForRole == null) return "";
return objvQxPotenceSymbolForRole[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPotenceSymbolForRoleEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPotenceSymbolForRoleEN[strField]);
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
 /// <param name = "lstvQxPotenceSymbolForRoleObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPotenceSymbolForRoleEN> lstvQxPotenceSymbolForRoleObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPotenceSymbolForRoleObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN in lstvQxPotenceSymbolForRoleObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPotenceSymbolForRoleEN);
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
int intRecCount = clsvQxPotenceSymbolForRoleDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPotenceSymbolForRoleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPotenceSymbolForRoleDA.GetRecCount();
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
int intRecCount = clsvQxPotenceSymbolForRoleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleCond)
{
List<clsvQxPotenceSymbolForRoleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPotenceSymbolForRoleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPotenceSymbolForRole.AttributeName)
{
if (objvQxPotenceSymbolForRoleCond.IsUpdated(strFldName) == false) continue;
if (objvQxPotenceSymbolForRoleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceSymbolForRoleCond[strFldName].ToString());
}
else
{
if (objvQxPotenceSymbolForRoleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPotenceSymbolForRoleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPotenceSymbolForRoleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPotenceSymbolForRoleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPotenceSymbolForRoleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPotenceSymbolForRoleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPotenceSymbolForRoleCond[strFldName]));
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
 List<string> arrList = clsvQxPotenceSymbolForRoleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPotenceSymbolForRoleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPotenceSymbolForRoleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}