
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjUserRelationWApi
 表名:vQxPrjUserRelation(00140032)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 18:32:27
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
public static class  clsvQxPrjUserRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetmId(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, long lngmId, string strComparisonOp="")
	{
objvQxPrjUserRelationEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.mId) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.mId, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.mId] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetQxPrjId(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjUserRelation.QxPrjId);
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjUserRelation.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjUserRelation.QxPrjId);
objvQxPrjUserRelationEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.QxPrjId) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.QxPrjId, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.QxPrjId] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetPrjName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjUserRelation.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjUserRelation.PrjName);
objvQxPrjUserRelationEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.PrjName) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.PrjName, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.PrjName] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetUserId(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxPrjUserRelation.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, convQxPrjUserRelation.UserId);
objvQxPrjUserRelationEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.UserId) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.UserId, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.UserId] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetUserName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxPrjUserRelation.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convQxPrjUserRelation.UserName);
objvQxPrjUserRelationEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.UserName) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.UserName, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.UserName] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentId">部门Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetDepartmentId(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxPrjUserRelation.DepartmentId);
objvQxPrjUserRelationEN.DepartmentId = strDepartmentId; //部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.DepartmentId) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.DepartmentId, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.DepartmentId] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strDepartmentName">部门名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetDepartmentName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxPrjUserRelation.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxPrjUserRelation.DepartmentName);
objvQxPrjUserRelationEN.DepartmentName = strDepartmentName; //部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.DepartmentName) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.DepartmentName, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.DepartmentName] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserStateName">用户状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetUserStateName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxPrjUserRelation.UserStateName);
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxPrjUserRelation.UserStateName);
objvQxPrjUserRelationEN.UserStateName = strUserStateName; //用户状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.UserStateName) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.UserStateName, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.UserStateName] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdentityDesc">身份描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetIdentityDesc(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strIdentityDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxPrjUserRelation.IdentityDesc);
objvQxPrjUserRelationEN.IdentityDesc = strIdentityDesc; //身份描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.IdentityDesc) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.IdentityDesc, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.IdentityDesc] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetMemo(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjUserRelation.Memo);
objvQxPrjUserRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxPrjUserRelationEN.dicFldComparisonOp.ContainsKey(convQxPrjUserRelation.Memo) == false)
{
objvQxPrjUserRelationEN.dicFldComparisonOp.Add(convQxPrjUserRelation.Memo, strComparisonOp);
}
else
{
objvQxPrjUserRelationEN.dicFldComparisonOp[convQxPrjUserRelation.Memo] = strComparisonOp;
}
}
return objvQxPrjUserRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxPrjUserRelationEN objvQxPrjUserRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.mId) == true)
{
string strComparisonOpmId = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxPrjUserRelation.mId, objvQxPrjUserRelationCond.mId, strComparisonOpmId);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.QxPrjId, objvQxPrjUserRelationCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.PrjName) == true)
{
string strComparisonOpPrjName = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.PrjName, objvQxPrjUserRelationCond.PrjName, strComparisonOpPrjName);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.UserId) == true)
{
string strComparisonOpUserId = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.UserId, objvQxPrjUserRelationCond.UserId, strComparisonOpUserId);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.UserName) == true)
{
string strComparisonOpUserName = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.UserName, objvQxPrjUserRelationCond.UserName, strComparisonOpUserName);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.DepartmentId, objvQxPrjUserRelationCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.DepartmentName, objvQxPrjUserRelationCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.UserStateName) == true)
{
string strComparisonOpUserStateName = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.UserStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.UserStateName, objvQxPrjUserRelationCond.UserStateName, strComparisonOpUserStateName);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.IdentityDesc) == true)
{
string strComparisonOpIdentityDesc = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.IdentityDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.IdentityDesc, objvQxPrjUserRelationCond.IdentityDesc, strComparisonOpIdentityDesc);
}
if (objvQxPrjUserRelationCond.IsUpdated(convQxPrjUserRelation.Memo) == true)
{
string strComparisonOpMemo = objvQxPrjUserRelationCond.dicFldComparisonOp[convQxPrjUserRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxPrjUserRelation.Memo, objvQxPrjUserRelationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程用户关系(vQxPrjUserRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjUserRelationWApi
{
private static readonly string mstrApiControllerName = "vQxPrjUserRelationApi";

 public clsvQxPrjUserRelationWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelationEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsvQxPrjUserRelationEN objvQxPrjUserRelationEN;
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
objvQxPrjUserRelationEN = JsonConvert.DeserializeObject<clsvQxPrjUserRelationEN>(strJson);
return objvQxPrjUserRelationEN;
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
public static clsvQxPrjUserRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxPrjUserRelationEN objvQxPrjUserRelationEN;
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
objvQxPrjUserRelationEN = JsonConvert.DeserializeObject<clsvQxPrjUserRelationEN>(strJson);
return objvQxPrjUserRelationEN;
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
public static List<clsvQxPrjUserRelationEN> GetObjLst(string strWhereCond)
{
 List<clsvQxPrjUserRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationEN>>(strJson);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQxPrjUserRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationEN>>(strJson);
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
public static List<clsvQxPrjUserRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxPrjUserRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationEN>>(strJson);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxPrjUserRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationEN>>(strJson);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxPrjUserRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationEN>>(strJson);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxPrjUserRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxPrjUserRelationEN>>(strJson);
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
 /// <param name = "objvQxPrjUserRelationENS">源对象</param>
 /// <param name = "objvQxPrjUserRelationENT">目标对象</param>
 public static void CopyTo(clsvQxPrjUserRelationEN objvQxPrjUserRelationENS, clsvQxPrjUserRelationEN objvQxPrjUserRelationENT)
{
try
{
objvQxPrjUserRelationENT.mId = objvQxPrjUserRelationENS.mId; //流水号
objvQxPrjUserRelationENT.QxPrjId = objvQxPrjUserRelationENS.QxPrjId; //项目Id
objvQxPrjUserRelationENT.PrjName = objvQxPrjUserRelationENS.PrjName; //工程名
objvQxPrjUserRelationENT.UserId = objvQxPrjUserRelationENS.UserId; //用户ID
objvQxPrjUserRelationENT.UserName = objvQxPrjUserRelationENS.UserName; //用户名
objvQxPrjUserRelationENT.DepartmentId = objvQxPrjUserRelationENS.DepartmentId; //部门Id
objvQxPrjUserRelationENT.DepartmentName = objvQxPrjUserRelationENS.DepartmentName; //部门名
objvQxPrjUserRelationENT.UserStateName = objvQxPrjUserRelationENS.UserStateName; //用户状态名
objvQxPrjUserRelationENT.IdentityDesc = objvQxPrjUserRelationENS.IdentityDesc; //身份描述
objvQxPrjUserRelationENT.Memo = objvQxPrjUserRelationENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxPrjUserRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxPrjUserRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxPrjUserRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxPrjUserRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxPrjUserRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxPrjUserRelationEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxPrjUserRelationEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvQxPrjUserRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxPrjUserRelation.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQxPrjUserRelation.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.UserStateName, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.IdentityDesc, Type.GetType("System.String"));
objDT.Columns.Add(convQxPrjUserRelation.Memo, Type.GetType("System.String"));
foreach (clsvQxPrjUserRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxPrjUserRelation.mId] = objInFor[convQxPrjUserRelation.mId];
objDR[convQxPrjUserRelation.QxPrjId] = objInFor[convQxPrjUserRelation.QxPrjId];
objDR[convQxPrjUserRelation.PrjName] = objInFor[convQxPrjUserRelation.PrjName];
objDR[convQxPrjUserRelation.UserId] = objInFor[convQxPrjUserRelation.UserId];
objDR[convQxPrjUserRelation.UserName] = objInFor[convQxPrjUserRelation.UserName];
objDR[convQxPrjUserRelation.DepartmentId] = objInFor[convQxPrjUserRelation.DepartmentId];
objDR[convQxPrjUserRelation.DepartmentName] = objInFor[convQxPrjUserRelation.DepartmentName];
objDR[convQxPrjUserRelation.UserStateName] = objInFor[convQxPrjUserRelation.UserStateName];
objDR[convQxPrjUserRelation.IdentityDesc] = objInFor[convQxPrjUserRelation.IdentityDesc];
objDR[convQxPrjUserRelation.Memo] = objInFor[convQxPrjUserRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}