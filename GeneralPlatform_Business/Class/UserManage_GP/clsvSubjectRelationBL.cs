
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSubjectRelationBL
 表名:vSubjectRelation(00140053)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:07
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
public static class  clsvSubjectRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSubjectRelationEN GetObj(this K_mId_vSubjectRelation myKey)
{
clsvSubjectRelationEN objvSubjectRelationEN = clsvSubjectRelationBL.vSubjectRelationDA.GetObjBymId(myKey.Value);
return objvSubjectRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetUserId(this clsvSubjectRelationEN objvSubjectRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convSubjectRelation.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convSubjectRelation.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetUserName(this clsvSubjectRelationEN objvSubjectRelationEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convSubjectRelation.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convSubjectRelation.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetDepartmentId(this clsvSubjectRelationEN objvSubjectRelationEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentId, convSubjectRelation.DepartmentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convSubjectRelation.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetDepartmentName(this clsvSubjectRelationEN objvSubjectRelationEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convSubjectRelation.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convSubjectRelation.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderId(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLeaderId, convSubjectRelation.LeaderId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLeaderId, 18, convSubjectRelation.LeaderId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetMemo(this clsvSubjectRelationEN objvSubjectRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSubjectRelation.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderUserName(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLeaderUserName, 30, convSubjectRelation.LeaderUserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderDepartmentId(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLeaderDepartmentId, 6, convSubjectRelation.LeaderDepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSubjectRelationEN SetLeaderDepartmentName(this clsvSubjectRelationEN objvSubjectRelationEN, string strLeaderDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLeaderDepartmentName, 100, convSubjectRelation.LeaderDepartmentName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSubjectRelationENS">源对象</param>
 /// <param name = "objvSubjectRelationENT">目标对象</param>
 public static void CopyTo(this clsvSubjectRelationEN objvSubjectRelationENS, clsvSubjectRelationEN objvSubjectRelationENT)
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
 /// <param name = "objvSubjectRelationENS">源对象</param>
 /// <returns>目标对象=>clsvSubjectRelationEN:objvSubjectRelationENT</returns>
 public static clsvSubjectRelationEN CopyTo(this clsvSubjectRelationEN objvSubjectRelationENS)
{
try
{
 clsvSubjectRelationEN objvSubjectRelationENT = new clsvSubjectRelationEN()
{
mId = objvSubjectRelationENS.mId, //流水号
UserId = objvSubjectRelationENS.UserId, //用户ID
UserName = objvSubjectRelationENS.UserName, //用户名
DepartmentId = objvSubjectRelationENS.DepartmentId, //部门Id
DepartmentName = objvSubjectRelationENS.DepartmentName, //部门名
LeaderId = objvSubjectRelationENS.LeaderId, //领导Id
IsDirectLeader = objvSubjectRelationENS.IsDirectLeader, //是否直接领导
Memo = objvSubjectRelationENS.Memo, //备注
LeaderUserName = objvSubjectRelationENS.LeaderUserName, //LeaderUserName
LeaderDepartmentId = objvSubjectRelationENS.LeaderDepartmentId, //LeaderDepartmentId
LeaderDepartmentName = objvSubjectRelationENS.LeaderDepartmentName, //LeaderDepartmentName
};
 return objvSubjectRelationENT;
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
public static void CheckProperty4Condition(this clsvSubjectRelationEN objvSubjectRelationEN)
{
 clsvSubjectRelationBL.vSubjectRelationDA.CheckProperty4Condition(objvSubjectRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSubjectRelation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v隶属关系(vSubjectRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSubjectRelationBL
{
public static RelatedActions_vSubjectRelation relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vSubjectRelationListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vSubjectRelationList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvSubjectRelationEN> arrvSubjectRelationObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSubjectRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSubjectRelationDA vSubjectRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSubjectRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSubjectRelationBL()
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
if (string.IsNullOrEmpty(clsvSubjectRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSubjectRelationEN._ConnectString);
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
objDS = vSubjectRelationDA.GetDataSet(strWhereCond);
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
objDS = vSubjectRelationDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vSubjectRelationDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vSubjectRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSubjectRelationDA.GetDataTable_vSubjectRelation(strWhereCond);
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
objDT = vSubjectRelationDA.GetDataTable(strWhereCond);
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
objDT = vSubjectRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSubjectRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSubjectRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSubjectRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vSubjectRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSubjectRelationDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vSubjectRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSubjectRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vSubjectRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vSubjectRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vSubjectRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vSubjectRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvSubjectRelationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
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
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSubjectRelationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvSubjectRelationEN._CurrTabName);
List<clsvSubjectRelationEN> arrvSubjectRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvSubjectRelationEN> arrvSubjectRelationObjLst_Sel =
arrvSubjectRelationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvSubjectRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSubjectRelationEN> GetObjLst(string strWhereCond)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
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
public static List<clsvSubjectRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSubjectRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSubjectRelationEN> GetSubObjLstCache(clsvSubjectRelationEN objvSubjectRelationCond)
{
List<clsvSubjectRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSubjectRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSubjectRelation.AttributeName)
{
if (objvSubjectRelationCond.IsUpdated(strFldName) == false) continue;
if (objvSubjectRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSubjectRelationCond[strFldName].ToString());
}
else
{
if (objvSubjectRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSubjectRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSubjectRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSubjectRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSubjectRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSubjectRelationCond[strFldName]));
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
public static List<clsvSubjectRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
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
public static List<clsvSubjectRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
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
List<clsvSubjectRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSubjectRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSubjectRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSubjectRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
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
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
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
public static List<clsvSubjectRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSubjectRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSubjectRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
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
public static List<clsvSubjectRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
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
public static IEnumerable<clsvSubjectRelationEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvSubjectRelationEN objvSubjectRelationCond, string strOrderBy)
{
List<clsvSubjectRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSubjectRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSubjectRelation.AttributeName)
{
if (objvSubjectRelationCond.IsUpdated(strFldName) == false) continue;
if (objvSubjectRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSubjectRelationCond[strFldName].ToString());
}
else
{
if (objvSubjectRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSubjectRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSubjectRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSubjectRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSubjectRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSubjectRelationCond[strFldName]));
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
public static IEnumerable<clsvSubjectRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvSubjectRelationEN objvSubjectRelationCond = JsonConvert.DeserializeObject<clsvSubjectRelationEN>(objPagerPara.whereCond);
if (objvSubjectRelationCond.sfFldComparisonOp == null)
{
objvSubjectRelationCond.dicFldComparisonOp = null;
}
else
{
objvSubjectRelationCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvSubjectRelationCond.sfFldComparisonOp);
}
clsvSubjectRelationBL.SetUpdFlag(objvSubjectRelationCond);
 try
{
CheckProperty4Condition(objvSubjectRelationCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvSubjectRelationBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvSubjectRelationCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSubjectRelationEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvSubjectRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
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
public static List<clsvSubjectRelationEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSubjectRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSubjectRelationEN> arrObjLst = new List<clsvSubjectRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
try
{
objvSubjectRelationEN.mId = Int32.Parse(objRow[convSubjectRelation.mId].ToString().Trim()); //流水号
objvSubjectRelationEN.UserId = objRow[convSubjectRelation.UserId].ToString().Trim(); //用户ID
objvSubjectRelationEN.UserName = objRow[convSubjectRelation.UserName].ToString().Trim(); //用户名
objvSubjectRelationEN.DepartmentId = objRow[convSubjectRelation.DepartmentId].ToString().Trim(); //部门Id
objvSubjectRelationEN.DepartmentName = objRow[convSubjectRelation.DepartmentName].ToString().Trim(); //部门名
objvSubjectRelationEN.LeaderId = objRow[convSubjectRelation.LeaderId].ToString().Trim(); //领导Id
objvSubjectRelationEN.IsDirectLeader = clsEntityBase2.TransNullToBool_S(objRow[convSubjectRelation.IsDirectLeader].ToString().Trim()); //是否直接领导
objvSubjectRelationEN.Memo = objRow[convSubjectRelation.Memo] == DBNull.Value ? null : objRow[convSubjectRelation.Memo].ToString().Trim(); //备注
objvSubjectRelationEN.LeaderUserName = objRow[convSubjectRelation.LeaderUserName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderUserName].ToString().Trim(); //LeaderUserName
objvSubjectRelationEN.LeaderDepartmentId = objRow[convSubjectRelation.LeaderDepartmentId] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentId].ToString().Trim(); //LeaderDepartmentId
objvSubjectRelationEN.LeaderDepartmentName = objRow[convSubjectRelation.LeaderDepartmentName] == DBNull.Value ? null : objRow[convSubjectRelation.LeaderDepartmentName].ToString().Trim(); //LeaderDepartmentName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSubjectRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSubjectRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSubjectRelation(ref clsvSubjectRelationEN objvSubjectRelationEN)
{
bool bolResult = vSubjectRelationDA.GetvSubjectRelation(ref objvSubjectRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSubjectRelationEN GetObjBymId(long lngmId)
{
clsvSubjectRelationEN objvSubjectRelationEN = vSubjectRelationDA.GetObjBymId(lngmId);
return objvSubjectRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSubjectRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSubjectRelationEN objvSubjectRelationEN = vSubjectRelationDA.GetFirstObj(strWhereCond);
 return objvSubjectRelationEN;
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
public static clsvSubjectRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSubjectRelationEN objvSubjectRelationEN = vSubjectRelationDA.GetObjByDataRow(objRow);
 return objvSubjectRelationEN;
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
public static clsvSubjectRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSubjectRelationEN objvSubjectRelationEN = vSubjectRelationDA.GetObjByDataRow(objRow);
 return objvSubjectRelationEN;
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
 /// <param name = "lstvSubjectRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSubjectRelationEN GetObjBymIdFromList(long lngmId, List<clsvSubjectRelationEN> lstvSubjectRelationObjLst)
{
foreach (clsvSubjectRelationEN objvSubjectRelationEN in lstvSubjectRelationObjLst)
{
if (objvSubjectRelationEN.mId == lngmId)
{
return objvSubjectRelationEN;
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
 lngmId = new clsvSubjectRelationDA().GetFirstID(strWhereCond);
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
 arrList = vSubjectRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vSubjectRelationDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vSubjectRelationDA.IsExist(lngmId);
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
 bolIsExist = clsvSubjectRelationDA.IsExistTable();
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
 bolIsExist = vSubjectRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objvSubjectRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvSubjectRelationEN objvSubjectRelationEN)
{
try
{
objvSubjectRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSubjectRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSubjectRelation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.mId = objvSubjectRelationEN.mId; //流水号
}
if (arrFldSet.Contains(convSubjectRelation.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.UserId = objvSubjectRelationEN.UserId; //用户ID
}
if (arrFldSet.Contains(convSubjectRelation.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.UserName = objvSubjectRelationEN.UserName; //用户名
}
if (arrFldSet.Contains(convSubjectRelation.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.DepartmentId = objvSubjectRelationEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convSubjectRelation.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.DepartmentName = objvSubjectRelationEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convSubjectRelation.LeaderId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.LeaderId = objvSubjectRelationEN.LeaderId; //领导Id
}
if (arrFldSet.Contains(convSubjectRelation.IsDirectLeader, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.IsDirectLeader = objvSubjectRelationEN.IsDirectLeader; //是否直接领导
}
if (arrFldSet.Contains(convSubjectRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.Memo = objvSubjectRelationEN.Memo == "[null]" ? null :  objvSubjectRelationEN.Memo; //备注
}
if (arrFldSet.Contains(convSubjectRelation.LeaderUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.LeaderUserName = objvSubjectRelationEN.LeaderUserName == "[null]" ? null :  objvSubjectRelationEN.LeaderUserName; //LeaderUserName
}
if (arrFldSet.Contains(convSubjectRelation.LeaderDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.LeaderDepartmentId = objvSubjectRelationEN.LeaderDepartmentId == "[null]" ? null :  objvSubjectRelationEN.LeaderDepartmentId; //LeaderDepartmentId
}
if (arrFldSet.Contains(convSubjectRelation.LeaderDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSubjectRelationEN.LeaderDepartmentName = objvSubjectRelationEN.LeaderDepartmentName == "[null]" ? null :  objvSubjectRelationEN.LeaderDepartmentName; //LeaderDepartmentName
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
 /// <param name = "objvSubjectRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSubjectRelationEN objvSubjectRelationEN)
{
try
{
if (objvSubjectRelationEN.Memo == "[null]") objvSubjectRelationEN.Memo = null; //备注
if (objvSubjectRelationEN.LeaderUserName == "[null]") objvSubjectRelationEN.LeaderUserName = null; //LeaderUserName
if (objvSubjectRelationEN.LeaderDepartmentId == "[null]") objvSubjectRelationEN.LeaderDepartmentId = null; //LeaderDepartmentId
if (objvSubjectRelationEN.LeaderDepartmentName == "[null]") objvSubjectRelationEN.LeaderDepartmentName = null; //LeaderDepartmentName
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
public static void CheckProperty4Condition(clsvSubjectRelationEN objvSubjectRelationEN)
{
 vSubjectRelationDA.CheckProperty4Condition(objvSubjectRelationEN);
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
if (clsSubjectRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSubjectRelationBL没有刷新缓存机制(clsSubjectRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUsersBL没有刷新缓存机制(clsQxUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserStateBL没有刷新缓存机制(clsQxUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentInfoBL没有刷新缓存机制(clsQxDepartmentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxDepartmentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxDepartmentTypeBL没有刷新缓存机制(clsQxDepartmentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvSubjectRelationObjLstCache == null)
//{
//arrvSubjectRelationObjLstCache = vSubjectRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSubjectRelationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSubjectRelationEN._CurrTabName);
List<clsvSubjectRelationEN> arrvSubjectRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvSubjectRelationEN> arrvSubjectRelationObjLst_Sel =
arrvSubjectRelationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvSubjectRelationObjLst_Sel.Count() == 0)
{
   clsvSubjectRelationEN obj = clsvSubjectRelationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSubjectRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSubjectRelationEN> GetAllvSubjectRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsvSubjectRelationEN> arrvSubjectRelationObjLstCache = GetObjLstCache(); 
return arrvSubjectRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSubjectRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSubjectRelationEN._CurrTabName);
List<clsvSubjectRelationEN> arrvSubjectRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSubjectRelationObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvSubjectRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvSubjectRelationEN> lstvSubjectRelationObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvSubjectRelationObjLst, writer);
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
 /// <param name = "lstvSubjectRelationObjLst">[clsvSubjectRelationEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvSubjectRelationEN> lstvSubjectRelationObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvSubjectRelationBL.listXmlNode);
writer.WriteStartElement(clsvSubjectRelationBL.itemsXmlNode);
foreach (clsvSubjectRelationEN objvSubjectRelationEN in lstvSubjectRelationObjLst)
{
clsvSubjectRelationBL.SerializeXML(writer, objvSubjectRelationEN);
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
 /// <param name = "objvSubjectRelationEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvSubjectRelationEN objvSubjectRelationEN)
{
writer.WriteStartElement(clsvSubjectRelationBL.itemXmlNode);
 
writer.WriteElementString(convSubjectRelation.mId, objvSubjectRelationEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvSubjectRelationEN.UserId != null)
{
writer.WriteElementString(convSubjectRelation.UserId, objvSubjectRelationEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSubjectRelationEN.UserName != null)
{
writer.WriteElementString(convSubjectRelation.UserName, objvSubjectRelationEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSubjectRelationEN.DepartmentId != null)
{
writer.WriteElementString(convSubjectRelation.DepartmentId, objvSubjectRelationEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSubjectRelationEN.DepartmentName != null)
{
writer.WriteElementString(convSubjectRelation.DepartmentName, objvSubjectRelationEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSubjectRelationEN.LeaderId != null)
{
writer.WriteElementString(convSubjectRelation.LeaderId, objvSubjectRelationEN.LeaderId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convSubjectRelation.IsDirectLeader, objvSubjectRelationEN.IsDirectLeader.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvSubjectRelationEN.Memo != null)
{
writer.WriteElementString(convSubjectRelation.Memo, objvSubjectRelationEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSubjectRelationEN.LeaderUserName != null)
{
writer.WriteElementString(convSubjectRelation.LeaderUserName, objvSubjectRelationEN.LeaderUserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSubjectRelationEN.LeaderDepartmentId != null)
{
writer.WriteElementString(convSubjectRelation.LeaderDepartmentId, objvSubjectRelationEN.LeaderDepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvSubjectRelationEN.LeaderDepartmentName != null)
{
writer.WriteElementString(convSubjectRelation.LeaderDepartmentName, objvSubjectRelationEN.LeaderDepartmentName.ToString(CultureInfo.InvariantCulture));
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
public static clsvSubjectRelationEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
reader.Read();
while (!(reader.Name == clsvSubjectRelationBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convSubjectRelation.mId))
{
objvSubjectRelationEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convSubjectRelation.UserId))
{
objvSubjectRelationEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.UserName))
{
objvSubjectRelationEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.DepartmentId))
{
objvSubjectRelationEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.DepartmentName))
{
objvSubjectRelationEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.LeaderId))
{
objvSubjectRelationEN.LeaderId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.IsDirectLeader))
{
objvSubjectRelationEN.IsDirectLeader = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convSubjectRelation.Memo))
{
objvSubjectRelationEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.LeaderUserName))
{
objvSubjectRelationEN.LeaderUserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.LeaderDepartmentId))
{
objvSubjectRelationEN.LeaderDepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convSubjectRelation.LeaderDepartmentName))
{
objvSubjectRelationEN.LeaderDepartmentName = reader.ReadElementContentAsString();
}
}
return objvSubjectRelationEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvSubjectRelationObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvSubjectRelationEN GetObjFromXmlStr(string strvSubjectRelationObjXmlStr)
{
clsvSubjectRelationEN objvSubjectRelationEN = new clsvSubjectRelationEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvSubjectRelationObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvSubjectRelationBL.itemXmlNode))
{
objvSubjectRelationEN = GetObjFromXml(reader);
return objvSubjectRelationEN;
}
}
return objvSubjectRelationEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvSubjectRelationEN objvSubjectRelationEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvSubjectRelationEN);
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
if (strInFldName != convSubjectRelation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSubjectRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSubjectRelation.AttributeName));
throw new Exception(strMsg);
}
var objvSubjectRelation = clsvSubjectRelationBL.GetObjBymIdCache(lngmId);
if (objvSubjectRelation == null) return "";
return objvSubjectRelation[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvSubjectRelationEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvSubjectRelationEN objvSubjectRelationEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvSubjectRelationEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvSubjectRelationEN[strField]);
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
 /// <param name = "lstvSubjectRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvSubjectRelationEN> lstvSubjectRelationObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvSubjectRelationObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvSubjectRelationEN objvSubjectRelationEN in lstvSubjectRelationObjLst)
{
string strJSON_One = SerializeObjToJSON(objvSubjectRelationEN);
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
int intRecCount = clsvSubjectRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvSubjectRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSubjectRelationDA.GetRecCount();
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
int intRecCount = clsvSubjectRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSubjectRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSubjectRelationEN objvSubjectRelationCond)
{
List<clsvSubjectRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSubjectRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSubjectRelation.AttributeName)
{
if (objvSubjectRelationCond.IsUpdated(strFldName) == false) continue;
if (objvSubjectRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSubjectRelationCond[strFldName].ToString());
}
else
{
if (objvSubjectRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSubjectRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSubjectRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSubjectRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSubjectRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSubjectRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSubjectRelationCond[strFldName]));
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
 List<string> arrList = clsvSubjectRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSubjectRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSubjectRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}