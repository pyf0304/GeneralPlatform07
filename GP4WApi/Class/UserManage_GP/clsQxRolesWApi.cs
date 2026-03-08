
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRolesWApi
 表名:QxRoles(00140014)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:19:55
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
using GP4WApi;

namespace GeneralPlatform4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsQxRolesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleId(this clsQxRolesEN objQxRolesEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, conQxRoles.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conQxRoles.RoleId);
objQxRolesEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleId) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleId, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleId] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleName(this clsQxRolesEN objQxRolesEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, conQxRoles.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, conQxRoles.RoleName);
objQxRolesEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleName) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleName, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleName] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleENName">角色英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleENName(this clsQxRolesEN objQxRolesEN, string strRoleENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleENName, 50, conQxRoles.RoleENName);
objQxRolesEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleENName) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleENName, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleENName] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "intRoleIndex">角色序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetRoleIndex(this clsQxRolesEN objQxRolesEN, int intRoleIndex, string strComparisonOp="")
	{
objQxRolesEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.RoleIndex) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.RoleIndex, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.RoleIndex] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserType">用户类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetUserType(this clsQxRolesEN objQxRolesEN, string strUserType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserType, 50, conQxRoles.UserType);
objQxRolesEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.UserType) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.UserType, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.UserType] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetQxPrjId(this clsQxRolesEN objQxRolesEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, conQxRoles.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, conQxRoles.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, conQxRoles.QxPrjId);
objQxRolesEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.QxPrjId) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.QxPrjId, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.QxPrjId] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInUse">是否在使用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetIsInUse(this clsQxRolesEN objQxRolesEN, bool bolIsInUse, string strComparisonOp="")
	{
objQxRolesEN.IsInUse = bolIsInUse; //是否在使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.IsInUse) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.IsInUse, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.IsInUse] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetUpdDate(this clsQxRolesEN objQxRolesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRoles.UpdDate);
objQxRolesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.UpdDate) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.UpdDate, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.UpdDate] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetUpdUserId(this clsQxRolesEN objQxRolesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conQxRoles.UpdUserId);
objQxRolesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.UpdUserId) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.UpdUserId, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.UpdUserId] = strComparisonOp;
}
}
return objQxRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRolesEN SetMemo(this clsQxRolesEN objQxRolesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRoles.Memo);
objQxRolesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRolesEN.dicFldComparisonOp.ContainsKey(conQxRoles.Memo) == false)
{
objQxRolesEN.dicFldComparisonOp.Add(conQxRoles.Memo, strComparisonOp);
}
else
{
objQxRolesEN.dicFldComparisonOp[conQxRoles.Memo] = strComparisonOp;
}
}
return objQxRolesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxRolesEN objQxRolesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxRolesCond.IsUpdated(conQxRoles.RoleId) == true)
{
string strComparisonOpRoleId = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.RoleId, objQxRolesCond.RoleId, strComparisonOpRoleId);
}
if (objQxRolesCond.IsUpdated(conQxRoles.RoleName) == true)
{
string strComparisonOpRoleName = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.RoleName, objQxRolesCond.RoleName, strComparisonOpRoleName);
}
if (objQxRolesCond.IsUpdated(conQxRoles.RoleENName) == true)
{
string strComparisonOpRoleENName = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.RoleENName, objQxRolesCond.RoleENName, strComparisonOpRoleENName);
}
if (objQxRolesCond.IsUpdated(conQxRoles.RoleIndex) == true)
{
string strComparisonOpRoleIndex = objQxRolesCond.dicFldComparisonOp[conQxRoles.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQxRoles.RoleIndex, objQxRolesCond.RoleIndex, strComparisonOpRoleIndex);
}
if (objQxRolesCond.IsUpdated(conQxRoles.UserType) == true)
{
string strComparisonOpUserType = objQxRolesCond.dicFldComparisonOp[conQxRoles.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.UserType, objQxRolesCond.UserType, strComparisonOpUserType);
}
if (objQxRolesCond.IsUpdated(conQxRoles.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objQxRolesCond.dicFldComparisonOp[conQxRoles.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.QxPrjId, objQxRolesCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objQxRolesCond.IsUpdated(conQxRoles.IsInUse) == true)
{
if (objQxRolesCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQxRoles.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQxRoles.IsInUse);
}
}
if (objQxRolesCond.IsUpdated(conQxRoles.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxRolesCond.dicFldComparisonOp[conQxRoles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.UpdDate, objQxRolesCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxRolesCond.IsUpdated(conQxRoles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objQxRolesCond.dicFldComparisonOp[conQxRoles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.UpdUserId, objQxRolesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objQxRolesCond.IsUpdated(conQxRoles.Memo) == true)
{
string strComparisonOpMemo = objQxRolesCond.dicFldComparisonOp[conQxRoles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRoles.Memo, objQxRolesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRolesEN objQxRolesEN)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQxRolesEN.sfUpdFldSetStr = objQxRolesEN.getsfUpdFldSetStr();
clsQxRolesWApi.CheckPropertyNew(objQxRolesEN); 
bool bolResult = clsQxRolesWApi.UpdateRecord(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
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
 /// 获取唯一性条件串--QxRoles(角色), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RoleName_QxPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxRolesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsQxRolesEN objQxRolesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxRolesEN == null) return "";
if (objQxRolesEN.RoleId == null || objQxRolesEN.RoleId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RoleName = '{0}'", objQxRolesEN.RoleName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxRolesEN.QxPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RoleId !=  '{0}'", objQxRolesEN.RoleId);
 sbCondition.AppendFormat(" and RoleName = '{0}'", objQxRolesEN.RoleName);
 sbCondition.AppendFormat(" and QxPrjId = '{0}'", objQxRolesEN.QxPrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRolesEN objQxRolesEN)
{
 if (string.IsNullOrEmpty(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQxRolesWApi.IsExist(objQxRolesEN.RoleId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objQxRolesEN.RoleId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQxRolesWApi.CheckPropertyNew(objQxRolesEN); 
bool bolResult = clsQxRolesWApi.AddNewRecord(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
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
 /// <param name = "objQxRolesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxRolesEN objQxRolesEN)
{
try
{
clsQxRolesWApi.CheckPropertyNew(objQxRolesEN); 
string strRoleId = clsQxRolesWApi.AddNewRecordWithMaxId(objQxRolesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
return strRoleId;
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
 /// <param name = "objQxRolesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRolesEN objQxRolesEN, string strWhereCond)
{
try
{
clsQxRolesWApi.CheckPropertyNew(objQxRolesEN); 
bool bolResult = clsQxRolesWApi.UpdateWithCondition(objQxRolesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumQxRolesWA
{
 /// <summary>
 /// 统一平台总管理员
 /// </summary>
public const string _00010001 = "00010001";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string _00010002 = "00010002";
 /// <summary>
 /// 高级用户
 /// </summary>
public const string _00010003 = "00010003";
 /// <summary>
 /// 普通用户
 /// </summary>
public const string _00010004 = "00010004";
 /// <summary>
 /// 管理员
 /// </summary>
public const string _00050001 = "00050001";
 /// <summary>
 /// 中级管理
 /// </summary>
public const string _00050002 = "00050002";
 /// <summary>
 /// 项目设计师
 /// </summary>
public const string _00050003 = "00050003";
 /// <summary>
 /// 项目程序员
 /// </summary>
public const string _00050004 = "00050004";
 /// <summary>
 /// 超级管理
 /// </summary>
public const string _00050005 = "00050005";
 /// <summary>
 /// 亚管理员
 /// </summary>
public const string _00050006 = "00050006";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _00190001 = "00190001";
 /// <summary>
 /// 设定会议人
 /// </summary>
public const string _00190002 = "00190002";
 /// <summary>
 /// 现场负责人
 /// </summary>
public const string _00190003 = "00190003";
 /// <summary>
 /// 部门负责人
 /// </summary>
public const string _00190004 = "00190004";
 /// <summary>
 /// 普通人员
 /// </summary>
public const string _00190005 = "00190005";
 /// <summary>
 /// 信息审核员
 /// </summary>
public const string _00200001 = "00200001";
 /// <summary>
 /// 信息管理员
 /// </summary>
public const string _00200002 = "00200002";
 /// <summary>
 /// 普通用户
 /// </summary>
public const string _00200003 = "00200003";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _00250001 = "00250001";
 /// <summary>
 /// 校办处理人员1
 /// </summary>
public const string _00250002 = "00250002";
 /// <summary>
 /// 校办处理人员2
 /// </summary>
public const string _00250003 = "00250003";
 /// <summary>
 /// 校办处理人员3
 /// </summary>
public const string _00250004 = "00250004";
 /// <summary>
 /// 校办处理人员4
 /// </summary>
public const string _00250005 = "00250005";
 /// <summary>
 /// 校办处理人员5
 /// </summary>
public const string _00250006 = "00250006";
 /// <summary>
 /// 校办管理人员6
 /// </summary>
public const string _00250007 = "00250007";
 /// <summary>
 /// 校领导1
 /// </summary>
public const string _00250008 = "00250008";
 /// <summary>
 /// 校领导2
 /// </summary>
public const string _00250009 = "00250009";
 /// <summary>
 /// 部门人员1
 /// </summary>
public const string _00250010 = "00250010";
 /// <summary>
 /// 校办管理人员7
 /// </summary>
public const string _00250011 = "00250011";
 /// <summary>
 /// 校办管理人员8
 /// </summary>
public const string _00250012 = "00250012";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _00260001 = "00260001";
 /// <summary>
 /// 考核主管部门
 /// </summary>
public const string _00260002 = "00260002";
 /// <summary>
 /// 教学核实
 /// </summary>
public const string _00260003 = "00260003";
 /// <summary>
 /// 科研核实
 /// </summary>
public const string _00260004 = "00260004";
 /// <summary>
 /// 科研打分
 /// </summary>
public const string _00260005 = "00260005";
 /// <summary>
 /// 考核职能部门（删除）
 /// </summary>
public const string _00260006 = "00260006";
 /// <summary>
 /// 校级受聘人
 /// </summary>
public const string _00260007 = "00260007";
 /// <summary>
 /// 一般教师
 /// </summary>
public const string _00260008 = "00260008";
 /// <summary>
 /// 游客
 /// </summary>
public const string _00260009 = "00260009";
 /// <summary>
 /// 教务考核
 /// </summary>
public const string _00260010 = "00260010";
 /// <summary>
 /// 科研考核
 /// </summary>
public const string _00260011 = "00260011";
 /// <summary>
 /// 研办考核
 /// </summary>
public const string _00260012 = "00260012";
 /// <summary>
 /// 学院考核
 /// </summary>
public const string _00260013 = "00260013";
 /// <summary>
 /// 校聘任委员会委员
 /// </summary>
public const string _00260014 = "00260014";
 /// <summary>
 /// 师资考核
 /// </summary>
public const string _00260015 = "00260015";
 /// <summary>
 /// 学院科研考核
 /// </summary>
public const string _00260016 = "00260016";
 /// <summary>
 /// 学院教学考核
 /// </summary>
public const string _00260017 = "00260017";
 /// <summary>
 /// 学院品德考核
 /// </summary>
public const string _00260018 = "00260018";
 /// <summary>
 /// 科研考核(院聘)
 /// </summary>
public const string _00260019 = "00260019";
 /// <summary>
 /// 教学考核(院聘)
 /// </summary>
public const string _00260020 = "00260020";
 /// <summary>
 /// 品德考核(院聘)
 /// </summary>
public const string _00260021 = "00260021";
 /// <summary>
 /// 院级受聘人
 /// </summary>
public const string _00260022 = "00260022";
 /// <summary>
 /// 学院科研打分
 /// </summary>
public const string _00260023 = "00260023";
 /// <summary>
 /// 学院等第评判
 /// </summary>
public const string _00260024 = "00260024";
 /// <summary>
 /// 管理岗受聘人
 /// </summary>
public const string _00260025 = "00260025";
 /// <summary>
 /// 部门考核
 /// </summary>
public const string _00260026 = "00260026";
 /// <summary>
 /// 工作考核
 /// </summary>
public const string _00260027 = "00260027";
 /// <summary>
 /// 廉政考核
 /// </summary>
public const string _00260028 = "00260028";
 /// <summary>
 /// 校级受聘人_师
 /// </summary>
public const string _00260029 = "00260029";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string _00280001 = "00280001";
 /// <summary>
 /// 部门经理
 /// </summary>
public const string _00280002 = "00280002";
 /// <summary>
 /// 项目负责人
 /// </summary>
public const string _00280003 = "00280003";
 /// <summary>
 /// 程序员
 /// </summary>
public const string _00280004 = "00280004";
 /// <summary>
 /// 美工
 /// </summary>
public const string _00280005 = "00280005";
 /// <summary>
 /// 测试员
 /// </summary>
public const string _00280006 = "00280006";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string _00530001 = "00530001";
 /// <summary>
 /// 公司负责人
 /// </summary>
public const string _00530002 = "00530002";
 /// <summary>
 /// 部门经理
 /// </summary>
public const string _00530003 = "00530003";
 /// <summary>
 /// 公司成员
 /// </summary>
public const string _00530004 = "00530004";
 /// <summary>
 /// 项目经理
 /// </summary>
public const string _00530005 = "00530005";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _00620001 = "00620001";
 /// <summary>
 /// AAA
 /// </summary>
public const string _00620002 = "00620002";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _01010001 = "01010001";
 /// <summary>
 /// 部门经理
 /// </summary>
public const string _01010002 = "01010002";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string _01010003 = "01010003";
 /// <summary>
 /// 程序员
 /// </summary>
public const string _01010004 = "01010004";
 /// <summary>
 /// 数据库设计
 /// </summary>
public const string _01010005 = "01010005";
 /// <summary>
 /// 人事主管
 /// </summary>
public const string _01010006 = "01010006";
 /// <summary>
 /// 美工
 /// </summary>
public const string _01010007 = "01010007";
 /// <summary>
 /// 项目测试
 /// </summary>
public const string _01010008 = "01010008";
 /// <summary>
 /// 成员
 /// </summary>
public const string _01010009 = "01010009";
 /// <summary>
 /// 部门领导
 /// </summary>
public const string _01010010 = "01010010";
 /// <summary>
 /// 系统超级管理员
 /// </summary>
public const string _01010011 = "01010011";
 /// <summary>
 /// 医生
 /// </summary>
public const string _01010012 = "01010012";
 /// <summary>
 /// 护士
 /// </summary>
public const string _01010013 = "01010013";
 /// <summary>
 /// 部主任
 /// </summary>
public const string _01010014 = "01010014";
 /// <summary>
 /// 护士长
 /// </summary>
public const string _01010015 = "01010015";
 /// <summary>
 /// 院长
 /// </summary>
public const string _01010016 = "01010016";
 /// <summary>
 /// 书记
 /// </summary>
public const string _01010017 = "01010017";
 /// <summary>
 /// 副院长
 /// </summary>
public const string _01010018 = "01010018";
 /// <summary>
 /// 处长
 /// </summary>
public const string _01010019 = "01010019";
 /// <summary>
 /// 副处长
 /// </summary>
public const string _01010020 = "01010020";
 /// <summary>
 /// 科长
 /// </summary>
public const string _01010021 = "01010021";
 /// <summary>
 /// 一般职工
 /// </summary>
public const string _01010022 = "01010022";
 /// <summary>
 /// 项目主管
 /// </summary>
public const string _01010023 = "01010023";
 /// <summary>
 /// 公司总经理
 /// </summary>
public const string _01010024 = "01010024";
 /// <summary>
 /// 公司副总经理
 /// </summary>
public const string _01010025 = "01010025";
 /// <summary>
 /// 部门副经理
 /// </summary>
public const string _01010026 = "01010026";
 /// <summary>
 /// 执行董事
 /// </summary>
public const string _01010027 = "01010027";
 /// <summary>
 /// 董事长
 /// </summary>
public const string _01010028 = "01010028";
 /// <summary>
 /// 测试
 /// </summary>
public const string _01010033 = "01010033";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _01090001 = "01090001";
 /// <summary>
 /// 操作员
 /// </summary>
public const string _01090002 = "01090002";
 /// <summary>
 /// 单位管理员
 /// </summary>
public const string _01090003 = "01090003";
 /// <summary>
 /// 问卷集操作员
 /// </summary>
public const string _01090004 = "01090004";
 /// <summary>
 /// 分类管理员
 /// </summary>
public const string _01090005 = "01090005";
 /// <summary>
 /// 系统管理员
 /// </summary>
public const string _01500001 = "01500001";
 /// <summary>
 /// 项目管理员
 /// </summary>
public const string _01670001 = "01670001";
 /// <summary>
 /// 教师
 /// </summary>
public const string _01670002 = "01670002";
 /// <summary>
 /// 学生
 /// </summary>
public const string _01670003 = "01670003";
}
 /// <summary>
 /// 角色(QxRoles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQxRolesWApi
{
private static readonly string mstrApiControllerName = "QxRolesApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsQxRolesWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[角色]...","0");
List<clsQxRolesEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="RoleId";
objDDL.DataTextField="RoleName";
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

 /// <param name = "strQxPrjId"></param>
public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox , string strQxPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxRoles.RoleId); 
List<clsQxRolesEN> arrObjLst = clsQxRolesWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.QxPrjId == strQxPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxRolesEN objQxRolesEN = new clsQxRolesEN()
{
RoleId = "0",
RoleName = "选[角色]..."
};
arrObjLstSel.Insert(0, objQxRolesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxRoles.RoleId;
objComboBox.DisplayMember = conQxRoles.RoleName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQxRolesEN objQxRolesEN)
{
if (!Object.Equals(null, objQxRolesEN.RoleId) && GetStrLen(objQxRolesEN.RoleId) > 8)
{
 throw new Exception("字段[角色Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQxRolesEN.RoleName) && GetStrLen(objQxRolesEN.RoleName) > 50)
{
 throw new Exception("字段[角色名称]的长度不能超过50!");
}
if (!Object.Equals(null, objQxRolesEN.RoleENName) && GetStrLen(objQxRolesEN.RoleENName) > 50)
{
 throw new Exception("字段[角色英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objQxRolesEN.UserType) && GetStrLen(objQxRolesEN.UserType) > 50)
{
 throw new Exception("字段[用户类型]的长度不能超过50!");
}
if (!Object.Equals(null, objQxRolesEN.QxPrjId) && GetStrLen(objQxRolesEN.QxPrjId) > 4)
{
 throw new Exception("字段[项目Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQxRolesEN.UpdDate) && GetStrLen(objQxRolesEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQxRolesEN.UpdUserId) && GetStrLen(objQxRolesEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objQxRolesEN.Memo) && GetStrLen(objQxRolesEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQxRolesEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRolesEN GetObjByRoleId(string strRoleId)
{
string strAction = "GetObjByRoleId";
clsQxRolesEN objQxRolesEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRoleId"] = strRoleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objQxRolesEN = JsonConvert.DeserializeObject<clsQxRolesEN>(strJson);
return objQxRolesEN;
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
public static clsQxRolesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsQxRolesEN objQxRolesEN;
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
objQxRolesEN = JsonConvert.DeserializeObject<clsQxRolesEN>(strJson);
return objQxRolesEN;
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
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRolesEN GetObjByRoleIdCache(string strRoleId,string strQxPrjId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQxRolesEN._CurrTabName, strQxPrjId);
List<clsQxRolesEN> arrQxRolesObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxRolesEN> arrQxRolesObjLst_Sel =
from objQxRolesEN in arrQxRolesObjLstCache
where objQxRolesEN.RoleId == strRoleId 
select objQxRolesEN;
if (arrQxRolesObjLst_Sel.Count() == 0)
{
   clsQxRolesEN obj = clsQxRolesWApi.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQxRolesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRoleNameByRoleIdCache(string strRoleId,string strQxPrjId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//初始化列表缓存
List<clsQxRolesEN> arrQxRolesObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxRolesEN> arrQxRolesObjLst_Sel1 =
from objQxRolesEN in arrQxRolesObjLstCache
where objQxRolesEN.RoleId == strRoleId 
select objQxRolesEN;
List <clsQxRolesEN> arrQxRolesObjLst_Sel = new List<clsQxRolesEN>();
foreach (clsQxRolesEN obj in arrQxRolesObjLst_Sel1)
{
arrQxRolesObjLst_Sel.Add(obj);
}
if (arrQxRolesObjLst_Sel.Count > 0)
{
return arrQxRolesObjLst_Sel[0].RoleName;
}
string strErrMsgForGetObjById = string.Format("在QxRoles对象缓存列表中,找不到记录[RoleId = {0}](函数:{1})", strRoleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRoleIdCache(string strRoleId,string strQxPrjId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//初始化列表缓存
List<clsQxRolesEN> arrQxRolesObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxRolesEN> arrQxRolesObjLst_Sel1 =
from objQxRolesEN in arrQxRolesObjLstCache
where objQxRolesEN.RoleId == strRoleId 
select objQxRolesEN;
List <clsQxRolesEN> arrQxRolesObjLst_Sel = new List<clsQxRolesEN>();
foreach (clsQxRolesEN obj in arrQxRolesObjLst_Sel1)
{
arrQxRolesObjLst_Sel.Add(obj);
}
if (arrQxRolesObjLst_Sel.Count > 0)
{
return arrQxRolesObjLst_Sel[0].RoleName;
}
string strErrMsgForGetObjById = string.Format("在QxRoles对象缓存列表中,找不到记录的相关名称[RoleId = {0}](函数:{1})", strRoleId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQxRolesBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolesEN> GetObjLst(string strWhereCond)
{
 List<clsQxRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRolesEN>>(strJson);
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
 /// <param name = "arrRoleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolesEN> GetObjLstByRoleIdLst(List<string> arrRoleId)
{
 List<clsQxRolesEN> arrObjLst; 
string strAction = "GetObjLstByRoleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRoleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRolesEN>>(strJson);
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

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRoleId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsQxRolesEN> GetObjLstByRoleIdLstCache(List<string> arrRoleId, string strQxPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQxRolesEN._CurrTabName, strQxPrjId);
List<clsQxRolesEN> arrQxRolesObjLstCache = GetObjLstCache(strQxPrjId);
IEnumerable <clsQxRolesEN> arrQxRolesObjLst_Sel =
from objQxRolesEN in arrQxRolesObjLstCache
where arrRoleId.Contains(objQxRolesEN.RoleId)
select objQxRolesEN;
return arrQxRolesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRolesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQxRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRolesEN>>(strJson);
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
public static List<clsQxRolesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQxRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRolesEN>>(strJson);
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
public static List<clsQxRolesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQxRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRolesEN>>(strJson);
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
public static List<clsQxRolesEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsQxRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQxRolesEN>>(strJson);
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
public static int DelRecord(string strRoleId)
{
string strAction = "DelRecord";
try
{
 clsQxRolesEN objQxRolesEN = clsQxRolesWApi.GetObjByRoleId(strRoleId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strRoleId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
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
public static int DelQxRoless(List<string> arrRoleId)
{
string strAction = "DelQxRoless";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRoleId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsQxRolesEN objQxRolesEN = clsQxRolesWApi.GetObjByRoleId(arrRoleId[0]);
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
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
public static int DelQxRolessByCond(string strWhereCond)
{
string strAction = "DelQxRolessByCond";
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
public static bool AddNewRecord(clsQxRolesEN objQxRolesEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRolesEN>(objQxRolesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
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
public static string AddNewRecordWithMaxId(clsQxRolesEN objQxRolesEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRolesEN>(objQxRolesEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRolesWApi.ReFreshCache(objQxRolesEN.QxPrjId);
var strRoleId = (string)jobjReturn0["returnStr"];
return strRoleId;
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
public static bool UpdateRecord(clsQxRolesEN objQxRolesEN)
{
if (string.IsNullOrEmpty(objQxRolesEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRolesEN.RoleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRolesEN>(objQxRolesEN);
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
 /// <param name = "objQxRolesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQxRolesEN objQxRolesEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQxRolesEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRolesEN.RoleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objQxRolesEN.RoleId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQxRolesEN>(objQxRolesEN);
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
public static bool IsExist(string strRoleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strRoleId"] = strRoleId
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
 /// <param name = "objQxRolesENS">源对象</param>
 /// <param name = "objQxRolesENT">目标对象</param>
 public static void CopyTo(clsQxRolesEN objQxRolesENS, clsQxRolesEN objQxRolesENT)
{
try
{
objQxRolesENT.RoleId = objQxRolesENS.RoleId; //角色Id
objQxRolesENT.RoleName = objQxRolesENS.RoleName; //角色名称
objQxRolesENT.RoleENName = objQxRolesENS.RoleENName; //角色英文名
objQxRolesENT.RoleIndex = objQxRolesENS.RoleIndex; //角色序号
objQxRolesENT.UserType = objQxRolesENS.UserType; //用户类型
objQxRolesENT.QxPrjId = objQxRolesENS.QxPrjId; //项目Id
objQxRolesENT.IsInUse = objQxRolesENS.IsInUse; //是否在使用
objQxRolesENT.UpdDate = objQxRolesENS.UpdDate; //修改日期
objQxRolesENT.UpdUserId = objQxRolesENS.UpdUserId; //修改用户Id
objQxRolesENT.Memo = objQxRolesENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQxRolesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQxRolesEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQxRolesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQxRolesEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQxRolesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQxRolesEN.AttributeName)
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
public static void ReFreshThisCache(string strQxPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsQxRolesEN._CurrTabName, strQxPrjId);
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
public static void ReFreshCache(string strQxPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQxRolesWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQxRolesEN._CurrTabName, strQxPrjId);
CacheHelper.Remove(strKey);
clsQxRolesWApi.objCommFun4WApi.ReFreshCache(strQxPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRolesEN> GetObjLstCache(string strQxPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsQxRolesEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsQxRolesEN._WhereFormat, strQxPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conQxRoles.QxPrjId, strQxPrjId);
}
var strKey = string.Format("{0}_{1}", clsQxRolesEN._CurrTabName, strQxPrjId);
List<clsQxRolesEN> arrQxRolesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrQxRolesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRolesEN> GetObjLstCacheFromObjLst(string strQxPrjId,List<clsQxRolesEN> arrObjLst_P)
{
var strKey = string.Format("{0}_{1}", clsQxRolesEN._CurrTabName, strQxPrjId);
List<clsQxRolesEN> arrQxRolesObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrQxRolesObjLstCache = CacheHelper.Get<List<clsQxRolesEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.QxPrjId == strQxPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrQxRolesObjLstCache = CacheHelper.Get<List<clsQxRolesEN>>(strKey);
}
return arrQxRolesObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQxRolesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQxRoles.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoles.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoles.RoleENName, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoles.RoleIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conQxRoles.UserType, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoles.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoles.IsInUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQxRoles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoles.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conQxRoles.Memo, Type.GetType("System.String"));
foreach (clsQxRolesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQxRoles.RoleId] = objInFor[conQxRoles.RoleId];
objDR[conQxRoles.RoleName] = objInFor[conQxRoles.RoleName];
objDR[conQxRoles.RoleENName] = objInFor[conQxRoles.RoleENName];
objDR[conQxRoles.RoleIndex] = objInFor[conQxRoles.RoleIndex];
objDR[conQxRoles.UserType] = objInFor[conQxRoles.UserType];
objDR[conQxRoles.QxPrjId] = objInFor[conQxRoles.QxPrjId];
objDR[conQxRoles.IsInUse] = objInFor[conQxRoles.IsInUse];
objDR[conQxRoles.UpdDate] = objInFor[conQxRoles.UpdDate];
objDR[conQxRoles.UpdUserId] = objInFor[conQxRoles.UpdUserId];
objDR[conQxRoles.Memo] = objInFor[conQxRoles.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 角色(QxRoles)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4QxRoles : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strQxPrjId)
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
clsQxRolesWApi.ReFreshThisCache(strQxPrjId);
}
}

}