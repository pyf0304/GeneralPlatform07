
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesByPotenceNumBL
 表名:vQxUserRolesByPotenceNum(00140084)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:40
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
public static class  clsvQxUserRolesByPotenceNumBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObj(this K_RoleId_vQxUserRolesByPotenceNum myKey)
{
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = clsvQxUserRolesByPotenceNumBL.vQxUserRolesByPotenceNumDA.GetObjByRoleId(myKey.Value);
return objvQxUserRolesByPotenceNumEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleId(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQxUserRolesByPotenceNum.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQxUserRolesByPotenceNum.RoleId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleName(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleName, convQxUserRolesByPotenceNum.RoleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleName, 50, convQxUserRolesByPotenceNum.RoleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleENName(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strRoleENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleENName, 50, convQxUserRolesByPotenceNum.RoleENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetRoleIndex(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, int? intRoleIndex, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetQxPrjId(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strQxPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxUserRolesByPotenceNum.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxUserRolesByPotenceNum.QxPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetPrjName(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxUserRolesByPotenceNum.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetUpdDate(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxUserRolesByPotenceNum.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetUpdUserId(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convQxUserRolesByPotenceNum.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetMemo(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxUserRolesByPotenceNum.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxUserRolesByPotenceNumEN SetPotenceNum(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN, int? intPotenceNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumENS">源对象</param>
 /// <param name = "objvQxUserRolesByPotenceNumENT">目标对象</param>
 public static void CopyTo(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumENS, clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumENT)
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
 /// <param name = "objvQxUserRolesByPotenceNumENS">源对象</param>
 /// <returns>目标对象=>clsvQxUserRolesByPotenceNumEN:objvQxUserRolesByPotenceNumENT</returns>
 public static clsvQxUserRolesByPotenceNumEN CopyTo(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumENS)
{
try
{
 clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumENT = new clsvQxUserRolesByPotenceNumEN()
{
RoleId = objvQxUserRolesByPotenceNumENS.RoleId, //角色Id
RoleName = objvQxUserRolesByPotenceNumENS.RoleName, //角色名称
RoleENName = objvQxUserRolesByPotenceNumENS.RoleENName, //角色英文名
RoleIndex = objvQxUserRolesByPotenceNumENS.RoleIndex, //角色序号
QxPrjId = objvQxUserRolesByPotenceNumENS.QxPrjId, //项目Id
PrjName = objvQxUserRolesByPotenceNumENS.PrjName, //工程名
IsInUse = objvQxUserRolesByPotenceNumENS.IsInUse, //是否在使用
UpdDate = objvQxUserRolesByPotenceNumENS.UpdDate, //修改日期
UpdUserId = objvQxUserRolesByPotenceNumENS.UpdUserId, //修改用户Id
Memo = objvQxUserRolesByPotenceNumENS.Memo, //备注
PotenceNum = objvQxUserRolesByPotenceNumENS.PotenceNum, //PotenceNum
};
 return objvQxUserRolesByPotenceNumENT;
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
public static void CheckProperty4Condition(this clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
 clsvQxUserRolesByPotenceNumBL.vQxUserRolesByPotenceNumDA.CheckProperty4Condition(objvQxUserRolesByPotenceNumEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxUserRolesByPotenceNum
{
public virtual bool UpdRelaTabDate(string strRoleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v角色By权限数(vQxUserRolesByPotenceNum)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxUserRolesByPotenceNumBL
{
public static RelatedActions_vQxUserRolesByPotenceNum relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxUserRolesByPotenceNumListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxUserRolesByPotenceNumList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxUserRolesByPotenceNumDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxUserRolesByPotenceNumDA vQxUserRolesByPotenceNumDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxUserRolesByPotenceNumDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxUserRolesByPotenceNumBL()
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
if (string.IsNullOrEmpty(clsvQxUserRolesByPotenceNumEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxUserRolesByPotenceNumEN._ConnectString);
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
objDS = vQxUserRolesByPotenceNumDA.GetDataSet(strWhereCond);
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
objDS = vQxUserRolesByPotenceNumDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxUserRolesByPotenceNumDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxUserRolesByPotenceNum(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxUserRolesByPotenceNumDA.GetDataTable_vQxUserRolesByPotenceNum(strWhereCond);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTable(strWhereCond);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTable_Top(objTopPara);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxUserRolesByPotenceNumDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByRoleIdLst(List<string> arrRoleIdLst)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
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
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRoleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxUserRolesByPotenceNumEN> GetObjLstByRoleIdLstCache(List<string> arrRoleIdLst)
{
string strKey = string.Format("{0}", clsvQxUserRolesByPotenceNumEN._CurrTabName);
List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLst_Sel =
arrvQxUserRolesByPotenceNumObjLstCache
.Where(x => arrRoleIdLst.Contains(x.RoleId));
return arrvQxUserRolesByPotenceNumObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLst(string strWhereCond)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxUserRolesByPotenceNumEN> GetSubObjLstCache(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumCond)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByPotenceNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRolesByPotenceNum.AttributeName)
{
if (objvQxUserRolesByPotenceNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRolesByPotenceNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByPotenceNumCond[strFldName].ToString());
}
else
{
if (objvQxUserRolesByPotenceNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByPotenceNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRolesByPotenceNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByPotenceNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByPotenceNumCond[strFldName]));
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxUserRolesByPotenceNumEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
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
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
public static IEnumerable<clsvQxUserRolesByPotenceNumEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumCond, string strOrderBy)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByPotenceNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRolesByPotenceNum.AttributeName)
{
if (objvQxUserRolesByPotenceNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRolesByPotenceNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByPotenceNumCond[strFldName].ToString());
}
else
{
if (objvQxUserRolesByPotenceNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByPotenceNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRolesByPotenceNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByPotenceNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByPotenceNumCond[strFldName]));
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
public static IEnumerable<clsvQxUserRolesByPotenceNumEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumCond = JsonConvert.DeserializeObject<clsvQxUserRolesByPotenceNumEN>(objPagerPara.whereCond);
if (objvQxUserRolesByPotenceNumCond.sfFldComparisonOp == null)
{
objvQxUserRolesByPotenceNumCond.dicFldComparisonOp = null;
}
else
{
objvQxUserRolesByPotenceNumCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxUserRolesByPotenceNumCond.sfFldComparisonOp);
}
clsvQxUserRolesByPotenceNumBL.SetUpdFlag(objvQxUserRolesByPotenceNumCond);
 try
{
CheckProperty4Condition(objvQxUserRolesByPotenceNumCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxUserRolesByPotenceNumBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxUserRolesByPotenceNumCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
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
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = new List<clsvQxUserRolesByPotenceNumEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
try
{
objvQxUserRolesByPotenceNumEN.RoleId = objRow[convQxUserRolesByPotenceNum.RoleId].ToString().Trim(); //角色Id
objvQxUserRolesByPotenceNumEN.RoleName = objRow[convQxUserRolesByPotenceNum.RoleName].ToString().Trim(); //角色名称
objvQxUserRolesByPotenceNumEN.RoleENName = objRow[convQxUserRolesByPotenceNum.RoleENName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.RoleENName].ToString().Trim(); //角色英文名
objvQxUserRolesByPotenceNumEN.RoleIndex = objRow[convQxUserRolesByPotenceNum.RoleIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.RoleIndex].ToString().Trim()); //角色序号
objvQxUserRolesByPotenceNumEN.QxPrjId = objRow[convQxUserRolesByPotenceNum.QxPrjId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.QxPrjId].ToString().Trim(); //项目Id
objvQxUserRolesByPotenceNumEN.PrjName = objRow[convQxUserRolesByPotenceNum.PrjName] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.PrjName].ToString().Trim(); //工程名
objvQxUserRolesByPotenceNumEN.IsInUse = clsEntityBase2.TransNullToBool_S(objRow[convQxUserRolesByPotenceNum.IsInUse].ToString().Trim()); //是否在使用
objvQxUserRolesByPotenceNumEN.UpdDate = objRow[convQxUserRolesByPotenceNum.UpdDate] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdDate].ToString().Trim(); //修改日期
objvQxUserRolesByPotenceNumEN.UpdUserId = objRow[convQxUserRolesByPotenceNum.UpdUserId] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.UpdUserId].ToString().Trim(); //修改用户Id
objvQxUserRolesByPotenceNumEN.Memo = objRow[convQxUserRolesByPotenceNum.Memo] == DBNull.Value ? null : objRow[convQxUserRolesByPotenceNum.Memo].ToString().Trim(); //备注
objvQxUserRolesByPotenceNumEN.PotenceNum = objRow[convQxUserRolesByPotenceNum.PotenceNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxUserRolesByPotenceNum.PotenceNum].ToString().Trim()); //PotenceNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxUserRolesByPotenceNumEN.RoleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxUserRolesByPotenceNumEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxUserRolesByPotenceNum(ref clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
bool bolResult = vQxUserRolesByPotenceNumDA.GetvQxUserRolesByPotenceNum(ref objvQxUserRolesByPotenceNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRoleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObjByRoleId(string strRoleId)
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
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = vQxUserRolesByPotenceNumDA.GetObjByRoleId(strRoleId);
return objvQxUserRolesByPotenceNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = vQxUserRolesByPotenceNumDA.GetFirstObj(strWhereCond);
 return objvQxUserRolesByPotenceNumEN;
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
public static clsvQxUserRolesByPotenceNumEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = vQxUserRolesByPotenceNumDA.GetObjByDataRow(objRow);
 return objvQxUserRolesByPotenceNumEN;
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
public static clsvQxUserRolesByPotenceNumEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = vQxUserRolesByPotenceNumDA.GetObjByDataRow(objRow);
 return objvQxUserRolesByPotenceNumEN;
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
 /// <param name = "lstvQxUserRolesByPotenceNumObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObjByRoleIdFromList(string strRoleId, List<clsvQxUserRolesByPotenceNumEN> lstvQxUserRolesByPotenceNumObjLst)
{
foreach (clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN in lstvQxUserRolesByPotenceNumObjLst)
{
if (objvQxUserRolesByPotenceNumEN.RoleId == strRoleId)
{
return objvQxUserRolesByPotenceNumEN;
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
 strRoleId = new clsvQxUserRolesByPotenceNumDA().GetFirstID(strWhereCond);
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
 arrList = vQxUserRolesByPotenceNumDA.GetID(strWhereCond);
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
bool bolIsExist = vQxUserRolesByPotenceNumDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxUserRolesByPotenceNumDA.IsExist(strRoleId);
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
 bolIsExist = clsvQxUserRolesByPotenceNumDA.IsExistTable();
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
 bolIsExist = vQxUserRolesByPotenceNumDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxUserRolesByPotenceNumEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
try
{
objvQxUserRolesByPotenceNumEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxUserRolesByPotenceNumEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.RoleId = objvQxUserRolesByPotenceNumEN.RoleId; //角色Id
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.RoleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.RoleName = objvQxUserRolesByPotenceNumEN.RoleName; //角色名称
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.RoleENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.RoleENName = objvQxUserRolesByPotenceNumEN.RoleENName == "[null]" ? null :  objvQxUserRolesByPotenceNumEN.RoleENName; //角色英文名
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.RoleIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.RoleIndex = objvQxUserRolesByPotenceNumEN.RoleIndex; //角色序号
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.QxPrjId = objvQxUserRolesByPotenceNumEN.QxPrjId == "[null]" ? null :  objvQxUserRolesByPotenceNumEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.PrjName = objvQxUserRolesByPotenceNumEN.PrjName == "[null]" ? null :  objvQxUserRolesByPotenceNumEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.IsInUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.IsInUse = objvQxUserRolesByPotenceNumEN.IsInUse; //是否在使用
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.UpdDate = objvQxUserRolesByPotenceNumEN.UpdDate == "[null]" ? null :  objvQxUserRolesByPotenceNumEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.UpdUserId = objvQxUserRolesByPotenceNumEN.UpdUserId == "[null]" ? null :  objvQxUserRolesByPotenceNumEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.Memo = objvQxUserRolesByPotenceNumEN.Memo == "[null]" ? null :  objvQxUserRolesByPotenceNumEN.Memo; //备注
}
if (arrFldSet.Contains(convQxUserRolesByPotenceNum.PotenceNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxUserRolesByPotenceNumEN.PotenceNum = objvQxUserRolesByPotenceNumEN.PotenceNum; //PotenceNum
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
 /// <param name = "objvQxUserRolesByPotenceNumEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
try
{
if (objvQxUserRolesByPotenceNumEN.RoleENName == "[null]") objvQxUserRolesByPotenceNumEN.RoleENName = null; //角色英文名
if (objvQxUserRolesByPotenceNumEN.QxPrjId == "[null]") objvQxUserRolesByPotenceNumEN.QxPrjId = null; //项目Id
if (objvQxUserRolesByPotenceNumEN.PrjName == "[null]") objvQxUserRolesByPotenceNumEN.PrjName = null; //工程名
if (objvQxUserRolesByPotenceNumEN.UpdDate == "[null]") objvQxUserRolesByPotenceNumEN.UpdDate = null; //修改日期
if (objvQxUserRolesByPotenceNumEN.UpdUserId == "[null]") objvQxUserRolesByPotenceNumEN.UpdUserId = null; //修改用户Id
if (objvQxUserRolesByPotenceNumEN.Memo == "[null]") objvQxUserRolesByPotenceNumEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
 vQxUserRolesByPotenceNumDA.CheckProperty4Condition(objvQxUserRolesByPotenceNumEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convQxUserRolesByPotenceNum.RoleId); 
List<clsvQxUserRolesByPotenceNumEN> arrObjLst = clsvQxUserRolesByPotenceNumBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By权限数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxUserRolesByPotenceNum.RoleId); 
IEnumerable<clsvQxUserRolesByPotenceNumEN> arrObjLst = clsvQxUserRolesByPotenceNumBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxUserRolesByPotenceNum.RoleId;
objDDL.DataTextField = convQxUserRolesByPotenceNum.RoleName;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v角色By权限数]...","0");
List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLst = GetAllvQxUserRolesByPotenceNumObjLstCache(); 
objDDL.DataValueField = convQxUserRolesByPotenceNum.RoleId;
objDDL.DataTextField = convQxUserRolesByPotenceNum.RoleName;
objDDL.DataSource = arrvQxUserRolesByPotenceNumObjLst;
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
//if (arrvQxUserRolesByPotenceNumObjLstCache == null)
//{
//arrvQxUserRolesByPotenceNumObjLstCache = vQxUserRolesByPotenceNumDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRoleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObjByRoleIdCache(string strRoleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxUserRolesByPotenceNumEN._CurrTabName);
List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLst_Sel =
arrvQxUserRolesByPotenceNumObjLstCache
.Where(x=> x.RoleId == strRoleId 
);
if (arrvQxUserRolesByPotenceNumObjLst_Sel.Count() == 0)
{
   clsvQxUserRolesByPotenceNumEN obj = clsvQxUserRolesByPotenceNumBL.GetObjByRoleId(strRoleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxUserRolesByPotenceNumObjLst_Sel.First();
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
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNum = GetObjByRoleIdCache(strRoleId);
if (objvQxUserRolesByPotenceNum == null) return "";
return objvQxUserRolesByPotenceNum.RoleName;
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
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNum = GetObjByRoleIdCache(strRoleId);
if (objvQxUserRolesByPotenceNum == null) return "";
return objvQxUserRolesByPotenceNum.RoleName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetAllvQxUserRolesByPotenceNumObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLstCache = GetObjLstCache(); 
return arrvQxUserRolesByPotenceNumObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxUserRolesByPotenceNumEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxUserRolesByPotenceNumEN._CurrTabName);
List<clsvQxUserRolesByPotenceNumEN> arrvQxUserRolesByPotenceNumObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxUserRolesByPotenceNumObjLstCache;
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvQxUserRolesByPotenceNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxUserRolesByPotenceNumEN> lstvQxUserRolesByPotenceNumObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxUserRolesByPotenceNumObjLst, writer);
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
 /// <param name = "lstvQxUserRolesByPotenceNumObjLst">[clsvQxUserRolesByPotenceNumEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxUserRolesByPotenceNumEN> lstvQxUserRolesByPotenceNumObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxUserRolesByPotenceNumBL.listXmlNode);
writer.WriteStartElement(clsvQxUserRolesByPotenceNumBL.itemsXmlNode);
foreach (clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN in lstvQxUserRolesByPotenceNumObjLst)
{
clsvQxUserRolesByPotenceNumBL.SerializeXML(writer, objvQxUserRolesByPotenceNumEN);
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
 /// <param name = "objvQxUserRolesByPotenceNumEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
writer.WriteStartElement(clsvQxUserRolesByPotenceNumBL.itemXmlNode);
 
if (objvQxUserRolesByPotenceNumEN.RoleId != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.RoleId, objvQxUserRolesByPotenceNumEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByPotenceNumEN.RoleName != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.RoleName, objvQxUserRolesByPotenceNumEN.RoleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByPotenceNumEN.RoleENName != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.RoleENName, objvQxUserRolesByPotenceNumEN.RoleENName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserRolesByPotenceNum.RoleIndex, objvQxUserRolesByPotenceNumEN.RoleIndex.ToString());
 
if (objvQxUserRolesByPotenceNumEN.QxPrjId != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.QxPrjId, objvQxUserRolesByPotenceNumEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByPotenceNumEN.PrjName != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.PrjName, objvQxUserRolesByPotenceNumEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserRolesByPotenceNum.IsInUse, objvQxUserRolesByPotenceNumEN.IsInUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvQxUserRolesByPotenceNumEN.UpdDate != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.UpdDate, objvQxUserRolesByPotenceNumEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByPotenceNumEN.UpdUserId != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.UpdUserId, objvQxUserRolesByPotenceNumEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxUserRolesByPotenceNumEN.Memo != null)
{
writer.WriteElementString(convQxUserRolesByPotenceNum.Memo, objvQxUserRolesByPotenceNumEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxUserRolesByPotenceNum.PotenceNum, objvQxUserRolesByPotenceNumEN.PotenceNum.ToString());
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
public static clsvQxUserRolesByPotenceNumEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
reader.Read();
while (!(reader.Name == clsvQxUserRolesByPotenceNumBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxUserRolesByPotenceNum.RoleId))
{
objvQxUserRolesByPotenceNumEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.RoleName))
{
objvQxUserRolesByPotenceNumEN.RoleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.RoleENName))
{
objvQxUserRolesByPotenceNumEN.RoleENName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.RoleIndex))
{
objvQxUserRolesByPotenceNumEN.RoleIndex = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.QxPrjId))
{
objvQxUserRolesByPotenceNumEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.PrjName))
{
objvQxUserRolesByPotenceNumEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.IsInUse))
{
objvQxUserRolesByPotenceNumEN.IsInUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.UpdDate))
{
objvQxUserRolesByPotenceNumEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.UpdUserId))
{
objvQxUserRolesByPotenceNumEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.Memo))
{
objvQxUserRolesByPotenceNumEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxUserRolesByPotenceNum.PotenceNum))
{
objvQxUserRolesByPotenceNumEN.PotenceNum = reader.ReadElementContentAsInt();
}
}
return objvQxUserRolesByPotenceNumEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxUserRolesByPotenceNumObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxUserRolesByPotenceNumEN GetObjFromXmlStr(string strvQxUserRolesByPotenceNumObjXmlStr)
{
clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN = new clsvQxUserRolesByPotenceNumEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxUserRolesByPotenceNumObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxUserRolesByPotenceNumBL.itemXmlNode))
{
objvQxUserRolesByPotenceNumEN = GetObjFromXml(reader);
return objvQxUserRolesByPotenceNumEN;
}
}
return objvQxUserRolesByPotenceNumEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxUserRolesByPotenceNumEN);
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
if (strInFldName != convQxUserRolesByPotenceNum.RoleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxUserRolesByPotenceNum.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxUserRolesByPotenceNum.AttributeName));
throw new Exception(strMsg);
}
var objvQxUserRolesByPotenceNum = clsvQxUserRolesByPotenceNumBL.GetObjByRoleIdCache(strRoleId);
if (objvQxUserRolesByPotenceNum == null) return "";
return objvQxUserRolesByPotenceNum[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxUserRolesByPotenceNumEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxUserRolesByPotenceNumEN[strField]);
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
 /// <param name = "lstvQxUserRolesByPotenceNumObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxUserRolesByPotenceNumEN> lstvQxUserRolesByPotenceNumObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxUserRolesByPotenceNumObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumEN in lstvQxUserRolesByPotenceNumObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxUserRolesByPotenceNumEN);
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
int intRecCount = clsvQxUserRolesByPotenceNumDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxUserRolesByPotenceNumDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxUserRolesByPotenceNumDA.GetRecCount();
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
int intRecCount = clsvQxUserRolesByPotenceNumDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxUserRolesByPotenceNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxUserRolesByPotenceNumEN objvQxUserRolesByPotenceNumCond)
{
List<clsvQxUserRolesByPotenceNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxUserRolesByPotenceNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxUserRolesByPotenceNum.AttributeName)
{
if (objvQxUserRolesByPotenceNumCond.IsUpdated(strFldName) == false) continue;
if (objvQxUserRolesByPotenceNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByPotenceNumCond[strFldName].ToString());
}
else
{
if (objvQxUserRolesByPotenceNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxUserRolesByPotenceNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxUserRolesByPotenceNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxUserRolesByPotenceNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxUserRolesByPotenceNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByPotenceNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxUserRolesByPotenceNumCond[strFldName]));
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
 List<string> arrList = clsvQxUserRolesByPotenceNumDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRolesByPotenceNumDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxUserRolesByPotenceNumDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}