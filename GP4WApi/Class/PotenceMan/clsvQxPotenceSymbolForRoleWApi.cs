
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceSymbolForRoleWApi
 表名:vQxPotenceSymbolForRole(00140047)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:37:04
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
public static class  clsvQxPotenceSymbolForRoleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetRoleId(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxPotenceSymbolForRole.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxPotenceSymbolForRole.RoleId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "lngRelaMid">流水号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceId">权限ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceId(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxPotenceSymbolForRole.PotenceId);
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxPotenceSymbolForRole.PotenceId);
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxPotenceSymbolForRole.PotenceId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolForProgramme">编程标志</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetSymbolForProgramme(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strSymbolForProgramme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolForProgramme, convQxPotenceSymbolForRole.SymbolForProgramme);
clsCheckSql.CheckFieldLen(strSymbolForProgramme, 20, convQxPotenceSymbolForRole.SymbolForProgramme);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceName">权限名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceName(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxPotenceSymbolForRole.PotenceName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeId">权限类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceTypeId(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceTypeId, 6, convQxPotenceSymbolForRole.PotenceTypeId);
clsCheckSql.CheckFieldForeignKey(strPotenceTypeId, 6, convQxPotenceSymbolForRole.PotenceTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPotenceTypeName">权限类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetPotenceTypeName(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strPotenceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPotenceTypeName, 50, convQxPotenceSymbolForRole.PotenceTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPotenceSymbolForRoleEN">需要设置字段值的实体对象</param>
 /// <param name = "strSymbolName">标志名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPotenceSymbolForRoleEN SetSymbolName(this clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN, string strSymbolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSymbolName, 200, convQxPotenceSymbolForRole.SymbolName);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// vPotenceSymbolForRole(vQxPotenceSymbolForRole)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPotenceSymbolForRoleWApi
{
private static readonly string mstrApiControllerName = "vQxPotenceSymbolForRoleApi";

 public clsvQxPotenceSymbolForRoleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPotenceSymbolForRoleEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvQxPotenceSymbolForRoleEN = JsonConvert.DeserializeObject<clsvQxPotenceSymbolForRoleEN>(strJson);
return objvQxPotenceSymbolForRoleEN;
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
public static clsvQxPotenceSymbolForRoleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPotenceSymbolForRoleEN objvQxPotenceSymbolForRoleEN;
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
objvQxPotenceSymbolForRoleEN = JsonConvert.DeserializeObject<clsvQxPotenceSymbolForRoleEN>(strJson);
return objvQxPotenceSymbolForRoleEN;
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceSymbolForRoleEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceSymbolForRoleEN>>(strJson);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceSymbolForRoleEN>>(strJson);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceSymbolForRoleEN>>(strJson);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceSymbolForRoleEN>>(strJson);
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
public static List<clsvQxPotenceSymbolForRoleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPotenceSymbolForRoleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPotenceSymbolForRoleEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
public static DataTable ToDataTable(List<clsvQxPotenceSymbolForRoleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPotenceSymbolForRoleEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPotenceSymbolForRoleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPotenceSymbolForRoleEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPotenceSymbolForRoleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPotenceSymbolForRoleEN.AttributeName)
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxPotenceSymbolForRoleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPotenceSymbolForRole.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxPotenceSymbolForRole.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceSymbolForRole.RelaMid, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxPotenceSymbolForRole.PotenceId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceSymbolForRole.SymbolForProgramme, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceSymbolForRole.PotenceName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceSymbolForRole.PotenceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceSymbolForRole.PotenceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPotenceSymbolForRole.SymbolName, Type.GetType("System.String"));
foreach (clsvQxPotenceSymbolForRoleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPotenceSymbolForRole.mId] = objInFor[convQxPotenceSymbolForRole.mId];
objDR[convQxPotenceSymbolForRole.RoleId] = objInFor[convQxPotenceSymbolForRole.RoleId];
objDR[convQxPotenceSymbolForRole.RelaMid] = objInFor[convQxPotenceSymbolForRole.RelaMid];
objDR[convQxPotenceSymbolForRole.PotenceId] = objInFor[convQxPotenceSymbolForRole.PotenceId];
objDR[convQxPotenceSymbolForRole.SymbolForProgramme] = objInFor[convQxPotenceSymbolForRole.SymbolForProgramme];
objDR[convQxPotenceSymbolForRole.PotenceName] = objInFor[convQxPotenceSymbolForRole.PotenceName];
objDR[convQxPotenceSymbolForRole.PotenceTypeId] = objInFor[convQxPotenceSymbolForRole.PotenceTypeId];
objDR[convQxPotenceSymbolForRole.PotenceTypeName] = objInFor[convQxPotenceSymbolForRole.PotenceTypeName];
objDR[convQxPotenceSymbolForRole.SymbolName] = objInFor[convQxPotenceSymbolForRole.SymbolName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}