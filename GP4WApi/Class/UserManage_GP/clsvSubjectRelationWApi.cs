
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSubjectRelationWApi
 表名:vSubjectRelation(00140053)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:37:17
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
public static class  clsvSubjectRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetmId(this clsvSubjectRelationEN objvSubjectRelationEN, long lngmId, string strComparisonOp="")
	{
objvSubjectRelationEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.mId) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.mId, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.mId] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetUserId(this clsvSubjectRelationEN objvSubjectRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convSubjectRelation.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convSubjectRelation.UserId);
objvSubjectRelationEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.UserId) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.UserId, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.UserId] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetUserName(this clsvSubjectRelationEN objvSubjectRelationEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convSubjectRelation.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convSubjectRelation.UserName);
objvSubjectRelationEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.UserName) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.UserName, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.UserName] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetDepartmentId(this clsvSubjectRelationEN objvSubjectRelationEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convSubjectRelation.DepartmentId);
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convSubjectRelation.DepartmentId);
objvSubjectRelationEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.DepartmentId) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.DepartmentId, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.DepartmentId] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetDepartmentName(this clsvSubjectRelationEN objvSubjectRelationEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convSubjectRelation.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convSubjectRelation.DepartmentName);
objvSubjectRelationEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.DepartmentName) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.DepartmentName, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.DepartmentName] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strLeaderId">领导Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderId(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLeaderId, convSubjectRelation.LeaderId);
clsCheckSql.CheckFieldLen(strLeaderId, 18, convSubjectRelation.LeaderId);
objvSubjectRelationEN.LeaderId = strLeaderId; //领导Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.LeaderId) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.LeaderId, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.LeaderId] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDirectLeader">是否直接领导</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetIsDirectLeader(this clsvSubjectRelationEN objvSubjectRelationEN, bool bolIsDirectLeader, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDirectLeader, convSubjectRelation.IsDirectLeader);
objvSubjectRelationEN.IsDirectLeader = bolIsDirectLeader; //是否直接领导
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.IsDirectLeader) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.IsDirectLeader, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.IsDirectLeader] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetMemo(this clsvSubjectRelationEN objvSubjectRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSubjectRelation.Memo);
objvSubjectRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.Memo) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.Memo, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.Memo] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strLeaderUserName">LeaderUserName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderUserName(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLeaderUserName, 30, convSubjectRelation.LeaderUserName);
objvSubjectRelationEN.LeaderUserName = strLeaderUserName; //LeaderUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.LeaderUserName) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.LeaderUserName, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.LeaderUserName] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strLeaderDepartmentId">LeaderDepartmentId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderDepartmentId(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLeaderDepartmentId, 6, convSubjectRelation.LeaderDepartmentId);
objvSubjectRelationEN.LeaderDepartmentId = strLeaderDepartmentId; //LeaderDepartmentId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.LeaderDepartmentId) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.LeaderDepartmentId, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.LeaderDepartmentId] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strLeaderDepartmentName">LeaderDepartmentName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderDepartmentName(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLeaderDepartmentName, 100, convSubjectRelation.LeaderDepartmentName);
objvSubjectRelationEN.LeaderDepartmentName = strLeaderDepartmentName; //LeaderDepartmentName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSubjectRelationEN.dicFldComparisonOp.ContainsKey(convSubjectRelation.LeaderDepartmentName) == false)
{
objvSubjectRelationEN.dicFldComparisonOp.Add(convSubjectRelation.LeaderDepartmentName, strComparisonOp);
}
else
{
objvSubjectRelationEN.dicFldComparisonOp[convSubjectRelation.LeaderDepartmentName] = strComparisonOp;
}
}
return objvSubjectRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSubjectRelationEN objvSubjectRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.mId) == true)
{
string strComparisonOpmId = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convSubjectRelation.mId, objvSubjectRelationCond.mId, strComparisonOpmId);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.UserId) == true)
{
string strComparisonOpUserId = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.UserId, objvSubjectRelationCond.UserId, strComparisonOpUserId);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.UserName) == true)
{
string strComparisonOpUserName = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.UserName, objvSubjectRelationCond.UserName, strComparisonOpUserName);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.DepartmentId, objvSubjectRelationCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.DepartmentName, objvSubjectRelationCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.LeaderId) == true)
{
string strComparisonOpLeaderId = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.LeaderId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.LeaderId, objvSubjectRelationCond.LeaderId, strComparisonOpLeaderId);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.IsDirectLeader) == true)
{
if (objvSubjectRelationCond.IsDirectLeader == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSubjectRelation.IsDirectLeader);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSubjectRelation.IsDirectLeader);
}
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.Memo) == true)
{
string strComparisonOpMemo = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.Memo, objvSubjectRelationCond.Memo, strComparisonOpMemo);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.LeaderUserName) == true)
{
string strComparisonOpLeaderUserName = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.LeaderUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.LeaderUserName, objvSubjectRelationCond.LeaderUserName, strComparisonOpLeaderUserName);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.LeaderDepartmentId) == true)
{
string strComparisonOpLeaderDepartmentId = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.LeaderDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.LeaderDepartmentId, objvSubjectRelationCond.LeaderDepartmentId, strComparisonOpLeaderDepartmentId);
}
if (objvSubjectRelationCond.IsUpdated(convSubjectRelation.LeaderDepartmentName) == true)
{
string strComparisonOpLeaderDepartmentName = objvSubjectRelationCond.dicFldComparisonOp[convSubjectRelation.LeaderDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSubjectRelation.LeaderDepartmentName, objvSubjectRelationCond.LeaderDepartmentName, strComparisonOpLeaderDepartmentName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v隶属关系(vSubjectRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSubjectRelationWApi
{
private static readonly string mstrApiControllerName = "vSubjectRelationApi";

 public clsvSubjectRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSubjectRelationEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvSubjectRelationEN objvSubjectRelationEN;
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
objvSubjectRelationEN = JsonConvert.DeserializeObject<clsvSubjectRelationEN>(strJson);
return objvSubjectRelationEN;
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
public static clsvSubjectRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvSubjectRelationEN objvSubjectRelationEN;
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
objvSubjectRelationEN = JsonConvert.DeserializeObject<clsvSubjectRelationEN>(strJson);
return objvSubjectRelationEN;
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
public static List<clsvSubjectRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvSubjectRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSubjectRelationEN>>(strJson);
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
public static List<clsvSubjectRelationEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvSubjectRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSubjectRelationEN>>(strJson);
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
public static List<clsvSubjectRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSubjectRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSubjectRelationEN>>(strJson);
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
public static List<clsvSubjectRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSubjectRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSubjectRelationEN>>(strJson);
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
public static List<clsvSubjectRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSubjectRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSubjectRelationEN>>(strJson);
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
public static List<clsvSubjectRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvSubjectRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSubjectRelationEN>>(strJson);
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
 /// <param name = "objvSubjectRelationENS">源对象</param>
 /// <param name = "objvSubjectRelationENT">目标对象</param>
 public static void CopyTo(clsvSubjectRelationEN objvSubjectRelationENS, clsvSubjectRelationEN objvSubjectRelationENT)
{
try
{
objvSubjectRelationENT.mId = objvSubjectRelationENS.mId; //流水号
objvSubjectRelationENT.UserId = objvSubjectRelationENS.UserId; //用户ID
objvSubjectRelationENT.UserName = objvSubjectRelationENS.UserName; //用户名
objvSubjectRelationENT.DepartmentId = objvSubjectRelationENS.DepartmentId; //部门Id
objvSubjectRelationENT.DepartmentName = objvSubjectRelationENS.DepartmentName; //部门名
objvSubjectRelationENT.LeaderId = objvSubjectRelationENS.LeaderId; //领导Id
objvSubjectRelationENT.IsDirectLeader = objvSubjectRelationENS.IsDirectLeader; //是否直接领导
objvSubjectRelationENT.Memo = objvSubjectRelationENS.Memo; //备注
objvSubjectRelationENT.LeaderUserName = objvSubjectRelationENS.LeaderUserName; //LeaderUserName
objvSubjectRelationENT.LeaderDepartmentId = objvSubjectRelationENS.LeaderDepartmentId; //LeaderDepartmentId
objvSubjectRelationENT.LeaderDepartmentName = objvSubjectRelationENS.LeaderDepartmentName; //LeaderDepartmentName
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
public static DataTable ToDataTable(List<clsvSubjectRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSubjectRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSubjectRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSubjectRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSubjectRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSubjectRelationEN.AttributeName)
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
string strKey = string.Format("{0}", clsvSubjectRelationEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvSubjectRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSubjectRelation.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convSubjectRelation.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.LeaderId, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.IsDirectLeader, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSubjectRelation.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.LeaderUserName, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.LeaderDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convSubjectRelation.LeaderDepartmentName, Type.GetType("System.String"));
foreach (clsvSubjectRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSubjectRelation.mId] = objInFor[convSubjectRelation.mId];
objDR[convSubjectRelation.UserId] = objInFor[convSubjectRelation.UserId];
objDR[convSubjectRelation.UserName] = objInFor[convSubjectRelation.UserName];
objDR[convSubjectRelation.DepartmentId] = objInFor[convSubjectRelation.DepartmentId];
objDR[convSubjectRelation.DepartmentName] = objInFor[convSubjectRelation.DepartmentName];
objDR[convSubjectRelation.LeaderId] = objInFor[convSubjectRelation.LeaderId];
objDR[convSubjectRelation.IsDirectLeader] = objInFor[convSubjectRelation.IsDirectLeader];
objDR[convSubjectRelation.Memo] = objInFor[convSubjectRelation.Memo];
objDR[convSubjectRelation.LeaderUserName] = objInFor[convSubjectRelation.LeaderUserName];
objDR[convSubjectRelation.LeaderDepartmentId] = objInFor[convSubjectRelation.LeaderDepartmentId];
objDR[convSubjectRelation.LeaderDepartmentName] = objInFor[convSubjectRelation.LeaderDepartmentName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}