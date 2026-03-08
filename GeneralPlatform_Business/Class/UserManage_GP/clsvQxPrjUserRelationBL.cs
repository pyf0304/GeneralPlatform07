
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjUserRelationBL
 表名:vQxPrjUserRelation(00140032)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:58
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
public static class  clsvQxPrjUserRelationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelationEN GetObj(this K_mId_vQxPrjUserRelation myKey)
{
clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = clsvQxPrjUserRelationBL.vQxPrjUserRelationDA.GetObjBymId(myKey.Value);
return objvQxPrjUserRelationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetQxPrjId(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxPrjUserRelation.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxPrjUserRelation.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxPrjUserRelation.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetPrjName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxPrjUserRelation.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxPrjUserRelation.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetUserId(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convQxPrjUserRelation.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convQxPrjUserRelation.UserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetUserName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convQxPrjUserRelation.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convQxPrjUserRelation.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetDepartmentId(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 8, convQxPrjUserRelation.DepartmentId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetDepartmentName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convQxPrjUserRelation.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 100, convQxPrjUserRelation.DepartmentName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetUserStateName(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strUserStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserStateName, convQxPrjUserRelation.UserStateName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserStateName, 20, convQxPrjUserRelation.UserStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetIdentityDesc(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strIdentityDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdentityDesc, 20, convQxPrjUserRelation.IdentityDesc);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxPrjUserRelationEN SetMemo(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxPrjUserRelation.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationENS">源对象</param>
 /// <param name = "objvQxPrjUserRelationENT">目标对象</param>
 public static void CopyTo(this clsvQxPrjUserRelationEN objvQxPrjUserRelationENS, clsvQxPrjUserRelationEN objvQxPrjUserRelationENT)
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
 /// <param name = "objvQxPrjUserRelationENS">源对象</param>
 /// <returns>目标对象=>clsvQxPrjUserRelationEN:objvQxPrjUserRelationENT</returns>
 public static clsvQxPrjUserRelationEN CopyTo(this clsvQxPrjUserRelationEN objvQxPrjUserRelationENS)
{
try
{
 clsvQxPrjUserRelationEN objvQxPrjUserRelationENT = new clsvQxPrjUserRelationEN()
{
mId = objvQxPrjUserRelationENS.mId, //流水号
QxPrjId = objvQxPrjUserRelationENS.QxPrjId, //项目Id
PrjName = objvQxPrjUserRelationENS.PrjName, //工程名
UserId = objvQxPrjUserRelationENS.UserId, //用户ID
UserName = objvQxPrjUserRelationENS.UserName, //用户名
DepartmentId = objvQxPrjUserRelationENS.DepartmentId, //部门Id
DepartmentName = objvQxPrjUserRelationENS.DepartmentName, //部门名
UserStateName = objvQxPrjUserRelationENS.UserStateName, //用户状态名
IdentityDesc = objvQxPrjUserRelationENS.IdentityDesc, //身份描述
Memo = objvQxPrjUserRelationENS.Memo, //备注
};
 return objvQxPrjUserRelationENT;
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
public static void CheckProperty4Condition(this clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
 clsvQxPrjUserRelationBL.vQxPrjUserRelationDA.CheckProperty4Condition(objvQxPrjUserRelationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxPrjUserRelation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程用户关系(vQxPrjUserRelation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjUserRelationBL
{
public static RelatedActions_vQxPrjUserRelation relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxPrjUserRelationListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxPrjUserRelationList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxPrjUserRelationEN> arrvQxPrjUserRelationObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxPrjUserRelationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxPrjUserRelationDA vQxPrjUserRelationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxPrjUserRelationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxPrjUserRelationBL()
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
if (string.IsNullOrEmpty(clsvQxPrjUserRelationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxPrjUserRelationEN._ConnectString);
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
objDS = vQxPrjUserRelationDA.GetDataSet(strWhereCond);
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
objDS = vQxPrjUserRelationDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxPrjUserRelationDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxPrjUserRelation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxPrjUserRelationDA.GetDataTable_vQxPrjUserRelation(strWhereCond);
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
objDT = vQxPrjUserRelationDA.GetDataTable(strWhereCond);
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
objDT = vQxPrjUserRelationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxPrjUserRelationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxPrjUserRelationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxPrjUserRelationDA.GetDataTable_Top(objTopPara);
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
objDT = vQxPrjUserRelationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxPrjUserRelationDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxPrjUserRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxPrjUserRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxPrjUserRelationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxPrjUserRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxPrjUserRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxPrjUserRelationDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
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
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxPrjUserRelationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxPrjUserRelationEN._CurrTabName);
List<clsvQxPrjUserRelationEN> arrvQxPrjUserRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationEN> arrvQxPrjUserRelationObjLst_Sel =
arrvQxPrjUserRelationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxPrjUserRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationEN> GetObjLst(string strWhereCond)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
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
public static List<clsvQxPrjUserRelationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxPrjUserRelationEN> GetSubObjLstCache(clsvQxPrjUserRelationEN objvQxPrjUserRelationCond)
{
List<clsvQxPrjUserRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelation.AttributeName)
{
if (objvQxPrjUserRelationCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationCond[strFldName]));
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
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
List<clsvQxPrjUserRelationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxPrjUserRelationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxPrjUserRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
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
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
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
public static List<clsvQxPrjUserRelationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxPrjUserRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
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
public static IEnumerable<clsvQxPrjUserRelationEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxPrjUserRelationEN objvQxPrjUserRelationCond, string strOrderBy)
{
List<clsvQxPrjUserRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelation.AttributeName)
{
if (objvQxPrjUserRelationCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationCond[strFldName]));
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
public static IEnumerable<clsvQxPrjUserRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxPrjUserRelationEN objvQxPrjUserRelationCond = JsonConvert.DeserializeObject<clsvQxPrjUserRelationEN>(objPagerPara.whereCond);
if (objvQxPrjUserRelationCond.sfFldComparisonOp == null)
{
objvQxPrjUserRelationCond.dicFldComparisonOp = null;
}
else
{
objvQxPrjUserRelationCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxPrjUserRelationCond.sfFldComparisonOp);
}
clsvQxPrjUserRelationBL.SetUpdFlag(objvQxPrjUserRelationCond);
 try
{
CheckProperty4Condition(objvQxPrjUserRelationCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxPrjUserRelationBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxPrjUserRelationCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
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
public static List<clsvQxPrjUserRelationEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxPrjUserRelationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxPrjUserRelationEN> arrObjLst = new List<clsvQxPrjUserRelationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
try
{
objvQxPrjUserRelationEN.mId = Int32.Parse(objRow[convQxPrjUserRelation.mId].ToString().Trim()); //流水号
objvQxPrjUserRelationEN.QxPrjId = objRow[convQxPrjUserRelation.QxPrjId].ToString().Trim(); //项目Id
objvQxPrjUserRelationEN.PrjName = objRow[convQxPrjUserRelation.PrjName].ToString().Trim(); //工程名
objvQxPrjUserRelationEN.UserId = objRow[convQxPrjUserRelation.UserId].ToString().Trim(); //用户ID
objvQxPrjUserRelationEN.UserName = objRow[convQxPrjUserRelation.UserName].ToString().Trim(); //用户名
objvQxPrjUserRelationEN.DepartmentId = objRow[convQxPrjUserRelation.DepartmentId] == DBNull.Value ? null : objRow[convQxPrjUserRelation.DepartmentId].ToString().Trim(); //部门Id
objvQxPrjUserRelationEN.DepartmentName = objRow[convQxPrjUserRelation.DepartmentName].ToString().Trim(); //部门名
objvQxPrjUserRelationEN.UserStateName = objRow[convQxPrjUserRelation.UserStateName].ToString().Trim(); //用户状态名
objvQxPrjUserRelationEN.IdentityDesc = objRow[convQxPrjUserRelation.IdentityDesc] == DBNull.Value ? null : objRow[convQxPrjUserRelation.IdentityDesc].ToString().Trim(); //身份描述
objvQxPrjUserRelationEN.Memo = objRow[convQxPrjUserRelation.Memo] == DBNull.Value ? null : objRow[convQxPrjUserRelation.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxPrjUserRelationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxPrjUserRelationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxPrjUserRelation(ref clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
bool bolResult = vQxPrjUserRelationDA.GetvQxPrjUserRelation(ref objvQxPrjUserRelationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxPrjUserRelationEN GetObjBymId(long lngmId)
{
clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = vQxPrjUserRelationDA.GetObjBymId(lngmId);
return objvQxPrjUserRelationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxPrjUserRelationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = vQxPrjUserRelationDA.GetFirstObj(strWhereCond);
 return objvQxPrjUserRelationEN;
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
public static clsvQxPrjUserRelationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = vQxPrjUserRelationDA.GetObjByDataRow(objRow);
 return objvQxPrjUserRelationEN;
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
public static clsvQxPrjUserRelationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = vQxPrjUserRelationDA.GetObjByDataRow(objRow);
 return objvQxPrjUserRelationEN;
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
 /// <param name = "lstvQxPrjUserRelationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjUserRelationEN GetObjBymIdFromList(long lngmId, List<clsvQxPrjUserRelationEN> lstvQxPrjUserRelationObjLst)
{
foreach (clsvQxPrjUserRelationEN objvQxPrjUserRelationEN in lstvQxPrjUserRelationObjLst)
{
if (objvQxPrjUserRelationEN.mId == lngmId)
{
return objvQxPrjUserRelationEN;
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
 lngmId = new clsvQxPrjUserRelationDA().GetFirstID(strWhereCond);
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
 arrList = vQxPrjUserRelationDA.GetID(strWhereCond);
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
bool bolIsExist = vQxPrjUserRelationDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxPrjUserRelationDA.IsExist(lngmId);
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
 bolIsExist = clsvQxPrjUserRelationDA.IsExistTable();
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
 bolIsExist = vQxPrjUserRelationDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxPrjUserRelationEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
try
{
objvQxPrjUserRelationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxPrjUserRelationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxPrjUserRelation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.mId = objvQxPrjUserRelationEN.mId; //流水号
}
if (arrFldSet.Contains(convQxPrjUserRelation.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.QxPrjId = objvQxPrjUserRelationEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxPrjUserRelation.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.PrjName = objvQxPrjUserRelationEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxPrjUserRelation.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.UserId = objvQxPrjUserRelationEN.UserId; //用户ID
}
if (arrFldSet.Contains(convQxPrjUserRelation.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.UserName = objvQxPrjUserRelationEN.UserName; //用户名
}
if (arrFldSet.Contains(convQxPrjUserRelation.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.DepartmentId = objvQxPrjUserRelationEN.DepartmentId == "[null]" ? null :  objvQxPrjUserRelationEN.DepartmentId; //部门Id
}
if (arrFldSet.Contains(convQxPrjUserRelation.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.DepartmentName = objvQxPrjUserRelationEN.DepartmentName; //部门名
}
if (arrFldSet.Contains(convQxPrjUserRelation.UserStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.UserStateName = objvQxPrjUserRelationEN.UserStateName; //用户状态名
}
if (arrFldSet.Contains(convQxPrjUserRelation.IdentityDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.IdentityDesc = objvQxPrjUserRelationEN.IdentityDesc == "[null]" ? null :  objvQxPrjUserRelationEN.IdentityDesc; //身份描述
}
if (arrFldSet.Contains(convQxPrjUserRelation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxPrjUserRelationEN.Memo = objvQxPrjUserRelationEN.Memo == "[null]" ? null :  objvQxPrjUserRelationEN.Memo; //备注
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
 /// <param name = "objvQxPrjUserRelationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
try
{
if (objvQxPrjUserRelationEN.DepartmentId == "[null]") objvQxPrjUserRelationEN.DepartmentId = null; //部门Id
if (objvQxPrjUserRelationEN.IdentityDesc == "[null]") objvQxPrjUserRelationEN.IdentityDesc = null; //身份描述
if (objvQxPrjUserRelationEN.Memo == "[null]") objvQxPrjUserRelationEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
 vQxPrjUserRelationDA.CheckProperty4Condition(objvQxPrjUserRelationEN);
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
if (clsQxPrjUserRelationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjUserRelationBL没有刷新缓存机制(clsQxPrjUserRelationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvQxPrjUserRelationObjLstCache == null)
//{
//arrvQxPrjUserRelationObjLstCache = vQxPrjUserRelationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxPrjUserRelationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxPrjUserRelationEN._CurrTabName);
List<clsvQxPrjUserRelationEN> arrvQxPrjUserRelationObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationEN> arrvQxPrjUserRelationObjLst_Sel =
arrvQxPrjUserRelationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxPrjUserRelationObjLst_Sel.Count() == 0)
{
   clsvQxPrjUserRelationEN obj = clsvQxPrjUserRelationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxPrjUserRelationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjUserRelationEN> GetAllvQxPrjUserRelationObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxPrjUserRelationEN> arrvQxPrjUserRelationObjLstCache = GetObjLstCache(); 
return arrvQxPrjUserRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxPrjUserRelationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxPrjUserRelationEN._CurrTabName);
List<clsvQxPrjUserRelationEN> arrvQxPrjUserRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxPrjUserRelationObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxPrjUserRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxPrjUserRelationEN> lstvQxPrjUserRelationObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxPrjUserRelationObjLst, writer);
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
 /// <param name = "lstvQxPrjUserRelationObjLst">[clsvQxPrjUserRelationEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxPrjUserRelationEN> lstvQxPrjUserRelationObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxPrjUserRelationBL.listXmlNode);
writer.WriteStartElement(clsvQxPrjUserRelationBL.itemsXmlNode);
foreach (clsvQxPrjUserRelationEN objvQxPrjUserRelationEN in lstvQxPrjUserRelationObjLst)
{
clsvQxPrjUserRelationBL.SerializeXML(writer, objvQxPrjUserRelationEN);
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
 /// <param name = "objvQxPrjUserRelationEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
writer.WriteStartElement(clsvQxPrjUserRelationBL.itemXmlNode);
 
writer.WriteElementString(convQxPrjUserRelation.mId, objvQxPrjUserRelationEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxPrjUserRelationEN.QxPrjId != null)
{
writer.WriteElementString(convQxPrjUserRelation.QxPrjId, objvQxPrjUserRelationEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.PrjName != null)
{
writer.WriteElementString(convQxPrjUserRelation.PrjName, objvQxPrjUserRelationEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.UserId != null)
{
writer.WriteElementString(convQxPrjUserRelation.UserId, objvQxPrjUserRelationEN.UserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.UserName != null)
{
writer.WriteElementString(convQxPrjUserRelation.UserName, objvQxPrjUserRelationEN.UserName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.DepartmentId != null)
{
writer.WriteElementString(convQxPrjUserRelation.DepartmentId, objvQxPrjUserRelationEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.DepartmentName != null)
{
writer.WriteElementString(convQxPrjUserRelation.DepartmentName, objvQxPrjUserRelationEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.UserStateName != null)
{
writer.WriteElementString(convQxPrjUserRelation.UserStateName, objvQxPrjUserRelationEN.UserStateName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.IdentityDesc != null)
{
writer.WriteElementString(convQxPrjUserRelation.IdentityDesc, objvQxPrjUserRelationEN.IdentityDesc.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxPrjUserRelationEN.Memo != null)
{
writer.WriteElementString(convQxPrjUserRelation.Memo, objvQxPrjUserRelationEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxPrjUserRelationEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
reader.Read();
while (!(reader.Name == clsvQxPrjUserRelationBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxPrjUserRelation.mId))
{
objvQxPrjUserRelationEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxPrjUserRelation.QxPrjId))
{
objvQxPrjUserRelationEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.PrjName))
{
objvQxPrjUserRelationEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.UserId))
{
objvQxPrjUserRelationEN.UserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.UserName))
{
objvQxPrjUserRelationEN.UserName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.DepartmentId))
{
objvQxPrjUserRelationEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.DepartmentName))
{
objvQxPrjUserRelationEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.UserStateName))
{
objvQxPrjUserRelationEN.UserStateName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.IdentityDesc))
{
objvQxPrjUserRelationEN.IdentityDesc = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxPrjUserRelation.Memo))
{
objvQxPrjUserRelationEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxPrjUserRelationEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxPrjUserRelationObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxPrjUserRelationEN GetObjFromXmlStr(string strvQxPrjUserRelationObjXmlStr)
{
clsvQxPrjUserRelationEN objvQxPrjUserRelationEN = new clsvQxPrjUserRelationEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxPrjUserRelationObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxPrjUserRelationBL.itemXmlNode))
{
objvQxPrjUserRelationEN = GetObjFromXml(reader);
return objvQxPrjUserRelationEN;
}
}
return objvQxPrjUserRelationEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxPrjUserRelationEN);
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
if (strInFldName != convQxPrjUserRelation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxPrjUserRelation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxPrjUserRelation.AttributeName));
throw new Exception(strMsg);
}
var objvQxPrjUserRelation = clsvQxPrjUserRelationBL.GetObjBymIdCache(lngmId);
if (objvQxPrjUserRelation == null) return "";
return objvQxPrjUserRelation[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxPrjUserRelationEN objvQxPrjUserRelationEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxPrjUserRelationEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxPrjUserRelationEN[strField]);
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
 /// <param name = "lstvQxPrjUserRelationObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxPrjUserRelationEN> lstvQxPrjUserRelationObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxPrjUserRelationObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxPrjUserRelationEN objvQxPrjUserRelationEN in lstvQxPrjUserRelationObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxPrjUserRelationEN);
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
int intRecCount = clsvQxPrjUserRelationDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxPrjUserRelationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxPrjUserRelationDA.GetRecCount();
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
int intRecCount = clsvQxPrjUserRelationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxPrjUserRelationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxPrjUserRelationEN objvQxPrjUserRelationCond)
{
List<clsvQxPrjUserRelationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxPrjUserRelationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxPrjUserRelation.AttributeName)
{
if (objvQxPrjUserRelationCond.IsUpdated(strFldName) == false) continue;
if (objvQxPrjUserRelationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationCond[strFldName].ToString());
}
else
{
if (objvQxPrjUserRelationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxPrjUserRelationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxPrjUserRelationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxPrjUserRelationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxPrjUserRelationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxPrjUserRelationCond[strFldName]));
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
 List<string> arrList = clsvQxPrjUserRelationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjUserRelationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxPrjUserRelationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}