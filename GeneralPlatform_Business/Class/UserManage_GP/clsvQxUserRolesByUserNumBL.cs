
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesByUserNumBL
 表名:vQxUserRolesByUserNum(00140081)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:50
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
public static class  clsvQxUserRolesByUserNumBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesByUserNumEN GetObj(this K_RoleId_vQxUserRolesByUserNum myKey)
{
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = clsvQxUserRolesByUserNumBL.vQxUserRolesByUserNumDA.GetObjByRoleId(myKey.Value);
return objvQxUserRolesByUserNumEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetRoleId(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRolesByUserNum.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRolesByUserNum.RoleId);
}
objvQxUserRolesByUserNumEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.RoleId) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.RoleId, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.RoleId] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetRoleName(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRolesByUserNum.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRolesByUserNum.RoleName);
}
objvQxUserRolesByUserNumEN.RoleName = strRoleName; //角色名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.RoleName) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.RoleName, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.RoleName] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetRoleENName(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strRoleENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleENName, 50, convQxUserRolesByUserNum.RoleENName);
}
objvQxUserRolesByUserNumEN.RoleENName = strRoleENName; //角色英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.RoleENName) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.RoleENName, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.RoleENName] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetRoleIndex(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, int? intRoleIndex, string strComparisonOp="")
	{
objvQxUserRolesByUserNumEN.RoleIndex = intRoleIndex; //角色序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.RoleIndex) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.RoleIndex, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.RoleIndex] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetQxPrjId(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strQxPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRolesByUserNum.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRolesByUserNum.QxPrjId);
}
objvQxUserRolesByUserNumEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.QxPrjId) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.QxPrjId, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.QxPrjId] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetPrjName(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRolesByUserNum.PrjName);
}
objvQxUserRolesByUserNumEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.PrjName) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.PrjName, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.PrjName] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetIsInUse(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, bool bolIsInUse, string strComparisonOp="")
	{
objvQxUserRolesByUserNumEN.IsInUse = bolIsInUse; //是否在使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.IsInUse) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.IsInUse, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.IsInUse] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetUpdDate(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserRolesByUserNum.UpdDate);
}
objvQxUserRolesByUserNumEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.UpdDate) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.UpdDate, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.UpdDate] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetUpdUserId(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserRolesByUserNum.UpdUserId);
}
objvQxUserRolesByUserNumEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.UpdUserId) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.UpdUserId, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.UpdUserId] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetMemo(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRolesByUserNum.Memo);
}
objvQxUserRolesByUserNumEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.Memo) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.Memo, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.Memo] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByUserNumEN SetUserNum(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN, int? intUserNum, string strComparisonOp="")
	{
objvQxUserRolesByUserNumEN.UserNum = intUserNum; //用户数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxUserRolesByUserNumEN.dicFldComparisonOp.ContainsKey(convQxUserRolesByUserNum.UserNum) == false)
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp.Add(convQxUserRolesByUserNum.UserNum, strComparisonOp);
}
else
{
objvQxUserRolesByUserNumEN.dicFldComparisonOp[convQxUserRolesByUserNum.UserNum] = strComparisonOp;
}
}
return objvQxUserRolesByUserNumEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumENS">源对象</param>
 /// <param name = "objvQxUserRolesByUserNumENT">目标对象</param>
 public static void CopyTo(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumENS, clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumENT)
{
try
{
objvQxUserRolesByUserNumENT.RoleId = objvQxUserRolesByUserNumENS.RoleId; //角色Id
objvQxUserRolesByUserNumENT.RoleName = objvQxUserRolesByUserNumENS.RoleName; //角色名称
objvQxUserRolesByUserNumENT.RoleENName = objvQxUserRolesByUserNumENS.RoleENName; //角色英文名
objvQxUserRolesByUserNumENT.RoleIndex = objvQxUserRolesByUserNumENS.RoleIndex; //角色序号
objvQxUserRolesByUserNumENT.QxPrjId = objvQxUserRolesByUserNumENS.QxPrjId; //项目Id
objvQxUserRolesByUserNumENT.PrjName = objvQxUserRolesByUserNumENS.PrjName; //工程名
objvQxUserRolesByUserNumENT.IsInUse = objvQxUserRolesByUserNumENS.IsInUse; //是否在使用
objvQxUserRolesByUserNumENT.UpdDate = objvQxUserRolesByUserNumENS.UpdDate; //修改日期
objvQxUserRolesByUserNumENT.UpdUserId = objvQxUserRolesByUserNumENS.UpdUserId; //修改用户Id
objvQxUserRolesByUserNumENT.Memo = objvQxUserRolesByUserNumENS.Memo; //备注
objvQxUserRolesByUserNumENT.UserNum = objvQxUserRolesByUserNumENS.UserNum; //用户数
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
 /// <param name = "objvQxUserRolesByUserNumENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserRolesByUserNumEN:objvQxUserRolesByUserNumENT</returns>
 public static clsvQxUserRolesByUserNumEN CopyTo(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumENS)
{
try
{
 clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumENT = new clsvQxUserRolesByUserNumEN()
{
RoleId = objvQxUserRolesByUserNumENS.RoleId, //角色Id
RoleName = objvQxUserRolesByUserNumENS.RoleName, //角色名称
RoleENName = objvQxUserRolesByUserNumENS.RoleENName, //角色英文名
RoleIndex = objvQxUserRolesByUserNumENS.RoleIndex, //角色序号
QxPrjId = objvQxUserRolesByUserNumENS.QxPrjId, //项目Id
PrjName = objvQxUserRolesByUserNumENS.PrjName, //工程名
IsInUse = objvQxUserRolesByUserNumENS.IsInUse, //是否在使用
UpdDate = objvQxUserRolesByUserNumENS.UpdDate, //修改日期
UpdUserId = objvQxUserRolesByUserNumENS.UpdUserId, //修改用户Id
Memo = objvQxUserRolesByUserNumENS.Memo, //备注
UserNum = objvQxUserRolesByUserNumENS.UserNum, //用户数
};
 return objvQxUserRolesByUserNumENT;
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
public static void CheckProperty4Condition(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
 clsvQxUserRolesByUserNumBL.vQxUserRolesByUserNumDA.CheckProperty4Condition(objvQxUserRolesByUserNumEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.RoleId) == true)
{
string strComparisonOpRoleId = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.RoleId, objvQxUserRolesByUserNumCond.RoleId, strComparisonOpRoleId);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.RoleName) == true)
{
string strComparisonOpRoleName = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.RoleName, objvQxUserRolesByUserNumCond.RoleName, strComparisonOpRoleName);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.RoleENName) == true)
{
string strComparisonOpRoleENName = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.RoleENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.RoleENName, objvQxUserRolesByUserNumCond.RoleENName, strComparisonOpRoleENName);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.RoleIndex) == true)
{
string strComparisonOpRoleIndex = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.RoleIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRolesByUserNum.RoleIndex, objvQxUserRolesByUserNumCond.RoleIndex, strComparisonOpRoleIndex);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.QxPrjId, objvQxUserRolesByUserNumCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.PrjName) == true)
{
string strComparisonOpPrjName = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.PrjName, objvQxUserRolesByUserNumCond.PrjName, strComparisonOpPrjName);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.IsInUse) == true)
{
if (objvQxUserRolesByUserNumCond.IsInUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQxUserRolesByUserNum.IsInUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQxUserRolesByUserNum.IsInUse);
}
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.UpdDate, objvQxUserRolesByUserNumCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.UpdUserId, objvQxUserRolesByUserNumCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.Memo) == true)
{
string strComparisonOpMemo = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxUserRolesByUserNum.Memo, objvQxUserRolesByUserNumCond.Memo, strComparisonOpMemo);
}
if (objvQxUserRolesByUserNumCond.IsUpdated(convQxUserRolesByUserNum.UserNum) == true)
{
string strComparisonOpUserNum = objvQxUserRolesByUserNumCond.dicFldComparisonOp[convQxUserRolesByUserNum.UserNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxUserRolesByUserNum.UserNum, objvQxUserRolesByUserNumCond.UserNum, strComparisonOpUserNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserRolesByUserNum
{
public virtual bool UpdRelaTabDate(string strRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v角色By用户数(vQxUserRolesByUserNum)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRolesByUserNumBL
{
public static RelatedActions_vQxUserRolesByUserNum relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserRolesByUserNumListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserRolesByUserNumList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserRolesByUserNumDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserRolesByUserNumDA vQxUserRolesByUserNumDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserRolesByUserNumDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserRolesByUserNumBL()
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
if (string.IsNullOrEmpty(clsvQxUserRolesByUserNumEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRolesByUserNumEN._ConnectString);
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
objDS = vQxUserRolesByUserNumDA.GetDataSet(strWhereCond);
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
objDS = vQxUserRolesByUserNumDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserRolesByUserNumDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserRolesByUserNum(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserRolesByUserNumDA.GetDataTable_vQxUserRolesByUserNum(strWhereCond);
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
objDT = vQxUserRolesByUserNumDA.GetDataTable(strWhereCond);
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
objDT = vQxUserRolesByUserNumDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserRolesByUserNumDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserRolesByUserNumDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserRolesByUserNumDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserRolesByUserNumDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserRolesByUserNumDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserRolesByUserNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserRolesByUserNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserRolesByUserNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserRolesByUserNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserRolesByUserNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserRolesByUserNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByRoleIdLst(List<string> arrRoleIdLst)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
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
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserRolesByUserNumEN> GetObjLstByRoleIdLstCache(List<string> arrRoleIdLst)
{
string strKey = string.Format("{0}", clsvQxUserRolesByUserNumEN._CurrTabName);
List<clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLst_Sel =
arrvQxUserRolesByUserNumObjLstCache
.Where(x => arrRoleIdLst.Contains(x.RoleId));
return arrvQxUserRolesByUserNumObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByUserNumEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserRolesByUserNumEN> GetSubObjLstCache(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumCond)
{
List<clsvQxUserRolesByUserNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByUserNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRolesByUserNum.AttributeName)
{
if (objvQxUserRolesByUserNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRolesByUserNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByUserNumCond[strFldName].ToString());
}
else
{
if (objvQxUserRolesByUserNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRolesByUserNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByUserNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRolesByUserNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByUserNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByUserNumCond[strFldName]));
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
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
List<clsvQxUserRolesByUserNumEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserRolesByUserNumEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByUserNumEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserRolesByUserNumEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
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
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
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
public static List<clsvQxUserRolesByUserNumEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
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
public static IEnumerable<clsvQxUserRolesByUserNumEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumCond, string strOrderBy)
{
List<clsvQxUserRolesByUserNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByUserNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRolesByUserNum.AttributeName)
{
if (objvQxUserRolesByUserNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRolesByUserNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByUserNumCond[strFldName].ToString());
}
else
{
if (objvQxUserRolesByUserNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRolesByUserNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByUserNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRolesByUserNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByUserNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByUserNumCond[strFldName]));
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
public static IEnumerable<clsvQxUserRolesByUserNumEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumCond = JsonConvert.DeserializeObject<clsvQxUserRolesByUserNumEN>(objPagerPara.whereCond);
if (objvQxUserRolesByUserNumCond.sfFldComparisonOp == null)
{
objvQxUserRolesByUserNumCond.dicFldComparisonOp = null;
}
else
{
objvQxUserRolesByUserNumCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserRolesByUserNumCond.sfFldComparisonOp);
}
clsvQxUserRolesByUserNumBL.SetUpdFlag(objvQxUserRolesByUserNumCond);
 try
{
CheckProperty4Condition(objvQxUserRolesByUserNumCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserRolesByUserNumBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserRolesByUserNumCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
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
public static List<clsvQxUserRolesByUserNumEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByUserNumEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserRolesByUserNumEN> arrObjLst = new List<clsvQxUserRolesByUserNumEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
try
{
objvQxUserRolesByUserNumEN.RoleId = objRow[convQxUserRolesByUserNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByUserNumEN.RoleName = objRow[convQxUserRolesByUserNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByUserNumEN.RoleENName = objRow[convQxUserRolesByUserNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByUserNumEN.RoleIndex = objRow[convQxUserRolesByUserNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByUserNumEN.QxPrjId = objRow[convQxUserRolesByUserNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByUserNumEN.PrjName = objRow[convQxUserRolesByUserNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByUserNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByUserNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByUserNumEN.UpdDate = objRow[convQxUserRolesByUserNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByUserNumEN.UpdUserId = objRow[convQxUserRolesByUserNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByUserNumEN.Memo = objRow[convQxUserRolesByUserNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByUserNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByUserNumEN.UserNum = objRow[convQxUserRolesByUserNum.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByUserNum.UserNum].ToString().Trim()); //用户数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByUserNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByUserNumEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRolesByUserNum(ref clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
bool bolResult = vQxUserRolesByUserNumDA.GetvQxUserRolesByUserNum(ref objvQxUserRolesByUserNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesByUserNumEN GetObjByRoleId(string strRoleId)
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
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = vQxUserRolesByUserNumDA.GetObjByRoleId(strRoleId);
return objvQxUserRolesByUserNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserRolesByUserNumEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = vQxUserRolesByUserNumDA.GetFirstObj(strWhereCond);
 return objvQxUserRolesByUserNumEN;
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
public static clsvQxUserRolesByUserNumEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = vQxUserRolesByUserNumDA.GetObjByDataRow(objRow);
 return objvQxUserRolesByUserNumEN;
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
public static clsvQxUserRolesByUserNumEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = vQxUserRolesByUserNumDA.GetObjByDataRow(objRow);
 return objvQxUserRolesByUserNumEN;
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
 /// <param name = "lstvQxUserRolesByUserNumObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRolesByUserNumEN GetObjByRoleIdFromList(string strRoleId, List<clsvQxUserRolesByUserNumEN> lstvQxUserRolesByUserNumObjLst)
{
foreach (clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN in lstvQxUserRolesByUserNumObjLst)
{
if (objvQxUserRolesByUserNumEN.RoleId == strRoleId)
{
return objvQxUserRolesByUserNumEN;
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
 strRoleId = new clsvQxUserRolesByUserNumDA().GetFirstID(strWhereCond);
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
 arrList = vQxUserRolesByUserNumDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserRolesByUserNumDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUserRolesByUserNumDA.IsExist(strRoleId);
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
 bolIsExist = clsvQxUserRolesByUserNumDA.IsExistTable();
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
 bolIsExist = vQxUserRolesByUserNumDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserRolesByUserNumENS">源对象</param>
 /// <param name = "objvQxUserRolesByUserNumENT">目标对象</param>
 public static void CopyTo(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumENS, clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumENT)
{
try
{
objvQxUserRolesByUserNumENT.RoleId = objvQxUserRolesByUserNumENS.RoleId; //角色Id
objvQxUserRolesByUserNumENT.RoleName = objvQxUserRolesByUserNumENS.RoleName; //角色名称
objvQxUserRolesByUserNumENT.RoleENName = objvQxUserRolesByUserNumENS.RoleENName; //角色英文名
objvQxUserRolesByUserNumENT.RoleIndex = objvQxUserRolesByUserNumENS.RoleIndex; //角色序号
objvQxUserRolesByUserNumENT.QxPrjId = objvQxUserRolesByUserNumENS.QxPrjId; //项目Id
objvQxUserRolesByUserNumENT.PrjName = objvQxUserRolesByUserNumENS.PrjName; //工程名
objvQxUserRolesByUserNumENT.IsInUse = objvQxUserRolesByUserNumENS.IsInUse; //是否在使用
objvQxUserRolesByUserNumENT.UpdDate = objvQxUserRolesByUserNumENS.UpdDate; //修改日期
objvQxUserRolesByUserNumENT.UpdUserId = objvQxUserRolesByUserNumENS.UpdUserId; //修改用户Id
objvQxUserRolesByUserNumENT.Memo = objvQxUserRolesByUserNumENS.Memo; //备注
objvQxUserRolesByUserNumENT.UserNum = objvQxUserRolesByUserNumENS.UserNum; //用户数
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
 /// <param name = "objvQxUserRolesByUserNumEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
try
{
objvQxUserRolesByUserNumEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserRolesByUserNumEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserRolesByUserNum.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.RoleId = objvQxUserRolesByUserNumEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.RoleName = objvQxUserRolesByUserNumEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.RoleENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.RoleENName = objvQxUserRolesByUserNumEN.RoleENName == "[null]" ? null :  objvQxUserRolesByUserNumEN.RoleENName; //角色英文名
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.RoleIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.RoleIndex = objvQxUserRolesByUserNumEN.RoleIndex; //角色序号
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.QxPrjId = objvQxUserRolesByUserNumEN.QxPrjId == "[null]" ? null :  objvQxUserRolesByUserNumEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.PrjName = objvQxUserRolesByUserNumEN.PrjName == "[null]" ? null :  objvQxUserRolesByUserNumEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.IsInUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.IsInUse = objvQxUserRolesByUserNumEN.IsInUse; //是否在使用
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.UpdDate = objvQxUserRolesByUserNumEN.UpdDate == "[null]" ? null :  objvQxUserRolesByUserNumEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.UpdUserId = objvQxUserRolesByUserNumEN.UpdUserId == "[null]" ? null :  objvQxUserRolesByUserNumEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.Memo = objvQxUserRolesByUserNumEN.Memo == "[null]" ? null :  objvQxUserRolesByUserNumEN.Memo; //备注
}
if (arrFldSet.Contains(convQxUserRolesByUserNum.UserNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByUserNumEN.UserNum = objvQxUserRolesByUserNumEN.UserNum; //用户数
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
 /// <param name = "objvQxUserRolesByUserNumEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
try
{
if (objvQxUserRolesByUserNumEN.RoleENName == "[null]") objvQxUserRolesByUserNumEN.RoleENName = null; //角色英文名
if (objvQxUserRolesByUserNumEN.QxPrjId == "[null]") objvQxUserRolesByUserNumEN.QxPrjId = null; //项目Id
if (objvQxUserRolesByUserNumEN.PrjName == "[null]") objvQxUserRolesByUserNumEN.PrjName = null; //工程名
if (objvQxUserRolesByUserNumEN.UpdDate == "[null]") objvQxUserRolesByUserNumEN.UpdDate = null; //修改日期
if (objvQxUserRolesByUserNumEN.UpdUserId == "[null]") objvQxUserRolesByUserNumEN.UpdUserId = null; //修改用户Id
if (objvQxUserRolesByUserNumEN.Memo == "[null]") objvQxUserRolesByUserNumEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
 vQxUserRolesByUserNumDA.CheckProperty4Condition(objvQxUserRolesByUserNumEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convQxUserRolesByUserNum.RoleId); 
List<clsvQxUserRolesByUserNumEN> arrObjLst = clsvQxUserRolesByUserNumBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN()
{
RoleId = "0",
RoleName = "选[v角色By用户数]..."
};
arrObjLst.Insert(0, objvQxUserRolesByUserNumEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxUserRolesByUserNum.RoleId;
objComboBox.DisplayMember = convQxUserRolesByUserNum.RoleName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By用户数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxUserRolesByUserNum.RoleId); 
IEnumerable<clsvQxUserRolesByUserNumEN> arrObjLst = clsvQxUserRolesByUserNumBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxUserRolesByUserNum.RoleId;
objDDL.DataTextField = convQxUserRolesByUserNum.RoleName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By用户数]...","0");
List<clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLst = GetAllvQxUserRolesByUserNumObjLstCache(); 
objDDL.DataValueField = convQxUserRolesByUserNum.RoleId;
objDDL.DataTextField = convQxUserRolesByUserNum.RoleName;
objDDL.DataSource = arrvQxUserRolesByUserNumObjLst;
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
//if (arrvQxUserRolesByUserNumObjLstCache == null)
//{
//arrvQxUserRolesByUserNumObjLstCache = vQxUserRolesByUserNumDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRolesByUserNumEN GetObjByRoleIdCache(string strRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserRolesByUserNumEN._CurrTabName);
List<clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLst_Sel =
arrvQxUserRolesByUserNumObjLstCache
.Where(x=> x.RoleId == strRoleId 
);
if (arrvQxUserRolesByUserNumObjLst_Sel.Count() == 0)
{
   clsvQxUserRolesByUserNumEN obj = clsvQxUserRolesByUserNumBL.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserRolesByUserNumObjLst_Sel.First();
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
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNum = GetObjByRoleIdCache(strRoleId);
if (objvQxUserRolesByUserNum == null) return "";
return objvQxUserRolesByUserNum.RoleName;
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
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNum = GetObjByRoleIdCache(strRoleId);
if (objvQxUserRolesByUserNum == null) return "";
return objvQxUserRolesByUserNum.RoleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRolesByUserNumEN> GetAllvQxUserRolesByUserNumObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLstCache = GetObjLstCache(); 
return arrvQxUserRolesByUserNumObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRolesByUserNumEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserRolesByUserNumEN._CurrTabName);
List<clsvQxUserRolesByUserNumEN> arrvQxUserRolesByUserNumObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserRolesByUserNumObjLstCache;
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
string strKey = string.Format("{0}", clsvQxUserRolesByUserNumEN._CurrTabName);
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
 /// <param name = "lstvQxUserRolesByUserNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserRolesByUserNumEN> lstvQxUserRolesByUserNumObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserRolesByUserNumObjLst, writer);
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
 /// <param name = "lstvQxUserRolesByUserNumObjLst">[clsvQxUserRolesByUserNumEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserRolesByUserNumEN> lstvQxUserRolesByUserNumObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserRolesByUserNumBL.listXmlNode);
writer.WriteStartElement(clsvQxUserRolesByUserNumBL.itemsXmlNode);
foreach (clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN in lstvQxUserRolesByUserNumObjLst)
{
clsvQxUserRolesByUserNumBL.SerializeXML(writer, objvQxUserRolesByUserNumEN);
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
 /// <param name = "objvQxUserRolesByUserNumEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
writer.WriteStartElement(clsvQxUserRolesByUserNumBL.itemXmlNode);
 
if (objvQxUserRolesByUserNumEN.RoleId != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.RoleId, objvQxUserRolesByUserNumEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByUserNumEN.RoleName != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.RoleName, objvQxUserRolesByUserNumEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByUserNumEN.RoleENName != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.RoleENName, objvQxUserRolesByUserNumEN.RoleENName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserRolesByUserNum.RoleIndex, objvQxUserRolesByUserNumEN.RoleIndex.ToString());
 
if (objvQxUserRolesByUserNumEN.QxPrjId != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.QxPrjId, objvQxUserRolesByUserNumEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByUserNumEN.PrjName != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.PrjName, objvQxUserRolesByUserNumEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserRolesByUserNum.IsInUse, objvQxUserRolesByUserNumEN.IsInUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUserRolesByUserNumEN.UpdDate != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.UpdDate, objvQxUserRolesByUserNumEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByUserNumEN.UpdUserId != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.UpdUserId, objvQxUserRolesByUserNumEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByUserNumEN.Memo != null)
{
writer.WriteElementString(convQxUserRolesByUserNum.Memo, objvQxUserRolesByUserNumEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserRolesByUserNum.UserNum, objvQxUserRolesByUserNumEN.UserNum.ToString());
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
public static clsvQxUserRolesByUserNumEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
reader.Read();
while (!(reader.Name == clsvQxUserRolesByUserNumBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserRolesByUserNum.RoleId))
{
objvQxUserRolesByUserNumEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.RoleName))
{
objvQxUserRolesByUserNumEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.RoleENName))
{
objvQxUserRolesByUserNumEN.RoleENName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.RoleIndex))
{
objvQxUserRolesByUserNumEN.RoleIndex = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.QxPrjId))
{
objvQxUserRolesByUserNumEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.PrjName))
{
objvQxUserRolesByUserNumEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.IsInUse))
{
objvQxUserRolesByUserNumEN.IsInUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.UpdDate))
{
objvQxUserRolesByUserNumEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.UpdUserId))
{
objvQxUserRolesByUserNumEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.Memo))
{
objvQxUserRolesByUserNumEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByUserNum.UserNum))
{
objvQxUserRolesByUserNumEN.UserNum = reader.ReadElementContentAsInt();
}
}
return objvQxUserRolesByUserNumEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserRolesByUserNumObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserRolesByUserNumEN GetObjFromXmlStr(string strvQxUserRolesByUserNumObjXmlStr)
{
clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN = new clsvQxUserRolesByUserNumEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserRolesByUserNumObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserRolesByUserNumBL.itemXmlNode))
{
objvQxUserRolesByUserNumEN = GetObjFromXml(reader);
return objvQxUserRolesByUserNumEN;
}
}
return objvQxUserRolesByUserNumEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserRolesByUserNumEN);
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
if (strInFldName != convQxUserRolesByUserNum.RoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserRolesByUserNum.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserRolesByUserNum.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserRolesByUserNum = clsvQxUserRolesByUserNumBL.GetObjByRoleIdCache(strRoleId);
if (objvQxUserRolesByUserNum == null) return "";
return objvQxUserRolesByUserNum[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserRolesByUserNumEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserRolesByUserNumEN[strField]);
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
 /// <param name = "lstvQxUserRolesByUserNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserRolesByUserNumEN> lstvQxUserRolesByUserNumObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserRolesByUserNumObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumEN in lstvQxUserRolesByUserNumObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserRolesByUserNumEN);
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
int intRecCount = clsvQxUserRolesByUserNumDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserRolesByUserNumDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserRolesByUserNumDA.GetRecCount();
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
int intRecCount = clsvQxUserRolesByUserNumDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserRolesByUserNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserRolesByUserNumEN objvQxUserRolesByUserNumCond)
{
List<clsvQxUserRolesByUserNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByUserNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRolesByUserNum.AttributeName)
{
if (objvQxUserRolesByUserNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRolesByUserNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByUserNumCond[strFldName].ToString());
}
else
{
if (objvQxUserRolesByUserNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRolesByUserNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByUserNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRolesByUserNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRolesByUserNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByUserNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByUserNumCond[strFldName]));
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
 List<string> arrList = clsvQxUserRolesByUserNumDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRolesByUserNumDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRolesByUserNumDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}