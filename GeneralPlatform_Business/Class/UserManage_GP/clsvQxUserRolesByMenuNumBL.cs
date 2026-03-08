
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRolesByMenuNumBL
 表名:vQxRolesByMenuNum(00140083)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:28
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
public static class  clsvQxRolesByMenuNumBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRolesByMenuNumEN GetObj(this K_RoleId_vQxRolesByMenuNum myKey)
{
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = clsvQxRolesByMenuNumBL.vQxRolesByMenuNumDA.GetObjByRoleId(myKey.Value);
return objvQxRolesByMenuNumEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleId(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxRolesByMenuNum.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxRolesByMenuNum.RoleId);
}
objvQxRolesByMenuNumEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleId) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleId, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleId] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleName(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxRolesByMenuNum.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxRolesByMenuNum.RoleName);
}
objvQxRolesByMenuNumEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleName) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleName, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleName] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleENName(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strRoleENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleENName, 50, convQxRolesByMenuNum.RoleENName);
}
objvQxRolesByMenuNumEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleENName) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleENName, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleENName] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetRoleIndex(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, int? intRoleIndex, string strComparisonOp="")
	{
objvQxRolesByMenuNumEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.RoleIndex) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.RoleIndex, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.RoleIndex] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetQxPrjId(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strQxPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxRolesByMenuNum.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxRolesByMenuNum.QxPrjId);
}
objvQxRolesByMenuNumEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.QxPrjId) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.QxPrjId, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.QxPrjId] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetPrjName(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxRolesByMenuNum.PrjName);
}
objvQxRolesByMenuNumEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.PrjName) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.PrjName, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.PrjName] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetIsInUse(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, bool bolIsInUse, string strComparisonOp="")
	{
objvQxRolesByMenuNumEN.IsInUse = bolIsInUse; //是否在使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.IsInUse) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.IsInUse, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.IsInUse] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetUpdDate(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRolesByMenuNum.UpdDate);
}
objvQxRolesByMenuNumEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.UpdDate) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.UpdDate, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.UpdDate] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetUpdUserId(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxRolesByMenuNum.UpdUserId);
}
objvQxRolesByMenuNumEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.UpdUserId) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.UpdUserId, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.UpdUserId] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetMemo(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRolesByMenuNum.Memo);
}
objvQxRolesByMenuNumEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.Memo) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.Memo, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.Memo] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRolesByMenuNumEN SetMenuNum(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN, int? intMenuNum, string strComparisonOp="")
	{
objvQxRolesByMenuNumEN.MenuNum = intMenuNum; //MenuNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRolesByMenuNumEN.dicFldComparisonOp.ContainsKey(convQxRolesByMenuNum.MenuNum) == false)
{
objvQxRolesByMenuNumEN.dicFldComparisonOp.Add(convQxRolesByMenuNum.MenuNum, strComparisonOp);
}
else
{
objvQxRolesByMenuNumEN.dicFldComparisonOp[convQxRolesByMenuNum.MenuNum] = strComparisonOp;
}
}
return objvQxRolesByMenuNumEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumENS">源对象</param>
 /// <param name = "objvQxRolesByMenuNumENT">目标对象</param>
 public static void CopyTo(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENS, clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENT)
{
try
{
objvQxRolesByMenuNumENT.RoleId = objvQxRolesByMenuNumENS.RoleId; //角色Id
objvQxRolesByMenuNumENT.RoleName = objvQxRolesByMenuNumENS.RoleName; //角色名称
objvQxRolesByMenuNumENT.RoleENName = objvQxRolesByMenuNumENS.RoleENName; //角色英文名
objvQxRolesByMenuNumENT.RoleIndex = objvQxRolesByMenuNumENS.RoleIndex; //角色序号
objvQxRolesByMenuNumENT.QxPrjId = objvQxRolesByMenuNumENS.QxPrjId; //项目Id
objvQxRolesByMenuNumENT.PrjName = objvQxRolesByMenuNumENS.PrjName; //工程名
objvQxRolesByMenuNumENT.IsInUse = objvQxRolesByMenuNumENS.IsInUse; //是否在使用
objvQxRolesByMenuNumENT.UpdDate = objvQxRolesByMenuNumENS.UpdDate; //修改日期
objvQxRolesByMenuNumENT.UpdUserId = objvQxRolesByMenuNumENS.UpdUserId; //修改用户Id
objvQxRolesByMenuNumENT.Memo = objvQxRolesByMenuNumENS.Memo; //备注
objvQxRolesByMenuNumENT.MenuNum = objvQxRolesByMenuNumENS.MenuNum; //MenuNum
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
 /// <param name = "objvQxRolesByMenuNumENS">源对象</param>
 /// <returns>目标对象=>clsvQxRolesByMenuNumEN:objvQxRolesByMenuNumENT</returns>
 public static clsvQxRolesByMenuNumEN CopyTo(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENS)
{
try
{
 clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENT = new clsvQxRolesByMenuNumEN()
{
RoleId = objvQxRolesByMenuNumENS.RoleId, //角色Id
RoleName = objvQxRolesByMenuNumENS.RoleName, //角色名称
RoleENName = objvQxRolesByMenuNumENS.RoleENName, //角色英文名
RoleIndex = objvQxRolesByMenuNumENS.RoleIndex, //角色序号
QxPrjId = objvQxRolesByMenuNumENS.QxPrjId, //项目Id
PrjName = objvQxRolesByMenuNumENS.PrjName, //工程名
IsInUse = objvQxRolesByMenuNumENS.IsInUse, //是否在使用
UpdDate = objvQxRolesByMenuNumENS.UpdDate, //修改日期
UpdUserId = objvQxRolesByMenuNumENS.UpdUserId, //修改用户Id
Memo = objvQxRolesByMenuNumENS.Memo, //备注
MenuNum = objvQxRolesByMenuNumENS.MenuNum, //MenuNum
};
 return objvQxRolesByMenuNumENT;
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
public static void CheckProperty4Condition(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
 clsvQxRolesByMenuNumBL.vQxRolesByMenuNumDA.CheckProperty4Condition(objvQxRolesByMenuNumEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRolesByMenuNumEN objvQxRolesByMenuNumCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleId) == true)
{
string strComparisonOpRoleId = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.RoleId, objvQxRolesByMenuNumCond.RoleId, strComparisonOpRoleId);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleName) == true)
{
string strComparisonOpRoleName = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.RoleName, objvQxRolesByMenuNumCond.RoleName, strComparisonOpRoleName);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleENName) == true)
{
string strComparisonOpRoleENName = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.RoleENName, objvQxRolesByMenuNumCond.RoleENName, strComparisonOpRoleENName);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.RoleIndex) == true)
{
string strComparisonOpRoleIndex = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRolesByMenuNum.RoleIndex, objvQxRolesByMenuNumCond.RoleIndex, strComparisonOpRoleIndex);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.QxPrjId, objvQxRolesByMenuNumCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.PrjName) == true)
{
string strComparisonOpPrjName = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.PrjName, objvQxRolesByMenuNumCond.PrjName, strComparisonOpPrjName);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.IsInUse) == true)
{
if (objvQxRolesByMenuNumCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxRolesByMenuNum.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxRolesByMenuNum.IsInUse);
}
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.UpdDate, objvQxRolesByMenuNumCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.UpdUserId, objvQxRolesByMenuNumCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.Memo) == true)
{
string strComparisonOpMemo = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRolesByMenuNum.Memo, objvQxRolesByMenuNumCond.Memo, strComparisonOpMemo);
}
if (objvQxRolesByMenuNumCond.IsUpdated(convQxRolesByMenuNum.MenuNum) == true)
{
string strComparisonOpMenuNum = objvQxRolesByMenuNumCond.dicFldComparisonOp[convQxRolesByMenuNum.MenuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRolesByMenuNum.MenuNum, objvQxRolesByMenuNumCond.MenuNum, strComparisonOpMenuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxRolesByMenuNum
{
public virtual bool UpdRelaTabDate(string strRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v角色By菜单数(vQxRolesByMenuNum)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxRolesByMenuNumBL
{
public static RelatedActions_vQxRolesByMenuNum relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxRolesByMenuNumListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxRolesByMenuNumList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxRolesByMenuNumDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxRolesByMenuNumDA vQxRolesByMenuNumDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxRolesByMenuNumDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxRolesByMenuNumBL()
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
if (string.IsNullOrEmpty(clsvQxRolesByMenuNumEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRolesByMenuNumEN._ConnectString);
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
objDS = vQxRolesByMenuNumDA.GetDataSet(strWhereCond);
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
objDS = vQxRolesByMenuNumDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxRolesByMenuNumDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxRolesByMenuNum(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxRolesByMenuNumDA.GetDataTable_vQxRolesByMenuNum(strWhereCond);
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
objDT = vQxRolesByMenuNumDA.GetDataTable(strWhereCond);
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
objDT = vQxRolesByMenuNumDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxRolesByMenuNumDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxRolesByMenuNumDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxRolesByMenuNumDA.GetDataTable_Top(objTopPara);
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
objDT = vQxRolesByMenuNumDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxRolesByMenuNumDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxRolesByMenuNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxRolesByMenuNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxRolesByMenuNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxRolesByMenuNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxRolesByMenuNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxRolesByMenuNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLstByRoleIdLst(List<string> arrRoleIdLst)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRoleIdLst, true);
 string strWhereCond = string.Format("RoleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxRolesByMenuNumEN> GetObjLstByRoleIdLstCache(List<string> arrRoleIdLst)
{
string strKey = string.Format("{0}", clsvQxRolesByMenuNumEN._CurrTabName);
List<clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLst_Sel =
arrvQxRolesByMenuNumObjLstCache
.Where(x => arrRoleIdLst.Contains(x.RoleId));
return arrvQxRolesByMenuNumObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLst(string strWhereCond)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
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
public static List<clsvQxRolesByMenuNumEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxRolesByMenuNumEN> GetSubObjLstCache(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumCond)
{
List<clsvQxRolesByMenuNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRolesByMenuNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRolesByMenuNum.AttributeName)
{
if (objvQxRolesByMenuNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxRolesByMenuNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRolesByMenuNumCond[strFldName].ToString());
}
else
{
if (objvQxRolesByMenuNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRolesByMenuNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRolesByMenuNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRolesByMenuNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRolesByMenuNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRolesByMenuNumCond[strFldName]));
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
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
List<clsvQxRolesByMenuNumEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxRolesByMenuNumEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxRolesByMenuNumEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
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
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
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
public static List<clsvQxRolesByMenuNumEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
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
public static IEnumerable<clsvQxRolesByMenuNumEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxRolesByMenuNumEN objvQxRolesByMenuNumCond, string strOrderBy)
{
List<clsvQxRolesByMenuNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRolesByMenuNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRolesByMenuNum.AttributeName)
{
if (objvQxRolesByMenuNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxRolesByMenuNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRolesByMenuNumCond[strFldName].ToString());
}
else
{
if (objvQxRolesByMenuNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRolesByMenuNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRolesByMenuNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRolesByMenuNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRolesByMenuNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRolesByMenuNumCond[strFldName]));
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
public static IEnumerable<clsvQxRolesByMenuNumEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumCond = JsonConvert.DeserializeObject<clsvQxRolesByMenuNumEN>(objPagerPara.whereCond);
if (objvQxRolesByMenuNumCond.sfFldComparisonOp == null)
{
objvQxRolesByMenuNumCond.dicFldComparisonOp = null;
}
else
{
objvQxRolesByMenuNumCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxRolesByMenuNumCond.sfFldComparisonOp);
}
clsvQxRolesByMenuNumBL.SetUpdFlag(objvQxRolesByMenuNumCond);
 try
{
CheckProperty4Condition(objvQxRolesByMenuNumCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxRolesByMenuNumBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxRolesByMenuNumCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
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
public static List<clsvQxRolesByMenuNumEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxRolesByMenuNumEN> arrObjLst = new List<clsvQxRolesByMenuNumEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
try
{
objvQxRolesByMenuNumEN.RoleId = objRow[convQxRolesByMenuNum.RoleId].ToString().Trim(); //角色Id
objvQxRolesByMenuNumEN.RoleName = objRow[convQxRolesByMenuNum.RoleName].ToString().Trim(); //角色名称
objvQxRolesByMenuNumEN.RoleENName = objRow[convQxRolesByMenuNum.RoleENName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.RoleENName].ToString().Trim(); //角色英文名
objvQxRolesByMenuNumEN.RoleIndex = objRow[convQxRolesByMenuNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.RoleIndex].ToString().Trim()); //角色序号
objvQxRolesByMenuNumEN.QxPrjId = objRow[convQxRolesByMenuNum.QxPrjId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.QxPrjId].ToString().Trim(); //项目Id
objvQxRolesByMenuNumEN.PrjName = objRow[convQxRolesByMenuNum.PrjName] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.PrjName].ToString().Trim(); //工程名
objvQxRolesByMenuNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxRolesByMenuNum.IsInUse].ToString().Trim()); //是否在使用
objvQxRolesByMenuNumEN.UpdDate = objRow[convQxRolesByMenuNum.UpdDate] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdDate].ToString().Trim(); //修改日期
objvQxRolesByMenuNumEN.UpdUserId = objRow[convQxRolesByMenuNum.UpdUserId] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxRolesByMenuNumEN.Memo = objRow[convQxRolesByMenuNum.Memo] == DBNull.Value ? null : objRow[convQxRolesByMenuNum.Memo].ToString().Trim(); //备注
objvQxRolesByMenuNumEN.MenuNum = objRow[convQxRolesByMenuNum.MenuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRolesByMenuNum.MenuNum].ToString().Trim()); //MenuNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRolesByMenuNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRolesByMenuNumEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRolesByMenuNum(ref clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
bool bolResult = vQxRolesByMenuNumDA.GetvQxRolesByMenuNum(ref objvQxRolesByMenuNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRolesByMenuNumEN GetObjByRoleId(string strRoleId)
{
if (strRoleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRoleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRoleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = vQxRolesByMenuNumDA.GetObjByRoleId(strRoleId);
return objvQxRolesByMenuNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxRolesByMenuNumEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = vQxRolesByMenuNumDA.GetFirstObj(strWhereCond);
 return objvQxRolesByMenuNumEN;
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
public static clsvQxRolesByMenuNumEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = vQxRolesByMenuNumDA.GetObjByDataRow(objRow);
 return objvQxRolesByMenuNumEN;
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
public static clsvQxRolesByMenuNumEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = vQxRolesByMenuNumDA.GetObjByDataRow(objRow);
 return objvQxRolesByMenuNumEN;
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
 /// <param name = "strRoleId">所给的关键字</param>
 /// <param name = "lstvQxRolesByMenuNumObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRolesByMenuNumEN GetObjByRoleIdFromList(string strRoleId, List<clsvQxRolesByMenuNumEN> lstvQxRolesByMenuNumObjLst)
{
foreach (clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN in lstvQxRolesByMenuNumObjLst)
{
if (objvQxRolesByMenuNumEN.RoleId == strRoleId)
{
return objvQxRolesByMenuNumEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strRoleId;
 try
 {
 strRoleId = new clsvQxRolesByMenuNumDA().GetFirstID(strWhereCond);
 return strRoleId;
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
 arrList = vQxRolesByMenuNumDA.GetID(strWhereCond);
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
bool bolIsExist = vQxRolesByMenuNumDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRoleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRoleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxRolesByMenuNumDA.IsExist(strRoleId);
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
 bolIsExist = clsvQxRolesByMenuNumDA.IsExistTable();
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
 bolIsExist = vQxRolesByMenuNumDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxRolesByMenuNumENS">源对象</param>
 /// <param name = "objvQxRolesByMenuNumENT">目标对象</param>
 public static void CopyTo(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENS, clsvQxRolesByMenuNumEN objvQxRolesByMenuNumENT)
{
try
{
objvQxRolesByMenuNumENT.RoleId = objvQxRolesByMenuNumENS.RoleId; //角色Id
objvQxRolesByMenuNumENT.RoleName = objvQxRolesByMenuNumENS.RoleName; //角色名称
objvQxRolesByMenuNumENT.RoleENName = objvQxRolesByMenuNumENS.RoleENName; //角色英文名
objvQxRolesByMenuNumENT.RoleIndex = objvQxRolesByMenuNumENS.RoleIndex; //角色序号
objvQxRolesByMenuNumENT.QxPrjId = objvQxRolesByMenuNumENS.QxPrjId; //项目Id
objvQxRolesByMenuNumENT.PrjName = objvQxRolesByMenuNumENS.PrjName; //工程名
objvQxRolesByMenuNumENT.IsInUse = objvQxRolesByMenuNumENS.IsInUse; //是否在使用
objvQxRolesByMenuNumENT.UpdDate = objvQxRolesByMenuNumENS.UpdDate; //修改日期
objvQxRolesByMenuNumENT.UpdUserId = objvQxRolesByMenuNumENS.UpdUserId; //修改用户Id
objvQxRolesByMenuNumENT.Memo = objvQxRolesByMenuNumENS.Memo; //备注
objvQxRolesByMenuNumENT.MenuNum = objvQxRolesByMenuNumENS.MenuNum; //MenuNum
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
 /// <param name = "objvQxRolesByMenuNumEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
try
{
objvQxRolesByMenuNumEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxRolesByMenuNumEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxRolesByMenuNum.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.RoleId = objvQxRolesByMenuNumEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxRolesByMenuNum.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.RoleName = objvQxRolesByMenuNumEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxRolesByMenuNum.RoleENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.RoleENName = objvQxRolesByMenuNumEN.RoleENName == "[null]" ? null :  objvQxRolesByMenuNumEN.RoleENName; //角色英文名
}
if (arrFldSet.Contains(convQxRolesByMenuNum.RoleIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.RoleIndex = objvQxRolesByMenuNumEN.RoleIndex; //角色序号
}
if (arrFldSet.Contains(convQxRolesByMenuNum.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.QxPrjId = objvQxRolesByMenuNumEN.QxPrjId == "[null]" ? null :  objvQxRolesByMenuNumEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxRolesByMenuNum.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.PrjName = objvQxRolesByMenuNumEN.PrjName == "[null]" ? null :  objvQxRolesByMenuNumEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxRolesByMenuNum.IsInUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.IsInUse = objvQxRolesByMenuNumEN.IsInUse; //是否在使用
}
if (arrFldSet.Contains(convQxRolesByMenuNum.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.UpdDate = objvQxRolesByMenuNumEN.UpdDate == "[null]" ? null :  objvQxRolesByMenuNumEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxRolesByMenuNum.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.UpdUserId = objvQxRolesByMenuNumEN.UpdUserId == "[null]" ? null :  objvQxRolesByMenuNumEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxRolesByMenuNum.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.Memo = objvQxRolesByMenuNumEN.Memo == "[null]" ? null :  objvQxRolesByMenuNumEN.Memo; //备注
}
if (arrFldSet.Contains(convQxRolesByMenuNum.MenuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRolesByMenuNumEN.MenuNum = objvQxRolesByMenuNumEN.MenuNum; //MenuNum
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
 /// <param name = "objvQxRolesByMenuNumEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
try
{
if (objvQxRolesByMenuNumEN.RoleENName == "[null]") objvQxRolesByMenuNumEN.RoleENName = null; //角色英文名
if (objvQxRolesByMenuNumEN.QxPrjId == "[null]") objvQxRolesByMenuNumEN.QxPrjId = null; //项目Id
if (objvQxRolesByMenuNumEN.PrjName == "[null]") objvQxRolesByMenuNumEN.PrjName = null; //工程名
if (objvQxRolesByMenuNumEN.UpdDate == "[null]") objvQxRolesByMenuNumEN.UpdDate = null; //修改日期
if (objvQxRolesByMenuNumEN.UpdUserId == "[null]") objvQxRolesByMenuNumEN.UpdUserId = null; //修改用户Id
if (objvQxRolesByMenuNumEN.Memo == "[null]") objvQxRolesByMenuNumEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
 vQxRolesByMenuNumDA.CheckProperty4Condition(objvQxRolesByMenuNumEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_RoleId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxRolesByMenuNum.RoleId); 
List<clsvQxRolesByMenuNumEN> arrObjLst = clsvQxRolesByMenuNumBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN()
{
RoleId = "0",
RoleName = "选[v角色By菜单数]..."
};
arrObjLst.Insert(0, objvQxRolesByMenuNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxRolesByMenuNum.RoleId;
objComboBox.DisplayMember = convQxRolesByMenuNum.RoleName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By菜单数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxRolesByMenuNum.RoleId); 
IEnumerable<clsvQxRolesByMenuNumEN> arrObjLst = clsvQxRolesByMenuNumBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxRolesByMenuNum.RoleId;
objDDL.DataTextField = convQxRolesByMenuNum.RoleName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RoleIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By菜单数]...","0");
List<clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLst = GetAllvQxRolesByMenuNumObjLstCache(); 
objDDL.DataValueField = convQxRolesByMenuNum.RoleId;
objDDL.DataTextField = convQxRolesByMenuNum.RoleName;
objDDL.DataSource = arrvQxRolesByMenuNumObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsQxRolesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRolesBL没有刷新缓存机制(clsQxRolesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RoleId");
//if (arrvQxRolesByMenuNumObjLstCache == null)
//{
//arrvQxRolesByMenuNumObjLstCache = vQxRolesByMenuNumDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRolesByMenuNumEN GetObjByRoleIdCache(string strRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxRolesByMenuNumEN._CurrTabName);
List<clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLst_Sel =
arrvQxRolesByMenuNumObjLstCache
.Where(x=> x.RoleId == strRoleId 
);
if (arrvQxRolesByMenuNumObjLst_Sel.Count() == 0)
{
   clsvQxRolesByMenuNumEN obj = clsvQxRolesByMenuNumBL.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxRolesByMenuNumObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRoleNameByRoleIdCache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//获取缓存中的对象列表
clsvQxRolesByMenuNumEN objvQxRolesByMenuNum = GetObjByRoleIdCache(strRoleId);
if (objvQxRolesByMenuNum == null) return "";
return objvQxRolesByMenuNum.RoleName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRoleIdCache(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return "";
//获取缓存中的对象列表
clsvQxRolesByMenuNumEN objvQxRolesByMenuNum = GetObjByRoleIdCache(strRoleId);
if (objvQxRolesByMenuNum == null) return "";
return objvQxRolesByMenuNum.RoleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetAllvQxRolesByMenuNumObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLstCache = GetObjLstCache(); 
return arrvQxRolesByMenuNumObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRolesByMenuNumEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxRolesByMenuNumEN._CurrTabName);
List<clsvQxRolesByMenuNumEN> arrvQxRolesByMenuNumObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRolesByMenuNumObjLstCache;
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
string strKey = string.Format("{0}", clsvQxRolesByMenuNumEN._CurrTabName);
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
 /// <param name = "lstvQxRolesByMenuNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxRolesByMenuNumEN> lstvQxRolesByMenuNumObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxRolesByMenuNumObjLst, writer);
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
 /// <param name = "lstvQxRolesByMenuNumObjLst">[clsvQxRolesByMenuNumEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxRolesByMenuNumEN> lstvQxRolesByMenuNumObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxRolesByMenuNumBL.listXmlNode);
writer.WriteStartElement(clsvQxRolesByMenuNumBL.itemsXmlNode);
foreach (clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN in lstvQxRolesByMenuNumObjLst)
{
clsvQxRolesByMenuNumBL.SerializeXML(writer, objvQxRolesByMenuNumEN);
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
 /// <param name = "objvQxRolesByMenuNumEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
writer.WriteStartElement(clsvQxRolesByMenuNumBL.itemXmlNode);
 
if (objvQxRolesByMenuNumEN.RoleId != null)
{
writer.WriteElementString(convQxRolesByMenuNum.RoleId, objvQxRolesByMenuNumEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRolesByMenuNumEN.RoleName != null)
{
writer.WriteElementString(convQxRolesByMenuNum.RoleName, objvQxRolesByMenuNumEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRolesByMenuNumEN.RoleENName != null)
{
writer.WriteElementString(convQxRolesByMenuNum.RoleENName, objvQxRolesByMenuNumEN.RoleENName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRolesByMenuNum.RoleIndex, objvQxRolesByMenuNumEN.RoleIndex.ToString());
 
if (objvQxRolesByMenuNumEN.QxPrjId != null)
{
writer.WriteElementString(convQxRolesByMenuNum.QxPrjId, objvQxRolesByMenuNumEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRolesByMenuNumEN.PrjName != null)
{
writer.WriteElementString(convQxRolesByMenuNum.PrjName, objvQxRolesByMenuNumEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRolesByMenuNum.IsInUse, objvQxRolesByMenuNumEN.IsInUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxRolesByMenuNumEN.UpdDate != null)
{
writer.WriteElementString(convQxRolesByMenuNum.UpdDate, objvQxRolesByMenuNumEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRolesByMenuNumEN.UpdUserId != null)
{
writer.WriteElementString(convQxRolesByMenuNum.UpdUserId, objvQxRolesByMenuNumEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxRolesByMenuNumEN.Memo != null)
{
writer.WriteElementString(convQxRolesByMenuNum.Memo, objvQxRolesByMenuNumEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxRolesByMenuNum.MenuNum, objvQxRolesByMenuNumEN.MenuNum.ToString());
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
public static clsvQxRolesByMenuNumEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
reader.Read();
while (!(reader.Name == clsvQxRolesByMenuNumBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxRolesByMenuNum.RoleId))
{
objvQxRolesByMenuNumEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.RoleName))
{
objvQxRolesByMenuNumEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.RoleENName))
{
objvQxRolesByMenuNumEN.RoleENName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.RoleIndex))
{
objvQxRolesByMenuNumEN.RoleIndex = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxRolesByMenuNum.QxPrjId))
{
objvQxRolesByMenuNumEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.PrjName))
{
objvQxRolesByMenuNumEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.IsInUse))
{
objvQxRolesByMenuNumEN.IsInUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxRolesByMenuNum.UpdDate))
{
objvQxRolesByMenuNumEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.UpdUserId))
{
objvQxRolesByMenuNumEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.Memo))
{
objvQxRolesByMenuNumEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxRolesByMenuNum.MenuNum))
{
objvQxRolesByMenuNumEN.MenuNum = reader.ReadElementContentAsInt();
}
}
return objvQxRolesByMenuNumEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxRolesByMenuNumObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxRolesByMenuNumEN GetObjFromXmlStr(string strvQxRolesByMenuNumObjXmlStr)
{
clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN = new clsvQxRolesByMenuNumEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxRolesByMenuNumObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxRolesByMenuNumBL.itemXmlNode))
{
objvQxRolesByMenuNumEN = GetObjFromXml(reader);
return objvQxRolesByMenuNumEN;
}
}
return objvQxRolesByMenuNumEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxRolesByMenuNumEN);
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
public static string Func(string strInFldName, string strOutFldName, string strRoleId)
{
if (strInFldName != convQxRolesByMenuNum.RoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxRolesByMenuNum.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxRolesByMenuNum.AttributeName));
throw new Exception(strMsg);
}
var objvQxRolesByMenuNum = clsvQxRolesByMenuNumBL.GetObjByRoleIdCache(strRoleId);
if (objvQxRolesByMenuNum == null) return "";
return objvQxRolesByMenuNum[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxRolesByMenuNumEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxRolesByMenuNumEN[strField]);
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
 /// <param name = "lstvQxRolesByMenuNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxRolesByMenuNumEN> lstvQxRolesByMenuNumObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxRolesByMenuNumObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxRolesByMenuNumEN objvQxRolesByMenuNumEN in lstvQxRolesByMenuNumObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxRolesByMenuNumEN);
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
int intRecCount = clsvQxRolesByMenuNumDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxRolesByMenuNumDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxRolesByMenuNumDA.GetRecCount();
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
int intRecCount = clsvQxRolesByMenuNumDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxRolesByMenuNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxRolesByMenuNumEN objvQxRolesByMenuNumCond)
{
List<clsvQxRolesByMenuNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRolesByMenuNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRolesByMenuNum.AttributeName)
{
if (objvQxRolesByMenuNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxRolesByMenuNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRolesByMenuNumCond[strFldName].ToString());
}
else
{
if (objvQxRolesByMenuNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRolesByMenuNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRolesByMenuNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRolesByMenuNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRolesByMenuNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRolesByMenuNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRolesByMenuNumCond[strFldName]));
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
 List<string> arrList = clsvQxRolesByMenuNumDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxRolesByMenuNumDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxRolesByMenuNumDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}