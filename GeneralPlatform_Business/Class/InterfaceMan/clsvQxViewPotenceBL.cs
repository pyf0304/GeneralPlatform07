
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewPotenceBL
 表名:vQxViewPotence(00140028)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:43:55
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
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
public static class  clsvQxViewPotenceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxViewPotenceEN GetObj(this K_mId_vQxViewPotence myKey)
{
clsvQxViewPotenceEN objvQxViewPotenceEN = clsvQxViewPotenceBL.vQxViewPotenceDA.GetObjBymId(myKey.Value);
return objvQxViewPotenceEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetmId(this clsvQxViewPotenceEN objvQxViewPotenceEN, long lngmId, string strComparisonOp="")
	{
objvQxViewPotenceEN.mId = lngmId; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.mId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.mId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.mId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetQxPrjId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strQxPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQxPrjId, convQxViewPotence.QxPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQxPrjId, 4, convQxViewPotence.QxPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQxPrjId, 4, convQxViewPotence.QxPrjId);
}
objvQxViewPotenceEN.QxPrjId = strQxPrjId; //项目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.QxPrjId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.QxPrjId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.QxPrjId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetPotenceId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strPotenceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceId, convQxViewPotence.PotenceId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceId, 8, convQxViewPotence.PotenceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPotenceId, 8, convQxViewPotence.PotenceId);
}
objvQxViewPotenceEN.PotenceId = strPotenceId; //权限ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.PotenceId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.PotenceId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.PotenceId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetPotenceName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strPotenceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPotenceName, convQxViewPotence.PotenceName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPotenceName, 200, convQxViewPotence.PotenceName);
}
objvQxViewPotenceEN.PotenceName = strPotenceName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.PotenceName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.PotenceName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.PotenceName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetPrjName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convQxViewPotence.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convQxViewPotence.PrjName);
}
objvQxViewPotenceEN.PrjName = strPrjName; //工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.PrjName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.PrjName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.PrjName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetViewId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convQxViewPotence.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convQxViewPotence.ViewId);
}
objvQxViewPotenceEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ViewId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ViewId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ViewId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetViewName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewName, convQxViewPotence.ViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewName, 100, convQxViewPotence.ViewName);
}
objvQxViewPotenceEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ViewName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ViewName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ViewName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetLevel(this clsvQxViewPotenceEN objvQxViewPotenceEN, int intLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intLevel, convQxViewPotence.Level);
objvQxViewPotenceEN.Level = intLevel; //等级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.Level) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.Level, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.Level] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetModuleId(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strModuleId, convQxViewPotence.ModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModuleId, 6, convQxViewPotence.ModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strModuleId, 6, convQxViewPotence.ModuleId);
}
objvQxViewPotenceEN.ModuleId = strModuleId; //模块号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ModuleId) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ModuleId, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ModuleId] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetModuleName(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strModuleName, convQxViewPotence.ModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModuleName, 100, convQxViewPotence.ModuleName);
}
objvQxViewPotenceEN.ModuleName = strModuleName; //模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.ModuleName) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.ModuleName, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.ModuleName] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxViewPotenceEN SetMemo(this clsvQxViewPotenceEN objvQxViewPotenceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxViewPotence.Memo);
}
objvQxViewPotenceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxViewPotenceEN.dicFldComparisonOp.ContainsKey(convQxViewPotence.Memo) == false)
{
objvQxViewPotenceEN.dicFldComparisonOp.Add(convQxViewPotence.Memo, strComparisonOp);
}
else
{
objvQxViewPotenceEN.dicFldComparisonOp[convQxViewPotence.Memo] = strComparisonOp;
}
}
return objvQxViewPotenceEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxViewPotenceENS">源对象</param>
 /// <param name = "objvQxViewPotenceENT">目标对象</param>
 public static void CopyTo(this clsvQxViewPotenceEN objvQxViewPotenceENS, clsvQxViewPotenceEN objvQxViewPotenceENT)
{
try
{
objvQxViewPotenceENT.mId = objvQxViewPotenceENS.mId; //流水号
objvQxViewPotenceENT.QxPrjId = objvQxViewPotenceENS.QxPrjId; //项目Id
objvQxViewPotenceENT.PotenceId = objvQxViewPotenceENS.PotenceId; //权限ID
objvQxViewPotenceENT.PotenceName = objvQxViewPotenceENS.PotenceName; //权限名称
objvQxViewPotenceENT.PrjName = objvQxViewPotenceENS.PrjName; //工程名
objvQxViewPotenceENT.ViewId = objvQxViewPotenceENS.ViewId; //界面编号
objvQxViewPotenceENT.ViewName = objvQxViewPotenceENS.ViewName; //界面名称
objvQxViewPotenceENT.Level = objvQxViewPotenceENS.Level; //等级
objvQxViewPotenceENT.ModuleId = objvQxViewPotenceENS.ModuleId; //模块号
objvQxViewPotenceENT.ModuleName = objvQxViewPotenceENS.ModuleName; //模块名称
objvQxViewPotenceENT.Memo = objvQxViewPotenceENS.Memo; //备注
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
 /// <param name = "objvQxViewPotenceENS">源对象</param>
 /// <returns>目标对象=>clsvQxViewPotenceEN:objvQxViewPotenceENT</returns>
 public static clsvQxViewPotenceEN CopyTo(this clsvQxViewPotenceEN objvQxViewPotenceENS)
{
try
{
 clsvQxViewPotenceEN objvQxViewPotenceENT = new clsvQxViewPotenceEN()
{
mId = objvQxViewPotenceENS.mId, //流水号
QxPrjId = objvQxViewPotenceENS.QxPrjId, //项目Id
PotenceId = objvQxViewPotenceENS.PotenceId, //权限ID
PotenceName = objvQxViewPotenceENS.PotenceName, //权限名称
PrjName = objvQxViewPotenceENS.PrjName, //工程名
ViewId = objvQxViewPotenceENS.ViewId, //界面编号
ViewName = objvQxViewPotenceENS.ViewName, //界面名称
Level = objvQxViewPotenceENS.Level, //等级
ModuleId = objvQxViewPotenceENS.ModuleId, //模块号
ModuleName = objvQxViewPotenceENS.ModuleName, //模块名称
Memo = objvQxViewPotenceENS.Memo, //备注
};
 return objvQxViewPotenceENT;
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
public static void CheckProperty4Condition(this clsvQxViewPotenceEN objvQxViewPotenceEN)
{
 clsvQxViewPotenceBL.vQxViewPotenceDA.CheckProperty4Condition(objvQxViewPotenceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxViewPotenceEN objvQxViewPotenceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.mId) == true)
{
string strComparisonOpmId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQxViewPotence.mId, objvQxViewPotenceCond.mId, strComparisonOpmId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.QxPrjId) == true)
{
string strComparisonOpQxPrjId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.QxPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.QxPrjId, objvQxViewPotenceCond.QxPrjId, strComparisonOpQxPrjId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.PotenceId) == true)
{
string strComparisonOpPotenceId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.PotenceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.PotenceId, objvQxViewPotenceCond.PotenceId, strComparisonOpPotenceId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.PotenceName) == true)
{
string strComparisonOpPotenceName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.PotenceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.PotenceName, objvQxViewPotenceCond.PotenceName, strComparisonOpPotenceName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.PrjName) == true)
{
string strComparisonOpPrjName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.PrjName, objvQxViewPotenceCond.PrjName, strComparisonOpPrjName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ViewId) == true)
{
string strComparisonOpViewId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ViewId, objvQxViewPotenceCond.ViewId, strComparisonOpViewId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ViewName) == true)
{
string strComparisonOpViewName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ViewName, objvQxViewPotenceCond.ViewName, strComparisonOpViewName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.Level) == true)
{
string strComparisonOpLevel = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.Level];
strWhereCond += string.Format(" And {0} {2} {1}", convQxViewPotence.Level, objvQxViewPotenceCond.Level, strComparisonOpLevel);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ModuleId) == true)
{
string strComparisonOpModuleId = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ModuleId, objvQxViewPotenceCond.ModuleId, strComparisonOpModuleId);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.ModuleName) == true)
{
string strComparisonOpModuleName = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.ModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.ModuleName, objvQxViewPotenceCond.ModuleName, strComparisonOpModuleName);
}
if (objvQxViewPotenceCond.IsUpdated(convQxViewPotence.Memo) == true)
{
string strComparisonOpMemo = objvQxViewPotenceCond.dicFldComparisonOp[convQxViewPotence.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxViewPotence.Memo, objvQxViewPotenceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxViewPotence
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v界面权限(vQxViewPotence)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxViewPotenceBL
{
public static RelatedActions_vQxViewPotence relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vQxViewPotenceListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vQxViewPotenceList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvQxViewPotenceEN> arrvQxViewPotenceObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxViewPotenceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxViewPotenceDA vQxViewPotenceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxViewPotenceDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxViewPotenceBL()
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
if (string.IsNullOrEmpty(clsvQxViewPotenceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxViewPotenceEN._ConnectString);
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
objDS = vQxViewPotenceDA.GetDataSet(strWhereCond);
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
objDS = vQxViewPotenceDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vQxViewPotenceDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vQxViewPotence(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxViewPotenceDA.GetDataTable_vQxViewPotence(strWhereCond);
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
objDT = vQxViewPotenceDA.GetDataTable(strWhereCond);
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
objDT = vQxViewPotenceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxViewPotenceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxViewPotenceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxViewPotenceDA.GetDataTable_Top(objTopPara);
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
objDT = vQxViewPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxViewPotenceDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vQxViewPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxViewPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vQxViewPotenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vQxViewPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vQxViewPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vQxViewPotenceDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
public static List<clsvQxViewPotenceEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
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
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxViewPotenceEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQxViewPotenceEN._CurrTabName);
List<clsvQxViewPotenceEN> arrvQxViewPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsvQxViewPotenceEN> arrvQxViewPotenceObjLst_Sel =
arrvQxViewPotenceObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQxViewPotenceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLst(string strWhereCond)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
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
public static List<clsvQxViewPotenceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxViewPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxViewPotenceEN> GetSubObjLstCache(clsvQxViewPotenceEN objvQxViewPotenceCond)
{
List<clsvQxViewPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxViewPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxViewPotence.AttributeName)
{
if (objvQxViewPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxViewPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxViewPotenceCond[strFldName].ToString());
}
else
{
if (objvQxViewPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxViewPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxViewPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxViewPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxViewPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxViewPotenceCond[strFldName]));
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
public static List<clsvQxViewPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
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
public static List<clsvQxViewPotenceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
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
List<clsvQxViewPotenceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxViewPotenceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxViewPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
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
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
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
public static List<clsvQxViewPotenceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxViewPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
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
public static List<clsvQxViewPotenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
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
public static IEnumerable<clsvQxViewPotenceEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvQxViewPotenceEN objvQxViewPotenceCond, string strOrderBy)
{
List<clsvQxViewPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxViewPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxViewPotence.AttributeName)
{
if (objvQxViewPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxViewPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxViewPotenceCond[strFldName].ToString());
}
else
{
if (objvQxViewPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxViewPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxViewPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxViewPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxViewPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxViewPotenceCond[strFldName]));
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
public static IEnumerable<clsvQxViewPotenceEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvQxViewPotenceEN objvQxViewPotenceCond = JsonConvert.DeserializeObject<clsvQxViewPotenceEN>(objPagerPara.whereCond);
if (objvQxViewPotenceCond.sfFldComparisonOp == null)
{
objvQxViewPotenceCond.dicFldComparisonOp = null;
}
else
{
objvQxViewPotenceCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvQxViewPotenceCond.sfFldComparisonOp);
}
clsvQxViewPotenceBL.SetUpdFlag(objvQxViewPotenceCond);
 try
{
CheckProperty4Condition(objvQxViewPotenceCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvQxViewPotenceBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvQxViewPotenceCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvQxViewPotenceEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
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
public static List<clsvQxViewPotenceEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxViewPotenceEN> arrObjLst = new List<clsvQxViewPotenceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
try
{
objvQxViewPotenceEN.mId = Int32.Parse(objRow[convQxViewPotence.mId].ToString().Trim()); //流水号
objvQxViewPotenceEN.QxPrjId = objRow[convQxViewPotence.QxPrjId].ToString().Trim(); //项目Id
objvQxViewPotenceEN.PotenceId = objRow[convQxViewPotence.PotenceId].ToString().Trim(); //权限ID
objvQxViewPotenceEN.PotenceName = objRow[convQxViewPotence.PotenceName].ToString().Trim(); //权限名称
objvQxViewPotenceEN.PrjName = objRow[convQxViewPotence.PrjName].ToString().Trim(); //工程名
objvQxViewPotenceEN.ViewId = objRow[convQxViewPotence.ViewId] == DBNull.Value ? null : objRow[convQxViewPotence.ViewId].ToString().Trim(); //界面编号
objvQxViewPotenceEN.ViewName = objRow[convQxViewPotence.ViewName].ToString().Trim(); //界面名称
objvQxViewPotenceEN.Level = Int32.Parse(objRow[convQxViewPotence.Level].ToString().Trim()); //等级
objvQxViewPotenceEN.ModuleId = objRow[convQxViewPotence.ModuleId].ToString().Trim(); //模块号
objvQxViewPotenceEN.ModuleName = objRow[convQxViewPotence.ModuleName].ToString().Trim(); //模块名称
objvQxViewPotenceEN.Memo = objRow[convQxViewPotence.Memo] == DBNull.Value ? null : objRow[convQxViewPotence.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxViewPotenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxViewPotenceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxViewPotence(ref clsvQxViewPotenceEN objvQxViewPotenceEN)
{
bool bolResult = vQxViewPotenceDA.GetvQxViewPotence(ref objvQxViewPotenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxViewPotenceEN GetObjBymId(long lngmId)
{
clsvQxViewPotenceEN objvQxViewPotenceEN = vQxViewPotenceDA.GetObjBymId(lngmId);
return objvQxViewPotenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxViewPotenceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxViewPotenceEN objvQxViewPotenceEN = vQxViewPotenceDA.GetFirstObj(strWhereCond);
 return objvQxViewPotenceEN;
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
public static clsvQxViewPotenceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxViewPotenceEN objvQxViewPotenceEN = vQxViewPotenceDA.GetObjByDataRow(objRow);
 return objvQxViewPotenceEN;
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
public static clsvQxViewPotenceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxViewPotenceEN objvQxViewPotenceEN = vQxViewPotenceDA.GetObjByDataRow(objRow);
 return objvQxViewPotenceEN;
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
 /// <param name = "lstvQxViewPotenceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxViewPotenceEN GetObjBymIdFromList(long lngmId, List<clsvQxViewPotenceEN> lstvQxViewPotenceObjLst)
{
foreach (clsvQxViewPotenceEN objvQxViewPotenceEN in lstvQxViewPotenceObjLst)
{
if (objvQxViewPotenceEN.mId == lngmId)
{
return objvQxViewPotenceEN;
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
 lngmId = new clsvQxViewPotenceDA().GetFirstID(strWhereCond);
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
 arrList = vQxViewPotenceDA.GetID(strWhereCond);
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
bool bolIsExist = vQxViewPotenceDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQxViewPotenceDA.IsExist(lngmId);
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
 bolIsExist = clsvQxViewPotenceDA.IsExistTable();
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
 bolIsExist = vQxViewPotenceDA.IsExistTable(strTabName);
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
 /// <param name = "objvQxViewPotenceENS">源对象</param>
 /// <param name = "objvQxViewPotenceENT">目标对象</param>
 public static void CopyTo(clsvQxViewPotenceEN objvQxViewPotenceENS, clsvQxViewPotenceEN objvQxViewPotenceENT)
{
try
{
objvQxViewPotenceENT.mId = objvQxViewPotenceENS.mId; //流水号
objvQxViewPotenceENT.QxPrjId = objvQxViewPotenceENS.QxPrjId; //项目Id
objvQxViewPotenceENT.PotenceId = objvQxViewPotenceENS.PotenceId; //权限ID
objvQxViewPotenceENT.PotenceName = objvQxViewPotenceENS.PotenceName; //权限名称
objvQxViewPotenceENT.PrjName = objvQxViewPotenceENS.PrjName; //工程名
objvQxViewPotenceENT.ViewId = objvQxViewPotenceENS.ViewId; //界面编号
objvQxViewPotenceENT.ViewName = objvQxViewPotenceENS.ViewName; //界面名称
objvQxViewPotenceENT.Level = objvQxViewPotenceENS.Level; //等级
objvQxViewPotenceENT.ModuleId = objvQxViewPotenceENS.ModuleId; //模块号
objvQxViewPotenceENT.ModuleName = objvQxViewPotenceENS.ModuleName; //模块名称
objvQxViewPotenceENT.Memo = objvQxViewPotenceENS.Memo; //备注
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
 /// <param name = "objvQxViewPotenceEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxViewPotenceEN objvQxViewPotenceEN)
{
try
{
objvQxViewPotenceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxViewPotenceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxViewPotence.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.mId = objvQxViewPotenceEN.mId; //流水号
}
if (arrFldSet.Contains(convQxViewPotence.QxPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.QxPrjId = objvQxViewPotenceEN.QxPrjId; //项目Id
}
if (arrFldSet.Contains(convQxViewPotence.PotenceId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.PotenceId = objvQxViewPotenceEN.PotenceId; //权限ID
}
if (arrFldSet.Contains(convQxViewPotence.PotenceName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.PotenceName = objvQxViewPotenceEN.PotenceName; //权限名称
}
if (arrFldSet.Contains(convQxViewPotence.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.PrjName = objvQxViewPotenceEN.PrjName; //工程名
}
if (arrFldSet.Contains(convQxViewPotence.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.ViewId = objvQxViewPotenceEN.ViewId == "[null]" ? null :  objvQxViewPotenceEN.ViewId; //界面编号
}
if (arrFldSet.Contains(convQxViewPotence.ViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.ViewName = objvQxViewPotenceEN.ViewName; //界面名称
}
if (arrFldSet.Contains(convQxViewPotence.Level, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.Level = objvQxViewPotenceEN.Level; //等级
}
if (arrFldSet.Contains(convQxViewPotence.ModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.ModuleId = objvQxViewPotenceEN.ModuleId; //模块号
}
if (arrFldSet.Contains(convQxViewPotence.ModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.ModuleName = objvQxViewPotenceEN.ModuleName; //模块名称
}
if (arrFldSet.Contains(convQxViewPotence.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxViewPotenceEN.Memo = objvQxViewPotenceEN.Memo == "[null]" ? null :  objvQxViewPotenceEN.Memo; //备注
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
 /// <param name = "objvQxViewPotenceEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxViewPotenceEN objvQxViewPotenceEN)
{
try
{
if (objvQxViewPotenceEN.ViewId == "[null]") objvQxViewPotenceEN.ViewId = null; //界面编号
if (objvQxViewPotenceEN.Memo == "[null]") objvQxViewPotenceEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxViewPotenceEN objvQxViewPotenceEN)
{
 vQxViewPotenceDA.CheckProperty4Condition(objvQxViewPotenceEN);
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
if (clsQxPrjPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjPotenceBL没有刷新缓存机制(clsQxPrjPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxViewPotenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxViewPotenceBL没有刷新缓存机制(clsQxViewPotenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxProjectsBL没有刷新缓存机制(clsQxProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxViewInfoBL没有刷新缓存机制(clsQxViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxPrjModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxPrjModuleBL没有刷新缓存机制(clsQxPrjModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQxViewPotenceObjLstCache == null)
//{
//arrvQxViewPotenceObjLstCache = vQxViewPotenceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxViewPotenceEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxViewPotenceEN._CurrTabName);
List<clsvQxViewPotenceEN> arrvQxViewPotenceObjLstCache = GetObjLstCache();
IEnumerable <clsvQxViewPotenceEN> arrvQxViewPotenceObjLst_Sel =
arrvQxViewPotenceObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQxViewPotenceObjLst_Sel.Count() == 0)
{
   clsvQxViewPotenceEN obj = clsvQxViewPotenceBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxViewPotenceObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxViewPotenceEN> GetAllvQxViewPotenceObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxViewPotenceEN> arrvQxViewPotenceObjLstCache = GetObjLstCache(); 
return arrvQxViewPotenceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxViewPotenceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxViewPotenceEN._CurrTabName);
List<clsvQxViewPotenceEN> arrvQxViewPotenceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxViewPotenceObjLstCache;
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
string strKey = string.Format("{0}", clsvQxViewPotenceEN._CurrTabName);
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
 /// <param name = "lstvQxViewPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvQxViewPotenceEN> lstvQxViewPotenceObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvQxViewPotenceObjLst, writer);
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
 /// <param name = "lstvQxViewPotenceObjLst">[clsvQxViewPotenceEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvQxViewPotenceEN> lstvQxViewPotenceObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvQxViewPotenceBL.listXmlNode);
writer.WriteStartElement(clsvQxViewPotenceBL.itemsXmlNode);
foreach (clsvQxViewPotenceEN objvQxViewPotenceEN in lstvQxViewPotenceObjLst)
{
clsvQxViewPotenceBL.SerializeXML(writer, objvQxViewPotenceEN);
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
 /// <param name = "objvQxViewPotenceEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvQxViewPotenceEN objvQxViewPotenceEN)
{
writer.WriteStartElement(clsvQxViewPotenceBL.itemXmlNode);
 
writer.WriteElementString(convQxViewPotence.mId, objvQxViewPotenceEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvQxViewPotenceEN.QxPrjId != null)
{
writer.WriteElementString(convQxViewPotence.QxPrjId, objvQxViewPotenceEN.QxPrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxViewPotenceEN.PotenceId != null)
{
writer.WriteElementString(convQxViewPotence.PotenceId, objvQxViewPotenceEN.PotenceId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxViewPotenceEN.PotenceName != null)
{
writer.WriteElementString(convQxViewPotence.PotenceName, objvQxViewPotenceEN.PotenceName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxViewPotenceEN.PrjName != null)
{
writer.WriteElementString(convQxViewPotence.PrjName, objvQxViewPotenceEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxViewPotenceEN.ViewId != null)
{
writer.WriteElementString(convQxViewPotence.ViewId, objvQxViewPotenceEN.ViewId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxViewPotenceEN.ViewName != null)
{
writer.WriteElementString(convQxViewPotence.ViewName, objvQxViewPotenceEN.ViewName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convQxViewPotence.Level, objvQxViewPotenceEN.Level.ToString(CultureInfo.InvariantCulture));
 
if (objvQxViewPotenceEN.ModuleId != null)
{
writer.WriteElementString(convQxViewPotence.ModuleId, objvQxViewPotenceEN.ModuleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxViewPotenceEN.ModuleName != null)
{
writer.WriteElementString(convQxViewPotence.ModuleName, objvQxViewPotenceEN.ModuleName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvQxViewPotenceEN.Memo != null)
{
writer.WriteElementString(convQxViewPotence.Memo, objvQxViewPotenceEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clsvQxViewPotenceEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
reader.Read();
while (!(reader.Name == clsvQxViewPotenceBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convQxViewPotence.mId))
{
objvQxViewPotenceEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convQxViewPotence.QxPrjId))
{
objvQxViewPotenceEN.QxPrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.PotenceId))
{
objvQxViewPotenceEN.PotenceId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.PotenceName))
{
objvQxViewPotenceEN.PotenceName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.PrjName))
{
objvQxViewPotenceEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.ViewId))
{
objvQxViewPotenceEN.ViewId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.ViewName))
{
objvQxViewPotenceEN.ViewName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.Level))
{
objvQxViewPotenceEN.Level = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convQxViewPotence.ModuleId))
{
objvQxViewPotenceEN.ModuleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.ModuleName))
{
objvQxViewPotenceEN.ModuleName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convQxViewPotence.Memo))
{
objvQxViewPotenceEN.Memo = reader.ReadElementContentAsString();
}
}
return objvQxViewPotenceEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvQxViewPotenceObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvQxViewPotenceEN GetObjFromXmlStr(string strvQxViewPotenceObjXmlStr)
{
clsvQxViewPotenceEN objvQxViewPotenceEN = new clsvQxViewPotenceEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvQxViewPotenceObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvQxViewPotenceBL.itemXmlNode))
{
objvQxViewPotenceEN = GetObjFromXml(reader);
return objvQxViewPotenceEN;
}
}
return objvQxViewPotenceEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvQxViewPotenceEN objvQxViewPotenceEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvQxViewPotenceEN);
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
if (strInFldName != convQxViewPotence.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxViewPotence.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxViewPotence.AttributeName));
throw new Exception(strMsg);
}
var objvQxViewPotence = clsvQxViewPotenceBL.GetObjBymIdCache(lngmId);
if (objvQxViewPotence == null) return "";
return objvQxViewPotence[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-08-22
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvQxViewPotenceEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvQxViewPotenceEN objvQxViewPotenceEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvQxViewPotenceEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvQxViewPotenceEN[strField]);
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
 /// <param name = "lstvQxViewPotenceObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvQxViewPotenceEN> lstvQxViewPotenceObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvQxViewPotenceObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvQxViewPotenceEN objvQxViewPotenceEN in lstvQxViewPotenceObjLst)
{
string strJSON_One = SerializeObjToJSON(objvQxViewPotenceEN);
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
int intRecCount = clsvQxViewPotenceDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxViewPotenceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxViewPotenceDA.GetRecCount();
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
int intRecCount = clsvQxViewPotenceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxViewPotenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxViewPotenceEN objvQxViewPotenceCond)
{
List<clsvQxViewPotenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxViewPotenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxViewPotence.AttributeName)
{
if (objvQxViewPotenceCond.IsUpdated(strFldName) == false) continue;
if (objvQxViewPotenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxViewPotenceCond[strFldName].ToString());
}
else
{
if (objvQxViewPotenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxViewPotenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxViewPotenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxViewPotenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxViewPotenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxViewPotenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxViewPotenceCond[strFldName]));
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
 List<string> arrList = clsvQxViewPotenceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxViewPotenceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxViewPotenceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}