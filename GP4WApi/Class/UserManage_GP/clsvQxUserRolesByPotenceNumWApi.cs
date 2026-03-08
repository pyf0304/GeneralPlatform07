
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesByPotenceNumWApi
 表名:vQxUserRolesByPotenceNum(00140084)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 18:56:55
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
public static class  clsvQxUserRolesByPotenceNumWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleId(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRolesByPotenceNum.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRolesByPotenceNum.RoleId);
objvQxUserRolesByPotenceNumEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.RoleId) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.RoleId, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleId] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleName">角色名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleName(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRolesByPotenceNum.RoleName);
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRolesByPotenceNum.RoleName);
objvQxUserRolesByPotenceNumEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.RoleName) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.RoleName, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleName] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleENName">角色英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleENName(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strRoleENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleENName, 50, convQxUserRolesByPotenceNum.RoleENName);
objvQxUserRolesByPotenceNumEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.RoleENName) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.RoleENName, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleENName] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "intRoleIndex">角色序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleIndex(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, int intRoleIndex, string strComparisonOp="")
	{
objvQxUserRolesByPotenceNumEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.RoleIndex) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.RoleIndex, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleIndex] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strQxPrjId">项目Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetQxPrjId(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRolesByPotenceNum.QxPrjId);
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRolesByPotenceNum.QxPrjId);
objvQxUserRolesByPotenceNumEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.QxPrjId) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetPrjName(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRolesByPotenceNum.PrjName);
objvQxUserRolesByPotenceNumEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.PrjName) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.PrjName, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.PrjName] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsInUse">是否在使用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetIsInUse(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, bool bolIsInUse, string strComparisonOp="")
	{
objvQxUserRolesByPotenceNumEN.IsInUse = bolIsInUse; //是否在使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.IsInUse) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.IsInUse, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.IsInUse] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetUpdDate(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserRolesByPotenceNum.UpdDate);
objvQxUserRolesByPotenceNumEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.UpdDate) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.UpdDate, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.UpdDate] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetUpdUserId(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserRolesByPotenceNum.UpdUserId);
objvQxUserRolesByPotenceNumEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.UpdUserId) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.UpdUserId, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.UpdUserId] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">备注</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetMemo(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRolesByPotenceNum.Memo);
objvQxUserRolesByPotenceNumEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.Memo) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.Memo, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.Memo] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "intPotenceNum">PotenceNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetPotenceNum(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, int intPotenceNum, string strComparisonOp="")
	{
objvQxUserRolesByPotenceNumEN.PotenceNum = intPotenceNum; //PotenceNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByPotenceNum.PotenceNum) == false)
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp.Add(convQxUserRolesByPotenceNum.PotenceNum, strComparisonOp);
}
else
{
objvQxUserRolesByPotenceNumEN.dicFldComparisonOp[convQxUserRolesByPotenceNum.PotenceNum] = strComparisonOp;
}
}
return objvQxUserRolesByPotenceNumEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.RoleId, objvQxUserRolesByPotenceNumCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.RoleName, objvQxUserRolesByPotenceNumCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.RoleENName) == true)
{
string strComparisonOpRoleENName = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.RoleENName, objvQxUserRolesByPotenceNumCond.RoleENName, strComparisonOpRoleENName);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.RoleIndex) == true)
{
string strComparisonOpRoleIndex = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRolesByPotenceNum.RoleIndex, objvQxUserRolesByPotenceNumCond.RoleIndex, strComparisonOpRoleIndex);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.QxPrjId, objvQxUserRolesByPotenceNumCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.PrjName, objvQxUserRolesByPotenceNumCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.IsInUse) == true)
{
if (objvQxUserRolesByPotenceNumCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUserRolesByPotenceNum.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUserRolesByPotenceNum.IsInUse);
}
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.UpdDate, objvQxUserRolesByPotenceNumCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.UpdUserId, objvQxUserRolesByPotenceNumCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByPotenceNum.Memo, objvQxUserRolesByPotenceNumCond.Memo, strComparisonOpMemo);
}
if (objvQxUserRolesByPotenceNumCond.IsUpdated(convQxUserRolesByPotenceNum.PotenceNum) == true)
{
string strComparisonOpPotenceNum = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[convQxUserRolesByPotenceNum.PotenceNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRolesByPotenceNum.PotenceNum, objvQxUserRolesByPotenceNumCond.PotenceNum, strComparisonOpPotenceNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v角色By权限数(vQxUserRolesByPotenceNum)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRolesByPotenceNumWApi
{
private static readonly string mstrApiControllerName = "vQxUserRolesByPotenceNumApi";

 public clsvQxUserRolesByPotenceNumWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By权限数]...","0");
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = GetObjLst("1=1");
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

public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxUserRolesByPotenceNum.RoleId); 
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = clsvQxUserRolesByPotenceNumWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN()
{
RoleId = "0",
RoleName = "选[v角色By权限数]..."
};
arrObjLst.Insert(0, objvQxUserRolesByPotenceNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxUserRolesByPotenceNum.RoleId;
objComboBox.DisplayMember = convQxUserRolesByPotenceNum.RoleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObjByRoleId(string strRoleId)
{
string strAction = "GetObjByRoleId";
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN;
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
objvQxUserRolesByPotenceNumEN = JsonConvert.DeserializeObject<clsvQxUserRolesByPotenceNumEN>(strJson);
return objvQxUserRolesByPotenceNumEN;
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
public static clsvQxUserRolesByPotenceNumEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN;
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
objvQxUserRolesByPotenceNumEN = JsonConvert.DeserializeObject<clsvQxUserRolesByPotenceNumEN>(strJson);
return objvQxUserRolesByPotenceNumEN;
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
//该表没有使用Cache,不需要生成[GetRoleNameByRoleIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLst(string strWhereCond)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesByPotenceNumEN>>(strJson);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByRoleIdLst(List<string> arrRoleId)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesByPotenceNumEN>>(strJson);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesByPotenceNumEN>>(strJson);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesByPotenceNumEN>>(strJson);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesByPotenceNumEN>>(strJson);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvQxUserRolesByPotenceNumEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxUserRolesByPotenceNumEN>>(strJson);
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
 /// <param name = "objvQxUserRolesByPotenceNumENS">源对象</param>
 /// <param name = "objvQxUserRolesByPotenceNumENT">目标对象</param>
 public static void CopyTo(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumENS, clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumENT)
{
try
{
objvQxUserRolesByPotenceNumENT.RoleId = objvQxUserRolesByPotenceNumENS.RoleId; //角色Id
objvQxUserRolesByPotenceNumENT.RoleName = objvQxUserRolesByPotenceNumENS.RoleName; //角色名称
objvQxUserRolesByPotenceNumENT.RoleENName = objvQxUserRolesByPotenceNumENS.RoleENName; //角色英文名
objvQxUserRolesByPotenceNumENT.RoleIndex = objvQxUserRolesByPotenceNumENS.RoleIndex; //角色序号
objvQxUserRolesByPotenceNumENT.QxPrjId = objvQxUserRolesByPotenceNumENS.QxPrjId; //项目Id
objvQxUserRolesByPotenceNumENT.PrjName = objvQxUserRolesByPotenceNumENS.PrjName; //工程名
objvQxUserRolesByPotenceNumENT.IsInUse = objvQxUserRolesByPotenceNumENS.IsInUse; //是否在使用
objvQxUserRolesByPotenceNumENT.UpdDate = objvQxUserRolesByPotenceNumENS.UpdDate; //修改日期
objvQxUserRolesByPotenceNumENT.UpdUserId = objvQxUserRolesByPotenceNumENS.UpdUserId; //修改用户Id
objvQxUserRolesByPotenceNumENT.Memo = objvQxUserRolesByPotenceNumENS.Memo; //备注
objvQxUserRolesByPotenceNumENT.PotenceNum = objvQxUserRolesByPotenceNumENS.PotenceNum; //PotenceNum
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
public static DataTable ToDataTable(List<clsvQxUserRolesByPotenceNumEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxUserRolesByPotenceNumEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxUserRolesByPotenceNumEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxUserRolesByPotenceNumEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxUserRolesByPotenceNumEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxUserRolesByPotenceNumEN.AttributeName)
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
string strKey = string.Format("{0}", clsvQxUserRolesByPotenceNumEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxUserRolesByPotenceNumEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxUserRolesByPotenceNum.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.RoleENName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.RoleIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.QxPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.IsInUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convQxUserRolesByPotenceNum.PotenceNum, Type.GetType("System.Int32"));
foreach (clsvQxUserRolesByPotenceNumEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxUserRolesByPotenceNum.RoleId] = objInFor[convQxUserRolesByPotenceNum.RoleId];
objDR[convQxUserRolesByPotenceNum.RoleName] = objInFor[convQxUserRolesByPotenceNum.RoleName];
objDR[convQxUserRolesByPotenceNum.RoleENName] = objInFor[convQxUserRolesByPotenceNum.RoleENName];
objDR[convQxUserRolesByPotenceNum.RoleIndex] = objInFor[convQxUserRolesByPotenceNum.RoleIndex];
objDR[convQxUserRolesByPotenceNum.QxPrjId] = objInFor[convQxUserRolesByPotenceNum.QxPrjId];
objDR[convQxUserRolesByPotenceNum.PrjName] = objInFor[convQxUserRolesByPotenceNum.PrjName];
objDR[convQxUserRolesByPotenceNum.IsInUse] = objInFor[convQxUserRolesByPotenceNum.IsInUse];
objDR[convQxUserRolesByPotenceNum.UpdDate] = objInFor[convQxUserRolesByPotenceNum.UpdDate];
objDR[convQxUserRolesByPotenceNum.UpdUserId] = objInFor[convQxUserRolesByPotenceNum.UpdUserId];
objDR[convQxUserRolesByPotenceNum.Memo] = objInFor[convQxUserRolesByPotenceNum.Memo];
objDR[convQxUserRolesByPotenceNum.PotenceNum] = objInFor[convQxUserRolesByPotenceNum.PotenceNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}