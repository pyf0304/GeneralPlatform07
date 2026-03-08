
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesWApi
 表名:vQxUserRoles(00140025)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:33:24
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

namespace GP4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsvQxUserRolesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetRoleId(this clsvQxUserRolesEN objvQxUserRolesEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRoles.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRoles.RoleId);
objvQxUserRolesEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.RoleId) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.RoleId, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.RoleId] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetRoleName(this clsvQxUserRolesEN objvQxUserRolesEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRoles.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRoles.RoleName);
objvQxUserRolesEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.RoleName) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.RoleName, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.RoleName] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleENName">角色英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetRoleENName(this clsvQxUserRolesEN objvQxUserRolesEN, string strRoleENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleENName, 50, convQxUserRoles.RoleENName);
objvQxUserRolesEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.RoleENName) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.RoleENName, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.RoleENName] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "intRoleIndex">角色序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetRoleIndex(this clsvQxUserRolesEN objvQxUserRolesEN, int intRoleIndex, string strComparisonOp="")
	{
objvQxUserRolesEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.RoleIndex) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.RoleIndex, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.RoleIndex] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetQxPrjId(this clsvQxUserRolesEN objvQxUserRolesEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxUserRoles.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRoles.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRoles.QxPrjId);
objvQxUserRolesEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.QxPrjId) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetPrjName(this clsvQxUserRolesEN objvQxUserRolesEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxUserRoles.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRoles.PrjName);
objvQxUserRolesEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.PrjName) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.PrjName, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.PrjName] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInUse">是否在使用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetIsInUse(this clsvQxUserRolesEN objvQxUserRolesEN, bool bolIsInUse, string strComparisonOp="")
	{
objvQxUserRolesEN.IsInUse = bolIsInUse; //是否在使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.IsInUse) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.IsInUse, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.IsInUse] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetUpdDate(this clsvQxUserRolesEN objvQxUserRolesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserRoles.UpdDate);
objvQxUserRolesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.UpdDate) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.UpdDate, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.UpdDate] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetUpdUserId(this clsvQxUserRolesEN objvQxUserRolesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserRoles.UpdUserId);
objvQxUserRolesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.UpdUserId) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.UpdUserId, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.UpdUserId] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesEN SetMemo(this clsvQxUserRolesEN objvQxUserRolesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRoles.Memo);
objvQxUserRolesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesEN.dicFldComparisonOp.ContainsKey(convQxUserRoles.Memo) == false)
{
objvQxUserRolesEN.dicFldComparisonOp.Add(convQxUserRoles.Memo, strComparisonOp);
}
else
{
objvQxUserRolesEN.dicFldComparisonOp[convQxUserRoles.Memo] = strComparisonOp;
}
}
return objvQxUserRolesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRolesEN objvQxUserRolesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.RoleId, objvQxUserRolesCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.RoleName, objvQxUserRolesCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.RoleENName) == true)
{
string strComparisonOpRoleENName = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.RoleENName, objvQxUserRolesCond.RoleENName, strComparisonOpRoleENName);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.RoleIndex) == true)
{
string strComparisonOpRoleIndex = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRoles.RoleIndex, objvQxUserRolesCond.RoleIndex, strComparisonOpRoleIndex);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.QxPrjId, objvQxUserRolesCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.PrjName, objvQxUserRolesCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.IsInUse) == true)
{
if (objvQxUserRolesCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUserRoles.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUserRoles.IsInUse);
}
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.UpdDate, objvQxUserRolesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.UpdUserId, objvQxUserRolesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxUserRolesCond.IsUpdated(convQxUserRoles.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRolesCond.dicFldComparisonOp[convQxUserRoles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRoles.Memo, objvQxUserRolesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v角色(vQxUserRoles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRolesWApi
{
private static readonly string mstrApiControllerName = "vQxUserRolesApi";

 public clsvQxUserRolesWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesEN GetObjByRoleId(string strRoleId)
{
string strAction = "GetObjByRoleId";
clsvQxUserRolesEN objvQxUserRolesEN;
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
objvQxUserRolesEN = JsonConvert.DeserializeObject<clsvQxUserRolesEN>(strJson);
return objvQxUserRolesEN;
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
public static clsvQxUserRolesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserRolesEN objvQxUserRolesEN;
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
objvQxUserRolesEN = JsonConvert.DeserializeObject<clsvQxUserRolesEN>(strJson);
return objvQxUserRolesEN;
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
public static List<clsvQxUserRolesEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesEN>>(strJson);
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
public static List<clsvQxUserRolesEN> GetObjLstByRoleIdLst(List<string> arrRoleId)
{
 List<clsvQxUserRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesEN>>(strJson);
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
public static List<clsvQxUserRolesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesEN>>(strJson);
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
public static List<clsvQxUserRolesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesEN>>(strJson);
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
public static List<clsvQxUserRolesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesEN>>(strJson);
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
public static List<clsvQxUserRolesEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserRolesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxUserRolesENS">源对象</param>
 /// <param name = "objvQxUserRolesENT">目标对象</param>
 public static void CopyTo(clsvQxUserRolesEN objvQxUserRolesENS, clsvQxUserRolesEN objvQxUserRolesENT)
{
try
{
objvQxUserRolesENT.RoleId = objvQxUserRolesENS.RoleId; //角色Id
objvQxUserRolesENT.RoleName = objvQxUserRolesENS.RoleName; //角色名称
objvQxUserRolesENT.RoleENName = objvQxUserRolesENS.RoleENName; //角色英文名
objvQxUserRolesENT.RoleIndex = objvQxUserRolesENS.RoleIndex; //角色序号
objvQxUserRolesENT.QxPrjId = objvQxUserRolesENS.QxPrjId; //项目Id
objvQxUserRolesENT.PrjName = objvQxUserRolesENS.PrjName; //工程名
objvQxUserRolesENT.IsInUse = objvQxUserRolesENS.IsInUse; //是否在使用
objvQxUserRolesENT.UpdDate = objvQxUserRolesENS.UpdDate; //修改日期
objvQxUserRolesENT.UpdUserId = objvQxUserRolesENS.UpdUserId; //修改用户Id
objvQxUserRolesENT.Memo = objvQxUserRolesENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxUserRolesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserRolesEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserRolesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserRolesEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserRolesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserRolesEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserRolesEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxUserRolesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserRoles.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoles.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoles.RoleENName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoles.RoleIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxUserRoles.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoles.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoles.IsInUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUserRoles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoles.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRoles.Memo, Type.GetType("System.String"));
foreach (clsvQxUserRolesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserRoles.RoleId] = objInFor[convQxUserRoles.RoleId];
objDR[convQxUserRoles.RoleName] = objInFor[convQxUserRoles.RoleName];
objDR[convQxUserRoles.RoleENName] = objInFor[convQxUserRoles.RoleENName];
objDR[convQxUserRoles.RoleIndex] = objInFor[convQxUserRoles.RoleIndex];
objDR[convQxUserRoles.QxPrjId] = objInFor[convQxUserRoles.QxPrjId];
objDR[convQxUserRoles.PrjName] = objInFor[convQxUserRoles.PrjName];
objDR[convQxUserRoles.IsInUse] = objInFor[convQxUserRoles.IsInUse];
objDR[convQxUserRoles.UpdDate] = objInFor[convQxUserRoles.UpdDate];
objDR[convQxUserRoles.UpdUserId] = objInFor[convQxUserRoles.UpdUserId];
objDR[convQxUserRoles.Memo] = objInFor[convQxUserRoles.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}